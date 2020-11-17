using System;
using System.Diagnostics;

namespace GUITestSupport
{
    /// <summary>
    /// IISの実行クラスです。
    /// </summary>
    public class IISRunner : IDisposable
    {
        /// <summary>
        /// シングルトンのインスタンスです。
        /// </summary>
        private static IISRunner instance;

        /// <summary>
        /// プロセスです。
        /// </summary>
        private readonly Process process = new Process();

        /// <summary>
        /// <see cref="IISRunner"/>のインスタンスを初期化します。
        /// </summary>
        private IISRunner()
        {
        }

        /// <summary>
        /// WebAppへのパスです。
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// ポート番号です。
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// シングルトンのインスタンスを取得します。
        /// </summary>
        /// <returns>インスタンスです。</returns>
        public static IISRunner GetInstance()
        {
            return instance ?? (instance = new IISRunner());
        }

        /// <summary>
        /// 破棄処理です。
        /// </summary>
        public void Dispose()
        {
            if (this.process == null)
            {
                return;
            }

            this.process.Kill();
            using (this.process)
            {
            }
        }

        /// <summary>
        /// IISを実行します。
        /// </summary>
        public void Run()
        {
            this.process.StartInfo.FileName = @"C:\Program Files (x86)\IIS Express\iisexpress.exe";
            this.process.StartInfo.Arguments = $"/path:{Path} /port:{Port}";
            this.process.Start();
        }
    }
}

using GUITestSupport;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace WebApplicationMVCSample.CT
{
    [TestClass]
    public class TestInitializer
    {
        /// <summary>
        /// テストの初期化を行います。
        /// </summary>
        /// <param name="context">テストコンテキストです。</param>
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            var screensshotPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshot");
            if (Directory.Exists(screensshotPath))
            {
                Directory.Delete(screensshotPath, true);
            }

            var runner = IISRunner.GetInstance();
            runner.Path = Path.Combine(new SolutionFilePathGetter().GetPath(), "WebApplicationMVCSample");
            runner.Port = "8888";
            runner.Run();
        }

        /// <summary>
        /// テストのクリーンアップを行います。
        /// </summary>
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            IISRunner.GetInstance().Dispose();
        }
    }
}

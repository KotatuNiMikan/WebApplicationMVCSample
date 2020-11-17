using GUITestSupport;
using GUITestSupport.WebDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.IO;
using WebApplicationMVCSample.CT.PageObjects;

namespace WebApplicationMVCSample.CT.TestCase
{
    /// <summary>
    /// 四則演算画面のテストクラスです。
    /// </summary>
    [TestClass]
    public class 四則演算画面Test
    {
        /// <summary>
        /// 初期表示をテストします。
        /// </summary>
        [TestMethod]
        public void 初期表示Test()
        {
            using (var webDriver = WebDriverFactory.Create(WebDriverType.Chrome))
            {
                var page = GetTargetPage(webDriver);
                var outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Screenshot", page.GetType().Name);
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                page.SaveScreenshot(Path.Combine(outputDirectory, "初期化.png"));
                Assert.IsTrue(page.ContainsUrl("Calculation"), page.GetUrl());
            }
        }

        /// <summary>
        /// <see cref="四則演算画面.計算ボタン押下_検証失敗"/>をテストします。
        /// </summary>
        /// <param name="left">左辺です。</param>
        /// <param name="operatorType">演算子です。</param>
        /// <param name="right">右辺です。</param>
        [TestMethod]
        [DataRow("1", "+", "")]
        [DataRow("", "+", "1")]
        public void 計算ボタン押下_検証失敗Test(string left, string operatorType, string right)
        {
            using (var webDriver = WebDriverFactory.Create(WebDriverType.Chrome))
            {
                var page = GetTargetPage(webDriver);
                var outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Screenshot", page.GetType().Name);
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                var result = page.計算ボタン押下_検証失敗(left, operatorType, right);
                result.SaveScreenshot(Path.Combine(outputDirectory, $"計算ボタン押下_検証失敗_{left}_{operatorType.Replace('/', '／')}_{right}.png"));
                Assert.IsTrue(result.ContainsUrl("Calculation"), page.GetUrl());
            }
        }

        /// <summary>
        /// <see cref="四則演算画面.計算ボタン押下_検証成功"/>をテストします。
        /// </summary>
        /// <param name="left">左辺です。</param>
        /// <param name="operatorType">演算子です。</param>
        /// <param name="right">右辺です。</param>
        [TestMethod]
        [DataRow("1", "+", "1")]
        [DataRow("1", "-", "1")]
        [DataRow("1", "×", "1")]
        [DataRow("1", "/", "1")]
        public void 計算ボタン押下_検証成功Test(string left, string operatorType, string right)
        {
            using (var webDriver = WebDriverFactory.Create(WebDriverType.Chrome))
            {
                var page = GetTargetPage(webDriver);
                var outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Screenshot", page.GetType().Name);
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                var result = page.計算ボタン押下_検証成功(left, operatorType, right);
                result.SaveScreenshot(Path.Combine(outputDirectory, $"計算ボタン押下_検証成功_{left}_{operatorType.Replace('/', '／')}_{right}.png"));
                Assert.IsTrue(result.ContainsUrl("Calculation/Calculate"), page.GetUrl());
            }
        }

        /// <summary>
        /// テスト対象のページオブジェクトを取得します。
        /// </summary>
        /// <param name="webDriver">ウェブドライバーです。</param>
        /// <returns><see cref="四則演算画面"/>です。</returns>
        private static 四則演算画面 GetTargetPage(IWebDriver webDriver)
        {
            webDriver.Url = $"http://localhost:{IISRunner.GetInstance().Port}";
            return new ホーム画面(webDriver).四則演算リンククリック();
        }
    }
}

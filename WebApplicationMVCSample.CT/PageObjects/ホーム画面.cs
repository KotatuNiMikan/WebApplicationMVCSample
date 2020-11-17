using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebApplicationMVCSample.CT.PageObjects
{
    /// <summary>
    /// ホーム画面のページオブジェクトです。
    /// </summary>
    public class ホーム画面 : BasePageObject
    {
        /// <summary>
        /// 四則演算リンクです。
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[.='四則演算']")]
        private IWebElement 四則演算リンク;

        /// <summary>
        /// インスタンスを初期化します。
        /// </summary>
        /// <param name="webDriver">ウェブドライバーです。</param>
        public ホーム画面(IWebDriver webDriver) : base(webDriver)
        {
        }

        /// <summary>
        /// 四則演算リンククリック処理です。
        /// </summary>
        /// <returns><see cref="四則演算画面"/>です。</returns>
        public 四則演算画面 四則演算リンククリック()
        {
            this.四則演算リンク.Click();
            return new 四則演算画面(WebDriver);
        }
    }
}

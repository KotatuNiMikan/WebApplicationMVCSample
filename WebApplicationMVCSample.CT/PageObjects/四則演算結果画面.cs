using OpenQA.Selenium;

namespace WebApplicationMVCSample.CT.PageObjects
{
    /// <summary>
    /// 四則演算結果画面のページオブジェクトです。
    /// </summary>
    public class 四則演算結果画面 : BasePageObject
    {
        /// <summary>
        /// インスタンスを初期化します。
        /// </summary>
        /// <param name="webDriver">ウェブドライバーです。</param>
        public 四則演算結果画面(IWebDriver webDriver) : base(webDriver)
        {
        }
    }
}

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebApplicationMVCSample.CT.PageObjects
{
    /// <summary>
    /// 四則演算画面ページオブジェクトです。
    /// </summary>
    public class 四則演算画面 : BasePageObject
    {
        /// <summary>
        /// 左辺のテキストインプットです。
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Left']")]
        private IWebElement 左辺;

        /// <summary>
        /// 演算子コンボボックスです。
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//select[@id='OperatorType']")]
        private IWebElement 演算子;

        /// <summary>
        /// 右辺のテキストインプットです。
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Right']")]
        private IWebElement 右辺;

        /// <summary>
        /// 計算ボタンです。
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//button[.='計算']")]
        private IWebElement 計算ボタン;

        /// <summary>
        /// インスタンスを初期化します。
        /// </summary>
        /// <param name="webDriver">ウェブドライバーです。</param>
        public 四則演算画面(IWebDriver webDriver) : base(webDriver)
        {
        }

        /// <summary>
        /// 計算ボタン押下_検証失敗の動作です。
        /// </summary>
        /// <param name="left">左辺です。</param>
        /// <param name="operatorType">演算子です。</param>
        /// <param name="right">右辺です。</param>
        /// <returns><see cref="四則演算画面"/>です。</returns>
        public 四則演算画面 計算ボタン押下_検証失敗(string left, string operatorType, string right)
        {
            this.右辺.SendKeys(right);
            new SelectElement(this.演算子).SelectByText(operatorType);
            this.左辺.SendKeys(left);
            this.計算ボタン.Click();
            return new 四則演算画面(this.WebDriver);
        }

        /// <summary>
        /// 計算ボタン押下_検証成功の動作です。
        /// </summary>
        /// <param name="left">左辺です。</param>
        /// <param name="operatorType">演算子です。</param>
        /// <param name="right">右辺です。</param>
        /// <returns><see cref="四則演算結果画面"/>です。</returns>
        public 四則演算結果画面 計算ボタン押下_検証成功(string left, string operatorType, string right)
        {
            this.右辺.SendKeys(right);
            new SelectElement(this.演算子).SelectByText(operatorType);
            this.左辺.SendKeys(left);
            this.計算ボタン.Click();
            return new 四則演算結果画面(this.WebDriver);
        }
    }
}

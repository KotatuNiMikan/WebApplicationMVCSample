using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebApplicationMVCSample.CT.PageObjects
{
    /// <summary>
    /// ページオブジェクトの基底クラスです。
    /// </summary>
    public abstract class BasePageObject 
    {
        /// <summary>
        /// インスタンスを初期化します。
        /// </summary>
        /// <param name="webDriver">ウェブドライバーです。</param>
        public BasePageObject(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        /// <summary>
        /// ウェブドライバーです。
        /// </summary>
        protected IWebDriver WebDriver { get; }
        
        /// <summary>
        /// スクリーンショットを保存します。
        /// </summary>
        /// <param name="filePath">保存するファイルパスです。</param>
        public void SaveScreenshot(string filePath)
        {
            ((ITakesScreenshot)this.WebDriver)
                .GetScreenshot()
                .SaveAsFile(filePath, ScreenshotImageFormat.Png);
        }

        /// <summary>
        /// URLに特定の文字列が含まれるか判定します。
        /// </summary>
        /// <param name="target">文字列です。</param>
        /// <returns>判定結果です。文字列が含まれていればTrueを返します。</returns>
        public bool ContainsUrl(string target)
        {
            return this.WebDriver.Url.Contains(target);
        }

        /// <summary>
        /// URLを取得します。
        /// </summary>
        /// <returns>URLです。</returns>
        public string GetUrl()
        {
            return this.WebDriver.Url;
        }
    }
}

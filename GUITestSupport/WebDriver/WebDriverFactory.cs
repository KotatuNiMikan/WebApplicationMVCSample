using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace GUITestSupport.WebDriver
{
    public class WebDriverFactory
    {
        public static IWebDriver Create(WebDriverType type)
        {
            if (type == WebDriverType.Chrome)
            {
                return new ChromeDriver();
            }

            throw new Exception();
        }
    }
}

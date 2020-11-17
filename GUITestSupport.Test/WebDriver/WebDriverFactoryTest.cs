using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUITestSupport.WebDriver
{
    [TestClass]
    public class WebDriverFactoryTest
    {
        [TestMethod]
        [DataRow(WebDriverType.Chrome,typeof(ChromeDriver))]
        public void Test(WebDriverType type,Type expected)
        {
            using (var actual = WebDriverFactory.Create(type))
            {
                Assert.IsInstanceOfType(actual, expected);
            }            
        }
    }
}

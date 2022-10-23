using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace ClassLibrary1
{
    class WebBrowserTestChrome
    {
        private static IWebDriver chromeDriver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            chromeDriver.Quit();
        }

        [Test]
        public static void WebBrowserTestBox()
        {
            IWebElement browserVersionText = chromeDriver.FindElement(By.CssSelector(".simple-major"));
            Assert.IsTrue("Chrome 106 on Windows 10".Equals(browserVersionText.Text),
                "Button value is not correct");
        }
    }
}

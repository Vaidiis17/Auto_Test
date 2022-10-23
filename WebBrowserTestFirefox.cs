using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace ClassLibrary1
{
    class WebBrowserTestFirefox
    {
        private static IWebDriver firefoxDriver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            firefoxDriver = new FirefoxDriver();
            firefoxDriver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            firefoxDriver.Manage().Window.Maximize();
            firefoxDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            firefoxDriver.Quit();
        }

        [Test]
        public static void WebBrowserTestBox()
        {
            IWebElement browserVersionText = firefoxDriver.FindElement(By.CssSelector(".simple-major"));
            Assert.IsTrue("Firefox 106 on Windows 10".Equals(browserVersionText.Text),
                "Button value is not correct");
        }
    }
}

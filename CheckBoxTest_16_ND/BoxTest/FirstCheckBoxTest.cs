using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ClassLibrary1.CheckBoxTest
{
    public class FirstCheckBoxTest
    {

        private static IWebDriver chromeDriver;
        private IWebDriver chromeDriver1;

        public FirstCheckBoxTest(IWebDriver chromeDriver1)
        {
            this.chromeDriver1 = chromeDriver1;
        }

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            chromeDriver.Quit();
        }

        [Test]

        public static void TestCheckBoxClicked()
        {
            FirstCheckBoxTest box = new FirstCheckBoxTest(chromeDriver);

            box.NavigateToPage();
            box.CheckOneBox();
            box.CheckResult();
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Page
{
    public class FirstSeleniumInputTest
    {
        private static IWebDriver chromeDriver;


        [OneTimeSetUp]
        public static void OneTimeSetup()
        {

            chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            chromeDriver.Quit();
        }




    }
}

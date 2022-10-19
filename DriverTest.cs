using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ClassLibrary1
{
    class DriverTest
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


        [TestCase("2", "2", "4", TestName = "Testas 2 plus 2")]
        [TestCase("-5", "3", "-2", TestName = "Testas -5 plus 3")]
        [TestCase("a", "b", "NaN", TestName = "Testas a plus b")]

        public static void TwoInputFields(string firstInputValue, string secondInputValue, string resultValue)
        {
            

            IWebElement number1 = chromeDriver.FindElement(By.Id("sum1"));
            number1.Clear();
            number1.SendKeys(firstInputValue);

            IWebElement number2 = chromeDriver.FindElement(By.Id("sum2"));
            number2.Clear();
            number2.SendKeys(secondInputValue);

            IWebElement button = chromeDriver.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            IWebElement resultElement = chromeDriver.FindElement(By.Id("displayvalue"));
            Assert.IsTrue(resultValue.Equals(resultElement.Text), "Text is not the same");
            
        }

    }
}

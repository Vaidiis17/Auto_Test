using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class CheckBoxDemo
    {
        private static IWebDriver chromeDriver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {

            chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
            chromeDriver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            chromeDriver.Quit();
        }

        [Test]
        public static void CheckboxTest()
        {
            IWebElement oneCheckBox = chromeDriver.FindElement(By.Id("isAgeSelected"));

            if (!oneCheckBox.Selected)
            {
                oneCheckBox.Click();
            }


            IWebElement resultElement = chromeDriver.FindElement(By.Id("txtAge"));
            Assert.AreEqual("Success - Check box is checked", resultElement.Text, "Result is wrong");


        }

        [Test]
        public static void CheckboxesTest()
        {
            IReadOnlyCollection<IWebElement> checkboxesCollection
                = chromeDriver.FindElements(By.CssSelector(".cb1-element"));

            foreach (IWebElement checkbox in checkboxesCollection)
            {
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
            }

            //IWebElement button = chromeDriver.FindElement(By.Id("check1"));
            IWebElement button = chromeDriver.FindElement(By.CssSelector("#check1"));
            Assert.IsTrue("Uncheck All".Equals(button.GetAttribute("value")),
                "Button value is not correct");

        }

        //Paspaudžiame mygtuką “Uncheck All” , patikriname kad visos “Multiple Checkbox Demo”
        //sekcijos varneles atžymėtos, patikriname kad mygtukas persivadino į “Check All”

        [Test]
        public static void UnchekAllTest()
        {
            
            IReadOnlyCollection<IWebElement> checkboxesCollection
                = chromeDriver.FindElements(By.CssSelector(".cb1-element"));

            foreach (IWebElement checkbox in checkboxesCollection)
            {
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
            }

            IWebElement button1 = chromeDriver.FindElement(By.CssSelector("#check1"));
            button1.Click();

            IWebElement button2 = chromeDriver.FindElement(By.CssSelector("#check1"));
            Assert.IsTrue("Check All".Equals(button2.GetAttribute("value")),
                "Button value is not correct");


        }
    }
}

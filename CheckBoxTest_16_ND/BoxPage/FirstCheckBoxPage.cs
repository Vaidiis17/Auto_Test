using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using ClassLibrary1.BoxPage;

namespace ClassLibrary1.CheckBoxPage
{
    public class FirstCheckBoxPage : BasePage

    {
        private string pageAddress = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
        private IWebElement oneCheckBox => Driver.FindElement(By.Id("isAgeSelected"));

        private IWebElement resultElement => Driver.FindElement(By.Id("txtAge"));

        public FirstCheckBoxPage(IWebDriver webdriver) : base(webdriver){}

        public void NavigateToPage() 
        {
            Driver.Url = pageAddress;
        }

        public void CheckOneBox()
        {
            if (!oneCheckBox.Selected)
            {
                oneCheckBox.Click();
            }
        }

        public void CheckResult()
        {
            Assert.AreEqual("Success - Check box is checked", resultElement.Text, "Result text is wrong");
        }

    }
}

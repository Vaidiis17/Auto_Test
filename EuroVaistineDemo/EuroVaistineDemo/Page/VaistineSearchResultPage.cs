﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace draft.Page
{
    public class VaistineSearchResultPage : BasePage
    {
        private const string orderByHighestPriceText = "Brangiausios viršuje";
        private IWebElement addToCardButton => Driver.FindElement(By.CssSelector(".btn.btn-green"));
        IReadOnlyCollection<IWebElement> results => Driver.FindElements(By.CssSelector("cart-block"));
        private SelectElement orderByDropdown => new SelectElement(Driver.FindElement(By.Id("products-orderby")));

        public VaistineSearchResultPage(IWebDriver webdriver) : base(webdriver) { }
        public void OrderByHighestPrice()
        {
            GetWait().Until(driver => driver.FindElement(By.CssSelector(".form-control")).Displayed);
            orderByDropdown.SelectByText(orderByHighestPriceText);
        }

        public void VerifyPrice(string price)
        {
            IWebElement firstResultElement = results.ElementAt(0);
            string firstResultElementPrice = firstResultElement.FindElement(By.CssSelector(".price.actual-price")).Text;
            Assert.AreEqual(price, firstResultElementPrice, "Price is wrong");
        }

        public void AddToCard()
        {
            IWebElement firstResultElement = results.ElementAt(0);
            Actions action = new Actions(Driver);
            IWebElement imageElement = firstResultElement.FindElement(By.CssSelector(".product-card"));
            action.MoveToElement(imageElement);
            action.Build().Perform();
            firstResultElement.FindElement(By.CssSelector(".btn btn-green")).Click();
            addToCardButton.Click();
        }
    }
}

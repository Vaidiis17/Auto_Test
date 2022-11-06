using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace draft.Page
{
    public class CartPage : BasePage
    {
        private IWebElement TotalPriceElement => Driver.FindElement(By.CssSelector(".row.cart-total > .col-md-3.col-sm-4.col-4"));
        public CartPage(IWebDriver webdriver) : base(webdriver) { }

        public void InsertQuantity(int quantity)
        {
            IWebElement quantityField = Driver.FindElement(By.Id("cart_items_0_quantity > product-quantity"));
            Actions action = new Actions(Driver);
            action.DoubleClick(quantityField);
            action.Build().Perform();
            quantityField.SendKeys(quantity.ToString());
            action.KeyDown(Keys.Enter);
            action.KeyUp(Keys.Enter);
            action.Build().Perform();
        }

        public void VerifyIfICanBuy(int moneyToSpent)
        {
            GetWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("")));
            double totalPrice = double.Parse(TotalPriceElement.Text.Replace("€", ""));
            Assert.IsTrue(moneyToSpent > totalPrice, $"Cannot by 5 mollers with 100€, total price is {totalPrice}");
        }
    }
}

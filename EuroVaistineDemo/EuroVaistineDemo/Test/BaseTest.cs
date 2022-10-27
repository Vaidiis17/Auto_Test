using draft.Drivers;
using draft.Page;
//using EuroVaistineDemo.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace draft.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static VaistineSearchResultPage _vaistineSearchResultPage;
        public static VaistineHomePage _vaistineHomePage;
        public static CartPage _cartPage;
        //public static AlertPage _alertPage;


        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            _vaistineSearchResultPage = new VaistineSearchResultPage(driver);
            _vaistineHomePage = new VaistineHomePage(driver);
           // _alertPage = new AlertPage(driver);
            _cartPage = new CartPage(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }
    }
}

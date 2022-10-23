using OpenQA.Selenium;

namespace ClassLibrary1.BoxPage
{
    public class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }

    }
}

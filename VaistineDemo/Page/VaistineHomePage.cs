using OpenQA.Selenium;

namespace draft.Page
{
    public class VaistineHomePage : BasePage
    {
        private const string PageAddress = "https://www.eurovaistine.lt/";

        private IWebElement popUpClose => Driver.FindElement(By.CssSelector(".PopupCloseButton__InnerPopupCloseButton-sc-957qyh-0.cMdPwy.wisepops-close"));
        private IWebElement spanClose => Driver.FindElement(By.CssSelector(".evBtn.evBtnLink"));
        private IWebElement cookieButton => Driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        private IWebElement searchField => Driver.FindElement(By.CssSelector(".sn-suggest-input.headerSearchInput.tt-input"));
        private IWebElement searchIcon => Driver.FindElement(By.CssSelector(".svg-inline--fa.fa-search.fa-w-16"));
       
        public VaistineHomePage(IWebDriver webdriver) : base(webdriver) { }
        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
        }

        public void PopUpClose()
        {
            GetWait().Until(driver => driver.FindElement(By.CssSelector(".PopupCloseButton__InnerPopupCloseButton-sc-957qyh-0.cMdPwy.wisepops-close")));
            popUpClose.Click();
        }
        
        public void CloseCookies()
        { 
        GetWait().Until(driver => driver.FindElement(By.Id("onetrust-accept-btn-handler")));
        cookieButton.Click();
        }

        public void SearchByText(string text)
        {
            searchField.Clear();
            searchField.SendKeys("Moller");
            searchIcon.Click();
        }

        public void SearchByTextSecond(string text)
        {
            searchField.Clear();
            searchField.SendKeys("biokalis forte");
            searchIcon.Click();
        }

        public void ClickOnSearchIcon()
        {
            searchIcon.Click();
        }
        public void SpanClose()
       {
            GetWait().Until(driver => driver.FindElement(By.CssSelector(".evBtn.evBtnLink")));
            spanClose.Click();
       }

    }
}

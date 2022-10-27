//using draft.Page;
//using OpenQA.Selenium;

//namespace draft.Page
//{
//    public class AlertPage : BasePage
//    {
//        private const string PageAddress = "https://www.eurovaistine.lt/";

//        private IWebElement alertButton => Driver.FindElement(By.Id("https://www.eurovaistine.lt/"));
//        public AlertPage(IWebDriver webdriver) : base(webdriver) { }
//        public void NavigateToPage()
//        {
//            if (Driver.Url != PageAddress)
//                Driver.Url = PageAddress;
//        }

//        public void ClickOnAlertButton()
//        {
//            alertButton.Click();
//        }

//        public void AcceptAlertButton()
//        {
//            IAlert alert = Driver.SwitchTo().Alert();
//            alert.Accept();
//        }
//    }
//}

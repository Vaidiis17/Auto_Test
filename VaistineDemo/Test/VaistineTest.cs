using NUnit.Framework;

namespace draft.Test
{
    public class VaistineTest : BaseTest
    {
        [Test]
        public static void TestMollersPrice()
        {
            _vaistineHomePage.NavigateToPage();
            _vaistineHomePage.PopUpClose();
            _vaistineHomePage.CloseCookies();
            _vaistineHomePage.SearchByText("Moller");
            _vaistineSearchResultPage.OrderByHighestPrice();
            _vaistineSearchResultPage.VerifyPrice("24,89 €");
        }

        [Test]
        public static void Test5MollersPrice()
        {
            _vaistineHomePage.NavigateToPage();
            _vaistineHomePage.PopUpClose();
            _vaistineHomePage.CloseCookies();
            _vaistineHomePage.SearchByText("Moller");
            _vaistineSearchResultPage.OrderByHighestPrice();
            _vaistineSearchResultPage.AddToCard();
            _cartPage.InsertQuantity(4);
            _cartPage.VerifyIfICanBuy(100);

        }

        [Test]
        public static void TestBiokalisForte()
        {
            _vaistineHomePage.NavigateToPage();
            _vaistineHomePage.PopUpClose();
            _vaistineHomePage.CloseCookies();
            _vaistineHomePage.SearchByTextSecond("biokalis forte");
            _vaistineSearchResultPage.VerifyPrice("7,49 €");
            _vaistineSearchResultPage.AddToCard();


        }
    }
}

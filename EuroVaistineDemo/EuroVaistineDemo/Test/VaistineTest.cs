﻿using NUnit.Framework;

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
            _vaistineSearchResultPage.VerifyPrice("15,39 €");
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
            _cartPage.InsertQuantity();
            _cartPage.VerifyIfICanBuy(100);

        }
    }
}

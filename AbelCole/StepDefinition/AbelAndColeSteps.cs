using AbelCole.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AbelCole.StepDefinition
{
    [Binding]
    public class AbelAndColeSteps
    {
        LandingPage landingPage;
        CartPage cartPage;
        ChocholateBrowniePage chocholateBrowniePage;
        HummusChipsPage hummusChipsPage;
        SimplySaltedPopcornPage simplySaltedPopcornPage;

        public AbelAndColeSteps()
        {
            landingPage = new LandingPage();
            cartPage = new CartPage();
            chocholateBrowniePage = new ChocholateBrowniePage();
            hummusChipsPage = new HummusChipsPage();
            simplySaltedPopcornPage = new SimplySaltedPopcornPage();
        }


        //LandingPage
        [Given(@"I navigate to the website""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
           landingPage.NavigateToWebSITE(url);
            Thread.Sleep(3000);
        }

        [Given(@"I click accept cookies")]
        public void GivenIClickAcceptCookies()
        {
           landingPage.ClickacceptCookies();
        }

        [Given(@"I click startshopping")]
        public void GivenIClickStartshopping()
        {
          landingPage.clickstartshopping();
        }

        [Given(@"I enter Item one""(.*)""")]
        public void GivenIEnterItemOne(string Item1)
        {
            landingPage.EnterSearchItem(Item1);
        }


        [Given(@"I click search item(.*)")]
        public void GivenIClickSearchItem(int p0)
        {
            landingPage.ClickSeArch();
        }


        //ChocholateBrowniePage

        [Given(@"I add to cart")]
        public void GivenIAddToCart()
        {
            chocholateBrowniePage.ClickAddTOCART();
        }

        [Given(@"I click search button")]
        public void GivenIClickSearchButton()
        {
           chocholateBrowniePage.ClickSearchButton();
        }

        [Given(@"I insert item(.*)""(.*)""")]
        public void GivenIInsertItem(int p0, string item2)
        {
            chocholateBrowniePage.EnterItem2(item2);
        }

        [Given(@"I click Search")]
        public void GivenIClickSearch()
        {
            chocholateBrowniePage.ClickSearch();
        }


        //HummusChipPage
        [Given(@"I add second item to cart")]
        public void GivenIAddSecondItemToCart()
        {
           hummusChipsPage.ClickAdd1();
        }


        [Given(@"I click add to increase the qty to two")]
        public void GivenIClickAddToIncreaseTheQtyToTwo()
        {
            hummusChipsPage.ClickAdd2();
        }

        [Given(@"I click add to increase the qty to three")]
        public void GivenIClickAddToIncreaseTheQtyToThree()
        {
            hummusChipsPage.ClickAdd3();
        }

        [Given(@"I click SEARCH")]
        public void GivenIClickSEARCH()
        {
            hummusChipsPage.ClickSEarch();
        }

        [Given(@"I enter the item(.*)""(.*)""")]
        public void GivenIEnterTheItem(int p0, string item3)
        {
           hummusChipsPage.EnterItem3(item3);
        }



        [Given(@"I click on search")]
        public void GivenIClickOnSearch()
        {
            hummusChipsPage.ClickSEarch();
        }

        //SimplySaltedPopcornPage
        [Given(@"I click add")]
        public void GivenIClickAdd()
        {
            simplySaltedPopcornPage.ClickAdd3();
        }

        [Given(@"I click add to increase quantity to(.*)")]
        public void GivenIClickAddToIncreaseQuantityTo(int p0)
        {
            simplySaltedPopcornPage.clickAdd2();
        }


        [When(@"I click on cart")]
        public void WhenIClickOnCart()
        {
            simplySaltedPopcornPage.ClickCart();
        }

        //CartPage
        [Then(@"I should have been able to add all items to the cart succesfuly")]
        public void ThenIShouldHaveBeenAbleToAddAllItemsToTheCartSuccesfuly()
        {
            Assert.That (cartPage.IsContinueDisplayed);
        }

        [Then(@"I delete the firsts item")]
        public void ThenIDeleteTheFirstsItem()
        {
            cartPage.ClickDeleteItem1();
        }

        [Then(@"I delete the second item")]
        public void ThenIDeleteTheSecondItem()
        {
            Thread.Sleep(2000);
           cartPage.ClickDeleteItem2();
        }

        [When(@"I delete third item")]
        public void WhenIDeleteThirdItem()
        {
            Thread.Sleep(2000);
            cartPage.ClickDeleteItem3();
        }

        [Then(@"I should be able to delete all cart items succesfully")]
        public void ThenIShouldBeAbleToDeleteAllCartItemsSuccesfully()
        {
            Thread.Sleep(5000);
            Assert.That (cartPage.IsContinueShoppingDisplayed);
        }











    }
}

using AbelCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelCole.PageObject
{
    class LandingPage
    {
        public LandingPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement AcceptCookie => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));
        IWebElement Startshoping => driver.FindElement(By.XPath("//*[@id='prospect-home-page']/section/section[2]/div/div[1]/a"));
        IWebElement EnterItem1 => driver.FindElement(By.XPath("//*[@id='search-term']"));
        IWebElement Search => driver.FindElement(By.XPath("//*[@id='search-btn']"));






        public void NavigateToWebSITE(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickacceptCookies()
        {
            AcceptCookie.Click();
        }
        public void EnterSearchItem(string Item1)
        {
            EnterItem1.SendKeys(Item1);
        }
        public void ClickSeArch()
        {
            Search.Click();
        }
        public void clickstartshopping()
        {
            Startshoping.Click();
        }


    }
}

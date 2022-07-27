using AbelCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AbelCole.PageObject
{
    class CartPage
    {
        public CartPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement Continue => driver.FindElement(By.XPath("/html/body/div[3]/div/section/section[2]/fragment/button"));
        IWebElement DeleteItem1 => driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[4]/div[1]/div[3]"));
        IWebElement DeleteItem2 => driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[4]/div[2]/div[3]"));
        IWebElement DeleteItem3 => driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[4]/div/div[3]/img"));
        IWebElement ContinueShopping => driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/p[3]/a"));

        public bool IsContinueDisplayed()
        {
            return (Continue.Displayed);
        }
        public void ClickDeleteItem1()
        {
            DeleteItem1.Click();
        }
        public void ClickDeleteItem2()
        {
            DeleteItem2.Click();
        }
        public void ClickDeleteItem3()
        {
            DeleteItem3.Click();
        }
        public bool IsContinueShoppingDisplayed()
        {
            return (ContinueShopping.Displayed);
        }






    }
}

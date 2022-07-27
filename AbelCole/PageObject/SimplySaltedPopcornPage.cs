using AbelCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelCole.PageObject
{
    class SimplySaltedPopcornPage
    {
        public SimplySaltedPopcornPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement AddItem3 => driver.FindElement(By.XPath("//*[@id='product-list']/li/div[3]/div[3]/div[2]/div[1]"));
        IWebElement Add2 => driver.FindElement(By.XPath("//*[@id='product-list']/li/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement Cart => driver.FindElement(By.XPath("//*[@id='BasketCount']"));


        public void ClickAdd3()
        {
            AddItem3.Click();
        }
        public void clickAdd2()
        {
            Add2.Click();
        }
        public void ClickCart()
        {
            Cart.Click();
        }


    }
}

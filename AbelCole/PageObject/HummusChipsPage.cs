using AbelCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelCole.PageObject
{
    class HummusChipsPage
    {
        public HummusChipsPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;



        IWebElement Add1 => driver.FindElement(By.XPath("//*[@id='product-list']/li/div[3]/div[3]/div[2]/div[1]"));
        IWebElement Add2 => driver.FindElement(By.XPath("//*[@id='product-list']/li/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement Add3 => driver.FindElement(By.XPath("//*[@id='product-list']/li/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement Searchbutton => driver.FindElement(By.XPath("//*[@id='search-btn']"));
        IWebElement Item3 => driver.FindElement(By.XPath("//*[@id='search-term']"));
        IWebElement Search => driver.FindElement(By.XPath("//*[@id='search-btn']"));

        public void ClickAdd1()
        {
            Add1.Click();
        }
        public void ClickAdd2()
        {
            Add2.Click();
        }
        public void ClickAdd3()
        {
            Add3.Click();
        }
        public void ClickSearch()
        {
            Searchbutton.Click();
        }
        public void EnterItem3(string item3)
        {
            Item3.SendKeys(item3);
        }
        public void ClickSEarch()
        {
            Search.Click();
        }




    }
}

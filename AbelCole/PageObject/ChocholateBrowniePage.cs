using AbelCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelCole.PageObject
{
    class ChocholateBrowniePage
    {
        public ChocholateBrowniePage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;


        IWebElement AddToCart => driver.FindElement(By.CssSelector("#product-list > li:nth-child(1) > div.product-infos.empty > div.add-to-basket > div.add-to-basket-controls > div.add.cta-button"));
        IWebElement Searchbutton => driver.FindElement(By.XPath("//*[@id='search-btn']"));
        IWebElement Item2 => driver.FindElement(By.XPath("//*[@id='search-term']"));
        IWebElement Search => driver.FindElement(By.XPath("//*[@id='search-btn']"));
        



       
        public void ClickAddTOCART()
        {
            AddToCart.Click();
        }
        
        public void ClickSearchButton()
        {
            Searchbutton.Click();
        }
        public void EnterItem2(string item2)
        {
            Item2.SendKeys(item2);
        }
        public void ClickSearch()
        {
            Search.Click();
        }





    }

}

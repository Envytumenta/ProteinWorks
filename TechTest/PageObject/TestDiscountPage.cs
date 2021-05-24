using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTest.Hooks;

namespace TechTest.PageObject
{
    class TestDiscountPage
    {
        public IWebDriver driver;
        public TestDiscountPage()
        {
            driver = WebHook.driver;
        }
        private By clickCarousel = By.CssSelector("#widget-banners-0 > div > div > div:nth-child(2) > div > div > a > picture > img");
        private By clickProduct = By.CssSelector("#31>div>div>strong>a>span");

        public void ClickCarousel()
        {
            Thread.Sleep(10000);
           // for (int i = 0; i < 3; i++) 
             driver.FindElement(clickCarousel).Click();
            
        }
        public void ClickProduct()
        {
            driver.FindElement(clickProduct).Click();
        }





























    }
}

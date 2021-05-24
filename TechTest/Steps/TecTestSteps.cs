using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTest.Hooks;
using TechTest.PageObject;

namespace TechTest.Steps
{
    [Binding]
    public class TecTestSteps
    {
        public IWebDriver driver = WebHook.driver;

        TestDiscountPage testDiscountPage = new TestDiscountPage();

        [Given(@"i am on the hompage ""(.*)""")]
        public void GivenIAmOnTheHompage(string URL)
        {
            driver.Navigate().GoToUrl(URL);
        }
        
        [Given(@"I go to the third product from the first carousel")]
        public void GivenIGoToTheThirdProductFromTheFirstCarousel()
        {
            testDiscountPage.ClickCarousel();
        }
        
        [Given(@"I click the product")]
        public void GivenIClickTheProduct()
        {
            testDiscountPage.ClickProduct();
        }
        
        [Given(@"I select the penultimate flavour from the list")]
        public void GivenISelectThePenultimateFlavourFromTheList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select the second available weight")]
        public void GivenISelectTheSecondAvailableWeight()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I clic on add to basket")]
        public void GivenIClicOnAddToBasket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I add the first item from pop up to basket")]
        public void GivenIAddTheFirstItemFromPopUpToBasket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I proceed to basket")]
        public void GivenIProceedToBasket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I apply the discount code ""(.*)""")]
        public void GivenIApplyTheDiscountCode(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I validate this message ""(.*)""")]
        public void GivenIValidateThisMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I proceed to checkout")]
        public void WhenIProceedToCheckout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"checkout must return (.*) HTTP code")]
        public void ThenCheckoutMustReturnHTTPCode(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

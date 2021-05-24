using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTest.Hooks;
using TechTest.PageObject;

namespace TechTest.Steps
{

    [Binding]
    public class CreateAccountSteps
    {
        public IWebDriver driver = WebHook.driver;

        CreateAccountPage createAccountPage = new CreateAccountPage();


        [Given(@"I navigate to homepage""(.*)""")]
        public void GivenINavigateToHomepage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        
        [When(@"I enter my details '(.*)''(.*)''(.*)''(.*)''(.*)''(.*)'")]
        public void WhenIEnterMyDetails(string p0, string p1, string p2, string p3, string p4, string p5)
        {
            createAccountPage.FirstName(p0);
            createAccountPage.LastName(p1);
            createAccountPage.Email(p2);
            createAccountPage.Password(p3);
            createAccountPage.ConfirmPassword(p4);
            createAccountPage.Gender();
            createAccountPage.DateOfBirth();
            createAccountPage.PhoneNumber(p5);
            createAccountPage.MainGoal();
            createAccountPage.CountMeIn();
            createAccountPage.JoinUp();
            
        }
        
        [Then(@"account should be created")]
        public void ThenAccountShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

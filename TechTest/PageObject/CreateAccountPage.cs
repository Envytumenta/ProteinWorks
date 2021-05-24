using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTest.Hooks;

namespace TechTest.PageObject
{
    class CreateAccountPage
    {
        public IWebDriver driver;

        public CreateAccountPage()
        {
            driver = WebHook.driver;
        }
        private By firstName = By.Id("firstname");
        private By lastName = By.Id("lastname");
        private By email = By.Id("email_address");
        private By password = By.Id("password");
        private By confirmPassword = By.Id("password-confirmation");
        private By gender = By.Id("gender");
        private By dateOfBirth = By.Id("dob");
        private By phoneNumber = By.Id("mobile_number_input");
        private By month = By.CssSelector("#ui-datepicker-div > div > div > select.ui-datepicker-month");
        private By mainGoal = By.Id("customer_goal");
        private By countMeIn = By.Id("is_subscribed_yes");
        private By joinUp = By.CssSelector("#form-validate > div > div.primary > button");
        private By year = By.CssSelector("#ui-datepicker-div > div > div > select.ui-datepicker-year");
        private By day = By.CssSelector("#ui-datepicker-div > table > tbody > tr:nth-child(2) > td.ui-datepicker-current-day > a");

        public void FirstName(string p0)
        {
            driver.FindElement(firstName).SendKeys(p0);
        }

        public void LastName(string p1)
        {
            driver.FindElement(lastName).SendKeys(p1);
        }

        public void Email(string p2)
        {
            driver.FindElement(email).SendKeys(p2);
        }

        public void Password(string p3)
        {
            driver.FindElement(password).SendKeys(p3);
        }

        public void ConfirmPassword(string p4)
        {
            driver.FindElement(confirmPassword).SendKeys(p4);
        }

        public void Gender()
        {
            driver.FindElement(gender).Click();
            var selectElement = new SelectElement(driver.FindElement(By.Id("gender")));
            selectElement.SelectByIndex(1);
        }

        public void DateOfBirth()
        {
            Thread.Sleep(5000);
           driver.FindElement(dateOfBirth).Click();
           // driver.FindElement(month).Click();
           // var selectElement = new SelectElement(driver.FindElement(By.CssSelector("#ui-datepicker-div > div > div > select.ui-datepicker-month")));
           //selectElement.SelectByText("Jan");
           // Thread.Sleep(5000);
           // driver.FindElement(year).Click();
           // _ = new SelectElement(driver.FindElement(By.CssSelector("#ui-datepicker-div > div > div > select.ui-datepicker-year")));
           // selectElement.SelectByIndex(30);
           // Thread.Sleep(5000);
           // driver.FindElement(day).Click();

        }

        public void PhoneNumber(string p5)
        {
            driver.FindElement(phoneNumber).SendKeys(p5);
        }

        public void MainGoal()
        {
            driver.FindElement(mainGoal).Click();
            var selectElement = new SelectElement(driver.FindElement(By.Id("customer_goal")));
            selectElement.SelectByIndex(3);
        }

        public void CountMeIn()
        {
            Thread.Sleep(10000);
            driver.FindElement(countMeIn).Click();
        }
        
        public void JoinUp()
        {
           // driver.FindElement(joinUp).Click();
        }
      











    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowPractice.StepDefinitions
{
    [Binding]
    public class LoginSetps
    {
        private IWebDriver driver;


        public LoginSetps(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"user navigate to turnup portal")]
        public void GivenUserNavigateToTurnupPortal()
        {
           
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
        }

        [When(@"user enters invalid credentials")]
        public void WhenUserEntersInvalidCredentials()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            driver.FindElement(By.Id("Password")).SendKeys("1223");
        }

        [Then(@"user clicks on the login button")]
        public void ThenUserClicksOnTheLoginButton()
        {
            driver.FindElement(By.XPath("//input[@value = \"Log in\"]")).Click();
        }

        [When(@"user enters valid credentials")]
        public void WhenUserEntersValidCredentials()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            driver.FindElement(By.Id("Password")).SendKeys("123123");
        }

    }
}

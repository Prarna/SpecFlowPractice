using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowPractice.StepDefinitions
{
    [Binding]
    public class HomePageSteps
    {
        private IWebDriver driver;
        public HomePageSteps(IWebDriver driver) 
        {
            this.driver = driver;
        }

        [Given(@"user is on the homepage")]
        public void UserIsOnTheHomepage()
        {
            
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            driver.FindElement(By.Id("Password")).SendKeys("123123");
            driver.FindElement(By.XPath("//input[@value = \"Log in\"]")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement userProfileName = driver.FindElement(By.XPath("//*[contains(text(),'Hello hari!')]"));
            Assert.That(userProfileName.Text, Is.EqualTo("Hello hari!"));
        }

        [When(@"user clicks on the main administration dropdown")]
        public void UserClicksOnTheMainAdministrationDropdown()
        {
            driver.FindElement(By.XPath("//*[contains(text(),'Administration')]")).Click();
        }

        [When(@"user clicks on the time and material option")]
        public void UserClicksOnTheTimeAndMaterialOption()
        {
            driver.FindElement(By.XPath("//*[contains(text(),'Administration')]")).Click();

        }

        [Then(@"user navigates to the time and material page")]
        public void UserNavigatesToTheTimeAndMaterialPage()
        {
            IWebElement createNewButton = driver.FindElement(By.XPath("//a[contains(text(), 'Create New')]"));
            Assert.That(createNewButton.Text, Is.EqualTo("Create New"));
        }

    }
}

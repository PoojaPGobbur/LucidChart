using SpecFlowProject1.Drivers;
using SpecFlowProject1.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class HomepageStepDefinitions : Basedriver
    {
       // Basedriver baseDriver;
        //homepageclass HomeClass;

        [Given(@"Navigate to home page")]
        public void GivenNavigateToHomePage()
        {
            //baseDriver = new Basedriver();
            //baseDriver.Setup();

            Setup();
            Thread.Sleep(3000);
        }

        [When(@"i click on signup for free button")]
        public void WhenIClickOnSignupForFreeButton()
        {
           // HomeClass = new homepageclass(baseDriver.driver);
           // HomeClass.signupfree.Click();

            homepageclass Home = new homepageclass(driver);
            Home.signupfree.Click();
            Home.Lucidchart_plans.Click();
        }

        [When(@"i click on start free button")]
        public void WhenIClickOnStartFreeButton()
        {
            homepageclass Home = new homepageclass(driver);
            Home.startfree.Click();
        }

        [Then(@"sign up page will be displayed")]
        public void ThenSignUpPageWillBeDisplayed()
        {
            throw new PendingStepException();
        }


    }
}

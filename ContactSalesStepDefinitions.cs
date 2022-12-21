using SpecFlowProject1.Drivers;
using SpecFlowProject1.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ContactSalesStepDefinitions :Basedriver
    {
        [Given(@"Navigation to Home page")]
        public void GivenNavigationToHomePage()
        {
            Setup();
            Thread.Sleep(2000);
        }

        [When(@"i will click on Contact sales button")]
        public void WhenIWillClickOnContactSalesButton()
        {
            ContactSalesform CS = new ContactSalesform(driver);
            CS.Contact_S.Click();
            Thread.Sleep(3000);
        }

        [When(@"i fill all the details in Contact sales form")]
        public void WhenIFillAllTheDetailsInContactSalesForm()
        {
            ContactSalesform CS = new ContactSalesform(driver);
            CS.C_Fname.SendKeys("Pooja");
            CS.C_Lname.SendKeys("Gobbur");
            CS.C_Email.SendKeys("pooja@quali.com");
            CS.C_Phone.SendKeys("1234567891");
            CS.C_Details.SendKeys("Gobbur");
            



        }

        [Then(@"i will click on submit button")]
        public void ThenIWillClickOnSubmitButton()
        {
            ContactSalesform CS = new ContactSalesform(driver);
            CS.C_Submit.Click();
        }
    }
}

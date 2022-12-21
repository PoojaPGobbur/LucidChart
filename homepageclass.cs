using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SpecFlowProject1.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class homepageclass : Basedriver
    {
       // public homepageclass(IWebDriver driver) => this.driver = driver;
        public homepageclass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How =How.XPath , Using = "//a[text()='Sign up free']")]
        public IWebElement signupfree { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[text()=' Lucidchart plans ']")]
        public IWebElement Lucidchart_plans  { get; set; }

        //bundle-pricing-tab-chart

        [FindsBy(How = How.XPath, Using = "//div[@class='buttons']//lucid-marketing-button[@class='button-marketing-primary marketing-style-chart']")]
        public IWebElement startfree { get; set; }



        /* public IWebElement signupmethod()
         {
             return signupfree;
         }*/
    }
}

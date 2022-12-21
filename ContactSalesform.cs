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
    public class ContactSalesform : Basedriver
    {
        public ContactSalesform(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#site-nav > div > div.css-n7re8u-navMenuContainer.e1n7skr50 > ul.css-bxt9xv-navMenuButtonUL > li:nth-child(1) > a")]
        public IWebElement Contact_S { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement C_Fname { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        public IWebElement C_Lname { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        public IWebElement C_Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Phone']")]
        public IWebElement C_Phone { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@id='MktoPersonNotes']")]
        public IWebElement C_Details { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ab-test-Y22Q4_UnifiedSuiteCTAs > div > main > div > div > div > div.css-rxdpp1.e1n7skr50 > div.css-tb3kfw.erqvlcy0 > form > div.css-4vap7y.e1n7skr50 > button")]
        public IWebElement C_Submit { get; set; }






    }




}


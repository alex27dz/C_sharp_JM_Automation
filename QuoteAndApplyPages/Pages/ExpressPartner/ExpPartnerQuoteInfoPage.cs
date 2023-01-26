using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;



namespace QuoteAndApplyPages.Pages.QNA
{
    public class ExpPartnerQuoteInfoPage : Page
    {
        string btnApplyforCoverage = "a[id='quoteResultsNext']";
        
        public ExpPartnerQuoteInfoPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnApplyforCoverage);
        }

        public override void WaitForLoad()
        {
           // System.Threading.Thread.Sleep(1000);
          //  WaitUntilElementIsDisplayed(driver, By.CssSelector(btnApplyforCoverage));
            IsElementPresent(driver, By.Id("quoteResultsNext"));

        }


        public void ClickApplyforCoverage()
        {
            pause();
            UIAction(btnApplyforCoverage, string.Empty, "a");
        }



       
    }
}

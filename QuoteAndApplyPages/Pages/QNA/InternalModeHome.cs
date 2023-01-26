using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace QuoteAndApplyPages.Pages.QNA
{
    public class InternalModeHome : Page
    {
        string radioReferralCustomer = "input[id$='ReferralSources-Customer Care']";
        string radioReferralAgency = "input[id$='ReferralSources-Agency Express']";
        string radioReferralJMIS = "input[id$='ReferralSources-JM Insurance Services, LLC']";
        string buttonContinue = "a[id$='continue']";
        string selectPartner= "select[id$= 'partner']";

        public InternalModeHome(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  SetActiveFrame();
            pause();
            VerifyUIElementIsDisplayed(radioReferralAgency);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(radioReferralAgency));
        }

        public void SelectReferralSource(string Source, string PartnerName)
        {
            switch (Source.ToLower().Trim())
            {
                case "customer care":
                    UIAction(radioReferralCustomer, string.Empty, "radio");
                    break;
                case "agency express":
                    UIAction(radioReferralAgency, string.Empty, "radio");
                    UIAction(selectPartner, PartnerName, "selectbox");
                    break;
                case "jm insurance service":
                    UIAction(radioReferralJMIS, string.Empty, "radio");
                    break;
            }

        }



        public void click_Continue()
        {
            UIAction(buttonContinue, string.Empty, "a");
            pause();
        }


    }
}

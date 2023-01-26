using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PLPortalPages.Pages
{
    public class JewelerDetailes : Page
    {


        string btnJewelerInfoContinue = "input[id$='jewelerInfoContinue']";
        string radiopreferredJewelerNo = "input[d$='no']";
        string radiopreferredJewelerYes = "input[id$='yes']";

        string txtJewelerName = "input[id$='NewJewelerName']";
        string txtJewelerStreetAddress = "input[id$='NewJewelerStreetAddress']";
        string txtJewelerCity = "input[id$='NewJewelerCity']";
        string txtJewelerState = "input[id$='NewJewelerState']";
        string txtJewelerPhone = "input[id$='NewJewelerPhone']";
        string txtJewelerEmail = "input[id$='NewJewelerEmail']";





        public JewelerDetailes(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnJewelerInfoContinue);
        }

        public override void WaitForLoad()
        {

        }

        public void UpdatePreferredJewelerInfo(string preferredjeweler)
        {
            Console.WriteLine("I am in Jeweler Information");
            switch (preferredjeweler.ToUpper().Trim())
            {

                case "NO":
                    UIAction(radiopreferredJewelerNo, string.Empty, "a");
                    break;
                case "YES":
                    UIAction(radiopreferredJewelerYes, string.Empty, "a");
                    break;
                default:
                    break;
            }



        }
        public void ClickContinue()
        {
            UIAction(btnJewelerInfoContinue, string.Empty, "a");
            pause();
        }

        public void UpdateJewelrInformation(string JewelerName, string JewelerAddress, string JewelerCity, string JewelerState, string JewelerPhone, string JewelerEmail)
        {
            pause();
            UIAction(txtJewelerName, JewelerName, "textbox");
            UIAction(txtJewelerStreetAddress, JewelerAddress, "textbox");
            UIAction(txtJewelerCity, JewelerCity, "textbox");
            UIAction(txtJewelerState, JewelerState, "textbox");
            UIAction(txtJewelerPhone, JewelerPhone, "textbox");
            UIAction(txtJewelerEmail, JewelerEmail, "textbox");
            pause();

        }
    }

}

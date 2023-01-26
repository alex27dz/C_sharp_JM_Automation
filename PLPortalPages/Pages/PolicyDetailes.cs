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
    public class PolicyDetailes : Page
    {
        string btnPayPremium = "img[alt='Pay My Premium']";
        string btnAddUpdateJewelry = "img[alt='Add Jewelry']";
        string btnuploadAppraisal = "img[alt='Update Personal Information']";
        string btnSubmitClaim = "img[alt='Update Personal Information']";
        string btnChangePersonalInfo = "img[alt='Submit a Claim']";


        public PolicyDetailes(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(txtAppfirstName);
        }

        public override void WaitForLoad()
        {
        }

    }

}

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
    public class SubmitClaim : Page
    {

        string btnStartClaim = "input[id$='startClaim']";
        string txtLossDate = "input[id$='LossDiscoveryDate']";

        string btnContinueClaim = "input[id$='continueClaim']";
        string btnCancelClaim = "input[id$='cancelClaim']";

        string checkSelectJewelryItem = "input[id$='selectedJewelryItems']";

        //loss Damage <input id="LossCause" name="LossCause" title="Any damage incurred while your jeweler was working on your jewelry." type="radio" value="Damaged During Work by Jeweler">

        string txtLossDescription = "textarea[id$='LossDescription']";
        string txtLossCaption = "textarea[id$='Comments']";
        string btnClaimDetailContinue = "input[id$='claimDetailContinue']";
        string btnJewelerInfoContinue = "input[id$='jewelerInfoContinue']";
        string btnSubmitClaim = "input[id$='verifyAndSubmit']";
        string btnSubmitClaimBack = "input[id$='claimReportByBack']";
        string txtContactCity = "input[id$='ContactCity']";

        //Preferred Jeweler Yes
        //<input type="radio" name="preferredJewelerYesNo" value="yes" id="yes">
        //<input type="radio" name="preferredJewelerYesNo" value="no" id="no">
        string txtJewelerName = "input[id$='NewJewelerName']";
        string txtJewelerStreetAddress = "input[id$='NewJewelerStreetAddress']";
        string txtJewelerCity = "input[id$='NewJewelerCity']";
        string txtJewelerState = "input[id$='NewJewelerState']";
        string txtJewelerPhone = "input[id$='NewJewelerPhone']";
        string txtJewelerEmail = "input[id$='NewJewelerEmail']";





        public SubmitClaim(IWebDriver driver) : base(driver)
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

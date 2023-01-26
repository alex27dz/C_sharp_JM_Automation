using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace BillingCenterPages.Pages.WriteOff
{
    public class BCWriteOff : Page
    {


        [FindsBy(How = How.Id, Using = "AccountCreateDisbursementWizard:Next-btnInnerEl")]
        public IWebElement btnNextDistribution;

        string WriteoffWizardConfirmation = "a[id='AccountNewWriteoffWizard:NewWriteoffWizardConfirmationStepScreen:ttlBar']";

        string WriteoffWizardDetailsStep = "a[id='AccountNewWriteoffWizard:NewWriteoffWizardDetailsStepScreen:ttlBar']";

        string WriteoffWizardTargetStep = "a[id='AccountNewWriteoffWizard:AccountNewWriteoffWizardTargetStepScreen:ttlBar']";

        string btnSelect = "a[id='AccountNewWriteoffWizard:AccountNewWriteoffWizardTargetStepScreen:TransferSourceDV:AccountPolicyPeriodsLV:0:Select']";

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffWizard:Next-btnInnerEl")]
        public IWebElement btnNextWriteOff;

        // [FindsBy(How = How.Id, Using = "AccountNewWriteoffWizard:AccountNewWriteoffWizardTargetStepScreen:TransferSourceDV:AccountPolicyPeriodsLV:0:Select")]

        // [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'g-actionable miniButton')]]")] 
        //  string SelectPolicy = "span[id$='AccountNewWriteoffWizard:AccountNewWriteoffWizardTargetStepScreen:TransferSourceDV:AccountPolicyPeriodsLV:0:Select']";


        //public IWebElement btnSelectPolicy; 

        // [FindsBy(How = How.XPath, Using = "//a[text()='Select']")] 
        //public IWebElement btnSelect; 

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffWizard:NewWriteoffWizardDetailsStepScreen:WriteoffDetailsDV:ChargePattern-inputEl")]

        public IWebElement txtChargePattern;

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffWizard:NewWriteoffWizardDetailsStepScreen:WriteoffDetailsDV:Amount-inputEl")]

        public IWebElement txtChargeAmount;

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffWizard:NewWriteoffWizardDetailsStepScreen:WriteoffDetailsDV:Reason-inputEl")]

        public IWebElement txtCustomerRequest;

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffWizard:Finish-btnInnerEl")]
        public IWebElement btnFinishWriteOff;

        public BCWriteOff(IWebDriver driver) : base(driver)
        {
            IsElementPresent(driver, By.CssSelector(WriteoffWizardTargetStep));
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(logOut); 
        }

        public override void WaitForLoad()
        {
            //throw new NotImplementedException(); 
        }
        public void WriteOffAmount(string WriteoffAmount, string WriteoffPattern, string WriteoffReason)
        {
            UIAction(btnSelect, string.Empty, "a");
            //  btnSelect.Click(); 
            // JavaScriptClick(btnSelect); 
            pause();
            btnNextWriteOff.Click();
            pause();
            IsElementPresent(driver, By.CssSelector(WriteoffWizardDetailsStep));
            txtChargePattern.Clear();
            txtChargePattern.SendKeys(WriteoffPattern);
            Console.WriteLine(WriteoffAmount + " Amount is");
            txtChargeAmount.Clear();
            txtChargeAmount.SendKeys(WriteoffAmount);
            txtCustomerRequest.SendKeys(WriteoffReason);
            btnNextWriteOff.Click();
            pause();
            IsElementPresent(driver, By.CssSelector(WriteoffWizardConfirmation));
            btnFinishWriteOff.Click();



        }

    }
}


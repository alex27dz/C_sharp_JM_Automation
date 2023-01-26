using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
namespace BillingCenterPages.Pages.DisbursementPayment
{
    public class DisbursementPayment : Page
    {
        [FindsBy(How = How.Id, Using = "AccountCreateDisbursementWizard:CreateDisbursementDetailScreen:CreateDisbursementDetailDV:amount-inputEl")]
        public IWebElement txtAmount;

        [FindsBy(How = How.Id, Using = "AccountCreateDisbursementWizard:CreateDisbursementDetailScreen:CreateDisbursementDetailDV:reason-inputEl")]
        public IWebElement txtReason;

        [FindsBy(How = How.Id, Using = "AccountCreateDisbursementWizard:Next-btnInnerEl")]
        public IWebElement btnNextDistribution;

        [FindsBy(How = How.Id, Using = "AccountCreateDisbursementWizard:Finish-btnInnerEl")]
        public IWebElement btnFinishDistribution;

        [FindsBy(How = How.Id, Using = "AccountCreateDisbursementWizard:CreateDisbursementDetailScreen:ttlBar")]
        public IWebElement lblPaymentHistory;
        
        public DisbursementPayment(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //throw new NotImplementedException(); 
        }

        public override void WaitForLoad()
        {
            //throw new NotImplementedException(); 
        }
        public void MakeDisbursementPayment(string paymentAmount, string disbursementReason)
        {


            txtAmount.SendKeys(paymentAmount);
            txtReason.Clear();
            txtReason.SendKeys(disbursementReason);
            btnNextDistribution.Click();
            WaitFor(btnFinishDistribution);
            btnFinishDistribution.Click();
        }
    }





}

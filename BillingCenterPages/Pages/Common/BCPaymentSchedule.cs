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


namespace BillingCenterPages.Pages.Common
{

    public class BCPaymentSchedule : Page
    {
        [FindsBy(How = How.Id, Using = "AccountDetailSummary:AccountDetailSummaryScreen:AccountPoliciesLV:0:PolicyNumber")]

        public IWebElement LinkPolicyNumber;

        [FindsBy(How = How.Id, Using = "PolicyDetailPayments:PolicyDetailPaymentsScreen:ChangePaymentPlan-btnInnerEl")]
        public IWebElement btnEditSchedule;

        [FindsBy(How = How.Id, Using = "ChangePaymentPlanPopup:PaymentPlan-inputEl")]
        public IWebElement txtPaymentPlan;

        [FindsBy(How = How.Id, Using = "ChangePaymentPlanPopup:Update-btnInnerEl")]
        public IWebElement btnExecutePaymentPlan;

        public BCPaymentSchedule(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(logOut); 
        }

        public override void WaitForLoad()
        {
            //throw new NotImplementedException(); 
        }

        public void ChangePaymentPlan(string PaymentPlan)
        {
            System.Threading.Thread.Sleep(2000);
            btnEditSchedule.Click();
            System.Threading.Thread.Sleep(2000);
            txtPaymentPlan.Clear();
            System.Threading.Thread.Sleep(2000);
            txtPaymentPlan.SendKeys(PaymentPlan);
            System.Threading.Thread.Sleep(2000);
            btnExecutePaymentPlan.Click();


        }

    }
}


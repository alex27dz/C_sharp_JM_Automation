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
using Microsoft.Win32;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenter9Pages.Pages.Transaction
{
    public class PolicyStartCancel_PC9 : Page
    {
        string lblPolicyCancel = "span[id='StartCancellation:StartCancellationScreen:ttlBar']";
        string listCancelSource = "input[id$=':StartCancellationScreen:CancelPolicyDV:Source-inputEl']";
        string listCancelReason = "input[id$=':StartCancellationScreen:CancelPolicyDV:Reason-inputEl']";
        string txtCancelEffectiveDate = "input[id='StartCancellation:StartCancellationScreen:CancelPolicyDV:CancelDate_date-inputEl']";
        string btnStartCancel = "span[id$=':NewCancellation-btnInnerEl']";
        string lblConfirmation = "span[id='CancellationWizard:CancellationWizard_QuoteScreen:ttlBar']";
        public PolicyStartCancel_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyCancel);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyCancel));
        }

        public void EnterPolicyCancelDetailsPC9(string Source, string Reason, string refundMethod, string CancelEffDt)
        {
            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            UIActionExt(By.CssSelector(listCancelSource), "ispresent");
            UIActionExt(By.CssSelector(listCancelSource), "List", Source);
            UIActionExt(By.CssSelector(listCancelReason), "ispresent");
            UIActionExt(By.CssSelector(listCancelReason), "List", Reason);

            if (CancelEffDt.ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (CancelEffDt.ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (CancelEffDt.Contains("+"))
            {
                string[] details = CancelEffDt.Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            else if (CancelEffDt.Contains("-"))
            {
                string[] details = CancelEffDt.Split('-');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));

            }
            else
            {
                tempDate = CancelEffDt;
            }
            Console.WriteLine("Cancellation Date:" + tempDate);
            try
            {
                UIActionExt(By.CssSelector(txtCancelEffectiveDate), "ispresent");
                UIActionExt(By.CssSelector(txtCancelEffectiveDate), "Text", tempDate);

            }
            catch (Exception e)
            {
                Console.WriteLine(" exception is " + e.Message);
            }
            Console.WriteLine("Click on start cancellation button");
        }

        public void ClickStartCancellationPC9()
        {
            UIAction(btnStartCancel, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lblConfirmation));
        }

        public void EnterDetailsForPolicyCancel(string Source, string Reason, string refundMethod, string CancelEffDt)
        {
            UIActionExt(By.CssSelector(listCancelSource), "ispresent");
            UIActionExt(By.CssSelector(listCancelSource), "List", Source);
            UIActionExt(By.CssSelector(listCancelReason), "ispresent");
            UIActionExt(By.CssSelector(listCancelReason), "List", Reason);

        }
    }
}

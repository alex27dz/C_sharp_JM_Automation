using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PolicyCenterPages.Pages.Transaction
{
    public class PolicyStartCancel : Page
    {
        string btnCancel = "a[id='StartCancellation:StartCancellationScreen:Cancel']";
        string lstSource = "select[id$='StartCancellation:StartCancellationScreen:CancelPolicyDV:Source']";
        string lstReason = "select[id$='StartCancellation:StartCancellationScreen:CancelPolicyDV:Reason']";
        //string lstRefundMethod = "select[id$='StartCancellation:StartCancellationScreen:CancelPolicyDV:CalcMethod']";
        string txtCancellationDate = "StartCancellation:StartCancellationScreen:CancelPolicyDV:CancelDate_date";
        string btnStartCancel = "a[id$='StartCancellation:StartCancellationScreen:NewCancellation']";

        public PolicyStartCancel(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            SetActiveFrame();
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(btnCancel); 
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnCancel));
        }
        public void EnterPolicyCancelDetails(string Source, string Reason, string refundMethod, string CancelEffDt)
        {
            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            UIAction(lstSource, Source, "selectbox");
            //WaitUntilElementEnabled(driver, By.CssSelector(lstReason));
            //WaitForPageLoad(driver);
            pause();
            pause();
            pause();
            UIAction(lstReason, Reason, "selectbox");

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
            pause();
            pause();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + txtCancellationDate + "').value='" + tempDate + "'");
        }
        public void ClickStartCancellation()
        {
            UIAction(btnStartCancel, string.Empty, "a");
            System.Threading.Thread.Sleep(10000);
        }
    }
}

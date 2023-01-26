using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenterPages.Pages.NewSubmission
{
    public class CL_Payment : Page
    {
        //string btnNext = "a[id$='SubmissionWizard:Next']";
        string bindAndIssue = "a[id$=':BindAndIssue']";
        string lstBillingMethod = "select[id$=':BillingAdjustmentsDV:BillingMethod']";
        string radioInstallmentPlans = "table[id$=':InstallmentPlan:BillingAdjustmentsInstallmentsLV']";
        string radio12Pay = "input[id$=':BillingAdjustmentsInstallmentsLV:0:InstallmentPlan']";
        string radio2Pay = "input[id$=':BillingAdjustmentsInstallmentsLV:1:InstallmentPlan']";
        string radio4Pay = "input[id$=':BillingAdjustmentsInstallmentsLV:2:InstallmentPlan']";
        string radio8Pay = "input[id$=':BillingAdjustmentsInstallmentsLV:3:InstallmentPlan']";
        string radio1Pay = "input[id$=':BillingAdjustmentsInstallmentsLV:4:InstallmentPlan']";
        public CL_Payment(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();
            VerifyUIElementIsDisplayed(bindAndIssue);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(bindAndIssue));
        }
        public void SelectBillingMethod(string BillingMethod)
        {
            WaitFor(driver.FindElement(By.CssSelector(lstBillingMethod)));
            UIAction(lstBillingMethod, BillingMethod, "selectbox");
        }
        public void SelectInstallmentPlan(string InstallmentPlan)
        {
            WaitFor(driver.FindElement(By.CssSelector(radioInstallmentPlans)));
            switch (InstallmentPlan.ToUpper().Trim())
            {
                case "12 PAY":
                    UIAction(radio12Pay, string.Empty, "radio");
                    break;
                case "2 PAY":
                case "2 PAY - SEMI ANNUALLY":
                    UIAction(radio2Pay, string.Empty, "radio");
                    break;
                case "4 PAY":
                case "4 PAY - QUARTERLY":
                    UIAction(radio4Pay, string.Empty, "radio");
                    break;
                case "8 PAY":
                    UIAction(radio8Pay, string.Empty, "radio");
                    break;
                case "ANNUAL PAY":
                    UIAction(radio1Pay, string.Empty, "radio");
                    break;
                default:
                    Console.WriteLine(InstallmentPlan + " , installment plan not recognized");
                    Assert.Fail("Please verify installment plan");
                    break;
            }

        }
    }
}

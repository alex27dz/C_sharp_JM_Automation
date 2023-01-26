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

namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class PL_PolicyInfo_PC9 : Page
    {
        string lblPolicyInfo = "span[id$='_PolicyInfoScreen:ttlBar']";
        string btnNext = "span[id$=':Next-btnInnerEl']";
        string lstTermType = "input[id$=':PolicyInfoInputSet:TermType-inputEl']";
        string lnkProducerSearchIcon = "div[id$=':ProducerCodeInput:SelectProducerCode']";
        string lblProducerCodeSearch = "span[id='ProducerCodeSearchPopup:ProducerCodeSearchScreen:ttlBar']";
        string txtProducerCode = "input[id$=':ProducerCodeSearchDV:Code-inputEl']";
        string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
        string PolicyEffectiveDate = "SubmissionWizard:LOBWizardStepGroup:SubmissionWizard_PolicyInfoScreen:SubmissionWizard_PolicyInfoDV:PolicyInfoInputSet:EffectiveDate-inputEl";
        // string PolicyEffectiveDateRewrite = "RewriteWizard:LOBWizardStepGroup:RewriteWizard_PolicyInfoScreen:RewriteWizard_PolicyInfoDV:PolicyInfoInputSet:EffectiveDate-inputEl";

        //string txtPolicyEffectiveDate = "input[id$=':PolicyInfoInputSet:EffectiveDate']";
        string PolicyRewriteEffectiveDate = "RewriteWizard:LOBWizardStepGroup:RewriteWizard_PolicyInfoScreen:RewriteWizard_PolicyInfoDV:PolicyInfoInputSet:EffectiveDate-inputEl";
        string btnQuote = "span[id$=':QuoteOrReview-btnInnerEl']";

        public PL_PolicyInfo_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyInfo);
        }
        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyInfo));
        }

        public void EnterPolicyInfoPC9()
        {
            UIActionExt(By.CssSelector(btnNext), "click");
            //UIAction(btnNext, string.Empty, "a");
        }

        public void ClickQuotebtn()
        {
            UIAction(btnQuote, string.Empty, "a");
        }

        public void EnterPolicyInfoDetailsPC9(string termType, string policyEffDate, string producerCode)
        {
            System.Console.WriteLine("term type is " + termType);
            switch (termType.ToUpper().Trim())
            {
                case "ANNUAL":
                    driver.FindElement(By.CssSelector(lstTermType)).Click();
                    UIAction(lstTermType, "Annual", "a");
                    break;
                case "OTHER":
                    driver.FindElement(By.CssSelector(lstTermType)).Click();
                    UIAction(lstTermType, "Other", "textbox");
                    break;
                case "6 MONTHS":
                    driver.FindElement(By.CssSelector(lstTermType)).Click();
                    UIAction(lstTermType, "6 months", "a");
                    break;
            }
            if (producerCode.ToLower() != "")
            {
                UIAction(lnkProducerSearchIcon, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lblProducerCodeSearch), 10);
                UIAction(txtProducerCode, producerCode, "input");
                UIAction(btnSearch, string.Empty, "span");
                //UIAction(btnSelect, string.Empty, "span");
            }
            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (policyEffDate.Length > 1)
            {
                if (policyEffDate.ToLower().ToString() == "systemdate")
                {
                    DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                    tempDate = tempRetroDate.ToShortDateString();
                }
                else if (policyEffDate.ToLower() == "currentdate")
                {
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
                }
                else if (policyEffDate.Contains("+"))
                {
                    string[] details = policyEffDate.Split('+');
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

                }
                else if (policyEffDate.Contains("-"))
                {
                    string[] details = policyEffDate.Split('-');
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));

                }

                //UIAction(txtPolicyEffectiveDate, string.Empty, "a");
                //UIAction(txtPolicyEffectiveDate, tempDate, "textbox");
                js.ExecuteScript("document.getElementById('" + PolicyEffectiveDate + "').value='" + tempDate + "'");
                DateTime temSignDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
            }
        }

        public void EnterRewritePolicyInfoDetailsPC9(string termType, string policyEffDate, string producerCode)
        {
            System.Console.WriteLine("term type is " + termType);
            switch (termType.ToUpper().Trim())
            {
                case "ANNUAL":
                    driver.FindElement(By.CssSelector(lstTermType)).Click();
                    UIAction(lstTermType, "Annual", "textbox");
                    break;
                case "OTHER":
                    driver.FindElement(By.CssSelector(lstTermType)).Click();
                    UIAction(lstTermType, "Other", "textbox");
                    break;
                case "6 MONTHS":
                    driver.FindElement(By.CssSelector(lstTermType)).Click();
                    UIAction(lstTermType, "6 months", "textbox");
                    break;
            }
            if (producerCode.ToLower() != "")
            {
                UIAction(lnkProducerSearchIcon, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lblProducerCodeSearch), 10);
                UIAction(txtProducerCode, producerCode, "input");
                UIAction(btnSearch, string.Empty, "span");
                //UIAction(btnSelect, string.Empty, "span");
            }
            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (policyEffDate.Length > 1)
            {
                if (policyEffDate.ToLower().ToString() == "systemdate")
                {
                    DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                    tempDate = tempRetroDate.ToShortDateString();
                }
                else if (policyEffDate.ToLower() == "currentdate")
                {
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
                }
                else if (policyEffDate.Contains("+"))
                {
                    string[] details = policyEffDate.Split('+');
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

                }
                else if (policyEffDate.Contains("-"))
                {
                    string[] details = policyEffDate.Split('-');
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));

                }
                js.ExecuteScript("document.getElementById('" + PolicyRewriteEffectiveDate + "').value='" + tempDate + "'");
                //   DateTime temSignDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
            }
        }

    }
}

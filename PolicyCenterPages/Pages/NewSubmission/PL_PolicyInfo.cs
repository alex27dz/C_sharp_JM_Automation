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

namespace PolicyCenterPages.Pages.NewSubmission
{
   

    public class PL_PolicyInfo : Page
    {
        string btnNext = "a[id$=':Next']";
        string PolicyEffectiveDate = "SubmissionWizard:LOBWizardStepGroup:SubmissionWizard_PolicyInfoScreen:SubmissionWizard_PolicyInfoDV:PolicyInfoInputSet:EffectiveDate_date";
        string PolicyEffectiveDateRewrite = "RewriteWizard:LOBWizardStepGroup:RewriteWizard_PolicyInfoScreen:RewriteWizard_PolicyInfoDV:PolicyInfoInputSet:EffectiveDate_date";
        string lstTermType = "select[id$=':PolicyInfoInputSet:TermType']";
        string lnkProducerSearchIcon = "a[id$=':ProducerCodeInput:SelectProducerCode']";
        string txtProducerCode = "input[id$=':ProducerCodeSearchScreen:ProducerCodeSearchDV:Code']";
        string btnSearch = "span[id$=':SearchLinksInputSet:Search_link']";
        string btnSelect = "span[id$=':ProducerCodeSearchLV:0:_Select_link']";


        public PL_PolicyInfo(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void EnterPolicyInfo()
        {
            UIAction(btnNext, string.Empty , "a");
        }

        public void EnterPolicyInfoDetails(string termType, string policyEffDate, string producerCode)
        {
            if (termType.ToLower() == "annual")
            {
                UIAction(lstTermType, "Annual", "select");
            }
            else if (termType.ToLower() == "other")
            {
                UIAction(lstTermType, "Other", "select");
            }
            if (producerCode.ToLower() != "")
            {
                UIAction(lnkProducerSearchIcon, string.Empty, "a");
                UIAction(txtProducerCode, producerCode, "input");
                UIAction(btnSearch, string.Empty, "span");
                UIAction(btnSelect, string.Empty, "span");
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
                js.ExecuteScript("document.getElementById('" + PolicyEffectiveDate + "').value='" + tempDate + "'");
                DateTime temSignDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
            }

        }

        public void EnterPolicyInfoDetailsforRewrite(string termType, string policyEffDate, string producerCode)
        {
            if (termType.ToLower() == "annual")
            {
                UIAction(lstTermType, "Annual", "select");
            }
            else if (termType.ToLower() == "other")
            {
                UIAction(lstTermType, "Other", "select");
            }
            if (producerCode.ToLower() != "")
            {
                UIAction(lnkProducerSearchIcon, string.Empty, "a");
                UIAction(txtProducerCode, producerCode, "input");
                UIAction(btnSearch, string.Empty, "span");
                UIAction(btnSelect, string.Empty, "span");
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
                js.ExecuteScript("document.getElementById('" + PolicyEffectiveDateRewrite + "').value='" + tempDate + "'");
                DateTime temSignDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
            }

        }

    }
    
}

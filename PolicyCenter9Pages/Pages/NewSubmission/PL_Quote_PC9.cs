using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Data;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class PL_Quote_PC9 : Page
    {
        string lblQuote = "span[id$='_QuoteScreen:ttlBar']";
        string lbRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";

        string ClickReinstatePolicy = "span[id$=':ReinstatementWizard_QuoteScreen:JobWizardToolbarButtonSet:Reinstate-btnInnerEl']";
        string txtBillingMethod = "input[id$=':BillingAdjustmentsDV:BillingMethod-inputEl']";
        string ClickIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions']";
        string ClickIssuePolicyRewrite = "a[id$=':JobWizardToolbarButtonSet:BindRewrite']";

        string ClickIssueChangePolicy = "span[id$=':JobWizardToolbarButtonSet:BindPolicyChange-btnInnerEl']";
        string BindIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions:BindAndIssue-itemEl']";
        string RenewPolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions:SendToRenewal-itemEl']";
        string CancelPolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions:SubmitCancellation-itemEl']";

        string btnOK = "a[id='button-1005']";
        string lnkPlcy = "div[id$='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";
        string lnkRenew = "div[id$=':JobWizardToolbarButtonSet:BindOptions:SendToRenewal']";
        string lnkPlcyChange = "span[id$='JobComplete:JobCompleteScreen:ttlBar']";
        string tblInstallmentPlan = "div[id$=':InstallmentPlan:BillingAdjustmentsInstallmentsLV-body']";
        string policyNumber = "";
        string btnDetails = "a[id$=':DetailsButton']";
        string btnRiskApprovalDetailsok = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
        string viewYourPlcy = "view your policy (#";

        string selRenewalCode = "input[id$='_RenewalScreen:RenewalCode-inputEl']";

        string lblRenewalDataEntry = "span[text()[contains(.,'Renewal Data Entry')]]";
        string btnRenewalok = "span[id$=':Update-btnInnerEl']";


        public PL_Quote_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            WaitUntilElementVisible(driver, By.CssSelector(lblQuote), 420);
            VerifyUIElementIsDisplayed(lblQuote);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblQuote));
        }

        public void PLIssueRenewPolicy(string RenewCode)
        {
            driver.FindElement(By.CssSelector(ClickIssuePolicy)).Click();
            //  WaitUntilElementInvisible(driver, By.CssSelector(lnkRenew));
            driver.FindElement(By.CssSelector(RenewPolicy)).Click();
            WaitUntilElementInvisible(driver, By.CssSelector(lblRenewalDataEntry), 20);

            WaitUntilElementVisible(driver, By.CssSelector(selRenewalCode));
            driver.FindElement(By.CssSelector(selRenewalCode)).Clear();
            UIAction(selRenewalCode, RenewCode, "textbox");
            UIAction(btnRenewalok, String.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();


            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcyChange), 420);
            Console.WriteLine(driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text);
            if (driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text.EndsWith("is in the process of being renewed."))
            {
                Console.WriteLine("Policy Renewal is successfull");
            }
            else
            {
                Assert.Fail("Unable to bound Policy Renewal");
            }

        }

        public void PLIssueChangedPolicy()
        {
            driver.FindElement(By.CssSelector(ClickIssueChangePolicy)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();
            try
            {
                WaitUntilElementVisible(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"), 10);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Exception is " + e.Message);
            }

            bool uwIssues = IsElementPresent(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"));
            Console.WriteLine("Value of uwIssues is " + uwIssues);
            if (uwIssues)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnDetails), 30);
                UIAction(btnDetails, string.Empty, "a");

                IsElementPresent(driver, By.Id("PolicyChangeWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body"));
                List<IWebElement> reservetableObj = driver.FindElements(By.Id("PolicyChangeWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body")).ToList();
                Console.WriteLine("count of array for account " + reservetableObj.Count());
                var rows = reservetableObj[0].FindElements(By.TagName("tr"));
                Console.WriteLine("Row count is " + rows.Count());
                List<IWebElement> approveList = driver.FindElements(By.Id("PolicyChangeWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:1:UWIssueRowSet:Approve")).ToList();
                Console.WriteLine("Number of approve button is " + approveList.Count());
                for (int i = 1; i <= approveList.Count(); i++)
                {
                    WaitUntilElementVisible(driver, By.XPath("//a[text()='Approve']"), 60);
                    driver.FindElement(By.XPath("//a[text()='Approve']")).Click();
                    IsElementPresent(driver, By.Id("RiskApprovalDetailsPopup:Update-btnInnerEl"));
                    UIAction(btnRiskApprovalDetailsok, string.Empty, "a");
                }
                WaitUntilElementVisible(driver, By.CssSelector(ClickIssueChangePolicy), 60);
                driver.FindElement(By.CssSelector(ClickIssueChangePolicy)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                driver.FindElement(By.CssSelector(btnOK)).Click();
            }
            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcyChange), 420);
            Console.WriteLine(driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text);
            if (driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text.EndsWith("has been bound."))
            {
                Console.WriteLine("Policy Change Status: is true");
            }
            else
            {
                Assert.Fail("Unable to bound Policy Change");
            }
        }

        public void PLIssueCanceledPolicy()
        {
            driver.FindElement(By.CssSelector(ClickIssuePolicy)).Click();
            driver.FindElement(By.CssSelector(CancelPolicy)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcyChange), 420);
            Console.WriteLine(driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text);
            if ((driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text.Contains(") has been scheduled for ")) || (driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text.EndsWith(") has been bound.")))
            {
                Console.WriteLine("Policy Cancel is successfull");
            }
            else
            {
                Assert.Fail("Unable to bound Policy Cancel");
            }
        }

        public void PLRewritePolicy()
        {
            driver.FindElement(By.CssSelector(ClickIssuePolicyRewrite)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();
            try
            {
                WaitUntilElementVisible(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"), 30);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            bool uwIssues = IsElementPresent(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"));

            Console.WriteLine("Value of uwIssues is " + uwIssues);
            if (uwIssues)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnDetails), 30);
                UIAction(btnDetails, string.Empty, "a");

                IsElementPresent(driver, By.Id("RewriteWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body"));
                List<IWebElement> reservetableObj = driver.FindElements(By.Id("RewriteWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body")).ToList();
                Console.WriteLine("count of array for account " + reservetableObj.Count());
                var rows = reservetableObj[0].FindElements(By.TagName("tr"));
                Console.WriteLine("Row count is " + rows.Count());
                for (int i = 1; i <= rows.Count - 1; i++)
                {
                    try
                    {
                        Console.WriteLine("value of i is :" + i);
                        driver.FindElement(By.XPath("//a[text()='Approve']")).Click();
                        IsElementPresent(driver, By.Id("RiskApprovalDetailsPopup:Update-btnInnerEl"));
                        UIAction(btnRiskApprovalDetailsok, string.Empty, "a");
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }

                }
                WaitUntilElementVisible(driver, By.CssSelector(ClickIssuePolicyRewrite), 60);
                driver.FindElement(By.CssSelector(ClickIssuePolicyRewrite)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                driver.FindElement(By.CssSelector(btnOK)).Click();

            }

            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcyChange), 100);
            Console.WriteLine(driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text);
            if (driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text.EndsWith(") has been bound."))
            {
                Console.WriteLine("Policy Rewrite is successfull");
            }
            else
            {
                Assert.Fail("Unable to bound Policy Rewrite");
            }
        }

        public void PLReinstatePolicy()
        {
            // WaitUntilElementInvisible(driver, By.Id("ReinstatementWizard:ReinstatementWizard_QuoteScreen:ttlBar"),10);
            driver.FindElement(By.CssSelector(ClickReinstatePolicy)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcyChange), 420);
            Console.WriteLine(driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text);
            if ((driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text.Contains("Your Reinstatement (#")) && (driver.FindElement(By.Id("JobComplete:JobCompleteScreen:Message")).Text.EndsWith(") has been bound.")))
            {
                Console.WriteLine("Policy Reinstatement is successfull");
            }
            else
            {
                Assert.Fail("Unable to bound Policy Reinstate");
            }
        }

        public void PLIssuePolicy()
        {
            driver.FindElement(By.CssSelector(ClickIssuePolicy)).Click();
            WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy));
            driver.FindElement(By.CssSelector(BindIssuePolicy)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();
            WaitUntilElementVisible(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"), 30);
            bool uwIssues = IsElementPresent(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"));
            Console.WriteLine("Value of uwIssues is " + uwIssues);
            if (uwIssues)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnDetails), 30);
                UIAction(btnDetails, string.Empty, "a");

                IsElementPresent(driver, By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body"));
                List<IWebElement> reservetableObj = driver.FindElements(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body")).ToList();
                Console.WriteLine("count of array for account " + reservetableObj.Count());
                var rows = reservetableObj[0].FindElements(By.TagName("tr"));
                Console.WriteLine("Row count is " + rows.Count());
                for (int i = 1; i <= rows.Count - 1; i++)
                {
                    WaitUntilElementVisible(driver, By.XPath("//a[text()='Approve']"), 60);
                    driver.FindElement(By.XPath("//a[text()='Approve']")).Click();
                    IsElementPresent(driver, By.Id("RiskApprovalDetailsPopup:Update-btnInnerEl"));
                    UIAction(btnRiskApprovalDetailsok, string.Empty, "a");
                }
                WaitUntilElementVisible(driver, By.CssSelector(ClickIssuePolicy), 60);
                driver.FindElement(By.CssSelector(ClickIssuePolicy)).Click();
                WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy));
                driver.FindElement(By.CssSelector(BindIssuePolicy)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                driver.FindElement(By.CssSelector(btnOK)).Click();
            }

            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcy), 420);
            Console.WriteLine(driver.FindElement(By.CssSelector(lnkPlcy)).Text);
            if (driver.FindElement(By.CssSelector(lnkPlcy)).Text.ToLower().Trim().Contains(viewYourPlcy))
            {
                policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Substring(viewYourPlcy.Length, 10);
            }
            Console.WriteLine("Policy Number: " + policyNumber);
            ScenarioContext.Current["POLICY"] = policyNumber;

        }

        public void IsInQuotePage()
        {

        }
    }
}

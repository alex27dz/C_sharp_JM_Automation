using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;
using HelperClasses;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace PolicyCenter9Pages.Pages.JPA
{
    public class PolicyIssuePC9 : Page
    {

        string policyNumber = "";
        string txtBillingMethod = "input[id$=':BillingAdjustmentsDV:BillingMethod-inputEl']";
        string ClickIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions']";

        string ClickIssuePolicyChamgeJPA = "a[id$=':JobWizardToolbarButtonSet:BindPolicyChange']";
        string ClickIssuePolicyRewriteJPA = "a[id$=':JobWizardToolbarButtonSet:BindRewrite']";
        string BindIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions:BindAndIssue-itemEl']";
        string btnOK = "a[id='button-1005']";
        string lnkPlcy = "div[id$='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";
        string tblInstallmentPlan = "div[id$=':InstallmentPlan:BillingAdjustmentsInstallmentsLV-body']";
        // string btnDetails = "a[id='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton']";
        string lblPaymentscreen = "span[id$='_PaymentScreen:ttlBar']";
        string btnDetails = "a[id$=':DetailsButton']";
        string btnRiskApprovalDetailsok = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
        string viewYourPlcy = "view your policy (#";
        string policyInfo = "//span[text()='Policy Info']";
        string insuranceScore = "div[id$='PolicyFile_PolicyInfo:PolicyFile_PolicyInfoScreen:PolicyFile_PolicyInfoDV:InsuranceScore-inputEl'";
        public PolicyIssuePC9(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {

        }

        public void clickNextButton()
        {

        }


        public string VerifyActivities()
        {
            WaitUntilElementVisible(driver, By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body"));
            List<IWebElement> reservetableObj = driver.FindElements(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body")).ToList();
            Console.WriteLine("count of array for account " + reservetableObj.Count());
            var table = reservetableObj[0].FindElements(By.TagName("table"));

            Console.WriteLine("Row count is " + table.Count());
            string ActivityList = "";
            for (int i = 1; i <= table.Count - 1; i++)
            {
                var tds = table[i].FindElements(By.TagName("td"));
                Console.WriteLine("Tds count is " + tds.Count() + " for counter " + i);
                var data = tds[1].FindElements(By.TagName("div"));
                Console.WriteLine("data is " + data[0].Text + " for counter " + i);
                ActivityList = ActivityList + ";" + data[0].Text;
            }
            ActivityList = ActivityList.Substring(1, ActivityList.Length - 1);
            Console.WriteLine("actualActvities are " + ActivityList);
            return ActivityList;
        }

        public void PLIssueChangePolicy_JPA()
        {
            string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
            string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
            string lblRiskApproveDetails = "span[id$='RiskApprovalDetailsPopup:ttlBar']";
            string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
            string lblIssuesThatBlock = "span[id$='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton-btnInnerEl']";


            Console.WriteLine("Click on issue policy");
            driver.FindElement(By.CssSelector(ClickIssuePolicyChamgeJPA)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK), 30);
            driver.FindElement(By.CssSelector(btnOK)).Click();
            //  WaitUntilElementVisible(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"), 30);
            //    bool uwIssues = false;
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(lblIssuesThatBlock), 10);
                //Console.WriteLine("Value of uwIssues is " + uwIssues);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught: " + e);
            }
            Console.WriteLine("before boolan true");
            if (IsElementPresent(driver, By.CssSelector(lblIssuesThatBlock)) == true)
            {
                Console.WriteLine("button issue");
                WaitUntilElementVisible(driver, By.CssSelector(btnDetails), 100);
                UIAction(btnDetails, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
                int BtnTotAppr = driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
                Console.WriteLine("Total Approve Btns: " + BtnTotAppr);
                for (int i = 1; i <= BtnTotAppr; i++)
                {
                    //    btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
                    driver.FindElement(By.CssSelector(btnSplApprove)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                    driver.FindElement(By.CssSelector(btnOK)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(lblRiskApproveDetails));
                    driver.FindElement(By.CssSelector(btnRAOK)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
                }


                driver.FindElement(By.CssSelector(ClickIssuePolicyChamgeJPA)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(btnOK), 30);
                driver.FindElement(By.CssSelector(btnOK)).Click();

            }
            Console.WriteLine("After boolan true");
            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcy), 420);
            Console.WriteLine(driver.FindElement(By.CssSelector(lnkPlcy)).Text);
            if (driver.FindElement(By.CssSelector(lnkPlcy)).Text.ToLower().Trim().Contains(viewYourPlcy))
            {
                policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");
            }
            Console.WriteLine("Policy Number: " + policyNumber);
            ScenarioContext.Current["POLICY"] = policyNumber;


        }
        public void PLIssuePolicy_JPA()
        {


            string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
            string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
            string lblRiskApproveDetails = "span[id$='RiskApprovalDetailsPopup:ttlBar']";
            string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
            string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";
            string LeftLnkRiskAnalysis = "td[id$='SubmissionWizard:RiskAnalysis']";
            string tabFraudwarning = "span[id$=':RiskAnalysisCV:FraudWarningidTab-btnInnerEl']";
            string radioJMApplication = "input[id$=':RiskAnalysisCV:ApplicationStatementId_true-inputEl']";
            string tabUWIssues = "span[id$=':RiskAnalysisCV:EvaluationIssuesCardTab-btnInnerEl']";



            driver.FindElement(By.CssSelector(ClickIssuePolicy)).Click();
            WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy), 30);

            driver.FindElement(By.CssSelector(BindIssuePolicy)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK), 600);
            driver.FindElement(By.CssSelector(btnOK)).Click();

            WaitUntilElementVisible(driver, By.CssSelector(btnClear));
            driver.FindElement(By.CssSelector(btnClear)).Click();
            UIActionExt(By.CssSelector(LeftLnkRiskAnalysis), "ispresent");
            UIActionExt(By.CssSelector(LeftLnkRiskAnalysis), "click");
            UIActionExt(By.CssSelector(tabFraudwarning), "ispresent");
            UIActionExt(By.CssSelector(tabFraudwarning), "click");
            UIActionExt(By.CssSelector(radioJMApplication), "ispresent");
            UIActionExt(By.CssSelector(radioJMApplication), "click");
            UIActionExt(By.CssSelector(tabUWIssues), "ispresent");
            UIActionExt(By.CssSelector(tabUWIssues), "click");
            UIActionExt(By.CssSelector(ClickIssuePolicy), "ispresent");
            driver.FindElement(By.CssSelector(ClickIssuePolicy)).Click();
            WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy), 30);

            driver.FindElement(By.CssSelector(BindIssuePolicy)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK), 600);
            driver.FindElement(By.CssSelector(btnOK)).Click();
            WaitUntilElementVisible(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"), 30);
            bool uwIssues = IsElementPresent(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"));
            Console.WriteLine("Value of uwIssues is " + uwIssues);
            if (uwIssues)
            {

                WaitUntilElementVisible(driver, By.CssSelector(btnDetails), 30);
                UIAction(btnDetails, string.Empty, "a");

                WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
                int BtnTotAppr = driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
                Console.WriteLine("Total Approve Btns: " + BtnTotAppr);
                for (int i = 1; i <= BtnTotAppr; i++)
                {
                    btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
                    driver.FindElement(By.CssSelector(btnSplApprove)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                    driver.FindElement(By.CssSelector(btnOK)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(lblRiskApproveDetails));
                    driver.FindElement(By.CssSelector(btnRAOK)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
                }


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
                policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");
            }
            Console.WriteLine("Policy Number: " + policyNumber);
            ScenarioContext.Current["POLICY"] = policyNumber;




        }

        public void PLIssueRewritePolicy_JPA()
        {
            string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
            string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
            string lblRiskApproveDetails = "span[id$='RiskApprovalDetailsPopup:ttlBar']";
            string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
            string lblIssuesThatBlock = "span[id$='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton-btnInnerEl']";


            Console.WriteLine("Click on issue policy");
            driver.FindElement(By.CssSelector(ClickIssuePolicyRewriteJPA)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK), 600);
            driver.FindElement(By.CssSelector(btnOK)).Click();
            //  WaitUntilElementVisible(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"), 30);
            //    bool uwIssues = false;
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(lblIssuesThatBlock), 5);
                //Console.WriteLine("Value of uwIssues is " + uwIssues);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught: " + e);
            }
            Console.WriteLine("before boolan true");
            if (IsElementPresent(driver, By.CssSelector(lblIssuesThatBlock)) == true)
            {

                WaitUntilElementVisible(driver, By.CssSelector(btnDetails), 1000);
                UIAction(btnDetails, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
                int BtnTotAppr = driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
                Console.WriteLine("Total Approve Btns: " + BtnTotAppr);
                for (int i = 1; i <= BtnTotAppr; i++)
                {
                    //    btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
                    driver.FindElement(By.CssSelector(btnSplApprove)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                    driver.FindElement(By.CssSelector(btnOK)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(lblRiskApproveDetails));
                    driver.FindElement(By.CssSelector(btnRAOK)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
                }


                driver.FindElement(By.CssSelector(ClickIssuePolicyRewriteJPA)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(btnOK), 30);
                driver.FindElement(By.CssSelector(btnOK)).Click();

            }
            Console.WriteLine("After boolan true");
            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcy), 420);
            Console.WriteLine(driver.FindElement(By.CssSelector(lnkPlcy)).Text);
            if (driver.FindElement(By.CssSelector(lnkPlcy)).Text.ToLower().Trim().Contains(viewYourPlcy))
            {
                policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");
            }
            Console.WriteLine("Policy Number: " + policyNumber);
            ScenarioContext.Current["POLICY"] = policyNumber;

        }

        public void verifyInsuranceScore(string score)
        {
            DataStorage temp = new DataStorage();
            string state = temp.GetTempValue("BASE_STATE");
            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcy), 420);
            driver.FindElement(By.CssSelector(lnkPlcy)).Click();
            WaitUntilElementVisible(driver, By.XPath(policyInfo), 30);
            driver.FindElement(By.XPath(policyInfo)).Click();
            if (IsElementPresent(driver, By.CssSelector(insuranceScore)))
            {
                string insuranceScoreText = driver.FindElement(By.CssSelector(insuranceScore)).Text;
                Assert.AreEqual(insuranceScoreText, score);
            }
            else if (state == "California" || state == "Hawaii" || state == "Massachusetts" || state == "Maryland")
            {
                Console.WriteLine(state + " is one of CA, HI, MD and MA, therefore, no credit check is performed.");
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine("Insurance score is empty and the state is not one of CA,HI, MD and MA.");
                Assert.IsFalse(true);
            }
        }

        public void selectDeclineReason(string reasons)
        {
            string btnCLoseOptions = "span[id$=':CloseOptions-btnInnerEl']";
            string btnDeclineOption = "span[id$=':CloseOptions:Decline-textEl']";
            string titleSubmissionDecline = "span[id='DeclineReasonPopup:RejectScreen:ttlBar']";
            string reasonOptions = "input[id$=':RejectReason-inputEl']";
            string btnDecline = "span[id='DeclineReasonPopup:RejectScreen:Update-btnInnerEl']";
            string lnkPolicy = "div[id='JobComplete:JobCompleteScreen:JobCompleteDV:ViewJob-inputEl']";
            string lnkViewPolicy = "div[id='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";
            string txtRejectReason = "textarea[id$=':RejectReasonText-inputEl']";
            driver.FindElement(By.CssSelector(btnCLoseOptions)).Click(); ;
            WaitUntilElementVisible(driver, By.CssSelector(btnDeclineOption), 5);
            UIAction(btnDeclineOption, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(titleSubmissionDecline), 5);
            Console.WriteLine("Reason of decline: " + reasons);
            int reasonID = 0;
            string[] reasonList = reasons.Split(';');
            //UIAction(CheckboxID, string.Empty, "radio");        
            foreach (string reason in reasonList)
            {
                if (reason.Trim().ToLower() == "other" || reason.Trim().ToLower().Contains("other"))
                {
                    reasonID = reason.Trim().ToLower().Contains("jpa") ? 6:5;
                }
                else if (reason.Trim().ToLower() == "loss history")
                {
                    reasonID = reason.Trim().ToLower().Contains("jpa") ? 4:3;
                }
                else if (reason.Trim().ToLower() == "nature of the item/schedule")
                {
                    reasonID = reason.Trim().ToLower().Contains("jpa") ? 5:4;
                }
                else if (reason.Trim().ToLower() == "level of security")
                {
                    reasonID = 2;
                }
                else if (reason.Trim().ToLower() == "travel risk")
                {
                    reasonID = reason.Trim().ToLower().Contains("jpa") ? 8:7;
                }
                else if (reason.Trim().ToLower() == "credit")
                {
                    reasonID = 0;
                }
                else if (reason.Trim().ToLower() == "criminal record")
                {
                    reasonID = 1;
                }
                string reasonOption = "input[id$=':RejectReasonPL_option" + reasonID + "-inputEl']";
                Console.WriteLine("reasonOption: " + reasonOption);
                JavaScriptClick(driver.FindElement(By.CssSelector(reasonOption)));
            }

            if (!reasons.Trim().ToLower().Contains(":checktext"))
            {
                UIActionExt(By.CssSelector(txtRejectReason), "Text", "This is a test");
                UIAction(btnDecline, string.Empty, "span");
                Thread.Sleep(3000);
                if (IsElementPresent(driver, By.CssSelector(lnkPolicy))
                    || IsElementPresent(driver, By.CssSelector(lnkViewPolicy)))
                {
                    Console.WriteLine("Declined Successfully");
                }
                else
                {
                    Assert.IsFalse(true);
                }
            }

            //UIActionExt(By.CssSelector(lnkPolicy), "ispresent", "", 0, 5, 5);
        }

        public void clickDeclineButton()
        {
            string btnDecline = "span[id='DeclineReasonPopup:RejectScreen:Update-btnInnerEl']";
            JavaScriptClick(driver.FindElement(By.CssSelector(btnDecline)));
        }

        public void verifyErrorMessage(String errorMessage)
        {
            string eMessageXpath = "//div[contains(.,'Missing required field')]";
            if (driver.FindElement(By.XPath(eMessageXpath)).Text.Contains(errorMessage))
            {
                Console.WriteLine("Reason Text is requires");
            }
            else
            {
                Assert.Fail("Reason Text field cannot be empty when \'Other\' is selected as Reason");
            }
        }

    }

}

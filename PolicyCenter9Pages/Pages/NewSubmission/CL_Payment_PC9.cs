
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class CL_Payment_PC9 : Page
    {
        string policyNumber = "";
        string txtBillingMethod = "input[id$=':BillingAdjustmentsDV:BillingMethod-inputEl']";
        string ClickIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions']";
        string BindIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions:BindAndIssue-itemEl']";
        string btnOK = "a[id='button-1005']";
        string lnkPlcy = "div[id$='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";
        string tblInstallmentPlan = "div[id$=':InstallmentPlan:BillingAdjustmentsInstallmentsLV-body']";
        // string btnDetails = "a[id='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton']";
        string lblPaymentscreen = "span[id$='_PaymentScreen:ttlBar']";
        string btnDetails = "a[id$=':DetailsButton']";
        string btnRiskApprovalDetailsok = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
        string viewYourPlcy = "view your policy (#";



        public void EnterPaymentDetails(Table table)
        {
            WaitUntilElementVisible(driver, By.CssSelector(lblPaymentscreen), 10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            if (table.Rows[0]["BilingMethod"].ToLower() == "list bill")
            {
                driver.FindElement(By.CssSelector(txtBillingMethod)).Clear();
                driver.FindElement(By.CssSelector(txtBillingMethod)).SendKeys(table.Rows[0]["BilingMethod"]);
                driver.FindElement(By.CssSelector(txtBillingMethod)).SendKeys(Keys.Tab);
            }
            IWebElement ObjInstallmentPlan = driver.FindElement(By.CssSelector(tblInstallmentPlan));
            string datarecordindex = "";
            switch (table.Rows[0]["InstallmentPlan"].ToUpper().Trim())
            {
                case "12 PAY":
                    datarecordindex = "0";
                    break;
                case "2 PAY":
                case "2 PAY - SEMI ANNUALLY":
                    datarecordindex = "1";
                    break;
                case "4 PAY":
                case "4 PAY - QUARTERLY":
                    datarecordindex = "2";
                    break;
                case "8 PAY":
                case "9 PAY - 12% RENEWAL":
                    datarecordindex = "3";
                    break;               
                case "ANNUAL PAY":
                    datarecordindex = "4";
                    break;
                default:
                    Console.WriteLine(table.Rows[0]["InstallmentPlan"] + " , installment plan not recognized");
                    Assert.Fail("Please verify installment plan");
                    break;
            }
            string paymentxPath = "//table[@data-recordindex='" + datarecordindex + "']//td[1]//div[1]//div[1]";
            driver.FindElement(By.XPath(paymentxPath)).Click();
            WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(paymentxPath)));
            driver.FindElement(By.XPath(paymentxPath)).SendKeys(Keys.Space);
            WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy));
            WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(paymentxPath)));
            if (IsElementPresent(driver, By.CssSelector(ClickIssuePolicy)) == false)
            {
                WaitUntilElementVisible(driver, By.CssSelector(ClickIssuePolicy));
            }

        }
        public void CLIssuePolicy_ST()
        {
            string btnquote = "span[id$=':QuoteOrReview-btnInnerEl']";
            string lblIssuesThatBlock = "span[id$='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton-btnInnerEl']";
            string btnDetails = "span[id$=':DetailsButton-btnInnerEl']";
            string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
            string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
            string lblRiskApproveDetails = "span[id$='RiskApprovalDetailsPopup:ttlBar']";
            string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";

            WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy));
            driver.FindElement(By.CssSelector(ClickIssuePolicy)).Click();
            WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy));
            driver.FindElement(By.CssSelector(BindIssuePolicy)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();

            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(lblIssuesThatBlock), 5);
                driver.FindElement(By.CssSelector(btnDetails)).Click();
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
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught: " + e);
            }


            WaitUntilElementVisible(driver, By.CssSelector(lnkPlcy), 420);
            Console.WriteLine(driver.FindElement(By.CssSelector(lnkPlcy)).Text);
            policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");
            Console.WriteLine("Policy Number: " + policyNumber);
            ScenarioContext.Current["POLICY"] = policyNumber;
        }


        public void PLQuotePolicy_ST()
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
                for (int i = 1; i <= rows.Count + 1; i++)
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

                    try
                    {
                        Console.WriteLine("value of i is :" + i);
                        driver.FindElement(By.XPath("//a[text()='Special Approve']")).Click();
                        WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                        driver.FindElement(By.CssSelector(btnOK)).Click();
                        IsElementPresent(driver, By.Id("RiskApprovalDetailsPopup:Update-btnInnerEl"));
                        UIAction(btnRiskApprovalDetailsok, string.Empty, "a");
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                }

                //WaitUntilElementVisible(driver, By.CssSelector(ClickIssuePolicy), 60);
                //driver.FindElement(By.CssSelector(ClickIssuePolicy)).Click();
                //WaitUntilElementInvisible(driver, By.CssSelector(lnkPlcy));
                //driver.FindElement(By.CssSelector(BindIssuePolicy)).Click();
                //WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                //driver.FindElement(By.CssSelector(btnOK)).Click();

            }
            //WaitUntilElementVisible(driver, By.CssSelector(lnkPlcy), 420);
            //Console.WriteLine(driver.FindElement(By.CssSelector(lnkPlcy)).Text);
            //if (driver.FindElement(By.CssSelector(lnkPlcy)).Text.ToLower().Trim().Contains(viewYourPlcy))
            //{
            //    policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");

            //}
            //Console.WriteLine("Policy Number: " + policyNumber);
            //ScenarioContext.Current["POLICY"] = policyNumber;



        }

        public void PLIssuePolicy_ST()
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
                for (int i = 1; i <= rows.Count + 1; i++)
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

                    try
                    {
                        Console.WriteLine("value of i is :" + i);
                        driver.FindElement(By.XPath("//a[text()='Special Approve']")).Click();
                        WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                        driver.FindElement(By.CssSelector(btnOK)).Click();
                        IsElementPresent(driver, By.Id("RiskApprovalDetailsPopup:Update-btnInnerEl"));
                        UIAction(btnRiskApprovalDetailsok, string.Empty, "a");
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
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
                policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");

            }
            Console.WriteLine("Policy Number: " + policyNumber);
            ScenarioContext.Current["POLICY"] = policyNumber;



        }

        public CL_Payment_PC9(IWebDriver driver) : base(driver)
        {
        }
        public override void VerifyPage()
        {
        }
        public override void WaitForLoad()
        {
        }
    }
}



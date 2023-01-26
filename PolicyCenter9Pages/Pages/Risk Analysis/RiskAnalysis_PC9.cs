using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.Risk_Analysis
{
    public class RiskAnalysis_PC9 : Page
    {
        private const string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";

        private const string tabConviction = "a[id$=':RiskAnalysisCV:ConvictionsTab']";
        private const string lblPriorConviction = "label[id$=':JPARiskAnalysisPanelSet:RiskAnalysisCV:ConvictionsDV:0']";

        private const string radioCaonvictedOfFelonyTrue = "input[id$=':ConvictionsDV:ConvictedOfFelony_Input_true-inputEl']";
        private const string radioCaonvictedOfFelonyFalse = "input[id$=':ConvictionsDV:ConvictedOfFelony_Input_false-inputEl']";
        private const string radioCaonvictedOfMisdemeanorTrue = "input[id$=':ConvictionsDV:ConvictedOfMisdemeanor_Input_true-inputEl']";
        private const string radioCaonvictedOfMisdemeanorFalse = "input[id$=':ConvictionsDV:ConvictedOfMisdemeanor_Input_false-inputEl']";
        private const string btnAddSentence = "span[id$=':ConvictionsDV:ConvictionsPanelLV_tb:Add']";

        private const string txtSentenceDate = "input[name='SenetenceDate'] ";
        private const string txtConvictionTyoe = "input[name='ConvictionType_JMIC'] ";

        //for Misdermeanor and Sherlock
        private const string blockingBindBodyXpath = "div[id$=':RiskEvaluationPanelSet:0-body']";
        private const string vendorReportBodyXpath = "div[id$=':RiskAnalysisConvictionsDV:1-body']";
        private const string manullyReportBodyXpath = "div[id$=':RiskAnalysisConvictionsDV:0-body']";
        private const string convictionTabXpath = "span[id$=':ConvictionsTab-btnInnerEl']";
        //string policyChangeBtnQuoteXpath = "//*[@id=':QuoteOrReview-btnInnerEl']";
        private const string policyChangeBtnQuoteXpath = "span[id$=':QuoteOrReview-btnInnerEl']";

        private const string specialApproveButtonCSS = "a[id$='UWIssueRowSet:SpecialApprove']";
        private const string approveBoxOkButtonXPath = "//div[contains(@id, 'messagebox')]/a[contains(.//span, 'OK')]";
        private const string riskApprovalDetailsOkButtonCSS = "span[id='RiskApprovalDetailsPopup:Update-btnInnerEl']";
        private const string releaseLockButtonCSS = "span[id$='JobWizardToolbarButtonSet:Unlock-btnInnerEl']";

        public RiskAnalysis_PC9(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblRiskAnalysis);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblRiskAnalysis));
        }

        public string VerifyActivities()
        {
            List<IWebElement> reservetableObj = driver.FindElements(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:0-body")).ToList();
            Console.WriteLine("count of array for account " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            string ActivityList = "";
            for (int i = 1; i <= rows.Count - 1; i++)
            {
                try
                {
                    ActivityList = ActivityList + ";" + driver.FindElement(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:RiskEvaluationPanelSet:" + i + ":UWIssueRowSet:ShortDescription")).Text;

                }
                catch(Exception e)
                {
                    Console.WriteLine("Issue for SU user" + e.Message);
                }

                try
                {
                    var td = rows[i].FindElements(By.TagName("td"));
                    var data = td[1].FindElements(By.TagName("div"));
                    ActivityList = ActivityList + ";" + data[0].Text;

                }
                catch (Exception e1)
                {
                    Console.WriteLine("Issue for Non SU user" + e1.Message);
                }

            }
            ActivityList = ActivityList.Substring(1, ActivityList.Length - 1);
            char[] delimiterChars = { ';' };
            string[] actualActivities = ActivityList.Split(delimiterChars);
            if (actualActivities.Distinct().Count() == 1)
                return actualActivities[0];
            else
                return ActivityList;
        }

        public void UpdateConvictionDetailsPC9(string ConvictedFelony, string ConvictedMisdemeanor)
        {
            UIAction(tabConviction, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lblPriorConviction), 2);
            if (ConvictedFelony.ToLower().Equals("no"))
            {
                UIAction(radioCaonvictedOfFelonyFalse, string.Empty, "a");
            }
            else if (ConvictedFelony.ToLower().Equals("yes"))
            {
                UIAction(radioCaonvictedOfFelonyTrue, string.Empty, "a");
            }

            if (ConvictedMisdemeanor.ToLower().Equals("no"))
            {
                UIAction(radioCaonvictedOfMisdemeanorFalse, string.Empty, "a");
            }
            else if (ConvictedMisdemeanor.ToLower().Equals("yes"))
            {
                UIAction(radioCaonvictedOfMisdemeanorTrue, string.Empty, "a");
            }

        }

        public void UpdateSentenceCompilationDetailsPC9(string SentenceCompilationDate, string ConvictionType, string OtherConvictionType, int Itemcounter)
        {
            driver.FindElement(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:ConvictionsDV:ConvictionsPanelLV_tb:Add-btnInnerEl")).Click();
            pause();
            System.Console.WriteLine("SentenceCompilationDate is " + SentenceCompilationDate);
            System.Console.WriteLine("ConvictionType is " + ConvictionType);
            System.Console.WriteLine("OtherConvictionType is " + OtherConvictionType);
            OffPermiseCoverage(1, 2, 1);
            UIAction(txtSentenceDate, SentenceCompilationDate, "textbox");
            OffPermiseCoverage(1, 3, 1);
            UIAction(txtConvictionTyoe, String.Empty, "a");
            UIAction(txtConvictionTyoe, ConvictionType, "textbox");
            OffPermiseCoverage(1, 4, 1);
            IWebElement txtareaText = driver.FindElement(By.XPath("//textarea[@name='OtherConvictionType']"));
            txtareaText.SendKeys(OtherConvictionType);

        }

        public void OffPermiseCoverage(int RowCount, int coloumnCount, int tableCount)
        {
            string Tableid = "SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:ConvictionsDV:ConvictionsPanelLV-body";
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id(Tableid)).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[tableCount - 1].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[RowCount - 1].FindElements(By.TagName("td"));
            tds[coloumnCount - 1].Click();

        }

        public void VerifyUWRuleIsBlockingBind(string rule)
        {
            string ruleName = rule.Trim();
            string ruleNum = "1";
            string check = "whatever";
            if (rule.Contains(":"))
            {
                ruleName = rule.Split(':')[0].Trim();
                ruleNum = rule.Split(':')[1].Trim();
                check = rule.Split(':')[2].Trim();
            }
            
            int ruleOccurNum = Int32.Parse(ruleNum);
            Console.WriteLine("rulename: " + ruleName + "  ruleOccurNum: " + ruleOccurNum + " check: " + check);

            IWebElement blockBindBody = driver.FindElement(By.CssSelector(blockingBindBodyXpath));
            List<IWebElement> tableElements = new List<IWebElement>(blockBindBody.FindElements(By.TagName("table")));
            Console.WriteLine(" tableElements Count " + tableElements.Count());
            int found = 0;
            for (int i = 0; i < tableElements.Count(); i++)
            {
                Console.WriteLine(i + " === " + tableElements[i].Text);
                string lineText = tableElements[i].Text;

                if (lineText.Trim().ToLower().Contains(ruleName.ToLower()))
                {                
                    found++;
                }
            }
            Console.WriteLine("found " + ruleName+ " rule is triggered: "+ found + " times");
            if (check.Equals("occurrence"))
            {
                if (found != ruleOccurNum)
                {
                    Assert.Fail(ruleName + " shuld be triggered " + ruleOccurNum + " times, but now it is triggered " + found + " times");
                }
            }
            else
            {             
                if (found == 0)
                {
                    Assert.Fail(ruleName + " is not triggered");
                }
            }
        }

        public void VerifyNoUWRuleIsBlockingBind(string rule)
        {
            IWebElement blockBindBody = driver.FindElement(By.CssSelector(blockingBindBodyXpath));
            List<IWebElement> tableElements = new List<IWebElement>(blockBindBody.FindElements(By.TagName("table")));
            Console.WriteLine(" tableElements Count " + tableElements.Count());
            bool found = false;
            for (int i = 0; i < tableElements.Count(); i++)
            {
                Console.WriteLine(i + " === " + tableElements[i].Text);
                string lineText = tableElements[i].Text;

                if (lineText.Trim().ToLower().Contains(rule.ToLower()))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Assert.Fail(rule + " is triggered");
            }
        }

        public void VerifyConvictedInRecentYears(int years, string manuallyOrVendor)
        {
            IWebElement vendorReportBody;
            if (manuallyOrVendor.ToLower().Equals("manually"))
            {
                vendorReportBody = driver.FindElement(By.CssSelector(manullyReportBodyXpath));
            }
            else
            {
                vendorReportBody = driver.FindElement(By.CssSelector(vendorReportBodyXpath));
            }
            List<IWebElement> tableElements = new List<IWebElement>(vendorReportBody.FindElements(By.TagName("table")));
            Console.WriteLine(" tableElements Count " + tableElements.Count());
            bool found = false;
            for (int i = 0; i < tableElements.Count(); i++)
            {
                Console.WriteLine(i + " === " + tableElements[i].Text);
                List<IWebElement> report = new List<IWebElement>(tableElements[i].FindElements(By.TagName("td")));
               
                string[] dateArr;
                if (manuallyOrVendor.ToLower().Equals("manually"))
                {
                    dateArr = report[3].Text.Split('/');
                }
                else
                {
                    dateArr = report[4].Text.Split('/');
                }

                DateTime mydate = new DateTime(Int32.Parse(dateArr[2]), Int32.Parse(dateArr[0]), Int32.Parse(dateArr[1]));
                DateTime today = DateTime.Now.Date;
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan span = today - mydate;

                // Because we start at year 1 for the Gregorian calendar, we must subtract a year here.
                int yearOfRecord = (zeroTime + span).Year - 1;
                Console.WriteLine("yearOfRecord: " + yearOfRecord);

                if (yearOfRecord <= years)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Assert.Fail("Not found convicted record in recent " + years + " years");
            }
        }

        public void VerifyNoConvictedInRecentYears(int years, string manuallyOrVendor)
        {
            IWebElement vendorReportBody;
            if (manuallyOrVendor.ToLower().Equals("manually"))
            {
                vendorReportBody = driver.FindElement(By.CssSelector(manullyReportBodyXpath));
            }
            else
            {
                vendorReportBody = driver.FindElement(By.CssSelector(vendorReportBodyXpath));
            }
            List<IWebElement> tableElements = new List<IWebElement>(vendorReportBody.FindElements(By.TagName("table")));
            Console.WriteLine(" tableElements Count " + tableElements.Count());
            bool found = false;
            if (tableElements.Count() > 0)
            {
                for (int i = 0; i < tableElements.Count(); i++)
                {
                    Console.WriteLine(i + " === " + tableElements[i].Text);
                    string lineText = tableElements[i].Text;
                    List<IWebElement> report = new List<IWebElement>(tableElements[i].FindElements(By.TagName("td")));

                    string[] dateArr;
                    if (manuallyOrVendor.ToLower().Equals("manually"))
                    {
                        dateArr = report[3].Text.Split('/');
                    }
                    else
                    {
                        dateArr = report[4].Text.Split('/');
                    }
                    Console.WriteLine("mydate: " + Int32.Parse(dateArr[2]) + ", " + Int32.Parse(dateArr[0]) + ", " + Int32.Parse(dateArr[1]));
                    DateTime mydate = new DateTime(Int32.Parse(dateArr[2]), Int32.Parse(dateArr[0]), Int32.Parse(dateArr[1]));
                    DateTime today = DateTime.Now.Date;
                    DateTime zeroTime = new DateTime(1, 1, 1);
                    TimeSpan span = today - mydate;

                    // Because we start at year 1 for the Gregorian calendar, we must subtract a year here.
                    int yearOfRecord = (zeroTime + span).Year - 1;
                    Console.WriteLine("yearOfRecord: " + yearOfRecord);

                    if (yearOfRecord <= years)
                    {
                        found = true;
                        break;
                    }
                }
            }
            if (found)
            {
                Assert.Fail("Found convicted record in recent " + years + " years");
            }
        }


        public void ClickConvictionTab()
        {
            WaitFor(driver.FindElement(By.CssSelector(convictionTabXpath))).Click();
        }
        public void ClickOnQuote()
        {
            WaitFor(driver.FindElement(By.CssSelector(policyChangeBtnQuoteXpath))).Click();
        }

        public void SpecialApproveAllUWRules()
        {
            var specialApproveButtons = driver.FindElements(By.CssSelector(specialApproveButtonCSS));
            
            while (specialApproveButtons.Count() > 0)
            {
                specialApproveButtons[0].Click();

                WaitUntilElementEnabled(driver, By.XPath(approveBoxOkButtonXPath), 30);
                driver.FindElement(By.XPath(approveBoxOkButtonXPath)).Click();

                WaitUntilElementEnabled(driver, By.CssSelector(riskApprovalDetailsOkButtonCSS), 30);
                driver.FindElement(By.CssSelector(riskApprovalDetailsOkButtonCSS)).Click();

                specialApproveButtons = driver.FindElements(By.CssSelector(specialApproveButtonCSS));
            }
        }

        public void ClickReleaseLockButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(releaseLockButtonCSS), 30);
            driver.FindElement(By.CssSelector(releaseLockButtonCSS)).Click();
        }
    }
}

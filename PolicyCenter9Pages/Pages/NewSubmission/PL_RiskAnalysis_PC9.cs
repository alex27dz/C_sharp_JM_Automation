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
using WebCommonCore;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class PL_RiskAnalysis_PC9 : Page
    {
        string btnNext = "span[id$=':Next-btnInnerEl']";
        string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";

        public PL_RiskAnalysis_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblRiskAnalysis);
        }
        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblRiskAnalysis));
        }

        public void CLickNextonReviewPC9()
        {
            //AddLossHistoryType();
            string lblPolicyReviewTitle = "span[text()[contains(.,'Policy Review')]]";
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.XPath("//span[text()[contains(.,'Policy Review')]]"), 20);
        }

        public void CLickNextonReviewPC9forRenewal()
        {
            string lblPolicyReviewTitle = "span[id$='_DifferencesScreen:ttlBar']";
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblPolicyReviewTitle));
        }
        public void AddLossHistoryType()
        {
            //click Loss history
            Console.WriteLine("Click Prior Loss");
            driver.FindElement(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:LossHistoryCardTab-btnInnerEl")).Click();
            System.Threading.Thread.Sleep(3000);
            string historyType = "input[id$=':LossHistoryType-inputEl']";
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(historyType), 15);
            }
            catch (Exception e)
            {
                Console.WriteLine("Known Exception: " + e);
            }
            if (IsElementPresent(driver, By.CssSelector(historyType + "[value='Please Select']")))
            {
                UIActionExt(By.CssSelector(historyType), "Text", " ");
                UIActionExt(By.CssSelector(historyType), "List", "No Loss History");
            }
        }
    }
}

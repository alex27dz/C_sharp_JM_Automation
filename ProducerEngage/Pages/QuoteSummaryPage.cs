using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class QuoteSummaryPage : Page
    {
        private const string summaryTileCSS = "div[tile-title='Summary']";
        private const string accountNameLinkCSS = "a[ui-sref*='accountNumber']";
        private const string headerTextCSS = "h1 ng-transclude span";
        private const string continueQuoteButtonCSS = "button[ng-if='canContinue']";

        public QuoteSummaryPage(IWebDriver driver) : base(driver) { }

        public override void VerifyPage()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(summaryTileCSS));
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver, 180);
        }

        public void ExtractAccountNumber()
        {
            var retryLimit = 3;

            while (retryLimit > 0)
            {
                try
                {
                    WaitUntilElementEnabled(driver, By.CssSelector(accountNameLinkCSS), 30);
                    var href = driver.FindElement(By.CssSelector(accountNameLinkCSS)).GetAttribute("href");
                    var hrefContents = href.Split('/');

                    var accountNumber = hrefContents[hrefContents.Length - 2];
                    ScenarioContext.Current["AccountNumber"] = accountNumber;
                    Console.WriteLine(string.Format("Account Number: '{0}'", accountNumber));

                    break;
                }
                catch (StaleElementReferenceException ex)
                {
                    retryLimit--;
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void ExtractSubmissionNumber()
        {
            WaitUntilElementVisible(driver, By.CssSelector(headerTextCSS), 30);
            var headerText = driver.FindElement(By.CssSelector(headerTextCSS)).Text;

            var submissionNumber = headerText.Split('(', ')')[1];
            ScenarioContext.Current["SubmissionNumber"] = submissionNumber;
            Console.WriteLine(string.Format("Submission Number: '{0}'", submissionNumber));
        }

        public void ClickContinueQuoteButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(continueQuoteButtonCSS), 30);
            driver.FindElement(By.CssSelector(continueQuoteButtonCSS)).Click();
        }
    }
}

using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class AccountSearchResultsPage : Page
    {
        private const string searchAgainButtonCSS = "button[ng-click='resetSearch()']";
        private const string continueAsNewCustomerButtonCSS = "button[ng-click='newQuote()']";

        public AccountSearchResultsPage(IWebDriver driver) : base(driver) { }

        public override void VerifyPage()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(searchAgainButtonCSS), 30);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver, 180);
        }

        public string QuoteNumberLinkCSS(string submissionNumber)
        {
            return string.Format("a[href*='{0}']", submissionNumber);
        }

        public void ClickContinueAsNewCustomerButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(continueAsNewCustomerButtonCSS), 30);
            driver.FindElement(By.CssSelector(continueAsNewCustomerButtonCSS)).Click();
        }

        public void ClickQuoteLink()
        {
            var submissionNumber = ScenarioContext.Current["SubmissionNumber"].ToString();
            WaitUntilElementEnabled(driver, By.CssSelector(QuoteNumberLinkCSS(submissionNumber)), 30);
            driver.FindElement(By.CssSelector(QuoteNumberLinkCSS(submissionNumber))).Click();
        }
    }
}

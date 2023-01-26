using OpenQA.Selenium;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class PolicyInformationpage: Page
    {
        private const string lblPolicyInformationXpath = "//div[@class='gw-page-section-title__left ng-binding']";
        private const string yesOverviewAndFraudWarningRadioButtonCSS = "div[name='isFraudStatementUnderStoodPolicyInfo'] label[title='Yes']";
        private const string submitForReviewButtonCSS = "button[ng-show='showNext']";
        private const string nextButtonCSS = "button[ng-show='showNext']";

        public PolicyInformationpage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyInformationXpath);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(lblPolicyInformationXpath));
        }

        public void ClickNextButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(nextButtonCSS), 30);
            driver.FindElement(By.CssSelector(nextButtonCSS)).Click();
        }

        public void ClickYesOverviewAndFraudWarning()
        {
            JavaScriptClick(driver.FindElement(By.CssSelector(yesOverviewAndFraudWarningRadioButtonCSS)));
        }

        public void ClickSubmitForReviewButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(submitForReviewButtonCSS), 30);
            driver.FindElement(By.CssSelector(submitForReviewButtonCSS)).Click();
        }
    }
}

using OpenQA.Selenium;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class PaymentConfirmationPage : Page
    {
        private const string accountNumberLinkCSS = "a[ui-sref*='accountNumber']";
        private const string policyNumberLinkCSS = "a[ui-sref*='policyNumber']";

        public PaymentConfirmationPage(IWebDriver driver) : base(driver) { }

        public override void VerifyPage()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(policyNumberLinkCSS));
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver, 180);
        }

        public string GetAccountNumber()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(accountNumberLinkCSS), 30);
            return driver.FindElement(By.CssSelector(accountNumberLinkCSS)).Text;
        }

        public string GetPolicyNumber()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(policyNumberLinkCSS), 30);
            return driver.FindElement(By.CssSelector(policyNumberLinkCSS)).Text;
        }
    }
}

using OpenQA.Selenium;
using WebCommonCore;

namespace BillingCenterPages.Pages.Desktop
{
    public class MultiPaymentEntryConfirm : Page
    {
        string lblMultiPayment = "span[id$='MultiPaymentEntryWizard:NewMultiPaymentScreen:ttlBar']";             
        string btnFinish = "span[id$='MultiPaymentEntryWizard:Finish-btnInnerEl']";

        public MultiPaymentEntryConfirm(IWebDriver driver) : base(driver)
        {
            pause();
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblMultiPayment);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblMultiPayment));
        }
        
        public void ClickFinish()
        {
            WaitFor(driver.FindElement(By.CssSelector(btnFinish)));
            driver.FindElement(By.CssSelector(btnFinish)).Click();
        }

    }
}

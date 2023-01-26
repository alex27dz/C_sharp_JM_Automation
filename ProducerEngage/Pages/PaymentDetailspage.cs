using OpenQA.Selenium;
using System;
using System.Threading;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class PaymentDetailsPage : Page
    {
        private const string addPaymentMethodButtonCSS = "button[on-click='addPaymentMethod()']";
        private const string creditCardPaymentMethodCSS = "div[label='Payment Method'] input[id*='Left']";
        private const string paymentIFrameCSS = "ng-form[name='paymentForm'] iframe";
        private const string cardNumberInputID = "cardNumberField";
        private const string cardCVVInputID = "cardCVVField";
        private const string cardExpirationDateInputID = "ccExpirationDate";
        private const string cardHolderNameInputID = "cardHolderField";
        private const string zipCodeInputID = "zipCode";
        private const string saveCardButtonCSS = "button[name='submitBtn']";
        private const string closeButtonCSS = "div[ng-click*='closePaymentWindow']";
        private const string buyNowButtonCSS = "button[ng-show='showNext']";

        public PaymentDetailsPage(IWebDriver driver) : base(driver) { }

        public override void VerifyPage()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(addPaymentMethodButtonCSS), 60);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver, 180);
        }

        public void ClickAddPaymentMethodButton()
        {
            // Temporary workaround for when iframe does not load correctly
            int retryCountRemaining = 5;
            string iframeHeight;

            while (retryCountRemaining > 0)
            {
                WaitUntilElementEnabled(driver, By.CssSelector(addPaymentMethodButtonCSS), 30);
                driver.FindElement(By.CssSelector(addPaymentMethodButtonCSS)).Click();

                // Check iframe loaded
                WaitUntilElementEnabled(driver, By.CssSelector(paymentIFrameCSS), 30);
                SwitchToIFrame(driver.FindElement(By.CssSelector(paymentIFrameCSS)));
                WaitUntilElementEnabled(driver, By.Id(cardNumberInputID), 30);
                SwitchToDefaultContent();

                Thread.Sleep(2000); // Allow iframe to resize
                WaitUntilElementEnabled(driver, By.CssSelector(paymentIFrameCSS), 30);

                iframeHeight = driver.FindElement(By.CssSelector(paymentIFrameCSS)).GetAttribute("height");
                Console.WriteLine("Payment iframe height: '{0}'", iframeHeight);

                if (!string.IsNullOrWhiteSpace(iframeHeight))
                    break;

                WaitUntilElementEnabled(driver, By.CssSelector(closeButtonCSS), 30);
                driver.FindElement(By.CssSelector(closeButtonCSS)).Click();
                retryCountRemaining--;
            }
        }

        public void ClickCreditCardPaymentMethod()
        {
            JavaScriptClick(driver.FindElement(By.CssSelector(creditCardPaymentMethodCSS)));
        }

        public void AddCreditCardInformation(string cardType, string cvv, string creditCardExpirationDate, string zipCode, string cardHolderName = null)
        {
            string creditCardNumber = string.Empty;

            switch (cardType.Trim())
            {
                case "VISA":
                    creditCardNumber = "4111111111111111";
                    break;
                case "MasterCard":
                    creditCardNumber = "5555555555554444";
                    break;
                case "AmericanExpress":
                    creditCardNumber = "378282246310005";
                    break;
                case "Discover":
                    creditCardNumber = "6011111111111117";
                    break;
                default:
                    break;
            }

            ClickCreditCardPaymentMethod();

            WaitUntilElementEnabled(driver, By.CssSelector(paymentIFrameCSS), 30);
            SwitchToIFrame(driver.FindElement(By.CssSelector(paymentIFrameCSS)));

            WaitUntilElementEnabled(driver, By.Id(cardNumberInputID), 30);
            driver.FindElement(By.Id(cardNumberInputID)).SendKeys(creditCardNumber);

            WaitUntilElementEnabled(driver, By.Id(cardCVVInputID), 30);
            driver.FindElement(By.Id(cardCVVInputID)).SendKeys(cvv);

            WaitUntilElementEnabled(driver, By.Id(cardExpirationDateInputID), 30);
            driver.FindElement(By.Id(cardExpirationDateInputID)).SendKeys(creditCardExpirationDate);

            if (!string.IsNullOrEmpty(cardHolderName))
            {
                WaitUntilElementEnabled(driver, By.Id(cardHolderNameInputID), 30);
                driver.FindElement(By.Id(cardHolderNameInputID)).Clear();
                driver.FindElement(By.Id(cardHolderNameInputID)).SendKeys(cardHolderName);
            }

            WaitUntilElementEnabled(driver, By.Id(zipCodeInputID), 30);
            driver.FindElement(By.Id(zipCodeInputID)).SendKeys(zipCode);

            WaitUntilElementEnabled(driver, By.CssSelector(saveCardButtonCSS), 30);
            driver.FindElement(By.CssSelector(saveCardButtonCSS)).Click();

            SwitchToDefaultContent();
        }

        public void ClickBuyNowButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(buyNowButtonCSS), 30);
            driver.FindElement(By.CssSelector(buyNowButtonCSS)).Click();
        }
    }
}

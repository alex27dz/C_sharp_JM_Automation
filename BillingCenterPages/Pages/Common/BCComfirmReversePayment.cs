using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using WebCommonCore;

namespace BillingCenterPages.Pages.Common
{

    public class BCConfirmReversePayment : Page
    {
       
        string lblConfirmReversePayment = "span[id$='DBPaymentReversalConfirmationPopup:ttlBar']";
        string btnOK = "span[id$='DBPaymentReversalConfirmationPopup:Update-btnInnerEl']";      
        string inputReasonXpath = "//*[@id='DBPaymentReversalConfirmationPopup:Reason-inputEl']";

        public BCConfirmReversePayment(IWebDriver driver) : base(driver)
        {
            pause();
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblConfirmReversePayment);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblConfirmReversePayment));
        }

        public void SelectConfirmReversePaymentReason(string reasonType)
        {

            WaitFor(driver.FindElement(By.XPath(inputReasonXpath)));
            JavaScriptClick(driver.FindElement(By.XPath(inputReasonXpath)));            

            Actions action = new Actions(driver);          
            switch (reasonType.ToLower().Trim())
            {
                case "returned check/nsf":
                    action.MoveToElement(driver.FindElement(By.XPath(inputReasonXpath))).SendKeys(reasonType).Build().Perform();
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
        }

        public void ClickOK()
        {
            WaitFor(driver.FindElement(By.CssSelector(btnOK)));
            driver.FindElement(By.CssSelector(btnOK)).Click();
        }
    }       

}





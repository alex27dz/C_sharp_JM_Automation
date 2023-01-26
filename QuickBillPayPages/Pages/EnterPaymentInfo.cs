using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
namespace QuickBillPayPages.Pages
{
    public class EnterPaymentInfo:Page
    {

        public void MakePayment(string CCorACH)
        {
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='paymentusIframe']")));
            UIActionExt(By.CssSelector("input[id='customer.address.zipCode']"), "ispresent");
            UIActionExt(By.CssSelector("input[id='customer.firstName']"), "List", "QBPFirstName");
            UIActionExt(By.CssSelector("input[id='customer.lastName']"), "List", "QBPLastName");
            string sCCorACH = CCorACH;
            var CardCVV = new Random();
            int rndValue = CardCVV.Next(1000);
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    switch (sCCorACH.ToLower().Trim())
                    {
                        case "visa":
                            CreditCardPayment("4111111111111111", rndValue.ToString("000"));
                            break;
                        case "master":
                            CreditCardPayment("5555555555554444", rndValue.ToString("000"));
                            break;
                        case "amex":
                            CreditCardPayment("378282246310005", "4"+ rndValue.ToString("000"));
                            break;
                        case "discover":
                            CreditCardPayment("6011111111111117", rndValue.ToString("000"));
                            break;
                        case "saving":
                        case "savings":
                            ACHPayment("savings");
                            break;
                        case "checking":
                            ACHPayment("checking");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    Assert.Fail("Scenario works only for STAGE");
                    break;
            }
            PaymentAuthorization();
        }
        public void CreditCardPayment(string sCardNumber, string sCVV)
        {

            UIActionExt(By.CssSelector("input[id='ccAccountNumber']"), "List", sCardNumber);
            UIActionExt(By.CssSelector("input[id='ccCvv']"), "List", sCVV);
            List<IWebElement> SelectCCExpMonth = driver.FindElements(By.CssSelector("select[id='ccExpiryDateMonth']")).ToList();
            SelectCCExpMonth[0].Click();
            SelectByText(SelectCCExpMonth[0], "05 - May");
            UIActionExt(By.CssSelector("select[id='ccExpiryDateYear']"), "ispresent");
            List<IWebElement> SelectCCExpYear = driver.FindElements(By.CssSelector("select[id='ccExpiryDateYear']")).ToList();
            SelectCCExpYear[0].Click();
            SelectByText(SelectCCExpYear[0], "2022");
            UIActionExt(By.CssSelector("input[id='ccCardHolderName']"), "List", "QBPRegression");
            UIActionExt(By.CssSelector("input[name='continueButton']"), "click");
            UIActionExt(By.XPath("//span[text()='I authorize payment and agree to the Payment Authorization Terms']"), "ispresent");
        }
        public void ACHPayment(string ACHType)
        {
            UIActionExt(By.CssSelector("span[id='echeck-group-heading']"), "ispresent");
            UIActionExt(By.CssSelector("span[id='echeck-group-heading']"), "click");
            if (ACHType == "savings")
            {
                UIActionExt(By.XPath("//span[@class='standard-label-msg']"), "ispresent","",1);
                UIActionExt(By.XPath("//span[@class='standard-label-msg']"), "click", "", 1);
            }
            else
            {
                UIActionExt(By.XPath("//span[@class='standard-label-msg']"), "ispresent", "", 0);
                UIActionExt(By.XPath("//span[@class='standard-label-msg']"), "click", "", 0);
            }
            UIActionExt(By.CssSelector("input[id$='ddAccountHolderName']"), "List", "QBPRegression LastName");
            UIActionExt(By.CssSelector("input[id$='ddRoutingNumber']"), "List", "021210073");
            try
            {
                if (IsElementPresent(driver, By.CssSelector("input[id='ddBankName'][value='WOORI AMERICA BANK']")) == false)
                {
                    WaitUntilElementVisible(driver, By.CssSelector("input[id='ddBankName'][value='WOORI AMERICA BANK']"), 5);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught: " + e);
            }
            
            UIActionExt(By.CssSelector("input[id$='ddAccountNumber']"), "List", "222343332");
            UIActionExt(By.CssSelector("input[name='continueButton']"), "click");
            UIActionExt(By.XPath("//span[text()='I authorize payment and agree to the Payment Authorization Terms']"), "ispresent");
        }

        public void PaymentAuthorization()
        {
            DataStorage RetrieveRegValue = new DataStorage();
            string sEmail = RetrieveRegValue.GetTempValue("EMAIL");
            string sPaymentAmount = ScenarioContext.Current["PaymentAmount"].ToString();
            UIActionExt(By.XPath("//span[text()='I authorize payment and agree to the Payment Authorization Terms']"), "ispresent");
            UIActionExt(By.XPath("//span[text()='I authorize payment and agree to the Payment Authorization Terms']"), "click");
            UIActionExt(By.CssSelector("a[id='make-payment-btn']"), "ispresent");
            UIActionExt(By.CssSelector("a[id='make-payment-btn']"), "click");
            Console.WriteLine(sEmail);
            Console.WriteLine(sPaymentAmount);
            UIActionExt(By.XPath("//a[text()='Return to Home']"), "ispresent");
            if (IsElementPresent(driver, By.XPath("//h1[text()='Payment Complete']"))==false)
            {
                Assert.Fail("Payment Complete not successfull. Expected string validation: Payment Complete");
            }
            if (sEmail != "")
            {
                if (IsElementPresent(driver, By.XPath("//b[text()='" + sEmail + "']")) == false)
                {
                    Assert.Fail("incorrect email ID. Expected was: " + sEmail);
                }
            }
            if (IsElementPresent(driver, By.XPath("//b[text()='$" + sPaymentAmount + "']")) == false)
            {
                Assert.Fail("Incorrect Payment Amount. Expected was : " + sPaymentAmount);
            }
            UIActionExt(By.XPath("//a[text()='Return to Home']"), "click");
        }

        public EnterPaymentInfo(IWebDriver driver) : base(driver)
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace BillingCenterPages.Pages.PaymentHistory
{
    
    public class PaymentHistory : Page
    {

        [FindsBy(How = How.Id, Using = "AccountPaymentHistory:AccountPaymentHistoryScreen:ttlBar")]
        public IWebElement lblPaymentHistory;

        public PaymentHistory(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            WaitFor(lblPaymentHistory);

        }

        public override void WaitForLoad()
        {
            WaitFor(lblPaymentHistory);
        }

        public void verifyPayments(string PaymentMethod)
        {
            SetActiveIFrame();
            pause();
            pause();
            pause();
            List<IWebElement> PageInputElements = new List<IWebElement>();
            Boolean isPresent = driver.FindElements(By.XPath("//*[text()='Unable to Process Request Notice']")).Count() > 0;
            Console.WriteLine("Is Error message presented " + isPresent);
            if (isPresent)
            {
                IWebElement paymentusErrorText = driver.FindElement(By.XPath("//*[text()='Unable to Process Request Notice']"));
                Console.WriteLine("PaymentUs Error is " + paymentusErrorText.Text);
                Assert.Fail("PaymentUs Error is " + paymentusErrorText.Text);
            }
            Console.WriteLine("Payment Method is " + PaymentMethod);
            if(PaymentMethod.Trim() == "<ACH>")
            {
                PaymentMethod = "ACH";
            }
            Console.WriteLine(ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim());
            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "stage")
            {
                switch (PaymentMethod.ToLower().Trim())
                {
                    case "checking":
                    case "savings":
                    case "ach":
                        PageInputElements = driver.FindElements(By.CssSelector(".pMethod.methodCheck")).ToList();
                        break;
                    case "master":
                        PageInputElements = driver.FindElements(By.CssSelector(".pMethod.methodMastercard")).ToList();
                        break;
                    case "amex":
                        PageInputElements = driver.FindElements(By.CssSelector(".pMethod.methodAmex")).ToList();
                        break;
                    case "visa":
                        PageInputElements = driver.FindElements(By.CssSelector(".pMethod.methodVisa")).ToList();
                        break;
                    case "discover":
                        PageInputElements = driver.FindElements(By.CssSelector(".pMethod.methodDiscover")).ToList();
                        break;
                    default:
                        break;
                }
                if (PageInputElements.Count == 0)
                    Assert.Fail("{0} payment is not displayed.", PaymentMethod.ToString());
                else
                    Console.WriteLine("{0} Count {1}", PaymentMethod.ToString(), PageInputElements.Count);
            }


            //List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(".pMethod.methodCheck")).ToList();


            //if (PageInputElements.Count == 0 && (PaymentMethod.ToLower().Trim() == "ach" || PaymentMethod.ToLower().Trim() == "all"))
            //    Assert.Fail("ECheck payment is not displayed.");
            //else
            //    Console.WriteLine("ECheck Count" + PageInputElements.Count);

            ////PageInputElements = driver.FindElements(By.CssSelector(".pMethod.methodMastercard")).ToList();

            //if (PageInputElements.Count == 0 && (PaymentMethod.ToLower().Trim() == "creditcard" || PaymentMethod.ToLower().Trim() == "all"))
            //    Assert.Fail("Master Card payment is not displayed.");
            //else
            //    Console.WriteLine("Mastercard Count" + PageInputElements.Count);

            //PageInputElements = driver.FindElements(By.CssSelector(".pMethod.methodAmex")).ToList();

            //if (PageInputElements.Count == 0 && (PaymentMethod.ToLower().Trim() == "creditcard" || PaymentMethod.ToLower().Trim() == "all"))
            //    Assert.Fail("Amex Card payment is not displayed.");
            //else
            //    Console.WriteLine("Amexcard Count" + PageInputElements.Count);
        }
    }
}

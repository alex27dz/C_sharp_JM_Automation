using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace QuoteAndApplyPages.Pages.QNA
{
    public class ReviewPage:Page
    {
        string checkCreditConsent = "input[id$='AcceptCreditConsent']";
        string checkHasAcknowledge = "input[id$='HasAcknowledgedLegalTerms']";
        string checkAcceptPaperless = "input[id$='AcceptPaperlessDelivery']";
        //string checkFraudWarning = "input[id$='HasAcknowledgedLegalTerms']";
        string btnContinueToPayment = "a[id$='ContinueToPayment']";
        string btnSubmitApplication = "a[id$='SignAndSubmit']";
        public ReviewPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //SetActiveFrame();
            VerifyUIElementIsDisplayed(checkHasAcknowledge);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.Id("HasAcknowledgedLegalTerms"));
            WaitUntilElementEnabled(driver, By.Id("HasAcknowledgedLegalTerms"));
        }

        public void SetCreditConsent(string CreditConsent)
        {
            switch (CreditConsent.ToLower().Trim())
            {
                case "yes":
                    UIAction(checkCreditConsent, string.Empty, "a");
                    pause();
                    break;
                default:
                    break;
            }
        }
        public void acceptReviewPageTerms(string ReviewButtonType, string paperlessflag)
        {
            
          //  UIAction(checkFraudWarning, string.Empty, "a");
            UIAction(checkHasAcknowledge, string.Empty, "a");
            switch (paperlessflag.ToLower().Trim())
            {
                case "yes":
                    UIAction(checkAcceptPaperless, string.Empty, "a");
                    pause();
                    break;
                default:
                    break;
            }
            switch (ReviewButtonType.ToLower().Trim())
            {
                case "yes":
                    Console.WriteLine("option a");
                    WaitUntilElementVisible(driver, By.Id("SignAndSubmit"));
                    UIAction(btnSubmitApplication, string.Empty, "a");
                    //pause();
                    //WaitUntilElementInvisible(driver,By.Id("SignAndSubmit"));
                    break;
                case "no":
                    Console.WriteLine("option b");
                    WaitUntilElementVisible(driver, By.Id("ContinueToPayment"));
                    UIAction(btnContinueToPayment, string.Empty, "a");
                    //pause();
                    //WaitUntilElementInvisible(driver, By.Id("ContinueToPayment"));
                    break;
                default:
                    break;

            }          
        }
        public void verifyAgentDashboard(string country)
        {
            UIActionExt(By.XPath("//a[text()='Make Payment']"), "click");
            var popup = driver.WindowHandles[1]; // handler for the new tab
            Assert.IsTrue(!string.IsNullOrEmpty(popup)); // tab was opened
            if (country == "US")
            {
                Assert.AreEqual(driver.SwitchTo().Window(popup).Url, "https://secure2.paymentus.com/biller/stde/jmic?v2=true"); // url is OK  

            }
            else if (country == "CA")
            {
                Assert.AreEqual(driver.SwitchTo().Window(popup).Url, "https://secure2.paymentus.com/biller/stde/jmcp?v2=true"); // url is OK  
            }

            Console.WriteLine(driver.SwitchTo().Window(popup).Url);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close(); // close the tab
            driver.SwitchTo().Window(driver.WindowHandles[0]); // get back to the main window
        }
        public void acceptReviewPageTermsAndIssuePolicy_STP(string paperlessflag, string paymentoptions)
        {

            //  UIAction(checkFraudWarning, string.Empty, "a");
            //Assert.IsTrue(driver.FindElement(By.XPath("//span[text()='REVIEW & SUBMIT']")).Displayed);
            //Assert.IsTrue(driver.FindElement(By.XPath("//h1[text()='Review and Submit Application']")).Displayed);
            UIAction(checkHasAcknowledge, string.Empty, "a");
            switch (paperlessflag.ToLower().Trim())
            {
                case "yes":
                    UIAction(checkAcceptPaperless, string.Empty, "a");
                    pause();
                    break;
                default:
                    break;
            }
            WaitUntilElementVisible(driver, By.Id("SignAndSubmit"));
            IList<IWebElement> paymentOptionList = driver.FindElements(By.XPath("//input[@name='PaymentPlanOptions']")).ToList();
            Console.WriteLine(paymentOptionList.Count);
            foreach (IWebElement element in paymentOptionList)
            {
                Console.WriteLine(element.GetAttribute("Id"));
            }
            //****need to check number of payment option presented
            //****Need to record which payment option chose
            if (paymentoptions == "1")
            {
                Assert.AreEqual(0, paymentOptionList.Count);
                //paymentOptionList[0].Click();
            }
            else if (paymentoptions == "2")
            {
                UIAction(btnSubmitApplication, string.Empty, "a");
                Assert.IsTrue(driver.FindElement(By.XPath("//span[text()='Please select a payment plan.']")).Displayed);
                Assert.AreEqual(2, paymentOptionList.Count / 2);
                paymentOptionList[3].Click();
            }
            else if (paymentoptions == "4")
            {
                UIAction(btnSubmitApplication, string.Empty, "a");
                Assert.IsTrue(driver.FindElement(By.XPath("//span[text()='Please select a payment plan.']")).Displayed);
                Assert.AreEqual(3, paymentOptionList.Count / 2);
                paymentOptionList[5].Click();
            }
            else if (paymentoptions == "8")
            {
                UIAction(btnSubmitApplication, string.Empty, "a");
                Assert.IsTrue(driver.FindElement(By.XPath("//span[text()='Please select a payment plan.']")).Displayed);
                Assert.AreEqual(4, paymentOptionList.Count / 2);
                paymentOptionList[7].Click();
            }
            else if (paymentoptions == "12")
            {
                UIAction(btnSubmitApplication, string.Empty, "a");
                Assert.IsTrue(driver.FindElement(By.XPath("//span[text()='Please select a payment plan.']")).Displayed);
                Assert.AreEqual(5, paymentOptionList.Count / 2);
                paymentOptionList[9].Click();
            }
            ScenarioContext.Current["PaymentOption"] = paymentoptions;
            //Thread.Sleep(10000);
            UIAction(btnSubmitApplication, string.Empty, "a");
            WaitUntilElementVisible(driver, By.XPath("//h1[text()[contains(.,'Confirmation – Policy Issued')]]"));
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            string sAccountNumber;
            IWebElement IWAccountNumber = driver.FindElement(By.XPath("//span[@data-bind='text: $root.reviewViewModel().accountNumber']"));
            sAccountNumber = IWAccountNumber.Text;
            Console.WriteLine("Account Number: {0}", sAccountNumber);
            ScenarioContext.Current["ACCOUNT"] = sAccountNumber;
            RegKey.SetValue("ACCNO", sAccountNumber);
        }
    }
}

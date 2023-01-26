using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using WebCommonCore;
using HelperClasses;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace BillingCenterPages.Pages.Desktop
{
    public class MultiPaymentEntryInfo : Page
    {
        string lblMultiPayment = "span[id$='MultiPaymentEntryWizard:NewMultiPaymentScreen:ttlBar']";          
        string btnNext = "span[id$='ultiPaymentEntryWizard:Next-btnInnerEl']";
        string tablePaymentEnterXpath = "//*[@id='MultiPaymentEntryWizard/EnterInformation-tbody']";

        public MultiPaymentEntryInfo(IWebDriver driver) : base(driver)
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
      
        public void EnterPaymentInfo(string accountNumber, string paymentInstrument, string checkNumber, string amount)
        {
            DataStorage temp = new DataStorage();

            string accNum = null;
            switch (accountNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    accNum = temp.GetTempValue("ACCNO");                  
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    accNum = UFTRegKey.GetValue("ACCNO").ToString();
                    break;
                default:
                    accNum = accountNumber;
                    break;
            }

            if (ScenarioContext.Current.ContainsKey("ACCOUNT") == true)
            {
                if (ScenarioContext.Current["ACCOUNT"].ToString() != accNum)
                {
                    ScenarioContext.Current["ACCOUNT"] = accNum;
                }
            }
            else
            {
                ScenarioContext.Current.Add("ACCOUNT", accNum);
            }

            WaitFor(driver.FindElement(By.XPath(tablePaymentEnterXpath)));
            IWebElement drMainTable = driver.FindElement(By.XPath(tablePaymentEnterXpath));
            List<IWebElement> lsGetTableElements = new List<IWebElement>(drMainTable.FindElements(By.TagName("table")));
            Console.WriteLine("table elements: " + lsGetTableElements.Count);           
            IWebElement firstTable = lsGetTableElements[0];
            EnterChechNumer(firstTable, checkNumber);
            EnterAmount(firstTable, amount);
            EnterAccountNumber(firstTable, accNum);
            EnterPaymentInstrument(firstTable, paymentInstrument);
        }

        private void EnterAccountNumber(IWebElement firstTable, string accountNumber) 
        {
            List<IWebElement> lsGetTdElemets = new List<IWebElement>(firstTable.FindElements(By.TagName("td")));
            if (lsGetTdElemets.Count > 0)
            {         
                IWebElement accountForEnter = lsGetTdElemets[1];
                var obj = accountForEnter.Enabled;
                accountForEnter.Click();           
                Actions action = new Actions(driver);
                action.SendKeys(accountNumber).Build().Perform();
            }
            else
            {
                Console.WriteLine("table is empty");
            }
        }

        private void EnterChechNumer(IWebElement firstTable, string checkNumber) 
        {
            List<IWebElement> lsGetTdElemets = new List<IWebElement>(firstTable.FindElements(By.TagName("td")));
            if (lsGetTdElemets.Count > 3)
            {
                IWebElement checkForEnter = lsGetTdElemets[4];
                var obj2 = checkForEnter.Enabled;
                checkForEnter.Click();
                Actions action = new Actions(driver);
                action.SendKeys(checkNumber).Build().Perform();
            }
            else
            {
                Console.WriteLine(" table column number is less then 4");
            }
        }

        private void EnterAmount(IWebElement firstTable, string amount)
        {
            List<IWebElement> lsGetTdElemets = new List<IWebElement>(firstTable.FindElements(By.TagName("td")));
            if (lsGetTdElemets.Count > 4)
            {
                IWebElement amountForEnter = lsGetTdElemets[5];
                var obj3 = amountForEnter.Enabled;
                amountForEnter.Click();
                Actions action = new Actions(driver);
                action.SendKeys(amount).Build().Perform();
            }
            else
            {
                Console.WriteLine(" table column number is less then 5");
            }
        }

        private void EnterPaymentInstrument(IWebElement firstTable, String paymentInstrument)
        {
            List<IWebElement> lsGetTdElemets = new List<IWebElement>(firstTable.FindElements(By.TagName("td"))); 
            if (lsGetTdElemets.Count > 2)
            {
                IWebElement paymentInsForEnter = lsGetTdElemets[3];
                var obj1 = paymentInsForEnter.Enabled;       
                paymentInsForEnter.Click();          
                Actions action = new Actions(driver);
                action.SendKeys(paymentInstrument).Build().Perform();
            }
            else
            {
                Console.WriteLine(" table column number is less then 3");
            }
        }

        public void ClickNext()
        {
            WaitFor(driver.FindElement(By.CssSelector(btnNext)));
            driver.FindElement(By.CssSelector(btnNext)).Click();
        }

    }
}

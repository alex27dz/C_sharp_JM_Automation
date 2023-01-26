using AutomationFramework;
using HelperClasses;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading.Tasks;


namespace PolicyCenter9Pages.Pages.Common
{
    public class Contacts_PC9 : Page
    {
        string tabConatctDetail = "span[id$='AccountFile_Contacts:AccountFile_ContactsScreen:ttlBar']";

        string tabCreditConsent = "a[id$=':AccountContactCV:CreditConsentTab']";


        public Contacts_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 200);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(tabConatctDetail);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(tabConatctDetail));
        }

        public void VerifyCreditConsent(string creditConsent)
        {
            UIAction(tabCreditConsent, String.Empty, "span");

            IsElementPresent(driver, By.Id("AccountFile_Contacts:AccountFile_ContactsScreen:AccountContactCV:CreditConsentPanelSet:CreditCheck-inputEl"));

            IWebElement CreditCheckValue = driver.FindElement(By.XPath("//div[@id ='AccountFile_Contacts:AccountFile_ContactsScreen:AccountContactCV:CreditConsentPanelSet:CreditCheck-inputEl']"));
            Console.WriteLine("Credit Consent value is " + CreditCheckValue.Text);
            switch (creditConsent.ToLower().Trim())
            {
                case "yes":

                    if (!(CreditCheckValue.Text.Equals("Yes")))
                    {
                        Assert.Fail("Credit Consent do not match");
                    }

                    break;
                default:
                    if (CreditCheckValue.Text.Equals("Yes"))
                    {
                        Assert.Fail("Credit Consent do not match");
                    }
                    break;
            }
        }

    }
}

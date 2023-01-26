using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PLPortalPages.Pages
{
    public class ClaimContactDerailes : Page
    {



        string btnSubmitClaim = "input[id$='verifyAndSubmit']";
        string txtContactPhone = "input[id$='contactPhoneField']";
        string txtContactCity = "input[id$='ContactCity']";
        string txtContactState = "input[id$='ContactState']";
        string txtContactPostal = "input[id$='ContactPostalCode']";
        string txtContactAddr1 = "input[id$='ContactAddr1']";
        string txtContactAddr2 = "input[id$='ContactAddr2']";
        string txtContactEmail = "input[id$='ContactEmail']";
        string chckNewAddress = "input[id$='IsNewAddress']";




        public ClaimContactDerailes(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnSubmitClaim);
        }

        public override void WaitForLoad()
        {

        }


        public void ClickSubmitClaim()
        {
            UIAction(btnSubmitClaim, string.Empty, "a");
            pause();
        }

        public void UpdateContactInformation(string ContactAddress1, string ContactAddress2, string ContactCity, string ContactState, string ContactPhone, string ContactEmail, string ContactZip, string IsNerwAddress)
        {

            if (!string.IsNullOrEmpty(ContactAddress1))
            {
                List<IWebElement> tempContactAddr1 = driver.FindElements(By.XPath("//input[@id='ContactAddr1']")).ToList();
                tempContactAddr1[0].Clear();
                UIAction(txtContactAddr1, ContactAddress1, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactAddress2))
            {
                List<IWebElement> tempContactAddr2 = driver.FindElements(By.XPath("//input[@id='ContactAddr2']")).ToList();
                tempContactAddr2[0].Clear();
                UIAction(txtContactAddr1, ContactAddress2, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactCity))
            {
                List<IWebElement> tempContactCity = driver.FindElements(By.XPath("//input[@id='ContactCity']")).ToList();
                tempContactCity[0].Clear();
                UIAction(txtContactCity, ContactCity, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactState))
            {
                List<IWebElement> tempContactState = driver.FindElements(By.XPath("//input[@id='ContactState']")).ToList();
                tempContactState[0].Clear();
                UIAction(txtContactState, ContactState, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactZip))
            {
                List<IWebElement> tempContactZip = driver.FindElements(By.XPath("//input[@id='ContactPostalCode']")).ToList();
                tempContactZip[0].Clear();
                UIAction(txtContactPostal, ContactZip, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactPhone))
            {
                Console.WriteLine("phone number valus is " + ContactPhone);
                List<IWebElement> tempContactPhone = driver.FindElements(By.XPath("//input[@id='contactPhoneField']")).ToList();
                tempContactPhone[0].Clear();
                UIAction(txtContactPhone, ContactPhone, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactEmail))
            {
                List<IWebElement> tempContactEmail = driver.FindElements(By.XPath("//input[@id='ContactEmail']")).ToList();
                tempContactEmail[0].Clear();
                UIAction(txtContactEmail, ContactEmail, "textbox");

            }

            if (IsNerwAddress.ToLower().Trim() == "yes")
            {
                UIAction(chckNewAddress, string.Empty, "a");

            }
        }
    }

}

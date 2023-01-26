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
    public class PersonalInformation : Page
    {
        string txtLastName = "input[id$='Contacts_0__LastName']";
        string txtEmailAddress = "input[id$='Contacts_0__EmailAddress']";
        string txtPhoneNumber = "input[id$='Contacts_0__PhoneNumber']";
        string txtAddress1 = "input[id$='Contacts_0__Address1']";
        string txtAddress2 = "input[id$='Contacts_0__Address2']";
        string txtCity = "input[id$='Contacts_0__City']";
        string txtState = "input[id$='Contacts_0__State']";
        string txtPostalCode = "input[id$='Contacts_0__PostalCode']";

        string txtMailingAddress1 = "input[id$='Contacts_0__MailingAddress1']";
        string txtMailingAddress2 = "input[id$='Contacts_0__MailingAddress2']";
        string txtMailingCity = "input[id$='Contacts_0__MailingCity']";
        string txtMailingState = "input[id$='Contacts_0__MailingState']";
        string txtMailingPostalCode = "input[id$='Contacts_0__MailingPostalCode']";


        string radioMailingAddressYes = "input[id$='IsMailingAddressSameYes0']";
        string radioMailingAddressNo = "input[id$='IsMailingAddressSameNo0']";
        string btnRetuentoAccount = "input[id$='return']";

        string ribbionSuccess = "div[id$='saveSuccess']";
        // 

        string btnSave = "input[id$='saveContacts']";


        public PersonalInformation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtLastName);
        }

        public override void WaitForLoad()
        {

        }

        public void UpdatePersonalInformation(string LastName, string Email, string Phone, string Address1, string Address2, string City, string State, string Zip, string MailingAddressSame)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");

            if (!string.IsNullOrEmpty(LastName))
            {

                List<IWebElement> tempLastName = driver.FindElements(By.XPath("//input[@id='Contacts_0__LastName']")).ToList();
                Console.WriteLine("count is " + tempLastName.Count());
                tempLastName[0].Clear();
                UIAction(txtLastName, LastName, "textbox");
                RegKey.SetValue("LNAME", LastName);

            }

            if (!string.IsNullOrEmpty(Email))
            {
                List<IWebElement> tempEmail = driver.FindElements(By.XPath("//input[@id='Contacts_0__EmailAddress']")).ToList();
                tempEmail[0].Clear();
                UIAction(txtEmailAddress, Email, "textbox");
                RegKey.SetValue("EMAIL", Email);

            }
            if (!string.IsNullOrEmpty(Phone))
            {
                Console.WriteLine("count is " + Phone);
                List<IWebElement> tempPhone = driver.FindElements(By.XPath("//input[@id='Contacts_0__PhoneNumber']")).ToList();
                tempPhone[0].Clear();
                UIAction(txtPhoneNumber, Phone, "textbox");
                //RegKey.SetValue("EMAIL", Phone);

            }
            if (!string.IsNullOrEmpty(Address1))
            {
                List<IWebElement> tempAddress1 = driver.FindElements(By.XPath("//input[@id='Contacts_0__Address1']")).ToList();
                tempAddress1[0].Clear();
                UIAction(txtAddress1, Address1, "textbox");

            }
            if (!string.IsNullOrEmpty(Address2))
            {
                List<IWebElement> tempAddress2 = driver.FindElements(By.XPath("//input[@id='Contacts_0__Address2']")).ToList();
                tempAddress2[0].Clear();
                UIAction(txtAddress2, Address2, "textbox");

            }
            if (!string.IsNullOrEmpty(City))
            {
                List<IWebElement> tempCity = driver.FindElements(By.XPath("//input[@id='Contacts_0__City']")).ToList();
                tempCity.Clear();
                UIAction(txtCity, City, "textbox");

            }
            if (!string.IsNullOrEmpty(State))
            {
                List<IWebElement> tempState = driver.FindElements(By.XPath("//input[@id='Contacts_0__State']")).ToList();
                tempState[0].Clear();
                UIAction(txtState, State, "textbox");

            }
            if (!string.IsNullOrEmpty(Zip))
            {
                List<IWebElement> tempZip = driver.FindElements(By.XPath("//input[@id='Contacts_0__PostalCode']")).ToList();
                tempZip[0].Clear();
                UIAction(txtPostalCode, Zip, "textbox");

            }
            if (!string.IsNullOrEmpty(MailingAddressSame))
            {
                switch ((MailingAddressSame.ToLower().Trim()))
                {
                    case "no":
                        UIAction(radioMailingAddressNo, string.Empty, "a");
                        break;
                    default:

                        break;


                }

            }
        }

        public void ClickonSave()
        {
            UIAction(btnSave, string.Empty, "a");
            pause();
            pause();
            WaitUntilElementIsDisplayed(driver, By.XPath("//div[id$='saveSuccess']"));
            System.Console.WriteLine("Succes Ribbon is displayed");
            pause();
            pause();
            pause();
            pause();

            //WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$='return']"));
            //UIAction(btnRetuentoAccount, string.Empty, "a");

        }

        public void UpdateMailingAddress(string MailingAddress1, string MailingAddress2, string MailingCity, string MailingState, string MailingZip)
        {
            if (!string.IsNullOrEmpty(MailingAddress1))
            {
                List<IWebElement> tempMailingAddress1 = driver.FindElements(By.XPath("//input[@id='Contacts_0__MailingAddress1']")).ToList();
                tempMailingAddress1[0].Clear();
                UIAction(txtMailingAddress1, MailingAddress1, "textbox");

            }
            if (!string.IsNullOrEmpty(MailingAddress2))
            {
                List<IWebElement> tempMailingAddress2 = driver.FindElements(By.XPath("//input[@id='Contacts_0__MailingAddress2']")).ToList();
                tempMailingAddress2[0].Clear();
                UIAction(txtMailingAddress2, MailingAddress2, "textbox");

            }
            if (!string.IsNullOrEmpty(MailingCity))
            {
                List<IWebElement> tempMailingCity = driver.FindElements(By.XPath("//input[@id='Contacts_0__MailingCity']")).ToList();
                tempMailingCity[0].Clear();
                UIAction(txtMailingCity, MailingCity, "textbox");

            }
            if (!string.IsNullOrEmpty(MailingState))
            {
                List<IWebElement> tempMailingState = driver.FindElements(By.XPath("//input[@id='Contacts_0__MailingState']")).ToList();
                tempMailingState[0].Clear();
                UIAction(txtMailingState, MailingState, "textbox");

            }
            if (!string.IsNullOrEmpty(MailingZip))
            {
                List<IWebElement> tempMailingZip = driver.FindElements(By.XPath("//input[@id='Contacts_0__MailingPostalCode']")).ToList();
                tempMailingZip[0].Clear();
                UIAction(txtMailingPostalCode, MailingZip, "textbox");

            }
        }
    }

}

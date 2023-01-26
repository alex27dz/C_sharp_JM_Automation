using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium.Interactions;
using System.Diagnostics;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgencyAutomationPages.Pages
{
    public class AgentEditAddress : Page
    {
        string txtMailingAddressLine1 = "input[id$='MailingAddress_AddressLine1']";
        string txtMailingAddressLine2 = "input[id$='MailingAddress_AddressLine2']";
        string txtMailingCity = "input[id$='MailingAddress_City']";
        string selectMailingState = "select[id$='MailingAddress_State_SelectedStateValue']";
        string txtMailingPostalCode = "input[id$='MailingAddress_PostalCode']";
        string txtMailingCounty = "input[id$='MailingAddress_County']";
        string selectMailingCountry = "select[id$='MailingAddress_Country_SelectedCountryValue']";

        string chckIsPrimary = "input[id$='IsPrimaryAddressSameAsMailingAddress']";


        string txtPrimaryAddressLine1 = "input[id$='PrimaryAddress_AddressLine1']";
        string txtPrimaryAddressLine2 = "input[id$='PrimaryAddress_AddressLine2']";
        string txtPrimaryCity = "input[id$='PrimaryAddress_City']";
        string selectPrimaryState = "select[id$='PrimaryAddress_State_SelectedStateValue']";
        string txtPrimaryPostalCode = "input[id$='PrimaryAddress_PostalCode']";
        string txtPrimaryCounty = "input[id$='PrimaryAddress_County']";
        string selectPrimaryCountry = "select[id$='PrimaryAddress_Country_SelectedCountryValue']";

        string selectAddressType = "select[id$='PrimaryAddress_AddressType_SelectedAddressTypeValue']";

        string btnSaveChange = "input[id$='addressButton']";



        public AgentEditAddress(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtMailingAddressLine1);
        }

        public void saveChanges()
        {
            UIAction(btnSaveChange, String.Empty, "a");
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtMailingAddressLine1));

        }

        public void UpdateMailingAddress(string address1, string address2, string city, string state, string zip, string county, string country)
        {
            if (!String.IsNullOrEmpty(address1))
            {
                List<IWebElement> MailingAddress1 = driver.FindElements(By.XPath("//input[@id='MailingAddress_AddressLine1']")).ToList();
                MailingAddress1[0].Clear();
                UIAction(txtMailingAddressLine1, address1, "textbox");
            }

            if (!String.IsNullOrEmpty(address2))
            {
                List<IWebElement> MailingAddress2 = driver.FindElements(By.XPath("//input[@id='MailingAddress_AddressLine2']")).ToList();
                MailingAddress2[0].Clear();
                UIAction(txtMailingAddressLine2, address2, "textbox");
            }
            if (!String.IsNullOrEmpty(city))
            {
                List<IWebElement> MailingCity = driver.FindElements(By.XPath("//input[@id='MailingAddress_City']")).ToList();
                MailingCity[0].Clear();
                UIAction(txtMailingCity, city, "textbox");
            }
            if (!String.IsNullOrEmpty(state))
            {
                UIAction(selectMailingState, state, "selectbox");
            }
            if (!String.IsNullOrEmpty(zip))
            {
                List<IWebElement> MailingZip = driver.FindElements(By.XPath("//input[@id='MailingAddress_PostalCode']")).ToList();
                MailingZip[0].Clear();
                UIAction(txtMailingPostalCode, zip, "textbox");
            }
            if (!String.IsNullOrEmpty(county))
            {
                List<IWebElement> MailingCounty = driver.FindElements(By.XPath("//input[@id='MailingAddress_County']")).ToList();
                MailingCounty[0].Clear();
                UIAction(txtMailingCounty, county, "textbox");
            }
            if (!String.IsNullOrEmpty(country))
            {
                switch (country.ToLower().Trim())
                {
                    case "usa":
                        UIAction(selectMailingCountry, "United States of America", "selectbox");
                        break;
                    case "canada":
                        UIAction(selectMailingCountry, "Canada", "selectbox");
                        break;
                    case "australia":
                        UIAction(selectMailingCountry, "Australia", "selectbox");
                        break;
                    default:
                        break;

                }

            }
        }

        public void UpdatePrimaryAddress(string address1, string address2, string city, string state, string zip, string county, string country, string isprimary, string addressType)
        {
            if (!String.IsNullOrEmpty(address1))
            {
                List<IWebElement> PrimaryAddress1 = driver.FindElements(By.XPath("//input[@id='PrimaryAddress_AddressLine1']")).ToList();
                PrimaryAddress1[0].Clear();
                UIAction(txtPrimaryAddressLine1, address1, "textbox");
            }

            if (!String.IsNullOrEmpty(address2))
            {
                List<IWebElement> PrimaryAddress2 = driver.FindElements(By.XPath("//input[@id='PrimaryAddress_AddressLine2']")).ToList();
                PrimaryAddress2[0].Clear();
                UIAction(txtPrimaryAddressLine2, address2, "textbox");
            }
            if (!String.IsNullOrEmpty(city))
            {
                List<IWebElement> PrimaryCity = driver.FindElements(By.XPath("//input[@id='PrimaryAddress_City']")).ToList();
                PrimaryCity[0].Clear();
                UIAction(txtPrimaryCity, city, "textbox");
            }
            if (!String.IsNullOrEmpty(state))
            {
                UIAction(selectPrimaryState, state, "selectbox");
            }
            if (!String.IsNullOrEmpty(zip))
            {
                List<IWebElement> PrimaryZip = driver.FindElements(By.XPath("//input[@id='PrimaryAddress_PostalCode']")).ToList();
                PrimaryZip[0].Clear();
                UIAction(txtPrimaryPostalCode, zip, "textbox");
            }
            if (!String.IsNullOrEmpty(county))
            {
                List<IWebElement> PrimaryCounty = driver.FindElements(By.XPath("//input[@id='PrimaryAddress_County']")).ToList();
                PrimaryCounty[0].Clear();
                UIAction(txtPrimaryCounty, county, "textbox");
            }
            if (!String.IsNullOrEmpty(country))
            {
                switch (country.ToLower().Trim())
                {
                    case "usa":
                        UIAction(selectPrimaryCountry, "United States of America", "selectbox");
                        break;
                    case "canada":
                        UIAction(selectPrimaryCountry, "Canada", "selectbox");
                        break;
                    case "australia":
                        UIAction(selectPrimaryCountry, "Australia", "selectbox");
                        break;
                    default:
                        break;
                }
            }

            if (!String.IsNullOrEmpty(addressType))
            {
                switch (addressType.ToLower().Trim())
                {
                    case "billing":
                        UIAction(selectAddressType, "Billing", "selectbox");
                        break;
                    case "other":
                        UIAction(selectAddressType, "Other", "selectbox");
                        break;
                    case "mailing":
                        UIAction(selectAddressType, "Mailing", "selectbox");
                        break;
                    case "business":
                        UIAction(selectAddressType, "Business", "selectbox");
                        break;
                    case "home":
                        UIAction(selectAddressType, "Home", "selectbox");
                        break;
                    default:
                        break;
                }
            }

            if (isprimary.ToLower().Equals("yes"))
            {
                UIAction(chckIsPrimary, String.Empty, "a");
            }
        }
    }
}

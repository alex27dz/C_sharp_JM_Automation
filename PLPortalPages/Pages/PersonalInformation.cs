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
            //VerifyUIElementIsDisplayed(txtAppfirstName);
        }

        public override void WaitForLoad()
        {
        }

    }

}

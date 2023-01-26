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
    public class Login : Page
    {
        string btnSignUpNow = "a[id$='registerButton']";
        string txtAccountNumber = "input[id$='AccountOrPolicyNumber']";
        string txtFirstName = "input[id$='FirstName']";
        string txtLastName = "input[id$='LastName']";
        string txtPostalCode = "input[id$='PostalCode']";
        string btnNext = "input[id$='register_submit']";

        string txtEmail = "input[id$='Email']";
        string txtConfirmEmail = "input[id$='ConfirmEmail']";
        string txtPassword = "input[id$='Password']";
        string txtConfirmPassword = "input[id$='ConfirmPassword']";
        string ChkIsAgreeWithTermsOfUse = "input[id$='IsAgreeWithTermsOfUse']";
        string btnRegister = "input[id$='submit_registration']";

        string txtLoginUserName = "input[id$='UserName']";
        string txtLoginPassword = "input[id$='Password']";


        //  string linkLogin = "a[href$='http://appstage.jewelersmutual.jewelersnt.local/PLPortal/Security']"; text Login to view and manage your policy

        //String  <p> Congratulations! You are now registered for online policy access.

        //string <a>ViewDetails

        public Login(IWebDriver driver) : base(driver)
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

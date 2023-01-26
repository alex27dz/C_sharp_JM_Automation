using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using Microsoft.Win32;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

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
        string btnLogin = "input[id$='submitButton']";


        //  string linkLogin = "a[href$='http://appstage.jewelersmutual.jewelersnt.local/PLPortal/Security']"; text Login to view and manage your policy

        //String  <p> Congratulations! You are now registered for online policy access.

        //string <a>ViewDetails

        public Login(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //SetActiveFrame();
            VerifyUIElementIsDisplayed(txtLoginUserName);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(txtLoginUserName));
        }
        public void RegisterNewUser(string AccountNumbr, string FirstName, string LastName, string PostalCode, string Email, string Password)
        {
            UIAction(btnSignUpNow, string.Empty, "a");
            pause();
            pause();
            UIAction(txtAccountNumber, AccountNumbr, "textbox");
            UIAction(txtFirstName, FirstName, "textbox");
            UIAction(txtLastName, LastName, "textbox");
            UIAction(txtPostalCode, PostalCode, "textbox");
            UIAction(btnNext, string.Empty, "a");
            pause();
            pause();
            UIAction(txtEmail, Email, "textbox");
            UIAction(txtConfirmEmail, Email, "textbox");
            UIAction(txtPassword, Password, "textbox");
            UIAction(txtConfirmPassword, Password, "textbox");
            UIAction(ChkIsAgreeWithTermsOfUse, string.Empty, "a");
            UIAction(btnRegister, string.Empty, "a");
            System.Threading.Thread.Sleep(7000);
            ScenarioContext.Current["ACCOUNT"] = AccountNumbr;
            ScenarioContext.Current["PlPOrtalUserid"] = Email;
            ScenarioContext.Current["PLPortalPassword"] = Password;
            Console.WriteLine("username is " + Email);
            // WaitUntilElementIsDisplayed(driver, By.XPath("//a[contains(.,'Login to view and manage your policy')]"));
            IWebElement Login_link = driver.FindElement(By.XPath("//a[contains(.,'Login to view and manage your policy')]"));
            Console.WriteLine("click on login link after regis." + Login_link);
            Login_link.Click();

        }

        public void LoginToPLPortal()
        {
            //ScenarioContext.Current["ACCOUNT"] = "3000931877";
            //ScenarioContext.Current["PlPOrtalUserid"] = "8c135bPA1@JMTest.com";
            //ScenarioContext.Current["PLPortalPassword"] = "Pass123@";
            Console.WriteLine("user id is" + ScenarioContext.Current["PlPOrtalUserid"]);
            Console.WriteLine("Password is" + ScenarioContext.Current["PLPortalPassword"]);

            WaitUntilElementIsDisplayed(driver, By.Id(txtLoginUserName));
            UIAction(txtLoginUserName, ScenarioContext.Current["PlPOrtalUserid"].ToString(), "textbox");
            UIAction(txtLoginPassword, ScenarioContext.Current["PLPortalPassword"].ToString(), "textbox");
            UIAction(btnLogin, string.Empty, "a");
            pause();

        }
    }

}

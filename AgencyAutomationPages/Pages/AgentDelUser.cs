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
    public class AgentDelUser : Page
    {

        string btnDeleteUser = "input[type$='button'][value ='Delete']";
        string btnDeleteUserConfirm = "button[id$='deleteConfirm']";



        public AgentDelUser(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnDeleteUser);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnDeleteUser));

        }

        public void DeleteAddedUser()
        {
            UIAction(btnDeleteUser, string.Empty, "button");
            WaitUntilElementVisible(driver, By.XPath("//h4[@id ='deleteLabel']"));
            UIAction(btnDeleteUserConfirm, string.Empty, "button");
        }




    }
}

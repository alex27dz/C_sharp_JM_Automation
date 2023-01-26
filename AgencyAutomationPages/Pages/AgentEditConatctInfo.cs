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
    public class AgentEditConatctInfo : Page
    {

        string selectPhoneType = "select[id$='PrimaryPhoneType_SelectedPrimaryPhoneTypeValue']";
        string txtWorkPhone = "input[id$='WorkPhone']";
        string txtCellPhone = "input[id$='CellPhone']";
        string txtFax = "input[id$='Fax']";
        string txtEmail = "input[id$='Email']";



        string btnSaveChange = "input[id$='contactInfoButton']";



        public AgentEditConatctInfo(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnSaveChange);
        }



        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnSaveChange));

        }

        public void saveChanges()
        {
            UIAction(btnSaveChange, String.Empty, "a");
        }

        public void UpdateContactInfo(string PhoneType, string WorkPhone, string CellPhone, string Fax, string Email)
        {
            if (!String.IsNullOrEmpty(PhoneType))
            {
                switch (PhoneType.ToLower().Trim())
                {
                    case "work":
                        UIAction(selectPhoneType, "Work", "selectbox");
                        break;
                    case "cell":
                        UIAction(selectPhoneType, "Cell", "selectbox");
                        break;
                    default:
                        break;
                }
            }
            if (!String.IsNullOrEmpty(WorkPhone))
            {
                List<IWebElement> WorkPhoneObj = driver.FindElements(By.XPath("//input[@id='WorkPhone']")).ToList();
                WorkPhoneObj[0].Clear();
                UIAction(txtWorkPhone, WorkPhone, "textbox");
            }

            if (!String.IsNullOrEmpty(CellPhone))
            {
                List<IWebElement> CellPhoneObj = driver.FindElements(By.XPath("//input[@id='CellPhone']")).ToList();
                CellPhoneObj[0].Clear();
                UIAction(txtCellPhone, CellPhone, "textbox");

            }
            if (!String.IsNullOrEmpty(Fax))
            {
                List<IWebElement> FaxObj = driver.FindElements(By.XPath("//input[@id='Fax']")).ToList();
                FaxObj[0].Clear();
                UIAction(txtFax, Fax, "textbox");

            }
            if (!String.IsNullOrEmpty(Email))
            {
                List<IWebElement> EmailObj = driver.FindElements(By.XPath("//input[@id='Email']")).ToList();
                EmailObj[0].Clear();
                UIAction(txtEmail, Email, "textbox");

            }

        }

    }
}

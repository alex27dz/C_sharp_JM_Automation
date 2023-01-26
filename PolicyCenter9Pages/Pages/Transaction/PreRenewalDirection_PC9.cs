using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenter9Pages.Pages.Transaction
{
    public class PreRenewalDirection_PC9 : Page
    {
        string lblPolicyPreRenewalDirection = "span[id='PreRenewalDirectionPage:PreRenewalDirectionScreen:0']";
        string btnEditPrerenewal = "a[id$= ':PreRenewalDirectionScreen:Edit']";
        string btnUpdatePrerenewal = "a[id$= ':PreRenewalDirectionScreen:Update']";
        string selectDirection = "input[id$= ':PreRenewalDirectionScreen:PreRenewalDirection-inputEl']";
        string selectSecurity = "input[id$= ':PreRenewalDirectionScreen:NonRenewReason-inputEl']";


        public PreRenewalDirection_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyPreRenewalDirection);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyPreRenewalDirection));
        }

        public void UpdatePreRenewalPC9(string Direction, string Text, string NonRenewReason)
        {
            UIAction(btnEditPrerenewal, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnUpdatePrerenewal), 10);
            UIAction(selectDirection, string.Empty, "a");
            UIAction(selectDirection, Direction, "textbox");

            IWebElement txtareaText = driver.FindElement(By.XPath("//textarea[@id='PreRenewalDirectionPage:PreRenewalDirectionScreen:Text-inputEl']"));
            txtareaText.SendKeys(Text);
            UIAction(selectSecurity, string.Empty, "a");
            UIAction(selectSecurity, NonRenewReason, "textbox");
            UIAction(btnUpdatePrerenewal, string.Empty, "a");
        }


    }
}

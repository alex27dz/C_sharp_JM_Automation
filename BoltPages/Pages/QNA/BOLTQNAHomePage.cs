using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BoltPages.Pages.QNA
{
    public class BOLTQNAHomePage : Page
    {
        string editUniqueId = "input[id$='ExternalApplicationKey']";
        string btnGetMyQuote = "a[id$='Retrieve']";
        public BOLTQNAHomePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  SetActiveFrame();
            System.Threading.Thread.Sleep(5000);
            VerifyUIElementIsDisplayed(editUniqueId);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(editUniqueId));
        }

        public void setUniqueId(string id)
        {
            WaitUntilElementVisible(driver, By.Id("ExternalApplicationKey"));
            IWebElement UniqueId = driver.FindElement(By.Id("ExternalApplicationKey"));
            UniqueId.Clear();
            UIAction(editUniqueId, id, "textbox");
            UIAction(btnGetMyQuote, String.Empty, "a");
            System.Threading.Thread.Sleep(5000);
        }
    }
}

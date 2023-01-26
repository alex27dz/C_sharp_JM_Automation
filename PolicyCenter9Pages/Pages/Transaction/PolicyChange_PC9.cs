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
    public class PolicyChange_PC9 : Page
    {
        string lblPolicyChange = "span[id$=':StartPolicyChangeScreen:ttlBar']";
        string txtEffectiveDate = "input[id$=':StartPolicyChangeDV:EffectiveDateJMIC_date-inputEl']";
        string listChangeReason = "input[id='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:Test-inputEl']";
        string btnPolicyChangeNext = "span[id = 'StartPolicyChange:StartPolicyChangeScreen:NewPolicyChange-btnInnerEl']";

        string txtDescription = "input[id$ = ':PolicyChangeReason_JMICPanelSet:Description-inputEl']";

        public PolicyChange_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyChange);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyChange));
        }


        public void updatePOlicyCHangeOOS()
        {
            string btnOK = "a[id='button-1005']";
            WaitUntilElementVisible(driver, By.CssSelector(btnOK), 40);
            UIAction(btnOK, string.Empty, "span");

        }

        public void updatePOlicyCHange(string EffectiveDate, string ChangeReason)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            DateTime date = DateTime.Now;
            Actions action = new Actions(driver);
            string SetDate = "";
            string ExpDate = "";
            if (EffectiveDate.ToLower() == "currentdate")
            {
                SetDate = string.Format("{0:MM/dd/yyyy}", date);
            }
            else if (EffectiveDate.Contains("+"))
            {
                string[] details = EffectiveDate.Split('+');
                SetDate = string.Format("{0:MM/dd/yyyy}", date.AddDays(Int32.Parse(details[1])));
            }
            else if (EffectiveDate.Contains("-"))
            {
                string[] details = EffectiveDate.Split('-');
                SetDate = string.Format("{0:MM/dd/yyyy}", date.AddDays(Int32.Parse("-" + details[1])));
            }
            else
            {
                SetDate = EffectiveDate;
            }
            string text = SetDate.ToString();
            Console.WriteLine("date to enter is : " + text);
            Console.WriteLine("Changes are " + ChangeReason);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('StartPolicyChange:StartPolicyChangeScreen:StartPolicyChangeDV:EffectiveDateJMIC_date-inputEl').value='" + text + "'");
            action.SendKeys(Keys.Tab);
            action.Perform();
            action.Release();
            WaitUntilElementVisible(driver, By.CssSelector(listChangeReason));
            driver.FindElement(By.CssSelector(listChangeReason)).Click();
            Console.WriteLine("value selected is " + ChangeReason);
            UIAction(listChangeReason, ChangeReason, "textbox");
            action.SendKeys(Keys.Tab);
            action.Perform();
            action.Release();
            pause();
            UIAction(btnPolicyChangeNext, string.Empty, "span");

        }
    }
}

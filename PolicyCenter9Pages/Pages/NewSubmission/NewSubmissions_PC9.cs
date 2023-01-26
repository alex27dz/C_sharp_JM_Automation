using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SupportCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using WebCommonCore;
using Microsoft.Win32;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class NewSubmissions_PC9 : Page
    {
        string txtEffectiveDate = "input[id='NewSubmission:NewSubmissionScreen:ProductSettingsDV:effDate-inputEl']";
        string PolicyEffDate = "NewSubmission:NewSubmissionScreen:ProductSettingsDV:effDate-inputEl";
        string nameHeader = "span[id$=':NameHeader_link']";
        string selectPersonalJewelry = "a[id$=':0:addSubmission']";
        string selectPersonalArticles = "a[id$=':1:addSubmission']";

        public NewSubmissions_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtEffectiveDate);
        }
        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(txtEffectiveDate));
        }

        public void StartNewSubmissionPC9(string policyEffDate, string product)
        {
            pause();

            if (policyEffDate.Contains("SYSTEMDATE"))
            {
                string policyExpDate;
                var policyEffDateArr = policyEffDate.Split('+');
                int daysToAdd = int.Parse(policyEffDateArr[1]);
                DateTime tempDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                DateTime tempDate1 = tempDate.AddDays(daysToAdd);
                policyEffDate = tempDate.AddDays(daysToAdd).ToString("MM/dd/yyyy");
                policyExpDate = tempDate1.AddYears(1).ToString("MM/dd/yyyy");
                Console.WriteLine("currSysDate is " + policyEffDate);
                ScenarioContext.Current["PCLYEFFDATE"] = policyEffDate;
                ScenarioContext.Current["PCLYEXPFDATE"] = policyExpDate;
                RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                RegKey.SetValue("EFFDATE", policyEffDate);

            }

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + PolicyEffDate + "').value='" + policyEffDate + "'");
            IWebElement Searchclaim = driver.FindElement(By.XPath("//*[@id='NewSubmission:NewSubmissionScreen:ProductSettingsDV:effDate-inputEl']"));
            Searchclaim.Click();

            if (product.ToLower().Equals("personalarticles"))
            {
                UIAction(selectPersonalArticles, string.Empty, "span");
            }
            else
            {
                UIAction(selectPersonalJewelry, string.Empty, "span");
            }

        }

    }
}

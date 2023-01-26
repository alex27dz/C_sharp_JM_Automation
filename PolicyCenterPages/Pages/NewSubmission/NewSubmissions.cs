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

namespace PolicyCenterPages.Pages.NewSubmission
{
    public class NewSubmissions : Page
    {
        string PolicyEffDate = "NewSubmission:NewSubmissionScreen:ProductSettingsDV:effDate";

        string nameHeader = "span[id$=':NameHeader_link']";

        string selectPersonalJewelry = "span[id$='0:addSubmission_link']";

        public NewSubmissions(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            //  VerifyUIElementIsDisplayed(selectPersonalJewelry);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(selectPersonalJewelry));
        }

        public void StartNewSubmission(string policyEffDate, string product)
        {
            pause();

            if (policyEffDate.Contains("SYSTEMDATE"))
            {
                string policyExpDate;
                var policyEffDateArr = policyEffDate.Split('+');

                int daysToAdd = int.Parse(policyEffDateArr[1]);

                DateTime tempDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());

                //policyEffDate = tempDate.AddDays(daysToAdd).ToShortDateString();

                DateTime tempDate1 = tempDate.AddDays(daysToAdd);
                policyEffDate = tempDate.AddDays(daysToAdd).ToString("MM/dd/yyyy");
                policyExpDate = tempDate1.AddYears(1).ToString("MM/dd/yyyy");


                // policyEffDate = tempDate.ToString("MM/dd/yyyy");
                Console.WriteLine("currSysDate is " + policyEffDate);

                ScenarioContext.Current["PCLYEFFDATE"] = policyEffDate;

                ScenarioContext.Current["PCLYEXPFDATE"] = policyExpDate;

            }

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + PolicyEffDate + "').value='" + policyEffDate + "'");

            pause();

            UIAction(nameHeader, string.Empty, "span");

            pause();

            UIAction(nameHeader, string.Empty, "span");

            pause();

            UIAction(selectPersonalJewelry, string.Empty, "span");




        }
    }
}

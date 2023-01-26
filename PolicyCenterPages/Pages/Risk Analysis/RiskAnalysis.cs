using AutomationFramework;
using HelperClasses;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading.Tasks;


namespace PolicyCenterPages.Pages.CreateAccount
{
    public class RiskAnalysis : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";

        string[] arrTblList;

        public RiskAnalysis(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();
            pause();
            pause();
            pause();
            VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public string    VerifyActivities(string activity)
        {

            pause();

            List<IWebElement> TableInputElements = driver.FindElements(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:RiskEvaluationPanelSet:1")).ToList();
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            string ActivityList = "";
            for (int i = 0; i < arrTblList.Count(); i++)
            {
                Console.WriteLine(i + " identifier " + arrTblList[i].ToString());
                ActivityList = ActivityList + ";" + arrTblList[i].ToString();
            }
            Console.WriteLine(" actual Activity is : " + ActivityList);
            ActivityList = ActivityList.Replace("ApproveReject", "");
            return ActivityList;

         


        }

    }
}

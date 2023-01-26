using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenterPages.Pages.Common
{
    public class WorkOrder : Page
    {
        //string Administrationmenu = "a[id$='TabBar:AdminTab']";
        //string EventmessageOption = "a[id$='Admin:MenuLinks:Admin_Messages']";
        //string resumeBtn = "a[id$=':MessagingDestinationControlList_ResumeButton']";
        //string SuspendBtn = "a[id$=':MessagingDestinationControlList_SuspendButton']";
        //string DesktopTab = "a[id$='TabBar:DesktopTab']";
        //string[] arrTblList;
        string tablePolicyJobDeatilsPanel = "table[id='PolicyFile_Jobs:Policy_JobsScreen:DetailPanel:JobsLV']";
        public WorkOrder(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(tablePolicyJobDeatilsPanel);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(tablePolicyJobDeatilsPanel));
        }

        public void VerifyWorkOrderStatus(string ExpectedWorkOrderStatus)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("PolicyFile_Jobs:Policy_JobsScreen:DetailPanel:JobsLV")).ToList();
            Console.WriteLine("Policy Info Job details table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            var tds = rows[1].FindElements(By.TagName("td"));
            var CellSpan = tds[4].FindElements(By.TagName("span"));
            string ActualWorkOrderStatus = CellSpan[0].GetAttribute("value");
            if (ActualWorkOrderStatus.ToLower().Equals(ExpectedWorkOrderStatus.ToLower()))
            {
                Console.WriteLine("WorkOrder Status Matched");
            }
            else
            {
                Console.WriteLine("WorkOrder Status do not Matched " + " Expected status is " + ExpectedWorkOrderStatus + " actual status is " + ActualWorkOrderStatus);
                Assert.Fail("WorkOrder Status do not Matched " + " Expected status is " + ExpectedWorkOrderStatus + " actual status is " + ActualWorkOrderStatus);
            }

        }



    }
}

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

namespace PolicyCenter9Pages.Pages.Common
{
    public class WorkOrder_PC9 : Page
    {
        string lblPolicyTransaction = "span[id$='PolicyFile_Jobs:Policy_JobsScreen:0']";
        public WorkOrder_PC9(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyTransaction);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyTransaction));
        }

        public void VerifyWorkOrderStatusPC9(string ExpectedWorkOrderStatus)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("PolicyFile_Jobs:Policy_JobsScreen:DetailPanel:JobsLV-body")).ToList();
            Console.WriteLine("Policy Info Job details table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("rows object count is " + rows.Count());
            var tds = rows[0].FindElements(By.TagName("td"));
            Console.WriteLine("tds object count is " + tds.Count());
            var CellSpan = tds[3].FindElements(By.TagName("div"));
            string ActualWorkOrderStatus = CellSpan[0].Text;
            Console.WriteLine("text is " + ActualWorkOrderStatus);
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

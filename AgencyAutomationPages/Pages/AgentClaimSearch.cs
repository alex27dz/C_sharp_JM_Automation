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
    public class AgentClaimSearch : Page
    {
        //[FindsBy(How = How.XPath, Using = "//div[text()[contains(.,'Account Information')]]")]
        //public IWebElement lblAccountInformation;

        //string lblAccountInformation = "div[text()[contains(.,'Account Information')]]";

        string selectentries = "select[name='idDataTable_length']";

        string textLossDate = "input[id$='FNOLRequest_LossDate']";
        string texareatLossDescription = "textarea[id$='FNOLRequest_LossDescription']";
        string textLossCause = "input[placeholder[contains(.,'Select Loss Code')]]";
        string btnnext = "input[id$='btnNext']";
        string btnsubmit = "input[id$='btnSubmit']";


        public AgentClaimSearch(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }


        public override void VerifyPage()
        {
            pause();
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'Claims Search')]]"));

        }


        public void getLatestClaim()
        {
            UIAction(selectentries, "3", "selectbox");
            pause();
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("idDataTable")).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[rows.Count - 1].FindElements(By.TagName("td"));
            var childitem = tds[0].FindElements(By.TagName("a"));
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "CLAIMNO", childitem[0].Text);





        }

        public void newClaimAdded()
        {
            UIAction(selectentries, "3", "selectbox");
            pause();
            string ClaimNo;
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("idDataTable")).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[rows.Count - 2].FindElements(By.TagName("td"));
            var childitem = tds[0].FindElements(By.TagName("a"));
            DataStorage temp = new DataStorage();
            ClaimNo = temp.GetTempValue("CLAIMNO");
            if (ClaimNo.Equals(childitem[0].Text))
            {
                Console.WriteLine("New Claim is created");
                var tds1 = rows[rows.Count - 1].FindElements(By.TagName("td"));
                var childitem1 = tds1[0].FindElements(By.TagName("a"));
                Console.WriteLine("Newely created Claim is " + childitem1[0].Text);
                temp.StoreTempValue("guidewire", "CLAIMNO", childitem1[0].Text);
            }
            else
            {
                Console.WriteLine("New Claim is not created");
                Assert.Fail("New Claim is not created");
            }
        }

    }
}

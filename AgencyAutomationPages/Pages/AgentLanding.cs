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
    public class AgentLanding : Page
    {
        string linkAgentProfile = "a[id$='ProfileLink']";
        string inputPassword = "input[id$='Password']";
        string login = "input[id$='submitButton']";
        string linkHome = "a[id$='HomeLink']";
        string linkPolicy = "a[id$='PolicyLink']";
        string linkClaim = "a[id$='ClaimsLink']";
        string linkBilling = "a[id$='BillingLink']";
        string linkReport = "a[id$='ReportsLink']";
        string policyProducerCode = "select[id$='ProdCode']";
        string policyOffering = "select[id$='Offering']";
        string policyStatus = "select[id$='PolicyStatus']";
        string searchStatus = "select[id$='Status']";

        string btnSearch = "input[id$='btnSubmit']";
        string radioSerarchByPolicy = "input[id$='SearchBy'][value='Policy']";
        string radioSerarchByAccount = "input[id$='SearchBy'][value='Account']";
        string txtPolicynumber = "input[id$='PolicyNumber']";
        string txtsearchClaim = "input[id$='ClaimNumberSearch']";
        string btnStartClaim = "input[id$='btnSubmit'][value='Start Claim']";
        string btnSearchClaim = "input[id$='btnSubmit'][value='Search']";

        //string linkAdvancedSearch = "a[text()[contains(.,'Advanced Search')]];
        //  string linkManageMyProfile = "a[contains(.,'Manage My Profile')]";

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Manage My Profile')]]")]
        public IWebElement linkManageMyProfile;

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'LogOff')]]")]
        public IWebElement linkLogOff;

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Advanced Search')]]")]
        public IWebElement linkAdvancedSearch;

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Edit Password')]]")]
        public IWebElement linkEditPassword;




        public AgentLanding(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            pause();
            pause();
        }

        public void ClickMasterAgentProfile()
        {
            UIAction(linkAgentProfile, String.Empty, "a");
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(linkAgentProfile);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(linkAgentProfile));

        }

        public void clicklogOff()
        {
            linkLogOff.Click();
            System.Threading.Thread.Sleep(5000);
        }

        public void clickManageMyProfile()
        {

            linkManageMyProfile.Click();
        }

        public void ClickEditPassword()
        {
            linkEditPassword.Click();
        }

        public void ManageleftNavigation(string NavigationOption)
        {
            pause();
            pause();
            List<IWebElement> linkNavigation;
            linkNavigation = driver.FindElements(By.XPath("//div[@class='leftNavButtonContainer']")).ToList();
            for (int i = 0; i <= linkNavigation.Count - 1; i++)
            {
                Console.WriteLine("COunter is " + i);
                Console.WriteLine("Text is " + linkNavigation[i].Text);
                Console.WriteLine("Expected is " + NavigationOption);
                if (linkNavigation[i].Text.ToLower().Equals(NavigationOption.ToLower()))
                {
                    linkNavigation[i].Click();
                    break;
                }
            }

            pause();

        }

        public void VerifyIfUsersAndPermissionsTab(string tabOption)
        {
            pause();
            pause();
            bool usersandpermissionstab = true;
            List<IWebElement> linkNavigation;
            linkNavigation = driver.FindElements(By.XPath("//div[@class='leftNavButtonContainer']")).ToList();
            for (int i = 0; i <= linkNavigation.Count - 1; i++)
            {
                Console.WriteLine("COunter is " + i);
                Console.WriteLine("Text is " + linkNavigation[i].Text);
                if (linkNavigation[i].Text.ToLower().Equals("users and permissions"))
                {
                    usersandpermissionstab = false;
                    break;
                }
            }
            if (tabOption.ToLower().Equals("yes"))
            {
                if (!(usersandpermissionstab))
                {
                    Console.WriteLine("users and permissions tab is displayed which is expected");
                }
                else
                {
                    Console.WriteLine("users and permissions tab is not displayed which is not expected");
                    Assert.Fail("users and permissions tab is not displayed which is not expected");
                }
            }
            else
            {
                if (!(usersandpermissionstab))
                {
                    Console.WriteLine("users and permissions tab is displayed which is not expected");
                    Assert.Fail("users and permissions tab is displayed which is not expected");
                }
                else
                {
                    Console.WriteLine("users and permissions tab is not displayed which is expected");
                }

            }
        }

        public void clickonTopNavigationOption(string MenuOption)
        {
            switch ((MenuOption.ToLower()).Trim())
            {
                case "home":
                    UIAction(linkHome, string.Empty, "a");
                    break;
                case "policy":
                    UIAction(linkPolicy, string.Empty, "a");
                    break;
                case "claims":
                    UIAction(linkClaim, string.Empty, "a");
                    break;
                case "billing":
                    UIAction(linkBilling, string.Empty, "a");
                    break;
                case "reports":
                    UIAction(linkReport, string.Empty, "a");
                    break;

                default:
                    break;

            }
            pause();
            pause();
        }

        public void clickonAdvancedSearch()
        {
            pause();
            linkAdvancedSearch.Click();
        }

        public void searchBilling(string Producer, string status)
        {
            pause();
            UIAction(policyProducerCode, Producer, "selectbox");
            UIAction(searchStatus, status, "selectbox");
            UIAction(btnSearch, String.Empty, "button");

        }

        public void clickPolicyfromBillingSearchTable()
        {
            WaitUntilElementVisible(driver, By.XPath("//table[@id='idDataTable']"));
            pause();
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("idDataTable")).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var ths = rows[1].FindElements(By.TagName("th"));
            Console.WriteLine("TH count is " + ths.Count());
            for (int i = 0; i < ths.Count(); i++)
            {
                Console.WriteLine("TH class is " + ths[i].GetAttribute("Class"));
            }
            var childitem = ths[1].FindElements(By.TagName("a"));
            DataStorage tempData = new DataStorage();
            Console.WriteLine("POlicy number is " + childitem[0].Text);
            string policy = childitem[0].Text;
            policy = policy.Substring(0, (policy.Length - 2));
            Console.WriteLine("Updated POlicy number is " + policy);
            tempData.StoreTempValue("guidewire", "PLCYNO", policy);
            childitem[0].Click();


        }

        public void searchPolicy(string searchBy, string Producer, string Offering, string status)
        {
            switch ((searchBy.ToLower()).Trim())
            {
                case "policy":
                    UIAction(radioSerarchByPolicy, String.Empty, "button");
                    break;
                case "account":
                    UIAction(radioSerarchByAccount, String.Empty, "button");
                    break;
                default:
                    break;
            }
            pause();
            UIAction(policyProducerCode, Producer, "selectbox");
            UIAction(policyOffering, Offering, "selectbox");
            UIAction(policyStatus, status, "selectbox");
            UIAction(btnSearch, String.Empty, "button");


        }


        public void clickAccountfromSearchTable()
        {
            WaitUntilElementVisible(driver, By.XPath("//table[@id='idDataTable']"));
            IList<IWebElement> Account = driver.FindElements(By.XPath("//td[@class='col-md-offset-1 sorting_1']")).ToList();
            System.Console.WriteLine("account value is " + Account[0].Text);
            ScenarioContext.Current["ACCOUNT"] = Account[0].Text;
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
            Account[0].FindElement(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/AccountInformation/')]]")).Click();

        }

        public void clickPolicyfromSearchTable()
        {

            WaitUntilElementVisible(driver, By.XPath("//table[@id='idDataTable']"));
            IList<IWebElement> Policy = driver.FindElements(By.XPath("//td[@class='col-md-offset-1']")).ToList();
            System.Console.WriteLine("Policy value is " + Policy[0].Text);
            ScenarioContext.Current["Policy"] = Policy[0].Text;
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["Policy"].ToString());
            Policy[0].FindElement(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/PolicyInformation/')]]")).Click();


        }

        public void clickFourthPolicyfromSearchTable()
        {

            WaitUntilElementVisible(driver, By.XPath("//table[@id='idDataTable']"));
            IList<IWebElement> Policy = driver.FindElements(By.XPath("//*[@id='idDataTable']/tbody/tr[1]/td[2]")).ToList();
            System.Console.WriteLine("Policy value is " + Policy[0].Text);
            ScenarioContext.Current["Policy"] = Policy[0].Text;
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["Policy"].ToString());
            Policy[0].FindElement(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/PolicyInformation/')]]")).Click();


        }

        public void setClaim(string policyNumber)
        {
            pause();
            UIAction(txtPolicynumber, policyNumber, "textbox");
            UIAction(btnStartClaim, String.Empty, "a");
        }

        public void searchClaim(string policyNumber)
        {
            pause();
            UIAction(txtsearchClaim, policyNumber, "textbox");
            UIAction(btnSearchClaim, String.Empty, "a");
        }
    }
}

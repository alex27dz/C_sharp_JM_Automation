using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace AgencyAutomationPages.Pages
{
    public class AgentUsersandPermissions : Page
    {
        //string tblProfileManagment = "table[id$='userProfilePermTable']";
        //string tblInquiry = "table[id$='userInquiryPermTable']";
        //string tblReports = "table[id$='userInqReportsTable']";

        string[] arrTblList;



        string btnPreviousProfile = "li[id$='userProfilePermTable_previous']";
        string btnNextProfile = "li[id$='userProfilePermTable_next']";

        string btnPreviousInquiry = "li[id$='userInquiryPermTable_previous']";
        string btnNextInquiry = "li[id$='userInquiryPermTable_next']";

        string btnPreviousReports = "li[id$='userInqReportsTable_previous']";
        string btnNextReports = "li[id$='userInqReportsTable_next']";

        string btnAddUser = "input[class$='btn btn-default'][title='Add User']";



        public AgentUsersandPermissions(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnAddUser);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnAddUser));

        }



        public void clickAddUser()
        {
            UIAction(btnAddUser, string.Empty, "button");
        }

        public void SearchAgent()
        {
            IWebElement AgentName;
            string UserName = ScenarioContext.Current["AgentName"].ToString();
            // UserName = UserName.Replace(" ", ";");
            string[] arrname = UserName.Split(' ');
            string UserName1 = arrname[1] + "," + arrname[0];
            Console.WriteLine("First instance" + arrname[1]);
            Console.WriteLine("Second instance" + arrname[0]);

            AgentName = driver.FindElement(By.XPath("//a[text()[contains(.,'" + UserName1 + "')]]"));
            AgentName.Click();

        }
        public void SearchAgentRole(string Role)
        {
            IWebElement txtSearchProfile;
            IWebElement linkTab;
            pause();
            switch ((Role.ToLower()).Trim())
            {
                case "profile managment":
                    linkTab = driver.FindElement(By.XPath("//a[@title='profile-managment']"));
                    linkTab.Click();
                    pause();
                    Console.WriteLine("In logic");
                    pause();
                    System.Threading.Thread.Sleep(3000);
                    txtSearchProfile = driver.FindElement(By.XPath("//input[@aria-controls='userProfilePermTable'][@type='search']"));
                    txtSearchProfile.SendKeys(ScenarioContext.Current["AgentName"].ToString());
                    break;
                case "inquiry":
                    linkTab = driver.FindElement(By.XPath("//a[@title='inquiry']"));
                    Console.WriteLine(linkTab.GetAttribute("href"));
                    linkTab.Click();
                    pause();
                    txtSearchProfile = driver.FindElement(By.XPath("//input[@aria-controls='userInquiryPermTable'][@type='search']"));
                    txtSearchProfile.SendKeys(ScenarioContext.Current["AgentName"].ToString());
                    break;
                case "reports":
                    linkTab = driver.FindElement(By.XPath("//a[@title='reports']"));
                    Console.WriteLine(linkTab.GetAttribute("href"));
                    linkTab.Click();
                    pause();
                    txtSearchProfile = driver.FindElement(By.XPath("//input[@aria-controls='userInqReportsTable'][@type='search']"));
                    txtSearchProfile.SendKeys(ScenarioContext.Current["AgentName"].ToString());
                    break;
                case "personal line profile managment":
                    WaitUntilElementVisible(driver, By.Id("userPLProfilePermTable_filter"), 60);
                    linkTab = driver.FindElement(By.XPath("//div[@id='userPLProfilePermTable_filter']"));
                    //Console.WriteLine(linkTab.GetAttribute("href"));
                    linkTab.Click();
                    pause();
                    pause();
                    txtSearchProfile = driver.FindElement(By.XPath("//input[@aria-controls='userPLProfilePermTable'][@type='search']"));
                    txtSearchProfile.SendKeys(ScenarioContext.Current["AgentName"].ToString());
                    break;
                default:
                    break;

            }

        }


        public void SetAccessType(IWebElement Element1, string Access, string Accesstype)
        {
            IJavaScriptExecutor javascriptDriver = (IJavaScriptExecutor)driver;
            Dictionary<string, object> ElementAttributes = javascriptDriver.ExecuteScript("var items = {}; for (index = 0; index < arguments[0].attributes.length; ++index) { items[arguments[0].attributes[index].name] = arguments[0].attributes[index].value }; return items;", Element1) as Dictionary<string, object>;
            if (Accesstype.ToLower().Equals("yes"))
            {
                if (ElementAttributes.ContainsKey("checked"))
                {
                    Console.WriteLine(ElementAttributes["checked"].ToString() + " value ");
                    if (!(ElementAttributes["checked"].ToString().Equals("checked")))
                    {
                        Element1.Click();
                    }

                }
                else
                {
                    Element1.Click();
                }
            }
            else
            {
                if (ElementAttributes["checked"].ToString().Equals("checked"))
                {
                    Element1.Click();
                }


            }

        }
        public void verifyAccessType(IWebElement Element1, string Access, string Accesstype)
        {


            IJavaScriptExecutor javascriptDriver = (IJavaScriptExecutor)driver;
            Dictionary<string, object> ElementAttributes = javascriptDriver.ExecuteScript("var items = {}; for (index = 0; index < arguments[0].attributes.length; ++index) { items[arguments[0].attributes[index].name] = arguments[0].attributes[index].value }; return items;", Element1) as Dictionary<string, object>;

            if (Accesstype.ToLower().Equals("yes"))
            {
                if (ElementAttributes.ContainsKey("checked"))
                {
                    Console.WriteLine(ElementAttributes["checked"].ToString() + " value ");
                    if (ElementAttributes["checked"].ToString().Equals("checked"))
                    {
                        Console.WriteLine(Access + "  access control is correct");
                    }
                    else
                    {
                        Assert.Fail(Access + " access control is having issue");
                    }
                }
                else
                {
                    Assert.Fail(Access + " access control is having issue");
                }
            }
            else
            {
                if (!(ElementAttributes.ContainsKey("checked")))
                {
                    Console.WriteLine(Access + "  access control is correct");
                }
                else
                {
                    if (ElementAttributes["checked"].ToString().Equals("checked"))
                    {
                        Assert.Fail(Access + " access control is having issue");
                    }

                }
            }


        }

        public void VerifyReportAccessType(string LossRun, string RenewalStatus, string CommissionStatement, string AgencyAlmanc, string NewBusiness, string CLInformcePolicyListing)
        {
            IWebElement ChckLossRun;
            IWebElement ChckRenewalStatus;
            IWebElement ChckCommissionStatement;
            IWebElement ChckAgencyAlmanc;
            IWebElement ChckNewBusiness;
            IWebElement ChckCLInformcePolicyListing;
            string UserName = ScenarioContext.Current["Email"].ToString();

            ChckLossRun = driver.FindElement(By.XPath("//input[@id='LossRuns'][@user='" + UserName + "']"));
            ChckRenewalStatus = driver.FindElement(By.XPath("//input[@id='RenewalStatus'][@user='" + UserName + "']"));
            ChckCommissionStatement = driver.FindElement(By.XPath("//input[@id='CommissionStatement'][@user='" + UserName + "']"));
            ChckAgencyAlmanc = driver.FindElement(By.XPath("//input[@id='AgencyAlmanac'][@user='" + UserName + "']"));
            ChckNewBusiness = driver.FindElement(By.XPath("//input[@id='NewBusiness'][@user='" + UserName + "']"));
            ChckCLInformcePolicyListing = driver.FindElement(By.XPath("//input[@id='CLInforcePolicyListing'][@user='" + UserName + "']"));

            verifyAccessType(ChckLossRun, "LossRun", LossRun);
            verifyAccessType(ChckRenewalStatus, "RenewalStatus", RenewalStatus);
            verifyAccessType(ChckCommissionStatement, "CommissionStatement", CommissionStatement);
            verifyAccessType(ChckAgencyAlmanc, "AgencyAlmanc", AgencyAlmanc);
            verifyAccessType(ChckNewBusiness, "NewBusiness", NewBusiness);
            verifyAccessType(ChckCLInformcePolicyListing, "CLInformcePolicyListing", CLInformcePolicyListing);
        }
        public void VerifyInquiryAccessType(string Read, string FNOL)
        {

            IWebElement ChckFNOLAcccess;
            IWebElement ChckReadAcccess;
            string UserName = ScenarioContext.Current["Email"].ToString();

            ChckReadAcccess = driver.FindElement(By.XPath("//input[@id='inquiry_Read_IsChecked'][@user='" + UserName + "']"));
            ChckFNOLAcccess = driver.FindElement(By.XPath("//input[@id='FNOL'][@user='" + UserName + "']"));

            verifyAccessType(ChckReadAcccess, "Read", Read);
            verifyAccessType(ChckFNOLAcccess, "FNOL", FNOL);


        }


        public void ResetProfileManagmentAccessType(string Admin, string Read, string ProducerAdmin)
        {
            IWebElement ChckAdminAcccess;
            IWebElement ChckProducerAcccess;
            IWebElement ChckReadAcccess;
            string UserName = ScenarioContext.Current["Email"].ToString();

            ChckAdminAcccess = driver.FindElement(By.XPath("//input[@id='profile_Admin_IsChecked'][@user='" + UserName + "']"));
            ChckReadAcccess = driver.FindElement(By.XPath("//input[@id='profile_Read_IsChecked'][@user='" + UserName + "']"));
            ChckProducerAcccess = driver.FindElement(By.XPath("//input[@id='profile_ProducerAdmin_IsChecked'][@user='" + UserName + "']"));

            SetAccessType(ChckAdminAcccess, "Admin", Admin);
            pause();
            SetAccessType(ChckReadAcccess, "Read", Read);
            pause();
            SetAccessType(ChckProducerAcccess, "ProducerAdmin", ProducerAdmin);
            pause();
            pause();

        }
        public void VerifyProfileManagmentAccessType(string Admin, string Read, string ProducerAdmin)
        {

            IWebElement ChckAdminAcccess;
            IWebElement ChckProducerAcccess;
            IWebElement ChckReadAcccess;
            string UserName = ScenarioContext.Current["Email"].ToString();

            ChckAdminAcccess = driver.FindElement(By.XPath("//input[@id='profile_Admin_IsChecked'][@user='" + UserName + "']"));
            ChckReadAcccess = driver.FindElement(By.XPath("//input[@id='profile_Read_IsChecked'][@user='" + UserName + "']"));
            ChckProducerAcccess = driver.FindElement(By.XPath("//input[@id='profile_ProducerAdmin_IsChecked'][@user='" + UserName + "']"));

            verifyAccessType(ChckAdminAcccess, "Admin", Admin);
            verifyAccessType(ChckReadAcccess, "Read", Read);
            verifyAccessType(ChckProducerAcccess, "ProducerAdmin", ProducerAdmin);

        }


        //public void VerifyReportsManagmentAccessType(string LossRun, string RenewalStatus, string CommissionStatement, string AgencyAlmanac, string NewBusiness, string CLInforcePolicyListing )
        //{

        //     string UserName = ScenarioContext.Current["Email"].ToString();

        //    IWebElement ChckLossRuns = driver.FindElement(By.XPath("//input[@id='LossRuns'][@user='" + UserName + "']"));
        //    IWebElement ChckRenewalStatus = driver.FindElement(By.XPath("//input[@id='RenewalStatus'][@user='" + UserName + "']"));
        //    IWebElement ChckCommissionStatement = driver.FindElement(By.XPath("//input[@id='CommissionStatement'][@user='" + UserName + "']"));
        //    IWebElement ChckAgencyAlmanac = driver.FindElement(By.XPath("//input[@id='AgencyAlmanac'][@user='" + UserName + "']"));
        //    IWebElement ChckNewBusiness = driver.FindElement(By.XPath("//input[@id='NewBusiness'][@user='" + UserName + "']"));
        //    IWebElement ChckCLInforcePolicyListing = driver.FindElement(By.XPath("//input[@id='CLInforcePolicyListing'][@user='" + UserName + "']"));

        //    verifyAccessType(ChckLossRuns, "Admin", Admin);
        //    verifyAccessType(ChckReadAcccess, "Read", Read);
        //    verifyAccessType(ChckProducerAcccess, "ProducerAdmin", ProducerAdmin);

        //}

        public void VerifyAgentAccessType(string Role, string AccessType)
        {
            SearchAgentRole(Role);
            pause();
            switch ((Role.ToLower()).Trim())
            {
                case "profile managment":
                    List<IWebElement> TableInputElements = driver.FindElements(By.Id("userProfilePermTable")).ToList();
                    Console.WriteLine("count of array for account " + TableInputElements.Count());
                    arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                    for (int i = 0; i < arrTblList.Count(); i++)
                    {
                        Console.WriteLine(i + " identifier " + arrTblList[i].ToString());
                    }




                    break;
                case "inquiry":
                    TableInputElements = driver.FindElements(By.Id("userInquiryPermTable")).ToList();
                    Console.WriteLine("count of array for account " + TableInputElements.Count());
                    arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                    for (int i = 0; i < arrTblList.Count(); i++)
                    {
                        Console.WriteLine(i + " identifier " + arrTblList[i].ToString());
                    }

                    break;
                case "reports":
                    TableInputElements = driver.FindElements(By.Id("userInqReportsTable")).ToList();
                    Console.WriteLine("count of array for account " + TableInputElements.Count());
                    arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                    for (int i = 0; i < arrTblList.Count(); i++)
                    {
                        Console.WriteLine(i + " identifier " + arrTblList[i].ToString());
                    }
                    break;

                default:
                    break;

            }
        }
    }
}

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
    public class ReportsPage : Page
    {
        //string AgentInfoContainer = "div[id$='agentInfoContainer']";
        //string txtLastName = "input[id$='LastName']";

        //string selectPhoneType = "select[id$='ContactInfo_PrimaryPhoneType_SelectedPrimaryPhoneTypeValue']";
        //string txtWorkPhone = "input[id$='ContactInfo_WorkPhone']";
        //string txtCellPhone = "input[id$='ContactInfo_CellPhone']";
        //string txtFax = "input[id$='ContactInfo_Fax']";
        //string txtEmail = "input[id$='ContactInfo_Email']";
        //string btnSaveUser = "input[id$='producerAccessButton']";



        public ReportsPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//div[@class='TableContent']/b[text()[.='Reports']"));
        }

        public void VerifyReportName(string Reports)
        {
            List<IWebElement> ReportObj;
            if (Reports.Contains(";"))
            {
                string[] Reports_field = Reports.Split(';');
                for (int i = 0; i < Reports_field.Count(); i++ )
                {
                    ReportObj = driver.FindElements(By.XPath("//a[@class='BOPLink'][text()[.='" + Reports_field[i] + "']]")).ToList();
                    if (ReportObj.Count() > 0)
                    {
                        Console.WriteLine(Reports_field[i] + " Report exist");
                    }
                    else
                    {
                        Assert.Fail(Reports_field[i] + " Report do not exist");
                    }
                }
            }
            else
            {
              
                ReportObj = driver.FindElements(By.XPath("//a[@class='BOPLink'][text()[.='" + Reports + "']]")).ToList();
                if(ReportObj.Count()>0)
                {
                    Console.WriteLine(Reports + " Report exist");
                }
                else
                {
                    Assert.Fail(Reports + " Report do not exist");
                }
            }
        }


    }
}

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
using TechTalk.SpecFlow.Assist;



namespace PolicyCenterPages.Pages.Common
{
   public class CLReinsurancePage : Page
    {
        string txtAttachmentPoint = "input[id$='NewAgreementPopup:AgreementScreen:AgreementCoverageInputSet:AttachmentPoint']";
        string txtCoverageLimit = "input[id$='NewAgreementPopup:AgreementScreen:AgreementCoverageInputSet:Limit']";
        string txtCommission = "input[id$='NewAgreementPopup:AgreementScreen:Commission']";
        string txtCededPremium = "input[id$='NewAgreementPopup:AgreementScreen:AgreementPAndCInputSet:CededPremium']";
        string btnFac = "a[id$=':PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV_tb:AddFacButton']";
        string btnFacCreateNew = "span[id$=':PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV_tb:AddFacButton:NewFacAgreementMenuItem']";
        string btnExcessofLossFacultative = "a[id$=':PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV_tb:AddFacButton:NewFacAgreementMenuItem:0:NewFac']";
        string txtAgreementNumber = "input[id$='NewAgreementPopup:AgreementScreen:AgreementNumber']";
        string btnAdd = "a[id$='NewAgreementPopup:AgreementScreen:ParticipantsLV_tb:Add']";
        string btnAddfromAddressBook = "a[id$='NewAgreementPopup:AgreementScreen:ParticipantsLV_tb:Add:ParticipantSearch']";
        string txtContactName = "input[id$='ContactSearchPopup:ContactSearchScreen:BasicContactInfoInputSet:Name']";
        string btnSearch = "span[id$='ContactSearchPopup:ContactSearchScreen:SearchAndResetInputSet:SearchLinksInputSet:Search_link']";
        string btnok = "a[id$='NewAgreementPopup:AgreementScreen:Update']";


        string txtName = "input[id$='NewAgreementPopup:AgreementScreen:Name']";
        string Administrationmenu = "a[id$='TabBar:AdminTab']";
        string EventmessageOption = "a[id$='Admin:MenuLinks:Admin_Messages']";
        string resumeBtn = "a[id$=':MessagingDestinationControlList_ResumeButton']";
        string SuspendBtn = "a[id$=':MessagingDestinationControlList_SuspendButton']";
        string DesktopTab = "a[id$='TabBar:DesktopTab']";
        string[] arrTblList;
        public CLReinsurancePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(Administrationmenu);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//div[id$='SubmissionWizard/Reinsurance']"));

        }

    public void ManageClReinsurance()
        {
            List<IWebElement> reservetableObj;
            string CoverageGroup;
            string SumInsured;
            string PMLAmount;
            string FacLimit;
            reservetableObj = driver.FindElements(By.Id("SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:3")).ToList();
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            int rocCount = rows.Count();
           
            for (int i = 1; i <= rocCount; i++)
            {
                List<IWebElement> reservetableObj1;
                reservetableObj1 = driver.FindElements(By.Id("SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:3")).ToList();
                var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
                pause();
                if (i!= 1)
                {
                    var tds = rows1[i-1].FindElements(By.TagName("td"));
                    CoverageGroup = tds[2].Text;
                    SumInsured = tds[3].Text;
                    PMLAmount = tds[4].Text;
                }
                else
                {
                    var tds = rows1[i].FindElements(By.TagName("td"));
                    CoverageGroup = tds[2].Text;
                    SumInsured = tds[3].Text;
                    PMLAmount = tds[4].Text;
                }
                SumInsured = SumInsured.Replace("$", "");
                SumInsured = SumInsured.Replace(",", "");
                pause();
                Console.WriteLine("CoverageGroup tds[2].Text is " + CoverageGroup);
                Console.WriteLine("SumInsured  tds[3].Text  is " + SumInsured);
                Console.WriteLine("PMLAmount  tds[4].Text  is " + PMLAmount);
                GetFacLimit(CoverageGroup, SumInsured, i+1);
                //pause();
                pause();
                Console.WriteLine("I am back in logic");
                pause();
             

            }
            //Console.WriteLine("Row count is " + rows.Count());
            //var tds = rows[RowCount - 1].FindElements(By.TagName("td"));
        }

        public void GetFacLimit(string CoverageGroup,string  SumInsured, int counter)
        {
            System.Threading.Thread.Sleep(3000);
            double InsuredAmount = double.Parse(SumInsured);
            string FacLimitValue = "";
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV']")).ToList();
            Console.WriteLine("Fac table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            int Pre_RowCount = rows.Count;
            System.Console.WriteLine(" Pre_RowCount " + Pre_RowCount);
            if (Pre_RowCount > 1)
            {
                var tds = rows[(rows.Count)-1].FindElements(By.TagName("td"));
                FacLimitValue = tds[5].Text;
                FacLimitValue = FacLimitValue.Replace("$", "");
                FacLimitValue = FacLimitValue.Replace(",", "");
                double FacLimitAmount = double.Parse(FacLimitValue);
                if (InsuredAmount > FacLimitAmount)
                {

                    AddFac(FacLimitValue, InsuredAmount);
                    System.Console.WriteLine("inide paramater");
                    List<IWebElement> reservetableObj_temp;
                    reservetableObj_temp = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV']")).ToList();
                    var rows_temp = reservetableObj_temp[0].FindElements(By.TagName("tr"));
                    if (rows_temp.Count>Pre_RowCount)
                    {
                        Console.WriteLine("Facultative is  added successfully");
                    }
                    else
                    {
                        Console.WriteLine("Facultative is not added successfully");
                        Assert.Fail("Facultative is not added successfully");
                    }
                }
            }
            else
            {
                AddFac("50000", InsuredAmount);
                System.Console.WriteLine("default paramater");
            }

            List<IWebElement> reservetableObj2;
            reservetableObj2 = driver.FindElements(By.Id("SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:3")).ToList();
            var rows2 = reservetableObj2[0].FindElements(By.TagName("tr"));
            System.Console.WriteLine("counter value is " + counter);
            System.Console.WriteLine(" table counter value is " + rows2.Count);
            if (rows2.Count < counter)
            {
                rows2[counter-2].Click();
            }
            else
            {
                rows2[counter-1].Click();
            }
            
        }

        public string GetUniqueValue()
        {
            DateTime myDateTime = DateTime.Now;
            //   string year = myDateTime.Year.ToString();
            // string month = myDateTime.Month.ToString();
            string day = myDateTime.Day.ToString();
            string hour = myDateTime.Hour.ToString();
            string minute = myDateTime.Minute.ToString();
            string second = myDateTime.Second.ToString();
            string GetUniqueValue = day + hour + minute + second;
            return GetUniqueValue;


        }

        public void AddFac(string limit, double SumInsured)
        {



            Console.WriteLine("limit value is " + limit);
            Console.WriteLine("SumInsured value is " + SumInsured.ToString());
            string CededPremium_Temp;
            UIAction(btnFac, string.Empty, "a");
            pause();
            UIAction(btnFacCreateNew, string.Empty, "a");
            pause();
            UIAction(btnExcessofLossFacultative, string.Empty, "a");
            WaitUntilElementIsDisplayed(driver, By.XPath("//inpt[id='NewAgreementPopup:AgreementScreen:AgreementNumber']"));
            UIAction(txtAgreementNumber, GetUniqueValue(), "textbox");
            
            UIAction(txtName, "Name"+GetUniqueValue(), "textbox");
            UIAction(txtCommission, "20", "textbox");
            string SumInsuredstring = SumInsured.ToString();
            Console.WriteLine("length of SumInsuredstring.Length " + SumInsuredstring.Length);
            if (SumInsuredstring.Length < 5)
            {
                CededPremium_Temp = "2";
            }
            else if (SumInsuredstring.Length < 7)
            {
                CededPremium_Temp = "20";
            }
            else
            {
                CededPremium_Temp = "200";
            }
            UIAction(txtCededPremium, CededPremium_Temp, "textbox");

            //System.Threading.Thread.Sleep(5000);
            pause();
            pause();
            UIAction(txtAttachmentPoint, string.Empty, "a");
            UIAction(txtAttachmentPoint, limit, "textbox");

            pause();
            pause();
            //System.Threading.Thread.Sleep(1000);
            UIAction(txtCoverageLimit, string.Empty, "a");
            UIAction(txtCoverageLimit, SumInsured.ToString(), "textbox");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab);
            pause();
            pause();
             UIAction(btnAdd, string.Empty, "a");
            pause();
            UIAction(btnAdd, string.Empty, "a");
            pause();
            UIAction(btnAddfromAddressBook, string.Empty, "a");
            WaitUntilElementIsDisplayed(driver, By.XPath("//inpt[id='ContactSearchPopup:ContactSearchScreen:BasicContactInfoInputSet:Name']"));
            UIAction(txtContactName, "tictoc", "textbox");
            UIAction(btnSearch, string.Empty, "a");


            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("ContactSearchPopup:ContactSearchScreen:ContactSearchResultsLV")).ToList();
            Console.WriteLine("Risk table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            var tds = rows[1].FindElements(By.TagName("td"));
            var CellSpan = tds[0].FindElements(By.TagName("span"));
            try
            {
                CellSpan[0].Click();
            }
            catch (Exception e)
            {

            }

            pause();
            pause();
            WaitUntilElementIsDisplayed(driver, By.XPath("//inpt[id='NewAgreementPopup:AgreementScreen:AgreementNumber']"));
            UIAction(btnok, string.Empty, "a");
            pause();
            Console.WriteLine("I have clicked ok");



        }

    }
}

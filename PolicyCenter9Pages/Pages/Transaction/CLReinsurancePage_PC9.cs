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

namespace PolicyCenter9Pages.Pages.Transaction
{
    public class CLReinsurancePage_PC9 : Page
    {
        string AgreementNumber = "";
        string btnok = "span[id$='NewAgreementPopup:AgreementScreen:Update-btnInnerEl']";
        string btnSearch = "a[id$='ContactSearchPopup:ContactSearchScreen:SearchAndResetInputSet:SearchLinksInputSet:Search']";
        string btnAddfromAddressBook = "span[id$=':AgreementScreen:ParticipantsLV_tb:Add:ParticipantSearch-textEl']";
        string btnAdd = "span[id$=':AgreementScreen:ParticipantsLV_tb:Add-btnInnerEl']";
        string btnFac = "span[id$=':PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV_tb:AddFacButton-btnInnerEl']";
        string lblReinsurance = "span[id= 'SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:ttlBar']";
        string btnFacCreateNew = "span[id$= 'PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV_tb:AddFacButton:NewFacAgreementMenuItem-textEl']";
        string btnExcessofLossFacultative = "span[id$='SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV_tb:AddFacButton:NewFacAgreementMenuItem:0:NewFac-textEl']";
        string lblFacultative = "span[id$= 'NewAgreementPopup:AgreementScreen:ttlBar']";
        string lblFacultativeEdit = "span[id$= 'EditAgreementPopup:AgreementScreen:ttlBar']";
        string txtAgreementNumber = "input[id$= ':AgreementScreen:AgreementNumber-inputEl']";
        string txtName = "input[id$= ':AgreementScreen:Name-inputEl']";
        string txtContactName = "input[id$= 'ContactSearchPopup:ContactSearchScreen:BasicContactInfoInputSet:Name']";
        string txtCededPremium = "input[id$= ':AgreementScreen:AgreementPAndCInputSet:CededPremium-inputEl']";
        string txtCommission = "input[id$= ':AgreementScreen:Commission-inputEl']";
        string txtZipCode = "input[id= 'ContactSearchPopup:ContactSearchScreen:AddressOwnerAddressInputSet:globalAddressContainer:GlobalAddressInputSet:PostalCode-inputEl']";
        string txtAttachmentPoint = "input[id$= ':AgreementScreen:AgreementCoverageInputSet:AttachmentPoint-inputEl']";
        string txtCoverageLimit = "input[id$= ':AgreementScreen:AgreementCoverageInputSet:Limit-inputEl']";
        string btnSelectAddress = "a[id= 'ContactSearchPopup:ContactSearchScreen:ContactSearchResultsLV:0:_Select']";
        string btnValidate = "span[id='EditAgreementPopup:AgreementScreen:ValidateButton-btnInnerEl']";
        string btnMakeActive = "span[id='EditAgreementPopup:AgreementScreen:MakeActiveButton-btnInnerEl']";
        string lblvalid = "//div[text()='This agreement is valid']";
        string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";


        public CLReinsurancePage_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblReinsurance);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblReinsurance));
        }

        public void ManageClReinsurance_PC9()
        {
            List<IWebElement> reservetableObj;
            string CoverageGroup;
            string SumInsured;
            string PMLAmount;
            string FacLimit;
            reservetableObj = driver.FindElements(By.Id("SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:2")).ToList();
            System.Console.WriteLine("reservetableObj count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            System.Console.WriteLine("row count is " + rows.Count());
            int rocCount = rows.Count();
            for (int i = 0; i < rocCount; i++)
            {
                System.Console.WriteLine("loop counter is " + i);
                List<IWebElement> reservetableObj1;
                reservetableObj1 = driver.FindElements(By.Id("SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:2")).ToList();
                var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
                pause();
                System.Console.WriteLine("reservetableObj1 count for ELSE is " + reservetableObj.Count());
                var tds = rows1[i].FindElements(By.TagName("td"));
                CoverageGroup = tds[1].Text;
                SumInsured = tds[2].Text;
                PMLAmount = tds[3].Text;
                System.Console.WriteLine("reservetableObj1 count for ELSE is " + reservetableObj.Count());
                System.Console.WriteLine("row1 count for ELSE is " + rows1.Count());
                System.Console.WriteLine("TD count for ELSE is" + tds.Count());
                SumInsured = SumInsured.Replace("$", "");
                SumInsured = SumInsured.Replace(",", "");
                pause();
                Console.WriteLine("CoverageGroup tds[2].Text is " + CoverageGroup);
                Console.WriteLine("SumInsured  tds[3].Text  is " + SumInsured);
                Console.WriteLine("PMLAmount  tds[4].Text  is " + PMLAmount);
                GetFacLimit(CoverageGroup, SumInsured, i + 1);
            }
            UIActionExt(By.XPath("//span[text()='Risk Analysis']"), "ispresent");
            UIActionExt(By.XPath("//span[text()='Risk Analysis']"), "click");
            WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));

        }


        public void GetFacLimit(string CoverageGroup, string SumInsured, int counter)
        {
            double InsuredAmount = double.Parse(SumInsured);
            string FacLimitValue = "";
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV-body")).ToList();
            Console.WriteLine("Fac table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            int Pre_RowCount = rows.Count;
            System.Console.WriteLine(" Pre_RowCount " + Pre_RowCount);
            if (Pre_RowCount > 0)
            {
                var tds = rows[(rows.Count) - 1].FindElements(By.TagName("td"));
                FacLimitValue = tds[5].Text;
                FacLimitValue = FacLimitValue.Replace("$", "");
                FacLimitValue = FacLimitValue.Replace(",", "");
                Console.WriteLine("InsuredAmount is " + InsuredAmount);
              
                double FacLimitAmount = double.Parse(FacLimitValue);
                Console.WriteLine("FacLimitAmount is " + FacLimitAmount);
                if (InsuredAmount > FacLimitAmount)
                {
                    AddFac(FacLimitValue, InsuredAmount);
                    System.Console.WriteLine("inide paramater");
                    List<IWebElement> reservetableObj_temp;
                    reservetableObj_temp = driver.FindElements(By.Id("SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV-body")).ToList();
                    Console.WriteLine("Fac second round table object count is " + reservetableObj_temp.Count());
                    var rows_temp = reservetableObj_temp[0].FindElements(By.TagName("tr"));
                    Console.WriteLine("rows_temp.Count is " + rows_temp.Count);
                    Console.WriteLine("Pre_RowCount is " + Pre_RowCount);
                    if (rows_temp.Count > Pre_RowCount)
                    {
                        Console.WriteLine("Facultative is  added successfully");
                        ValidateFacc();
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
                ValidateFacc();
            }
        }


        public void AddFac(string limit, double SumInsured)
        {
            Console.WriteLine("limit value is " + limit);
            Console.WriteLine("SumInsured value is " + SumInsured.ToString());
            string CededPremium_Temp;
            UIActionExt(By.CssSelector(btnFac), "click");
            driver.FindElement(By.CssSelector(btnFac)).SendKeys(Keys.ArrowDown);
            UIActionExt(By.CssSelector(btnFacCreateNew), "ispresent");
            driver.FindElement(By.CssSelector(btnFacCreateNew)).SendKeys(Keys.ArrowRight);
            UIActionExt(By.CssSelector(btnExcessofLossFacultative), "ispresent");
            UIActionExt(By.CssSelector(btnExcessofLossFacultative), "click");
            WaitUntilElementVisible(driver, By.CssSelector(lblFacultative), 10);
            AgreementNumber = AgreementNumber + Unique.ID;
            AgreementNumber = AgreementNumber.Substring(0, AgreementNumber.Length - 20);
            string Name = "";
            Name = Name + Unique.ID;
            Name = Name.Substring(0, Name.Length - 20);
            Console.WriteLine("Agreement number is " + AgreementNumber);
            Console.WriteLine("Name is " + Name);
            UIAction(txtAgreementNumber, AgreementNumber, "textbox");
            //UIAction(txtAgreementNumber, AgreementNumber, "textbox");
            UIAction(txtName, Name, "textbox");
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
            UIActionExt(By.CssSelector(txtCededPremium), "Text", CededPremium_Temp);
            UIActionExt(By.CssSelector(txtAttachmentPoint), "click");
            UIActionExt(By.CssSelector(txtAttachmentPoint), "Text", limit);
            UIActionExt(By.CssSelector(txtCoverageLimit), "click");
            UIActionExt(By.CssSelector(txtCoverageLimit), "Text", SumInsured.ToString());
            UIActionExt(By.CssSelector(btnAdd), "click");
            UIActionExt(By.CssSelector(btnAddfromAddressBook), "click");
            WaitUntilElementVisible(driver, By.Id("ContactSearchPopup:ContactSearchScreen:ttlBar"), 10);
            UIAction(txtZipCode, "55101", "textbox");
            UIActionExt(By.CssSelector(btnSearch), "click");
            //UIActionExt(btnSearch, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnSelectAddress), 20);
            UIAction(btnSelectAddress, String.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lblFacultative), 10);
            UIAction(btnok, string.Empty, "a");
            try
            {
                WaitUntilElementVisible(driver, By.Id("NewAgreementPopup:AgreementScreen:_msgs"), 10);
                UIAction(btnok, string.Empty, "a");
            }
            catch (Exception e)
            {

            }
        }

        public void ValidateFacc()
        {
            UIActionExt(By.XPath("//a[text()[contains(.,'" + AgreementNumber + "')]]"), "ispresent");
            UIActionExt(By.XPath("//a[text()[contains(.,'" + AgreementNumber + "')]]"), "click");
            UIActionExt(By.CssSelector(btnMakeActive), "ispresent");
            UIActionExt(By.CssSelector(btnMakeActive), "click");
            UIActionExt(By.CssSelector(btnValidate), "ispresent");
            UIActionExt(By.CssSelector(btnValidate), "click");
            Console.WriteLine("validate FAC");
            //string btnfac1 = "a[id='SubmissionWizard:JobWizardToolsMenuWizardStepSet:PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV:1:Number']";
            //UIActionExt(By.CssSelector(btnfac1), "click");
            WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'This agreement is valid')]]"), 40);
            if (IsElementPresent(driver, By.XPath("//div[text()[contains(.,'This agreement is valid')]]")) == false)
            {
                Assert.Fail("Agreement not validated");
            }
            UIActionExt(By.XPath("//a[text()='Return to Reinsurance']"), "ispresent");
            UIActionExt(By.XPath("//a[text()='Return to Reinsurance']"), "click");
        }
        public string GetUniqueValue()
        {
            DateTime myDateTime = DateTime.Now;
            string day = myDateTime.Day.ToString();
            string hour = myDateTime.Hour.ToString();
            string minute = myDateTime.Minute.ToString();
            string second = myDateTime.Second.ToString();
            string GetUniqueValue = day + hour + minute + second;
            return GetUniqueValue;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenterPages.Pages.Transaction
{
    public class PolicyRenew : Page
    {

        string issueNowDownArrow = "a[id$=':BindOptions_arrow']";

        string bindAndRenew = "a[id$=':SendToRenewal']";

        string listRenewCode = "select[id$=':RenewalWizard_RenewalScreen:RenewalCode']";

        string btnOK = "a[id$=':Update']";

        public PolicyRenew(IWebDriver driver) : base(driver)
        {
            pause();
            WaitForPageLoad(driver);
            SetActiveFrame();
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(btnPolicyChangeNext); 
        }

        public override void WaitForLoad()
        {
            //throw new NotImplementedException(); 
        }

        public void IssuePLPolicyRenew()
        {
            UIAction(issueNowDownArrow, string.Empty, "a");

            pause();

            UIAction(bindAndRenew, string.Empty, "a");

            pause();
        }

        public void SetRenewCode(string RenewCode)
        {
            pause();
            UIAction(listRenewCode, RenewCode, "selectbox");
            pause();
            UIAction(btnOK, string.Empty, "a");
            pause();
            driver.SwitchTo().Alert().Accept();
        }

        public void VerifyPolicyRenew()
        {
            string lnkPolicyBound = "div[class='info'][id='JobComplete:JobCompleteScreen:Message']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkPolicyBound));
            string sPolicyChangeStatus = driver.FindElement(By.CssSelector(lnkPolicyBound)).Text;

            if (sPolicyChangeStatus.EndsWith("is in the process of being renewed."))
            {
                Console.WriteLine("Policy Renew Status: " + sPolicyChangeStatus);
            }
            else
            {
                Assert.Fail("Unable to renew Policy");
            }
        }

        public void ChangeAddressDetails(Table table)
        {
            string AddressLine1 = "input[id$=':AddressLine1']";
            string City = "input[id$=':City']";
            string State = "select[id$=':State']";
            //string ZipCode = "NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";
            //string btnOK = "a[id$='NewAdditionalInterestPopup:ContactDetailScreen:ForceDupCheckUpdate']";
            string btnLocOK = "a[id$=':Update']";
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            System.Threading.Thread.Sleep(2000);
            string ILMLoc = "span[label='Loc. #'][value='" + locationNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLoc));
            UIAction(ILMLoc, string.Empty, "span");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('ILMLocation_JMICPopup:ILMLocation_JMICCV:LocationDetailInputSet:AddressInputSet:PostalCode').value=''");
            System.Threading.Thread.Sleep(2000);
            js.ExecuteScript("document.getElementById('ILMLocation_JMICPopup:ILMLocation_JMICCV:LocationDetailInputSet:AddressInputSet:AddressLine1').value=''");
            System.Threading.Thread.Sleep(2000);
            js.ExecuteScript("document.getElementById('ILMLocation_JMICPopup:ILMLocation_JMICCV:LocationDetailInputSet:AddressInputSet:City').value=''");
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.CssSelector(AddressLine1)).Click();
            System.Threading.Thread.Sleep(5000);
            UIAction(AddressLine1, table.Rows[0]["AddressLine1"], "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            UIAction(State, table.Rows[0]["State"], "selectbox");
            js.ExecuteScript("document.getElementById('ILMLocation_JMICPopup:ILMLocation_JMICCV:LocationDetailInputSet:AddressInputSet:PostalCode').value='" + table.Rows[0]["ZipCode"] + "'");
            driver.FindElement(By.CssSelector(AddressLine1)).Click();
            System.Threading.Thread.Sleep(2000);
            string VerifyAddress = "a[id$=':verifyAddress_JMIC']";
            string selectVerifiedAddress = "span[id$=':selectAddress_link']";
            string acceptAddressChkBox = "input[id$=':acceptKeyInAddress']";
            string acceptAddress = "a[id$='VerifyAddress_JMIC_Popup:Update']";
            UIAction(VerifyAddress, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();
            if (PageInputs.Count > 0)
            {
                UIAction(selectVerifiedAddress, string.Empty, "a");
                UIAction(acceptAddressChkBox, string.Empty, "a");
                UIAction(acceptAddress, string.Empty, "button");
                pause();
            }
            System.Threading.Thread.Sleep(2000);
            UIAction(btnLocOK, string.Empty, "button");

        }

        public void SelectLines_Renewal(string lines)
        {
            string btnNext = "a[id=':Next']";
            string lineType = "td[class='lv-cell first-cell']";

            string lineTypeChkBox = "input[id$=':LineSelected']";
            string[] lineItemArray = lines.Split(':');

            foreach (var line in lineItemArray)
            {
                List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(lineType)).ToList();

                for (var i = 0; i < PageInputElements.Count; i++)
                {
                    if (line.ToLower().Trim() == PageInputElements[i].Text.ToLower().Trim())
                    {
                        List<IWebElement> chkBoxes = driver.FindElements(By.CssSelector(lineTypeChkBox)).ToList();

                        Console.WriteLine("Line items count" + chkBoxes.Count);

                        Console.WriteLine("===" + chkBoxes[i].GetAttribute("checked"));
                        if (chkBoxes[i].GetAttribute("checked") != "true")

                            chkBoxes[i].Click();

                    }
                }

            }

            pause();


        }

        public void AddAIonILMBOLocs(Table table)
        {
            string btnNext = "a[id$=':Next']";
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            int ILMlocationNum = Convert.ToInt32(table.Rows[0]["ILMLoc"]);
            System.Threading.Thread.Sleep(5000);
            string ILMLoc = "span[label='Loc. #'][value='" + ILMlocationNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLoc));
            UIAction(ILMLoc, string.Empty, "span");

            System.Threading.Thread.Sleep(2000);
            string AddILMLOCAddlIntrests = "a[id$='ILMLocation_JMICPopup:ILMLocation_JMICCV:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:AddContactsButton_arrow']";
            WaitUntilElementVisible(driver, By.CssSelector(AddILMLOCAddlIntrests));
            UIAction(AddILMLOCAddlIntrests, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string AddCompany = "a[id$='ILMLocation_JMICPopup:ILMLocation_JMICCV:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:AddContactsButton:0:ContactType']";
            WaitUntilElementVisible(driver, By.CssSelector(AddCompany));
            UIAction(AddCompany, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string lstIntrestType = "select[id$='NewAdditionalInterestPopup:ContactDetailScreen:AdditionalInterestInfoDV:Type']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstIntrestType));
            UIAction(lstIntrestType, table.Rows[0]["Interest_Type"], "selectbox");
            RegistryKey RegKey;
            string CompanyName = table.Rows[0]["AI_Name"] + GetUniqueValue();
            RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            RegKey.SetValue("PC_AddInsrd_ILM", CompanyName);

            string txtAddlIntrestName = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:CompanyName']";
            WaitUntilElementVisible(driver, By.CssSelector(txtAddlIntrestName));
            UIAction(txtAddlIntrestName, CompanyName, "textbox");
            string IsJewelerYesPL = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:IsAccountHolderJeweler_true']";
            string IsJewelerNoPL = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:IsAccountHolderJeweler_false']";
            switch (table.Rows[0]["Is_Jeweler"].ToLower().Trim())
            {
                case "yes":
                    UIAction(IsJewelerYesPL, string.Empty, "button");
                    break;
                case "no":
                    UIAction(IsJewelerNoPL, string.Empty, "button");
                    break;
                default:
                    break;
            }
            string AddressLine1 = "input[id$=':AddressLine1']";
            string City = "input[id$=':City']";
            string State = "select[id$=':State']";
            string ZipCode = "NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";
            string btnOK = "a[id$='NewAdditionalInterestPopup:ContactDetailScreen:ForceDupCheckUpdate']";
            string btnLocOK = "a[id$=':Update']";
            UIAction(AddressLine1, table.Rows[0]["Address_Line1"], "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            UIAction(State, table.Rows[0]["State"], "selectbox");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + table.Rows[0]["ZipCode"] + "'");
            System.Threading.Thread.Sleep(5000);
            UIAction(btnOK, string.Empty, "button");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnLocOK, string.Empty, "button");
            string lnkBusinessOwners = "a[id$=':LOBWizardStepGroup:BOPWizardStepGroup']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkBusinessOwners));
            UIAction(lnkBusinessOwners, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnNext, string.Empty, "a");
            Renew_AddAI_BOP(table);
        }

        public void Renew_AddAI_BOP(Table table)
        {
            string btnNext = "a[id$=':Next']";
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            System.Threading.Thread.Sleep(5000);
            string BOLoc = "span[label='Loc. #'][value='" + locationNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(BOLoc));
            UIAction(BOLoc, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string AddBoLOCAddlIntrests = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationAdditionalInsureds_JMICDV:AdditionalInsuredLV_tb:AddContactsButton_arrow']";
            WaitUntilElementVisible(driver, By.CssSelector(AddBoLOCAddlIntrests));
            UIAction(AddBoLOCAddlIntrests, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string AddCompany = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationAdditionalInsureds_JMICDV:AdditionalInsuredLV_tb:AddContactsButton:0:ContactType']";
            WaitUntilElementVisible(driver, By.CssSelector(AddCompany));
            UIAction(AddCompany, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string lstIntrestType = "select[id$='NewAdditionalInsuredPopup:ContactDetailScreen:AdditionalInsuredInfoDV:Type']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstIntrestType));
            UIAction(lstIntrestType, table.Rows[0]["Insured_Type"], "selectbox");
            RegistryKey RegKey;
            string CompanyName = table.Rows[0]["AI_Name_BOP"] + GetUniqueValue();
            RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            RegKey.SetValue("PC_AddInsrd_BOPLoc", CompanyName);
            string txtAddlIntrestName = "input[id$='NewAdditionalInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:CompanyName']";
            System.Threading.Thread.Sleep(4000);
            UIAction(txtAddlIntrestName, CompanyName, "textbox");
            string IsJewelerYesPL = "input[id$='NewAdditionalInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:IsAccountHolderJeweler_true']";
            string IsJewelerNoPL = "input[id$='NewAdditionalInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:IsAccountHolderJeweler_false']";
            switch (table.Rows[0]["Is_Jeweler_BOP"].ToLower().Trim())
            {
                case "yes":
                    UIAction(IsJewelerYesPL, string.Empty, "button");
                    break;
                case "no":
                    UIAction(IsJewelerNoPL, string.Empty, "button");
                    break;
                default:
                    break;
            }
            string AddressLine1 = "input[id$=':AddressLine1']";
            string City = "input[id$=':City']";
            string State = "select[id$=':State']";
            string ZipCode = "NewAdditionalInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";
            string btnOK = "a[id$='NewAdditionalInsuredPopup:ContactDetailScreen:ForceDupCheckUpdate']";
            string btnLocOK = "a[id$=':Update']";
            UIAction(AddressLine1, table.Rows[0]["Address_Line1_BOP"], "textbox");
            UIAction(City, table.Rows[0]["City_BOP"], "textbox");
            UIAction(State, table.Rows[0]["State_BOP"], "selectbox");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + table.Rows[0]["ZipCode_BOP"] + "'");
            System.Threading.Thread.Sleep(5000);
            UIAction(btnOK, string.Empty, "button");
            string txtAInsIntrest = "input[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationAdditionalInsureds_JMICDV:AdditionalInsuredLV:0:Interest_JMIC']";
            WaitUntilElementVisible(driver, By.CssSelector(txtAInsIntrest));
            UIAction(txtAInsIntrest, table.Rows[0]["BOPLocation_AI_Interest"], "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnLocOK, string.Empty, "button");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnNext, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(BOLoc));
            UIAction(BOLoc, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string BldLoc = "span[label='Bldg. #'][value='1']";
            WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
            UIAction(BldLoc, string.Empty, "span");


            string AddBoBldAddlIntrests = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:AddContactsButton_arrow']";
            WaitUntilElementVisible(driver, By.CssSelector(AddBoBldAddlIntrests));
            UIAction(AddBoBldAddlIntrests, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string AddPerson = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:AddContactsButton:1:ContactType']";
            WaitUntilElementVisible(driver, By.CssSelector(AddPerson));
            UIAction(AddPerson, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string lstPersonIntrestType = "select[id$='NewAdditionalInterestPopup:ContactDetailScreen:AdditionalInterestInfoDV:Type']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstPersonIntrestType));
            UIAction(lstPersonIntrestType, table.Rows[0]["Interest_Type1"], "selectbox");

            string PersonFName = table.Rows[0]["FirstName"];
            string PersonLName = table.Rows[0]["LastName"] + GetUniqueValue();
            RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            RegKey.SetValue("PC_AddInsrd_BOPBld", PersonFName + " " + PersonLName);
            string txtAddlIntrestFName = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:FirstName']";
            WaitUntilElementVisible(driver, By.CssSelector(txtAddlIntrestFName));
            UIAction(txtAddlIntrestFName, PersonFName, "textbox");
            string txtAddlIntrestLName = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:LastName']";
            WaitUntilElementVisible(driver, By.CssSelector(txtAddlIntrestLName));
            UIAction(txtAddlIntrestLName, PersonLName, "textbox");

            UIAction(AddressLine1, table.Rows[0]["Address_Line1"], "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            UIAction(State, table.Rows[0]["State"], "selectbox");
            string BldZipCode = "NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";
            js.ExecuteScript("document.getElementById('" + BldZipCode + "').value='" + table.Rows[0]["ZipCode"] + "'");
            System.Threading.Thread.Sleep(5000);
            btnOK = "a[id$='NewAdditionalInterestPopup:ContactDetailScreen:ForceDupCheckUpdate']";
            UIAction(btnOK, string.Empty, "button");
            System.Threading.Thread.Sleep(2000);
            string btnBoBldUpdate = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:Update']";
            WaitUntilElementVisible(driver, By.CssSelector(btnBoBldUpdate));
            UIAction(btnBoBldUpdate, string.Empty, "a");

            //
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

        public void BOUmbrellaLineDetails()
        {
            pause();
            string selSelfInsuredRetention = "select[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBSI']";
            string selUmbrellaLimit = "select[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBLimit']";
            string selAdditionalPremium = "input[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBAddtnlPrem']";
            string btnNext = "a[id$=':Next']";
            string radioUmbUnderwritingQ1 = "input[id$=':0:QuestionInputSet:BooleanRadioInput_false']";
            string radioUmbUnderwritingQ2 = "input[id$=':1:QuestionInputSet:BooleanRadioInput_false']";
            string radioUmbUnderwritingQ3 = "input[id$=':2:QuestionInputSet:BooleanRadioInput_false']";
            string radioUmbUnderwritingQ4 = "input[id$=':3:QuestionInputSet:BooleanRadioInput_false']";
            string radioUmbUnderwritingQ5 = "input[id$='0:QuestionInputSet:BooleanRadioInput_NoPost_false']";

            UIAction(selSelfInsuredRetention, "2", "selectbox");
            UIAction(btnNext, string.Empty, "a");
            pause();
            pause();
            UIAction(btnNext, string.Empty, "a");
            UIAction(radioUmbUnderwritingQ1, string.Empty, "radio");
            pause();
            UIAction(radioUmbUnderwritingQ2, string.Empty, "radio");
            pause();
            UIAction(radioUmbUnderwritingQ3, string.Empty, "radio");
            pause();
            UIAction(radioUmbUnderwritingQ4, string.Empty, "radio");
            pause();
            UIAction(radioUmbUnderwritingQ5, string.Empty, "radio");
            pause();
            pause();
            pause();
            UIAction(btnNext, string.Empty, "a");
            pause();
        }

        public void issueCLRenewPolicy()
        {
            string btnQuote = "a[id$=':JobWizardToolbarButtonSet:RenewalQuote']";
            string btnDetails = "a[id$=':DetailsButton']";
            string btnClear = "a[id$='WebMessageWorksheet:WebMessageWorksheetScreen:WebMessageWorksheet_ClearButton']";
            System.Threading.Thread.Sleep(2000);
            UIAction(btnQuote, string.Empty, "a");

            List<IWebElement> PageInputs;
            Actions action = new Actions(driver);
            System.Threading.Thread.Sleep(15000);
            PageInputs = driver.FindElements(By.CssSelector(btnClear)).ToList();
            if (PageInputs.Count > 0)
            {
                PageInputs[0].Click();
                System.Threading.Thread.Sleep(2000);
            }
            UIAction(issueNowDownArrow, string.Empty, "a");
            System.Threading.Thread.Sleep(3000);
            UIAction(bindAndRenew, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            try
            {
                driver.SwitchTo().Alert().Accept();
                WaitForPageLoad(driver);
                System.Threading.Thread.Sleep(5000);
                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            IWebElement btnUSIssues = driver.FindElement(By.CssSelector(btnDetails));
            WaitForEnabled(btnUSIssues);
            Console.WriteLine("UW issues present");
            UIAction(btnDetails, string.Empty, "a");
            pause();
            PageInputs = driver.FindElements(By.CssSelector("span[id$=':SpecialApprove_link']")).ToList();
            for (int i = 0; i < PageInputs.Count; i++)
            {
                Console.WriteLine("TExt" + PageInputs[i].Text);

                if (PageInputs[i].Text.ToLower().Trim() == "special approve")
                {
                    Console.WriteLine("Found");
                    PageInputs[i].Click();
                    pause();
                }
                break;
            }
            pause();
            driver.SwitchTo().Alert().Accept();
            pause();
            PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();
            for (int i = 0; i < PageInputs.Count; i++)
            {
                if (PageInputs[i].Text.ToLower().Trim() == "ok")
                    PageInputs[i].Click();
                break;
            }
            pause();
            UIAction(issueNowDownArrow, string.Empty, "a");
            pause();
            pause();
            UIAction(bindAndRenew, string.Empty, "a");
            pause();
            try
            {
                driver.SwitchTo().Alert().Accept();
                WaitForPageLoad(driver);
                System.Threading.Thread.Sleep(5000);
                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            System.Threading.Thread.Sleep(5000);

        }

        public void AddHotelMotelCoverage_ILM(Table table)
        {
            string chkHotelCov = "input[id$='RenewalWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:CoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:1:ILMCoverageInputSet:CovPatternInputGroup:_checkbox']";
            string txtPremium = "input[id$='RenewalWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:CoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:1:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput']";
            driver.FindElement(By.CssSelector(chkHotelCov)).Click();
            System.Threading.Thread.Sleep(2000);
            UIAction(txtPremium, table.Rows[0]["Premium"], "textbox");

        }

        public void AddPolicyInfo(Table table)
        {
            pause();
            pause();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Console.WriteLine("Term Type: " + table.Rows[0]["TermType"].ToLower());
            string lstTermType = "RenewalWizard:LOBWizardStepGroup:RenewalWizard_PolicyInfoScreen:RenewalWizard_PolicyInfoDV:PolicyInfoInputSet:TermType";
            if (table.Rows[0]["TermType"].ToLower() == "annual")
            {
                //UIAction(lstTermType, "Annual", "select");
                js.ExecuteScript("document.getElementById('" + lstTermType + "').selectedIndex='0'");
            }
            else if (table.Rows[0]["TermType"].ToLower() == "other")
            {
                //UIAction(lstTermType, "Other", "select");
                js.ExecuteScript("document.getElementById('" + lstTermType + "').selectedIndex='1'");
            }
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();
            System.Threading.Thread.Sleep(4000);
        }

        public void AddTradeShowcasesCovg(Table table)
        {
            string btnAddCoverage = "a[id$=':ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton_arrow']";
            string lstTradeShowcase = "a[id$=':ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton:9:subItemCoverable']";
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
            UIAction(btnAddCoverage, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lstTradeShowcase));
            UIAction(lstTradeShowcase, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string txtShowcaseLocationName = "textarea[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:StringTermInputMed']";
            string txtShowcaseAddress = "textarea[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:StringTermInputMed']";
            //string txtItemDesc = "textarea[id$='RenewalWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ILMCovTermInputSet:StringTermInputMed'";
            string txtItemDesc = "RenewalWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ILMCovTermInputSet:StringTermInputMed";
            string txtShowcaseLimit = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput']";
            string lstShowcaseDeductiblee = "select[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:ILMCovTermInputSet:OptionTermInput']";
            WaitUntilElementVisible(driver, By.CssSelector(txtShowcaseLocationName));
            UIAction(txtShowcaseLocationName, table.Rows[0]["ShowcaseLocationName"], "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtShowcaseAddress));
            UIAction(txtShowcaseAddress, table.Rows[0]["ShowcaseAddress"], "textbox");
            System.Threading.Thread.Sleep(4000);
            //WaitUntilElementVisible(driver, By.CssSelector(txtItemDesc));
            //UIAction(txtItemDesc, table.Rows[0]["ItemDesc"], "textbox");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + txtItemDesc + "').value='" + table.Rows[0]["ItemDesc"] + "'");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtShowcaseLimit));
            UIAction(txtShowcaseLimit, table.Rows[0]["ShowcaseLimit"], "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstShowcaseDeductiblee));
            UIAction(lstShowcaseDeductiblee, table.Rows[0]["ShowcaseDeductible"], "selectbox");
            System.Threading.Thread.Sleep(2000);
        }

        public void AddStockPeak(Table table)
        {
            System.Threading.Thread.Sleep(5000);
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            string ILMLocJStock = "a[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV:" + (locationNum - 1) + ":StockDescription']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLocJStock));
            UIAction(ILMLocJStock, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string coveragesTab = "a[id$=':CoveragesTab']";
            WaitUntilElementVisible(driver, By.CssSelector(coveragesTab));
            UIAction(coveragesTab, string.Empty, "a");

            string btnAddCoverage = "a[id$=':CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:ToolbarButton_arrow']";
            string lnkStockPeak = "a[id$=':CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:ToolbarButton:0:subItemCoverable']";

            pause();
            pause();
            string txtStockPeakLimit = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput']";
            string StockPeakDeductible = "select[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:OptionTermInput']";
            string StockPeakFrom = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:FromDate:DateTimeTermInput";
            string StockPeakTo = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ToDate:DateTimeTermInput";
            string StockPeakRecurringNo = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_false']";

            WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
            UIAction(btnAddCoverage, string.Empty, "a");
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(lnkStockPeak));
            UIAction(lnkStockPeak, string.Empty, "a");
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(txtStockPeakLimit));
            UIAction(txtStockPeakLimit, table.Rows[0]["StockPeak_Limit"], "textbox");
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(StockPeakDeductible));
            UIAction(StockPeakDeductible, table.Rows[0]["StockPeak_Deductible"], "selectbox");

            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (table.Rows[0]["StockPeak_StartDate"].ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (table.Rows[0]["StockPeak_StartDate"].ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (table.Rows[0]["StockPeak_StartDate"].Contains("+"))
            {
                string[] details = table.Rows[0]["StockPeak_StartDate"].Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            js.ExecuteScript("document.getElementById('" + StockPeakFrom + "').value='" + tempDate + "'");
            pause();
            if (table.Rows[0]["StockPeak_EndDate"].ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (table.Rows[0]["StockPeak_EndDate"].ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (table.Rows[0]["StockPeak_EndDate"].Contains("+"))
            {
                string[] details = table.Rows[0]["StockPeak_EndDate"].Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            js.ExecuteScript("document.getElementById('" + StockPeakTo + "').value='" + tempDate + "'");

            pause();
            WaitUntilElementVisible(driver, By.CssSelector(StockPeakRecurringNo));
            UIAction(StockPeakRecurringNo, string.Empty, "input");
            pause();
            string btnOK = "a[id$='ILMJewelryStock_JMICPopup:Update']";
            UIAction(btnOK, string.Empty, "a");
        }

        public void AddILMLocation(Table table)
        {
            pause();
            string btnAddLocation = "a[id$='ILMLocation_JMICScreen:addLocationsOrBuildingsTB']";
            string menuNewILMLocation = "a[id$='ILMLocation_JMICScreen:addLocationsOrBuildingsTB:AddNewLocation']";
            UIAction(btnAddLocation, string.Empty, "a");
            UIAction(menuNewILMLocation, string.Empty, "a");

            string AddressLine1 = "input[id$=':AddressLine1']";
            string City = "input[id$=':City']";
            string State = "select[id$=':State']";
            string ILMLocZipCode = "ILMLocation_JMICPopup:ILMLocation_JMICCV:LocationDetailInputSet:AddressInputSet:PostalCode";

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement IAddressline = driver.FindElement(By.CssSelector(AddressLine1));
            WaitForEnabled(IAddressline);
            UIAction(AddressLine1, table.Rows[0]["AddressLine1"], "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            UIAction(State, table.Rows[0]["State"], "selectbox");
            js.ExecuteScript("document.getElementById('" + ILMLocZipCode + "').value='" + table.Rows[0]["ZipCode"] + "'");

            string SegmentationCode = "input[id$=':SegmentationCode_JMIC']";
            string GenBusinessRetail = "input[id$=':Retail_JMIC']";
            string GenBusinessRepair = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:Repair_JMIC";
            string FulltimeEmployees = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:FullTimeEmployees_JMIC";
            string ParttimeEmployees = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:PartTimeEmployees_JMIC";
            string PublicProtection = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:PublicProtection_JMIC";
            string LocationType = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:LocationType_JMIC";
            string ConstructionType = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:ConstructionType";
            string TotalArea = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:TotalArea";
            string AreaOccupied = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:AreaOccupied";
            string PercentSprinklered = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:PercentSprinklered";
            string SharedPremises = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:SharedPremises_false";


            //UIAction(SegmentationCode, segmentationCode, "textbox");
            //UIAction(GenBusinessRetail, "100", "textbox");
            //Actions action = new Actions(driver);
            //action.SendKeys(Keys.Tab).Build().Perform();
            //pause();
            //pause();
            //IsElementPresent(driver, By.CssSelector(GenBusinessRepair));
            //pause();
            //pause();
            ////IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("document.getElementById('" + GenBusinessRepair + "').value='0'");
            //js.ExecuteScript("document.getElementById('" + FulltimeEmployees + "').value='" + FTEmployees + "'");
            //js.ExecuteScript("document.getElementById('" + ParttimeEmployees + "').value='" + PTEmployees + "'");
            //js.ExecuteScript("document.getElementById('" + PublicProtection + "').selectedIndex='4'");
            //js.ExecuteScript("document.getElementById('" + LocationType + "').selectedIndex='8'");
            //js.ExecuteScript("document.getElementById('" + ConstructionType + "').selectedIndex='1'");
            //js.ExecuteScript("document.getElementById('" + TotalArea + "').value='" + totalBuildingArea + "'");
            //js.ExecuteScript("document.getElementById('" + AreaOccupied + "').value='" + areaOccupied + "'");
            //js.ExecuteScript("document.getElementById('" + PercentSprinklered + "').selectedIndex='1'");
            //js.ExecuteScript("document.getElementById('" + SharedPremises + "').checked=true");
        }

        public void RemoveUMB()
        {
            string chkUMB = "input[id$=':CPPLineSelectionScreen:CPPLineSelectionDV:2:LineSelected']";
            driver.FindElement(By.CssSelector(chkUMB)).Click();
            System.Threading.Thread.Sleep(2000);
            try
            {
                driver.SwitchTo().Alert().Accept();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Exception is " + e.Message);
            }
            System.Threading.Thread.Sleep(2000);
        }

        public void AddBldgCovg(string locationNum)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            System.Threading.Thread.Sleep(2000);
            string BldLoc = "span[label='Bldg. #'][value='1']";
            string btnUpdateBuilding = "a[id$=':Update']";
            string tabBuildingBPPCoverages = "a[id$=':BOPBuildingBPPCoveragesCardTab']";
            string txtBPPLimit = "input[id$=':BOPBPPBldgLimit']";
            WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
            UIAction(BldLoc, string.Empty, "span");
            pause();

            UIAction(tabBuildingBPPCoverages, string.Empty, "a");

            IsElementPresent(driver, By.CssSelector(txtBPPLimit));

            string chkBuilding = "input[id='BOPBuildingPopup:BOPSingleBuildingDetailScreen:0:CoverageInputSet:CovPatternInputGroup:_checkbox']";

            driver.FindElement(By.CssSelector(chkBuilding)).Click();
            System.Threading.Thread.Sleep(2000);
            string txtBldLimit = "input[id='BOPBuildingPopup:BOPSingleBuildingDetailScreen:0:CoverageInputSet:CovPatternInputGroup:BOPBldgCovLimit']";
            //string txtRplCost = "input=[id='BOPBuildingPopup:BOPSingleBuildingDetailScreen:0:CoverageInputSet:CovPatternInputGroup:BOPBldgEstFullReplacementCostLimit']";
            UIAction(txtBldLimit, "10000", "textbox");
            System.Threading.Thread.Sleep(2000);
            string jsBPPLimit = "BOPBuildingPopup:BOPSingleBuildingDetailScreen:1:CoverageInputSet:CovPatternInputGroup:BOPBPPBldgLimit";
            js.ExecuteScript("document.getElementById('" + jsBPPLimit + "').value=''");
            System.Threading.Thread.Sleep(2000);
            UIAction(txtBPPLimit, "10000", "textbox");
            System.Threading.Thread.Sleep(2000);
            string BPPRepCost = "input[id='BOPBuildingPopup:BOPSingleBuildingDetailScreen:1:CoverageInputSet:CovPatternInputGroup:BOPBPPEstRplcmntCostLim']";
            driver.FindElement(By.CssSelector(BPPRepCost)).Click();
            System.Threading.Thread.Sleep(2000);
            UIAction(btnUpdateBuilding, string.Empty, "a");
        }

        public void Renew_BOAddBlanket(Table table)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string btnAddBlanket = "a[id$=':BOPBlanket_tb:AddBlanket']";
            string lstBlanketType = "select[id='BOPBlanket_JMICPopup:BlanketType']";
            string lstGroupType = "select[id='BOPBlanket_JMICPopup:BlanketGroupType']";
            string lstLocation = "BOPBlanket_JMICPopup:BlanketLocation";
            string txtLimit = "input[id='BOPBlanket_JMICPopup:BOPBlanketCovLimit']";
            string btnShowCovgs = "a[id='BOPBlanket_JMICPopup:BOPBlanketCovLV_tb:ShowCoverages']";
            string chkSelectAll = "input[id='BOPBlanket_JMICPopup:BOPBlanketCovLV:_Checkbox']";
            string btnIncldSelCovgs = "a[id='BOPBlanket_JMICPopup:BOPBlanketCovLV_tb:AddCoverages']";
            string btnOK = "a[id='BOPBlanket_JMICPopup:Update']";
            string btnClear = "a[id='WebMessageWorksheet:WebMessageWorksheetScreen:WebMessageWorksheet_ClearButton']";
            string lstDed = "BOPBlanket_JMICPopup:BOPBlanketCovDeductible";

            UIAction(btnAddBlanket, string.Empty, "a");
            driver.FindElement(By.XPath("//html")).Click();
            System.Threading.Thread.Sleep(2000);
            UIAction(lstBlanketType, table.Rows[0]["BOP_Blanket_Type"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(lstGroupType, table.Rows[0]["BOP_Blanket_GroupType"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            if (table.Rows[0]["LocationNum"] == "1")
            {
                js.ExecuteScript("document.getElementById('" + lstLocation + "').selectedIndex='1'");
            }
            System.Threading.Thread.Sleep(2000);
            UIAction(btnShowCovgs, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(chkSelectAll)).Click();
            System.Threading.Thread.Sleep(2000);
            UIAction(btnIncldSelCovgs, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            UIAction(txtLimit, "20000", "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnOK, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnClear, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            //UIAction(lstDed, "500", "selectbox");
            js.ExecuteScript("document.getElementById('" + lstDed + "').selectedIndex='2'");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnOK, string.Empty, "a");

        }

        public void Renew_AddILMBlankets(Table table)
        {
            IWebElement ilmtab = driver.FindElement(By.XPath("//a[text()= 'Blanket Coverages']"));
            JavaScriptClick(ilmtab);
            System.Threading.Thread.Sleep(2000);
            string chkStockBlanket = "input[id$='ILMLineCoveragesPanelSet:CovCategoryIterator:0:ILMCoverageInputSet:CovPatternInputGroup:_checkbox']";
            WaitUntilElementVisible(driver, By.CssSelector(chkStockBlanket));
            //UIAction(chkStockBlanket, string.Empty, "span");
            driver.FindElement(By.CssSelector(chkStockBlanket)).Click();
            string txtStockLimit = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput']";
            string txtPremium = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:2:ILMCovTermInputSet:DirectTermInput']";
            WaitUntilElementVisible(driver, By.CssSelector(txtStockLimit));
            UIAction(txtStockLimit, table.Rows[0]["StockLimit"], "textbox");
            WaitUntilElementVisible(driver, By.CssSelector(txtPremium));
            UIAction(txtPremium, table.Rows[0]["Premium"], "textbox");

        }


        public void EditWorkOrder()
        {
            string btnEditWorkOrder = "a[id$='RenewalWizard:OfferingScreen:JobWizardToolbarButtonSet:EditPolicyWorkflow']";
            System.Threading.Thread.Sleep(12000);
            WaitUntilElementVisible(driver, By.CssSelector(btnEditWorkOrder));
            UIAction(btnEditWorkOrder, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            try
            {
                driver.SwitchTo().Alert().Accept();
                WaitForPageLoad(driver);
                System.Threading.Thread.Sleep(3000);
                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddTradeShowcasesCovg_JSP(Table table)
        {
            string btnAddCoverage = "a[id$=':ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton_arrow']";
            string lstTradeShowcase = "a[id$=':OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton:0:subItemCoverable']";
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
            UIAction(btnAddCoverage, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lstTradeShowcase));
            UIAction(lstTradeShowcase, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string txtShowcaseLocationName = "textarea[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:StringTermInputMed']";
            string txtShowcaseAddress = "textarea[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:StringTermInputMed']";
            //string txtItemDesc = "textarea[id$='RenewalWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ILMCovTermInputSet:StringTermInputMed'";
            string txtItemDesc = "RenewalWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ILMCovTermInputSet:StringTermInputMed";
            string txtShowcaseLimit = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput']";
            string lstShowcaseDeductiblee = "select[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:ILMCovTermInputSet:OptionTermInput']";
            WaitUntilElementVisible(driver, By.CssSelector(txtShowcaseLocationName));
            UIAction(txtShowcaseLocationName, table.Rows[0]["ShowcaseLocationName"], "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtShowcaseAddress));
            UIAction(txtShowcaseAddress, table.Rows[0]["ShowcaseAddress"], "textbox");
            System.Threading.Thread.Sleep(4000);
            //WaitUntilElementVisible(driver, By.CssSelector(txtItemDesc));
            //UIAction(txtItemDesc, table.Rows[0]["ItemDesc"], "textbox");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + txtItemDesc + "').value='" + table.Rows[0]["ItemDesc"] + "'");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtShowcaseLimit));
            UIAction(txtShowcaseLimit, table.Rows[0]["ShowcaseLimit"], "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstShowcaseDeductiblee));
            UIAction(lstShowcaseDeductiblee, table.Rows[0]["ShowcaseDeductible"], "selectbox");
            System.Threading.Thread.Sleep(2000);
        }

        public void ClickOKButton()
        {
            string btnOK = "a[id$=':Update']";
            System.Threading.Thread.Sleep(2000);
            UIAction(btnOK, string.Empty, "a");
        }

        public void issueCLRenewPolicy_JSP()
        {
            string btnQuote = "a[id$=':JobWizardToolbarButtonSet:RenewalQuote']";
            string btnDetails = "a[id$=':DetailsButton']";
            string btnClear = "a[id$='WebMessageWorksheet:WebMessageWorksheetScreen:WebMessageWorksheet_ClearButton']";
            System.Threading.Thread.Sleep(2000);
            UIAction(btnQuote, string.Empty, "a");

            List<IWebElement> PageInputs;
            Actions action = new Actions(driver);
            System.Threading.Thread.Sleep(15000);
            PageInputs = driver.FindElements(By.CssSelector(btnClear)).ToList();
            if (PageInputs.Count > 0)
            {
                PageInputs[0].Click();
                System.Threading.Thread.Sleep(2000);
            }
            UIAction(issueNowDownArrow, string.Empty, "a");
            System.Threading.Thread.Sleep(3000);
            UIAction(bindAndRenew, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            try
            {
                driver.SwitchTo().Alert().Accept();
                WaitForPageLoad(driver);
                System.Threading.Thread.Sleep(5000);
                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
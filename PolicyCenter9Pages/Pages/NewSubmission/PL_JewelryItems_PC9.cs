using HelperClasses;
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

namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class PL_JewelryItems_PC9 : Page
    {
        string btnVerifyAddress = "span[id$='PolicyContactDetailsDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:verifyAddress_JMIC-btnInnerEl']";

        string btnVerifyAddressNewLoc = "a[id$=':PolicyContactDetailsDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:verifyAddress_JMIC']";
        string txtZipCode = "input[id$=':PolicyContactDetailsDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:PostalCode-inputEl']";
        string txtCity = "input[id$=':PolicyContactDetailsDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:City-inputEl']";
        string txtFirstName = "input[id$=':PolicyContactDetailsDV:PolicyContactRoleNameInputSet:GlobalPersonNameInputSet:FirstName-inputEl']";
        string txtLastName = "input[id$=':PolicyContactDetailsDV:PolicyContactRoleNameInputSet:GlobalPersonNameInputSet:LastName-inputEl']";
        string txtAddressline1 = "input[id$=':PolicyContactDetailsDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:AddressLine1-inputEl']";
        string lblNewlocation = "span[id='NewPolicyLocatedWithPopup:ContactDetailScreen:ttlBar']";
        string lblItemScreen = "span[id='JewelryItem_JMIC_PLPopup:ttlBar']";
        string lblPersonalJewelryItems = "span[id$=':LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:ttlBar']";
        string btnNext = "span[id$=':Next-btnInnerEl']";
        string btnAddJwelryItems = "span[id$=':LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV_tb:ToolbarButton1-btnInnerEl']";
        string textState = "input[id$='PolicyContactDetailsDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:State-inputEl']";
        string selLocatedWith = "input[id$=':LocatedWithPolicyRoleRangeInput-inputEl']";
        string AddressErrorMsg = "//span[text()[contains(.,'Address is unverified. You must verify the address before updating contact information')]]";
        string lblVerifyAddress = "span[id='VerifyAddress_JMIC_Popup:ttlBar']";
        string selLocatedWithCSS = "JewelryItem_JMIC_PLPopup:LocatedWithPolicyRoleRangeInput-inputEl";
        string AcceptThisAddress = "a[id='VerifyAddress_JMIC_Popup:likelyMatchedAddressLV:0:selectAddress']";
        string selJewelryClass = "input[id$=':ClassCodeTypeKeyInput-inputEl']";
        string btnNewLoctionOK = "span[id$=':ContactDetailScreen:Update-btnInnerEl']";


        string selInactiveReason = "input[id$=':InactiveReasonInput-inputEl']";

        string JewelryValue = "input[id$=':ValueInputCell-inputEl']";

        string selDeductible = "input[id$=':ded-inputEl']";

        string btnUpdateJewelryItem = "span[id$=':Update-btnInnerEl']";

        string chckboxInactiveArticle = "input[id$=':ActiveCheckboxInput-inputEl']";

        string btnEditWorkOrder = "span[id$=':JobWizardToolbarButtonSet:EditPolicyWorkflow-btnInnerEl']";

        string btnOK = "span[id='button-1005-btnInnerEl']";

        string selectAlarmType = "input[id$=':PersonalItemJMICPLPanelSet:alarm-inputEl']";

        string AppraisaleffectiveDate = "input[id$=':inspectionDate-inputEl']";

        string selBrand = "input[id$=':BrandTypeKeyInput-inputEl']";

        string selStyle = "input[id$=':StyleTypeKeyInput-inputEl']";

        string selItemStored = "input[id$=':ItemWhereStored_JMIC-inputEl']";

        string btnAddressButtonMenuIcon = "a[id$=':LocatedWithPolicyRoleRangeInput:LocatedWithPolicyRoleRangeInputMenuIcon']";

        string btnNewLocation = "span[id$=':LocatedWithPolicyRoleRangeInput:NewPolicyAddlInsured-textEl']";
        public PL_JewelryItems_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPersonalJewelryItems);
        }
        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPersonalJewelryItems));
        }

        public void CLickNextonPErsonalJewelryItemPC9()
        {
            string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
        }

        public void AddJewelryIteminPC9(string LocatedWith, string itemClass, string ValueOfItem, string Deductible)
        {
            UIAction(btnAddJwelryItems, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lblItemScreen));

            driver.FindElement(By.CssSelector(selLocatedWith)).Clear();
            UIAction(selLocatedWith, LocatedWith, "textbox");

            driver.FindElement(By.CssSelector(selJewelryClass)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(selLocatedWith + "[value='" + LocatedWith + "']"));
            driver.FindElement(By.CssSelector(selJewelryClass)).Clear();
            UIAction(selJewelryClass, itemClass, "textbox");

            driver.FindElement(By.CssSelector(JewelryValue)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(selJewelryClass + "[value='" + itemClass + "']"));
            UIAction(JewelryValue, ValueOfItem, "textbox");

            driver.FindElement(By.CssSelector(selDeductible)).Clear();
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(selDeductible + "[value='" + Deductible + "']"), 3);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("message is " + e.Message);
            }
            UIAction(selDeductible, Deductible, "textbox");

            UIAction(btnUpdateJewelryItem, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));
        }

        public void AddMultiJewelryItemPC9(string LocatedWith, string itemClass, string ValueOfItem, string Deductible, string Appraisal, string AppraisalDate, int counter)
        {
            DataStorage temp = new DataStorage();
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));
            UIAction(btnAddJwelryItems, string.Empty, "a");

            WaitUntilElementVisible(driver, By.CssSelector(lblItemScreen));
            switch (LocatedWith.ToUpper().Trim())
            {
                case "SELF":
                    LocatedWith = temp.GetTempValue("FNAME") + " " + temp.GetTempValue("LNAME");
                    break;
            }

            driver.FindElement(By.CssSelector(selLocatedWith)).Clear();
            UIAction(selLocatedWith, LocatedWith, "textbox");

            driver.FindElement(By.CssSelector(selJewelryClass)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(selLocatedWith + "[value='" + LocatedWith + "']"));
            driver.FindElement(By.CssSelector(selJewelryClass)).Clear();
            UIAction(selJewelryClass, itemClass, "textbox");

            driver.FindElement(By.CssSelector(JewelryValue)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(selJewelryClass + "[value='" + itemClass + "']"));
            UIAction(JewelryValue, ValueOfItem, "textbox");

            driver.FindElement(By.CssSelector(selDeductible)).Clear();
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(selDeductible + "[value='" + Deductible + "']"), 3);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("message is " + e.Message);
            }
            UIAction(selDeductible, Deductible, "textbox");

            if (Appraisal.ToLower().Trim() == "yes")
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_true-inputEl']", string.Empty, "a");
            }
            else
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_false-inputEl']", string.Empty, "a");
            }
            WaitUntilElementVisible(driver, By.CssSelector(btnUpdateJewelryItem));
            UIAction(btnUpdateJewelryItem, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));


        }

        public void AddMultiJewelryItemwithItemStoredPC9(string LocatedWith, string itemClass, string ValueOfItem, string Deductible, string Appraisal, string AppraisalDate, string JewelryBrand, string JewelryStyle, string JewelryItemStored, int counter)
        {
            DataStorage temp = new DataStorage();
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));
            UIAction(btnAddJwelryItems, string.Empty, "a");

            WaitUntilElementVisible(driver, By.CssSelector(lblItemScreen));
            switch (LocatedWith.ToUpper().Trim())
            {
                case "SELF":
                    LocatedWith = temp.GetTempValue("FNAME") + " " + temp.GetTempValue("LNAME");
                    break;
            }

            driver.FindElement(By.CssSelector(selLocatedWith)).Clear();
            UIAction(selLocatedWith, LocatedWith, "textbox");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(selJewelryClass)).Click();
            //   WaitUntilElementVisible(driver, By.CssSelector(selLocatedWith + "[value='" + LocatedWith + "']"));
            driver.FindElement(By.CssSelector(selJewelryClass)).Clear();
            UIAction(selJewelryClass, itemClass, "textbox");

            driver.FindElement(By.CssSelector(JewelryValue)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(selJewelryClass + "[value='" + itemClass + "']"));
            UIAction(JewelryValue, ValueOfItem, "textbox");

            System.Console.WriteLine("JewelryBrand is " + JewelryBrand);
            if (JewelryBrand.Length > 1)
            {
                driver.FindElement(By.CssSelector(selBrand)).Clear();
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(selBrand + "[value='" + JewelryBrand + "']"), 3);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("selBrand exception message is " + e.Message);
                }
                UIAction(selBrand, JewelryBrand, "textbox");
            }

            System.Console.WriteLine("JewelryStyle is " + JewelryStyle);
            if (JewelryStyle.Length > 1)
            {
                driver.FindElement(By.CssSelector(selStyle)).Clear();
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(selStyle + "[value='" + JewelryStyle + "']"), 2);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("selStyle exception message is " + e.Message);
                }
                UIAction(selStyle, JewelryStyle, "textbox");
            }


            driver.FindElement(By.CssSelector(selDeductible)).Clear();
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(selDeductible + "[value='" + Deductible + "']"), 3);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("message is " + e.Message);
            }
            UIAction(selDeductible, Deductible, "textbox");

            if (Appraisal.ToLower().Trim() == "yes")
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_true-inputEl']", string.Empty, "a");
                if (AppraisalDate.Length > 0)
                {
                    setAppraisalDate(AppraisalDate);
                }
            }
            else
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_false-inputEl']", string.Empty, "a");
            }

            driver.FindElement(By.CssSelector(selItemStored)).Clear();
            UIAction(selItemStored, JewelryItemStored, "textbox");
            WaitUntilElementVisible(driver, By.CssSelector(btnUpdateJewelryItem));
            UIAction(btnUpdateJewelryItem, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));

        }


        public void setAppraisalDate(string AppraisalDate)
        {
            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (AppraisalDate.ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (AppraisalDate.ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (AppraisalDate.Contains("+"))
            {
                string[] details = AppraisalDate.Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            else if (AppraisalDate.Contains("-"))
            {
                string[] details = AppraisalDate.Split('-');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));

            }
            js.ExecuteScript("document.getElementById('" + AppraisaleffectiveDate + "').value='" + tempDate + "'");
            DateTime temSignDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());

        }



        public void UpdateAlarm(string AlarmType)
        {
            WaitUntilElementVisible(driver, By.CssSelector(lblPersonalJewelryItems));
            driver.FindElement(By.CssSelector(selectAlarmType)).Click();
            UIAction(selectAlarmType, AlarmType, "textbox");
        }

        public void MakeJewelryItemInactiveinPC9(string InactiveReason, int Itemcounter)
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));
            SelectJewelryItemPC9(Itemcounter, "change");
            WaitUntilElementVisible(driver, By.CssSelector(lblItemScreen));
            UIAction(chckboxInactiveArticle, string.Empty, "a");

            driver.FindElement(By.CssSelector(selInactiveReason)).Click();

            WaitUntilElementVisible(driver, By.CssSelector(selInactiveReason));
            driver.FindElement(By.CssSelector(selInactiveReason)).Clear();
            UIAction(selInactiveReason, InactiveReason, "textbox");

            WaitUntilElementVisible(driver, By.CssSelector(btnUpdateJewelryItem));
            UIAction(btnUpdateJewelryItem, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));
        }

        public void ClickEditWorkOrderPC9()
        {
            WaitUntilElementVisible(driver, By.CssSelector(lblPersonalJewelryItems));
            UIAction(btnEditWorkOrder, string.Empty, "a");
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnOK), 5);
                driver.FindElement(By.CssSelector(btnOK)).Click();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Exception is " + e.Message);
            }
        }

        public void SelectJewelryItemPC9(int Counter, string type)
        {

            switch (type.ToLower().Trim())
            {
                case "change":
                    List<IWebElement> tempObj;
                    tempObj = driver.FindElements(By.Id("PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV:" + Counter + ":itemNo")).ToList();
                    tempObj[0].Click();
                    break;
            }





        }

        public void UpdateMultiJewelryItemDetailsPC9(string JewelryLocatedWith, string WearerFirstName, string WearerLastName, string WearerAddressLine1, string WearerCity, string WearerState, string WearerZipCode, string itemClass, string ValueOfItem, string Deductible, string Appraisal, string AppraisalDate, string JewelryBrand, string JewelryStyle, string JewelryItemStored, int Itemcounter)
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));
            UIAction(btnAddJwelryItems, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lblItemScreen));
            if (JewelryLocatedWith.ToLower().Equals("new"))
            {
                UIAction(btnAddressButtonMenuIcon, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(btnNewLocation), 10);
                UIAction(btnNewLocation, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lblNewlocation), 10);

                UIAction(txtFirstName, WearerFirstName, "textbox");
                UIAction(txtLastName, WearerLastName, "textbox");

                UIAction(txtAddressline1, WearerAddressLine1, "textbox");
                UIAction(txtCity, WearerCity, "textbox");
                driver.FindElement(By.CssSelector(txtCity)).SendKeys(Keys.Tab);
                driver.FindElement(By.CssSelector(textState)).Click();
                driver.FindElement(By.CssSelector(textState)).Clear();
                UIAction(textState, WearerState, "textbox");
                driver.FindElement(By.CssSelector(textState)).SendKeys(Keys.Tab);
                WaitUntilElementVisible(driver, By.CssSelector(textState + "[value='" + WearerState + "']"));


                if (IsElementPresent(driver, By.CssSelector(txtZipCode)) == false)
                {
                    WaitUntilElementVisible(driver, By.CssSelector(txtZipCode));
                }
                UIAction(txtZipCode, WearerZipCode, "textbox");
                driver.FindElement(By.CssSelector(txtZipCode)).SendKeys(Keys.Tab);
               // UIAction(btnVerifyAddressNewLoc, String.Empty, "a");
                //try
                //{
                //    if (IsElementPresent(driver, By.CssSelector(lblVerifyAddress)))
                //    {
                //        driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();

                //    }
                //    //if (IsElementPresent(driver, By.CssSelector(AcceptThisAddress)))
                //    //{
                //    //    driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();
                //    //    // UIAction(VerifyAddrPageOK, string.Empty, "span");
                //    //}
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine("issue is " + e.Message);
                //}
                pause();
                UIAction(btnNewLoctionOK, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lblItemScreen), 10);
            }

            driver.FindElement(By.CssSelector(selJewelryClass)).Click();
            //   WaitUntilElementVisible(driver, By.CssSelector(selLocatedWith + "[value='" + LocatedWith + "']"));
            driver.FindElement(By.CssSelector(selJewelryClass)).Clear();
            UIAction(selJewelryClass, itemClass, "textbox");

            driver.FindElement(By.CssSelector(JewelryValue)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(selJewelryClass + "[value='" + itemClass + "']"));
            UIAction(JewelryValue, ValueOfItem, "textbox");

            System.Console.WriteLine("JewelryBrand is " + JewelryBrand);
            if (JewelryBrand.Length > 1)
            {
                driver.FindElement(By.CssSelector(selBrand)).Clear();
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(selBrand + "[value='" + JewelryBrand + "']"), 3);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("selBrand exception message is " + e.Message);
                }
                UIAction(selBrand, JewelryBrand, "textbox");
            }

            System.Console.WriteLine("JewelryStyle is " + JewelryStyle);
            if (JewelryStyle.Length > 1)
            {
                driver.FindElement(By.CssSelector(selStyle)).Clear();
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(selStyle + "[value='" + JewelryStyle + "']"), 2);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("selStyle exception message is " + e.Message);
                }
                UIAction(selStyle, JewelryStyle, "textbox");
            }

            driver.FindElement(By.CssSelector(selDeductible)).Clear();
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(selDeductible + "[value='" + Deductible + "']"), 3);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("message is " + e.Message);
            }
            UIAction(selDeductible, Deductible, "textbox");

            if (Appraisal.ToLower().Trim() == "yes")
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_true-inputEl']", string.Empty, "a");
                if (AppraisalDate.Length > 0)
                {
                    setAppraisalDate(AppraisalDate);
                }
            }
            else
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_false-inputEl']", string.Empty, "a");
            }

            driver.FindElement(By.CssSelector(selItemStored)).Clear();
            UIAction(selItemStored, JewelryItemStored, "textbox");
            WaitUntilElementVisible(driver, By.CssSelector(btnUpdateJewelryItem));
            UIAction(btnUpdateJewelryItem, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnAddJwelryItems));

        }
    }
}

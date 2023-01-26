using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace PolicyCenterPages.Pages.Transaction
{
    public class PLPChange_JewelryItems : Page
    {
        //  string btnPolicyChangeAddJwelryItems = "a[id='PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV_tb:ToolbarButton1']";

        string btnAddJwelryItems = "a[id$=':LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV_tb:ToolbarButton1']";

      //  string btnAddJwelryItems = "a[id='PersonalItemJMICPLPanelSet:PersonalItemLV_tb:ToolbarButton1']";

        // string btnAddJwelryItems = "PersonalItemLV_tb:ToolbarButton1";

        string selLocatedWith = "select[id='JewelryItem_JMIC_PLPopup:LocatedWithPolicyRoleRangeInput']";

        string selLocatedWithCSS = "JewelryItem_JMIC_PLPopup:LocatedWithPolicyRoleRangeInput";

        string selJewelryClass = "select[id=JewelryItem_JMIC_PLPopup:ClassCodeTypeKeyInput']";

        string JewelryValue = "input[id='JewelryItem_JMIC_PLPopup:ValueInputCell']";

        string btnUpdateJewelryItem = "a[id='JewelryItem_JMIC_PLPopup:Update']";

        string personalItemTab = "span[id='JewelryItem_JMIC_PLPopup:ItemCV:PersonalItemCardTab']";

        string btnNext = "a[id='SubmissionWizard:Next']";

        string btnPolicyChangeNext = "a[id$=':Next']";

        string btnNextRewrite = "a[id='RewriteWizard:Next']";

        string chckboxInactiveArticle = "input[id='JewelryItem_JMIC_PLPopup:ActiveCheckboxInput']";

        string ChangeTableid = "PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV";

        string RewrireTableid = "RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV";


        string listInactiveReason = "select[id='JewelryItem_JMIC_PLPopup:InactiveReasonInput']";

        string txtFirstName = "input[id='NewPolicyLocatedWithPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:FirstName']";
        string txtLastName = "input[id='NewPolicyLocatedWithPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:LastName']";
        string txtAddressline1 = "input[id='NewPolicyLocatedWithPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:AddressLine1']";
        string txtCity = "input[id='NewPolicyLocatedWithPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:City']";
        string selectState = "select[id='NewPolicyLocatedWithPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:State']";
        string btnvalidateAddress = "a[id$=':validateAddress_JMIC']";
        string btnVerifyAddress = "a[id$=':verifyAddress_JMIC']";
        string btnOkAddressDetails = "a[id$=':ContactDetailScreen:Update']";
        string ZipCode = "NewPolicyLocatedWithPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";

        string btnAddressButtonMenuIcon = "a[id$=':LocatedWithPolicyRoleRangeInput:LocatedWithPolicyRoleRangeInputMenuIcon']";

        string selectVerifiedAddress = "span[id$=':selectAddress_link']";
        string acceptAddressChkBox = "input[id$=':acceptKeyInAddress']";

        string acceptAddress = "a[id$='VerifyAddress_JMIC_Popup:Update']";

        [FindsBy(How = How.Id, Using = "JewelryItem_JMIC_PLPopup:ValueInputCell")]
        public IWebElement txtJweleryValueClear;


        public PLPChange_JewelryItems(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
           SetActiveFrame("top_frame");

            VerifyUIElementIsDisplayed(btnAddJwelryItems);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnAddJwelryItems));
        }

      

        public void AddMultiJewelryItem(string LocatedWith, string itemClass, string ValueOfItem, string Deductible, string Appraisal, string AppraisalDate, int counter)
        {
            int Deductible_index = 0; 
            UIAction(btnAddJwelryItems, string.Empty, "a");
            Console.WriteLine("I am in Item Screen");
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            if (counter == 0)
            {
                if (LocatedWith.ToLower().Trim() == "self")
                {
                    SelectByIndex(PageInputs[0], 1);
                }
            }
            Console.WriteLine("I am in located with");
            pause();


            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
            pause();
            //   SelectByIndex(PageInputs[2], 1);
            SelectByText(PageInputs[2], itemClass);
            pause();

            Console.WriteLine("I am in Location");

            UIAction(JewelryValue, ValueOfItem, "textbox");
            pause();

            Console.WriteLine("I am in Item Value");

            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
           switch (Deductible.ToLower().Trim())
            {
                case "100":
                    Deductible_index = 1;
                    break;
                case "250":
                    Deductible_index = 2;
                    break;
                case "500":
                    Deductible_index = 3;
                    break;
                case "1000":
                    Deductible_index = 4;
                    break;
                case "2500":
                    Deductible_index = 5;
                    break;
                case "5000":
                    Deductible_index = 6;
                    break;
                case "10000":
                    Deductible_index = 7;
                    break;
                case "25000":
                    Deductible_index = 8;
                    break;
                case "50000":
                    Deductible_index = 9;
                    break;
                case "100000":
                    Deductible_index = 10;
                    break;
            }
          SelectByIndex(PageInputs[5], Deductible_index);

            pause();

            if (Appraisal.ToLower().Trim() == "yes")
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_true']", string.Empty, "a");
            }
            else
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_false']", string.Empty, "a");
            }
            pause();
            UIAction(btnUpdateJewelryItem, string.Empty, "a");
        }

    
        public void ClickPolicyChangeNextButton()
        {
            UIAction(btnPolicyChangeNext, string.Empty, "a");
        }

        public void AddJewelryItem(string LocatedWith, string itemClass, string ValueOfItem, string Deductible)
        {

            UIAction(btnAddJwelryItems, string.Empty, "a");

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            if (LocatedWith.ToLower().Trim() == "self")
                try
                {
                    SelectByIndex(PageInputs[0], 1);
                }
                catch (Exception e)
                {

                }
            pause();

            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            pause();
            //   SelectByIndex(PageInputs[2], 1);
            SelectByText(PageInputs[2], itemClass);

            pause();

            UIAction(JewelryValue, ValueOfItem, "textbox");

            pause();

            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            SelectByIndex(PageInputs[5], 1);

            pause();

            UIAction(btnUpdateJewelryItem, string.Empty, "a");

            pause();

            UIAction(btnNext, string.Empty, "a");

        }

        public void AddMultiJewelryItemwithDescriptionDate(string LocatedWith, string itemClass, string ValueOfItem, string Deductible, string Appraisal, string AppraisalDate, string DescriptionDate, int counter)
        {
            int Deductible_index = 0;
            UIAction(btnAddJwelryItems, string.Empty, "a");
            Console.WriteLine("I am in Item Screen");
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            if (counter == 0)
            {
                if (LocatedWith.ToLower().Trim() == "self")
                {
                    SelectByIndex(PageInputs[0], 1);
                }
            }
            Console.WriteLine("I am in located with");
            pause();


            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
            pause();
            //   SelectByIndex(PageInputs[2], 1);
            SelectByText(PageInputs[2], itemClass);
            pause();

            Console.WriteLine("I am in Location");

            UIAction(JewelryValue, ValueOfItem, "textbox");
            pause();

            Console.WriteLine("I am in Item Value");

            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
            switch (Deductible.ToLower().Trim())
            {
                case "100":
                    Deductible_index = 1;
                    break;
                case "250":
                    Deductible_index = 2;
                    break;
                case "500":
                    Deductible_index = 3;
                    break;
                case "1000":
                    Deductible_index = 4;
                    break;
                case "2500":
                    Deductible_index = 5;
                    break;
                case "5000":
                    Deductible_index = 6;
                    break;
                case "10000":
                    Deductible_index = 7;
                    break;
                case "25000":
                    Deductible_index = 8;
                    break;
                case "50000":
                    Deductible_index = 9;
                    break;
                case "100000":
                    Deductible_index = 10;
                    break;
            }
            SelectByIndex(PageInputs[5], Deductible_index);

            pause();

            if (Appraisal.ToLower().Trim() == "yes")
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_true']", string.Empty, "a");
            }
            else
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_false']", string.Empty, "a");
            }
            pause();
            UIAction(btnUpdateJewelryItem, string.Empty, "a");
        }

        public void MakeJewelryItemInactive(string InactiveReason, int Itemcounter)
        {
            SelectJewelryItem(Itemcounter, ChangeTableid);
            pause();
            UIAction(chckboxInactiveArticle, string.Empty, "a");
            pause();
            UIAction(listInactiveReason, InactiveReason, "selectbox");
            pause();
            UIAction(btnUpdateJewelryItem, string.Empty, "a");

        }


        public void SelectJewelryItem(int Counter, string tableid)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id(tableid)).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[Counter].FindElements(By.TagName("td"));
            Console.WriteLine("tds count is " + tds.Count());
            var celllink = tds[0].FindElements(By.TagName("a"));
            Console.WriteLine("celllink count is " + celllink.Count());
            Console.WriteLine("celllink id is " + celllink[0].GetAttribute("id"));
            try
            {
                celllink[0].Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(" Exception message is " + e.Message);
            }
        }

        public void clckNextButtonRewrite()
        {
            UIAction(btnNextRewrite, string.Empty, "a");
        }

        public void UpdateMultiJewelryItemDetails(string JewelryLocatedWith, string WearerFirstName, string WearerLastName, string WearerAddressLine1, string WearerCity, string WearerState, string WearerZipCode, string JewelryClass, string JewelryValueOfItem, string JewelryDeductible, string JewelryAppraisalReceived, string JewelryAppraisalDate, string JewelryBrand, string JewelryStyle, string JewelryItemStored, int Itemcounter)
        {
            SelectJewelryItem(Itemcounter, RewrireTableid);
            pause();
            if (JewelryLocatedWith.ToLower().Equals("new"))
            {
                UIAction(btnAddressButtonMenuIcon, string.Empty, "a");
                IList<IWebElement> EditCurrentAddressBtn = driver.FindElements(By.Id("JewelryItem_JMIC_PLPopup:LocatedWithPolicyRoleRangeInput:NewPolicyAddlInsured")).ToList();
                JavaScriptClick(EditCurrentAddressBtn[0]);
                pause();
                pause();
                UIAction(txtFirstName, WearerFirstName, "textbox");
                UIAction(txtLastName, WearerLastName, "textbox");
                UIAction(txtAddressline1, WearerAddressLine1, "textbox");
                UIAction(txtCity, WearerCity, "textbox");
                UIAction(selectState, WearerState, "selectbox");
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + WearerZipCode + "'");
                UIAction(btnVerifyAddress, string.Empty, "a");
                pause();
                pause();
                pause();
                List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();


                if (PageInputs.Count > 0)
                {
                    UIAction(selectVerifiedAddress, "", "a");

                    UIAction(acceptAddressChkBox, string.Empty, "a");

                    UIAction(acceptAddress, string.Empty, "button");
                }

                UIAction(btnOkAddressDetails, string.Empty, "a");

                pause();
            }

            pause();
            pause();
            pause();
            pause();


            List<IWebElement> PageInputs1 = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            pause();
            //   SelectByIndex(PageInputs[2], 1);
            SelectByText(PageInputs1[2], JewelryClass);

            pause();
            //txtJweleryValueClear.Click();

            ////IWebElement TextItemvalue = driver.FindElement(By.Id("JewelryItem_JMIC_PLPopup:ValueInputCell"));
            ////IJavaScriptExecutor js1= (IJavaScriptExecutor)driver;
            ////js1.ExecuteScript("document.getElementById('JewelryItem_JMIC_PLPopup:ValueInputCell').value=''");

            ////  TextItemvalue.Clear();
            Console.WriteLine("I will update Item Value");
            Console.WriteLine("Jwelery Item value is " + JewelryValueOfItem);
            //UIAction(JewelryValue, JewelryValueOfItem, "textbox");
            //txtJweleryValueClear.Clear();
            UIAction(JewelryValue, JewelryValueOfItem, "textbox");


            pause();

            PageInputs1 = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
            int Deductible_index = 0;
            switch (JewelryDeductible.ToLower().Trim())
            {
                case "100":
                    Deductible_index = 1;
                    break;
                case "250":
                    Deductible_index = 2;
                    break;
                case "500":
                    Deductible_index = 3;
                    break;
                case "1000":
                    Deductible_index = 4;
                    break;
                case "2500":
                    Deductible_index = 5;
                    break;
                case "5000":
                    Deductible_index = 6;
                    break;
                case "10000":
                    Deductible_index = 7;
                    break;
                case "25000":
                    Deductible_index = 8;
                    break;
                case "50000":
                    Deductible_index = 9;
                    break;
                case "100000":
                    Deductible_index = 10;
                    break;
            }
            SelectByIndex(PageInputs1[5], Deductible_index);

            pause();
            pause();

            UIAction(btnUpdateJewelryItem, string.Empty, "a");

            pause();



        }
    }
}

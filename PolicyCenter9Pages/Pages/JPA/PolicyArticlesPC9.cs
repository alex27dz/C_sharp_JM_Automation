using HelperClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.JPA
{
    public class PolicyArticlesPC9 : Page
    {
        string selSafedetails = "input[id$=':JewelryItemDV:SafeDetailsRangeInput-inputEl']";
        string lblAdditionaldetails = "span[id$= ':JPAAdditionalDetailsScreen:ttlBar']";
        string labelAppraisalrequestedYes = "label[id$=':AppraisalRequestedFlag_true-boxLabelEl']";
        string labelAppraisalrequestedNo = "label[id$=':AppraisalRequestedFlag_false-boxLabelEl']";
        string labelWearableTechYes = "input[id$=':WearableTechID_true-inputEl']";
        string labelWearableTechNo = "input[id$=':WearableTechID_false-inputEl']";
        string labelAppraisalrecivedYes = "label[id$=':AppraisalDisReceivedId_true-boxLabelEl']";
        string labelAppraisalrecivedNo = "label[id$=':AppraisalDisReceivedId_false-inputEl']";
        string lblPersonalArticles = "span[id$= ':PersonalArticle_JMScreen:ttlBar']";
        string checkUnscheduled = "input[id$ = ':JPALineStandardCoveragesDV:0:CoverageInputSet:CovPatternInputGroup:_checkbox']";
        string selUnschedulelimit = "input[id$= ':UnscheduledLimitInput-inputEl']";
        string selUnschedulelimitDeduc = "input[id$= ':UnscheduledDeductibleInput-inputEl']";
        string btnAdd = "a[id$=':PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP_tb:Add']";
        string lblArticleDetails = "span[id$=':JewelryItemCardCV:JewelryItemCardIdCVTab-btnInnerEl']";
        string selLocatedWith = "input[id$=':JewelryItemDV:LocatedWithLabel-inputEl']";
        string selJewelryClass = "input[id$=':JewelryItemDV:ItemTypeId-inputEl']";
        string selitemSubType = "input[id$=':JewelryItemDV:ItemSubTypeId-inputEl']";
        string selitemGender = "input[id$=':JewelryItemDV:Genderid-inputEl']";
        string selbrand = "input[id$=':JewelryItemDV:Brand-inputEl']";
        string selstyle = "input[id$=':JewelryItemDV:Style-inputEl']";
        string selDeductible = "input[id$=':JewelryItemDV:DeductibleID-inputEl']";
        string chckFullDescriptin = "input[id$=':JewelryItemDV:Overridefulldesc-inputEl']";
        string txtDescriptin = "textarea[id$= 'JewelryItemDV:FulldescId-inputEl']";
        string txtvalue = "input[id$=':JewelryItemCardCV:JewelryItemDV:LimitId-inputEl']";
        string txtAppraisalDate = "input[id$=':JewelryItemDV:AppraisalDate-inputEl']";
        string txtvaluationtype = "input[id$= ':JewelryItemDV:Valuationtype-inputEl']";

        string selAffinityGroup = "input[id$= ':AffinityGroup-inputEl']";
        string radioDamgeYes = "input[id$= ':IsDamagedId_true-inputEl']";
        string radioDamgeNo = "input[id$= ':IsDamagedId_false-inputEl']";
        string txtDamagetype = "input[id$= ':JewelryItemDV:DamageId-inputEl']";
        string selArticlestored = "input[Id$= ':StorageId-inputEl']";
        string radioCareplanflagYes = "input[id$= ':Hascareplanid_true-inputEl']";
        string radioCareplanflagNo = "input[id$= ':Hascareplanid_false-inputEl']";
        string txtCareplanexpirationdate = "input[id$= ':Careplandateid-inputEl']";
        string txtCareplanid = "input[id$= ':Careplanid-inputEl']";
        string selArticleacquired = "input[id$= ':Articleacquisition-inputEl']";
        string txtArticleacquiredYear = "input[id$= ':Articleacquisitionyear-inputEl']";
        string selArticleinsuredbyother = "input[id$= ':Insuredbyother-inputEl']";
        string btnNextArticlesItem = "span[id$=':Next-btnInnerEl']";

        string txtcompanyName = "input[id$= ':Name-inputEl']";
        string radiocompanyjeweleryes = "input[id$= ':IsAccountHolderJeweler_true-inputEl']";
        string radiocompanyjewelerno = "input[id$= ':IsAccountHolderJeweler_false-inputEl']";

        string txtcompanyAddress1 = "input[id$= ':AddressLine1-inputEl']";
        string txtcompanyAddress2 = "input[id$= ':AddressLine2-inputEl']";
        string txtcompanycity = "input[id$= ':City-inputEl']";
        string txtcompanystate = "input[id$= ':State-inputEl']";
        string txtcompanyzip = "input[id$= ':PostalCode-inputEl']";
        string btnverifyAddress = "a[id$=':verifyAddress_JMIC']";

        string txtlocation = "input[id$=':JewelryItemDV:Location-inputEl']";

        //  string AcceptThisAddress = "input[id='VerifyAddress_JMIC_Popup:acceptKeyInAddress-inputEl']";
        string VerifyAddrPageOK = "span[id='VerifyAddress_JMIC_Popup:Update-btnInnerEl']";
        //  string VerifyAddressAccCreate = "a[id$=':likelyMatchedAddressLV:0:selectAddress']";
        string seladdressType = "input[id$= ':PolicyContactDetailsDV:AddressType']";
        string btnokvault = "a[id$= ':ContactDetailScreen:ForceDupCheckUpdate']";
        string btnbankvaultsource = "a[id$= ':ChangeVaultButtonMenuIcon']";

        string AddressErrorMsg = "//span[text()[contains(.,'Address is unverified. You must verify the address before updating contact information')]]";
        string VerifyAddressAccCreate = "span[id$=':verifyAddress_JMIC-btnInnerEl']";
        string AcceptThisAddress = "input[id='VerifyAddress_JMIC_Popup:acceptKeyInAddress-inputEl']";
        string selInactiveReason = "input[id$=':InactiveReason-inputEl']";
        string chckboxInactiveArticle = "input[id$=':ActiveCheckboxInput-inputEl']";
        string btnMassUpdateArticle = "a[id$=':PersonalArticlesEddit_DP_tb:ToolbarButton']";
        string irpmTab = "span[id$=':IPRMCVTab-btnInnerEl']";

        public PolicyArticlesPC9(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPersonalArticles);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPersonalArticles));
        }

        public void updateUnschedulelimit(string limit, string deductible)
        {
            driver.FindElement(By.XPath("//input[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:JPALineStandardCoveragesDV:0:CoverageInputSet:CovPatternInputGroup:_checkbox']")).Click();
            //UIAction(checkUnscheduled, string.Empty, "radio");
            WaitUntilElementVisible(driver, By.CssSelector(selUnschedulelimit), 20);
            UIAction(selUnschedulelimit, String.Empty, "a");
            UIAction(selUnschedulelimit, limit, "textbox");
            UIAction(selUnschedulelimitDeduc, String.Empty, "a");
            UIAction(selUnschedulelimitDeduc, deductible, "textbox");
        }



        public void updatePersonalArtile(string LocatedWith, string itemClass, string itemSubType, string gender, string wearabletech, string brand, string style, string ValueOfItem, string Deductible, string fulldescriptionflag, string fulldescription, string appraisalrequested, string appraisalrecieved, string AppraisalDate, string appraiser, string valuationtype)
        {

            DataStorage temp = new DataStorage();
            UIAction(btnAdd, String.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lblArticleDetails), 40);
            switch (LocatedWith.ToUpper().Trim())
            {
                case "SELF":

                    LocatedWith = temp.GetTempValue("FNAME") + " " + temp.GetTempValue("LNAME");
                    break;
            }
            driver.FindElement(By.CssSelector(selLocatedWith)).Clear();
            UIAction(selLocatedWith, LocatedWith, "textbox");


            driver.FindElement(By.CssSelector(selJewelryClass)).Click();
            driver.FindElement(By.CssSelector(selJewelryClass)).Clear();
            UIAction(selJewelryClass, itemClass, "textbox");

            driver.FindElement(By.CssSelector(txtvalue)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(selJewelryClass + "[value='" + itemClass + "']"));
            UIAction(txtvalue, ValueOfItem, "textbox");

            if (itemSubType.Length > 1)
            {
                driver.FindElement(By.CssSelector(selitemSubType)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(selJewelryClass + "[value='" + itemClass + "']"));
                driver.FindElement(By.CssSelector(selitemSubType)).Clear();
                UIAction(selitemSubType, itemSubType, "textbox");
            }
            try
            {
                driver.FindElement(By.CssSelector(selitemGender)).Click();
                driver.FindElement(By.CssSelector(selitemGender)).Clear();
                UIAction(selitemGender, gender, "textbox");     
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //WaitUntilElementVisible(driver, By.CssSelector(txtvalue), 30);
            //driver.FindElement(By.CssSelector(txtvalue)).Click();
            //UIAction(txtvalue, ValueOfItem, "textbox");
            driver.FindElement(By.CssSelector(selDeductible)).Clear();
            try
            {
                //WaitUntilElementVisible(driver, By.CssSelector(selDeductible + "[value='" + Deductible + "']"), 3);
                UIAction(selDeductible, Deductible, "textbox");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("message is " + e.Message);
            }


            pause();

            if (wearabletech.Length > 1)
            {
                Console.WriteLine("wearabletech value is " + wearabletech);
                switch (wearabletech.ToUpper().Trim())
                {
                    case "YES":
                        Console.WriteLine("for yes value");
                        JavaScriptClick(driver.FindElement(By.CssSelector(labelWearableTechYes)));
                        //  UIAction(labelWearableTechYes, string.Empty, "span");
                        break;
                    case "NO":
                        Console.WriteLine("for no value");
                        JavaScriptClick(driver.FindElement(By.CssSelector(labelWearableTechNo)));
                        // UIAction(labelWearableTechNo, String.Empty, "a");
                        break;
                }
            }


            if (brand.Length > 1)
            {
                driver.FindElement(By.CssSelector(selbrand)).Clear();
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(selbrand + "[value='" + brand + "']"), 2);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("selBrand exception message is " + e.Message);
                }
                UIAction(selbrand, brand, "textbox");
            }

            if (style.Length > 1)
            {
                driver.FindElement(By.CssSelector(selstyle)).Clear();
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(selstyle + "[value='" + style + "']"), 2);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("selStyle exception message is " + e.Message);
                }
                UIAction(selstyle, style, "textbox");
            }



            if (fulldescriptionflag.ToLower().Equals("yes"))
            {
                UIAction(chckFullDescriptin, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(txtDescriptin), 40);
            }

            if (appraisalrequested.Length > 1)
            {
                switch (appraisalrequested.ToUpper().Trim())
                {
                    case "YES":
                        JavaScriptClick(driver.FindElement(By.CssSelector(labelAppraisalrequestedYes)));
                        driver.FindElement(By.CssSelector(labelAppraisalrequestedYes)).Click();
                        break;
                    case "NO":
                        JavaScriptClick(driver.FindElement(By.CssSelector(labelAppraisalrequestedNo)));
                        break;
                }
            }



            if (appraisalrecieved.Length > 1)
            {
                switch (appraisalrecieved.ToUpper().Trim())
                {
                    case "YES":
                        JavaScriptClick(driver.FindElement(By.CssSelector(labelAppraisalrecivedYes)));
                        WaitUntilElementVisible(driver, By.CssSelector(txtAppraisalDate), 40);
                        UIAction(txtAppraisalDate, AppraisalDate, "textbox");
                        break;
                    case "NO":
                        JavaScriptClick(driver.FindElement(By.CssSelector(labelAppraisalrecivedNo)));
                        break;
                }
            }


            if (valuationtype.Length > 1)
            {
                UIAction(txtvaluationtype, String.Empty, "a");
                UIAction(txtvaluationtype, valuationtype, "textbox");
            }



        }

        public void ClickNextButton()
        {
            var element = driver.FindElement(By.CssSelector(btnNextArticlesItem));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
            UIAction(btnNextArticlesItem, string.Empty, "a");
            //WaitUntilElementVisible(driver, By.CssSelector(lblAdditionaldetails), 120);

        }

        public void updatePersonalArtileLocation(string JewelryLocation)
        {

            driver.FindElement(By.CssSelector(txtlocation)).Clear();
            UIAction(txtlocation, JewelryLocation, "textbox");
        }

        public void updatePersonalArtileAffinity(string affinitygroup, string damage, string damagetype, string articlestored, string safeDetails, string careplanflag, string careplanexpirationdate, string careplanID, string articleacquired, string articleacquiredYear, string articleinsuredbyother)
        {
            if (affinitygroup.Length > 1)
            {
                driver.FindElement(By.CssSelector(selAffinityGroup)).Click();
                driver.FindElement(By.CssSelector(selAffinityGroup)).Clear();
                UIAction(selAffinityGroup, affinitygroup, "textbox");
            }

            if (damage.Length > 1)
            {
                pause();
                switch (damage.ToUpper().Trim())
                {
                    case "YES":
                        JavaScriptClick(driver.FindElement(By.CssSelector(radioDamgeYes)));
                        WaitUntilElementVisible(driver, By.CssSelector(txtDamagetype), 40);
                        driver.FindElement(By.CssSelector(txtDamagetype)).Click();
                        driver.FindElement(By.CssSelector(txtDamagetype)).Clear();
                        UIAction(txtDamagetype, damagetype, "textbox");
                        break;
                    case "NO":
                        JavaScriptClick(driver.FindElement(By.CssSelector(radioDamgeNo)));
                        break;
                }
            }

            if (articlestored.Length > 1)
            {
                driver.FindElement(By.CssSelector(selArticlestored)).Click();
                driver.FindElement(By.CssSelector(selArticlestored)).Clear();
                UIAction(selArticlestored, articlestored, "textbox");
                driver.FindElement(By.CssSelector(selArticlestored)).SendKeys(Keys.Tab);
                if (articlestored.ToLower().Equals("safe"))
                {
                    WaitUntilElementVisible(driver, By.CssSelector(selSafedetails), 40);
                    driver.FindElement(By.CssSelector(selSafedetails)).Click();
                    WaitFor(driver.FindElement(By.XPath("//li[text()='" + safeDetails + "']"))).Click();
                }


            }
            if (careplanflag.Length > 1)
            {
                switch (careplanflag.ToUpper().Trim())
                {
                    case "YES":
                        JavaScriptClick(driver.FindElement(By.CssSelector(radioCareplanflagYes)));

                        string txtCareplanexpirationdate = "input[id$= ':Careplandateid-inputEl']";
                        string txtCareplanid = "input[id$= ':Careplanid-inputEl']";
                        WaitUntilElementVisible(driver, By.CssSelector(txtCareplanid), 50);
                        JavaScriptClick(driver.FindElement(By.CssSelector(txtCareplanexpirationdate)));
                        driver.FindElement(By.CssSelector(txtCareplanexpirationdate)).SendKeys(careplanexpirationdate);

                        //UIAction(txtCareplanexpirationdate, careplanexpirationdate, "textbox");
                        UIAction(txtCareplanid, careplanID, "textbox");
                        break;
                    case "NO":
                        JavaScriptClick(driver.FindElement(By.CssSelector(radioCareplanflagNo)));
                        break;
                }
            }



            if (articleacquired.Length > 1)
            {
                driver.FindElement(By.CssSelector(selArticleacquired)).Click();
                driver.FindElement(By.CssSelector(selArticleacquired)).Clear();
                UIAction(selArticleacquired, articleacquired, "textbox");
            }

            if (articleacquiredYear.Length > 1)
            {
                UIAction(txtArticleacquiredYear, articleacquiredYear, "textbox");
            }

            if (articleinsuredbyother.Length > 1)
            {
                driver.FindElement(By.CssSelector(selArticleinsuredbyother)).Click();
                driver.FindElement(By.CssSelector(selArticleinsuredbyother)).Clear();
                UIAction(selArticleinsuredbyother, articleinsuredbyother, "textbox");
            }


        }

        public void updateVault(string ItemFlag, string ValutType, string Name, string CompanyJeweler, string AddressType, string Address1, string Address2, string City, string State, string ZipCode, string ValutAddressType, int Itemcounter)
        {
            if (ItemFlag.ToLower().Equals("yes"))
            {
                //List<IWebElement> reservetableObj;
                pause();
                pause();
                UIActionExt(By.XPath("//img[@src='images/app/drop_button.png']"), "ispresent");
                UIActionExt(By.XPath("//img[@src='images/app/drop_button.png']"), "click", "", 0);

                switch (ValutType.ToUpper().Trim())
                {
                    case "ADD NEW BANK VAULT":
                        WaitUntilElementVisible(driver, By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP:JewelryItemCardCV:JewelryItemDV:ChangeVaultButton:VaultCompanyAdder-textEl"), 60);
                        driver.FindElement(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP:JewelryItemCardCV:JewelryItemDV:ChangeVaultButton:VaultCompanyAdder-textEl")).Click();
                        WaitUntilElementVisible(driver, By.Id("NewPolicyVaultContactPopup:ContactDetailScreen:ttlBar"), 60);
                        AddNewBankVault(Name, CompanyJeweler, AddressType, Address1, Address2, City, State, ZipCode, ValutAddressType);
                        break;
                    case "FROM ADDRESS BOOK":
                        WaitUntilElementVisible(driver, By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP:JewelryItemCardCV:JewelryItemDV:ChangeVaultButton:VaultABContactAdder-textEl"), 60);
                        driver.FindElement(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP:JewelryItemCardCV:JewelryItemDV:ChangeVaultButton:VaultABContactAdder-textEl")).Click();
                        WaitUntilElementVisible(driver, By.Id("ContactSearchPopup:ContactSearchScreen:ttlBar"), 60);
                        searchAddressBookVault(Name);
                        break;
                    default:

                        break;
                }

            }

        }


        public void AddNewBankVault(string Name, string CompanyJeweler, string AddressType, string Address1, string Address2, string City, string State, string ZipCode, string ValutAddressType)
        {

            UIAction(txtcompanyName, Name, "textbox");
            if (CompanyJeweler.ToLower().Equals("yes"))
            {
                driver.FindElement(By.CssSelector(radiocompanyjeweleryes)).Click();
            }
            else
            {
                driver.FindElement(By.CssSelector(radiocompanyjewelerno)).Click();
            }

            if (AddressType.ToLower().Equals("new"))
            {
                UIAction(txtcompanyAddress1, Address1, "textbox");
                UIAction(txtcompanyAddress2, Address2, "textbox");
                UIAction(txtcompanycity, City, "textbox");
                driver.FindElement(By.CssSelector(txtcompanycity)).SendKeys(Keys.Tab);
                driver.FindElement(By.CssSelector(txtcompanystate)).Click();
                driver.FindElement(By.CssSelector(txtcompanystate)).Clear();
                UIAction(txtcompanystate, State, "textbox");
                driver.FindElement(By.CssSelector(txtcompanystate)).SendKeys(Keys.Tab);
                WaitUntilElementVisible(driver, By.CssSelector(txtcompanystate + "[value='" + State + "']"));
                if (IsElementPresent(driver, By.CssSelector(txtcompanyzip)) == false)
                {
                    WaitUntilElementVisible(driver, By.CssSelector(txtcompanyzip));
                }

                UIAction(txtcompanyzip, ZipCode, "textbox");

                WaitUntilElementInvisible(driver, By.XPath(AddressErrorMsg));
                try
                {
                    IsElementPresent(driver, By.XPath(AddressErrorMsg));
                    if (IsElementPresent(driver, By.CssSelector(VerifyAddressAccCreate)))
                    {
                        if (IsElementPresent(driver, By.CssSelector(AcceptThisAddress)))
                        {
                            driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();
                            UIAction(VerifyAddrPageOK, string.Empty, "span");
                        }
                        else
                        {
                            UIAction(VerifyAddressAccCreate, string.Empty, "span");
                        }
                    }
                    if (IsElementPresent(driver, By.CssSelector(AcceptThisAddress)))
                    {
                        driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();
                        UIAction(VerifyAddrPageOK, string.Empty, "span");
                    }
                }
                catch
                {

                }

                WaitUntilElementVisible(driver, By.Id("NewPolicyVaultContactPopup:ContactDetailScreen:ttlBar"), 60);
                if (ValutAddressType.Length > 1)
                {
                    driver.FindElement(By.CssSelector(seladdressType)).Click();
                    driver.FindElement(By.CssSelector(seladdressType)).Clear();
                    UIAction(seladdressType, ValutAddressType, "textbox");
                }
                UIAction(btnokvault, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lblPersonalArticles), 60);

            }

        }


        public void searchAddressBookVault(string companyName)
        {
            string btnresetvaultAddressSbook = "a[id$=':SearchLinksInputSet:Reset']";
            string btnsearchvaultAddressSbook = "a[id$=':SearchLinksInputSet:Search']";
            string txtCompanyNamevaultAddressSbook = "input[id$=':Name-inputEl']";
            string btnSelectitem1vaultAddressSbook = "a[id$=':ContactSearchResultsLV:0:_Select']";

            driver.FindElement(By.CssSelector(btnresetvaultAddressSbook)).Click();
            UIAction(txtCompanyNamevaultAddressSbook, companyName, "textbox");
            driver.FindElement(By.CssSelector(btnsearchvaultAddressSbook)).Click();
            WaitUntilElementIsDisplayed(driver, By.XPath("//div[(contains(.,'Displaying')]"));
            driver.FindElement(By.CssSelector(btnSelectitem1vaultAddressSbook)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblPersonalArticles), 60);

        }

        public void MakeJPAItemInactiveinPC9PolicyChange(string InactiveReason, int Itemcounter)
        {
            SelectJewelryItemPC9(Itemcounter, "change");
            pause();
            UIAction(chckboxInactiveArticle, string.Empty, "a");


            WaitUntilElementVisible(driver, By.CssSelector(selInactiveReason), 60);
            driver.FindElement(By.CssSelector(selInactiveReason)).Click();


            driver.FindElement(By.CssSelector(selInactiveReason)).Clear();
            UIAction(selInactiveReason, InactiveReason, "textbox");

            //  WaitFor(driver.FindElement(By.XPath("//li[text()='" + InactiveReason + "']"))).Click();

        }

        public void ClickBtnMassUpdate()
        {
            pause();
            UIAction(btnMassUpdateArticle, string.Empty, "a");
        }

        public void SelectJewelryItemPC9(int Counter, string type)
        {
            switch (type.ToLower().Trim())
            {
                case "change":
                    List<IWebElement> reservetableObj;
                    reservetableObj = driver.FindElements(By.Id("PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP:JewelryItemsEdit_LV-body")).ToList();
                    System.Console.WriteLine("reservetableObj count is " + reservetableObj.Count());
                    var tabletemp = reservetableObj[0].FindElements(By.TagName("table"));
                    tabletemp[Counter].Click();
                    break;
            }
        }

        public void ClickIRPMTab()
        {
            var element = driver.FindElement(By.CssSelector(irpmTab));
            element.Click();
        }

        public void VerifyIRPMIsPreventedOrNot(String isPreventedOrNot)
        {
            string tbIRPM = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP:JewelryItemCardCV:7_ref-tbody";
            var drIRPMTable = driver.FindElement(By.Id(tbIRPM));
            List<IWebElement> lsGetTrElements = new List<IWebElement>(drIRPMTable.FindElements(By.TagName("tr")));
            System.Console.WriteLine("IRPM table rows: " + lsGetTrElements.Count());
            switch (isPreventedOrNot.ToLower().Trim())
            {
                case "not":
                    if (lsGetTrElements.Count() <= 2)
                    {
                        Assert.Fail("IRPM shold not be prevented, but it is prevented");
                    }
                    else
                    {
                        //System.Console.WriteLine("----------------IRPM Table-----------------");
                        // for (int i = 0; i < lsGetTrElements.Count(); i++)
                        // {
                        //	 System.Console.WriteLine(i + "-----" + lsGetTrElements[i].Text);
                        // }
                        // System.Console.WriteLine("----------------IRPM Table-----------------");
                    }
                    break;
                case "is":
                    if (lsGetTrElements.Count() > 2)
                    {
                        Assert.Fail("IRPM should be prevented, but it is not");
                    }
                    else
                    {
                       //Console.WriteLine("----------------IRPM Table:-----------------");
                       // for (int i = 0; i < lsGetTrElements.Count(); i++)
                       // {
                       //     Console.WriteLine(i + "-----" + lsGetTrElements[i].Text);
                       // }
                       // Console.WriteLine("----------------IRPM Table:-----------------");
                    }
                    break;
            }
        }

        public void VerifyIRPMNotContain(String thusOption)
        {
            string tbIRPM = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP:JewelryItemCardCV:7_ref-tbody";
            var drIRPMTable = driver.FindElement(By.Id(tbIRPM));
            List<IWebElement> lsGetTrElements = new List<IWebElement>(drIRPMTable.FindElements(By.TagName("tr")));
            System.Console.WriteLine("IRPM table rows: " + lsGetTrElements.Count());
            System.Console.WriteLine("----------------IRPM Table:-----------------"); 
            
            for (int i = 0; i < lsGetTrElements.Count(); i++)
            {
                 System.Console.WriteLine(i + "-----" + lsGetTrElements[i].Text);
                 string lineText = lsGetTrElements[i].Text;
                 if (lineText.Trim().Contains(thusOption))
                 {
                        Assert.Fail("IRPM should not contain the option " + thusOption);
                 }
            }
            
            System.Console.WriteLine("----------------IRPM Table:-----------------");
        }

        public void VerifyIRPMHasPercentageInOverall(String numOfPercentage)
        {
            string tbIRPM = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PersonalArticle_JMScreen:PersonalArticle_JMPanelSet:PersonalArticlesEddit_DP:JewelryItemCardCV:7_ref-tbody";
            var drIRPMTable = driver.FindElement(By.Id(tbIRPM));
            List<IWebElement> lsGetTrElements = new List<IWebElement>(drIRPMTable.FindElements(By.TagName("tr")));
            Boolean contain = false;
            System.Console.WriteLine("IRPM table rows: " + lsGetTrElements.Count());
            System.Console.WriteLine("----------------IRPM Table:-----------------");
            for (int i = 0; i < lsGetTrElements.Count(); i++)
            {          
                string lineText = lsGetTrElements[i].Text;
                System.Console.WriteLine(i + "-----" + lineText);
                if (lineText.Trim().Contains(numOfPercentage) && lineText.Trim().ToLower().Contains("overall"))
                {
                    contain = true;
                }
            }
            System.Console.WriteLine("----------------IRPM Table:-----------------");
            if (!contain)
            {
                Assert.Fail("IRPM should not contain the option " + numOfPercentage);
            }
        }
    }
}

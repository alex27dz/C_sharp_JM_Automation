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

namespace PolicyCenterPages.Pages.NewSubmission
{
   

    public class CL_LocationDetails : Page
    {
        //string btnNext = "a[id='SubmissionWizard:Next']";
        string btnNext = "a[id$=':Next']";

        string SegmentationCode = "input[id$=':SegmentationCode_JMIC']";

        string GenBusinessRetail = "input[id$=':Retail_JMIC']";

        //   string GenBusinessRepair = "input[id$=':Repair_JMIC']";

        string GenBusinessRepair = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:Repair_JMIC";

        //  string FulltimeEmployees = "input[id$=':FullTimeEmployees_JMIC']";

        string FulltimeEmployees = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:FullTimeEmployees_JMIC";

        //  string ParttimeEmployees = "input[id$=':PartTimeEmployees_JMIC']";

        string ParttimeEmployees = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:PartTimeEmployees_JMIC";

        // string PublicProtection = "select[id$=:PublicProtection_JMIC']";

        string PublicProtection = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:PublicProtection_JMIC";

        string LocationType = "ILMLocation_JMICPopup:ILMLocation_JMICCV:ILMLineLocationDetailInputSet:LocationType_JMIC";

        string ConstructionType = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:ConstructionType";

        string TotalArea = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:TotalArea";

        string AreaOccupied = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:AreaOccupied";

        string PercentSprinklered = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:PercentSprinklered";

        string SharedPremises = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuildingInfoILMLine_JMICInputSet:SharedPremises_false";

        string AddressLine1 = "input[id$=':AddressLine1']";

        string AddressLine2 = "input[id$=':AddressLine2']";

        string City = "input[id$=':City']";

        string State = "select[id$=':State']";

        string County = "input[id$=':County']";

        string Country = "select[id$=':Country']";

        string ILMLocZipCode = "ILMLocation_JMICPopup:ILMLocation_JMICCV:LocationDetailInputSet:AddressInputSet:PostalCode";


        public CL_LocationDetails(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(SegmentationCode);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(SegmentationCode));
        }

        public void EnterLocationDetails(string segmentationCode, string GeneralInformation, string FTEmployees, string PTEmployees, string publicProtection, string locationType, string constructionType, string totalBuildingArea, string areaOccupied, string percentSplinkered, string sharedPremises)
        {
            UIAction(SegmentationCode, segmentationCode, "textbox");

            Actions action3 = new Actions(driver);

            action3.SendKeys(Keys.Tab).Build().Perform();

            pause();

            pause();

            UIAction(GenBusinessRetail, "100" , "textbox");

            Actions action = new Actions(driver);

            action.SendKeys(Keys.Tab).Build().Perform();

            pause();

            pause();

            IsElementPresent(driver, By.CssSelector(GenBusinessRepair));

           // UIAction(GenBusinessRepair, "50" , "textbox");


            pause();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("document.getElementById('" + GenBusinessRepair + "').value='0'");

            js.ExecuteScript("document.getElementById('" + FulltimeEmployees + "').value='" + FTEmployees + "'");

            js.ExecuteScript("document.getElementById('" + ParttimeEmployees + "').value='" + PTEmployees + "'");

            js.ExecuteScript("document.getElementById('" + PublicProtection + "').selectedIndex='4'");

            js.ExecuteScript("document.getElementById('" + LocationType + "').selectedIndex='8'");

            Actions action1 = new Actions(driver);

            action1.SendKeys(Keys.Tab).Build().Perform();

            pause();

            pause();

            js.ExecuteScript("document.getElementById('" + ConstructionType + "').selectedIndex='1'");

            js.ExecuteScript("document.getElementById('" + TotalArea + "').value='" + totalBuildingArea + "'");

            js.ExecuteScript("document.getElementById('" + AreaOccupied + "').value='" + areaOccupied + "'");

            js.ExecuteScript("document.getElementById('" + PercentSprinklered + "').selectedIndex='1'");

            js.ExecuteScript("document.getElementById('" + SharedPremises + "').checked=true");

            Actions action2 = new Actions(driver);

            action2.SendKeys(Keys.Tab).Build().Perform();

            pause();

            pause();


        }
        public void EnterAddressDetails(string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement IAddressline = driver.FindElement(By.CssSelector(AddressLine1));
            WaitForEnabled(IAddressline);
            UIAction(AddressLine1, addressLine1, "textbox");
            UIAction(AddressLine2, addressLine2, "textbox");
            UIAction(City, city, "textbox");
            UIAction(State, state, "selectbox");
            js.ExecuteScript("document.getElementById('" + ILMLocZipCode + "').value='" + zipCode + "'");

            System.Threading.Thread.Sleep(2000);
            string VerifyAddress;
            if (ScenarioContext.Current["country"].ToString().ToLower() == "canada")
            {
                VerifyAddress = "a[id$=':validateAddress_JMIC']";
            }
            else
            {
                VerifyAddress = "a[id$=':verifyAddress_JMIC']";
            }
            string selectVerifiedAddress = "span[id$=':selectAddress_link']";
            string acceptAddressChkBox = "input[id$=':acceptKeyInAddress']";
            string acceptAddress = "a[id$='VerifyAddress_JMIC_Popup:Update']";
            UIAction(VerifyAddress, string.Empty, "a");
            System.Threading.Thread.Sleep(4000);
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();
            if (PageInputs.Count > 0)
            {
                UIAction(selectVerifiedAddress, string.Empty, "a");
                UIAction(acceptAddressChkBox, string.Empty, "a");
                UIAction(acceptAddress, string.Empty, "button");
                pause();
            }
        }

        public void EnterLocationDetailsNewYork(string segmentationCode, string GeneralInformation, string FTEmployees, string PTEmployees, string publicProtection, string locationType, string constructionType, string totalBuildingArea, string areaOccupied, string percentSplinkered, string sharedPremises)
        {
            UIAction(SegmentationCode, segmentationCode, "textbox");

            UIAction(GenBusinessRetail, "100", "textbox");

            Actions action = new Actions(driver);

            action.SendKeys(Keys.Tab).Build().Perform();

            pause();

            pause();

            //IsElementPresent(driver, By.CssSelector(GenBusinessRepair));

            //UIAction(GenBusinessRepair, "50", "textbox");


            pause();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //js.ExecuteScript("document.getElementById('" + GenBusinessRepair + "').value='0'");

            //js.ExecuteScript("document.getElementById('" + FulltimeEmployees + "').value='" + FTEmployees + "'");

            //js.ExecuteScript("document.getElementById('" + ParttimeEmployees + "').value='" + PTEmployees + "'");

            js.ExecuteScript("document.getElementById('" + PublicProtection + "').selectedIndex='4'");

            js.ExecuteScript("document.getElementById('" + LocationType + "').selectedIndex='8'");

            js.ExecuteScript("document.getElementById('" + ConstructionType + "').selectedIndex='1'");

            js.ExecuteScript("document.getElementById('" + TotalArea + "').value='" + totalBuildingArea + "'");

            js.ExecuteScript("document.getElementById('" + AreaOccupied + "').value='" + areaOccupied + "'");

            js.ExecuteScript("document.getElementById('" + PercentSprinklered + "').selectedIndex='1'");

            js.ExecuteScript("document.getElementById('" + SharedPremises + "').checked=true");

            js.ExecuteScript("document.getElementById('ILMLocation_JMICPopup:ILMLocation_JMICCV:LocationDetailInputSet:TerrorismTerritoryProp').selectedIndex='1'");


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
        public void EnterLocDetails_AI_ECOMM_MSV(Table table)
        {
            string txtFulltimeEmployees = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:FullTimeEmployees_JMIC";
            string txtParttimeEmployees = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:PartTimeEmployees_JMIC";
            string txtAnnualSales = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:AnnualSales_JMIC";
            string lstPublicProtection = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:PublicProtection_JMIC";
            string lstLocationType = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:LocationType_JMIC";
            System.Threading.Thread.Sleep(2000);
            UIAction(GenBusinessRetail, "100", "textbox");
            System.Threading.Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();
            System.Threading.Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + txtFulltimeEmployees + "').value='" + table.Rows[0]["FTEmployees"] + "'");
            js.ExecuteScript("document.getElementById('" + txtParttimeEmployees + "').value='" + table.Rows[0]["PTEmployees"] + "'");
            js.ExecuteScript("document.getElementById('" + lstPublicProtection + "').selectedIndex='4'");
            js.ExecuteScript("document.getElementById('" + lstLocationType + "').selectedIndex='5'");
            js.ExecuteScript("document.getElementById('" + txtAnnualSales + "').value='5,000,000'");
            action.SendKeys(Keys.Tab).Build().Perform();
            System.Threading.Thread.Sleep(2000);
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
            //WaitUntilElementVisible(driver, By.CssSelector(txtAddlIntrestName));
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
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + table.Rows[0]["ZipCode_BOP"] + "'");
            System.Threading.Thread.Sleep(5000);
            UIAction(btnOK, string.Empty, "button");

            string lnkLocAddCovgsTab = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:AdditionalCoveragesCardTab']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkLocAddCovgsTab));
            UIAction(lnkLocAddCovgsTab, string.Empty, "a");
            string lnkAddCoverages = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:BOPLocationAdditionalCoveragesCardPanelSet:BOPAdditionalCoveragesPanelSet:BOPCoveragesDV_tb:Add']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkAddCoverages));
            UIAction(lnkAddCoverages, string.Empty, "a");
            string txtKeyWord = "input[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchDV:Keyword']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtKeyWord));
            UIAction(txtKeyWord, "Electronic Commerce (E-Commerce)", "textbox");
            string btnSeach = "span[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search_link']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnSeach));
            UIAction(btnSeach, string.Empty, "button");

            string chkEcomm = "input[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchResultsLV:0:_Checkbox']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(chkEcomm));
            driver.FindElement(By.CssSelector(chkEcomm)).Click();
            string btnAddSelectedCovg = "a[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchResultsLV_tb:AddCoverageButton']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnAddSelectedCovg));
            UIAction(btnAddSelectedCovg, string.Empty, "a");

            string lnkCovgsQuestionTab = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:CoverageQuestionsCardTab']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkCovgsQuestionTab));
            UIAction(lnkCovgsQuestionTab, string.Empty, "a");
            for (int i = 0; i <= 4; i++)
            {
                string radioQuestion = "input[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:covQns:QuestionSetsDV:0:QuestionSetLV:" + i + ":QuestionInputSet:BooleanRadioInput_NoPost_false']";
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(radioQuestion));
                driver.FindElement(By.CssSelector(radioQuestion)).Click();
            }

            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkLocAddCovgsTab));
            UIAction(lnkLocAddCovgsTab, string.Empty, "a");

            string txtEcommAnnLimit = "input[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:BOPLocationAdditionalCoveragesCardPanelSet:BOPAdditionalCoveragesPanelSet:BOPCoveragesDV:1:BOPCoverageInputSet:CovPatternInputGroup:0:CovTermInputSet:DirectTermInput']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtEcommAnnLimit));
            UIAction(txtEcommAnnLimit, "10000", "textbox");
            string lstHazardGrp = "select[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:BOPLocationAdditionalCoveragesCardPanelSet:BOPAdditionalCoveragesPanelSet:BOPCoveragesDV:1:BOPCoverageInputSet:CovPatternInputGroup:5:CovTermInputSet:TypekeyTermInput']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstHazardGrp));
            UIAction(lstHazardGrp, "Medium", "selectbox");

            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkAddCoverages));
            UIAction(lnkAddCoverages, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtKeyWord));
            UIAction(txtKeyWord, "Manufactured Stock Valuation", "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnSeach));
            UIAction(btnSeach, string.Empty, "button");
            System.Threading.Thread.Sleep(2000);

            //System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(chkEcomm));
            driver.FindElement(By.CssSelector(chkEcomm)).Click();
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnAddSelectedCovg));
            UIAction(btnAddSelectedCovg, string.Empty, "a");

            UIAction(btnLocOK, string.Empty, "button");
            System.Threading.Thread.Sleep(3000);
            //UIAction(btnNext, string.Empty, "a");
            //System.Threading.Thread.Sleep(2000);

            //string btnBldAdd = "a[id$=':BOPLocationBuildingsLV_tb:Add']";
            //WaitUntilElementVisible(driver, By.CssSelector(btnBldAdd));
            //UIAction(btnBldAdd, string.Empty, "a");
        }

        public void EnterLocDetails_BOP(Table table)
        {
            string txtFulltimeEmployees = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:FullTimeEmployees_JMIC";
            string txtParttimeEmployees = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:PartTimeEmployees_JMIC";
            string txtAnnualSales = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:AnnualSales_JMIC";
            string lstPublicProtection = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:PublicProtection_JMIC";
            string lstLocationType = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:LocationType_JMIC";
            System.Threading.Thread.Sleep(2000);
            UIAction(GenBusinessRetail, "100", "textbox");
            System.Threading.Thread.Sleep(2000);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();
            System.Threading.Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + txtFulltimeEmployees + "').value='" + table.Rows[0]["FTEmployees"] + "'");
            js.ExecuteScript("document.getElementById('" + txtParttimeEmployees + "').value='" + table.Rows[0]["PTEmployees"] + "'");
            js.ExecuteScript("document.getElementById('" + lstPublicProtection + "').selectedIndex='4'");
            js.ExecuteScript("document.getElementById('" + lstLocationType + "').selectedIndex='5'");
            js.ExecuteScript("document.getElementById('" + txtAnnualSales + "').value='5,000,000'");
            action.SendKeys(Keys.Tab).Build().Perform();
            System.Threading.Thread.Sleep(2000);
            System.Threading.Thread.Sleep(2000);
            string btnLocOK = "a[id$=':Update']";
            UIAction(btnLocOK, string.Empty, "button");
            System.Threading.Thread.Sleep(3000);
        }

        public void LocationAddlCoverage(Table table)
        {
            string tabLocAddlCovgs = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:AdditionalCoveragesCardTab']";
            string btnAddCoverage = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:BOPLocationAdditionalCoveragesCardPanelSet:BOPAdditionalCoveragesPanelSet:BOPCoveragesDV_tb:Add']";
            string txtCoverage = "input[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchDV:Keyword']";
            string btnSearch = "span[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search_link']";
            string chkCovg = "input[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchResultsLV:0:_Checkbox']";
            string btnAddCovg = "a[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchResultsLV_tb:AddCoverageButton']";
            string btnOK = "a[id$='BOPLocationPopup:LocationScreen:Update']";

            WaitUntilElementVisible(driver, By.CssSelector(tabLocAddlCovgs));
            UIAction(tabLocAddlCovgs, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
            UIAction(btnAddCoverage, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtCoverage));
            UIAction(txtCoverage, table.Rows[0]["CoverageName"], "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnSearch));
            UIAction(btnSearch, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(chkCovg));
            UIAction(chkCovg, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnAddCovg));
            UIAction(btnAddCovg, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            UIAction(btnOK, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
        }

    }
}

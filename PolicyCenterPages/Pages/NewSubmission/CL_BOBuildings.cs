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

namespace PolicyCenterPages.Pages.NewSubmission
{
   

    public class CL_BOBuildings : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";

        string btnAddILMBuilding = "a[id$=':AddILMBuilding']";

        string btnAddAllILMBuildings = "a[id$=':LocationsEdit_DP_tb:addAllLocationsButton']";

        string BOLocationRow;

        string btnOK = "a[id$=':Update']";

        string lnkSearchTerritoryCode = "a[id$=':TerritoryCode:SelectTerritoryCode']";

        string btnSelectLink = "span[id$=':0:_Select_link']";

        string lnkLocation;

        public CL_BOBuildings(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            pause();

            //VerifyUIElementIsDisplayed(btnAddILMBuilding);
            VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
            //IsElementPresent(driver, By.CssSelector(btnAddILMBuilding));
        }

        public void BOAddILMLocation()
        {
            pause();

            UIAction(btnAddILMBuilding, string.Empty, "a");

            pause();
        }

        public void BOBuildingNext()
        {
            UIAction(btnNext, string.Empty , "a");
        }

        public void BOAddAllILMLocations()
        {
            pause();

            UIAction(btnAddAllILMBuildings, string.Empty, "a");

            pause();
        }
        public void SelectBOLocation(int LocationNum)
        {
            pause();
            pause();
            BOLocationRow = "span[id$=':BOPLocationsLV:" + (LocationNum - 1) + ":LocNum']";
            UIAction(BOLocationRow, string.Empty, "a");
            pause();
        }

        public void VerifyBOLocSegmentationCode()
        {

            List<IWebElement> LocationsTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPLocationsScreen:BOPLocationsPanelSet:LocationsEdit_DP:LocationsEdit_LV']")).ToList();
            IList<IWebElement> LocationRows = new List<IWebElement>(LocationsTable[0].FindElements(By.TagName("tr")));
            Console.WriteLine("BO locations Table Rows: " + LocationRows.Count);
            pause();
            for (int i = 1; i < LocationRows.Count(); i++)
            {
                lnkLocation = "a[id$=':" + (i - 1) + ":Loc']";
                UIAction(lnkLocation, string.Empty, "a");
                UIAction(lnkSearchTerritoryCode, string.Empty, "a");
                UIAction(btnSelectLink, string.Empty, "a");
                UIAction(btnOK, string.Empty, "a");
            }
        }

        public void VerifyBOLocSegmentationCode_NewYork()
        {

            List<IWebElement> LocationsTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPLocationsScreen:BOPLocationsPanelSet:LocationsEdit_DP:LocationsEdit_LV']")).ToList();
            IList<IWebElement> LocationRows = new List<IWebElement>(LocationsTable[0].FindElements(By.TagName("tr")));
            Console.WriteLine("BO locations Table Rows: " + LocationRows.Count);
            pause();
            for (int i = 1; i < LocationRows.Count(); i++)
            {
                lnkLocation = "a[id$=':" + (i - 1) + ":Loc']";
                UIAction(lnkLocation, string.Empty, "a");
                string FulltimeEmployees = "input[id$=':LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:FullTimeEmployees_JMIC']";
                string ParttimeEmployees = "input[id$=':LocationDetailCV:LocationDetailDV:BOPLineLocationDetailInputSet:PartTimeEmployees_JMIC']";
                if (i == 1)
                {
                    pause();
                    pause();
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("document.getElementById('BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:LocationDetailInputSet:TerrorismTerritoryLiab').selectedIndex='1'");
                    UIAction(FulltimeEmployees, "10", "textbox");
                    UIAction(ParttimeEmployees, "10", "textbox");
                    UIAction(btnOK, string.Empty, "a");
                }
                else
                {
                    pause();
                    UIAction(btnOK, string.Empty, "a");
                }
            }


        }

        public void VerifyBOLocSegmentationCode_NoSegCode()
        {

            List<IWebElement> LocationsTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPLocationsScreen:BOPLocationsPanelSet:LocationsEdit_DP:LocationsEdit_LV']")).ToList();
            IList<IWebElement> LocationRows = new List<IWebElement>(LocationsTable[0].FindElements(By.TagName("tr")));
            Console.WriteLine("BO locations Table Rows: " + LocationRows.Count);
            pause();
            for (int i = 1; i < LocationRows.Count(); i++)
            {
                lnkLocation = "a[id$=':" + (i - 1) + ":Loc']";
                UIAction(lnkLocation, string.Empty, "a");
                System.Threading.Thread.Sleep(2000);
                UIAction(lnkSearchTerritoryCode, string.Empty, "a");
                System.Threading.Thread.Sleep(2000);
                string btnSearchSeg = "span[id$='TerritoryCodeSearchPopup:TerritoryCodeSearchScreen:TerritoryCodeSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search_link']";
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('TerritoryCodeSearchPopup:TerritoryCodeSearchScreen:TerritoryCodeSearchDV:PostalCode').value=''");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Before Search");
                UIAction(btnSearchSeg, string.Empty, "span");
                Console.WriteLine("After Search");
                System.Threading.Thread.Sleep(3000);
                pause();
                pause();
                UIAction(btnSelectLink, string.Empty, "a");
                System.Threading.Thread.Sleep(2000);
                UIAction(btnOK, string.Empty, "a");

                List<IWebElement> lstbtnClear = driver.FindElements(By.CssSelector("a[id$='WebMessageWorksheet:WebMessageWorksheetScreen:WebMessageWorksheet_ClearButton']")).ToList();
                if (lstbtnClear.Count == 1)
                {
                    //WaitUntilElementVisible(driver, By.CssSelector(lstbtnClear[0]));
                    //UIAction(btnClear, string.Empty, "a");
                    lstbtnClear[0].Click();
                    System.Threading.Thread.Sleep(2000);
                    System.Threading.Thread.Sleep(2000);
                    UIAction(btnOK, string.Empty, "a");
                }
            }
        }
    }
}

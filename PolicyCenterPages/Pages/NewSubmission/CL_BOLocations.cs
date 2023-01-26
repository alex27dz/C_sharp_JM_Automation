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


    public class CL_BOLocations : Page
    {
        string btnNext = "a[id$='SubmissionWizard:Next']";

        string EditTerritoryCode = "input[id$=':LocationDetailInputSet:TerritoryCode']";

        string selectPackageLevel = "select[id$=':BOPWizardStepGroup:BOPScreen:BOPLineDV:PackageLevel']";

        string btnOK = "a[id$=':Update']";
        string lnkLocation = "a[id$=':0:Loc']";

        public CL_BOLocations(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void BOLOcationsNext()
        {
            UIAction(btnNext, string.Empty, "a");
        }

        public void BOLOcationSetTerritoryCode(string Territory)
        {
            UIAction(lnkLocation, string.Empty, "a");
            UIAction(EditTerritoryCode, Territory, "textbox");

            UIAction(btnOK, string.Empty, "a");

        }
        public void VisitBOLocation()
        {
            UIAction(lnkLocation, string.Empty, "a");
            UIAction(btnOK, string.Empty, "a");
        }

        public void visitAllBOLocations()
        {
            List<IWebElement> LocationsTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPLocationsScreen:BOPLocationsPanelSet:LocationsEdit_DP:LocationsEdit_LV']")).ToList();
            IList<IWebElement> LocationRows = new List<IWebElement>(LocationsTable[0].FindElements(By.TagName("tr")));
            Console.WriteLine("BO locations Table Rows: " + LocationRows.Count);
            pause();
            for (int i = 1; i < LocationRows.Count(); i++)
            {
                lnkLocation = "a[id$=':" + (i - 1) + ":Loc']";
                UIAction(lnkLocation, string.Empty, "a");
                pause();
            }
        }

        public void SelectBOPLocation(int locNum)
        {
            System.Threading.Thread.Sleep(2000);
            string ILMLoc = "span[label='Loc. #'][value='" + locNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLoc));
            UIAction(ILMLoc, string.Empty, "span");
        }

    }
}

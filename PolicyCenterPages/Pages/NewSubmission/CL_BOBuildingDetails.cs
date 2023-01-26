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
   

    public class CL_BOBuildingDetails : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";

        string btnUpdate = "a[id$=':Update']";

        string searchPredominantBuildingOccupancy  = "a[id$=':BOPBuildingClassCodeRange:SelectOrganization']";

        string selectFirstSearchResult = "span[id$=':0:_Select_link']";

        string selBuildingCodeEffectivenessGrade = "select[id$=':BuildingCodeEffectivenessGrade']";

        string radioTheftExclusionIndicatorFalse = "input[id$=':BOPTheftExclusionIndicator_false']";

        string radioBrandsAndLabelsIndicatorFalse = "input[id$=':BOPBrandsAndLabelsIndicator_false']";

         string radioTheftExclusionIndicatorTrue = "input[id$=':BOPTheftExclusionIndicator_true']";

        string radioBrandsAndLabelsIndicatortrue = "input[id$=':BOPBrandsAndLabelsIndicator_true']";

        string tabPackageCoverages = "a[id$=':PackageCoveragesTab']";

        string selPackageLevel = "select[id$=':PackageLevel']";


        public CL_BOBuildingDetails(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnUpdate);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnUpdate));
        }

        public void AddBuildingDetails()
        {
            UIAction(searchPredominantBuildingOccupancy, string.Empty , "a");

            UIAction(selectFirstSearchResult, string.Empty , "span");

            UIAction(selBuildingCodeEffectivenessGrade, "2", "selectbox");

            UIAction(radioTheftExclusionIndicatorFalse, string.Empty , "span");

            UIAction(radioBrandsAndLabelsIndicatorFalse, string.Empty , "span");

            pause();

            string txtNoOfFloors = "input[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_DetailsDV:CommonBuildingInfoBOPInputSet:NumStories']";
            List<IWebElement> lstNumofFloors = driver.FindElements(By.CssSelector(txtNoOfFloors)).ToList();
            if (lstNumofFloors.Count == 1)
                UIAction(txtNoOfFloors, "2", "textbox");

            //    UIAction(tabPackageCoverages, string.Empty , "a");

            //    UIAction(selPackageLevel, "Silver", "selectbox");

        }
    }
}

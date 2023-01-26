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

namespace PolicyCenterPages.Pages.NewSubmission
{
    public class CL_RiskAnalysis : Page
    {
        string btnQuote = "a[id$=':QuoteOrReview']";

        string btnClear = "a[id$=':WebMessageWorksheet_ClearButton']";

        string btnNext = "a[id='SubmissionWizard:Next']";

        string leftNavBusinessOwners = "a[id$=':BOPWizardStepGroup']";

        string leftNavPolicyContract = "a[id$=':LOBWizardStepGroup']";

        string location1 = "a[id$=':LocationsEdit_LV:0:Loc']";

        string tabPackageCoverages = "a[id$=':PackageCoveragesTab']";

        string selPackageLevel = "select[id$=':PackageLevel']";

        string btnOK = "a[id$=':Update']";

       

        public CL_RiskAnalysis(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnQuote);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnQuote));
        }

        public void RiskAnalysisQuote()
        {
            //UIAction(leftNavBusinessOwners, string.Empty , "a");

            //UIAction(btnNext, string.Empty , "a");

            //pause();

            //UIAction(location1, string.Empty , "a");

            //pause();

            //UIAction(tabPackageCoverages, string.Empty, "a");

            //UIAction(selPackageLevel, "Silver", "selectbox");

            //UIAction(btnOK, string.Empty , "a");

            //for (int i = 0; i < 8; i++)
            //{
            //    pause();

            //    pause();

            //    pause();

            //    UIAction(btnNext, string.Empty , "a");
            //}

            //UIAction(btnClear, string.Empty , "a");

            //pause();

            UIAction(btnQuote, string.Empty , "a");

        }
    }
}

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
   

    public class CL_UmbrellaLine : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";

      //  string UmbrellaLimit = ":0:UMBCoverageInputSet:CovPatternInputGroup:UMBLimit";

          string selSelfInsuredRetention = "select[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBSI']";

        string selUmbrellaLimit = "select[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBLimit']";

        string selAdditionalPremium = "input[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBAddtnlPrem']";



        //  string selSelfInsuredRetention = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:UMBWizardStepGroup:UMBLineCoveragesScreen:UMBLineStandardCoveragesDV:0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBSI:";


        public CL_UmbrellaLine(IWebDriver driver) : base(driver)
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

        public void UpdateStandardCoverages(string UmbrellaLimit, string AdditionalPremium, string SelfInsuredRetention)
        {
            pause();
            UIAction(selUmbrellaLimit, UmbrellaLimit, "selectbox");
            pause();
            UIAction(selAdditionalPremium, AdditionalPremium, "textbox");
            pause();
            UIAction(selSelfInsuredRetention, "1", "selectbox");
            pause();
            UIAction(btnNext, string.Empty, "a");
        }

        public void BOUmbrellaLineDetails()
        {
            pause();

               UIAction(selSelfInsuredRetention, "2", "selectbox");

          //  IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           // js.ExecuteScript("document.getElementById('" + selSelfInsuredRetention + "').value='0'");

            UIAction(btnNext, string.Empty , "a");
        }
    }
}

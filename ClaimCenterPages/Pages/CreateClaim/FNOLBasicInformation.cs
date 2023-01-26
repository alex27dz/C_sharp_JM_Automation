using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace ClaimCenterPages.Pages.CreateClaim
{
    public class FNOLBasicInformation : Page
    {

        string btnNext = "a[id='FNOLWizard:Next']";

        string ReportedByName = "select[id$=':NewClaimPeopleDV:ReportedBy_Name']";

        string RelatedToInsured = "select[id$=':NewClaimPeopleDV:Claim_ReportedByType']";


        public FNOLBasicInformation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(ReportedByName);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(ReportedByName));
        }


        public void EnterBasicInformation(string ReportedName, string RelationToInsured)
        {
            UIAction(ReportedByName, ReportedName, "selectbox");

            UIAction(RelatedToInsured, RelationToInsured, "selectbox");

            UIAction(btnNext, string.Empty, "a");
        }
    }
}

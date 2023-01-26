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

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class FNOLClaimInformation_CC9 : Page
    {
        string btnNext = "a[id='FNOLWizard:Next']";
        string ClaimDescription = "textarea[id$=':NewClaimLossDetailsDV:Description-inputEl']";
		string txtLossCause = "input[id$=':Claim_LossCause-inputEl']";

        public FNOLClaimInformation_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(ClaimDescription);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//textarea[id$=':NewClaimLossDetailsDV:Description-inputEl']"));
        }

        public void EnterClaimInformation(string claimDescription, string lossCause)
        {
			UIActionExt(By.CssSelector(ClaimDescription), "Text", claimDescription);
			UIActionExt(By.CssSelector(txtLossCause), "List", lossCause);
			UIActionExt(By.CssSelector(btnNext), "click");

        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenterPages.Pages.CreateClaim
{
    public class CloseClaim : Page
    {
        string btnCloseClaim = "a[id$=':CloseClaimScreen:Update']";

        string txtCloseClaimNote = "textarea[id$=':CloseClaimInfoDV:Note']";

        string selOutcome = "select[id$=':CloseClaimInfoDV:Outcome']";

        string chkForceClose = "input[id$=':CloseClaimInfoDV:forceClose']";

        public CloseClaim(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnCloseClaim);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnCloseClaim));
        }

        public void CloseCurrentClaim()
        {
            UIAction(txtCloseClaimNote, "Selenium Test Note", "textbox");

            UIAction(selOutcome, "Payments Complete", "selectbox");

            UIAction(chkForceClose, string.Empty, "a");

            pause();

            UIAction(btnCloseClaim, string.Empty, "a");



        }

    }
}

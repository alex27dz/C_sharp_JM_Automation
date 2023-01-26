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
    public class AssignClaim : Page
    {
       
        string selAssignClaim = "select[id$=':AssignmentPopupDV:SelectFromList']";

        string btnAssign = "a[id$=':AssignmentPopupScreen_ButtonButton']";

        public AssignClaim(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(selAssignClaim);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(selAssignClaim));
        }

     
        public void AssignClaimAction()
        {
            UIAction(selAssignClaim, "1", "selectbox");
            pause();
            UIAction(btnAssign, string.Empty, "a");
        }

        public void ReAssignClaimAction()
        {
           // UIAction(selAssignClaim, "1", "selectbox");
            pause();
            UIAction(btnAssign, string.Empty, "a");
            pause();
        }
    }
}

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
   

    public class CL_BOLineReview : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";

       
        public CL_BOLineReview(IWebDriver driver) : base(driver)
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

      
        public void BOLineReviewNext()
        {
            UIAction(btnNext, string.Empty , "a");
        }
    }
}

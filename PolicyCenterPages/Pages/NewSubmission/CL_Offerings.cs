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
   

    public class CL_Offerings : Page
    {
        string selOfferingSelection = "select[id$=':OfferingSelection']";

        string btnNext = "a[id='SubmissionWizard:Next']";
        public CL_Offerings(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(selOfferingSelection);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(selOfferingSelection));
        }

        public void SelectOffering(string Offering)
        {
            pause();

            UIAction(selOfferingSelection, Offering , "selectbox");

            pause();

            IsElementPresent(driver, By.CssSelector(btnNext));

            pause();

            UIAction(btnNext, string.Empty , "a");
        }
    }
}

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
    public class PL_PolicyReview : Page
    {
        string btnQuote = "a[id$=':QuoteOrReview']";
        public PL_PolicyReview(IWebDriver driver) : base(driver)
        {

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


        public void QuotePolicy()
        {
            pause();

            UIAction(btnQuote, string.Empty , "a");

        }
    }

}

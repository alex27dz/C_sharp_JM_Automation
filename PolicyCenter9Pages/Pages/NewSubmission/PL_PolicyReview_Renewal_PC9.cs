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

namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class PL_PolicyReview_Renewal_PC9 : Page
    {
        string btnQuote = "span[id$=':RenewalQuote-btnInnerEl']";
        string btnRenewalQuote = "span[id$=':JobWizardToolbarButtonSet:RenewalQuote-btnInnerEl']";
        public PL_PolicyReview_Renewal_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnQuote);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnQuote));
        }
        public void QuotePolicyRenewal()
        {
            string lblQuote = "span[id$='_QuoteScreen:ttlBar']";
            driver.FindElement(By.CssSelector(btnRenewalQuote)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblQuote));
        }
    }
}

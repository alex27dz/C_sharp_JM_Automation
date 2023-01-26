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
    public class PL_PolicyReview_PC9 : Page
    {
        string btnQuote = "span[id$=':QuoteOrReview-btnInnerEl']";
        public PL_PolicyReview_PC9(IWebDriver driver) : base(driver)
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
        public void QuotePolicy()
        {
            string lblQuote = "span[id$='_QuoteScreen:ttlBar']";
            WaitUntilElementVisible(driver, By.CssSelector(btnQuote), 600);
            driver.FindElement(By.CssSelector(btnQuote)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblQuote));
        }

        public void QuotePolicyJPA()
        {
            string lblQuote = "span[id$='_QuoteScreen:ttlBar']";
            WaitUntilElementVisible(driver, By.CssSelector(btnQuote), 600);
            driver.FindElement(By.CssSelector(btnQuote)).Click();
            UIActionExt(By.CssSelector(lblQuote), "ispresent"); 
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenter9Pages.Pages.Transaction
{
    public class PolicyReinstatement_PC9 : Page
    {
        string lblPolicyReinstate = "span[id='ReinstatementWizard:ReinstatementWizard_ReinstatePolicyScreen:ttlBar']";
        string TxtReinstateReason = "input[id$=':ReinstatePolicyDV:ReasonCode-inputEl']";
        string btnQuote = "span[id$=':JobWizardToolbarButtonSet:QuoteOrReview-btnInnerEl']";
        string txtareareasondesc = "textarea[id$=':ReinstatementWizard_ReinstatePolicyScreen:ReinstatePolicyDV:ReasonDescription-inputEl']";
        public PolicyReinstatement_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyReinstate);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyReinstate));
        }

        public void setReinstateReason(string ReinstateReason)
        {
            WaitUntilElementVisible(driver, By.Id("ReinstatementWizard:ReinstatementWizard_ReinstatePolicyScreen:ReinstatePolicyDV:ReasonCode-inputEl"), 20);
            driver.FindElement(By.CssSelector(TxtReinstateReason)).Click();
            driver.FindElement(By.CssSelector(TxtReinstateReason)).Clear();
            UIAction(TxtReinstateReason, ReinstateReason, "textbox");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();
            UIAction(btnQuote, String.Empty, "a");          
        }
    }
}

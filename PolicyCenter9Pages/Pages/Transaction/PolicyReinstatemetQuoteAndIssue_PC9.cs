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
    public class PolicyReinstatemetQuoteAndIssue_PC9 : Page
    {      
        string lblPolicyReinstate = "span[id$='ReinstatementWizard:ReinstatementWizard_QuoteScreen:ttlBar']";   
        string btnReinstate = "span[id$='ReinstatementWizard:ReinstatementWizard_QuoteScreen:JobWizardToolbarButtonSet:Reinstate-btnInnerEl']";
        string btnOK = "span[id$='button-1005-btnInnerEl']";

        public PolicyReinstatemetQuoteAndIssue_PC9(IWebDriver driver) : base(driver)
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

        public void clickReinstateButton()
        {          
            WaitUntilElementVisible(driver, By.CssSelector(btnReinstate));
            driver.FindElement(By.CssSelector(btnReinstate)).Click();
        }

        public void clickOKToConfirmReinstate()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();
        }
    }
}
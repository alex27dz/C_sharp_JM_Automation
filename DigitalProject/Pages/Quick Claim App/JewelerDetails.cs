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
using System.Text.RegularExpressions;
using System.Threading;
using HelperClasses;
using iTextSharp.text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;


namespace DigitalProject.ClaimsApp
{
    public class JewelerDetailes : Page
    {
        #region Required

        public JewelerDetailes(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  VerifyUIElementIsDisplayed(VerifyPageElement);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("JewelerName"));
        }
        #endregion

        #region Elements
        string inputJewelerName = "input[id$='JewelerName']";
        string inputJewelerAddress = "input[id$='JewelerAddress']";
        string State = "select[id='JewelerState']";
        string inputCity = "input[id='JewelerCity']";
        string btnContinue = "input[id='continueButton']";


        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement ContinueButton;
        #endregion
        
        public void EnterJewelerDetails(string jewelerName, string jewelerAddress, string city, string state)
        {
            UIAction(inputJewelerName, jewelerName, "textbox");
            UIAction(inputJewelerAddress, jewelerAddress, "textbox");
            UIActionExt(By.CssSelector(inputCity), "ispresent");
            UIActionExt(By.CssSelector(inputCity), "Text", city);

            UIActionExt(By.CssSelector(State), "ispresent");
            SelectByText(driver.FindElement(By.CssSelector(State)), state);
          }

        public void SubmitClaim()
        {
            UIAction(btnContinue, String.Empty, "a");
            //SubmitClaimButton.Click();
        }



    }
}

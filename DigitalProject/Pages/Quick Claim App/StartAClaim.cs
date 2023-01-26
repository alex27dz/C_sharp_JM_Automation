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
    public class StartAClaim : Page
    {
        #region Required

        public StartAClaim(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  VerifyUIElementIsDisplayed(VerifyPageElement);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("EmailOrPolicy"));
        }
        #endregion

        #region Elements

        [FindsBy(How = How.Id, Using = "EmailOrPolicy")]
        public IWebElement PolicyNumberTextBox;

        string inputPolicyNumber = "input[id$='EmailOrPolicy']";

        string inputLastName = "input[id$='LastName']";

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastNameTextBox;

        string inputZipCode = "input[id$='ZipCode']";

        [FindsBy(How = How.Id, Using = "PolicyZipCode")]
        public IWebElement ZipCode;

        [FindsBy(How = How.CssSelector, Using = "#BypassRecaptcha")]
        public IWebElement CaptchaBox;

        [FindsBy(How = How.CssSelector, Using = ".validation-summary-errors > ul:nth-child(1)")]
        public IWebElement StartAClaimErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "div.col-md-12:nth-child(3) > span:nth-child(2) > span:nth-child(1)")]
        public IWebElement PolicyNumberErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(2) > div:nth-child(2) > span:nth-child(2) > span:nth-child(1)")]
        public IWebElement LastNameErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(3) > div:nth-child(2) > span:nth-child(2)")]
        public IWebElement ZipCodeErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "#recaptchaError")]
        public IWebElement CaptchaErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement ContinueButton;
        #endregion


        public void EnterPolicyNumber(string policyNumber)
        {
            PolicyNumberTextBox.Click();
            UIAction(inputPolicyNumber, policyNumber, "textbox");
        }


        public void EnterLastName(string lastName)
        {
            UIAction(inputLastName, lastName, "textbox");
        }

        public void EnterZipCode(string zipCode)
        {

            ZipCode.Click();
            UIAction(inputZipCode, zipCode, "textbox");
        }

        public void DisableCaptcha()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].setAttribute('value', 'true')", CaptchaBox);
        }

        public void ClickContinue()
        {
            ContinueButton.Click();
        }

        public void VerifyCLError()
        {
            Assert.IsTrue(StartAClaimErrorMessage.Text.Contains("Sorry, Report A Claim  is only for personal jewelry insurance accounts. Contact us at 800-558-6411 to report a claim for your jewelry business."), "Actual error mesasge text = " + StartAClaimErrorMessage.Text);
        }

        public void VerifyStartAClaimValidationMessages()
        {

            Assert.IsTrue(PolicyNumberErrorMessage.Text.Equals("Please enter your policy number."), "Actual Error Message" + PolicyNumberErrorMessage.Text);
            Assert.IsTrue(LastNameErrorMessage.Text.Equals("Please enter your last name."), "Actual Error Message" + LastNameErrorMessage.Text);
            Assert.IsTrue(ZipCodeErrorMessage.Text.Equals("Please enter your zip/postal code."), "Actual Error Message" + ZipCodeErrorMessage.Text);
            Assert.IsTrue(CaptchaErrorMessage.Text.Equals("Please confirm you\'re not a robot by checking the box above."), "Actual Error Message" + CaptchaErrorMessage.Text);

        }

    }
}

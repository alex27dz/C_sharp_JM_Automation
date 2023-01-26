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
    public class DateOfLoss : Page
    {
        #region Required
        public DateOfLoss(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  VerifyUIElementIsDisplayed(VerifyPageElement);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("PolicyNumber"));
        }

        #endregion

        #region Elements

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement ContinueButton;

        [FindsBy(How = How.ClassName, Using = ".pull-left")]
        public IWebElement BackButton;

        string inputDateOfLoss = "input[id$='NoticeDate']";

        [FindsBy(How = How.Id, Using = "NoticeDate")]
        public IWebElement fieldDateOfLoss;

        [FindsBy(How = How.CssSelector, Using = ".text-danger > span:nth-child(1)")]
        public IWebElement DateOfLossErrorMessage;

        [FindsBy(How = How.CssSelector, Using = ".validation-summary-errors > ul:nth-child(1) > li:nth-child(1)")]
        public IWebElement FutureDateErrorMessage;

        #endregion


        public void DateOfLossField(string dateOfLoss)
        {
            fieldDateOfLoss.Click();
            UIAction(inputDateOfLoss, dateOfLoss, "textbox");
        }

        public void EnterTodaysDate()
        {
            fieldDateOfLoss.Click();
            string today = DateTime.Now.ToString("MM/dd/yyyy");
            fieldDateOfLoss.SendKeys(today);
        }
        public void VerifyFNOLErrors()
        {
            Assert.IsTrue(DateOfLossErrorMessage.Text.Equals("The Date of Loss is required."), "Actual Error Message" + DateOfLossErrorMessage.Text);

            fieldDateOfLoss.SendKeys("05/05/2020");
            ContinueButton.Click();
            Assert.IsTrue(FutureDateErrorMessage.Text.Equals("Sorry, you can\'t use a future date for your loss or damage."), "Actual Error Message" + FutureDateErrorMessage.Text);
            fieldDateOfLoss.Clear();
        }
    }
}

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
    public class Description : Page
    {
        #region Required
        public Description(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(textItemtDescription);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("ItemDescription"));
        }

        #endregion

        #region Elements
        string textItemtDescription = "textarea[id$='ItemDescription']";

        string textWhatHappenedDescription = "textarea[id$='Description'][name$='Description']";

        [FindsBy(How = How.Id, Using = "Description")]
        public IWebElement DescriptionField;

        [FindsBy(How = How.CssSelector, Using = ".text-danger > span:nth-child(1)")]
        public IWebElement DescriptionErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement SubmitClaimButton;


        #endregion


        public void EnterDescriptionWhatHappened(string description)
        {
            IWebElement txtareadescription;

            txtareadescription = driver.FindElement(By.XPath("//textarea[@id='Description']"));
            txtareadescription.SendKeys(description);
            pause();

        }

        public void EnterDescriptionLostItem(string description)
        {
            UIAction(textItemtDescription, description, "textbox");
            pause();
        }

        public void SubmitClaim()
        {
            SubmitClaimButton.Click();
        }



        public void DescriptionError()
        {
            Assert.IsTrue(DescriptionErrorMessage.Text.Equals("Please enter a description."), "Actual Description Name Error Message" + DescriptionErrorMessage.Text);
        }
    }
}

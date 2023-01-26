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
    public class ClaimCreatedScreen : Page
    {
        #region Required
        public ClaimCreatedScreen(IWebDriver driver) : base(driver)
        {
            //Console.WriteLine("Constructor");
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //Console.WriteLine("VerifyPage");
       
        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("a[text() ='Return to Home']"));
            Console.WriteLine("Wait For Page Load");
          
        }

        #endregion

        #region Elements


        [FindsBy(How = How.CssSelector, Using = "div.row:nth-child(2) > div:nth-child(1) > b:nth-child(1)")]
        public IWebElement ClaimNumber;

        [FindsBy(How = How.CssSelector, Using = "a.btn:nth-child(7)")]
        public IWebElement ReturnToHome;

        [FindsBy(How = How.CssSelector, Using = "body > div.container.body-content > div > div.panel.jm-panel > div:nth-child(5) > div")]
        public IWebElement ClaimSubmittedText;

        #endregion


        public void StoreClaimNumber()
        {
            Console.WriteLine("Find Claim");
            IWebElement ClaimNumber = driver.FindElement(By.XPath("//input[@id='ClaimNumber']"));
            Console.WriteLine(ClaimNumber.GetAttribute("value"));
            ScenarioContext.Current.Add("CLAIM", ClaimNumber.GetAttribute("value"));
            

        }

        public void VerifyText()
        {
            string cst = ClaimSubmittedText.Text;
            Console.WriteLine("Claim submitted text =  " + ClaimSubmittedText.Text + "Expected Text" + "We’ll reach out (by email and mail) within 2-3 business days to continue your claims process and get you on your way to a resolution.");
            Assert.IsTrue(cst.Contains("We’ll reach out (by email and mail) within 2-3 business days to continue your claims process and get you on your way to a resolution."));
        }
    }
}

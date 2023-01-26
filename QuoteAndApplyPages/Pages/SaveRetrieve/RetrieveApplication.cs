using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace QuoteAndApplyPages.Pages.SaveRetrieve
{
    public class RetrieveApplication : Page
    {
        string editZipCode = "input[id$='QuoteZipCode']";
        string txtRetrieveZipCode = "input[id$='ZipCode']";
        string txtRetrieveLastName = "input[id$='LastName']";
        string txtRetrieveEmailAddress = "input[id$='EmailAddress']";
        string btnRetrieve = "input[id$='submitButton']";

        string CaptchaBox = "input[id$='BypassRecaptcha']";
        //[FindsBy(How = How.CssSelector, Using = "BypassRecaptcha")]
        //public IWebElement CaptchaBox;



        public RetrieveApplication(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver,120);
        }

        public override void VerifyPage()
        {
            // SetActiveFrame();

            VerifyUIElementIsDisplayed(editZipCode);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(editZipCode));
        }

        public void retrieveApplication()
        {
            IWebElement linkRetrieve;
            IWebElement btnOKGotit;
            linkRetrieve = driver.FindElement(By.XPath("//a[text()='Retrieve your saved quote or application']"));
            linkRetrieve.Click();
            WaitFor(driver.FindElement(By.XPath("//h1[text()='Finish Your Saved Quote or Application']")));
            WaitFor(driver.FindElement(By.Id("ZipCode")));
            DataStorage temp = new DataStorage();
            string ApplicantZipCode = temp.GetTempValue("ZIPCODE");
            string ApplicantLastName = temp.GetTempValue("LNAME");
            string ApplicantEmail = temp.GetTempValue("EMAIL");
            pause();
            pause();
            UIAction(txtRetrieveZipCode, ApplicantZipCode, "textbox");
            UIAction(txtRetrieveLastName, ApplicantLastName, "textbox");
            UIAction(txtRetrieveEmailAddress, ApplicantEmail, "textbox");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].setAttribute('value', 'true')", driver.FindElement(By.CssSelector(CaptchaBox)));

            Console.WriteLine("I am good till here");
            pause();
            //UIAction(btnRetrieve, String.Empty, "a");
            JavaScriptClick(driver.FindElement(By.CssSelector(btnRetrieve)));
            WaitFor(driver.FindElement(By.XPath("//span[text()='To ensure accuracy, please review your entire application before submitting.']")));
            Console.WriteLine("I need to click on");
            btnOKGotit = driver.FindElement(By.XPath("//button[text()='Ok, got it']"));
            btnOKGotit.Click();



        }


    }
}



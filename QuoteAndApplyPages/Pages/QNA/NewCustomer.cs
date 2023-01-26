using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace QuoteAndApplyPages.Pages.QNA
{
    public class NewCustomer : Page
    {
        string buttonContinue = "//*[@id='customerNext']";
        // string buttonContinue = "a[id$='customerNext']";
        // string buttonContinue = "a#customerNext";
        public NewCustomer(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            // VerifyUIElementIsDisplayed(buttonContinue);
        }

        public override void WaitForLoad()
        {
            //  IsElementPresent(driver, By.Id("customerNext"));
            // WaitUntilElementVisible(driver, By.CssSelector(buttonContinue));
        }

        public void ClickContinue()
        {
            try
            {
                JavaScriptClick(driver.FindElement(By.XPath("//*[@id='customerNext']")));
                System.Threading.Thread.Sleep(2000);
            }
            catch
            {
                IWebElement Searchpay = driver.FindElement(By.Id("customerNext"));
                Searchpay.Click();
            }
            //pause();
            //JavaScriptClick(driver.FindElement(By.XPath("//*[@id='customerNext']")));
            //System.Threading.Thread.Sleep(2000);
            //IWebElement Searchpay = driver.FindElement(By.Id("customerNext"));
            //Searchpay.Click();
        }

    }
}

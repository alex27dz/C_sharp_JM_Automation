using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;



namespace QuoteAndApplyPages.Pages.ExpressPartner
{
    public class ExpPartnerQuotePage: Page
    {
        string txtOrderNumber = "input[id$='OrderNumber']";
        string txtEmail = "input[id$='Email']";
        string btnGetMyQuote = "a[id$='GetMyQuote']";

        

        //bool checkmarkGreenSolid = false;
        //string buttonApplyforCoverage = "a[id$='quoteResultsNext']";
        //[FindsBy(How = How.XPath, Using = "//img[contains(@src,'/jewelry-insurance-quote-apply/Content/Images/Icon-Edit.png')]")]
        //private IWebElement checkMarkGreenSolid;


        public ExpPartnerQuotePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtOrderNumber);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtOrderNumber));
        }

     
        public void EnterOrderDetails(string orderid, string emailid)
        {
            UIAction(txtOrderNumber, orderid, "textbox");
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            if (emailid.ToLower().Contains("unique"))
            {
                emailid = Unique.ID.Substring(7, 9) + "@apptest.jminsure.com";
            }
            else if (emailid.ToLower().Equals("regedit"))
            {
                DataStorage temp = new DataStorage();
                emailid = temp.GetTempValue("EMAIL");
            }
            RegKey.SetValue("EMAIL", emailid);

            UIAction(txtEmail, emailid, "textbox");
            UIAction(btnGetMyQuote, string.Empty, "a");
        }



       
    }
}

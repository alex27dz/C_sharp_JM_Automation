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


namespace Quote.Pages
{
    public class QuotePage : Page
    {
        string editZipCode = "input[id$='QuoteZipCode']";
        string buttonContinue = "a[id$='quoteInfoNext']";
        string buttonApplyforCoverage = "a[id$='quoteResultsNext']";
        string linkAddanotherItem = "a[id$='AddJewelryItemQuoteInfo']";
        string linknoThanks = "a[id$='noThanks']";
        string listJewelryType;
        string editJewelryValue;
        bool checkmarkGreenSolid = false;
        [FindsBy(How = How.XPath, Using = "//img[contains(@src,'/jewelry-insurance-quote-apply/Content/Images/Icon-Edit.png')]")]
        private IWebElement checkMarkGreenSolid;
        // GreenSolidCheckMark //img[contains(@src,'/jewelry-insurance-quote-apply/Content/Images/Icon-Edit.png')]


        public QuotePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(editZipCode);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(editZipCode));
        }

        public  void EnterZipCode(string Zipcode)
        { 
            IList<IWebElement> Countylist;
            UIAction(editZipCode, Zipcode, "textbox");
            do
            {
                try
                {
                    if (checkMarkGreenSolid.Displayed)
                    {
                        Countylist = driver.FindElements(By.XPath("//input[@name='QuoteCounties']")).ToList();
                        if (Countylist.Count > 1)
                        {
                            Countylist[0].Click();
                        }
                    }
                    pause();
                }
                catch(Exception e)
                {
                   
                }
                
            }while (checkmarkGreenSolid == false) ;
        }



        public void ManageJewelryItems(string JewelryType, string Value, int counter)
        {
            if (counter > 0)
            {
                UIAction(linkAddanotherItem, string.Empty, "a");
            }

            AddJewelryItem(JewelryType, Value, counter);


        }

        public void AddJewelryItem(string JewelryType, string Value, int counter)
        {
            listJewelryType = "select[id$='jewelry-itemType-"+ counter+ "'\"]";
            editJewelryValue = "input[id$='jewelry-itemValue-"+ counter+ "'\"']";
            UIAction(listJewelryType, JewelryType, "selectbox");
            UIAction(editJewelryValue, Value, "textbox");
        }

        public void click_Continue()
        {
            UIAction(buttonContinue, string.Empty, "a");
            pause();
        }

        public void click_ApplyForCoverage()
        {
            UIAction(buttonContinue, string.Empty, "a");
            pause();
          if(IsElementPresent(driver, By.Id(linknoThanks)))
            {
                UIAction(buttonContinue, string.Empty, "a");
    
            }
           

        }
    }
}

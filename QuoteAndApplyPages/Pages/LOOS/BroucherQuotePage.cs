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



namespace QuoteAndApplyPages.Pages.LOOS
{
    public class BroucherQuotePage : Page
    {
        string txtboucherquotefield1Xpath = "//input[@class='pincode form-control'][@name='0']";
        string buttonContinueXpath = "//button[@type='submit'][contains(.,'Continue')]";
        string selrecentPurcahseat = "//select[@id='RetailerState']";
        string linkAddanotherItem = "a[id$='AddJewelryItemQuoteInfo']";
        string linknoThanks = "a[id$='noThanks']";
        string listJewelryType;
        string editJewelryValue;
        string txtAppfirstName = "input[id$='QuoteFirstName']";
        string txtApplastName = "input[id$='QuoteLastName']";
        string txtAppPhonenumber = "input[id$='QuotePhoneNumber']";
        string txtAppEmailaddress = "input[id$='PlatinumEmailAddress']";


        //bool checkmarkGreenSolid = false;
        //string buttonApplyforCoverage = "a[id$='quoteResultsNext']";
        //[FindsBy(How = How.XPath, Using = "//img[contains(@src,'/jewelry-insurance-quote-apply/Content/Images/Icon-Edit.png')]")]
        //private IWebElement checkMarkGreenSolid;



        public BroucherQuotePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(txtboucherquotefield1Xpath);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtboucherquotefield1Xpath));
        }
        public void click_Continue()
        {
            System.Threading.Thread.Sleep(5000);
            IWebElement continuee = driver.FindElement(By.XPath(buttonContinueXpath));
            continuee.Click();
        }
        public void click_Continue2()
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement continuee = driver.FindElement(By.XPath("//*[@id='locationSelectForm']/div[3]/div/button"));
            continuee.Click();
        }

        public void entercodefromBroucher(int quote)
        {
            int temp = 0;

            for (int i = 3; i >= 0; i--)
            {
                temp = quote % 10;
                Console.WriteLine("temp value is " + temp);
                UIActionExt(By.XPath("//input[@class='pincode form-control'][@name='" + i + "']"), "listbox", temp.ToString());
                quote = quote / 10;
            }
            //IList<IWebElement> btnContinuetemp = driver.FindElements(By.XPath(buttonContinueXpath)).ToList();
            //Console.WriteLine("COunt is" + btnContinuetemp.Count());
            //JavaScriptClick(btnContinuetemp[0]);

        }

        public void UpdateRecentPurchase(string recentPurcahseat)
        {
            IWebElement Purchase = driver.FindElement(By.XPath("//*[@id='RetailerState']"));
            Purchase.Click();
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.XPath(selrecentPurcahseat), 120);
            SelectByText(driver.FindElement(By.XPath(selrecentPurcahseat)), recentPurcahseat);
            System.Threading.Thread.Sleep(2000);
            IWebElement continue2 = driver.FindElement(By.XPath("//*[@id='locationSelectForm']/div[1]/div[2]/div/a[1]"));
            continue2.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement continue1 = driver.FindElement(By.XPath("//*[@id='locationSelectForm']/div[3]/div/button"));
            continue1.Click();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("purchase updated");
        }

        public void selectLocation(string counter)
        {
            WaitUntilElementVisible(driver, By.XPath("//div[@class='location-card-container list-group list-group-horizontal']"), 120);
            IList <IWebElement> countertemp = driver.FindElements(By.XPath("//div[@class='location-card-container list-group list-group-horizontal']//a")).ToList();
            int counter1 = int.Parse(counter);
            JavaScriptClick(countertemp[counter1-1]);
        }
    }
}

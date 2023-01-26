using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class QuoteSummaryUWpage:Page
    {
        string lblunderwriterreviewXpath = "//div[contains(.,'This application requires underwriter review.')][@class='ng-binding ng-scope']";
        string btnRefertoUWXpath = "//span[text()='Refer to Underwriter']";
        string txtNotetoUWXpath = "//textarea[@class='ng-pristine ng-untouched ng-valid ng-empty']";
        string btnSubmittoReviewXpath = "//button[@class='gw-btn-primary ng-binding']";
        string lblQuotedStateXpath = "//span[.='Quoted']";
        string lblAccountNameXpath = "//a[@ui-sref='accounts.detail.summary({accountNumber: accountInfo.accountNumber})']";
        string lblQuoteDetailsXpath = "//gw-row[@gw-visuallyhidden-unless='submissionNumber']//span";
        string lblTotalAmountXpath = "//div[@class='gw-monetary-amount ng-binding']";
		string btnSubmitForReview = "//span[text()='Submit for Review']";
        string btnYesJMApplication = "//div[@class='gw-error gw-control-group']//label[1][@class='gw-first']";

        //string
        string txtEmailpath = "//input[@id='186']";
        public QuoteSummaryUWpage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnYesJMApplication);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(btnYesJMApplication));

        }

        public void RefertoUW()
        {
            string accountnumber = "";
            UIActionExt(By.XPath(btnYesJMApplication), "click");
			UIActionExt(By.XPath(btnSubmitForReview), "ispresent");
			UIActionExt(By.XPath(btnSubmitForReview), "click");
			WaitUntilElementVisible(driver, By.XPath(lblQuotedStateXpath));
            IsElementPresent(driver, By.XPath(lblQuotedStateXpath));
            Console.WriteLine("Account Name is " + driver.FindElement(By.XPath(lblAccountNameXpath)).Text);
            ScenarioContext.Current["ACCOUNTNAME"] = driver.FindElement(By.XPath(lblAccountNameXpath)).Text;
            string tempAccount = driver.FindElement(By.XPath(lblAccountNameXpath)).GetAttribute("href");
            if (tempAccount.Contains(".html"))
            {
                char[] delimiterChars = { '/' };
                string[] tempAccount1 = tempAccount.Split(delimiterChars);
                accountnumber = tempAccount1[tempAccount1.Count() - 2];
                Console.WriteLine("Account Number is " + accountnumber);
            }

            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            ScenarioContext.Current["ACCOUNT"] = accountnumber;
            RegKey.SetValue("ACCNO", accountnumber);

            List<IWebElement> quoteobj = driver.FindElements(By.XPath(lblQuoteDetailsXpath)).ToList();
            Console.WriteLine("Quote id is " + quoteobj[0].Text.ToString().Replace("Quote (","").Replace(")",""));
            Console.WriteLine("Quote Status is " + quoteobj[1].Text);
            List<IWebElement> amountobj = driver.FindElements(By.XPath(lblTotalAmountXpath)).ToList();
            Console.WriteLine("Total premium is " + amountobj[0].Text);
            Console.WriteLine("Total Taxes and Fee is " + amountobj[1].Text);
            Console.WriteLine("Total Cost is " + amountobj[2].Text);


        }

    }
}

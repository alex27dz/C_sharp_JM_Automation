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

namespace PolicyCenter9Pages.Pages.Search
{
    public class PCSearchAccounts_PC9 : Page
    {
        string txtAccountNumber = "input[id$=':AccountNumber-inputEl']";
        string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
        string btnReset = "a[id$=':SearchLinksInputSet:Reset']";
        string accSearchResult = "a[id$=':0:AccountNumber']";
        string txtPolicyNumber = "input[id$=':PolicyNumberCriterion-inputEl']";
        string policySearchResult = "a[id$=':0:PolicyNumber']";


        public PCSearchAccounts_PC9(IWebDriver driver) : base(driver)
        {

            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnSearch);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtAccountNumber));
        }

        public void SearchAccount(string AccountNumber)
        {
            try
            {
                UIAction(btnReset, string.Empty, "span");
                IList<IWebElement> accountNumbers = driver.FindElements(By.CssSelector(txtAccountNumber)).ToList();
                accountNumbers[0].SendKeys(AccountNumber);
                System.Threading.Thread.Sleep(2000);
            }
            catch
            {
                IWebElement Searchclaim = driver.FindElement(By.CssSelector(txtAccountNumber));
                Searchclaim.Click();
                System.Threading.Thread.Sleep(2000);
                Searchclaim.SendKeys(AccountNumber);
                System.Threading.Thread.Sleep(2000);
            }

            // tripple clicking on search
            UIAction(btnSearch, string.Empty, "span");
            System.Threading.Thread.Sleep(1000);
            UIAction(btnSearch, string.Empty, "span");
            System.Threading.Thread.Sleep(1000);
            UIAction(btnSearch, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("account search button clicked");
        }

        public void SelectAccount()
        {

            WaitUntilElementIsDisplayed(driver, By.XPath("//div[(contains(.,'Displaying')]"));
            UIAction(accSearchResult, string.Empty, "a");
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[(contains(.,'Account File Summary')]"));
        }

        public void SearchPolicy(string PolicyNumber)
        {
            //    WaitUntilElementVisible(driver, By.Id("PolicySearch:PolicySearchScreen:ttlBar"), 10);
            UIAction(btnReset, string.Empty, "span");
            IList<IWebElement> accountNumbers = driver.FindElements(By.CssSelector(txtPolicyNumber)).ToList();
            accountNumbers[0].SendKeys(PolicyNumber);
            UIAction(btnSearch, string.Empty, "span");
        }

        public void SelectPolicy()
        {

            UIAction(policySearchResult, string.Empty, "a");



        }
    }
}

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

namespace PolicyCenterPages.Pages.Search
{
    public class SearchAccounts : Page
    {
        string txtAccountNumber = "input[id$=':AccountNumber']";

        string btnSearch = "span[id$=':SearchLinksInputSet:Search_link']";

        string btnReset = "span[id$=':SearchLinksInputSet:Reset_link']";

        //   string btnReset = "span[text()='Reset']";

        string accSearchResult = "a[id$=':0:AccountNumber']";

        string txtPolicyNumber = "input[id$=':PolicyNumberCriterion']";

        string policySearchResult = "a[id$=':0:PolicyNumber']";

        public SearchAccounts(IWebDriver driver) : base(driver)
        {
            SetActiveFrame();

            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  VerifyUIElementIsDisplayed(btnSearch);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtAccountNumber));
        }

        public void SearchAccount(string AccountNumber)
        {
            // pause();


            System.Threading.Thread.Sleep(6000);

            UIAction(btnReset, string.Empty, "span");

            pause();

            IList<IWebElement> accountNumbers = driver.FindElements(By.CssSelector(txtAccountNumber)).ToList();

            accountNumbers[0].SendKeys(AccountNumber);


            pause();


            UIAction(btnSearch, string.Empty, "span");

            //pause();

            //UIAction(accSearchResult, string.Empty, "a");

        }

        public void SelectAccount()
        {
            pause();
            pause();
            pause();

            UIAction(accSearchResult, string.Empty, "a");
            pause();
            pause();
            pause();


        }

        public void SearchPolicy(string PolicyNumber)
        {
            // pause();


            System.Threading.Thread.Sleep(5000);

            UIAction(btnReset, string.Empty, "span");

            pause();

            IList<IWebElement> accountNumbers = driver.FindElements(By.CssSelector(txtPolicyNumber)).ToList();

            accountNumbers[0].SendKeys(PolicyNumber);


            pause();


            UIAction(btnSearch, string.Empty, "span");

            //pause();

            //UIAction(accSearchResult, string.Empty, "a");

        }


        public void SelectPolicy()
        {
            pause();
            pause();
            pause();

            UIAction(policySearchResult, string.Empty, "a");
            pause();
            pause();
            pause();


        }

    }
}
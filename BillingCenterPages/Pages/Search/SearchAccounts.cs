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

namespace BillingCenterPages.Pages.Search
{
    public class SearchAccounts : Page
    {
        string txtAccountNumber = "input[id$=':AccountNumberCriterion-inputEl']";

        string btnSearch = "a[id$=':SearchLinksInputSet:Search']";

        string btnReset = "a[id$=':SearchLinksInputSet:Reset']";

        string accSearchResult = "a[id$=':0:AccountNumber']";

        public SearchAccounts(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtAccountNumber);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtAccountNumber));
        }

        public void SearchAccount(string AccountNumber)
        {
            WaitFor(driver.FindElement(By.CssSelector(btnReset)));

            UIAction(btnReset, string.Empty, "a");

            pause();

            WaitFor(driver.FindElement(By.CssSelector(txtAccountNumber)));

            UIAction(txtAccountNumber, AccountNumber, "textbox");

            UIAction(btnSearch, string.Empty, "a");

            pause();
        }

        public void SelectAccount()
        {
            pause();
            pause();
            pause();

            WaitFor(driver.FindElement(By.CssSelector(accSearchResult)));

            UIAction(accSearchResult, string.Empty, "a");
            pause();
            pause();
            pause();


        }
        public void SelectTransferTargetAccount()
        {
            string targetSearchAccount = "a[id$='AccountTransferWizard:WizardsStep1AccountPolicySearchScreen:AccountSearchResultsLV:0:Select']";
            pause();
            pause();
            pause();

            WaitFor(driver.FindElement(By.CssSelector(targetSearchAccount)));

            UIAction(targetSearchAccount, string.Empty, "a");
            pause();
            pause();
            pause();


        }

    }
}

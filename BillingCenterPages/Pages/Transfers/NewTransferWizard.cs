using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using BillingCenterPages.Pages.Search;

namespace BillingCenterPages.Pages.Transfers
{
    public class NewTransferWizard : Page
    {
        string btnNextTransferPage = "a[id='AccountNewTransferWizard:Next-btnInnerEl']";
        string btnNext = "AccountNewTransferWizard:Next-btnInnerEl";
        string btnFinish = "AccountNewTransferWizard:Finish-btnInnerEl";
        string TrgAccountRow = "AccountNewTransferWizard:TransferDetailsScreen:TransferDetailsDV:TransferDetailsLV-body";

        public NewTransferWizard(IWebDriver driver) : base(driver)
        {
            IsElementPresent(driver, By.CssSelector(btnNextTransferPage));
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(logOut); 
			//test
        }

        public override void WaitForLoad()
        {

        }
        public void SearchTargetAccountAndEnterAmount(string targetAccount, string targetAmount)
        {

            var tdTargetAccounts = driver.FindElement(By.Id(TrgAccountRow));
            List<IWebElement> ListTargetAccounts = new List<IWebElement>(tdTargetAccounts.FindElements(By.TagName("td")));
            ListTargetAccounts[1].Click();
            IWebElement txtTargerAccount = driver.FindElement(By.CssSelector("div[id='AccountNewTransferWizard:TransferDetailsScreen:TransferDetailsDV:TransferDetailsLV:0:TargetAccount:SelectTargetAccount'"));
            txtTargerAccount.Click();
            SearchAccounts searchAccounts = new SearchAccounts(driver);
            searchAccounts.SearchAccount(targetAccount);
            pause();
            IWebElement BtnClickSelect = driver.FindElement(By.XPath("//a[text()[contains(.,'Select')]]"));
            BtnClickSelect.Click();
            pause();
            WaitFor(driver.FindElement(By.Id(TrgAccountRow)));
            tdTargetAccounts = driver.FindElement(By.Id(TrgAccountRow));
            ListTargetAccounts = new List<IWebElement>(tdTargetAccounts.FindElements(By.TagName("td")));
            ListTargetAccounts[4].Click();
            IWebElement setTargetAmount = driver.FindElement(By.Name("Amount"));
            setTargetAmount.SendKeys(targetAmount);
        }
        public void FinishTransferfunds()
        {

            driver.FindElement(By.Id(btnNext)).Click();
            WaitFor(driver.FindElement(By.Id(btnFinish)));
            driver.FindElement(By.Id(btnFinish)).Click();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace BillingCenterPages.Pages.Common
{
    public class BCHistory : Page
    {
        string historyPageTitle = "AccountDetailHistory:AccountDetailHistoryScreen:ttlBar";
        string listAcctHistory = "AccountDetailHistory:AccountDetailHistoryScreen:AccountDetailHistoryLV-body";
        string FilterByType = "AccountDetailHistory:AccountDetailHistoryScreen:AccountDetailHistoryLV:HistoryEventTypeFilter";
        public BCHistory(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {

        }

        public void VerifyHistoryPageWriteOff(string writeoffType, string writeoffAmount, string WriteoffReason, string WriteoffReveesalReason)

        {

            System.Threading.Thread.Sleep(5000);
            pause();
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountDetailHistory:AccountDetailHistoryScreen:AccountDetailHistoryLV-body")).ToList();

            string[] arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            string Expected_result = "";
            if (writeoffType.Equals("Write off"))
            {
                Expected_result = writeoffType + " created for " + WriteoffReason + " for $" + writeoffAmount + " usd";
            }
            else if (writeoffType.Equals("Write off reversal"))
            {
                Expected_result = writeoffType + " of $" + writeoffAmount + " processed for reason: " + WriteoffReveesalReason;

            }
            Console.WriteLine(TableInputElements.Count());
            Console.WriteLine("Expected result is " + Expected_result + " Actual result is " + arrTblList[arrTblList.Count() - 2]);

            if (Expected_result.Equals(arrTblList[arrTblList.Count() - 2]))
            {
                Console.WriteLine(writeoffType + " detail is available in the history page");
            }
            else
            {
                Console.WriteLine(writeoffType + " detail is not available in the history page");
            }

        }

        public void VerifyAccountFundTransfer(string targetAccount, string targetAmount)
        {

            WaitUntilElementVisible(driver, By.Id(historyPageTitle));
            var tdHistoryResultsRow = driver.FindElement(By.Id(listAcctHistory));
            string expAccount = "Account Fund Transfer to account " + targetAccount;
            string expAmount = "$" + targetAmount;
            driver.FindElement(By.Name(FilterByType)).Clear();
            driver.FindElement(By.Name(FilterByType)).Click();
            driver.FindElement(By.Name(FilterByType)).SendKeys("Account Funds Transfer");
            driver.FindElement(By.Id(historyPageTitle)).Click();
            WaitUntilElementVisible(driver, By.Id(historyPageTitle));
            Console.WriteLine("Acct fund Transfer");
            List<IWebElement> tdTransferredAccounts = new List<IWebElement>(tdHistoryResultsRow.FindElements(By.TagName("td")));
            WaitFor(tdHistoryResultsRow);
            if (tdTransferredAccounts[1].Text.Replace(" ", string.Empty) != expAccount.Replace(" ", string.Empty))
                Assert.Fail("Validating Account fund transfer failed: \nExpected : {0} \nActual : {1} ", expAccount, tdTransferredAccounts[1].Text);
            if (tdTransferredAccounts[2].Text.Replace(" ", string.Empty) != expAmount.Replace(" ", string.Empty))
                Assert.Fail("Validating Account fund transfer failed: \nExpected : {0} \nActual : {1} ", expAmount, tdTransferredAccounts[2].Text);
        }

        public void VerifyMovePayments(string targetAccount, string targetAmount)
        {
            WaitUntilElementVisible(driver, By.Id(historyPageTitle));
            var tdHistoryResultsRow = driver.FindElement(By.Id(listAcctHistory));
            string expAccount = "Payment moved to account " + targetAccount;
            string expAmount = "$" + targetAmount;
            driver.FindElement(By.Name(FilterByType)).Clear();
            driver.FindElement(By.Name(FilterByType)).Click();
            driver.FindElement(By.Name(FilterByType)).SendKeys("Payment Moved");
            driver.FindElement(By.Id(historyPageTitle)).Click();
            WaitUntilElementVisible(driver, By.Id(historyPageTitle));
            List<IWebElement> tdTransferredAccounts = new List<IWebElement>(tdHistoryResultsRow.FindElements(By.TagName("td")));
            WaitFor(tdHistoryResultsRow);
            if (tdTransferredAccounts[1].Text.Replace(" ", string.Empty) != expAccount.Replace(" ", string.Empty))
                Assert.Fail("Validating Move Payments failed: \nExpected : {0} \nActual : {1} ", expAccount, tdTransferredAccounts[1].Text);
            if (tdTransferredAccounts[2].Text.Replace(" ", string.Empty) != expAmount.Replace(" ", string.Empty))
                Assert.Fail("Validating Move Payments failed: \nExpected : {0} \nActual : {1} ", expAmount, tdTransferredAccounts[2].Text);
        }
    }
}


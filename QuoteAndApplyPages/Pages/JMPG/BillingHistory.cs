using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace QuoteAndApplyPages.Pages.JMPG
{
    public class BillingHistory: Page
    {
        string policyDetailsHeader = "//h2[text()=' Policy Details ']";

        //Billing Details
        string billingDetailsHeader = "//h4[text()=' Billing Details ']";
        string fullAmountDueLabel = "//strong[text()='Full Amount Due']";
        string amountDueText = "//div[1]/div/div/span[text()=' $0.00']";
        string totalOutstandingDueLabel = "//strong[text()='Total Outstanding Due:']";
        string totalOutStandingText = "//div[2]/div/div/span[text()=' $0.00']";
        string statusLabel = "//strong[text()='Status:']";
        string inGoodStandingText = "//span[text()='In Good Standing']";
        string paymentPlanLabel = "//strong[text()='Payment Plan:']";
        string aunnualPayText = "//span[text()=' Annual Pay']";
        string autoPayLabel = "//strong[text()='Auto Pay:']";
        string yesText = "//span[text()='Yes']";

        //Billing History
        string billingHistoryHeader = "//h4[text()=' Billing History ']";
        string ticketsTableFilter = "//div[@id='tickets-table_filter']";
        string paymentDateTableHeader = "//th[text()='Payment Date']";
        string paymentAmountTableHeader = "//th[text()='Payment Amount']";
        string paymentTypeTableHeader = "//th[text()='Payment Type']";

        public BillingHistory(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            // WaitForLoad();
        }

        public override void VerifyPage()
        {
            pause();
        }

        public override void WaitForLoad()
        {
            pause();
            pause();
        }

        public void verifyBillingHisotryPage()
        {
            //WaitForTableLoad();
            Console.WriteLine("----JMPG Billing History Page error message validation ----- started------");
            verifyBillingHistoryMenuBar();
            verifyBillingHistorysBar();
            verifyBillingHistoryAccountAndTabs();
            verifyBillingDetails();
            verifyBillingHistory();
            verifyLeftNav();
            verifyFooter();
            Console.WriteLine("----JMPG Billing History Page error message validation ----- ended------");
        }

        public void verifyBillingHistoryMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifyBillingHistorysBar()
        {
            VerifyUIElementIsDisplayed(policyDetailsHeader);

            verifySearchBar();
        }

        public void verifyBillingHistoryAccountAndTabs()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyPolicyDetailsCommonElements();
           
        }

        public void verifySearchBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGSearchBar();
        }

        public void verifyLeftNav()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLeftNav();
        }

        public void verifyFooter()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGFooter();
        }

        public void verifyBillingDetails()
        {
            VerifyUIElementIsDisplayed(billingDetailsHeader);
            VerifyUIElementIsDisplayed(fullAmountDueLabel);
            VerifyUIElementIsDisplayed(totalOutstandingDueLabel);
            VerifyUIElementIsDisplayed(statusLabel);
            VerifyUIElementIsDisplayed(paymentPlanLabel);
            VerifyUIElementIsDisplayed(autoPayLabel);

            VerifyUIElementIsDisplayed(inGoodStandingText);
            VerifyUIElementIsDisplayed(yesText);
            VerifyUIElementIsDisplayed(aunnualPayText);
            VerifyUIElementIsDisplayed(totalOutStandingText);
            VerifyUIElementIsDisplayed(amountDueText);
        }

        public void verifyBillingHistory()
        {
            IWebElement labelTicketsTableFilter = driver.FindElement(By.XPath(ticketsTableFilter));
            Assert.IsTrue(labelTicketsTableFilter.Text.Contains("Viewing"), "Actual text content to verify Billing History Table Filter of Table Control: " + labelTicketsTableFilter.Text);

            VerifyUIElementIsDisplayed(billingHistoryHeader);
            VerifyUIElementIsDisplayed(paymentDateTableHeader);
            VerifyUIElementIsDisplayed(paymentAmountTableHeader);
            VerifyUIElementIsDisplayed(paymentTypeTableHeader);

            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[1]/td[1]")).Text.Equals("05/29/2020"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[1]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[2]/td[1]")).Text.Equals("05/29/2019"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[2]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[3]/td[1]")).Text.Equals("05/29/2018"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[3]/td[1]")).Text);


            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[1]/td[2]")).Text.Equals("$278.00"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[1]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[2]/td[2]")).Text.Equals("$274.00"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[2]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[3]/td[2]")).Text.Equals("$334.00"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[3]/td[2]")).Text);

            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[1]/td[3]")).Text.Equals("Credit Card"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[1]/td[3]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[2]/td[3]")).Text.Equals("Credit Card"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[2]/td[3]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[3]/td[3]")).Text.Equals("Credit Card"), "Actual text data content to verify Billing History Table: " + driver.FindElement(By.XPath("//*[@id='paymentHistoryTable']//tr[3]/td[3]")).Text);

        }
    }
}

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
    public class Transactions : Page
    {
        string policyDetailsHeader = "//h2[text()=' Policy Details ']";
        string ticketsTableFilter = "//div[@id='tickets-table_filter']";
        string viewBy = "//div[text()=' View by: ']";
        string viewBySelect = "//select[@class='filter-select font-16 custom-select custom-select-sm']";

        // Transactions Table
        string effectiveDateTableHeader = "//th[text()='Effective Date']";
        string transactionDateTableHeader = "//th[text()='Transaction Type']";
        string changeReasonTableHeader = "//th[text()='Change Reason']";
        string writtenPremiumTableHeader = "//th[text()='Written Premium']";
        string effectiveDateSortingIcon = "//th[text()='Effective Date']/span";
        string transactionDateSortingIcon = "//th[text()='Transaction Type']/span";

        public Transactions(IWebDriver driver) : base(driver)
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

        public void verifyTransactionsPage()
        {
            //WaitForTableLoad();
            Console.WriteLine("----JMPG Transactions Page error message validation ----- started------");
            verifyTransactionsMenuBar();
            verifyTransactionsBar();
            verifyTransactionAccountAndTabs();
            verifyTransactionsTable();
            verifyLeftNav();
            verifyFooter();           
            Console.WriteLine("----JMPG Transactions Page error message validation ----- ended------");
        }

        public void verifyTransactionsMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifyTransactionsBar()
        {
            VerifyUIElementIsDisplayed(policyDetailsHeader);

            verifySearchBar();
        }

        public void verifySearchBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGSearchBar();
        }

        public void verifyTransactionAccountAndTabs()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyPolicyDetailsCommonElements();
            IWebElement labelTicketsTableFilter = driver.FindElement(By.XPath(ticketsTableFilter));
            Assert.IsTrue(labelTicketsTableFilter.Text.Contains("Viewing"), "Actual text content to verify Transactions Table Filter of Table Control: " + labelTicketsTableFilter.Text);

            VerifyUIElementIsDisplayed(viewBy);
            VerifyUIElementIsDisplayed(viewBySelect);
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

        public void verifyTransactionsTable()
        {
            verifyTableHeader();
            verifyTableData();
        }

        public void verifyTableHeader()
        {
            VerifyUIElementIsDisplayed(effectiveDateTableHeader);
            VerifyUIElementIsDisplayed(writtenPremiumTableHeader);
            VerifyUIElementIsDisplayed(transactionDateTableHeader);
            VerifyUIElementIsDisplayed(changeReasonTableHeader);
            VerifyUIElementIsDisplayed(effectiveDateSortingIcon);
            VerifyUIElementIsDisplayed(transactionDateSortingIcon);
        }

        public void verifyTableData()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[4]/td[1]")).Text.Equals("05/29/2018"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[4]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[3]/td[1]")).Text.Equals("12/10/2018"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[3]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[1]")).Text.Equals("05/29/2019"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[1]")).Text.Equals("05/29/2020"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[1]")).Text);

            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[4]/td[2]")).Text.Equals("Submission"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[4]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[3]/td[2]")).Text.Equals("Policy Change"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[3]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[2]")).Text.Equals("Renewal"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[2]")).Text.Equals("Renewal"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[2]")).Text);

            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[4]/td[3]")).Text.Equals(""), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[4]/td[3]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[3]/td[3]")).Text.Equals("Address Change"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[3]/td[3]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[3]")).Text.Equals(""), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[3]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[3]")).Text.Equals(""), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[3]")).Text);

            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[4]/td[4]")).Text.Equals("$334.00"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[4]/td[4]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[3]/td[4]")).Text.Equals("$-28.00"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[3]/td[4]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[4]")).Text.Equals("$274.00"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[4]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[4]")).Text.Equals("$278.00"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[4]")).Text);


        }
    }
}

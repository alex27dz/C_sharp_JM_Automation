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
    public class Documents : Page
    {
        string policyDetailsHeader = "//h2[text()=' Policy Details ']";
        string ticketsTableFilter = "//div[@id='tickets-table_filter']";

        string nameTableHeader = "//th[text()='Name']";
        string dateTableHeader = "//th[text()='Date']";
        string viewTableHeader = "//th[text()='View']";
        string downloadTableHeader = "//th[text()='Download']";

        public Documents(IWebDriver driver) : base(driver)
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

        public void verifyDocuemntsPage()
        {
            //WaitForTableLoad();
            Console.WriteLine("----JMPG Documents Page error message validation ----- started------");
            verifyDocuemntsMenuBar();
            verifyDocumentsBar();
            verifyDocumentsAccountAndTabs();
            verifyDocumentsTable();
            verifyLeftNav();
            verifyFooter();
            Console.WriteLine("----JMPG Documents Page error message validation ----- ended------");
        }

        public void verifyDocuemntsMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifyDocumentsBar()
        {
            VerifyUIElementIsDisplayed(policyDetailsHeader);

            verifySearchBar();
        }

        public void verifyDocumentsAccountAndTabs()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyPolicyDetailsCommonElements();
            IWebElement labelTicketsTableFilter = driver.FindElement(By.XPath(ticketsTableFilter));
            Assert.IsTrue(labelTicketsTableFilter.Text.Contains("Viewing"), "Actual text content to verify Documents Table Filter of Table Control: " + labelTicketsTableFilter.Text);
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

        public void verifyDocumentsTable()
        {
            verifyTableHeader();
            verifyTableData();
        }

        public void verifyTableHeader()
        {
            VerifyUIElementIsDisplayed(nameTableHeader);
            VerifyUIElementIsDisplayed(dateTableHeader);
            VerifyUIElementIsDisplayed(viewTableHeader);
            VerifyUIElementIsDisplayed(downloadTableHeader);
        }

        public void verifyTableData()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[1]/td[1]")).Text.Equals("Renewal Formset"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[1]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[1]/td[2]")).Text.Equals("04/24/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[1]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[1]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));


            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[1]")).Text.Equals("Auto Pay Schedule"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[1]")).Text);
            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "qa15")
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[2]")).Text.Equals("04/28/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[2]")).Text);
            }
            else if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "qa4")
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[2]")).Text.Equals("04/24/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[2]")).Text);
            }
            else
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[2]")).Text.Equals("04/25/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[2]")).Text);
            }
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[2]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));

            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "qa4")
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[1]")).Text.Equals("Payment Reminder"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[1]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[2]")).Text.Equals("05/30/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[2]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));
            }

            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "stage")
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[1]")).Text.Equals("Credit Card Error Letter"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[1]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[2]")).Text.Equals("05/29/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[2]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));

                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[4]/td[1]")).Text.Equals("Payment Reminder"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[1]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[4]/td[2]")).Text.Equals("05/30/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//*[@id='documentTable']//tr[3]/td[2]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[4]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='documentTable']//tr[4]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));
            }




        }
    }
}

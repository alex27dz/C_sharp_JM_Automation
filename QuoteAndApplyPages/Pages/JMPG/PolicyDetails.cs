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
    public class PolicyDetails: Page
    {
        string policyDetailsHeader = "//h2[text()=' Policy Details ']";

        //Custome info
        string customeInfoHeader = "//h4[text()=' Customer Information ']";
        string accountNumberLabel = "//span[text()='Account Number:']";
        string accountNameLabel = "//span[text()='Account Name:']";
        string accountNumberValue = "//div[contains(text(), '3000878512')]";
        string phoneNumberLabel = "//span[text()='Phone Number:']";
        string emailLabel = "//span[text()='Email:']";
        string addressLabel= "//span[text()='Address:']";

        //Policy Info
        string policyInfoHeader = "//h4[text()=' Policy Information ']";
        string policyNumbersLabel = "//span[text()='Policy Number:']";
        string policyNumberValue = "//div[contains(text(), '#24-845465')]";
        string effectiveDateLabel = "//span[text()='Effective Date:']";
        string effectiveDateValue = "//div[contains(text(), '05/29/2020')]";
        string expirationDateLabel = "//span[text()='Expiration Date:']";
        string expirationDateValue = "//div[contains(text(), '05/29/2021')]";
        string statusLabel = "//span[text()='Status:']";
        string statusValue = "//div[contains(text(), 'In Force')]";
        string annualPremiumLabel = "//span[text()='Annual Premium:']";
        string annualPremiumValue = "//div[contains(text(), '$278.00')]";

        //Billing Info
        string billingInfoHeader = "//h4[text()=' Billing Information ']";
        string autoPayLabel = "//span[text()='Auto Pay:']";
        string autoPayValue = "//div[contains(text(), 'Yes')]";
        string amountDueLabel = "//span[text()='Amount Due:']";
        string amountDueValue = "//div[contains(text(), '$0.00')]";
        string paymentStatusLabel = "//span[text()='Payment Status:']";
        string paymentStatusValue = "//div[contains(text(), 'In Good Standing')]";
        string dueDateLabel = "//span[text()='Due Date:']";
        string dueDateValue = "//div[contains(text(), ' - ')]";
        string paymentPlanLabel = "//span[text()='Payment Plan:']";
        string paymentPlanValue = "//div[contains(text(), 'Annual Pay')]";
        string seeBillingHistoryButton = "//button[text()=' See Billing History ']";

        //Item Info
        string itemInfoHeader = "//h4[text()=' Item Information ']";
        string itemNumTableHeader = "//th[text()='Item #']";
        string itemTypeTableHeader = "//th[text()='Item Type']";
        string wearerNameTableHeader = "//th[text()='Wearer Name']";
        string valueTableHeader = "//th[text()='Value']";
        string deductibleTableHeader = "//th[text()='Deductible']";
        string appraisalReceivedTableHeader = "//th[text()='Appraisal Received']";

        //Transaction
        string transactionHeader = "//h4[text()=' Transactions ']";
        string expirationDateTableHeader = "//th[text()='Effective Date']";
        string typeTableHeader = "//th[text()='Type']";
        string changeReasonTableHeader = "//th[text()='Change Reason']";
        string writtenPremiumTableHeader = "//th[text()='Written Premium']";
        string seeAllTransactionHistoryButton = "//button[text()=' See All Transaction History ']";

        //Document
        string documentHeader = "//h4[text()=' View Documents ']";
        string documentNameTableHeader = "//th[text()='Document Name']";
        string dateTableHeader = "//th[text()='Date']";
        string viewTableHeader = "//th[text()=' View ']";
        string downloadTableHeader = "//th[text()=' Download ']";
        string seeAllDocumentsButton = "//button[text()=' See All Documents ']";

        //
        string tableError = "//div[@class='spinner-container']";

        public PolicyDetails(IWebDriver driver) : base(driver)
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

        public void WaitForTableLoad()
        {
            CommonPageElements cp = new CommonPageElements(driver);

            while (!cp.IsElementPresent(By.XPath(documentNameTableHeader)))
            {
                if (cp.IsElementPresent(By.XPath(tableError)))
                {
                    Assert.Fail("View Documents Table on Police Details has go wrong, please try again!!");
                }
            }

        }

        public void verifyPolicyDetailsPage()
        {
            WaitForTableLoad();
            Console.WriteLine("----JMPG Policy Details Page error message validation ----- started------");
            verifyPolicyDetailsMenuBar();
            verifyPolicyDetailsBar();            
            verifyLeftNav();
            verifyFooter();
            policyDetailsPanel();
            Console.WriteLine("----JMPG Policy Details Page error message validation ----- ended------");
        }

        public void verifyPolicyDetailsMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifyPolicyDetailsBar()
        {
            VerifyUIElementIsDisplayed(policyDetailsHeader);

            verifySearchBar();
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

        public void policyDetailsPanel()
        {
            verifyCustmoerInfoPanel();
            verifyPolicyInfoPanel();
            verifyBillingInfoPanel();
            verifyItemInfoPanel();
            verifyTransactionsPanel();
            verifyDocumentPanel();
        }
        public void verifyCustmoerInfoPanel()
        {
            VerifyUIElementIsDisplayed(customeInfoHeader);
            VerifyUIElementIsDisplayed(accountNumberLabel);
            VerifyUIElementIsDisplayed(accountNameLabel);
            VerifyUIElementIsDisplayed(accountNumberValue);
            VerifyUIElementIsDisplayed(phoneNumberLabel);
            VerifyUIElementIsDisplayed(emailLabel);
            VerifyUIElementIsDisplayed(addressLabel);
        }

        public void verifyPolicyInfoPanel()
        {
            VerifyUIElementIsDisplayed(policyInfoHeader);
            VerifyUIElementIsDisplayed(policyNumbersLabel);
            VerifyUIElementIsDisplayed(effectiveDateLabel);
            VerifyUIElementIsDisplayed(expirationDateLabel);
            VerifyUIElementIsDisplayed(statusLabel);
            VerifyUIElementIsDisplayed(annualPremiumLabel);

            VerifyUIElementIsDisplayed(policyNumberValue);
            VerifyUIElementIsDisplayed(effectiveDateValue);
            VerifyUIElementIsDisplayed(expirationDateValue);
            VerifyUIElementIsDisplayed(statusValue);
            VerifyUIElementIsDisplayed(annualPremiumValue);
        }

        public void verifyBillingInfoPanel()
        {
            VerifyUIElementIsDisplayed(billingInfoHeader);
            VerifyUIElementIsDisplayed(autoPayLabel);
            VerifyUIElementIsDisplayed(paymentStatusLabel);
            VerifyUIElementIsDisplayed(amountDueLabel);
            VerifyUIElementIsDisplayed(dueDateLabel);
            VerifyUIElementIsDisplayed(paymentPlanLabel);
            VerifyUIElementIsDisplayed(seeBillingHistoryButton);

            VerifyUIElementIsDisplayed(autoPayValue);
            VerifyUIElementIsDisplayed(paymentPlanValue);
            VerifyUIElementIsDisplayed(amountDueValue);
            VerifyUIElementIsDisplayed(dueDateValue);
            VerifyUIElementIsDisplayed(paymentPlanValue);
        }

        public void verifyItemInfoPanel()
        {
            VerifyUIElementIsDisplayed(itemInfoHeader);
            VerifyUIElementIsDisplayed(itemNumTableHeader);
            VerifyUIElementIsDisplayed(itemTypeTableHeader);
            VerifyUIElementIsDisplayed(wearerNameTableHeader);
            VerifyUIElementIsDisplayed(valueTableHeader);
            VerifyUIElementIsDisplayed(deductibleTableHeader);
            VerifyUIElementIsDisplayed(appraisalReceivedTableHeader);

            verifyActualDataOfItemInfoTable();

        }

        public void verifyTransactionsPanel()
        {
            VerifyUIElementIsDisplayed(transactionHeader);
            VerifyUIElementIsDisplayed(expirationDateTableHeader);
            VerifyUIElementIsDisplayed(typeTableHeader);
            VerifyUIElementIsDisplayed(changeReasonTableHeader);
            VerifyUIElementIsDisplayed(writtenPremiumTableHeader);
            VerifyUIElementIsDisplayed(seeAllTransactionHistoryButton);

            verifyActualDataofTransactions();
           
        }

        public void verifyDocumentPanel()
        {
            VerifyUIElementIsDisplayed(documentHeader);
            VerifyUIElementIsDisplayed(documentNameTableHeader);
            VerifyUIElementIsDisplayed(dateTableHeader);
            VerifyUIElementIsDisplayed(viewTableHeader);
            VerifyUIElementIsDisplayed(downloadTableHeader);
            VerifyUIElementIsDisplayed(seeAllDocumentsButton);

            verifyActualDataofDocuemnts();
        }

        public void verifyActualDataOfItemInfoTable()
        {
            
            IWebElement firstItem = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[1]"));
            IWebElement firstItemType = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[2]"));
            IWebElement firstItemWearName = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[3]"));
            IWebElement firstItemValue = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[4]"));
            IWebElement firstItemDeductible = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[5]"));
            IWebElement firstItemAppraisalReceived = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[1]/td[6]"));
            IWebElement secondItem = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[1]"));
            IWebElement secondItemType = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[2]"));
            IWebElement secondItemWearName = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[3]"));
            IWebElement secondItemValue = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[4]"));
            IWebElement secondItemDeductible = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[5]"));
            IWebElement secondItemAppraisalReceived = driver.FindElement(By.XPath("//*[@id='transactionsTable']//tr[2]/td[6]"));
            Assert.IsTrue(firstItem.Text.Equals("1"), "Actual text content to verify Item # Information Table Data: " + firstItem.Text);
            Assert.IsTrue(firstItemType.Text.Equals("Gents Watch"), "Actual text content to verify Item Type Information Table Data: " + firstItemType.Text);           
            Assert.IsTrue(firstItemValue.Text.Equals("$6,250.00"), "Actual text content to verify Item Value Information Table Data: " + firstItemValue.Text);
            Assert.IsTrue(firstItemDeductible.Text.Equals("$0.00"), "Actual text content to verify Item Deductible Information Table Data: " + firstItemDeductible.Text);
            Assert.IsTrue(firstItemAppraisalReceived.Text.Equals("Yes"), "Actual text content to verify Item Appraisal ReceivedInformation Table Data: " + firstItemAppraisalReceived.Text);
            Assert.IsTrue(secondItem.Text.Equals("2"), "Actual text content to verify Item # Information Table Data: " + firstItem.Text);
            Assert.IsTrue(secondItemType.Text.Equals("Ladies Engagement Ring"), "Actual text content to verify Item Type Information Table Data: " + secondItemType.Text);            
            Assert.IsTrue(secondItemValue.Text.Equals("$16,320.00"), "Actual text content to verify Item Value Information Table Data: " + secondItemValue.Text);
            Assert.IsTrue(secondItemDeductible.Text.Equals("$0.00"), "Actual text content to verify Item Deductible Information Table Data: " + secondItemDeductible.Text);
            Assert.IsTrue(secondItemAppraisalReceived.Text.Equals("Yes"), "Actual text content to verify Item Appraisal ReceivedInformation Table Data: " + secondItemAppraisalReceived.Text);

            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "prod")
            {
                Assert.IsTrue(firstItemWearName.Text.Equals("James Murdoch"), "Actual text content to verify Item Wear Name Information Table Data: " + firstItemWearName.Text);
                Assert.IsTrue(secondItemWearName.Text.Equals("Kelsey Murdoch"), "Actual text content to verify Item Wear Name Information Table Data: " + secondItemWearName.Text);
            }
            else
            {
                Assert.IsTrue(firstItemWearName.Text.Equals("Emanuel Mimnaugh"), "Actual text content to verify Item Wear Name Information Table Data: " + firstItemWearName.Text);
                Assert.IsTrue(secondItemWearName.Text.Equals("Ivan Spaugh"), "Actual text content to verify Item Wear Name Information Table Data: " + secondItemWearName.Text);
            }
        }

        public void verifyActualDataofDocuemnts()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[1]")).Text.Equals("Renewal Formset"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[2]")).Text.Equals("04/24/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));


            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[1]")).Text.Equals("Auto Pay Schedule"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[1]")).Text);
            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "qa15")
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[2]")).Text.Equals("04/28/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[2]")).Text);
            }
            else if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "qa4")
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[2]")).Text.Equals("04/24/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[2]")).Text);
            }
            else
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[2]")).Text.Equals("04/25/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[2]")).Text);
            }              
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[2]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));

            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "qa4")
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[3]/td[1]")).Text.Equals("Payment Reminder"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[1]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[3]/td[2]")).Text.Equals("05/30/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[2]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[3]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[3]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));
            }

            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "stage")
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[3]/td[1]")).Text.Equals("Credit Card Error Letter"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[1]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[3]/td[2]")).Text.Equals("05/29/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[2]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[3]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[3]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));

                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[4]/td[1]")).Text.Equals("Payment Reminder"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[1]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[4]/td[2]")).Text.Equals("05/30/2020"), "Actual text data content to verify Documents Table: " + driver.FindElement(By.XPath("//div[3]/div[2]//tr[1]/td[2]")).Text);
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[4]/td[3]//i")).GetAttribute("class").Equals("uil uil-eye"));
                Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[2]//tr[4]/td[4]//i")).GetAttribute("class").Equals("uil uil-file-download-alt"));
            }
        }

        public void verifyActualDataofTransactions()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[4]/td[1]")).Text.Equals("05/29/2018"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[4]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[3]/td[1]")).Text.Equals("12/10/2018"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[3]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[2]/td[1]")).Text.Equals("05/29/2019"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[2]/td[1]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[1]/td[1]")).Text.Equals("05/29/2020"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[1]/td[1]")).Text);

            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[4]/td[2]")).Text.Equals("Submission"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[4]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[3]/td[2]")).Text.Equals("Policy Change"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[3]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[2]/td[2]")).Text.Equals("Renewal"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[2]/td[2]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[1]/td[2]")).Text.Equals("Renewal"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[1]/td[2]")).Text);

            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[4]/td[3]")).Text.Equals(""), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[4]/td[3]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[3]/td[3]")).Text.Equals("Address Change"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[3]/td[3]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[2]/td[3]")).Text.Equals(""), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[2]/td[3]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[1]/td[3]")).Text.Equals(""), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[1]/td[3]")).Text);

            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[4]/td[4]")).Text.Equals("$334.00"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[4]/td[4]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[3]/td[4]")).Text.Equals("$-28.00"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[3]/td[4]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[2]/td[4]")).Text.Equals("$274.00"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[2]/td[4]")).Text);
            Assert.IsTrue(driver.FindElement(By.XPath("//div[3]/div[1]//tr[1]/td[4]")).Text.Equals("$278.00"), "Actual text data content to verify Transactions Table: " + driver.FindElement(By.XPath("//div[3]/div[1]//tr[1]/td[4]")).Text);


        }

        public void clickSeeAllTransactions()
        {
            driver.FindElement(By.XPath(seeAllTransactionHistoryButton)).Click();
        }

        public void clickSeeAllDocuments()
        {
            driver.FindElement(By.XPath(seeAllDocumentsButton)).Click();
        }

        public void clickSeeBillingHistory()
        {
            driver.FindElement(By.XPath(seeBillingHistoryButton)).Click();
        }
    }
}

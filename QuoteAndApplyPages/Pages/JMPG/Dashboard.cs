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
    public class Dashboard : Page
    {
        // Agent Dashboard
        string agentDashboardLabel = "//div[@class='page-title-position']";
        string agentProfileIcon = "//img[@class='rounded-circle']";
        string welcomeAgentLabel = "//span[@class='welcome-message']";

        // Dashboard Panel
        string getAQuotaDashboardPanelLabel = "//div[text()=' Get a Quote ']";
        string recentlySubmittedDashboardPanelLabel = "//div[text()=' Recently Submitted ']";
        string pendingCancellationDashboardPanelLabel = "//div[text()=' Pending Cancellation ']";
        string getAQuotaDashboardPanelButton = "//a[text()='Get a Quote']";
        string recentlySubmittedDashboardPanelButton = "//button[text()=' View Recently Submitted ']";
        string pendingCancellationDashboardPanelButton = "//button[text()=' View Pending Cancellation ']";

        // Dashboard Table
        string recentlySubmittedDashboardTableLabel = "//h4[text()=' Recently Submitted ']";
        string recentlyViewedDashboardTableLabel = "//h4[text()=' Recently Viewed ']";
        string pendingCancellationDashboardTableLabel = "//h4[text()=' Pending Cancellation ']";
        string recentlySubmittedDashboardTableButton = "//button[text()=' View All Applications ']";
        string pendingCancellationDashboardTableButton = "//button[text()=' View Pending Policies ']";

        // Error
        string recentlySubmittedError = "//*[@id='app']//div[3]//div[@class='spinner-container']";
        string recentlyViewedError = "//*[@id='app']//div[4]/div[1]//div[@class='spinner-container']";
        string pendingCancellationError = "//*[@id='app']//div[4]/div[2]//div[@class='spinner-container']";

        public Dashboard(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
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

        // wait until dashbaord tables show table header!WaitUntilElementVisible(driver, By.XPath("//*[@id='app']//div[2]//div[3]//table//th[1]"), 1)
        public void WaitForTableLoad()
        {
            CommonPageElements cp = new CommonPageElements(driver);

            while (!cp.IsElementPresent(By.XPath("//*[@id='app']//div[2]//div[3]//table//th[1]")))
            {
                 if (cp.IsElementPresent(By.XPath(recentlySubmittedError)))
                 {
                     Assert.Fail("Recently Submitted Table on Dashboard has go wrong, please try again!!");
                 }

                 if (cp.IsElementPresent(By.XPath(recentlyViewedError)))
                 {
                     Assert.Fail("Recently Viewed Table on Dashboard has go wrong, please try again!!");
                 }
                 
                 if (cp.IsElementPresent(By.XPath(pendingCancellationError)))
                 {
                    Assert.Fail("Pending Cancellation Table on Dashboard has go wrong, please try again!!");
                 }
            }

        }

        public void verifyDashboardPage()
        {
            WaitForTableLoad();
            Console.WriteLine("----JMPG Dashboard Page error message validation ----- started------");
            verifyDashboardMenuBar();
            verifyLeftNav();
            verifyAgentDashboard();
            verifyDashboardPanel();
            verifyDashboardTable();
            verifyFooter();
            Console.WriteLine("----JMPG Dashboard Page error message validation ----- ended------");
        }

        public void verifyDashboardMenuBar()
        {
            WaitForLoad();
            verifyLogo();
            verifyHelpDesk();
            verifyProfile();
        }

        public void verifyLogo()
        {
            //VerifyUIElementIsDisplayed(jmpgLogo);
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
        }

        public void verifyHelpDesk()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGHelpDesk();
            cp.clickHelpDesk();
            cp.verifyJMPGHelpDeskDropDown();
            cp.clickHelpDesk();
        }

        public void verifyProfile()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGProfile();
            cp.clickProfile();
            cp.verifyJMPGProfileDropDown();
            cp.clickProfile();
        }
        
        public void verifyLeftNav()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLeftNav();
        }

        public void verifyAgentDashboard()
        {
            VerifyUIElementIsDisplayed(agentProfileIcon);
            IWebElement labelAgentDashboard = driver.FindElement(By.XPath(agentDashboardLabel));
            IWebElement labelWelcome = driver.FindElement(By.XPath(welcomeAgentLabel));
            Assert.IsTrue(labelAgentDashboard.Text.Equals("AGENT DASHBOARD"), "Actual text content to verify Agent Dashboard Label of Agent Dashboard: " + labelAgentDashboard.Text);

            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "prod")
            {
                Assert.IsTrue(labelWelcome.Text.Equals("Welcome, Smoke Two."), "Actual text content to verify Welcome Agent of Agent Dashboard: " + labelWelcome.Text);
            }
            else
            {
                Assert.IsTrue(labelWelcome.Text.Equals("Welcome, Ryan."), "Actual text content to verify Welcome Agent of Agent Dashboard: " + labelWelcome.Text);
            }
            
            verifySearchBar();
        }

        public void verifySearchBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGSearchBar();
        }

        public void verifyDashboardPanel()
        {
            IWebElement labelGetAQuote = driver.FindElement(By.XPath(getAQuotaDashboardPanelLabel));
            IWebElement labelRecentlySubmitted = driver.FindElement(By.XPath(recentlySubmittedDashboardPanelLabel));
            IWebElement labelPendingCancellation = driver.FindElement(By.XPath(pendingCancellationDashboardPanelLabel));
            IWebElement buttonGetAQuote = driver.FindElement(By.XPath(getAQuotaDashboardPanelButton));
            IWebElement buttonRecentlySubmitted = driver.FindElement(By.XPath(recentlySubmittedDashboardPanelButton));
            IWebElement buttonPendingCancellation = driver.FindElement(By.XPath(pendingCancellationDashboardPanelButton));
            Assert.IsTrue(labelGetAQuote.Text.Equals("Get a Quote"), "Actual text content to verify Get A Quote Label of Dashboard Panel: " + labelGetAQuote.Text);
            Assert.IsTrue(labelRecentlySubmitted.Text.Equals("Recently Submitted"), "Actual text content to verify Recently Submitted Label of Dashboard Panel:: " + labelRecentlySubmitted.Text);
            Assert.IsTrue(labelPendingCancellation.Text.Equals("Pending Cancellation"), "Actual text content to verify Recently Submitted Label of Dashboard Panel:: " + labelPendingCancellation.Text);
            Assert.IsTrue(buttonGetAQuote.Text.Equals("Get a Quote"), "Actual text content to verify Pending Cancellation Button of Dashboard Panel: " + buttonGetAQuote.Text);
            Assert.IsTrue(buttonRecentlySubmitted.Text.Equals("View Recently Submitted"), "Actual text content to verify View Recently Submitted Button of Dashboard Panel:: " + buttonRecentlySubmitted.Text);
            Assert.IsTrue(buttonPendingCancellation.Text.Equals("View Pending Cancellation"), "Actual text content to verify View Pending Cancellation Button of Dashboard Panel:: " + buttonPendingCancellation.Text);

        }

        public void verifyDashboardTable()
        {
            verifyRecentlyViewedTableOfDashboard();
            verifyRecentlySubmittedTableOfDashboard();
            verifyPendingCancellationTableOfDashboard();
        }

        public void verifyRecentlyViewedTableOfDashboard()
        {
            string accountName = "//*[@id='app']//div[4]/div[1]//table//th[1]";
            string effectiveDate = "//*[@id='app']//div[4]/div[1]//table//th[2]";
            string accountNubmer = "//*[@id='app']//div[4]/div[1]//table//th[3]";
            string policyNubmer = "//*[@id='app']//div[4]/div[1]//table//th[4]";
            string status = "//*[@id='app']//div[4]/div[1]//table//th[5]";

            IWebElement labelRecentlyViewed = driver.FindElement(By.XPath(recentlyViewedDashboardTableLabel));
            IWebElement tableHeaderAccountName = driver.FindElement(By.XPath(accountName));
            IWebElement tableHeaderEffectiveDate = driver.FindElement(By.XPath(effectiveDate));
            IWebElement tableHeaderAccountNubmer = driver.FindElement(By.XPath(accountNubmer));
            IWebElement tableHeaderPolicyNumber = driver.FindElement(By.XPath(policyNubmer));
            IWebElement tableHeaderStatus = driver.FindElement(By.XPath(status));
            Assert.IsTrue(labelRecentlyViewed.Text.Equals("Recently Viewed"), "Actual text content to verify Recently Viewed Label of Dashboard Table: " + labelRecentlyViewed.Text);
            Assert.IsTrue(tableHeaderAccountName.Text.Equals("Account Name"), "Actual text content to verify View Table Header Account Name of Recently Viewed Dashboard Table: " + tableHeaderAccountName.Text);
            Assert.IsTrue(tableHeaderEffectiveDate.Text.Equals("Effective Date"), "Actual text content to verify View Table Header Effective Date of  Recently Viewed Dashboard Table: " + tableHeaderEffectiveDate.Text);
            Assert.IsTrue(tableHeaderAccountNubmer.Text.Equals("Account #"), "Actual text content to verify View Table HeaderAccount Number of  Recently Viewed Dashboard Table: " + tableHeaderAccountNubmer.Text);
            Assert.IsTrue(tableHeaderPolicyNumber.Text.Equals("Policy #"), "Actual text content to verify View Table Header Policy Number of  Recently Viewed Dashboard Table: " + tableHeaderPolicyNumber.Text);
            Assert.IsTrue(tableHeaderStatus.Text.Equals("Status"), "Actual text content to verify View Table Header Status of  Recently Viewed Dashboard Table: " + tableHeaderStatus.Text);
        }
        public void verifyRecentlySubmittedTableOfDashboard()
        {
            string accountName = "//*[@id='app']//div[2]//div[3]//table//th[1]";
            string submissionDate = "//*[@id='app']//div[2]//div[3]//table//th[2]";
            string accountNubmer = "//*[@id='app']//div[2]//div[3]//table//th[3]";
            string policyNubmer = "//*[@id='app']//div[2]//div[3]//table//th[4]";
            string status = "//*[@id='app']//div[2]//div[3]//table//th[5]";

            IWebElement labelRecentlySubmitted = driver.FindElement(By.XPath(recentlySubmittedDashboardTableLabel));
            IWebElement tableHeaderAccountName = driver.FindElement(By.XPath(accountName));
            IWebElement tableHeaderSubmissionDate = driver.FindElement(By.XPath(submissionDate));
            IWebElement tableHeaderAccountNubmer = driver.FindElement(By.XPath(accountNubmer));
            IWebElement tableHeaderPolicyNumber = driver.FindElement(By.XPath(policyNubmer));
            IWebElement tableHeaderStatus = driver.FindElement(By.XPath(status));
            IWebElement buttonRecentlySubmitted = driver.FindElement(By.XPath(recentlySubmittedDashboardTableButton));

            Assert.IsTrue(labelRecentlySubmitted.Text.Equals("Recently Submitted"), "Actual text content to verify Recently Submitted Label of Dashboard Table: " + labelRecentlySubmitted.Text);
            Assert.IsTrue(buttonRecentlySubmitted.Text.Equals("View All Applications"), "Actual text content to verify Recently Submitted Button of Dashboard Table: " + buttonRecentlySubmitted.Text);
            Assert.IsTrue(tableHeaderAccountName.Text.Equals("Account Name"), "Actual text content to verify View Table Header Account Name of Recently Submitted Dashboard Table: " + tableHeaderAccountName.Text);
            Assert.IsTrue(tableHeaderSubmissionDate.Text.Equals("Submission Date"), "Actual text content to verify View Table Header Effective Date of Recently Submitted Dashboard Table: " + tableHeaderSubmissionDate.Text);
            Assert.IsTrue(tableHeaderAccountNubmer.Text.Equals("Account #"), "Actual text content to verify View Table HeaderAccount Number of Recently Submitted Dashboard Table: " + tableHeaderAccountNubmer.Text);
            Assert.IsTrue(tableHeaderPolicyNumber.Text.Equals("Policy #"), "Actual text content to verify View Table Header Policy Number of Recently Submitted Dashboard Table: " + tableHeaderPolicyNumber.Text);
            Assert.IsTrue(tableHeaderStatus.Text.Equals("Status"), "Actual text content to verify View Table Header Status of Recently Submitted Dashboard Table: " + tableHeaderStatus.Text);
        }
        public void verifyPendingCancellationTableOfDashboard()
        {
            string accountName = "//*[@id='app']//div[4]/div[2]//table//th[1]";
            string effectiveDate = "//*[@id='app']//div[4]/div[2]//table//th[2]";
            string accountNubmer = "//*[@id='app']//div[4]/div[2]//table//th[3]";
            string policyNubmer = "//*[@id='app']//div[4]/div[2]//table//th[4]";
            string status = "//*[@id='app']//div[4]/div[2]//table//th[5]";

            IWebElement labelPendingCancellation = driver.FindElement(By.XPath(pendingCancellationDashboardTableLabel));
            IWebElement tableHeaderAccountName = driver.FindElement(By.XPath(accountName));
            IWebElement tableHeaderEffectiveDate = driver.FindElement(By.XPath(effectiveDate));
            IWebElement tableHeaderAccountNubmer = driver.FindElement(By.XPath(accountNubmer));
            IWebElement tableHeaderPolicyNumber = driver.FindElement(By.XPath(policyNubmer));
            IWebElement tableHeaderStatus = driver.FindElement(By.XPath(status));
            IWebElement buttonPendingCancellation = driver.FindElement(By.XPath(pendingCancellationDashboardTableButton));

            Assert.IsTrue(buttonPendingCancellation.Text.Equals("View Pending Policies"), "Actual text content to verify View Pending Cancellation Button of Dashboard Table: " + buttonPendingCancellation.Text);
            Assert.IsTrue(labelPendingCancellation.Text.Equals("Pending Cancellation"), "Actual text content to verify View Pending Cancellation Label of Dashboard Table: " + labelPendingCancellation.Text);
            Assert.IsTrue(tableHeaderAccountName.Text.Equals("Account Name"), "Actual text content to verify View Table Header Account Name of Pending Dashboard Table: " + tableHeaderAccountName.Text);
            Assert.IsTrue(tableHeaderEffectiveDate.Text.Equals("Effective Date"), "Actual text content to verify View Table Header Effective Date of Pending Dashboard Table: " + tableHeaderEffectiveDate.Text);
            Assert.IsTrue(tableHeaderAccountNubmer.Text.Equals("Account #"), "Actual text content to verify View Table HeaderAccount Number of Pending Dashboard Table: " + tableHeaderAccountNubmer.Text);
            Assert.IsTrue(tableHeaderPolicyNumber.Text.Equals("Policy #"), "Actual text content to verify View Table Header Policy Number of Pending Dashboard Table: " + tableHeaderPolicyNumber.Text);
            Assert.IsTrue(tableHeaderStatus.Text.Equals("Status"), "Actual text content to verify View Table Header Status of Pending Dashboard Table: " + tableHeaderStatus.Text);

        }

        public void verifyFooter()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGFooter();
        }

        public void goToMyAccountPage()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickEditInformation();
        }

        public void goToGetAQuotePage()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickGetAQuotePage();
            // Switch to new Tab
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public void goToRecentlySubmitted()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickRecentlySubmitted();
        }

        public void goToPendingCancellation()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickPendingCancellation();
        }

        public void goToSavedQuotes()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickSavedQutoes();
        }

        public void goToAgentKnowledgeBase()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickAgentKnowledgeBase();
        }

        public void goToLostBusiness()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickLostBusiness();
        }

        public void goToJMSupport()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickJMSupport();
        }

        public void logout()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.clickLogoutButton();
        }

        public void search(string accountNumbe)
        {
            //WaitForTableLoad();
            CommonPageElements cp = new CommonPageElements(driver);
            cp.searchAccountNumber(accountNumbe);
        }

    }
}

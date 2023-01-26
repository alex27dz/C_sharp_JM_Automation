using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using QuoteAndApplyPages.Pages.JMPG;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class JMPG_Steps: TestBase
    {


        [BeforeScenario]
        public void cleanUpBeforeTest()
        {
            //  InitializeWEbDriver();

            KillWEbDriver();
        }

        [When(@"I access on the login page of JMPG then verify login page")]
        public void LoginPageOfJMPGVerify()
        {
            LoginPage loginpage = new LoginPage(getDriver());
            loginpage.verifyPageContent();
        }

       // [AfterScenario]
        [Then(@"I close the browser after the content of page verified")]
        public void ThenICloseBrowserAfterVerifyPageContent()
        {
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }

        [When(@"I login to JMPG app")]
        [Then(@"I login to JMPG app")]
        public void WhenILoginToSuperPartnerMode(Table table)
        {
            LoginPage loginPage = new LoginPage(getDriver());
            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "prod")
            {                
                loginPage.loginJMPG("jmtestpartner+222@gmail.com", "Admin123!");
            }
            else
            {
                loginPage.loginJMPG(table.Rows[0]["UserName"], table.Rows[0]["Password"]);
            }
                
        }

        [When(@"I search account number")]
        [Then(@"I search account number")]
        public void SearchAccountNumber(Table table)
        {
            Dashboard db = new Dashboard(getDriver());
            db.search(table.Rows[0]["AccountNumber"]);
           // cp.searchAccountNumber();
            //table.Rows[0]["AccountNumber"]
        }

        [Given(@"I verify JMPG Dashboard validation information")]
        [When(@"I verify JMPG Dashboard validation information")]
        public void VerifyJMPGDashboardValidationInfo()
        {
            Dashboard db = new Dashboard(getDriver());
            db.verifyDashboardPage();
        }

        [Given(@"I verify JMPG Recently Submitted validation information")]
        [When(@"I verify JMPG Recently Submitted validation information")]
        public void VerifyJMPGRecentlySubmittedValidationInfo()
        {
            RecentlySubmitted rs = new RecentlySubmitted(getDriver());
            rs.verifyRecentlySubmittedPage();
        }

        [Given(@"I verify JMPG Saved Quotes validation information")]
        [When(@"I verify JMPG Saved Quotes validation information")]
        public void VerifyJMPGSavedQuotesValidationInfo()
        {
            SavedQuotes sq = new SavedQuotes(getDriver());
            sq.verifySavedQuotesPage();
        }

        [Given(@"I verify JMPG Agent Knowledge Base validation information")]
        [When(@"I verify JMPG Agent Knowledge Base validation information")]
        public void VerifyJMPGAgentKnowledgeBaseValidationInfo()
        {
            AgentKnowledgeBase akb = new AgentKnowledgeBase(getDriver());
            akb.verifyAgentKnowledgeBasePage();
        }

        [Given(@"I verify JMPG Pending Cancellation validation information")]
        [When(@"I verify JMPG Pending Cancellation validation information")]
        public void VerifyJMPGPendingCancellationValidationInfo()
        {
            PendingCancellation pc = new PendingCancellation(getDriver());
            pc.verifyPendingCancellationPage();
        }

        [Given(@"I verify JM Support validation information")]
        [When(@"I verify JM Support validation information")]
        public void VerifyJMSupportValidationInfo()
        {
            JMSupport js = new JMSupport(getDriver());
            js.verifyJMSupportPage();
        }

        [Given(@"I verify Lost Business validation information")]
        [When(@"I verify Lost Business validation information")]
        public void VerifyLostBusinessValidationInfo()
        {
            LostBusiness lb = new LostBusiness(getDriver());
            lb.verifyLostBusinessPage();
        }

        [Given(@"I verify Policy Search Result validation information")]
        [When(@"I verify Policy Search Result validation information")]
        public void VerifyPolicySearchResultValidationInfo()
        {
            PolicySearchResult psr = new PolicySearchResult(getDriver());
            psr.verifyPolicySearchResultPage();
        }

        [Given(@"I verify Policy Details validation information")]
        [When(@"I verify Policy Details validation information")]
        public void VerifyPolicyDetailsValidationInfo()
        {
            PolicyDetails pd = new PolicyDetails(getDriver());
            pd.verifyPolicyDetailsPage();
        }

        [Given(@"I verify Transactions Page validation information")]
        [When(@"I verify Transactions Page validation information")]
        public void VerifyTransactionsPageValidationInfo()
        {
            Transactions tr = new Transactions(getDriver());
            tr.verifyTransactionsPage();
        }

        [Given(@"I verify Documents Page validation information")]
        [When(@"I verify Documents Page validation information")]
        public void VerifyDocumentsPageValidationInfo()
        {
            Documents dc = new Documents(getDriver());
            dc.verifyDocuemntsPage();
        }

        [Given(@"I verify Billing History Page validation information")]
        [When(@"I verify Billing History Page validation information")]
        public void VerifyBillingHistoryPageValidationInfo()
        {
            BillingHistory bh = new BillingHistory(getDriver());
            bh.verifyBillingHisotryPage();
        }


        [Given(@"I verify JMPG Get A Quote Page validation information")]
        [When(@"I verify JMPG Get A Quote Page validation information")]
        public void VerifyJMPGGetAQuoteValidationInfo()
        {
            GetAQuote gq = new GetAQuote(getDriver());
            gq.verifyGetAGuotePage();
        }

        [Given(@"I click profile and go to My Account Page")]
        [When(@"I click profile and go to My Account Page")]
        public void GoToMyAccountPage()
        {
            Dashboard db = new Dashboard(getDriver());
            db.goToMyAccountPage();
        }

        [Given(@"I click profile and go to Get a Quote Page")]
        [When(@"I click profile and go to Get a Quote Page")]
        public void GoToGetAQuotePage()
        {
            Dashboard db = new Dashboard(getDriver());
            db.goToGetAQuotePage();
        }

        [Given(@"I click Recently Submitted on the Left Nav")]
        [When(@"I click Recently Submitted on the Left Nav")]
        public void GoToRecentlySubmiited()
        {
            Dashboard db = new Dashboard(getDriver());
            db.goToRecentlySubmitted();
        }

        [Given(@"I click Pending Cancellation on the Left Nav")]
        [When(@"I click Pending Cancellation on the Left Nav")]
        public void GoToPendingCancellation()
        {
            Dashboard db = new Dashboard(getDriver());
            db.goToPendingCancellation();
        }

        [Given(@"I click Saved Quotes on the Left Nav")]
        [When(@"I click Saved Quotes on the Left Nav")]
        public void GoToSavedQUotes()
        {
            Dashboard db = new Dashboard(getDriver());
            db.goToSavedQuotes();
        }

        [Given(@"I click Agent Knowledge Base on the Left Nav")]
        [When(@"I click Agent Knowledge Base on the Left Nav")]
        public void GoToAgentKnowledgeBase()
        {
            Dashboard db = new Dashboard(getDriver());
            db.goToAgentKnowledgeBase();
        }

        [Given(@"I click Lost Business on the Left Nav")]
        [When(@"I click Lost Business on the Left Nav")]
        public void GoToLostBusiness()
        {
            Dashboard db = new Dashboard(getDriver());
            db.goToLostBusiness();
        }

        [Given(@"I click JM Support on the Left Nav")]
        [When(@"I click JM Support on the Left Nav")]
        public void GoToJMSupport()
        {
            Dashboard db = new Dashboard(getDriver());
            db.goToJMSupport();
        }

        [Given(@"I click search result to check policy details")]
        [When(@"I click search result to check policy details")]
        public void GoToPolicyDetails()
        {
            PolicySearchResult psr = new PolicySearchResult(getDriver());
            psr.clickSearchResult();
        }

        [Then(@"I verify JMPG My Account validation information")]
        public void VerifyJMPGMyAccountValidationInfo()
        {
            MyAccount ma = new MyAccount(getDriver());
            ma.verifyMyAccount();
        }

        [Then(@"I click Go Back Button on My Account Page to back to Dashboard Page")]
        public void GoBackDashboardPage()
        {
            MyAccount ma = new MyAccount(getDriver());
            ma.clickGoBackButton();
            Dashboard db = new Dashboard(getDriver());
            db.verifyLogo();
        }

        [Then(@"I click Go To JM Partner Gateway Link on Get a Quote Page Menu Bar")]
        public void ClickGoToJMPartnerGateway()
        {
            GetAQuote gq = new GetAQuote(getDriver());
            gq.clickGoToJMPG();
            Dashboard db = new Dashboard(getDriver());
            db.verifyLogo();
        }

        [Then(@"I click See All Transaction History")]
        [When(@"I click See All Transaction History")]
        [Given(@"I click See All Transaction History")]
        public void ClickGoToSeeAllTransactions()
        {
            PolicyDetails pd = new PolicyDetails(getDriver());
            pd.clickSeeAllTransactions();
        }

        [Then(@"I click See All Documents History")]
        [When(@"I click See All Documents History")]
        [Given(@"I click See All Documents History")]
        public void ClickGoToSeeAllDocuments()
        {
            PolicyDetails pd = new PolicyDetails(getDriver());
            pd.clickSeeAllDocuments();
        }

        [Then(@"I click See Billing History")]
        [When(@"I click See Billing History")]
        [Given(@"I click See Billing History")]
        public void ClickGoToSeeBillingHistory()
        {
            PolicyDetails pd = new PolicyDetails(getDriver());
            pd.clickSeeBillingHistory();
        }

        [Then(@"I logout the JMPG Application and verify the login page")]
        public void LogOutJMPGApplicationAndVerifyLoginPage()
        {
            Dashboard db = new Dashboard(getDriver());
            db.logout();

            LoginPageOfJMPGVerify();
        }


        [Given(@"I access the JMPG app in (.*) , (.*) and (.*)")]
        public void GivenIAccessJMPGAppApplicationIn(string ApplicationEnvironment, string TargetType, string BrowserType)
        {
            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];

            ScenarioContext.Current["Application"] = ApplicationEnvironment;

            Console.WriteLine("Application is " + ApplicationEnvironment);

            ScenarioContext.Current["TargetType"] = TargetType;


            ScenarioContext.Current["BrowserType"] = BrowserType;

            if (TargetType.ToLower() != "desktop")
            {
                startBrowserStackLocal();

                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}

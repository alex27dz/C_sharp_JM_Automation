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
    public class CommonPageElements : Page
    {
        // Menu Bar
        string jmpgLogo = "span[class$='topnav-logo-lg']";
        string helpDeskIcon = "i[class$='uil uil-phone']";
        string helpDesk = "//div[text()='Helpdesk']";
        string profileIcon = "i[class$='uil uil-user']";
        string profile = "//div[text()='Profile']";

        // JMPG Search Bar
        string searchBarButton = "//button[@class='btn btn btn-primary btn-secondary']";
        string searchBarPlaceHolder = "//input[@class='form-control']";


        // Table Control
        // string sortBy = "//span[text()='Sort by:']";
        string sortBy = "//span[contains(text(), 'Sort by:')]";
        string sortBySelect = "//select[@class='custom-select custom-select-md']";
        //string viewBySelect = "//select[@class='custom-select custom-select-sm']";
        //string viewBySelect = "//select[@class='view-by-select custom-select custom-select-sm']";
        string viewBySelect = "//select[contains(@class, 'custom-select custom-select-sm')]";
        string viewBy = "//span[contains(text(), 'View by:')]";
        string ticketsTableFilter = "//div[@id='tickets-table_filter']";

        string startDateLabel = "//label[text()='Start Date']";
        string startDateSelect = "//label[text()='Start Date']//following-sibling::div";
        string endDateLabel = "//label[text()='End Date']";
        string endDateSelect = "//label[text()='End Date']//following-sibling::div";

        // Profile Drop Down
        string logout = "//a[@class='btn btn-secondary btn-170 w-100 text-uppercase']";
        string editInfo = "//a[@class='dropdown-menu-link']";
        string profileInfomationLabel = "//strong[text()='Personal Information:']";
        string email = "//a[text()=' jmtestpartner+803@gmail.com ']";
        string businessInformationLabel = "//strong[text()='Business Information:']";
        string link = "//a[text()=' mytest15.jewelersnt.local ']";
        string personalInfo = "//*[@id='__BVID__11']//address[1]";
        string businessInfo = "//*[@id='__BVID__11']//address[2]";

        // Help Desk Drop Down
        string supportEmail = "//p[text()='Support Email']";
        string custmoerHelpline = "//p[text()='Customer Helpline']";
        string horizontalLine = "//*[@id='__BVID__9']//hr";
        string helpDeskEmail = "//strong[text()='Email']";
        string helpDeskLineNumber = "//strong[text()='Helpline Number']";
        string helpDeskNumber = "//a[text()='844-517-0556']";
        string helpDeskEmailAddress = "//a[text()='contactjm@jminsure.com']";

        // Login Footer
        string linkFooterPrivacyXpath = "//a[@class='privacy-policy']";
       // string smallTroubleXpath = "//small[@class='contrast-btn']";
        string spanCopyRightXpath = "//span[@class='copyright-info']";
        string spanDotXpath = "//span[@class='px-1']";

        // JMPG Footer
        string privacyPolicyFooter = "//a[text()=' Privacy Policy ']";
        string termsOfUseFooter = "//a[text()=' Terms of Use ']";
        string smallPipeFooter = "//*[@id='app']//p/span[2]";
        string jewelersMutualAllRightsReservedFooter = "//p[text()=' © 2020 Jewelers Mutual - All Rights Reserved ']";
        string contact = "//p[@class='mb-0']";
        string address = "//address[@class='mb-0']";

        // JMPG Main Page Left Nav
        string dashBoardIcon = "i[class$='uil-home-alt']";
        string dashBoardLabel = "//span[text()='Dashboard']";
        string savedQuotesIcon = "i[class$='dripicons-archive']";
        string savedQuotesLabel = "//span[text()='Saved Quotes']";
        string quickActionLabel = "//li[text()=' Quick Actions ']";
        string getQuotaIcon = "//i[@class='dripicons-jewel']";
        string getAQuotaLabel = "//span[text()='Get a Quote']";
        string sendAPpraisalIcon = "//i[@class='mdi mdi-email-send-outline']";
        string sendAppraisalLabel = "//span[text()='Send Appraisal']";
        string manageLabel = "//li[text()=' Manage ']";
        string recentSubmitIcon = "//i[@class='uil-file-plus-alt']";
        string recentSubmitLabel = "//span[text()='Recently Submitted']";
        string pendingCancellationIcon = "//i[@class='uil-stopwatch']";
        string pendingCancellationLabel = "//span[text()='Pending Cancellation']";
        string lostBusinessIcon = "//i[@class='uil-bag-slash']";
        string lostBusinessLabel = "//span[text()='Lost Business']";
        string supportLabel = "//li[text()=' Support ']";
        string jmSupportIcon = "//i[@class='uil-comments-alt']";
        string jmSupportLabel = "//span[text()='JM Support']";
        string FAQIcon = "//i[@class='uil-question-circle']";
        string FAQLabel = "//span[text()='FAQ']"; 
        string agentKnowledgeBaseIcon = "//i[@class='mdi mdi-file-pdf-outline']";
        string agentKnowledgeBaseLabel = "//span[text()='Agent Knowledge Base']";

        //Table Header
        string accountNumber = "//th[text()='Account Number']";
        string policyID = "//th[text()='Policy ID']";
        string firstName = "//th[text()='First Name']";
        string lastName = "//th[text()='Last Name']";
        string city = "//th[text()='City']";
        string state = "//th[text()='State']";
        string status = "//th[text()='Status']";
        string submissionDate = "//th[text()='Submission Date']";
        string effectiveDate = "//th[text()='Effective Date']";
        string expireDate = "//th[text()='Expiration Date']";
        string annualPremium = "//th[text()='Annual Premium']";

        //Policy Details
        string documentsButton = "//button[text()=' Documents ']";
        string policyButton = "//button[text()=' Policy ']";
        string billingButton = "//button[text()=' Billing ']";
        string transactionsButton = "//button[text()=' Transactions ']";
        string accountNameLabel = "//b[text()='Account Name:']";
        string accountNumberLabel = "//b[text()='Account Number:']";
        string accountNumberValue = "//div[contains(text(), '3000878512')]";

        public CommonPageElements(IWebDriver driver) : base(driver)
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

        public void verifyJMPGLogo()
        {
            VerifyUIElementIsDisplayed(jmpgLogo);
           // WaitUntilElementIsDisplayed(driver, By.ClassName("topnav-logo-lg"));
        }


        public void verifyJMPGHelpDesk()
        {
            VerifyUIElementIsDisplayed(helpDeskIcon);
            IWebElement labelHelpDesk = driver.FindElement(By.XPath(helpDesk));
            Assert.IsTrue(labelHelpDesk.Text.Equals("HELPDESK"), "Actual text content to verify Help Desk of Dashboard Menu Bar: " + labelHelpDesk.Text);

        }

        public void verifyJMPGProfile()
        {
            VerifyUIElementIsDisplayed(profileIcon);
            IWebElement labelProfile = driver.FindElement(By.XPath(profile));
            Assert.IsTrue(labelProfile.Text.Equals("PROFILE"), "Actual text content to verify Profile of Dashboard Menu Bar: " + labelProfile.Text);
        }

        public void verifyJMPGHelpDeskDropDown()
        {
            VerifyUIElementIsDisplayed(supportEmail);
            VerifyUIElementIsDisplayed(custmoerHelpline);
            VerifyUIElementIsDisplayed(horizontalLine);
            VerifyUIElementIsDisplayed(helpDeskEmail);
            VerifyUIElementIsDisplayed(helpDeskLineNumber);
            VerifyUIElementIsDisplayed(helpDeskNumber);
            VerifyUIElementIsDisplayed(helpDeskEmailAddress);
        }

        public void verifyStartDateAndEndDateTabel()
        {
            VerifyUIElementIsDisplayed(startDateLabel);
            VerifyUIElementIsDisplayed(startDateSelect);
            VerifyUIElementIsDisplayed(endDateLabel);
            VerifyUIElementIsDisplayed(endDateSelect);
        }

        public void verifySortTable()
        {
            VerifyUIElementIsDisplayed(sortBy);
            VerifyUIElementIsDisplayed(sortBySelect);
        }

        public void verifyViewTable()
        {
            VerifyUIElementIsDisplayed(viewBy);
            VerifyUIElementIsDisplayed(viewBySelect);
        }

        public void verifyViewTableFilterLabel()
        {
            IWebElement labelTicketsTableFilter = driver.FindElement(By.XPath(ticketsTableFilter));
            Assert.IsTrue(labelTicketsTableFilter.Text.Contains("Viewing"), "Actual text content to verify Table Filter of Table Control: " + labelTicketsTableFilter.Text);
        }

        public void verifyJMPGProfileDropDown()
        {
            IWebElement logoutButton = driver.FindElement(By.XPath(logout));
            IWebElement editInfoLink = driver.FindElement(By.XPath(editInfo));
            IWebElement labelPersonalInfo = driver.FindElement(By.XPath(profileInfomationLabel));
            IWebElement linkEmail = driver.FindElement(By.XPath(email));
            IWebElement labelBusinessInfo = driver.FindElement(By.XPath(businessInformationLabel));
            IWebElement linkOfProfileDropDown = driver.FindElement(By.XPath(link));
            IWebElement personalInfoAddress = driver.FindElement(By.XPath(personalInfo));
            IWebElement businessInfoAddress = driver.FindElement(By.XPath(businessInfo));

            string name = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[3].textContent;", personalInfoAddress)).Trim();
            string phone = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[5].textContent;", personalInfoAddress)).Trim();

            string geico = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[3].textContent;", businessInfoAddress)).Trim();
            string streetInfo = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[5].textContent;", businessInfoAddress)).Trim();
            string cityStateAndZip = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[8].textContent;", businessInfoAddress)).Trim();

            Assert.IsTrue(logoutButton.Text.Equals("LOGOUT"), "Actual text content to verify Logout of Profile Drop down of Dashboard Menu Bar: " + logoutButton.Text);
            Assert.IsTrue(editInfoLink.Text.Equals("Edit Information"), "Actual text content to verify Edit Information link of Profile Drop down of Dashboard Menu Bar: " + editInfoLink.Text);
            Assert.IsTrue(labelPersonalInfo.Text.Equals("Personal Information:"), "Actual text content to verify Personal Information Label of Profile Drop down of Dashboard Menu Bar: " + labelPersonalInfo.Text);
            Assert.IsTrue(linkEmail.Text.Equals("jmtestpartner+803@gmail.com"), "Actual text content to verify Email Link of Profile Drop down of Dashboard Menu Bar: " + linkEmail.Text);
            Assert.IsTrue(labelBusinessInfo.Text.Equals("Business Information:"), "Actual text content to verify Business Information Label of Profile Drop down of Dashboard Menu Bar: " + labelBusinessInfo.Text);
            Assert.IsTrue(linkOfProfileDropDown.Text.Equals("mytest15.jewelersnt.local"), "Actual text content to verify Link of Profile Drop down of Dashboard Menu Bar: " + linkOfProfileDropDown.Text);
            Assert.IsTrue(name.Equals("Ryan Rose"), "Actual text content to verify name of Profile Drop down of Dashboard Menu Bar: " + name);
            Assert.IsTrue(phone.Equals("+1-5555555555"), "Actual text content to verify phone of Profile Drop down of Dashboard Menu Bar: " + phone);
            Assert.IsTrue(geico.Equals("GEICO (for JM Gateway Partners project)"), "Actual text content to verify phone of Profile Drop down of Dashboard Menu Bar: " + geico);
            Assert.IsTrue(streetInfo.Equals("101 W 103rd St"), "Actual text content to verify Street Information of Profile Drop down of Dashboard Menu Bar: " + streetInfo);
            Assert.IsTrue(cityStateAndZip.Equals("Indianapolis, IN 46290"), "Actual text content to verify City State and ZipCode of Profile Drop down of Dashboard Menu Bar: " + cityStateAndZip);
            // 
        }

        public void verifyJMPGSearchBar()
        {

            IWebElement buttonSearchBar = driver.FindElement(By.XPath(searchBarButton));
            IWebElement inputSearchBar = driver.FindElement(By.XPath(searchBarPlaceHolder));

            Assert.IsTrue(buttonSearchBar.Text.Equals("Search"), "Actual text content to verify Search Bar Button of Agent Dashboard: " + buttonSearchBar.Text);
            Assert.IsTrue(inputSearchBar.GetAttribute("placeholder").Equals("Search by Name, Account No., or Policy ID"), "Actual text content to verify Search Bar Input of Agent Dashboard: " + inputSearchBar.GetAttribute("placeholder"));
        }

        public void verifLoginAndMyAccountyFooter()
        {
            Console.WriteLine("----Login and My Account Footer error message validation ----- started ------");

           // IWebElement troubleFooter = driver.FindElement(By.XPath(smallTroubleXpath));
            IWebElement dotFooter = driver.FindElement(By.XPath(spanDotXpath));
            IWebElement copyRightFooter = driver.FindElement(By.XPath(spanCopyRightXpath));
            IWebElement privacyLink = driver.FindElement(By.XPath(linkFooterPrivacyXpath));

          //  string troubleFooterText = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].firstChild.textContent;", troubleFooter)).Trim();

          //  Assert.IsTrue(troubleFooterText.Equals("Trouble viewing content? Please switch to"), "Actual text content to verify Footer Trouble viewing: " + troubleFooterText);
            Assert.IsTrue(dotFooter.Text.Equals("•"), "Actual text content to verify Footer Dot: " + dotFooter.Text);
            Assert.IsTrue(copyRightFooter.Text.Equals("© 2020 Jewelers Mutual Group. All Rights Reserved."), "Actual text content to verify Footer Copy Right Info: " + copyRightFooter.Text);
            Assert.IsTrue(privacyLink.Text.Equals("Privacy"), "Actual text content to verify Footer Privacy Link: " + privacyLink.Text);

            Console.WriteLine("----Login and My Account Footer error message validation ----- complete ------");
        }

        public void verifyJMPGFooter()
        {
            Console.WriteLine("----JMPG Footer error message validation ----- started ------");

            IWebElement privacyPolicy = driver.FindElement(By.XPath(privacyPolicyFooter));
            IWebElement termsOfUse = driver.FindElement(By.XPath(termsOfUseFooter));
            IWebElement smallPipe = driver.FindElement(By.XPath(smallPipeFooter));
            IWebElement jewelersMutualAllRightsReserved = driver.FindElement(By.XPath(jewelersMutualAllRightsReservedFooter));
            IWebElement contactUSFooter = driver.FindElement(By.XPath(contact));
            IWebElement addressFooter = driver.FindElement(By.XPath(address));

            string contactUS = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].firstChild.textContent;", contactUSFooter)).Trim();
            string callText = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[2].textContent;", contactUSFooter)).Trim();

            string JM = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].firstChild.textContent;", addressFooter)).Trim();
            string street = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[2].textContent;", addressFooter)).Trim();
            string cityStateAndZIP = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].lastChild.textContent;", addressFooter)).Trim();

            Assert.IsTrue(privacyPolicy.Text.Equals("Privacy Policy"), "Actual text content to verify Footer Privacy Policy of JMPG Page: " + privacyPolicy.Text);
            Assert.IsTrue(termsOfUse.Text.Equals("Terms of Use"), "Actual text content to verify Footer Terms Of Use of JMPG Page: " + termsOfUse.Text);
            Assert.IsTrue(smallPipe.Text.Equals("|"), "Actual text content to verify Footer Small Pipe of Dashboard Page: " + smallPipe.Text);
            Assert.IsTrue(jewelersMutualAllRightsReserved.Text.Equals("© 2020 Jewelers Mutual - All Rights Reserved"), "Actual text content to verify Footer Jewelers Mutual All Right sReserved of JMPG Page: " + jewelersMutualAllRightsReserved.Text);
            Assert.IsTrue(contactUS.Equals("Contact Us:"), "Actual text content to verify Footer Contact US of JMPG Page: " + contactUS);
            Assert.IsTrue(callText.Equals("1-833-970-9464"), "Actual text content to verify Footer Contact number of JMPG Page: " + callText);
            Assert.IsTrue(JM.Equals("Jewelers Mutual"), "Actual text content to verify Footer JM Name of JMPG Page: " + JM);
            Assert.IsTrue(street.Equals("24 Jewelers Park Dr"), "Actual text content to verify Footer Street of JMPG Page: " + street);
            Assert.IsTrue(cityStateAndZIP.Equals("Neenah, WI 54956"), "Actual text content to verify Footer city, State and ZIP Address of JMPG Page: " + cityStateAndZIP);

            Console.WriteLine("----JMPG Footer error message validation ----- complete ------");
        }

        public void verifyJMPGLeftNav()
        {
            Console.WriteLine("----JMPG Left Navigation error message validation ----- started ------");

            VerifyUIElementIsDisplayed(dashBoardIcon);
            VerifyUIElementIsDisplayed(savedQuotesIcon);
            VerifyUIElementIsDisplayed(getQuotaIcon);
            VerifyUIElementIsDisplayed(sendAPpraisalIcon);
            VerifyUIElementIsDisplayed(pendingCancellationIcon);
            VerifyUIElementIsDisplayed(recentSubmitIcon);
            VerifyUIElementIsDisplayed(lostBusinessIcon);
            VerifyUIElementIsDisplayed(jmSupportIcon);
            VerifyUIElementIsDisplayed(FAQIcon);
            VerifyUIElementIsDisplayed(agentKnowledgeBaseIcon);
            IWebElement labelDashBoard = driver.FindElement(By.XPath(dashBoardLabel));
            IWebElement labelSavedQuotes = driver.FindElement(By.XPath(savedQuotesLabel));
            IWebElement labelQuickAction = driver.FindElement(By.XPath(quickActionLabel));
            IWebElement labelGetQuote = driver.FindElement(By.XPath(getAQuotaLabel));
            IWebElement labelSendAppraisal = driver.FindElement(By.XPath(sendAppraisalLabel));
            IWebElement labelManage = driver.FindElement(By.XPath(manageLabel));
            IWebElement labelRecentSubmit = driver.FindElement(By.XPath(recentSubmitLabel));
            IWebElement labelLostBusiness = driver.FindElement(By.XPath(lostBusinessLabel));
            IWebElement labelPendingCancellation = driver.FindElement(By.XPath(pendingCancellationLabel));
            IWebElement labelSupport = driver.FindElement(By.XPath(supportLabel));
            IWebElement labelFAQ = driver.FindElement(By.XPath(FAQLabel));
            IWebElement labelJMSupport = driver.FindElement(By.XPath(jmSupportLabel));
            IWebElement labelAgentKnowledgeBase = driver.FindElement(By.XPath(agentKnowledgeBaseLabel));
            Assert.IsTrue(labelDashBoard.Text.Equals("Dashboard"), "Actual text content to verify Dashboard Label of JMPG Left Navigation: " + labelDashBoard.Text);
            Assert.IsTrue(labelSavedQuotes.Text.Equals("Saved Quotes"), "Actual text content to verify Saved Quotes Label of JMPG Left Navigation: " + labelSavedQuotes.Text);
            Assert.IsTrue(labelQuickAction.Text.Equals("QUICK ACTIONS"), "Actual text content to verify Quick Action Label of JMPG Left Navigation: " + labelQuickAction.Text);
            Assert.IsTrue(labelGetQuote.Text.Equals("Get a Quote"), "Actual text content to verify Get Quote Label of JMPG Left Navigation: " + labelGetQuote.Text);
            Assert.IsTrue(labelSendAppraisal.Text.Equals("Send Appraisal"), "Actual text content to verify Send Appraisal Label of JMPG Left Navigation: " + labelSendAppraisal.Text);
            Assert.IsTrue(labelManage.Text.Equals("MANAGE"), "Actual text content to verify Manage of JMPG Left Navigation: " + labelManage.Text);
            Assert.IsTrue(labelRecentSubmit.Text.Equals("Recently Submitted"), "Actual text content to verify Recent Submit Label of JMPG Left Navigation: " + labelRecentSubmit.Text);
            Assert.IsTrue(labelLostBusiness.Text.Equals("Lost Business"), "Actual text content to verify Lost Business of JMPG Left Navigation: " + labelLostBusiness.Text);
            Assert.IsTrue(labelPendingCancellation.Text.Equals("Pending Cancellation"), "Actual text content to verify Pending Cancellation Label of JMPG Left Navigation: " + labelPendingCancellation.Text);
            Assert.IsTrue(labelSupport.Text.Equals("SUPPORT"), "Actual text content to verify Support Label of JMPG Left Navigation: " + labelSupport.Text);
            Assert.IsTrue(labelJMSupport.Text.Equals("JM Support"), "Actual text content to verify JM Support Label of JMPG Left Navigation: " + labelJMSupport.Text);
            Assert.IsTrue(labelFAQ.Text.Equals("FAQ"), "Actual text content to verify FAQ Label of JMPG Left Navigation: " + labelFAQ.Text);
            Assert.IsTrue(labelAgentKnowledgeBase.Text.Equals("Agent Knowledge Base"), "Actual text content to verify FAQ Label of JMPG Left Navigation: " + labelAgentKnowledgeBase.Text);

            Console.WriteLine("----JMPG Left Navigation error message validation ----- complete ------");
        }

        public void verifyPolicyDetailsCommonElements()
        {
            VerifyUIElementIsDisplayed(billingButton);
            VerifyUIElementIsDisplayed(documentsButton);
            VerifyUIElementIsDisplayed(transactionsButton);
            VerifyUIElementIsDisplayed(policyButton);
            VerifyUIElementIsDisplayed(accountNameLabel);
            VerifyUIElementIsDisplayed(accountNumberLabel);
            VerifyUIElementIsDisplayed(accountNumberValue);
        }

        public void verifyManageTableHeader(string tabName)
        {
            int numOfSortElements;

            if (tabName == "Recently Submitted")
            {
                numOfSortElements = 10;
                IWebElement tableHeaderSubmissionDate = driver.FindElement(By.XPath(submissionDate));
                Assert.IsTrue(tableHeaderSubmissionDate.Text.Contains("Submission Date"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderSubmissionDate.Text);
            }
            else
            {
                numOfSortElements = 9;
            }

            verifyClickToSortElements(numOfSortElements);

            IWebElement tableHeaderAccountNumber = driver.FindElement(By.XPath(accountNumber));
            IWebElement tableHeaderPolicyID = driver.FindElement(By.XPath(policyID));
            IWebElement tableHeaderFirstName = driver.FindElement(By.XPath(firstName));
            IWebElement tableHeaderLastName = driver.FindElement(By.XPath(lastName));
            IWebElement tableHeaderCity = driver.FindElement(By.XPath(city));
            IWebElement tableHeaderState = driver.FindElement(By.XPath(state));
            IWebElement tableHeaderStatus = driver.FindElement(By.XPath(status));
            
            IWebElement tableHeaderEffectiveDate = driver.FindElement(By.XPath(effectiveDate));
            IWebElement tableHeaderExpireDate = driver.FindElement(By.XPath(expireDate));
            IWebElement tableHeaderAnnualPremium = driver.FindElement(By.XPath(annualPremium));

            Assert.IsTrue(tableHeaderAccountNumber.Text.Contains("Account Number"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderAccountNumber.Text);
            Assert.IsTrue(tableHeaderPolicyID.Text.Contains("Policy ID"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderPolicyID.Text);
            Assert.IsTrue(tableHeaderFirstName.Text.Contains("First Name"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderFirstName.Text);
            Assert.IsTrue(tableHeaderLastName.Text.Contains("Last Name"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderLastName.Text);
            Assert.IsTrue(tableHeaderCity.Text.Contains("City"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderCity.Text);
            Assert.IsTrue(tableHeaderState.Text.Contains("State"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderState.Text);
            Assert.IsTrue(tableHeaderStatus.Text.Contains("Status"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderStatus.Text);            
            Assert.IsTrue(tableHeaderEffectiveDate.Text.Contains("Effective Date"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderEffectiveDate.Text);
            Assert.IsTrue(tableHeaderExpireDate.Text.Contains("Expiration Date"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderExpireDate.Text);
            Assert.IsTrue(tableHeaderAnnualPremium.Text.Contains("Annual Premium"), "Actual text content to verify Account Number of " + tabName + " Table Header: " + tableHeaderAnnualPremium.Text);
        }

        public void verifyClickToSortElements(int numOfItem)
        {
            for (int i = 1; i <= numOfItem; i++)
            {
                VerifyUIElementIsDisplayed("//*[@id='policiesTable']//th[" + i + "]/span");
            }
        }


        public void clickGetAQuotePage()
        {
            IWebElement labelGetQuote = driver.FindElement(By.XPath(getAQuotaLabel));
            labelGetQuote.Click();
        }

        public void clickRecentlySubmitted()
        {
            IWebElement labelRecentSubmit = driver.FindElement(By.XPath(recentSubmitLabel));
            labelRecentSubmit.Click();
        }

        public void clickPendingCancellation()
        {
            IWebElement labelPendingCancellation = driver.FindElement(By.XPath(pendingCancellationLabel));
            labelPendingCancellation.Click();
        }

        public void clickSavedQutoes()
        {
            IWebElement labelSavedQuotes = driver.FindElement(By.XPath(savedQuotesLabel));
            labelSavedQuotes.Click();
        }
        public void clickAgentKnowledgeBase()
        {
            IWebElement labelAgentKnowledgeBase = driver.FindElement(By.XPath(agentKnowledgeBaseLabel));
            labelAgentKnowledgeBase.Click();
        }

        public void clickJMSupport()
        {
            IWebElement labelJMSupport = driver.FindElement(By.XPath(jmSupportLabel));
            labelJMSupport.Click();
        }

        public void clickLostBusiness()
        {
            IWebElement labelLostBusiness = driver.FindElement(By.XPath(lostBusinessLabel));
            labelLostBusiness.Click();
        }

        public void clickProfile()
        {
            IWebElement labelProfile = driver.FindElement(By.XPath(profile));
            labelProfile.Click();
        }

        public void clickHelpDesk()
        {
            IWebElement labelHelpDesk = driver.FindElement(By.XPath(helpDesk));
            labelHelpDesk.Click();
        }

        public void clickEditInformation()
        {
            IWebElement labelProfile = driver.FindElement(By.XPath(profile));
            IWebElement editInfoLink = driver.FindElement(By.XPath(editInfo));
            labelProfile.Click();
            WaitUntilElementVisible(driver, By.XPath(editInfo));
            editInfoLink.Click();
        }
        public void clickLogoutButton()
        {
            driver.FindElement(By.XPath(profile)).Click();
            WaitUntilElementVisible(driver, By.XPath(logout));
            driver.FindElement(By.XPath(logout)).Click();
        }


        public void searchAccountNumber(string accountNumber)
        {
            driver.FindElement(By.XPath(searchBarPlaceHolder)).SendKeys(accountNumber);
            pause();
            driver.FindElement(By.XPath(searchBarButton)).Click();
        }

        public bool viewByLabelIsPresent()
        {
            return IsElementPresent(By.XPath(viewBy));
        }

        public bool sortByLabelIsPresent()
        {
            return IsElementPresent(By.XPath(sortBy));
        }

        public bool viewFilterLabelIsPresent()
        {
            return IsElementPresent(By.XPath(ticketsTableFilter));
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

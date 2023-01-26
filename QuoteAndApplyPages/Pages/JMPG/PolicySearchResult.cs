using System;
using System.Collections.Generic;
using System.Linq;
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
    public class PolicySearchResult : Page
    {
        // Policy Search Results Bar
        string policySearchResultsHeader = "//h2[text()=' Policy Search Results ']";
        string policySearchResultsLabel = "//div[@class='pr-1 mb-0']";

        // Table Data
        string accountNumberData = "//td[text()='3000878512']";
        string policyIdData = "//td[text()=' 24-845465 ']";
        string firstNameData = "//td[text()='Emanuel']";
        string firstNameDataOnProd = "//td[text()='James']";
        string lastNameData = "//td[text()='Mimnaugh']";
        string lastNameDataOnProd = "//td[text()='Murdoch']";
        string cityData = "//td[text()='Seattle']";
        string stateData = "//td[text()='Washington']";
        string statusData = "//td[text()='In Force']";
        string effectiveDateData = "//td[text()=' 05/29/2020 ']";
        string expirationDateData = "//td[text()=' 05/29/2021 ']";
        string annulPremiumData = "//td[text()=' $278.00 ']";

        //Error
        string tableError = "//*[@id='policiesTable']//div[@class='spinner-container']";

        public PolicySearchResult(IWebDriver driver) : base(driver)
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

            //| mbevers@jminsure.com | Admin123! | is negative case 
            while (!cp.sortByLabelIsPresent())
            {
                if (cp.IsElementPresent(By.XPath(tableError)))
                {
                    //driver.Quit();
                    Assert.Fail("Table on Policy Search Result Page has go wrong, please try again!!");
                    // KillWEbDriver();
                }
            }
        }

        public void verifyPolicySearchResultPage()
        {
            WaitForTableLoad();
            Console.WriteLine("----JMPG Policy Search Result Page error message validation ----- started------");
            verifyPolicySearchResultMenuBar();
            verifyPolicySearchResultBar();
            verifyPolicySearchResultControl();
            verifyTable();
            verifyLeftNav();
            verifyFooter();
            Console.WriteLine("----JMPG Policy Search Result Page error message validation ----- ended------");
        }

        public void verifyPolicySearchResultMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifyPolicySearchResultBar()
        {
            VerifyUIElementIsDisplayed(policySearchResultsHeader);
            //Search Results for 3000878512
            IWebElement labelPolicySearchResults = driver.FindElement(By.XPath(policySearchResultsLabel));
            Assert.IsTrue(labelPolicySearchResults.Text.Contains("Search Results for 3000878512"), "Actual text content to verify Policy Search Result Label under the Policy Search Result Header: " + labelPolicySearchResults.Text);

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

        public void verifyTableHeader()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyManageTableHeader("Policy Search Result");
        }

        public void verifyTableData()
        {
            VerifyUIElementIsDisplayed(accountNumberData);
            VerifyUIElementIsDisplayed(policyIdData);           
            VerifyUIElementIsDisplayed(cityData);
            VerifyUIElementIsDisplayed(stateData);
            VerifyUIElementIsDisplayed(statusData);
            VerifyUIElementIsDisplayed(effectiveDateData);
            VerifyUIElementIsDisplayed(expirationDateData);
            VerifyUIElementIsDisplayed(annulPremiumData);

            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() != "prod")
            {
                VerifyUIElementIsDisplayed(firstNameData);
                VerifyUIElementIsDisplayed(lastNameData);
            }
            else
            {
                VerifyUIElementIsDisplayed(firstNameDataOnProd);
                VerifyUIElementIsDisplayed(lastNameDataOnProd);
            }
            
        }

        public void verifyTable()
        {
            verifyTableHeader();
            verifyTableData();
        }

        public void verifyPolicySearchResultControl()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifySortTable();
           /* if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() != "qa15")
            {
                cp.verifyViewTableFilterLabel();
            }
            */
        }

        public void clickSearchResult()
        {
            WaitForTableLoad();
            driver.FindElement(By.XPath(accountNumberData)).Click();
        }

    }
}

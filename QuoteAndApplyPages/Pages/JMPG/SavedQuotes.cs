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
    public class SavedQuotes : Page
    {
        // Saved Quotes Bar
        string savedQuotesHeader = "//h2[text()=' Saved Quotes ']";

        // table refresh
        string refreshLink = "//span[contains(text(), 'Refresh')]";

        //Error
        string tableError = "//*[@id='policiesTable']//div[@class='spinner-container']";

        // table header
        string accountNameTableHeader = "//th[text()='Account Name']";
        string emailAddressTableHeader = "//th[text()='Email Address']";
        string stateTableHeader = "//th[text()='State']";
        string quotedPremiumTableHeader = "//th[text()='Quoted Premium']";
        string quoteExpirationDateTableHeader = "//th[text()='Quote Expiration Date']";
        string reviewApplicationTableHeader = "//th[text()='Review Application']";

        public SavedQuotes(IWebDriver driver) : base(driver)
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
            while (!cp.viewFilterLabelIsPresent())
            {
                if (cp.IsElementPresent(By.XPath(tableError)))
                {
                    //driver.Quit();
                    Assert.Fail("Table on Pending Cancellation Page has go wrong, please try again!!");
                    // KillWEbDriver();
                }
            }
        }
        

        public void verifySavedQuotesPage()
        {
            WaitForTableLoad();
            Console.WriteLine("----JMPG Saved Quotes Page error message validation ----- started------");
            verifySavedQuotesMenuBar();
            verifySavedQuotesBar();
            verifySavedQuotesTableControl();
            verifyLeftNav();
            verifyFooter();
            verifyTable();
            Console.WriteLine("----JMPG Saved Quotes Page error message validation ----- ended------");
        }

        public void verifySavedQuotesMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifySavedQuotesBar()
        {
            VerifyUIElementIsDisplayed(savedQuotesHeader);

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

        public void verifySavedQuotesTableControl()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifySortTable();
            cp.verifyViewTableFilterLabel();
            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "qa15")
            {
                cp.verifyViewTable();
            }

        }

        public void verifyTable()
        {
            verifyTableHeader();
            VerifyUIElementIsDisplayed(refreshLink);
        }

        public void verifyTableHeader()
        {
            VerifyUIElementIsDisplayed(accountNameTableHeader);
            VerifyUIElementIsDisplayed(emailAddressTableHeader);
            VerifyUIElementIsDisplayed(stateTableHeader);
            VerifyUIElementIsDisplayed(quotedPremiumTableHeader);
            VerifyUIElementIsDisplayed(quoteExpirationDateTableHeader);
            VerifyUIElementIsDisplayed(reviewApplicationTableHeader);
        }
    }
}

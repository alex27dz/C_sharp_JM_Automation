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
    public class RecentlySubmitted : Page
    {
        // Recently Submitted Bar
        string recentlySubmiitedHeader = "//h2[text()=' Recently Submitted ']";
        string recentlySubmittedPolicciesMayBePendingReviewLabel = "//div[text()=' Recently submitted policies may be pending review ']";


        //Error
        string tableError = "//*[@id='policiesTable']//div[@class='spinner-container']";

        public RecentlySubmitted(IWebDriver driver) : base(driver)
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
            while (!cp.viewByLabelIsPresent())
            {
                if (cp.IsElementPresent(By.XPath(tableError)))
                {
                    //driver.Quit();
                    Assert.Fail("Table on Recently Submitted Page has go wrong, please try again!!");
                   // KillWEbDriver();
                }
            }
        }

        public void verifyRecentlySubmittedPage()
        {
            WaitForTableLoad();
            Console.WriteLine("----JMPG Recently Submitted Page error message validation ----- started------");
            verifyRecentlySubmittedMenuBar();
            verifyLeftNav();
            verifyRecentlySubmittedBar();
            verifyRecentlySubmiitedTableControl();
            verifyTableHeader();
            verifyFooter();
            Console.WriteLine("----JMPG Recently Submitted Page error message validation ----- ended------");
        }

        public void verifyRecentlySubmittedMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
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

        public void verifyRecentlySubmittedBar()
        {
            VerifyUIElementIsDisplayed(recentlySubmiitedHeader);
            VerifyUIElementIsDisplayed(recentlySubmittedPolicciesMayBePendingReviewLabel);
            verifySearchBar();
        }

        public void verifySearchBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGSearchBar();
        }

        public void verifyRecentlySubmiitedTableControl()
        {
           
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyStartDateAndEndDateTabel();
            cp.verifyViewTable();
            cp.verifyViewTableFilterLabel();
        }

        public void verifyTableHeader()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyManageTableHeader("Recently Submitted");
        }
    }
}

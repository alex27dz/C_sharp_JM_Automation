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
    public class LostBusiness : Page
    {
        // Lost Business Bar
        string lostBuinessHeader = "//h2[text()=' Lost Business ']";

        //Error
        string tableError = "//*[@id='policiesTable']//div[@class='spinner-container']";

        public LostBusiness(IWebDriver driver) : base(driver)
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
                    Assert.Fail("Table on Lost Business Page has go wrong, please try again!!");
                    // KillWEbDriver();
                }
            }
        }

        public void verifyLostBusinessPage()
        {
            WaitForTableLoad();
            Console.WriteLine("----JMPG Lost Business Page error message validation ----- started------");
            verifyLostBusinessMenuBar();
            verifyLostBusinessBar();
            verifyLostBusinessTableControl();
            verifyTableHeader();
            verifyLeftNav();
            verifyFooter();
            Console.WriteLine("----JMPG Lost Business Page error message validation ----- ended------");
        }

        public void verifyLostBusinessMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifyLostBusinessBar()
        {
            VerifyUIElementIsDisplayed(lostBuinessHeader);

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
            cp.verifyManageTableHeader("Lost Business");
        }

        public void verifyLostBusinessTableControl()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifySortTable();
            cp.verifyViewTable();
            cp.verifyViewTableFilterLabel();
          
        }
    }
}

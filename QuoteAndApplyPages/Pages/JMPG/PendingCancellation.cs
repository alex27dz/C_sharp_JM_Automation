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
    public class PendingCancellation : Page
    {
        // Pending Cancellation Bar
        string pendingCancellationHeader = "//h2[text()=' Pending Cancellation ']";

        //Error
        string tableError = "//*[@id='policiesTable']//div[@class='spinner-container']";

        public PendingCancellation(IWebDriver driver) : base(driver)
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
                    Assert.Fail("Table on Pending Cancellation Page has go wrong, please try again!!");
                    // KillWEbDriver();
                }
            }
        }

        public void verifyPendingCancellationPage()
        {
            WaitForTableLoad();
            Console.WriteLine("----JMPG Pending Cancellation Page error message validation ----- started------");
            verifyPendingCancellationMenuBar();
            verifyPendingCancellationBar();
            verifyPendingCancellationTableControl();
            verifyLeftNav();         
            verifyFooter();
            verifyTableHeader();
            Console.WriteLine("----JMPG Pending Cancellation Page error message validation ----- ended------");
        }

        public void verifyPendingCancellationMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifyPendingCancellationBar()
        {
            VerifyUIElementIsDisplayed(pendingCancellationHeader);

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

        public void verifyPendingCancellationTableControl()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifySortTable();
            cp.verifyViewTable();
            cp.verifyViewTableFilterLabel();
        }

        public void verifyTableHeader()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyManageTableHeader("Pending Cancellation");
        }

    }
}

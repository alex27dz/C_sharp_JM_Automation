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
    public class AgentKnowledgeBase : Page
    {
        // Agent Knowledge Base  Bar
        string agentKnowledgebaseHeader = "//h2[text()=' Agent Knowledge Base ']";
        //Error
        //string tableError = "//*[@id='policiesTable']//div[@class='spinner-container']";

        // table header
        string documentDateTableHeader = "//th[text()='Document Date']";
        string documentNameTableHeader = "//th[text()='Document Name']";
        string viewTableHeader = "//th[text()='View']";
        string downloadTableHeader = "//th[text()='Download']";

        public AgentKnowledgeBase(IWebDriver driver) : base(driver)
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

        /*
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
      */

        public void verifyAgentKnowledgeBasePage()
        {
            // WaitForTableLoad();
            Console.WriteLine("----JMPG Agent Knowledge Base Page error message validation ----- started------");
            verifyAgentKnowledgeBaseBar();
            verifyAgentKnowledgeBaseSearchBar();
            verifyAgentKnowledgeBaseTableControl();
            verifyLeftNav();
            verifyFooter();
            verifyTableHeader();
            Console.WriteLine("----JMPG Agent Knowledge Base Page error message validation ----- ended------");
        }

        public void verifyAgentKnowledgeBaseBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }

        public void verifyAgentKnowledgeBaseSearchBar()
        {
            VerifyUIElementIsDisplayed(agentKnowledgebaseHeader);

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

        public void verifyAgentKnowledgeBaseTableControl()
        {
            CommonPageElements cp = new CommonPageElements(driver);
         
            cp.verifySortTable();
            cp.verifyViewTableFilterLabel();
        }

        public void verifyTableHeader()
        {
            VerifyUIElementIsDisplayed(documentDateTableHeader);
            VerifyUIElementIsDisplayed(documentNameTableHeader);
            VerifyUIElementIsDisplayed(viewTableHeader);
            VerifyUIElementIsDisplayed(downloadTableHeader);
           
        }
    }
}

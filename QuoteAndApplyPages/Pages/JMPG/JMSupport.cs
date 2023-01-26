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
    public class JMSupport : Page
    {
        // JM Support Bar
        string jmSupportHeader = "//h2[text()=' Jewelers Mutual Support ']";

        // contact board
        string howToReashUs = "//h3[text()=' How to Reach Us ']";
        string supportPhoneNumber = "//h5[text()='Support Phone Number:']";
        string supportEmail = "//h5[text()='Support Email:']";
        string emailUsOnYourQuestion = "//a[text()=' Email us your question ']";
        string giveUsACall = "//a[text()=' Give us a call ']";
        string phone = "//p//a[text()='844-517-0556']";
        string email = "//p//a[text()='contactjm@jminsure.com']";
        string howToReachUSText = "//p[@class='text-muted mt-3']";

        public JMSupport(IWebDriver driver) : base(driver)
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
           
            WaitUntilElementVisible(driver, By.XPath(jmSupportHeader));
        }

        public void verifyJMSupportPage()
        {
           
            Console.WriteLine("----JM Support Page error message validation ----- started------");
            verifyJMSupportMenuBar();
            verifyJMSupportBar();
            verifyContactBoard();
            verifyLeftNav();
            verifyFooter();
            Console.WriteLine("----JM Support Page error message validation ----- ended------");
        }


        public void verifyContactBoard()
        {
            VerifyUIElementIsDisplayed(howToReashUs);
            VerifyUIElementIsDisplayed(supportPhoneNumber);
            VerifyUIElementIsDisplayed(supportEmail);
            VerifyUIElementIsDisplayed(giveUsACall);
            VerifyUIElementIsDisplayed(emailUsOnYourQuestion);
            VerifyUIElementIsDisplayed(phone);
            VerifyUIElementIsDisplayed(email);

            IWebElement text = driver.FindElement(By.XPath(howToReachUSText));
            string textOfReashUs_1 = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].firstChild.textContent;", text)).Trim();
            string textOfReashUs_2 = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[2].textContent;", text)).Trim();

            Assert.IsTrue(textOfReashUs_1.Equals("We're here Monday-Thursday 7am-7pm Central Time, and Friday 7am-6pm."), "Actual text content to verify JM Support How to Reach US: " + textOfReashUs_1);
            Assert.IsTrue(textOfReashUs_2.Equals("Reach us by phone, or email and we'll get back to you in the next couple business days."), "Actual text content to verify JM Support How to Reach US: " + textOfReashUs_2);
           
        }

        public void verifyJMSupportBar()
        {
            VerifyUIElementIsDisplayed(jmSupportHeader);

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

        public void verifyJMSupportMenuBar()
        {
            CommonPageElements cp = new CommonPageElements(driver);
            cp.verifyJMPGLogo();
            cp.verifyJMPGHelpDesk();
            cp.verifyJMPGProfile();
        }
    }
}

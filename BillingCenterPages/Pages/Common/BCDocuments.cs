using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace BillingCenterPages.Pages.Common
{
    public class BCDocuments : Page
    {


        [FindsBy(How = How.Id, Using = "AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentSearchDV:DocumentType-inputEl")]

        public IWebElement txtDocumentTypeName;

        [FindsBy(How = How.Id, Using = "AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentSearchDV:DateSearchCriteria:DateSearchCriteriaRangeChoice_Choice-inputEl")]

        public IWebElement rdgrpSearchbySince;

        [FindsBy(How = How.Id, Using = "AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentSearchDV:DateSearchCriteria:DateSearchCriteriaDirectChoice_Choice-inputEl")]

        public IWebElement rdgrpSearchbyFrom;

        [FindsBy(How = How.Id, Using = "AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentSearchDV:DateSearchCriteria:DateSearchCriteriaRangeValue-inputEl")]

        public IWebElement txtSinceOption;

        [FindsBy(How = How.Id, Using = "AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentSearchDV:DateSearchCriteria:DateSearchCriteriaStartDate-inputEl")]

        public IWebElement txtFromDate;

        [FindsBy(How = How.Id, Using = "AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentSearchDV:DateSearchCriteria:DateSearchCriteriaEndDate-inputEl")]

        public IWebElement txtTodate;


        [FindsBy(How = How.Id, Using = "AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search")]

        public IWebElement btnSearchDocument;

        string radSince = "input[id$=':DateSearchCriteriaRangeChoice_Choice-inputEl']";

        string radFrom = "input[id$=':DateSearchCriteriaDirectChoice_Choice-inputEl']";

        string documentRow1 = "span[id$=:NameLink']";

        public BCDocuments(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(radSince);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(radSince));
        }

        public void DocumentSearch(string DocumentTypeName, string SearchBy, string FromDate, string Todate, string SinceOption)

        {
            List<IWebElement> TableInputElements = driver.FindElements(By.ClassName("x-grid-item-container")).ToList();
            Console.WriteLine(TableInputElements.ToString());


            if (!string.IsNullOrEmpty(DocumentTypeName))
            {
                txtDocumentTypeName.Clear();
                txtDocumentTypeName.SendKeys(DocumentTypeName);
                pause();

            }
            if (SearchBy.Equals("Since"))
            {
                //   IJavaScriptExecutor js = (IJavaScriptExecutor)driver; 
                //  js.ExecuteScript("document.getElementById('" + rdgrpSearchbySince + "').checked=true"); 
                // rdgrpSearchbySince. 
                //  pause(); 
                UIAction(radSince, string.Empty, "radio");
                txtSinceOption.Clear();
                txtSinceOption.SendKeys(SinceOption);
                

            }
            else
            {
                // IJavaScriptExecutor js = (IJavaScriptExecutor)driver; 
                // js.ExecuteScript("document.getElementById('" + rdgrpSearchbyFrom + "').checked=true"); 
                // pause(); 
                UIAction(radFrom, string.Empty, "radio");
                txtFromDate.Clear();
                txtFromDate.SendKeys(FromDate);
                txtTodate.Clear();
                txtTodate.SendKeys(Todate);
            }

            btnSearchDocument.Click();
            pause();
            pause();
			pause();
			pause();
			pause();
			pause();


		}

        public void VerifyDocuments(string Documentsavailable)
        {
            bool isDocumentDisplayed = IsElementPresent(driver, By.CssSelector(documentRow1));
            Console.WriteLine("Expected is " + Documentsavailable);
            Console.WriteLine("Document is available " + isDocumentDisplayed);
            if (Documentsavailable.Equals("Yes"))
            {
                Console.WriteLine("Document should be available");
                if(isDocumentDisplayed)
                {
                    Console.WriteLine("Document is displayed which is expected");
                }
                else
                {
                    Console.WriteLine("Document is not displayed which is not expected");
                    //Assert.Fail("Documents are not displayed.");
                }
            }
            else
            {
                Console.WriteLine("Document should not be available");
                if (isDocumentDisplayed)
                {
                    Console.WriteLine("Document is displayed which is not expected");
                    //Assert.Fail("Documents are not displayed.");
                }
                else
                {
                    Console.WriteLine("Document is not displayed which is expected");
                   
                }

            }
        }
    }
}



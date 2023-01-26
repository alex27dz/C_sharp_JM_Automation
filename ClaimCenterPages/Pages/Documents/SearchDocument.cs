using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenterPages.Pages.CreateClaim
{
    public class SearchDocument : Page
    {
        string btnSearch = "span[id$=':Search_link']";

        string selDocumentType = "select[id$=':DocumentType']";

        string documentRow1 = "span[id$=':0:DocumentsLV_ViewLink_link']";

        string leftNavPartiesInvolved = "a[id$='MenuLinks:Claim_ClaimPartiesGroup']";



        public SearchDocument(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnSearch);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnSearch));
        }

        public void verifyDocument()
        {
            UIAction(selDocumentType, "Correspondence", "selectbox");

            UIAction(btnSearch, string.Empty, "a");

            bool isDocumentDisplayed = false;

            int i = 0;

            do
            {
                i++;

                UIAction(btnSearch, string.Empty, "a");
                System.Threading.Thread.Sleep(2000);
                isDocumentDisplayed = IsElementPresent(driver, By.CssSelector(documentRow1));

               

                if (i > 20)
                    break;

            } while (!isDocumentDisplayed);

            if (!isDocumentDisplayed)
                Assert.Fail("Documents are not displayed.");

            pause();

            UIAction(leftNavPartiesInvolved, string.Empty, "a");

            pause();
            pause();
            pause();
        }
       
        

    }
}

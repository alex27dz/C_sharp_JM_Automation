using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class SearchDocument_CC9 : Page
    {
        string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
		string txtDocumentType = "input[id$=':DocumentType-inputEl']";

        public SearchDocument_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnSearch);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnSearch));
        }

        public void verifyDocument()
        {
			UIActionExt(By.CssSelector(txtDocumentType), "List", "Correspondence");
			UIActionExt(By.CssSelector(btnSearch), "click");
			List<IWebElement> documenttableObj;
            bool isDocumentDisplayed = false;
            int i = 0;
            do
            {
                i++;
				UIActionExt(By.Id("ClaimDocuments:Claim_DocumentsScreen:DocumentsLV-body"), "ispresent");
				documenttableObj = driver.FindElement(By.Id("ClaimDocuments:Claim_DocumentsScreen:DocumentsLV-body")).FindElements(By.TagName("table")).ToList();
              
                if (documenttableObj.Count() > 0)
                {
                    isDocumentDisplayed = true;
                }
				UIActionExt(By.CssSelector(btnSearch), "click");
                if (i > 20)
                    break;

            } while (!isDocumentDisplayed);

            if (!isDocumentDisplayed)
                Assert.Fail("Documents are not displayed.");
			UIActionExt(By.XPath("//span[text()= 'Parties Involved']"), "click");
        }
    }
}

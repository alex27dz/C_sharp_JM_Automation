using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace BillingCenterPages.Pages.Documents
{
    public class Documents : Page
    {
        string radSince = "input[id$=':DateSearchCriteriaRangeChoice_Choice-inputEl']";

        string radFrom = "input[id$=':DateSearchCriteriaDirectChoice_Choice-inputEl']";

        //Followings for search document based on types      
        string btnSearchInputXpath = "//*[@id='AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";
        string documentTableXpath = "//*[@id='AccountDetailDocuments:AccountDetailDocumentsScreen:DocumentsLV-body']";

        public Documents(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
       //     SetActiveFrame();

            
        }

        public override void WaitForLoad()
        {
           // IsElementPresent(driver, By.CssSelector(lnkJeweleryStock));
        }

        public void SelectSearchByCriteria(string searchBy)
        {
            switch (searchBy.ToLower().Trim())
            {
                case "since":
                    UIAction(radSince, string.Empty, "radio");
                    pause();

                    break;
                case "from":
                    UIAction(radFrom, string.Empty, "radio");
                    pause();

                    break;
                default:
                    break;
            }

        }

        public void SearchDocumentType(string documentType)
        {
            string documentTypeName = "input[id$=':DocumentSearchDV:DocumentType-inputEl']";
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(documentTypeName), 15);
            }
            catch (Exception e)
            {
                Console.WriteLine("Known Exception: " + e);
            }
            if (IsElementPresent(driver, By.CssSelector(documentTypeName + "[value='<none>']")))
            {
                UIActionExt(By.CssSelector(documentTypeName), "Text", " ");
                UIActionExt(By.CssSelector(documentTypeName), "List", documentType);
            }
        }

        public void ClickSearchButton()
        {
            WaitFor(driver.FindElement(By.XPath(btnSearchInputXpath))).Click();
        }

        public void VerifyDocumentGenerated(string documentType)
        {
            bool find = false;
            IWebElement tableElement = driver.FindElement(By.XPath(documentTableXpath + "/div/div"));
            List<IWebElement> TrAsTableElements = new List<IWebElement>(tableElement.FindElements(By.TagName("table")));
            Console.WriteLine(" TrAsTableElements Count " + TrAsTableElements.Count());
            //System.Threading.Thread.Sleep(2000);
            for (int i = 0; i < TrAsTableElements.Count(); i++)
            {
                Console.WriteLine(i + " === " + TrAsTableElements[i].Text);
                string lineText = TrAsTableElements[i].Text;
                if (lineText.Trim().ToLower().Contains(documentType.ToLower()))
                {
                    find = true;
                }
            }
            if (!find)
            {
                Assert.Fail(documentType + " is not found");
            }
        }
    }
}

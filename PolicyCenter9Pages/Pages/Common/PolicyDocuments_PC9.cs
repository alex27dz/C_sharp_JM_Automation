using AutomationFramework;
using HelperClasses;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace PolicyCenter9Pages.Pages.Common
{
    public class PolicyDocuments_PC9 : Page
    {
        string lblPolicyDocument = "span[id$=':DocumentsScreen:ttlBar']";
        string txtDocumentType = "input[id$=':DocumentsScreen:DocumentSearchDV:DocumentType-inputEl']";
        string txtDateFrom = "input[id$=':DocumentsScreen:DocumentSearchDV:DateFrom-inputEl']";
        string txtDateto = "input[id$=':DocumentsScreen:DocumentSearchDV:DateTo-inputEl']";
        string btnSearch = "a[id$=':DocumentSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";

        public PolicyDocuments_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyDocument);
        }
        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyDocument));
        }

        public void DocumentSearchPC9(string DocumentTypeName, string FromDate, string Todate)
        {
            //driver.FindElement(By.CssSelector(txtDocumentType)).Clear();
            UIAction(txtDocumentType, String.Empty, "a");
            UIAction(txtDocumentType, DocumentTypeName, "textbox");

            if (FromDate.Length > 4)
            {
                UIAction(txtDateFrom, String.Empty, "a");
                UIAction(txtDateFrom, FromDate, "textbox");
            }

            if (Todate.Length > 4)
            {
                UIAction(txtDateto, String.Empty, "a");
                UIAction(txtDateto, Todate, "textbox");
            }

            UIAction(btnSearch, String.Empty, "a");

        }

        public void VerifyDocumentsPC9(int Documentsavailable)
        {
            // WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'Displaying']]"), 40);
            System.Threading.Thread.Sleep(4000);
            List<IWebElement> reservetableObj1;
            int tablecount = 0;
            reservetableObj1 = driver.FindElements(By.Id("AccountFile_Documents:DocumentsScreen:DocumentsLV-body")).ToList();
            var tableChild = reservetableObj1[0].FindElements(By.TagName("table"));
            tablecount = tableChild.Count();
            if (Documentsavailable == tablecount)
            {
                Console.WriteLine("Document Count match");
            }
            else
            {
                Assert.Fail("Document Count do not match");
            }

        }
    }
}

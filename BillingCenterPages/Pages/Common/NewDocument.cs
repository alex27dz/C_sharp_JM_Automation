using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace BillingCenterPages.Pages.Common
{
    public class NewDocument : Page
    {
        string lblNewDocument = "span[id$='wsTabBar:wsTab_0-btnInnerEl']";     
        string divSearchResulteXpath = "//*[@id='DocumentTemplateSearchPopup:DocumentTemplateSearchScreen:DocumentTemplateSearchResultsLV-body']";
        string templatePickerWrapXpath = "//*[@id='NewDocumentFromTemplateWorksheet:NewDocumentFromTemplateScreen:NewTemplateDocumentDV:TemplatePicker-triggerWrap']";
        string btnCreateDocument = "span[id$='NewDocumentFromTemplateWorksheet:NewDocumentFromTemplateScreen:NewTemplateDocumentDV:CreateDocument-btnInnerEl']";
        string btnSubmitDocument = "span[id$='NewDocumentFromTemplateWorksheet:NewDocumentFromTemplateScreen:NewTemplateDocumentDV:SubmitDocument-btnInnerEl']";

        public NewDocument(IWebDriver driver) : base(driver)
        {
            Console.WriteLine(" New Document page ..");
            pause();
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            Console.WriteLine(" New Document page verify..");
            VerifyUIElementIsDisplayed(lblNewDocument);
        }

        public override void WaitForLoad()
        {
            Console.WriteLine(" New Document page load..");
            IsElementPresent(driver, By.CssSelector(lblNewDocument));
        }

        public void GetSearchResults()
        {
            WaitFor(driver.FindElement(By.XPath(templatePickerWrapXpath + "/div[2]"))).Click();
        }

        public void SelectPaymentSchedule()
        {
            IWebElement planTable = driver.FindElement(By.XPath(divSearchResulteXpath));
            List<IWebElement> TrAsTableElements = new List<IWebElement>(planTable.FindElements(By.TagName("table")));
            Console.WriteLine(" TrAsTableElements Count " + TrAsTableElements.Count());
            for (int i = 0; i < TrAsTableElements.Count(); i++)
            {
                Console.WriteLine(i + " === " + TrAsTableElements[i].Text);
                string lineText = TrAsTableElements[i].Text;
                string aSelectBase = "a[id$='DocumentTemplateSearchScreen:DocumentTemplateSearchResultsLV:";
                if (lineText.Trim().ToLower().Contains("payment_schedule"))
                {
                    Console.WriteLine("Xpath: " + aSelectBase + i + ":_Select']");
                    WaitFor(driver.FindElement(By.CssSelector(aSelectBase + i + ":_Select']"))).Click();
                }
            }
        }

        public void ClickCreateDocumentButton()
        {
            WaitFor(driver.FindElement(By.CssSelector(btnCreateDocument))).Click();
        }

        public void ClickSubmitDocumentButton()
        {
            WaitFor(driver.FindElement(By.CssSelector(btnSubmitDocument))).Click();
        }
    }

}

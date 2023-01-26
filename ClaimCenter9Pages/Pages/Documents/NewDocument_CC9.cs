using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class NewDocument_CC9 : Page
    {
        string btnCancel = "a[id$=':NewDocumentFromTemplate_CustomCancel']";
		string selectTemplatePicker = "div[id$=':SelectTemplatePicker']";
        string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
        string txtKeywords = "input[id$=':Keywords-inputEl']";
        string btnSelect = "a[id$=':DocumentTemplateSearchResultLV:0:_Select']";
		string lstSendTo = "input[id$=':send_to-inputEl']";
        string btnCreateDocument = "span[id$='ClaimNewDocumentFromTemplateWorksheet:NewDocumentFromTemplateScreen:NewTemplateDocumentDV:CreateDocument-btnInnerEl']";
        string btnSubmitDocument = "span[id$=':NewTemplateDocumentDV:SubmitDocument-btnInnerEl']";

        public NewDocument_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnCancel);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnCancel));
        }

        public void CreateNewDocument(string ReportedName)
        {
			string lstSendTo = "input[id$=':NewTemplateDocumentDV:send_to-inputEl']";
			UIActionExt(By.CssSelector(selectTemplatePicker), "click");
			UIActionExt(By.CssSelector("a[id$=':Reset']"), "ispresent");
			UIActionExt(By.CssSelector("a[id$=':Reset']"), "click");
			UIActionExt(By.CssSelector(txtKeywords), "ispresent");
			UIActionExt(By.CssSelector(txtKeywords), "Text", "Agent_Loss_Notice");
			UIActionExt(By.CssSelector(btnSearch), "click");
			UIActionExt(By.CssSelector(btnSelect), "ispresent");
			UIActionExt(By.CssSelector(btnSelect), "click");
			if (ReportedName.ToUpper().Trim() == "INSURED")
			{
				UIActionExt(By.CssSelector(lstSendTo), "List", ScenarioContext.Current["INSURED"].ToString());
			}
			else
			{
				UIActionExt(By.CssSelector(lstSendTo), "List", ReportedName);
			}
			ScrollDownTillElement(driver, driver.FindElement(By.XPath("//span[text()= 'Create Document']")));
			UIActionExt(By.XPath("//span[text()= 'Create Document']"), "click");
			WaitUntilElementVisible(driver, By.CssSelector(btnSubmitDocument), 10);
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnSubmitDocument)));
			UIActionExt(By.CssSelector(btnSubmitDocument), "click");
        }

        public void SubmitNewDocument(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
				UIActionExt(By.CssSelector(selectTemplatePicker), "click");
				UIActionExt(By.CssSelector("a[id$=':Reset']"), "ispresent");
				UIActionExt(By.CssSelector("a[id$=':Reset']"), "click");
				UIActionExt(By.CssSelector(txtKeywords), "ispresent");
				UIActionExt(By.CssSelector(txtKeywords), "Text", table.Rows[i]["DocumentTemplate"]);
				UIActionExt(By.CssSelector(btnSearch), "click");
				UIActionExt(By.CssSelector(btnSelect), "ispresent");
				UIActionExt(By.CssSelector(btnSelect), "click");
                if (table.Rows[i]["SendTo"].ToUpper().Trim() == "INSURED")
                {
					UIActionExt(By.CssSelector(lstSendTo), "List", ScenarioContext.Current["INSURED"].ToString());
				}
				else
                {
					UIActionExt(By.CssSelector(lstSendTo), "List", table.Rows[i]["SendTo"]);
				}
				ScrollDownTillElement(driver, driver.FindElement(By.XPath("//span[text()= 'Create Document']")));
				UIActionExt(By.XPath("//span[text()= 'Create Document']"), "click");
                WaitUntilElementVisible(driver, By.CssSelector(btnSubmitDocument),10);
				ScrollDownTillElement(driver,driver.FindElement(By.CssSelector(btnSubmitDocument)));
				UIActionExt(By.CssSelector(btnSubmitDocument), "click");
			}
		}
	}
}

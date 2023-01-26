using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace BillingCenterPages.Pages.NewPayment
{
    public class DirectBillPayment : Page
    {
        //string btnExecute = "span[id$=':Update-btnInnerEl']";

        //string btnExecuteWODistribution = "span[id$=':ExecuteWithoutDistribution-btnInnerEl']";

        //string txtPaymentAmount = "input[id$=':Amount-inputEl']";

        public DirectBillPayment(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(btnExecute);
        }

        public override void WaitForLoad()
        {
            //IsElementPresent(driver, By.CssSelector(btnExecute));
        }

		public void NewDirectBillPayment(string PaymentAmount)
		{
			string tabDesktop = "span[id$='TabBar:DesktopTab-btnInnerEl']";
			string lnkActions = "span[id$='DesktopGroup:DesktopMenuActions-btnInnerEl']";
			string lnkNewPayment = "span[id$='DesktopGroup:DesktopMenuActions:DesktopMenuActions_NewPayment-textEl']";
			string lnkMultiPayment = "span[id$='DesktopGroup:DesktopMenuActions:DesktopMenuActions_NewPayment:DesktopMenuActions_MultiPaymentEntryWizard-textEl']";
			string lblMultiPayScreen = "span[id$='MultiPaymentEntryWizard:NewMultiPaymentScreen:ttlBar']";
			string tblReservesTableHeader = "div[id$='MultiPaymentEntryWizard:NewMultiPaymentScreen:NewMultiPaymentLV-body']";
			string btnMultiPayNext = "span[id$='MultiPaymentEntryWizard:Next-btnInnerEl']";
			string btnMultiPayFinish = "span[id$='MultiPaymentEntryWizard:Finish-btnInnerEl']";
			string tabSearch = "span[id$='TabBar:SearchTab-btnInnerEl']";
			string txtAccountNumber = "input[id$=':AccountNumberCriterion-inputEl']";
			string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
			string btnReset = "a[id$=':SearchLinksInputSet:Reset']";
			string accSearchResult = "a[id$=':0:AccountNumber']";
			string lblAcctDetailsPage = "span[id$='AccountDetailSummary:AccountDetailSummaryScreen:ttlBar']";

			UIActionExt(By.CssSelector(tabDesktop), "click");
			UIActionExt(By.CssSelector(lnkActions), "click");
			UIActionExt(By.CssSelector(lnkNewPayment), "ispresent");
			UIActionExt(By.CssSelector(lnkNewPayment), "click");
			//*[@id="DesktopGroup:DesktopMenuActions:DesktopMenuActions_NewPayment-itemEl"]
			driver.FindElement(By.XPath("//*[@id='DesktopGroup:DesktopMenuActions:DesktopMenuActions_NewPayment-itemEl']")).SendKeys(Keys.ArrowRight);
			UIActionExt(By.CssSelector(lnkMultiPayment), "click");
			UIActionExt(By.CssSelector(lblMultiPayScreen), "ispresent");

			InputTableValues(tblReservesTableHeader, "TextBox", 0, 0, 1, ScenarioContext.Current["ACCOUNT"].ToString(), "", "Account");
			InputTableValues(tblReservesTableHeader, "ListBox", 0, 0, 3, "Cash", "", "PaymentInstrument");
			InputTableValues(tblReservesTableHeader, "TextBox", 0, 0, 5, PaymentAmount, "", "Amount");
			UIActionExt(By.CssSelector(btnMultiPayNext), "click");
			UIActionExt(By.CssSelector(btnMultiPayFinish), "click");
			UIActionExt(By.CssSelector(tabSearch), "click");

			UIActionExt(By.CssSelector(btnReset), "ispresent");
			UIActionExt(By.CssSelector(btnReset), "click");
			UIActionExt(By.CssSelector(txtAccountNumber), "ispresent");
			UIActionExt(By.CssSelector(txtAccountNumber), "Text", ScenarioContext.Current["ACCOUNT"].ToString());
			UIActionExt(By.CssSelector(btnSearch), "click");
			UIActionExt(By.CssSelector(accSearchResult), "ispresent");
			UIActionExt(By.CssSelector(accSearchResult), "click");
			UIActionExt(By.CssSelector(lblAcctDetailsPage), "ispresent");
		}

		public void InputTableValues(string TblName, string ObjectName, int ObjectIndex, int RowIndex, int ColumnNumber, string sValue, string valueCondition, string inputName)
		{
			UIActionExt(By.CssSelector(TblName), "ispresent");
			List<IWebElement> TableHeader, PageInputElements;
			var TblHdr = driver.FindElement(By.CssSelector(TblName));
			TableHeader = TblHdr.FindElements(By.XPath(".//*")).ToList();
			string sTblHdrID = TableHeader[0].GetAttribute("id");
			var tblReserveRows = driver.FindElements(By.XPath("//table[@data-boundview='" + sTblHdrID + "']")).ToList();
			List<IWebElement> tblGetTdElements = new List<IWebElement>(tblReserveRows[RowIndex].FindElements(By.TagName("td")));
			switch (ObjectName.ToLower().Trim())
			{
				case "cleartextbox":
				case "textbox":
					JavaScriptClick(tblGetTdElements[ColumnNumber]);
					UIActionExt(By.CssSelector("input[name='" + inputName + "']"), "Text", sValue);
					break;
				case "listbox":
					JavaScriptClick(tblGetTdElements[ColumnNumber]);
					if (valueCondition.ToLower() == "contains")
					{
						UIActionExt(By.XPath("//li[text()[contains(.,'" + sValue + "')]]"), "ispresent");
						PageInputElements = driver.FindElements(By.XPath("//li[text()[contains(.,'" + sValue + "')]]")).ToList();
					}
					else
					{
						UIActionExt(By.XPath("//li[text()='" + sValue + "']"), "ispresent");
						PageInputElements = driver.FindElements(By.XPath("//li[text()='" + sValue + "']")).ToList();
					}
					PageInputElements[ObjectIndex].Click();
					break;
				default:
					break;
			}
		}
	}
}

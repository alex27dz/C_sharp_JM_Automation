using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClaimCenter9.Pages.Recovery
{
	public class Recovery_CC9 : Page
	{

		string btnCancel = "span[id='ClaimRecoveryDetailRequestWizard:Cancel-btnInnerEl']";
		string btnNext = "span[id='ClaimRecoveryDetailRequestWizard:Next-btnInnerEl']";
		string btnClose = "span[id='ClaimRecoveryDetailRequestWizard:PaymentusPaymentRequestScreen:ToolbarButton-btnInnerEl']";
		public Recovery_CC9(IWebDriver driver) : base(driver)
		{
			WaitForPageLoad(driver);
		}
		public override void VerifyPage()
		{

		}
		public override void WaitForLoad()
		{
			WaitUntilElementVisible(driver, By.CssSelector(btnCancel));
		}

		public void AddRecovery(Table table)
		{
			string lstRecoveryCategory = "input[id$=':RecoveryDetailDV:RecoveryCategory-inputEl']";
			string txtComments = "input[id$=':RecoveryDetailDV:Comments-inputEl']";
			string lstPayer = "input[id$=':RecoveryDetailDV:Payer-inputEl']";
			string lstReserveLine = "input[id$=':RecoveryDetailDV:ReserveLineInputSet:ReserveLine-inputEl']";
			string lstPaymentMethod = "input[id$=':RecoveryDetailDV:PaymentMethod-inputEl']";
			string tblRecovery = "div[id$=':RecoveryDetailDV:EditableRecoveryLineItemsLV-body']";

			string txtFirstName = "input[id='customer.firstName']";
			string txtLastName = "input[id='customer.lastName']";
			string txtPaymentAmount = "input[id='header.paymentAmount']";
			string txtZipCode = "input=[id='customer.address.zipCode']";
			string txtEmail = "input[id='customer.email']";
			string txtClaimNumber = "input[id='header.accountNumber']";
			string txtReEneterEmail = "input[id='customer.email2']";
			string btnIContinue = "input[class$='btn-action']";
			string txtCCNumber = "input[id$='ccAccountNumber']";
			string txtCCCvv = "input[id$='ccCvv']";
			string selectCCExpMonth = "select[id$='ccExpiryDateMonth']";
			string selectCCExpYear = "select[id$='ccExpiryDateYear']";
			string txtCCHolderName = "input[id$='ccCardHolderName']";
			string submitApplication = "a[id$='make-payment-btn']";
			string btnPrint = "a[class='btn-action btn-print']";

			string lstTransactions = "input[id$=':TransactionsLVRangeInput-inputEl']";
			string tblRecover = "div[id$=':ClaimFinancialsTransactionsScreen:TransactionsLV-body']";
			for (int i = 0; i <= table.RowCount - 1; i++)
			{
				SelectCSSListBox(lstRecoveryCategory, "text", table.Rows[i]["RecoveryCategory"], 0, "");
				UIActionExt(By.CssSelector(txtComments), "Text", table.Rows[i]["Comments"]);
				if (table.Rows[i]["Payer"].ToUpper().Trim() == "INSURED")
				{
					SelectCSSListBox(lstPayer, "text", ScenarioContext.Current["INSURED"].ToString(), 0, "");
				}
				else
				{
					SelectCSSListBox(lstPayer, "text", table.Rows[i]["Payer"], 0, "");
				}
				SelectCSSListBox(lstReserveLine, "text", table.Rows[i]["Reserveline"], 0, "contains");
				SelectCSSListBox(lstPaymentMethod, "text", table.Rows[i]["PaymentMethod"], 0, "");
				InputTableValues(tblRecovery, "TextBox", 0, 0, 2, table.Rows[i]["Amount"], "","Amount");
				UIActionExt(By.CssSelector(btnNext), "click");
				UIActionExt(By.CssSelector(btnClose), "ispresent");
				switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
				{
					case "stage":
						driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='inetframe']")));
						WaitUntilElementVisible(driver, By.CssSelector(btnIContinue));
						var claimNumber = ScenarioContext.Current["CLAIM"];
						UIActionExt(By.CssSelector(txtClaimNumber), "Text", claimNumber.ToString());
						UIActionExt(By.CssSelector(txtEmail), "Text", table.Rows[i]["Email"]);
						UIActionExt(By.CssSelector(txtReEneterEmail), "Text", table.Rows[i]["Email"]);
						UIActionExt(By.CssSelector(btnIContinue), "click");
						UIActionExt(By.CssSelector(txtCCNumber), "ispresent");
						var element = driver.FindElement(By.Id("customer.address.zipCode"));
						Actions actions = new Actions(driver);
						actions.MoveToElement(element);
						actions.Perform();
						element.SendKeys("54965");
						//UIActionExt(By.CssSelector(txtFirstName), "Text", "firsName");
						//UIActionExt(By.CssSelector(txtLastName), "Text", "lastName");
						UIActionExt(By.CssSelector(txtPaymentAmount), "Text", "125.00");
						UIActionExt(By.CssSelector(txtCCNumber), "Text", table.Rows[i]["Credit_Card_No"]);
						UIActionExt(By.CssSelector(txtCCCvv), "Text", table.Rows[i]["CVV"]);

						UIActionExt(By.CssSelector(selectCCExpMonth), "ispresent");

						List<IWebElement> SelectCCExpMonth = driver.FindElements(By.CssSelector(selectCCExpMonth)).ToList();
						SelectCCExpMonth[0].Click();
						SelectByText(SelectCCExpMonth[0], table.Rows[i]["ExpiryDateMonth"]);
						UIActionExt(By.CssSelector(selectCCExpYear), "ispresent");

						List<IWebElement> SelectCCExpYear = driver.FindElements(By.CssSelector(selectCCExpYear)).ToList();
						SelectCCExpYear[0].Click();
						SelectByText(SelectCCExpYear[0], table.Rows[i]["ExpiryDateYear"]);

						UIActionExt(By.CssSelector(txtCCHolderName), "Text", table.Rows[i]["Card_Holder_Name"]);
					
						//UIActionExt(By.CssSelector(txtZipCode), "Text", "54965");
						UIActionExt(By.CssSelector(btnIContinue), "click");
						UIActionExt(By.XPath("//span[text()='I authorize payment and agree to the Payment Authorization Terms']"), "ispresent");
						UIActionExt(By.XPath("//span[text()='I authorize payment and agree to the Payment Authorization Terms']"), "Click");

						//List<IWebElement> AuthorizePayment = driver.FindElements(By.XPath("//input[@id='acceptTermsAndConditions-1'][@type='checkbox']")).ToList();
						//JavaScriptClick(AuthorizePayment[0]);
						//Console.WriteLine("Payment Checkbox: " + AuthorizePayment.Count);
						UIActionExt(By.CssSelector(submitApplication), "ispresent");
						UIActionExt(By.CssSelector(submitApplication), "click");
						WaitUntilElementVisible(driver, By.CssSelector(btnPrint));
						driver.SwitchTo().DefaultContent();
						UIAction(btnClose, string.Empty, "a");
						SelectCSSListBox(lstTransactions, "text", "Recovery Reserves", 0, "");
						WaitUntilElementInvisible(driver, By.CssSelector(btnIContinue),5);

						List<IWebElement> RecoveryTable = driver.FindElements(By.CssSelector(tblRecover)).ToList();
						if (RecoveryTable.Count > 0)
						{
							Console.WriteLine("Recovery Table exists");
						}
						else
						{
							Assert.Fail("Recovery Table doen't exists");
						}
						break;
					default:
						UIActionExt(By.CssSelector(btnClose), "click");
						break;
				}
			}

		}
		public void SelectCSSListBox(string CSS, string Valuetype, string sValue, int index, string valueCondition)
		{
			List<IWebElement> PageInputElements;
			UIActionExt(By.CssSelector(CSS), "click", "", index);
			switch (Valuetype.ToLower().Trim())
			{
				case "index":
					UIActionExt(By.TagName("li"), "ispresent");
					PageInputElements = driver.FindElements(By.TagName("li")).ToList();
					JavaScriptClick(PageInputElements[index]);
					break;
				case "text":
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
					JavaScriptClick(PageInputElements[index]);
					break;
				default:
					break;
			}
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
					tblGetTdElements[ColumnNumber].Click();
					tblGetTdElements[ColumnNumber].SendKeys(Keys.Enter);
					UIActionExt(By.CssSelector("input[name='" + inputName + "']"), "Text", sValue);
					driver.FindElement(By.CssSelector("input[name='" + inputName + "']")).SendKeys(Keys.LeftShift + Keys.Tab);
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

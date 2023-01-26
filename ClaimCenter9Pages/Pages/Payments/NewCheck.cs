using HelperClasses;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class NewCheck_CC9 : Page
    {

        string btnCancel = "a[id$=':Cancel']";
        string btnNext = "a[id$=':Next']";
        string btnFinish = "a[id$=':Finish']";

		string txtPrimaryPayeeName = "input[id$=':PrimaryPayee_Name-inputEl']";
		string txtPrimaryPayeeType = "input[id$=':PrimaryPayee_Type-inputEl']";
		string txtReserveLineCategory = "input[id$=':tempLineCategory-inputEl']";
		string txtAddtoDeductible = "input[id$=':deductible_amount-inputEl']";
		string txtReserveLine = "input[id$=':ReserveLineInputSet:ReserveLine-inputEl']";
		string txtPaymentType = "input[id$=':NewPaymentDetailDV:Payment_PaymentType-inputEl']";
		string radioDeductibleYes="input[id$=':Deductible_Applies_true-inputEl']";
		string radioDeductibleNo = "input[id$=':Deductible_Applies_false-inputEl']";
		public NewCheck_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnCancel);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//a[id$=':Cancel']"));
        }

        public void EnterPayeeInformation(string Name, string Type)
        {
			UIActionExt(By.CssSelector(txtPrimaryPayeeName), "ispresent");
			UIActionExt(By.CssSelector(txtPrimaryPayeeName), "List", Name);
			UIActionExt(By.CssSelector(txtPrimaryPayeeType), "ispresent");
			UIActionExt(By.CssSelector(txtPrimaryPayeeType), "List", Type);
			UIActionExt(By.CssSelector(btnNext), "click");
		}

        public void EnetrPaymentInformation(string ReserveLineCategory, string ReserveLine, string PaymentType, string AddtoDeductible, string Amount)
        {
            DataStorage temp = new DataStorage();
            string policyNum = temp.GetTempValue("PLCYNO");
            WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$=':NewCheckPaymentPanelSet:NewPaymentDetailDV:tempLineCategory-inputEl']"));
			UIActionExt(By.CssSelector(txtReserveLineCategory), "List", ReserveLineCategory);
			UIActionExt(By.CssSelector(txtReserveLine), "List", ReserveLine);
			UIActionExt(By.CssSelector(txtPaymentType), "List", PaymentType);
            if (AddtoDeductible.ToLower().Trim().Equals("no"))
            {
				UIActionExt(By.CssSelector(radioDeductibleNo), "click");
			}
			else
            {
				UIActionExt(By.CssSelector(radioDeductibleYes), "click");
                WaitUntilElementIsDisplayed(driver, By.XPath("//label[id$='NormalCreateCheckWizard:CheckWizard_CheckPaymentsScreen:NewCheckPaymentPanelSet:NewPaymentDetailDV:deductible_amount-inputEl']"));
				UIActionExt(By.CssSelector(txtAddtoDeductible), "List", AddtoDeductible);
             }
			string catagoryTable = "div[id$='NormalCreateCheckWizard:CheckWizard_CheckPaymentsScreen:NewCheckPaymentPanelSet:NewPaymentDetailDV:EditablePaymentLineItemsLV-body']";
			InputTableValues(catagoryTable, "TextBox", 0, 0, 2, Amount, "", "Amount");
        }

        public void SetCheckInstructions()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[id$='NormalCreateCheckWizard:Finish-btnInnerEl']"));
            UIAction(btnFinish, string.Empty, "a");

        }


		public void EnterPLPaymentInformation(Table table)
		{
			string primaryPayeeName = "input[id$=':NewCheckPayeeDV:PrimaryPayee_Name-inputEl']";
			string primaryPayeeType = "input[id$=':NewCheckPayeeDV:PrimaryPayee_Type-inputEl']";
			string templineCategory = "input[id$=':NewPaymentDetailDV:ReserveLine_JMInputSet:ReserveLineCategory-inputEl']";
			string reserveLine = "input[id$=':NewPaymentDetailDV:ReserveLine_JMInputSet:ReserveLine-inputEl']";
			string paymentType = "input[id$=':NewPaymentDetailDV:Payment_PaymentType-inputEl']";
			string catagoryTable = "div[id$='NormalCreateCheckWizard:CheckWizard_CheckPaymentsScreen:NewCheckPaymentPanelSet:NewPaymentDetailDV:EditablePaymentLineItemsLV-body']";
			string btnFinish = "span[id='NormalCreateCheckWizard:Finish-btnInnerEl']";
			string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";
			string actionMenuArrow = "a[id$=':ClaimMenuActions']";
			string menuItemCheck = "a[id$='ClaimMenuActions_NewTransaction_CheckSet-itemEl']";
			for (int i = 0; i <= table.RowCount - 1; i++)
			{
				WaitUntilElementVisible(driver, By.CssSelector(primaryPayeeName));
				if (table.Rows[i]["PrimaryPayeeName"].ToUpper().Trim() == "INSURED")
				{
					SelectCSSListBox(primaryPayeeName, "text", ScenarioContext.Current["INSURED"].ToString(), 0, "");
				}
				else
				{
					SelectCSSListBox(primaryPayeeName, "text", table.Rows[i]["PrimaryPayeeName"], 0, "");
				}
				SelectCSSListBox(primaryPayeeType, "text", table.Rows[i]["PrimaryPayeeType"], 0, "");
				UIAction(btnNext, string.Empty, "a");
				SelectCSSListBox(reserveLine, "text", table.Rows[i]["ReserveLine"], 0, "contains");
				SelectCSSListBox(templineCategory, "text", table.Rows[i]["ReserveLineCategory"], 0, "");
				SelectCSSListBox(paymentType, "text", table.Rows[i]["PaymentType"], 0, "");

				if (table.Rows[i]["AddtoDeductible"].ToLower().Trim().Equals("no"))
				{
					UIActionExt(By.CssSelector(radioDeductibleNo), "click");
				}
				else
				{
					UIActionExt(By.CssSelector(radioDeductibleYes), "click");
					WaitUntilElementIsDisplayed(driver, By.XPath("//label[id$='NormalCreateCheckWizard:CheckWizard_CheckPaymentsScreen:NewCheckPaymentPanelSet:NewPaymentDetailDV:deductible_amount-inputEl']"));
					UIActionExt(By.CssSelector(txtAddtoDeductible), "List", "100");
				}
				InputTableValues(catagoryTable, "TextBox", 0, 0, 2, table.Rows[i]["Amount"], "", "Amount");
				UIActionExt(By.CssSelector(btnNext), "click");
				UIActionExt(By.CssSelector(btnFinish), "click");
				WaitUntilElementInvisible(driver, By.CssSelector(primaryPayeeName),5);
				List<IWebElement> IWbtnClear = driver.FindElements(By.CssSelector(btnClear)).ToList();
				if (IWbtnClear.Count > 0)
				{
					IWbtnClear[0].Click();
					pause();
					UIAction(btnFinish, string.Empty, "a");
				}
				
				if (i < table.RowCount - 1)
				{
					UIActionExt(By.CssSelector(actionMenuArrow), "ispresent");
					UIActionExt(By.CssSelector(actionMenuArrow), "click");
					UIActionExt(By.CssSelector(menuItemCheck), "ispresent");
					UIActionExt(By.CssSelector(menuItemCheck), "click");
				}
			}

		}

		public void EnterCLPaymentInformation(Table table)
        {
            string primaryPayeeName = "input[id$=':NewCheckPayeeDV:PrimaryPayee_Name-inputEl']";
            string primaryPayeeType = "input[id$=':NewCheckPayeeDV:PrimaryPayee_Type-inputEl']";
            string templineCategory = "input[id$=':NewPaymentDetailDV:ReserveLine_JMInputSet:ReserveLineCategory-inputEl']";
            string reserveLine = "input[id$=':NewPaymentDetailDV:ReserveLine_JMInputSet:ReserveLine-inputEl']";
            string paymentType = "input[id$=':NewPaymentDetailDV:Payment_PaymentType-inputEl']";
            string catagoryTable = "div[id$=':NewPaymentDetailDV:LineItemsCL:EditablePaymentLineItemsCLLV-body']";
            string btnFinish = "span[id='NormalCreateCheckWizard:Finish-btnInnerEl']";
            string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";
            string actionMenuArrow = "a[id$=':ClaimMenuActions']";
            string menuItemCheck = "a[id$='ClaimMenuActions_NewTransaction_CheckSet-itemEl']";
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                WaitUntilElementVisible(driver, By.CssSelector(primaryPayeeName));
                if (table.Rows[i]["PrimaryPayeeName"].ToUpper().Trim() == "INSURED")
                {
                    SelectCSSListBox(primaryPayeeName, "text", ScenarioContext.Current["INSURED"].ToString(), 0, "");
                }
                else
                {
                    SelectCSSListBox(primaryPayeeName, "text", table.Rows[i]["PrimaryPayeeName"], 0, "");
                }
                SelectCSSListBox(primaryPayeeType, "text", table.Rows[i]["PrimaryPayeeType"], 0, "");
				UIActionExt(By.CssSelector(btnNext), "click");
				SelectCSSListBox(reserveLine, "text", table.Rows[i]["ReserveLine"], 0, "contains");
				SelectCSSListBox(templineCategory, "text", table.Rows[i]["ReserveLineCategory"], 0, "");
				SelectCSSListBox(paymentType, "text", table.Rows[i]["PaymentType"], 0, "");
				InputTableValues(catagoryTable, "TextBox", 0, 0, 2, table.Rows[i]["Amount"], "", "Amount");

				UIActionExt(By.CssSelector(btnNext), "click");
				UIActionExt(By.CssSelector(btnFinish), "click");
				WaitUntilElementInvisible(driver, By.CssSelector(primaryPayeeName), 5);
				List<IWebElement> IWbtnClear = driver.FindElements(By.CssSelector(btnClear)).ToList();
				if (IWbtnClear.Count > 0)
				{
					IWbtnClear[0].Click();
					UIActionExt(By.CssSelector(btnFinish), "click");
				}
				WaitUntilElementVisible(driver,By.CssSelector("span[id$=':ClaimFinancialsSummaryScreen:ttlBar']"),30);
				if (i < table.RowCount - 1)
                {
					UIActionExt(By.CssSelector(actionMenuArrow), "click");
					UIActionExt(By.CssSelector(menuItemCheck), "click");
				}
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

    }
}

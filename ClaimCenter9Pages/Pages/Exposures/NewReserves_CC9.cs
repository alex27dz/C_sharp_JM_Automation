using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class NewReserves_CC9 : Page
    {
        string tblReservesTableHeader = "div[id$=':ReservesSummaryDV:EditableReservesLV-body']";
        string btnSave = "span[id$=':NewReserveSetScreen:Update-btnInnerEl']";
		string btnRemove = "span[id$=':NewReserveSetScreen:Remove-btnInnerEl']";
		string btnAdd = "span[id$=':NewReserveSetScreen:Add-btnInnerEl']";
		public NewReserves_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
        }

        public override void WaitForLoad()
        {
        }

        public void CreateReserves()
        {
			UIActionExt(By.XPath("//div[@class='x-grid-checkcolumn']"), "ispresent");
            List<IWebElement> selectAll = driver.FindElements(By.XPath("//div[@class='x-grid-checkcolumn']")).ToList();
            JavaScriptClick(selectAll[0]);
			UIActionExt(By.XPath("//span[text()= 'Create Re']"), "ispresent");
			UIActionExt(By.XPath("//span[text()= 'Create Re']"), "click");
        }

        public void ClickSaveReserveButton()
        {
			UIActionExt(By.XPath("//span[text()= 'Save']"), "ispresent");
			UIActionExt(By.XPath("//span[text()= 'Save']"), "click");
		}

        public void ClickAddReserveButton()
        {
			UIActionExt(By.XPath("//span[text()= 'A']"), "ispresent");
			UIActionExt(By.XPath("//span[text()= 'A']"), "click");
		}

        public void RemoveAllReserves()
        {
            List<IWebElement> ReserveTableHeaderElements;
            List<IWebElement> ReserveTableHeaderSubElements;
			UIActionExt(By.CssSelector(tblReservesTableHeader), "ispresent");
			var TblHdr = driver.FindElement(By.CssSelector(tblReservesTableHeader));
            ReserveTableHeaderElements = TblHdr.FindElements(By.XPath(".//*")).ToList();
            Console.WriteLine("Header lower elements: " + ReserveTableHeaderElements.Count);
            string sTblHdrID = ReserveTableHeaderElements[0].GetAttribute("id");
            Console.WriteLine("Header lower elements componentId: " + sTblHdrID);
            ReserveTableHeaderSubElements = driver.FindElements(By.XPath("//table[@data-boundview='" + sTblHdrID + "']")).ToList();
            Console.WriteLine("Current Table row count " + ReserveTableHeaderSubElements.Count());
            List<IWebElement> SelectReserve = ReserveTableHeaderSubElements[0].FindElements(By.XPath("//div[@class='x-grid-checkcolumn']")).ToList();
            JavaScriptClick(SelectReserve[0]);
            WaitUntilElementVisible(driver, By.CssSelector(btnRemove));
			UIActionExt(By.CssSelector(btnRemove), "click");
        }
        public void SetReserves(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
				UIActionExt(By.CssSelector(btnAdd), "click");
			}
			for (int i = 0; i <= table.RowCount - 1; i++)
            {
                InputTableValues(tblReservesTableHeader, "ListBox", 0, i, 1, table.Rows[i]["Exposure"], "contains","");
                InputTableValues(tblReservesTableHeader, "TextBox", 0, i, 3, table.Rows[i]["Reserve"], "", "CostType");
                InputTableValues(tblReservesTableHeader, "TextBox", 0, i, 4, table.Rows[i]["ReserveCategory"], "", "CostCategory");
                InputTableValues(tblReservesTableHeader, "TextBox", 0, i, 7, table.Rows[i]["NewAvailableReserves"], "", "NewAmount");
            }
        }

        public void UpdateReserves(Table table)
        {
			List<IWebElement> PageInputElements;
			UIActionExt(By.CssSelector("a[id$=':ReserveOverrideButton']"),"ispresent");
			PageInputElements = driver.FindElements(By.CssSelector("a[id$=':ReserveOverrideButton']")).ToList();
			if (PageInputElements.Count() > 0)
			{
				for (int i = 0; i < PageInputElements.Count() - 1; i++)
				{
					UIActionExt(By.CssSelector("a[id$='" + i + ":ReserveOverrideButton']"), "click");
				}
			}
			for (int i = 0; i <= table.RowCount - 1; i++)
            {
                if (table.Rows[i]["ReserveCategory"].ToLower().Trim() == "indemnity category")
                {
                    InputTableValues(tblReservesTableHeader, "ClearTextBox", 0, 0, 7, table.Rows[i]["NewAvailReserves"], "", "NewAmount");
                }
                else if (table.Rows[i]["ReserveCategory"].ToLower().Trim() == "a&o expense")
                {
                    InputTableValues(tblReservesTableHeader, "ClearTextBox", 0, 2, 7, table.Rows[i]["NewAvailReserves"], "", "NewAmount");
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
		public void SaveReserves()
        {
			UIActionExt(By.CssSelector(btnSave), "click");

			List<IWebElement> btnClearList = driver.FindElements(By.XPath("//span[@id='WebMessageWorksheet:WebMessageWorksheetScreen:WebMessageWorksheet_ClearButton-btnInnerEl']")).ToList();
            if (btnClearList.Count > 0)
                btnClearList[0].Click();
        }


		//public void SetReserveValue(string value, string Parameter, int counter)
		//{

		//    List<IWebElement> reservetableObj = driver.FindElement(By.Id("NewReserveSet:NewReserveSetScreen:ReservesSummaryDV:EditableReservesLV-body")).FindElements(By.TagName("table")).ToList();
		//    Console.WriteLine("table object count is " + reservetableObj.Count());
		//    var rows = reservetableObj[reservetableObj.Count()-2].FindElements(By.TagName("tr"));
		//    Console.WriteLine("Row count is " + rows.Count());
		//    var tds = rows[0].FindElements(By.TagName("td"));
		//    Console.WriteLine("cell count is " + tds.Count());

		//    switch (Parameter.ToLower().Trim())
		//    {
		//        case "costtype":
		//            tds[0].Click();
		//            Console.WriteLine("in CostTYpe");
		//            tds[3].Click();
		//            Actions action = new Actions(driver);
		//            action.SendKeys(Keys.Control + "a").Build().Perform();
		//            action.SendKeys(Keys.Delete).Build().Perform();
		//            pause();
		//            action.SendKeys(value).Build().Perform();
		//            pause();
		//            pause();

		//            break;
		//        case "costcategory":
		//            Console.WriteLine("in CostCategory");
		//            tds[4].Click();
		//            Actions action1 = new Actions(driver);
		//            pause();
		//            action1.SendKeys(value).Build().Perform();
		//            action1.SendKeys(Keys.Tab).Build().Perform();
		//            pause();
		//            pause();
		//            break;
		//        case "newavailablereserves":

		//            Console.WriteLine("in newavailablereserves value is " + value);
		//            tds[7].Click();
		//            pause();
		//            Actions action3 = new Actions(driver);
		//            action3.SendKeys(value).Build().Perform();
		//            pause();
		//            pause();
		//            tds[0].Click();
		//            break;
		//        default:
		//            break;
		//    }


		//}

		//public void SetReserves(string CostType, string CostCategory, string NewAvailableReserves, int counter)
		//{
		//    List<IWebElement> reservetableObj1 = driver.FindElement(By.Id("NewReserveSet:NewReserveSetScreen:ReservesSummaryDV:EditableReservesLV-body")).FindElements(By.TagName("table")).ToList();
		//    Console.WriteLine("table object count is " + reservetableObj1.Count());
		//    pause();
		//    Console.WriteLine("for counter " + counter + " CostType is " + CostType);
		//    SetReserveValue(CostType, "CostType", counter);
		//    pause();
		//    Console.WriteLine("for counter " + counter + " CostCategory is " + CostCategory);
		//    SetReserveValue(CostCategory, "CostCategory", counter);
		//    pause();
		//    pause();
		//    Console.WriteLine("for counter " + counter + " NewAvailableReserves is " + NewAvailableReserves);
		//    SetReserveValue(NewAvailableReserves, "NewAvailableReserves", counter);
		//    System.Threading.Thread.Sleep(3000);

		//}
	}
}

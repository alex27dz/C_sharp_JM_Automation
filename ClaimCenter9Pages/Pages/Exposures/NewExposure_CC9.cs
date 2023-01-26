using OpenQA.Selenium;
using WebCommonCore;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class NewExposure_CC9 : Page
    {
        string btnCreateExposure = "span[id$='ClaimExposures:ClaimExposuresScreen:ToolbarButton-btnInnerEl']";
        string btnUpdate = "span[id$='NewExposure:NewExposureScreen:Update-btnInnerEl' ]";
        string btnExpanAllExposure = "span[id$='NewExposureMenu_EX_Popup:NewExposureMenuPopUpScreen:NewExposureMenuTreePanelSet_tb:Expand-btnInnerEl']";

        public NewExposure_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnExpanAllExposure);
        }
        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnExpanAllExposure));
        }
        public void CreateExposures(string ExposureType)
        {
			UIActionExt(By.XPath("//a[text()= '" + ExposureType + "' ]"), "ispresent");
			UIActionExt(By.XPath("//a[text()= '" + ExposureType + "' ]"), "click");
			UIActionExt(By.CssSelector(btnUpdate), "ispresent");
			UIActionExt(By.CssSelector(btnUpdate), "click");
			UIActionExt(By.CssSelector(btnCreateExposure), "ispresent");
			UIActionExt(By.CssSelector(btnCreateExposure), "click");
        }

        public void ReturntoExposures()
        {
			UIActionExt(By.XPath("//a[text()= 'Return to Exposures']"), "ispresent");
			UIActionExt(By.XPath("//a[text()= 'Return to Exposures']"), "click");
		}

		public void CreateExposures(Table table)
		{
			UIActionExt(By.XPath("//a[text()= '" + table.Rows[0]["ExposureType"] + "' ]"), "ispresent");
			UIActionExt(By.XPath("//a[text()= '" + table.Rows[0]["ExposureType"] + "' ]"), "click");
			if (table.Rows[0]["ExposureType"].ToString() == "Unscheduled Jewelry Item")
			{
				string UnSchJewelryDown = "a[id$=':unscheduled_jewelry_incident:unscheduled_jewelry_incidentMenuIcon']";
				string NewIncident = "a[id$=':unscheduled_jewelry_incident:JPAContentsDamageDV_NewIncidentMenuItem-itemEl']";
				string lblPersonalProp = "span[id$='NewJPAUnscheduledPropertyIncidentPopup:NewUnscheduledPropertyIncidentScreen:0']";
				string UnSchArticleTable = "div[id$='NewJPAUnscheduledPropertyIncidentPopup:NewUnscheduledPropertyIncidentScreen:unscheduledLV-body']";
				string btnOK = "span[id$=':Update-btnInnerEl']";
				string lblUnSchExp = "span[id$='NewExposure:NewExposureScreen:ttlBar']";
				UIActionExt(By.CssSelector(UnSchJewelryDown), "ispresent");
				UIActionExt(By.CssSelector(UnSchJewelryDown), "click");
				UIActionExt(By.CssSelector(NewIncident), "ispresent");
				UIActionExt(By.CssSelector(NewIncident), "click");
				UIActionExt(By.CssSelector(lblPersonalProp), "ispresent");
				InputTableValues(UnSchArticleTable, "ListBox", 0, 0, 1, table.Rows[0]["ArticleType"], "", "article");
				InputTableValues(UnSchArticleTable, "ListBox", 0, 0, 3, table.Rows[0]["Gender"], "", "gender");
				InputTableValues(UnSchArticleTable, "TextBox", 0, 0, 4, table.Rows[0]["Value"], "", "value");
				UIActionExt(By.CssSelector(btnOK), "click");
				UIActionExt(By.CssSelector(lblUnSchExp), "ispresent");
			}

			UIActionExt(By.CssSelector(btnUpdate), "ispresent");
			UIActionExt(By.CssSelector(btnUpdate), "click");
			UIActionExt(By.CssSelector(btnCreateExposure), "ispresent");
			UIActionExt(By.CssSelector(btnCreateExposure), "click");
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


using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_JewelryStock_PC9 : Page
	{
		string lnkJweleryStock;
		string radioCompInvTrue = "input[id$=':CompleteInventory_true-inputEl']";
		string txtRecentInv = "input[id$=':LastInvTotal-inputEl']";
		string txtTakenOn = "input[id$=':LastInvDate-inputEl']";
		string txtMaxStockVal = "input[id$=':MaxStockValue-inputEl']";
		string radioMaintainRecordsTrue = "input[id$=':IsCustPropertyRecorded_true-inputEl']";
		string txtAvgCust = "input[id$=':CustomerPropertyAvg-inputEl']";
		string txtAvgMemo = "input[id$=':ConsignmentPropertyAvg-inputEl']";
		string divLooseDiamonds = "div[id$=':ILMJewelryStock_JMICPropertyCategoryLV-body']";
		string txtLooseDiamonds = "input[name='PercentOfTotal']";
		string lnkTabCoverages = "span[id$=':CoveragesTab-btnInnerEl']";
		string txtStockAOPLimit = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:0:StockAOPLimit-inputEl']";
		string btnOK = "span[id$=':Update-btnInnerEl']";
		string btnILMAddLocation = "span[id$=':addLocationsOrBuildingsTB-btnInnerEl']";

		public void EnterJewelryStockInfo(Table table)
		{
			for (int i = 0; i <= table.Rows.Count() - 1; i++)
			{
				lnkJweleryStock = "a[id$=':" + (Convert.ToInt16(table.Rows[i]["Loc"]) - 1) + ":StockDescription'";
				UIActionExt(By.CssSelector(lnkJweleryStock), "click");
				UIActionExt(By.CssSelector(radioCompInvTrue), "ispresent");
				UIActionExt(By.CssSelector(radioCompInvTrue), "click");
				UIActionExt(By.CssSelector(txtRecentInv), "Text", table.Rows[i]["RecentInventry"]);
				UIActionExt(By.CssSelector(txtTakenOn), "Text", table.Rows[i]["TakenOn"]);
				UIActionExt(By.CssSelector(txtMaxStockVal), "Text", table.Rows[i]["MaxStockValue"]);
				UIActionExt(By.CssSelector(radioMaintainRecordsTrue), "click");
				UIActionExt(By.CssSelector(txtAvgCust), "Text", table.Rows[i]["AvgAmtCustProp"]);
				UIActionExt(By.CssSelector(txtAvgMemo), "Text", table.Rows[i]["AvgAmtMemo"]);
				var PropCategoryTable = driver.FindElement(By.CssSelector(divLooseDiamonds));
				IList<IWebElement> TblLooseDiamonds = new List<IWebElement>(PropCategoryTable.FindElements(By.TagName("td")));
				IList<IWebElement> TxtLooseDiamonds = new List<IWebElement>(TblLooseDiamonds[0].FindElements(By.TagName("div")));
				JavaScriptClick(TxtLooseDiamonds[0]);
				driver.FindElement(By.CssSelector(txtLooseDiamonds)).Clear();
				driver.FindElement(By.CssSelector(txtLooseDiamonds)).SendKeys(table.Rows[0]["LooseDiamonds"]);
				driver.FindElement(By.CssSelector(txtLooseDiamonds)).SendKeys(Keys.LeftShift + Keys.Tab);
				UIActionExt(By.CssSelector(lnkTabCoverages), "ispresent");
				ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(lnkTabCoverages)));
				UIActionExt(By.CssSelector(lnkTabCoverages), "click");
				UIActionExt(By.CssSelector(txtStockAOPLimit), "Text", table.Rows[i]["StockAOPLimit"]);
				UIActionExt(By.CssSelector(txtStockAOPLimit), "ispresent");
				//+ "[value='" + table.Rows[i]["StockAOPLimit"] + "']"), "ispresent");
				UIActionExt(By.CssSelector(btnOK), "click");
				UIActionExt(By.CssSelector(btnILMAddLocation), "ispresent");
			}
		}
		public void EnterJewelryStockInfo_JS(Table table)
		{
			for (int i = 0; i <= table.Rows.Count() - 1; i++)
			{
				lnkJweleryStock = "a[id$=':" + (Convert.ToInt16(table.Rows[i]["Loc"]) - 1) + ":StockDescription'";
				UIActionExt(By.CssSelector(lnkJweleryStock), "click");
				UIActionExt(By.CssSelector(radioCompInvTrue), "ispresent");
				UIActionExt(By.CssSelector(radioCompInvTrue), "click");
				UIActionExt(By.CssSelector(txtRecentInv), "Text", table.Rows[i]["RecentInventry"]);
				UIActionExt(By.CssSelector(txtTakenOn), "Text", table.Rows[i]["TakenOn"]);
				UIActionExt(By.CssSelector(txtMaxStockVal), "Text", table.Rows[i]["MaxStockValue"]);
				UIActionExt(By.CssSelector(radioMaintainRecordsTrue), "click");
				UIActionExt(By.CssSelector(txtAvgCust), "Text", table.Rows[i]["AvgAmtCustProp"]);
				UIActionExt(By.CssSelector(txtAvgMemo), "Text", table.Rows[i]["AvgAmtMemo"]);
				var PropCategoryTable = driver.FindElement(By.CssSelector(divLooseDiamonds));
				IList<IWebElement> TblLooseDiamonds = new List<IWebElement>(PropCategoryTable.FindElements(By.TagName("td")));
				IList<IWebElement> TxtLooseDiamonds = new List<IWebElement>(TblLooseDiamonds[0].FindElements(By.TagName("div")));
				JavaScriptClick(TxtLooseDiamonds[0]);
				driver.FindElement(By.CssSelector(txtLooseDiamonds)).Clear();
				driver.FindElement(By.CssSelector(txtLooseDiamonds)).SendKeys(table.Rows[0]["LooseDiamonds"]);
				driver.FindElement(By.CssSelector(txtLooseDiamonds)).SendKeys(Keys.LeftShift + Keys.Tab);

				UIActionExt(By.CssSelector(lnkTabCoverages), "ispresent");
				UIActionExt(By.CssSelector(lnkTabCoverages), "click");
				UIActionExt(By.CssSelector(txtStockAOPLimit), "Text", table.Rows[i]["StockAOPLimit"]);
				UIActionExt(By.CssSelector(txtStockAOPLimit), "ispresent");
				//+ "[value='" + table.Rows[i]["StockAOPLimit"] + "']"), "ispresent");
				string txtStockOOL = "input[id$=':DirectTermInput-inputEl']";
				UIActionExt(By.CssSelector(txtStockOOL), "Text", table.Rows[i]["StockOutOfLimit"]);
				UIActionExt(By.CssSelector(btnOK), "click");
				UIActionExt(By.CssSelector(btnILMAddLocation), "ispresent");
			}
		}

		public CL_JewelryStock_PC9(IWebDriver driver) : base(driver)
		{
		}
		public override void VerifyPage()
		{
		}
		public override void WaitForLoad()
		{
		}
	}
}

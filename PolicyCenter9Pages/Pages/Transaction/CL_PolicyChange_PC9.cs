using iTextSharp.text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace PolicyCenter9Pages.Pages.Transaction
{
	public class CL_PolicyChange_PC9 : Page
	{
		string btnPolicyChngNext = "span[id$=':NewPolicyChange-btnInnerEl']";
		string btnNext = "span[id$=':Next-btnInnerEl']";

		string txtPolicyChngEffDate = "input[id$=':EffectiveDateJMIC_date-inputEl']";
		string tblPolicyChange = "div[id$=':PolicyChangeReason_JMICPanelSet:1-body']";
		string txtPlcyChngReason1 = "input[name$='PrimaryChangeReason']";
		string txtPlcyChngReason2 = "input[name$='ChangeReason']";
		string txtPlcyChngReason3 = "input[name$='ChangeReasonCat']";
		string radioInclApplication = "input[id$=':IncludeAppNeeded_true-inputEl']";

		string txtRngInputChoice1 = "input[id$=':RangeTypekeyInputChoice1-inputEl']";
		string txtRngInputChoice2 = "input[id$=':RangeTypekeyInputChoice2-inputEl']";
		string txtRngInputChoice3 = "input[id$=':RangeTypekeyInputChoice3-inputEl']";

		string txtInputChoice1 = "input[id$=':RangeInputChoice1-inputEl']";
		string txtInputChoice2 = "input[id$=':RangeInputChoice2-inputEl']";
		string txtInputChoice3 = "input[id$=':RangeInputChoice3-inputEl']";
		string txtInputChoice4 = "input[id$=':RangeInputChoice4-inputEl']";

		string txtInputNewInteger1 = "input[id$=':InputInteger1-inputEl']";
		string txtInputNewInteger2 = "input[id$=':InputInteger2-inputEl']";
		string txtInputShortText1 = "input[id$=':InputShortText1-inputEl']";

		string txtInputMediumText1 = "input[id$=':InputMediumText1-inputEl']";
		string txtAreaMedText1 = "textarea[id$=':TextAreaMediumText1-inputEl']";

		string lnkCoveragesTab = "span[id$='ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesTab-btnInnerEl']";
		string btnILMAddLocation = "span[id$=':addLocationsOrBuildingsTB-btnInnerEl']";

		string btnPolicyChangeNext = "span[id$='PolicyChangeWizard:Next-btnInnerEl']";
		string btnOK = "span[id$=':Update-btnInnerEl']";
		string btnOKAddlIntrest = "span[id$=':ForceDupCheckUpdate-btnInnerEl']";
		string btnRemove = "span[id$=':Remove-btnInnerEl']";
		string btnSetActive = "span[id$=':setToPrimary-btnInnerEl']";

		string lblPlcyEffChngDateMsg = "span[id$=':policyEffDateMsg']";
		string lblInventryInfo = "span[id$='ILMJewelryStock_JMICPopup:ttlBar']";
		string lblLocationInfo = "span[id$='ILMLocation_JMICPopup:ttlBar']";
		string lblOfferings = "span[id$=':OfferingScreen:ttlBar']";
		string lblBOLocBldgs = "span[id$=':BOPBuildingsScreen:ttlBar']";
		string lblLocations = "span[id$=':BOPWizardStepGroup:BOPLocationsScreen:ttlBar']";
		string lblLineSelection = "span[id$=':CPPLineSelectionScreen:ttlBar']";
		string lblPolicyInfo = "span[id$='PolicyInfoScreen:ttlBar']";
		string lblILMLine = "span[id$=':ILMLineCoveragesScreen:ttlBar']";
		string lblILMLocation = "span[id$=':ILMLocation_JMICScreen:ttlBar']";
		string lblBusinessOwnersLine = "span[id$=':BOPWizardStepGroup:BOPScreen:ttlBar']";
		string lblBOLocationInfo = "span[id$=':LocationScreen:ttlBar']";
		string lblBuilding = "span[id$=':BOPSingleBuildingDetailScreen:ttlBar']";
		string tblPlcyChngDetails = "div[id$=':PolicyChangeReason_JMICPanelSet:2-body']";

		public void PolicyChangeReasonTbl(Table table)
		{

			UIActionExt(By.CssSelector(tblPolicyChange), "ispresent");
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("td")).ToList();
			tblTDplcyChng[1].Click();
			tblTDplcyChng[1].SendKeys(Keys.Enter);
			driver.FindElement(By.CssSelector(txtPlcyChngReason1)).Clear();
			driver.FindElement(By.CssSelector(txtPlcyChngReason1)).SendKeys(table.Rows[0]["ChangeReason"]);
			driver.FindElement(By.CssSelector(txtPlcyChngReason1)).SendKeys(Keys.LeftShift + Keys.Tab);
			//if (table.Rows[0]["ChangeReason"].ToString() == "Temporary Endorsement")
			//{
			//	WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			//}
			//else
			//{
			//	UIActionExt(By.CssSelector(radioInclApplication), "ispresent");
			//}
			UIActionExt(By.CssSelector(tblPolicyChange), "ispresent");
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));

			tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("td")).ToList();
			tblTDplcyChng[2].Click();
			tblTDplcyChng[2].SendKeys(Keys.Enter);
			driver.FindElement(By.CssSelector(txtPlcyChngReason2)).Clear();
			driver.FindElement(By.CssSelector(txtPlcyChngReason2)).SendKeys(table.Rows[0]["ChangeReasonNext"]);
			driver.FindElement(By.CssSelector(txtPlcyChngReason2)).SendKeys(Keys.LeftShift + Keys.Tab);

			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitUntilElementVisible(driver, By.XPath("//div[text()='" + table.Rows[0]["ChangeReasonNext"] + "']"));


			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			if (IsElementPresent(driver, By.CssSelector(tblPolicyChange)) == false)
			{
				WaitUntilElementVisible(driver, By.CssSelector(tblPolicyChange));
			}
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));


			UIActionExt(By.CssSelector(tblPolicyChange), "ispresent");
			tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("td")).ToList();
			tblTDplcyChng[3].Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			tblTDplcyChng[3].SendKeys(Keys.Enter);
			driver.FindElement(By.CssSelector(txtPlcyChngReason3)).Clear();
			driver.FindElement(By.CssSelector(txtPlcyChngReason3)).SendKeys(table.Rows[0]["ChangeReasonCategory"]);
			driver.FindElement(By.CssSelector(txtPlcyChngReason3)).SendKeys(Keys.LeftShift + Keys.Tab);
			//UIActionExt(By.CssSelector(tblPlcyChngDetails), "ispresent");
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));

		}
		public void PermChangeStockPeak(Table table)
		{

			string lnkJewlryStock = "a[id$=':" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":StockDescription'";
			string btnAddCoverage = "span[id$=':ILMJewelryStock_JMICCoveragesPanelSet:ToolbarButton-btnInnerEl']";
			string lnkSteakPeak = "span[id$=':ToolbarButton:0:subItemCoverable-textEl']";
			string txtSteakPeakLimit = "input[id$=':0:ILMCovTermInputSet:DirectTermInput-inputEl']";
			string txtSteakPeakDed = "input[id$='ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:OptionTermInput-inputEl']";
			string txtSteakPeakFrom = "input[id$=':2:FromDate:DateTimeTermInput-inputEl']";
			string txtSteakPeakTo = "input[id$=':3:ToDate:DateTimeTermInput-inputEl']";
			string radioStockPeakRecYes = "input[id$=':4:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_true-inputEl']";
			string radioStockPeakRecNo = "input[id$=':4:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_false-inputEl']";
			string lblLineSelection = "span[id$=':CPPLineSelectionScreen:ttlBar']";
			string lblPolicyInfo = "span[id$='PolicyInfoScreen:ttlBar']";
			string lblILMLine = "span[id$=':ILMLineCoveragesScreen:ttlBar']";
			string lblILMLocation = "span[id$=':ILMLocation_JMICScreen:ttlBar']";
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtRngInputChoice1), "Text", table.Rows[0]["ChoiceChange1"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputChoice2), "List", ScenarioContext.Current["ILMLOCZIP" + table.Rows[0]["Location"]].ToString());
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputNewInteger1), "Text", table.Rows[0]["SteakPeak_Limit"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(radioInclApplication), "click");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLocation), "ispresent");
			UIActionExt(By.CssSelector(lnkJewlryStock), "click");
			UIActionExt(By.CssSelector(lblInventryInfo), "ispresent");
			UIActionExt(By.CssSelector(lnkCoveragesTab), "click");
			UIActionExt(By.CssSelector(btnAddCoverage), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnAddCoverage)));
			UIActionExt(By.CssSelector(btnAddCoverage), "click");
			UIActionExt(By.CssSelector(lnkSteakPeak), "ispresent");
			UIActionExt(By.CssSelector(lnkSteakPeak), "click");
			UIActionExt(By.CssSelector(txtSteakPeakLimit), "Text", table.Rows[0]["SteakPeak_Limit"]);
			UIActionExt(By.CssSelector(txtSteakPeakDed), "Text", table.Rows[0]["SteakPeak_Deductible"]);
			UIActionExt(By.CssSelector(txtSteakPeakFrom), "Text", GetCurrSysDate(table.Rows[0]["SteakPeak_StartDate"]));
			UIActionExt(By.CssSelector(txtSteakPeakTo), "Text", GetCurrSysDate(table.Rows[0]["SteakPeak_EndDate"]));

			if (table.Rows[0]["SteakPeak_Recurring"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(radioStockPeakRecYes), "click");
			}
			else if (table.Rows[0]["SteakPeak_Recurring"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(radioStockPeakRecNo), "click");
			}
			UIActionExt(By.CssSelector(btnOK), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnOK)));
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector("span[id$=':ILMLocation_JMICScreen:ttlBar']"), "ispresent");
		}
		public void PermChangeStockAOP(Table table)
		{
			string lnkJewlryStock = "a[id$=':" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":StockDescription'";
			string txtStockAOPLimit = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:0:StockAOPLimit-inputEl']";
			string txtStockAOPDed = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:1:StockAOPDeductible-inputEl']";
			string LocToSelect = ScenarioContext.Current["ILMLOCZIP" + table.Rows[0]["Location"]].ToString();

			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtRngInputChoice1), "Text", table.Rows[0]["ChoiceChange1"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			Console.WriteLine("ILMLOCZIP{0}: {1}", table.Rows[0]["Location"], LocToSelect);
			if (table.Rows[0]["Country"].ToString().ToLower() == "canada")
			{
				LocToSelect = LocToSelect.Insert(LocToSelect.Length - 7, " ");
				Console.WriteLine("ILMLOCZIP{0}: {1}", table.Rows[0]["Location"], LocToSelect);
			}
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputChoice2), "List", LocToSelect);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputNewInteger1), "Text", table.Rows[0]["StockAOP_Limit"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(radioInclApplication), "click");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "Sync");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "Sync");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "Sync");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "Sync");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLocation), "Sync");
			UIActionExt(By.CssSelector(lnkJewlryStock), "click");
			UIActionExt(By.CssSelector(lblInventryInfo), "Sync");
			UIActionExt(By.CssSelector(lnkCoveragesTab), "click");
			UIActionExt(By.CssSelector(txtStockAOPLimit), "Text", table.Rows[0]["StockAOP_Limit"]);
			//WaitUntilElementInvisible(driver, By.CssSelector(btnILMAddLocation), 10);
			UIActionExt(By.CssSelector(txtStockAOPLimit + "[value='" + table.Rows[0]["StockAOP_Limit"] + "']"), "ispresent");
			UIActionExt(By.CssSelector(txtStockAOPDed), "List", table.Rows[0]["AOP_Deductible"]);
			UIActionExt(By.CssSelector(txtStockAOPDed + "[value='" + table.Rows[0]["AOP_Deductible"] + "']"), "ispresent");
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(btnILMAddLocation), "ispresent");
		}
		public void PermChangeTradeShows(Table table)
		{
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtInputNewInteger1), "Text", table.Rows[0]["Limit"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputNewInteger2), "Text", table.Rows[0]["Deductible"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputShortText1), "Text", table.Rows[0]["ShowName_City_State"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(radioInclApplication), "click");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "ispresent");
		}
		public void TempChangeTradeShows(Table table)
		{
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtRngInputChoice1), "Text", table.Rows[0]["Tradeshow_Type"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputNewInteger1), "Text", table.Rows[0]["Limit"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputNewInteger2), "Text", table.Rows[0]["Deductible"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputMediumText1), "Text", table.Rows[0]["ShowName_City_State"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "ispresent");
		}
		public void AddTradeShow(Table table)
		{
			string SearchText;
			string tabOffPremises = "span[id$=':OffPremiseCoveragesTab-btnInnerEl']";
			string btnAddCoverage = "span[id$=':OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton-btnInnerEl']";
			string lnkTradeShow = "span[id$=':ILMLineCoveragesPanelSet:ToolbarButton:5:subItemCoverable-textEl']";
			string imgTradeShowSearchIcon = "div[id$=':0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TradeshowPicker:SelectTradeshowPicker']";
			string imgTempReasonSearchIcon = "div[id$=':0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
			string btnReasonSelect = "a[id$=':0:_Select']";
			string txtTradeShowCity = "input[id$=':ShowCity-inputEl']";
			string txtTradeShowState = "input[id$=':ShowState-inputEl']";
			string txtTradeShowYear = "input[id$=':ShowYear-inputEl']";
			string btnTradeShowSearch = "a[id$=':SearchLinksInputSet:Search']";
			string lstHowMerch_Transported = "input[id$=':0:ILMCovTermInputSet:TypekeyTermInput-inputEl']";
			string txtLimit = "input[id$=':1:ILMCovTermInputSet:DirectTermInput-inputEl']";
			string lstDeductible = "input[id$=':2:ILMCovTermInputSet:OptionTermInput-inputEl']";
			string txtTransit_Days = "input[id$=':5:ILMCovTermInputSet:DirectTermInput-inputEl']";
			string lnkFirstSelect = "a[id$=':TradeShows_JMICLV:0:_Select']";
			string lnkTimeFrame = "//span[text()='Timeframe']";
			string sEffDate = "span[id$=':JobWizardInfoBar:EffectiveDate-btnInnerEl']";
			string EffDate = driver.FindElement(By.CssSelector(sEffDate)).Text.Replace("Eff. ", string.Empty);
			string sTradeshowYear = Convert.ToDateTime(EffDate).AddMonths(3).Year.ToString();

			UIActionExt(By.CssSelector(tabOffPremises), "click");
			UIActionExt(By.CssSelector(btnAddCoverage), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnAddCoverage)));
			UIActionExt(By.CssSelector(btnAddCoverage), "click");
			UIActionExt(By.CssSelector(lnkTradeShow), "click");
			UIActionExt(By.CssSelector(imgTradeShowSearchIcon), "ispresent");
			UIActionExt(By.CssSelector(imgTradeShowSearchIcon), "click");
			UIActionExt(By.CssSelector(txtTradeShowCity), "ispresent");
			UIActionExt(By.CssSelector(txtTradeShowCity), "Text", table.Rows[0]["Tradeshow_City"]);
			UIActionExt(By.CssSelector(txtTradeShowYear), "Text", sTradeshowYear);
			UIActionExt(By.CssSelector(txtTradeShowState), "Text", table.Rows[0]["Tradeshow_State"]);
			UIActionExt(By.CssSelector(btnTradeShowSearch), "click");
			UIActionExt(By.CssSelector(lnkFirstSelect), "ispresent");
			UIActionExt(By.XPath(lnkTimeFrame), "click");

			string CurrMonth = Convert.ToDateTime(EffDate).ToString("MMM");
			switch (CurrMonth.ToString())
			{
				case "Jan":
				case "Feb":
				case "Mar":
					SearchText = "April-June";
					break;
				case "Apr":
				case "May":
				case "Jun":
					SearchText = "July-Sept";
					break;
				case "Jul":
				case "Aug":
				case "Sep":
					SearchText = "Oct-Dec";
					break;
				default:
					SearchText = "Jan-March";
					break;
			}
			Console.WriteLine("EffDate: {0}\nTradeshowYear: {1}\nMonth: {2}\nSearchText: {3}", EffDate, sTradeshowYear, CurrMonth, SearchText);
			IWebElement sDisplayText = driver.FindElement(By.XPath("//div[text()[contains(.,'Displaying 1 - ')]]"));
			string totalItems = sDisplayText.Text.Substring(sDisplayText.Text.Length - 2, 2);
			int iTotPages = (Convert.ToInt16(totalItems.Trim()) % 15 != 0)? Convert.ToInt16(totalItems.Trim()) % 15 : 1;
			//int iTotPages = Convert.ToInt16(sDisplayText.Text.Replace("Displaying 1 - 9 of ", "")) % 15;
			bool bTradeshowFound = false;
			string txtPages = "input[id$=':TradeShows_JMICLV:_ListPaging-inputEl']";
			for (int j = 0; j < iTotPages; j++)
			{
				if (bTradeshowFound == true)
					break;
				if (j > 0)
				{
					UIActionExt(By.CssSelector(txtPages), "ispresent");
					driver.FindElement(By.CssSelector(txtPages)).Clear();
					UIAction(txtPages, (j + 1).ToString(), "textbox");
					driver.FindElement(By.CssSelector(txtPages)).SendKeys(Keys.Enter);
					UIActionExt(By.CssSelector(lnkFirstSelect), "ispresent");
				}
				UIActionExt(By.CssSelector("div[id$='Tradeshow_JMICSearchPopup:TradeShows_JMICLV-body']"), "ispresent");

				IWebElement divTradeShowMainTable = driver.FindElement(By.CssSelector("div[id$='Tradeshow_JMICSearchPopup:TradeShows_JMICLV-body']"));
				IList<IWebElement> lstTable = divTradeShowMainTable.FindElements(By.TagName("table")).ToList();
				for (int k = 1; k <= lstTable.Count - 1; k++)
				{
					if (bTradeshowFound == true)
						break;
					IList<IWebElement> lstTimeFrame = lstTable[k - 1].FindElements(By.TagName("td")).ToList();
					string lnkTimeFrameSelect = "a[id$='Tradeshow_JMICSearchPopup:TradeShows_JMICLV:" + (k - 1) + ":_Select']";
					string sTimeFrame = lstTimeFrame[lstTimeFrame.Count - 1].Text;
					if (sTimeFrame == SearchText)
					{
						UIActionExt(By.CssSelector(lnkTimeFrameSelect), "ispresent");
						ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(lnkTimeFrameSelect)));
						JavaScriptClick(driver.FindElement(By.CssSelector(lnkTimeFrameSelect)));
						bTradeshowFound = true;
						break;
					}
				}
			}
			UIActionExt(By.CssSelector(lstHowMerch_Transported), "Text", table.Rows[0]["HowMerch_Transported"]);
			UIActionExt(By.CssSelector(txtLimit), "Text", table.Rows[0]["Limit"]);
			UIActionExt(By.CssSelector(lstDeductible), "List", table.Rows[0]["Deductible"]);
			UIActionExt(By.CssSelector(txtTransit_Days), "Text", table.Rows[0]["Transit_Days"]);

			string radioRecurringYes = "input[id$=':13:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_true-inputEl']";
			string radioRecurringNo = "input[id$=':13:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_false-inputEl']";

			switch (table.Rows[0]["Recurring"].ToLower().Trim())
			{
				case "true":
					UIActionExt(By.CssSelector(radioRecurringYes), "click");
					break;
				default:
					UIActionExt(By.CssSelector(radioRecurringNo), "click");
					break;
			}
			switch (table.Rows[0]["TempReason"].ToLower().Trim())
			{
				case "yes":
					UIActionExt(By.CssSelector(imgTempReasonSearchIcon), "click");
					UIActionExt(By.CssSelector(btnReasonSelect), "click");
					break;
				default:
					break;
			}
		}
		public void PermChangeAddlAI(Table table)
		{
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtRngInputChoice1), "Text", table.Rows[0]["AI_Type"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtRngInputChoice2), "List", table.Rows[0]["AI_Change_Type"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtRngInputChoice3), "List", table.Rows[0]["Offering"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputChoice4), "List", ScenarioContext.Current["ILMLOCZIP" + table.Rows[0]["Location"]].ToString());
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtAreaMedText1), "Text", table.Rows[0]["Description"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(radioInclApplication), "click");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
		}
		public void PermChangeDeletelAI(Table table)
		{
			UIActionExt(By.CssSelector(tblPolicyChange), "ispresent");
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtRngInputChoice1), "Text", table.Rows[0]["AI_Type"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtRngInputChoice2), "List", table.Rows[0]["Offering"]);
			UIActionExt(By.CssSelector(txtRngInputChoice2 + "[value='" + table.Rows[0]["Offering"] + "']"), "ispresent");
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputChoice3), "List", ScenarioContext.Current["ILMLOCZIP" + table.Rows[0]["Location"]].ToString());
			UIActionExt(By.CssSelector(txtInputChoice3 + "[value='" + ScenarioContext.Current["ILMLOCZIP" + table.Rows[0]["Location"]].ToString() + "']"), "ispresent");
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtAreaMedText1), "Text", table.Rows[0]["Description"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(radioInclApplication), "click");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
		}
		public void PermChangeAddAddlIntrest(Table table)
		{
			string lnkILMLocation = "a[id$=':" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":LocationNumber";

			UIAction(btnPolicyChangeNext, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(lblPolicyInfo));

			UIAction(btnPolicyChangeNext, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(lblILMLine));

			UIAction(btnPolicyChangeNext, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(lblILMLocation));

			UIAction(lnkILMLocation, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblLocationInfo));

			AddAddlIntrest_Insured("company", "", table);
			WaitUntilElementVisible(driver, By.CssSelector(lblLocationInfo));
			UIAction(btnOK, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(btnILMAddLocation));

		}
		public void NavigatetoBOLocs()
		{
			WaitUntilElementInvisible(driver, By.CssSelector(lblLocations));
			WaitUntilElementInvisible(driver, By.CssSelector(lblLocations));
			string lnkBusinessOwners = "td[id$=':LOBWizardStepGroup:BOPWizardStepGroup']";
			UIAction(lnkBusinessOwners, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblBusinessOwnersLine));
			UIAction(btnNext, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblLocations));
		}
		public void PermChangeAddAI_BOP(Table table)
		{
			string lnkBOLocation = "a[id$=':LocationsEdit_LV:" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":Loc";
			string divAddlInsured = "div[id$=':AdditionalInsuredLV-body']";
			string txtInterest_JMIC = "input[name='Interest_JMIC']";
            System.Threading.Thread.Sleep(5000);
            UIAction(lnkBOLocation, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblBOLocationInfo));
			AddAddlIntrest_Insured("company", "insured", table);
			WaitUntilElementVisible(driver, By.CssSelector(lblBOLocationInfo));
			IWebElement objDivAddIns = driver.FindElement(By.CssSelector(divAddlInsured));
			IList<IWebElement> tdListInsured = objDivAddIns.FindElements(By.TagName("td")).ToList();
			tdListInsured[7].Click();
			tdListInsured[7].SendKeys(Keys.Enter);
			UIActionExt(By.CssSelector(txtInterest_JMIC), "Text", "Testing");
			UIAction(btnOK, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(lblLocations));
		}
		public void NavigatetoBOLocsBuldgs()
		{
			UIActionExt(By.CssSelector(btnNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblBOLocBldgs));
		}
		public void NavigateToBOBuilding(Table table)
		{
			string tblBOBldLocs = "div[id$=':BOPLocationBuildingsPanelSet:BOPLocationsLV-body']";
			int locBuilding = (Convert.ToInt16(table.Rows[0]["Location"]) - 1);
			string locText = "//div[text()='" + ScenarioContext.Current["BOPLOC" + table.Rows[0]["Location"]].ToString() + "']"; Console.WriteLine(locText);
			string BOLocBldg = "a[id$=':0:BuildingNumEdit']";
			IWebElement tblbodyBOLocs = WaitFor(driver.FindElement(By.CssSelector(tblBOBldLocs)));
			IList<IWebElement> tblBOLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
			if (locBuilding != 0)
			{
				WaitUntilElementVisible(driver, By.CssSelector("table[id='" + tblBOLocs[locBuilding].GetAttribute("id") + "']"));
				tblBOLocs[locBuilding].Click();
				WaitUntilElementVisible(driver, By.XPath(locText));
			}
			UIAction(BOLocBldg, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblBuilding));
		}
		public void PermChangeAddAI_BOPBld(Table table)
		{
			string btnUpdateBldg = "span[id$=':Update-btnInnerEl']";
			NavigateToBOBuilding(table);
			AddAddlIntrest_Insured("person", "", table);
			WaitUntilElementVisible(driver, By.CssSelector(btnUpdateBldg));
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnUpdateBldg)));

			UIAction(btnUpdateBldg, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(lblBOLocBldgs));
		}
		public void PermChangeDeleteAI_BOPBld(Table table)
		{
			string btnRemove = "span[id$=':Remove-btnInnerEl']";
			string btnUpdateBldg = "span[id$=':Update-btnInnerEl']";
			string tblAddlInst = "div[id$=':AdditionalInterestLV-body']";
			NavigateToBOBuilding(table);
			UIActionExt(By.CssSelector(tblAddlInst), "ispresent");
			IWebElement divAddlIns = driver.FindElement(By.CssSelector(tblAddlInst));
			IList<IWebElement> tblBldgAI = divAddlIns.FindElements(By.TagName("img")).ToList();
			tblBldgAI[0].Click();
			tblBldgAI[0].SendKeys(Keys.Space);
			UIActionExt(By.CssSelector(btnRemove), "click");
			UIActionExt(By.CssSelector(btnUpdateBldg), "click");
		}
		public void ChangeEffectiveDate(string PolicyChangeEffDate)
		{
			string tblChangeReason = "div[id$=':PolicyChangeReason_JMICPanelSet:1-body']";
			UIActionExt(By.CssSelector(txtPolicyChngEffDate), "ispresent");
			UIActionExt(By.CssSelector(txtPolicyChngEffDate), "List", GetCurrSysDate(PolicyChangeEffDate));
			UIActionExt(By.CssSelector(tblChangeReason), "ispresent");
		}
		public void AddAddlIntrest_Insured(string sCompanyPerson, string intr_insured, Table table)
		{
			string sCompanyName, sFirstName, sLastName;
			string btnAdd = "span[id$=':AddContactsButton-btnInnerEl']";
			string lnkNewCompnay = "span[id$=':AddContactsButton:0:ContactType-textEl']";
			string lnkNewPerson = "span[id$=':AddContactsButton:1:ContactType-textEl']";
			string lstIntrestType = "input[id$=':Type-inputEl']";
			string txtInsIntrest = "input[id$=':Interest_JMIC-inputEl']";
			string txtCompName = "input[id$=':GlobalContactNameInputSet:Name-inputEl']";
			string IsJewelerYes = "input[id$=':IsAccountHolderJeweler_true-inputEl']";
			string IsJewelerNo = "input[id$=':IsAccountHolderJeweler_false-inputEl']";
			string txtFirstName = "input[id$=':FirstName-inputEl']";
			string txtLastName = "input[id$=':LastName-inputEl']";

			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnAdd)));
			UIActionExt(By.CssSelector(btnAdd), "click");

			if (sCompanyPerson.ToLower() == "company")
			{
				UIActionExt(By.CssSelector(lnkNewCompnay), "click");
			}
			else
			{
				UIActionExt(By.CssSelector(lnkNewPerson), "click");
			}
			UIActionExt(By.CssSelector(lstIntrestType), "Text", table.Rows[0]["Interest_Type"]);
			if (sCompanyPerson.ToLower() == "company")
			{
				sCompanyName = table.Rows[0]["AI_Name"] + GetUniqueValue();
				UIActionExt(By.CssSelector(txtCompName), "Text", sCompanyName);
				switch (table.Rows[0]["Is_Jeweler"].ToLower().Trim())
				{
					case "yes":
						UIActionExt(By.CssSelector(IsJewelerYes), "click");

						break;
					default:
						UIActionExt(By.CssSelector(IsJewelerNo), "click");
						break;
				}
			}
			else
			{
				sFirstName = table.Rows[0]["FirstName"] + GetUniqueValue();
				sLastName = table.Rows[0]["LastName"] + GetUniqueValue();
				UIActionExt(By.CssSelector(txtFirstName), "Text", sFirstName);
				UIActionExt(By.CssSelector(txtLastName), "Text", sLastName);
			}
			AddAddress(table.Rows[0]["Address_Line1"], table.Rows[0]["City"], table.Rows[0]["State"], table.Rows[0]["ZipCode"]);
			JavaScriptClick(driver.FindElement(By.CssSelector(btnOKAddlIntrest)));
		}
		public void AddAddress(string sAddrLine1, string sCity, string sState, string sZipCode)
		{
			string AddressLine1 = "input[id$=':AddressLine1-inputEl']";
			string City = "input[id$=':City-inputEl']";
			string ZipCode = "input[id$=':PostalCode-inputEl']";
			string State = "input[id$=':State-inputEl']";
			string lblNewAI = "span[id$=':ContactDetailScreen:ttlBar']";
			UIActionExt(By.CssSelector(State), "ispresent");
			UIActionExt(By.CssSelector(State), "Text", sState);
			UIActionExt(By.CssSelector(AddressLine1), "Text", sAddrLine1);
			UIActionExt(By.CssSelector(City), "List", sCity);
			UIActionExt(By.CssSelector(ZipCode), "ispresent");
			UIActionExt(By.CssSelector(ZipCode), "List", sZipCode);
			if (IsElementPresent(driver, By.XPath("//div[text()[contains(.,'Verified')]]")) == false)
			{
				UIActionExt(By.CssSelector("span[id$=':verifyAddress_JMIC-btnInnerEl']"), "click", "", 0, 12, 5);
				try
				{
					WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'Verified')]]"), 30);
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception Caught: " + e);
				}
			}
			UIActionExt(By.XPath("//div[text()[contains(.,'Verified')]]"), "ispresent");
			UIActionExt(By.CssSelector(lblNewAI), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(lblNewAI)));
		}
		public void AddILMLocation(Table table)
		{
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtInputShortText1), "Text", table.Rows[0]["Location"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			if (IsElementPresent(driver, By.CssSelector(radioInclApplication)) == true)
			{
				UIActionExt(By.CssSelector(radioInclApplication), "click");
			}
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLocation), "ispresent");
		}
		public void DeleteBOLocation(Table table)
		{
			UIActionExt(By.CssSelector(txtInputChoice1), "ispresent");
			UIActionExt(By.CssSelector(txtInputChoice1), "List", ScenarioContext.Current["BOPLOCZIP" + table.Rows[0]["Location"]].ToString());
			UIActionExt(By.CssSelector(txtRngInputChoice2), "List", table.Rows[0]["Offering"]);
			UIActionExt(By.CssSelector(radioInclApplication), "click");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLocation), "ispresent");

			NavigatetoBOLocs();
			NavigatetoBOLocsBuldgs();

			IWebElement divBOBuildLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':BOPLocationBuildingsLV-body")));
			IList<IWebElement> tblBOBldgLocs = divBOBuildLocs.FindElements(By.TagName("table")).ToList();
			IList<IWebElement> ImgBOBldChkBox = tblBOBldgLocs[Convert.ToInt32(table.Rows[0]["BldgToDelete"]) - 1].FindElements(By.TagName("img")).ToList();
			WaitFor(ImgBOBldChkBox[0]).Click();
			WaitFor(ImgBOBldChkBox[0]).SendKeys(Keys.Space);
			WaitUntilElementVisible(driver, By.CssSelector(btnRemove), 4);
			WaitFor(driver.FindElement(By.CssSelector(btnRemove))).Click();
			Console.WriteLine("Location Building Removed");
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);
			JavaScriptClick(driver.FindElement(By.CssSelector("span[id$=':Prev-btnInnerEl']")));
			WaitUntilElementVisible(driver, By.CssSelector(lblLocations), 5);


			IWebElement divBOLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':LocationsEdit_LV-body']")));
			IList<IWebElement> tbBOlLocs = divBOLocs.FindElements(By.TagName("table")).ToList();
			IList<IWebElement> ImgBOChkBox = tbBOlLocs[Convert.ToInt32(table.Rows[0]["SetActiveLoc"]) - 1].FindElements(By.TagName("img")).ToList();
			WaitFor(ImgBOChkBox[0]).Click();
			WaitFor(ImgBOChkBox[0]).SendKeys(Keys.Space);
			WaitUntilElementVisible(driver, By.CssSelector(btnSetActive), 5);
			WaitFor(driver.FindElement(By.CssSelector(btnSetActive))).Click();
			WaitUntilElementVisible(driver, By.CssSelector("label[id$=':LocationInfo-labelEl']"), 10);
			Console.WriteLine("Location Set as Primary");
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);

			IWebElement divBODelLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':LocationsEdit_LV-body']")));
			IList<IWebElement> tblBODelLocs = divBODelLocs.FindElements(By.TagName("table")).ToList();
			IList<IWebElement> ImgBOSelChkBox = tblBODelLocs[Convert.ToInt32(table.Rows[0]["Location"]) - 1].FindElements(By.TagName("img")).ToList();
			WaitFor(ImgBOSelChkBox[0]).Click();
			WaitFor(ImgBOSelChkBox[0]).SendKeys(Keys.Space);
			WaitUntilElementVisible(driver, By.CssSelector(btnRemove), 5);
			WaitFor(driver.FindElement(By.CssSelector(btnRemove))).Click();
			Console.WriteLine("Location Removed");
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 10);
		}
		public void DeleteBOLocation_BOP(string Offering, int locationNumber, Table table)
		{
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));


			UIActionExt(By.CssSelector(txtInputChoice1), "ispresent");
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputChoice1), "List", ScenarioContext.Current["BOPLOCZIP" + locationNumber].ToString());
			Console.WriteLine(ScenarioContext.Current["BOPLOCZIP" + locationNumber].ToString());
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtRngInputChoice2), "List", Offering);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			if (IsElementPresent(driver, By.CssSelector(radioInclApplication)) == true)
			{
				UIActionExt(By.CssSelector(radioInclApplication), "click");
			}
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblBusinessOwnersLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLocations), "ispresent");
			NavigatetoBOLocsBuldgs();

			UIActionExt(By.XPath("//div[text()[contains(.,'" + ScenarioContext.Current["BOPLOCZIP" + locationNumber].ToString() + "')]]"), "ispresent");
			UIActionExt(By.XPath("//div[text()[contains(.,'" + ScenarioContext.Current["BOPLOCZIP" + locationNumber].ToString() + "')]]"), "click");
			UIActionExt(By.XPath("//div[text()[contains(.,'" + ScenarioContext.Current["BOPLOC" + locationNumber].ToString() + "')]]"), "ispresent");
			for (int k = 0; k <= table.Rows.Count - 1; k++)
			{
				IWebElement divBOBuildLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':BOPLocationBuildingsLV-body")));
				IList<IWebElement> tblBOBldgLocs = divBOBuildLocs.FindElements(By.TagName("table")).ToList();
				IList<IWebElement> ImgBOBldChkBox = tblBOBldgLocs[Convert.ToInt32(table.Rows[k]["BldgToDelete"]) - 1].FindElements(By.TagName("img")).ToList();
				Console.WriteLine("BldgToDelete: " + table.Rows[k]["BldgToDelete"]);
				ImgBOBldChkBox[0].Click();
				ImgBOBldChkBox[0].SendKeys(Keys.Space);
				WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 2);
			}
			UIActionExt(By.CssSelector(btnRemove), "click");
            UIActionExt(By.CssSelector("span[id$=':Prev-btnInnerEl']"), "ispresent");
            UIActionExt(By.CssSelector("span[id$=':Prev-btnInnerEl']"), "click");
			UIActionExt(By.CssSelector("span[id$=':BOPLocationsScreen:ttlBar']"), "ispresent");
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 5);
		}
		public void DeleteBOLocationSet(Table table)
		{
			if (table.Rows[0]["SetActiveLoc"] != "1")
			{
				IWebElement divBOLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':LocationsEdit_LV-body']")));
				IList<IWebElement> tbBOlLocs = divBOLocs.FindElements(By.TagName("table")).ToList();
				IList<IWebElement> ImgBOChkBox = tbBOlLocs[Convert.ToInt32(table.Rows[0]["SetActiveLoc"]) - 1].FindElements(By.TagName("img")).ToList();
				WaitFor(ImgBOChkBox[0]).Click();
				WaitFor(ImgBOChkBox[0]).SendKeys(Keys.Space);
				WaitUntilElementVisible(driver, By.CssSelector(btnSetActive), 5);
				WaitFor(driver.FindElement(By.CssSelector(btnSetActive))).Click();
				//WaitUntilElementVisible(driver, By.CssSelector("label[id$=':LocationInfo-labelEl']"), 10);
				Console.WriteLine("Location Set as Primary");
				WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 5);
			}
			IWebElement divBODelLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':LocationsEdit_LV-body']")));
			IList<IWebElement> tblBODelLocs = divBODelLocs.FindElements(By.TagName("table")).ToList();
			IList<IWebElement> ImgBOSelChkBox = tblBODelLocs[Convert.ToInt32(table.Rows[0]["Location"]) - 1].FindElements(By.TagName("img")).ToList();
			WaitFor(ImgBOSelChkBox[0]).Click();
			WaitFor(ImgBOSelChkBox[0]).SendKeys(Keys.Space);
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 5);
			WaitFor(driver.FindElement(By.CssSelector(btnRemove))).Click();
			Console.WriteLine("Location Removed");
			WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 5);
		}

		public void DeleteILMLocation(Table table)
		{
			UIActionExt(By.CssSelector(txtInputChoice1), "ispresent");
			UIActionExt(By.CssSelector(txtInputChoice1), "List", ScenarioContext.Current["ILMLOCZIP" + table.Rows[0]["Location"]].ToString());
			UIActionExt(By.CssSelector(txtRngInputChoice2), "List", table.Rows[0]["Offering"]);

			UIActionExt(By.CssSelector(radioInclApplication), "ispresent");
			UIActionExt(By.CssSelector(radioInclApplication), "click");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLocation), "ispresent");

			string disbtnRemove = driver.FindElement(By.CssSelector("a[id$=':Remove']")).GetAttribute("class");
			string sbtnRemove = disbtnRemove.Replace(" x-item-disabled x-btn-disabled", "");
			sbtnRemove = sbtnRemove + " x-btn-over";
			IWebElement divILMStockLocations = driver.FindElement(By.CssSelector("div[id$=':ILMStockAndLocationsLV-body']"));
			IList<IWebElement> tblLocs = divILMStockLocations.FindElements(By.TagName("table")).ToList();
			IList<IWebElement> ImgChkBox = tblLocs[Convert.ToInt32(table.Rows[0]["Location"]) - 1].FindElements(By.TagName("img")).ToList();
			ImgChkBox[0].Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			ImgChkBox[0].SendKeys(Keys.Space);
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitFor(driver.FindElement(By.CssSelector(btnRemove))).Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
		}
		public void DeleteILMLocation_CAD(Table table)
		{
			string LocToSelect = ScenarioContext.Current["ILMLOCZIP" + table.Rows[0]["Location"]].ToString();
			Console.WriteLine("ILMLOCZIP{0}: {1}", table.Rows[0]["Location"], LocToSelect);
			LocToSelect = LocToSelect.Insert(LocToSelect.Length - 7, " ");
			Console.WriteLine("ILMLOCZIP{0}: {1}", table.Rows[0]["Location"], LocToSelect);

			UIActionExt(By.CssSelector(txtInputChoice1), "ispresent");
			UIActionExt(By.CssSelector(txtInputChoice1), "List", LocToSelect);
			UIActionExt(By.CssSelector(txtRngInputChoice2), "List", table.Rows[0]["Offering"]);

			UIActionExt(By.CssSelector(radioInclApplication), "ispresent");
			UIActionExt(By.CssSelector(radioInclApplication), "click");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLocation), "ispresent");

			string disbtnRemove = driver.FindElement(By.CssSelector("a[id$=':Remove']")).GetAttribute("class");
			string sbtnRemove = disbtnRemove.Replace(" x-item-disabled x-btn-disabled", "");
			sbtnRemove = sbtnRemove + " x-btn-over";
			IWebElement divILMStockLocations = driver.FindElement(By.CssSelector("div[id$=':ILMStockAndLocationsLV-body']"));
			IList<IWebElement> tblLocs = divILMStockLocations.FindElements(By.TagName("table")).ToList();
			IList<IWebElement> ImgChkBox = tblLocs[Convert.ToInt32(table.Rows[0]["Location"]) - 1].FindElements(By.TagName("img")).ToList();
			ImgChkBox[0].Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			ImgChkBox[0].SendKeys(Keys.Space);
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitFor(driver.FindElement(By.CssSelector(btnRemove))).Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
		}
		public void AddBOLocation(Table table)
		{
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtInputShortText1), "Text", table.Rows[0]["Location"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			if (IsElementPresent(driver, By.CssSelector(radioInclApplication)) == true)
			{
				UIActionExt(By.CssSelector(radioInclApplication), "click");
			}
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblILMLocation), "ispresent");

		}
		public void AddBOLocation_BOP(Table table)
		{
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

			UIActionExt(By.CssSelector(txtInputShortText1), "Text", table.Rows[0]["Location"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			if (IsElementPresent(driver, By.CssSelector(radioInclApplication)) == true)
			{
				UIActionExt(By.CssSelector(radioInclApplication), "click");
			}
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblBusinessOwnersLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLocations), "ispresent");
		}
		public void AddBOLocationBldg_BOP(Table table)
		{
			IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblPolicyChange));
			IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("table")).ToList();
			tblTDplcyChng = tblTDplcyChng[0].FindElements(By.TagName("td")).ToList();
			string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtRngInputChoice1), "List", table.Rows[0]["Change"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputChoice2), "List", ScenarioContext.Current["BOPLOCZIP" + table.Rows[0]["Location"]].ToString());
			Console.WriteLine(ScenarioContext.Current["BOPLOCZIP" + table.Rows[0]["Location"]].ToString());
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputNewInteger1), "Text", table.Rows[0]["Building"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(txtInputShortText1), "Text", table.Rows[0]["Coverage"]);
			WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
			UIActionExt(By.CssSelector(btnPolicyChngNext), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			UIActionExt(By.CssSelector("span[id$='button-1005-btnInnerEl']"), "ispresent");
			UIActionExt(By.CssSelector("span[id$='button-1005-btnInnerEl']"), "click");
			UIActionExt(By.CssSelector(lblOfferings), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLineSelection), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblBusinessOwnersLine), "ispresent");
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			UIActionExt(By.CssSelector(lblLocations), "ispresent");
			//NavigatetoBOLocsBuldgs();
			if (table.Rows[0]["Change"].ToString().ToLower() == "removed")
			{
				UIActionExt(By.XPath("//div[text()[contains(.,'" + ScenarioContext.Current["BOPLOCZIP" + table.Rows[0]["Location"]].ToString() + "')]]"), "ispresent");
				UIActionExt(By.XPath("//div[text()[contains(.,'" + ScenarioContext.Current["BOPLOCZIP" + table.Rows[0]["Location"]].ToString() + "')]]"), "click");
				UIActionExt(By.XPath("//div[text()[contains(.,'" + ScenarioContext.Current["BOPLOC" + table.Rows[0]["Location"]].ToString() + "')]]"), "ispresent");
				for (int k = 0; k <= table.Rows.Count - 1; k++)
				{
					IWebElement divBOBuildLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':BOPLocationBuildingsLV-body")));
					IList<IWebElement> tblBOBldgLocs = divBOBuildLocs.FindElements(By.TagName("table")).ToList();
					Console.WriteLine("Table:" + tblBOBldgLocs.Count);
					IList<IWebElement> ImgBOBldChkBox = tblBOBldgLocs[Convert.ToInt32(table.Rows[k]["Building"]) - 1].FindElements(By.TagName("img")).ToList();
					Console.WriteLine("BldgToDelete: " + table.Rows[k]["Building"]);
					Console.WriteLine("imgs" + ImgBOBldChkBox.Count);
					ImgBOBldChkBox[0].Click();
					ImgBOBldChkBox[0].SendKeys(Keys.Space);
					WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 2);
				}
				UIActionExt(By.CssSelector(btnRemove), "click");
				WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 5);
				UIActionExt(By.CssSelector("span[id$=':Prev-btnInnerEl']"), "click");
				UIActionExt(By.CssSelector("span[id$=':BOPLocationsScreen:ttlBar']"), "ispresent");
				WaitUntilElementInvisible(driver, By.CssSelector(lblILMLine), 5);
			}
		}
		public void ChangeStockPeak_JBP(Table table)
		{
			string lnkJewlryStock = "a[id$=':" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":StockDescription'";

			string btnAddCoverage = "span[id$=':ILMJewelryStock_JMICCoveragesPanelSet:ToolbarButton-btnInnerEl']";
			string lnkSteakPeak = "span[id$=':ToolbarButton:0:subItemCoverable-textEl']";
			string txtSteakPeakLimit = "input[id$=':0:ILMCovTermInputSet:DirectTermInput-inputEl']";
			string txtSteakPeakDed = "input[id$='ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:OptionTermInput-inputEl']";
			string txtSteakPeakFrom = "input[id$=':2:FromDate:DateTimeTermInput-inputEl']";
			string txtSteakPeakTo = "input[id$=':3:ToDate:DateTimeTermInput-inputEl']";
			string radioStockPeakRecYes = "input[id$=':4:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_true-inputEl']";
			string radioStockPeakRecNo = "input[id$=':4:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_false-inputEl']";

			//UIAction(lnkJewlryStock, string.Empty, "a");
			//WaitUntilElementVisible(driver, By.CssSelector(lblInventryInfo));
			//UIAction(lnkCoveragesTab, string.Empty, "span");
			//WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
			//UIAction(btnAddCoverage, string.Empty, "span");
			//WaitUntilElementVisible(driver, By.CssSelector(lnkSteakPeak));
			//UIAction(lnkSteakPeak, string.Empty, "span");
			UIActionExt(By.CssSelector(lblILMLocation), "ispresent");
			UIActionExt(By.CssSelector(lnkJewlryStock), "click");
			UIActionExt(By.CssSelector(lblInventryInfo), "ispresent");
			UIActionExt(By.CssSelector(lnkCoveragesTab), "click");
			UIActionExt(By.CssSelector(btnAddCoverage), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnAddCoverage)));
			UIActionExt(By.CssSelector(btnAddCoverage), "click");
			UIActionExt(By.CssSelector(lnkSteakPeak), "ispresent");
			UIActionExt(By.CssSelector(lnkSteakPeak), "click");
			UIActionExt(By.CssSelector(txtSteakPeakLimit), "Text", table.Rows[0]["SteakPeak_Limit"]);
			UIActionExt(By.CssSelector(txtSteakPeakDed), "Text", table.Rows[0]["SteakPeak_Deductible"]);
			UIActionExt(By.CssSelector(txtSteakPeakFrom), "Text", GetCurrSysDate(table.Rows[0]["SteakPeak_StartDate"]));
			UIActionExt(By.CssSelector(txtSteakPeakTo), "Text", GetCurrSysDate(table.Rows[0]["SteakPeak_EndDate"]));

			if (table.Rows[0]["SteakPeak_Recurring"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(radioStockPeakRecYes), "click");
			}
			else if (table.Rows[0]["SteakPeak_Recurring"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(radioStockPeakRecNo), "click");
			}
			UIActionExt(By.CssSelector(btnOK), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnOK)));
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector("span[id$=':ILMLocation_JMICScreen:ttlBar']"), "ispresent");



		}

        public void SetAsPrimary_ILM(Table table)
        {
            System.Threading.Thread.Sleep(5000);
            IWebElement divILMStockLocations = driver.FindElement(By.CssSelector("div[id$=':ILMStockAndLocationsLV-body']"));
            IList<IWebElement> tblLocs = divILMStockLocations.FindElements(By.TagName("table")).ToList();
            IList<IWebElement> ImgChkBox = tblLocs[Convert.ToInt32(table.Rows[0]["Location"]) - 1].FindElements(By.TagName("img")).ToList();
            ImgChkBox[0].Click();
            System.Threading.Thread.Sleep(2000);
            ImgChkBox[0].SendKeys(Keys.Space);
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("span[id$=':ILMLocation_JMICScreen:button1-btnInnerEl']")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        public void DeleteILMLocation_JBP(Table table)
		{
			string disbtnRemove = driver.FindElement(By.CssSelector("a[id$=':Remove']")).GetAttribute("class");
			string sbtnRemove = disbtnRemove.Replace(" x-item-disabled x-btn-disabled", "");
			sbtnRemove = sbtnRemove + " x-btn-over";
			IWebElement divILMStockLocations = driver.FindElement(By.CssSelector("div[id$=':ILMStockAndLocationsLV-body']"));
			IList<IWebElement> tblLocs = divILMStockLocations.FindElements(By.TagName("table")).ToList();
			IList<IWebElement> ImgChkBox = tblLocs[Convert.ToInt32(table.Rows[0]["Location"]) - 1].FindElements(By.TagName("img")).ToList();
			ImgChkBox[0].Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			ImgChkBox[0].SendKeys(Keys.Space);
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
			WaitFor(driver.FindElement(By.CssSelector(btnRemove))).Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
		}
		public void PermChangeAddAddlIntrest_JBP(Table table)
		{
			string lnkILMLocation = "a[id$=':" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":LocationNumber";
			UIAction(lnkILMLocation, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblLocationInfo));
			AddAddlIntrest_Insured("company", "", table);
			WaitUntilElementVisible(driver, By.CssSelector(lblLocationInfo));
			UIAction(btnOK, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(btnILMAddLocation));
		}
		public void PolicyChangeReasonMultiTbl(Table table)
		{
			for (int i = 0; i <= table.RowCount - 1; i++)
			{
				if (i != 0)
				{
					string btnAdd = "span[id$=':Add-btnInnerEl']";
					UIActionExt(By.CssSelector(btnAdd), "click");
				}
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				IWebElement tblsPlcyChng = WaitFor(driver.FindElement(By.CssSelector(tblPolicyChange)));
				IList<IWebElement> tblPlcyChng = tblsPlcyChng.FindElements(By.TagName("table")).ToList();
				IList<IWebElement> tblTDplcyChng = tblPlcyChng[i].FindElements(By.TagName("td")).ToList();
				//tblTDplcyChng[1].Click();
				JavaScriptClick(tblTDplcyChng[1]);
				tblTDplcyChng[1].SendKeys(Keys.Enter);
				driver.FindElement(By.CssSelector(txtPlcyChngReason1)).Click();
				driver.FindElement(By.CssSelector(txtPlcyChngReason1)).Clear();
				driver.FindElement(By.CssSelector(txtPlcyChngReason1)).SendKeys(table.Rows[i]["ChangeReason"]);
				driver.FindElement(By.CssSelector(txtPlcyChngReason1)).SendKeys(Keys.LeftShift + Keys.Tab);

				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));

				tblsPlcyChng = WaitFor(driver.FindElement(By.CssSelector(tblPolicyChange)));
				tblPlcyChng = tblsPlcyChng.FindElements(By.TagName("table")).ToList();
				tblTDplcyChng = tblPlcyChng[i].FindElements(By.TagName("td")).ToList();
				JavaScriptClick(tblTDplcyChng[2]);
				//tblTDplcyChng[2].Click();
				tblTDplcyChng[2].SendKeys(Keys.Enter);
				driver.FindElement(By.CssSelector(txtPlcyChngReason2)).Click();
				driver.FindElement(By.CssSelector(txtPlcyChngReason2)).Clear();
				driver.FindElement(By.CssSelector(txtPlcyChngReason2)).SendKeys(table.Rows[i]["ChangeReasonNext"]);
				driver.FindElement(By.CssSelector(txtPlcyChngReason2)).SendKeys(Keys.LeftShift + Keys.Tab);

				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));

				tblsPlcyChng = WaitFor(driver.FindElement(By.CssSelector(tblPolicyChange)));
				tblPlcyChng = tblsPlcyChng.FindElements(By.TagName("table")).ToList();
				tblTDplcyChng = tblPlcyChng[i].FindElements(By.TagName("td")).ToList();
				//tblTDplcyChng[3].Click();
				JavaScriptClick(tblTDplcyChng[3]);
				tblTDplcyChng[3].SendKeys(Keys.Enter);
				driver.FindElement(By.CssSelector(txtPlcyChngReason3)).Click();
				driver.FindElement(By.CssSelector(txtPlcyChngReason3)).Clear();
				driver.FindElement(By.CssSelector(txtPlcyChngReason3)).SendKeys(table.Rows[i]["ChangeReasonCategory"]);
				driver.FindElement(By.CssSelector(txtPlcyChngReason3)).SendKeys(Keys.LeftShift + Keys.Tab);

				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
				WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));

				tblsPlcyChng = WaitFor(driver.FindElement(By.CssSelector(tblPolicyChange)));
				tblPlcyChng = tblsPlcyChng.FindElements(By.TagName("table")).ToList();
				tblTDplcyChng = tblPlcyChng[i].FindElements(By.TagName("td")).ToList();
				string descDatdaColId = "td[id='" + tblTDplcyChng[4].GetAttribute("data-columnid") + "']";
				Console.WriteLine(descDatdaColId);
				if (table.Rows[i]["Integer1"].ToString() != "")
				{
					string txtInteger1 = "input[id$=':InputInteger1-inputEl']";
					UIActionExt(By.CssSelector(txtInteger1), "Text", table.Rows[i]["Integer1"]);
					WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
				}
				if (table.Rows[i]["Integer2"].ToString() != "")
				{
					string txtInteger2 = "input[id$=':InputInteger2-inputEl']";
					UIActionExt(By.CssSelector(txtInteger2), "Text", table.Rows[i]["Integer2"]);
					WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
				}
				if (table.Rows[i]["Integer3"].ToString() != "")
				{
					string txtInteger3 = "input[id$=':InputInteger3-inputEl']";
					UIActionExt(By.CssSelector(txtInteger3), "Text", table.Rows[i]["Integer3"]);
					WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

				}
				if (table.Rows[i]["ShortText1"].ToString() != "")
				{
					string txtShortText1 = "input[id$=':InputShortText1-inputEl']";
					UIActionExt(By.CssSelector(txtShortText1), "Text", table.Rows[i]["ShortText1"]);
					WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
				}
				if (table.Rows[i]["ShortText2"].ToString() != "")
				{
					string txtShortText2 = "input[id$=':InputShortText2-inputEl']";
					UIActionExt(By.CssSelector(txtShortText2), "Text", table.Rows[i]["ShortText2"]);
					WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));

				}
				if (table.Rows[i]["MediumText1"].ToString() != "")
				{
					string txtMeduimText1;
					if (i == 3)
					{
						txtMeduimText1 = "textarea[id$=':TextAreaMediumText1-inputEl']";
					}
					else
					{
						txtMeduimText1 = "input[id$=':InputMediumText1-inputEl']";
					}
					UIActionExt(By.CssSelector(txtMeduimText1), "Text", table.Rows[i]["MediumText1"]);
					WaitUntilElementInvisible(driver, By.CssSelector(descDatdaColId));
				}
			}

			string lblLineSelection = "span[id$=':CPPLineSelectionScreen:ttlBar']";
			string lblPolicyInfo = "span[id$='PolicyInfoScreen:ttlBar']";
			string lblILMLine = "span[id$=':ILMLineCoveragesScreen:ttlBar']";
			UIActionExt(By.CssSelector(btnPolicyChngNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblLineSelection));
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblPolicyInfo));
			UIActionExt(By.CssSelector(btnPolicyChangeNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblILMLine));
		}
		public void AddTempCovgs(Table table)
		{
			string tabTempCovrgs = "a[id$=':ILMLineCoveragesScreen:OneTimeCoveragesTab']";
			string lblTempCovg = "span[id$=':ILMLineCoveragesPanelSet:1']";
			string lblChngReason = "span[id$='PolicyChangeReason_JMICPopup:0']";
			UIAction(tabTempCovrgs, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblTempCovg));
			string sCovgLimit = "";
			for (int i = 0; i <= table.RowCount - 1; i++)
			{
				string lnkSubTab, lstCategory, txtFromTravel, txtToTravel, txtLimit, lstDed, txtWP, lnkSearchReason;
				string btnSelectReason, lstCarrierName, txtDed, CovgLimit, txtCoverageDesc;
				string btnAddCoverage = "a[id$=':OneTimeCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton']";
				WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
				ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnAddCoverage)));
				UIAction(btnAddCoverage, string.Empty, "a");
				switch (table.Rows[i]["TempCoverage"].ToLower())
				{
					case "off premise travel":
						lnkSubTab = "a[id$=':ToolbarButton:2:subItemCoverable-itemEl']";
						WaitUntilElementVisible(driver, By.CssSelector(lnkSubTab));
						UIAction(lnkSubTab, string.Empty, "a");
						lstCategory = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:TypekeyTermInput-inputEl']";
						txtFromTravel = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:FromDate:DateTimeTermInput-inputEl']";
						txtToTravel = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ToDate:DateTimeTermInput-inputEl']";
						txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput-inputEl']";
						lstDed = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:ILMCovTermInputSet:OptionTermInput-inputEl']";
						txtWP = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:5:ILMCovTermInputSet:DirectTermInput-inputEl']";
						lnkSearchReason = "div[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
						btnSelectReason = "a[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:2:_Select']";
						if (IsElementPresent(driver, By.CssSelector(lstCategory)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(lstCategory), 10);
						}
						UIActionExt(By.CssSelector(lstCategory), "Text", "Inside Territory");
						UIActionExt(By.CssSelector(txtFromTravel), "Text", GetCurrSysDate("SYSTEMDATE"));
						UIActionExt(By.CssSelector(txtToTravel), "Text", GetCurrSysDate("SYSTEMDATE+30"));
						UIActionExt(By.CssSelector(txtLimit), "Text", "200000");
						UIActionExt(By.CssSelector(lstDed), "Text", "2,500");
						UIActionExt(By.CssSelector(txtWP), "Text", "200000");

						UIActionExt(By.CssSelector(lnkSearchReason), "click");
						WaitUntilElementVisible(driver, By.CssSelector(lblChngReason));
						UIActionExt(By.CssSelector(btnSelectReason), "click");
						WaitUntilElementVisible(driver, By.CssSelector(lblTempCovg));
						break;
					case "shipments inside territory":
						lnkSubTab = "a[id$=':ToolbarButton:4:subItemCoverable-itemEl']";
						WaitUntilElementVisible(driver, By.CssSelector(lnkSubTab));
						UIAction(lnkSubTab, string.Empty, "a");
						lstCarrierName = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:TempEndShipInTerrSubCat_JMIC:TypekeyTermInput-inputEl']";
						txtFromTravel = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:FromDate:DateTimeTermInput-inputEl']";
						txtToTravel = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ToDate:DateTimeTermInput-inputEl']";
						txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput-inputEl']";
						txtDed = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:ILMCovTermInputSet:DirectTermInput-inputEl']";
						CovgLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:6:ILMCovTermInputSet:DirectTermInput-inputEl']";
						lnkSearchReason = "div[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
						btnSelectReason = "a[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:1:_Select']";
						if (IsElementPresent(driver, By.CssSelector(lstCarrierName)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(lstCarrierName), 10);
						}
						ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(lstCarrierName)));
						UIActionExt(By.CssSelector(lstCarrierName), "ispresent");
						sCovgLimit = CovgLimit;
						UIActionExt(By.CssSelector(lstCarrierName), "Text", "Fed Ex");
						UIActionExt(By.CssSelector(txtFromTravel), "Text", GetCurrSysDate("SYSTEMDATE"));
						UIActionExt(By.CssSelector(txtToTravel), "Text", GetCurrSysDate("SYSTEMDATE+30"));
						UIActionExt(By.CssSelector(txtLimit), "Text", "200000");
						UIActionExt(By.CssSelector(txtDed), "Text", "200");
						UIActionExt(By.CssSelector(CovgLimit), "Text", "200000");

						UIActionExt(By.CssSelector(lnkSearchReason), "click");
						WaitUntilElementVisible(driver, By.CssSelector(lblChngReason));
						UIActionExt(By.CssSelector(btnSelectReason), "click");
						WaitUntilElementVisible(driver, By.CssSelector(lblTempCovg));

						break;
					case "shipments outside territory":
						lnkSubTab = "a[id$=':ToolbarButton:5:subItemCoverable-itemEl']";
						WaitUntilElementVisible(driver, By.CssSelector(lnkSubTab));
						UIAction(lnkSubTab, string.Empty, "a");
						lstCarrierName = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:TypekeyTermInput-inputEl']";
						txtFromTravel = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:FromDate:DateTimeTermInput-inputEl']";
						txtToTravel = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ToDate:DateTimeTermInput-inputEl']";
						txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput-inputEl']";
						txtDed = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:ILMCovTermInputSet:DirectTermInput-inputEl']";
						CovgLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:6:ILMCovTermInputSet:DirectTermInput-inputEl']";
						lnkSearchReason = "div[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
						btnSelectReason = "a[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:0:_Select']";
						if (IsElementPresent(driver, By.CssSelector(lstCarrierName)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(lstCarrierName), 10);
						}
						ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(lstCarrierName)));
						UIActionExt(By.CssSelector(lstCarrierName), "ispresent");
						UIActionExt(By.CssSelector(lstCarrierName), "Text", "Fed Ex");
						UIActionExt(By.CssSelector(txtFromTravel), "Text", GetCurrSysDate("SYSTEMDATE"));
						UIActionExt(By.CssSelector(txtToTravel), "Text", GetCurrSysDate("SYSTEMDATE+30"));
						UIActionExt(By.CssSelector(txtLimit), "Text", "200000");
						UIActionExt(By.CssSelector(txtDed), "Text", "200");
						UIActionExt(By.CssSelector(CovgLimit), "Text", "200000");

						UIActionExt(By.CssSelector(lnkSearchReason), "click");
						WaitUntilElementVisible(driver, By.CssSelector(lblChngReason));
						UIActionExt(By.CssSelector(btnSelectReason), "click");
						WaitUntilElementVisible(driver, By.CssSelector(lblTempCovg));


						break;
					case "all other":
						lnkSubTab = "a[id$='ToolbarButton:0:subItemCoverable-itemEl']";
						WaitUntilElementVisible(driver, By.CssSelector(lnkSubTab));
						UIAction(lnkSubTab, string.Empty, "a");
						txtCoverageDesc = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:StringTermInput-inputEl']";
						txtFromTravel = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:FromDate:DateTimeTermInput-inputEl']";
						txtToTravel = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ToDate:DateTimeTermInput-inputEl']";
						txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput-inputEl']";
						txtWP = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:5:ILMCovTermInputSet:DirectTermInput-inputEl']";
						lnkSearchReason = "div[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
						btnSelectReason = "a[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:3:_Select']";

						if (IsElementPresent(driver, By.CssSelector(txtCoverageDesc)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(txtCoverageDesc), 10);
						}
						ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(txtCoverageDesc)));
						UIActionExt(By.CssSelector(txtCoverageDesc), "ispresent");

						UIActionExt(By.CssSelector(txtCoverageDesc), "Text", "Test Automation");
						UIActionExt(By.CssSelector(txtFromTravel), "Text", GetCurrSysDate("SYSTEMDATE"));
						UIActionExt(By.CssSelector(txtToTravel), "Text", GetCurrSysDate("SYSTEMDATE+30"));
						UIActionExt(By.CssSelector(txtLimit), "Text", "200000");
						UIActionExt(By.CssSelector(txtWP), "Text", "200");


						UIActionExt(By.CssSelector(lnkSearchReason), "click");
						WaitUntilElementVisible(driver, By.CssSelector(lblChngReason));
						UIActionExt(By.CssSelector(btnSelectReason), "click");
						WaitUntilElementVisible(driver, By.CssSelector(lblTempCovg));

						break;
					default:
						break;
				}
			}
			UIActionExt(By.CssSelector(sCovgLimit), "List", "200000");
		}
		public void ClickQuote()
		{
			string btnQuote = "span[id$=':QuoteOrReview-btnInnerEl']";
			string lblQuote = "span[id$='PolicyChangeWizard:PolicyChangeWizard_MultiLine_QuoteScreen:ttlBar']";
			string btnIssuePolicy = "span[id$=':JobWizardToolbarButtonSet:BindPolicyChange-btnInnerEl']";
			string btnOK = "a[id='button-1005']";
			string lnkPolicy = "div[id='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";

			if (IsElementPresent(driver, By.CssSelector(btnQuote)) == false)
			{
				WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
			}
			UIAction(btnQuote, string.Empty, "span");
			UIActionExt(By.CssSelector(lblQuote), "ispresent", "", 0, 80, 5);
			UIAction(btnIssuePolicy, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(btnOK));
			driver.FindElement(By.CssSelector(btnOK)).Click();
			UIActionExt(By.CssSelector(lnkPolicy), "ispresent", "", 0, 60, 5);

		}

        public void PlcyRenew_ClickQuote_Issue()
        {
            string btnQuote = "span[id$=':RenewalQuote-btnInnerEl']";
            string lblQuote = "span[id$='RenewalWizard:PostQuoteWizardStepSet:RenewalWizard_MultiLine_QuoteScreen:ttlBar']";
            string btnBindPolicy = "span[id$=':BindOptions-btnInnerEl']";
            //
            string btnIssuePolicy = "span[id$=':BindOptions:IssueNow-textEl']";
            string btnOK = "a[id='button-1005']";
            string lnkPolicy = "div[id='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";

            if (IsElementPresent(driver, By.CssSelector(btnQuote)) == false)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            }
            UIActionExt(By.CssSelector(btnQuote), "click");
            UIActionExt(By.CssSelector(lblQuote), "ispresent", "", 0, 80, 5);
            UIActionExt(By.CssSelector(btnBindPolicy), "click");
            UIActionExt(By.CssSelector(btnIssuePolicy), "click");
            WaitUntilElementVisible(driver, By.CssSelector(btnOK));
            driver.FindElement(By.CssSelector(btnOK)).Click();
            UIActionExt(By.CssSelector(lnkPolicy), "ispresent", "", 0, 60, 5);

        }
        public void GetLocAddr_ILM()
		{
			string LocAddress;
			string LocAddr;
			string LocAddrZip;
			string lnkLocations = "//span[text()='Locations']";
			string lblPFSummary = "span[id$=':Policy_SummaryScreen:0']";
			string lblPFLocations = "span[id$=':PolicyFile_LocationsScreen:ttlBar']";
			WaitUntilElementVisible(driver, By.CssSelector(lblPFSummary));
			driver.FindElement(By.XPath(lnkLocations)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lblPFLocations));

			IWebElement tblbodyBOLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':LocationsEdit_DP:LocationsEdit_LV-body']")));
			IList<IWebElement> tblBOLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
			for (int i = 0; i <= tblBOLocs.Count - 1; i++)
			{
				LocAddress = "a[id$=':LocationsEdit_LV:" + i + ":Address']";
				LocAddrZip = driver.FindElement(By.CssSelector(LocAddress)).Text;
				int j = i + 1;
				char[] dSpace = { ' ' }, dComma = { ',' };
				string[] SplitBySpace = LocAddrZip.Split(dSpace);
				string CompZipCode = SplitBySpace[SplitBySpace.Length - 1];
				string LocAddrNoAddr1 = "";
				LocAddr = LocAddrZip.Replace(CompZipCode, "").TrimEnd();
				string[] SplitByComma = LocAddr.Split(dComma);
				if (SplitByComma.Length > 3)
				{
					for (int k = 0; k < SplitByComma.Length; k++)
					{
						if (k != 1)
							if (k == 0)
								LocAddrNoAddr1 = SplitByComma[k];
							else
								LocAddrNoAddr1 = LocAddrNoAddr1 + "," + SplitByComma[k];
					}
				}
				else
				{
					LocAddrNoAddr1 = LocAddr;
				}

				if (ScenarioContext.Current.ContainsKey("LOC" + j) == true)
				{
					if (ScenarioContext.Current["LOC" + j].ToString() != LocAddrNoAddr1)
					{
						ScenarioContext.Current["LOC" + j] = LocAddrNoAddr1;
					}
				}
				else
				{
					ScenarioContext.Current.Add("LOC" + j, LocAddrNoAddr1);
				}
				if (ScenarioContext.Current.ContainsKey("LOCZIP" + j) == true)
				{
					if (ScenarioContext.Current["LOCZIP" + j].ToString() != LocAddrZip)
					{
						ScenarioContext.Current["LOCZIP" + j] = LocAddrZip;
					}
				}
				else
				{
					ScenarioContext.Current.Add("LOCZIP" + j, LocAddrZip);
				}
			}
		}

		public string GetUniqueValue()
		{
			DateTime myDateTime = DateTime.Now;
			string day = myDateTime.Day.ToString();
			string hour = myDateTime.Hour.ToString();
			string minute = myDateTime.Minute.ToString();
			string second = myDateTime.Second.ToString();
			string GetUniqueValue = day + hour + minute + second;
			return GetUniqueValue;
		}
		public void GetLocAddress()
		{
			string lblPolicySummary = "span[id$='PolicyFile_Summary:Policy_SummaryScreen:0']";
			WaitUntilElementVisible(driver, By.CssSelector(lblPolicySummary));
			string sLOB = driver.FindElement(By.XPath("//span[@id='PolicyFile:PolicyFileMenuInfoBar:InfoBarElementOffering-btnInnerEl']/span[2]")).Text;
			//Console.WriteLine(sLOB);
			switch (sLOB)
			{
				case "Businessowners":
				case "BOP Select - Property Only":
					GetLocAddress_BOP();
					break;
				case "Jewelers Block":
				case "Jewelers Standard":
					GetLocAddress_ILM();
					break;
				case "Jewelers Block Pak":
				case "Jewelers Standard Pak":
					GetLocAddress_ILM();
					GetLocAddress_BOP();
					break;
				default:
					Console.WriteLine("unknown LOB type");
					break;
			}
			foreach (var KeyValuePair in ScenarioContext.Current)
			{
				if (KeyValuePair.Key.Contains("LOC"))
				{
					Console.WriteLine("Key = {0}, Value = {1}", KeyValuePair.Key, KeyValuePair.Value);
				}
			}
		}
		public void GetLocAddress_ILM()
		{
			string LocAddress;
			string lnkLocations = "//span[text()='Inventory and Locations']";
			string lblPFLocations = "span[id$='PolicyFile_ILMJewelryStock:ttlBar']";
			string lblLocInfoTitle = "span[id$='ILMLocation_JMICPopup:ttlBar']";
			string lblLocInfo = "div[id$=':LocationInfo-inputEl']";
			string lblLocAddr = "div[id$=':AddressSummary-inputEl']";
			string lnkReturn = "//a[text()='Return to Inventory and Locations']";
			driver.FindElement(By.XPath(lnkLocations)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lblPFLocations));

			IWebElement tblbodyBOLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':ILMJewelryStock_JMICPanelSet:ILMLocationsLV-body']")));
			IList<IWebElement> tblBOLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
			string TotILMLocCount = tblBOLocs.Count.ToString();

			if (ScenarioContext.Current.ContainsKey("TOTILMLOCS") == true)
			{
				Console.WriteLine(ScenarioContext.Current["TOTILMLOCS"].ToString());
				if (ScenarioContext.Current["TOTILMLOCS"].ToString() != TotILMLocCount)
				{
					ScenarioContext.Current["TOTILMLOCS"] = TotILMLocCount;
				}
			}
			else
			{
				ScenarioContext.Current.Add("TOTILMLOCS", TotILMLocCount);
			}
			for (int i = 0; i <= tblBOLocs.Count - 1; i++)
			{
				LocAddress = "a[id$=':ILMLocationsLV:" + i + ":LocationName']";
				driver.FindElement(By.CssSelector(LocAddress)).Click();
				WaitUntilElementVisible(driver, By.CssSelector(lblLocInfoTitle));
				string LocAddrNoAddr1 = driver.FindElement(By.CssSelector(lblLocInfo)).Text;
				string LocAddrZip = driver.FindElement(By.CssSelector(lblLocAddr)).Text.Replace(System.Environment.NewLine, ", ");
				driver.FindElement(By.XPath(lnkReturn)).Click();
				WaitUntilElementVisible(driver, By.CssSelector(lblPFLocations));
				string sScrCont1 = "ILMLOC" + (i + 1).ToString();
				string sScrCont2 = "ILMLOCZIP" + (i + 1).ToString();
				if (ScenarioContext.Current.ContainsKey(sScrCont1) == true)
				{
					if (ScenarioContext.Current[sScrCont1].ToString() != LocAddrNoAddr1)
					{
						ScenarioContext.Current[sScrCont1] = LocAddrNoAddr1;
					}
				}
				else
				{
					ScenarioContext.Current.Add(sScrCont1, LocAddrNoAddr1);
				}
				if (ScenarioContext.Current.ContainsKey(sScrCont2) == true)
				{
					if (ScenarioContext.Current[sScrCont2].ToString() != LocAddrZip)
					{
						ScenarioContext.Current[sScrCont2] = LocAddrZip;
					}
				}
				else
				{
					ScenarioContext.Current.Add(sScrCont2, LocAddrZip);
				}
			}
		}
		public void GetLocAddress_BOP()
		{
			string LocAddress;
			string lnkLocations = "//span[text()='Locations']";
			string lblPFLocations = "span[id$=':PolicyFile_LocationsScreen:ttlBar']";
			string lblLocInfoTitle = "span[id$='BOPLocationPopup:LocationScreen:ttlBar']";
			string lblLocInfo = "div[id$=':LocationInfo-inputEl']";
			string lblLocAddr = "div[id$=':AddressSummary-inputEl']";
			string lnkReturn = "//a[text()='Return to Locations']";

			driver.FindElement(By.XPath(lnkLocations)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lblPFLocations));

			IWebElement tblbodyBOLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':LocationsEdit_DP:LocationsEdit_LV-body']")));
			IList<IWebElement> tblBOLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
			string TotILMLocCount = tblBOLocs.Count.ToString();
			if (ScenarioContext.Current.ContainsKey("BOPTOTLOCS") == true)
			{
				if (ScenarioContext.Current["BOPTOTLOCS"].ToString() != TotILMLocCount)
				{
					ScenarioContext.Current["BOPTOTLOCS"] = TotILMLocCount;
				}
			}
			else
			{
				ScenarioContext.Current.Add("BOPTOTLOCS", TotILMLocCount);
			}
			for (int i = 0; i <= tblBOLocs.Count - 1; i++)
			{
				LocAddress = "a[id$=':LocationsEdit_LV:" + i + ":Address']";
				driver.FindElement(By.CssSelector(LocAddress)).Click();
				WaitUntilElementVisible(driver, By.CssSelector(lblLocInfoTitle));
				string LocAddrNoAddr1 = driver.FindElement(By.CssSelector(lblLocInfo)).Text;
				string LocAddrZip = driver.FindElement(By.CssSelector(lblLocAddr)).Text.Replace(System.Environment.NewLine, ", ");
				driver.FindElement(By.XPath(lnkReturn)).Click();
				WaitUntilElementVisible(driver, By.CssSelector(lblPFLocations));
				string sScrCont1 = "BOPLOC" + (i + 1).ToString();
				string sScrCont2 = "BOPLOCZIP" + (i + 1).ToString();

				if (ScenarioContext.Current.ContainsKey(sScrCont1) == true)
				{
					if (ScenarioContext.Current[sScrCont1].ToString() != LocAddrNoAddr1)
					{
						ScenarioContext.Current[sScrCont1] = LocAddrNoAddr1;
					}
				}
				else
				{
					ScenarioContext.Current.Add(sScrCont1, LocAddrNoAddr1);
				}
				if (ScenarioContext.Current.ContainsKey(sScrCont2) == true)
				{
					if (ScenarioContext.Current[sScrCont2].ToString() != LocAddrZip)
					{
						ScenarioContext.Current[sScrCont2] = LocAddrZip;
					}
				}
				else
				{
					ScenarioContext.Current.Add(sScrCont2, LocAddrZip);
				}
			}
		}
		public string GetCurrSysDate(string DateCondition)
		{

			var sDate = "";
			DateTime CurrentDate = DateTime.Now;
			IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
			if (DateCondition.ToLower().ToString() == "systemdate")
			{
				DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
				sDate = tempRetroDate.ToShortDateString();
			}
			else if (DateCondition.ToLower() == "currentdate")
			{
				sDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
			}
			else if (DateCondition.Contains("+"))
			{
				string[] details = DateCondition.Split('+');
				if (DateCondition.ToLower().ToString().Contains("systemdate"))
				{
					DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
					sDate = string.Format("{0:MM/dd/yyyy}", tempRetroDate.AddDays(Int32.Parse(details[1])));
				}
				else
				{
					sDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));
				}
			}
			else if (DateCondition.Contains("-"))
			{
				string[] details = DateCondition.Split('-');
				if (DateCondition.ToLower().ToString().Contains("systemdate"))
				{
					DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
					sDate = string.Format("{0:MM/dd/yyyy}", tempRetroDate.AddDays(Int32.Parse("-" + details[1])));
				}
				else
				{
					sDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));
				}
			}
			else
			{
				sDate = DateCondition;
			}

			return sDate;
		}
		public CL_PolicyChange_PC9(IWebDriver driver) : base(driver)
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

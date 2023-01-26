
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_BOLocations_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lnkLocation = "a[id$=':LocationsEdit_LV:0:Loc']";
		string EditTerritoryCode = "input[id$=':LocationDetailInputSet:TerritoryCode-inputEl']";
		string btnOK = "span[id$=':Update-btnInnerEl']";
		string txtAddress1 = "input[id$=':GlobalAddressInputSet:AddressLine1-inputEl']";
		string btnBldgAdd = "span[id$=':BOPLocationBuildingsLV_tb:Add-btnInnerEl']";

		string AddressLine1 = "input[id$=':AddressLine1-inputEl']";
		string City = "input[id$=':City-inputEl']";
		string ZipCode = "input[id$=':PostalCode-inputEl']";
		string State = "input[id$=':State-inputEl']";
		string Country = "input[id$=':Country-inputEl']";
		string btnLocScreenOK = "a[id$=':LocationScreen:Update']";
		string locAddrInfo = "div[id$=':LocationInfo-inputEl']";
		string btnNewLocation = "span[id$=':Add-btnInnerEl']";

		string TerrorProp = "input[id$=':TerrorismTerritoryProp-inputEl']";
		string TerrorLiab = "input[id$=':TerrorismTerritoryLiab-inputEl']";
		string txtFullTimeEmp = "input[id$=':FullTimeEmployees_JMIC-inputEl']";
		string txtPartTimeEmp = "input[id$=':PartTimeEmployees_JMIC-inputEl']";
		string lstPublicProtection = "input[id$=':PublicProtection_JMIC-inputEl']";
		string lstLocationType = "input[id$=':LocationType_JMIC-inputEl']";
		string txtRetailPercent = "input[id$=':Retail_JMIC-inputEl']";
		string txtCastingPercent = "input[id$=':Casting_JMIC-inputEl']";

		public void BOLOcationSetTerritoryCode(string Territory)
		{
			UIActionExt(By.CssSelector(lnkLocation), "ispresent");
			UIActionExt(By.CssSelector(lnkLocation), "click");
			UIActionExt(By.CssSelector(EditTerritoryCode), "ispresent");
			UIActionExt(By.CssSelector(EditTerritoryCode), "Text", Territory);
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(lnkLocation), "ispresent");
			if (IsElementPresent(driver, By.CssSelector(lnkLocation)) == false)
			{
				WaitUntilElementVisible(driver, By.CssSelector(lnkLocation), 10);
			}
		}

		public void BOLOcationSetTerritoryCode(Table table)
		{
			string imgTMagnifier = "div[id$=':TerritoryCode:SelectTerritoryCode']";
			string txtZipCode = "input[id$=':GlobalAddressInputSet:PostalCode-inputEl']";
			string btnReset = "a[id$=':Reset']";
			string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
			string btnFirstSearch = "a[id$=':TerritoryCodeSearchResultsLV:0:_Select']";
			for (int i = 0; i <= table.RowCount - 1; i++)
			{
				string lnkLocation = "a[id$=':LocationsEdit_LV:" + (Convert.ToInt16(table.Rows[i]["Location"]) - 1) + ":Loc']";
				UIActionExt(By.CssSelector(lnkLocation), "ispresent");
				UIActionExt(By.CssSelector(lnkLocation), "click");
				UIActionExt(By.CssSelector(txtAddress1), "ispresent");
				UIActionExt(By.CssSelector(imgTMagnifier), "click");
				UIActionExt(By.CssSelector(btnReset), "click");
				UIActionExt(By.CssSelector(txtZipCode), "Text", "");
				UIActionExt(By.CssSelector(btnSearch), "click");
				UIActionExt(By.CssSelector(btnFirstSearch), "ispresent");
				UIActionExt(By.CssSelector(btnFirstSearch), "click");
				UIActionExt(By.CssSelector(State), "ispresent");
				if (IsElementPresent(driver, By.CssSelector(TerrorProp)) == true)
				{
					UIActionExt(By.CssSelector(TerrorProp), "Text", "001");
				}
				if (IsElementPresent(driver, By.CssSelector(TerrorLiab)) == true)
				{
					UIActionExt(By.CssSelector(TerrorLiab), "Text", "001");
				}
				UIActionExt(By.CssSelector(btnOK), "click");
				UIActionExt(By.CssSelector(lnkLocation), "ispresent");
			}
		}
		public void ClickNext()
		{
			UIActionExt(By.CssSelector(btnNext), "click");
			UIActionExt(By.CssSelector(btnBldgAdd), "ispresent");
		}

		public void ClickNewLocation()
		{
			UIActionExt(By.CssSelector(btnNewLocation), "click", "", 0, 10);
			UIActionExt(By.CssSelector(txtAddress1), "ispresent");
		}

		public void AddBOLoactionDetails(Table table)
		{
			UIActionExt(By.CssSelector(AddressLine1), "ispresent");
			string sUSA = "united states of america";
			ScenarioContext.Current["country"] = table.Rows[0]["Country"];
			if (string.Equals(table.Rows[0]["Country"].ToLower(), sUSA) == false)
			{
				UIActionExt(By.CssSelector(Country), "List", table.Rows[0]["Country"]);
			}
			UIActionExt(By.CssSelector(AddressLine1), "Text", table.Rows[0]["AddressLine1"]);
			UIActionExt(By.CssSelector(City), "Text", table.Rows[0]["City"]);
			UIActionExt(By.CssSelector(State), "ispresent");
			UIActionExt(By.CssSelector(State), "List", table.Rows[0]["State"]);
			WaitUntilElementInvisible(driver, By.CssSelector(btnBldgAdd));
			UIActionExt(By.CssSelector(ZipCode), "List", table.Rows[0]["ZipCode"]);
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
			if (IsElementPresent(driver, By.CssSelector(TerrorProp)) == true)
			{
				UIActionExt(By.CssSelector(TerrorProp), "Text", "001");
			}
			if (IsElementPresent(driver, By.CssSelector(TerrorLiab)) == true)
			{
				UIActionExt(By.CssSelector(TerrorLiab), "Text", "001");
			}
			AddBOLocDetailsNoAddr(table);
		}
		public void BOAddLocation(Table table)
		{
			string lnkBOLocation = "a[id$=':LocationsEdit_LV:" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":Loc";
			UIActionExt(By.CssSelector(lnkBOLocation), "click");
			UIActionExt(By.CssSelector(txtAddress1), "ispresent");
		}
		public void AddBOLocDetailsNoAddr(Table table)
		{
			UIActionExt(By.CssSelector(txtRetailPercent), "Text", table.Rows[0]["RetailPercent"]);
			UIActionExt(By.CssSelector(txtCastingPercent), "Text", table.Rows[0]["CastingPercent"]);
			UIActionExt(By.CssSelector(txtFullTimeEmp), "Text", table.Rows[0]["FullTimeEmp"]);
			UIActionExt(By.CssSelector(txtPartTimeEmp), "Text", table.Rows[0]["PartTimeEmp"]);
			UIActionExt(By.CssSelector(lstPublicProtection), "Text", table.Rows[0]["PublicProtection"]);
			UIActionExt(By.CssSelector(lstLocationType), "Text", table.Rows[0]["LocationType"]);
			UIActionExt(By.CssSelector(btnLocScreenOK), "click");
			if (driver.FindElements(By.XPath("//div[contains(text(), 'Missing required field')]")).Count>0) 
            {
				UIActionExt(By.CssSelector(txtRetailPercent), "Text", table.Rows[0]["RetailPercent"]);
				UIActionExt(By.CssSelector(txtCastingPercent), "Text", table.Rows[0]["CastingPercent"]);
				UIActionExt(By.CssSelector(txtFullTimeEmp), "Text", table.Rows[0]["FullTimeEmp"]);
				UIActionExt(By.CssSelector(txtPartTimeEmp), "Text", table.Rows[0]["PartTimeEmp"]);
				UIActionExt(By.CssSelector(lstPublicProtection), "Text", table.Rows[0]["PublicProtection"]);
				UIActionExt(By.CssSelector(lstLocationType), "Text", table.Rows[0]["LocationType"]);
				UIActionExt(By.CssSelector(btnLocScreenOK), "click");
			}
			UIActionExt(By.CssSelector(btnNewLocation), "ispresent");
		}

		public void AddBOLocEcommCovg(Table table)
		{
			string lnkAddAddlCovg = "span[id$=':AdditionalCoveragesCardTab-btnInnerEl']";
			string btnAddAddlCovg = "span[id$=':BOPCoveragesDV_tb:Add-btnInnerEl']";
			string txtKeyword = "input[id$=':Keyword-inputEl']";
			string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
			string btnAddSelecCovg = "span[id$=':AddCoverageButton-btnInnerEl']";
			string lnkLocation = "a[id$=':LocationsEdit_LV:" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":Loc']";

			string lnkCovgQues = "span[id$=':CoverageQuestionsCardTab-btnInnerEl']";

			string txtAnnlAggLimit = "input[id$=':1:BOPCoverageInputSet:CovPatternInputGroup:0:CovTermInputSet:DirectTermInput1:CovTermDirectInputSet:DirectTermInput-inputEl']";
			string LstHazardGrp = "input[id$=':1:BOPCoverageInputSet:CovPatternInputGroup:5:CovTermInputSet:TypekeyTermInput-inputEl']";
			UIActionExt(By.CssSelector(lnkLocation), "ispresent");
			UIActionExt(By.CssSelector(lnkLocation), "click");
			//WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 3);
			UIActionExt(By.CssSelector(lnkAddAddlCovg), "ispresent");
			UIActionExt(By.CssSelector(lnkAddAddlCovg), "click");
			UIActionExt(By.CssSelector(btnAddAddlCovg), "ispresent");
			UIActionExt(By.CssSelector(btnAddAddlCovg), "click");

			UIActionExt(By.CssSelector(txtKeyword), "ispresent");
			UIActionExt(By.CssSelector(txtKeyword), "Text", table.Rows[0]["Keyword"]);
			WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 1);
			UIActionExt(By.CssSelector(btnSearch), "click");
			WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 5);

			IWebElement divBOBuildLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':CoveragePatternSearchResultsLV-body")));
			IList<IWebElement> tblBOBldgLocs = divBOBuildLocs.FindElements(By.TagName("table")).ToList();
			IList<IWebElement> ImgBOBldChkBox = tblBOBldgLocs[0].FindElements(By.TagName("img")).ToList();
			ImgBOBldChkBox[0].Click();
			ImgBOBldChkBox[0].SendKeys(Keys.Space);
			WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 2);
			UIActionExt(By.CssSelector(btnAddSelecCovg), "click");
			UIActionExt(By.CssSelector(txtAnnlAggLimit), "ispresent");
			UIActionExt(By.CssSelector(txtAnnlAggLimit), "Text", table.Rows[0]["AnnualAggLimit"]);
			UIActionExt(By.CssSelector(LstHazardGrp), "List", table.Rows[0]["HazardGroup"]);

			UIActionExt(By.CssSelector(lnkCovgQues), "click");
			UIActionExt(By.XPath("//label[text()[contains(.,'BOP Loc E-Commerce Information')]]"), "ispresent");
			IWebElement divCyberQ = WaitFor(driver.FindElement(By.CssSelector("div[id$=':covQns:QuestionSetsDV:0:QuestionSetLV-body")));
			IList<IWebElement> tblCyberQ = divCyberQ.FindElements(By.CssSelector("input[inputvalue='false']")).ToList();
			for (int i = 0; i <= tblCyberQ.Count - 1; i++)
			{
				JavaScriptClick(tblCyberQ[i]);
				WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 2);
			}
			UIActionExt(By.CssSelector(btnLocScreenOK), "click");
			UIActionExt(By.CssSelector(btnNewLocation), "ispresent");
		}
		public void AddBOLocMSVCovg(Table table)
		{
			string txtAnnualSales = "input[id$=':AnnualSales_JMIC-inputEl']";
			string lnkAddAddlCovg = "span[id$=':AdditionalCoveragesCardTab-btnInnerEl']";
			string btnAddAddlCovg = "span[id$=':BOPCoveragesDV_tb:Add-btnInnerEl']";
			string txtKeyword = "input[id$=':Keyword-inputEl']";
			string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
			string btnAddSelecCovg = "span[id$=':AddCoverageButton-btnInnerEl']";
			string lnkLocation = "a[id$=':LocationsEdit_LV:" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":Loc']";

			UIActionExt(By.CssSelector(lnkLocation), "ispresent");
			UIActionExt(By.CssSelector(lnkLocation), "click");
			UIActionExt(By.CssSelector(txtAnnualSales), "ispresent");
			UIActionExt(By.CssSelector(txtAnnualSales), "List", table.Rows[0]["AnnualSales"]);
			//UIActionExt(By.CssSelector(txtAnnualSales+"[value='"+ table.Rows[0]["AnnualSales"] + "']"), "ispresent");
			//WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 1);

			UIActionExt(By.CssSelector(lnkAddAddlCovg), "click");
			UIActionExt(By.CssSelector(btnAddAddlCovg), "ispresent");
			UIActionExt(By.CssSelector(btnAddAddlCovg), "click");

			UIActionExt(By.CssSelector(txtKeyword), "ispresent");
			UIActionExt(By.CssSelector(txtKeyword), "List", table.Rows[0]["Keyword"]);
			WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 1);
			UIActionExt(By.CssSelector(btnSearch), "click");
			WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 5);


			IWebElement divBOBuildLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':CoveragePatternSearchResultsLV-body")));
			IList<IWebElement> tblBOBldgLocs = divBOBuildLocs.FindElements(By.TagName("table")).ToList();
			Console.WriteLine("Table:" + tblBOBldgLocs.Count);
			IList<IWebElement> ImgBOBldChkBox = tblBOBldgLocs[0].FindElements(By.TagName("img")).ToList();
			ImgBOBldChkBox[0].Click();
			ImgBOBldChkBox[0].SendKeys(Keys.Space);
			WaitUntilElementInvisible(driver, By.CssSelector(btnNewLocation), 2);
			UIActionExt(By.CssSelector(btnAddSelecCovg), "click");
			UIActionExt(By.CssSelector(btnLocScreenOK), "click");
			UIActionExt(By.CssSelector(btnNewLocation), "ispresent");
		}
		public CL_BOLocations_PC9(IWebDriver driver) : base(driver)
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

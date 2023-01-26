using System;
using System.Linq;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_BOBuildingDetails_PC9 : Page
	{
		string lnkLocClassSearch = "a[id$=':BOPBuildingClassCodePicker']";
		string btnLocCalssSelect = "a[id$=':ClassCodeSearchResultsLV:0:_Select']";
		string txtBldCdEffGrade = "input[id$=':BuildingCodeEffectivenessGrade-inputEl']";
		string radioTheftYes = "input[id$=':BOPTheftExclusionIndicator_true-inputEl']";
		string radioTheftNo = "input[id$=':BOPTheftExclusionIndicator_false-inputEl']";
		string radioBrandsLabelsYes = "input[id$=':BOPBrandsAndLabelsIndicator_true-inputEl']";
		string radioBrandsLabelsNo = "input[id$=':BOPBrandsAndLabelsIndicator_false-inputEl']";
		string tabBuldingBPPCvg = "span[id$=':BOPBuildingBPPCoveragesCardTab-btnInnerEl']";
		string txtBPPLimit = "input[id$=':BOPBPPBldgLimit-inputEl']";
		string tabSecurityInfo = "span[id$=':BOPBuilding_SecurityCardTab-btnInnerEl']";
		string txtBurglarAlarm = "input[id$=':CommonBuilding_SecurityInfoDV:BurglarAlarmSystem-inputEl']";
		string txtDescSafeGaurd = "input[id$=':BOPBuilding_SecurityDetails:CommonBuilding_SecurityInfoDV:DescriptionOfSafeguard-inputEl']";
		string radioExtOfProtHighYes = "input[id$=':CommonBuilding_SecurityInfoDV:HighExtentOfProtect_JMIC_true-inputEl']";
		string radioAutoFireAlarmYes = "input[id$=':CommonBuilding_SecurityInfoDV:P2_true-inputEl']";
		string radioOtherProSafeYes = "input[id$=':CommonBuilding_SecurityInfoDV:P9_true-inputEl']";
		string radioOtherProSafeNo = "input[id$=':CommonBuilding_SecurityInfoDV:P9_false-inputEl']";
		string btnUpdateBuilding = "span[id$=':Update-btnInnerEl']";
		string btnAddILMBldgs = "span[id$=':AddILMBuilding-btnInnerEl']";

		string tblBOBldLocs = "div[id$=':BOPLocationBuildingsPanelSet:BOPLocationsLV-body']";
		string btnAddBldgs = "span[id$=':Add-btnInnerEl']";
		string txtFloors = "input[id$=':NumStories-inputEl']";
		string ConstructionType = "input[id$=':ConstructionType-inputEl']";
		string TotalArea = "input[id$=':TotalArea-inputEl']";
		string AreaOccupied = "input[id$=':AreaOccupied-inputEl']";
		string PercentSprinklered = "input[id$=':PercentSprinklered-inputEl']";
		public void BOAddBOBuildingDetails(Table table)
		{
			UIActionExt(By.CssSelector(lnkLocClassSearch), "ispresent");
			UIActionExt(By.CssSelector(lnkLocClassSearch), "click");
			UIActionExt(By.CssSelector(btnLocCalssSelect), "ispresent");
			UIActionExt(By.CssSelector(btnLocCalssSelect), "click");
			UIActionExt(By.CssSelector(txtBldCdEffGrade), "ispresent");
			UIActionExt(By.CssSelector(txtBldCdEffGrade), "Text", table.Rows[0]["BldCodeEffGrade"]);

			if (table.Rows[0]["TheftExec"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(radioTheftYes), "click");
			}
			else if (table.Rows[0]["TheftExec"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(radioTheftNo), "click");
			}
			if (table.Rows[0]["BandLIndicator"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(radioBrandsLabelsYes), "click");
			}
			else if (table.Rows[0]["BandLIndicator"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(radioBrandsLabelsNo), "click");
			}
			UIActionExt(By.CssSelector(tabBuldingBPPCvg), "click");
			UIActionExt(By.CssSelector(txtBPPLimit), "ispresent");
			UIActionExt(By.CssSelector(txtBPPLimit), "Text", table.Rows[0]["BPPLimit"]);
			UIActionExt(By.CssSelector(tabSecurityInfo), "click");
			UIActionExt(By.CssSelector(txtBurglarAlarm), "ispresent");
			UIActionExt(By.CssSelector(txtBurglarAlarm), "List", table.Rows[0]["BurglarAlarm"]);
			UIActionExt(By.CssSelector(txtBurglarAlarm + "[value='" + table.Rows[0]["BurglarAlarm"] + "']"), "ispresent");
			WaitUntilElementInvisible(driver, By.CssSelector(txtBldCdEffGrade), 5);
			if (IsElementPresent(driver, By.CssSelector(radioExtOfProtHighYes)) == true)
			{
				UIActionExt(By.CssSelector(radioExtOfProtHighYes), "click");
			}
			try
			{
				WaitUntilElementInvisible(driver, By.CssSelector(txtBldCdEffGrade), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Known exception" + e);
			}
			if (table.Rows[0]["OtherProtSafe"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(radioOtherProSafeYes), "ispresent");
				UIActionExt(By.CssSelector(radioOtherProSafeYes), "click");
			}
			else if (table.Rows[0]["OtherProtSafe"].ToLower() == "no")
			{
				//UIActionExt(By.CssSelector(radioOtherProSafeNo), "ispresent");
				if (IsElementPresent(driver, By.CssSelector(radioOtherProSafeNo)) == false)
				{
					WaitUntilElementVisible(driver, By.CssSelector(radioOtherProSafeNo), 5);
				}
				UIActionExt(By.CssSelector(radioOtherProSafeNo), "click");
			}
			try
			{
				WaitUntilElementInvisible(driver, By.CssSelector(txtBldCdEffGrade), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Known exception" + e);
			}
			if (table.Rows[0]["FireAlarm"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(radioAutoFireAlarmYes), "ispresent");
				UIActionExt(By.CssSelector(radioAutoFireAlarmYes), "click");
			}
			UIActionExt(By.CssSelector(btnUpdateBuilding), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnUpdateBuilding)));
			UIActionExt(By.CssSelector(btnUpdateBuilding), "click");
			UIActionExt(By.CssSelector(btnAddILMBldgs), "ispresent");
		}
		public void BOAddBOBldgDetails(Table table)
		{
			string tblBOBldLocs = "div[id$=':BOPLocationBuildingsPanelSet:BOPLocationsLV-body']";
			for (int eachRow = 0; eachRow <= table.Rows.Count() - 1; eachRow++)
			{
				UIActionExt(By.CssSelector(tblBOBldLocs), "ispresent");
				IWebElement tblbodyBOLocs = driver.FindElement(By.CssSelector(tblBOBldLocs));
				IList<IWebElement> tblBOLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();

				Console.WriteLine(tblBOLocs[eachRow].GetAttribute("id"));
				if (eachRow != 0)
				{
					UIActionExt(By.Id(tblBOLocs[eachRow].GetAttribute("id")), "ispresent");
					JavaScriptClick(tblBOLocs[eachRow]);
				}
				UIActionExt(By.CssSelector(btnAddILMBldgs), "ispresent");
				UIActionExt(By.CssSelector(btnAddILMBldgs), "click");
				BOAddBOBuildingDetails(table);
			}
		}
		public void CL_AddBOBldgDetails(Table table)
		{
			for (int i = 0; i <= table.Rows.Count() - 1; i++)
			{
				UIActionExt(By.CssSelector(tblBOBldLocs), "ispresent");
				IWebElement tblbodyBOLocs = driver.FindElement(By.CssSelector(tblBOBldLocs));
				IList<IWebElement> tblBOLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
				string BldgClass = tblBOLocs[Convert.ToInt32(table.Rows[i]["Location"]) - 1].GetAttribute("class");
				if (BldgClass.Contains("selected") == false)
				{
					string sLocAddrXPath = "//table[@id='" + tblBOLocs[Convert.ToInt32(table.Rows[i]["Location"]) - 1].GetAttribute("id") + "']//td[4]//div[1]";
					JavaScriptClick(driver.FindElement(By.XPath(sLocAddrXPath)));
				}
				if (table.Rows[i]["AddILMLoc"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(btnAddILMBldgs), "ispresent");
					UIActionExt(By.CssSelector(btnAddILMBldgs), "click");
				}
				else if (table.Rows[i]["AddILMLoc"].ToLower() == "no")
				{
					UIActionExt(By.CssSelector(btnAddBldgs), "ispresent");
					UIActionExt(By.CssSelector(btnAddBldgs), "click");
				}
				UIActionExt(By.CssSelector(lnkLocClassSearch), "click");
				UIActionExt(By.CssSelector(btnLocCalssSelect), "click");
				UIActionExt(By.CssSelector(txtBldCdEffGrade), "List", table.Rows[i]["BldCodeEffGrade"]);

				if (table.Rows[i]["TheftExec"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(radioTheftYes), "click");
				}
				else if (table.Rows[i]["TheftExec"].ToLower() == "no")
				{
					UIActionExt(By.CssSelector(radioTheftNo), "click");
				}
				if (table.Rows[i]["BandLIndicator"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(radioBrandsLabelsYes), "click");
				}
				else if (table.Rows[i]["BandLIndicator"].ToLower() == "no")
				{
					UIActionExt(By.CssSelector(radioBrandsLabelsNo), "click");
				}

				UIActionExt(By.CssSelector(ConstructionType), "ispresent");
				UIActionExt(By.CssSelector(txtFloors), "Text", "2");
				if (driver.FindElement(By.CssSelector(ConstructionType)).GetAttribute("value") == "<none>")
				{
					UIActionExt(By.CssSelector(ConstructionType), "List", table.Rows[i]["ConstructionType"]);
					UIActionExt(By.CssSelector(TotalArea), "Text", table.Rows[i]["TotalBuildingArea"]);
					UIActionExt(By.CssSelector(AreaOccupied), "Text", table.Rows[i]["AreaOccupied"]);
					UIActionExt(By.CssSelector(PercentSprinklered), "ispresent");
					UIActionExt(By.CssSelector(PercentSprinklered), "Text", table.Rows[i]["PercentSplinkered"]);
				}
				UIActionExt(By.CssSelector(tabBuldingBPPCvg), "click");
				UIActionExt(By.CssSelector(txtBPPLimit), "Text", table.Rows[i]["BPPLimit"]);
				UIActionExt(By.CssSelector(tabSecurityInfo), "click");
				UIActionExt(By.CssSelector(txtBurglarAlarm), "List", table.Rows[i]["BurglarAlarm"]);
				UIActionExt(By.CssSelector(txtDescSafeGaurd), "ispresent");
				if (IsElementPresent(driver, By.CssSelector(radioExtOfProtHighYes)) == true)
				{
					UIActionExt(By.CssSelector(radioExtOfProtHighYes), "click");
				}

				if (table.Rows[i]["FireAlarm"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(radioAutoFireAlarmYes), "ispresent");
					UIActionExt(By.CssSelector(radioAutoFireAlarmYes), "click");
				}
				try
				{
					WaitUntilElementInvisible(driver, By.CssSelector(txtBldCdEffGrade), 5);
				}
				catch (Exception e)
				{
					Console.WriteLine("Known exception" + e);
				}
				if (table.Rows[i]["OtherProtSafe"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(radioOtherProSafeYes), "click");
				}
				else if (table.Rows[i]["OtherProtSafe"].ToLower() == "no")
				{
					UIActionExt(By.CssSelector(radioOtherProSafeNo), "click");
					UIActionExt(By.CssSelector(radioOtherProSafeNo), "ispresent");
					string txtOtherProfSafeN0 = "input[id$=':DescriptionOfSafeguard-inputEl']";
					WaitUntilElementInvisible(driver, By.CssSelector(txtOtherProfSafeN0));
				}
				UIActionExt(By.CssSelector(btnUpdateBuilding), "click");
				UIActionExt(By.CssSelector(btnAddBldgs), "ispresent");
			}
		}
		public void CL_AddBOBldgDetails_EQ(Table table)
		{
			for (int i = 0; i <= table.Rows.Count() - 1; i++)
			{
				string lnkAddlCovgs = "span[id$=':BOPBuilding_AdditionalCoveragesCardTab-btnInnerEl']";
				string btnAddCovgs = "a[id$=':AdditionalCoveragesDV_tb:Add']";
				string txtKeyword = "input[id$=':Keyword-inputEl']";
				string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
				string btnAddSelecCovg = "span[id$=':AddCoverageButton-btnInnerEl']";
				string lstBuildingClass = "input[id$=':BOPBuildingClass-inputEl']";
				string lstEQTerritory = "input[id$=':BOPEQTerritory-inputEl']";

				UIActionExt(By.CssSelector(tblBOBldLocs), "ispresent");
				IWebElement tblbodyBOLocs = driver.FindElement(By.CssSelector(tblBOBldLocs));
				IList<IWebElement> tblBOLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
				string BldgClass = tblBOLocs[Convert.ToInt32(table.Rows[i]["Location"]) - 1].GetAttribute("class");
				if (BldgClass.Contains("selected") == false)
				{
					string sLocAddrXPath = "//table[@id='" + tblBOLocs[Convert.ToInt32(table.Rows[i]["Location"]) - 1].GetAttribute("id") + "']//td[4]//div[1]";
					JavaScriptClick(driver.FindElement(By.XPath(sLocAddrXPath)));
				}
				if (table.Rows[i]["AddILMLoc"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(btnAddILMBldgs), "ispresent");
					UIActionExt(By.CssSelector(btnAddILMBldgs), "click");
				}
				else if (table.Rows[i]["AddILMLoc"].ToLower() == "no")
				{
					UIActionExt(By.CssSelector(btnAddBldgs), "ispresent");
					UIActionExt(By.CssSelector(btnAddBldgs), "click");
				}
				UIActionExt(By.CssSelector(lnkLocClassSearch), "click");
				UIActionExt(By.CssSelector(btnLocCalssSelect), "click");
				UIActionExt(By.CssSelector(txtBldCdEffGrade), "List", table.Rows[i]["BldCodeEffGrade"]);
				UIActionExt(By.CssSelector(lstBuildingClass), "List", table.Rows[i]["BuildingClass"]);
				UIActionExt(By.CssSelector(lstEQTerritory), "List", table.Rows[i]["EQTerritory"]);

				if (table.Rows[i]["TheftExec"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(radioTheftYes), "click");
				}
				else if (table.Rows[i]["TheftExec"].ToLower() == "no")
				{
					UIActionExt(By.CssSelector(radioTheftNo), "click");
				}
				if (table.Rows[i]["BandLIndicator"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(radioBrandsLabelsYes), "click");
				}
				else if (table.Rows[i]["BandLIndicator"].ToLower() == "no")
				{
					UIActionExt(By.CssSelector(radioBrandsLabelsNo), "click");
				}

				UIActionExt(By.CssSelector(ConstructionType), "ispresent");
				UIActionExt(By.CssSelector(txtFloors), "Text", "2");
				if (driver.FindElement(By.CssSelector(ConstructionType)).GetAttribute("value") == "<none>")
				{
					UIActionExt(By.CssSelector(ConstructionType), "List", table.Rows[i]["ConstructionType"]);
					UIActionExt(By.CssSelector(TotalArea), "Text", table.Rows[i]["TotalBuildingArea"]);
					UIActionExt(By.CssSelector(AreaOccupied), "Text", table.Rows[i]["AreaOccupied"]);
					UIActionExt(By.CssSelector(PercentSprinklered), "ispresent");
					UIActionExt(By.CssSelector(PercentSprinklered), "Text", table.Rows[i]["PercentSplinkered"]);
				}
				UIActionExt(By.CssSelector(tabBuldingBPPCvg), "click");
				UIActionExt(By.CssSelector(txtBPPLimit), "Text", table.Rows[i]["BPPLimit"]);
				UIActionExt(By.CssSelector(tabSecurityInfo), "click");
				UIActionExt(By.CssSelector(txtBurglarAlarm), "List", table.Rows[i]["BurglarAlarm"]);
				UIActionExt(By.CssSelector(txtDescSafeGaurd), "ispresent");
				if (IsElementPresent(driver, By.CssSelector(radioExtOfProtHighYes)) == true)
				{
					UIActionExt(By.CssSelector(radioExtOfProtHighYes), "click");
				}

				if (table.Rows[i]["FireAlarm"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(radioAutoFireAlarmYes), "ispresent");
					UIActionExt(By.CssSelector(radioAutoFireAlarmYes), "click");
				}
				try
				{
					WaitUntilElementInvisible(driver, By.CssSelector(txtBldCdEffGrade), 5);
				}
				catch (Exception e)
				{
					Console.WriteLine("Known exception" + e);
				}
				if (table.Rows[i]["OtherProtSafe"].ToLower() == "yes")
				{
					UIActionExt(By.CssSelector(radioOtherProSafeYes), "click");
				}
				else if (table.Rows[i]["OtherProtSafe"].ToLower() == "no")
				{
					UIActionExt(By.CssSelector(radioOtherProSafeNo), "click");
					UIActionExt(By.CssSelector(radioOtherProSafeNo), "ispresent");
					string txtOtherProfSafeN0 = "input[id$=':DescriptionOfSafeguard-inputEl']";
					WaitUntilElementInvisible(driver, By.CssSelector(txtOtherProfSafeN0));
				}


				UIActionExt(By.CssSelector(lnkAddlCovgs), "ispresent");
				UIActionExt(By.CssSelector(lnkAddlCovgs), "click");
				UIActionExt(By.CssSelector(btnAddCovgs), "ispresent");
				UIActionExt(By.CssSelector(btnAddCovgs), "click");

				UIActionExt(By.CssSelector(txtKeyword), "ispresent");
				UIActionExt(By.CssSelector(txtKeyword), "List", "Earthquake");
				WaitUntilElementInvisible(driver, By.CssSelector(btnAddBldgs), 1);
				UIActionExt(By.CssSelector(btnSearch), "click");
				WaitUntilElementInvisible(driver, By.CssSelector(btnAddBldgs), 5);


				IWebElement divBOBuildLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':CoveragePatternSearchResultsLV-body")));
				IList<IWebElement> tblBOBldgLocs = divBOBuildLocs.FindElements(By.TagName("table")).ToList();
				Console.WriteLine("Table:" + tblBOBldgLocs.Count);
				IList<IWebElement> ImgBOBldChkBox = tblBOBldgLocs[0].FindElements(By.TagName("img")).ToList();
				ImgBOBldChkBox[0].Click();
				ImgBOBldChkBox[0].SendKeys(Keys.Space);
				WaitUntilElementInvisible(driver, By.CssSelector(btnAddBldgs), 2);
				UIActionExt(By.CssSelector(btnAddSelecCovg), "click");

				UIActionExt(By.CssSelector(btnUpdateBuilding), "click");
				UIActionExt(By.CssSelector(btnAddBldgs), "ispresent");
			}
		}

		public void CL_AddBOBldgCovgDetails(Table table)
		{
			for (int i = 0; i <= table.Rows.Count() - 1; i++)
			{
				string linkBOLocationBldg = "a[id$=':BOPLocationBuildingsLV:" + (Convert.ToInt32(table.Rows[i]["Building"]) - 1) + ":BuildingNumEdit']";
				string chkBuilding = "input[id$=':BOPSingleBuildingDetailScreen:0:CoverageInputSet:CovPatternInputGroup:_checkbox']";
				string bldLimit = "input[id$=':0:CoverageInputSet:CovPatternInputGroup:BOPBldgCovLimit-inputEl']";
				string BldAddress = "div[id$=':LocationInfo-inputEl']";
				UIActionExt(By.CssSelector(tblBOBldLocs), "ispresent");
				IWebElement tblbodyBOLocs = WaitFor(driver.FindElement(By.CssSelector(tblBOBldLocs)));
				IList<IWebElement> tblBOLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
				string BldgClass = tblBOLocs[Convert.ToInt32(table.Rows[i]["Location"]) - 1].GetAttribute("class");
				if (BldgClass.Contains("selected") == false)
				{
					string sLocAddrXPath = "//table[@id='" + tblBOLocs[Convert.ToInt32(table.Rows[i]["Location"]) - 1].GetAttribute("id") + "']//td[4]//div[1]";
					JavaScriptClick(driver.FindElement(By.XPath(sLocAddrXPath)));
				}
				UIActionExt(By.CssSelector(BldAddress), "ispresent");
				ScenarioContext.Current.Add("BLANKETADDRESS", driver.FindElement(By.CssSelector(BldAddress)).Text);
				UIActionExt(By.CssSelector(linkBOLocationBldg), "click");
				UIActionExt(By.CssSelector(tabBuldingBPPCvg), "click");
				UIActionExt(By.CssSelector(chkBuilding), "click");
				UIActionExt(By.CssSelector(bldLimit), "text", "10000");
				UIActionExt(By.CssSelector(txtBPPLimit), "ispresent");
				Console.WriteLine(driver.FindElement(By.CssSelector(txtBPPLimit)).Text);
				if (driver.FindElement(By.CssSelector(txtBPPLimit)).Text != "10,000")
				{
					UIActionExt(By.CssSelector(txtBPPLimit), "text", "10000");
				}

				UIActionExt(By.CssSelector(btnUpdateBuilding), "click");
				UIActionExt(By.CssSelector(btnAddBldgs), "ispresent");
			}
		}

		public CL_BOBuildingDetails_PC9(IWebDriver driver) : base(driver)
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

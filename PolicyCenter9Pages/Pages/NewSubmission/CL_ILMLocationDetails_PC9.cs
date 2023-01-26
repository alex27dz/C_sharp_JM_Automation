using TechTalk.SpecFlow;
using OpenQA.Selenium;
using WebCommonCore;
using System;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_ILMLocationDetails_PC9 : Page
	{
		string SegmentationCode = "input[id$=':SegmentationCode_JMIC-inputEl']";
		string sTerrorProp = "input[id$=':ILMLocation_JMICCV:LocationDetailInputSet:TerrorismTerritoryProp-inputEl']";
		string GenBusinessRetail = "input[id$=':Retail_JMIC-inputEl']";
		string FulltimeEmployees = "input[id$=':FullTimeEmployees_JMIC-inputEl']";
		string ParttimeEmployees = "input[id$=':PartTimeEmployees_JMIC-inputEl']";
		string PublicProtection = "input[id$=':PublicProtection_JMIC-inputEl']";
		string LocationType = "input[id$=':LocationType_JMIC-inputEl']";
		string ConstructionType = "input[id$=':ConstructionType-inputEl']";
		string TotalArea = "input[id$=':TotalArea-inputEl']";
		string AreaOccupied = "input[id$=':AreaOccupied-inputEl']";
		string PercentSprinklered = "input[id$=':PercentSprinklered-inputEl']";
		string SharedPremisesYes = "input[id$=':SharedPremises_true-inputEl']";
		string SharedPremisesNo = "input[id$=':SharedPremises_false-inputEl']";
		string txtSharedWith = "input[id$=':PremisesSharedWith-inputEl']";
		string lnkTabSecurity = "span[id$=':SecurityInformationTab-btnInnerEl']";
		string radioBurgerAlarmTrue = "input[id$=':BurAlaWhenClosed_JMIC_true-inputEl']";
		string radioBurgerAlarmFalse = "input[id$=':BurAlaWhenClosed_JMIC_false-inputEl']";
		string txtBurgerAlarmExplain = "textarea[id$=':CommonBuilding_SecurityInfoDV:IsRespondtoBurglarAlarm-inputEl']";
		string sCameraSystem = "input[id$=':ILMLocation_JMICCV:CommonBuilding_SecurityInfoDV:cameraSystem-inputEl']";
		string lnkTabSafesVaultsStock = "span[id$=':SafeVaultStockroomTab-btnInnerEl']";
		string txtTotInstrgPrct = "input[id$=':TotalInStrgPrcnt_JMIC-inputEl']";
		string txtBankVaultPrct = "input[id$=':BankVaultPercent_JMIC-inputEl']";
		string btnOK = "span[id='ILMLocation_JMICPopup:Update-btnInnerEl']";
		string btnILMAddLocation = "span[id$=':ILMLocation_JMICScreen:addLocationsOrBuildingsTB-btnInnerEl']";


		public void EnterLocationDetails(Table table)
		{
			UIActionExt(By.CssSelector(SegmentationCode), "ispresent");
			UIActionExt(By.CssSelector(SegmentationCode), "Text", table.Rows[0]["SegmentationCode"]);
			UIActionExt(By.CssSelector(GenBusinessRetail), "Text", table.Rows[0]["GenBusinessRetail"]);
			if (IsElementPresent(driver, By.CssSelector(sTerrorProp)) == true)
			{
				UIActionExt(By.CssSelector(sTerrorProp), "Text", "001");
			}
			UIActionExt(By.CssSelector(FulltimeEmployees), "ispresent");
			UIActionExt(By.CssSelector(FulltimeEmployees), "Text", table.Rows[0]["FullTimeEmp"]);
			UIActionExt(By.CssSelector(ParttimeEmployees), "Text", table.Rows[0]["PartTimeEmp"]);
			UIActionExt(By.CssSelector(PublicProtection), "List", table.Rows[0]["PublicProtection"]);
			UIActionExt(By.CssSelector(LocationType), "List", table.Rows[0]["LocationType"]);
			WaitUntilElementInvisible(driver, By.CssSelector(txtSharedWith), 5);
			UIActionExt(By.CssSelector(ConstructionType), "List", table.Rows[0]["ConstructionType"]);

			UIActionExt(By.CssSelector(TotalArea), "Text", table.Rows[0]["TotalBuildingArea"]);
			UIActionExt(By.CssSelector(AreaOccupied), "Text", table.Rows[0]["AreaOccupied"]);
			UIActionExt(By.CssSelector(PercentSprinklered), "List", table.Rows[0]["PercentSplinkered"]);
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector(txtBurgerAlarmExplain), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Known exception" + e);
			}
			if (table.Rows[0]["SharedPremises"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(SharedPremisesYes), "click");
				UIActionExt(By.CssSelector(txtSharedWith), "Text", table.Rows[0]["SharedWith"]);
			}
			else if (table.Rows[0]["SharedPremises"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(SharedPremisesNo), "click");
				WaitUntilElementInvisible(driver, By.CssSelector(txtSharedWith), 5);
			}
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnOK)));

			UIActionExt(By.CssSelector(lnkTabSecurity), "click");
			UIActionExt(By.CssSelector(radioBurgerAlarmTrue), "ispresent");
			if (table.Rows[0]["BurglarAlarm"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(radioBurgerAlarmFalse), "click");
				UIActionExt(By.CssSelector(txtBurgerAlarmExplain), "ispresent");
			}
			else if (table.Rows[0]["BurglarAlarm"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(radioBurgerAlarmTrue), "click");
				WaitUntilElementInvisible(driver, By.CssSelector(txtBurgerAlarmExplain));
			}
			if (IsElementPresent(driver, By.CssSelector(sCameraSystem)) == true)
			{
				UIActionExt(By.CssSelector(sCameraSystem), "Text", "Camera Decoy");
			}

			if (IsElementPresent(driver, By.CssSelector(lnkTabSafesVaultsStock)) == false)
			{
				WaitUntilElementVisible(driver, By.CssSelector(lnkTabSafesVaultsStock));
			}
			UIActionExt(By.CssSelector(lnkTabSafesVaultsStock), "ispresent");
			UIActionExt(By.CssSelector(lnkTabSafesVaultsStock), "click");
			UIActionExt(By.CssSelector(txtTotInstrgPrct), "ispresent");
			UIActionExt(By.CssSelector(txtTotInstrgPrct), "Text", table.Rows[0]["TotalLocationInSafe"]);
			UIActionExt(By.CssSelector(txtBankVaultPrct), "Text", table.Rows[0]["BankVault"]);
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(btnILMAddLocation), "ispresent");
		}
		public void AddNewILMLocation(Table table)
		{
			string btnAddLocation = "span[id$=':addLocationsOrBuildingsTB-btnInnerEl']";
			string lnkNewLocation = "span[id$=':addLocationsOrBuildingsTB:AddNewLocation-textEl']";
			string AddressLine1 = "input[id$=':AddressLine1-inputEl']";
			string City = "input[id$=':City-inputEl']";
			string ZipCode = "input[id$=':PostalCode-inputEl']";
			string State = "input[id$=':State-inputEl']";

			UIActionExt(By.CssSelector(btnAddLocation), "ispresent");
			UIActionExt(By.CssSelector(btnAddLocation), "click");
			UIActionExt(By.CssSelector(lnkNewLocation), "ispresent");
			UIActionExt(By.CssSelector(lnkNewLocation), "click");

			UIActionExt(By.CssSelector(AddressLine1), "ispresent");
			UIActionExt(By.CssSelector(AddressLine1), "Text", table.Rows[0]["AddressLine1"]);
			UIActionExt(By.CssSelector(City), "Text", table.Rows[0]["City"]);
			UIActionExt(By.CssSelector(State), "ispresent");
			UIActionExt(By.CssSelector(State), "List", table.Rows[0]["State"]);
			UIActionExt(By.CssSelector(ZipCode), "ispresent");
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

		}
		public void ILMLocDetailsInfo_CL(Table table)
		{
			string tblILMLocDetails = "table[id$=':LocationDetailsTab:panelId-table']"; ;
			UIActionExt(By.CssSelector(tblILMLocDetails), "ispresent");
			UIActionExt(By.CssSelector(SegmentationCode), "Text", table.Rows[0]["SegmentationCode"]);
			if (IsElementPresent(driver, By.CssSelector(sTerrorProp)) == true)
			{
				UIActionExt(By.CssSelector(sTerrorProp), "Text", "001");
			}
			UIActionExt(By.CssSelector(GenBusinessRetail), "Text", table.Rows[0]["GenBusinessRetail"]);
			UIActionExt(By.CssSelector(FulltimeEmployees), "Text", table.Rows[0]["FullTimeEmp"]);
			UIActionExt(By.CssSelector(ParttimeEmployees), "Text", table.Rows[0]["PartTimeEmp"]);
			UIActionExt(By.CssSelector(PublicProtection), "ispresent");
			UIActionExt(By.CssSelector(PublicProtection), "List", table.Rows[0]["PublicProtection"]);
			UIActionExt(By.CssSelector(LocationType), "List", table.Rows[0]["LocationType"]);
			//UIActionExt(By.CssSelector(ConstructionType), "Sync");
			WaitUntilElementInvisible(driver, By.CssSelector(txtSharedWith), 5);
			UIActionExt(By.CssSelector(ConstructionType), "List", table.Rows[0]["ConstructionType"]);
			UIActionExt(By.CssSelector(TotalArea), "Text", table.Rows[0]["TotalBuildingArea"]);
			UIActionExt(By.CssSelector(AreaOccupied), "Text", table.Rows[0]["AreaOccupied"]);
			UIActionExt(By.CssSelector(PercentSprinklered), "List", table.Rows[0]["PercentSplinkered"]);
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector(txtBurgerAlarmExplain), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Known exception" + e);
			}
			if (table.Rows[0]["SharedPremises"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(SharedPremisesYes), "click");
				UIActionExt(By.CssSelector(txtSharedWith), "Text", table.Rows[0]["SharedWith"]);
			}
			else if (table.Rows[0]["SharedPremises"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(SharedPremisesNo), "click");
				WaitUntilElementInvisible(driver, By.CssSelector(txtSharedWith), 5);
			}
			UIActionExt(By.CssSelector(btnOK), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnOK)));
		}
		public void ILMLocSecInfo_CL(Table table)
		{
			UIActionExt(By.CssSelector(lnkTabSecurity), "click");
			UIActionExt(By.CssSelector(radioBurgerAlarmTrue), "ispresent");
			if (table.Rows[0]["BurglarAlarm"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(radioBurgerAlarmFalse), "click");
				UIActionExt(By.CssSelector(txtBurgerAlarmExplain), "ispresent");
			}
			else if (table.Rows[0]["BurglarAlarm"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(radioBurgerAlarmTrue), "click");
				WaitUntilElementInvisible(driver, By.CssSelector(txtBurgerAlarmExplain));
			}
			if (IsElementPresent(driver, By.CssSelector(sCameraSystem)) == true)
			{
				UIActionExt(By.CssSelector(sCameraSystem), "Text", "Camera Decoy");
			}
		}
		public void ILMLocSafeVaultStock(Table table)
		{
			UIActionExt(By.CssSelector(lnkTabSafesVaultsStock), "ispresent");
			UIActionExt(By.CssSelector(lnkTabSafesVaultsStock), "click");
			UIActionExt(By.CssSelector(txtTotInstrgPrct), "ispresent");
			UIActionExt(By.CssSelector(txtTotInstrgPrct), "Text", table.Rows[0]["TotalLocationInSafe"]);
			UIActionExt(By.CssSelector(txtBankVaultPrct), "Text", table.Rows[0]["BankVault"]);
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(btnILMAddLocation), "ispresent");
		}
		public void JSILMClickOK()
		{
			UIActionExt(By.CssSelector(lnkTabSafesVaultsStock), "ispresent");
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(btnILMAddLocation), "ispresent");
		}
		public void AddNewILMLocation_Renew(Table table)
		{
			string AddressLine1 = "input[id$=':AddressLine1-inputEl']";
			string City = "input[id$=':City-inputEl']";
			string ZipCode = "input[id$=':PostalCode-inputEl']";
			string State = "input[id$=':State-inputEl']";
			UIActionExt(By.CssSelector(AddressLine1), "ispresent");
			UIActionExt(By.CssSelector(AddressLine1), "Text", table.Rows[0]["AddressLine1"]);
			UIActionExt(By.CssSelector(City), "Text", table.Rows[0]["City"]);
			UIActionExt(By.CssSelector(State), "ispresent");
			UIActionExt(By.CssSelector(State), "List", table.Rows[0]["State"]);
			UIActionExt(By.CssSelector(ZipCode), "ispresent");
			UIActionExt(By.CssSelector(ZipCode), "List", table.Rows[0]["ZipCode"]);
			UIActionExt(By.XPath("//div[text()[contains(.,'Verified')]]"), "ispresent");
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(btnILMAddLocation), "ispresent");
		}
		public void AddILMBlanket(Table table)
		{
			string taBlanketCoverage = "span[id$=':BlanketCoveragesTab-btnInnerEl']";
			string lblBlanketCoverage = "span[id$=':BlanketCoveragesPanel:ILMLineCoveragesPanelSet:1']";
			string chkStockBlanket = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:_checkbox']";
			string txtStockLimit = "input[id$=':0:ILMCovTermInputSet:DirectTermInput-inputEl']";
			string txtStockPremium = "input[id$=':2:ILMCovTermInputSet:DirectTermInput-inputEl']";

			UIActionExt(By.CssSelector(taBlanketCoverage), "click");
			UIActionExt(By.CssSelector(lblBlanketCoverage), "ispresent");
			UIActionExt(By.CssSelector(chkStockBlanket), "click");
			UIActionExt(By.CssSelector(txtStockLimit), "ispresent");
			UIActionExt(By.CssSelector(txtStockLimit), "Text", table.Rows[0]["StockLimit"]);
			UIActionExt(By.CssSelector(txtStockPremium), "Text", table.Rows[0]["Premium"]);


		}
		public CL_ILMLocationDetails_PC9(IWebDriver driver) : base(driver)
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


using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_InlandMarineLine_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string btnILMAddLocation = "span[id$=':ILMLocation_JMICScreen:addLocationsOrBuildingsTB-btnInnerEl']";
		string tabOffPremises = "span[id$=':OffPremiseCoveragesTab-btnInnerEl']";
		string lblOffPrimiseCoverage = "span[id$=':OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:1']";
		string txtPropLimit = "input[id$=':9:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput-inputEl']";
		string txtAvgDed = "input[id$=':9:ILMCoverageInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:OptionTermInput-inputEl']";
		public void ClickNextButton()
		{
			WaitUntilElementInvisible(driver, By.CssSelector(btnILMAddLocation), 10);
			UIActionExt(By.CssSelector(btnNext), "ispresent");
			UIActionExt(By.CssSelector(btnNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(btnILMAddLocation));
		}

		public void AddPropOtherwiseCovg(Table table)
		{
			string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";

			string txtGoodsExp = "input[id$=':5:ILMCoverageInputSet:CovPatternInputGroup:2:GdsAtJwlrExposure_JMIC-inputEl']";

			if (IsElementPresent(driver, By.CssSelector(btnClear)) == true)
			{
				UIActionExt(By.CssSelector(btnClear), "click");
			}
			UIActionExt(By.CssSelector(tabOffPremises), "click");
			UIActionExt(By.CssSelector(txtPropLimit), "ispresent");
			UIActionExt(By.CssSelector(txtPropLimit), "Text", table.Rows[0]["PropOtherAwayLimit"]);
			UIActionExt(By.CssSelector(txtAvgDed), "List", table.Rows[0]["AvgDayilyLimit"]);
			UIActionExt(By.CssSelector(txtGoodsExp), "Text", table.Rows[0]["GdsAtJwlrExposure"]);
			UIActionExt(By.CssSelector(btnNext), "ispresent");
			UIActionExt(By.CssSelector(btnNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(btnILMAddLocation));
			if (IsElementPresent(driver, By.CssSelector(btnClear)) == true)
			{
				UIActionExt(By.CssSelector(btnClear), "click");
			}
		}
		public void UpdateBOPEPLI_Verify()
		{
			string[] EPLILimits = new string[] { "250,000", "500,000", "1,000,000" };
			string btnQuote = "span[id$=':QuoteOrReview-btnInnerEl']";
			string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";
			string btnEditTrans = "span[id$=':EditPolicy-btnInnerEl']";
			string btnOK = "span[id$='button-1005-btnInnerEl']";
			string lblBOLine = "span[id$=':BOPScreen:ttlBar']";
			string lblPolicyInfo = "span[id$=':SubmissionWizard_PolicyInfoScreen:ttlBar'";
			string txtEPLIperClaimLimit = "input[id$=':5:CoverageInputSet:CovPatternInputGroup:BOPEmplmtPrctcLiabLimTerm-inputEl']";
			UIActionExt(By.CssSelector(btnEditTrans), "ispresent");
			UIActionExt(By.CssSelector(btnEditTrans), "click");
			UIActionExt(By.CssSelector(btnOK), "ispresent");
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(lblPolicyInfo), "ispresent");
			UIActionExt(By.CssSelector(btnNext), "click");
			UIActionExt(By.CssSelector(lblBOLine), "ispresent");
			for (int i = 0; i <= EPLILimits.Length - 1; i++)
			{
				Console.WriteLine("1");
				UIActionExt(By.CssSelector(txtEPLIperClaimLimit), "ispresent");
				Console.WriteLine("2");
				UIActionExt(By.CssSelector(txtEPLIperClaimLimit), "List", EPLILimits[i]);
				UIActionExt(By.CssSelector(txtEPLIperClaimLimit + "[value='" + EPLILimits[i] + "']"), "ispresent");
				Console.WriteLine("3");
				UIActionExt(By.CssSelector(btnQuote), "ispresent");
				Console.WriteLine("4");
				UIActionExt(By.CssSelector(btnQuote), "click");
				Console.WriteLine("5");
				UIActionExt(By.CssSelector(btnClear), "ispresent", "", 0, 48);
				Console.WriteLine("6");
				string errorMessage = driver.FindElement(By.XPath("//*[@id='WebMessageWorksheet:WebMessageWorksheetScreen:grpMsgs']")).Text;
				Console.WriteLine("Error message for " + EPLILimits[i] + ":\n" + errorMessage);
				UIActionExt(By.CssSelector(btnClear), "click");
				Console.WriteLine("7");
				WaitUntilElementInvisible(driver, By.CssSelector(btnILMAddLocation), 10);
				Console.WriteLine("8");
			}
			UIActionExt(By.CssSelector(txtEPLIperClaimLimit), "ispresent");
			UIActionExt(By.CssSelector(txtEPLIperClaimLimit), "List", "100,000");
			UIActionExt(By.CssSelector(btnQuote), "ispresent");
			UIActionExt(By.CssSelector(btnQuote), "click");
		}

		public void CLAddILMLineCovgs(Table table)
		{
			string mtaLimit = "input[id$=':8:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput-inputEl']";
			string mtaDed = "input[id$=':8:ILMCoverageInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:OptionTermInput-inputEl']";
			string chkPOA = "input[id$=':CovCategoryIterator:9:ILMCoverageInputSet:CovPatternInputGroup:_checkbox']";
			UIActionExt(By.CssSelector(tabOffPremises), "ispresent");
			UIActionExt(By.CssSelector(tabOffPremises), "click");
			UIActionExt(By.CssSelector(lblOffPrimiseCoverage), "ispresent");
			for (int i = 0; i <= table.Rows.Count - 1; i++)
			{
				switch (table.Rows[i]["CoverageType"].ToString().ToLower())
				{
					case "maximum travel aggregate":
						UIActionExt(By.CssSelector(mtaLimit), "List", table.Rows[0]["AvgDayilyLimit"]);
						UIActionExt(By.CssSelector(mtaDed), "List", table.Rows[0]["AvgDayilyDed"]);
						break;
					case "property otherwise away":
						UIActionExt(By.CssSelector(chkPOA), "click");
						UIActionExt(By.CssSelector(txtPropLimit), "ispresent");
						UIActionExt(By.CssSelector(txtPropLimit), "Text", table.Rows[0]["AvgDayilyLimit"]);
						UIActionExt(By.CssSelector(txtAvgDed), "List", table.Rows[0]["AvgDayilyDed"]);
						UIActionExt(By.CssSelector(btnNext), "ispresent");
						UIActionExt(By.CssSelector(btnNext), "click");
						WaitUntilElementVisible(driver, By.CssSelector(btnILMAddLocation));
						break;
					default:
						break;
				}
			}


		}
		public CL_InlandMarineLine_PC9(IWebDriver driver) : base(driver)
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

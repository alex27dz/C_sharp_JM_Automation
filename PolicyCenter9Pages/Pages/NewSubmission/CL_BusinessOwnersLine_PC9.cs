
using OpenQA.Selenium;
using WebCommonCore;
using TechTalk.SpecFlow;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_BusinessOwnersLine_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lnkPackageCovgs = "span[id$=':BOP_PackageCoveragesCardTab-btnInnerEl']";
		string txtPackageLevel = "input[id$=':BOPScreen:BOPLineDV:PackageLevel-inputEl']";
		string btnNewLocation = "span[id$=':BOPLocationsPanelSet:LocationsEdit_DP_tb:Add-btnInnerEl']";
		public void EnterBOLineDetails(string packageLevel)
		{
			UIActionExt(By.CssSelector(lnkPackageCovgs), "click");
			UIActionExt(By.CssSelector(txtPackageLevel), "ispresent");
			UIActionExt(By.CssSelector(txtPackageLevel), "List", packageLevel);
			UIActionExt(By.CssSelector(txtPackageLevel + "[value='" + packageLevel + "']"), "ispresent");
		}
		public void AddBOLineCoverage(Table table)
		{
			switch (table.Rows[0]["CoverageName"].ToLower().Trim())
			{
				case "epli":
					string txtEPLIperClaimLimit = "input[id$=':5:CoverageInputSet:CovPatternInputGroup:BOPEmplmtPrctcLiabLimTerm-inputEl']";
					string txtEPLIperClaimDed = "input[id$=':5:CoverageInputSet:CovPatternInputGroup:BOPEmplmtPrctcLiabDedTerm-inputEl']";
					try
					{
						if (IsElementPresent(driver, By.CssSelector(txtEPLIperClaimLimit)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(txtEPLIperClaimLimit), 30);
						}
					}
					catch (System.Exception e)
					{
						System.Console.WriteLine("Exception Caught: " + e);
					}

					//UIActionExt(By.CssSelector(txtEPLIperClaimLimit), "ispresent");
					UIActionExt(By.CssSelector(txtEPLIperClaimLimit), "List", table.Rows[0]["Limit"]);
					//UIActionExt(By.CssSelector(txtEPLIperClaimLimit + "[value='" + table.Rows[0]["Limit"] + "']"), "ispresent");

					try
					{
						if (IsElementPresent(driver, By.CssSelector(txtEPLIperClaimDed)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(txtEPLIperClaimDed), 30);
						}
					}
					catch (System.Exception e)
					{
						System.Console.WriteLine("Exception Caught: " + e);
					}
					UIActionExt(By.CssSelector(txtEPLIperClaimDed), "List", table.Rows[0]["Deductible"]);
                    //UIActionExt(By.CssSelector(txtEPLIperClaimDed + "[value='" + table.Rows[0]["Deductible"] + "']"), "ispresent");
                    try
                    {
                        if (IsElementPresent(driver, By.CssSelector(txtEPLIperClaimDed)) == false)
                        {
                            WaitUntilElementVisible(driver, By.CssSelector(txtEPLIperClaimDed), 30);
                        }
                    }
                    catch (System.Exception e)
                    {
                        System.Console.WriteLine("Exception Caught: " + e);
                    }
                    break;
				case "money and securities - off premises":
					string MSOverrideLimit = "input[id$=':6:CoverageInputSet:CovPatternInputGroup:1:CovTermInputSet:DirectTermInput1:CovTermDirectInputSet:DirectTermInput-inputEl']";
					string MSOverrideDed = "input[id$=':6:CoverageInputSet:CovPatternInputGroup:3:CovTermInputSet:OptionTermInput-inputEl']";
					UIActionExt(By.CssSelector(MSOverrideLimit), "ispresent");
					UIActionExt(By.CssSelector(MSOverrideLimit), "Text", table.Rows[0]["OverrideLimit"]);
					UIActionExt(By.CssSelector(MSOverrideDed), "List", table.Rows[0]["OverrideDeductable"]);
					//UIActionExt(By.CssSelector(MSOverrideDed + "[value='" + table.Rows[0]["OverrideDeductable"] + "']"), "ispresent");
					break;
				case "employee dishonesty":
					string lstCovOvrLimit = "input[id$=':3:CoverageInputSet:CovPatternInputGroup:BOPEmpDisCovOvrLimit-inputEl']";
					string lstCovRetLimit = "input[id$=':3:CoverageInputSet:CovPatternInputGroup:BOPEmpDisCovRetLimit-inputEl']";
					string txtReinsuranceCost = "input[id$=':3:CoverageInputSet:CovPatternInputGroup:BOPEmpDisReinsCost-inputEl']";
					string lstOvrDed = "input[id$=':3:CoverageInputSet:CovPatternInputGroup:BOPEmpDisCovOverDed-inputEl']";
					try
					{
						if (IsElementPresent(driver, By.CssSelector(lstCovOvrLimit)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(lstCovOvrLimit), 30);
						}
					}
					catch (System.Exception e)
					{
						System.Console.WriteLine("Exception Caught: " + e);
					}
					UIActionExt(By.CssSelector(lstCovOvrLimit), "List", table.Rows[0]["OverrideLimit"]);
					UIActionExt(By.CssSelector(lstCovOvrLimit + "[value='" + table.Rows[0]["OverrideLimit"] + "']"), "ispresent");
					try
					{
						if (IsElementPresent(driver, By.CssSelector(lstCovRetLimit)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(lstCovRetLimit), 30);
						}
					}
					catch (System.Exception e)
					{
						System.Console.WriteLine("Exception Caught: " + e);
					}
					UIActionExt(By.CssSelector(lstCovRetLimit), "List", table.Rows[0]["RetainedLimitofInsurance"]);
					//UIActionExt(By.CssSelector(lstCovRetLimit + "[value='" + table.Rows[0]["RetainedLimitofInsurance"] + "']"), "ispresent");

					UIActionExt(By.CssSelector(txtReinsuranceCost), "Text", table.Rows[0]["FacultativeReinsuranceCost"]);
					//UIActionExt(By.CssSelector(txtReinsuranceCost + "[value='" + table.Rows[0]["FacultativeReinsuranceCost"] + "']"), "ispresent");

					try
					{
						if (IsElementPresent(driver, By.CssSelector(lstOvrDed)) == false)
						{
							WaitUntilElementVisible(driver, By.CssSelector(lstOvrDed), 30);
						}
					}
					catch (System.Exception e)
					{
						System.Console.WriteLine("Exception Caught: " + e);
					}
					UIActionExt(By.CssSelector(lstOvrDed), "List", table.Rows[0]["OverrideDeductible"]);
					//UIActionExt(By.CssSelector(lstOvrDed + "[value='" + table.Rows[0]["OverrideDeductible"] + "']"), "ispresent");

					break;
				default:
					break;
			}
		}

		public void ClickNext()
		{
			UIActionExt(By.CssSelector(btnNext), "click");
			UIActionExt(By.CssSelector(btnNewLocation), "ispresent");
		}
		public CL_BusinessOwnersLine_PC9(IWebDriver driver) : base(driver)
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

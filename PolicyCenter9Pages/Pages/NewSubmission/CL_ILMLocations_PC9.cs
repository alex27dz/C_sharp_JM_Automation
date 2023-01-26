
using OpenQA.Selenium;
using WebCommonCore;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_ILMLocations_PC9 : Page
	{
		string btnAddAllExistingLocs = "span[id$=':ILMLocation_JMICScreen:AddAllLocations-btnInnerEl']";
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lnkJudgment = "span[id$=':ILMLocationModifiers_JMICCV:ModifiersTab-btnInnerEl']";
		string SegmentationCode = "input[id$=':SegmentationCode_JMIC-inputEl']";
		public void AddExistingLocation(int locationNumber)
		{
			string linkILMLocation = linkILMLocation = "a[id$=':" + (locationNumber - 1) + ":LocationNumber']";

			UIActionExt(By.CssSelector(btnAddAllExistingLocs), "ispresent");
			UIActionExt(By.CssSelector(btnAddAllExistingLocs), "click");
			UIActionExt(By.CssSelector(linkILMLocation), "ispresent");
			UIActionExt(By.CssSelector(linkILMLocation), "click");
			UIActionExt(By.CssSelector(SegmentationCode), "ispresent");
		}

		public void AddEmpDisHonesty(Table table)
		{
			string chchkEmpDis = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:_checkbox']";
			string lstLimit = "input[id$=':0:EmpDshnstLimt_JMIC-inputEl']";
			string lstDed = "input[id$=':1:DeductibleTermInput-inputEl']";

			UIActionExt(By.CssSelector(chchkEmpDis), "ispresent");
			UIActionExt(By.CssSelector(chchkEmpDis), "click");
			UIActionExt(By.CssSelector(lstLimit), "ispresent");
			UIActionExt(By.CssSelector(lstLimit), "List", table.Rows[0]["EmpDisHonesty_Limit"]);
			UIActionExt(By.CssSelector(lstDed), "ispresent");
			UIActionExt(By.CssSelector(lstDed), "List", table.Rows[0]["EmpDisHonesty_Ded"]);

		}

		public void AddHotelMotelCoverage_ILM(Table table)
		{
			string chkHotelCov = "input[id$=':1:ILMCoverageInputSet:CovPatternInputGroup:_checkbox']";
			string txtPremium = "input[id$=':1:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput-inputEl']";

			UIActionExt(By.CssSelector(chkHotelCov), "ispresent");
			UIActionExt(By.CssSelector(chkHotelCov), "click");
			UIActionExt(By.CssSelector(txtPremium), "ispresent");
			UIActionExt(By.CssSelector(txtPremium), "Text", table.Rows[0]["Premium"]);
		}

		public void AddTradeShowcasesCovg(Table table)
		{
			string tabOffPremises = "span[id$=':OffPremiseCoveragesTab-btnInnerEl']";
			string btnAddCoverage = "span[id$=':OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton-btnInnerEl']";
			string lnkTradeShow = "span[id$=':ILMLineCoveragesPanelSet:ToolbarButton:1:subItemCoverable-textEl']";
			string lnkTradeShow_jsp = "span[id$=':ILMLineCoveragesPanelSet:ToolbarButton:0:subItemCoverable-textEl']";
			string txtShowcaseLocationName = "textarea[id$=':0:ILMCovTermInputSet:StringTermInputMed-inputEl']";
			string txtShowcaseAddress = "textarea[id$=':1:ILMCovTermInputSet:StringTermInputMed-inputEl']";
			string txtItemDesc = "textarea[id$=':2:ILMCovTermInputSet:StringTermInputMed-inputEl']";
			string txtShowcaseLimit = "input[id$=':3:ILMCovTermInputSet:DirectTermInput-inputEl']";
			string lstShowcaseDeductible = "input[id$=':4:ILMCovTermInputSet:OptionTermInput-inputEl']";
			string lblLOB = "span[id$=':JobWizardInfoBar:OfferingLabel-btnInnerEl']";

			string LOB = driver.FindElement(By.CssSelector(lblLOB)).Text;
			UIActionExt(By.CssSelector(tabOffPremises), "click");
			UIActionExt(By.CssSelector(btnAddCoverage), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnAddCoverage)));
			UIActionExt(By.CssSelector(btnAddCoverage), "click");
			if (LOB == "Jewelers Standard Pak")
			{
				UIActionExt(By.CssSelector(lnkTradeShow_jsp), "ispresent");
				UIActionExt(By.CssSelector(lnkTradeShow_jsp), "click");
			}
			else
			{
				UIActionExt(By.CssSelector(lnkTradeShow), "ispresent");
				UIActionExt(By.CssSelector(lnkTradeShow), "click");
			}
			UIActionExt(By.CssSelector(txtShowcaseLocationName), "ispresent");
			UIActionExt(By.CssSelector(txtShowcaseLocationName), "Text", table.Rows[0]["ShowcaseLocationName"]);
			UIActionExt(By.CssSelector(txtShowcaseAddress), "ispresent");
			UIActionExt(By.CssSelector(txtShowcaseAddress), "Text", table.Rows[0]["ShowcaseAddress"]);
			UIActionExt(By.CssSelector(txtItemDesc), "ispresent");
			UIActionExt(By.CssSelector(txtItemDesc), "Text", table.Rows[0]["ItemDesc"]);
			UIActionExt(By.CssSelector(txtShowcaseLimit), "ispresent");
			UIActionExt(By.CssSelector(txtShowcaseLimit), "Text", table.Rows[0]["ShowcaseLimit"]);
			UIActionExt(By.CssSelector(lstShowcaseDeductible), "ispresent");
			UIActionExt(By.CssSelector(lstShowcaseDeductible), "Text", table.Rows[0]["ShowcaseDeductible"]);
		}
		public void ILMLocationsNext()
		{
			UIActionExt(By.CssSelector(btnNext), "click");
			UIActionExt(By.CssSelector(lnkJudgment), "ispresent");
		}


		public CL_ILMLocations_PC9(IWebDriver driver) : base(driver)
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

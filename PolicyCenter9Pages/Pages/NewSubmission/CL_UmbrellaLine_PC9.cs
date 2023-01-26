using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_UmbrellaLine_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string txtUbrellaLimit = "input[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBLimit-inputEl']";
		string txtSelfInsured = "input[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBSI-inputEl']";
		string txtAddlPremium = "input[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:DirectTermInput-inputEl']";
		string lblUWriting = "span[id$=':UMBUnderwritingScreen:ttlBar']";
		string tblUMBModifier = "table[id$=':UMBWizardStepGroup:UMBModifiersScreen:ScheduleRateDV_ref-table']";
		public void BOUmbrellaLineDetails(Table table)
		{
			if (table.Rows[0]["UmbrellaLimit"] != "1,000,000")
			{
				UIActionExt(By.CssSelector(txtUbrellaLimit), "ispresent");
				UIActionExt(By.CssSelector(txtUbrellaLimit), "Text", table.Rows[0]["UmbrellaLimit"]);
			}
			UIActionExt(By.CssSelector(txtSelfInsured), "ispresent");
			UIActionExt(By.CssSelector(txtSelfInsured), "Text", table.Rows[0]["SelfInsuredRetention"]);
		}
		public void BOUmbrellaLineDetails_CLRI(Table table)
		{
			UIActionExt(By.CssSelector(txtUbrellaLimit), "ispresent");
			UIActionExt(By.CssSelector(txtUbrellaLimit), "List", table.Rows[0]["UmbrellaLimit"]);
			try
			{
				if (IsElementPresent(driver, By.CssSelector(txtAddlPremium)) == false)
				{
					WaitUntilElementVisible(driver, By.CssSelector(txtAddlPremium), 5);
				}
			}
			catch (System.Exception e)
			{
				System.Console.WriteLine("Exception Caught: " + e);
			}
			UIActionExt(By.CssSelector(txtAddlPremium), "Text", table.Rows[0]["AdditionalPremium"]);
			UIActionExt(By.CssSelector(txtSelfInsured), "ispresent");
			UIActionExt(By.CssSelector(txtSelfInsured), "Text", table.Rows[0]["SelfInsuredRetention"]);
			ClickNext();
		}
		public void ClickNext()
		{
			UIActionExt(By.CssSelector(btnNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(tblUMBModifier));
		}
		public void ClickNextNoModifierPage()
		{
			UIActionExt(By.CssSelector(btnNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblUWriting));
		}


		public CL_UmbrellaLine_PC9(IWebDriver driver) : base(driver)
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


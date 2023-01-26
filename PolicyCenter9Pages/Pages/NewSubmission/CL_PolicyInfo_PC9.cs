
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;
using HelperClasses;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_PolicyInfo_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string PolicySignatureDate = "input[id$=':PolicyInfoCLDetailsInputSet:SignatureDate-inputEl']";
		string btnILMAddCovg = "span[id$=':CoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton-btnInnerEl']";

		string lstTermType = "input[id$=':TermType-inputEl']";
		string txtEffDate = "input[id$=':EffectiveDate-inputEl']";
		string txtExpDate = "input[id$=':ExpirationDate-inputEl']";

		string lnkProducerSearchIcon = "div[id$=':SelectProducerCode']";
		string lnkOrgSearchIcon = "div[id$=':SelectOrganization']";
		string txtProducerCode = "input[id$=':ProducerCode-inputEl']";
		string btnOrgSearch = "a[id$=':OrganizationSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";
		string btnOrgSelect = "a[id$=':OrganizationSearchResultsLV:0:_Select']";

		string btnProSearch = "a[id$=':ProducerCodeSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";
		string btnProSelect = "a[id$=':ProducerCodeSearchLV:0:_Select']";

		//string radioTerrorAccept = "input[id$=':TerrorSelect_option0-inputEl']";
		string radioTerrorReject = "input[id$=':TerrorSelect_option1-inputEl']";
		string lblBusinessownersLine = "span[class='g-title'][id$=':BOPScreen:ttlBar']";
		string lblInlandMarineLine = "span[class='g-title'][id$=':ILMLineCoveragesScreen:ttlBar']";

		public void EnterPolicyInfo_ST()
		{
			DateTime tempDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
			var policySignatureDate = tempDate.ToShortDateString();
			WaitFor(driver.FindElement(By.CssSelector(PolicySignatureDate)));
			UIAction(PolicySignatureDate, policySignatureDate, "textbox");
			UIAction(btnNext, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(btnILMAddCovg));
		}
		public void CL_EnterPolicyInfo(Table table)
		{
			string LOB = WaitFor(driver.FindElement(By.CssSelector("span[id$=':OfferingLabel-btnInnerEl']"))).Text.ToString();
			if (table.Rows[0]["TermType"].ToString() != "")
			{
				UIActionExt(By.CssSelector(lstTermType), "Text", table.Rows[0]["TermType"]);
			}
			UIActionExt(By.CssSelector("input[id$=':BaseState-inputEl']"), "ispresent");
			string sBaseState = driver.FindElement(By.CssSelector("input[id$=':BaseState-inputEl']")).GetAttribute("value");
			DataStorage tempData = new DataStorage();
			tempData.StoreTempValue("guidewire", "BASE_STATE", sBaseState);
			if (table.Rows[0]["TermType"].ToLower() != "")
			{
				if (table.Rows[0]["TermType"].ToLower() != "other")
				{
					string AnnualDate = GetCurrSysDate(table.Rows[0]["PolicyEffDate"]);
					UIActionExt(By.CssSelector(txtEffDate), "Text", AnnualDate);

				}
			}
			string SignDate = GetCurrSysDate("SYSTEMDATE");
			UIActionExt(By.CssSelector(PolicySignatureDate), "Text", SignDate);
			ClickNext(LOB);
		}

		public void ClickNext(string LOB)
		{
			UIAction(btnNext, string.Empty, "span");
			switch (LOB)
			{
				case "Jewelers Block Pak":
				case "Jewelers Block":
				case "Jewelers Standard":
				case "Jewelers Standard Pak":
					WaitUntilElementVisible(driver, By.CssSelector(lblInlandMarineLine));
					break;
				case "Businessowners":
				case "BOP Select - Property Only":
					WaitUntilElementVisible(driver, By.CssSelector(lblBusinessownersLine));
					break;
				default:
					break;
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
		public CL_PolicyInfo_PC9(IWebDriver driver) : base(driver)
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

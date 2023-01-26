using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_Reinsurance_PC9 : Page
	{
		string btnAddFac = "span[id$=':AddFacButton-btnInnerEl']";
		string btnCreateNew = "span[id$=':AddFacButton:NewFacAgreementMenuItem-textEl']";
		string lnkExcssOfLoss = "span[id$=':AddFacButton:NewFacAgreementMenuItem:0:NewFac-textEl']";

		string txtAggNumber = "input[id$=':AgreementNumber-inputEl']";
		string txtAggName = "input[id$=':Name-inputEl']";
		string txtAttPoint = "input[id$=':AttachmentPoint-inputEl']";
		string txtCovgLimit = "input[id$=':Limit-inputEl']";
		string txtCededShare = "input[id$=':CededShare-inputEl']";
		string txtCededPremium = "input[id$=':CededPremium-inputEl']";
		string txtCededComm = "input[id$=':Commission-inputEl']";
		string btnMakeActive = "span[id$=':MakeActiveButton-btnInnerEl']";
		string btnValidate = "span[id$=':ValidateButton-btnInnerEl']";
		string btnAdd = "span[id$=':ParticipantsLV_tb:Add-btnInnerEl']";
		string lnkCreateCompany = "span[id$=':Add:NewCompany-textEl']";

		string txtCompanyName = "input[id$=':GlobalContactNameInputSet:Name-inputEl']";
		string btnOK = "span[id$=':ForceDupCheckUpdate-btnInnerEl']";
		string btnAggOK = "span[id$=':Update-btnInnerEl']";
		string radioIsJeweler = "input[id$=':IsCompanyJeweler_true-inputEl']";
		string txtGAddr1 = "input[id$=':ContactDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:AddressLine1-inputEl']";
		string txtGCity = "input[id$=':ContactDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:City-inputEl']";
		string lstGstate = "input[id$=':ContactDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:State-inputEl']";
		string txtGZipCode = "input[id$=':ContactDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:PostalCode-inputEl']";
		string txtGCountry = "input[id$=':ContactDV:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:Country-inputEl']";

		string txtMAddr1 = "input[id$=':mailAddress:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:AddressLine1-inputEl']";
		string txtMCity = "input[id$=':mailAddress:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:City-inputEl']";
		string lstMstate = "input[id$=':mailAddress:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:State-inputEl']";
		string txtMZipCode = "input[id$=':mailAddress:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:PostalCode-inputEl']";
		string txtMCountry = "input[id$=':mailAddress:AddressInputSet:globalAddressContainer:GlobalAddressInputSet:Country-inputEl']";


		string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
		string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
		string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
		string btnPopUpOK = "a[id='button-1005']";
		string lnkPolicy = "div[id='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lblQuote = "span[id$=':SubmissionWizard_MultiLine_QuoteScreen:ttlBar']";

        public void verifyAgreementNum(Table table)
        {
            string lnkAgreementNum = "a[id$=':PolicyReinsuranceScreen:PolicyReinsuranceCV:PerRisksLV:RIAgreementsLV:0:Number']";

            UIActionExt(By.CssSelector(btnAddFac), "ispresent");
            UIActionExt(By.XPath("//div[text()[contains(.,'EPLI')]]"), "click");
            UIActionExt(By.XPath("//div[text()[contains(.,'EPLI')]]"), "ispresent", "", 1);
            string sActualValue = driver.FindElement(By.CssSelector(lnkAgreementNum)).Text;
            Console.WriteLine("Expected Agreement Number: " + table.Rows[0]["AgreementNumber"]);
            Console.WriteLine("Actual   Agreement Number: " + sActualValue);
            if (table.Rows[0]["AgreementNumber"] != sActualValue)
            {
                Assert.Fail("Agreement mismatch.");
            }
        }


        public void AddFacultative(Table table)
		{
			UIActionExt(By.CssSelector(btnAddFac), "ispresent");
			for (int i = 0; i <= table.Rows.Count - 1; i++)
			{
				if (table.Rows[i]["GroupCovg"].ToString().ToLower().Contains("location 1"))
				{
					UIActionExt(By.XPath("//div[text()[contains(.,'Location 1: ')]]"), "click");
					UIActionExt(By.XPath("//div[text()[contains(.,'Location 1: ')]]"), "ispresent", "", 1);
				}
				else
				{
					UIActionExt(By.XPath("//div[text()[contains(.,'" + table.Rows[i]["GroupCovg"].ToString() + "')]]"), "click");
					UIActionExt(By.XPath("//div[text()[contains(.,'" + table.Rows[i]["GroupCovg"].ToString() + "')]]"), "ispresent", "", 1);
				}
				UIActionExt(By.CssSelector(btnAddFac), "ispresent");
				ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnAddFac)));
				UIActionExt(By.CssSelector(btnAddFac), "click");
				driver.FindElement(By.CssSelector(btnAddFac)).SendKeys(Keys.ArrowDown);
				UIActionExt(By.CssSelector(btnCreateNew), "ispresent");
				driver.FindElement(By.CssSelector(btnCreateNew)).SendKeys(Keys.ArrowRight);
				UIActionExt(By.CssSelector(lnkExcssOfLoss), "ispresent");
				UIActionExt(By.CssSelector(lnkExcssOfLoss), "click");
				string sAggNumber = GetUniqueValue();
				UIActionExt(By.CssSelector(txtAggNumber), "Text", sAggNumber);
				UIActionExt(By.CssSelector(txtAggName), "Text", table.Rows[i]["AggName"]);
				UIActionExt(By.CssSelector(txtAttPoint), "Text", table.Rows[i]["AttachmentPoint"]);
				UIActionExt(By.CssSelector(txtCovgLimit), "Text", table.Rows[i]["CoverageLimit"]);
				UIActionExt(By.CssSelector(txtCededShare), "List", table.Rows[i]["CededShare"]);
				UIActionExt(By.CssSelector(txtCededPremium), "Text", table.Rows[i]["CededPremium"]);
				UIActionExt(By.CssSelector(txtCededComm), "Text", table.Rows[i]["CommissionPer"]);
				var addBtn = driver.FindElement(By.CssSelector(btnAdd));
				Actions actions = new Actions(driver);
				actions.MoveToElement(addBtn);
				actions.Perform();
				UIActionExt(By.CssSelector(btnAdd), "click");
				UIActionExt(By.CssSelector(lnkCreateCompany), "click");
				UIActionExt(By.CssSelector(txtCompanyName), "ispresent");
				UIActionExt(By.CssSelector(txtCompanyName), "Text", table.Rows[i]["ContactName"]);


				UIActionExt(By.CssSelector(radioIsJeweler), "click");
				if (string.Equals(table.Rows[0]["Country"].ToLower(), "usa") == false)
				{
					UIActionExt(By.CssSelector(txtGCountry), "List", table.Rows[i]["Country"]);
				}
				UIActionExt(By.CssSelector(txtGAddr1), "ispresent");
				UIActionExt(By.CssSelector(txtGAddr1), "Text", table.Rows[i]["AddressLine1"]);
				UIActionExt(By.CssSelector(txtGCity), "Text", table.Rows[i]["City"]);
				UIActionExt(By.CssSelector(lstGstate), "List", table.Rows[i]["State"]);
				UIActionExt(By.CssSelector(txtGZipCode), "ispresent");
				UIActionExt(By.CssSelector(txtGZipCode), "List", table.Rows[i]["ZipCode"]);
				try
				{
					WaitUntilElementVisible(driver, By.CssSelector(txtGZipCode + "[value^='" + table.Rows[i]["ZipCode"] + "]"), 5);
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception Caught: " + e);
				}
				if (string.Equals(table.Rows[0]["Country"].ToLower(), "usa") == false)
				{
					UIActionExt(By.CssSelector(txtMCountry), "List", table.Rows[i]["Country"]);
				}
				UIActionExt(By.CssSelector(txtMAddr1), "ispresent");
				UIActionExt(By.CssSelector(txtMAddr1), "Text", table.Rows[i]["AddressLine1"]);
				UIActionExt(By.CssSelector(txtMCity), "Text", table.Rows[i]["City"]);
				UIActionExt(By.CssSelector(lstMstate), "List", table.Rows[i]["State"]);
				UIActionExt(By.CssSelector(txtMZipCode), "ispresent");
				UIActionExt(By.CssSelector(txtMZipCode), "List", table.Rows[i]["ZipCode"]);
				try
				{
					WaitUntilElementVisible(driver, By.CssSelector(txtMZipCode + "[value^='" + table.Rows[i]["ZipCode"] + "]"), 5);
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception Caught: " + e);
				}
				UIActionExt(By.CssSelector(btnOK), "ispresent");
				UIActionExt(By.CssSelector(btnOK), "click");
				UIActionExt(By.CssSelector(btnAggOK), "ispresent");
				UIActionExt(By.CssSelector(btnAggOK), "click");
				UIActionExt(By.CssSelector(btnAggOK), "ispresent");
				UIActionExt(By.CssSelector(btnAggOK), "click");
				UIActionExt(By.XPath("//a[text()[contains(.,'" + sAggNumber + "')]]"), "ispresent");
				UIActionExt(By.XPath("//a[text()[contains(.,'" + sAggNumber + "')]]"), "click");
				UIActionExt(By.CssSelector(btnMakeActive), "ispresent");
				UIActionExt(By.CssSelector(btnMakeActive), "click");
				UIActionExt(By.CssSelector(btnValidate), "ispresent");
				UIActionExt(By.CssSelector(btnValidate), "click");
				WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'This agreement is valid')]]"), 10);
				if (IsElementPresent(driver, By.XPath("//div[text()[contains(.,'This agreement is valid')]]")) == false)
				{
					Assert.Fail("Agreement not validated");
				}
				UIActionExt(By.XPath("//a[text()='Return to Reinsurance']"), "ispresent");
				UIActionExt(By.XPath("//a[text()='Return to Reinsurance']"), "click");
			}
			UIActionExt(By.XPath("//span[text()='Risk Analysis']"), "ispresent");
			UIActionExt(By.XPath("//span[text()='Risk Analysis']"), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
			int BtnTotAppr;
			string btnAproove = "a[id$=':UWIssueRowSet:Approve']";
			btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
			BtnTotAppr = driver.FindElements(By.CssSelector(btnAproove)).ToList().Count;
			BtnTotAppr = BtnTotAppr + driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;

			//int BtnTotAppr = driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
			Console.WriteLine("Total Approve Btns: " + BtnTotAppr);
			for (int i = 1; i <= BtnTotAppr; i++)
			{
				btnAproove = "a[id$=':1:UWIssueRowSet:Approve']";
				btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
				WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
				if (IsElementPresent(driver, By.CssSelector(btnSplApprove)) == true)
				{
					UIActionExt(By.CssSelector(btnSplApprove), "click");
				}
				else
				{
					UIActionExt(By.CssSelector(btnAproove), "click");
				}
				WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
				if (IsElementPresent(driver, By.CssSelector(btnPopUpOK)) == true)
				{
					UIActionExt(By.CssSelector(btnPopUpOK), "click");
				}
				WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
				if (IsElementPresent(driver, By.CssSelector(btnRAOK)) == true)
				{
					UIActionExt(By.CssSelector(btnRAOK), "click");
				}
				WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);

				if (IsElementPresent(driver, By.CssSelector(btnPopUpOK)) == true)
				{
					UIActionExt(By.CssSelector(btnPopUpOK), "click");
				}
				UIActionExt(By.CssSelector(lblRiskAnalysis), "ispresent");
			}
			UIActionExt(By.CssSelector(btnNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblQuote));
		}
		public void SearchDraftPolicy(string AccNumber)
		{
			string lnkSearchTab = "a[id$='TabBar:SearchTab']";
			string btnReset = "a[id$=':SearchLinksInputSet:Reset']";
			string lstSearchFor = "input[id$=':SearchFor-inputEl']";
			string txtAccNum = "input[id$=':AccountNumber-inputEl']";
			string btnSearchlink = "a[id$=':PolicySearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";
			string lnkSubmissionNum = "a[id$=':0:SubmissionNumber']";

			DataStorage temp = new DataStorage();
			string AccountNum = null;
			switch (AccNumber.ToUpper().Trim())
			{
				case "REGISTRY":
					AccountNum = temp.GetTempValue("ACCNO");
					break;
				default:
					AccountNum = AccNumber;
					break;
			}
			UIActionExt(By.CssSelector(lnkSearchTab), "ispresent");
			UIActionExt(By.CssSelector(lnkSearchTab), "click");
			UIActionExt(By.CssSelector(btnReset), "ispresent");
			UIActionExt(By.CssSelector(btnReset), "click");
			UIActionExt(By.CssSelector(lstSearchFor), "List", "Submission");
			UIActionExt(By.CssSelector(txtAccNum), "Text", AccountNum);
			UIActionExt(By.CssSelector(btnSearchlink), "click");
			UIActionExt(By.CssSelector(lnkSubmissionNum), "ispresent");
			UIActionExt(By.CssSelector(lnkSubmissionNum), "click");
		}
		public string GetUniqueValue()
		{
			DateTime myDateTime = DateTime.Now;
			string agreenumber = myDateTime.ToShortDateString();
			string time = myDateTime.ToLongTimeString();
			time = time.Replace(":", "");
			time = time.Substring(0, 5);
			agreenumber = agreenumber.Replace("/", "");
			string day = myDateTime.Day.ToString();
			string hour = myDateTime.Hour.ToString();
			string minute = myDateTime.Minute.ToString();
			string second = myDateTime.Second.ToString();
			string GetUniqueValue = agreenumber + day + hour + minute + second;
			return GetUniqueValue;
		}
		public CL_Reinsurance_PC9(IWebDriver driver) : base(driver)
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

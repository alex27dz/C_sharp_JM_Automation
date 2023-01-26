using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.CreateAccount
{
	public class CL_CreateAccount_PC9 : Page
	{
		string CompanyName = "input[id$=':Name-inputEl']";
		string srchResultsCreateNewAcct = "span[id$=':NewAccountButton-btnInnerEl']";
		string PrimaryEmail = "input[id$=':EmailAddress1-inputEl']";
		string AddressLine1 = "input[id$=':AddressLine1-inputEl']";
		string City = "input[id$=':City-inputEl']";
		string ZipCode = "input[id$=':PostalCode-inputEl']";
		string State = "input[id$=':State-inputEl']";
		string Country = "input[id$=':Country-inputEl']";
		string FEINid = "input[id$=':OfficialIDDV_Input-inputEl']";
		string AddressType = "input[id$=':AddressType-inputEl']";
		string OrgType = "input[id$=':OrgType-inputEl']";
		string IsJewelerYes = "input[id$=':IsAccountHolderJeweler_true-inputEl']";
		string IsJewelerNo = "input[id$=':IsAccountHolderJeweler_false-inputEl']";
		string imgSearchProducer = "div[id$=':ProducerSelectionInputSet:Producer:SelectOrganization']";
		string producerCode = "input[id$=':ProducerCode-inputEl']";
		string searchBtn = "a[id$=':SearchLinksInputSet:Search']";
		string selectFirstSearchResult = "a[id$=':0:_Select']";
		string UpdateAccount = "span[id='CreateAccount:CreateAccountScreen:Update-btnInnerEl']";
		string accountNumber = "div[id$=':AccountFile_Summary_BasicInfoDV:AccountNumber-inputEl']";
		string accountSummary = "span[id='AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_RefreshButton-btnInnerEl']";
		string newAccountCompany = "span[id$=':NewAccount_Company-textEl']";

		public void SearchCompany(string companyName)
		{
			UIActionExt(By.CssSelector(CompanyName), "Text", companyName);
			UIActionExt(By.CssSelector(searchBtn), "click");
			UIActionExt(By.CssSelector(srchResultsCreateNewAcct), "Sync");
			UIActionExt(By.CssSelector(srchResultsCreateNewAcct), "click");
			UIActionExt(By.CssSelector(newAccountCompany), "click");
			UIActionExt(By.CssSelector(PrimaryEmail), "Sync");
		}
		public void CL_NewAccountDetails(Table table)
		{
			string sUSA = "united states of america";
			string accNo;
			UIActionExt(By.CssSelector(PrimaryEmail), "Text", table.Rows[0]["PrimaryEmail"]);
			ScenarioContext.Current["country"] = table.Rows[0]["Country"];
			if (string.Equals(table.Rows[0]["Country"].ToLower(), sUSA) == false)
			{
				UIActionExt(By.CssSelector(Country), "List", table.Rows[0]["Country"]);
			}
			UIActionExt(By.CssSelector(AddressLine1), "Text", table.Rows[0]["AddressLine1"]);
			UIActionExt(By.CssSelector(City), "List", table.Rows[0]["City"]);
			if (string.Equals(table.Rows[0]["Country"].ToLower(), sUSA) == false)
			{
				try
				{
					WaitUntilElementVisible(driver, By.CssSelector(State), 15);
				}
				catch (Exception e)
				{
					Console.WriteLine("Known Exception: " + e);
				}
				UIActionExt(By.CssSelector(State), "Text", " ");
				WaitUntilElementVisible(driver, By.CssSelector(State + "[value='<none>']"));
				try
				{
					WaitUntilElementVisible(driver, By.CssSelector(accountSummary), 5);
				}
				catch (Exception e)
				{
					Console.WriteLine("Known Exception" + e);
				}
				UIActionExt(By.CssSelector(State), "List", table.Rows[0]["State"]);
				UIActionExt(By.CssSelector(ZipCode), "ispresent");
				UIActionExt(By.CssSelector(ZipCode), "click");
				try
				{
					WaitUntilElementVisible(driver, By.CssSelector(accountSummary), 5);
				}
				catch (Exception e)
				{
					Console.WriteLine("Known Exception" + e);
				}
			}
			else
			{
				UIActionExt(By.CssSelector(State), "ispresent");
				UIActionExt(By.CssSelector(State), "List", table.Rows[0]["State"]);
			}
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
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector(accountSummary), 10);
			}
			catch (Exception e)
			{
				Console.WriteLine("Known Exception" + e);
			}
			UIActionExt(By.CssSelector(FEINid), "List", "21-3121334");
			UIActionExt(By.CssSelector(AddressType), "List", table.Rows[0]["AddressType"]);
			UIActionExt(By.CssSelector(OrgType), "List", table.Rows[0]["OrgType"]);
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector(IsJewelerYes), 10);
			}
			catch (Exception e)
			{
				Console.WriteLine("Caught Exception: " + e);
			}
			if (table.Rows[0]["IsJeweler"].ToLower() == "yes")
			{
				UIActionExt(By.CssSelector(IsJewelerYes), "click");
			}
			else if (table.Rows[0]["IsJeweler"].ToLower() == "no")
			{
				UIActionExt(By.CssSelector(IsJewelerNo), "click");
			}

			UIActionExt(By.CssSelector(imgSearchProducer), "ispresent");
			UIActionExt(By.CssSelector(imgSearchProducer), "click");
			UIActionExt(By.CssSelector(producerCode), "Text", table.Rows[0]["ProducerCode"]);
			UIActionExt(By.CssSelector(searchBtn), "click");
			UIActionExt(By.CssSelector(selectFirstSearchResult), "ispresent");
			UIActionExt(By.CssSelector(selectFirstSearchResult), "click");
			UIActionExt(By.CssSelector(UpdateAccount), "ispresent");
			UIActionExt(By.CssSelector(UpdateAccount), "click");
			UIActionExt(By.CssSelector(accountSummary), "ispresent");
			accNo = driver.FindElement(By.CssSelector(accountNumber)).Text;
			Console.WriteLine("Account Number:{0}", accNo);
			ScenarioContext.Current["ACCOUNT"] = accNo;
		}

		public CL_CreateAccount_PC9(IWebDriver driver) : base(driver)
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

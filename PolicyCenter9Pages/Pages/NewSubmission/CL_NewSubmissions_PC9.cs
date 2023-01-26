
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebCommonCore;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_NewSubmissions_PC9 : Page
	{
		string txtPolicyEffDate = "input[id$=':ProductSettingsDV:effDate-inputEl']";
		string tblProductName = "div[id$=':ProductOffersDV:ProductSelectionLV']";
		string selOfferingSelection = "input[id$=':OfferingScreen:OfferingSelection-inputEl']";
		string productNameColumn= "//span[text()='Product Name']";
		public void StartNewCLSubmission(Table table)
		{
			string policyEffDate = GetCurrSysDate(table.Rows[0]["PolicyEffDate"]);
			string policyExpDate = Convert.ToDateTime(policyEffDate).AddYears(1).ToString("MM/dd/yyyy");
			ScenarioContext.Current["PCLYEFFDATE"] = policyEffDate;
			ScenarioContext.Current["PCLYEXPFDATE"] = policyExpDate;
			UIActionExt(By.CssSelector(txtPolicyEffDate), "Text", policyEffDate);
			UIActionExt(By.CssSelector(tblProductName), "ispresent");
			driver.FindElement(By.XPath(productNameColumn)).Click();

			var ProductMainTable = driver.FindElement(By.CssSelector(tblProductName));
			List<IWebElement> lsGetTblElements = new List<IWebElement>(ProductMainTable.FindElements(By.TagName("table")));
			Console.WriteLine("Products Table Row Count: " + lsGetTblElements.Count);
			for (int i = 0; i <= lsGetTblElements.Count - 1; i++)
			{
				List<IWebElement> lsGetTdElements = null;
				try
				{
					lsGetTdElements = new List<IWebElement>(lsGetTblElements[i].FindElements(By.TagName("td")));
				} catch (StaleElementReferenceException e)
                {
					pause();
					lsGetTdElements = new List<IWebElement>(lsGetTblElements[i].FindElements(By.TagName("td")));
				}
				string lnkSelect = "a[id$='" + i + ":addSubmission']";
				if (lsGetTdElements[1].Text == table.Rows[0]["Product"])
				{
					UIActionExt(By.CssSelector(lnkSelect), "click");
					ScenarioContext.Current["Product"] = table.Rows[0]["Product"];
					break;
				}
			}
			UIActionExt(By.CssSelector(selOfferingSelection), "ispresent");
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
		public CL_NewSubmissions_PC9(IWebDriver driver) : base(driver)
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_Quote_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lblForms = "span[id$=':FormsScreen:ttlBar']";
		string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";
		string totalTaxesSurcharge = "div[id$=':TotTaxesSurChg-inputEl']";
		//SubmissionWizard:SubmissionWizard_QuoteScreen:Quote_SummaryDV:QuoteSummaryPremiumInputSet:TotTaxesSurChg-inputEl

		public void ClickNext()
		{
			if (IsElementPresent(driver, By.CssSelector(btnClear)) == true)
			{
				UIActionExt(By.CssSelector(btnClear), "click");
			}
			
			UIActionExt(By.CssSelector(btnNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lblForms));
		}

		public void verifyKYTaxes()
        {
			WaitUntilElementVisible(driver, By.CssSelector(totalTaxesSurcharge));
			string totalTaxesSurchargeText = driver.FindElement(By.CssSelector(totalTaxesSurcharge)).Text;
			Console.WriteLine("Total Taxes and Surcharges is: " + totalTaxesSurchargeText);
			List<IWebElement> reservetableObj1;
			reservetableObj1 = driver.FindElements(By.Id("SubmissionWizard:SubmissionWizard_QuoteScreen:RatingCumulDetailsPanelSet:2-body")).ToList();
			var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
			Console.WriteLine("number of row is : " + rows1.Count());
			var tds = rows1[0].FindElements(By.TagName("td"));
			Console.WriteLine("number of columns in the first row: " + tds.Count());
			var munTaxRow = rows1[1].FindElements(By.TagName("td"));
			var stateTaxRow = rows1[2].FindElements(By.TagName("td"));
			string munTaxText = munTaxRow[4].Text;
			string statetaxText = stateTaxRow[4].Text;
			Console.WriteLine("MUN_TAX is: " + munTaxText);
			Console.WriteLine("STATE_TAX is: " + statetaxText);
			double munTaxAmount = stringToDouble(munTaxText);
			double stateTaxAmount = stringToDouble(statetaxText);
			double totalAmount = stringToDouble(totalTaxesSurchargeText);
			Console.WriteLine("MUN_Tax in double is: " + munTaxAmount);
			Console.WriteLine("STATE_Tax in double is: " + stateTaxAmount);
			Console.WriteLine("TotalTaxesSurcharges in double is: " + totalAmount);		
			Assert.AreEqual(munTaxAmount + stateTaxAmount, totalAmount);
		}
		public double stringToDouble (string str)
        {
			string numericString = "";
			foreach (char c in str)
			{
				// Check for numeric characters (0-9), a negative sign, or leading or trailing spaces.
				if ((c >= '0' && c <= '9') || c == '.' || c == '-')
				{
					numericString = string.Concat(numericString, c);
				}
			}
			double j = Convert.ToDouble(numericString);
			return j;
		}
		public CL_Quote_PC9(IWebDriver driver) : base(driver)
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


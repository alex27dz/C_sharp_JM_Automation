
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using WebCommonCore;
using TechTalk.SpecFlow;
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_LineSelection_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		//string tblLineSelection = "div[id='SubmissionWizard:CPPLineSelectionScreen:CPPLineSelectionDV:1-body']";
		//string lnkUMBSection = "td[id$=':UMBWizardStepGroup']";
		string tblPreQualification = "div[id$=':PreQualQuestionSetsDV:QuestionSetsDV:1:QuestionSetLV']";
		string PolicySignatureDate = "input[id$=':PolicyInfoCLDetailsInputSet:SignatureDate-inputEl']";
		string btnOK = "a[id='button-1005']";
		public void SelectLinesAddUMB()
		{
			string tblLineSelection = "div[id='SubmissionWizard:CPPLineSelectionScreen:CPPLineSelectionDV:1-body']";
			string lnkUMBSection = "td[id$='SubmissionWizard:LOBWizardStepGroup:UMBWizardStepGroup']";
			UIActionExt(By.CssSelector(tblLineSelection), "ispresent");

			var tblMainTable = driver.FindElement(By.CssSelector(tblLineSelection));
			List<IWebElement> lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			int TotalRows = lsGetTblElements.Count - 1;
			lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			List<IWebElement> lsGetTdElements = new List<IWebElement>(lsGetTblElements[2].FindElements(By.TagName("td")));
			lsGetTdElements[1].Click();
			//MoveToCoordinates(driver, lsGetTdElements[1]);
			//WaitUntilElementVisible(driver, By.CssSelector(lnkUMBSection));
			ClickNext();
		}
		public void SelectLinesAddUMB_BO()
		{
			string tblLineSelection = "div[id='SubmissionWizard:CPPLineSelectionScreen:CPPLineSelectionDV:1-body']";
			string lnkUMBSection = "td[id$='SubmissionWizard:LOBWizardStepGroup:UMBWizardStepGroup']";
			UIActionExt(By.CssSelector(tblLineSelection), "ispresent");

			var tblMainTable = driver.FindElement(By.CssSelector(tblLineSelection));
			List<IWebElement> lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			int TotalRows = lsGetTblElements.Count - 1;
			lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			List<IWebElement> lsGetTdElements = new List<IWebElement>(lsGetTblElements[1].FindElements(By.TagName("td")));
			lsGetTdElements[1].Click();
			WaitUntilElementVisible(driver, By.CssSelector(lnkUMBSection));
			ClickNext();
		}

		public void SelectLinesAddUMB_Renew()
		{
			string tblLineSelection = "div[id$=':CPPLineSelectionScreen:CPPLineSelectionDV:1-body']";
			string lnkUMBSection = "td[id$=':LOBWizardStepGroup:UMBWizardStepGroup']";
			UIActionExt(By.CssSelector(tblLineSelection), "ispresent");

			var tblMainTable = driver.FindElement(By.CssSelector(tblLineSelection));
			List<IWebElement> lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			int TotalRows = lsGetTblElements.Count - 1;
			lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			List<IWebElement> lsGetTdElements = new List<IWebElement>(lsGetTblElements[2].FindElements(By.TagName("td")));
			lsGetTdElements[1].Click();
			WaitUntilElementVisible(driver, By.CssSelector(lnkUMBSection));
			UIAction(btnNext, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(PolicySignatureDate));

		}

		public void SelectLinesRemoveUMB_Renew()
		{
			string tblLineSelection = "div[id$=':CPPLineSelectionScreen:CPPLineSelectionDV:1-body']";
			string lnkUMBSection = "td[id$=':LOBWizardStepGroup:UMBWizardStepGroup']";
			UIActionExt(By.CssSelector(tblLineSelection), "ispresent");

			var tblMainTable = driver.FindElement(By.CssSelector(tblLineSelection));
			List<IWebElement> lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			int TotalRows = lsGetTblElements.Count - 1;
			lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			List<IWebElement> lsGetTdElements = new List<IWebElement>(lsGetTblElements[2].FindElements(By.TagName("td")));
			lsGetTdElements[1].Click();
			WaitUntilElementVisible(driver, By.CssSelector(btnOK));
			driver.FindElement(By.CssSelector(btnOK)).Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lnkUMBSection));
			WaitUntilElementInvisible(driver, By.CssSelector(lnkUMBSection));
			WaitUntilElementInvisible(driver, By.CssSelector(lnkUMBSection));

			UIAction(btnNext, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(PolicySignatureDate));

		}
		public void SelectLinesAddUMB_JSP()
		{
			string tblLineSelection = "div[id$=':CPPLineSelectionScreen:CPPLineSelectionDV:1-body']";
			string lnkUMBSection = "td[id$=':LOBWizardStepGroup:UMBWizardStepGroup']";
			UIActionExt(By.CssSelector(tblLineSelection), "ispresent");

			var tblMainTable = driver.FindElement(By.CssSelector(tblLineSelection));
			List<IWebElement> lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			int TotalRows = lsGetTblElements.Count - 1;
			lsGetTblElements = new List<IWebElement>(tblMainTable.FindElements(By.TagName("table")));
			List<IWebElement> lsGetTdElements = new List<IWebElement>(lsGetTblElements[2].FindElements(By.TagName("td")));
			lsGetTdElements[1].Click();
			WaitUntilElementVisible(driver, By.CssSelector(lnkUMBSection));
			ClickNext();
		}
		public void ClickNext_PlcyInfo()
		{
			UIAction(btnNext, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(PolicySignatureDate));
		}
		public void ClickNext()
		{
			UIAction(btnNext, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(tblPreQualification));
		}

		public void LineSelection(string PolicyType, Table table)
		{
			string lblLOIBOffering = "span[id$=':JobWizardInfoBar:OfferingLabel-btnInnerEl']";
			UIActionExt(By.CssSelector(lblLOIBOffering), "ispresent");
			string Offering = driver.FindElement(By.CssSelector(lblLOIBOffering)).Text;
			string tblLineSelect = "div[id$=':CPPLineSelectionDV:1-body']";
			string btnOK = "a[id='button-1005']";

			//string sLOBtblXPath = "//div[contain(@id=':CPPLineSelectionDV:1-body')]";
			IWebElement tblLineType = driver.FindElement(By.CssSelector("div[id$=':CPPLineSelectionDV:1-body']"));
			List<IWebElement> LineTypes = tblLineType.FindElements(By.TagName("img")).ToList();
			foreach (var item in LineTypes)
			{
				Console.WriteLine(item.GetAttribute("class"));
			}
			for (int i = 0; i <= table.Rows.Count() - 1; i++)
			{
				UIActionExt(By.CssSelector(tblLineSelect), "ispresent");
				tblLineType = driver.FindElement(By.CssSelector(tblLineSelect));
				LineTypes = tblLineType.FindElements(By.TagName("img")).ToList();
				switch (Offering)
				{
					case "Businessowners":
						break;
					case "Jewelers Block Pak":
						if (table.Rows[i]["LOB"].ToString().ToLower() == "inland marine line")
						{
							if (table.Rows[i]["LOB"].ToString().ToLower() == "yes")
							{
								if (LineTypes[0].GetAttribute("class").Contains("checked") == false)
								{
									LineTypes[0].Click();
								}
							}
							else if (table.Rows[i]["LOB"].ToString().ToLower() == "no")
							{
								if (LineTypes[0].GetAttribute("class").Contains("checked") == false)
								{
									LineTypes[0].Click();
								}
							}
						}
						break;
					case "Jewelers Standard Pak":
						break;
					default:
						break;
				}
			}
		}

		public CL_LineSelection_PC9(IWebDriver driver) : base(driver)
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

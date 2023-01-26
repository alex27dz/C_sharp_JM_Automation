
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_SelectPayPlan : Page
	{
		string policyNumber = "";
		string txtBillingMethod = "input[id$=':BillingAdjustmentsDV:BillingMethod-inputEl']";
		string ClickIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions']";
		string BindIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions:BindAndIssue-itemEl']";
		string btnOK = "a[id='button-1005']";
		string lnkPlcy = "div[id$='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";
		string tblInstallmentPlan = "div[id$=':InstallmentPlan:BillingAdjustmentsInstallmentsLV-body']";
		string btnDetails = "span[id$=':DetailsButton-btnInnerEl']";
		string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
		string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
		string lblRiskApproveDetails = "span[id$='RiskApprovalDetailsPopup:ttlBar']";
		string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
		string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";

		public void EnterPaymentDetails(Table table)
		{
			int datarecordindex = -1;
			if (table.Rows[0]["BilingMethod"].ToLower() == "list bill")
			{
				UIActionExt(By.CssSelector(txtBillingMethod), "ispresent");
				UIActionExt(By.CssSelector(txtBillingMethod), "Text", table.Rows[0]["BilingMethod"]);
			}
			IWebElement ObjInstallmentPlan = driver.FindElement(By.CssSelector(tblInstallmentPlan));
			switch (table.Rows[0]["InstallmentPlan"].ToUpper().Trim())
			{
				case "12 PAY":
					datarecordindex = 0;
					break;
				case "2 PAY":
				case "2 PAY - SEMI ANNUALLY":
					datarecordindex = 1;
					break;
				case "4 PAY":
				case "4 PAY - QUARTERLY":
					datarecordindex = 2;
					break;
				case "8 PAY":
					datarecordindex = 3;
					break;

				case "ANNUAL PAY":
					datarecordindex = 4;
					break;
				default:
					Console.WriteLine(table.Rows[0]["InstallmentPlan"] + " , installment plan not recognized");
					Assert.Fail("Please verify installment plan");
					break;
			}
			string tblPayPlan = "div[id$=':BillingAdjustmentsInstallmentsLV-body']";
			string paymentxPath = "//table[@data-recordindex='" + datarecordindex + "']//td[1]//div[1]//div[1]";
			UIActionExt(By.CssSelector(tblPayPlan), "ispresent");
			UIActionExt(By.XPath(paymentxPath), "click");
			//This is for chrome JavaScriptClick(driver.FindElement(By.XPath(paymentxPath)));
			driver.FindElement(By.XPath(paymentxPath)).SendKeys(Keys.Space);
			WaitUntilElementInvisible(driver, By.CssSelector(btnClear));
			UIActionExt(By.CssSelector(tblPayPlan), "ispresent");
		}
		public void CLUWIssuePolicy()
		{
			//string lblIssuesThatBlock = "span[id$='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton-btnInnerEl']";

			string lblIssuesThatBlock = "//span[text()='Issues that block Issuance']";
			UIActionExt(By.CssSelector(ClickIssuePolicy), "click");
			UIActionExt(By.CssSelector(BindIssuePolicy), "ispresent");
			UIActionExt(By.CssSelector(BindIssuePolicy), "click");
			UIActionExt(By.CssSelector(btnOK), "ispresent");
			UIActionExt(By.CssSelector(btnOK), "click");
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector(lblIssuesThatBlock), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			if (IsElementPresent(driver, By.XPath(lblIssuesThatBlock)) == true)
			{
				UIActionExt(By.CssSelector(btnDetails), "click");
				UIActionExt(By.CssSelector(lblRiskAnalysis), "ispresent");
				string btnApprove = "a[id$=':1:UWIssueRowSet:Approve']";
				int BtnTotAppr;
				if (IsElementPresent(driver, By.CssSelector(btnApprove)))
				{
					BtnTotAppr = driver.FindElements(By.CssSelector(btnApprove)).ToList().Count;
				}
				else
				{
					BtnTotAppr = driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
				}

				//int BtnTotAppr = driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
				Console.WriteLine("Total Approve Btns: " + BtnTotAppr);
				for (int i = 1; i <= BtnTotAppr; i++)
				{
					btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
					if (IsElementPresent(driver, By.CssSelector(btnApprove)))
					{
						UIActionExt(By.CssSelector(btnApprove), "click");
					}
					else
					{
						UIActionExt(By.CssSelector(btnSplApprove), "click");
						UIActionExt(By.CssSelector(btnOK), "click");
						UIActionExt(By.CssSelector(lblRiskApproveDetails), "ispresent");
					}
					UIActionExt(By.CssSelector(btnRAOK), "click");
					UIActionExt(By.CssSelector(lblRiskAnalysis), "ispresent");
				}
				UIActionExt(By.CssSelector(ClickIssuePolicy), "ispresent");
				UIActionExt(By.CssSelector(ClickIssuePolicy), "click");
				UIActionExt(By.CssSelector(BindIssuePolicy), "ispresent");
				UIActionExt(By.CssSelector(BindIssuePolicy), "click");
				UIActionExt(By.CssSelector(btnOK), "click");
			}
			UIActionExt(By.CssSelector(lnkPlcy), "ispresent", "", 0, 80, 5);
			Console.WriteLine(driver.FindElement(By.CssSelector(lnkPlcy)).Text);
			policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");
			Console.WriteLine("Policy Number: " + policyNumber);
			ScenarioContext.Current["POLICY"] = policyNumber;
		}
		public void CLIssuePolicy()
		{
			UIActionExt(By.CssSelector(ClickIssuePolicy), "click");
			UIActionExt(By.CssSelector(BindIssuePolicy), "ispresent");
			UIActionExt(By.CssSelector(BindIssuePolicy), "click");
			UIActionExt(By.CssSelector(btnOK), "ispresent");
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(lnkPlcy), "ispresent", "", 0, 180, 5);
			Console.WriteLine(driver.FindElement(By.CssSelector(lnkPlcy)).Text);
			policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");
			Console.WriteLine("Policy Number: " + policyNumber);
			ScenarioContext.Current["POLICY"] = policyNumber;
		}
		public CL_SelectPayPlan(IWebDriver driver) : base(driver)
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

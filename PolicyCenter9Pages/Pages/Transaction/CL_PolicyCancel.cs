using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.Transaction
{
	public class CL_PolicyCancel : Page
	{
		string PlcyClSource = "input[id$=':Source-inputEl']";
		string PlcyClReason = "input[id$=':Reason-inputEl']";
		string PlcyClEffDate = "input[id$=':CancelDate_date-inputEl']";

		string btnStartCancellation = "span[id$=':NewCancellation-btnInnerEl']";
		string lblConfirm = "span[id='CancellationWizard:CancellationWizard_MultiLine_QuoteScreen:ttlBar']";
		string btnBindOptions = "span[id$=':BindOptions-btnInnerEl']";
		string lnkCancelPolicy = "span[id$=':SubmitCancellation-textEl']";
		string btnOK = "a[id='button-1005']";
		string lnkPolicy = "div[id='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";

		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lblILMLocations = "span[id$=':ILMLocation_JMICScreen:ttlBar']";

		string btnquote = "span[id$=':QuoteOrReview-btnInnerEl']";
		string btnReWrite = "span[id$=':BindRewrite-btnInnerEl']";
		//string lblIssuesThatBlock = "span[id$='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton-btnInnerEl']";
		string lblIssuesThatBlock = "//span[text()='Issues that block Issuance']";
		string btnDetails = "span[id$=':DetailsButton-btnInnerEl']";
		string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
		string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
		string lblRiskApproveDetails = "span[id$='RiskApprovalDetailsPopup:ttlBar']";
		string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";

		public void CL_ProrataCancel(Table table)
		{
			UIActionExt(By.CssSelector(PlcyClSource), "ispresent");
			UIActionExt(By.CssSelector(PlcyClSource), "List", table.Rows[0]["Source"]);
			UIActionExt(By.CssSelector(PlcyClReason), "ispresent");
			UIActionExt(By.CssSelector(PlcyClReason), "List", table.Rows[0]["Reason"]);
			if (table.Rows[0]["Reason"].ToString().Contains("Courtesy Flat Cancel") == false)
			{
				UIActionExt(By.CssSelector(PlcyClEffDate), "ispresent");
				string PolicyCancelEffDate = GetCurrSysDate(table.Rows[0]["CancelEffDate"]);
				UIActionExt(By.CssSelector(PlcyClEffDate), "Text", PolicyCancelEffDate);
			}
		}
		public void RewriteNewTerm_RemoveTradeshow()
		{
			string tabOffPremises = "span[id$=':OffPremiseCoveragesTab-btnInnerEl']";
			string btnAddCoverage = "span[id$=':OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton-btnInnerEl']";
			string chkTradeshow = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:_checkbox']";
			string lblTradeshow = "div[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup-legendTitle']";
			string lblExhibition = "label[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TradeshowPicker-labelEl']";
			UIAction(tabOffPremises, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(lblTradeshow)));
			driver.FindElement(By.CssSelector(chkTradeshow)).Click();
			WaitUntilElementInvisible(driver, By.CssSelector(lblExhibition));
		}
		public void NavigateToBOLocs_Rewrite()
		{
			string lnkBusinessOwners = "td[id$=':LOBWizardStepGroup:BOPWizardStepGroup']";
			string lblBusinessOwnersLine = "span[id$=':BOPWizardStepGroup:BOPScreen:ttlBar']";
			string lblLocations = "span[id$=':BOPWizardStepGroup:BOPLocationsScreen:ttlBar']";
			UIAction(lnkBusinessOwners, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblBusinessOwnersLine));
			UIAction(btnNext, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblLocations));
		}
		public void InactivateAI_BO_Loc(Table table)
		{
			string lnkLocation = "a[id$=':LocationsEdit_LV:" + (Convert.ToInt16(table.Rows[0]["Location"]) - 1) + ":Loc']";
			string txtAddress1 = "input[id$=':GlobalAddressInputSet:AddressLine1-inputEl']";
			string btnAdd = "a[id$=':AddContactsButton']";
			string btnUpdateBldg = "span[id$=':Update-btnInnerEl']";
			string lblLocations = "span[id$=':BOPWizardStepGroup:BOPLocationsScreen:ttlBar']";

			UIActionExt(By.CssSelector(lnkLocation), "ispresent");
			UIActionExt(By.CssSelector(lnkLocation), "click");
			UIActionExt(By.CssSelector(txtAddress1), "ispresent");
			UIActionExt(By.CssSelector(btnAdd), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnAdd)));
			IWebElement divAddlIns = driver.FindElement(By.CssSelector("div[id$=':AdditionalInsuredLV-body']"));
			IList<IWebElement> tblBldgAI = divAddlIns.FindElements(By.TagName("img")).ToList();
			tblBldgAI[1].Click();
			UIActionExt(By.CssSelector(btnUpdateBldg), "ispresent");
			ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnUpdateBldg)));
			UIActionExt(By.CssSelector(btnUpdateBldg), "click");
			UIActionExt(By.CssSelector(lblLocations), "ispresent");
		}
		public void ClickNext()
		{
			WaitFor(driver.FindElement(By.CssSelector(btnNext))).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lblILMLocations));
		}
		public void StartCancelAndIssue()
		{
            if ((Boolean)ScenarioContext.Current["RegionAffected"])
            {
                Console.WriteLine("This Region is affected, Policy cannot be cancelled");
            }else
            {
                UIActionExt(By.CssSelector(btnStartCancellation), "ispresent");
                UIActionExt(By.CssSelector(btnStartCancellation), "click");
                UIActionExt(By.CssSelector(btnBindOptions), "ispresent", "", 0, 80, 5);
                UIActionExt(By.CssSelector(btnBindOptions), "click");
                UIActionExt(By.CssSelector(lnkCancelPolicy), "click");
                UIActionExt(By.CssSelector(btnOK), "click");
                UIActionExt(By.CssSelector(lnkPolicy), "ispresent");
            }
        }
		public void RenewAndIssue(Table table)
		{
			string lnkRenew = "span[id$=':SendToRenewal-textEl']";
			string lsRenewalCode = "input[id$=':RenewalCode-inputEl']";
			string btnRenewOK = "span[id$=':Update-btnInnerEl']";
			UIAction(btnBindOptions, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(lnkRenew));
			UIAction(lnkRenew, string.Empty, "span");

			try
			{
				WaitUntilElementVisible(driver, By.XPath(lblIssuesThatBlock), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			if (IsElementPresent(driver, By.XPath(lblIssuesThatBlock)) == true)
			{
				driver.FindElement(By.CssSelector(btnDetails)).Click();
				WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
				int BtnTotAppr;
				string btnApprove = "a[id$=':UWIssueRowSet:Approve']";
				btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
				BtnTotAppr = driver.FindElements(By.CssSelector(btnApprove)).ToList().Count;
				BtnTotAppr = BtnTotAppr + driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
				Console.WriteLine("Total Approve Btns: " + BtnTotAppr);

				for (int i = 1; i <= BtnTotAppr; i++)
				{
					btnApprove = "a[id$=':1:UWIssueRowSet:Approve']";
					btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
					if (IsElementPresent(driver, By.CssSelector(btnApprove)))
					{
						UIActionExt(By.CssSelector(btnApprove), "click");
					}
					else
					{
						UIActionExt(By.CssSelector(btnSplApprove), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
					if (IsElementPresent(driver, By.CssSelector(btnOK)) == true)
					{
						UIActionExt(By.CssSelector(btnOK), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
					if (IsElementPresent(driver, By.CssSelector(btnRAOK)) == true)
					{
						UIActionExt(By.CssSelector(btnRAOK), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);

					if (IsElementPresent(driver, By.CssSelector(btnOK)) == true)
					{
						UIActionExt(By.CssSelector(btnOK), "click");
					}
					WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
				}
				UIAction(btnBindOptions, string.Empty, "span");
				WaitUntilElementVisible(driver, By.CssSelector(lnkRenew));
				UIAction(lnkRenew, string.Empty, "span");
			}
			WaitUntilElementVisible(driver, By.CssSelector(lsRenewalCode), 10);
			driver.FindElement(By.CssSelector(lsRenewalCode)).Click();
			driver.FindElement(By.CssSelector(lsRenewalCode)).Clear();
			driver.FindElement(By.CssSelector(lsRenewalCode)).SendKeys(table.Rows[0]["RenewalCode"]);
			UIAction(btnRenewOK, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(btnOK));
			driver.FindElement(By.CssSelector(btnOK)).Click();
			UIActionExt(By.CssSelector(lnkPolicy), "ispresent", "", 0, 48, 5);
		}
		public void RecindPolicy()
		{
            if ((Boolean)ScenarioContext.Current["RegionAffected"])
            {
                Console.WriteLine("This region is affected by policy hold, this step is skipped");
            }
            else
            {
                string btnCLoseOptions = "span[id$=':CloseOptions-btnInnerEl']";
			string lnkRescindCancel = "span[id$=':RescindCancellation-textEl']";
			driver.FindElement(By.CssSelector(btnCLoseOptions)).Click(); ;
			WaitUntilElementInvisible(driver, By.CssSelector(btnOK), 2);
			UIAction(lnkRescindCancel, string.Empty, "span");
			UIActionExt(By.CssSelector(lnkPolicy), "ispresent", "", 0, 48, 5);
            }
        }
		public void ReinstatePolicy(Table table)
		{
            if ((Boolean)ScenarioContext.Current["RegionAffected"])
            {
                Console.WriteLine("Region Affected");
            }
            else
            {
                string txtReason = "input[id$=':ReasonCode-inputEl']";
                UIActionExt(By.CssSelector(txtReason), "Text", table.Rows[0]["Reason"]);
            }
        }
		public void QuoteReinstate()
		{
            if((Boolean)ScenarioContext.Current["RegionAffected"]) {
                Console.WriteLine("Region Affected");
            }else {
                string btnquote = "span[id$=':QuoteOrReview-btnInnerEl']";
                string btnReinstate = "span[id$=':Reinstate-btnInnerEl']";
                ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(btnquote)));
                driver.FindElement(By.CssSelector(btnquote)).Click();
                UIActionExt(By.CssSelector(btnReinstate), "ispresent", "", 0, 60, 5);
                driver.FindElement(By.CssSelector(btnReinstate)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(btnOK));
                driver.FindElement(By.CssSelector(btnOK)).Click();
                UIActionExt(By.CssSelector(lnkPolicy), "ispresent", "", 0, 48, 5);            
            }
        }
		public void QuoteReWriteFullTerm()
		{
            if ((Boolean)ScenarioContext.Current["RegionAffected"])
            {
                Console.WriteLine("Region Affected");
            }
            else
            {
                driver.FindElement(By.CssSelector(btnquote)).Click();
			UIActionExt(By.CssSelector(btnReWrite), "ispresent", "", 0, 60, 5);
			driver.FindElement(By.CssSelector(btnReWrite)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(btnOK));
			driver.FindElement(By.CssSelector(btnOK)).Click();
			try
			{
				WaitUntilElementVisible(driver, By.XPath(lblIssuesThatBlock), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			if (IsElementPresent(driver, By.XPath(lblIssuesThatBlock)) == true)
			{
				driver.FindElement(By.CssSelector(btnDetails)).Click();
				WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
				int BtnTotAppr;
				string btnApprove = "a[id$=':UWIssueRowSet:Approve']";
				btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
				BtnTotAppr = driver.FindElements(By.CssSelector(btnApprove)).ToList().Count;
				BtnTotAppr = BtnTotAppr + driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
				Console.WriteLine("Total Approve Btns: " + BtnTotAppr);

				for (int i = 1; i <= BtnTotAppr; i++)
				{
					btnApprove = "a[id$=':1:UWIssueRowSet:Approve']";
					btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
					if (IsElementPresent(driver, By.CssSelector(btnApprove)))
					{
						UIActionExt(By.CssSelector(btnApprove), "click");
					}
					else
					{
						UIActionExt(By.CssSelector(btnSplApprove), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
					if (IsElementPresent(driver, By.CssSelector(btnOK)) == true)
					{
						UIActionExt(By.CssSelector(btnOK), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
					if (IsElementPresent(driver, By.CssSelector(btnRAOK)) == true)
					{
						UIActionExt(By.CssSelector(btnRAOK), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);

					if (IsElementPresent(driver, By.CssSelector(btnOK)) == true)
					{
						UIActionExt(By.CssSelector(btnOK), "click");
					}
					WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
				}
				driver.FindElement(By.CssSelector(btnReWrite)).Click();
				WaitUntilElementVisible(driver, By.CssSelector(btnOK));
				driver.FindElement(By.CssSelector(btnOK)).Click();
			}else if (IsElementPresent(driver, By.CssSelector(lnkPolicy)) == false)
                {
					Console.WriteLine("No issue found");
					string txtBillingMethod = "input[id$=':BillingAdjustmentsDV:BillingMethod-inputEl']";
					string lblForms = "span[id$=':FormsScreen:ttlBar']";
					UIActionExt(By.CssSelector(btnNext), "click");
					WaitUntilElementVisible(driver, By.CssSelector(lblForms));
					driver.FindElement(By.CssSelector(btnNext)).Click();
					WaitUntilElementVisible(driver, By.CssSelector(txtBillingMethod));
					driver.FindElement(By.CssSelector(btnReWrite)).Click();
					WaitUntilElementVisible(driver, By.CssSelector(btnOK));
					driver.FindElement(By.CssSelector(btnOK)).Click();
				}
			UIActionExt(By.CssSelector(lnkPolicy), "ispresent", "", 0, 60, 5);
            }
        }

		public void QuoteReWriteFullTerm_JS()
		{
            if ((Boolean)ScenarioContext.Current["RegionAffected"])
            {
                Console.WriteLine("Region Affected");
            }
            else
            {
                UIActionExt(By.CssSelector(btnquote), "click");
			string lblPreQuote = "//span[text()='Pre-Quote Issues']";
			try
			{
				WaitUntilElementVisible(driver, By.XPath(lblIssuesThatBlock), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			if ((IsElementPresent(driver, By.XPath(lblIssuesThatBlock)) == true) || (IsElementPresent(driver, By.XPath(lblPreQuote)) == true))
			{
				UIActionExt(By.CssSelector(btnDetails), "click");
				UIActionExt(By.CssSelector(lblRiskAnalysis), "ispresent");
				int BtnTotAppr;
				string btnApprove = "a[id$=':UWIssueRowSet:Approve']";
				btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
				BtnTotAppr = driver.FindElements(By.CssSelector(btnApprove)).ToList().Count;
				BtnTotAppr = BtnTotAppr + driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;

				Console.WriteLine("Total Approve Btns: " + BtnTotAppr);
				for (int i = 1; i <= BtnTotAppr; i++)
				{
					btnApprove = "a[id$=':1:UWIssueRowSet:Approve']";
					btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
					if (IsElementPresent(driver, By.CssSelector(btnApprove)))
					{
						UIActionExt(By.CssSelector(btnApprove), "click");
					}
					else
					{
						UIActionExt(By.CssSelector(btnSplApprove), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
					if (IsElementPresent(driver, By.CssSelector(btnOK)) == true)
					{
						UIActionExt(By.CssSelector(btnOK), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);
					if (IsElementPresent(driver, By.CssSelector(btnRAOK)) == true)
					{
						UIActionExt(By.CssSelector(btnRAOK), "click");
					}
					WaitUntilElementInvisible(driver, By.CssSelector(lnkPolicy), 5);

					if (IsElementPresent(driver, By.CssSelector(btnOK)) == true)
					{
						UIActionExt(By.CssSelector(btnOK), "click");
					}
					UIActionExt(By.CssSelector(lblRiskAnalysis), "ispresent");
				}
				UIActionExt(By.CssSelector(btnquote), "click");
				UIActionExt(By.CssSelector(btnReWrite), "click", "", 0, 10, 5);
				UIActionExt(By.CssSelector(btnOK), "ispresent");
				UIActionExt(By.CssSelector(btnOK), "click");
			}
			UIActionExt(By.CssSelector(lnkPolicy), "ispresent", "", 0, 60, 5);
            }
        }

		public void EditWorkOrder()
		{
			string btnEditWorkOrder = "a[id$=':JobWizardToolbarButtonSet:EditPolicyWorkflow']";
			UIActionExt(By.CssSelector(btnEditWorkOrder), "click");
			UIActionExt(By.CssSelector(btnOK), "click");
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
		public CL_PolicyCancel(IWebDriver driver) : base(driver)
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

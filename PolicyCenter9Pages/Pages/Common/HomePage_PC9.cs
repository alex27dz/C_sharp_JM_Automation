using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelperClasses;
using System.Data.SqlClient;

namespace PolicyCenter9Pages.Pages.Common
{
	public class HomePage_PC9 : Page
	{
		string lnkMenuSetting = "span[id$=':TabLinkMenuButton-btnIconEl']";
		string searchLink = "span[id='TabBar:SearchTab-btnInnerEl']";
		string searchPolicy = "a[id='TabBar:SearchTab:Search_PolicySearch-itemEl']";
		string searchAccount = "a[id='TabBar:SearchTab:Search_AccountSearch-itemEl']";

       // string leftRiskAnalysis = "td[id$='SubmissionWizard:RiskAnalysis']";
		string leftRiskAnalysis = "//span[text()[contains(.,'Risk Analysis')]]";

		string leftDocumentPolicy = "td[id$='PolicyFile:MenuLinks:PolicyFile_PolicyFile_Documents']";
		string leftWorkOrder = "td[id='PolicyFile:MenuLinks:PolicyFile_PolicyFile_Jobs']";
		string leftReinsurance = "td[id$='SubmissionWizard:Reinsurance']";
		string leftSummary = "td[id$=':MenuLinks:AccountFile_AccountFile_Summary']";
		string leftContacts = "td[id$=':MenuLinks:AccountFile_AccountFile_Contacts']";
		string leftpersonaljewelryitemsWorkOrder = "td[id$=':LOBWizardStepGroup:personalItemDetailsStep']";
		string leftpersonaljewelryitemsPolicy = "td[id$=':PolicyMenuItemSet:policyfile_menuitemset_jwlryitem']";
		string leftContactsAccont = "td[id$=':MenuLinks:AccountFile_AccountFile_Contacts']";
		string leftLocationsAccont = "td[id$=':MenuLinks:AccountFile_AccountFile_Locations']";
		string leftSummaryAccont = "td[id$=':MenuLinks:AccountFile_AccountFile_Summary']";
		string leftDocumentAccont = "td[id$=':MenuLinks:AccountFile_AccountFile_Documents']";
		string leftNavBusinessOwners = "td[id$=':BOPWizardStepGroup']";

		string actionMenuArrow = "span[id='Desktop:DesktopMenuActions-btnInnerEl']";
		string menuItemNewAccount = "span[id='Desktop:DesktopMenuActions:DesktopMenuActions_Create:DesktopMenuActions_NewAccount-textEl']";
		string actionAccountMenu = "span[id='AccountFile:AccountFileMenuActions-btnInnerEl']";
		string menuItemNewSubmission = "span[id$=':AccountFileMenuActions_Create:AccountFileMenuActions_NewSubmission-textEl']";
		string txtPolicyEffDate = "input[id$=':ProductSettingsDV:effDate-inputEl']";
		string linkPolicynumber = "a[id$=':AccountFile_Summary_PolicyTermsLV:0:PolicyNumber']";

		string actionworkOrderMenu = "span[id$='MenuActions-btnInnerEl']";
		string actionChangePOlicy = "a[id$=':PolicyFileMenuActions_ChangePolicy-itemEl']";
		string lblSummary = "span[id='PolicyFile_Summary:Policy_SummaryScreen:0']";
		string actionCancelPOlicy = "a[id$=':PolicyFileMenuActions_CancelPolicy-itemEl']";
		string actionReinstatePolicy = "a[id$=':PolicyFileMenuActions_ReinstatePolicy-itemEl']";
		string actionRewriteRemainderOfTermPolicy = "a[id$=':StartRewriteMenuItemSet:RewriteRemainderOfTerm-itemEl']";
		string actionRewriteNewTermPolicy = "a[id$=':StartRewriteMenuItemSet:RewriteNewTerm-itemEl']";
		string actionRewritefullTermPolicy = "a[id$=':StartRewriteMenuItemSet:RewriteFullTerm-itemEl']";
		string actionPreRenewalDirection = "a[id$=':PolicyFileMenuActions_PreRenewalDirection-itemEl']";
		string actionRescindCancel = "span[id$=':PolicyFileMenuActions_RescindCancellation-textEl']";
		string actionRescindNonPament = "span[id$=':PolicyFileMenuActions_RescindCancellation:0:item-textEl']";
		string actionRenewPolicy = "a[id$=':PolicyFileMenuActions_RenewPolicy-itemEl']";

		string lblOfferings = "span[id$=':OfferingScreen:ttlBar']";

		string menuPolicyFile = "span[id='PolicyFile:PolicyFileMenuActions-btnInnerEl']";
		string menuItemChangePlcy = "span[id='PolicyFile:PolicyFileMenuActions:PolicyFileMenuActions_NewWorkOrder:PolicyFileMenuActions_ChangePolicy-textEl']";
		string menuItemCancelPlcy = "span[id='PolicyFile:PolicyFileMenuActions:PolicyFileMenuActions_NewWorkOrder:PolicyFileMenuActions_CancelPolicy-textEl']";
		string txtPolicyChngEffDate = "input[id$=':StartPolicyChangeDV:EffectiveDateJMIC_date-inputEl']";
		string btnStartCancel = "span[id$=':NewCancellation-btnInnerEl']";
		string btnOK = "span[id='button-1005-btnInnerEl']";

		string selectDocumentType = "input[id$=':Policy_DocumentSearchDV:DocumentType-inputEl']";
		string btnSearch = "a[id$=':SearchAndResetInputSet:SearchLinksInputSet:Search']";


		string txtDateFrom = "input[id$=':DateFrom-inputEl']";
		string txtDateTo = "input[id$=':DateTo-inputEl']";

		string linkTransactionNumber = "a[id$='AccountFile_Summary_WorkOrdersLV:0:WorkOrderNumber']";
		string btnAccount = "span[id$= 'TabBar:AccountTab-btnWrap']";
		string xpathTxtInputAccount = "//*[@id='TabBar:AccountTab:AccountTab_AccountNumberSearchItem-inputEl']";
		string xpathAccountSearchBtn = "//*[@id='TabBar:AccountTab:AccountTab_AccountNumberSearchItem_Button']";

		public HomePage_PC9(IWebDriver driver) : base(driver)
		{

		}
		public override void VerifyPage()
		{
			VerifyUIElementIsDisplayed(lnkMenuSetting);
		}

		public override void WaitForLoad()
		{
			IsElementPresent(driver, By.CssSelector(lnkMenuSetting));
		}

		public void NavigateTabBar(string TabName, string TabMenuItem)
		{
			switch (TabName.ToLower().Trim())
			{
				case "search":
					if (string.IsNullOrEmpty(TabMenuItem))
					{
						UIAction(searchLink, string.Empty, "span");
						pause();
					}
					else
					{
						Console.WriteLine("I am in Else loop");
						IWebElement WebElementComponent = driver.FindElement(By.CssSelector("span[id$='TabBar:SearchTab-btnWrap']"));
						string[] WebEleSize = WebElementComponent.Size.ToString().Replace("{Width=", "").Replace("Height=", "").Replace("}", "").Split(',');
						int WebEleLocWidth = Convert.ToInt16(WebEleSize[0]);
						int WebEleLocHeight = Convert.ToInt16(WebEleSize[1]);
						Console.WriteLine("iWidth: " + WebEleLocWidth);
						Console.WriteLine("iHeight: " + WebEleLocHeight);
						Actions action = new Actions(driver);
						action.MoveToElement(WebElementComponent, WebEleLocWidth, WebEleLocHeight).Click().Build().Perform();

						switch (TabMenuItem.ToLower().Trim())
						{
							case "policies":
								UIAction(searchPolicy, string.Empty, "a");
								Console.WriteLine("I clicked sub menu");
								break;
							case "accounts":
								//UIAction(SearchMenuArrow, string.Empty, "a");
								UIAction(searchAccount, string.Empty, "a");
								Console.WriteLine("I clicked sub menu");
								break;
						}
					}

					break;

				case "desktop":
					if (string.IsNullOrEmpty(TabMenuItem))
					{

					}

					break;
				default:
					break;
			}

		}

		public void selectLeftNavMenu(string leftNavMenu)
		{
			pause();
			string[] menuOption = leftNavMenu.Split(':');
			switch (menuOption[0].ToLower().Trim())
			{
				case "riskanalysis":
					pause();
					//UIActionExt(By.CssSelector(leftRiskAnalysis), "click");
					WaitUntilElementVisible(driver, By.XPath(leftRiskAnalysis), 30);
					UIActionExt(By.XPath(leftRiskAnalysis), "click");
					//  UIAction(leftRiskAnalysis, string.Empty, "a");
					break;
				case "personaljewelryitemsworkorder":
					Console.WriteLine("I clicked leftJewelryItems");
					pause();
					UIAction(leftpersonaljewelryitemsWorkOrder, string.Empty, "a");
					break;
				case "personaljewelryitemspolicy":
					pause();
					UIAction(leftpersonaljewelryitemsPolicy, string.Empty, "a");
					break;
				case "accontlocations":
					pause();
					UIAction(leftLocationsAccont, string.Empty, "a");
					break;
				case "accontcontacts":
					pause();
					UIAction(leftContactsAccont, string.Empty, "a");
					break;
				case "accontsummary":
					pause();
					UIAction(leftSummaryAccont, string.Empty, "a");
					break;
				case "businessowners":
					pause();
					UIAction(leftNavBusinessOwners, string.Empty, "a");
					break;
				case "documents":
					pause();
					UIAction(leftDocumentAccont, string.Empty, "a");
					break;
				case "contacts":
					pause();
					UIAction(leftContacts, string.Empty, "a");
					break;
				case "summary":
					pause();
					UIAction(leftSummary, string.Empty, "a");
					break;
				case "reinsurance":
					pause();
					UIAction(leftReinsurance, string.Empty, "a");
					break;
				case "work orders":
					pause();
					UIAction(leftWorkOrder, string.Empty, "a");
					break;
				case "transaction":
					pause();
					UIAction(leftWorkOrder, string.Empty, "a");
					break;
				case "documentspolicy":
					pause();
					UIAction(leftDocumentPolicy, string.Empty, "a");
					break;

				default:
					break;
			}

		}

		public void SelectActionMenuPC9(string menuOption)
		{
            Boolean policyHoldMessageIsPresented = driver.FindElements(By.XPath("//*[contains(., 'COVID-19 CL affected region.')]")).Count > 0;
            if (policyHoldMessageIsPresented)
            {
                ScenarioContext.Current["RegionAffected"] = true;
            }
            Console.WriteLine("Is Region Affected " + ScenarioContext.Current["RegionAffected"]);
            Console.WriteLine(menuOption.ToLower().Trim());
			switch (menuOption.ToLower().Trim())
			{
				case "new account":
                    if (IsElementPresent(driver, By.CssSelector("span[id$='TabBar:DesktopTab-btnInnerEl']")) == true)
                    {
                        UIActionExt(By.CssSelector("span[id$='TabBar:DesktopTab-btnInnerEl']"), "click");
                        UIActionExt(By.CssSelector(actionMenuArrow), "ispresent");

                    }
                    WaitFor(driver.FindElement(By.CssSelector(actionMenuArrow))).Click();
					WaitFor(driver.FindElement(By.CssSelector(menuItemNewAccount))).Click();
					break;
				case "change policy":
					if (IsElementPresent(driver, By.CssSelector(menuPolicyFile)) == false)
					{
						WaitUntilElementVisible(driver, By.CssSelector(menuPolicyFile));
					}
					ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(menuPolicyFile)));
					WaitFor(driver.FindElement(By.CssSelector(menuPolicyFile))).Click();
					WaitFor(driver.FindElement(By.CssSelector(menuItemChangePlcy))).Click();
					WaitUntilElementVisible(driver, By.CssSelector(txtPolicyChngEffDate));
					break;
				case "cancel policy":
					if (IsElementPresent(driver, By.CssSelector(menuPolicyFile)) == false)
					{
						WaitUntilElementVisible(driver, By.CssSelector(menuPolicyFile));
					}
					ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(menuPolicyFile)));
					WaitFor(driver.FindElement(By.CssSelector(menuPolicyFile))).Click();
					WaitFor(driver.FindElement(By.CssSelector(menuItemCancelPlcy))).Click();
					WaitUntilElementVisible(driver, By.CssSelector(btnStartCancel));
					break;
				case "new submission":
					WaitFor(driver.FindElement(By.CssSelector(actionAccountMenu))).Click();
					WaitFor(driver.FindElement(By.CssSelector(menuItemNewSubmission))).Click();
					WaitUntilElementVisible(driver, By.CssSelector(txtPolicyEffDate));
					break;
				case "rescind cancellation":
                    if ((Boolean)ScenarioContext.Current["RegionAffected"])
                    {
                        Console.WriteLine("This Region is affected, rescind cancellation option is not available");
                        break;
                    }
                    else
                    {
                        string lblRescindConf = "span[id$='CancellationWizard:CancellationWizard_MultiLine_QuoteScreen:ttlBar']";
                        if (IsElementPresent(driver, By.CssSelector(menuPolicyFile)) == false)
                        {
                            WaitUntilElementVisible(driver, By.CssSelector(menuPolicyFile));
                        }
                        ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(menuPolicyFile)));
                        WaitFor(driver.FindElement(By.CssSelector(menuPolicyFile))).Click();
                        WaitFor(driver.FindElement(By.CssSelector(actionRescindCancel))).Click();
                        driver.FindElement(By.CssSelector(actionRescindCancel)).SendKeys(Keys.ArrowRight);
                        //WaitUntilElementVisible(driver, By.CssSelector(actionRescindNonPament));
                        WaitFor(driver.FindElement(By.CssSelector(actionRescindNonPament))).Click();
                        WaitUntilElementVisible(driver, By.CssSelector(lblRescindConf));
                        break;
                    }
				case "reinstate policy":
                    if ((Boolean)ScenarioContext.Current["RegionAffected"])
                    {
                        Console.WriteLine("This Region is affected, reinstate option is not available");
                        break;
                    }
                    else
                    {
                        string lblStartReinstate = "span[id$='ReinstatementWizard:ReinstatementWizard_ReinstatePolicyScreen:ttlBar']";

                        if (IsElementPresent(driver, By.CssSelector(menuPolicyFile)) == false)
                        {
                            WaitUntilElementVisible(driver, By.CssSelector(menuPolicyFile));
                        }
                        ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(menuPolicyFile)));
                        WaitFor(driver.FindElement(By.CssSelector(menuPolicyFile))).Click();
                        WaitFor(driver.FindElement(By.CssSelector(actionReinstatePolicy))).Click();
                        WaitUntilElementVisible(driver, By.CssSelector(lblStartReinstate));
                        break;
                    }

				case "rewrite fullterm policy":
                    if ((Boolean)ScenarioContext.Current["RegionAffected"])
                    {
                        Console.WriteLine("This Region is affected, rewrite fullterm option is not availabe");
                        break;
                    }
                    else
                    {
                        if (IsElementPresent(driver, By.CssSelector(menuPolicyFile)) == false)
                        {
                            WaitUntilElementVisible(driver, By.CssSelector(menuPolicyFile));
                        }
                        ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(menuPolicyFile)));
                        WaitFor(driver.FindElement(By.CssSelector(menuPolicyFile))).Click();
                        WaitFor(driver.FindElement(By.CssSelector(actionRewritefullTermPolicy))).Click();
                        WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));
                        break;
                    }
				case "rewritenewterm policy":
                    if ((Boolean)ScenarioContext.Current["RegionAffected"])
                    {
                        Console.WriteLine("This Region is affected, rewrite fullterm option is not availabe");
                        break;
                    }
                    else
                    {
                        if (IsElementPresent(driver, By.CssSelector(menuPolicyFile)) == false)
                        {
                            WaitUntilElementVisible(driver, By.CssSelector(menuPolicyFile));
                        }
                        ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(menuPolicyFile)));
                        WaitFor(driver.FindElement(By.CssSelector(menuPolicyFile))).Click();
                        WaitFor(driver.FindElement(By.CssSelector(actionRewriteNewTermPolicy))).Click();
                        WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));
                        break;
                    }
                case "rewriteremainderofterm policy":
                    if ((Boolean)ScenarioContext.Current["RegionAffected"])
                    {
                        Console.WriteLine("This Region is affected, rewrite fullterm option is not availabe");
                        break;
                    }
                    else
                    {
                        if (IsElementPresent(driver, By.CssSelector(menuPolicyFile)) == false)
                        {
                            WaitUntilElementVisible(driver, By.CssSelector(menuPolicyFile));
                        }
                        ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(menuPolicyFile)));
                        WaitFor(driver.FindElement(By.CssSelector(menuPolicyFile))).Click();
                        WaitFor(driver.FindElement(By.CssSelector(actionRewriteRemainderOfTermPolicy))).Click();
                        WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));
                        break;
                    }
                case "renew policy":
					if (IsElementPresent(driver, By.CssSelector(menuPolicyFile)) == false)
					{
						WaitUntilElementVisible(driver, By.CssSelector(menuPolicyFile));
					}
					ScrollDownTillElement(driver, driver.FindElement(By.CssSelector(menuPolicyFile)));
					WaitFor(driver.FindElement(By.CssSelector(menuPolicyFile))).Click();
					WaitFor(driver.FindElement(By.CssSelector(actionRenewPolicy))).Click();
					WaitUntilElementVisible(driver, By.CssSelector(btnOK), 5);
					WaitFor(driver.FindElement(By.CssSelector(btnOK))).Click();
					WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));

					break;
				default:
					Assert.Fail();
					Console.WriteLine("Unable to find Action Type");
					break;
			}
		}

		public void ClickPolicy()
		{
			WaitUntilElementVisible(driver, By.CssSelector(linkPolicynumber));
			UIAction(linkPolicynumber, String.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lblSummary));

		}

		public void SelectActionMenuForWorkOrder(string menuOption)
		{
			//WaitUntilElementIsDisplayed(driver, By.CssSelector(actionworkOrderMenu));
			UIAction(actionworkOrderMenu, string.Empty, "a");
			switch (menuOption.ToLower().Trim())
			{
				case "policy chnage":
					Console.WriteLine("under policy change section");
					WaitUntilElementVisible(driver, By.CssSelector(actionChangePOlicy));
					UIAction(actionChangePOlicy, string.Empty, "a");

					break;
				case "policy cancel":
					WaitUntilElementVisible(driver, By.CssSelector(actionCancelPOlicy));
					UIAction(actionCancelPOlicy, string.Empty, "a");

					break;
				case "reinstate policy":

					WaitUntilElementVisible(driver, By.CssSelector(actionReinstatePolicy));
					UIAction(actionReinstatePolicy, string.Empty, "a");

					break;
				case "rewriteremainderofterm policy":

					WaitUntilElementVisible(driver, By.CssSelector(actionRewriteRemainderOfTermPolicy));
					UIAction(actionRewriteRemainderOfTermPolicy, string.Empty, "a");

					break;
				case "rewritenewterm policy":

					WaitUntilElementVisible(driver, By.CssSelector(actionRewriteNewTermPolicy));
					UIAction(actionRewriteNewTermPolicy, string.Empty, "a");

					break;
				case "rewrite fullterm policy":

					WaitUntilElementVisible(driver, By.CssSelector(actionRewritefullTermPolicy));
					UIAction(actionRewritefullTermPolicy, string.Empty, "a");

					break;

				case "pre-renewal direction":
					WaitUntilElementVisible(driver, By.CssSelector(actionPreRenewalDirection));

					UIAction(actionPreRenewalDirection, string.Empty, "a");

					break;
				case "renew policy":
					Console.WriteLine("under policy change section");
					WaitUntilElementVisible(driver, By.CssSelector(actionRenewPolicy));
					UIAction(actionRenewPolicy, string.Empty, "a");

					try
					{
						WaitUntilElementVisible(driver, By.CssSelector(btnOK), 5);
						driver.FindElement(By.CssSelector(btnOK)).Click();
					}
					catch (Exception e)
					{
						System.Console.WriteLine("Exception is " + e.Message);
					}



					break;

				//case "rescind cancellation":

				//    UIAction(actionworkOrderMenu, string.Empty, "a");
				//    System.Threading.Thread.Sleep(2000);
				//    UIAction(actionRescindCancel, string.Empty, "span");
				//    System.Threading.Thread.Sleep(2000);
				//    UIAction(actionRescindNonPament, string.Empty, "a");

				//    break;
				default:

					break;
			}

		}

		public void SearchAndSelect(string PolicyNumber)
		{
			string lnkSearchTab = "a[id$='TabBar:SearchTab']";
			string txtPolicyNum = "input[id$=':PolicySearchDV:PolicyNumberCriterion-inputEl']";
			string btnSearchlink = "a[id$=':PolicySearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";
			string lnkPolicyNum = "a[id$=':PolicySearch_ResultsLV:0:PolicyNumber']";

			DataStorage temp = new DataStorage();
			string policyNum = null;
			switch (PolicyNumber.ToUpper().Trim())
			{
				case "REGISTRY":
					policyNum = temp.GetTempValue("PLCYNO");
					break;
				default:
					policyNum = PolicyNumber;
					break;
			}

			UIAction(lnkSearchTab, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(txtPolicyNum));
			UIAction(txtPolicyNum, policyNum, "textbox");
			UIAction(btnSearchlink, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(lnkPolicyNum));
			UIAction(lnkPolicyNum, string.Empty, "a");
		}

		public void ClickLeftNavigationMenu(string leftNavMenu)
		{
			string[] menuOption = leftNavMenu.Split(':');
			switch (menuOption[0].ToLower().Trim())
			{
				case "reinsurance":
					UIActionExt(By.CssSelector(leftReinsurance), "ispresent");
					UIActionExt(By.CssSelector(leftReinsurance), "click");
					break;
				default:
					break;
			}

		}


		public void TbFromDbToRegistry(Table table)
		{
			string testScenarioName = table.Rows[0]["ScenarioName"];
			FromDbToRegistry(testScenarioName);
		}

		public void FromDbToRegistry(string sScenarioName)
		{
			string testScenarioName = sScenarioName;
			string sEnv = ScenarioContext.Current["AUTEnv"].ToString().ToLower();
			string DbAccountNumber = "";
			string DbPolicyNumber = "";
			string sDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-1)) + " 00:00:00";
			string sqlQuery = "SELECT TOP 1 Account_Policy FROM [automation testing].[dbo].[TestResults] WHERE ScenarioName='" + testScenarioName + "' AND Environment='" + sEnv + "' AND ExecutionDate='" + sDate + "' AND Account_Policy like '%:%'" + " AND Result = 'Pass'";
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                string startDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-3)) + " 00:00:00";
                string endDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-1)) + " 00:00:00";
                sqlQuery = "SELECT TOP 1 Account_Policy FROM [automation testing].[dbo].[TestResults] WHERE ScenarioName='" + testScenarioName + "' AND Environment='" + sEnv + "' AND Account_Policy like '%:%'" + " AND ExecutionDate Between'" + startDate + "'" + " And '" + endDate + "'";
            }
            if(sScenarioName == "06_NB_Cancel_Rewrite_RemainderTerm_Claim_USA" || sScenarioName == "07_NB_Convicted_Claim_Cancel_CashPayment_ReWriteNewTerm_Claim_USA")

			{
                sqlQuery = "SELECT TOP 1 Account_Policy FROM [automation testing].[dbo].[TestResults] WHERE ScenarioName='" + testScenarioName + "' AND Environment='" + sEnv + "' AND ExecutionDate='" + sDate + "' AND Result = 'Pass'";
            }
            Console.WriteLine("SQL Query: " + sqlQuery);
			string connectionString = "Server=dbautomationtesting_prod;Database=automation testing;Trusted_Connection=Yes";
			SqlConnection con = new SqlConnection(connectionString);
			List<string> AccountPolicies = new List<string>();
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand(sqlQuery, con);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					AccountPolicies.Add(reader.GetValue(0).ToString());
				}
				reader.Close();
				con.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exceptiion:" + ex.ToString());
			}
			finally
			{
				con.Close();
			}


			if (AccountPolicies.Count == 1)
			{
				Console.WriteLine("DB Result: " + AccountPolicies[0].ToString());
				if (AccountPolicies[0].ToString().Contains(":"))
				{
					string[] AcctPlcy = AccountPolicies[0].ToString().Split(':');
					if ((AcctPlcy[0].ToString() != "") && (AcctPlcy[1].ToString() != ""))
					{
						DbAccountNumber = AcctPlcy[0].ToString();
						DbPolicyNumber = AcctPlcy[1].ToString();
					}
				}
				Console.WriteLine("Account: {0}\nPolicy: {1}", DbAccountNumber, DbPolicyNumber);
			}

			if ((DbAccountNumber != "") && ((DbPolicyNumber != "")))
			{
				DataStorage tempData = new DataStorage();
				tempData.StoreTempValue("guidewire", "ACCNO", DbAccountNumber);
				tempData.StoreTempValue("guidewire", "PLCYNO", DbPolicyNumber);
			}
			else
			{
				Assert.Fail("Account and/or Policy not found in database.");
			}

		}

		public void VerifyWorkOrderDetails(string expectedType, string expectedStatus)
		{

			List<IWebElement> reservetableObj1;
			//reservetableObj1 = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_JobsInProgressLV")).ToList();
			reservetableObj1 = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_JobsInProgressLV-body")).ToList();
			var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
			pause();
			string type = "";
			string status = "";
			Console.WriteLine("Count is " + rows1.Count());
			if (rows1.Count() == 1)
			{
				var tds = rows1[0].FindElements(By.TagName("td"));
				type = type + " " + tds[4].Text;
				status = status + " " + tds[3].Text;
			}
			else
			{
				for (int i = 1; i < rows1.Count(); i++)
				{
					var tds = rows1[i].FindElements(By.TagName("td"));
					type = type + " " + tds[4].Text;
					status = status + " " + tds[3].Text;
				}
			}


			Console.WriteLine("Status is " + status);
			Console.WriteLine("type is " + type);

			if (type.ToUpper().Contains(expectedType.ToUpper()))
			{
				Console.WriteLine("Type matches");
			}
			else
			{
				Console.WriteLine("Type donot matches");
				Assert.Fail("Type donot matches");
			}
			if (status.ToUpper().Contains(expectedStatus.ToUpper()))
			{
				Console.WriteLine("status matches");
			}
			else
			{
				Console.WriteLine("status donot matches");
				Assert.Fail("status donot matches");
			}

		}

		public void Verify_RenewalButton_Check(string flag)
		{
			UIAction(actionworkOrderMenu, string.Empty, "a");

			System.Threading.Thread.Sleep(2000);
			List<IWebElement> btnRenew = driver.FindElements(By.Id("PolicyFile:PolicyFileMenuActions:PolicyFileMenuActions_NewWorkOrder:PolicyFileMenuActions_RenewPolicy")).ToList();
			if (flag.ToLower().Equals("yes"))
			{
				if (btnRenew.Count() > 0)
				{
					Console.WriteLine("Renew button exist which is expected");
				}
				else
				{
					Assert.Fail("Renew button do not exist which is not expected");
				}

			}
			else
			{
				if (btnRenew.Count() > 0)
				{
					Assert.Fail("Renew button exist which is not expected");
				}
				else
				{
					Console.WriteLine("Renew button do not exist which is expected");
				}

			}
		}


		public void VerifyTransaction(string expectedType)
		{
			List<IWebElement> reservetableObj1;
			//reservetableObj1 = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_TransactionsLV")).ToList();
			string PlcySummaryTrans = "PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_TransactionsLV-body";
			UIActionExt(By.Id(PlcySummaryTrans), "ispresent");
			reservetableObj1 = driver.FindElements(By.Id(PlcySummaryTrans)).ToList();
			var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
			pause();
			List<IWebElement> reservetableObj2 = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_JobsInProgressLV-body")).ToList();
			var pendingPolicytransRow = reservetableObj2[0].FindElements(By.TagName("tr"));
			pause();
			Console.WriteLine("Count is " + pendingPolicytransRow.Count());
            if (pendingPolicytransRow.Count() > 0)
            {
				var tds = pendingPolicytransRow[0].FindElements(By.TagName("td"));
				driver.FindElement(By.XPath("//a[text()='" + tds[5].Text + "']")).Click();
				specialApprove();
				NavigateTabBar("search", "policies");
				string btnSearch = "a[id$=':SearchLinksInputSet:Search']";
				string btnReset = "a[id$=':SearchLinksInputSet:Reset']";
				string txtPolicyNumber = "input[id$=':PolicyNumberCriterion-inputEl']";
				string policySearchResult = "a[id$=':0:PolicyNumber']";
				DataStorage temp = new DataStorage();
				UIAction(btnReset, string.Empty, "span");
				IList<IWebElement> accountNumbers = driver.FindElements(By.CssSelector(txtPolicyNumber)).ToList();
				accountNumbers[0].SendKeys(temp.GetTempValue("PLCYNO"));
				UIAction(btnSearch, string.Empty, "span");
				UIAction(policySearchResult, string.Empty, "a");
			}			
			string type = "";
			reservetableObj1 = driver.FindElements(By.Id(PlcySummaryTrans)).ToList();
			rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
			Console.WriteLine("Count is " + rows1.Count());
			if (rows1.Count() == 2)
			{
				var tds = rows1[0].FindElements(By.TagName("td"));
				type = type + " " + tds[4].Text;
			}
			else
			{
				for (int i = 1; i < rows1.Count(); i++)
				{
					var tds = rows1[i].FindElements(By.TagName("td"));
					type = type + " " + tds[4].Text;
				}

			}
			Console.WriteLine("Type is " + type);
			Console.WriteLine("Expected Type is " + expectedType);
			if (type.ToUpper().Contains(expectedType.ToUpper()))
			{
				Console.WriteLine("Type matches");
			}
			else
			{
				Console.WriteLine("Type donot matches");
				Assert.Fail("Type donot matches");
			}
		}
		private void specialApprove()
        {
			string policyNumber = "";
			string btnOK = "a[id='button-1005']";
			string lnkPlcy = "div[id$='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";
			// string btnDetails = "a[id='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton']";
			string btnDetails = "a[id$=':DetailsButton']";
			string viewYourPlcy = "view your policy (#";
			string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
			string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
			string lblRiskApproveDetails = "span[id$='RiskApprovalDetailsPopup:ttlBar']";
			string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
			string lblIssuesThatBlock = "span[id$='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton-btnInnerEl']";
			string btnIssuePolicy = "span[id$=':BindOptions:IssueNow-textEl']";
			string btnBindPolicy = "span[id$=':BindOptions-btnInnerEl']";

			Console.WriteLine("Click on issue policy");
			UIActionExt(By.CssSelector(btnBindPolicy), "click");
			UIActionExt(By.CssSelector(btnIssuePolicy), "click");
			WaitUntilElementVisible(driver, By.CssSelector(btnOK), 30);
			driver.FindElement(By.CssSelector(btnOK)).Click();
			//  WaitUntilElementVisible(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"), 30);
			//    bool uwIssues = false;
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector(lblIssuesThatBlock), 10);
				//Console.WriteLine("Value of uwIssues is " + uwIssues);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			Console.WriteLine("before boolan true");
			if (IsElementPresent(driver, By.CssSelector(lblIssuesThatBlock)) == true)
			{
				Console.WriteLine("button issue");
				WaitUntilElementVisible(driver, By.CssSelector(btnDetails), 100);
				UIAction(btnDetails, string.Empty, "a");
				WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
				int BtnTotAppr = driver.FindElements(By.CssSelector(btnSplApprove)).ToList().Count;
				Console.WriteLine("Total Approve Btns: " + BtnTotAppr);
				for (int i = 1; i <= BtnTotAppr; i++)
				{
					//    btnSplApprove = "a[id$=':1:UWIssueRowSet:SpecialApprove']";
					driver.FindElement(By.CssSelector(btnSplApprove)).Click();
					WaitUntilElementVisible(driver, By.CssSelector(btnOK));
					driver.FindElement(By.CssSelector(btnOK)).Click();
					WaitUntilElementVisible(driver, By.CssSelector(lblRiskApproveDetails));
					driver.FindElement(By.CssSelector(btnRAOK)).Click();
					WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
				}


				UIActionExt(By.CssSelector(btnBindPolicy), "click");
				UIActionExt(By.CssSelector(btnIssuePolicy), "click");
				WaitUntilElementVisible(driver, By.CssSelector(btnOK), 30);
				driver.FindElement(By.CssSelector(btnOK)).Click();

			}
			Console.WriteLine("After boolan true");
			WaitUntilElementVisible(driver, By.CssSelector(lnkPlcy), 420);
			Console.WriteLine(driver.FindElement(By.CssSelector(lnkPlcy)).Text);
			if (driver.FindElement(By.CssSelector(lnkPlcy)).Text.ToLower().Trim().Contains(viewYourPlcy))
			{
				policyNumber = driver.FindElement(By.CssSelector(lnkPlcy)).Text.Trim().Replace("View your policy (#", "").Replace(")", "");
			}
			Console.WriteLine("Policy Number: " + policyNumber);
			ScenarioContext.Current["POLICY"] = policyNumber;
		}
		public void verifyCLRenewal(string Offering)
		{
			string PolicyExpDate = "//div[@id='PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_DatesDV:PolicyPerExpirDate-inputEl']";
			UIActionExt(By.XPath(PolicyExpDate), "ispresent");
			IWebElement labelPolicyExpiryeDate = driver.FindElement(By.XPath(PolicyExpDate));
			string TempDate = labelPolicyExpiryeDate.Text;
			Console.WriteLine("Tem Date is " + TempDate);
			DateTime effectivedate = (DateTime.Parse(TempDate)).Date;
			int DateDiff = (effectivedate - DateTime.Today).Days;
			ScenarioContext.Current["DateDiff"] = DateDiff;
			Console.WriteLine("DateDiff is " + DateDiff);
			switch (Offering.ToUpper())
			{
				case "JEWELERS BLOCK":
				case "JEWELERS BLOCK PAK":
					if ((DateDiff > 0) & (DateDiff <= 31))
					{
						VerifyWorkOrderDetails("Renewal", "Quoted");
						Verify_RenewalButton_Check("no");
						//Verify_RenewalButton_Check(Offering, DateDiff);
					}
					else if ((DateDiff > 31) & (DateDiff <= 46))
					{
						VerifyWorkOrderDetails("Renewal", "Quoted");
						Verify_RenewalButton_Check("no");
						//Verify_RenewalButton_Check(Offering, DateDiff);
					}
					else if ((DateDiff > 46) & (DateDiff <= 75))
					{
						Verify_RenewalButton_Check("yes");
						//Verify_RenewalButton_Check(Offering, DateDiff);
					}

					else if ((DateDiff > 75) & (DateDiff <= 100))
					{
						Verify_RenewalButton_Check("yes");
						//Verify_RenewalButton_Check(Offering, DateDiff);
					}


					break;
				case "BUSINESSOWNERS":
				case "JEWELERS STANDARD":
				case "JEWELERS STANDARD PAK":
					if ((DateDiff > 0) & (DateDiff <= 31))
					{
						VerifyTransaction("Renewal");
						Verify_RenewalButton_Check("yes");
						//Verify_RenewalButton_Check(Offering, DateDiff);
					}
					else if ((DateDiff > 31) & (DateDiff <= 46))
					{

						VerifyWorkOrderDetails("Renewal", "Quoted");
						Verify_RenewalButton_Check("no");
						//Verify_RenewalButton_Check(Offering, DateDiff);
					}

					else if ((DateDiff > 46) & (DateDiff <= 75))
					{
						Verify_RenewalButton_Check("yes");
						//Verify_RenewalButton_Check(Offering, DateDiff);
					}

					else if ((DateDiff > 75) & (DateDiff <= 100))
					{
						//Verify_RenewalButton_Check(Offering, DateDiff);
						Verify_RenewalButton_Check("yes");
					}


					break;
			}

			//labelPolicyExpiryeDate.Click();
			//pause();
		}

		public void CLRenewDocument(int DateDiff, string Offering)
		{
			switch (Offering.ToUpper())
			{
				case "JEWELERS BLOCK":
				case "JEWELERS BLOCK PAK":
					if ((DateDiff > 0) & (DateDiff <= 31))
					{
						CheckDocument("Renewal Statement", Offering, DateDiff);
						CheckDocument("Renewal", Offering, DateDiff);
					}
					else if ((DateDiff > 31) & (DateDiff <= 46))
					{
						CheckDocument("Renewal Statement", Offering, DateDiff);
						CheckDocument("Renewal", Offering, DateDiff);
					}
					else if ((DateDiff > 46) & (DateDiff <= 75))
					{
						CheckDocument("Renewal Statement", Offering, DateDiff);
						CheckDocument("Renewal", Offering, DateDiff);
					}
					else if ((DateDiff > 75) & (DateDiff <= 100))
					{
						CheckDocument("Renewal Statement", Offering, DateDiff);
					}
					break;
				case "BUSINESSOWNERS":
				case "JEWELERS STANDARD":
				case "JEWELERS STANDARD PAK":
					if ((DateDiff > 0) & (DateDiff <= 31))
					{
						CheckDocument("Renewal Statement", Offering, DateDiff);
						CheckDocument("Renewal", Offering, DateDiff);
					}
					else if ((DateDiff > 31) & (DateDiff <= 46))
					{
						CheckDocument("Renewal Statement", Offering, DateDiff);
						CheckDocument("Renewal", Offering, DateDiff);
					}

					else if ((DateDiff > 46) & (DateDiff <= 75))
					{
						CheckDocument("Renewal Statement", Offering, DateDiff);
						CheckDocument("Renewal", Offering, DateDiff);
					}

					else if ((DateDiff > 75) & (DateDiff <= 100))
					{
						CheckDocument("Renewal Statement", Offering, DateDiff);
					}


					break;
			}

		}

		public void VerifyDocuments(string Documentsavailable)
		{
			System.Threading.Thread.Sleep(4000);
			int Row = 0;
			List<IWebElement> reservetableObj1;
			Console.WriteLine("Table Row count is " + Row);
			try
			{
				reservetableObj1 = driver.FindElements(By.Id("PolicyFile_Documents:Policy_DocumentsScreen:DocumentsLV")).ToList();
				var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
				Row = rows1.Count;
				Console.WriteLine("Table Row count is " + Row);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			if (Row > 1)
			{
				if (Documentsavailable.ToLower().Equals("yes"))
				{
					Console.WriteLine("Document Status match");
				}
				else
				{
					Assert.Fail("Document Status do not match");
				}

			}
			else
			{
				if (Documentsavailable.ToLower().Equals("yes"))
				{
					Assert.Fail("Document Status do not match");
				}
				else
				{
					Console.WriteLine("Document Status match");
				}
			}



		}

		public void CheckDocument(string DocName, string Offering, int DateDiff)
		{
			DocumentSearch(DocName, "", "");
			pause();
			switch (Offering.ToUpper())
			{
				case "JEWELERS BLOCK":
				case "JEWELERS BLOCK PAK":
					if ((DateDiff > 75) & (DateDiff <= 100))
					{
						VerifyDocuments("no");
					}
					else
					{
						VerifyDocuments("yes");
					}
					break;
				case "BUSINESSOWNERS":
				case "JEWELERS STANDARD":
				case "JEWELERS STANDARD PAK":

					VerifyDocuments("no");
					break;

			}
		}

		public void DocumentSearch(string DocumentTypeName, string FromDate, string Todate)
		{
			//UIAction(selectDocumentType, DocumentTypeName, "selectbox");
			UIActionExt(By.CssSelector(selectDocumentType), "ispresent");
			UIActionExt(By.CssSelector(selectDocumentType), "List", DocumentTypeName);

			pause();
			if (FromDate.Length > 3)
			{
				//txtDateFrom.Clear();
				//txtDateFrom.SendKeys(FromDate);
				//txtDateTo.Clear();
				//txtDateTo.SendKeys(Todate);
				UIActionExt(By.CssSelector(txtDateFrom), "List", FromDate);
				UIActionExt(By.CssSelector(txtDateTo), "List", Todate);


			}
			//UIAction(btnSearch, string.Empty, "a");
			UIActionExt(By.CssSelector(btnSearch), "click");

		}

        public void ClickOnPolicyInfo()
        {
            Console.WriteLine("trying to click on policy info");
            string leftPolicyInfo = "td[id$='SubmissionWizard:LOBWizardStepGroup:PolicyInfo']";
            UIActionExt(By.CssSelector(leftPolicyInfo), "click");
            Console.WriteLine("I clicked policyInfoPage");
        }

        public void VerifyPolicyInfoParamsPartner(string FirstName, string LastName, string Phone, string Email)
        {
            Console.WriteLine("Starting verification of policy info");
            System.Threading.Thread.Sleep(3000);
            IWebElement IW_Agent_id = driver.FindElement(By.XPath("//*[@id='SubmissionWizard:LOBWizardStepGroup:SubmissionWizard_PolicyInfoScreen:SubmissionWizard_PolicyInfoDV:PolicyInfoAgentInfoInputSet:AgentID-inputEl']"));
            IWebElement IW_First_name = driver.FindElement(By.XPath("//*[@id='SubmissionWizard:LOBWizardStepGroup:SubmissionWizard_PolicyInfoScreen:SubmissionWizard_PolicyInfoDV:PolicyInfoAgentInfoInputSet:AgentFirstName-inputEl']"));
            IWebElement IW_Last_name = driver.FindElement(By.XPath("//*[@id='SubmissionWizard:LOBWizardStepGroup:SubmissionWizard_PolicyInfoScreen:SubmissionWizard_PolicyInfoDV:PolicyInfoAgentInfoInputSet:AgentLastName-inputEl']"));
            IWebElement IW_Phone = driver.FindElement(By.XPath("//*[@id='SubmissionWizard:LOBWizardStepGroup:SubmissionWizard_PolicyInfoScreen:SubmissionWizard_PolicyInfoDV:PolicyInfoAgentInfoInputSet:AgentPhoneNumber-inputEl']"));
            IWebElement IW_Email = driver.FindElement(By.XPath("//*[@id='SubmissionWizard:LOBWizardStepGroup:SubmissionWizard_PolicyInfoScreen:SubmissionWizard_PolicyInfoDV:PolicyInfoAgentInfoInputSet:AgentEmailID-inputEl']"));
            Console.WriteLine(IW_Agent_id.Text);
            Console.WriteLine(IW_First_name.Text);
            Console.WriteLine(IW_Last_name.Text);
            Console.WriteLine(IW_Phone.Text);
            Console.WriteLine(IW_Email.Text);

            if (IW_Agent_id.Text.Equals(Email))
            {
                System.Console.WriteLine("Expected valus is " + Email + " actual value is " + IW_Agent_id.Text);
            }
            else
            {
                System.Console.WriteLine("Expected valus is " + Email + " actual value is " + IW_Agent_id.Text + " do not matches");
                Assert.Fail("Expected valus is " + Email + " actual value is " + IW_Agent_id.Text + " do not matches");
            }

            if (IW_First_name.Text.Equals(FirstName))
            {
                System.Console.WriteLine("Expected valus is " + FirstName + " actual value is " + IW_First_name.Text);
            }
            else
            {
                System.Console.WriteLine("Expected valus is " + FirstName + " actual value is " + IW_First_name.Text + " do not matches");
                Assert.Fail("Expected valus is " + FirstName + " actual value is " + IW_First_name.Text + " do not matches");
            }

            if (IW_Last_name.Text.Equals(LastName))
            {
                System.Console.WriteLine("Expected valus is " + LastName + " actual value is " + IW_Last_name.Text);
            }
            else
            {
                System.Console.WriteLine("Expected valus is " + LastName + " actual value is " + IW_Last_name.Text + " do not matches");
                Assert.Fail("Expected valus is " + LastName + " actual value is " + IW_Last_name.Text + " do not matches");
            }
            
            Phone = Phone.Replace(" ", String.Empty);
            if (IW_Phone.Text.Equals(Phone.ToString()))
            {
                System.Console.WriteLine("Expected valus is " + Phone + " actual value is " + IW_Phone.Text);
            }
            else
            {
                System.Console.WriteLine("Expected valus is " + Phone + " actual value is " + IW_Phone.Text + " do not matches");
                Assert.Fail("Expected valus is " + Phone + " actual value is " + IW_Phone.Text + " do not matches");
            }


        }

        public void VerifyPolicyInfoParamsInternal(string Email)
        {
            Console.WriteLine("Starting verification of policy info");
            System.Threading.Thread.Sleep(3000);
            IWebElement IW_Agent_id = driver.FindElement(By.XPath("//*[@id='SubmissionWizard:LOBWizardStepGroup:SubmissionWizard_PolicyInfoScreen:SubmissionWizard_PolicyInfoDV:PolicyInfoAgentInfoInputSet:AgentID-inputEl']"));
            Console.WriteLine(IW_Agent_id.Text);
            Console.WriteLine(Email);
            if (IW_Agent_id.Text.Contains(Email))
            {
                System.Console.WriteLine("Expected valus is JEWELERSNT" + Email + " actual value contains " + IW_Agent_id.Text);
            }
            else
            {
                System.Console.WriteLine("Expected valus is JEWELERSNT" + Email + " actual value is " + IW_Agent_id.Text + " do not contains");
                Assert.Fail("Expected valus is " + Email + " actual value is " + IW_Agent_id.Text + " do not contains");
            }

        }

		public void ClickOnPayment()
		{
			Console.WriteLine("trying to click on payment");
			string leftPayment = "td[id$='SubmissionWizard:BillingInfo']";
			UIActionExt(By.CssSelector(leftPayment), "click");
			Console.WriteLine("I clicked Payment");
		}

		public void ClickTransactionNumber()
		{
			WaitUntilElementVisible(driver, By.CssSelector(linkTransactionNumber));
			UIAction(linkTransactionNumber, String.Empty, "a");
			pause();			
		}

		public void NavigateAccount(string accountNumber)
		{
			IWebElement WebElementComponent = driver.FindElement(By.CssSelector(btnAccount));
			Console.WriteLine("WebElementComponent.Size.ToString():  " + WebElementComponent.Size.ToString());
			string[] WebEleSize = WebElementComponent.Size.ToString().Replace("{Width=", "").Replace("Height=", "").Replace("}", "").Split(',');
			int WebEleLocWidth = Convert.ToInt16(WebEleSize[0]);
			int WebEleLocHeight = Convert.ToInt16(WebEleSize[1]);
			Console.WriteLine("iWidth: " + WebEleLocWidth);
			Console.WriteLine("iHeight: " + WebEleLocHeight);
			Actions action = new Actions(driver);
			action.MoveToElement(WebElementComponent, WebEleLocWidth, WebEleLocHeight).Click().Build().Perform();
			WaitFor(driver.FindElement(By.XPath(xpathTxtInputAccount))).Click();
			Actions action1 = new Actions(driver);
			action1.SendKeys(accountNumber).Build().Perform();
			WaitFor(driver.FindElement(By.XPath(xpathAccountSearchBtn))).Click();
		}

		public void ClickOnRiskAnalysis()
		{
			string leftPayment = "td[id$='SubmissionWizard:RiskAnalysis']";
			UIActionExt(By.CssSelector(leftPayment), "click");
			Console.WriteLine("I clicked Risk Analysis");
		}

		//public void VerifyPolicyInfoParamsRegular(string a, string b, string c)


	}
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace BillingCenterPages.Pages.Common
{
    public class BCHomePage : Page
    {
        string logOut = "span[id=':TabLinkMenuButton-btnIconEl']";

        string logOutLink = "span[id='TabBar:LogoutTabBarLink-textEl']";

        string searchLink = "span[id$='SearchTab-btnInnerEl']";

        string desktopLink = "span[id$='TabBar:DesktopTab-btnInnerEl']";

        string actionMenuArrow = "span[id$=':AccountDetailMenuActions-btnWrap']";

        string actionMenuNewPayment = "span[id$=':AccountDetailMenuActions_Payments-textEl']";

        string actionMenuDirectBillPayment = "span[id$=':AccountDetailMenuActions_NewDirectBillPayment-textEl']";

        string actionMenuDirectBillCreditDist = "span[id$=':AccountDetailMenuActions_NewDirectBillCreditDistribution-textEl']";

        //   string actionMenuPmtRequest = "span[id$=':AccountDetailMenuActions_NewPaymentRequest-textEl']";
        [FindsBy(How = How.XPath, Using = "//div[@id='AccountGroup:AccountDetailMenuActions:AccountDetailMenuActions_Payments-arrowEl']")]
        public IWebElement actionMenuNewPaymentArrow;

        [FindsBy(How = How.Id, Using = "AccountGroup:AccountDetailMenuActions:AccountDetailMenuActions_Payments:AccountDetailMenuActions_NewPaymentRequest-textEl")]
        public IWebElement actionMenuPmtRequest;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Payment Wallet')]]")]
        public IWebElement leftNavPaymentWallet;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Charges')]]")]
        public IWebElement leftNavCharges;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Payments')]]")]
        public IWebElement leftNavPayments;

        [FindsBy(How = How.Id, Using = "ext-element-212")]
        public IWebElement leftNavSubMenuPayments;

        string actionMenuNewTransaction = "span[id$=':AccountDetailMenuActions_NewTransaction-textEl']";

        string actionMenuDisursement = "span[id$=':AccountDetailMenuActions_Disbursement-textEl']";

        // string actionMenuWriteOff = "span[id$=':AccountDetailMenuActions_NewTransaction:AccountDetailMenuActions_Writeoff-itemEl']";

        //   AccountGroup:AccountDetailMenuActions:AccountDetailMenuActions_NewTransaction:AccountDetailMenuActions_Writeoff-textEl

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Disbursements')]]")]
        public IWebElement leftDisbursements;

        [FindsBy(How = How.Id, Using = "AccountGroup:AccountDetailMenuActions:AccountDetailMenuActions_NewTransaction:AccountDetailMenuActions_Writeoff-textEl")]
        public IWebElement actionMenuWriteOff;

        [FindsBy(How = How.XPath, Using = "//span[text()[.='Transfer']]")]
        public IWebElement actionTransfer;

        

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Payment History')]]")]
        public IWebElement leftNavPaymentHistory;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Documents')]]")]
        public IWebElement leftNavDocuments;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Details')]]")]
        public IWebElement leftDetails;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Payment Schedule')]]")]
        public IWebElement leftNavPaymentSchedule;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'History')]]")]
        public IWebElement leftHistory;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Write-Off Reversal')]]")]
        public IWebElement actionWriteoffReversal;

        [FindsBy(How = How.XPath, Using = "//span[text()[.='Write-Off']]")]
        public IWebElement actionWriteOff;

        string actPaymentPlan = "AccountSummary:AccountSummaryScreen:AccountPolicyPeriodsLV-body";
        //string actInvoices= "AccountDetailInvoices:AccountDetailInvoicesScreen:DetailPanel:AccountInvoicesLV-body";
        string actInvoices = "AccountDetailInvoices:AccountDetailInvoicesScreen:DetailPanel:AccountInvoicesLV";


        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Invoices')]]")]
        public IWebElement leftNavInvoices;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Summary')]]")]
        public IWebElement leftNavSummary;

        //Followings for Desktop tab
        string desktopActionArrow = "span[id$='DesktopGroup:DesktopMenuActions-btnWrap']";
        string desktopMenuActionNewPayment = "span[id$=':DesktopMenuActions:DesktopMenuActions_NewPayment-textEl']";
        string deskoptMenuActionNewPaymentMultiPaymentEntry = "span[id$=':DesktopMenuActions_NewPayment:DesktopMenuActions_MultiPaymentEntryWizard-textEl']";
        string desktopMenuActionNewPaymenSuspensePayment = "span[id$='DesktopMenuActions_NewPayment:DesktopMenuActions_NewSuspensePayment-textEl']";

        //Following for New Document
        string actionNewDocument = "span[id$=':AccountDetailMenuActions:NewDocument-textEl']";
        string actionNewDocumentCreateFromTemplate = "span[id$=':NewDocument:NewDocumentMenuItemSet:NewDocumentFromTemplate-textEl']";
        string btnAccount = "span[id$= 'TabBar:AccountsTab-btnWrap']";
        string xpathTxtInputAccount = "//*[@id='TabBar:AccountsTab:AccountNumberSearchItem-inputEl']";
        string xpathAccountSearchBtn = "//*[@id='TabBar:AccountsTab:AccountNumberSearchItem_Button']";


        public BCHomePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);

            //Console.WriteLine("Driver:" + driver.PageSource);
        }

        public override void VerifyPage()
        {
            //Console.WriteLine("Driver:" + driver.PageSource);

          //  VerifyUIElementIsDisplayed(logOut);
        }

        public override void WaitForLoad()
        {
            //Console.WriteLine("Driver:" + driver.PageSource);
            //     WaitFor(driver.FindElement(By.CssSelector("input.QuickJump")));
          //  IsElementPresent(driver, By.CssSelector(logOut));
        }



        public void NavigateTabBar(string TabName, string TabMenuItem)
        {

			//IList<IWebElement> ImgBillCenters = driver.FindElements(By.TagName("input"));

			//Console.WriteLine("Input tags" + ImgBillCenters.Count);

			//for (int i = 0; i < ImgBillCenters.Count; i++)
			//{
			//    Console.WriteLine(ImgBillCenters[i].GetAttribute("name"));
			//    Console.WriteLine(ImgBillCenters[i].GetAttribute("id"));
			//    Console.WriteLine(ImgBillCenters[i].GetAttribute("class"));
			//}


			//IList<IWebElement> ImgBillCenter = driver.FindElements(By.Id("image-1012"));

			//Console.WriteLine("Images Count: "+ ImgBillCenter.Count);



			//if (ImgBillCenter.Count > 0)
			//    JavaScriptClick(ImgBillCenter[0]);
			//   // ImgBillCenter[0].Click();

			//System.Threading.Thread.Sleep(50000);
			System.Threading.Thread.Sleep(2000);

			switch (TabName.ToLower().Trim())
            {
                case "claimgwsearch":
					System.Threading.Thread.Sleep(2000);
					if (string.IsNullOrEmpty(TabMenuItem))
                    {
                        try
                        {
                            Console.WriteLine("In Try");


                            // WaitFor(driver.FindElement(By.Id("TabBar:SearchTab-btnInnerEl")));

                            IList<IWebElement> searchTab = driver.FindElements(By.Id("TabBar:SearchTab-btnInnerEl")).ToList();

                            Console.WriteLine("Search Tabs:" + searchTab.Count);

                            if (searchTab.Count > 0)
                                JavaScriptClick(searchTab[0]);
                            else
                            {
                                Assert.Fail("Search Tab Not selected.");
                            }
							System.Threading.Thread.Sleep(2000);
						}
                        catch (Exception ex)
                        {
                            Console.WriteLine("In catch");

                            WaitFor(driver.FindElement(By.Id("TabBar:SearchTab")));

                            IList<IWebElement> searchTab = driver.FindElements(By.Id("TabBar:SearchTab")).ToList();

                            Console.WriteLine("Search Tabs:" + searchTab.Count);

                            if (searchTab.Count > 0)
                                JavaScriptClick(searchTab[0]);
                            else
                            {
                                Assert.Fail("Search Tab Not selected.");
                            }
							System.Threading.Thread.Sleep(2000);
						}
                    }
                    break;
                case "search":
					System.Threading.Thread.Sleep(2000);
					if (string.IsNullOrEmpty(TabMenuItem))
                    {
                        try
                        {
                            Console.WriteLine("In Try");


                            // WaitFor(driver.FindElement(By.Id("TabBar:SearchTab-btnInnerEl")));

                            IList<IWebElement> searchTab = driver.FindElements(By.Id("TabBar:SearchTab-btnInnerEl")).ToList();

                            Console.WriteLine("Search Tabs:" + searchTab.Count);

                            if (searchTab.Count > 0)
                                JavaScriptClick(searchTab[0]);
                            else
                            {
                                Assert.Fail("Search Tab Not selected.");
                            }
							System.Threading.Thread.Sleep(5000);

						}
                        catch (Exception ex)
                        {
                            Console.WriteLine("In catch");

                            WaitFor(driver.FindElement(By.Id("TabBar:SearchTab-btnInnerEl")));

                            IList<IWebElement> searchTab = driver.FindElements(By.Id("TabBar:SearchTab-btnInnerEl")).ToList();

                            Console.WriteLine("Search Tabs:" + searchTab.Count);

                            if (searchTab.Count > 0)
                                JavaScriptClick(searchTab[0]);
                            else
                            {
                                Assert.Fail("Search Tab Not selected.");
                            }
							System.Threading.Thread.Sleep(2000);
						}
                        //  System.Windows.Forms.SendKeys.SendWait("(%{K})");



                        //   pause();

                        ////   System.Windows.Forms.SendKeys.SendWait("{ENTER}");

                        //   pause();
                        //   System.Windows.Forms.SendKeys.SendWait("%{s}");

                        //   //Actions action = new Actions(driver);

                        //   pause();

                        //   System.Windows.Forms.SendKeys.SendWait("{ENTER}");

                        //Actions action = new Actions(driver);

                        //action.SendKeys(Keys.Alt + "k").Build().Perform();

                        //action.Release();

                        //pause();

                        //action = new Actions(driver);

                        //action.SendKeys(Keys.Return).Build().Perform();

                        // System.Threading.Thread.Sleep(3000);

                        //try
                        //{
                        //    WaitFor(driver.FindElement(By.CssSelector(searchLink)));
                        //    UIAction(searchLink, string.Empty, "span");
                        //    pause();
                        //}
                        //catch (Exception ex)
                        //{
                        //    WaitFor(driver.FindElement(By.CssSelector(searchLink)));
                        //    UIAction(searchLink, string.Empty, "span");
                        //    pause();
                        //}
                    }

                    break;

                case "desktop":
                    if (string.IsNullOrEmpty(TabMenuItem))
                    {
                        WaitFor(driver.FindElement(By.CssSelector(desktopLink)));
                        UIAction(desktopLink, string.Empty, "span");   
                        pause();
                    }
                    break;
                default:
                    break;
            }

        }

		public void SelectFromActionMenu(string menuOption)
		{
			Console.WriteLine("In Here");
			if (menuOption.ToString() != "new payment:new direct bill payment")
			{
				string[] menuItems = menuOption.Split(':');
				switch (menuItems[0].ToLower().Trim())
				{
					case "new payment":
						WaitFor(driver.FindElement(By.CssSelector(actionMenuArrow)));
						UIAction(actionMenuArrow, string.Empty, "a");
						pause();
						pause();
						WaitFor(driver.FindElement(By.CssSelector(actionMenuNewPayment)));
						UIAction(actionMenuNewPayment, string.Empty, "a");
						pause();
						pause();
						pause();
						UIAction(actionMenuNewPayment, string.Empty, "a");

						System.Threading.Thread.Sleep(3000);

						JavaScriptClick(driver.FindElement(By.CssSelector(actionMenuNewPayment)));
						pause();
						pause();
						Actions action = new Actions(driver);
						action.MoveToElement(driver.FindElement(By.CssSelector(actionMenuNewPayment))).SendKeys(driver.FindElement(By.CssSelector(actionMenuNewPayment)), Keys.ArrowRight).Build().Perform();
						//  IList<IWebElement> elems = driver.FindElements(By.CssSelector("span#AccountGroup:AccountDetailMenuActions:AccountDetailMenuActions_Payments-textEl"));

						//  Console.WriteLine("Elements"+elems.Count);

						//   MouseOver(driver, elems[0]);

						////   WaitFor(actionMenuNewPaymentArrow);
						// JavaScriptClick(actionMenuNewPaymentArrow);

						//Actions action = new Actions(driver);
						//action.SendKeys(Keys.ArrowRight).Build().Perform();

						//action.Release();

						//System.Windows.Forms.SendKeys.SendWait("{RIGHT}");
						//IWebElement PaymentLinkArrow = driver.FindElement(By.XPath("//div[@id='AccountGroup:AccountDetailMenuActions:AccountDetailMenuActions_Payments-arrowEl']"));
						////PaymentLinkArrow.Click();
						//JavaScriptClick(PaymentLinkArrow);
						WaitForPageLoad(driver);
						pause();
						if (menuItems.Length > 1)
						{
							switch (menuItems[1].ToLower().Trim())
							{
								case "new direct bill payment":
									Console.WriteLine("New Direct Bill Payment");
									WaitFor(driver.FindElement(By.CssSelector(actionMenuDirectBillPayment)));
									UIAction(actionMenuDirectBillPayment, string.Empty, "a");
									pause();
									break;

								case "new direct bill credit distribution":
									Console.WriteLine("New Direct Bill Credit Distribution");
									WaitFor(driver.FindElement(By.CssSelector(actionMenuDirectBillCreditDist)));
									UIAction(actionMenuDirectBillCreditDist, string.Empty, "a");
									pause();
									break;

								case "payment request":

									pause();

									WaitFor(actionMenuPmtRequest);
									JavaScriptClick(actionMenuPmtRequest);
									WaitForPageLoad(driver);

									pause();
									break;
								default:
									break;
							}
						}

						break;

					case "new transaction":
						WaitFor(driver.FindElement(By.CssSelector(actionMenuArrow)));
						UIAction(actionMenuArrow, string.Empty, "a");
						pause();
						WaitFor(driver.FindElement(By.CssSelector(actionMenuNewTransaction)));
						UIAction(actionMenuNewTransaction, string.Empty, "a");
						driver.FindElement(By.CssSelector(actionMenuNewTransaction)).SendKeys(Keys.ArrowRight);
						pause();
						if (menuItems.Length > 1)
						{
							switch (menuItems[1].ToLower().Trim())
							{
								case "disbursement":
									Console.WriteLine("Disursement");
									WaitFor(driver.FindElement(By.CssSelector(actionMenuDisursement)));
									UIAction(actionMenuDisursement, string.Empty, "a");
									pause();
									break;


								case "write-off":
									Console.WriteLine("write-off");
									WaitFor(actionWriteOff);
									JavaScriptClick(actionWriteOff);
									pause();
									//WaitFor(driver.FindElement(By.XPath("//span[text()[contains(.,'Write-Off')]]")));

									//IList<IWebElement> list = driver.FindElements(By.XPath("//span[text()[contains(.,'Write-Off')]]")).ToList();

									//for (int i = 0; i < list.Count; i++)
									//{
									//    if (list[i].Text.Trim().Length < 10)
									//    {
									//        Console.WriteLine(list[i].Text);
									//        JavaScriptClick(list[0]);
									//        break;
									//    }
									//}
									break;

								case "write-offreversal":
									Console.WriteLine("write-offreversal");
									// actionWriteoffReversal.Click(); 
									WaitFor(actionWriteoffReversal);
									JavaScriptClick(actionWriteoffReversal);
									pause();
									break;

								case "transfer":
									Console.WriteLine("Transfer");
									WaitFor(actionTransfer);
									JavaScriptClick(actionTransfer);
									pause();
									break;


							}
						}
						break;
                    case "new document":
                        Console.WriteLine("new documents");
                        WaitFor(driver.FindElement(By.CssSelector(actionMenuArrow)));
                        UIAction(actionMenuArrow, string.Empty, "a");
                        pause();

                        WaitFor(driver.FindElement(By.CssSelector(actionNewDocument)));
                        UIAction(actionNewDocument, string.Empty, "a");
                        JavaScriptClick(driver.FindElement(By.CssSelector(actionNewDocument)));
                        Actions action1 = new Actions(driver);
                        action1.MoveToElement(driver.FindElement(By.CssSelector(actionNewDocument))).SendKeys(driver.FindElement(By.CssSelector(actionNewDocument)), Keys.ArrowRight).Build().Perform();
                        WaitForPageLoad(driver);
                        if (menuItems.Length > 1)
                        {
                            switch (menuItems[1].ToLower().Trim())
                            {
                                case "create from a template":
                                    Console.WriteLine("Create from a template");
                                    WaitFor(driver.FindElement(By.CssSelector(actionNewDocumentCreateFromTemplate)));
                                    UIAction(actionNewDocumentCreateFromTemplate, string.Empty, "a");
                                    JavaScriptClick(driver.FindElement(By.CssSelector(actionNewDocumentCreateFromTemplate)));
                                    pause();
                                    pause();
                                    break;
                                default:
                                    Console.WriteLine("None");
                                    break;
                            }
                        }
                        break;
                    default:
						break;
				}
			}
			
        }


        public void selectLeftNavMenu(string leftNavMenu)
        {
            pause();
            string[] menuOption = leftNavMenu.Split(':');

            switch (menuOption[0].ToLower().Trim())
            {
                case "payments":
                    System.Threading.Thread.Sleep(2000);
                    WaitFor(leftNavPayments);
                    leftNavPayments.Click();
                    pause();
                    switch (menuOption[1].ToLower().Trim())
                    {
                        case "payments":
                            // leftNavSubMenuPayments.Click();
                            pause();
                            break;

                        case "payment history":
                            WaitFor(leftNavPaymentHistory);
                            leftNavPaymentHistory.Click();
                            pause();
                            break;
                        default:
                            break;
                    }

                    break;

                case "charges":
                    pause();
                    WaitFor(leftNavCharges);
                    leftNavCharges.Click();
                    break;

                case "disbursements":
                    pause();
                    WaitFor(leftDisbursements);
                    leftDisbursements.Click();
                    break;

                case "payment wallet":
                    WaitFor(leftNavPaymentWallet);
                    leftNavPaymentWallet.Click();
                    break;

                case "documents":
                    WaitFor(leftNavDocuments);
                    leftNavDocuments.Click();
					string lblDocuments = "span[id$='AccountDetailDocuments:AccountDetailDocumentsScreen:ttlBar']";
					WaitUntilElementVisible(driver,By.CssSelector(lblDocuments));
                    break;


                case "details":
                    WaitFor(leftDetails);
                    leftDetails.Click();
                    break;


                case "payment schedule":
                    WaitFor(leftNavPaymentSchedule);
                    leftNavPaymentSchedule.Click();
                    break;

                case "history":
                    pause();
                    pause();
                    WaitFor(leftHistory);
                    leftHistory.Click();
                    break;
                case "invoices":
                    WaitFor(leftNavInvoices);
                    leftNavInvoices.Click();
                    break;
                case "summary":
                    WaitFor(leftNavSummary);
                    leftNavSummary.Click();
                    break;

                default:
                    break;
            }

        }



        public void LogoutOfBC()
        {
            WaitFor(driver.FindElement(By.CssSelector(logOut)));
            UIAction(logOut, string.Empty, "span");

            pause();

            WaitFor(driver.FindElement(By.CssSelector(logOutLink)));
            UIAction(logOutLink, string.Empty, "span");

        }


        public void GetPaymentPlan(string expPaymentPlan)
        {
            pause();
            pause();
            WaitFor(driver.FindElement(By.Id(actPaymentPlan)));

            List<IWebElement> PageInputs = driver.FindElements(By.Id(actPaymentPlan)).ToList();
            string[] arrTblList = PageInputs[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            Console.WriteLine("Policy Period : {0} - {1}", arrTblList[3], arrTblList[4]);
            ScenarioContext.Current["EffectiveDate"] = arrTblList[3];
            //ScenarioContext.Current["EffectiveDate"] = arrTblList[3];
            if (expPaymentPlan.Trim().ToLower().Equals(arrTblList[1].Trim().ToLower()))
            {
                Console.WriteLine("Payment Plan validation : {0}", "Pass");
            }
            else
            {
                Console.WriteLine("Payment Plan validation : {0}", "Fail");
                Assert.Fail("Payment Plan validation Fail");
            }
            Console.WriteLine("Expected Payment Plan: {0},\nActual Payment Plan: {1}", expPaymentPlan, arrTblList[1]);

        }

        public void verifyinvoicePayments(string paymentPlan)
        {
			pause();
			pause();
			WaitFor(driver.FindElement(By.Id(actInvoices)));

            var drMainTable = driver.FindElement(By.Id(actInvoices));
            List<IWebElement> lsGetTrElements = new List<IWebElement>(drMainTable.FindElements(By.TagName("tr")));
            for (int i = 0; i < lsGetTrElements.Count(); i++)
            {
                Console.WriteLine(i + "-----" + lsGetTrElements[i].Text);
            }
            String sRowData = "";
            String sTableDate = "";
            int iToTalRows = 0;
            iToTalRows = (lsGetTrElements.Count > 0) ? lsGetTrElements.Count : iToTalRows;
            if (iToTalRows > 0)
            {
                foreach (var oTrElement in lsGetTrElements)
                {
                    List<IWebElement> lsGetTdElemets = new List<IWebElement>(oTrElement.FindElements(By.TagName("td")));
                    if (lsGetTdElemets.Count > 0)
                    {
                        int iBillDates = 1;
                        foreach (var oTdElement in lsGetTdElemets)
                        {
                            sRowData = (iBillDates == 1) ? sRowData = oTdElement.Text : sRowData + "|" + oTdElement.Text;
                            iBillDates = 0;
                        }
                        //Console.WriteLine(sRowData);
                        sTableDate = (sTableDate == "") ? sRowData : sTableDate + ";" + sRowData;
                    }

                }
            }
            List<string> arrTblEachRow = new List<string>(sTableDate.Split(';'));
            string sActInvoiceDates = "";
            for (int iEachRow = 0; iEachRow < arrTblEachRow.Count - 1; iEachRow++)
            {
                List<string> arrTblEachCol = new List<string>(arrTblEachRow[iEachRow].Split('|'));
                if (arrTblEachCol[7].ToString() != "-")
                {
                    sActInvoiceDates = sActInvoiceDates == "" ? arrTblEachCol[1].ToString() : sActInvoiceDates + ";" + arrTblEachCol[1].ToString();
                }
            }

            DateTime dtBillDate = Convert.ToDateTime(ScenarioContext.Current["EffectiveDate"].ToString()).AddDays(1);
            string sExpInvoiceList = dtBillDate.ToString("MM/dd/yyyy");
            switch (paymentPlan.ToLower().Trim())
            {
                case "annual pay":
                    break;
                case "2 pay - semi annually":
                    sExpInvoiceList = sExpInvoiceList + ";" + dtBillDate.AddMonths(6).ToString("MM/dd/yyyy");
                    break;
                case "4 pay - quarterly":
                    for (int i = 3; i <= 9; i += 3)
                    {
                        sExpInvoiceList = sExpInvoiceList + ";" + dtBillDate.AddMonths(i).ToString("MM/dd/yyyy");
                    }
                    break;
                case "8 pay":
                    for (int i = 1; i <= 7; i++)
                    {
                        sExpInvoiceList = sExpInvoiceList + ";" + dtBillDate.AddMonths(i).ToString("MM/dd/yyyy");
                    }
                    break;
                case "12 pay":
                    for (int i = 1; i <= 11; i++)
                    {
                        sExpInvoiceList = sExpInvoiceList + ";" + dtBillDate.AddMonths(i).ToString("MM/dd/yyyy");
                    }
                    break;
                case "10 pay":
                    for (int i = 1; i <= 9; i++)
                    {
                        sExpInvoiceList = sExpInvoiceList + ";" + dtBillDate.AddMonths(i).ToString();
                    }
                    break;
                default:
                    break;
            }
            //Console.WriteLine("Expected invoice dates:\t {0}\nActual invoice dates:\t {1}",sExpInvoiceList, sActInvoiceDates);
            string teststatus = "";
            teststatus = (sActInvoiceDates == sExpInvoiceList) ? "Pass" : "Fail";
            //Console.WriteLine("Validating Payment Plan invoice Dates :{0}", teststatus);

            switch (teststatus.ToLower().Trim())
            {
                case "fail":
                    Assert.Fail("\nExpected invoice dates:\t {0}\nActual invoice dates:\t {1}", sExpInvoiceList, sActInvoiceDates);
                    break;
                case "pass":
                    Console.WriteLine("Scenario Passed:\nExpected invoice dates:\t {0}\nActual invoice dates:\t {1}", sExpInvoiceList, sActInvoiceDates);
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
        }


        public void verifyBilldate(string Billdate)
        {
            WaitFor(driver.FindElement(By.Id(actInvoices)));

            DateTime dt = Convert.ToDateTime(Billdate);
            ///*BillDateComparision*/(dt.AddDays(1).ToString("MM/dd/yyyy"), "Bill Date");
            var drMainTable = driver.FindElement(By.Id(actInvoices));
            List<IWebElement> lsGetTrElements = new List<IWebElement>(drMainTable.FindElements(By.TagName("tr")));
            //String sRowData = "";
            //String sTableDate = "";
            int iToTalRows = 0;
            iToTalRows = (lsGetTrElements.Count > 0) ? lsGetTrElements.Count : iToTalRows;
            if (iToTalRows > 0)
            {
                foreach (var oTrElement in lsGetTrElements)
                {
                    List<IWebElement> lsGetTdElemets = new List<IWebElement>(oTrElement.FindElements(By.TagName("td")));
                    if (lsGetTdElemets.Count > 0)
                    {
                        String billDate = (dt.AddDays(1).ToString("MM/dd/yyyy"));

                        if (string.Compare(billDate, lsGetTdElemets[1].Text) == 0)
                        {
                            Console.WriteLine("Bill date matches : Expected value " + billDate + " actual value " + lsGetTdElemets[1].Text);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Bill date do not matches : Expected value " + billDate + " actual value " + lsGetTdElemets[1].Text);
                            break;
                        }

                    }

                }
            }
        }

  
        public void SelectFromActionMenuUnderDesktopTab(string menuOption)
        {
            if (menuOption.ToLower().Equals("new payment:multiple payment entry"))
            {
                string[] menuItems = menuOption.Split(':');
                switch (menuItems[0].ToLower().Trim())
                {
                    case "new payment":
                        WaitFor(driver.FindElement(By.CssSelector(desktopActionArrow)));
                        UIAction(desktopActionArrow, string.Empty, "a");
                        pause();
                        WaitFor(driver.FindElement(By.CssSelector(desktopMenuActionNewPayment)));
                        UIAction(desktopMenuActionNewPayment, string.Empty, "a");

                        JavaScriptClick(driver.FindElement(By.CssSelector(desktopMenuActionNewPayment)));
                      //  pause();
                        Actions action = new Actions(driver);
                        action.MoveToElement(driver.FindElement(By.CssSelector(desktopMenuActionNewPayment))).SendKeys(driver.FindElement(By.CssSelector(desktopMenuActionNewPayment)), Keys.ArrowRight).Build().Perform();
                        WaitForPageLoad(driver);

                        if (menuItems.Length > 1)
                        {
                            switch (menuItems[1].ToLower().Trim())
                            {
                                case "multiple payment entry":
                                    Console.WriteLine("Multiple Payment Entry");
                                    WaitFor(driver.FindElement(By.CssSelector(deskoptMenuActionNewPaymentMultiPaymentEntry)));
                                    UIAction(deskoptMenuActionNewPaymentMultiPaymentEntry, string.Empty, "a");
                                    pause();
                                    break;
                                case "suspense payment":
                                    Console.WriteLine("Suspense Payment");
                                    WaitFor(driver.FindElement(By.CssSelector(desktopMenuActionNewPaymenSuspensePayment)));
                                    UIAction(desktopMenuActionNewPaymenSuspensePayment, string.Empty, "a");
                                    pause();
                                    break;
                                default:
                                    Console.WriteLine("None");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("None");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Other Actions");
            }
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

    }
}

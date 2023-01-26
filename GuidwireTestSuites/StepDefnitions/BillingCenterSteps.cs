using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PolicyCenterPages.Pages.CreateAccount;
using PolicyCenterPages.Pages.NewSubmission;
using PolicyCenterPages.Pages.Common;
using GuidewireTestSuites.UIScreenMapping;
using TechTalk.SpecFlow.Assist;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using System.Data;
using WebCommonCore;
using BillingCenterPages.Pages.Common;
using BillingCenterPages.Pages.Search;
using BillingCenterPages.Pages.NewPayment;
using BillingCenterPages.Pages.PaymentWallet;
using BillingCenterPages.Pages.PaymentHistory;
using BillingCenterPages.Pages.Charges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BillingCenterPages.Pages.DisbursementPayment;
using BillingCenterPages.Pages.Disbursement;
using BillingCenterPages.Pages.Documents;
using BillingCenterPages.Pages.WriteOff;
using BillingCenterPages.Pages.Transfers;
using BillingCenterPages.Pages.Desktop;

//Sample Test comment
namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    public class BillingCenterSteps : TestBase
    {
        [Given(@"I enter (.*) and (.*) on the BC Login page")]
        [Then(@"I enter (.*) and (.*) on the BC Login page")]
        [When(@"I enter (.*) and (.*) on the BC Login page")]
        public void GivenIEnterLoginDetailsOnTheBCLoginPage(string userName, string passWord)
        {
            BCLoginPage bcLogin = new BCLoginPage(getDriver());

			userName = System.Configuration.ConfigurationManager.AppSettings[userName];
			passWord = System.Configuration.ConfigurationManager.AppSettings[passWord];
			if (userName.ToString() == string.Empty)
			{
				Assert.Fail("UserName can't be empty or null");
			}
			else
			{
				if (ScenarioContext.Current.ContainsKey("GWBCUSER") == false)
				{
					ScenarioContext.Current.Add("GWBCUSER", userName);
				}
				else
				{
					if (ScenarioContext.Current["GWBCUSER"].ToString() != userName)
					{
						ScenarioContext.Current["GWBCUSER"] = userName;
					}
				}
			}
			bcLogin.LoginIntoBC(userName, passWord);
		}

        [Given(@"I select (.*) from the Tab menu")]
        [When(@"I select (.*) from the Tab menu")]
        public void SelectSearchFromTheTabMenu(string TabMenu)
        {
            BCHomePage bCHomePage = new BCHomePage(getDriver());

            bCHomePage.NavigateTabBar(TabMenu, string.Empty);
        }


        [Given(@"search for account with (.*) and select from search results")]
        [When(@"search for account with (.*) and select from search results")]
        public void GivenSearchForAccount(string accountNumber)
        {
            DataStorage temp = new DataStorage();

            string accNum = null;
            switch (accountNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    accNum = temp.GetTempValue("ACCNO");
					string policyNum = temp.GetTempValue("PLCYNO");

					if (ScenarioContext.Current.ContainsKey("ACCOUNT") == false)
					{
						ScenarioContext.Current.Add("ACCOUNT", accNum);
					}
					if (ScenarioContext.Current.ContainsKey("POLICY") == false)
					{
						ScenarioContext.Current.Add("POLICY", policyNum);
					}
					break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    accNum = UFTRegKey.GetValue("ACCNO").ToString();
                    break;
                default:
                    accNum = accountNumber;
                    break;
            }

            if (ScenarioContext.Current.ContainsKey("ACCOUNT") == true)
            {
                if (ScenarioContext.Current["ACCOUNT"].ToString() != accNum)
                {
                    ScenarioContext.Current["ACCOUNT"] = accNum;
                }
            }
            else
            {
                ScenarioContext.Current.Add("ACCOUNT", accNum);
            }


            SearchAccounts searchAccounts = new SearchAccounts(getDriver());

            searchAccounts.SearchAccount(accNum);

            searchAccounts.SelectAccount();
        }

        [When(@"I fetch country name and total amount due")]
        public void WhenIFetchCountryNameAndTotalAmountDue()
        {
            BCDetails bCDetails = new BCDetails(getDriver());
            bCDetails.GetCountryNameDueDate();
            bCDetails.GetTotalAmountDue();
        }

        [When(@"search for account with (.*) and select from search results for QNA")]
        public void WhenSearchForAccountWithAndSelectFromSearchResultsForQNA(string accountNumber)
        {
            DataStorage temp = new DataStorage();

            string accNum = null;
            switch (accountNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    accNum = temp.GetTempValue("ACCNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    accNum = UFTRegKey.GetValue("ACCNO").ToString();
                    break;
                default:
                    accNum = accountNumber;
                    break;
            }

            SearchAccounts searchAccounts = new SearchAccounts(getDriver());
            searchAccounts.SearchAccount(accNum);
            searchAccounts.SelectAccount();
        }


        [Given(@"I select (.*) from actions menu")]
        [When(@"I select (.*) from actions menu")]
        [Then(@"I select (.*) from actions menu")]
        public void GivenISelectFromActionsMenu(string menuOption)
        {
            BCHomePage bCHomePage = new BCHomePage(getDriver());

            bCHomePage.SelectFromActionMenu(menuOption);


        }

        [When(@"I make a write-off payments of (.*) , (.*) , (.*) in Write-off Wizard page")]
        public void WhenIMakeAWrite_OffPaymentsOfInstallmentFeeCustomerRequestInWrite_OffWizardPage(string WriteoffAmount, string WriteoffPattern, string WriteoffReason)

        {
            //   System.Threading.Thread.Sleep(5000);
            BCWriteOff BCWriteOffPage = new BCWriteOff(getDriver());

            BCWriteOffPage.WriteOffAmount(WriteoffAmount, WriteoffPattern, WriteoffReason);

        }




        [Given(@"I make a direct bill payment of (.*)")]
        [When(@"I make a direct bill payment of (.*)")]
        public void GivenIMakeADirectBillPaymentOf(string paymentAmount)
        {
            DirectBillPayment directBillPmt = new DirectBillPayment(getDriver());

            directBillPmt.NewDirectBillPayment(paymentAmount);
        }

        [Given(@"I pay premium of (.*) using (.*) with (.*) on (.*)")]
        [When(@"I pay premium of (.*) using (.*) with (.*) on (.*)")]
        public void IPayMyPremium(string paymentAmount, string paymentType, string CCType, string paymentDate)
        {
            NewPaymentRequestWizard newPmtWizard = new NewPaymentRequestWizard(getDriver());

            newPmtWizard.PayMyPremium(paymentAmount, paymentType, CCType, paymentDate);

        }
        [Then(@"I verify (.*) in Payment Methods")]
        [Given(@"I verify (.*) in Payment Methods")]
        [When(@"I verify (.*) in Payment Methods")]
        public void ThenIVerifyInPaymentMethods(string PaymentMethod)
        {
            PaymentWallet pmtWallet = new PaymentWallet(getDriver());
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    pmtWallet.verifyPaymentMethods(PaymentMethod);
                    break;
                default:
                    break;

            }
        }





        [Then(@"I click on ManageAutoPay (.*)")]
        [When(@"I click on ManageAutoPay (.*)")]
        public void ThenIClickOnManageAutoPay(string PaymentMethod)
        {
            PaymentWallet pmtWallet = new PaymentWallet(getDriver());
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    pmtWallet.clickonManageAutoPay();
                    pmtWallet.VerifyAutoPay(PaymentMethod);
                    break;
                default:
                    break;

            }

        }
        [Given(@"I select (.*) from left navigation menu")]
        [Then(@"I select (.*) from left navigation menu")]
        [When(@"I select (.*) from left navigation menu")]
        public void SelectFromLeftNavigationMenu(string leftNavMenu)
        {
            BCHomePage bCHomePage = new BCHomePage(getDriver());

            bCHomePage.selectLeftNavMenu(leftNavMenu);
        }

        [Then(@"I verify see the (.*) value displayed")]
        public void ThenIVerifySeeTheTaxesPLPLPremiumPLPLInstallmentFeeValueDisplayed(string chargeType)
        {
            Charges charges = new Charges(getDriver());

            string actualVal = charges.getChargeType();
            string coampre_flag = "";
            string actual_value_temp = actualVal;
            if (chargeType.Contains(";"))
            {
                char[] delimiterChars = { ';' };
                string[] expected_value = chargeType.Split(delimiterChars);
                if (actualVal.Contains(";"))
                {
                    string[] actual_value = actualVal.Split(delimiterChars);
                    foreach (string expected in expected_value)
                    {
                        coampre_flag = "false";
                        foreach (string actual in actual_value)
                        {
                            if (String.Equals(expected.ToLower(), actual.ToLower()))
                            {
                                coampre_flag = "true";
                                actual_value_temp = actual;
                                break;
                            }
                        }
                        if (String.Equals(coampre_flag, "true"))
                        {
                            Assert.AreEqual(expected.ToLower(), actual_value_temp.ToLower());
                            Console.WriteLine("expected value is " + expected.ToLower() + "actual value is " + actual_value_temp.ToLower());
                        }
                        else
                        {
                            Assert.AreEqual(expected.ToLower(), actualVal.ToLower());
                            Console.WriteLine("expected value is " + expected.ToLower() + "actual value is " + actual_value_temp.ToLower());
                        }
                    }
                }



            }
            else
            {
                Assert.AreEqual(chargeType.ToLower(), actualVal.ToLower());

            }

        }


        [When(@"I select PolicyNumber from Account Details Screen")]
        public void WhenISelectPolicyNumberFromAccountDetailsScreen()
        {
            //ScenarioContext.Current.Pending();
            BCDetails bCDetailsPage = new BCDetails(getDriver());

            bCDetailsPage.SelectPolicyNumber();


        }

        [Given(@"I remove the stored payment methods")]
        [When(@"I remove the stored payment methods")]
        public void RemoveTheStoredPaymentMethods()
        {
            PaymentWallet pmtWallet = new PaymentWallet(getDriver());

            pmtWallet.removeExistingPaymentTypes();
        }

        [Then(@"I verify (.*) payment methods")]
        public void GivenIVerifyPaymentMethods(string PaymentMethod)
        {
            PaymentHistory pmtHistory = new PaymentHistory(getDriver());

            pmtHistory.verifyPayments(PaymentMethod);
        }

        [Given(@"I perform payment reversal")]
        [Then(@"I perform payment reversal")]
        public void GivenIPerformPaymentReversal()
        {
            Payments payments = new Payments(getDriver());

            payments.ReverserPayment();
        }



        [Then(@"I Logout of the Billing Center application")]
        [When(@"I Logout of the Billing Center application")]
        public void LogoutOfTheBillingCenterApplication()
        {
            System.Threading.Thread.Sleep(5000);

            BCHomePage bCHomePage = new BCHomePage(getDriver());

            bCHomePage.LogoutOfBC();
        }


        [Then(@"I Should see the Charge Type value displayed")]
        public void VerifyChargeTypeValueDisplayed()
        {
            Charges charges = new Charges(getDriver());

            charges.getChargeType();
        }

        [Then(@"I Should see the (.*) value displayed")]
        public void VerifyChargeTypeValueDisplayed(string chargeType)
        {
            Charges charges = new Charges(getDriver());

            string actualVal = charges.getChargeType();

            Assert.AreEqual(chargeType.ToLower(), actualVal.ToLower());
        }

        [When(@"I make a disburse payment of (.*) for (.*)")]
        public void MakeaDisbursePayment(string paymentAmount, string disbursementReason)
        {
            // System.Threading.Thread.Sleep(5000);
            DisbursementPayment bCDisbursementPaymentPage = new DisbursementPayment(getDriver());

            bCDisbursementPaymentPage.MakeDisbursementPayment(paymentAmount, disbursementReason);
        }

        [Then(@"I Verify (.*) status is (.*) in Disbursements table")]
        public void WhenIVerifyIsSuccessfullInDisbursementsTable(string paymentAmount, string status)
        {

            Disbursements bCDisbursementPage = new Disbursements(getDriver());

            bCDisbursementPage.DisbursementPaymentStatus(paymentAmount, status);


        }

        [When(@"I select (.*) on the document search criteria")]
        public void SelectOnTheDocumentSearchCriteria(string searchBy)
        {
            //System.Threading.Thread.Sleep(5000);

            Documents documents = new Documents(getDriver());

            documents.SelectSearchByCriteria(searchBy);
        }


        [Then(@"I verify (.*) for (.*) for (.*) , (.*) in History Page")]
        public void ThenIVerifyWriteOffForForCustomerRequestInHistoryPage(string writeoffType, string writeoffAmount, string WriteoffReason, string WriteoffReversalReason)

        {
            //System.Threading.Thread.Sleep(5000);
            BCHistory bCHistoryPage = new BCHistory(getDriver());

            bCHistoryPage.VerifyHistoryPageWriteOff(writeoffType, writeoffAmount, WriteoffReason, WriteoffReversalReason);

            //ScenarioContext.Current.Pending(); 
        }

        [When(@"I make a write-off Reversal for (.*) in Write-off Reversal Wizard page")]
        [Then(@"I make a write-off Reversal for (.*) in Write-off Reversal Wizard page")]
        public void WhenIMakeAWrite_OffReversalForPaymentReceivedInWrite_OffReversalWizardPage(string writeOffReversalReason)
        {

            BCWriteOffReversal bCWriteOffReversalPage = new BCWriteOffReversal(getDriver());

            bCWriteOffReversalPage.WriteOffReversal(writeOffReversalReason);
        }

        [When(@"I search documents by selecting (.*) , (.*) , (.*) , (.*) , (.*) in document page")]
        public void WhenISearchDocumentsBySelectingInDocumentPage(string DocumentTypeName, string SearchBy, string FromDate, string Todate, string SinceOption)

        {
            //  System.Threading.Thread.Sleep(5000);
            BCDocuments bcDocumentsPage = new BCDocuments(getDriver());

            bcDocumentsPage.DocumentSearch(DocumentTypeName, SearchBy, FromDate, Todate, SinceOption);

        }

        [When(@"I select policy number from Account Details Screen")]
        public void WhenISelectFromAccountDetailsScreen()
        {
            //  System.Threading.Thread.Sleep(5000);
            //  System.Threading.Thread.Sleep(5000);
            BCDetails bCDetailsPage = new BCDetails(getDriver());

            bCDetailsPage.SelectPolicyNumber();
        }

        [Then(@"I change (.*) in Change Payment Plan Page")]
        [When(@"I change (.*) in Change Payment Plan Page")]
        public void WhenIChangInChangePaymentPlanPage(string PaymentPlan)
        {
            //System.Threading.Thread.Sleep(5000);
            BCPaymentSchedule BCChangePaymentPlanPage = new BCPaymentSchedule(getDriver());
            DataStorage temp = new DataStorage();

            string payPlan = null;
            switch (PaymentPlan.ToUpper().Trim())
            {
                case "REGISTRY":
                    payPlan = temp.GetTempValue("PAYMENT_PLAN");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    payPlan = UFTRegKey.GetValue("PAYMENT_PLAN").ToString();
                    break;
                default:
                    payPlan = PaymentPlan;
                    break;
            }

            BCChangePaymentPlanPage.ChangePaymentPlan(payPlan);
        }





        [Then(@"I Verify if documents are (.*) in document page")]
        public void ThenIVerifyIfDocumentsAreYesInDocumentPage(string Documentsavailable)
        {
            BCDocuments bcDocumentsPage = new BCDocuments(getDriver());

            bcDocumentsPage.VerifyDocuments(Documentsavailable);
        }


        [When(@"I validate (.*) for the Policy")]
        public void WhenIValidatePaymentPlanForThePolicy(string paymentPlan)
        {
            DataStorage temp = new DataStorage();

            string payPlan = null;
            switch (paymentPlan.ToUpper().Trim())
            {
                case "REGISTRY":
                    payPlan = temp.GetTempValue("PAYMENT_PLAN");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    payPlan = UFTRegKey.GetValue("PAYMENT_PLAN").ToString();
                    break;
                default:
                    payPlan = paymentPlan;
                    break;
            }
            BCHomePage bCHomePage = new BCHomePage(getDriver());
            bCHomePage.GetPaymentPlan(payPlan);
        }

        [Then(@"I verify the current and scheduled invoice payments for (.*)")]
        public void ThenIVerifyTheCurrentAndScheduledInvoicePaymentsForPaymentPlans(string paymentPlan)
        {
            BCHomePage bCHomePage = new BCHomePage(getDriver());
            DataStorage temp = new DataStorage();

            string payPlan = null;
            switch (paymentPlan.ToUpper().Trim())
            {
                case "REGISTRY":
                    payPlan = temp.GetTempValue("PAYMENT_PLAN");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    payPlan = UFTRegKey.GetValue("PAYMENT_PLAN").ToString();
                    break;
                default:
                    payPlan = paymentPlan;
                    break;
            }
            bCHomePage.verifyinvoicePayments(payPlan);
        }

        [Then(@"I verify bill date (.*) in Invoice")]
        public void ThenIVerifyBillDateInInvoice(string p0)
        {
            BCHomePage bCHomePage = new BCHomePage(getDriver());
            bCHomePage.verifyBilldate(p0);

        }

        [Then(@"I verify (.*) , (.*) in Account Details page for Agent Inquiry")]
        public void IVerifyInAccountDetailsPageForAgentInquiry(string Address, string PaymentPlan)
        {
            BCDetails bCDetailsPage = new BCDetails(getDriver());
            DataStorage temp = new DataStorage();
            string addr = null;
            string PymtPlan = null;
            switch (Address.ToUpper().Trim())
            {
                case "REGISTRY":
                    addr = temp.GetTempValue("ACC_ADDRESS");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    addr = UFTRegKey.GetValue("ACC_ADDRESS").ToString();
                    break;
                default:
                    addr = Address;
                    break;
            }
            switch (PaymentPlan.ToUpper().Trim())
            {
                case "REGISTRY":
                    PymtPlan = temp.GetTempValue("PAYMENTPLAN");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PymtPlan = UFTRegKey.GetValue("PAYMENTPLAN").ToString();
                    break;
                default:
                    PymtPlan = PaymentPlan;
                    break;
            }
            Console.WriteLine("Reg Values: {0},{1}", addr, PymtPlan);
            bCDetailsPage.VerifyDetailsAgentInquiry(addr, PymtPlan);

        }



        [When(@"I verify (.*) , (.*) , (.*) , (.*) ,  (.*) , (.*) , (.*) in Account Details page")]
        [Then(@"I verify (.*) , (.*) , (.*) , (.*) ,  (.*) , (.*) , (.*) in Account Details page")]
        public void ThenIVerifyInAccountDetailsPage(string PrimaryInsured, string Address, string PolicyNo, string PaymentPlan, string EffectiveDate, string ExpireDate, string PaymentInstrument)
        {
            BCDetails bCDetailsPage = new BCDetails(getDriver());
            DataStorage temp = new DataStorage();
            string PriInsured = null;
            string addr = null;
            string PlcyNo = null;
            string EffDt = null;
            string ExpDt = null;
            string PymtPlan = null;
            switch (PrimaryInsured.ToUpper().Trim())
            {
                case "REGISTRY":
                    PriInsured = temp.GetTempValue("PRIMARY_INSURED");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PriInsured = UFTRegKey.GetValue("PRIMARY_INSURED").ToString();
                    break;
                default:
                    PriInsured = PrimaryInsured;
                    break;
            }

            switch (Address.ToUpper().Trim())
            {
                case "REGISTRY":
                    addr = temp.GetTempValue("ACC_ADDRESS");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    addr = UFTRegKey.GetValue("ACC_ADDRESS").ToString();
                    break;
                default:
                    addr = Address;
                    break;
            }


            switch (PolicyNo.ToUpper().Trim())
            {
                case "REGISTRY":
                    PlcyNo = temp.GetTempValue("PLCYNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PlcyNo = UFTRegKey.GetValue("PLCYNO").ToString();
                    break;
                default:
                    PlcyNo = PolicyNo;
                    break;
            }


            switch (PaymentPlan.ToUpper().Trim())
            {
                case "REGISTRY":
                    PymtPlan = temp.GetTempValue("PAYMENTPLAN");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PymtPlan = UFTRegKey.GetValue("PAYMENTPLAN").ToString();
                    break;
                default:
                    PymtPlan = PaymentPlan;
                    break;
            }


            switch (ExpireDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    ExpDt = temp.GetTempValue("EXPDATE");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    ExpDt = UFTRegKey.GetValue("EXPDATE").ToString();
                    break;
                default:
                    ExpDt = ExpireDate;
                    break;
            }


            switch (EffectiveDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    EffDt = temp.GetTempValue("EFFDATE");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    EffDt = UFTRegKey.GetValue("EFFDATE").ToString();
                    break;
                default:
                    EffDt = EffectiveDate;
                    break;
            }

            Console.WriteLine("Reg Values: {0},{1},{2},{3},{4}", PriInsured, addr, PlcyNo, EffDt, ExpDt);
            bCDetailsPage.VerifyDetails(PriInsured, addr, PlcyNo, PymtPlan, EffDt, ExpDt, PaymentInstrument);

        }


        [Then(@"I verify (.*) in Account Details page for Auto Pay")]
        public void ThenIVerifyVisaInAccountDetailsPageForAutoPay(string autoPay)
        {
            BCDetails bCDetailsPage = new BCDetails(getDriver());
            bCDetailsPage.verifyAutopay(autoPay);
        }


     




        [When(@"I select (.*) and input an amount of (.*)")]
        public void WhenISelectAndInputAnAmountOf(string targetAccount, string targetAmount)
        {
			DataStorage temp = new DataStorage();

			string accNum = null;
			switch (targetAccount.ToUpper().Trim())
			{
				case "REGISTRY":
					accNum = temp.GetTempValue("ACCNO");
					string policyNum = temp.GetTempValue("PLCYNO");

					if (ScenarioContext.Current.ContainsKey("ACCOUNT") == false)
					{
						ScenarioContext.Current.Add("ACCOUNT", accNum);
					}
					if (ScenarioContext.Current.ContainsKey("POLICY") == false)
					{
						ScenarioContext.Current.Add("POLICY", policyNum);
					}
					break;
				default:
					accNum = targetAccount;
					break;
			}

			if (ScenarioContext.Current.ContainsKey("ACCOUNT") == true)
			{
				if (ScenarioContext.Current["ACCOUNT"].ToString() != accNum)
				{
					ScenarioContext.Current["ACCOUNT"] = accNum;
				}
			}
			else
			{
				ScenarioContext.Current.Add("ACCOUNT", accNum);
			}
			NewTransferWizard searchTargetAccounts = new NewTransferWizard(getDriver());
			searchTargetAccounts.SearchTargetAccountAndEnterAmount(accNum, targetAmount);
			searchTargetAccounts.FinishTransferfunds();

        }
		[Then(@"I verify Account Fund Transfer for (.*) and (.*)")]
		[When(@"I verify Account Fund Transfer for (.*)and (.*)")]
		public void WhenIVerifyAccountFundTransferForAnd(string targetAccount, string targetAmount)
		{
			DataStorage temp = new DataStorage();

			string accNum = null;
			switch (targetAccount.ToUpper().Trim())
			{
				case "REGISTRY":
					accNum = temp.GetTempValue("ACCNO");
					string policyNum = temp.GetTempValue("PLCYNO");

					if (ScenarioContext.Current.ContainsKey("ACCOUNT") == false)
					{
						ScenarioContext.Current.Add("ACCOUNT", accNum);
					}
					if (ScenarioContext.Current.ContainsKey("POLICY") == false)
					{
						ScenarioContext.Current.Add("POLICY", policyNum);
					}
					break;
				default:
					accNum = targetAccount;
					break;
			}

			if (ScenarioContext.Current.ContainsKey("ACCOUNT") == true)
			{
				if (ScenarioContext.Current["ACCOUNT"].ToString() != accNum)
				{
					ScenarioContext.Current["ACCOUNT"] = accNum;
				}
			}
			else
			{
				ScenarioContext.Current.Add("ACCOUNT", accNum);
			}
			BCHistory VerifyAccountFundsTransfer = new BCHistory(getDriver());
			VerifyAccountFundsTransfer.VerifyAccountFundTransfer(accNum, targetAmount);
		}

		[When(@"I perform move to Account, (.*)")]
		public void WhenIPerformMoveToAccount(string MovingAccount)
		{
			DataStorage temp = new DataStorage();

			string accNum = null;
			switch (MovingAccount.ToUpper().Trim())
			{
				case "REGISTRY":
					accNum = temp.GetTempValue("ACCNO");
					string policyNum = temp.GetTempValue("PLCYNO");

					if (ScenarioContext.Current.ContainsKey("ACCOUNT") == false)
					{
						ScenarioContext.Current.Add("ACCOUNT", accNum);
					}
					if (ScenarioContext.Current.ContainsKey("POLICY") == false)
					{
						ScenarioContext.Current.Add("POLICY", policyNum);
					}
					break;
				default:
					accNum = MovingAccount;
					break;
			}

			if (ScenarioContext.Current.ContainsKey("ACCOUNT") == true)
			{
				if (ScenarioContext.Current["ACCOUNT"].ToString() != accNum)
				{
					ScenarioContext.Current["ACCOUNT"] = accNum;
				}
			}
			else
			{
				ScenarioContext.Current.Add("ACCOUNT", accNum);
			}
			Payments payments = new Payments(getDriver());
			payments.MoveToAccount(accNum);
		}

		[Then(@"I verify move payments for (.*) and (.*)")]
		public void ThenIVerifyMovePaymentsForAnd(string targetAccount, string targetAmount)
		{
			DataStorage temp = new DataStorage();

			string accNum = null;
			switch (targetAccount.ToUpper().Trim())
			{
				case "REGISTRY":
					accNum = temp.GetTempValue("ACCNO");
					string policyNum = temp.GetTempValue("PLCYNO");

					if (ScenarioContext.Current.ContainsKey("ACCOUNT") == false)
					{
						ScenarioContext.Current.Add("ACCOUNT", accNum);
					}
					if (ScenarioContext.Current.ContainsKey("POLICY") == false)
					{
						ScenarioContext.Current.Add("POLICY", policyNum);
					}
					break;
				default:
					accNum = targetAccount;
					break;
			}

			if (ScenarioContext.Current.ContainsKey("ACCOUNT") == true)
			{
				if (ScenarioContext.Current["ACCOUNT"].ToString() != accNum)
				{
					ScenarioContext.Current["ACCOUNT"] = accNum;
				}
			}
			else
			{
				ScenarioContext.Current.Add("ACCOUNT", accNum);
			}
			BCHistory VerifyMovePaymentsTransfer = new BCHistory(getDriver());
			VerifyMovePaymentsTransfer.VerifyMovePayments(accNum, targetAmount);
		}

		[Given(@"I select (.*) from left navigation menu for smoketest")]
        [Then(@"I select (.*) from left navigation menu for smoketest")]
        [When(@"I select (.*) from left navigation menu for smoketest")]
        public void WhenISelectFromLeftNavigationMenuForSmoketest(string leftNavMenu)
        {
            if ((leftNavMenu == "new payment:Payment Request") || (leftNavMenu == "payment wallet") || (leftNavMenu == "Payments:Payment History"))
            {
                switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
                {
                    case "stage":
                        BCHomePage bCHomePage = new BCHomePage(getDriver());
                        bCHomePage.selectLeftNavMenu(leftNavMenu);
                        break;
                    default:
                        break;

                }
            }
            else
            {
                BCHomePage bCHomePage = new BCHomePage(getDriver());
                bCHomePage.selectLeftNavMenu(leftNavMenu);
            }
        }

        [Given(@"I remove the stored payment methods for smoketest")]
        [When(@"I remove the stored payment methods for smoketest")]
        public void WhenIRemoveTheStoredPaymentMethodsForSmoketest()
        {
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    PaymentWallet pmtWallet = new PaymentWallet(getDriver());
                    pmtWallet.removeExistingPaymentTypes();
                    break;
                case "default":

                    break;
            }
        }

        [Then(@"I verify (.*) payment methods for smoketest")]
        public void ThenIVerifyPaymentMethodsForSmoketest(string PaymentMethod)
        {
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    PaymentHistory pmtHistory = new PaymentHistory(getDriver());
                    pmtHistory.verifyPayments(PaymentMethod);
                    break;
                case "default":

                    break;
            }
        }
		[When(@"I perform payment reversals for all transactions")]
		[Then(@"I perform payment reversals for all transactions")]
		public void ThenIPerformPaymentReversalsForAllTransactions()
		{
			switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
			{
				case "stage":
                case "qa2":
					Payments payments = new Payments(getDriver());
					payments.ReverserAllPayments();
					break;
				case "default":

					break;
			}
		}

        [When(@"Verify there is no (.*) fee")]
        public void WhenVerifyThereIsNoSuchKindOfFee(string feeType)
        {
            Charges charges = new Charges(getDriver());
            string amount = charges.getAmount(feeType);
            System.Console.WriteLine("amount: " + amount);
            if (!amount.Equals(""))
            {
                Assert.Fail("There shoud be no " + feeType + " fee, but now it is " + amount + " charged.");
            }
        }

        [When(@"I select (.*) from actions menu under Desktop tab")]
        public void WhenISelectFromActionsMenuUnderDesktopTab(string menuOption)
        {
              BCHomePage bCHomePage = new BCHomePage(getDriver());
              bCHomePage.SelectFromActionMenuUnderDesktopTab(menuOption);
        }

         [When(@"I Enter Payment information on Multiple Payment Entry Information page")]
         public void WhenIEnterPaymentInformationOnMultiplePaymentEntryInformationPage(Table table)
         {
             string accountNum = table.Rows[0]["AccountNum"];
             string paymentInstrument = table.Rows[0]["PaymentInstrument"];
             string checkNum = table.Rows[0]["CheckNum"];
             string amount = table.Rows[0]["Amount"];
             MultiPaymentEntryInfo multiPaymentEnterInfo = new MultiPaymentEntryInfo(getDriver());     
             multiPaymentEnterInfo.EnterPaymentInfo(accountNum, paymentInstrument, checkNum, amount);          
        }

        [When(@"I click Next on Multiple Payment Entry Information page")]
        public void WhenIClickNextOnMultiplePaymentEntryInformationPage()
        {
            MultiPaymentEntryInfo multiPaymentEnterInfo = new MultiPaymentEntryInfo(getDriver());
            multiPaymentEnterInfo.ClickNext();
        }

        [When(@"I click Finish on Multiple Payment Entry Confirm page")]
        public void WhenIClickFinishOnMultiplePaymentEntryConfirmPage()
        {
            MultiPaymentEntryConfirm multiPaymentEnterConfirm = new MultiPaymentEntryConfirm(getDriver());
            multiPaymentEnterConfirm.ClickFinish();
        }

        [When(@"I select action on Account Details page in BC")]
        public void WhenISelectActionOnAccountDetailsPageInBC(Table table)
        {
            string actionType = table.Rows[0]["Action"];
            BCDetails bcDetals = new BCDetails(getDriver());
            bcDetals.SelectActionInRecentPaymentSection(actionType);
        }

        [When(@"I select reason on Confirm Payment Reversal page in BC")]
        public void WhenISelectReasonOnConfirmPaymentReversalPageInBC(Table table)
        {
            string reasonType = table.Rows[0]["Reason"];
            BCConfirmReversePayment bcConfirmReversePayment = new BCConfirmReversePayment(getDriver());
            bcConfirmReversePayment.SelectConfirmReversePaymentReason(reasonType);
        }

        [When(@"I click OK on Confirm Payment Reversal page in BC")]
        public void WhenIClickOKOnConfirmPaymentReversalPageInBC()
        {
            BCConfirmReversePayment bcConfirmReversePayment = new BCConfirmReversePayment(getDriver());
            bcConfirmReversePayment.ClickOK();
        }

        [When(@"Verify the (.*) fee is (.*)")]
        public void WhenVerifyTheFeeForSuchType(string feeType, string fee)
        {
            Charges charges = new Charges(getDriver());
            string amount = charges.getAmount(feeType);
            System.Console.WriteLine("The Amount of Changes is: " + amount);
            if (!amount.Equals(fee))
            {
                Assert.Fail("There shoud be " + fee+ " charge for " +feeType + ", but now it is " + amount + " charged.");
            }
        }

        [When(@"I click on search button under New Document tab")]
        public void WhenIClickOnSearchButtonUnderNewDocumentTab()
        {
            NewDocument newDocument = new NewDocument(getDriver());
            newDocument.GetSearchResults();
        }

        [When(@"select Payment Schedule from list of documents under New Document tab")]
        public void WhenSelectPaymentScheduleFromListOfDocumentsUnderNewDocumentTab()
        {
            NewDocument newDocument = new NewDocument(getDriver());
            newDocument.SelectPaymentSchedule();
        }

        [When(@"I click Create Document button under New Document tab")]
        public void WhenIClickCreateDocumentButtonUnderNewDocumentTab()
        {
            NewDocument newDocument = new NewDocument(getDriver());
            newDocument.ClickCreateDocumentButton();
        }


        [When(@"I click Sumbit Document button under New Document tab")]
        public void WhenISumbitDocumentButtonUnderNewDocumentTab()
        {
            NewDocument newDocument = new NewDocument(getDriver());
            newDocument.SelectPaymentSchedule();
        }

        [When(@"I select (.*) from list of document type names")]
        public void WhenISelectOtherBillingFromListOfDocumentTypeNames(string documentType)
        {
            Documents documents = new Documents(getDriver());
            documents.SearchDocumentType(documentType);
        }

        [When(@"I click on Search button on Document page in BC")]
        public void WhenIClickOnSearchButtonOnDocumentPageInBC()
        {
            Documents documents = new Documents(getDriver());
            documents.ClickSearchButton();
        }

        [When(@"Verify the (.*) document is generated")]
        public void WhenVerifyThePaymentScheduleDocumentIsGenerated(string documentType)
        {
            Documents documents = new Documents(getDriver());
            documents.VerifyDocumentGenerated(documentType);
        }

        [When(@"I navigate (.*) from the Account Tab menu of BC")]
        public void WhenINavigateFromTheAccountTabMenuOfBC(string accountNumber)
        {
            BCHomePage BCNavigationtoAccount = new BCHomePage(getDriver());
            BCNavigationtoAccount.NavigateAccount(accountNumber);
        }


    }

}


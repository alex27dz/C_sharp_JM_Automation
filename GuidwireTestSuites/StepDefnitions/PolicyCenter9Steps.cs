using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TechTalk.SpecFlow;
using System.IO;
using GuidewireTestSuites.UIScreenMapping;
using TechTalk.SpecFlow.Assist;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using PolicyCenter9Pages.Pages.Common;
using PolicyCenter9Pages.Pages.CreateAccount;
using PolicyCenter9Pages.Pages.Transaction;
using BillingCenterPages.Pages.Common;
using PolicyCenter9Pages.Pages.Search;
using PolicyCenter9Pages.Pages.Risk_Analysis;
using PolicyCenter9Pages.Pages.NewSubmission;
using ClaimCenter9Pages.Pages.Common;
using PolicyCenter9Pages.Pages.JPA;
using PolicyCenter9Pages.Pages.Payment;
using PolicyCenterPages.Pages.Administration;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class PolicyCenter9Steps : WebCommonCore.TestBase
    {

        [When(@"I enter (.*) and (.*) on the PC9 Login page")]
        [Given(@"I enter (.*) and (.*) on the PC9 Login page")]
        public void IEnterAndOnThePC9LoginPage(string userName, string passWord)
        {
            BCLoginPage Login = new BCLoginPage(getDriver());
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
			Login.LoginIntoBC(userName, passWord);
		}


        [When(@"I select (.*) from the (.*) Tab menu of PC9")]
        public void WhenISelectAccountFromTheSearchTabMenuOfPC(string TabMenuItem, string TabName)
        {
            HomePage_PC9 searchAccounts = new HomePage_PC9(getDriver());
            searchAccounts.NavigateTabBar(TabName, TabMenuItem);

        }

        [When(@"I search for Policy with (.*) and select from search results in PC9")]
        public void WhenISearchForPolicyWithAndSelectFromSearchResultsInPC(string policyNumber)
        {
            DataStorage temp = new DataStorage();

            string policyNum = null;
            switch (policyNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    policyNum = temp.GetTempValue("PLCYNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    policyNum = UFTRegKey.GetValue("PLCYNO").ToString();
                    break;
                default:
                    policyNum = policyNumber;
                    break;
            }
            PCSearchAccounts_PC9 searchAccounts = new PCSearchAccounts_PC9(getDriver());

            searchAccounts.SearchPolicy(policyNum);
            searchAccounts.SelectPolicy();
        }




        [When(@"I click on PolicyNo of Account detail screen in PC9")]
        public void WhenIClickOnPolicyNoOfAccountDetailScreenInPC9()
        {
            HomePage_PC9 ClickPolicy = new HomePage_PC9(getDriver());
            ClickPolicy.ClickPolicy();
        }


        [When(@"I select (.*) from actions menu of Policy Cenetrin PC9")]
        public void WhenISelectFromActionsMenuOfPolicyCenetrinPC9(string option)
        {
            HomePage_PC9 PCHomePage = new HomePage_PC9(getDriver());
            PCHomePage.SelectActionMenuForWorkOrder(option);
        }

        [When(@"I start Cancel policy on Prorata basis with below details in PC9")]
        public void WhenIStartCancelPolicyOnProrataBasisWithBelowDetailsInPC9(Table table)
        {
            string sSource = table.Rows[0]["Source"];
            string sReason = table.Rows[0]["Reason"];
            string sReasonMethod = table.Rows[0]["ReasonMethod"];
            string sCancelEffDt = table.Rows[0]["CancelEffDate"];
            PolicyStartCancel_PC9 clPolicyStartCancel = new PolicyStartCancel_PC9(getDriver());
            clPolicyStartCancel.EnterPolicyCancelDetailsPC9(sSource, sReason, sReasonMethod, sCancelEffDt);
            System.Threading.Thread.Sleep(3000);
            clPolicyStartCancel.ClickStartCancellationPC9();
        }


        [When(@"I enter following details in PC9 on create account page (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void IEnterFollowingDetailsInPC9OnCreateAccountPage(string DOB, string maritalStatus, string primaryPhone, string homePhone, string workPhone, string mobilePhone, string otherPhone, string faxPhone, string primaryEmail, string secondaryEmail, string gender, string occupation, string investigations)
        {
            CreateAccount_PC9 creatPLAcc = new CreateAccount_PC9(getDriver());
            creatPLAcc.EnterPLAccountDetails(DOB, maritalStatus, primaryPhone, homePhone, workPhone, mobilePhone, otherPhone, faxPhone, primaryEmail, secondaryEmail, gender, occupation, investigations);
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "EMAIL", primaryEmail);
        }



        [When(@"I enter Address details in PC9 on the create account page (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*), (.*)")]
        public void IEnterAddressDetailsinPC9OnTheCreateAccountPage(string careOf, string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country, string addressType, string description, string producercode)
        {
            CreateAccount_PC9 creatPLAcc = new CreateAccount_PC9(getDriver());
            creatPLAcc.EnterPLAddressDetails(careOf, addressLine1, addressLine2, city, state, zipCode, county, country, addressType, description, producercode);
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "BASE_STATE", state);
            tempData.StoreTempValue("guidewire", "ZIPCODE", zipCode);
        }

        [When(@"I enter official id details  in PC9 on the create account page (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterOfficialIdDetailsinPC(string SSN, string isAccountAJeweler, string distributionSource, string preferredMethodOfCommunication, string paperlessDelivery, string okToSurvey, string markettingMaterials, string recieveConfirmationEmails, string jewelerID)
        {
            CreateAccount_PC9 creatPLAcc = new CreateAccount_PC9(getDriver());
            creatPLAcc.EnterPLOfficialIDDetails(SSN, isAccountAJeweler, distributionSource, preferredMethodOfCommunication, paperlessDelivery, okToSurvey, markettingMaterials, recieveConfirmationEmails, jewelerID);
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());

        }



        [When(@"I click ok on OOS Policy Change in PC(.*)")]
        public void WhenIClickOkOnOOSPolicyChangeInPC(int p0)
        {
            PolicyChange_PC9 PCChanges = new PolicyChange_PC9(base.getDriver());
            PCChanges.updatePOlicyCHangeOOS();
        }


        [When(@"I Start Policy Change in PC9 with (.*) and (.*)")]
        public void IStartPolicyChangeInPC9WithAnd(string EffectiveDate, string ChangeReason)
        {
            DataStorage temp = new DataStorage();
            switch (EffectiveDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    EffectiveDate = temp.GetTempValue("EFFDATE");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    EffectiveDate = UFTRegKey.GetValue("EFFDATE").ToString();
                    break;
                default:

                    break;
            }

            PolicyChange_PC9 PCChanges = new PolicyChange_PC9(base.getDriver());
            PCChanges.updatePOlicyCHange(EffectiveDate, ChangeReason);
        }

        [When(@"I get Policynumber, LastName and zipcode from summary Page in PC(.*)")]
        public void WhenIGetPolicynumberLastNameAndZipcodeFromSummaryPageInPC(int p0)
        {
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            PCDetailsPage.getDetailsforQuickClaim();
        }

        [When(@"search for account number and select from search results in PC9")]
        public void WhenSearchForAccountNumberAndSelectFromSearchResultsInPC()
        {
            PCSearchAccounts_PC9 searchAccountsPage = new PCSearchAccounts_PC9(getDriver());
            searchAccountsPage.SearchAccount(ScenarioContext.Current["AccountNumber"].ToString());
            searchAccountsPage.SelectAccount();
        }

        [When(@"search for account with (.*) and select from search results in PC9")]
        public void WhenSearchForAccountWithREGISTRYAndSelectFromSearchResultsInPC(string accountNumber)
        {
            DataStorage temp = new DataStorage();
            string accNum = null;
            switch (accountNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    accNum = temp.GetTempValue("ACCNO");
                    break;
                default:
                    accNum = accountNumber;
                    break;
            }
            PCSearchAccounts_PC9 searchAccounts = new PCSearchAccounts_PC9(getDriver());
            searchAccounts.SearchAccount(accNum);
            searchAccounts.SelectAccount();
        }

        //[When(@"I search for submission with (.*) and select from search results in PC9")]
        //public void WhenISearchForSubmissionWithAndSelectFromSearchResultsInPC(string submissionNumber)
        //{
        //    DataStorage temp = new DataStorage();
        //    string accNum = null;
        //    switch (accountNumber.ToUpper().Trim())
        //    {
        //        case "REGISTRY":
        //            accNum = temp.GetTempValue("ACCNO");
        //            break;
        //        default:
        //            accNum = accountNumber;
        //            break;
        //    }
        //    PCSearchAccounts_PC9 searchAccounts = new PCSearchAccounts_PC9(getDriver());
        //    searchAccounts.SearchAccount(accNum);
        //    searchAccounts.SelectAccount();
        //}


        [Then(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*), (.*)  in Left Account Details page for PC9")]
        [When(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*), (.*)  in Left Account Details page for PC9")]
        public void WhenIVerifyMaleInLeftAccountDetailsPageForPC(string PrimaryInsured, string Address, string PhonNo, string Email, string Status, string AddressType, string Gender, string Occupation, string DateofBirth)
        {
            DataStorage temp = new DataStorage();
            string PriInsured = null;
            string Addr = null;
            string Phone = null;
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
                    Addr = temp.GetTempValue("ACC_ADDRESS");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Addr = UFTRegKey.GetValue("ACC_ADDRESS").ToString();
                    break;
                default:
                    Addr = Address;
                    break;
            }

            switch (PhonNo.ToUpper().Trim())
            {
                case "REGISTRY":
                    Phone = temp.GetTempValue("PHONE");
                    break;
               default:
                    Phone = PhonNo;
                    break;
            }


            switch (Email.ToUpper().Trim())
            {
                case "UNIQUE":
                case "REGISTRY":
                    Email = temp.GetTempValue("EMAIL");
                    break;
                default:
                    Email = Email;
                    break;
            }

            Console.WriteLine("Reg Values: {0},{1},{2},{3},{4}", PriInsured, Address, Phone, Email, Status);
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            PCDetailsPage.VerifyLeftAccountDetails(PriInsured, Addr, Phone, Email, Status, AddressType, Gender, Occupation, DateofBirth);

        }

        [Then(@"I verify (.*) for Express Partners")]
        public void IVerifyForExpressPartners(string Id)
        {
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            PCDetailsPage.VerfiyJwelerID(Id);
        }


        [When(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) in Right Account Details page for PC9 for QNA Account")]
        [Then(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) in Right Account Details page for PC9 for QNA Account")]
        public void IVerifyAgencyExpressEmailYesZInRightAccountDetailsPageForPCForQNAAccount(string DistributionSource, string MethodofCommunication, string ApplicationTakenBy, string Paperless, string ProducerCode)
        {
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            DataStorage temp = new DataStorage();
            switch (ProducerCode.ToUpper().Trim())
            {
                case "REGISTRY":
                    ProducerCode = temp.GetTempValue("PRODUCERCODE");
                    break;


            }
            PCDetailsPage.VerifyRightAccountDetailsQNA(DistributionSource, MethodofCommunication, ApplicationTakenBy, Paperless, ProducerCode);

        }

        //[When(@"I verify (.*) in PC9")]
        //public void WhenIVerifyInPC(string Activities)
        //{
        //    PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
        //    PCDetailsPage.verifyActivityInSummary(Activities);
        //}

        [When(@"I verify Activity (.*) in PC9")]
        public void WhenIVerifyActivityInPC(string Activities)
        {
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            PCDetailsPage.verifyActivityInSummary(Activities);

        }

        [When(@"I verfy (.*) , (.*) in Policy Term  for WorkOrders in PC9")]
        public void IVerfyInPolicyTermForWorkOrdersInPC9(string Status, string EffectiveDate)
        {
            DataStorage temp = new DataStorage();
            string PolicyStatus = null;
            string PolicyEffectiveDate = null;

            switch (Status.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyStatus = temp.GetTempValue("Status");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyStatus = UFTRegKey.GetValue("Status").ToString();
                    break;
                default:
                    PolicyStatus = Status;
                    break;
            }

            switch (EffectiveDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyEffectiveDate = temp.GetTempValue("EFFDATE");
                    Console.WriteLine("Effective date is " + PolicyEffectiveDate);
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyEffectiveDate = UFTRegKey.GetValue("EffectiveDate").ToString();
                    break;
                default:
                    PolicyEffectiveDate = EffectiveDate;
                    break;
            }
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            PCDetailsPage.VerifyQuoteTerm(PolicyStatus, PolicyEffectiveDate);
        }

        [When(@"I verify the payment plan")]
        public void WhenIVerifyThePaymentPlan()
        {
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            DataStorage temp = new DataStorage();
            string policyNo = temp.GetTempValue("PLCYNO");
            Console.WriteLine(policyNo);
            PCDetailsPage.verifyPaymentPlan(policyNo);
        }

        [When(@"I verfy  (.*) , (.*) , (.*) in Policy Term  for PC9")]
        [Then(@"I verfy  (.*) , (.*) , (.*) in Policy Term  for PC9")]
        public void IVerfyInForceREGISTRYInPolicyTermForPC(string PolicyNumber, string Status, string EffectiveDate)
        {
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            DataStorage temp = new DataStorage();
            string Policyno = null;
            string PolicyStatus = null;
            string PolicyEffectiveDate = null;
            switch (PolicyNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    Policyno = temp.GetTempValue("PLCYNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Policyno = UFTRegKey.GetValue("PolicyNumber").ToString();
                    break;
                default:
                    Policyno = PolicyNumber;
                    break;
            }

            switch (Status.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyStatus = temp.GetTempValue("Status");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyStatus = UFTRegKey.GetValue("Status").ToString();
                    break;
                default:
                    PolicyStatus = Status;
                    break;
            }

            switch (EffectiveDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyEffectiveDate = temp.GetTempValue("EFFDATE");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyEffectiveDate = UFTRegKey.GetValue("EFFDATE").ToString();
                    break;
                default:
                    PolicyEffectiveDate = EffectiveDate;
                    break;
            }
            PCDetailsPage.VerifyPolicyTerm(Policyno, PolicyStatus, PolicyEffectiveDate);

        }

        [When(@"I logout of the PC9 application")]
        [Then(@"I logout of the PC9 application")]
        public void ILogoutOfThePC9Application()
        {
            BCHomePage bCHomePage = new BCHomePage(getDriver());

            bCHomePage.LogoutOfBC();
        }


        [When(@"I click workorder number of Account detail screen in PC9")]
        public void IClickWorkorderNumberOfAccountDetailScreenInPC9()
        {
            PCDetails_PC9 PCDetailsPage = new PCDetails_PC9(getDriver());
            PCDetailsPage.SelectWorkOrderNumber();
        }

        [When(@"I click on (.*) on Left NavMenu Screen in PC9")]
        public void IClickOnOnLeftNavMenuScreenInPC9(string leftNavMenu)
        {
            HomePage_PC9 PCNavigation = new HomePage_PC9(getDriver());
            PCNavigation.selectLeftNavMenu(leftNavMenu);
        }

        [When(@"I special approve all underwriting rules on the Risk Analysis tab in PC9")]
        public void WhenISpecialApproveAllUnderwritingRulesOnTheRiskAnalysisTabInPC()
        {
            RiskAnalysis_PC9 riskAnalysisPage = new RiskAnalysis_PC9(getDriver());
            riskAnalysisPage.SpecialApproveAllUWRules();
        }

        [When(@"I click the release lock on the Risk Analysis tab in PC9")]
        public void WhenIClickTheReleaseLockOnTheRiskAnalysisTabInPC()
        {
            RiskAnalysis_PC9 riskAnalysisPage = new RiskAnalysis_PC9(getDriver());
            riskAnalysisPage.ClickReleaseLockButton();
        }

        [Then(@"I verify (.*) in the Risk Analysis screen in PC9")]
        [When(@"I verify (.*) in the Risk Analysis screen in PC9")]
        public void IVerifyInTheRiskAnalysisScreenInPC(string activities)
        {
            RiskAnalysis_PC9 PCRiskPage = new RiskAnalysis_PC9(getDriver());
            string actualVal = PCRiskPage.VerifyActivities();
            string coampre_flag = "";
            string actual_value_temp = actualVal;
            if (activities.Contains(";"))
            {
                int expect_counter = 1;
                int Actual_counter = 1;
                char[] delimiterChars = { ';' };
                string[] Expectedactivity = activities.Split(delimiterChars);
                string[] actualactivity = actualVal.Split(delimiterChars);
                foreach (string expected in Expectedactivity)
                {
                    Console.WriteLine(expect_counter + " expected value " + expected);
                    coampre_flag = "false";
                    foreach (string actual in actualactivity)
                    {
                        Console.WriteLine(Actual_counter + " actual value " + actual);
                        if (actual.ToLower().Trim().Contains(expected.ToLower().Trim()))
                        {
                            coampre_flag = "true";
                            actual_value_temp = actual;
                            break;
                        }
                        Actual_counter = Actual_counter + 1;
                    }
                    if (string.Equals(coampre_flag, "true"))
                    {
                        Console.WriteLine("expected value match " + expected.ToLower() + "actual value is " + actual_value_temp.ToLower());
                    }
                    else
                    {
                        Console.WriteLine("expected value do not match " + expected.ToLower() + "actual value is " + actual_value_temp.ToLower());
                        Assert.AreEqual(expected.ToLower(), actualVal.ToLower());
                    }
                    Actual_counter = 0;
                    expect_counter = expect_counter + 1;
                }
            }
            else
            {
                if (actualVal.ToLower().Contains(activities.ToLower()))
                {
                    Console.WriteLine("Activities matches expected value is " + activities.ToLower() + "actual value is " + activities.ToLower());
                }
                else
                {
                    Console.WriteLine("Activities do not matches expected value is " + activities.ToLower() + "actual value is " + actualVal.ToLower());
                    Assert.AreEqual(activities.ToLower(), actual_value_temp.ToLower());
                }
            }

        }

        [When(@"I verify  (.*) in GW policy Center in Pc9")]
        public void WhenIVerifyInGWPolicyCenterInPc(string CreditConsent)
        {
            Contacts_PC9 PCContacts = new Contacts_PC9(getDriver());
            PCContacts.VerifyCreditConsent(CreditConsent);
        }

        [Given(@"I enter (.*) and (.*) on the Login page in PC9")]
        [When(@"I enter (.*) and (.*) on the Login page in PC9")]
        [Then(@"I enter (.*) and (.*) on the Login page in PC9")]
		public void GivenIEnterSuAndUpOnTheLoginPageFinPC9(string userName, string passWord)
		{
			LoginPage_PC9 loginPg = new LoginPage_PC9(getDriver());
			userName = System.Configuration.ConfigurationManager.AppSettings[userName];
			passWord = System.Configuration.ConfigurationManager.AppSettings[passWord];
			if (userName.ToString() == string.Empty)
			{
				Assert.Fail("UserName can't be empty or null");
			}
			else
			{
				if (ScenarioContext.Current.ContainsKey("GWPCUSER") == false)
				{
					ScenarioContext.Current.Add("GWPCUSER", userName);
				}
				else
				{
					if (ScenarioContext.Current["GWPCUSER"].ToString() != userName)
					{
						ScenarioContext.Current["GWPCUSER"] = userName;
					}
				}
			}
			loginPg.EnterLoginDetailsPC9(userName, passWord);
		}

        [Given(@"I get the system date in PC9")]
        [When(@"I get the system date in PC9")]
        public void GivenIGetTheSystemDateInPC9()
        {
            AdminTools_PC9 adminToolsPage = new AdminTools_PC9(getDriver());
            adminToolsPage.getPC9SystemDate();
            Console.WriteLine(ScenarioContext.Current["SYSTEMDATE"].ToString());
            DateTime tempDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
            string currSysDate = tempDate.ToString("MM/dd/yyyy");
            Console.WriteLine("currSysDate is " + currSysDate);
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "TESTINGSYSTEMCLOCK", currSysDate);
        }

        [Given(@"I manage Transport with below status")]
        [When(@"I manage Transport with below status")]
        public void WhenIManageTransportWithBelowStatus(Table table)
        {
            AdminPage_PC9 adminPage = new AdminPage_PC9(getDriver());
            adminPage.ManagePC9Trasport(table.Rows[0]["Status"]);
        }
        [Given(@"I verify below payload")]
        [When(@"I verify below payload")]
        [Then(@"I verify below payload")]
        public void WhenIVerifyBelowPayload(Table table)
        {
            AdminPage_PC9 adminPage = new AdminPage_PC9(getDriver());
            adminPage.verifyPayload(table.Rows[0]["Type"]);
        }

        [When(@"I select below Action type from Actions menu")]
        public void WhenISelectBelowActionTypeFromActionsMenu(Table table)
        {
            HomePage_PC9 homePage = new HomePage_PC9(getDriver());
            homePage.SelectActionMenuPC9(table.Rows[0]["ActionType"]);
        }


        [When(@"I search for personal account in PC9 using (.*) and (.*)")]
        public void ISearchForPersonalAccountInPC9UsingAnd(string FirstName, string LastName)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            switch (FirstName.ToUpper().Trim())
            {
                case "UNIQUE":
                    FirstName = Unique.ID;
                    FirstName = FirstName.Substring(1, 10);
                    break;
            }

            switch (LastName.ToUpper().Trim())
            {
                case "UNIQUE":
                    LastName = Unique.ID;
                    LastName = LastName.Substring(1, 10);
                    break;
            }
            RegKey.SetValue("LNAME", LastName);
            RegKey.SetValue("FNAME", FirstName);
            EnterAccountInformation_PC9 searchAcc = new EnterAccountInformation_PC9(getDriver());
            searchAcc.SearchPersonalDetail(FirstName, LastName);
        }



        [When(@"I search for commercial account with below company name in PC9")]
        public void WhenISearchForCommercialAccountWithBelowCompanyNameInPC9(Table table)
        {
            string CompanyName = table.Rows[0]["CompanyName"];
			CL_CreateAccount_PC9 searchAcc = new CL_CreateAccount_PC9(getDriver());
			searchAcc.SearchCompany(CompanyName);
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "COMPNAME", CompanyName);
        }


        [When(@"I enter following mandatory details on create account page for Personal lines in PC9")]
        public void WhenIEnterFollowingMandatoryDetailsOnCreateAccountPageForPersonalLinesInPC9(Table table)
        {
            CreateAccount_PC9 creatAcc = new CreateAccount_PC9(getDriver());
            creatAcc.EnterPLmandateAccountDetails_ST(table);
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
            tempData.StoreTempValue("guidewire", "EMAIL", ScenarioContext.Current["Email"].ToString());
        }

        [When(@"I click Quote on the policy information page in PC9")]
        public void WhenIClickQuoteOnThePolicyInformationPageInPC()
        {
            PL_PolicyInfo_PC9 plInfoScreen = new PL_PolicyInfo_PC9(getDriver());
            plInfoScreen.ClickQuotebtn();
        }


        [When(@"I enter below details on the policy information page in PC9")]
        public void IEnterBelowDetailsOnThePolicyInformationPageInPC9(Table table)
        {
            string policyTermType = table.Rows[0]["Term"];
            string policyEffDt = table.Rows[0]["PolicyEffDate"];
            string PolicyProducerCode = table.Rows[0]["ProducerCode"];
            PL_PolicyInfo_PC9 plInfoScreen = new PL_PolicyInfo_PC9(getDriver());
            plInfoScreen.EnterPolicyInfoDetailsPC9(policyTermType, policyEffDt, PolicyProducerCode);
            plInfoScreen.EnterPolicyInfoPC9();
        }

        [When(@"I enter below details on the policy information page in PC9 for Policy Rewrite")]
        public void WhenIEnterBelowDetailsOnThePolicyInformationPageInPCForPolicyRewrite(Table table)
        {
            string policyTermType = table.Rows[0]["Term"];
            string policyEffDt = table.Rows[0]["PolicyEffDate"];
            string PolicyProducerCode = table.Rows[0]["ProducerCode"];
            PL_PolicyInfo_PC9 plInfoScreen = new PL_PolicyInfo_PC9(getDriver());
            plInfoScreen.EnterRewritePolicyInfoDetailsPC9(policyTermType, policyEffDt, PolicyProducerCode);
            plInfoScreen.EnterPolicyInfoPC9();
        }

        [When(@"I enter following mandatory details on create account page for commercial lines for ST in PC9")]
        public void WhenIEnterFollowingMandatoryDetailsOnCreateAccountPageForCommercialLinesForSTInPC9(Table table)
        {
            CreateAccount_PC9 creatAcc = new CreateAccount_PC9(getDriver());
            creatAcc.EnterCLmandateAccountDetails_ST(table);
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
        }


        [When(@"I select (.*) from the Actions menu in PC9")]
        public void WhenISelectNewSubmissionFromTheActionsMenuInPC(string menuItem)
        {
            HomePage_PC9 homePage = new HomePage_PC9(getDriver());
            homePage.SelectActionMenuPC9(menuItem);
        }

        [When(@"I enter (.*) and (.*) on the New Submission page in PC9")]
        public void WhenIEnterSYSTEMDATEAndOnTheNewSubmissionPageInPC(string policyEffDate, string product)
        {
            NewSubmissions_PC9 startNew = new NewSubmissions_PC9(getDriver());
            startNew.StartNewSubmissionPC9(policyEffDate, product);
        }

        [When(@"I enter (.*) , (.*) , (.*) for questions on qualification page in PC9")]
        public void WhenIEnterNoNoNoForQuestionsOnQualificationPageInPC(string professionalAthelete, string previousLoss, string convictedOfCrime)
        {
            PL_Qualification_PC9 plQualification = new PL_Qualification_PC9(getDriver());
            plQualification.selectPLQualitificationsPC9(professionalAthelete, previousLoss, convictedOfCrime);
        }


        [When(@"I add below Additional Insured details with unique name in PC9")]
        public void WhenIAddBelowAdditionalInsuredDetailsWithUniqueNameInPC9(Table table)
        {
            PL_AddAdditionalInsured plAddAI = new PL_AddAdditionalInsured(getDriver());
            plAddAI.AddAdditionalInsured(table);
        }


        [When(@"I enter the details on the policy information page in PC9")]
        public void IEnterTheDetailsOnThePolicyInformationPageInPC9()
        {
            PL_PolicyInfo_PC9 plInfoScreen = new PL_PolicyInfo_PC9(getDriver());
            plInfoScreen.EnterPolicyInfoPC9();
        }

        [When(@"I Add Jewelry item in PC9 with (.*) , (.*) , (.*) , (.*)")]
        public void IAddJewelryItemInPC9With(string LocatedWith, string Class, string ValueOfItem, string Deductible)
        {
            DataStorage temp = new DataStorage();
            PL_JewelryItems_PC9 plJewelryItems = new PL_JewelryItems_PC9(getDriver());

            switch (LocatedWith.ToUpper().Trim())
            {
                case "REGISTRY":
                    LocatedWith = temp.GetTempValue("FNAME") + " " + temp.GetTempValue("LNAME");
                    break;
            }
            plJewelryItems.AddJewelryIteminPC9(LocatedWith, Class, ValueOfItem, Deductible);
            plJewelryItems.CLickNextonPErsonalJewelryItemPC9();

        }
        [When(@"I click next on the Risk Analysis in PC9")]
        public void WhenIClickNextOnTheRiskAnalysisInPC9()
        {
            PL_RiskAnalysis_PC9 plRiskAnalysis = new PL_RiskAnalysis_PC9(getDriver());
            plRiskAnalysis.CLickNextonReviewPC9();
        }

        [When(@"I click next on the Risk Analysis in PC9 for Renewal")]
        public void WhenIClickNextOnTheRiskAnalysisInPCForRenewal()
        {
            PL_RiskAnalysis_PC9 plRiskAnalysis = new PL_RiskAnalysis_PC9(getDriver());
            plRiskAnalysis.CLickNextonReviewPC9forRenewal();
        }


        [Then(@"I click on Edit Work Order in Personal Jewelry Item screen in PC9")]
        [When(@"I click on Edit Work Order in Personal Jewelry Item screen in PC9")]
        public void IClickOnEditWorkOrderInPersonalJewelryItemScreenInPC9()
        {
            PL_JewelryItems_PC9 plJewelryItems = new PL_JewelryItems_PC9(getDriver());
            plJewelryItems.ClickEditWorkOrderPC9();
            plJewelryItems.CLickNextonPErsonalJewelryItemPC9();
        }


        [Then(@"I Delete Multi Jewelry items for Policy Change in PC9")]
        [When(@"I Delete Multi Jewelry items for Policy Change in PC9")]
        public void IDeleteMultiJewelryItemsForPolicyChangeInPC9(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PL_JewelryItems_PC9 plJewelryItems = new PL_JewelryItems_PC9(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryInactiveFlag = table.Rows[Itemcounter]["InactiveArticle"];
                string InactiveReason = table.Rows[Itemcounter]["InactiveReason"];
                if (JewelryInactiveFlag.ToLower().Equals("yes"))
                {
                    plJewelryItems.MakeJewelryItemInactiveinPC9(InactiveReason, Itemcounter);
                }
                Itemcounter = Itemcounter + 1;
            }
            plJewelryItems.CLickNextonPErsonalJewelryItemPC9();
        }


        [When(@"I Update Multi Jewelry items with Deatils in PC9")]
        public void WhenIUpdateMultiJewelryItemsWithDeatilsInPC(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PL_JewelryItems_PC9 plJewelryItems = new PL_JewelryItems_PC9(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                // var temp = row.Values.ToList();
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string WearerFirstName = table.Rows[Itemcounter]["FirstName"];
                string WearerLastName = table.Rows[Itemcounter]["LastName"];
                string WearerAddressLine1 = table.Rows[Itemcounter]["AddressLine1"];
                string WearerCity = table.Rows[Itemcounter]["City"];
                string WearerState = table.Rows[Itemcounter]["State"];
                string WearerZipCode = table.Rows[Itemcounter]["ZipCode"];
                string JewelryClass = table.Rows[Itemcounter]["Class"];
                string JewelryValueOfItem = table.Rows[Itemcounter]["ValueOfItem"];
                string JewelryDeductible = table.Rows[Itemcounter]["Deductible"];
                string JewelryAppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string JewelryAppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];
                string JewelryBrand = table.Rows[Itemcounter]["Brand"];
                string JewelryItemStored = table.Rows[Itemcounter]["ItemStored"];
                string JewelryStyle = table.Rows[Itemcounter]["Style"];
                plJewelryItems.UpdateMultiJewelryItemDetailsPC9(JewelryLocatedWith, WearerFirstName, WearerLastName, WearerAddressLine1, WearerCity, WearerState, WearerZipCode, JewelryClass, JewelryValueOfItem, JewelryDeductible, JewelryAppraisalReceived, JewelryAppraisalDate, JewelryBrand, JewelryStyle, JewelryItemStored, Itemcounter + 1);
                Itemcounter = Itemcounter + 1;

            }
            plJewelryItems.CLickNextonPErsonalJewelryItemPC9();
        }

        [When(@"I Add Multi Jewelry items in PC9 with Alarm Details")]
        public void WhenIAddMultiJewelryItemsInPCWithAlarmDetails(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PL_JewelryItems_PC9 plJewelryItems = new PL_JewelryItems_PC9(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string JewelryClass = table.Rows[Itemcounter]["Class"];
                string JewelryValueOfItem = table.Rows[Itemcounter]["ValueOfItem"];
                // string JewelryDeductible = Convert.ToInt32(table.Rows[Itemcounter]["Deductible"]);
                string JewelryDeductible = table.Rows[Itemcounter]["Deductible"];
                string JewelryAppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string JewelryAppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];
                string JewelryBrand = table.Rows[Itemcounter]["Brand"];
                string JewelryItemStored = table.Rows[Itemcounter]["ItemStored"];
                string JewelryStyle = table.Rows[Itemcounter]["Style"];

                Console.WriteLine("item counter is " + Itemcounter);
                plJewelryItems.AddMultiJewelryItemwithItemStoredPC9(JewelryLocatedWith, JewelryClass, JewelryValueOfItem, JewelryDeductible, JewelryAppraisalReceived, JewelryAppraisalDate, JewelryBrand, JewelryStyle, JewelryItemStored, Itemcounter);


                //                plJewelryItems.AddMultiJewelryItemPC9(JewelryBrand, JewelryStyle, JewelryItemStored, Itemcounter);


                Itemcounter = Itemcounter + 1;
            }
            if (table.Rows[0]["Alarm"].Length > 1)
            {
                plJewelryItems.UpdateAlarm(table.Rows[0]["Alarm"]);
            }
            plJewelryItems.CLickNextonPErsonalJewelryItemPC9();
        }


        [When(@"In Risk Analysis page I update convications details on the Risk Analysis section in PC9")]
        public void WhenInRiskAnalysisPageIUpdateConvicationsDetailsOnTheRiskAnalysisSectionInPC(Table table)
        {
            RiskAnalysis_PC9 PLRiskAnalysis = new RiskAnalysis_PC9(getDriver());
            PLRiskAnalysis.UpdateConvictionDetailsPC9(table.Rows[0]["ConvictedFelony"], table.Rows[0]["ConvictedMisdemeanor"]);
        }


        [When(@"In Risk Analysis page I update Sentence Completion Details in PC9")]
        public void WhenInRiskAnalysisPageIUpdateSentenceCompletionDetailsInPC(Table table)
        {
            RiskAnalysis_PC9 PLRiskAnalysis = new RiskAnalysis_PC9(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string SentenceCompilationDate = temp[0];
                string ConvictionType = temp[1];
                string OtherConvictionType = temp[2];
                PLRiskAnalysis.UpdateSentenceCompilationDetailsPC9(SentenceCompilationDate, ConvictionType, OtherConvictionType, Itemcounter);
                Itemcounter = Itemcounter + 1;
                Console.WriteLine("Counter Value is " + Itemcounter);
            }
        }

        [When(@"I click Quote on the Policy Review in PC9 for Renewal")]
        public void WhenIClickQuoteOnThePolicyReviewInPCForRenewal()
        {
            PL_PolicyReview_Renewal_PC9 plPolicyReview = new PL_PolicyReview_Renewal_PC9(getDriver());
            plPolicyReview.QuotePolicyRenewal();
        }



        [When(@"I Add Multi Jewelry items in PC9")]
        public void IAddMultiJewelryItemsInPC9(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PL_JewelryItems_PC9 plJewelryItems = new PL_JewelryItems_PC9(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string JewelryClass = table.Rows[Itemcounter]["Class"];
                string JewelryValueOfItem = table.Rows[Itemcounter]["ValueOfItem"];
                // string JewelryDeductible = Convert.ToInt32(table.Rows[Itemcounter]["Deductible"]);
                string JewelryDeductible = table.Rows[Itemcounter]["Deductible"];
                string JewelryAppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string JewelryAppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];

                Console.WriteLine("item counter is " + Itemcounter);
                plJewelryItems.AddMultiJewelryItemPC9(JewelryLocatedWith, JewelryClass, JewelryValueOfItem, JewelryDeductible, JewelryAppraisalReceived, JewelryAppraisalDate, Itemcounter);


                Itemcounter = Itemcounter + 1;
            }
            plJewelryItems.CLickNextonPErsonalJewelryItemPC9();
        }

        [When(@"I click Quote on the Policy Review for JPA in PC9")]
        public void WhenIClickQuoteOnThePolicyReviewForJPAInPC()
        {
            PL_PolicyReview_PC9 plPolicyReview = new PL_PolicyReview_PC9(getDriver());
            plPolicyReview.QuotePolicyJPA();
        }

        [When(@"I decline policy for (.*)")]
        public void WhenIDeclinePolicyFor(string reason)
        {
            PolicyIssuePC9 plDecline = new PolicyIssuePC9(getDriver());
            plDecline.selectDeclineReason(reason);
        }

        [When(@"I click on Decline button")]
        public void WhenIClickOnDeclineButton()
        {
            PolicyIssuePC9 plDecline = new PolicyIssuePC9(getDriver());
            plDecline.clickDeclineButton();
        }

        [Then(@"I verify error message Missing required field (.*) is shown up")]
        public void ThenIVerifyErrorMessageMissingRequiredFieldIsShownUp(string errorMessage)
        {
            PolicyIssuePC9 plDecline = new PolicyIssuePC9(getDriver());
            plDecline.verifyErrorMessage(errorMessage);
        }

        [When(@"I click Quote on the Policy Review in PC(.*)")]
        public void WhenIClickQuoteOnThePolicyReviewInPC(int p0)
        {
            PL_PolicyReview_PC9 plPolicyReview = new PL_PolicyReview_PC9(getDriver());
            plPolicyReview.QuotePolicy();
        }

        [Then(@"I Quote the PL Smoke test policy in PC(.*)")]
        [When(@"I Quote the PL Smoke test policy in PC(.*)")]
        public void WhenIQuoteThePLSmokeTestPolicyInPC(int p0)
        {
            CL_Payment_PC9 plPayment = new CL_Payment_PC9(getDriver());
            plPayment.PLQuotePolicy_ST();
        }


        [Then(@"I Issue the PL Smoke test policy in PC9")]
        [When(@"I Issue the PL Smoke test policy in PC9")]
        public void ThenIIssueThePLSmokeTestPolicyInPC9()
        {
            CL_Payment_PC9 plPayment = new CL_Payment_PC9(getDriver());
            plPayment.PLIssuePolicy_ST();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }


        [When(@"I Issue the changed policy in PC9")]
        [Then(@"I Issue the changed policy in PC9")]
        public void WhenIIssueTheChangedPolicyInPC9()
        {
            PL_Quote_PC9 plQuote = new PL_Quote_PC9(getDriver());
            plQuote.PLIssueChangedPolicy();
        }

        [When(@"I Issue the canceled policy in PC9")]
        [Then(@"I Issue the canceled policy in PC9")]
        public void WhenIIssueTheCanceledPolicyInPC9()
        {
            PL_Quote_PC9 plQuote = new PL_Quote_PC9(getDriver());
            plQuote.PLIssueCanceledPolicy();
        }

        [When(@"I Reinstate the canceled policy in PC9")]
        [Then(@"I Reinstate the canceled policy in PC9")]
        public void IReinstateTheCanceledPolicyInPC9()
        {
            PL_Quote_PC9 plQuote = new PL_Quote_PC9(getDriver());
            plQuote.PLReinstatePolicy();
        }

        [When(@"I Rewrite the canceled policy in PC9")]
        public void WhenIRewriteTheCanceledPolicyInPC()
        {
            PL_Quote_PC9 plQuote = new PL_Quote_PC9(getDriver());
            plQuote.PLRewritePolicy();
        }

        [When(@"I Rewrite the policy in PC9")]
        public void WhenIRewriteThePolicyInPC9()
        {
            PL_Quote_PC9 plQuote = new PL_Quote_PC9(getDriver());
            plQuote.PLRewritePolicy();
        }


        //[When(@"I Renew PL policy in PC9")]
        //public void WhenIRenewPLPolicyInPC9()
        //{
        //    PL_Quote_PC9 plQuote = new PL_Quote_PC9(getDriver());
        //    plQuote.PLIssueRenewPolicy();
        //}

        [When(@"I Renew PL policy in PC9 with below details")]
        [Then(@"I Renew PL policy in PC9 with below details")]
        public void WhenIRenewPLPolicyInPCWithBelowDetails(Table table)
        {
            PL_Quote_PC9 plQuote = new PL_Quote_PC9(getDriver());
            plQuote.PLIssueRenewPolicy((table.Rows[0]["RenewCode"]));
        }



        [When(@"I Issue the policy in PC(.*)")]
        [Then(@"I Issue the policy in PC(.*)")]
        public void ThenIIssueThePolicyInPC(int p0)
        {
            PL_Quote_PC9 plQuote = new PL_Quote_PC9(getDriver());
            plQuote.PLIssuePolicy();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }

        [When(@"I set Reinstate reason in PC9")]
        public void ISetReinstateReasonInPC9(Table table)
        {
            PolicyReinstatement_PC9 PlReinstate = new PolicyReinstatement_PC9(getDriver());
            PlReinstate.setReinstateReason(table.Rows[0]["ReinstatementReason"]);
        }

        [Then(@"I Verify if documents are (.*) in document page of PC9")]
        public void ThenIVerifyIfDocumentsAreInDocumentPageOfPC(int Documentsavailable)
        {
            PolicyDocuments_PC9 PLDocuments = new PolicyDocuments_PC9(base.getDriver());
            PLDocuments.VerifyDocumentsPC9(Documentsavailable);
        }



        [Then(@"I search documents by selecting (.*) , (.*) , (.*)  in document page of PC9")]
        [When(@"I search documents by selecting (.*) , (.*) , (.*)  in document page of PC9")]
        public void WhenISearchDocumentsBySelectingAppraisalInDocumentPageOfPC(string DocumentTypeName, string FromDate, string Todate)
        {
            PolicyDocuments_PC9 PLDocuments = new PolicyDocuments_PC9(base.getDriver());
            PLDocuments.DocumentSearchPC9(DocumentTypeName, FromDate, Todate);
        }


        [When(@"I Click on (.*) link on left navigation bar in PC9")]
        [Then(@"I Click on (.*) link on left navigation bar in PC9")]
        public void IClickOnLinkOnLeftNavigationBarInPC(string option)
        {
            HomePage_PC9 PCHomePage = new HomePage_PC9(getDriver());
            PCHomePage.selectLeftNavMenu(option);

        }

        [Then(@"I verify (.*) in Work Orders page in PC9")]
        public void ThenIVerifyNon_RenewedInWorkOrdersPageInPC(string ExpectedWorkOrderStatus)
        {
            WorkOrder_PC9 WorkOrderPage = new WorkOrder_PC9(getDriver());
            WorkOrderPage.VerifyWorkOrderStatusPC9(ExpectedWorkOrderStatus);
        }



        [When(@"I manage reinsurance in PC9")]
        public void WhenIManageReinsuranceInPC9()
        {
            CLReinsurancePage_PC9 Reinsurance = new CLReinsurancePage_PC9(getDriver());
            Reinsurance.ManageClReinsurance_PC9();
        }



        [Then(@"I Issue PL policy for ST in PC(.*)")]
        public void ThenIIssuePLPolicyForSTInPC(int p0)
        {
            CL_Payment_PC9 clPayment = new CL_Payment_PC9(getDriver());
            clPayment.CLIssuePolicy_ST();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }

        [When(@"I enter below details on CL New submission page")]
        public void WhenIEnterBelowDetailsOnCLNewSubmissionPage(Table table)
        {
            CL_NewSubmissions_PC9 startNew = new CL_NewSubmissions_PC9(getDriver());

            startNew.StartNewCLSubmission(table);
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "EFFDATE", ScenarioContext.Current["PCLYEFFDATE"].ToString());
            tempData.StoreTempValue("guidewire", "EXPDATE", ScenarioContext.Current["PCLYEXPFDATE"].ToString());
        }

        [When(@"I select below offering on the Offerings Page in PC9")]
        public void WhenISelectBelowOfferingOnTheOfferingsPageInPC9(Table table)
        {
            CL_Offerings_PC9 offeringsPage = new CL_Offerings_PC9(getDriver());

            offeringsPage.SelectOffering(table);
        }

        [When(@"I add UMB line on line selection page in PC9")]
        public void WhenIAddUMBLineOnLineSelectionPageInPC9()
        {
            CL_LineSelection_PC9 lineSelection = new CL_LineSelection_PC9(getDriver());
            lineSelection.SelectLinesAddUMB();
        }

        [When(@"I click next on line selection page in PC9")]
        public void WhenIClickNextOnLineSelectionPageInPC9()
        {
            CL_LineSelection_PC9 lineSelection = new CL_LineSelection_PC9(getDriver());
            lineSelection.ClickNext();
        }

        [When(@"I enter (.*) for all questions on qualification page in PC9")]
        public void WhenIEnterNoForAllQuestionsOnQualificationPageInPC9(string radioOption)
        {
            CL_Qualification_PC9 qualificationPage = new CL_Qualification_PC9(getDriver());

            qualificationPage.selectQualitifications(radioOption);
        }

        [When(@"I enter the policy details on the commercial lines policy information page for ST in PC9")]
        public void WhenIEnterThePolicyDetailsOnTheCommercialLinesPolicyInformationPageForStInPC9()
        {
            CL_PolicyInfo_PC9 clPolicyInfo = new CL_PolicyInfo_PC9(getDriver());
            clPolicyInfo.EnterPolicyInfo_ST();
        }

        [When(@"I enter Inland marine details on the Inland Marine line page in PC9")]
        public void WhenIEnterInlandMarineDetailsOnTheInlandMarineLinePageInPC9()
        {
            CL_InlandMarineLine_PC9 clILM = new CL_InlandMarineLine_PC9(getDriver());
            clILM.ClickNextButton();
        }

        [When(@"I select the (.*) location from existing locations in PC9")]
        public void WhenISelectTheLocationFromExistingLocationsInPC(int locationNumber)
        {
            CL_ILMLocations_PC9 clLocations = new CL_ILMLocations_PC9(getDriver());

            clLocations.AddExistingLocation(locationNumber);
        }
        [When(@"I enter below ILM location details in PC9")]
        public void WhenIEnterBelowILMLocationDetailsInPC(Table table)
        {
            CL_ILMLocationDetails_PC9 clLocationDetails = new CL_ILMLocationDetails_PC9(getDriver());
            clLocationDetails.EnterLocationDetails(table);
        }

		[When(@"I enter below ILM location info details in PC9")]
		public void WhenIEnterBelowILMLocationInfoDetailsInPC(Table table)
		{
			CL_ILMLocationDetails_PC9 clLocationDetails = new CL_ILMLocationDetails_PC9(getDriver());
			clLocationDetails.ILMLocDetailsInfo_CL(table);
			clLocationDetails.ILMLocSecInfo_CL(table);
			clLocationDetails.ILMLocSafeVaultStock(table);
		}

		[When(@"I Enter Below Jewelry Stock Information in PC9")]
        public void WhenIEnterBelowJewelryStockInformationInPC9(Table table)
        {
            CL_JewelryStock_PC9 clJewelryStock = new CL_JewelryStock_PC9(getDriver());
            clJewelryStock.EnterJewelryStockInfo(table);
        }
        [When(@"I Click Next on ILM Location Page on PC9")]
        public void WhenIClickNextOnILMLocationPageOnPC9()
        {
            CL_ILMLocations_PC9 clLocationNext = new CL_ILMLocations_PC9(getDriver());
            clLocationNext.ILMLocationsNext();
        }

        [When(@"I Click Next on Modifiers Page on PC9")]
        public void WhenIClickNextOnModifiersPageOnPC9()
        {
            CL_Modifiers_PC9 clModifiers = new CL_Modifiers_PC9(getDriver());
            clModifiers.ModifiersNext();
        }
        [When(@"I Click Next on Line Review Page for ST on PC9")]
        public void WhenIClickNextOnLineReviewPageForStOnPC9()
        {
            CL_LineReview_PC9 clLineReview = new CL_LineReview_PC9(getDriver());
            clLineReview.LineReviewNext_ST();
        }

        [When(@"I Enter (.*) level on Business Owners Line Page in PC9")]
        public void WhenIEnterPlatinumDetailsOnBusinessOwnersLinePageInPC(string PackageLevel)
        {
            CL_BusinessOwnersLine_PC9 clBOLine = new CL_BusinessOwnersLine_PC9(getDriver());
            clBOLine.EnterBOLineDetails(PackageLevel);
        }
        [When(@"I Click Next on Business Owners Lines Page in PC9")]
        public void WhenIClickNextOnBusinessOwnersLinesPageInPC9()
        {
            CL_BusinessOwnersLine_PC9 clBOLine = new CL_BusinessOwnersLine_PC9(getDriver());
            clBOLine.ClickNext();
        }

        [When(@"I Set Territory code (.*) for Location in PC9")]
        public void WhenISetTerritoryCodeForLocationInPC(string TerriotryCode)
        {
            CL_BOLocations_PC9 clBOLocations = new CL_BOLocations_PC9(getDriver());

            clBOLocations.BOLOcationSetTerritoryCode(TerriotryCode);
        }

        [When(@"I Click Next on Business Owners Locations Page in PC9")]
        public void WhenIClickNextOnBusinessOwnersLocationsPageInPC()
        {
            CL_BOLocations_PC9 clBOLocs = new CL_BOLocations_PC9(getDriver());
            clBOLocs.ClickNext();
        }

        [When(@"I Click on Add Inland Marine Location Building in PC9")]
        public void WhenIClickOnAddInlandMarineLocationBuildingInPC9()
        {
            CL_BOBuildings_PC9 clBOBuildings = new CL_BOBuildings_PC9(getDriver());
            clBOBuildings.BOAddILMLocation();
        }

        [When(@"I Click on Add ILM Location Building in PC9")]
        public void WhenIClickOnAddILMLocationBuildingInPC9()
        {
            CL_BOBuildings_PC9 clBuildingDetails = new CL_BOBuildings_PC9(getDriver());
            clBuildingDetails.BOAddILMLocation();
        }

        [When(@"I add below Location details in PC9")]
        public void WhenIAddBelowLocationDetailsInPC9(Table table)
        {
            CL_BOBuildingDetails_PC9 clBuildingDetails = new CL_BOBuildingDetails_PC9(getDriver());
            clBuildingDetails.BOAddBOBuildingDetails(table);
        }

        [When(@"I Click Next on BO Location Building Page in PC9")]
        public void WhenIClickNextOnBOLocationBuildingPageInPC9()
        {
            CL_BOBuildings_PC9 clBuildingDetails = new CL_BOBuildings_PC9(getDriver());
            clBuildingDetails.ClickNext();
        }

        [When(@"I Click Next on Bldg Blankets Page in PC9")]
        public void WhenIClickNextOnBldgBlanketsPageInPC9()
        {
            CL_BldgBlankets_PC9 clBldgBlankets = new CL_BldgBlankets_PC9(getDriver());
            clBldgBlankets.ClickNext();
        }

        [When(@"I Click Next on Bldg Modifiers Page in PC9")]
        public void WhenIClickNextOnBldgModifiersPageInPC9()
        {
            CL_BldgModifiers_PC9 clBldgModifiers = new CL_BldgModifiers_PC9(getDriver());
            clBldgModifiers.ClickNext();
        }

        [When(@"I Click Next on Bldg Line Review Page for ST in PC9")]
        public void WhenIClickNextOnBldgLineReviewPageForStInPC9()
        {
            CL_BldgLineReview_PC9 clBldgLineReview = new CL_BldgLineReview_PC9(getDriver());
            clBldgLineReview.ClickNext_ST();
        }

        [When(@"I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9")]
        public void WhenIClickNextOnBldgLineReviewPageAndVerifyRiskAnalysisScreenInPC9()
        {
            CL_BldgLineReview_PC9 clBldgLineReview = new CL_BldgLineReview_PC9(getDriver());
            clBldgLineReview.ClickNext_NoUMB();
        }

        [When(@"I Enter below Umbrella Line Coverage Details in PC9")]
        public void WhenIEnterBelowUmbrellaLineCoverageDetailsInPC9(Table table)
        {
            CL_UmbrellaLine_PC9 clUmbrella = new CL_UmbrellaLine_PC9(getDriver());
            clUmbrella.BOUmbrellaLineDetails(table);
			clUmbrella.ClickNext();

		}

        [When(@"I Click Next on Umbrella Modifiers Page in PC9")]
        public void WhenIClickNextOnUmbrellaModifiersPageInPC9()
        {
            CL_UmbrellaModifiers_PC9 clUmbrellaModifiers = new CL_UmbrellaModifiers_PC9(getDriver());
            clUmbrellaModifiers.ClickNext();
        }
        [When(@"I select (.*) for all and Click Next on Umbrella Underwriting Page in PC9")]
        public void WhenISelectNoForAllAndClickNextOnUmbrellaUnderwritingPageInPC9(string YesNo)
        {
            CL_UmbrellaUnderwriting_PC9 clUmbrellaUnderwriting = new CL_UmbrellaUnderwriting_PC9(getDriver());
            clUmbrellaUnderwriting.BOUmbrellaUnderwritingDetails(YesNo);
        }
        [When(@"I Click Next on Umbrella Line Review Page in PC9")]
        public void WhenIClickNextOnUmbrellaLineReviewPageInPC9()
        {
            CL_UmbrellaLineReview_PC9 clUmbrellaLineReview = new CL_UmbrellaLineReview_PC9(getDriver());
            clUmbrellaLineReview.ClickNext();
        }

        [When(@"I click Quote on Policy Review Page in PC(.*)")]
        public void WhenIClickQuoteOnPolicyReviewPageInPC(int p0)
        {
            CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
            clRiskAnalysis.RiskAnalysisQuote_Rewrite();
        }



        [When(@"I click Quote on Risk Analysis Page for ST in PC9")]
        public void WhenIClickQuoteOnRiskAnalysisPageForStInPC9()
        {
            CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
            clRiskAnalysis.RiskAnalysisQuote_ST();
        }

        [When(@"I click Quote on Risk Analysis Pages and verify for clear button")]
        public void WhenIClickQuoteOnRiskAnalysisPagesAndVerifyForClearButton()
        {
            CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
            clRiskAnalysis.RiskAnalysis_QuoteClear_JBP07();
            //clRiskAnalysis.RiskAnalysis_NavigateAllPages();
           // clRiskAnalysis.RiskAnalysisQuote_ST();
        }

        [When(@"I Click Next on Quote Page in PC9")]
        public void WhenIClickNextOnQuotePageInPC()
        {
            CL_Quote_PC9 clQuote = new CL_Quote_PC9(getDriver());
            clQuote.ClickNext();
        }


        [When(@"I handle prequote UW issues and click next on Risk Analysis page in PC9")]
        public void WhenIHandlePrequoteUWIssuesAndClickNextOnRiskAnalysisPageInPC9()
        {
            CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
            //clRiskAnalysis.HandlePrequoteUWissues();
        }


        [When(@"I check forms listed on Forms Page and click next in PC9")]
        public void WhenICheckFormsListedOnFormsPageAndClickNextInPC9()
        {
            CL_Forms_PC9 clForms = new CL_Forms_PC9(getDriver());
            clForms.VerifyFormsList();
        }
        [When(@"I enter below details on Payment Page in PC9")]
        public void WhenIEnterBelowDetailsOnPaymentPageInPC9(Table table)
        {
            CL_Payment_PC9 clPayment = new CL_Payment_PC9(getDriver());
            clPayment.EnterPaymentDetails(table);

        }
        [Then(@"I Issue the CL policy for ST in PC9")]
        public void ThenIIssueTheCLPolicyForStInPC9()
        {
            CL_Payment_PC9 clPayment = new CL_Payment_PC9(getDriver());
            clPayment.CLIssuePolicy_ST();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }

		[Given(@"I Logout of the Policy Center application")]
		[Then(@"I Logout of the Policy Center application")]
        [When(@"I Logout of the Policy Center application")]
        public void ThenILogoutOfThePolicyCenterApplication()
        {
            CCHomePage_CC9 bCHomePage = new CCHomePage_CC9(getDriver());
            bCHomePage.LogoutOfCC();
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }

        [Given(@"I search and select for (.*) policy number in PC9")]
		[When(@"I search and select for (.*) policy number in PC9")]
		public void GivenISearchAndSelectForPolicyNumberInPC9(string policyNum)
        {
            HomePage_PC9 searchAccounts = new HomePage_PC9(getDriver());
            searchAccounts.SearchAndSelect(policyNum);
        }

        [When(@"I Enter below details for Stock Peak policy change in PC9")]
        public void WhenIEnterBelowDetailsForStockPeakPolicyChangeInPC9(Table table)
        {
            CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_PlcyChange.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_PlcyChange.PermChangeStockPeak(table);
        }

        [When(@"I Update Pre Renewal direction details in PC9")]
        public void WhenIUpdatePreRenewalDirectionDetailsInPC9(Table table)
        {
            PreRenewalDirection_PC9 PreRenewalDirection = new PreRenewalDirection_PC9(getDriver());
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string Direction = temp[0];
                string Text = temp[1];
                string NonRenewReason = temp[2];
                PreRenewalDirection.UpdatePreRenewalPC9(Direction, Text, NonRenewReason);
            }
        }

        [When(@"I add below new ILM location on PC9")]
        public void WhenIAddBelowNewILMLocationOnPC9(Table table)
        {
            CL_ILMLocationDetails_PC9 clLocationDetails = new CL_ILMLocationDetails_PC9(getDriver());
            clLocationDetails.AddNewILMLocation(table);
        }

        [When(@"I click on Add All Existing Locations in PC9")]
        public void WhenIClickOnAddAllExistingLocationsInPC9()
        {
            CL_BOBuildings_PC9 clBuildingDetails = new CL_BOBuildings_PC9(getDriver());
            clBuildingDetails.BOAddAllExistingLocations();
        }

        [When(@"I add territory code by state for below locations")]
        public void WhenIAddTerritoryCodeByStateForBelowLocations(Table table)
        {
            CL_BOLocations_PC9 clBOLocations = new CL_BOLocations_PC9(getDriver());

            clBOLocations.BOLOcationSetTerritoryCode(table);
        }

        [When(@"I add below Location details for each location in PC9")]
        public void WhenIAddBelowLocationDetailsForEachLocationInPC9(Table table)
        {
            CL_BOBuildingDetails_PC9 clBuildingDetails = new CL_BOBuildingDetails_PC9(getDriver());
            clBuildingDetails.BOAddBOBldgDetails(table);
        }

        [When(@"I Enter below details for Steak Peak policy change in PC9")]
        public void WhenIEnterBelowDetailsForSteakPeakPolicyChangeInPC9(Table table)
        {
            CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_PlcyChange.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_PlcyChange.PermChangeStockPeak(table);
        }

        [When(@"I Enter below details for Stock AOP policy change in PC9")]
        public void WhenIEnterBelowDetailsForStockAOPPolicyChangeInPC(Table table)
        {
            CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_PlcyChange.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_PlcyChange.PermChangeStockAOP(table);
        }
        [When(@"I Enter below details for Add AI policy change in PC9")]
        public void WhenIEnterBelowDetailsForAddAIPolicyChangeInPC(Table table)
        {
            CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_PlcyChange.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_PlcyChange.PermChangeAddAddlIntrest(table);
        }


		[When(@"I enter below Additional Intrest at ILM Location in PC9")]
		public void WhenIEnterBelowAdditionalIntrestAtILMLocationInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.PermChangeAddlAI(table);
			CL_PlcyChange.PermChangeAddAddlIntrest(table);
		}

		[When(@"I enter below Additional Intrest at BOP Location in PC9")]
		public void WhenIEnterBelowAdditionalIntrestAtBOPLocationInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.NavigatetoBOLocs();
			CL_PlcyChange.PermChangeAddAI_BOP(table);
		}

		[When(@"I enter below Additional Insured at BOP Location  Building in PC9")]
		public void WhenIEnterBelowAdditionalInsuredAtBOPLocationBuildingInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.NavigatetoBOLocsBuldgs();
			CL_PlcyChange.PermChangeAddAI_BOPBld(table);
		}

		[When(@"I delete below Additional Insured at BOP Building in PC9")]
		public void WhenIDeleteBelowAdditionalInsuredAtBOPBuildingInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.PermChangeDeletelAI(table);
			CL_PlcyChange.NavigatetoBOLocs();
			CL_PlcyChange.NavigatetoBOLocsBuldgs();
			CL_PlcyChange.PermChangeDeleteAI_BOPBld(table);
		}

		[When(@"I Enter below details for Tradeshows policy change in PC9")]
		public void WhenIEnterBelowDetailsForTradeshowsPolicyChangeInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.PermChangeTradeShows(table);
		}
		[When(@"I add Tradeshows with below details on ILM Off Premise Coverages tab")]
		public void WhenIAddTradeshowsWithBelowDetailsOnILMOffPremiseCoveragesTab(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.AddTradeShow(table);
		}
		[Given(@"I save ILM Location address")]
		[When(@"I save ILM Location address")]
		public void WhenISaveILMLocationAddress()
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.GetLocAddress_ILM();
		}

		[When(@"I Enter below details for policy change in PC9")]
		public void WhenIEnterBelowDetailsForPolicyChangeInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
			CL_PlcyChange.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
			CL_PlcyChange.PolicyChangeReasonTbl(table);
		}

		[When(@"I enter below Policy Change Stockpeak details in PC9")]
		public void WhenIEnterBelowPolicyChangeStockpeakDetailsInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.PermChangeStockPeak(table);
		}

		[When(@"I enter below Policy Change Stock AOP changes in PC9")]
		public void WhenIEnterBelowPolicyChangeStockAOPChangesInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.PermChangeStockAOP(table);
		}

		[Then(@"I click Quote and Issue policy change")]
        [When(@"I click Quote and Issue policy change")]
        public void WhenIClickQuoteAndIssuePolicyChange()
        {
            CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
            CL_PlcyChange.ClickQuote();
        }

        [Then(@"I click Quote and Issue policy renew")]
        [When(@"I click Quote and Issue policy renew")]
        public void ThenIClickQuoteAndIssuePolicyRenew()
        {
            CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
            CL_PlcyChange.PlcyRenew_ClickQuote_Issue();
        }

        [When(@"I enter below Policy Info Details in PC9")]
		public void WhenIEnterBelowPolicyInfoDetailsInPC(Table table)
		{
			CL_PolicyInfo_PC9 clPolicyInfo = new CL_PolicyInfo_PC9(getDriver());
			clPolicyInfo.CL_EnterPolicyInfo(table);
		}

		[Given(@"I save Location address in SC Dictionary object")]
		public void GivenISaveLocationAddressInSCDictionaryObject()
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.GetLocAddress();
		}

		[When(@"I Enter below location to add new ILM Location")]
		public void WhenIEnterBelowLocationToAddNewILMLocation(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.AddILMLocation(table);
		}

		[When(@"I Enter below location to add new BO Location")]
		public void WhenIEnterBelowLocationToAddNewBOLocation(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.AddBOLocation(table);
		}
		[When(@"I click on New Location on BO Locations Page")]
		public void WhenIClickOnNewLocationOnBOLocationsPage()
		{
			CL_BOLocations_PC9 clAddBOLocs = new CL_BOLocations_PC9(getDriver());
			clAddBOLocs.ClickNewLocation();
		}

		[When(@"I add below details for new BO Location in PC(.*)")]
		public void WhenIAddBelowDetailsForNewBOLocationInPC(int p0, Table table)
		{
			CL_BOLocations_PC9 clAddBOLocs = new CL_BOLocations_PC9(getDriver());
			clAddBOLocs.AddBOLoactionDetails(table);
		}

		[When(@"I add below Building details for each BO Location in PC9")]
		public void WhenIAddBelowBuildingDetailsForEachBOLocationInPC(Table table)
		{
			CL_BOBuildingDetails_PC9 PlcyAddBOBldg = new CL_BOBuildingDetails_PC9(getDriver());
			PlcyAddBOBldg.CL_AddBOBldgDetails(table);
		}
		[When(@"I Enter below location to delete ILM Location")]
		public void WhenIEnterBelowLocationToDeleteILMLocation(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.DeleteILMLocation(table);
		}
		[When(@"I Enter below location to delete BO Location")]
		public void WhenIEnterBelowLocationToDeleteBOLocation(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.DeleteBOLocation(table);
		}
		[When(@"I Click Next on Line Review Page and verify Risk analysis screen in PC9")]
		public void WhenIClickNextOnLineReviewPageAndVerifyRiskAnalysisScreenInPC()
		{
			CL_LineReview_PC9 ILMLineReview = new CL_LineReview_PC9(getDriver());
			ILMLineReview.CL_LineReviewNextNoUMB();
		}

		[When(@"I Enter below Umbrella Line Coverage Details and verify UnderWriting Page in PC9")]
		public void WhenIEnterBelowUmbrellaLineCoverageDetailsAndVerifyUnderWritingPageInPC(Table table)
		{
			CL_UmbrellaLine_PC9 clUmbrella = new CL_UmbrellaLine_PC9(getDriver());
			clUmbrella.BOUmbrellaLineDetails(table);
			clUmbrella.ClickNextNoModifierPage();
		}

		[When(@"I click Quote on Risk Analysis Pages and verify for clear button for UMB")]
		public void WhenIClickQuoteOnRiskAnalysisPagesAndVerifyForClearButtonForUMB()
		{
			CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
			clRiskAnalysis.RiskAnalysis_QuoteClear();
			clRiskAnalysis.RiskAnalysis_NavigateAllPages_UMB();
			clRiskAnalysis.RiskAnalysisQuote_ST();
		}

		[When(@"I add UMB line on line selection page for Businessowners in PC9")]
		public void WhenIAddUMBLineOnLineSelectionPageForBusinessownersInPC()
		{
			CL_LineSelection_PC9 lineSelection = new CL_LineSelection_PC9(getDriver());
			lineSelection.SelectLinesAddUMB_BO();
		}

		[When(@"I enter (.*) for all questions on qualification page for Businessowners in PC9")]
		public void WhenIEnterNoForAllQuestionsOnQualificationPageForBusinessownersInPC(string radioOption)
		{
			CL_Qualification_PC9 qualificationPage = new CL_Qualification_PC9(getDriver());

			qualificationPage.selectQualitifications(radioOption);
		}
		[When(@"I click on below Location on BO Locations Page")]
		public void WhenIClickOnBelowLocationOnBOLocationsPage(Table table)
		{
			CL_BOLocations_PC9 clAddBOLocs = new CL_BOLocations_PC9(getDriver());
			clAddBOLocs.BOAddLocation(table);
		}

		[When(@"I add below details for new BO Location with same address in PC9")]
		public void WhenIAddBelowDetailsForNewBOLocationWithSameAddressInPC(Table table)
		{
			CL_BOLocations_PC9 clAddBOLocs = new CL_BOLocations_PC9(getDriver());
			clAddBOLocs.AddBOLocDetailsNoAddr(table);
		}
		[When(@"I enter below ILM location info details for Jewelers Standard in PC9")]
		public void WhenIEnterBelowILMLocationInfoDetailsForJewelersStandardInPC(Table table)
		{
			CL_ILMLocationDetails_PC9 clLocationDetails = new CL_ILMLocationDetails_PC9(getDriver());
			clLocationDetails.ILMLocDetailsInfo_CL(table);
			clLocationDetails.ILMLocSecInfo_CL(table);
			clLocationDetails.JSILMClickOK();
		}

		[When(@"I Enter Below Jewelry Stock Information for JS in PC9")]
		public void WhenIEnterBelowJewelryStockInformationForJSInPC(Table table)
		{
			CL_JewelryStock_PC9 clJewelryStock = new CL_JewelryStock_PC9(getDriver());
			clJewelryStock.EnterJewelryStockInfo_JS(table);
		}

		[When(@"I click Quote on Risk Analysis Pages and verify for clear button for UMB with modifier")]
		public void WhenIClickQuoteOnRiskAnalysisPagesAndVerifyForClearButtonForUMBWithModifier()
		{
			CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
			clRiskAnalysis.RiskAnalysis_QuoteClear();
			clRiskAnalysis.RiskAnalysis_NavAllPages_UMB_WithModifier();
			clRiskAnalysis.RiskAnalysisQuote_ST();
		}

		[When(@"I click Quote on Risk Analysis Pages")]
		public void WhenIClickQuoteOnRiskAnalysisPages()
		{
			CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
			clRiskAnalysis.RiskAnalysisCLQuote();
		}
		[When(@"I start Cancel policy with below details")]
		public void WhenIStartCancelPolicyWithBelowDetails(Table table)
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.CL_ProrataCancel(table);
		}
		[When(@"I click Quote and Issue policy Cancel")]
		public void WhenIClickQuoteAndIssuePolicyCancel()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.StartCancelAndIssue();
		}

		[When(@"I rescind Policy")]
		public void WhenIRescindPolicy()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.RecindPolicy();
		}
		[When(@"I enter below details for policy reinstatement")]
		public void WhenIEnterBelowDetailsForPolicyReinstatement(Table table)
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.ReinstatePolicy(table);
		}
		[When(@"I click Quote and Issue Policy Reinstatement")]
		public void WhenIClickQuoteAndIssuePolicyReinstatement()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.QuoteReinstate();
		}

		[When(@"I Enter below details for Temp Endorse Tradeshows policy change in PC9")]
		public void WhenIEnterBelowDetailsForTempEndorseTradeshowsPolicyChangeInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.TempChangeTradeShows(table);
		}
		[When(@"I click Quote and Issue policy RewriteFullTerm")]
		public void WhenIClickQuoteAndIssuePolicyRewriteFullTerm()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.QuoteReWriteFullTerm();
		}
		[When(@"I add below coverage on BO Line page")]
		public void WhenIAddBelowCoverageOnBOLinePage(Table table)
		{
			CL_BusinessOwnersLine_PC9 clBOLine = new CL_BusinessOwnersLine_PC9(getDriver());
			clBOLine.AddBOLineCoverage(table);
		}

		[When(@"I click next on CL Offerings Page")]
		public void WhenIClickNextOnCLOfferingsPage()
		{
			CL_Offerings_PC9 offeringsPage = new CL_Offerings_PC9(getDriver());
			offeringsPage.ClickNext();
		}
		[When(@"I click next on Policy Info Page for (.*)")]
		public void WhenIClickNextOnPolicyInfoPageFor(string LOB)
		{
			CL_PolicyInfo_PC9 clPolicyInfo = new CL_PolicyInfo_PC9(getDriver());
			clPolicyInfo.ClickNext(LOB);
		}
		[When(@"I delete Tradeshow coverage on ILM Off Premise Coverages tab")]
		public void WhenIDeleteTradeshowCoverageOnILMILMOffPremiseCoveragesTab()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.RewriteNewTerm_RemoveTradeshow();
			clPolicyCancel.ClickNext();
		}

		[When(@"I navigate to BO Locations")]
		public void WhenINavigateToBOLocations()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.NavigateToBOLocs_Rewrite();
		}

		[When(@"I Inactive AI for below BO location")]
		public void WhenIInactiveAIForBelowBOLocation(Table table)
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.InactivateAI_BO_Loc(table);
		}

		[When(@"I click Quote and Issue policy RewriteNewTerm")]
		public void WhenIClickQuoteAndIssuePolicyRewriteNewTerm()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.QuoteReWriteFullTerm();
		}

		[When(@"I Add Employee Dishonesty coverage on ILM Coverages tab")]
		public void WhenIAddEmployeeDishonestyCoverageOnILMCoveragesTab(Table table)
		{
			CL_ILMLocations_PC9 CLAddEmpDisHonesty = new CL_ILMLocations_PC9(getDriver());
			CLAddEmpDisHonesty.AddEmpDisHonesty(table);
		}

        [When(@"I set below location as primary")]
        public void WhenISetBelowLocationAsPrimary(Table table)
        {
            CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
            CL_PlcyChange.SetAsPrimary_ILM(table);
        }

        [When(@"I delete below ILM Location")]
		public void WhenIDeleteBelowILMLocation(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.DeleteILMLocation_JBP(table);
		}

		[When(@"I enter below Stockpeak details in PC9")]
		public void WhenIEnterBelowStockpeakDetailsInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.ChangeStockPeak_JBP(table);
		}
		[When(@"I enter below Additional Intrest details at ILM Location in PC9")]
		public void WhenIEnterBelowAdditionalIntrestDetailsAtILMLocationInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.PermChangeAddAddlIntrest_JBP(table);
		}
		[When(@"I enter below Additional Intrest details at BOP Location in PC9")]
		public void WhenIEnterBelowAdditionalIntrestDetailsAtBOPLocationInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.PermChangeAddAI_BOP(table);
		}
		[When(@"I click Quote and Issue policy RewriteRemainderOfTerm")]
		public void WhenIClickQuoteAndIssuePolicyRewriteRemainderOfTerm()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.QuoteReWriteFullTerm();
		}
		[When(@"I add UMB line on line selection page in PC(.*) for plcy Renew")]
		public void WhenIAddUMBLineOnLineSelectionPageInPCForPlcyRenew(int p0)
		{
			CL_LineSelection_PC9 lineSelection = new CL_LineSelection_PC9(getDriver());
			lineSelection.SelectLinesAddUMB_Renew();
		}

		[When(@"I click Quote on Risk Analysis Page for Plcy Renewal")]
		public void WhenIClickQuoteOnRiskAnalysisPageForPlcyRenewal()
		{
			CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
			clRiskAnalysis.RiskAnalysisQuote_Renew();
		}
		[When(@"I click Quote and Issue policy Renewal")]
		public void WhenIClickQuoteAndIssuePolicyRenewal(Table table)
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.RenewAndIssue(table);
		}
		[When(@"I click next on line selection page in PC9 and verify Plcy info page")]
		public void WhenIClickNextOnLineSelectionPageInPCAndVerifyPlcyInfoPage()
		{
			CL_LineSelection_PC9 lineSelection = new CL_LineSelection_PC9(getDriver());
			lineSelection.ClickNext_PlcyInfo();
		}
		[When(@"I Add below HotelMotel Coverage on ILM Line in PC9")]
		public void WhenIAddBelowHotelMotelCoverageOnILMLineInPC(Table table)
		{
			CL_ILMLocations_PC9 CLAddEmpDisHonesty = new CL_ILMLocations_PC9(getDriver());
			CLAddEmpDisHonesty.AddHotelMotelCoverage_ILM(table);
		}
		[When(@"I add below ShowCases Windows coverage with below details in PC9")]
		public void WhenIAddBelowShowCasesWindowsCoverageWithBelowDetailsInPC(Table table)
		{
			CL_ILMLocations_PC9 AddTradeShowcases = new CL_ILMLocations_PC9(getDriver());
			AddTradeShowcases.AddTradeShowcasesCovg(table);
		}
		[When(@"I remove UMB line on line selection page in PC9 for plcy Renew")]
		public void WhenIRemoveUMBLineOnLineSelectionPageInPCForPlcyRenew()
		{
			CL_LineSelection_PC9 lineSelection = new CL_LineSelection_PC9(getDriver());
			lineSelection.SelectLinesRemoveUMB_Renew();
		}

        //#####################JPA########################################################################
        [When(@"I click next on the policy location page in PC9")]
        public void WhenIClickNextOnThePolicyLocationPageInPC()
        {
            PolicyLocationPC9 location = new PolicyLocationPC9(getDriver());
            location.clickNextButton();
        }

        [When(@"I update Safe details on the policy location page in PC9")]
        public void WhenIUpdateSafeDetailsOnThePolicyLocationPageInPC9(Table table)
        {
            PolicyLocationPC9 location = new PolicyLocationPC9(getDriver());
            location.UpdateSafeDetails(table);

        }

        [When(@"I update below new location details  on the policy location page in PC9")]
        public void WhenIUpdateBelowNewLocationDetailsOnThePolicyLocationPageInPC(Table table)
        {
            PolicyLocationPC9 location = new PolicyLocationPC9(getDriver());
            location.UpdateNewLocationDetails(table);
        }

        [When(@"I update below new contact details  on the policy contact page in PC9")]
        public void WhenIUpdateBelowNewContactDetailsOnThePolicyContactPageInPC9(Table table)
        {
            PolicyContactsPC9 contact = new PolicyContactsPC9(getDriver());
            contact.UpdateNewContactDetails(table);
        }


        [When(@"I update Alarm type  on the policy location page in PC9")]
        public void WhenIUpdateAlarmTypeOnThePolicyLocationPageInPC9(Table table)
        {
            string alarmtype = table.Rows[0]["AlarmType"];
            PolicyLocationPC9 location = new PolicyLocationPC9(getDriver());
            location.UpdateAlarmType(alarmtype);
        }



        [When(@"I enter (.*) and denied coverage details on the policy contact page in PC9")]
        public void WhenIEnterAndDeniedCoverageDetailsOnThePolicyContactPageInPC(string dateofBirth, Table table)
        {
            string deniedcoverage = table.Rows[0]["deniedcoverage"];
            string reason = table.Rows[0]["reason"];
            PolicyContactsPC9 contact = new PolicyContactsPC9(getDriver());
            contact.updateDob(dateofBirth);
            contact.updateDeniedCoverage(deniedcoverage, reason);

        }

        [When(@"I click next on the  policy contact page in PC9")]
        public void WhenIClickNextOnThePolicyContactPageInPC()
        {
            PolicyContactsPC9 contact = new PolicyContactsPC9(getDriver());
            contact.clickNextButton();
        }

        [When(@"I Update Unschedule details on personal articles page in PC9")]
        public void WhenIUpdateUnscheduleDetailsOnPersonalArticlesPageInPC(Table table)
        {
            string limit = table.Rows[0]["Unschedulelimit"];
            string deductible = table.Rows[0]["UnscheduleDeductible"];
            PolicyArticlesPC9 JPA = new PolicyArticlesPC9(getDriver());
            JPA.updateUnschedulelimit(limit, deductible);
        }



        [When(@"I Click next on personal articles page in PC9")]
        public void WhenIClickNextOnPersonalArticlesPageInPC9()
        {
            PolicyArticlesPC9 JPA = new PolicyArticlesPC9(getDriver());
            JPA.ClickNextButton();
        }

        [When(@"I Click IRPM tab on personal articles page in PC9")]
        public void WhenIClickIRPMTabOnPersonalArticlesPageInPC9()
        {
            PolicyArticlesPC9 JPA = new PolicyArticlesPC9(getDriver());
            JPA.ClickIRPMTab();
        }

        [When(@"I Click next on Additional Underwriting question page in PC(.*)")]
        public void WhenIClickNextOnAdditionalUnderwritingQuestionPageInPC(int p0)
        {
            AdditionalUWPC9 JPAUW = new AdditionalUWPC9(getDriver());
            JPAUW.ClickNextButton();
        }

        [When(@"I Update Contact details in Additional Underwriting question")]
        public void WhenIUpdateContactDetailsInAdditionalUnderwritingQuestion(Table table)
        {
            int Itemcounter = 0;
            AdditionalUWPC9 JPAUW = new AdditionalUWPC9(getDriver());
            foreach (var row in table.Rows)
            {
                string Articleworn = table.Rows[Itemcounter]["Articleworn"].Trim();
                string currentocuption = table.Rows[Itemcounter]["currentocuption"].Trim();
                string overnighttravel = table.Rows[Itemcounter]["overnighttravel"].Trim();
                string travelaborod = table.Rows[Itemcounter]["travelaborod"].Trim();
                string safeguradwhiletraviling = table.Rows[Itemcounter]["safeguradwhiletraviling"];
                if (Itemcounter > 0)
                {
                    JPAUW.SelectonContact(Itemcounter);

                }
                JPAUW.SetContactDetails(Articleworn, currentocuption, overnighttravel, travelaborod, safeguradwhiletraviling);
                Itemcounter = Itemcounter + 1;
            }


        }


        [When(@"I Update Location details in Additional Underwriting question")]
        public void WhenIUpdateLocationDetailsInAdditionalUnderwritingQuestion(Table table)
        {
            int Itemcounter = 0;
            AdditionalUWPC9 JPAUW = new AdditionalUWPC9(getDriver());
            foreach (var row in table.Rows)
            {
                string GatedEntrance = table.Rows[0]["GatedEntrance"];
                string fenceSurround = table.Rows[0]["fenceSurround"];
                string guardatgate = table.Rows[0]["guardatgate"];
                string guardpresentfrequency = table.Rows[0]["guardpresentfrequency"];
                string communitypatrol = table.Rows[0]["communitypatrol"];
                string communitypatrolfrequency = table.Rows[0]["communitypatrolfrequency"];
                string enterancetocommunity = table.Rows[0]["enterancetocommunity"];
                string guestenterancetocommunity = table.Rows[0]["guestenterancetocommunity"];
                string domestichelp = table.Rows[0]["domestichelp"];
                string helptype = table.Rows[0]["helptype"];
                string employmentlength = table.Rows[0]["employmentlength"];
                string resideathome = table.Rows[0]["resideathome"];
                string theycomehome = table.Rows[0]["theycomehome"];

                string otherpersonresideathome = table.Rows[0]["otherpersonresideathome"];
                string theycomelseresideehome = table.Rows[0]["elsereside"];

                if (Itemcounter > 0)
                {
                    JPAUW.SelectonLocation(Itemcounter);

                }

                JPAUW.Setlocationdetails(GatedEntrance, domestichelp, otherpersonresideathome, theycomelseresideehome);
                if (GatedEntrance.ToLower().Equals("yes"))
                {
                    Console.WriteLine("value of GatedEntrance is " + GatedEntrance.ToLower());
                    JPAUW.SetGatedCommunityDetails(fenceSurround, guardatgate, guardpresentfrequency, communitypatrol, communitypatrolfrequency, enterancetocommunity, guestenterancetocommunity);
                }
                if (domestichelp.ToLower().Equals("yes"))
                {
                    JPAUW.SetDomesticHelpDetails(helptype, employmentlength, resideathome, theycomehome);
                }
                Itemcounter = Itemcounter + 1;
            }
        }



        [When(@"I add Vault details in personal articles page in PC9")]
        public void WhenIAddVaultDetailsInPersonalArticlesPageInPC9(Table table)
        {



            //| ItemFlag | ValutType | Name | CompanyJeweler | AddressType | Address1 | Address2 | City | State | ZipCode | ValutAddressType |
            PolicyArticlesPC9 JPA = new PolicyArticlesPC9(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                string ItemFlag = table.Rows[Itemcounter]["ItemFlag"];
                string ValutType = table.Rows[Itemcounter]["ValutType"];
                string Name = table.Rows[Itemcounter]["Name"];
                string CompanyJeweler = table.Rows[Itemcounter]["CompanyJeweler"];
                string AddressType = table.Rows[Itemcounter]["AddressType"];
                string Address1 = table.Rows[Itemcounter]["Address1"];
                string Address2 = table.Rows[Itemcounter]["Address2"];
                string City = table.Rows[Itemcounter]["City"];
                string State = table.Rows[Itemcounter]["State"];
                string ZipCode = table.Rows[Itemcounter]["ZipCode"];
                string ValutAddressType = table.Rows[Itemcounter]["ValutAddressType"];

                JPA.updateVault(ItemFlag, ValutType, Name, CompanyJeweler, AddressType, Address1, Address2, City, State, ZipCode, ValutAddressType, Itemcounter);
                Itemcounter = Itemcounter + 1;
            }
        }

        [When(@"I Delete below Multi Article details on personal articles page in PC9")]
        public void WhenIDeleteBelowMultiArticleDetailsOnPersonalArticlesPageInPC9(Table table)
        {
            int Itemcounter = 0;
            PolicyArticlesPC9 JPA = new PolicyArticlesPC9(getDriver());
            foreach (var row in table.Rows)
            {
                string InactiveArticle = table.Rows[Itemcounter]["InactiveArticle"];
                string InactiveReason = table.Rows[Itemcounter]["InactiveReason"];
                if (InactiveArticle.ToLower().Equals("yes"))
                {
                    JPA.MakeJPAItemInactiveinPC9PolicyChange(InactiveReason, Itemcounter);
                    //  JPA.ClickBtnMassUpdate();
                }
                Itemcounter = Itemcounter + 1;
            }
        }

        [When(@"I Enter below Multi Article details on personal articles page in PC9")]
        public void WhenIEnterBelowMultiArticleDetailsOnPersonalArticlesPageInPC9(Table table)
        {
            int Itemcounter = 0;
            PolicyArticlesPC9 JPA = new PolicyArticlesPC9(getDriver());
            foreach (var row in table.Rows)
            {
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string JeweArticle = table.Rows[Itemcounter]["Article"];
                string JewelryArticleSubType = table.Rows[Itemcounter]["ArticleSubType"];
                string JewelryGenderType = table.Rows[Itemcounter]["GenderType"];
                string WearableTech = table.Rows[Itemcounter]["WearableTech"];
                string Brand = table.Rows[Itemcounter]["Brand"];
                string Style = table.Rows[Itemcounter]["Style"];
                string ArticleValue = table.Rows[Itemcounter]["ArticleValue"];
                string Deductible = table.Rows[Itemcounter]["Deductible"];
                string FullDescriptionFlag = table.Rows[Itemcounter]["FullDescriptionFlag"];
                string Description = table.Rows[Itemcounter]["Description"];
                string AppraisalRequested = table.Rows[Itemcounter]["AppraisalRequested"];
                string AppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string ArticleStored = table.Rows[Itemcounter]["Article Stored"];
                string ValuationType = table.Rows[Itemcounter]["ValuationType"];
                string Damage = table.Rows[Itemcounter]["Damage"];
                string CarePlan = table.Rows[Itemcounter]["CarePlan"];
                string CarePlanExpirDate = table.Rows[Itemcounter]["CarePlanExpirDate"];
                string CarePLanID = table.Rows[Itemcounter]["CarePLanID"];
                string HowWasArticleAquired = table.Rows[Itemcounter]["HowWasArticleAquired"];
                string ArticleAquiredYear = table.Rows[Itemcounter]["ArticleAquiredYear"];
                string ArticleAquiredInsurance = table.Rows[Itemcounter]["ArticleAquiredInsurance"];
                string AppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];
                string Retailer = table.Rows[Itemcounter]["Retailer"];
                string affinitygroup = table.Rows[Itemcounter]["AffinityGroup"];
                string Damagetype = table.Rows[Itemcounter]["Damagetype"];
                string SafeDetails = table.Rows[Itemcounter]["Safe Details"];
                //  string Articleinsuredbyother = table.Rows[Itemcounter]["Articleinsuredbyother"];
                JPA.updatePersonalArtile(JewelryLocatedWith, JeweArticle, JewelryArticleSubType, JewelryGenderType, WearableTech, Brand, Style, ArticleValue, Deductible, FullDescriptionFlag, Description, AppraisalRequested, AppraisalReceived, AppraisalDate, Retailer, ValuationType);
                JPA.updatePersonalArtileAffinity(affinitygroup, Damage, Damagetype, ArticleStored, SafeDetails, CarePlan, CarePlanExpirDate, CarePLanID, HowWasArticleAquired, ArticleAquiredYear, ArticleAquiredInsurance);
                Itemcounter = Itemcounter + 1;
            }

        }


        [When(@"I Enter below Multi Article details for different locations on personal articles page in PC9")]
        public void WhenIEnterBelowMultiArticleDetailsForDifferentLocationsOnPersonalArticlesPageInPC9(Table table)
        {
            int Itemcounter = 0;
            PolicyArticlesPC9 JPA = new PolicyArticlesPC9(getDriver());
            foreach (var row in table.Rows)
            {
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string JewelryLocation = table.Rows[Itemcounter]["Location"];
                string JeweArticle = table.Rows[Itemcounter]["Article"];
                string JewelryArticleSubType = table.Rows[Itemcounter]["ArticleSubType"];
                string JewelryGenderType = table.Rows[Itemcounter]["GenderType"];
                string WearableTech = table.Rows[Itemcounter]["WearableTech"];
                string Brand = table.Rows[Itemcounter]["Brand"];
                string Style = table.Rows[Itemcounter]["Style"];
                string ArticleValue = table.Rows[Itemcounter]["ArticleValue"];
                string Deductible = table.Rows[Itemcounter]["Deductible"];
                string FullDescriptionFlag = table.Rows[Itemcounter]["FullDescriptionFlag"];
                string Description = table.Rows[Itemcounter]["Description"];
                string AppraisalRequested = table.Rows[Itemcounter]["AppraisalRequested"];
                string AppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string ArticleStored = table.Rows[Itemcounter]["Article Stored"];
                string ValuationType = table.Rows[Itemcounter]["ValuationType"];
                string Damage = table.Rows[Itemcounter]["Damage"];
                string CarePlan = table.Rows[Itemcounter]["CarePlan"];
                string CarePlanExpirDate = table.Rows[Itemcounter]["CarePlanExpirDate"];
                string CarePLanID = table.Rows[Itemcounter]["CarePLanID"];
                string HowWasArticleAquired = table.Rows[Itemcounter]["HowWasArticleAquired"];
                string ArticleAquiredYear = table.Rows[Itemcounter]["ArticleAquiredYear"];
                string ArticleAquiredInsurance = table.Rows[Itemcounter]["ArticleAquiredInsurance"];
                string AppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];
                string Retailer = table.Rows[Itemcounter]["Retailer"];
                string affinitygroup = table.Rows[Itemcounter]["AffinityGroup"];
                string Damagetype = table.Rows[Itemcounter]["Damagetype"];
                string SafeDetails = table.Rows[Itemcounter]["Safe Details"];
                //  string Articleinsuredbyother = table.Rows[Itemcounter]["Articleinsuredbyother"];
                JPA.updatePersonalArtile(JewelryLocatedWith, JeweArticle, JewelryArticleSubType, JewelryGenderType, WearableTech, Brand, Style, ArticleValue, Deductible, FullDescriptionFlag, Description, AppraisalRequested, AppraisalReceived, AppraisalDate, Retailer, ValuationType);
                if (JewelryLocation.Length > 1)
                {
                    JPA.updatePersonalArtileLocation(JewelryLocation);
                }
                JPA.updatePersonalArtileAffinity(affinitygroup, Damage, Damagetype, ArticleStored, SafeDetails, CarePlan, CarePlanExpirDate, CarePLanID, HowWasArticleAquired, ArticleAquiredYear, ArticleAquiredInsurance);
                Itemcounter = Itemcounter + 1;
            }
        }


        [When(@"I select Additional Details in Additional Details in PC9")]
        public void WhenISelectAdditionalDetailsInAdditionalDetailsInPC9(Table table)
        {

            string PossessionofItem = table.Rows[0]["PossessionofItem"];
            string FaudWarningConsent = table.Rows[0]["FaudWarningConsent"];
            string ConsumerReportConsent = table.Rows[0]["ConsumerReportConsent"];
            AdditionalDetailsPC9 AdditionalDetails = new AdditionalDetailsPC9(getDriver());
            AdditionalDetails.updateAdditionalDetails(PossessionofItem, FaudWarningConsent, ConsumerReportConsent);
            AdditionalDetails.ClickNextButton();
        }

        [When(@"I select Additional Details in Additional Details in PC9 for policy change")]
        public void WhenISelectAdditionalDetailsInAdditionalDetailsInPCForPolicyChange(Table table)
        {
            string PossessionofItem = table.Rows[0]["PossessionofItem"];
            string FaudWarningConsent = table.Rows[0]["FaudWarningConsent"];
            string ConsumerReportConsent = table.Rows[0]["ConsumerReportConsent"];
            AdditionalDetailsPC9 AdditionalDetails = new AdditionalDetailsPC9(getDriver());
            AdditionalDetails.updateAdditionalDetailsPolicyChange(PossessionofItem, FaudWarningConsent, ConsumerReportConsent);
            AdditionalDetails.ClickNextButton();
        }

        [When(@"I click next on Additional Details in PC9")]
        public void WhenIClickNextOnAdditionalDetailsInPC()
        {
            AdditionalDetailsPC9 AdditionalDetails = new AdditionalDetailsPC9(getDriver());
            AdditionalDetails.ClickNextButton();
        }

        [When(@"I Issue the JPA Smoke test policy in PC9")]
        [When(@"I Issue the JPA Smoke test policy in PC9")]
        public void WhenIIssueTheJPASmokeTestPolicyInPC9()
        {
            PolicyIssuePC9 plPayment = new PolicyIssuePC9(getDriver());
            plPayment.PLIssuePolicy_JPA();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }
        [When(@"I verify insurance (.*)")]
        public void WhenIVerifyInsuranceSocre(string score)
        {
            PolicyIssuePC9 plPayment = new PolicyIssuePC9(getDriver());
            plPayment.verifyInsuranceScore(score);
        }
        [When(@"I verify Taxes")]
        public void WhenIVerifyTaxes()
        {
            CL_Quote_PC9 clQuote = new CL_Quote_PC9(getDriver());
            clQuote.verifyKYTaxes();
        }

        [When(@"I verify IRPM (.*) prevented")]
        public void WhenIVerifyIRPMIsPreventedOrNot(String yesOrNot)
        {
            PolicyArticlesPC9 plArticle = new PolicyArticlesPC9(getDriver());
            plArticle.VerifyIRPMIsPreventedOrNot(yesOrNot);
        }

        [When(@"I verify IRPM has no (.*)")]
        public void WhenIVerifyIRPMHasNoSuchOption(String suchOption)
        {
            PolicyArticlesPC9 plArticle = new PolicyArticlesPC9(getDriver());
            plArticle.VerifyIRPMNotContain(suchOption);
        }

        [When(@"I verify IRPM has Minus And Plus (.*) Percentage in Overall")]
        public void WhenIVerifyIRPMHasPercentageInOverall(String numOfPercentage)
        {
            PolicyArticlesPC9 plArticle = new PolicyArticlesPC9(getDriver());
            plArticle.VerifyIRPMHasPercentageInOverall(numOfPercentage);
        }

        [When(@"I verify (.*) in the Risk Analysis screen for JPA in PC9")]
        public void IVerifyInTheRiskAnalysisScreenForJPAInPC9(string activities)
        {
            PolicyIssuePC9 plPayment = new PolicyIssuePC9(getDriver());
            string actualVal = plPayment.VerifyActivities();
            string coampre_flag = "";
            string actual_value_temp = actualVal;
            if (activities.Contains(";"))
            {
                int expect_counter = 1;
                int Actual_counter = 1;
                char[] delimiterChars = { ';' };
                string[] Expectedactivity = activities.Split(delimiterChars);
                string[] actualactivity = actualVal.Split(delimiterChars);
                foreach (string expected in Expectedactivity)
                {
                    Console.WriteLine(expect_counter + " expected value " + expected);
                    coampre_flag = "false";
                    foreach (string actual in actualactivity)
                    {
                        Console.WriteLine(Actual_counter + " actual value " + actual);
                        if (actual.ToLower().Trim().Contains(expected.ToLower().Trim()))
                        {
                            coampre_flag = "true";
                            actual_value_temp = actual;
                            break;
                        }
                        Actual_counter = Actual_counter + 1;
                    }
                    if (string.Equals(coampre_flag, "true"))
                    {
                        Console.WriteLine("expected value match " + expected.ToLower() + "actual value is " + actual_value_temp.ToLower());
                    }
                    else
                    {
                        Console.WriteLine("expected value do not match " + expected.ToLower() + "actual value is " + actual_value_temp.ToLower());
                        Assert.AreEqual(expected.ToLower(), actualVal.ToLower());
                    }
                    Actual_counter = 0;
                    expect_counter = expect_counter + 1;
                }
            }
            else
            {
                if (actualVal.Contains(activities))
                {
                    Console.WriteLine("Activities matches expected value is " + activities.ToLower() + "actual value is " + activities.ToLower());
                }
                else
                {
                    Console.WriteLine("Activities do not matches expected value is " + activities.ToLower() + "actual value is " + actualVal.ToLower());
                    Assert.AreEqual(activities.ToLower(), actual_value_temp.ToLower());
                }
            }

        }


        [When(@"I Issue the JPA Smoke test policy in PC9 for policy change")]
        public void WhenIIssueTheJPASmokeTestPolicyInPCForPolicyChange()
        {
            PolicyIssuePC9 plPayment = new PolicyIssuePC9(getDriver());
            plPayment.PLIssueChangePolicy_JPA();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }

        [When(@"I Issue the JPA Smoke test policy in PC9 for policy ReWrite")]
        public void WhenIIssueTheJPASmokeTestPolicyInPCForPolicyReWrite()
        {
            PolicyIssuePC9 plPayment = new PolicyIssuePC9(getDriver());
            plPayment.PLIssueRewritePolicy_JPA();
        }


		[When(@"I enter below details for Policy change OOS in PC9 for (.*)")]
		public void WhenIEnterBelowDetailsForPolicyChangeOOSInPCFor(string ChangeEffectiveDate, Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.ChangeEffectiveDate(ChangeEffectiveDate);
			CL_PlcyChange.PolicyChangeReasonMultiTbl(table);
		}
		[When(@"I add below Temp Coverages in PC9")]
		public void WhenIAddBelowTempCoveragesInPC(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.AddTempCovgs(table);
		}
		[When(@"I click Quote on Risk Analysis Pages and verify for clear button for PolicyRenew")]
		public void WhenIClickQuoteOnRiskAnalysisPagesAndVerifyForClearButtonForPolicyRenew()
		{
			CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
			clRiskAnalysis.RiskAnalysis_QuoteClearRenew();
			clRiskAnalysis.RiskAnalysis_NavigateAllPages_Renew();
		}
		[When(@"I enter below ILM Blanket details on ILM Line page in PC9")]
		public void WhenIEnterBelowILMBlanketDetailsOnILMLinePageInPC(Table table)
		{
			CL_ILMLocationDetails_PC9 CL_AddILMBlanket = new CL_ILMLocationDetails_PC9(getDriver());
			CL_AddILMBlanket.AddILMBlanket(table);
		}
		[When(@"I add a Blanket with Below details in PC9")]
		public void WhenIAddABlanketWithBelowDetailsInPC(Table table)
		{
			CL_BldgBlankets_PC9 clBldgBlankets = new CL_BldgBlankets_PC9(getDriver());
			clBldgBlankets.AddBlanket(table);
		}
		[When(@"I add building coverage for below details")]
		public void WhenIAddBuildingCoverageForBelowDetails(Table table)
		{
			CL_BOBuildingDetails_PC9 PlcyAddBOBldg = new CL_BOBuildingDetails_PC9(getDriver());
			PlcyAddBOBldg.CL_AddBOBldgCovgDetails(table);
		}
		[When(@"I enter below mandatory details on create account page for CL")]
		public void WhenIEnterBelowMandatoryDetailsOnCreateAccountPageForCL(Table table)
		{
			CL_CreateAccount_PC9 cl_CreateAcccount = new CL_CreateAccount_PC9(getDriver());
			cl_CreateAcccount.CL_NewAccountDetails(table);
			DataStorage tempData = new DataStorage();
			tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
		}
		[When(@"I enter below details to select Payment plan")]
		public void WhenIEnterBelowDetailsToSelectPaymentPlan(Table table)
		{
			CL_SelectPayPlan cl_SelectPayPlan = new CL_SelectPayPlan(getDriver());
			cl_SelectPayPlan.EnterPaymentDetails(table);
		}
		[Then(@"I Issue CL policy for after PaymentPlan Selection")]
		public void ThenIIssueCLPolicyForAfterPaymentPlanSelection()
		{
			CL_SelectPayPlan cl_IssuePolicy = new CL_SelectPayPlan(getDriver());
			cl_IssuePolicy.CLIssuePolicy();
			DataStorage ClPolicy = new DataStorage();
			ClPolicy.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
		}

		[When(@"I choose below optionson line selection page for (.*)")]
		public void WhenIChooseBelowOptionsonLineSelectionPageFor(string PolicyType, Table table)
		{
			CL_LineSelection_PC9 lineSelection = new CL_LineSelection_PC9(getDriver());
			lineSelection.LineSelection(PolicyType, table);
		}
		[Then(@"I Issue CL policy for after handling UW issues")]
		public void ThenIIssueCLPolicyForAfterHandlingUWIssues()
		{
			CL_SelectPayPlan cl_IssuePolicy = new CL_SelectPayPlan(getDriver());
			cl_IssuePolicy.CLUWIssuePolicy();
			DataStorage ClPolicy = new DataStorage();
			ClPolicy.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
		}
		[When(@"I add UMB line on line selection page in PC9 for JSP")]
		public void WhenIAddUMBLineOnLineSelectionPageInPCForJSP()
		{
			CL_LineSelection_PC9 lineSelection = new CL_LineSelection_PC9(getDriver());
			lineSelection.SelectLinesAddUMB_JSP();
		}
		[When(@"I add below Property Otherwise Away Limit on ILM Line")]
		public void WhenIAddBelowPropertyOtherwiseAwayLimitOnILMLine(Table table)
		{
			CL_InlandMarineLine_PC9 clILM = new CL_InlandMarineLine_PC9(getDriver());
			clILM.AddPropOtherwiseCovg(table);
		}
		[When(@"I enter below Safes Vaults and Stockroom details")]
		public void WhenIEnterBelowSafesVaultsAndStockroomDetails(Table table)
		{
			CL_ILMLocationDetails_PC9 clLocationDetails = new CL_ILMLocationDetails_PC9(getDriver());
			clLocationDetails.ILMLocSafeVaultStock(table);
		}
		[When(@"I click on Edit Work Order For Policy Renewal in PC9")]
		public void WhenIClickOnEditWorkOrderForPolicyRenewalInPC9()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.EditWorkOrder();
		}

		[When(@"I click Quote and Issue policy RewriteFullTerm for JS")]
		public void WhenIClickQuoteAndIssuePolicyRewriteFullTermForJS()
		{
			CL_PolicyCancel clPolicyCancel = new CL_PolicyCancel(getDriver());
			clPolicyCancel.QuoteReWriteFullTerm_JS();
		}
		[When(@"I Enter below location to delete ILM Location for Canada")]
		public void WhenIEnterBelowLocationToDeleteILMLocationForCanada(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.DeleteILMLocation_CAD(table);
		}

		[When(@"I click Quote on Risk Analysis Pages and verify for clear button in BOP")]
		public void WhenIClickQuoteOnRiskAnalysisPagesAndVerifyForClearButtonInBOP()
		{
			CL_RiskAnalysis_PC9 clRiskAnalysis = new CL_RiskAnalysis_PC9(getDriver());
			clRiskAnalysis.RiskAnalysis_QuoteClear();
			clRiskAnalysis.RiskAnalysis_NavigateAllPages_BOP();
			clRiskAnalysis.RiskAnalysisQuote_ST();
		}
		[When(@"I Enter below location to add new BO Location for BOP")]
		public void WhenIEnterBelowLocationToAddNewBOLocationForBOP(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.AddBOLocation_BOP(table);
		}
		[When(@"I Enter below Building details to add a Building")]
		public void WhenIEnterBelowBuildingDetailsToAddABuilding(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.AddBOLocationBldg_BOP(table);
		}
		[When(@"I Enter below details for (.*) to delete BO Location buidling for location (.*)")]
		public void WhenIEnterBelowDetailsForOfferingToDeleteBOLocationBuidlingForLocation(string Offering, int locationNumber, Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.DeleteBOLocation_BOP(Offering, locationNumber, table);

		}
		[When(@"I Enter below details to delete BO Location")]
		public void WhenIEnterBelowDetailsToDeleteBOLocation(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.DeleteBOLocationSet(table);
		}
		[When(@"I change EPLI details and verify Ratabase Error in PC9")]
		public void WhenIChangeEPLIDetailsAndVerifyRatabaseErrorInPC()
		{
			CL_InlandMarineLine_PC9 cl_EPLI = new CL_InlandMarineLine_PC9(getDriver());
			cl_EPLI.UpdateBOPEPLI_Verify();
		}
		[When(@"I enter below Additional Intrest at BOP Location in PC9 for BOP")]
		public void WhenIEnterBelowAdditionalIntrestAtBOPLocationInPCForBOP(Table table)
		{
			CL_PolicyChange_PC9 CL_PlcyChange = new CL_PolicyChange_PC9(getDriver());
			CL_PlcyChange.PermChangeAddAI_BOP(table);
		}

		[When(@"I enter below details to add Ecomm Coverage")]
		public void WhenIEnterBelowDetailsToAddEcommCoverage(Table table)
		{
			CL_BOLocations_PC9 CL_AddCovg = new CL_BOLocations_PC9(getDriver());
			CL_AddCovg.AddBOLocEcommCovg(table);
		}
		[When(@"I enter below details to add MSV Coverage")]
		public void WhenIEnterBelowDetailsToAddMSVCoverage(Table table)
		{
			CL_BOLocations_PC9 CL_AddCovg = new CL_BOLocations_PC9(getDriver());
			CL_AddCovg.AddBOLocMSVCovg(table);
		}
		[When(@"I add below Building details for each BO Location in PC(.*) and add EQ Covg")]
		public void WhenIAddBelowBuildingDetailsForEachBOLocationInPCAndAddEQCovg(int p0, Table table)
		{
			CL_BOBuildingDetails_PC9 PlcyAddBOBldg = new CL_BOBuildingDetails_PC9(getDriver());
			PlcyAddBOBldg.CL_AddBOBldgDetails_EQ(table);
		}
		[When(@"I add below coverages on ILM Line for CL RI")]
		public void WhenIAddBelowCoveragesOnILMLineForCLRI(Table table)
		{
			CL_InlandMarineLine_PC9 clILMCovgs = new CL_InlandMarineLine_PC9(getDriver());
			clILMCovgs.CLAddILMLineCovgs(table);
		}
		[When(@"I Enter below Umbrella Line Coverage Details in PC(.*) for CL RI")]
		public void WhenIEnterBelowUmbrellaLineCoverageDetailsInPCForCLRI(int p0, Table table)
		{
			CL_UmbrellaLine_PC9 clUmbrella = new CL_UmbrellaLine_PC9(getDriver());
			clUmbrella.BOUmbrellaLineDetails_CLRI(table);
		}
		[When(@"I click on (.*) link on left navigation bar")]
		public void WhenIClickOnLinkOnLeftNavigationBar(string slinkName)
		{
			HomePage_PC9 PCNavigation = new HomePage_PC9(getDriver());
			PCNavigation.ClickLeftNavigationMenu(slinkName);
		}
        [When(@"I verify below AgreementNumber for EPLI")]
        public void WhenIVerifyBelowAgreementNumberForEPLI(Table table)
        {
            CL_Reinsurance_PC9 CL_RI = new CL_Reinsurance_PC9(getDriver());
            CL_RI.verifyAgreementNum(table);
        }
        [When(@"I enter below details for CL Reinsurance")]
		public void WhenIEnterBelowDetailsForCLReinsurance(Table table)
		{
			CL_Reinsurance_PC9 CL_RI = new CL_Reinsurance_PC9(getDriver());
			CL_RI.AddFacultative(table);
		}
		[Given(@"I search and select for (.*) account number in PC9")]
		[When(@"I search and select for (.*) account number in PC9")]
		public void WhenISearchAndSelectForAccountNumberInPC(string AccNum)
		{
			CL_Reinsurance_PC9 CL_RI = new CL_Reinsurance_PC9(getDriver());
			CL_RI.SearchDraftPolicy(AccNum);
		}


		[Given(@"I update policy into REGISTRY from below scenario")]
		[When(@"I update policy into REGISTRY from below scenario")]
		[Then(@"I update policy into REGISTRY from below scenario")]
		public void GivenIUpdatePolicyIntoREGISTRYFromBelowScenario(Table table)
		{
			HomePage_PC9 AcctPolicy = new HomePage_PC9(getDriver());
			AcctPolicy.TbFromDbToRegistry(table);
		}

		[Given(@"I search for (.*) and update policy into REGISTRY")]
		[When(@"I search for (.*) and update policy into REGISTRY")]
		[Then(@"I search for (.*) and update policy into REGISTRY")]
		public void GivenISearchForScenarioNameAndUpdatePolicyIntoREGISTRY(string sScenarioName)
		{
			HomePage_PC9 AcctPolicy = new HomePage_PC9(getDriver());
			AcctPolicy.FromDbToRegistry(sScenarioName);
		}

		[When(@"I verify (.*) for CL Policy")]
		public void WhenIVerifyJewelersBlockForCLPolicy(string Offering)
		{
			HomePage_PC9 PCNavigation = new HomePage_PC9(getDriver());
			PCNavigation.verifyCLRenewal(Offering);
			//switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
			//{
			//	case "stage":
			//		int DateDiff = Convert.ToInt32(ScenarioContext.Current["DateDiff"]);
			//		PCNavigation.selectLeftNavMenu("documentspolicy");
			//		PCNavigation.CLRenewDocument(DateDiff, Offering);
			//		break;
			//	case "default":

			//		break;
			//}
		}

        [When(@"I click on PolicyInfoPage on the Left NavMenu Screen in PC9")]
        public void IClickOnPolicyInfoLeftBar()
        {
            HomePage_PC9 PCNavigationtoInfo = new HomePage_PC9(getDriver());
            Console.WriteLine("Clicking on Policy information link to page!");
            PCNavigationtoInfo.ClickOnPolicyInfo();
        }

        [When(@"I verify (.*) , (.*) , (.*), (.*) in Left Policy Info Page in partner mode for PC9")]
        public void IVerifyPolicyInfoPartner(string FirstName, string LastName, string Phone, string Email)
        {
            HomePage_PC9 PCPloicyInfo = new HomePage_PC9(getDriver());
            PCPloicyInfo.VerifyPolicyInfoParamsPartner(FirstName, LastName, Phone, Email);

        }

        [When(@"I verify (.*) in Left Policy Info Page in Internal mode for PC9")]
        public void IVerifyPolicyInfoPartner(string Email)
        {
            HomePage_PC9 PCPloicyInfo = new HomePage_PC9(getDriver());
            PCPloicyInfo.VerifyPolicyInfoParamsInternal(Email);

        }

        [When(@"I Cancel policy with below details in PC9")]
        public void WhenICancelPolicyWithBelowDetailsInPC9(Table table)
        {
            string sSource = table.Rows[0]["Source"];
            string sReason = table.Rows[0]["Reason"];
            string sReasonMethod = table.Rows[0]["ReasonMethod"];
            string sCancelEffDt = table.Rows[0]["CancelEffDate"];
            PolicyStartCancel_PC9 clPolicyStartCancel = new PolicyStartCancel_PC9(getDriver());
            clPolicyStartCancel.EnterDetailsForPolicyCancel(sSource, sReason, sReasonMethod, sCancelEffDt);
            System.Threading.Thread.Sleep(3000);
            clPolicyStartCancel.ClickStartCancellationPC9();
        }

        [When(@"I select reason on the start reinstatement page in PC9")]
        public void WhenISelectReasonOnTheStartReinstatementPageInPC(Table table)
        {
            string reinstatementReason = table.Rows[0]["ReinstatmentReason"];
            Console.WriteLine("reinstatementReason: " + reinstatementReason);
            PolicyReinstatement_PC9 plPolicyReinstatement = new PolicyReinstatement_PC9(getDriver());
            plPolicyReinstatement.setReinstateReason(reinstatementReason);
        }

        [When(@"I click Reinstate on the Policy reinstate Quote page")]
        public void WhenIClickReinstateOnThePolicyReinstateQuotePage()
        {
            PolicyReinstatemetQuoteAndIssue_PC9 plPolicyReinstatementQI = new PolicyReinstatemetQuoteAndIssue_PC9(getDriver());
            plPolicyReinstatementQI.clickReinstateButton();
        }


        [When(@"I click OK to confirm the policy Reinstatement")]
        public void WhenIClickOKToConfirmThePolicyReinstatement()
        {
            PolicyReinstatemetQuoteAndIssue_PC9 plPolicyReinstatementQI = new PolicyReinstatemetQuoteAndIssue_PC9(getDriver());
            plPolicyReinstatementQI.clickOKToConfirmReinstate();
        }

        [When(@"I answer question in UW Questions page in PC9")]
        public void WhenIAnswerQuestionInUWQuestionsPageInPC(Table table)
        {
            string communityInformation = table.Rows[0]["CommunityInformation"];
            string domesticHelpInformation = table.Rows[0]["DomesticHelpInformation"];
            string otherResidenceInformation = table.Rows[0]["OtherResidenceInformation"];
            string howOftenWornArticles = table.Rows[0]["HowOftenWornArticles"];
            string currentOccupation = table.Rows[0]["CurrentOccupation"];
            string travelOvernighIn12Month = table.Rows[0]["TravelOvernighIn12Month"];
            string cancelledOrDeniedByAnInsuranceCompany = table.Rows[0]["CancelledOrDeniedByAnInsuranceCompany"];
            AdditionalUWPC9 additionalUW = new AdditionalUWPC9(getDriver());
            additionalUW.Setlocationdetails(communityInformation, domesticHelpInformation, otherResidenceInformation, "whatever");
            additionalUW.SetContactDetails(howOftenWornArticles, currentOccupation, travelOvernighIn12Month);
        }

        [When(@"I Click next on UW Questions page in PC9")]
        public void WhenIClickNextOnUWQuestionsPageInPC()
        {
            AdditionalUWPC9 additionalUW = new AdditionalUWPC9(getDriver());
            additionalUW.ClickNextButton();
        }


        [When(@"I click on left navigation option in PC9")]
        public void WhenIClickOnLeftNavigationOptionInPC(Table table)
        {
            string option = table.Rows[0]["NavigationOption"];
            Console.WriteLine("option: " + option);
            HomePage_PC9 PCNavigationtoPayment = new HomePage_PC9(getDriver());
            switch (option.ToLower().Trim())
            {
                case "payment":
                    Console.WriteLine("Clicking on Payment link to page!");
                    PCNavigationtoPayment.ClickOnPayment();
                    break;
                case "risk analysis":
                    Console.WriteLine("Clicking on Risk Analysis link to page!");
                    PCNavigationtoPayment.ClickOnRiskAnalysis();
                    break;
                default:
                    break;
            }
        }

        [When(@"I verify there is (.*) payment paln")]
        public void WhenIVerifyThereIsPaymentPaln(int paymentPlan)
        {
            PaymentPlan paymentplan = new PaymentPlan(getDriver());
            paymentplan.VerifyIsPaymentPlan(paymentPlan);
        }

        [When(@"I verify there no (.*) payment paln")]
        public void WhenIVerifyThereNoPaymentPaln(int paymentPlan)
        {
            PaymentPlan paymentplan = new PaymentPlan(getDriver());
            paymentplan.VerifyNoPaymentPlan(paymentPlan);
        }


        [When(@"I navigate (.*) from the Account Tab menu of PC9")]
        public void WhenINavigateAccountsFromTheAccountTabMenuOfPC(string accountNumber)
        {
            HomePage_PC9 PCNavigationtoAccount = new HomePage_PC9(getDriver());
            PCNavigationtoAccount.NavigateAccount(accountNumber);
        }

        [When(@"I click on Transaction number link of Account detail screen in PC9")]
        public void WhenIClickOnTransactionNumberLinkOfAccountDetailScreenInPC()
        {
            HomePage_PC9 PCNavigationtoTransaction = new HomePage_PC9(getDriver());
            PCNavigationtoTransaction.ClickTransactionNumber();
        }

        [When(@"I select (.*) Pay on Payment plan page")]
        public void WhenISelectPayOnPaymentPlanPage(int payTimes)
        {
            PaymentPlan paymentplan = new PaymentPlan(getDriver());
            paymentplan.SelectPaymentPlan(payTimes);
        }

        [When(@"I see convict in recent (.*) years is recorded under Conviction tab on Risk Analysis Page in PC9")]
        public void WhenIVerifyAtLeastOneConvictedInRecentYearsUnderConvictionTabOnRiskAnalysisPageInPC(int years)
        {
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyConvictedInRecentYears(years, "vendor");
        }

        [When(@"I see convict in recent (.*) years is recorded manually under Conviction tab on Risk Analysis Page in PC9")]
        public void WhenISeeConvictInRecentYearsIsRecordedManullyUnderConvictionTabOnRiskAnalysisPageInPC(int years)
        {
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyConvictedInRecentYears(years, "manually");
        }

        [When(@"I do not see convict in recent (.*) years is recorded under Conviction tab on Risk Analysis Page in PC9")]
        public void WhenIDoNotSeeConvictedInRecentYearsUnderConvictionTabOnRiskAnalysisPageInPC(int years)
        {
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyNoConvictedInRecentYears(years, "vendor");
        }

        [When(@"I see (.*) is triggered under UW Issues tab on Risk Analysis Page in PC9")]
        [When(@"I see (.*) rule is triggered under UW Issues tab on Risk Analysis Page in PC9")]
        public void WhenIVerifyRuleIsTriggeredUnderUWIssuesTabOnRiskAnalysisPageInPC(string rule)
        {
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyUWRuleIsBlockingBind(rule);
        }
       // [When(@"I see (.*) is triggered under UW Issues tab on Risk Analysis Page in PC9")]
       // public void WhenISeeMisdemeanorIsTriggeredUnderUWIssuesTabOnRiskAnalysisPageInPC(string rule)
       // {
       //     RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
       //     riskAnalysis.VerifyUWRuleIsBlockingBind(rule);
       // }



        [When(@"I see (.*) rule is not triggered under UW Issues tab on Risk Analysis Page in PC9")]
        public void WhenIVerifyRuleIsNotTriggeredUnderUWIssuesTabOnRiskAnalysisPageInPC(string rule)
        {
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyNoUWRuleIsBlockingBind(rule);
        }

        [When(@"I click Conviction tab on Risk Analysis Page in PC9")]
        public void WhenIClickConvictionTabOnRiskAnalysisPageInPC()
        {
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.ClickConvictionTab();
        }


        [When(@"I see (.*) rule is triggered under UW Issues tab on Risk Analysis Page for PolicyChange in PC9")]
        public void WhenISeeMisdemeanorRuleIsTriggeredUnderUWIssuesTabOnRiskAnalysisPageForPolicyChangeInPC(string rule)
        {          
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyUWRuleIsBlockingBind(rule);
        }

        [When(@"I see (.*) rule is not triggered under UW Issues tab on Risk Analysis Page for PolicyChange in PC9")]
        public void WhenISeeMisdemeanorRuleIsNotTriggeredUnderUWIssuesTabOnRiskAnalysisPageForPolicyChangeInPC(string rule)
        {           
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyNoUWRuleIsBlockingBind(rule);
        }

        [When(@"I click Conviction tab on Risk Analysis Page for PolicyChange in PC9")]
        public void WhenIClickConvictionTabOnRiskAnalysisPageForPolicyChangeInPC()
        {          
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.ClickConvictionTab();
        }

        [When(@"I see convict in recent (.*) years is recorded under Conviction tab on Risk Analysis Page for PolicyChange in PC9")]
        public void WhenISeeConvictInRecentYearsIsRecordedUnderConvictionTabOnRiskAnalysisPageForPolicyChangeInPC(int years)
        {          
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyConvictedInRecentYears(years, "vendor");
        }

        [When(@"I do not see convict in recent (.*) years is recorded under Conviction tab on Risk Analysis Page for PolicyChange in PC9")]
        public void WhenIDoNotSeeConvictInRecentYearsIsRecordedUnderConvictionTabOnRiskAnalysisPageForPolicyChangeInPC(int years)
        {           
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyNoConvictedInRecentYears(years, "vendor");
        }

        [When(@"I do not see convict in recent (.*) years is recorded manually under Conviction tab on Risk Analysis Page in PC9")]
        public void WhenIDoNotSeeConvictInRecentYearsIsRecordedManuallyUnderConvictionTabOnRiskAnalysisPageInPC(int years)
        {
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.VerifyNoConvictedInRecentYears(years, "manually");
        }


        [When(@"I click Quote on Risk Analysis Page for policy change in PC9")]
        [When(@"I click Quote on Risk Analysis Page for policy rewrite in PC9")]
        public void WhenIClickQuoteOnRiskAnalysisPageForPolicyChangeInPC()
        {          
            RiskAnalysis_PC9 riskAnalysis = new RiskAnalysis_PC9(getDriver());
            riskAnalysis.ClickOnQuote();
        }

      
        [When(@"I click on left navigation option in PC9 for policy change")]
        [When(@"I click on left navigation option for policy rewrite in PC9")]
        public void WhenIClickOnLeftNavigationOptionForPolicyRewriteInPC(Table table)
        {
            string navigationOption = table.Rows[0]["NavigationOption"];
            HomePage_PC9 nvOption = new HomePage_PC9(getDriver());
            nvOption.selectLeftNavMenu(navigationOption);
        }

        [When(@"I click Risk tab on policy contact page in PC9")]
        public void WhenIClickRiskTabOnPolicyContactPageInPC()
        {
            PolicyContactsPC9 contacts = new PolicyContactsPC9(getDriver());
            contacts.ClickOnRiskTab();
        }

        [When(@"I add a record into Manually Reported Records table")]
        public void WhenIAddARecordIntoManuallyReportedRecordsTable(Table table)
        {
            string recordDate = table.Rows[0]["Record Date"];
            Console.WriteLine("recordDate: " + recordDate);
            string convictionType = table.Rows[0]["Conviction Type"];
            Console.WriteLine("recordconvictionType: " + convictionType);
            string convictionCategory = table.Rows[0]["Conviction Category"];
            Console.WriteLine("convictionCategory: " + convictionCategory);
            PolicyContactsPC9 contacts = new PolicyContactsPC9(getDriver());
            contacts.AddRecordsToManuallyReportTable(recordDate, convictionType, convictionCategory);
        }

        [Given(@"I go to (.*) page through administration")]
        public void GivenIGoToProducerCodePageThroughAdministration(string menuOption)
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.SelectFromAdministrationTab(menuOption);
        }

        [Given(@"I search a (.*) on the Producer Codes search page")]
        public void GivenISearchAF(string agencyCode)
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.SearchAgencyByCode(agencyCode);
        }

        [Given(@"I click on the producer link from the search result on the Producer Codes search page")]
        public void GivenIClickOnTheProducerLinkFromTheSearchResultOnTheProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.ClickProducerCode();
        }

        [Given(@"I click on Producer Availability tab on the Producer Code page")]
        public void GivenIClickOnProducerAvailabilityTabOnTheSpcificProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.ClickProductAvailabilityTab();
        }

        [Given(@"I click Edit button on the Producer Code page")]
        public void GivenIClickEditButtonOnTheProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.ClickEditButton();
        }

        [Given(@"I click Add button on the Producer Code page")]
        public void GivenIClickAddButtonOnTheProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.ClickAddButton();
        }

        [Given(@"I enter product details on the Producer Code page with (.*), (.*), (.*), (.*)")]
        public void GivenIEnterProductDetailsOnTheProducerCodePageWithCommercialLines(string product, string state, string effectiveDate, string expiryDate)
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.EnterProductDetails(product, state, effectiveDate, expiryDate);
        }      

        [Given(@"I click on update button on the Producer Code page")]
        public void GivenIClickOnUpdateButtonOnTheProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.ClickUpdateButton();
        }

        [Given(@"I see the products are entered successfully on the Producer Code page")]
        public void GivenISeeTheProductsAreEnteredSuccessfullyOnTheProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.NoErrorMessage();
        }

        [Given(@"I select the entered product on the Producer Code page")]
        public void GivenISelectTheEnteredProductOnTheProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.SelectEnteredProduct();
        }

        [Given(@"I delete the entered products on the Producer Code page")]
        public void GivenIDeleteTheEnteredProductsOnTheProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.ClickRemoveButton();
        }

        [Given(@"I do not see the products are entered successfully on the Producer Code page")]
        public void GivenIDoNotSeeTheProductsAreEnteredSuccessfullyOnTheProducerCodePage()
        {
            ProducerCode pCode = new ProducerCode(getDriver());
            pCode.ErrorMessage();
        }

        [When(@"I verify the taxes are prorated correctly")]
        public void WhenIVerifyTheTaxesAreProratedCorrectly()
        {
            PolicyQuotePC9 quote = new PolicyQuotePC9(getDriver());
            quote.VerifyTaxesAreProrated();
        }
    }
}

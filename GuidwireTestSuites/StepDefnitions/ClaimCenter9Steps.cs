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
using ClaimCenterPages;
using WebCommonCore;
//using ClaimCenterPages.Pages.Common;
using ClaimCenter9Pages;
using ClaimCenter9Pages.Pages.Common;
using ClaimCenter9Pages.Pages.CreateClaim;
using ClaimCenter9.Pages.Recovery;
using ClaimCenter9.Pages.Exposures;
using ClaimCenter9.Pages.Reinsurance;
using ClaimCenter9.Pages.CreateClaim;
using ClaimCenter9.Pages.Workplan;
using ClaimCenter9.Pages.ReopenClaim;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    public class ClaimCenter9Steps : TestBase
    {
        [Given(@"I enter (.*) and (.*) on the Login page of CC9")]
        [When(@"I enter (.*) and (.*) on the Login page of CC9")]
        public void IEnterAndOnTheLoginPageOfCC9(string userName, string passWord)
        {


            //loginPg.EnterLoginDetails(userName, password);

            CCLoginPage_CC9 loginPage = new CCLoginPage_CC9(getDriver());
			userName = System.Configuration.ConfigurationManager.AppSettings[userName];
			passWord = System.Configuration.ConfigurationManager.AppSettings[passWord];
			if (userName.ToString() == string.Empty)
			{
				Assert.Fail("UserName can't be empty or null");
			}
			else
			{
				if (ScenarioContext.Current.ContainsKey("GWCCUSER") == false)
				{
					ScenarioContext.Current.Add("GWCCUSER", userName);
				}
				else
				{
					if (ScenarioContext.Current["GWCCUSER"].ToString() != userName)
					{
						ScenarioContext.Current["GWCCUSER"] = userName;
					}
				}
			}
			loginPage.LoginIntoBC(userName, passWord);
		}

        [When(@"In CC9 I set the authority profile limit of (.*) to (.*)")]
        [Given(@"In CC9 I set the authority profile limit of (.*) to (.*)")]
        public void InCC9ISetTheAuthorityProfileLimitOfTo(string UserName, string Profile)
        {
            CCHomePage_CC9 cc9Home = new CCHomePage_CC9(getDriver());

            cc9Home.SelectTabMenu("Administration", "");

            CCAdminPage_CC9 cc9Admin = new CCAdminPage_CC9(getDriver());

			UserName = System.Configuration.ConfigurationManager.AppSettings[UserName];

			cc9Admin.SearchUserAndSetProfile(UserName, Profile);
		}

        [Given(@"In CC9 I set passwords and authority profiles for below users")]
        [When(@"In CC9 I set passwords and authority profiles for below users")]
        public void GivenInCCISetPasswordsAndAuthorityProfilesForBelowUsers(Table table)
        {
            CCHomePage_CC9 cc9Home = new CCHomePage_CC9(getDriver());

            cc9Home.SelectTabMenu("Administration", "");
            Console.WriteLine("rowCount:" + table.RowCount);
            CCAdminPage_CC9 cc9Admin = new CCAdminPage_CC9(getDriver());
            for (int i = 0; i < table.RowCount; i++)
            {
                cc9Admin.SearchUserAndSetProfile(table.Rows[i]["CCUserName"], table.Rows[i]["CCPassword"], table.Rows[i]["CCProfile"]);
            }
            //cc9Admin.SearchUserAndSetProfile(UserName, Profile, password);
        }

        [When(@"I Search for claim number (.*) on Claim Search Page of CC9")]
        public void WhenISearchForClaimNumberREGISTRYOnClaimSearchPageOfCC(string ClaimNumber)
        {
            string ClaimNum;
            DataStorage temp = new DataStorage();
            switch (ClaimNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    ClaimNum = temp.GetTempValue("CLAIMNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    ClaimNum = UFTRegKey.GetValue("CLAIMNO").ToString();
                    break;
                default:
                    ClaimNum = ClaimNumber;
                    break;
            }
            CCSearchClaimPage_CC9 ccSearchcc9 = new CCSearchClaimPage_CC9(getDriver());
            ccSearchcc9.SearchClaim(ClaimNum);
        }

        [When(@"I Verify If Claim Number is referred to correct policy number  (.*)  in Cc9")]
        [Then(@"I Verify If Claim Number is referred to correct policy number  (.*)  in Cc9")]
        public void ThenIVerifyIfClaimNumberIsReferredToCorrectPolicyNumberREGISTRYInCc(string policyNumber)
        {
            string PolicyNum;

            DataStorage temp = new DataStorage();
            switch (policyNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyNum = temp.GetTempValue("PLCYNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyNum = UFTRegKey.GetValue("PLCYNO").ToString();
                    break;
                default:
                    PolicyNum = policyNumber;
                    break;
            }
            CCSearchClaimPage_CC9 ccSearchcc9 = new CCSearchClaimPage_CC9(getDriver());
            ccSearchcc9.verifyPolivyClaimRefrence(PolicyNum);
        }

        [When(@"In CC9 I Create Unverified Policy")]
        public void InCC9ICreateUnverifiedPolicy(Table table)
        {
            SearchOrCreateUnverifiedPolicy_CC9 searchPolicy = new SearchOrCreateUnverifiedPolicy_CC9(getDriver());

            searchPolicy.CreateUnverfiedPolicy(table.Rows[0]["PolicyType"], table.Rows[0]["FirstName"], table.Rows[0]["Lastname"], table.Rows[0]["Address1"], table.Rows[0]["Zip"], table.Rows[0]["legcyPolicyNumber"]);
        }




        [Given(@"In CC9 I navigate to the (.*) Page")]
        [When(@"In CC9 I navigate to the (.*) Page")]
        public void InCC9INavigateToTheClaimNewClaimPage(string MenuOption)
        {
            string[] menuOption = MenuOption.Split(':');

            CCHomePage_CC9 ccHome9 = new CCHomePage_CC9(getDriver());

            ccHome9.SelectTabMenu(menuOption[0], menuOption[1]);
        }

        [When(@"In CC9 I Search for legecy policy (.*) on Policy Search Page")]
        [Then(@"In CC9 I Search for legecy policy (.*) on Policy Search Page")]
        public void InCC9ISearchForLegecyPolicySearchPage(string PolicyNumber)
        {
            DataStorage temp = new DataStorage();

            string policyNum = null;
            switch (PolicyNumber.ToUpper().Trim())
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
                    policyNum = PolicyNumber;
                    break;
            }

            SearchOrCreateUnverifiedPolicy_CC9 searchPolicy = new SearchOrCreateUnverifiedPolicy_CC9(getDriver());

            searchPolicy.SearchLegecyPolicy(policyNum);
        }




        [When(@"In CC9 I Search for the (.*) on Policy Search Page")]
        [Given(@"In CC9 I Search for the (.*) on Policy Search Page")]
        public void InCC9ISearchForTheREGISTRYOnPolicySearchPage(string PolicyNumber)
        {
            DataStorage temp = new DataStorage();

            string policyNum = null;
            switch (PolicyNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    policyNum = temp.GetTempValue("PLCYNO");
					string AcctNum = temp.GetTempValue("ACCNO");
					Console.WriteLine("Policy Number:" + policyNum);
					if (ScenarioContext.Current.ContainsKey("ACCOUNT") == false)
					{
						ScenarioContext.Current.Add("ACCOUNT", AcctNum);
					}
					if (ScenarioContext.Current.ContainsKey("POLICY") == false)
					{
						ScenarioContext.Current.Add("POLICY", policyNum);
					}
					break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    policyNum = UFTRegKey.GetValue("PLCYNO").ToString();
                    break;

                default:
                    policyNum = PolicyNumber;
                    break;
            }

            SearchOrCreateUnverifiedPolicy_CC9 searchPolicy = new SearchOrCreateUnverifiedPolicy_CC9(getDriver());

            searchPolicy.SearchPolicy(policyNum);
        }








        [When(@"In CC9 I Enter the (.*) and (.*) on the policy search page")]
        [Given(@"In CC9 I Enter the (.*) and (.*) on the policy search page")]
        public void InCC9IEnterTheAndCommerOnThePolicySearchPage(string LossDate, string TypeOfClaim)
        {
            SearchOrCreateUnverifiedPolicy_CC9 searchPolicy = new SearchOrCreateUnverifiedPolicy_CC9(getDriver());

            DataStorage tempData = new DataStorage();
            string tempLossDate = "";
            if (LossDate.ToUpper().Trim().Equals("CURRENT"))
            {
                tempLossDate = tempData.GetTempValue("TESTINGSYSTEMCLOCK");
            }
            else
            {
                tempLossDate = LossDate.Trim();
            }


            searchPolicy.EnterNewClaimDetails(tempLossDate, TypeOfClaim);
        }

        [Given(@"In CC9 I Enter below details for CL policy on search page")]
        [When(@"In CC9 I Enter below details for CL policy on search page")]
        public void WhenInCCIEnterBelowDetailsForCLPolicyOnSearchPage(Table table)
        {
            SearchOrCreateUnverifiedPolicy_CC9 searchPolicy = new SearchOrCreateUnverifiedPolicy_CC9(getDriver());

            DataStorage tempData = new DataStorage();

            string tempLossDate = tempData.GetTempValue("TESTINGSYSTEMCLOCK");

            searchPolicy.EnterNewClaimDetails(tempLossDate, table.Rows[0]["TypeofClaim"], table.Rows[0]["ClaimsMade"]);
        }

        [When(@"In CC9 I Enter the (.*) , (.*) on the Basic Information page")]
        [Given(@"In CC9 I Enter the (.*) , (.*) on the Basic Information page")]
        public void InCC9IEnterTheOnTheBasicInformationPage(string Name, string RelatedTo)
        {
            FNOLBasicInformation_CC9 basicInformation = new FNOLBasicInformation_CC9(getDriver());

            basicInformation.EnterBasicInformation(Name, RelatedTo);

        }

        [When(@"In CC9 I Enter below CL claim details on the Basic Information page")]
        public void WhenInCCIEnterBelowCLClaimDetailsOnTheBasicInformationPage(Table table)
        {
            //FNOLBasicInformation_CC9 basicInformation = new FNOLBasicInformation_CC9(getDriver());

            //basicInformation.EnterCLQuickClaimBasicInformation(table.Rows[0]["Name"], table.Rows[0]["RelatedToInsured"]);
            FNOLStep2CLQuickClaim_CC9 CLQuickClaimDetails = new FNOLStep2CLQuickClaim_CC9(getDriver());
            CLQuickClaimDetails.CLQuickClaimDetails(table);
            CLQuickClaimDetails.ClickFinishButton();
            CLQuickClaimDetails.SaveAndGotoClaim();
        }


        [When(@"In CC9 I Enter the (.*) and (.*) on the Claim Information Page")]
        [Given(@"In CC9 I Enter the (.*) and (.*) on the Claim Information Page")]
        public void InCC9IEnterTheAndOnTheClaimInformationPage(string claimDescription, string lossCause)
        {
            FNOLClaimInformation_CC9 claimInformation = new FNOLClaimInformation_CC9(getDriver());

            claimInformation.EnterClaimInformation(claimDescription, lossCause);

        }

        [When(@"In CC9 I Enter the Auto Assign to the Claim and Finish the Application")]
        [Given(@"In CC9 I Enter the Auto Assign to the Claim and Finish the Application")]
        public void InCC9IEnterTheAutoAssignToTheClaimAndFinishTheApplication()
        {
            FNOLSaveAndAssignClaim_CC9 SaveAndAssignClaim = new FNOLSaveAndAssignClaim_CC9(getDriver());

            SaveAndAssignClaim.FinishClaimInformation();

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "CLAIMNO", ScenarioContext.Current["CLAIM"].ToString());
        }





        [When(@"In CC9 I Pick (.*) from the Actions menu")]
        [Given(@"In CC9 I Pick (.*) from the Actions menu")]
        [Then(@"In CC9 I Pick (.*) from the Actions menu")]
        public void InCC9IPickAssignClaimFromTheActionsMenu(string ActionMenuItem)
        {
            CCHomePage_CC9 ccHomepage = new CCHomePage_CC9(getDriver());

            ccHomepage.SelectActionMenu(ActionMenuItem);
        }

        [Given(@"In CC9 I Assign the claim to (.*)")]
        [When(@"In CC9 I Assign the claim to (.*)")]
        public void InCC9IAssignTheClaimTo(string user)
        {
            AssignClaim_CC9 assignClaim = new AssignClaim_CC9(getDriver());

            assignClaim.AssignClaimAction(user);
        }

        [Given(@"IN CC9 I ReAssign the claim")]
        [When(@"IN CC9 I ReAssign the claim")]
        public void INCC9IReAssignTheClaim()
        {
            AssignClaim_CC9 assignClaim = new AssignClaim_CC9(getDriver());
            assignClaim.ReAssignClaimAction();
        }

        [When(@"In CC9 I Select (.*) from the New exposure page")]
        public void InCC9ISelectEmployeeDishonestyFromTheNewExposurePage(string ExposureType)
        {
            NewExposure_CC9 newExposure = new NewExposure_CC9(getDriver());

            newExposure.CreateExposures(ExposureType);
        }

        [When(@"I make below transaction on Explosures")]
        [Then(@"I make below transaction on Explosures")]
        public void ThenIMakeBelowTransactionOnExplosures(Table table)
        {
            ExposureTransactions_CC9 ReopenExposure = new ExposureTransactions_CC9(getDriver());
            ReopenExposure.RepoenCloseExposure(table);
        }

        [When(@"In CC9 Pick (.*) from the Actions menu")]
        public void InCC9PickFromTheActionsMenu(string ActionMenuItem)
        {
            CCHomePage_CC9 ccHomepage = new CCHomePage_CC9(getDriver());

            ccHomepage.SelectActionMenu(ActionMenuItem);
        }

        [When(@"In CC9 I click on return to Exposures")]
        public void InCC9IClickOnReturnToExposures()
        {
            NewExposure_CC9 newExposure = new NewExposure_CC9(getDriver());

            newExposure.ReturntoExposures();
        }

        [When(@"In CC9 I Add Reserves")]
        public void InCC9IAddReserves()
        {
            NewReserves_CC9 newReserves = new NewReserves_CC9(getDriver());

            newReserves.CreateReserves();
        }



        [When(@"In CC9 I set Reserve")]
        public void InCC9ISetReserve(Table table)
        {
			NewReserves_CC9 newReserves = new NewReserves_CC9(getDriver());
			newReserves.RemoveAllReserves();
			newReserves.SetReserves(table);
			newReserves.SaveReserves();
		}

        [When(@"In CC9 I set below Reserves for CL Policy")]
        public void WhenInCCISetBelowReservesForCLPolicy(Table table)
        {
            NewReserves_CC9 newReserves = new NewReserves_CC9(getDriver());
            newReserves.RemoveAllReserves();
            newReserves.SetReserves(table);
            newReserves.SaveReserves();
        }

        [When(@"I Update reserve with below details")]
        public void WhenIUpdateReserveWithBelowDetails(Table table)
        {
            NewReserves_CC9 newReserves = new NewReserves_CC9(getDriver());
            newReserves.RemoveAllReserves();
            newReserves.UpdateReserves(table);
            newReserves.SaveReserves();
        }

        [When(@"In CC9 I Save Reserve")]
        public void WhenInCCIAddReserve()
        {
            NewReserves_CC9 newReserves = new NewReserves_CC9(getDriver());
            newReserves.ClickSaveReserveButton();
        }

        [When(@"In CC9 I Update Coverage in Question (.*)")]
        [Then(@"In CC9 I Update Coverage in Question (.*)")]
        public void InCC9IUpdateCoverageInQuestionNo(string flag)
        {
            CCLossDetailsPage_CC9 LossDetails = new CCLossDetailsPage_CC9(getDriver());
            LossDetails.updateCoverageinQuestion(flag);
        }

        [Then(@"In CC(.*) I verify if claim is for legacy policy")]
        [When(@"In CC(.*) I verify if claim is for legacy policy")]
        public void WhenInCCIVerifyIfClaimIsForLegacyPolicy(int p0)
        {
            CCStatusPage_CC9 ccHome = new CCStatusPage_CC9(getDriver());
            ccHome.VerifyisClaimforLegecyPolicy();
        }



        [Then(@"In CC9 I select (.*) from the left navigation menu")]
        [When(@"In CC9 I select (.*) from the left navigation menu")]
        public void InCC9ISelectFromTheLeftNavigationMenu(string leftNavMenuItem)
        {
            CCHomePage_CC9 ccHome = new CCHomePage_CC9(getDriver());

            ccHome.SelectLeftNavigationMenu(leftNavMenuItem);
        }

        [When(@"In CC9 I Add Jewelry Items")]
        public void WhenInCCIAddJewelryItems(Table table)
        {
            CCJewelryItemsPage_CC9 ccItem = new CCJewelryItemsPage_CC9(getDriver());
            ccItem.AddItems(table.Rows[0]["ItemClass"], table.Rows[0]["Description"], table.Rows[0]["Value"], table.Rows[0]["LocatedWith"]);
        }



        [When(@"In CC9 I Add a new contact")]
        public void InCC9IAddANewContact(Table table)
        {
            NewContact_CC9 newContact = new NewContact_CC9(getDriver());

            newContact.AddContactType(table.Rows[0]["ContactType"]);

            newContact.AddCLContactRole(table.Rows[0]["ContactRole"]);

            if (table.Rows[0]["ContactType"].ToLower() == "person")
            {
                newContact.AddPersonalContactDetails(table.Rows[0]["FirstName"], table.Rows[0]["LastName"], table.Rows[0]["TaxID"]);
            }
            else if ((table.Rows[0]["ContactType"].ToLower() == "company") || (table.Rows[0]["ContactType"].ToLower() == "vendor:jeweler"))
            {
                newContact.AddCompanyContactDetails(table.Rows[0]["CompanyName"], table.Rows[0]["TaxID"]);
            }

        }

        [When(@"In CC9 I Add a new contact for CL Claim")]
        public void WhenInCCIAddANewContactForCLClaim(Table table)
        {
            NewContact_CC9 newContact = new NewContact_CC9(getDriver());

            newContact.AddContactType(table.Rows[0]["ContactType"]);

            newContact.AddCLContactRole(table.Rows[0]["ContactRole"]);

            if (table.Rows[0]["ContactType"].ToLower() == "person")
            {
                newContact.AddPersonalContactDetails(table.Rows[0]["FirstName"], table.Rows[0]["LastName"], table.Rows[0]["TaxID"]);
            }
            else if (table.Rows[0]["ContactType"].ToLower() == "company")
            {
                newContact.AddCompanyContactDetails(table.Rows[0]["CompanyName"], table.Rows[0]["TaxID"]);
            }
            else if (table.Rows[0]["ContactType"].ToLower().Contains("jeweler"))
            {
                newContact.AddJewelryContactDetails(table.Rows[0]["CompanyName"], table.Rows[0]["TaxID"]);
            }


        }


        [When(@"In CC9 I create a new document for (.*)")]
        public void InCC9ICreateANewDocumentForCommercialLinesSmoke(string Assginedto)
        {
            NewDocument_CC9 newDocument = new NewDocument_CC9(getDriver());

            newDocument.CreateNewDocument(Assginedto);
        }

        [When(@"In CC9 I verify that the document is created")]
        [Then(@"In CC9 I verify that the document is created")]
        public void InCC9IVerifyThatTheDocumentIsCreated()
        {
            SearchDocument_CC9 searchDoc = new SearchDocument_CC9(getDriver());

            searchDoc.verifyDocument();
        }


        [When(@"I Enter Payee information")]
        [Then(@"I Enter Payee information")]
        public void IEnterPayeeInformation(Table table)
        {
            NewCheck_CC9 newCheck = new NewCheck_CC9(getDriver());
            newCheck.EnterPayeeInformation(table.Rows[0]["Name"], table.Rows[0]["Type"]);
        }

        [When(@"I Enter below payment information for CL Claim")]
        [Then(@"I Enter below payment information for CL Claim")]
        public void ThenIEnterBelowPaymentInformationForCLClaim(Table table)
        {
            NewCheck_CC9 newCheck = new NewCheck_CC9(getDriver());
            newCheck.EnterCLPaymentInformation(table);
        }

        [Then(@"I Enter below payment information for PL Claim")]
        [When(@"I Enter below payment information for PL Claim")]
        public void WhenIEnterBelowPaymentInformationForPLClaim(Table table)
        {
            NewCheck_CC9 newCheck = new NewCheck_CC9(getDriver());
            newCheck.EnterPLPaymentInformation(table);
        }


        [Then(@"I Eneter Payment Information")]
        [When(@"I Eneter Payment Information")]
        public void IEneterPaymentInformation(Table table)
        {
            NewCheck_CC9 newCheck = new NewCheck_CC9(getDriver());
            newCheck.EnetrPaymentInformation(table.Rows[0]["ReserveLineCategory"], table.Rows[0]["ReserveLine"], table.Rows[0]["PaymentType"], table.Rows[0]["AddtoDeductible"], table.Rows[0]["Amount"]);
        }

        [Then(@"I Enter CL Payment Information")]
        [When(@"I Enter CL Payment Information")]
        public void WhenIEnterCLPaymentInformation(Table table)
        {
            NewCheck_CC9 newCheck = new NewCheck_CC9(getDriver());
            newCheck.EnterCLPaymentInformation(table);
        }

        [Then(@"I Enetr Check Instructions")]
        [When(@"I Enetr Check Instructions")]
        public void ThenIEnetrCheckInstructions()
        {
            NewCheck_CC9 newCheck = new NewCheck_CC9(getDriver());
            newCheck.SetCheckInstructions();
        }


        [When(@"I Complete all Activities in workplan")]
        public void WhenICompleteAllActivitiesInWorkplan()
        {
            Workplan_CC9 CLWorkplan = new Workplan_CC9(getDriver());
            CLWorkplan.selectAllActivities();
            CLWorkplan.ClickCompleteButton();
        }


        [Then(@"In CC9 I close the claim")]
        public void InCC9ICloseTheClaim()
        {
            CloseClaim_CC9 closeClaim = new CloseClaim_CC9(getDriver());

            closeClaim.CloseCurrentClaim();
        }

        [When(@"In CC9 I close the claim with below details")]
        [Then(@"In CC9 I close the claim with below details")]
        public void ThenInCCICloseTheClaimWithBelowDetails(Table table)
        {
            CloseClaim_CC9 closeClaim = new CloseClaim_CC9(getDriver());

            closeClaim.CloseCurrentClaim(table);
        }
        [When(@"In CC9 I close the claim with below details and Verify its status")]
        [Then(@"In CC9 I close the claim with below details and Verify its status")]
        public void ThenInCCICloseTheClaimWithBelowDetailsAndVerifyItsStatus(Table table)
        {
            CloseClaim_CC9 closeClaim = new CloseClaim_CC9(getDriver());

            closeClaim.CloseCurrentClaim(table);
        }

        [Then(@"I verify the claim is in (.*) status")]
        public void ThenIVerifyTheClaimIsInStatus(string ClaimStatus)
        {
            CloseClaim_CC9 closeClaim = new CloseClaim_CC9(getDriver());

            closeClaim.VerifyClaimStatus(ClaimStatus);
        }


        [Then(@"In CC9 I enter below details to reopen claim")]
        [When(@"In CC9 I enter below details to reopen claim")]
        public void WhenInCCIEnterBelowDetailsToReopenClaim(Table table)
        {

            ReopenClaim_CC9 reopenClaim = new ReopenClaim_CC9(getDriver());

            reopenClaim.ReopenCurrentClaim(table);
        }

        [Then(@"I create recovery with below details")]
        [When(@"I create recovery with below details")]
        public void WhenICreateRecoveryWithBelowDetails(Table table)
        {
            Recovery_CC9 CreateRecovery = new Recovery_CC9(getDriver());

            CreateRecovery.AddRecovery(table);
        }

        [When(@"In CC9 I create a new document with below details")]
        public void WhenInCCICreateANewDocumentWithBelowDetails(Table table)
        {
            NewDocument_CC9 newDocument = new NewDocument_CC9(getDriver());

            newDocument.SubmitNewDocument(table);
        }

        [Then(@"In CC9 I verify below Activity")]
        public void ThenInCCIVerifyBelowActivity(Table table)
        {
            Workplan_CC9 CLWorkplan = new Workplan_CC9(getDriver());
            CLWorkplan.verifyActivity(table);
        }
        [When(@"In CC(.*) I validate below details on Reinsurance Financials Summary page")]
        public void WhenInCCIValidateBelowDetailsOnReinsuranceFinancialsSummaryPage(int p0, Table table)
        {

            CL_Reinsurance_CC9 ValidateCLReinsuranceFinancials = new CL_Reinsurance_CC9(getDriver());
            ValidateCLReinsuranceFinancials.ValidateCLReinsuraceDetails(table);
        }
        [Then(@"In CC9 I verify CM CC integration for (.*)")]
        [When(@"In CC9 I verify CM CC integration for (.*)")]
        public void WhenInCCIVerifyCMCCIntegrationFor(string p1)
        {
            NewContact_CC9 VerifyCMCCIntegration = new NewContact_CC9(getDriver());
            VerifyCMCCIntegration.verifyContactManagerIntegeration();
        }

        [Given(@"I Logout of the Claim Center application")]
        [Then(@"I Logout of the Claim Center application")]
        [When(@"I Logout of the Claim Center application")]
        public void ThenILogoutOfTheClaimCenterApplication()
        {
            System.Threading.Thread.Sleep(5000);

            CCHomePage_CC9 bCHomePage = new CCHomePage_CC9(getDriver());

            bCHomePage.LogoutOfCC();
            KillWEbDriver();

            ScenarioContext.Current.Remove("WebDriver");
        }
		
		[When(@"I click on ClaimyNo of Claim Search Page of CC(.*)")]
        public void WhenIClickOnClaimyNoOfClaimSearchPageOfCC(int p0)
        {
            CCSearchClaimPage_CC9 ccSearchcc9 = new CCSearchClaimPage_CC9(getDriver());
            ccSearchcc9.ClickonClaim();
        }
		[When(@"In CC9 I create New exposure with below detals")]
		public void WhenInCCICreateNewExposureWithBelowDetals(Table table)
		{
			NewExposure_CC9 newExposure = new NewExposure_CC9(getDriver());

			newExposure.CreateExposures(table);
		}
	}
}

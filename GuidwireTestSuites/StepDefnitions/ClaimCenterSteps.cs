using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using GuidewireTestSuites.UIScreenMapping;
using TechTalk.SpecFlow.Assist;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using WebCommonCore;
using ClaimCenterPages.Pages.Common;
using ClaimCenterPages.Pages.CreateClaim;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class ClaimCenterSteps : TestBase
    {
        [Given(@"I set the authority profile limit of (.*) to (.*)")]
        public void SetTheAuthorityProfileLimitForUser(string UserName, string Profile)
        {
            CCHomePage ccHome = new CCHomePage(getDriver());

            ccHome.SelectTabMenu("Administration", "");

            CCAdminPage ccAdmin = new CCAdminPage(getDriver());

            ccAdmin.SearchUserAndSetProfile(UserName, Profile);
        }




        [Given(@"I navigate to the (.*) Page")]
        public void INavigateToTheNewClaimPage(string MenuOption)
        {
            string[] menuOption = MenuOption.Split(':');

            CCHomePage ccHome = new CCHomePage(getDriver());

            ccHome.SelectTabMenu(menuOption[0], menuOption[1]);
        }



        [When(@"I Search for the (.*) on Policy Search Page")]
        public void SearchForPolicy(string PolicyNumber)
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
                //    case "PL-REGISTRY":
                //       policyNum = temp.GetTempValue("PL_POLICY");
                //        break;
                default:
                    policyNum = PolicyNumber;
                    break;
            }

            SearchOrCreateUnverifiedPolicy searchPolicy = new SearchOrCreateUnverifiedPolicy(getDriver());

            searchPolicy.SearchPolicy(policyNum);


        }

        [When(@"I Enter the (.*) and (.*) on the policy search page")]
        public void IEnterClaimDetailsOnThePolicySearchPage(string LossDate, string TypeOfClaim)
        {
            SearchOrCreateUnverifiedPolicy searchPolicy = new SearchOrCreateUnverifiedPolicy(getDriver());

            DataStorage tempData = new DataStorage();

            string tempLossDate = tempData.GetTempValue("TESTINGSYSTEMCLOCK");

            //  searchPolicy.EnterNewClaimDetails(LossDate, TypeOfClaim);

            searchPolicy.EnterNewClaimDetails(tempLossDate, TypeOfClaim);



        }

        [When(@"I Enter the (.*) , (.*) on the Basic Information page")]
        public void WhenIEnterOnTheBasicInformationPage(string Name, string RelatedTo)
        {
            FNOLBasicInformation basicInformation = new FNOLBasicInformation(getDriver());

            basicInformation.EnterBasicInformation("1", "1");

        }


        [When(@"I Enter the (.*) and (.*) on the Claim Information Page")]
        public void WhenIEnterOnTheClaimInformationPage(string claimDescription, string lossCause)
        {
            FNOLClaimInformation claimInformation = new FNOLClaimInformation(getDriver());

            claimInformation.EnterClaimInformation(claimDescription, lossCause);

        }

        [When(@"I Enter the Auto Assign to the Claim and Finish the Application")]
        public void WhenIEnterTheAutoAssignToTheClaimAndFinishTheApplication()
        {
            FNOLSaveAndAssignClaim SaveAndAssignClaim = new FNOLSaveAndAssignClaim(getDriver());

            SaveAndAssignClaim.FinishClaimInformation();

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "CLAIMNO", ScenarioContext.Current["CLAIM"].ToString());
        }

        [When(@"I Pick (.*) from the Actions menu")]
        [Then(@"I Pick (.*) from the Actions menu")]
        public void WhenIPickFromTheActionsMenu(string ActionMenuItem)
        {
            CCHomePage ccHomepage = new CCHomePage(getDriver());

            ccHomepage.SelectActionMenu(ActionMenuItem);
        }


        [When(@"I Assign the claim")]
        public void WhenIAssignTheClaim()
        {
            AssignClaim assignClaim = new AssignClaim(getDriver());

            assignClaim.AssignClaimAction();


        }

        [When(@"I ReAssign the claim")]
        public void WhenIReAssignTheClaim()
        {
            AssignClaim assignClaim = new AssignClaim(getDriver());

            assignClaim.ReAssignClaimAction();
        }


        [When(@"I Select (.*) from the New exposure page")]
        public void WhenISelectFromTheNewExposurePage(string ExposureType)
        {
            NewExposure newExposure = new NewExposure(getDriver());

            newExposure.CreateExposures(ExposureType);


        }


        [When(@"I Add Reserves")]
        public void WhenIAddReserves()
        {
            NewReserves newReserves = new NewReserves(getDriver());

            newReserves.CreateReserves();

        }

        [When(@"I select (.*) from the left navigation menu")]
        [Then(@"I select (.*) from the left navigation menu")]
        public void WhenISelectFromTheLeftNavigationMenu(string leftNavMenuItem)
        {
            CCHomePage ccHome = new CCHomePage(getDriver());

            ccHome.SelectLeftNavigationMenu(leftNavMenuItem);

        }

        [When(@"I Add a new contact")]
        public void WhenIAddANewContact()
        {
            NewContact newContact = new NewContact(getDriver());

            newContact.AddContactType("Person");

            newContact.AddContactRole("Vendor");

            newContact.AddContactDetails("SeleniumFname", "SeleniumLname", "213121334");


        }

        [When(@"I create a new document")]
        public void CreateANewDocument()
        {
            NewDocument newDocument = new NewDocument(getDriver());

            newDocument.CreateNewDocument();
        }

        [Then(@"I verify that the document is created")]
        public void ThenIVerifyThatTheDocumentIsCreated()
        {
            //switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            //{
            //    case "stage":
                    SearchDocument searchDoc = new SearchDocument(getDriver());
                    searchDoc.verifyDocument();
                //    break;
                //default:
            //        Console.WriteLine("############################ - WARNING: DOCUMENTS verification is not done in {0} Environment - ############", ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
            //        break;
            //}

        }

        [Then(@"I make a payment")]
        public void MakeAPayment()
        {
            NewCheck newCheck = new NewCheck(getDriver());

            newCheck.CheckPayment();
        }

        [Then(@"I close the claim")]
        public void ThenICloseTheClaim()
        {
            CloseClaim closeClaim = new CloseClaim(getDriver());

            closeClaim.CloseCurrentClaim();
        }

        [Given(@"I manage Claim Center Transport")]
        public void GivenIManageClaimCenterTransport()
        {
            CCHomePage ccHome = new CCHomePage(getDriver());
            ccHome.SelectTabMenu("Administration", "");
            CCAdminPage ccAdmin = new CCAdminPage(getDriver());
            ccAdmin.ManageTransport();

        }

        [When(@"I Search for claim number (.*) on Policy Search Page")]
        public void SearchForClaim(string ClaimNumber)
        {
            DataStorage temp = new DataStorage();


            {
                string claimNum = null;
                switch (ClaimNumber.ToUpper().Trim())
                {
                    case "REGISTRY":
                        claimNum = temp.GetTempValue("PL_CLAIM");
                        break;
                    case "UFTREGISTRY":
                        RegistryKey UFTRegKey;
                        UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                        claimNum = UFTRegKey.GetValue("CLAIMNO").ToString();
                        break;
                    //    case "PL-REGISTRY":
                    //       policyNum = temp.GetTempValue("PL_POLICY");
                    //        break;
                    default:
                        claimNum = ClaimNumber;
                        break;
                }

                CCHomePage searchClaim = new CCHomePage(getDriver());

                searchClaim.searchClaimNumberUsingClaimTab(claimNum);

            }
        }


        [Then(@"I Verify If Claim Number is referred to policy  (.*)")]
        [When(@"I Verify If Claim Number is referred to policy  (.*)")]
        public void ThenIVerifyIfClaimNumberIsReferredToPolicyREGISTRY(string PolicyNumber)
        {
            DataStorage temp = new DataStorage();


            {
                string PolicyNum = null;
                switch (PolicyNumber.ToUpper().Trim())
                {
                    case "REGISTRY":
                        PolicyNum = temp.GetTempValue("PLCYNO");
                        break;
                    case "UFTREGISTRY":
                        RegistryKey UFTRegKey;
                        UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                        PolicyNum = UFTRegKey.GetValue("PLCYNO").ToString();
                        break;
                    //case "PL-REGISTRY":
                    //    PolicyNum = temp.GetTempValue("PL_POLICY");
                    //    break;
                    default:
                        PolicyNum = PolicyNumber;
                        break;
                }
                CCHomePage searchClaim = new CCHomePage(getDriver());
                Console.WriteLine("Policy Number to verify is " + PolicyNum);
                searchClaim.verifyCalimTaggedToPolicy(PolicyNum);

            }


        }

    }
}

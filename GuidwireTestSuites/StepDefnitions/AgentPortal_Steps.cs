using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WebCommonCore;
using HelperClasses;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using PolicyCenterPages;
using Microsoft.Win32;
using AutomationFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgencyAutomationPages.Pages;


namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    public sealed class AgentPortal_Steps : TestBase
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"I access the AgentAutomation app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        public void GivenIAccessTheAgentAutomationAppIn(string ApplicationEnvironment, string TargetType, string Capability, string BrowserType, string OperatingSystem)
        {
            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];

            ScenarioContext.Current["Application"] = ApplicationEnvironment;

            ScenarioContext.Current["TargetType"] = TargetType;

            ScenarioContext.Current["Capability"] = Capability;

            ScenarioContext.Current["BrowserType"] = BrowserType;

            if (TargetType.ToLower() != "desktop")
            {
                startBrowserStackLocal();

                System.Threading.Thread.Sleep(10000);
            }
        }

        [When(@"I login with (.*) and (.*) in  AgentPortal")]
        public void WhenILoginWithAndInAgentPortal(string username, string password)
        {
            AgentPortalLogin login = new AgentPortalLogin(getDriver());
            login.EnterLoginDetails(username, password);
        }

        [When(@"I click on Top Navigation option in Agent Portal")]
        public void WhenIClickOnTopNavigationOptionInAgentPortal(Table table)
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.clickonTopNavigationOption(table.Rows[0]["NavigationOption"]);
        }

        [When(@"I click on Advanced Search option in Agent Portal")]
        public void WhenIClickOnAdvancedSearchOptionInAgentPortal()
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.clickonAdvancedSearch();
        }


        [When(@"I click on Master Agent Profile Link")]
        public void WhenIClickOnMasterAgentProfileLink()
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.ClickMasterAgentProfile();
        }


        [When(@"I click on Edit password link")]
        public void WhenIClickOnEditPasswordLink()
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.ClickEditPassword();
        }


        [When(@"I click on Manage my profile option in Agent Portal landing")]
        public void WhenIClickOnManageMyProfileOptionInAgentPortalLanding()
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.clickManageMyProfile();
        }

        [When(@"I verify if Users and Permissions tab is displayed")]
        public void WhenIVerifyIfUsersAndPermissionsTabIsDisplayed(Table table)
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.VerifyIfUsersAndPermissionsTab(table.Rows[0]["DisplayedFlag"]);
        }

        [When(@"I Manage left Navigation option in Agent Portal")]
        public void WhenIManageLeftNavigationOptionInAgentPortal(Table table)
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.ManageleftNavigation(table.Rows[0]["NavigationOption"]);
        }

        [When(@"I Manage Top Navigation option in Agent Portal")]
        public void WhenIManageTopNavigationOptionInAgentPortal(Table table)
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.clickonTopNavigationOption(table.Rows[0]["NavigationOption"]);

        }

        [When(@"I logoff Agent User")]
        public void WhenILogoffAgentUser()
        {
            AgentLanding AgentProfile = new AgentLanding(getDriver());
            AgentProfile.clicklogOff();
        }


        [When(@"I verify Agent name from MyProfile Page")]
        public void WhenIVerifyAgentNameFromMyProfilePage()
        {
            AgentMyProfile MyProfile = new AgentMyProfile(getDriver());
            MyProfile.VerifyAgentName();
        }

        [When(@"I select Producer from MyProfile Page")]
        public void WhenISelectProducerFromMyProfilePage(Table table)
        {
            AgentMyProfile MyProfile = new AgentMyProfile(getDriver());
            MyProfile.SelectProducer(table.Rows[0]["Producer"]);
        }

        [When(@"I subscribe Producer from MyProfile Page")]
        public void WhenISubscribeProducerFromMyProfilePage(Table table)
        {
            AgentMyProfile MyProfile = new AgentMyProfile(getDriver());
            MyProfile.SubscribeProducer(table.Rows[0]["Producer"]);
        }

        [When(@"I save Changes in MyProfile Page")]
        public void WhenISaveChangesInMyProfilePage()
        {
            AgentMyProfile MyProfile = new AgentMyProfile(getDriver());
            MyProfile.SaveChanges();
        }

        [When(@"I Update Contact information in My profile screen")]
        public void WhenIUpdateContactInformationInMyProfileScreen(Table table)
        {
            AgentMyProfile MyProfile = new AgentMyProfile(getDriver());
           MyProfile.UpdateContactInfo(table.Rows[0]["PhoneType"], table.Rows[0]["WorkPhone"], table.Rows[0]["CellPhone"], table.Rows[0]["Fax"], table.Rows[0]["Email"]);
        }


        [When(@"I Get username from MyProfile Page")]
        public void WhenIGetUsernameFromMyProfilePage()
        {
            AgentMyProfile MyProfile = new AgentMyProfile(getDriver());
            MyProfile.GetAgentName();
        }

        [When(@"I select Agent from profile managment table in User and Permission Page")]
        public void WhenISelectAgentFromProfileManagmentTableInUserAndPermissionPage()
        {
            AgentUsersandPermissions UserPermission = new AgentUsersandPermissions(getDriver());
            UserPermission.SearchAgent();
        }


        [When(@"I search Agent in User and Permission section")]
        public void WhenISearchAgentInUserAndPermissionSection(Table table)
        {
            AgentUsersandPermissions UserPermission = new AgentUsersandPermissions(getDriver());
            UserPermission.SearchAgentRole(table.Rows[0]["Role"]);
        }

        [When(@"I verify Agent access type for the role")]
        public void WhenIVerifyAgentAccessTypeForTheRole(Table table)
        {
            AgentUsersandPermissions UserPermission = new AgentUsersandPermissions(getDriver());
            UserPermission.VerifyAgentAccessType(table.Rows[0]["Role"], table.Rows[0]["Access"]);
        }

        [When(@"I set access type for Profile Managment")]
        public void WhenISetAccessTypeForProfileManagment(Table table)
        {
            AgentUsersandPermissions UserPermission = new AgentUsersandPermissions(getDriver());
            UserPermission.ResetProfileManagmentAccessType(table.Rows[0]["Admin"], table.Rows[0]["Read"], table.Rows[0]["ProducerAdmin"]);
        }



        [When(@"I verify Agent access type for Profile Managment")]
        public void WhenIVerifyAgentAccessTypeForProfileManagment(Table table)
        {
            AgentUsersandPermissions UserPermission = new AgentUsersandPermissions(getDriver());
            UserPermission.VerifyProfileManagmentAccessType(table.Rows[0]["Admin"], table.Rows[0]["Read"], table.Rows[0]["ProducerAdmin"]);
        }

        [When(@"I verify Agent access type for Inquiry")]
        public void WhenIVerifyAgentAccessTypeForInquiry(Table table)
        {
            AgentUsersandPermissions UserPermission = new AgentUsersandPermissions(getDriver());
            UserPermission.VerifyInquiryAccessType(table.Rows[0]["Read"], table.Rows[0]["FNOL"]);
        }

        [When(@"I verify Agent access type for Reports")]
        public void WhenIVerifyAgentAccessTypeForReports(Table table)
        {
            AgentUsersandPermissions UserPermission = new AgentUsersandPermissions(getDriver());
            UserPermission.VerifyReportAccessType(table.Rows[0]["LossRun"], table.Rows[0]["RenewalStatus"], table.Rows[0]["CommissionStatement"], table.Rows[0]["AgencyAlmanc"], table.Rows[0]["NewBusiness"], table.Rows[0]["CLInformcePolicyListing"]);
        }

        [When(@"I verify Reports displayed in Report section")]
        public void WhenIVerifyReportsDisplayedInReportSection(Table table)
        {
            ReportsPage Reports = new ReportsPage(getDriver());
            Reports.VerifyReportName(table.Rows[0]["Reports"]);
        }


        [When(@"I click Add user button in User and Permission Page")]
        public void WhenIClickAddUserButtonInUserAndPermissionPage()
        {
            AgentUsersandPermissions UserPermission = new AgentUsersandPermissions(getDriver());
            UserPermission.clickAddUser();
            
        }

        [When(@"I delete Added user in User and Permission Page")]
        public void WhenIDeleteAddedUserInUserAndPermissionPage()
        {
            AgentDelUser DelUser = new AgentDelUser(getDriver());
            DelUser.DeleteAddedUser();
        }


        [When(@"I add new user details in User and Permission Page")]
        public void WhenIAddNewUserDetailsInUserAndPermissionPage(Table table)
        {
            AgentAddUser UserPermission = new AgentAddUser(getDriver());
            UserPermission.AddUser(table.Rows[0]["FirstName"], table.Rows[0]["LastName"], table.Rows[0]["PhoneType"], table.Rows[0]["WorkPhone"], table.Rows[0]["CellPhone"], table.Rows[0]["Fax"], table.Rows[0]["Email"], table.Rows[0]["Producer"], table.Rows[0]["Subscribe"]);

        }

        [When(@"I click Edit button in MasterAgency")]
        public void WhenIClickEditButtonInMasterAgency(Table table)
        {
            MasterAgency MasterAgencyPage = new MasterAgency(getDriver());
            MasterAgencyPage.ClickonEditButton(table.Rows[0]["EditType"]);

        }


        [When(@"I Update Mailing address in Edit Address screen")]
        public void WhenIUpdateMailingAddressInEditAddressScreen(Table table)
        {
            AgentEditAddress AgentEditAddressPage = new AgentEditAddress(getDriver());
            AgentEditAddressPage.UpdateMailingAddress(table.Rows[0]["Address1"], table.Rows[0]["Address2"], table.Rows[0]["City"], table.Rows[0]["State"], table.Rows[0]["Zip"], table.Rows[0]["County"], table.Rows[0]["Country"]);
        }

        [When(@"I Update Primary address in Edit Address screen")]
        public void WhenIUpdatePrimaryAddressInEditAddressScreen(Table table)
        {
            AgentEditAddress AgentEditAddressPage = new AgentEditAddress(getDriver());
            AgentEditAddressPage.UpdatePrimaryAddress(table.Rows[0]["Address1"], table.Rows[0]["Address2"], table.Rows[0]["City"], table.Rows[0]["State"], table.Rows[0]["Zip"], table.Rows[0]["County"], table.Rows[0]["Country"], table.Rows[0]["Isprimary"], table.Rows[0]["AddressType"]);

        }

        [When(@"I save Edit address changes")]
        public void WhenISaveEditAddressChanges()
        {
            AgentEditAddress AgentEditAddressPage = new AgentEditAddress(getDriver());
            AgentEditAddressPage.saveChanges();

        }

        [When(@"I Update Contact information in Edit Contact information screen")]
        public void WhenIUpdateContactInformationInEditContactInformationScreen(Table table)
        {
            AgentEditConatctInfo AgentEditConatctInfoPage = new AgentEditConatctInfo(getDriver());
            AgentEditConatctInfoPage.UpdateContactInfo(table.Rows[0]["PhoneType"], table.Rows[0]["WorkPhone"], table.Rows[0]["CellPhone"], table.Rows[0]["Fax"], table.Rows[0]["Email"]);
        }

        [When(@"I save Edit contact information changes")]
        public void WhenISaveEditContactInformationChanges()
        {
            AgentEditConatctInfo AgentEditConatctInfoPage = new AgentEditConatctInfo(getDriver());
            AgentEditConatctInfoPage.saveChanges();
        }

        [When(@"I select Producer for MasterAgency")]
        public void WhenISelectProducerForMasterAgency(Table table)
        {
            MasterAgency MasterAgencyPage = new MasterAgency(getDriver());

            MasterAgencyPage.SelectProducer(table.Rows[0]["Producer"]);
        }

        [When(@"I select user for Producer Information")]
        public void WhenISelectUserForProducerInformation(Table table)
        {
            ProducerInformation ProducerInfoPage = new ProducerInformation(getDriver());

            ProducerInfoPage.SelectUser(table.Rows[0]["User"]);
        }

        [When(@"I verify user in master Agency")]
        public void WhenIVerifyUserInMasterAgency()
        {
            MasterAgency MasterAgencyPage = new MasterAgency(getDriver());

            MasterAgencyPage.VerifyUser();
        }

        [When(@"I Select Producer")]
        public void WhenISelectProducer(Table table)
        {
            ProducerInformation ProducerInfoPage = new ProducerInformation(getDriver());
            ProducerInfoPage.SelectProducer(table.Rows[0]["Producer"]);
        }

        [When(@"I verify Edit Button in Producer Information")]
        public void WhenIVerifyEditButtonInProducerInformation(Table table)
        {
            ProducerInformation ProducerInfoPage = new ProducerInformation(getDriver());
            ProducerInfoPage.VerifyEditButtoninProducerInformation(table.Rows[0]["AddressEdit"], table.Rows[0]["ContactInformationEdit"]);
        }


        [When(@"I verify Edit Button in Master Agency")]
        public void WhenIVerifyEditButtonInMasterAgency(Table table)
        {
            MasterAgency MasterAgencyPage = new MasterAgency(getDriver());
            MasterAgencyPage.VerifyEditButtoninMasterAgency(table.Rows[0]["AddressEdit"], table.Rows[0]["ContactInformationEdit"]);

        }

        [When(@"I search with below details")]
        public void WhenISearchWithBelowDetails(Table table)
        {
            AgentLanding SearchPolicy = new AgentLanding(getDriver());
            SearchPolicy.searchPolicy(table.Rows[0]["Searchby"],table.Rows[0]["ProducerCode"], table.Rows[0]["Offering"], table.Rows[0]["PolicyStatus"]);

        }

        [When(@"I search with below details in billing section")]
        public void WhenISearchWithBelowDetailsInBillingSection(Table table)
        {
            AgentLanding SearchPolicy = new AgentLanding(getDriver());
            SearchPolicy.searchBilling(table.Rows[0]["ProducerCode"], table.Rows[0]["PolicyStatus"]);

        }


        [When(@"I selct First account in Account search result table of AgentPortal")]
        public void WhenISelctFirstAccountInAccountSearchResultTableOfAgentPortal()
        {
            AgentLanding SearchPolicy = new AgentLanding(getDriver());
            SearchPolicy.clickAccountfromSearchTable();
        }

        [When(@"I selct First policy in Account search result table of AgentPortal")]
        public void WhenISelctFirstPolicyInAccountSearchResultTableOfAgentPortal()
        {
            AgentLanding SearchPolicy = new AgentLanding(getDriver());
            SearchPolicy.clickPolicyfromSearchTable();
          
        }
        // I selct fourth policy with avalable claim table of AgentPortal
        [When(@"I selct fourth policy with avalable claim table of AgentPortal")]
        public void WhenISelctFourthPolicyInAccountSearchResultTableOfAgentPortal()
        {
            AgentLanding SearchPolicy = new AgentLanding(getDriver());
            SearchPolicy.clickFourthPolicyfromSearchTable();

        }

        [When(@"I selct First policy in Billing search result table of AgentPortal")]
        public void WhenISelctFirstPolicyInBillingSearchResultTableOfAgentPortal()
        {
            AgentLanding SearchPolicy = new AgentLanding(getDriver());
            SearchPolicy.clickPolicyfromBillingSearchTable();
        }

        [When(@"I click on section of Policy Summary Billing")]
        public void WhenIClickOnSectionOfPolicySummaryBilling(Table table)
        {
            AgentBillingInformation AgentBilling = new AgentBillingInformation(getDriver());
            AgentBilling.clickLefttab(table.Rows[0]["section"]);
        }

        [When(@"I fetch Accountnumber, address, paymentplan and autopay from billing page")]
        public void WhenIFetchAccountnumberAddressPaymentplanAndAutopayFromBillingPage_()
        {
            AgentBillingInformation AgentBilling = new AgentBillingInformation(getDriver());
            AgentBilling.fetchBillingData();
        }



        [When(@"I fetch Accountname and PrimaryAddress from Accounts page of Agent inquiry")]
        public void IFetchAccountnameAndPrimaryAddressFromAccountsPageOfAgentInquiry()
        {
            AgentAccountInormation AccountInormation = new AgentAccountInormation(getDriver());
            AccountInormation.getAccountDetails();
        }


      

        [When(@"I fetch EffectiveDate , ExpirationDate, ProducerCode , ProducerName")]
        public void WhenIFetchEffectiveDateExpirationDateProducerCodeProducerName()
        {
            AgentPolicyInormation PolicyInormation = new AgentPolicyInormation(getDriver());
            PolicyInormation.getPolicyDetails();
        }

        [When(@"I enetr (.*) in Policy number text  in Search a Claim section")]
        public void IEnetrREGISTRYInPolicyNumberTextInSearchAClaimSection(string PolicyNumber)
        {
            AgentLanding SubmitClaim = new AgentLanding(getDriver());
            DataStorage temp = new DataStorage();
            string Policyno = null;

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
            SubmitClaim.searchClaim(Policyno);
        }

      



        [When(@"I enetr (.*) in Policy number text  in Submit a Claim section")]
        public void IEnetrInPolicyNumberTextInSubmitAClaimSection(string PolicyNumber)
        {
            AgentLanding SubmitClaim = new AgentLanding(getDriver());
            DataStorage temp = new DataStorage();
            string Policyno = null;

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
            SubmitClaim.setClaim(Policyno);

        }


        [When(@"I selct First policy in Claim search result table of AgentPortal")]
        public void WhenISelctFirstPolicyInClaimSearchResultTableOfAgentPortal()
        {
            AgentClaimInformation ClaimInformation = new AgentClaimInformation(getDriver());
            ClaimInformation.selectFirstPolicyForClaim();

        }

        [When(@"I set First Notice of Loss details for Agent portal")]
        public void WhenISetFirstNoticeOfLossDetailsForAgentPortal(Table table)
        {
            AgentClaimInformation ClaimInformation = new AgentClaimInformation(getDriver());
            DataStorage tempData = new DataStorage();
            string tempLossDate = "";
            if (table.Rows[0]["Date"].ToLower().Trim().Equals("current"))
            {
                tempLossDate = tempData.GetTempValue("TESTINGSYSTEMCLOCK");
            }
            else if (table.Rows[0]["Date"].ToLower().Trim().Equals("system"))
            {
                tempLossDate = ScenarioContext.Current["LossDate"].ToString();
            }
            else
            {
                tempLossDate = table.Rows[0]["Date"].Trim();
            }

            ClaimInformation.SetFirstNoticeofLose(tempLossDate, table.Rows[0]["LossDescription"], table.Rows[0]["LossCause"]);
        }


        [When(@"I submit First Notice of Loss details for Agent portal")]
        public void WhenISubmitFirstNoticeOfLossDetailsForAgentPortal()
        {
            AgentClaimInformation ClaimInformation = new AgentClaimInformation(getDriver());
            ClaimInformation.SubmitClaim();
        }

        [When(@"I verify if first notice of loss is recived")]
        public void WhenIVerifyIfFirstNoticeOfLossIsRecived()
        {
            AgentClaimInformation ClaimInformation = new AgentClaimInformation(getDriver());
            ClaimInformation.VerifyClaimisSubmitted();
        }

        [When(@"I get latest claim number from claim search")]
        public void IGetLatestClaimNumberFromClaimSearch()
        {
            AgentClaimSearch ClaimSearch = new AgentClaimSearch(getDriver());
            ClaimSearch.getLatestClaim();

        }

        [When(@"I get verify new claim number is added in claim search")]
        public void WhenIGetVerifyNewClaimNumberIsAddedInClaimSearch()
        {
            AgentClaimSearch ClaimSearch = new AgentClaimSearch(getDriver());
            ClaimSearch.newClaimAdded();
        }




    }
}

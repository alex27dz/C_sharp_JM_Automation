using HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using PolicyCenterPages;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PLPortalPages.Pages;
//using PLPortal.;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    public class PLPortal_Steps : TestBase
    {
        [When(@"I access the PLPOrtal app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        [Given(@"I access the PLPOrtal app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        public void GivenIAccessThePLPortalAppIn(string ApplicationEnvironment, string TargetType, string Capability, string BrowserType, string OperatingSystem)
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


        [Given(@"I access the remove regeistration app in PLReg , (.*) , (.*) , (.*) and (.*)")]
        [When(@"I access the remove regeistration app in PLReg , (.*) , (.*) , (.*) and (.*)")]
        public void IAccessTheRemoveRegeistrationAppInPLReg(string TargetType, string Capability, string BrowserType, string OperatingSystem)
        {
            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];
            ScenarioContext.Current["Application"] = "PLREG";
            //ScenarioContext.Current["Application"] = "PLREG";

            ScenarioContext.Current["TargetType"] = TargetType;

            ScenarioContext.Current["Capability"] = Capability;

            ScenarioContext.Current["BrowserType"] = BrowserType;

            if (TargetType.ToLower() != "desktop")
            {
                startBrowserStackLocal();

                System.Threading.Thread.Sleep(10000);
            };
        }

        [When(@"I unregister (.*)")]
        public void WhenIUnregister(string p0)
        {
            PLRemoveRegistration PLPortalUnregister = new PLRemoveRegistration(getDriver());
            PLPortalUnregister.PLUnregister(p0);
        }

        [When(@"I set PLPortal User (.*)")]
        public void WhenISetPLPortalUserPass(string password, Table table)
        {
            Login PortalLogin = new Login(getDriver());
            DataStorage temp = new DataStorage();
            string Account = null;
            string Email = null;
            switch (table.Rows[0]["Account"].ToUpper().Trim())
            {
                case "REGISTRY":
                    Account = temp.GetTempValue("ACCNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Account = UFTRegKey.GetValue("ACCNO").ToString();
                    break;
                default:
                    Account = table.Rows[0]["Account"]; ;
                    break;
            }
            switch (table.Rows[0]["Email"].ToUpper().Trim())
            {
                case "REGISTRY":
                    Email = temp.GetTempValue("EMAIL");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Email = UFTRegKey.GetValue("EMAIL").ToString();
                    break;
                default:
                    Email = Guid.NewGuid().ToString().Replace("-", "").Substring(1, 6) + table.Rows[0]["Email"];
                    break;
            }
            ScenarioContext.Current["ACCOUNT"] = Account;
            ScenarioContext.Current["PlPOrtalUserid"] = Email;
            ScenarioContext.Current["PLPortalPassword"] = password;

        }



        [When(@"I Register PLPortal User")]
        public void WhenIRegisterPLPortalUser(Table table)
        {
            Login PortalLogin = new Login(getDriver());
            DataStorage temp = new DataStorage();
            string Account = null;
            string FirstName = null;
            string LastName = null;
            string Zip = null;
            string Email = null;
            switch (table.Rows[0]["Account"].ToUpper().Trim())
            {
                case "REGISTRY":
                    Account = temp.GetTempValue("ACCNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Account = UFTRegKey.GetValue("ACCNO").ToString();
                    break;
                default:
                    Account = table.Rows[0]["Account"]; ;
                    break;
            }

            switch (table.Rows[0]["FirstName"].ToUpper().Trim())
            {
                case "REGISTRY":
                    FirstName = temp.GetTempValue("FNAME");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    FirstName = UFTRegKey.GetValue("FNAME").ToString();
                    break;
                default:
                    FirstName = table.Rows[0]["FirstName"];
                    break;
            }

            switch (table.Rows[0]["LastName"].ToUpper().Trim())
            {
                case "REGISTRY":
                    LastName = temp.GetTempValue("LNAME");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    LastName = UFTRegKey.GetValue("LNAME").ToString();
                    break;
                default:
                    LastName = table.Rows[0]["LastName"];
                    break;
            }
            switch (table.Rows[0]["Zip"].ToUpper().Trim())
            {
                case "REGISTRY":
                    Zip = temp.GetTempValue("ZIPCODE");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Zip = UFTRegKey.GetValue("ZIPCODE").ToString();
                    break;
                default:
                    Zip = table.Rows[0]["Zip"];
                    break;
            }

            switch (table.Rows[0]["Email"].ToUpper().Trim())
            {
                case "REGISTRY":
                    Email = temp.GetTempValue("EMAIL");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Email = UFTRegKey.GetValue("EMAIL").ToString();
                    break;
                default:
                    //Email = Guid.NewGuid().ToString().Replace("-", "").Substring(1, 6) + table.Rows[0]["Email"];
                  Email = table.Rows[0]["Email"];

                    break;
            }

            PortalLogin.RegisterNewUser(Account, FirstName, LastName, Zip, Email, table.Rows[0]["Password"]);

        }


        [When(@"I login to PlPortal")]
        public void WhenILoginToPlPOrtal()
        {
            Login PortalLogin = new Login(getDriver());
            PortalLogin.LoginToPLPortal();
        }

        [When(@"I Select paper less delivery option")]
        public void WhenISelectPaperLessDeliveryOption(Table table)
        {
            PolicyDetailes PortalPLDetails = new PolicyDetailes(getDriver());
            PortalPLDetails.MangePaperlessSetting(table.Rows[0]["PaperlessFlag"]);

        }

        [When(@"I verify correct policy number is displayed on My Policy screen")]
        public void WhenIVerifyCorrectPolicyNumberIsDisplayedOnMyPolicyScreen(Table table)
        {
            PolicyDetailes PortalPLDetails = new PolicyDetailes(getDriver());
            DataStorage temp = new DataStorage();
            string policyno;
            switch (table.Rows[0]["PolicyNumber"].ToUpper().Trim())
            {
                case "REGISTRY":
                    policyno = temp.GetTempValue("PLCYNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    policyno = UFTRegKey.GetValue("PLCYNO").ToString();
                    break;
                default:
                    policyno = table.Rows[0]["PolicyNumber"]; ;
                    break;
            }
            PortalPLDetails.VerifyPolicyNumber(policyno);
        }



        [When(@"I click on view details option of PL Portal")]
        public void WhenIClickOnViewDetailsOptionOfPLPortal()
        {
            PolicyDetailes PortalPLDetails = new PolicyDetailes(getDriver());
            PortalPLDetails.clickonvewDetailes();

        }

        [When(@"I click  on Policy detail menu option")]
        public void WhenIClickOnPolicyDetailMenuOption(Table table)
        {
            PolicyDetailes PortalPLDetails = new PolicyDetailes(getDriver());
            PortalPLDetails.clickonMenuOption(table.Rows[0]["PolicyMenu"]);

        }

        [When(@"I update personal information details in information section of PL Portal")]
        [Then(@"I update personal information details in information section of PL Portal")]
        public void WhenIUpdatePersonalInformationDetailsInInformationSectionOfPLPortal(Table table)
        {

            PersonalInformation PersonalInfo = new PersonalInformation(getDriver());
            PersonalInfo.UpdatePersonalInformation(table.Rows[0]["lastname"], table.Rows[0]["Email"], table.Rows[0]["Phonenumber"], table.Rows[0]["Address1"], table.Rows[0]["Address2"], table.Rows[0]["City"], table.Rows[0]["State"], table.Rows[0]["Zip"], table.Rows[0]["ISMailingAddressSame"]);
            if ((table.Rows[0]["ISMailingAddressSame"].ToLower().Trim()).Equals("no"))
            {
                PersonalInfo.UpdateMailingAddress(table.Rows[0]["MailingAddress1"], table.Rows[0]["MailingAddress2"], table.Rows[0]["MailingCity"], table.Rows[0]["MailingState"], table.Rows[0]["MailingZip"]);
            }
            PersonalInfo.ClickonSave();
            System.Threading.Thread.Sleep(5000);

        }


        [When(@"I Start a new Claim")]
        public void WhenIStartANewClaim(Table table)
        {

            SubmitClaim ClaimDetail = new SubmitClaim(getDriver());
            ClaimDetail.StartNewCliam(table.Rows[0]["LossDate"], table.Rows[0]["ItemDescription"], table.Rows[0]["LossType"], table.Rows[0]["LossCircumstances"], table.Rows[0]["Comments"]);
            //ClaimDetail.ClickContinue();
        }

        [When(@"I manage Preferred jeweler")]
        public void WhenIManagePreferredJeweler(Table table)
        {

            JewelerDetailes JewelerDetail = new JewelerDetailes(getDriver());
            JewelerDetail.UpdatePreferredJewelerInfo(table.Rows[0]["preferredjeweler"]);

            if (table.Rows[0]["preferredjeweler"].ToUpper().Trim() == "YES")
            {
                JewelerDetail.UpdateJewelrInformation(table.Rows[0]["JewelerName"], table.Rows[0]["JewelerAddress"], table.Rows[0]["JewelerCity"], table.Rows[0]["JewelerState"], table.Rows[0]["JewelerPhone"], table.Rows[0]["JewelerEmail"]);
            }
            JewelerDetail.ClickContinue();
        }

        [When(@"I submit Claim Contact information")]
        public void WhenISubmitClaimContactInformation(Table table)
        {
            ClaimContactDerailes ClaimContactDetail = new ClaimContactDerailes(getDriver());

            ClaimContactDetail.UpdateContactInformation(table.Rows[0]["ContactAddress1"], table.Rows[0]["ContactAddress2"], table.Rows[0]["ContactCity"], table.Rows[0]["ContactState"], table.Rows[0]["ContactPhone"], table.Rows[0]["ContactEmail"], table.Rows[0]["ContactZip"], table.Rows[0]["IsNewAddress"]);
            ClaimContactDetail.ClickSubmitClaim();
        }


        [When(@"I verify if claim is successfully submited")]
        public void WhenIVerifyIfClaimIsSuccessfullySubmited()
        {
            CommonPLPortal ClaimNotification = new CommonPLPortal(getDriver());
            System.Threading.Thread.Sleep(8000);
            ClaimNotification.GetClaimNumber();

            DataStorage tempData = new DataStorage();

            //  tempData.StoreTempValue("guidewire", "PL_Policy", ScenarioContext.Current["POLICY"].ToString());
            tempData.StoreTempValue("guidewire", "PL_CLAIM", ScenarioContext.Current["CLAIM"].ToString());
            tempData.StoreTempValue("guidewire", "CLAIMNO", ScenarioContext.Current["CLAIM"].ToString());

        }

        [When(@"I click on left navigation option")]
        public void WhenIClickOnLeftNavigationOption(Table table)
        {
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                case "qa4":
                case "qa6":
                case "qa15":
                case "qa1":
                case "qa2":
                    CommonPLPortal ManageLeftMenu = new CommonPLPortal(getDriver());
                    ManageLeftMenu.ManageleftNavigation(table.Rows[0]["NavigationOption"]);
                    break;

                default:
                    break;
            }
        }

        [When(@"I make PLPOrtal payment using Card")]
        public void WhenIMakePLPOrtalPaymentUsingCard(Table table)
        {
            Payment PLPayment = new Payment(getDriver());
            PLPayment.makePayment(table.Rows[0]["paymentMethod"], table.Rows[0]["Country"], table.Rows[0]["paymentAmount"], table.Rows[0]["PaymentType"], table.Rows[0]["paymentDate"]);

        }

        [When(@"I set AutoPay on")]
        public void WhenISetAutoPayOn()
        {
            Payment PLPayment = new Payment(getDriver());
            PLPayment.setAutoPay();

        }



        [When(@"I manage my Jewelry Item")]
        public void WhenIManageMyJewelryItem(Table table)
        {
            AddUpdateJewelryItem PLManageItem = new AddUpdateJewelryItem(getDriver());
            DataStorage temp = new DataStorage();
            string JewelryWearer;
            switch (table.Rows[0]["JewelryWearer"].ToUpper().Trim())
            {
                case "REGISTRY":
                    JewelryWearer = temp.GetTempValue("PRIMARY_INSURED");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    JewelryWearer = UFTRegKey.GetValue("PRIMARY_INSURED").ToString();
                    break;
                default:
                    JewelryWearer = table.Rows[0]["JewelryWearer"].Trim();
                    break;
            }


            PLManageItem.ClickonManageButton(table.Rows[0]["ActionType"]);

            if ((table.Rows[0]["ActionType"]).ToLower() == "add")
            {
                PLManageItem.AddJewelry((table.Rows[0]["JewelryType"]), (table.Rows[0]["ReplacingItem"]), (table.Rows[0]["ValuedDate"]), (table.Rows[0]["ReplacementValue"]), (table.Rows[0]["Deductible"]), JewelryWearer, (table.Rows[0]["JewelryStored"]), (table.Rows[0]["DateforCoverage"]), (table.Rows[0]["AdditionalInformation"]));


            }
            else
            {
                PLManageItem.UpdateJewelry(table.Rows[0]["ReplacementValue"], table.Rows[0]["ValuedDate"]);
            }


        }

        [When(@"I manage Additional Questions")]
        public void WhenIManageAdditionalQuestions(Table table)
        {
            AddJewelryConfirmation PLUWItem = new AddJewelryConfirmation(getDriver());
            PLUWItem.ManageAdditionalQuestions(table.Rows[0]["AdditionalQuestion"]);

        }



        [When(@"I click on Submit button of Review Add Jewelry screen")]
        public void WhenIClickOnSubmitButtonOfReviewAddJewelryScreen()
        {
            AddJewelryConfirmation ReviewItem = new AddJewelryConfirmation(getDriver());
            ReviewItem.ClickSubmit();
        }

        [Then(@"I waite for batch Cycle to execute")]
        [When(@"I waite for batch Cycle to execute")]
        public void ThenIWaiteForBatchCycleToExecute()
        {
            System.Threading.Thread.Sleep(120000);
        }

        [When(@"I waite for batch Cycle to execute for PC")]
        public void WhenIWaiteForBatchCycleToExecuteForPC()
        {
            System.Threading.Thread.Sleep(2000);
        }


        [When(@"I Verify if Item is added")]
        [Then(@"I Verify if Item is added")]
        public void ThenIVerifyIfItemIsAdded()
        {
            CommonPLPortal ItemConfirm = new CommonPLPortal(getDriver());
            ItemConfirm.VerifyJewelryAdded();
        }

        [When(@"I Upload a  (.*) apprisial in Pl Portal")]
        public void WhenIUploadAApprisialInPlPortal(int count)
        {
            CommonPLPortal UploadAApprisial = new CommonPLPortal(getDriver());
            UploadAApprisial.UploadApprisial(count);
        }


        [Then(@"I verify if Apprisial is uploaded")]
        [When(@"I verify if Apprisial is uploaded")]
        public void ThenIVerifyIfApprisialIsUploaded()
        {
            CommonPLPortal UploadAApprisial = new CommonPLPortal(getDriver());
            UploadAApprisial.VerifyApprisialUploaded();
        }
        [Given(@"I Kill Web Driver")]
        [When(@"I Kill Web Driver")]
        [Then(@"I Kill Web Driver")]
        public void WhenIKillWebDriver()
        {
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }


        [When(@"I enter the  Personal  History Details in UW question details for PL POrtal")]
        public void WhenIEnterThePersonalHistoryDetailsInUWQuestionDetailsForPLPOrtal(Table table)
        {
            AddJewelryConfirmation appAdditionalQuestions = new AddJewelryConfirmation(getDriver());
            appAdditionalQuestions.SetPersonalHistory(table.Rows[0]["DeniedCov"], table.Rows[0]["DeniedCovreason"]);
        }

        [When(@"I enter  for Jewelry Storage Details in UW question details for PL POrtal")]
        public void WhenIEnterForJewelryStorageDetailsInUWQuestionDetailsForPLPOrtal(Table table)
        {
            AddJewelryConfirmation appAdditionalQuestions = new AddJewelryConfirmation(getDriver());
            appAdditionalQuestions.SetJewelryStorage(table.Rows[0]["SafeDepositBox"], table.Rows[0]["CommunityGated"], table.Rows[0]["CommunityGated"], table.Rows[0]["HomeHasOtherResidents"], table.Rows[0]["JewelryWornFre"], table.Rows[0]["ReleationshiptoResident"]);


            if ((table.Rows[0]["SafeDepositBox"] == "Yes") || (table.Rows[0]["SafeDepositBox"] == "yes"))
            {
                appAdditionalQuestions.SetJewelryStorageDetails(table.Rows[0]["SafeDepositlocation"], table.Rows[0]["SafeDepositAddress"]);
            }
            if ((table.Rows[0]["CommunityGated"] == "Yes") || (table.Rows[0]["CommunityGated"] == "yes"))
            {
                //
                appAdditionalQuestions.SetGatedCommunityDetails(table.Rows[0]["FenceSurround"], table.Rows[0]["GuardAtGate"], table.Rows[0]["GuardPresent"], table.Rows[0]["CommunityPatrol"], table.Rows[0]["PatrolFrequency"], table.Rows[0]["HowyouEnterCommunity"], table.Rows[0]["HowGuestEnterCommunity"]);
            }
            if ((table.Rows[0]["DomesticHelp"] == "Yes") || (table.Rows[0]["DomesticHelp"] == "yes"))
            {

                appAdditionalQuestions.SetDomesticHelpDetails(table.Rows[0]["DomesticHelp"], table.Rows[0]["EmployeeLength"], table.Rows[0]["DomesticHelpResideHome"], table.Rows[0]["DomesticHelpFreq"]);
            }
        }

        [When(@"I enter Travel Details in UW question details for PL POrtal")]
        public void WhenIEnterTravelDetailsInUWQuestionDetailsForPLPOrtal(Table table)
        {
            AddJewelryConfirmation appAdditionalQuestions = new AddJewelryConfirmation(getDriver());
            appAdditionalQuestions.SetTavelDetails(table.Rows[0]["TravelOverNightFreq"], table.Rows[0]["TravelAbroad"], table.Rows[0]["TravelSafeGuard"], table.Rows[0]["TravelDescription"]);
            appAdditionalQuestions.ClickSaveContinue();

        }

        [Then(@"I verify if paperless Delivery is mamaged correctly in Account settings")]
        [When(@"I verify if paperless Delivery is mamaged correctly in Account settings")]
        public void ThenIVerifyIfPaperlessDeliveryIsMamagedCorrectlyInAccountSettings()
        {
            AccountSettings AccountSettings = new AccountSettings(getDriver());
            AccountSettings.ClickPaperlessButton();
            AccountSettings.VerifyPaperLessErrorMessage("canceled");
            AccountSettings.ClickPaperlessCheckBox();
            AccountSettings.ClickPaperlessButton();
            AccountSettings.VerifyPaperLessErrorMessage("set");
        }


        [Then(@"I click on Auto Pay  link in Account Settings")]
        [When(@"I click on Auto Pay  link in Account Settings")]
        public void ThenIClickOnAutoPayLinkInAccountSettings()
        {
            AccountSettings AccountSettings = new AccountSettings(getDriver());
            AccountSettings.ClickAutoPay();
        }






    }

}

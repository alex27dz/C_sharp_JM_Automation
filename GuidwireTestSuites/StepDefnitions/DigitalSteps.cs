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
using WebCommonCore;
using DigitalProject.Pages.Common;
using DigitalProject.Pages.Landing_Pages;
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
using DigitalProject.ClaimsApp;
using DigitalProject.Pages;
using DigitalProject.Pages.Business;
using DigitalProject.Pages.Personal;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using OpenQA.Selenium;
using DigitalProject.Pages.Drupal;
using DigitalProject.Pages.Drupal_Portal;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class DigitalSteps : TestBase
    {
        [When(@"I access on the home page of JewlersMutual")]
        [When(@"I access on the home page of JewlersMutual")]
        public void WhenIAccessOnTheHomePageOfJewlersMutual()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            System.Threading.Thread.Sleep(5000);
            jmHomePage.VerifyPage();
        }

        [Then(@"I Verify all the elements in the homepage are displayed")]
        public void ThenIVerifyAllTheElementsInTheHomepageAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.verifyAllHomePageContent();
        }

        [Then(@"I Verify all the elements in the header section are displayed")]
        public void ThenIVerifyAllTheLinksOnTheHeaderSectionAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.verifyAllHomePageContent();

        }

        [Then(@"I Verify all the elements in the about us page are displayed")]
        public void ThenIVerifyAllTheElementsInTheAboutUsPageAreDisplayed()
        {
            AboutUs_D aboutUs = new AboutUs_D(getDriver());
            aboutUs.verifyAllAboutUsPageContent();
        }


        [Then(@"I Verify all the elements in the Personal Insureance page are displayed")]
        public void ThenIVerifyAllTheElementsInThePersonalInsureancePageAreDisplayed()
        {
            PersonalInsurance_D persInsurance = new PersonalInsurance_D(getDriver());
            persInsurance.verifyAllPersonalInsurancePageContent();
        }


        [Then(@"I Verify all the elements in the claims page are displayed")]
        public void ThenIVerifyAllTheElementsInTheClaimsPageAreDisplayed()
        {
            Claims_D claimsPage = new Claims_D(getDriver());
            claimsPage.verifyAllClaimsPageContent();
        }

        [Then(@"I Verify all the elements in the footer section are displayed")]
        public void ThenIVerifyAllTheLinksOnTheFooterSectionAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.verifyFooter();
        }


        [Then(@"I verify all the elements in the check your rate section are displayed")]
        public void ThenIVerifyAllTheElementsInTheCheckYourRateSectionAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.verifycheckYourRate();
        }

        [Then(@"I verify all the elements in the personal policy center section are displayed")]
        public void ThenIVerifyAllTheElementsInThePersonalPolicyCenterSectionAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.verifyPersonalPolicyCenter();
        }

        [Then(@"I verify all the elements in the check rate section are displayed")]
        public void ThenIVerifyAllTheElementsInTheCheckRateSectionAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            //jmHomePage.verifyCheckRate();
        }

        [Then(@"I verify all the elements in the expertise section are displayed")]
        public void ThenIVerifyAllTheElementsInTheEspertiseSectionAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.verifyexpertiseSince1913();
        }

        [Then(@"I verify all the elements in the testimonial section are displayed")]
        public void ThenIVerifyAllTheElementsInTheTestimonialSectionAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.verifyDarrylTestimonial();
        }

        [Then(@"I verify all the elements in the trust section are displayed")]
        public void ThenIVerifyAllTheElementsInTheTrustSectionAreDisplayed()
        {
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.verifyItAllComesDownToTrust();
        }

        [Then(@"I select the (.*) on homepage")]
        [When(@"I select the (.*) on homepage")]
        public void WhenISelectTheLinkOnHomepage(string linkToClick)
        {
            Home_D jmHomePage = new Home_D(getDriver());
            Console.WriteLine("selecting link to navigate");
            jmHomePage.selectLinkToNavigate(linkToClick);

        }

        [Then(@"I Verify all the elements in the Jewelry Business page are displayed")]
        public void ThenIVerifyAllTheElementsInTheJewelryBusinessPageAreDisplayed()
        {
            JewelryBusiness_D jewelryBusiness = new JewelryBusiness_D(getDriver());
            jewelryBusiness.verifyAllJewelryBusinessPageContent();
        }

        [Then(@"I Verify all the elements in the JMUniversity page are displayed")]
        public void ThenIVerifyAllTheElementsInTheJMUniversityPageAreDisplayed()
        {
            JMUniversity_D JMUniversity_D = new JMUniversity_D(getDriver());
            JMUniversity_D.verifyJMUniversityPageContent();

        }

        [Then(@"I Verify all the elements in the Jeweler Programs page are displayed")]
        public void ThenIVerifyAllTheElementsInTheJewelerProgramsPageAreDisplayed()
        {
            JewelerPrograms_D jewelersPrograms = new JewelerPrograms_D(getDriver());
            jewelersPrograms.verifyAllJewelerProgramsPageContent();
        }


        [Then(@"I navigate back to the home page")]
        [When(@"I navigate back to the home page")]
        public void ThenINavigateBackToTheHomePage()
        {
            System.Threading.Thread.Sleep(5000);
            getDriver().Navigate().Back();
            System.Threading.Thread.Sleep(2000);
            Home_D jmHomePage = new Home_D(getDriver());
            jmHomePage.VerifyPage();
        }


        #region Common
        [Then(@"Verify Links are correct environment")]
        public void VerifyUrls()
        {
            JMCommon VerifyUrls = new JMCommon(getDriver());
            VerifyUrls.VerifyPLPortalLinksAreCorrectEnvironment(getDriver());
        }

        #endregion

        #region Home Page

        [Then(@"Assert Explore Personal Jewelry Insurance Button Exists")]
        public void IAssertExplorePersonalJewelryInsuranceButtonExists()
        {
            Home home = new Home(getDriver());
            home.DoesExplorePersonalJewelryInsuranceButtonExist();
        }

        [Then(@"I Click on the Log Into Your Account Button")]

        public void LogIntoYourAccount()
        {
            Home logIntoYourAccount = new Home(getDriver());

            logIntoYourAccount.LogIntoYourAccountBTN();

        }

        [Then(@"I Click the Explore Personal Jewelry Insurance Button and verify it brings me to the correct webpage")]

        public void ExplorePersonalJewelry()
        {
            Home explore = new Home(getDriver());
            explore.ClickAndAssertExplorePJ();

        }

        [Then(@"I click the IWantToInsureDropdown")]
        public void ClickIWantToInsureDropdow()
        {
            Home insuredropdown = new Home(getDriver());
            insuredropdown.ClickIWantToInsureDropdown();
        }

        [Then(@"Assert that quick quote does not exist")]

        public void AssertQuickQuoteDoesNotExist()
        {
            Home assertQQ = new Home(getDriver());
            assertQQ.AssertQuickQuoteDoesNotExist();
        }


        [Then(@"Verify Home Page Testimonials are correct")]

        public void VerifyHomePageTestimonials()
        {
            Home verifyHomeTestimonial = new Home(getDriver());
            verifyHomeTestimonial.VerifyHomeTestimonial();
        }
        #endregion

        #region About Us Page

        [Then(@"Go to About Us Page")]
        public void GoToAboutUsPage()
        {
            AboutUs goToAboutUsPage = new AboutUs(getDriver());
            goToAboutUsPage.GoToAboutUsPage();
        }

        [Then(@"Verify leadership bios")]
        public void VerifyLeadershipBios()
        {
            AboutUs verifyLeadershipBios = new AboutUs(getDriver());
            verifyLeadershipBios.verifyLeadershipBios();
            verifyLeadershipBios.VerifySeeIfButtonsOnAboutUsPageWork();
        }

        [Then(@"Verify About Us buttons are working")]
        public void VerifyAboutUsButtonsAreWorking()
        {
            AboutUs verifyAboutUsButtonsAreWorking = new AboutUs(getDriver());
            verifyAboutUsButtonsAreWorking.VerifySeeIfButtonsOnAboutUsPageWork();

        }


        [Then(@"Test for broken images")]
        public void CheckForBrokenImages()
        {
            AboutUs checkForBrokenImages = new AboutUs(getDriver());
            checkForBrokenImages.CheckImages(getDriver());

        }


        #endregion

        #region Grooms Page
        [Then(@"I go to the Grooms Page")]
        public void GoToGroomsPage()
        {
            GroomsPage goToGroomsPage = new GroomsPage(getDriver());
            goToGroomsPage.GoToGroomspage();
        }

        [Then(@"Grooms Page Verify URL's are the correct environment")]
        public void GroomsPageVerifyUrls()
        {
            JMCommon groomsPageVerifyUrls = new JMCommon(getDriver());
            groomsPageVerifyUrls.VerifyPLPortalLinksAreCorrectEnvironment(getDriver());

        }

        [Then(@"grooms verify correct images are shown")]
        public void VerifyGroomsImages()
        {
            GroomsPage verifyGroomsImages = new GroomsPage(getDriver());
            verifyGroomsImages.CheckImages(getDriver());
        }


        #endregion

        #region Watches Insurance
        [Then(@"I go to the Watches Page")]
        public void GoToWatchInsurancePage()
        {
            Watches goToWatchInsurancePage = new Watches(getDriver());
            goToWatchInsurancePage.GoToWatchInsurancePage();
        }



        #endregion

        #region Business Insurance
        [Then(@"I go to the Business Insurance Page")]
        public void GoToBusinessInsurancePage()
        {
            BusinessInsurance goToBusinessInsurancePage = new BusinessInsurance(getDriver());
            goToBusinessInsurancePage.GoToBusinessInsurancePage();
        }

        [Then(@"I verify Business Insurance images")]
        public void VerifyBusinessInsuranceImages()
        {
            BusinessInsurance verifyBusinessInsuranceImages = new BusinessInsurance(getDriver());
            verifyBusinessInsuranceImages.CheckImages(getDriver());
        }

        [Then(@"I verify Business Insurance Testimonials")]

        public void VerifyBusinessInsuranceTestimonials()
        {
            BusinessInsurance verifyBITestimonial = new BusinessInsurance(getDriver());
            verifyBITestimonial.VerifyBusinessInsuranceTestimonials();
        }


        #endregion

        #region Jewelers Programs
        [Then(@"I go to the Jewelers Programs Page")]
        public void GoToJewelersProgramsPage()
        {
            JewelersPrograms goToJewelersProgramsPage = new JewelersPrograms(getDriver());
            goToJewelersProgramsPage.GoToJewelerProgramsPage();
        }


        #endregion

        #region JM University
        [Then(@"I go to the JM University Page")]
        public void GoToJMUniversityPage()
        {
            JMUniversity goToJMUniversityPage = new JMUniversity(getDriver());
            goToJMUniversityPage.GoToJMUniversityPage();
        }

        #endregion

        #region Shipping Solution
        [Then(@"I go to the Shipping Solution Page")]
        public void GoToShippingSolutionPage()
        {
            ShippingSolution goToShippingSolutionPage = new ShippingSolution(getDriver());
            goToShippingSolutionPage.GoToShippingSolutionPage();
        }

        #endregion

        #region FAQ
        [Then(@"I go to the FAQ Page")]
        public void GoToFAQPage()
        {
            FAQ goToFAQPage = new FAQ(getDriver());
            goToFAQPage.GoToFAQPage();
        }

        [Then(@"I verify FAQ images")]
        public void VerifyFAQImages()
        {
            FAQ verifyFAQImages = new FAQ(getDriver());
            verifyFAQImages.CheckImages(getDriver());
        }

        [Then(@"I Verify FAQ Testimonial")]
        public void VerifyFAQTestimonial()
        {
            FAQ verifyFAQTestimonial = new FAQ(getDriver());
            verifyFAQTestimonial.VerifyFAQTestimonial();
        }

        #endregion

        #region Personal Insurance
        [Then(@"I go to the Personal Insurance Page")]
        public void GoToPersonalInsurancePage()
        {
            PersonalInsurance goToPersonalInsurancePage = new PersonalInsurance(getDriver());
            goToPersonalInsurancePage.GoToPersonalInsurancePage();
        }

        [Given(@"I access the Quick Claim App app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        [When(@"I access the Quick Claim App app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        public void GivenIAccessTheQuickClaimAppApp(string ApplicationEnvironment, string TargetType, string Capability, string BrowserType, string OperatingSystem)
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


        [Given(@"I access the Digital Application (.*) on (.*) in (.*)")]
        public void GivenIAccessTheDigitalApplication(string applicationType, string target, string browser)
        {
            Console.WriteLine(Unique.ID.Substring(15));

            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];

            Console.Write("BrowserStackUser" + System.Configuration.ConfigurationManager.AppSettings["BrowserStackUser"]);

            ScenarioContext.Current["Application"] = applicationType;

            DataStorage tempData = new DataStorage();

            switch (applicationType.ToLower().Trim())
            {
                case "pc":
                    tempData.StoreTempValue("guidewire", "PC-APPENV", "PC-" + ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
                    break;
                case "cc":
                    tempData.StoreTempValue("guidewire", "CC-APPENV", "CC-" + ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
                    break;
                case "cm":
                    tempData.StoreTempValue("guidewire", "CM-APPENV", "CM-" + ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
                    break;
                case "kentico":
                    tempData.StoreTempValue("guidewire", "CM-APPENV", "CM-" + ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
                    break;
                default:
                    break;
            }





            ScenarioContext.Current["TargetType"] = target;

            ScenarioContext.Current["BrowserType"] = browser;

            //  DataStorage temp = new DataStorage();

            //  temp.StoreTempValue("guidewire", "key", "value");

            /*   RegistryKey regKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium");

               regKey.SetValue("key", "value");

               regKey.Close(); */


            if (target.ToLower() != "desktop")
            {
                startBrowserStackLocal();

                System.Threading.Thread.Sleep(10000);
            }
        }


        #endregion

        #region ClaimsApp
        [Then(@"I go to the Claims App")]
        [When(@"I go to the Claims App")]
        public void GoToClaimsApp()
        {
            ClaimsApp GoToClaimsApp = new ClaimsApp(getDriver());
            GoToClaimsApp.GoToClaimsApp();
        }

        [Then(@"I enter Policy Number using (.*)")]
        [When(@"I enter Policy Number using (.*)")]
        public void EnterPolicyNumber(string policyNumber)
        {
            {
                DataStorage temp = new DataStorage();

                string policyNum = null;
                switch (policyNumber.ToUpper().Trim())
                {
                    case "REGISTRY":
                        policyNum = temp.GetTempValue("PLCYNO");
                        break;

                    case "EMAILREGISTRY":
                        policyNum = temp.GetTempValue("EMAIL");
                        break;

                    default:
                        policyNum = policyNumber;
                        break;
                }
                StartAClaim EnterPolicyNumber = new StartAClaim(getDriver());
                EnterPolicyNumber.EnterPolicyNumber(policyNum);
            }

        }
        [Then(@"I enter Last Name using (.*)")]
        [When(@"I enter Last Name using (.*)")]
        public void EnterLastName(string lastName)
        {
            DataStorage temp = new DataStorage();

            string lastN = null;
            switch (lastName.ToUpper().Trim())
            {
                case "REGISTRY":
                    lastN = temp.GetTempValue("LNAME");
                    break;

                default:
                    lastN = lastName;
                    break;
            }
            StartAClaim EnterLastName = new StartAClaim(getDriver());
            EnterLastName.EnterLastName(lastN);
        }
        [Then(@"I enter Zip Code using (.*)")]
        [When(@"I enter Zip Code using (.*)")]
        public void EnterZipCode(string zipCode)
        {

            DataStorage temp = new DataStorage();

            string zipC = null;
            switch (zipCode.ToUpper().Trim())
            {
                case "REGISTRY":
                    zipC = temp.GetTempValue("ZIPCODE");
                    break;

                default:
                    zipC = zipCode;
                    break;
            }
            StartAClaim EnterZipCode = new StartAClaim(getDriver());
            EnterZipCode.EnterZipCode(zipC);
        }

        [Then(@"I disable Captcha")]
        [When(@"I disable Captcha")]
        public void DisableCaptcha()
        {
            StartAClaim DisableCaptcha = new StartAClaim(getDriver());
            DisableCaptcha.DisableCaptcha();
        }

        [Then(@"I verify CL error message")]
        [When(@"I verify CL error message")]
        public void VerifyCLErrorMessage()
        {
            StartAClaim VerifyCLError = new StartAClaim(getDriver());
            VerifyCLError.VerifyCLError();

        }

        [Then(@"I verify Start A Claim Error Messages")]
        [When(@"I verify Start A Claim Error Messages")]
        public void VerifyStartAClaimErrorMessages()
        {
            StartAClaim StartAClaimErrors = new StartAClaim(getDriver());
            StartAClaimErrors.VerifyStartAClaimValidationMessages();

        }

        [Then(@"I verify Start FNOL Error Messages")]
        [When(@"I verify Start FNOL Error Messages")]
        public void VerifyFNOLErrorMessages()
        {
            DateOfLoss FNOLErrors = new DateOfLoss(getDriver());
            FNOLErrors.VerifyFNOLErrors();

        }

        [Then(@"I verify Contact Screen Error Messages")]
        [When(@"I verify Contact Screen Error Messages")]
        public void VerifyContactErrorMessages()
        {
            ContactScreen ContactErrors = new ContactScreen(getDriver());
            ContactErrors.ContactScreenErrors();

        }

        [Then(@"I verify Loss Damage Screen Error Messages")]
        [When(@"I verify Loss Damage Screen Error Messages")]
        public void VerifyLossDamageErrorMessages()
        {
            Loss_Damage_Screen LossDamageErrors = new Loss_Damage_Screen(getDriver());
            LossDamageErrors.DamageLossErrors();

        }

        [Then(@"I verify Description Screen Error Messages")]
        public void VerifyDescriptionErrorMessages()
        {
            Description DescriptionErrors = new Description(getDriver());
            DescriptionErrors.DescriptionError();

        }


        [Then(@"I click continue")]
        [When(@"I click continue")]
        public void IClickContinue()
        {
            ClaimsApp IClickContinue = new ClaimsApp(getDriver());
            IClickContinue.ClickContinue();
        }

        [Then(@"I enter a date of loss of (.*)")]
        [When(@"I enter a date of loss of (.*)")]
        public void EnterDateOfLoss(string dateOfLoss)
        {
            DateOfLoss EnterDateOfLoss = new DateOfLoss(getDriver());
            EnterDateOfLoss.DateOfLossField(dateOfLoss);
        }

        [Then(@"I enter date of loss of today")]
        [When(@"I enter date of loss of today")]
        public void EnterDateOfLoss()
        {
            DateOfLoss TodaysDate = new DateOfLoss(getDriver());
            TodaysDate.EnterTodaysDate();
        }

        [When(@"I click on continue button in Jeweler Details Page")]
        public void WhenIClickOnContinueButtonInJewelerDetailsPage()
        {
            JewelerDetailes JewelerDetailes = new JewelerDetailes(getDriver());
            JewelerDetailes.SubmitClaim();
        }


        [When(@"I Enter Jeweler Details")]
        public void WhenIEnterJewelerDetails(Table table)
        {
            JewelerDetailes JewelerDetailes = new JewelerDetailes(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string firstName = table.Rows[Itemcounter]["Name"];
                string streetAddress = table.Rows[Itemcounter]["streetAddress"];
                string city = table.Rows[Itemcounter]["city"];
                string state = table.Rows[Itemcounter]["state"];
                JewelerDetailes.EnterJewelerDetails(firstName, streetAddress, city, state);

            }

        }


        [When(@"I Enter Claim Details")]
        public void WhenIEnterClaimDetails(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            ContactScreen ClaimDetails = new ContactScreen(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string firstName = table.Rows[Itemcounter]["FirstName"];
                string phoneNumber = table.Rows[Itemcounter]["phoneNumber"];
                string streetAddress = table.Rows[Itemcounter]["streetAddress"];
                string city = table.Rows[Itemcounter]["city"];
                string state = table.Rows[Itemcounter]["state"];
                string email = "adzhoharidze@jminsure.com";
                ClaimDetails.EnterClaimDetails(firstName, phoneNumber, streetAddress, city, state, email);

            }
        }




        [When(@"I Enter person's relationship (.*)")]
        public void IEnterPersonSRelationship(string Relationship)
        {
            ContactScreen ClaimDetails = new ContactScreen(getDriver());
            ClaimDetails.selectRelationship(Relationship);
        }

        [When(@"I Select Checkbox this is a new Address")]
        public void WhenISelectCheckboxThisIsANewAddress()
        {
            ContactScreen ClaimDetails = new ContactScreen(getDriver());
            ClaimDetails.selectThisisNewAddress();
        }


        [When(@"I enter a first name of (.*)")]
        [Then(@"I enter a first name of (.*)")]
        public void EnterFirstName(string firstName)
        {
            ContactScreen EnterFirstName = new ContactScreen(getDriver());
            EnterFirstName.EnterFirstName(firstName);
        }

        [Then(@"I enter a phone number of (.*)")]
        [When(@"I enter a phone number of (.*)")]
        public void EnterPhoneNumber(string phoneNumber)
        {
            ContactScreen EnterPhoneNumber = new ContactScreen(getDriver());
            EnterPhoneNumber.EnterPhoneNumber(phoneNumber);
        }

        [Then(@"I enter a email of (.*)")]
        [When(@"I enter a email of (.*)")]
        public void EnterEmail(string email)
        {
            ContactScreen EnterEmail = new ContactScreen(getDriver());
            EnterEmail.EnterEmail(email);
        }

        [Then(@"I enter a street Address of (.*)")]
        [When(@"I enter a street Address of (.*)")]
        public void EnterStreetAddress(string streetAddress)
        {
            ContactScreen EnterStreetAddress = new ContactScreen(getDriver());
            EnterStreetAddress.EnterStreetAddress(streetAddress);
        }

        [Then(@"I enter a city of (.*)")]
        public void EnterCity(string city)
        {
            ContactScreen EnterCity = new ContactScreen(getDriver());
            EnterCity.EnterCity(city);
        }

        [Then(@"I enter a state of (.*)")]
        [When(@"I enter a state of (.*)")]
        public void EnterState(string state)
        {
            ContactScreen EnterState = new ContactScreen(getDriver());
            EnterState.EnterState(state);
        }


        [Then(@"I enter Zip Code on the Contact Screen using (.*)")]
        [When(@"I enter Zip Code on the Contact Screen using (.*)")]
        public void ContactScreenEnterZipCode(string zipCode)
        {
            ContactScreen EnterZipCode = new ContactScreen(getDriver());
            EnterZipCode.ContactScreenEnterZipCode(zipCode);
        }

        [Then(@"I click loss")]
        [When(@"I click loss")]
        public void ClickLoss()
        {
            Loss_Damage_Screen clickLoss = new Loss_Damage_Screen(getDriver());
            clickLoss.ClickLoss();
        }

        [When(@"I click loss type")]
        [Then(@"I click loss type")]
        public void WhenIClickLossType(Table table)
        {
            Loss_Damage_Screen IClickAccidentalLoss = new Loss_Damage_Screen(getDriver());
            IClickAccidentalLoss.ClickLossType(table.Rows[0]["LossType"]);
        }



        [Then(@"I click accidental loss")]
        [When(@"I click accidental loss")]
        public void IClickAccidentalLoss()
        {
            Loss_Damage_Screen IClickAccidentalLoss = new Loss_Damage_Screen(getDriver());
            IClickAccidentalLoss.ClickAccidentalLoss();
        }

        [Then(@"I click Continue on Loss/Damage Screen")]
        [When(@"I click Continue on Loss/Damage Screen")]
        public void IClickContinueOnLossDamageScreen()
        {
            Loss_Damage_Screen IClickContinueOnLossDamageScreen = new Loss_Damage_Screen(getDriver());
            IClickContinueOnLossDamageScreen.ClickContinueLossDamage();
        }

        [When(@"I click on continue on Loss/Damage Screen")]
        [Then(@"I click on continue on Loss/Damage Screen")]
        public void WhenIClickOnContinueOnLossDamageScreen()
        {
            Description IClickSubmitClaim = new Description(getDriver());
            IClickSubmitClaim.SubmitClaim();
        }


        [Then(@"I click submit claim")]
        [When(@"I click submit claim")]
        public void IClickSubmitClaim()
        {
            Description IClickSubmitClaim = new Description(getDriver());
            IClickSubmitClaim.SubmitClaim();
        }

        [Then(@"I store claim number")]
        [When(@"I store claim number")]
        public void StoreClaimNumber()
        {
            ClaimCreatedScreen ClaimNum = new ClaimCreatedScreen(getDriver());
            ClaimNum.StoreClaimNumber();

            DataStorage tempData = new DataStorage();
            Console.WriteLine("Claim number in When is " + ScenarioContext.Current["CLAIM"].ToString());
            tempData.StoreTempValue("guidewire", "PL_CLAIM", ScenarioContext.Current["CLAIM"].ToString());
            tempData.StoreTempValue("guidewire", "CLAIMNO", ScenarioContext.Current["CLAIM"].ToString());
        }

        [Then(@"I Validate Claim Submitted")]
        [When(@"I Validate Claim Submitted")]
        public void ValidateClaimSubmitted()
        {
            ClaimCreatedScreen Verify = new ClaimCreatedScreen(getDriver());
            Verify.VerifyText();
        }

        [Then(@"I go to Claim Center")]
        [When(@"I go to Claim Center")]

        public void GoToClaimCenter()
        {
            ClaimsApp ClaimCen = new ClaimsApp(getDriver());
            ClaimCen.GoToClaimCenter();
        }


        [When(@"I enter description for Lost Item (.*)")]
        public void IEnterDescriptionForLostItem(string Lossdescription)
        {
            Description EnterDescription = new Description(getDriver());
            EnterDescription.EnterDescriptionLostItem(Lossdescription);
        }

        [When(@"I enter description for what happened (.*)")]
        public void IEnterDescriptionForWhatHappened(string WhtHappendescription)
        {
            Description EnterDescription = new Description(getDriver());
            EnterDescription.EnterDescriptionWhatHappened(WhtHappendescription);
        }


        //[Then(@"I enter (.*) and (.*) on the Login page")]
        //public void GivenIEnterLoginDetails(string userName, string password)
        //{
        //    LoginPage loginPg = new LoginPage(getDriver());

        //    loginPg.EnterLoginDetails(userName, password);

        //}



        #endregion

        #region Contact
        [Then(@"I Verify all the elements in the Contact page are displayed")]
        public void ThenIVerifyAllTheElementsInTheContactPageAreDisplayed()
        {
            Contact_D contact = new Contact_D(getDriver());
            contact.VerifyPage();
        }
        [Then(@"I Verify all the elements in the contact information section in contcat page are dispayed")]
        public void ThenIVerifyAllTheElementsInTheContactInformationSectionInContcatPageAreDispayed()
        {
            Contact_D contact = new Contact_D(getDriver());
            contact.verifyContactPageContent();

        }

        #endregion
        #region privacy Policy

        [Then(@"I Verify all the elements in the privacy policy page are displayed")]
        public void ThenIVerifyAllTheElementsInThePrivacyPolicyPageAreDisplayed()
        {
            PrivacyPolicy_D PrivacyPolicy_D = new PrivacyPolicy_D(getDriver());
            PrivacyPolicy_D.verifyPJInsurancePageContent();

        }



        #endregion

        #region Term Of Use

        [Then(@"I Verify all the elements in the terms of use page are displayed")]
        public void ThenIVerifyAllTheElementsInTheTermsOfUsePageAreDisplayed()
        {
            TermsOfUse_D TermsOfUse_D = new TermsOfUse_D(getDriver());
            TermsOfUse_D.verifyTermsofUse();
            TermsOfUse_D.verifyIntroductionTU();
            TermsOfUse_D.verifyChangesTU();
            TermsOfUse_D.verifyRestrictions();
            TermsOfUse_D.verifyAccessing();
            TermsOfUse_D.verifyPrivacy();
            TermsOfUse_D.verifyLinks();
            TermsOfUse_D.verifyPropertRights();
            TermsOfUse_D.verifyReliance();
            TermsOfUse_D.verifyDisclaimer();
            TermsOfUse_D.verifyLimitation();
            TermsOfUse_D.verifyInsuranceCoverages();
            TermsOfUse_D.verifyAuthority();
            TermsOfUse_D.verifyQuestionsorComments();


        }

        #endregion

        #region share your concerns

        [Then(@"I Verify all the elements in the share your concerns page are displayed")]
        public void ThenIVerifyAllTheElementsInTheShareYourConcernsPageAreDisplayed()
        {
            ShareYourConcerns_D ShareYourConcerns_D = new ShareYourConcerns_D(getDriver());
            ShareYourConcerns_D.verifyShareYourConcernsPageContent();


        }


        #endregion

        #region career

        [Then(@"I Verify all the elements in the Careers page are displayed")]
        public void ThenIVerifyAllTheElementsInTheCareersPageAreDisplayed()
        {
            Careers_D Careers_D = new Careers_D(getDriver());
            Careers_D.verifyCarrersPageContent();

        }


        #endregion


        #region NewsRoom

        [Then(@"I Verify all the elements in the Newsroom page are displayed")]
        public void ThenIVerifyAllTheElementsInTheNewsroomPageAreDisplayed()
        {
            NewsRoom_D NewsRoom_D = new NewsRoom_D(getDriver());
            NewsRoom_D.verifyNewsRoom();

        }


        #endregion

        #region Quote

        [Then(@"I Verify all the elements in the Quote page are displayed")]
        public void ThenIVerifyAllTheElementsInTheQuotePageAreDisplayed()
        {
            Quote_D Quote_D = new Quote_D(getDriver());
            Quote_D.verifyHeader();
            Quote_D.verifyHeaderRibbon();
            Quote_D.verifyMainContent();
            Quote_D.verifyRightCove();
            Quote_D.verifyFooter();
        }


        #endregion

        #region ManageMyPolicy

        [Then(@"I Verify all the elements in the ManageMyPolicy page are displayed")]
        public void ThenIVerifyAllTheElementsInTheManageMyPolicyPageAreDisplayed()
        {
            ManageMyPolicy_D ManageMyPolicy_D = new ManageMyPolicy_D(getDriver());
            ManageMyPolicy_D.verifyHeader();
            ManageMyPolicy_D.verifyHeaderRibbon();
            ManageMyPolicy_D.verifyMainContent();
            ManageMyPolicy_D.verifyFooter();
        }

        [Then(@"I Verify all the elements in the RegisterforOnlineAccount page are displayed")]
        public void ThenIVerifyAllTheElementsInTheRegisterforOnlineAccountPageAreDisplayed()
        {
            ManageMyPolicyRegister_D ManageMyPolicy_D = new ManageMyPolicyRegister_D(getDriver());
            ManageMyPolicy_D.verifyHeader();
            ManageMyPolicy_D.verifyHeaderRibbon();
            ManageMyPolicy_D.verifyMainContent();
            ManageMyPolicy_D.verifyFooter();
        }


        #endregion

        #region Start A Claim

        [Then(@"I Verify all the elements in the Start a Claim page are displayed")]
        public void ThenIVerifyAllTheElementsInTheStartAClaimPageAreDisplayed()
        {
            StartaClaim_D StartaClaim_D = new StartaClaim_D(getDriver());
            StartaClaim_D.verifyStartaClaim();
        }
        #endregion

        #region QuickBillPay
        [Then(@"I Verify all the elements in the Quick Bill Pay page are displayed")]
        public void ThenIVerifyAllTheElementsInTheQuickBillPayPageAreDisplayed()
        {
            QuickBillPay_D QuickBillPay = new QuickBillPay_D(getDriver());
            QuickBillPay.verifyQuickBillPay();
        }

        #endregion

        #region Agent Portal

        [Then(@"I Verify all the elements in the Agent Portal page are displayed")]
        public void ThenIVerifyAllTheElementsInTheAgentPortalPageAreDisplayed()
        {
            AgentPortal_D AgentPortal_D = new AgentPortal_D(getDriver());
            AgentPortal_D.verifyHeader();
            AgentPortal_D.verifyHeaderRibbon();
            AgentPortal_D.verifyMainContent();
            AgentPortal_D.verifyFooter();
        }


        #endregion

        #region Social Responsibility

        [Then(@"I Verify all the elements in the SocialResponsibility page are displayed")]
        public void ThenIVerifyAllTheElementsInTheSocialResponsibilityPageAreDisplayed()
        {
            SocialResponsibility_D SocialResponsibility_D = new SocialResponsibility_D(getDriver());
            SocialResponsibility_D.verifySocialResponsibilityPageContent();


        }

        #endregion

        #region FAQ
        [Then(@"I Verify all the elements in the FAQ page are displayed")]
        public void ThenIVerifyAllTheElementsInTheFAQPageAreDisplayed()
        {
            FAQ_D FAQ_D = new FAQ_D(getDriver());
            FAQ_D.verifyCarrersPageContent();

        }


        #endregion

        #region Shipping solution
        [Then(@"I Verify all the elements in the Shipping solution page are displayed")]
        public void ThenIVerifyAllTheElementsInTheShippingSolutionPageAreDisplayed()
        {
            Shipping_D Shipping_D = new Shipping_D(getDriver());
            Shipping_D.verifyShippingPageContent();

        }


        #endregion

        #region Pawn Broker

        [Then(@"I Verify all the elements in the Pawn Brokers page are displayed")]
        public void ThenIVerifyAllTheElementsInThePawnBrokersPageAreDisplayed()
        {
            Pawnbrokers_D Pawnbrokers_D = new Pawnbrokers_D(getDriver());
            Pawnbrokers_D.verifyPawnbrokers();

        }


        #endregion

        #region Blog

        [Then(@"I Verify all the elements in the CL Blogs page are displayed")]
        public void ThenIVerifyAllTheElementsInTheCLBlogsPageAreDisplayed()
        {
            CL_Blog_D CL_Blog_D = new CL_Blog_D(getDriver());
            CL_Blog_D.verifyCLBlogPageContent();
        }


        [Then(@"I Verify all the elements in the Personal Blog page are displayed")]
        public void ThenIVerifyAllTheElementsInThePersonalBlogPageAreDisplayed()
        {
            PL_Blog_D PL_Blog_D = new PL_Blog_D(getDriver());
            //PL_Blog_D.verifyPLBlog();
        }

        #endregion

        #region drupal admin portal

        [Given(@"I enter (.*) and (.*) on the Drupal Admin Login Page")]
        public void IEnterAndOnTheDrupalAdminLoginPage(string username, string password)
        {
            Portalloginpage loginpage = new Portalloginpage(getDriver());
            loginpage.logintoportal(username, password);
        }

        [When(@"I click on menu option in Drupal Admin Landing Page")]
        public void WhenIClickOnMenuOptionInDrupalAdminLandingPage(Table table)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.ClickOnToolBaroptions(table.Rows[0]["MenuOption"]);
        }

        [When(@"I click on tab option in Drupal Admin Landing Page")]
        public void WhenIClickOnTabOptionInDrupalAdminLandingPage(Table table)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.ClickOnTaboptions(table.Rows[0]["TabOption"]);
        }

        [When(@"I click on tool bar option in Layout Page")]
        public void WhenIClickOnToolBarOptionInLayoutPage(Table table)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.ClickOnToolHeaderoptions(table.Rows[0]["Option"]);
        }


        [When(@"I take action on markating page content in  Drupal Admin Landing Page")]
        public void WhenITakeActionOnMarkatingPageContentInDrupalAdminLandingPage(Table table)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.ActionOnMarkatingPageContent(table.Rows[0]["Action"]);
        }

        [When(@"I create a custome block type in  Drupal Admin Landing Page")]
        public void WhenICreateACustomeBlockTypeInDrupalAdminLandingPage(Table table)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.AddBloack(table.Rows[0]["BlockType"]);

        }

        [When(@"I Update (.*) , (.*) and (.*) details for Configure Block in  Drupal Admin Landing Page and Click Save button")]
        public void WhenIUpdateDetailsForConfigureBlockInDrupalAdminLandingPageAndClickSaveButton(string title, string headline, string text)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.UpdateConfigureBlock(title, headline, text);
            landingpage.clickSavebutton();
        }




        [When(@"I Update (.*) , (.*) and (.*) for Configure Block in Drupal Admin Landing Page and click on Update button")]
        [Then(@"I Update (.*) , (.*) and (.*) for Configure Block in Drupal Admin Landing Page and click on Update button")]
        public void IUpdateForConfigureBlockInDrupalAdminLandingPagAndClickOnUpdateButton(string title, string headline, string text)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.UpdateConfigureBlock(title, headline, text);
            landingpage.clickUpdatebutton();
        }




        [When(@"I verify (.*) , (.*) and (.*) updates from Configure Block in  Drupal Admin Landing Page")]
        [Then(@"I verify (.*) , (.*) and (.*) updates from Configure Block in  Drupal Admin Landing Page")]
        public void IVerifyUpdatesFromConfigureBlockInDrupalAdminLandingPage(string title, string headline, string text)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.VerifyTitletext(title);
            landingpage.VerifyHeadlinetext(headline);
            landingpage.VerifyTexttext(text);
        }



        [When(@"I click on Save Layout button in Drupal Admin Landing Page")]
        public void WhenIClickOnSaveLayoutButtonInDrupalAdminLandingPage()
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.SaveLayout();
        }



        [When(@"I verify (.*) , (.*) and (.*) from Configure Block in Layout Page")]
        [Then(@"I verify (.*) , (.*) and (.*) from Configure Block in Layout Page")]
        public void IVerifyFromConfigureBlockInLayoutPage(string title, string headline, string text)
        {
            Layoutpage layoutpage = new Layoutpage(getDriver());
            layoutpage.VerifyTitletext(title);
            layoutpage.VerifyHeadlinetext(headline);
            layoutpage.VerifyTexttext(text);
        }

        [When(@"I verify (.*) , (.*) and (.*) updates from Configure Block in View Page")]
        public void IVerifyUpdatesFromConfigureBlockInViewPage(string title, string headline, string text)
        {
            Viewpage Viewpage = new Viewpage(getDriver());
            Viewpage.VerifyTitletext(title);
            Viewpage.VerifyHeadlinetext(headline);
            Viewpage.VerifyTexttext(text);
        }






        [When(@"I verify sucess message in  Layout Page")]
        public void IVerifySucessMessageInLayoutPage()
        {
            Layoutpage layoutpage = new Layoutpage(getDriver());
            layoutpage.VerifySuccessfullMessage();
        }




        [When(@"I change State in Drupal Admin Landing Page")]
        public void WhenIChangeStateInDrupalAdminLandingPage(Table table)
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.SelectChangetoState(table.Rows[0]["State"]);
        }

        [When(@"I click on edit pencil button for Layout builder in Drupal Admin Landing Page")]
        public void IClickOnEditPencilButtonForLayoutBuilderInDrupalAdminLandingPage()
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.ClickonEditPencilButtonForLayoutBuilder();
        }



        [When(@"I Verify Title is created in Drupal Admin Landing Page")]
        public void WhenIVerifyTitleIsCreatedInDrupalAdminLandingPage()
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.verifyTitleCreatd();
        }

        [When(@"I Verify Layout text header in Drupal Admin Landing Page")]
        public void WhenIVerifyLayoutTextHeaderInDrupalAdminLandingPage()
        {
            Portallandingpage landingpage = new Portallandingpage(getDriver());
            landingpage.verifyLayoutheader();
        }



        [When(@"I click on options in Add Content Page")]
        public void WhenIClickOnOptionsInAddContentPage(Table table)
        {
            AddContentpage contactpage = new AddContentpage(getDriver());
            contactpage.ClickOnPageoptions(table.Rows[0]["Options"]);

        }



        [When(@"I insert (.*) into Tile in Create Marketing Page")]
        public void IInsertIntoTileInCreateMarketingPage(string title)
        {
            CreateMarketingpage CreateMarketing = new CreateMarketingpage(getDriver());
            CreateMarketing.UpdateTitle(title);
        }

        [When(@"I Delete (.*) from Content Page")]
        [Then(@"I Delete (.*) from Content Page")]
        public void IDeleteFromContentPage(string title)
        {
            ManageContentpage contact = new ManageContentpage(getDriver());
            contact.DeleteTitle(title);
        }


        #endregion




    }
}

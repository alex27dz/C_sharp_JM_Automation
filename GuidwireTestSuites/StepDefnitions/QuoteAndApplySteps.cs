using HelperClasses;
using QuoteAndApplyPages.Pages.QNA;
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
using OpenQA.Selenium;
using System.IO;
using QuoteAndApplyPages.Pages.ExpressPartner;
using QuoteAndApplyPages.Pages.LOOS;

namespace QuoteAndApply.StepDefnitions
{
    [Binding]
    class QuoteAndApplySteps : WebCommonCore.TestBase
    {

        [BeforeScenario]

        public void cleanUpBeforeTest()
        {
            //  InitializeWEbDriver();

            KillWEbDriver();
        }

        //[AfterScenario]
        //public void cleanUpAfter()
        //{
        //    if (ScenarioContext.Current.TestError != null)
        //    {
        //        //     CaptureApplicationSnapshot("error");
        //        IWebDriver currDriver = (IWebDriver)ScenarioContext.Current["WebDriver"];

        //        string fileBaseName = string.Format("error_{0}_{1}", ScenarioContext.Current.ScenarioInfo.Title.ToString(), DateTime.Now.ToString("yyyyMMdd_HHmmss"));

        //        string pageSource = currDriver.PageSource;

        //        Console.WriteLine("Page Source:" + pageSource);

        //        string sourceFilePath = Path.Combine(@"c:\Tmp\Errors", fileBaseName + "_source.html");

        //        Console.WriteLine("File Path:" + sourceFilePath);

        //        File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);

        //        Screenshot takescreenshot = ((ITakesScreenshot)currDriver).GetScreenshot();

        //        if (takescreenshot != null)
        //        {

        //            string screenShorFilePath = Path.Combine(@"c:\Tmp\Errors", fileBaseName + "_screenshot.png");

        //            Console.WriteLine("screenShorFilePath:" + screenShorFilePath);

        //            takescreenshot.SaveAsFile(screenShorFilePath, ScreenshotImageFormat.Png);
        //        }


        //    }

        //    Console.WriteLine("After scenario");

        //    string text = System.IO.File.ReadAllText(@"C:\Tmp\BuildInfo.txt");

        //    // Display the file contents to the console. Variable text is a string.
        //    System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

        //    string featureName = FeatureContext.Current.FeatureInfo.Title;

        //    string userStory = "TBD";

        //    string[] tags = ScenarioContext.Current.ScenarioInfo.Tags;

        //    string tag = null;

        //    foreach (string val in tags)
        //        tag = val + ";" + tag;

        //    string scenarioName = ScenarioContext.Current.ScenarioInfo.Title;

        //    string application = ScenarioContext.Current["Application"].ToString();

        //    string platform = ScenarioContext.Current["TargetType"].ToString();

        //    string environment = ScenarioContext.Current["AUTEnv"].ToString();

        //    string buildNumber = text;

        //    string result = "Pass";

        //    if (ScenarioContext.Current.TestError != null)
        //        result = "Fail";

        //    string account_Policy = "";
        //    if (ScenarioContext.Current.ContainsKey("ACCOUNT") && ScenarioContext.Current.ContainsKey("POLICY"))
        //        account_Policy = ScenarioContext.Current["ACCOUNT"].ToString() + ":" + ScenarioContext.Current["POLICY"].ToString();
        //    else if (ScenarioContext.Current.ContainsKey("ACCOUNT"))
        //        account_Policy = ScenarioContext.Current["ACCOUNT"].ToString();

        //    string executionDate = DateTime.Now.ToShortDateString();

        //    string stackTrace = "TBD";

        //    string executionTime = DateTime.Now.ToString();

        //    Console.WriteLine("Insert into TestResults(FeatureName, UserStory , Tags , ScenarioName, Application,Platform, Environment, BuildNumber, Result, Account_Policy,ExecutionDate,StackTrace,ExecutionTime) values ('" + featureName + "','" + userStory + "','" + tag + "','" + scenarioName + "','" + application + "','" + platform + "','" + environment + "','" + buildNumber + "','" + result + "','" + account_Policy + "','" + executionDate + "','" + stackTrace + "','" + executionTime + "')");

        //    DataStorage resultsData = new DataStorage();
        //    resultsData.WriteTestResults("Insert into TestResults(FeatureName, UserStory , Tags , ScenarioName, Application,Platform, Environment, BuildNumber, Result, Account_Policy,ExecutionDate,StackTrace,ExecutionTime) values ('" + featureName + "','" + userStory + "','" + tag + "','" + scenarioName + "','" + application + "','" + platform + "','" + environment + "','" + buildNumber + "','" + result + "','" + account_Policy + "','" + executionDate + "','" + stackTrace + "','" + executionTime + "')");

        //    //KillWEbDriver();
        //}

        [Then(@"I access the QuoteAndApp app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        [Given(@"I access the QuoteAndApp app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        [When(@"I access the QuoteAndApp app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        public void GivenIAccessQuoteAndAppApplicationIn(string ApplicationEnvironment, string TargetType, string Capability, string BrowserType, string OperatingSystem)
        {
            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];

            ScenarioContext.Current["Application"] = ApplicationEnvironment;

            Console.WriteLine("Application is " + ApplicationEnvironment);

            ScenarioContext.Current["TargetType"] = TargetType;

            ScenarioContext.Current["Capability"] = Capability;

            ScenarioContext.Current["BrowserType"] = BrowserType;

            if (TargetType.ToLower() != "desktop")
            {
                startBrowserStackLocal();

                System.Threading.Thread.Sleep(10000);
            }
        }

        [Given(@"I verify Quote Page error validation messages for Partner Mode")]
        [When(@"I verify Quote Page error validation messages for Partner Mode")]
        public void WhenIVerifyQuotePageErrorValidationMessagesForPartnerMode()
        {
            QuotePage quote = new QuotePage(getDriver());
            quote.click_Continue();
            quote.verifyErrorValidationMessages();
            quote.verifyErrorValidationMessagesForPartner();
        }



        [Given(@"I verify Quote Page error validation messages")]
        [When(@"I verify Quote Page error validation messages")]
        public void GivenIVerifyQuotePageErrorValidationMessages()
        {
            QuotePage quote = new QuotePage(getDriver());
            quote.click_Continue();
            quote.verifyErrorValidationMessages();
        }

        [When(@"I verify Applicant Wearer Page error validation messages")]
        public void WhenIVerifyApplicantWearerPageErrorValidationMessages()
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());

            appAndWearer.ClickOnApplicantPageNextButton();
            appAndWearer.verifyErrorValidationMessages();
        }


        [When(@"I click on Next button in in Applicant and Wearer page")]
        public void WhenIClickOnNextButtonInInApplicantAndWearerPage()
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            appAndWearer.ClickOnApplicantPageNextButton();
        }



        //[When(@"I Enter the Contact Information (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        //public void WhenIEnterTheContactInformation(string FirstName, string LastName, string Address, string Apartment, string City, string State, string AddressZipCode, string IsMailingAddress, string PhoneNumber, string EmailAddress, string ContactPreference, string DOB_Month, string DOB_Day, string DOB_Year, string Gender)
        //{
        //    ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());

        //    appAndWearer.EnterYourContactInformation(FirstName, LastName, Address, Apartment, City, State, AddressZipCode, IsMailingAddress, PhoneNumber, EmailAddress, ContactPreference, DOB_Month, DOB_Day, DOB_Year, Gender);

        //}
        [When(@"I Enter the Contact Information (.*) , (.*), (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterTheContactInformation(string FirstName, string LastName, string Address, string Apartment, string City, string State, string AddressZipCode, string IsMailingAddress, string PhoneNumber, string EmailAddress, string ContactPreference, string sDOB, string Gender)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());


            appAndWearer.EnterYourContactInformation(FirstName, LastName, Address, Apartment, City, State, AddressZipCode, IsMailingAddress, PhoneNumber, EmailAddress, ContactPreference, sDOB, Gender);

        }

        [When(@"I Enter the Contact Information  (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) for Partner mode")]
        public void WhenIEnterTheContactInformationForPartnerMode(string Address, string Apartment, string City, string State, string AddressZipCode, string IsMailingAddress, string ContactPreference, string sDOB, string Gender)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());

            appAndWearer.EnterYourContactInformationPartnerMode(Address, Apartment, City, State, AddressZipCode, IsMailingAddress, ContactPreference, sDOB, Gender);

        }



        [When(@"I Enter the Wearers details (.*) on Applicant and Wearer page")]
        public void WhenIEnterTheWearersDetails(string Applicant)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());

            appAndWearer.WhowillwearthejeweleryItems(Applicant);
        }

        [When(@"I Enter the Applicant or Wearers details with respect to wearing items")]
        public void WhenIEnterTheApplicantOrWearersDetailsWithRespectToWearingItems(Table table)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            appAndWearer.WhowillwearthejeweleryItems(table);
        }

        [When(@"I Enter the Applicant or Wearers details with respect to wearing items for BOLT")]
        public void WhenIEnterTheApplicantOrWearersDetailsWithRespectToWearingItemsForBOLT(Table table)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            appAndWearer.WhowillwearthejeweleryItemsforBOLT(table);
        }


        [When(@"I only Check the (.*) on Applicant and Wearer page")]
        public void WhenIOnlyCheckTheOnApplicantAndWearerPage(string TermsAndConditions)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            if (TermsAndConditions != "No")
            {
                appAndWearer.ImpInfocheckox();

            }
        }



        [When(@"I Enter qualification questions (.*) , (.*) on Applicant and Wearer page")]
        public void WhenIEnterQualificationQuestions(string MinorTrafficViolation, string LossTheftDamageToJewelry)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            appAndWearer.InTheLastTenYears(MinorTrafficViolation, LossTheftDamageToJewelry);
        }

        [When(@"I Enetr Sentence completion details")]
        public void WhenIEnetrSentenceCompletionDetails(Table table)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            appAndWearer.EnterSentenceCompltionDetailes(table.Rows[0]["Date"], table.Rows[0]["Type"]);
        }

        [When(@"I Enetr loss details")]
        public void WhenIEnetrLossDetails(Table table)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            var dictionoary = new Dictionary<string, string>();
            // Items items = table.CreateInstance<Items>();
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                if (Itemcounter > 0)
                {
                    appAndWearer.AddanotherLoss();

                }

                appAndWearer.EnterLossDetailes(temp[0], temp[1], temp[2], Itemcounter);

                Itemcounter = Itemcounter + 1;
            }



        }


        [When(@"I Check the (.*) on Applicant and Wearer page")]
        public void WhenICheckTheAuthorization(string TermsAndConditions)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            if (TermsAndConditions != "No")
            {
                appAndWearer.ImpInfocheckox();

            }
            appAndWearer.ClickOnApplicantPageNextButton();
        }

        //[When(@"I Enter the Jewelry Details (.*) , (.*) , (.*) , (.*) on the Jewelry Details Page")]
        //public void WhenIEnterTheJewelryDetailsMaleOnTheJewelryDetailsPage(string Gender, string DateOFPurchase, string AlarmAndSecurity, string EffecTiveDate)
        //{
        //    JewelryDetails jewelryDetails = new JewelryDetails(getDriver());

        //    jewelryDetails.SmokeTest(Gender, DateOFPurchase, AlarmAndSecurity, EffecTiveDate);
        //}

        //[When(@"I Enter details for Additional questions")]
        //public void WhenIEnterDetailsForAdditionalQuestions()
        //{
        //    AdditionalQuestions additionalQuestions = new AdditionalQuestions(getDriver());

        //    additionalQuestions.SmokeTest();
        //}

        [Then(@"I End QNA Session")]
        public void ThenIEndQNASession()
        {
            KillWEbDriver();

            ScenarioContext.Current.Remove("WebDriver");
        }

        [When(@"I should get the text on the confirmation page only for GW Down Scenarios")]
        [Then(@"I should get the text on the confirmation page only for GW Down Scenarios")]
        public void IShouldGetTheTextOnTheConfirmationPageOnlyForGWDownScenarios(Table table)
        {
            Confirmation CaptureAccount = new Confirmation(getDriver());
            if (table.Rows[0]["ConfirmationContentValidation"].Length > 10)
            {
                CaptureAccount.VerifyConfirmationText(table.Rows[0]["ConfirmationContentValidation"]);
            }

            KillWEbDriver();

            ScenarioContext.Current.Remove("WebDriver");
        }


        [Then(@"I should get the confirmation page with the account number")]
        [When(@"I should get the confirmation page with the account number")]
        public void ThenIShouldGetTheConfirmationPageWithTheAccountNumber(Table table)
        {
            Confirmation CaptureAccount = new Confirmation(getDriver());
            CaptureAccount.CaptureAccountNumber();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
            if (table.Rows[0]["ConfirmationContentValidation"].Length > 10)
            {
                CaptureAccount.VerifyConfirmationText(table.Rows[0]["ConfirmationContentValidation"]);
            }

            KillWEbDriver();

            ScenarioContext.Current.Remove("WebDriver");
        }



        [When(@"I Review the application")]
        public void WhenIReviewTheApplication(Table table)
        {
            ReviewPage reviewAndSubmit = new ReviewPage(getDriver());

            reviewAndSubmit.acceptReviewPageTerms(table.Rows[0]["Submitapplication"], table.Rows[0]["PaperlessDelivery"]);
        }
        [When(@"I Review and issue the application for STP")]
        public void WhenIReviewAndIssueTheApplicationForSTP(Table table)
        {
            ReviewPage reviewAndSubmit = new ReviewPage(getDriver());
            reviewAndSubmit.acceptReviewPageTermsAndIssuePolicy_STP(table.Rows[0]["PaperlessDelivery"], table.Rows[0]["PaymentPlan"]);
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }
        [When(@"I verify Agent Dashbboard")]
        public void WhenIVerifyAgentDashbboard(Table table)
        {
            ReviewPage reviewAndSubmit = new ReviewPage(getDriver());
            reviewAndSubmit.acceptReviewPageTermsAndIssuePolicy_STP("yes", "1");
            reviewAndSubmit.verifyAgentDashboard(table.Rows[0]["Country"]);
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }

        [When(@"I set Credit Consent (.*) for CA")]
        public void WhenISetCreditConsentYesForCA(string Consent)
        {
            ReviewPage reviewAndSubmit = new ReviewPage(getDriver());
            reviewAndSubmit.SetCreditConsent(Consent);
        }



        [When(@"I Edit jewelry information in Jewelry Details page")]
        public void WhenIEditJewelryInformationInJewelryDetailsPage(Table table)
        {
            JewelryDetails JewelryDetails = new JewelryDetails(getDriver());
            var dictionoary = new Dictionary<string, string>();
            //Items items = table.CreateInstance<Items>();
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryItem = temp[0];
                if (JewelryItem.Length > 1)
                {
                    JewelryDetails.UpdateItemValue(JewelryItem, Itemcounter);
                    Itemcounter = Itemcounter + 1;
                }
            }
        }

        [When(@"I Select Jeweler Type in Jewelry Details Page")]
        public void ISelectJewelerTypeInJewelryDetailsPage(Table table)
        {
            JewelryDetails JewelryDetails = new JewelryDetails(getDriver());
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                JewelryDetails.selectJewelry(temp[0], Itemcounter);
                Itemcounter = Itemcounter + 1;
            }
                
        }



        [When(@"I Enter the jewelry information Jewelry Details page")]
        public void WhenIEnterTheJewelryInformationJewelryDetailsPage(Table table)
        {
            JewelryDetails JewelryDetails = new JewelryDetails(getDriver());
            var dictionoary = new Dictionary<string, string>();
            //Items items = table.CreateInstance<Items>();
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryGender = temp[1];
                string JewelrySubType = temp[0];
                string DateOFPurchase = temp[2];
                if (JewelryGender.Length > 1 || JewelrySubType.Length > 1)
                {
                    JewelryDetails.JewelryDetails_Details_Group(JewelrySubType, JewelryGender, Itemcounter);
                }
                if (temp[3].ToLower().Trim() == "yes")
                {
                    JewelryDetails.SelectAppraisal(Itemcounter);
                }

                if (DateOFPurchase.ToLower().Trim() != "")
                {
                    JewelryDetails.ClickApprisalDate(DateOFPurchase, Itemcounter);
                }
                Itemcounter = Itemcounter + 1;
            }
        }




        [When(@"I select (.*) in Jewelry Details page")]
        public void WhenISelectInJewelryDetailsPage(string EffectiveDate)
        {
            JewelryDetails JewelryDetails = new JewelryDetails(getDriver());
            DataStorage temp = new DataStorage();
            string PriInsured = null;
            string addr = null;
            string PlcyNo = null;
            string EffDt = null;
            string ExpDt = null;
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
            JewelryDetails.SetEffectiveDate(EffDt);
        }

        [When(@"I only Enetr (.*) in Securityoption of  Jewelry Details page")]
        public void WhenIOnlyEnetrInSecurityoptionOfJewelryDetailsPage(string AlarmSecuritySystems)
        {
            JewelryDetails JewelryDetails = new JewelryDetails(getDriver());
            JewelryDetails.SelectAlarm(AlarmSecuritySystems);
        }

        [When(@"I Enetr (.*) and Additional Underwriting Needed in Security option of  Jewelry Details page")]
        public void WhenIEnetrAndAdditionalUnderwritingNeededInSecurityOptionOfJewelryDetailsPage(string AlarmSecuritySystems, Table table)
       {
            JewelryDetails JewelryDetails = new JewelryDetails(getDriver());
            JewelryDetails.SelectAlarm(AlarmSecuritySystems);
            JewelryDetails.SetAdditionalUnderwritingNeeded(table.Rows[0]["AdditionalUnderwritingNeeded"]);
            JewelryDetails.ClickNext();
        }


        [When(@"I Enetr (.*) in Securityoption of  Jewelry Details page")]
        public void WhenIEnetrNoInSecurityoptionOfJewelryDetailsPage(string AlarmSecuritySystems)
        {
            JewelryDetails JewelryDetails = new JewelryDetails(getDriver());
            JewelryDetails.SelectAlarm(AlarmSecuritySystems);
            JewelryDetails.ClickNext();
        }


        [When(@"I enter the  Personal  History Details in UW question details")]
        public void WhenIEnterThePersonalHistoryDetailsInUWQuestionDetails(Table table)
        {
            AdditionalQuestions appAdditionalQuestions = new AdditionalQuestions(getDriver());
            appAdditionalQuestions.SetPersonalHistory(table.Rows[0]["DeniedCov"], table.Rows[0]["DeniedCovreason"]);

        }

        [When(@"I enter  for Jewelry Storage Details in UW question details")]
        public void WhenIEnterForJewelryStorageDetailsInUWQuestionDetails(Table table)
        {
            AdditionalQuestions appAdditionalQuestions = new AdditionalQuestions(getDriver());
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

            //if ((table.Rows[0]["HomeHasOtherResidents"] == "Yes") || (table.Rows[0]["HomeHasOtherResidents"] == "yes"))
            //{
            //    //appAdditionalQuestions.SetHomeHasOtherResidentsDetails();
            //}
        }

        [When(@"I enter Travel Details in UW question details")]
        public void WhenIEnterTravelDetailsInUWQuestionDetails(Table table)
        {
            AdditionalQuestions appAdditionalQuestions = new AdditionalQuestions(getDriver());
            appAdditionalQuestions.SetTavelDetails(table.Rows[0]["TravelOverNightFreq"], table.Rows[0]["TravelAbroad"], table.Rows[0]["TravelSafeGuard"], table.Rows[0]["TravelDescription"]);

        }

        [When(@"I click on NewExisting Customer Page")]
        public void WhenIClickOnNewExistingCustomerPage()
        {
            NewCustomer NewCus = new NewCustomer(getDriver());
            NewCus.ClickContinue();
        }

        [When(@"I Enter Malling Address of Appplicant")]
        public void WhenIEnterMallingAddressOfAppplicant(Table table)
        {
            ApplicantWearerPage appAndWearer = new ApplicantWearerPage(getDriver());
            appAndWearer.ApplicantMaillingAddress(table.Rows[0]["Address"], table.Rows[0]["Apartment"], table.Rows[0]["City"], table.Rows[0]["State"], table.Rows[0]["Zip"]);
            //   PLPayment.makePayment(table.Rows[0]["paymentMethod"], table.Rows[0]["Country"], table.Rows[0]["paymentAmount"], table.Rows[0]["PaymentType"], table.Rows[0]["paymentDate"]);

        }

        [When(@"I Enter (.*) , (.*) , (.*) , (.*)  in the Quote Page Details for Partner Mode")]
        public void IEnterInTheQuotePageDetailsForPartnerMode(string FirstName, string LastName, string Phonenumber, string Email)
        {
            QuotePage quote = new QuotePage(getDriver());
            quote.AddPartnerDetails(FirstName, LastName, Phonenumber, Email);

        }


        [When(@"I Enter the Quote Page Details")]
        public void WhenIEnterTheQuotePageDetails(Table table)
        {
            QuotePage quote = new QuotePage(getDriver());
            var dictionoary = new Dictionary<string, string>();
            // Items items = table.CreateInstance<Items>();
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                if (Itemcounter == 1)
                {
                    quote.EnterZipCode(temp[0]);
                }
                if (Itemcounter > 1)
                {
                    quote.AddanotherItem();
                }
                string JewelryItem = temp[1];
                string JewelryItemvalue = temp[2];
                quote.AddJewelryItem(JewelryItem, JewelryItemvalue, Itemcounter);
                Itemcounter = Itemcounter + 1;
            }
            quote.click_Continue();

            quote.click_ApplyForCoverage(Itemcounter);
        }












        [Then(@"I click on Contact JMIS on the Confirmation page")]
        public void ThenIClickOnContactJMISOnTheConfirmationPage()
        {
            Confirmation ContactJMIS = new Confirmation(getDriver());
            ContactJMIS.ClickJMISButton();
        }



        [Then(@"I validate first name , last name, (.*), (.*) and select contact preference (.*)")]
        public void WhenIValidateAndSelectContactPreference(string phoneNumberJMIS, string emailAddress, string EmailOrPhoneJMIS)
        {
            string Fname = null;
            string Lname = null;
            DataStorage temp = new DataStorage();
            Fname = temp.GetTempValue("FNAME");
            Lname = temp.GetTempValue("LNAME");
            Confirmation ContactJMIS = new Confirmation(getDriver());
            ContactJMIS.VerifyDetailsJMIS(Fname, Lname, phoneNumberJMIS, emailAddress);
            ContactJMIS.ClickJMISContactPreference(EmailOrPhoneJMIS);
        }

        [Then(@"I click Send To JMIS button")]
        public void ThenIClickSendToJMISButton()
        {
            Confirmation SendToJMIS = new Confirmation(getDriver());
            SendToJMIS.ClickSendToJMIS();
        }

        [When(@"I select ReferalSource for Quote internal mode")]
        public void WhenISelectReferalSourceForQuoteInternalMode(Table table)
        {
            InternalModeHome IM = new InternalModeHome(getDriver());
            IM.SelectReferralSource(table.Rows[0]["ReferalSource"], table.Rows[0]["ReferralOption"]);
            IM.click_Continue();

        }


        [When(@"I login to partner mode")]
        public void WhenILoginToPartnerMode(Table table)
        {
            PartnerModeHome PM = new PartnerModeHome(getDriver());
            PM.loginPartnerMode(table.Rows[0]["UserName"], table.Rows[0]["Password"]);
        }

        [When(@"I login to super partner mode")]
        public void WhenILoginToSuperPartnerMode(Table table)
        {
            PartnerModeHome PM = new PartnerModeHome(getDriver());
            PM.loginSuperPartnerMode(table.Rows[0]["UserName"], table.Rows[0]["Password"]);
        }

        [When(@"I select Agency")]
        public void WhenISelectAgency(Table table)
        {
            PartnerModeHome PM = new PartnerModeHome(getDriver());
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string Agency = temp[0];
                PM.selectAgency(Agency);

            }
            PM.clickContinuebtn();
        }


        [Then(@"I make payment using E-check, Set (.*) and Later I verify confirmation message and policy number depending on Environment and (.*)")]
        [When(@"I make payment using E-check, Set (.*) and Later I verify confirmation message and policy number depending on Environment and (.*)")]
        public void ThenIMakePaymentUsingE_CheckSetAndLaterIVerifyConfirmationMessageAndPolicyNumberDependingOnEnvironmentAnd(string AutoPay, string PolicyStatus, Table table)
        {
            Paymentus Paymentus = new Paymentus(getDriver());
            Paymentus.MakeACHPayment(table.Rows[0]["AchType"], table.Rows[0]["Country"], AutoPay);
            Console.WriteLine("before confirmation page");
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    System.Threading.Thread.Sleep(1000);
                    Confirmation CaptureAccount = new Confirmation(getDriver());
                    CaptureAccount.CaptureAccountNumber();
                    DataStorage tempData = new DataStorage();
                    tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
                    if (table.Rows[0]["ConfirmationContentValidation"].Length > 10)
                    {
                        CaptureAccount.VerifyConfirmationText(table.Rows[0]["ConfirmationContentValidation"]);
                    }
                    CaptureAccount.VerifyAutoPay(AutoPay);
                    Console.WriteLine("adding verification of Policy nember - pending");
                    System.Threading.Thread.Sleep(15000);
                    CaptureAccount.CapturePolicyNumberDisplayed();


                    break;
                default:
                    break;
            }
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }

        [When(@"I select Payment PLan")]
        [Then(@"I select Payment PLan")]
        public void WhenISelectPaymentPLan(Table table)
        {
            PaymentPlan Paymentus = new PaymentPlan(getDriver());
            Paymentus.selectPaymentPlan(table.Rows[0]["PaymentPLan"]);


        }


        [Then(@"I make payment using Card, Set (.*) and Later I verify confirmation message and policy number depending on Environment and (.*)")]
        [When(@"I make payment using Card, Set (.*) and Later I verify confirmation message and policy number depending on Environment and (.*)")]
        public void ThenIMakePaymentUsingCardSetAndLaterIVerifyConfirmationMessageAndPolicyNumberDependingOnEnvironmentAnd(string AutoPay, string PolicyStatus, Table table)
        {
            Paymentus Paymentus = new Paymentus(getDriver());
            Paymentus.MakeCCPayment(table.Rows[0]["cardType"], table.Rows[0]["Country"], AutoPay);
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    System.Threading.Thread.Sleep(1000);
                    Confirmation CaptureAccount = new Confirmation(getDriver());
                    CaptureAccount.CaptureAccountNumber();
                    DataStorage tempData = new DataStorage();
                    tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
                    if (table.Rows[0]["ConfirmationContentValidation"].Length > 10)
                    {
                        CaptureAccount.VerifyConfirmationText(table.Rows[0]["ConfirmationContentValidation"]);
                    }
                    CaptureAccount.VerifyAutoPay(AutoPay);

                    ///Console.WriteLine("adding verification of Policy nember - pending");
                    ///System.Threading.Thread.Sleep(15000);
                    ///CaptureAccount.CapturePolicyNumberDisplayed();

                    break;
                default:
                    break;
            }
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }



        [When(@"I make payment using Card, set (.*)  Confirmation page and policy number depending on Environment and (.*) and register for PL POrtal (.*)")]
        [Then(@"I make payment using Card, set (.*)  Confirmation page and policy number depending on Environment and (.*) and register for PL POrtal (.*)")]
        public void ThenIMakePaymentUsingCardSetYesConfirmationPageAndPolicyNumberDependingOnEnvironmentAndInForceAndRegisterForPLPOrtalPass(string Autopay, string PolicyStatus, string PLPortal_Password, Table table)
        {
            Paymentus Paymentus = new Paymentus(getDriver());
            Paymentus.MakeCCPayment(table.Rows[0]["cardType"], table.Rows[0]["Country"], Autopay);
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("in confirmation page logic");
                    string Fname = null;
                    string Lname = null;
                    System.Threading.Thread.Sleep(5000);
                    Confirmation ContactJMIS = new Confirmation(getDriver());
                    DataStorage temp = new DataStorage();
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("*********************ACCOUNT NUM Confirmation page***************************");
                    ContactJMIS.CaptureAccountNumber();
                    //temp.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
                    if (table.Rows[0]["ConfirmationContentValidation"].Length > 10)
                    {
                        ContactJMIS.VerifyConfirmationText(table.Rows[0]["ConfirmationContentValidation"]);
                    }
                    ContactJMIS.VerifyAutoPay(Autopay);
                    ContactJMIS.RegisterPLPortal(PLPortal_Password);
                    Console.WriteLine("adding verification of Policy nember - pending");
                    System.Threading.Thread.Sleep(15000);
                    ContactJMIS.CapturePolicyNumberDisplayed();
                    break;
                default:
                    break;
            }

            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }



        [When(@"I make payment using Card, set (.*)  and Verify Contact JMIS Page (.*), (.*), (.*), Confirmation page and policy number depending on Environment and (.*)")]
        [Then(@"I make payment using Card, set (.*)  and Verify Contact JMIS Page (.*), (.*), (.*), Confirmation page and policy number depending on Environment and (.*)")]
        public void ThenIMakePaymentUsingCardSetAndVerifyContactJMISPageConfirmationPageWithTheAccountNumber(string Autopay, string phoneNumberJMIS, string emailAddress, string EmailOrPhoneJMIS, string PolicyStatus, Table table)
        {
            Paymentus Paymentus = new Paymentus(getDriver());
            Paymentus.MakeCCPayment(table.Rows[0]["cardType"], table.Rows[0]["Country"], Autopay);
            Console.WriteLine("in pre confirmation page logic");
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("in confirmation page logic");
                    string Fname = null;
                    string Lname = null;
                    System.Threading.Thread.Sleep(5000);
                    Confirmation ContactJMIS = new Confirmation(getDriver());
                    DataStorage temp = new DataStorage();
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("*********************ACCOUNT NUM Confirmation page***************************");
                    ContactJMIS.CaptureAccountNumber();
                    //temp.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
                    if (table.Rows[0]["ConfirmationContentValidation"].Length > 10)
                    {
                        ContactJMIS.VerifyConfirmationText(table.Rows[0]["ConfirmationContentValidation"]);
                    }

                    ///Console.WriteLine("adding verification of Policy nember - pending");
                    ///System.Threading.Thread.Sleep(15000);
                    ///ContactJMIS.CapturePolicyNumberDisplayed();

                    ContactJMIS.VerifyAutoPay(Autopay);
                    ContactJMIS.ClickGetQuotes();
                    ContactJMIS.VerifyQuoteContnet();
                    ContactJMIS.ClickGetQuotesGotIt();


                    //ContactJMIS.ClickJMISButton();
                    //Fname = temp.GetTempValue("FNAME");
                    //Lname = temp.GetTempValue("LNAME");
                    //Console.WriteLine("*********************" + Fname + Lname + phoneNumberJMIS + EmailOrPhoneJMIS + emailAddress + "***************************");
                    //ContactJMIS.VerifyDetailsJMIS(Fname, Lname, phoneNumberJMIS, emailAddress);
                    //ContactJMIS.ClickJMISContactPreference(EmailOrPhoneJMIS);
                    //ContactJMIS.ClickSendToJMIS();
                    break;
                default:
                    break;
            }
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }

        [When(@"I make ACH payment, Set (.*) and Later I verify confirmation message depending on Environment for Partner Mode and (.*)")]
        [Then(@"I make ACH payment, Set (.*) and Later I verify confirmation message depending on Environment for Partner Mode and (.*)")]
        public void ThenIMakeACHPaymentSetAndLaterIVerifyConfirmationMessageDependingOnEnvironmentForPartnerModeAnd(string AutoPay, string PolicyStatus, Table table)
        {
            Paymentus Paymentus = new Paymentus(getDriver());
            Paymentus.MakePartnerModeACHPayment(table.Rows[0]["AchType"], table.Rows[0]["Country"], AutoPay);
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    System.Threading.Thread.Sleep(1000);
                    Confirmation CaptureAccount = new Confirmation(getDriver());
                    CaptureAccount.CaptureAccountNumber();
                    DataStorage tempData = new DataStorage();
                    tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
                    if (table.Rows[0]["ConfirmationContentValidation"].Length > 10)
                    {
                        CaptureAccount.VerifyConfirmationText(table.Rows[0]["ConfirmationContentValidation"]);
                    }
                    CaptureAccount.VerifyAutoPayPolicyStatus(AutoPay, PolicyStatus);
                    Console.WriteLine("adding verification of Policy nember - pending");
                    System.Threading.Thread.Sleep(15000);
                    CaptureAccount.CapturePolicyNumberDisplayed();


                    break;
                default:
                    break;
            }
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }


        [When(@"I make Card payment, Set (.*) and Later I verify confirmation message depending on Environment for Partner Mode and (.*)")]
        [Then(@"I make Card payment, Set (.*) and Later I verify confirmation message depending on Environment for Partner Mode and (.*)")]
        public void ThenIMakeCardPaymentSetAndLaterIVerifyConfirmationMessageDependingOnEnvironmentForPartnerModeAnd(string AutoPay, string PolicyStatus, Table table)
        {
            Paymentus Paymentus = new Paymentus(getDriver());
            Paymentus.MakePartnerModeCardPayment(table.Rows[0]["cardType"], table.Rows[0]["Country"], AutoPay);
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("inside stage");
                    Confirmation CaptureAccount = new Confirmation(getDriver());
                    CaptureAccount.CaptureAccountNumber();
                    DataStorage tempData = new DataStorage();
                    tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
                    if (table.Rows[0]["ConfirmationContentValidation"].Length > 10)
                    {
                        CaptureAccount.VerifyConfirmationText(table.Rows[0]["ConfirmationContentValidation"]);
                    }
                    CaptureAccount.VerifyAutoPayPolicyStatus(AutoPay, PolicyStatus);
                    Console.WriteLine("adding verification of Policy nember - pending");
                    //System.Threading.Thread.Sleep(15000);
                    //CaptureAccount.CapturePolicyNumberDisplayed();
                    break;
                default:
                    break;
            }
            KillWEbDriver();
            ScenarioContext.Current.Remove("WebDriver");
        }

        #region Express Partner

       
        [When(@"I enetr detailes in Epress Partners Quote Page")]
        public void IEnetrDetailesInEpressPartnersQuotePage(Table table)
        {
            ExpPartnerQuotePage QuotePage = new ExpPartnerQuotePage(getDriver());
            QuotePage.EnterOrderDetails(table.Rows[0]["OrderNo"], table.Rows[0]["Email"]);
        }

        [When(@"I click on Apply for Coverage button in Epress Partners Quote info Page")]
        public void IClickOnApplyForCoverageButtonInEpressPartnersQuoteInfoPage()
        {
            ExpPartnerQuoteInfoPage QuoteInfoPage = new ExpPartnerQuoteInfoPage(getDriver());
            QuoteInfoPage.ClickApplyforCoverage();
        }




        #endregion

        #region Loos
        [When(@"I click on Continue button on Free Jewelry Insurance Quote Page")]
        public void WhenIClickOnContinueButtonOnFreeJewelryInsuranceQuotePage()
        {
            BroucherQuotePage loosquote = new BroucherQuotePage(getDriver());
            loosquote.click_Continue();
        }

        [When(@"I Enter the Quote Page Details for LOOS")]
        public void WhenIEnterTheQuotePageDetailsForLOOS(Table table)
        {
            LOOSQuotePage quote = new LOOSQuotePage(getDriver());
            var dictionoary = new Dictionary<string, string>();
            // Items items = table.CreateInstance<Items>();
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                if (Itemcounter == 1)
                {
                    quote.EnterZipCode(temp[0]);
                }
                if (Itemcounter > 1)
                {
                    quote.AddanotherItem();
                }
                string JewelryItem = temp[1];
                string JewelryItemvalue = temp[2];
                quote.AddJewelryItem(JewelryItem, JewelryItemvalue, Itemcounter);
                Itemcounter = Itemcounter + 1;
            }
            quote.click_Continue();

            quote.click_ApplyForCoverage(Itemcounter);
        }


        [When(@"I Enter (.*) , (.*) , (.*)  in the Quote Page Details for LOOS")]
        public void WhenIEnterInTheQuotePageDetailsForLOOS(string FirstName, string LastName, string Email)
        {
            LOOSQuotePage quote = new LOOSQuotePage(getDriver());
            quote.AddPartnerDetails(FirstName, LastName, Email);

        }


        [When(@"I Enter State where I recently made purcahse")]
        public void WhenIEnterStateWhereIRecentlyMadePurcahse(Table table)
        {
            BroucherQuotePage loosquote = new BroucherQuotePage(getDriver());
            loosquote.UpdateRecentPurchase(table.Rows[0]["State"]);

        }

        [When(@"I select Location on Free Jewelry Insurance Quote Page")]
        public void WhenISelectLocationOnFreeJewelryInsuranceQuotePage(Table table)
        {
            BroucherQuotePage loosquote = new BroucherQuotePage(getDriver());
            loosquote.selectLocation(table.Rows[0]["Location_counter"]);
        }


        [When(@"I enter the (.*) on Free Jewelry Insurance Quote Page")]
        public void WhenIEnterTheOnFreeJewelryInsuranceQuotePage(int p0)
        {
            BroucherQuotePage loosquote = new BroucherQuotePage(getDriver());
            loosquote.entercodefromBroucher(p0);
            loosquote.click_Continue();
            System.Threading.Thread.Sleep(5000);
            loosquote.click_Continue2();
            System.Threading.Thread.Sleep(5000);
        }
        #endregion


    }
}


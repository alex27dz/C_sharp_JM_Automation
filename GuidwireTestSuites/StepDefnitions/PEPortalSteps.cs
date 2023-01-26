using TechTalk.SpecFlow;
using WebCommonCore;
using ProducerEngage.Pages;
using HelperClasses;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuidewireTestSuites
{
    [Binding]
    public class PEPortalSteps : TestBase
    {

        [Given(@"I access the Producer Engage app in (.*) , (.*) , (.*) , (.*) and (.*)")]
        public void GivenIAccessTheProducerEngageAppInAnd(string ApplicationEnvironment, string TargetType, string Capability, string BrowserType, string OperatingSystem)
        {
            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];

            ScenarioContext.Current["Application"] = ApplicationEnvironment;

            ScenarioContext.Current["TargetType"] = TargetType;

            ScenarioContext.Current["Capability"] = Capability;

            ScenarioContext.Current["BrowserType"] = BrowserType;

            if (TargetType.ToLower() != "desktop")
            {
                // startBrowserStackLocal();

                System.Threading.Thread.Sleep(10000);
            }
        }

        [When(@"I click on start New Quote button")]
        public void WhenIClickOnStartNewQuoteButton()
        {
            HomePage homePage = new HomePage(getDriver());
            homePage.ClickStartNewQuoteButton();
        }

        [When(@"I Enter (.*) and (.*) in New Quote Search for Existing Account Page")]
        public void WhenIEnterPEAndScenario_InNewQuoteSearchForExistingAccountPage(string firstName, string lastname)
        {
            ExistingAccountPage existingAccountPage = new ExistingAccountPage(getDriver());
            existingAccountPage.SearchByFirstAndLastName(firstName, lastname);
        }

        [When(@"I take action on search Account result")]
        public void ITakeActionOnSearchAccountResult(Table table)
        {
            SearchAccountResultpage ResultPage = new SearchAccountResultpage(getDriver());
            ResultPage.AtionOnSerachResult(table.Rows[0]["Action"]);
        }

        [When(@"I Enter (.*) , (.*) , (.*), (.*) and (.*) in Create New Account Page")]
        public void IEnterJewelersParkDrNeenahWisconsinAndInCreateNewAccountPage(string address1, string address2, string city, string state, string zip)
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.EnterAddressDetails(address1, address2, city, state, zip);
        }
        [When(@"I select producer code")]
        public void WhenISelectProducerCode(Table table)
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.SelectProducerCode(table.Rows[0]["ProducerCode"]);
        }
        [When(@"I click Create Account in Create New Account Page")]
        public void WhenIClickCreateAccountInCreateNewAccountPage()
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.ClickCreateAccount();
        }
        [When(@"I click Start Full Application")]
        public void WhenIClickStartFullApplication()
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.ClickStartApplication();
        }

        [When(@"I enter other address related details (.*) , (.*) , (.*) , (.*) and (.*) in Create New Account Page")]
        public void IEnterOtherAddressRelatedInCreateNewAccountPage(string EmailAddress, string HomePhone, string WorkPhone, string MobilePhone, string PrimaryNumber)
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.EnterOtherDetails(EmailAddress, HomePhone, WorkPhone, MobilePhone, PrimaryNumber);
        }

        [When(@"I select (.*) in Create New Account Page")]
        public void ISelectdateInCreateNewAccountPage(string EffectiveDate)
        {
            string EffDt = null;
            DataStorage temp = new DataStorage();
            switch (EffectiveDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    EffDt = temp.GetTempValue("EFFDATE");
                    break;
                default:
                    EffDt = EffectiveDate;
                    break;
            }
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.SetEffectiveDate(EffDt);

        }

        [When(@"I click Next in Create New Account Page")]
        public void IClickNextInCreateNewAccountPage()
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.ClickNext();
        }

        [When(@"I enter below details in Article Page")]
        public void IEnterBelowDetailsInArticlePage(Table table)
        {
            PersonalArticlespage Articlespage = new PersonalArticlespage(getDriver());
            Articlespage.AddArticleDetails(table);

        }


        [When(@"I click on next in Article Page")]
        public void IClickOnNextInArticlePage()
        {
            PersonalArticlespage Articlespage = new PersonalArticlespage(getDriver());
            Articlespage.ClickNext();
        }


        [When(@"I Update Alarm Details in Location Details Page")]
        public void IUpdateAlarmDetailsInLocationDetailsPage(Table table)
        {
            LocationDetailspage Locationpage = new LocationDetailspage(getDriver());
            Locationpage.AddAlarmDetails(table);
        }

        [When(@"I Update Safe Details in Location Details Page")]
        public void IUpdateSafeDetailsInLocationDetailsPage(Table table)
        {
            LocationDetailspage Locationpage = new LocationDetailspage(getDriver());
            Locationpage.AddSafeDetails(table);
        }

        [When(@"I Update UW Details in Location Details Page")]
        public void WhenIUpdateUWDetailsInLocationDetailsPage(Table table)
        {
            LocationDetailspage Locationpage = new LocationDetailspage(getDriver());
            Locationpage.AddUWDetails(table);
        }


        [When(@"I click on next in Location Details Page")]
        public void IClickOnNextInLocationDetailsPage()
        {
            LocationDetailspage Locationpage = new LocationDetailspage(getDriver());
            Locationpage.ClickNext();
        }

        [When(@"For single contact I update convicted crime denied Coverage and (.*)  in Contact Details Page")]
        public void ForSingleContactIUpdateConvictedCrimeDeniedCoverageAndInContactDetailsPage(string dob, Table table)
        {
            ContactDetailspage Contactpage = new ContactDetailspage(getDriver());
            Contactpage.SingleItemDetails(table, dob);
        }



        [When(@"I Update convicted crime information in Contact Details Page")]
        public void IUpdateConvictedCrimeInformationInContactDetailsPage(Table table)
        {
            ContactDetailspage Contactpage = new ContactDetailspage(getDriver());
            Contactpage.CrimeDetails(table);
        }

        [When(@"I Update denied Coverage information in Contact Details Page")]
        public void IUpdateDeniedCoverageInformationInContactDetailsPage(Table table)
        {
            ContactDetailspage Contactpage = new ContactDetailspage(getDriver());
            Contactpage.DeniedCoverage(table);
        }

        [When(@"I Update details for Additional question in Contact Deatils Page")]
        public void IUpdateDetailsForAdditionalQuestionInContactDeatilsPage(Table table)
        {
            ContactDetailspage Contactpage = new ContactDetailspage(getDriver());
            Contactpage.AdditionalUWQuestions(table);
        }


        [When(@"I Eneter (.*) for Primary Contact in Contact Details Page")]
        public void WhenIEneterForPrimaryContactInContactDetailsPage(string DOB)
        {
            ContactDetailspage Contactpage = new ContactDetailspage(getDriver());
            Contactpage.SetDateOfBirthforPrimaryContact(DOB);
        }

        [When(@"I click on next in Contact Details Page")]
        public void WhenIClickOnNextInContactDetailsPage()
        {
            ContactDetailspage Contactpage = new ContactDetailspage(getDriver());
            Contactpage.ClickNext();
        }

        [When(@"I Update Loss details in Consent Details Page")]
        public void IUpdateLossDetailsInConsentDetailsPage(Table table)
        {
            ConsentDetailspage Consentpage = new ConsentDetailspage(getDriver());
            Consentpage.LossDetails(table);
        }

        [When(@"I Update details in Consent Details Page")]
        public void IUpdateDetailsInConsentDetailsPage(Table table)
        {
            ConsentDetailspage Consentpage = new ConsentDetailspage(getDriver());
            Consentpage.SetLossConsent(table.Rows[0]["LossConsent"]);
            Consentpage.SetPossessionConsent(table.Rows[0]["PossessionConsent"]);
            Consentpage.SetStatmentConsent(table.Rows[0]["StatmentConsent"]);
            Consentpage.SetReportConsent(table.Rows[0]["ReportConsent"]);
        }


        [When(@"I click on next in Consent Details Page")]
        public void IClickOnNextInConsentDetailsPage()
        {
            ConsentDetailspage Consentpage = new ConsentDetailspage(getDriver());
            Consentpage.ClickNext();
        }

        [When(@"I click on details for underwriter approval in Quote Page")]
        public void WhenIClickOnDetailsForUnderwriterApprovalInQuotePage()
        {
            Quotepage Quotepage = new Quotepage(getDriver());
            Quotepage.ClickdetailsforUW();

        }

        [When(@"I click on Continue in Quote Page")]
        public void WhenIClickOnContinueInQuotePage()
        {
            Quotepage Quotepage = new Quotepage(getDriver());
            Quotepage.ClickContinue();
        }


        [When(@"I click Next on Policy Information Page")]
        public void WhenIClickNextOnPolicyInformationPage()
        {
            PolicyInformationpage PolicyInformation = new PolicyInformationpage(getDriver());
            PolicyInformation.ClickNextButton();
        }

        [When(@"I submit my application for review on the Policy Information page")]
        public void WhenISubmitMyApplicationForReviewOnThePolicyInformationPage()
        {
            PolicyInformationpage policyInformationPage = new PolicyInformationpage(getDriver());
            policyInformationPage.ClickYesOverviewAndFraudWarning();
            policyInformationPage.ClickSubmitForReviewButton();
        }

        [When(@"I obtain the account and submission number from the Quote Summary page")]
        public void WhenIObtainTheAccountAndSubmissionNumberFromTheQuoteSummaryPage()
        {
            QuoteSummaryPage quoteSummaryPage = new QuoteSummaryPage(getDriver());
            quoteSummaryPage.ExtractAccountNumber();
            quoteSummaryPage.ExtractSubmissionNumber();
        }

        [When(@"I click Continue quote in the Quote Summary page")]
        public void WhenIClickContinueQuoteInTheQuoteSummaryPage()
        {
            QuoteSummaryPage quoteSummaryPage = new QuoteSummaryPage(getDriver());
            quoteSummaryPage.ClickContinueQuoteButton();
        }

        [When(@"I send Quot for UW review in Quote Summary UW page")]
        public void WhenISendQuotForUWReviewInQuoteSummaryUWPage()
        {
            QuoteSummaryUWpage UWpage = new QuoteSummaryUWpage(getDriver());
            UWpage.RefertoUW();
        }

        [When(@"I see the account with (.*) and (.*) in the Search Account Result page")]
        public void WhenISeeTheAccountWithUniqueAndUniqueInThePossibleAccountMatchesPage(string firstName, string lastName)
        {
            SearchAccountResultpage searchResultPage = new SearchAccountResultpage(getDriver());
            searchResultPage.VerifyAccount(firstName, lastName);
        }

        [When(@"I enter birthday in Create New Account Page")]
        public void WhenIEnterBirthdayInCreateNewAccountPage(Table table)
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.EnterDateOfBirth(table.Rows[0]["BIRTHDAY"]);
        }

        [When(@"I verify the address verification page is puped up")]
        public void WhenIVerifyTheAddressVerificationPageIsPupedUp()
        {
            AddressSelection addressSelection = new AddressSelection(getDriver());
            addressSelection.verifySelectAddressButton();
        }

        [When(@"I select the first address in address verification page")]
        public void WhenISelectTheFirstAddressInAddressVerificationPage()
        {
            AddressSelection addressSelection = new AddressSelection(getDriver());
            addressSelection.SelectFirstAddress();
        }

        [When(@"I verify the account is created")]
        public void WhenIVerifyTheAccountIsCreated()
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.VerifyAccountIsCreated();
        }

        [When(@"I click Quick Estimate button")]
        public void WhenIClickQuickEstimateButton()
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            Accountpage.ClickQuickEstimateButton();
        }

        [When(@"I enter below details in Quick Estimate page")]
        public void WhenIEnterBelowDetailsInQuickEstimatePage(Table table)
        {

            string itemType = table.Rows[0]["ITEM TYPE"];
            Console.WriteLine("itemType " + itemType);
            string itemSubType = table.Rows[0]["ITEM SUBTYPE"];
            Console.WriteLine("itemSubType " + itemSubType);
            string gender = table.Rows[0]["GENDER"];
            Console.WriteLine("gender " + gender);
            string itemValue = table.Rows[0]["ITEM VALUE"];
            Console.WriteLine("itemValue " + itemValue);

            QuickEstimatepage qq = new QuickEstimatepage(getDriver());
            qq.AddItem(itemType, itemSubType, gender, itemValue);
        }

        [When(@"I click Estimate button in Quick Estimate page")]
        public void WhenIClickEstimateButtonInQuickEstimatePage()
        {
            QuickEstimatepage qq = new QuickEstimatepage(getDriver());
            qq.ClickEstimateButton();
        }

        [When(@"I verify that the Estimated Annual Premium is returned in Quick Estimate page")]
        public void WhenIVerifyThatTheEstimatedAnnualPremiumIsReturnedInQuickEstimatePage()
        {
            QuickEstimatepage qq = new QuickEstimatepage(getDriver());
            qq.VerifyEstimatedAnnualPremiumIsReturned();
        }

        [When(@"I verify that the QQ print button is enabled")]
        public void WhenIVerifyThatTheQQPrintButtonIsEnabled()
        {
            QuickEstimatepage qq = new QuickEstimatepage(getDriver());
            qq.VerifyQQPdfPrintButtonIsEnable();
        }

        [When(@"I click on Apply button in Quick Estimate page")]
        public void WhenIClickOnApplyButtonInQuickEstimatePage()
        {
            QuickEstimatepage qq = new QuickEstimatepage(getDriver());
            qq.ClickApplyButton();
        }

        [When(@"I click on next in Personal Articles page")]
        public void WhenIClickOnNextInPersonalArticlesPage()
        {
            PersonalArticlespage articlespage = new PersonalArticlespage(getDriver());
            articlespage.ClickNext();
        }

        [When(@"I select No for Damage question for the article in Personal Articles page")]
        public void WhenISelectNoForDamageQuestionInPersonalArticlesPage()
        {
            PersonalArticlespage articlespage = new PersonalArticlespage(getDriver());
            articlespage.setDamageToBeBoForAnArticleForQQ();
        }

        [When(@"I select No for Convict Of Crime in Contact Details Page")]
        public void WhenISelectNoForConvictOfCrimeInContactDetailsPage()
        {
            ContactDetailspage contactDetailspage = new ContactDetailspage(getDriver());
            contactDetailspage.setConvictedofCrimedToBeNoForQQ();
        }

        [When(@"I select No for Denied Coverage question for the article in Contact Details Page")]
        public void WhenISelectNoForDeniedCoverageQuestionForTheArticleInContactDetailsPage()
        {
            ContactDetailspage contactDetailspage = new ContactDetailspage(getDriver());
            contactDetailspage.setDeniedCoverageToBeNoForQQ();
        }

        [When(@"I select (.*) phone (.*) as the Primary number")]
        public void WhenISelectHomePhoneAsThePrimaryNumber(string phoneType, string phoneNumber)
        {
            NewAccountpage Accountpage = new NewAccountpage(getDriver());
            switch (phoneType.ToLower().Trim())
            {
                case "home":
                    Accountpage.EnterOtherDetails("anyone@jminsure.com", phoneNumber, "", "", "homephone");
                    break;
                case "work":
                    Accountpage.EnterOtherDetails("anyone@jminsure.com", "", phoneNumber, "", "workphone");
                    break;
                case "mobile":
                    Accountpage.EnterOtherDetails("anyone@jminsure.com", "", "", phoneNumber, "mobilephone");
                    break;
                default:
                    Accountpage.EnterOtherDetails("anyone@jminsure.com", phoneNumber, "", "", "homephone");
                    break;
            }
        }

        [When(@"I search account with first name (.*) and last name (.*)")]
        public void WhenISearchAccountWithFirstNameAndLastName(string firstName, string lastName)
        {
            SearchAccountResultpage searchAccountResultpage = new SearchAccountResultpage(getDriver());
            searchAccountResultpage.SearchAccountByName(firstName, lastName);
        }

        [When(@"I click account number link in the Search Account Result page")]
        public void WhenIClickREGISTRYLinkInTheSearchAccountResultPage()
        {
            SearchAccountResultpage searchAccountResultpage = new SearchAccountResultpage(getDriver());
            searchAccountResultpage.ClickAccountLink();
        }

        [When(@"I see polices are in the Issued Policies section for this account")]
        public void WhenISeePolicesAreInTheIssuedPoliciesSectionForThisAccount()
        {
            ScenarioContext.Current.Pending();
        }

        #region NEW PE Portal Steps
        [Given(@"I access the Producer Engage application in (.*), (.*) and (.*)")]
        [When(@"I access the Producer Engage application in (.*), (.*) and (.*)")]
        public void GivenIAccessTheProducerEngageApplicationInAnd(string applicationEnvironment, string targetType, string browserType)
        {
            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];
            ScenarioContext.Current["Application"] = applicationEnvironment;
            ScenarioContext.Current["TargetType"] = targetType;
            ScenarioContext.Current["BrowserType"] = browserType;
        }

        [When(@"I login to Producer Engage")]
        public void GivenILoginToProducerEngage(Table table)
        {
            PELoginPage loginPage = new PELoginPage(getDriver());
            loginPage.EnterEmail(table.Rows[0]["Email"]);
            loginPage.EnterPassword(table.Rows[0]["Password"]);
            loginPage.ClickLoginButton();
        }

        [When(@"I click Start New Quote in Producer Engage home page")]
        public void GivenIClickStartNewQuoteInProducerEngageHomePage()
        {
            HomePage homePage = new HomePage(getDriver());
            homePage.ClickStartNewQuoteButton();
        }

        [When(@"I click Search in Producer Engage home page")]
        public void WhenIClickSearchInProducerEngageHomePage()
        {
            HomePage homePage = new HomePage(getDriver());
            homePage.ClickSearchButton();
        }

        [When(@"I search for an existing account in Producer Engage")]
        public void GivenISearchForAnExistingAccountInProducerEngage(Table table)
        {
            var firstName = table.Rows[0]["FirstName"].ToString().Contains("Unique")
                            ? Unique.LetterSequence(10)
                            : table.Rows[0]["FirstName"].ToString().Contains("Context")
                            ? ScenarioContext.Current["FirstName"].ToString()
                            : table.Rows[0]["FirstName"];

            var lastName = table.Rows[0]["LastName"].ToString().Contains("Context")
                           ? ScenarioContext.Current["LastName"].ToString()
                           : table.Rows[0]["LastName"];

            ExistingAccountPage existingAccountPage = new ExistingAccountPage(getDriver());
            existingAccountPage.EnterFirstName(firstName);
            existingAccountPage.EnterLastName(lastName);

            // Optional Fields
            if (!string.IsNullOrEmpty(table.Rows[0]["City"]))
                existingAccountPage.EnterCity(table.Rows[0]["City"]);
            if (!string.IsNullOrEmpty(table.Rows[0]["ZipCode"]))
                existingAccountPage.EnterZipCode(table.Rows[0]["ZipCode"]);
            if (!string.IsNullOrEmpty(table.Rows[0]["State"]))
                existingAccountPage.SelectState(table.Rows[0]["State"]);
            if (!string.IsNullOrEmpty(table.Rows[0]["DateOfBirth"]))
                existingAccountPage.EnterDateOfBirth(table.Rows[0]["DateOfBirth"]);
            if (!string.IsNullOrEmpty(table.Rows[0]["EmailAddress"]))
                existingAccountPage.EnterEmailAddress(table.Rows[0]["EmailAddress"]);

            existingAccountPage.ClickSearchButton();
        }

        [When(@"I click my quote based on the submission number in Producer Engage")]
        public void WhenIClickMyQuoteBasedOnTheSubmissionNumberInProducerEngage()
        {
            AccountSearchResultsPage accountSearchResultsPage = new AccountSearchResultsPage(getDriver());
            accountSearchResultsPage.ClickQuoteLink();
        }

        [When(@"I continue as a new customer after searching for an existing account in Producer Engage")]
        public void GivenIContinueAsANewCustomerAfterSearchingForAnExistingAccountInProducerEngage()
        {
            AccountSearchResultsPage accountSearchResultsPage = new AccountSearchResultsPage(getDriver());
            accountSearchResultsPage.ClickContinueAsNewCustomerButton();
        }

        [When(@"I create a new account in the Create New Account page")]
        public void WhenICreateANewAccountInTheCreateNewAccountPage(Table table)
        {
            var values = table.Rows[0];

            CreateNewAccountPage createNewAccountPage = new CreateNewAccountPage(getDriver());
            createNewAccountPage.EnterAddressDetails(values["AddressLine1"], values["AddressLine2"],
                                                     values["City"], values["ZipCode"], values["State"]);

            // Optional Fields
            if (!string.IsNullOrEmpty(values["DateOfBirth"]))
                createNewAccountPage.EnterDateOfBirth(values["DateOfBirth"]);
            if (!string.IsNullOrEmpty(values["EmailAddress"]))
                createNewAccountPage.EnterEmailAddress(values["EmailAddress"]);
            if (!string.IsNullOrEmpty(values["HomeNumber"]))
                createNewAccountPage.EnterHomePhoneNumber(values["HomeNumber"]);
            if (!string.IsNullOrEmpty(values["WorkNumber"]))
                createNewAccountPage.EnterWorkPhoneNumber(values["WorkNumber"]);
            if (!string.IsNullOrEmpty(values["MobileNumber"]))
                createNewAccountPage.EnterMobilePhoneNumber(values["MobileNumber"]);
            if (!string.IsNullOrEmpty(values["PrimaryPhoneType"]))
                createNewAccountPage.SelectPrimaryPhoneType(values["PrimaryPhoneType"]);
            if (!string.IsNullOrEmpty(values["EffectiveDate"]) && !values["EffectiveDate"].Contains("Today"))
                createNewAccountPage.EnterEffectiveDate(values["EffectiveDate"]);

            createNewAccountPage.SelectProducerCode(values["ProducerCode"]);
            createNewAccountPage.ClickCreateAccount();
        }

        [When(@"I start a full application in Producer Engage")]
        public void WhenIStartAFullApplicationInProducerEngage()
        {
            CreateNewAccountPage createNewAccountPage = new CreateNewAccountPage(getDriver());
            createNewAccountPage.ClickStartNewApplicationButton();
        }

        [When(@"I save my credit card information in the Payment Details page")]
        public void WhenISaveMyCreditCardInformationInThePaymentDetailsPage(Table table)
        {
            var zipCode = table.Rows[0]["ZipCode"].Contains("Context") && ScenarioContext.Current.ContainsKey("ZipCode")
                          ? ScenarioContext.Current["ZipCode"].ToString()
                          : table.Rows[0]["ZipCode"];

            PaymentDetailsPage paymentDetailsPage = new PaymentDetailsPage(getDriver());
            paymentDetailsPage.ClickAddPaymentMethodButton();
            paymentDetailsPage.AddCreditCardInformation(table.Rows[0]["CardType"], table.Rows[0]["CVV"], table.Rows[0]["ExpirationDate"],
                                                        zipCode, table.Rows[0]["CardholderName"]);
        }

        [When(@"I click Buy Now in the Payment Details page")]
        public void WhenIClickBuyNowInThePaymentDetailsPage()
        {
            PaymentDetailsPage paymentDetailsPage = new PaymentDetailsPage(getDriver());
            paymentDetailsPage.ClickBuyNowButton();
        }

        [Then(@"I verify the policy summary details in the Payment Confirmation page")]
        public void ThenIVerifyThePolicySummaryDetailsInThePaymentConfirmationPage()
        {
            PaymentConfirmationPage paymentConfirmationPage = new PaymentConfirmationPage(getDriver());

            var accountNumber = paymentConfirmationPage.GetAccountNumber();
            Console.WriteLine(string.Format("Account Number: {0}", accountNumber));

            var policyNumber = paymentConfirmationPage.GetPolicyNumber();
            Console.WriteLine(string.Format("Policy Number: {0}", policyNumber));

            Assert.IsTrue(accountNumber.Contains(ScenarioContext.Current["AccountNumber"].ToString()), "Account Number Mismatch");
            Assert.IsTrue(!string.IsNullOrEmpty(policyNumber), "Policy Number is null or empty");
        }

        #endregion
    }
}

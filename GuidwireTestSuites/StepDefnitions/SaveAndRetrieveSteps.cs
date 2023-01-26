using HelperClasses;
using QuoteAndApplyPages.Pages;
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
using QuoteAndApplyPages.Pages.SaveRetrieve;

namespace SaveAndRetrieve
{
    [Binding]
    public class SaveAndRetrieveSteps : WebCommonCore.TestBase
    {
        [When(@"I click on Save and Finish application")]
        public void WhenIClickOnSaveAndFinishApplication()
        {
            Common SaveRetrieve = new Common(getDriver());
            SaveRetrieve.clickSaveFinishLater();
        }
        [When(@"I Save My Application")]
        public void ISaveMyApplication()
        {
            Common SaveRetrieve = new Common(getDriver());
            SaveRetrieve.saveMyApplication();
        }
        [When(@"I Take Action on saved application")]
        public void ITakeActionOnSavedApplication(Table table)
        {
            Common SaveRetrieve = new Common(getDriver());
            SaveRetrieve.actiononSavedApplication(table.Rows[0]["Action"]);
            //  SaveRetrieve.subactiononSavedApplication(table.Rows[0]["SubAction"]);

        }

        [When(@"I click on Save and Finish application on Jwelery Details Page")]
        public void WhenIClickOnSaveAndFinishApplicationOnJweleryDetailsPage()
        {
            Common SaveRetrieve = new Common(getDriver());
            SaveRetrieve.JewelrydetailssaveMyApplication();
        }


        [When(@"I click on Save and Finish application on Applicant and Wearer page")]
        public void WhenIClickOnSaveAndFinishApplicationOnApplicantAndWearerPage()
        {
            Common SaveRetrieve = new Common(getDriver());
            SaveRetrieve.ApplicantwWearersaveMyApplication();
        }


        [When(@"I retrieve Saved Application")]
        public void IRetrieveSavedApplication()
        {
            RetrieveApplication Retrievepage = new RetrieveApplication(getDriver());
            Retrievepage.retrieveApplication();
        }

        [When(@"I verify Contact Information (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) in the Applicant page")]
        public void IVerifyContactInformationInTheApplicantPage(string FirstName, string LastName, string Address, string Apartment, string City, string State, string AddressZipCode, string PhoneNumber, string EmailAddress, string ContactPreference, string sDOB, string Gender)
        {
            RetrieveApplicantWearerPage RetrieveApplicantpage = new RetrieveApplicantWearerPage(getDriver());
            DataStorage temp = new DataStorage();
            switch (FirstName.ToUpper().Trim())
            {
                case "REGISTRY":
                    FirstName = temp.GetTempValue("FNAME");
                    break;
                default:

                    break;
            }

            switch (LastName.ToUpper().Trim())
            {
                case "REGISTRY":
                    LastName = temp.GetTempValue("LNAME");
                    break;
                default:

                    break;
            }
            EmailAddress = temp.GetTempValue("EMAIL");
            RetrieveApplicantpage.verifyRetrievdContactInformation(FirstName, LastName, Address, Apartment, City, State, AddressZipCode, PhoneNumber, EmailAddress, ContactPreference, sDOB, Gender);

        }

        [When(@"I verify the Applicant or Wearers details with respect to wearing items")]
        public void IVerifyTheApplicantOrWearersDetailsWithRespectToWearingItems(Table table)
        {
            RetrieveApplicantWearerPage RetrieveApplicantpage = new RetrieveApplicantWearerPage(getDriver());
            RetrieveApplicantpage.verifyWhowillwearthejeweleryItems(table);
        }

        [When(@"I Verify qualification questions (.*) , (.*) in Applicant and Wearer page")]
        public void IVerifyQualificationQuestionsInApplicantAndWearerPage(string MinorTrafficViolation, string LossTheftDamageToJewelry)
        {
            RetrieveApplicantWearerPage RetrieveApplicantpage = new RetrieveApplicantWearerPage(getDriver());
            RetrieveApplicantpage.verifyQualificationQuestions(MinorTrafficViolation, LossTheftDamageToJewelry);
        }

        [When(@"I Verify Sentence completion details")]
        public void IVerifySentenceCompletionDetails(Table table)
        {
            RetrieveApplicantWearerPage RetrieveApplicantpage = new RetrieveApplicantWearerPage(getDriver());
            RetrieveApplicantpage.verifySentenceCompltionDetailes(table.Rows[0]["Date"], table.Rows[0]["Type"]);
        }

        [When(@"I Verify loss details")]
        public void IVerifyLossDetails(Table table)
        {
            RetrieveApplicantWearerPage RetrieveApplicantpage = new RetrieveApplicantWearerPage(getDriver());
            var dictionoary = new Dictionary<string, string>();
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                RetrieveApplicantpage.verifyLossDetailes(temp[0], temp[1], temp[2], Itemcounter);

                Itemcounter = Itemcounter + 1;
            }

        }


        [When(@"I Verify the jewelry information Jewelry Details page")]
        public void IVerifyTheJewelryInformationJewelryDetailsPage(Table table)
        {
            RetrieveJewelryDetails RetrieveJewelryDetails = new RetrieveJewelryDetails(getDriver());
            var dictionoary = new Dictionary<string, string>();
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                int main_Counter = table.Rows.Count();
                var temp = row.Values.ToList();
                string JewelryType = temp[0];
                string JewelryValue = temp[1];
                string JewelryGender = temp[3];
                string JewelrySubType = temp[2];
                string DateOFPurchase = temp[4];
                RetrieveJewelryDetails.VerifyMainJewelry(JewelryType, JewelryValue, Itemcounter, main_Counter);
                if (JewelryGender.Length > 1 || JewelrySubType.Length > 1)
                {
                    RetrieveJewelryDetails.verifyJewelryDetails_Details_Group(JewelrySubType, JewelryGender, Itemcounter);
                }
                if (DateOFPurchase.ToLower().Trim() != "")
                {
                    RetrieveJewelryDetails.verifyApprisalDate(DateOFPurchase, Itemcounter);
                }
                Itemcounter = Itemcounter + 1;
            }

        }

        [When(@"I Verify (.*) in Jewelry Details page")]
        public void IVerifyCurrentdateInJewelryDetailsPage(string EffectiveDate)
        {
            RetrieveJewelryDetails RetrieveJewelryDetails = new RetrieveJewelryDetails(getDriver());
            DataStorage temp = new DataStorage();
            string EffDt = null;
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
            RetrieveJewelryDetails.verifyEffectiveDate(EffDt);
        }

        [When(@"I Verify (.*) in Securityoption of  Jewelry Details page")]
        public void IVerifyInSecurityoptionOfJewelryDetailsPage(string AlarmSecuritySystems)
        {
            RetrieveJewelryDetails RetrieveJewelryDetails = new RetrieveJewelryDetails(getDriver());
            RetrieveJewelryDetails.VerifyAlarm(AlarmSecuritySystems);
            JewelryDetails JewelryDetails = new JewelryDetails(getDriver());

            JewelryDetails.ClickNext();
        }


        [When(@"I Verify the  Personal  History Details in UW question details")]
        public void WhenIVerifyThePersonalHistoryDetailsInUWQuestionDetails(Table table)
        {
            RetrieveAdditionalQuestions RetrieveAdditionalQuestionDetails = new RetrieveAdditionalQuestions(getDriver());
            RetrieveAdditionalQuestionDetails.verifyPersonalHistory(table.Rows[0]["DeniedCov"], table.Rows[0]["DeniedCovreason"]);
        }


        [When(@"I Verify  the Jewelry Storage Details in UW question details")]
        public void WhenIVerifyTheJewelryStorageDetailsInUWQuestionDetails(Table table)
        {
            RetrieveAdditionalQuestions RetrieveAdditionalQuestionDetails = new RetrieveAdditionalQuestions(getDriver());
            RetrieveAdditionalQuestionDetails.verifyJewelryStorage(table.Rows[0]["SafeDepositBox"], table.Rows[0]["CommunityGated"], table.Rows[0]["CommunityGated"], table.Rows[0]["HomeHasOtherResidents"], table.Rows[0]["JewelryWornFre"], table.Rows[0]["ReleationshiptoResident"]);

        }

        [When(@"I verify the Travel Details in UW question details")]
        public void WhenIVerifyTheTravelDetailsInUWQuestionDetails(Table table)
        {
            RetrieveAdditionalQuestions RetrieveAdditionalQuestionDetails = new RetrieveAdditionalQuestions(getDriver());
            RetrieveAdditionalQuestionDetails.verifyTavelDetails(table.Rows[0]["TravelOverNightFreq"], table.Rows[0]["TravelAbroad"], table.Rows[0]["TravelSafeGuard"], table.Rows[0]["TravelDescription"]);


        }





        [When(@"I Enter the jewelry information in Retrieve Jewelry Details page")]
        public void WhenIEnterTheJewelryInformationInRetrieveJewelryDetailsPage(Table table)
        {
            RetrieveJewelryDetails RetrieveJewelryDetails = new RetrieveJewelryDetails(getDriver());
            var dictionoary = new Dictionary<string, string>();
            //Items items = table.CreateInstance<Items>();
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryGender = temp[1];
                string JewelrySubType = temp[0];
                string DateOFPurchase = temp[2];
                string browsertype = temp[3];
                if (JewelryGender.Length > 1 || JewelrySubType.Length > 1)
                {
                    RetrieveJewelryDetails.RetrieveSetJewelryDetails_Details_Group(JewelrySubType, JewelryGender, Itemcounter);
                }
                //if (temp[3].ToLower().Trim() == "yes")
                //{
                //    RetrieveJewelryDetails.RetrieveSetSelectAppraisal(Itemcounter);
                //}

                //if (DateOFPurchase.ToLower().Trim() != "")
                //{
                //    RetrieveJewelryDetails.RetrieveSetClickApprisalDate(DateOFPurchase, Itemcounter);
                //}
                //Itemcounter = Itemcounter + 1;
            }
        }

    }
}

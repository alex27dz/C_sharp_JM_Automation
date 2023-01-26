using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace Quote.Pages
{
    public class ApplicantWearerPage:Page
    {
        string txtAppfirstName = "//*[@id='ApplicantFirstName']";
        string txtApplastName = "//*[@id='ApplicantLastName']";
        string txtAppaddress = "//*[@id='ApplicantAddress']";
        string txtAppaptsuite = "//*[@id='ApplicantApartmentSuite']";
        string txtAppcity = "//*[@id='ApplicantCity']";
        string selectAppstate = "//*[@id='ApplicantState']";
        string txtAppzipcode = "//*[@id='ApplicantZipCode']";
        string checkMailingaddressissame = "//*[@id='MailingAddressIsSame']";
        string txtAppPhonenumber = "//*[@id='ApplicantPhoneNumber']";
        string txtAppEmailaddress = "//*[@id='ApplicantEmailAddress']";
        string radioContactpreferencephone = "//*[@id='contactPreference-Phone']";
        string radioContactpreferenceemail = "//*[@id='contactPreference-Email']";
        string selectAppdobmonth = "//*[@id='applicantDOBMonth']";
        string selectAppdobday = "//*[@id='applicantDOBDay']";
        string selectAppdobyear = "//*[@id='applicantDOBYear']";
        string radioAppGendermale = "//*[@id='ApplicantGender-Male']";
        string radioAppGenderfemale = "//*[@id='ApplicantGender-Female']";
        string radiowearernameitem1_0 = "//*[@id='WearerName-Item#1-0']";
        string radiowearernameitem1_1 = "//*[@id='WearerName-Item#1-1']";
        string radioConvictedofcrime = "//*[@id='ConvictedOfCrime-No']";
        string radioPriorlossexperienced = "//*[@id='PriorLossExperienced-No']";
        string checkHasagreedtoterms = "//*[@id='HasAgreedToTerms']";
        string btnAppWearerPageNext = "//*[@id='applicantNext']";

        public ApplicantWearerPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();
            VerifyUIElementIsDisplayed(btnAppWearerPageNext);
        }

        public void EnterYourContactInformation(string ApplicantFirstName, string ApplicantLastName, string ApplicantAddress, string ApplicantApartment, string ApplicantCity, string ApplicantState, string ApplicantZipCode, string IsMailingAddressSame, string ApplicantPhone, string ApplicantEmail, string ApplicantContactPref, string DOB_Month, string DOB_Day, string DOB_Year, string ApplicantGender)
        {
            UIAction(txtAppfirstName, ApplicantFirstName, "textbox");
            UIAction(txtApplastName, ApplicantLastName, "textbox");
            UIAction(txtAppaddress, ApplicantAddress, "textbox");
            UIAction(txtAppaptsuite, ApplicantApartment, "textbox");
            UIAction(txtAppcity, ApplicantCity, "textbox");
            UIAction(selectAppstate, ApplicantState, "selectbox");
            UIAction(txtAppzipcode, ApplicantZipCode, "textbox");
            UIAction(checkMailingaddressissame, string.Empty, "checkbox");
            UIAction(txtAppPhonenumber, ApplicantPhone, "textbox");
            UIAction(txtAppEmailaddress, ApplicantEmail, "textbox");
            switch (ApplicantContactPref.ToLower().Trim())
            {
                case "phone":
                    UIAction(radioContactpreferencephone, string.Empty, "span");
                    pause();
                    break;
                case "email":
                    UIAction(radioContactpreferenceemail, string.Empty, "span");
                    pause();
                    break;
                default:
                    break;

            }
            UIAction(selectAppdobmonth, DOB_Month, "selectbox");
            UIAction(selectAppdobday, DOB_Day, "selectbox");
            UIAction(selectAppdobyear, DOB_Year, "selectbox");
            switch (ApplicantGender.ToLower().Trim())
            {
                case "male":
                    UIAction(radioAppGendermale, string.Empty, "span");
                    pause();
                    break;
                case "female":
                    UIAction(radioAppGenderfemale, string.Empty, "span");
                    pause();
                    break;
                default:
                    break;
            }
        }
        public void WhowillwearthejeweleryItems(string ApplicantWearer)
        {
            switch (ApplicantWearer.ToLower().Trim())
            {
                case "applicant":
                    UIAction(radiowearernameitem1_1, string.Empty, "span");
                    pause();
                    break;
                case "wearer":
                    UIAction(radiowearernameitem1_0, string.Empty, "span");
                    pause();
                    break;
                default:
                    break;
            }
        }
         
        string radioPriorlossexperiencedNo = "//*[@id='PriorLossExperienced-No']";
        string radioPriorlossexperiencedYes = "//*[@id='PriorLossExperienced-Yes']";
        string checkHasagreedtoterms = "//*[@id='HasAgreedToTerms']";
        string btnAppWearerPageNext = "//*[@id='applicantNext']";
        public void InTheLastTenYears(string ConvictedOfCrime, string PriorLossExperienced)
        {
            switch (ConvictedOfCrime.ToLower().Trim())
            {
                case "no":
                    UIAction(radiowearernameitem1_1, string.Empty, "span");
                    pause();
                    break;
                case "misdemeanor":
                    UIAction(radioConvictedofcrimeMisdemeanor, string.Empty, "span");
                    pause();
                    break;
                case "felony":
                    UIAction(radioConvictedofcrimeFelony, string.Empty, "span");
                    pause();
                    break;
                case "both":
                    UIAction(radioConvictedofcrimeBoth, string.Empty, "span");
                    pause();
                    break;
                default:
                    break;
            }

            switch (PriorLossExperienced.ToLower().Trim())
            {
                case "no":
                    UIAction(radioPriorlossexperiencedNo, string.Empty, "span");
                    pause();
                    break;
                case "yes":
                    UIAction(radioPriorlossexperiencedYes, string.Empty, "span");
                    pause();
                    break;
                default:
                    break;

            }
        }
        public void ImpInfocheckox()
        {
            UIAction(checkHasagreedtoterms, string.Empty, "checkbox");
        }
        public void ClickOnApplicantPageNextButton()
        {
            UIAction(btnAppWearerPageNext, string.Empty, "span");
        }
    }
}

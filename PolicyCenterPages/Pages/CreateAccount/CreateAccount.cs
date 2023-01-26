using AutomationFramework;
using HelperClasses;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace PolicyCenterPages.Pages.CreateAccount
{
    public class CreateAccount : Page
    {
        string DateOfBirth = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:DateOfBirth";

        string HomePhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:HomePhone";

        string WorkPhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:Phone";

        string MobilePhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:CellPhone";

        string OtherPhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:OtherPhone";

        string FaxPhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:FaxPhone";

        string ZipCode = "CreateAccount:CreateAccountScreen:CreateAccountDV:AddressInputSet:PostalCode";

        string OfficialID = "CreateAccount:CreateAccountScreen:CreateAccountDV:OfficialIDInputSet:OfficialIDDV_Input";

        string MaritalStatus = "select[id$=':MaritalStatus']";

        string OfficePhone = "select[id$=':Phone']";

        string PrimaryPhone = "select[id$=':PrimaryPhone']";

        string PrimaryEmail = "input[id$=':EmailAddress1']";

        string SecondaryEmail = "input[id$=':EmailAddress2']";

        string FemaleGender = "input[id$=':Gender_F']";

        string MaleGender = "input[id$=':Gender_M']";

        string Occupation = "input[id$=':Occupation']";

        string InvestigationsYes = "input[id$=':Investigation_true']";

        string InvestigationsNo = "input[id$=':Investigation_false']";

        string CareOf = "input[id$=':CareOf']";

        string AddressLine1 = "input[id$=':AddressLine1']";

        string AddressLine2 = "input[id$=':AddressLine2']";

        string City = "input[id$=':City']";

        string State = "select[id$=':State']";

        string County = "input[id$=':County']";

        string Country = "select[id$=':Country']";

        string OrgType = "select[id$=':OrgType']";

        string ValidateAddress = "a[id$=':validateAddress_JMIC']";

        string VerifyAddress = "a[id$=':verifyAddress_JMIC']";

        string AddressType = "select[id$=':AddressType']";

        string AddressDescription = "input[id$=':AddressDescription']";

        string selectVerifiedAddress = "span[id$=':selectAddress_link']";

        string acceptAddressChkBox = "input[id$=':acceptKeyInAddress']";

        string acceptAddress = "a[id$='VerifyAddress_JMIC_Popup:Update']";

        string fipsCode = "span[id$=':CountyFIPSCode']";

        string IsJewelerYesPL = "input[id$=':InsuredInfo_PLInputSet:IsJeweler_true']";

        string IsJewelerNoPL = "input[id$=':InsuredInfo_PLInputSet:IsJeweler_false']";

        string IsJewelerYes = "input[id$=':IsAccountHolderJeweler_true']";

        string IsJewelerNo = "input[id$=':IsAccountHolderJeweler_false']";

        string DistributionSource = "select[id$=':InsuredInfo_PLInputSet:HeardAbout']";

        string PreferredMethodOfCommunication = "select[id$=':InsuredInfo_PLInputSet:PreferredMethodComm']";

        string PaperlessDeliveryYes = "input[id$=':InsuredInfo_PLInputSet:IsPaperlessDelivered_true']";

        string PaperlessDeliveryNo = "input[id$=':InsuredInfo_PLInputSet:IsPaperlessDelivered_false']";

        string OKToSurveryYes = "input[id$=':Question_PLInputSet:DoNotContact_true']";

        string OKToSurveryNo = "input[id$=':Question_PLInputSet:DoNotContact_false']";

        string MarkettingMaterialsYes = "input[id$=':Question_PLInputSet:NoMarketing_true']";

        string MarkettingMaterialsNo = "input[id$=':Question_PLInputSet:NoMarketing_false']";

        string RecieveConfirmationEmailsYes = "input[id$=':NoEmails_true']";

        string RecieveConfirmationEmailsNo = "input[id$=':Question_PLInputSet:NoEmails_false']";

        string ReferringJewelerID = "input[id$=':Question_PLInputSet:ReferringJeweler']";

        string UpdateAccount = "a[id$='CreateAccount:CreateAccountScreen:Update']";

        string accountNumber = "span[id$=':AccountFile_Summary_BasicInfoDV:AccountNumber']";

        string checkForDuplicates = "a[id$=':CheckForDuplicates']";

        string selectOrganization = "a[id$=':SelectOrganization']";

        string producerCode = "input[id$=':ProducerCode']";

        string searchBtn = "span[id$=':Search_link']";

        string selectFirstSearchResult = "span[id$=':0:_Select_link']";

        string imgSearchProducer = "a[id$=':ProducerSelectionInputSet:Producer:SelectOrganization']";

        string txtProducerCode = "input[id$=':OrganizationSearchDV:ProducerCode']";

        string btnSearchProducer = "span[id$=':SearchAndResetInputSet:SearchLinksInputSet:Search_link']";

        string btnSelectProducer = "span[id$=':OrganizationSearchResultsLV:0:_Select_link']";

        public CreateAccount(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(PrimaryEmail);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(PrimaryEmail));
        }

        public void EnterAccountDetails(string DOB, string maritalStatus, string primaryPhone, string homePhone, string workPhone, string mobilePhone, string otherPhone, string faxPhone, string primaryEmail, string secondaryEmail, string gender, string occupation, string investigations)
        {
            pause();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + DateOfBirth + "').value='" + DOB + "'");

            UIAction(MaritalStatus, maritalStatus, "selectbox");

            UIAction(PrimaryPhone, primaryPhone, "selectbox");

            pause();

            js.ExecuteScript("document.getElementById('" + HomePhone + "').value='" + homePhone + "'");

            js.ExecuteScript("document.getElementById('" + WorkPhone + "').value='" + workPhone + "'");

            js.ExecuteScript("document.getElementById('" + MobilePhone + "').value='" + mobilePhone + "'");

            js.ExecuteScript("document.getElementById('" + OtherPhone + "').value='" + otherPhone + "'");

            js.ExecuteScript("document.getElementById('" + FaxPhone + "').value='" + faxPhone + "'");

            UIAction(PrimaryEmail, primaryEmail, "textbox");

            UIAction(SecondaryEmail, secondaryEmail, "textbox");

            switch (gender.ToLower().Trim())
            {
                case "female":
                    UIAction(FemaleGender, string.Empty , "button");
                    break;

                case "male":
                    UIAction(MaleGender, string.Empty , "button");
                    break;

                default:
                    break;
            }
         

           // UIAction(Occupation, occupation, "selectbox");

            switch (investigations.ToLower().Trim())
            {
                case "yes":
                    UIAction(InvestigationsYes, string.Empty , "button");
                    break;
                case "no":
                    UIAction(InvestigationsNo, string.Empty , "button");
                    break;
                default:
                    break;
            }


        }

        public void EnterAccountDetailsCL(string officePhone, string faxPhone, string primaryEmail, string secondaryEmail)
        {
            pause();

         //   SetActiveFrame();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("document.getElementById('" + WorkPhone + "').value='" + officePhone + "'");

            js.ExecuteScript("document.getElementById('" + FaxPhone + "').value='" + faxPhone + "'");

            UIAction(PrimaryEmail, primaryEmail, "textbox");

            UIAction(SecondaryEmail, secondaryEmail, "textbox");



        }



        public void EnterAddressDetailsCL(string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country, string addressType, string orgType)
        {
            ScenarioContext.Current["country"] = country;
            string sUSA = "united states of america";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (string.Equals(country.ToLower(), sUSA) == false)
            {
                UIAction(Country, country, "selectbox");
                pause();
                pause();
            }

            IWebElement IAddressline = driver.FindElement(By.CssSelector(AddressLine1));
            WaitForEnabled(IAddressline);
            UIAction(AddressLine1, addressLine1, "textbox");
            UIAction(AddressLine2, addressLine2, "textbox");
            UIAction(City, city, "textbox");
            UIAction(State, state, "selectbox");
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + zipCode + "'");
            UIAction(Country, country, "selectbox");
            UIAction(AddressType, addressType, "selectbox");
            pause();
            pause();
            if (string.Equals(country.ToLower(), sUSA))
            {
                UIAction(VerifyAddress, string.Empty, "a");
            }
            else
            {
                IWebElement ClickVerifyAddrButton = driver.FindElement(By.Id("CreateAccount:CreateAccountScreen:CreateAccountDV:AddressInputSet:validateAddress_JMIC"));
                ClickVerifyAddrButton.Click();
            }

            pause();
            pause();
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();
            if (PageInputs.Count > 0)
            {
                UIAction(selectVerifiedAddress, string.Empty, "a");
                UIAction(acceptAddressChkBox, string.Empty, "a");
                UIAction(acceptAddress, string.Empty, "button");
                pause();
                //if (string.Equals(country.ToLower(), sUSA) == true)
                //{
                PageInputs = driver.FindElements(By.CssSelector(fipsCode)).ToList();
                if (PageInputs.Count > 0)
                {
                    string currFipsCode = PageInputs[0].Text;
                    Console.WriteLine("Current FIPS Code:{0}", currFipsCode);
                }
                //}
                pause();
            }

            UIAction(OrgType, orgType, "selectbox");
            pause();
        }

        public void EnterAddressDetailsCA(string careOf, string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country, string addressType, string description)
        {

            ScenarioContext.Current["country"] = country;
            string sUSA = "united states of america";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (string.Equals(country.ToLower(), sUSA) == false)
            {
                UIAction(Country, country, "selectbox");
                pause();
                pause();
            }

            UIAction(CareOf, careOf, "textbox");

            //UIAction(Country, country, "selectbox");

            UIAction(AddressLine1, addressLine1, "textbox");

            UIAction(AddressLine2, addressLine2, "textbox");

            UIAction(City, city, "textbox");

            UIAction(State, state, "selectbox");

            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + zipCode + "'");

            UIAction(County, county, "textbox");



            UIAction(AddressType, addressType, "selectbox");

            UIAction(AddressDescription, description, "textbox");

            System.Threading.Thread.Sleep(1500);

            UIAction(ValidateAddress, string.Empty, "a");

            //UIAction(VerifyAddress, string.Empty, "a");

            pause();
            pause();
            pause();
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();


            if (PageInputs.Count > 0)
            {
                UIAction(selectVerifiedAddress, "", "a");

                UIAction(acceptAddressChkBox, string.Empty, "a");

                UIAction(acceptAddress, string.Empty, "button");
            }
        }

        public void EnterAddressDetails(string careOf, string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country, string addressType, string description)
        {
            UIAction(CareOf, careOf, "textbox");

            UIAction(AddressLine1, addressLine1, "textbox");

            UIAction(AddressLine2, addressLine2, "textbox");

            UIAction(City, city, "textbox");

            UIAction(State, state, "selectbox");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + zipCode + "'");

            UIAction(County, county, "textbox");

            UIAction(Country, country, "selectbox");

            UIAction(AddressType, addressType, "selectbox");

            UIAction(AddressDescription, description, "textbox");

            UIAction(VerifyAddress, string.Empty , "a");

            pause();

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();

            if (PageInputs.Count > 0)
            {
                UIAction(selectVerifiedAddress, "", "a");

                UIAction(acceptAddressChkBox, string.Empty , "a");

                UIAction(acceptAddress, string.Empty , "button");
            }




            PageInputs = driver.FindElements(By.CssSelector(fipsCode)).ToList();

            string currFipsCode = PageInputs[0].Text;

            Console.WriteLine("Current FIPS Code:{0}", currFipsCode);

            //  UIAction(selectProducer, "", "a");




        }


        public void EnterOfficialIDDetails(string SSN, string isAccountAJeweler, string distributionSource, string preferredMethodOfCommunication, string paperlessDelivery, string okToSurvey, string markettingMaterials, string recieveConfirmationEmails, string jewelerID)
        {
            pause();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + OfficialID + "').value='" + SSN + "'");

            switch (isAccountAJeweler.ToLower().Trim())
            {
                case "yes":
                    UIAction(IsJewelerYesPL, string.Empty , "button");
                    break;
                case "no":
                    UIAction(IsJewelerNoPL, string.Empty , "button");
                    break;
                default:
                    break;
            }

            UIAction(DistributionSource, distributionSource, "selectbox");

            UIAction(PreferredMethodOfCommunication, preferredMethodOfCommunication, "selectbox");

            switch (paperlessDelivery.ToLower().Trim())
            {
                case "yes":
                    UIAction(PaperlessDeliveryYes, string.Empty , "button");
                    break;
                case "no":
                    UIAction(PaperlessDeliveryNo, string.Empty , "button");
                    break;
                default:
                    break;
            }

            switch (okToSurvey.ToLower().Trim())
            {
                case "yes":
                    UIAction(OKToSurveryYes, string.Empty , "button");
                    break;
                case "no":
                    UIAction(OKToSurveryNo, string.Empty , "button");
                    break;
                default:
                    break;
            }

            switch (markettingMaterials.ToLower().Trim())
            {
                case "yes":
                    UIAction(MarkettingMaterialsYes, string.Empty , "button");
                    break;
                case "no":
                    UIAction(MarkettingMaterialsNo, string.Empty , "button");
                    break;
                default:
                    break;
            }

            switch (recieveConfirmationEmails.ToLower().Trim())
            {
                case "yes":
                    UIAction(RecieveConfirmationEmailsYes, string.Empty , "button");
                    break;
                case "no":
                    UIAction(RecieveConfirmationEmailsNo, string.Empty , "button");
                    break;
                default:
                    break;
            }

            pause();

            //UIAction(checkForDuplicates, string.Empty , "button");

            pause();

            UIAction(UpdateAccount, string.Empty , "button");

            pause();

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(accountNumber)).ToList();

            string accNo = PageInputs[0].Text;

            Console.WriteLine("Account Number:{0}", accNo);

            ScenarioContext.Current["ACCOUNT"] = accNo;

          
          

        }

        public void EnterOfficialIDDetailsCL(string EIN, string isAccountAJeweler, string distributionSource, string preferredMethodOfCommunication, string okToSurvey)
        {
            pause();
            pause();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + OfficialID + "').value='" + EIN + "'");

            switch (isAccountAJeweler.ToLower().Trim())
            {
                case "yes":
                    UIAction(IsJewelerYes, string.Empty , "button");
                    break;
                case "no":
                    UIAction(IsJewelerNo, string.Empty , "button");
                    break;
                default:
                    break;
            }

            UIAction(DistributionSource, distributionSource, "selectbox");

            UIAction(PreferredMethodOfCommunication, preferredMethodOfCommunication, "selectbox");

            switch (okToSurvey.ToLower().Trim())
            {
                case "yes":
                    UIAction(OKToSurveryYes, string.Empty , "button");
                    break;
                case "no":
                    UIAction(OKToSurveryNo, string.Empty , "button");
                    break;
                default:
                    break;
            }

        }

        public void EnterProducerDetailsCL(string producer)
        {
            UIAction(selectOrganization, string.Empty , "a");
            System.Threading.Thread.Sleep(5000);
            UIAction(producerCode, producer, "TextBox");
            System.Threading.Thread.Sleep(3000);
            UIAction(searchBtn, string.Empty, "button");
            System.Threading.Thread.Sleep(4000);
            UIAction(selectFirstSearchResult, string.Empty, "span");
            System.Threading.Thread.Sleep(3000);
            //UIAction(checkForDuplicates, string.Empty , "button");

            //pause();

            UIAction(UpdateAccount, string.Empty, "button");
            System.Threading.Thread.Sleep(4000);
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(accountNumber)).ToList();

            string accNo = PageInputs[0].Text;

            Console.WriteLine("Account Number:{0}", accNo);

            ScenarioContext.Current["ACCOUNT"] = accNo;

        }

        public void UpdateProducerCode(string producer)
        {
            UIAction(imgSearchProducer, string.Empty, "a");

            pause();
            pause();

            UIAction(txtProducerCode, producer, "textbox");

            UIAction(btnSearchProducer, string.Empty, "a");

            pause();

            UIAction(btnSelectProducer, string.Empty, "a");


        }
    }
}

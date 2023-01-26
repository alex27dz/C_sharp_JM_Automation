using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.CreateAccount
{
    public class CreateAccount_PC9 : Page
    {
        string lblCreateAccountTitle = "span[id='CreateAccount:CreateAccountScreen:ttlBar']";
        string lblVerifyAddress = "span[id='VerifyAddress_JMIC_Popup:ttlBar']";
        string PrimaryEmail = "input[id$=':EmailAddress1-inputEl']";
        string SecondaryEmail = "input[id$=':EmailAddress2-inputEl']";
        string AddressLine1 = "input[id$=':AddressLine1-inputEl']";
        string AddressLine2 = "input[id$=':AddressLine2-inputEl']";
        string City = "input[id$=':City-inputEl']";
        string ZipCode = "input[id$=':PostalCode-inputEl']";
        string State = "input[id$=':State-inputEl']";
        string County = "input[id$=':County-inputEl']";
        string Country = "input[id$=':Country-inputEl']";
        string AddressDescription = "input[id$=':AddressDescription-inputEl']";
        string AddressErrorMsg = "//span[text()[contains(.,'Address is unverified. You must verify the address before updating contact information')]]";
        string AcceptThisAddress = "input[id='VerifyAddress_JMIC_Popup:acceptKeyInAddress-inputEl']";
        string VerifyAddrPageOK = "span[id='VerifyAddress_JMIC_Popup:Update-btnInnerEl']";
        string VerifyAddressAccCreate = "span[id$=':verifyAddress_JMIC-btnInnerEl']";
        string VerifyAddressPagePartial = "label[id='VerifyAddress_JMIC_Popup:4']";
        string AddressType = "input[id$=':AddressType-inputEl']";
        string OrgType = "input[id$=':OrgType-inputEl']";
        string IsJewelerYes = "input[id$=':IsAccountHolderJeweler_true-inputEl']";
        string IsJewelerNo = "input[id$=':IsAccountHolderJeweler_false-inputEl']";
        string imgSearchProducer = "div[id$=':ProducerSelectionInputSet:Producer:SelectOrganization']";
        string producerCode = "input[id$=':ProducerCode-inputEl']";
        string searchBtn = "a[id$=':SearchLinksInputSet:Search']";
        string selectFirstSearchResult = "a[id$=':0:_Select']";
        string checkForDuplicates = "span[id$=':CheckForDuplicates-btnInnerEl']";
        string UpdateAccount = "span[id='CreateAccount:CreateAccountScreen:Update-btnInnerEl']";
        string lblErrorMessage = "div[id='CreateAccount:CreateAccountScreen:_msgs']";
        string lblAcctFileSummary = "span[id='AccountFile_Summary:AccountFile_SummaryScreen:ttlBar']";
        string accountNumber = "div[id$=':AccountFile_Summary_BasicInfoDV:AccountNumber-inputEl']";
        string accountSummary = "span[id='AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_RefreshButton-btnInnerEl']";
        string FemaleGender = "input[id$=':Gender_option1-inputEl']";
        string MaleGender = "input[id$=':Gender_option2-inputEl']";
        string InvestigationsYes = "input[id$=':Investigation_true-inputEl']";
        string InvestigationsNo = "input[id$=':Investigation_false-inputEl']";
        string CareOf = "input[id$=':CareOf-inputEl']";
        string IsJewelerYesPL = "input[id$=':InsuredInfo_PLInputSet:IsJeweler_true-inputEl']";
        string IsJewelerNoPL = "input[id$=':InsuredInfo_PLInputSet:IsJeweler_false-inputEl']";
        string DistributionSource = "input[id$=':InsuredInfo_PLInputSet:HeardAbout-inputEl']";
        string PreferredMethodOfCommunication = "input[id$=':InsuredInfo_PLInputSet:PreferredMethodComm-inputEl']";

        string PaperlessDeliveryYes = "input[id$=':InsuredInfo_PLInputSet:IsPaperlessDelivered_true-inputEl']";
        string PaperlessDeliveryNo = "input[id$=':InsuredInfo_PLInputSet:IsPaperlessDelivered_false-inputEl']";
        string OKToSurveryYes = "input[id$=':Question_PLInputSet:DoNotContact_true-inputEl']";
        string OKToSurveryNo = "input[id$=':Question_PLInputSet:DoNotContact_false-inputEl']";
        string MarkettingMaterialsYes = "input[id$=':Question_PLInputSet:NoMarketing_true-inputEl']";
        string MarkettingMaterialsNo = "input[id$=':Question_PLInputSet:NoMarketing_false-inputEl']";
        string RecieveConfirmationEmailsYes = "input[id$=':NoEmails_true-inputEl']";
        string RecieveConfirmationEmailsNo = "input[id$=':Question_PLInputSet:NoEmails_false-inputEl']";




        string DateOfBirth = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:DateOfBirth-inputEl";
        string HomePhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:HomePhone:GlobalPhoneInputSet:NationalSubscriberNumber-inputEl";
        string WorkPhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:Phone:GlobalPhoneInputSet:NationalSubscriberNumber-inputEl";
        string MobilePhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:CellPhone:GlobalPhoneInputSet:NationalSubscriberNumber-inputEl";
        string OtherPhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:OtherPhoneJMI:GlobalPhoneInputSet:NationalSubscriberNumber-inputEl";
        string FaxPhone = "CreateAccount:CreateAccountScreen:CreateAccountDV:CreateAccountContactInputSet:FaxPhone:GlobalPhoneInputSet:NationalSubscriberNumber-inputEl";
        //  string ZipCode = "CreateAccount:CreateAccountScreen:CreateAccountDV:AddressInputSet:PostalCode";
        string OfficialID = "CreateAccount:CreateAccountScreen:CreateAccountDV:OfficialIDInputSet:OfficialIDDV_Input-inputEl";

        string MaritalStatus = "input[id$=':MaritalStatus-inputEl']";
        string PrimaryPhone = "input[id$=':PrimaryPhone-inputEl']";


        public CreateAccount_PC9(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblCreateAccountTitle);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblCreateAccountTitle));
        }

        public void EnterPLmandateAccountDetails(Table table)
        {
            string sUSA = "united states of america";
            WaitFor(driver.FindElement(By.CssSelector(PrimaryEmail))).SendKeys(table.Rows[0]["PrimaryEmail"]);
            ScenarioContext.Current["country"] = table.Rows[0]["Country"];
            if (string.Equals(table.Rows[0]["Country"].ToLower(), sUSA) == false)
            {
                UIAction(Country, table.Rows[0]["Country"], "selectbox");
            }
            WaitForEnabled(driver.FindElement(By.CssSelector(AddressLine1)));

            UIAction(AddressLine1, table.Rows[0]["AddressLine1"], "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            UIAction(State, table.Rows[0]["State"], "textbox");
            UIAction(ZipCode, "", "textbox");
            WaitFor(driver.FindElement(By.CssSelector(ZipCode))).Click();
            WaitForPageLoad(driver);
            UIAction(ZipCode, table.Rows[0]["ZipCode"], "textbox");
            WaitFor(driver.FindElement(By.CssSelector(ZipCode))).SendKeys(Keys.Tab);
            try
            {
                IsElementPresent(driver, By.XPath(AddressErrorMsg));
                if (IsElementPresent(driver, By.CssSelector(VerifyAddressAccCreate)))
                {
                    if (IsElementPresent(driver, By.CssSelector(AcceptThisAddress)))
                    {
                        driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();
                        UIAction(VerifyAddrPageOK, string.Empty, "span");
                    }
                    else
                    {
                        UIAction(VerifyAddressAccCreate, string.Empty, "span");
                    }
                }
                if (IsElementPresent(driver, By.CssSelector(AcceptThisAddress)))
                {
                    driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();
                    UIAction(VerifyAddrPageOK, string.Empty, "span");
                }
            }
            catch
            {

            }
            WaitForPageLoad(driver);
            WaitUntilElementInvisible(driver, By.XPath(AddressErrorMsg));
            WaitFor(driver.FindElement(By.CssSelector(AddressType))).Clear();
            UIAction(AddressType, table.Rows[0]["AddressType"], "textbox");

            WaitFor(driver.FindElement(By.CssSelector(imgSearchProducer))).Click();
            WaitFor(driver.FindElement(By.CssSelector(producerCode))).SendKeys(table.Rows[0]["ProducerCode"]);
            UIAction(searchBtn, String.Empty, "a");
            WaitFor(driver.FindElement(By.CssSelector(selectFirstSearchResult)));
            UIAction(selectFirstSearchResult, String.Empty, "a");
            WaitFor(driver.FindElement(By.CssSelector(AddressLine1)));

            if (IsElementPresent(driver, By.CssSelector(checkForDuplicates)))
            {
                UIAction(checkForDuplicates, String.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(lblErrorMessage));
                Console.WriteLine("validation Msg:" + driver.FindElement(By.CssSelector(lblErrorMessage)).Text);
                if (driver.FindElement(By.CssSelector(lblErrorMessage)).Text != "No potential duplicate contacts found.")
                {
                    Assert.Fail("Validation Message, -No potential duplicate contacts found.- not found");
                }
            }
            WaitFor(driver.FindElement(By.CssSelector(UpdateAccount)));
            if (IsElementPresent(driver, By.CssSelector(UpdateAccount)))
            {
                UIAction(UpdateAccount, String.Empty, "span");
            }
            WaitUntilElementVisible(driver, By.CssSelector(lblAcctFileSummary));
            string accNo = driver.FindElement(By.CssSelector(accountNumber)).Text;
            Console.WriteLine("Account Number:{0}", accNo);
            ScenarioContext.Current["ACCOUNT"] = accNo;

        }

        public void EnterPLmandateAccountDetails_ST(Table table)
        {
            string sUSA = "united states of america";
            string accNo;

            ScenarioContext.Current["Email"] = table.Rows[0]["PrimaryEmail"];
            UIAction(PrimaryEmail, table.Rows[0]["PrimaryEmail"], "textbox");
            ScenarioContext.Current["country"] = table.Rows[0]["Country"];

            if (string.Equals(table.Rows[0]["Country"].ToLower(), sUSA) == false)
            {
                UIActionExt(By.CssSelector(Country), "List", table.Rows[0]["Country"]);

            }
            UIActionExt(By.CssSelector(AddressLine1), "Text", table.Rows[0]["AddressLine1"]);
            try
            {
                UIActionExt(By.CssSelector(AddressLine2), "Text", table.Rows[0]["AddressLine2"]);
            }
            catch (Exception e)
            {

            }
            UIActionExt(By.CssSelector(City), "List", table.Rows[0]["City"]);
            System.Threading.Thread.Sleep(2000);
            if (string.Equals(table.Rows[0]["Country"].ToLower(), sUSA) == false)
            {
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(State), 15);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Known Exception: " + e);
                }
                UIActionExt(By.CssSelector(State), "Text", " ");
                WaitUntilElementVisible(driver, By.CssSelector(State + "[value='<none>']"));
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(accountSummary), 5);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Known Exception" + e);
                }
                UIActionExt(By.CssSelector(State), "List", table.Rows[0]["State"]);
                UIActionExt(By.CssSelector(ZipCode), "ispresent");
                UIActionExt(By.CssSelector(ZipCode), "click");
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(accountSummary), 5);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Known Exception" + e);
                }
            }
            else
            {
                UIActionExt(By.CssSelector(State), "ispresent");
                UIActionExt(By.CssSelector(State), "List", table.Rows[0]["State"]);
            }
            UIActionExt(By.CssSelector(ZipCode), "List", table.Rows[0]["ZipCode"]);
            if (IsElementPresent(driver, By.XPath("//div[text()[contains(.,'Verified')]]")) == false)
            {
                UIActionExt(By.CssSelector("span[id$=':verifyAddress_JMIC-btnInnerEl']"), "click", "", 0, 12, 5);
                try
                {
                    WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'Verified')]]"), 30);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Caught: " + e);
                }
            }
            UIActionExt(By.XPath("//div[text()[contains(.,'Verified')]]"), "ispresent");
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(accountSummary), 10);
            }
            catch (Exception e)
            {
                Console.WriteLine("Known Exception" + e);
            }

            driver.FindElement(By.CssSelector(AddressType)).Clear();
            UIAction(AddressType, table.Rows[0]["AddressType"], "textbox");
            driver.FindElement(By.CssSelector(AddressType)).SendKeys(Keys.Tab);
            UIActionExt(By.CssSelector(imgSearchProducer), "ispresent");
            UIActionExt(By.CssSelector(imgSearchProducer), "click");
            System.Threading.Thread.Sleep(2000);
            try
            {
                IWebElement Searchclaim = driver.FindElement(By.CssSelector(producerCode));
                Searchclaim.Click();
                Searchclaim.SendKeys(table.Rows[0]["ProducerCode"]);
            }
            catch
            {
                UIActionExt(By.CssSelector(producerCode), "Text", table.Rows[0]["ProducerCode"]);
            }
            UIActionExt(By.CssSelector(searchBtn), "click");
            UIActionExt(By.CssSelector(selectFirstSearchResult), "ispresent");
            UIActionExt(By.CssSelector(selectFirstSearchResult), "click");
            UIActionExt(By.CssSelector(UpdateAccount), "ispresent");
            UIActionExt(By.CssSelector(UpdateAccount), "click");
            UIActionExt(By.CssSelector(accountSummary), "ispresent");
            accNo = driver.FindElement(By.CssSelector(accountNumber)).Text;
            Console.WriteLine("Account Number:{0}", accNo);
            ScenarioContext.Current["ACCOUNT"] = accNo;
        }

        public void EnterCLmandateAccountDetails_ST(Table table)
        {
            string sUSA = "united states of america";
            string accNo;
            UIAction(PrimaryEmail, table.Rows[0]["PrimaryEmail"], "textbox");
            ScenarioContext.Current["country"] = table.Rows[0]["Country"];
            if (string.Equals(table.Rows[0]["Country"].ToLower(), sUSA) == false)
            {
                driver.FindElement(By.CssSelector(Country)).Click();
                driver.FindElement(By.CssSelector(Country)).Clear();
                UIAction(Country, table.Rows[0]["Country"], "textbox");
                driver.FindElement(By.CssSelector(Country)).SendKeys(Keys.Tab);
                WaitUntilElementInvisible(driver, By.CssSelector(County));
            }
            UIAction(AddressLine1, table.Rows[0]["AddressLine1"], "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            driver.FindElement(By.CssSelector(City)).SendKeys(Keys.Tab);
            if (string.Equals(table.Rows[0]["Country"].ToLower(), sUSA) == false)
            {
                switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
                {
                    case "stage":
                        try
                        {
                            WaitUntilElementVisible(driver, By.CssSelector(State + "[value='" + table.Rows[0]["State"] + "']"), 6);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception Caught" + e);
                        }
                        break;
                    default:
                        break;
                }
            }
            if (IsElementPresent(driver, By.CssSelector(State)) == false)
            {
                driver.FindElement(By.CssSelector("div[id$=':State-trigger-picker']")).Click();
                WaitUntilElementVisible(driver, By.CssSelector(State));
            }
            driver.FindElement(By.CssSelector(State)).Click();
            driver.FindElement(By.CssSelector(State)).Clear();
            UIAction(State, table.Rows[0]["State"], "textbox");
            driver.FindElement(By.CssSelector(State)).SendKeys(Keys.Tab);
            WaitUntilElementVisible(driver, By.CssSelector(State + "[value='" + table.Rows[0]["State"] + "']"));

            if (IsElementPresent(driver, By.CssSelector(ZipCode)) == false)
            {
                WaitUntilElementVisible(driver, By.CssSelector(ZipCode));
            }
            UIAction(ZipCode, table.Rows[0]["ZipCode"], "textbox");
            driver.FindElement(By.CssSelector(ZipCode)).SendKeys(Keys.Tab);
            WaitUntilElementInvisible(driver, By.XPath(AddressErrorMsg));


            if (table.Rows[0]["IsJeweler"].ToLower() == "yes")
            {
                UIAction(IsJewelerYes, string.Empty, "span");
            }
            else if (table.Rows[0]["IsJeweler"].ToLower() == "no")
            {
                UIAction(IsJewelerYes, string.Empty, "span");
            }
            driver.FindElement(By.CssSelector(AddressType)).Clear();
            UIAction(AddressType, table.Rows[0]["AddressType"], "textbox");
            driver.FindElement(By.CssSelector(AddressType)).SendKeys(Keys.Tab);
            driver.FindElement(By.CssSelector(OrgType)).Clear();
            UIAction(OrgType, table.Rows[0]["OrgType"], "textbox");
            driver.FindElement(By.CssSelector(OrgType)).SendKeys(Keys.Tab);

            //UIAction(imgSearchProducer, string.Empty, "a");
            JavaScriptClick(driver.FindElement(By.CssSelector(imgSearchProducer)));
            WaitUntilElementVisible(driver, By.CssSelector(producerCode));
            UIAction(producerCode, table.Rows[0]["ProducerCode"], "textbox");
            UIAction(searchBtn, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(selectFirstSearchResult));
            UIAction(selectFirstSearchResult, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(UpdateAccount));
            UIAction(UpdateAccount, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(accountSummary));
            accNo = driver.FindElement(By.CssSelector(accountNumber)).Text;
            Console.WriteLine("Account Number:{0}", accNo);
            ScenarioContext.Current["ACCOUNT"] = accNo;
        }

        public void EnterPLAccountDetails(string DOB, string maritalStatus, string primaryPhone, string homePhone, string workPhone, string mobilePhone, string otherPhone, string faxPhone, string primaryEmail, string secondaryEmail, string gender, string occupation, string investigations)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + DateOfBirth + "').value='" + DOB + "'");

            UIAction(MaritalStatus, String.Empty, "a");
            UIAction(MaritalStatus, maritalStatus, "textbox");
            UIAction(MaritalStatus, string.Empty, "span");
            UIAction(PrimaryPhone, String.Empty, "a");
            UIAction(PrimaryPhone, primaryPhone, "textbox");
            UIAction(PrimaryPhone, string.Empty, "span");

            js.ExecuteScript("document.getElementById('" + HomePhone + "').value='" + homePhone + "'");
            js.ExecuteScript("document.getElementById('" + WorkPhone + "').value='" + workPhone + "'");
            js.ExecuteScript("document.getElementById('" + MobilePhone + "').value='" + mobilePhone + "'");
            js.ExecuteScript("document.getElementById('" + OtherPhone + "').value='" + otherPhone + "'");
            js.ExecuteScript("document.getElementById('" + FaxPhone + "').value='" + faxPhone + "'");

            //UIAction(SecondaryEmail, secondaryEmail, "textbox");
            System.Threading.Thread.Sleep(5000);
            UIAction(PrimaryEmail, primaryEmail, "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(SecondaryEmail, secondaryEmail, "textbox");
            System.Threading.Thread.Sleep(2000);

            switch (gender.ToLower().Trim())
            {
                case "female":
                    UIAction(FemaleGender, string.Empty, "button");
                    break;

                case "male":
                    UIAction(MaleGender, string.Empty, "button");
                    break;

                default:
                    break;
            }

            switch (investigations.ToLower().Trim())
            {
                case "yes":
                    UIAction(InvestigationsYes, string.Empty, "button");
                    break;
                case "no":
                    UIAction(InvestigationsNo, string.Empty, "button");
                    break;
                default:
                    break;
            }


        }

        public void EnterPLAddressDetails(string careOf, string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country, string addressType, string description, string producercode)
        {
            UIAction(CareOf, careOf, "textbox");
            string sUSA = "united states of america";
            ScenarioContext.Current["country"] = country;
            if (string.Equals(country.ToLower(), sUSA) == false)
            {
                UIActionExt(By.CssSelector(Country), "List", country);

            }

            UIActionExt(By.CssSelector(AddressLine1), "Text", addressLine1);
            UIActionExt(By.CssSelector(AddressLine2), "Text", addressLine2);
            UIActionExt(By.CssSelector(City), "List", city);
            if (string.Equals(country.ToLower(), sUSA) == true)
            {
                UIActionExt(By.CssSelector(County), "List", county);
            }             
            if (string.Equals(country.ToLower(), sUSA) == false)
            {
                UIActionExt(By.CssSelector(State), "Text", " ");
                WaitUntilElementVisible(driver, By.CssSelector(State + "[value='<none>']"));
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(accountSummary), 5);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Known Exception" + e);
                }
                UIActionExt(By.CssSelector(State), "List", state);
                UIActionExt(By.CssSelector(ZipCode), "ispresent");
                UIActionExt(By.CssSelector(ZipCode), "click");
                try
                {
                    WaitUntilElementVisible(driver, By.CssSelector(accountSummary), 5);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Known Exception" + e);
                }
            }
            else
            {
                UIActionExt(By.CssSelector(State), "ispresent");
                UIActionExt(By.CssSelector(State), "List", state);
            }
            UIActionExt(By.CssSelector(ZipCode), "List", zipCode);
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(lblVerifyAddress), 10);
            }
            catch (Exception e)
            {
                Console.WriteLine("Known exception: " + e);
            }
            Console.WriteLine(IsElementPresent(driver, By.CssSelector(VerifyAddressPagePartial)));
            if (IsElementPresent(driver, By.CssSelector(lblVerifyAddress)))
            {
                Console.WriteLine("Inside Verify address page");
                driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();
                UIAction(VerifyAddrPageOK, string.Empty, "span");
            }else
            {
                UIAction(VerifyAddressAccCreate, string.Empty, "span");             
            }
            UIActionExt(By.CssSelector(AddressType), "Text", addressType);
            JavaScriptClick(driver.FindElement(By.CssSelector(imgSearchProducer)));
            WaitUntilElementVisible(driver, By.CssSelector(producerCode));
            UIActionExt(By.CssSelector(producerCode), "Text", producercode);
            // UIAction(producerCode, producercode, "textbox");
            UIAction(searchBtn, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(selectFirstSearchResult));
            UIAction(selectFirstSearchResult, string.Empty, "span");


        }

        public void EnterPLOfficialIDDetails(string SSN, string isAccountAJeweler, string distributionSource, string preferredMethodOfCommunication, string paperlessDelivery, string okToSurvey, string markettingMaterials, string recieveConfirmationEmails, string jewelerID)
        {
            string accNo;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + OfficialID + "').value='" + SSN + "'");

            switch (isAccountAJeweler.ToLower().Trim())
            {
                case "yes":
                    UIAction(IsJewelerYesPL, string.Empty, "button");
                    break;
                case "no":
                    UIAction(IsJewelerNoPL, string.Empty, "button");
                    break;
                default:
                    break;
            }
            //UIAction(DistributionSource, String.Empty, "a");
            //UIAction(DistributionSource, distributionSource, "textbox");
            //UIAction(PreferredMethodOfCommunication, String.Empty, "a");
            //UIAction(PreferredMethodOfCommunication, preferredMethodOfCommunication, "textbox");

            // UIAction(DistributionSource, String.Empty, "a");
            // UIAction(DistributionSource, distributionSource, "textbox");
            UIAction(DistributionSource, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            UIAction(DistributionSource, string.Empty, "span");
            // UIAction(PreferredMethodOfCommunication, String.Empty, "a");
            // UIAction(PreferredMethodOfCommunication, preferredMethodOfCommunication, "textbox");
            UIAction(PreferredMethodOfCommunication, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            UIAction(PreferredMethodOfCommunication, string.Empty, "span");

            switch (okToSurvey.ToLower().Trim())
            {
                case "yes":
                    UIAction(OKToSurveryYes, string.Empty, "button");
                    break;
                case "no":
                    UIAction(OKToSurveryNo, string.Empty, "button");
                    break;
                default:
                    break;
            }

            switch (markettingMaterials.ToLower().Trim())
            {
                case "yes":
                    UIAction(MarkettingMaterialsYes, string.Empty, "button");
                    break;
                case "no":
                    UIAction(MarkettingMaterialsNo, string.Empty, "button");
                    break;
                default:
                    break;
            }

            switch (recieveConfirmationEmails.ToLower().Trim())
            {
                case "yes":
                    UIAction(RecieveConfirmationEmailsYes, string.Empty, "button");
                    break;
                case "no":
                    UIAction(RecieveConfirmationEmailsNo, string.Empty, "button");
                    break;
                default:
                    break;
            }
            switch (paperlessDelivery.ToLower().Trim())
            {
                case "yes":
                    UIAction(PaperlessDeliveryYes, string.Empty, "button");
                    break;
                case "no":
                    UIAction(PaperlessDeliveryNo, string.Empty, "button");
                    break;
                default:
                    break;
            }
            WaitUntilElementVisible(driver, By.CssSelector(UpdateAccount));
            UIAction(UpdateAccount, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(accountSummary));
            accNo = driver.FindElement(By.CssSelector(accountNumber)).Text;
            Console.WriteLine("Account Number:{0}", accNo);
            ScenarioContext.Current["ACCOUNT"] = accNo;
        }

    }
}

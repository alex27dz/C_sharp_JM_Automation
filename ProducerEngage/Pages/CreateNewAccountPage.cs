using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class CreateNewAccountPage : Page
    {
        private const string firstNameInputCSS = "div[label='First Name'] input[type='text']";
        private const string addressLine1InputCSS = "gw-pl-input-ctrl[label='Address Line 1'] input[type='text']";
        private const string addressLine2InputCSS = "gw-pl-input-ctrl[label='Address Line 2'] input[type='text']";
        private const string cityInputCSS = "gw-pl-input-ctrl[label='City'] input[type='text']";
        private const string zipCodeInputCSS = "gw-pl-input-ctrl[label='ZIP Code'] input[type='text']";
        private const string stateSelectCSS = "div[label='State'] select";
        private const string dateOfBirthInputCSS = "div[label='Date Of Birth'] #localDateChooser";
        private const string emailAddressInputCSS = "gw-pl-input-ctrl[label='Email Address'] input[type='text']";
        private const string homePhoneNumberInputID = "HomeNumber";
        private const string homePrimaryPhoneTypeRadioButtonCSS = "label[for='HomeNumberPrimaryPhoneType']";
        private const string workPhoneNumberInputID = "WorkNumber";
        private const string workPrimaryPhoneTypeRadioButtonCSS = "label[for='WorkNumberPrimaryPhoneType']";
        private const string mobilePhoneNumberInputID = "CellNumber";
        private const string mobilePrimaryPhoneTypeRadioButtonCSS = "label[for='CellNumberPrimaryPhoneType']";
        private const string producerCodeDropdownCSS = "div[label='Producer Code']:first-of-type select[name='ProducerCode']";
        private const string effectiveDateInputCSS = "div[label='Effective Date'] #localDateChooser";
        private const string createAccountButtonCSS = "button[ng-click*='submitCreateAccountForm']";
        private const string startApplicationButtonCSS = "button[on-click='submitNewSubmissionForm(newSubmissionForm)']";

        public CreateNewAccountPage(IWebDriver driver) : base(driver) { }

        public override void VerifyPage()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(firstNameInputCSS), 30);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver, 180);
        }

        private string ProducerCodeDropdownOptionCSS(string producerCode)
        {
            return string.Format("section[class='gw-container-form'] section:first-of-type select[name='ProducerCode'] option[value*='{0}']", producerCode);
        }

        public void EnterAddressDetails(string addressLine1, string addressLine2, string city, string zipCode, string state)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(addressLine1InputCSS), 30);
            driver.FindElement(By.CssSelector(addressLine1InputCSS)).Clear();
            driver.FindElement(By.CssSelector(addressLine1InputCSS)).SendKeys(addressLine1);
            ScenarioContext.Current["AddressLine1"] = addressLine1;

            if (!string.IsNullOrEmpty(addressLine2))
            {
                WaitUntilElementEnabled(driver, By.CssSelector(addressLine2InputCSS), 30);
                driver.FindElement(By.CssSelector(addressLine2InputCSS)).Clear();
                driver.FindElement(By.CssSelector(addressLine2InputCSS)).SendKeys(addressLine2);
                ScenarioContext.Current["AddressLine2"] = addressLine2;
            }

            WaitUntilElementEnabled(driver, By.CssSelector(cityInputCSS), 30);
            driver.FindElement(By.CssSelector(cityInputCSS)).Clear();
            driver.FindElement(By.CssSelector(cityInputCSS)).SendKeys(city);
            ScenarioContext.Current["City"] = city;

            WaitUntilElementEnabled(driver, By.CssSelector(zipCodeInputCSS), 30);
            driver.FindElement(By.CssSelector(zipCodeInputCSS)).Clear();
            driver.FindElement(By.CssSelector(zipCodeInputCSS)).SendKeys(zipCode);
            ScenarioContext.Current["ZipCode"] = zipCode;

            WaitUntilElementEnabled(driver, By.CssSelector(stateSelectCSS), 30);
            SelectByText(driver.FindElement(By.CssSelector(stateSelectCSS)), state);
            ScenarioContext.Current["State"] = state;
        }

        public void EnterDateOfBirth(string dateOfBirth)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(dateOfBirthInputCSS), 30);
            driver.FindElement(By.CssSelector(dateOfBirthInputCSS)).Clear();
            driver.FindElement(By.CssSelector(dateOfBirthInputCSS)).SendKeys(dateOfBirth);
            ScenarioContext.Current["DateOfBirth"] = dateOfBirth;
        }

        public void EnterEmailAddress(string emailAddress)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(emailAddressInputCSS), 30);
            driver.FindElement(By.CssSelector(emailAddressInputCSS)).Clear();
            driver.FindElement(By.CssSelector(emailAddressInputCSS)).SendKeys(emailAddress);
            ScenarioContext.Current["EmailAddress"] = emailAddress;
        }

        public void EnterHomePhoneNumber(string homePhoneNumber)
        {
            WaitUntilElementEnabled(driver, By.Id(homePhoneNumberInputID), 30);
            driver.FindElement(By.Id(homePhoneNumberInputID)).Clear();
            driver.FindElement(By.Id(homePhoneNumberInputID)).SendKeys(homePhoneNumber);
            ScenarioContext.Current["HomePhoneNumber"] = homePhoneNumber;
        }

        public void EnterWorkPhoneNumber(string workPhoneNumber)
        {
            WaitUntilElementEnabled(driver, By.Id(workPhoneNumberInputID), 30);
            driver.FindElement(By.Id(workPhoneNumberInputID)).Clear();
            driver.FindElement(By.Id(workPhoneNumberInputID)).SendKeys(workPhoneNumber);
            ScenarioContext.Current["WorkPhoneNumber"] = workPhoneNumber;
        }

        public void EnterMobilePhoneNumber(string mobilePhoneNumber)
        {
            WaitUntilElementEnabled(driver, By.Id(mobilePhoneNumberInputID), 30);
            driver.FindElement(By.Id(mobilePhoneNumberInputID)).Clear();
            driver.FindElement(By.Id(mobilePhoneNumberInputID)).SendKeys(mobilePhoneNumber);
            ScenarioContext.Current["MobilePhoneNumber"] = mobilePhoneNumber;
        }

        public void SelectPrimaryPhoneType(string primaryPhoneType)
        {
            switch (primaryPhoneType)
            {
                case "Home":
                    JavaScriptClick(driver.FindElement(By.CssSelector(homePrimaryPhoneTypeRadioButtonCSS)));
                    break;
                case "Work":
                    JavaScriptClick(driver.FindElement(By.CssSelector(workPrimaryPhoneTypeRadioButtonCSS)));
                    break;
                case "Mobile":
                    JavaScriptClick(driver.FindElement(By.CssSelector(mobilePrimaryPhoneTypeRadioButtonCSS)));
                    break;
                default:
                    Console.WriteLine("'{0}' phone type does not exist", primaryPhoneType);
                    break;
            }
            ScenarioContext.Current["PrimaryPhoneType"] = primaryPhoneType;
        }

        public void SelectProducerCode(string producerCode)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(producerCodeDropdownCSS), 30);
            driver.FindElement(By.CssSelector(producerCodeDropdownCSS)).Click();

            WaitUntilElementEnabled(driver, By.CssSelector(ProducerCodeDropdownOptionCSS(producerCode)), 30);
            driver.FindElement(By.CssSelector(ProducerCodeDropdownOptionCSS(producerCode))).Click();
            ScenarioContext.Current["ProducerCode"] = producerCode;
        }

        public void EnterEffectiveDate(string date)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(effectiveDateInputCSS), 30);
            driver.FindElement(By.CssSelector(effectiveDateInputCSS)).Clear();
            driver.FindElement(By.CssSelector(effectiveDateInputCSS)).SendKeys(date);
            ScenarioContext.Current["EffectiveDate"] = date;
        }

        public void ClickCreateAccount()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(createAccountButtonCSS), 30);
            driver.FindElement(By.CssSelector(createAccountButtonCSS)).Click();
        }

        public void ClickStartNewApplicationButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(startApplicationButtonCSS), 30);
            driver.FindElement(By.CssSelector(startApplicationButtonCSS)).Click();
        }
    }
}

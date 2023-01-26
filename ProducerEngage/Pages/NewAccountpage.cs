using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebCommonCore;

namespace ProducerEngage.Pages
{
   public class NewAccountpage:Page
    {
        public Dictionary<string, string> urlDictionary = new Dictionary<string, string>();
        string btnCreateAccount = "button[ng-click='submitCreateAccountForm(newAccountForm)']";
        string txtAddress1Xpath = "//gw-pl-input-ctrl[contains(@label,'Address Line 1')]/div/div/div/input[@ng-model='model.value']";
        string txtAddress2Xpath = "//gw-pl-input-ctrl[contains(@label,'Address Line 2')]/div/div/div/input[@ng-model='model.value']";
        string txtCityXpath = "//gw-pl-input-ctrl[contains(@label,'City')]/div/div/div/input[@ng-model='model.value']";
        string txtZipXpath = "//gw-pl-input-ctrl[contains(@label,'ZIP Code')]/div/div/div/input[@ng-model='model.value']";
        string selStaeXpath = "//select[@class='ng-scope ng-isolate-scope gw-pl-select']";
        string btnVerifyAddress = "//span[contains(.,'Verify Address')]";
        string txtEmailAddressXpath = "//gw-pl-input-ctrl[contains(@label,'Email Address')]/div/div/div/input[@ng-model='model.value']";
        string txtHomePhoneXpath = "//input[@id='HomeNumber']";
        string txtWorkPhoneXpath = "//input[@id='WorkNumber']";
        string txtMobilePhonepath = "//input[@id='CellNumber']";
        string radioHomePhoneXpath = "//label[@for='HomeNumberPrimaryPhoneType']";
        string radioWorkPhoneXpath = "//label[@for='HomeNumberPrimaryPhoneType']";
        string radioMobilePhoneXpath = "//label[@for='CellNumberPrimaryPhoneType'] ";
        string btnCreateAccountXpath = "//button[@class='gw-next gw-btn-primary gw-btn ng-binding']";
        string txtEffectiveDateXpath = "//input[@id='localDateChooser']";
        string btnNextXapth = "//button[@class='gw-next gw-btn-primary gw-btn ng-isolate-scope']";
        string lbladdressverifiedXpath = "//span[.='Verified']";
        string btnCreateNewAccount = "//button[@class='gw-next gw-btn-primary gw-btn ng-binding']";
        string btnStartApplication = "//button[@class='gw-next gw-btn-primary gw-btn ng-isolate-scope']";

        string txtDateOfBirthXpath = "//input[@class='gw-form-control ng-pristine ng-valid ng-empty ng-touched']";
        string accountNumberXpath = "//div[@ng-show='isAnExistingAccount']/div/p";
        string lblNewQuoteForExistingAccountXpath = "//h1[contains(.,'New Quote: Policy Details for Existing Account')]";
        string btnQuickEstimate = "//button[@on-click='submitNewSubmissionFormForQQ(newSubmissionForm)']";

        private const string producerCodeDropdownSelectCSS = "section[class='gw-container-form'] section:first-of-type select[name='ProducerCode']";

        public NewAccountpage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnCreateAccount);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnCreateAccount));

        }

        private string ProducerCodeDropdownOptionCSS(string producerCode)
        {
            return string.Format("section[class='gw-container-form'] section:first-of-type select[name='ProducerCode'] option[value*='{0}']", producerCode);
        }

        public void EnterAddressDetails(string adress1, string adress2, string city, string state, string zip)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            string CompleteAddress = "";
            CompleteAddress = adress1;
            UIActionExt(By.XPath(txtAddress1Xpath), "listbox", adress1);
            if (adress2.Length >0)
            {
                UIActionExt(By.XPath(txtAddress2Xpath), "listbox", adress2);
                CompleteAddress = CompleteAddress+ adress2;
            }
            
            UIActionExt(By.XPath(txtCityXpath), "listbox", city);
            CompleteAddress = CompleteAddress + city;
            SelectByText(driver.FindElement(By.XPath(selStaeXpath)),state);
            UIActionExt(By.XPath(txtZipXpath), "listbox", zip);
            getState();
            string temp_State = urlDictionary[state];
            CompleteAddress = CompleteAddress + "," + temp_State;
            if (zip.Contains("-"))
            {
                char[] delimiterChars = { '-' };
                string[] tempZip1 = zip.Split(delimiterChars);
                zip = tempZip1[0];
                Console.WriteLine("Zip code is  " + zip);
            }
            CompleteAddress = CompleteAddress + zip;
            CompleteAddress = CompleteAddress.Replace(" ", "");
            RegKey.SetValue("ZIPCODE", zip);
            Console.WriteLine("Address for registry is " + CompleteAddress);
            RegKey.SetValue("ACC_ADDRESS", CompleteAddress);
            //UIActionExt(By.XPath(btnVerifyAddress), "click");
            //WaitUntilElementVisible(driver, By.XPath(lbladdressverifiedXpath), 120);
        }
        public void SelectProducerCode(string code)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(producerCodeDropdownSelectCSS), 30);
            driver.FindElement(By.CssSelector(producerCodeDropdownSelectCSS)).Click();

            WaitUntilElementEnabled(driver, By.CssSelector(ProducerCodeDropdownOptionCSS(code)), 30);
            driver.FindElement(By.CssSelector(ProducerCodeDropdownOptionCSS(code))).Click();
        }
        public void ClickCreateAccount()
        {
            WaitUntilElementEnabled(driver, By.XPath(btnCreateNewAccount), 30);
            JavaScriptClick(driver.FindElement(By.XPath(btnCreateNewAccount)));
        }
        public void ClickStartApplication()
        {
            WaitUntilElementVisible(driver, By.XPath(btnStartApplication), 5);
            Thread.Sleep(3000); 
            JavaScriptClick(driver.FindElement(By.XPath(btnStartApplication)));
        }

        public void EnterOtherDetails(string EmailAddress, string HomePhone, string WorkPhone, string MobilePhone, string PrimaryNumber)
        {
            string phonenumber = "";
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            if (EmailAddress.ToLower().Contains("unique"))
            {
                EmailAddress = Unique.ID;
                EmailAddress = EmailAddress.Substring(0, EmailAddress.Length - 15);
                EmailAddress = EmailAddress + "@apptest.jminsure.com";
            }
            UIActionExt(By.XPath(txtEmailAddressXpath), "listbox", EmailAddress);
            RegKey.SetValue("EMAIL", EmailAddress);
            if (HomePhone.Length > 0)
            {
                UIActionExt(By.XPath(txtHomePhoneXpath), "listbox", HomePhone);
            }
            if (WorkPhone.Length > 0)
            {
               UIActionExt(By.XPath(txtWorkPhoneXpath), "listbox", WorkPhone);
            }
            if (MobilePhone.Length > 0)
            {
                UIActionExt(By.XPath(txtMobilePhonepath), "listbox", MobilePhone);
            }

            switch (PrimaryNumber.ToLower().Trim())
            {
                case "homephone":
                    JavaScriptClick(driver.FindElement(By.XPath(radioHomePhoneXpath)));
                    phonenumber = HomePhone;
                    break;
                case "workphone":
                    JavaScriptClick(driver.FindElement(By.XPath(radioWorkPhoneXpath)));
                    phonenumber = WorkPhone;
                    break;
                case "mobilephone":
                    JavaScriptClick(driver.FindElement(By.XPath(radioMobilePhoneXpath)));
                    phonenumber = MobilePhone;
                    break;
                default:
                    break;
            }
            JavaScriptClick(driver.FindElement(By.XPath(btnCreateAccountXpath)));
            phonenumber = phonenumber.Replace("-", "");
            RegKey.SetValue("PHONE", phonenumber);

        }

        public void SetEffectiveDate(string EffectiveDate)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            DateTime date = DateTime.Now;
            Actions action = new Actions(driver);
            string SetDate = "";
            string ExpDate = "";
            if (EffectiveDate.ToLower() == "currentdate")
            {
                Console.WriteLine("----------------");
                SetDate = string.Format("{0:MM/dd/yyyy}", date);
                ExpDate = string.Format("{0:MM/dd/yyyy}", date.AddYears(1));
            }
            else if (EffectiveDate.Contains("+"))
            {
                Console.WriteLine("---dATE +--------");
                string[] details = EffectiveDate.Split('+');
                Console.WriteLine(Int32.Parse(details[1]));
                Console.WriteLine(date);
                Console.WriteLine(date.AddDays(Int32.Parse(details[1])));
                SetDate = string.Format("{0:MM/dd/yyyy}", date.AddDays(Int32.Parse(details[1])));
                Console.WriteLine("under logic ");
                DateTime parsedDate = DateTime.Parse(SetDate);
                Console.WriteLine(SetDate);
                ExpDate = string.Format("{0:MM/dd/yyyy}", parsedDate.AddYears(1));

            }
            else
            {
                SetDate = EffectiveDate;
                ExpDate = string.Format("{00:MMM d, yyyy}", date.AddYears(1));
            }
            
            //UIActionExt(By.XPath(txtEffectiveDateXpath), "listbox", SetDate);
            RegKey.SetValue("EFFDATE", SetDate);
            RegKey.SetValue("EXPDATE", ExpDate);

        }

        public void ClickNext()
        {
            JavaScriptClick(driver.FindElement(By.XPath(btnNextXapth)));
        }

        public void getState()
        {
            urlDictionary.Add("Alabama", "AL");
            urlDictionary.Add("Alaska", "AK");
            urlDictionary.Add("Arizona", "AZ");
            urlDictionary.Add("Arkansas", "AR");
            urlDictionary.Add("California", "CA");
            urlDictionary.Add("Colorado", "CO");
            urlDictionary.Add("Connecticut", "CT");
            urlDictionary.Add("Delaware", "DE");
            urlDictionary.Add("Florida", "FL");
            urlDictionary.Add("Georgia", "GA");
            urlDictionary.Add("Hawaii", "HI");
            urlDictionary.Add("Idaho", "ID");
            urlDictionary.Add("Illinois", "IL");
            urlDictionary.Add("Indiana", "IN");
            urlDictionary.Add("Iowa", "IA");
            urlDictionary.Add("Kansas", "KS");
            urlDictionary.Add("Kentucky", "KY");
            urlDictionary.Add("Louisiana", "LA");
            urlDictionary.Add("Maine", "ME");
            urlDictionary.Add("Maryland", "MD");
            urlDictionary.Add("Massachusetts", "MA");
            urlDictionary.Add("Michigan", "MI");
            urlDictionary.Add("Minnesota", "MN");
            urlDictionary.Add("Mississippi", "MS");
            urlDictionary.Add("Missouri", "MO");
            urlDictionary.Add("Montana", "MT");
            urlDictionary.Add("Nebraska", "NE");
            urlDictionary.Add("Nevada", "NV");
            urlDictionary.Add("New Hampshire", "NH");
            urlDictionary.Add("New Jersey", "NJ");
            urlDictionary.Add("New Mexico", "NM");
            urlDictionary.Add("New York", "NY");
            urlDictionary.Add("North Carolina", "NC");
            urlDictionary.Add("North Dakota", "ND");
            urlDictionary.Add("Ohio", "OH");
            urlDictionary.Add("Oklahoma", "OK");
            urlDictionary.Add("Oregon", "OR");
            urlDictionary.Add("Pennsylvania", "PA");
            urlDictionary.Add("Rhode Island", "RI");
            urlDictionary.Add("South Carolina", "SC");
            urlDictionary.Add("South Dakota", "SD");
            urlDictionary.Add("Tennessee", "TN");
            urlDictionary.Add("Texas", "TX");
            urlDictionary.Add("Utah", "UT");
            urlDictionary.Add("Vermont", "VT");
            urlDictionary.Add("Virginia", "VA");
            urlDictionary.Add("Washington", "WA");
            urlDictionary.Add("West Virginia", "WV");
            urlDictionary.Add("Wisconsin", "WI");
            urlDictionary.Add("Wyoming", "WY");
            //Canada States:
            urlDictionary.Add("Alberta", "AB");
            urlDictionary.Add("British Columbia", "BC");
            urlDictionary.Add("Manitoba", "MB");
            urlDictionary.Add("New Brunswick", "NB");
            urlDictionary.Add("Newfoundland and Labrador", "NL");
            urlDictionary.Add("Northwest Territories", "NT");
            urlDictionary.Add("Nova Scotia", "NS");
            urlDictionary.Add("Nunavut", "NU");
            urlDictionary.Add("Ontario", "ON");
            urlDictionary.Add("Prince Edward Island", "PE");
            urlDictionary.Add("Quebec", "QC");
            urlDictionary.Add("Saskatchewan", "SK");
            urlDictionary.Add("Yukon", "YT");
        }

        public void EnterDateOfBirth(string dateOfBirth)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");

            UIActionExt(By.XPath(txtDateOfBirthXpath), "listbox", dateOfBirth);
            RegKey.SetValue("BIRTHDAY", dateOfBirth);
        }

        public void VerifyAccountIsCreated()
        {
            WaitUntilElementVisible(driver, By.XPath(lblNewQuoteForExistingAccountXpath));
            string accountNumber = driver.FindElement(By.XPath(accountNumberXpath)).Text;
            if (IsElementPresent(driver, By.XPath(lblNewQuoteForExistingAccountXpath)))
            {
                if (accountNumber.Equals(""))
                {
                    Assert.Fail("Account is not successfully created");
                }
            }
            else
            {
                Assert.Fail("Failed in creating account");
            }
        }

        public void ClickQuickEstimateButton()
        {
            WaitUntilElementVisible(driver, By.XPath(lblNewQuoteForExistingAccountXpath));
            Thread.Sleep(1000);
            JavaScriptClick(driver.FindElement(By.XPath(btnQuickEstimate)));            
        }
    }   
}

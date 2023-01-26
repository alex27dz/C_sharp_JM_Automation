using HelperClasses;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class ExistingAccountPage : Page
    {
        private const string firstNameInputCSS = "div[label='First Name'] input[type='text']";
        private const string lastNameInputCSS = "div[label='Last Name'] input[type='text']";
        private const string cityInputCSS = "gw-pl-input-ctrl[label='City'] input[type='text']";
        private const string zipCodeInputCSS = "gw-pl-input-ctrl[label='ZIP Code'] input[type='text']";
        private const string stateDropdownCSS = "div[label='State'] select";
        private const string dateOfBirthInputID = "localDateChooser";
        private const string emailAddressInputCSS = "gw-pl-input-ctrl[label='Email Address'] input[type='text']";
        private const string searchButtonCSS = "button[value='Search']";

        public ExistingAccountPage(IWebDriver driver) : base(driver) { }

        public override void VerifyPage()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(firstNameInputCSS), 30);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver, 180);
        }

        public void SearchByFirstAndLastName(string firstName, string lastName)
        {
            if (firstName.ToLower().Equals("unique"))
            {
                firstName = "FN" + Unique.ID;
                firstName = firstName.Substring(0, firstName.Length - 15);
            }

            if (lastName.ToLower().Equals("unique"))
            {
                lastName = "LN" + Unique.ID;
                lastName = lastName.Substring(0, lastName.Length - 15);
            }
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");

            UIActionExt(By.CssSelector(firstNameInputCSS), "listbox", firstName);
            RegKey.SetValue("FNAME", firstName);
            UIActionExt(By.CssSelector(lastNameInputCSS), "listbox", lastName);
            RegKey.SetValue("LNAME", lastName);
            RegKey.SetValue("PRIMARY_INSURED", firstName + " " + lastName);
            UIAction(searchButtonCSS, String.Empty, "a");
        }

        public void EnterFirstName(string firstName)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(firstNameInputCSS), 30);
            driver.FindElement(By.CssSelector(firstNameInputCSS)).Clear();
            driver.FindElement(By.CssSelector(firstNameInputCSS)).SendKeys(firstName);
            ScenarioContext.Current["FirstName"] = firstName;
        }

        public void EnterLastName(string lastName)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(lastNameInputCSS), 30);
            driver.FindElement(By.CssSelector(lastNameInputCSS)).Clear();
            driver.FindElement(By.CssSelector(lastNameInputCSS)).SendKeys(lastName);
            ScenarioContext.Current["LastName"] = lastName;
        }

        public void EnterCity(string city)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(cityInputCSS), 30);
            driver.FindElement(By.CssSelector(cityInputCSS)).Clear();
            driver.FindElement(By.CssSelector(cityInputCSS)).SendKeys(city);
            ScenarioContext.Current["City"] = city;
        }

        public void EnterZipCode(string zipCode)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(zipCodeInputCSS), 30);
            driver.FindElement(By.CssSelector(zipCodeInputCSS)).Clear();
            driver.FindElement(By.CssSelector(zipCodeInputCSS)).SendKeys(zipCode);
            ScenarioContext.Current["ZipCode"] = zipCode;
        }

        public void SelectState(string state)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(stateDropdownCSS), 30);
            SelectByText(driver.FindElement(By.CssSelector(stateDropdownCSS)), state);
            ScenarioContext.Current["State"] = state;
        }

        public void EnterDateOfBirth(string dateOfBirth)
        {
            WaitUntilElementEnabled(driver, By.Id(dateOfBirthInputID), 30);
            driver.FindElement(By.Id(dateOfBirthInputID)).Clear();
            driver.FindElement(By.Id(dateOfBirthInputID)).SendKeys(dateOfBirth);
            ScenarioContext.Current["DateOfBirth"] = dateOfBirth;
        }

        public void EnterEmailAddress(string emailAddress)
        {
            WaitUntilElementEnabled(driver, By.CssSelector(emailAddressInputCSS), 30);
            driver.FindElement(By.CssSelector(emailAddressInputCSS)).Clear();
            driver.FindElement(By.CssSelector(emailAddressInputCSS)).SendKeys(emailAddress);
            ScenarioContext.Current["EmailAddress"] = emailAddress;
        }

        public void ClickSearchButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(searchButtonCSS), 30);
            driver.FindElement(By.CssSelector(searchButtonCSS)).Click();
        }
    }
}

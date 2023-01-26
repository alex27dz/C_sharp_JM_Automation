using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using System.Text.RegularExpressions;
using System.Threading;
using HelperClasses;
using iTextSharp.text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;


namespace DigitalProject.ClaimsApp
{
    public class ContactScreen : Page
    {
        #region Required

        public ContactScreen(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  VerifyUIElementIsDisplayed(VerifyPageElement);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("PolicyNumber"));
        }

        #endregion

        #region Elements

        string inputFirstName = "input[id$='FirstName']";

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(1) > div:nth-child(1) > span:nth-child(3)")]
        public IWebElement FirstNameErrorMessage;

        string inputPhoneNumber = "input[id$='PhoneNum']";

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(2) > div:nth-child(1) > span:nth-child(3)")]
        public IWebElement PhoneNumberErrorMessage;

        [FindsBy(How = How.Id, Using = "PhoneNum")]
        public IWebElement PhoneNumber;

        string inputEmail = "input[id$='Email']";

        string chckNewAddress = "input[id$='UpdateAddressCheckbox']";

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email;

        [FindsBy(How = How.CssSelector,
            Using = "div.form-group:nth-child(2) > div:nth-child(2) > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement EmailErrorMessage;

        string inputStreetAddress = "input[id$='StreetAddress']";

        [FindsBy(How = How.CssSelector, Using = ".col-md-8 > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement StreetAddressErrorMessage;

        
        [FindsBy(How = How.CssSelector,
            Using = "div.form-group:nth-child(4) > div:nth-child(1) > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement CityErrorMessage;

        
        [FindsBy(How = How.CssSelector,
            Using = "div.form-group:nth-child(4) > div:nth-child(2) > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement StateErrorMessage;

        [FindsBy(How = How.Id, Using = "State")]
        public IWebElement StateEle;
        string State = "select[id='State']";

        [FindsBy(How = How.Id, Using = "City")]
        public IWebElement inputCityEle;


        string inputCity = "input[id='City']";


        [FindsBy(How = How.Id, Using = "ZipCode")]
        public IWebElement InputContactZipCode;

        #endregion

        public void selectRelationship(string Relationship)
        {
            IWebElement releationship_type;
            switch (Relationship.ToLower())
            {
                case "self":
                    releationship_type = driver.FindElement(By.XPath("//input[@name='Relationship'][@value='Self']"));
                    releationship_type.Click();
                    break;
                case "spouse":
                    releationship_type = driver.FindElement(By.XPath("//input[@name='Relationship'][@value='Spouse']"));
                    releationship_type.Click();
                    break;
                case "jeweler":
                    releationship_type = driver.FindElement(By.XPath("//input[@name='Relationship'][@value='Jeweler']"));
                    releationship_type.Click();
                    break;
                case "other":
                    releationship_type = driver.FindElement(By.XPath("//input[@name='Relationship'][@value='Other']"));
                    releationship_type.Click();
                    break;

            }

        }

        public void selectThisisNewAddress()
        {
            UIAction(chckNewAddress, String.Empty, "a");
        }
        public void EnterClaimDetails(string firstName, string phoneNumber, string streetAddress, string city, string state, string email)
        {
            UIAction(inputFirstName, firstName, "textbox");
            UIAction(inputPhoneNumber, phoneNumber, "textbox");
            UIAction(inputStreetAddress, streetAddress, "textbox");
            UIActionExt(By.CssSelector(inputCity), "ispresent");
            UIActionExt(By.CssSelector(inputCity), "Text", city);

            UIActionExt(By.CssSelector(State), "ispresent");
            Email.Clear();
            UIAction(inputEmail, email, "textbox");
            SelectByText(driver.FindElement(By.CssSelector(State)), state);
          //  UIActionExt(By.CssSelector(State), "listbox", state);


            //    //  UIAction(inputCity, city, "textbox");
            //    pause();
            //    State.Click();
            //    State.SendKeys(state);
            //    State.SendKeys(Keys.Enter);
            //    State.SendKeys(Keys.Tab);
        }
        public void EnterFirstName(string firstName)
        {
            UIAction(inputFirstName, firstName, "textbox");
        }

        public void EnterPhoneNumber(string phoneNumber)
        {
            PhoneNumber.Click();
            UIAction(inputPhoneNumber, phoneNumber, "textbox");
        }

        public void EnterEmail(string email)
        {
            UIAction(inputEmail, email, "textbox");
        }

        public void EnterStreetAddress(string streetAddress)
        {
            UIAction(inputStreetAddress, streetAddress, "textbox");
        }

        public void EnterCity(string city)
        {
            UIAction(inputCity, city, "textbox");
        }

        public void EnterState(string state)
        {
            StateEle.Click();
            StateEle.SendKeys(state);
            // UIAction(inputState, state, "textbox");
            StateEle.SendKeys(Keys.Enter);
            StateEle.SendKeys(Keys.Tab);
        }

        public void ContactScreenEnterZipCode(string zipCode)
        {

            InputContactZipCode.Click();
            InputContactZipCode.Clear();
            InputContactZipCode.SendKeys(zipCode);

        }


        public void ContactScreenErrors()
        {
            Assert.IsTrue(FirstNameErrorMessage.Text.Equals("Please enter your first name."),
                "Actual First Name Error Message" + FirstNameErrorMessage.Text);
            Assert.IsTrue(PhoneNumberErrorMessage.Text.Equals("Please enter your phone number."),
                "Actual Phone Error Message" + PhoneNumberErrorMessage.Text);

            Assert.IsTrue(StreetAddressErrorMessage.Text.Equals("Please enter your street address."),
                "Actual Street Error Message" + StreetAddressErrorMessage.Text);
            Assert.IsTrue(CityErrorMessage.Text.Equals("Please enter your city."),
                "Actual City Error Message" + CityErrorMessage.Text);
            Assert.IsTrue(StateErrorMessage.Text.Equals("Please select your state/province."),
                "Actual State Error Message" + StateErrorMessage.Text);
            PhoneNumber.Click();
            PhoneNumber.SendKeys("234");
            Assert.IsTrue(PhoneNumberErrorMessage.Text.Equals("Please enter a valid 10-digit phone number."),
                "Actual Phone Error Message" + PhoneNumberErrorMessage.Text);
            PhoneNumber.Clear();
            //Email.SendKeys("test@");
            //Assert.IsTrue(EmailErrorMessage.Text.Equals("Please enter a valid email address."), "Actual Email Error Message" + EmailErrorMessage.Text);
            // Email.Clear();
        }
    }
}

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

namespace DigitalProject.Pages.Personal
{
    public class ClaimsApp : Page
    {

        #region Required
        public ClaimsApp(IWebDriver driver) : base(driver)
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

        [FindsBy(How = How.Id, Using = "PolicyNumber")]
        public IWebElement PolicyNumberTextBox;

        string inputPolicyNumber = "input[id$='PolicyNumber']";

        string inputLastName = "input[id$='LastName']";

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastNameTextBox;

        string inputZipCode = "input[id$='ZipCode']";

        [FindsBy(How = How.Id, Using = "PolicyZipCode")]
        public IWebElement ZipCode;

        [FindsBy(How = How.CssSelector, Using = "#BypassRecaptcha")]
        public IWebElement CaptchaBox;

        [FindsBy(How = How.CssSelector, Using = ".validation-summary-errors > ul:nth-child(1)")]
        public IWebElement StartAClaimErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "div.col-md-12:nth-child(3) > span:nth-child(2) > span:nth-child(1)")]
        public IWebElement PolicyNumberErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(2) > div:nth-child(2) > span:nth-child(2) > span:nth-child(1)")]
        public IWebElement LastNameErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(3) > div:nth-child(2) > span:nth-child(2)")]
        public IWebElement ZipCodeErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "#recaptchaError")]
        public IWebElement CaptchaErrorMessage;

        [FindsBy(How = How.Id, Using = "continueButton")]
        public IWebElement ContinueButton;

        [FindsBy(How = How.ClassName, Using = ".pull-left")]
        public IWebElement BackButton;

        string inputDateOfLoss = "input[id$='NoticeDate']";

        [FindsBy(How = How.Id, Using = "NoticeDate")]
        public IWebElement fieldDateOfLoss;

        [FindsBy(How = How.CssSelector, Using = ".text-danger > span:nth-child(1)")]
        public IWebElement DateOfLossErrorMessage;

        [FindsBy(How = How.CssSelector, Using = ".validation-summary-errors > ul:nth-child(1) > li:nth-child(1)")]
        public IWebElement FutureDateErrorMessage;

        string inputFirstName = "input[id$='FirstName']";

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(1) > div:nth-child(1) > span:nth-child(3)")]
        public IWebElement FirstNameErrorMessage;

        string inputPhoneNumber = "input[id$='PhoneNum']";

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(2) > div:nth-child(1) > span:nth-child(3)")]
        public IWebElement PhoneNumberErrorMessage;

        [FindsBy(How = How.Id, Using = "PhoneNum")]
        public IWebElement PhoneNumber;

        string inputEmail = "input[id$='Email']";

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email;

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(2) > div:nth-child(2) > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement EmailErrorMessage;

        string inputStreetAddress = "input[id$='StreetAddress']";

        [FindsBy(How = How.CssSelector, Using = ".col-md-8 > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement StreetAddressErrorMessage;

        string inputCity = "input[id$='City']";

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(4) > div:nth-child(1) > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement CityErrorMessage;

        string inputState = "input[id$='State']";

        [FindsBy(How = How.CssSelector, Using = "div.form-group:nth-child(4) > div:nth-child(2) > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement StateErrorMessage;

        [FindsBy(How = How.Id, Using = "State")]
        public IWebElement State;

        [FindsBy(How = How.Id, Using = "ZipCode")]
        public IWebElement InputContactZipCode;

        [FindsBy(How = How.ClassName, Using = "jm-loss-damage-group")]
        public IWebElement LossDamageContainer;

        [FindsBy(How = How.Id, Using = "loss")]
        public IWebElement LossButton;

        string lossB = "input[id$='loss']";  //Input class = btn jm-loss-damage-btn
        // input.#loss.btn.jm-loss-damage-btn

        [FindsBy(How = How.XPath, Using = "//*[@id=\"loss\"]")]
        public IWebElement LossButton2;

        [FindsBy(How = How.Id, Using = "damage")]
        public IWebElement DamageButton;

        [FindsBy(How = How.CssSelector, Using = ".field-validation-error")]
        public IWebElement LossDamageError;

        [FindsBy(How = How.CssSelector, Using = "input.btn:nth-child(8)")]
        public IWebElement LossDamageContinue;

        [FindsBy(How = How.CssSelector, Using = "#LossType > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > label:nth-child(1) > span:nth-child(3)")]
        public IWebElement AccidentalLoss;

        [FindsBy(How = How.CssSelector, Using = "#DamageType > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > label:nth-child(1) > span:nth-child(3)")]
        public IWebElement DamagedStone;

        [FindsBy(How = How.LinkText, Using = "I have more than one type of loss or damage.")]
        public IWebElement IHaveMoreThanOneTypeOfLossLink;

        string inputDescription = "input[id$='Description']";

        [FindsBy(How = How.Id, Using = "Description")]
        public IWebElement Description;

        [FindsBy(How = How.CssSelector, Using = ".text-danger > span:nth-child(1)")]
        public IWebElement DescriptionErrorMessage;

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement SubmitClaimButton;

        [FindsBy(How = How.CssSelector, Using = "div.row:nth-child(2) > div:nth-child(1) > b:nth-child(1)")]
        public IWebElement ClaimNumber;

        [FindsBy(How = How.CssSelector, Using = "a.btn:nth-child(7)")]
        public IWebElement ReturnToHome;

        string searchLink = "a[id$='TabBar:SearchTab']";

        [FindsBy(How = How.Id, Using = "SimpleClaimSearch:SimpleClaimSearchScreen:SimpleClaimSearchDV:ClaimNumber")]
        public IWebElement ClaimNumberInput;

        #endregion

        #region Common
        public void GoToUrl(string url2)
        {
            String currentURL = driver.Url;

            int index = currentURL.LastIndexOf("www.");

            if (index > 0)
                currentURL = currentURL.Remove(currentURL.LastIndexOf(".com/") + 5);

            this.driver.Url = currentURL + url2;
        }


        #endregion
        #region Methods

        #region MyRegion




        public void GoToClaimsApp()
        {
            string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();
            if (currEnvironment.Contains("dev1"))
            {
                string url = "http://mytest07.jewelersnt.local/start-a-claim";
                this.driver.Url = url;
            }
            else if (currEnvironment.Contains("test"))
            {
                string url = "http://mytest06.jewelersnt.local/start-a-claim";
                this.driver.Url = url;
            }
            else if (currEnvironment.Contains("qa4"))
            {
                string url = "http://mytest04.jewelersnt.local/start-a-claim";
                this.driver.Url = url;
            }
            else if (currEnvironment.Contains("stage"))
            {
                string url = "https://my.testjewelersmutual.com/Start-A-Claim";
                this.driver.Url = url;
            }
        }

        public void GoToClaimCenter()
        {
            string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();
            if (currEnvironment.Contains("dev1"))
            {
                string url = "http://jmdgcc01/cc/ClaimCenter.do";
                this.driver.Url = url;
            }
            else if (currEnvironment.Contains("test"))
            {
                string url = "http://jmtgcc07/cc/ClaimCenter.do";
                this.driver.Url = url;
            }
        }


        public void EnterPolicyNumber(string policyNumber)
        {
            PolicyNumberTextBox.Click();
            UIAction(inputPolicyNumber, policyNumber, "textbox");
        }


        public void EnterLastName(string lastName)
        {
            UIAction(inputLastName, lastName, "textbox");
        }

        public void EnterZipCode(string zipCode)
        {

            ZipCode.Click();
            UIAction(inputZipCode, zipCode, "textbox");
        }

        public void DisableCaptcha()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].setAttribute('value', 'true')", CaptchaBox);
        }

        public void ClickContinue()
        {
            ContinueButton.Click();
        }

        public void VerifyCLError()
        {
            Assert.IsTrue(StartAClaimErrorMessage.Text.Contains("Sorry, Report A Claim  is only for personal jewelry insurance accounts. Contact us at 800-558-6411 to report a claim for your jewelry business."), "Actual error mesasge text = " + StartAClaimErrorMessage.Text);
        }

        public void VerifyStartAClaimValidationMessages()
        {

            Assert.IsTrue(PolicyNumberErrorMessage.Text.Equals("Please enter your policy number."), "Actual Error Message" + PolicyNumberErrorMessage.Text);
            Assert.IsTrue(LastNameErrorMessage.Text.Equals("Please enter your last name."), "Actual Error Message" + LastNameErrorMessage.Text);
            Assert.IsTrue(ZipCodeErrorMessage.Text.Equals("Please enter your zip/postal code."), "Actual Error Message" + ZipCodeErrorMessage.Text);
            Assert.IsTrue(CaptchaErrorMessage.Text.Equals("Please confirm you\'re not a robot by checking the box above."), "Actual Error Message" + CaptchaErrorMessage.Text);

        }

        public void VerifyFNOLErrors()
        {
            Assert.IsTrue(DateOfLossErrorMessage.Text.Equals("The Date of Loss is required."), "Actual Error Message" + DateOfLossErrorMessage.Text);

            fieldDateOfLoss.SendKeys("05/05/2020");
            ContinueButton.Click();
            Assert.IsTrue(FutureDateErrorMessage.Text.Equals("Sorry, you can\'t use a future date for your loss or damage."), "Actual Error Message" + FutureDateErrorMessage.Text);
            fieldDateOfLoss.Clear();
        }

        public void ContactScreenErrors()
        {
            Assert.IsTrue(FirstNameErrorMessage.Text.Equals("Please enter your first name."), "Actual First Name Error Message" + FirstNameErrorMessage.Text);
            Assert.IsTrue(PhoneNumberErrorMessage.Text.Equals("Please enter your phone number."), "Actual Phone Error Message" + PhoneNumberErrorMessage.Text);

            Assert.IsTrue(StreetAddressErrorMessage.Text.Equals("Please enter your street address."), "Actual Street Error Message" + StreetAddressErrorMessage.Text);
            Assert.IsTrue(CityErrorMessage.Text.Equals("Please enter your city."), "Actual City Error Message" + CityErrorMessage.Text);
            Assert.IsTrue(StateErrorMessage.Text.Equals("Please select your state/province."), "Actual State Error Message" + StateErrorMessage.Text);
            PhoneNumber.Click();
            PhoneNumber.SendKeys("234");
            Assert.IsTrue(PhoneNumberErrorMessage.Text.Equals("Please enter a valid 10-digit phone number."), "Actual Phone Error Message" + PhoneNumberErrorMessage.Text);
            PhoneNumber.Clear();
            //Email.SendKeys("test@");
            //Assert.IsTrue(EmailErrorMessage.Text.Equals("Please enter a valid email address."), "Actual Email Error Message" + EmailErrorMessage.Text);
            // Email.Clear();
        }

        public void DamageLossErrors()
        {
            Assert.IsTrue(LossDamageError.Text.Equals("Please select the type of loss or damage."), "Actual Damage loss Name Error Message" + LossDamageError.Text);
        }

        public void DescriptionError()
        {
            Assert.IsTrue(DescriptionErrorMessage.Text.Equals("Please enter a description."), "Actual Description Name Error Message" + DescriptionErrorMessage.Text);
        }

        public void DateOfLoss(string dateOfLoss)
        {
            fieldDateOfLoss.Click();
            UIAction(inputDateOfLoss, dateOfLoss, "textbox");
        }

        public void EnterTodaysDate()
        {
            fieldDateOfLoss.Click();
            string today = DateTime.Now.ToString("MM/dd/yyyy");
            fieldDateOfLoss.SendKeys(today);
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
            State.Click();
            State.SendKeys(state);
            // UIAction(inputState, state, "textbox");
            State.SendKeys(Keys.Enter);
            State.SendKeys(Keys.Tab);
        }

        public void ContactScreenEnterZipCode(string zipCode)
        {

            InputContactZipCode.Click();
            InputContactZipCode.Clear();
            InputContactZipCode.SendKeys(zipCode);
        }


        public void ClickLoss()
        {

            //Thread.Sleep(4000);
            // LossButton.Click();
            // JavaScriptClick(LossButton);
            //LossButton2.Click();
            // LossButton2.Click();
            UIAction(lossB, string.Empty, "button");

        }

        public void ClickAccidentalLoss()
        {
            AccidentalLoss.Click();
        }

        public void ClickContinueLossDamage()
        {
            LossDamageContinue.Click();
        }

        public void EnterADescription(string description)
        {
            Description.Click();
            Description.SendKeys(description);
            //  UIAction(inputDescription, description, "textbox");
        }

        public void SubmitClaim()
        {
            SubmitClaimButton.Click();
        }

        public void StoreClaimNumber()
        {
            string cn = ClaimNumber.Text;
            Console.WriteLine("claim Number 1" + cn);
            ScenarioContext.Current.Add("CLAIM", ClaimNumber.Text);

        }
        #endregion


        #endregion
    }
}

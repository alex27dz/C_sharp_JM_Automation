using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;



namespace QuoteAndApplyPages.Pages.QNA
{
    public class LOOSQuotePage : Page
    {
        string editZipCode = "input[id$='zipCodeInput']";
        string buttonContinue = "//button[@class='btn jm-btn-primary btn-next pull-right']";
        string linkAddanotherItem = "a[id$='AddJewelryItemQuoteInfo']";
        string linknoThanks = "a[id$='noThanks']";
        string listJewelryType;
        string editJewelryValue;
        string txtAppfirstName = "input[id$='firstNameInput']";
        string txtApplastName = "input[id$='lastNameInput']";
        string txtAppPhonenumber = "input[id$='QuotePhoneNumber']";
        string txtAppEmailaddress = "input[id$='emailAddressInput']";


        //bool checkmarkGreenSolid = false;
        //string buttonApplyforCoverage = "a[id$='quoteResultsNext']";
        //[FindsBy(How = How.XPath, Using = "//img[contains(@src,'/jewelry-insurance-quote-apply/Content/Images/Icon-Edit.png')]")]
        //private IWebElement checkMarkGreenSolid;


        public LOOSQuotePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(editZipCode);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(editZipCode));
        }

        public void verifyErrorValidationMessagesForPartner()
        {
            WaitUntilElementVisible(driver, By.Id("quoteInfoNext"));
            IWebElement IwZipCodePostalCode = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Zip/Postal Code is required.')]"));
            IWebElement IwJewelryType = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Jewelry Type is required.')]"));
            IWebElement IwJeweleryValue = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Jewelry Value is required.')]"));
            IWebElement IwFirstName = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'First Name is required.')]"));
            IWebElement IwLastName = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Last Name is required.')]"));
            IWebElement IwEmailAddress = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Email Address is invalid. Please re-enter.')]"));
            Console.WriteLine("----QuotePage error message validation ----- started------");
            Assert.IsTrue(IwZipCodePostalCode.Text.Equals("Zip/Postal Code is required."), "Actual error message to verify zip code: " + IwZipCodePostalCode.Text);
            Assert.IsTrue(IwJewelryType.Text.Equals("Jewelry Type is required."), "Actual error message to verify Jewelry Type: " + IwJewelryType.Text);
            Assert.IsTrue(IwJeweleryValue.Text.Equals("Jewelry Value is required."), "Actual error message to verify jewelry value: " + IwJeweleryValue.Text);
            Assert.IsTrue(IwFirstName.Text.Equals("First Name is required."), "Actual error message to verify jewelry value: " + IwFirstName.Text);
            Assert.IsTrue(IwLastName.Text.Equals("Last Name is required."), "Actual error message to verify jewelry value: " + IwLastName.Text);
            Assert.IsTrue(IwEmailAddress.Text.Equals("Email Address is invalid. Please re-enter."), "Actual error message to verify jewelry value: " + IwEmailAddress.Text);
            Console.WriteLine("----QuotePage error message validation ----- complete------");
        }



        public void verifyErrorValidationMessages()
        {
            WaitUntilElementVisible(driver, By.Id("quoteInfoNext"));
            IWebElement IwZipCodePostalCode = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Zip/Postal Code is required.')]"));
            IWebElement IwJewelryType = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Jewelry Type is required.')]"));
            IWebElement IwJeweleryValue = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Jewelry Value is required.')]"));
            Console.WriteLine("----QuotePage error message validation ----- started------");
            Assert.IsTrue(IwZipCodePostalCode.Text.Equals("Zip/Postal Code is required."), "Actual error message to verify zip code: " + IwZipCodePostalCode.Text);
            Assert.IsTrue(IwJewelryType.Text.Equals("Jewelry Type is required."), "Actual error message to verify Jewelry Type: " + IwJewelryType.Text);
            Assert.IsTrue(IwJeweleryValue.Text.Equals("Jewelry Value is required."), "Actual error message to verify jewelry value: " + IwJeweleryValue.Text);
            Console.WriteLine("----QuotePage error message validation ----- complete------");
        }

        public void EnterZipCode(string Zipcode)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            //IList<IWebElement> Countylist;
            UIAction(editZipCode, Zipcode, "textbox");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab);
            action.Perform();
            action.Release();
            WaitUntilElementVisible(driver, By.XPath("//div[@class='jm-input-valid display-inline']"));
            ScenarioContext.Current["ZIPCODE"] = Zipcode;
            RegKey.SetValue("ZIPCODE", Zipcode);
        }



        public void AddanotherItem()
        {
            UIAction(linkAddanotherItem, string.Empty, "a");
        }

        public void AddPartnerDetails(string FirstName, string LastName, string Email)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            FirstName = FirstName + Unique.ID;
            FirstName = FirstName.Substring(1, 15);

            Console.WriteLine("Firts name is " + FirstName);
            RegKey.SetValue("FNAME", FirstName);
            LastName = LastName + Unique.ID;
            LastName = LastName.Substring(1, 15);

            RegKey.SetValue("LNAME", LastName);
            RegKey.SetValue("PRIMARY_INSURED", FirstName + " " + LastName);
            UIAction(txtAppfirstName, FirstName, "textbox");
            UIAction(txtApplastName, LastName, "textbox");
            if (Email.ToLower().Equals("unique"))
            {
                Email = Unique.ID + "@test-jminsure.com";
            }
            else if (Email.ToLower().Equals("regedit"))
            {
                DataStorage temp = new DataStorage();
                Email = temp.GetTempValue("EMAIL");
            }
            RegKey.SetValue("EMAIL", Email);
            UIAction(txtAppEmailaddress, Email, "textbox");
            //IWebElement IWApplicantPhoneNumber = driver.FindElement(By.XPath("//input[@id='QuotePhoneNumber']"));
            //IWApplicantPhoneNumber.Clear();
            //JavaScriptClick(IWApplicantPhoneNumber);
            //UIAction(txtAppPhonenumber, Phonenumber, "textbox");
        }

        public void AddJewelryItem(string JewelryType, string Value, int counter)
        {
            listJewelryType = "select[id$='jewelryTypeSelector']";
            editJewelryValue = "input[id$='jewelryValue']";
            //IList<IWebElement> listJewelryTypeTemp = driver.FindElements(By.CssSelector(listJewelryType)).ToList();
            //IList<IWebElement> editJewelryValueTemp = driver.FindElements(By.CssSelector(editJewelryValue)).ToList();
            //SelectByText(listJewelryTypeTemp[listJewelryTypeTemp.Count() - 1], JewelryType);

            //UIActionExt(listJewelryTypeTemp[listJewelryTypeTemp.Count()-1], "listbox", JewelryType);


            //Console.WriteLine("ListJew: {0}", listJewelryType);
            //Console.WriteLine("EditJew: {0}", editJewelryValue);
            UIAction(editJewelryValue, Value, "textbox");
            UIAction(listJewelryType, JewelryType, "selectbox");
        }

        public void click_Continue()
        {
            JavaScriptClick(driver.FindElement(By.XPath(buttonContinue)));
           // UIAction(buttonContinue, string.Empty, "a");

        }


        public void click_ApplyForCoverage(int Counter)
        {
            WaitUntilElementVisible(driver, By.Id("quoteResultsNext"));
            IWebElement btnApplyforCoverage = driver.FindElement(By.XPath("//a[@id ='quoteResultsNext']"));
            JavaScriptClick(btnApplyforCoverage);
            //if (Counter == 2)
            //{
            //    if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() != "stage")
            //    {
            //        IsElementPresent(driver, By.Id("noThanks"));
            //        pause();
            //        JavaScriptClick(driver.FindElement(By.Id("noThanks")));
            //        //  UIAction(linknoThanks, string.Empty, "a");
            //    }
            //}
        }

        //public string GetUniqueValue()
        //{
        //    DateTime myDateTime = DateTime.Now;
        //    string day = myDateTime.Day.ToString();
        //    string hour = myDateTime.Hour.ToString();
        //    string minute = myDateTime.Minute.ToString();
        //    string second = myDateTime.Second.ToString();
        //    string GetUniqueValue = day + hour + minute + second;
        //    return GetUniqueValue;
        //}

    }
}

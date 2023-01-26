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
using Microsoft.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelperClasses;

namespace BoltPages.Pages.QNA
{
    public class BOLTApplicantWearerPage : Page
    {
        private Dictionary<string, string> urlDictionary = new Dictionary<string, string>();
        string txtAppfirstName = "input[id$='ApplicantFirstName']";
        string txtApplastName = "input[id$='ApplicantLastName']";
        string txtAppaddress = "input[id$='ApplicantAddress']";
        string txtAppaptsuite = "input[id$='ApplicantApartmentSuite']";
        string txtAppcity = "input[id$='ApplicantCity']";
        string selectAppstate = "select[id$='ApplicantState']";
        string txtAppzipcode = "input[id$='ApplicantZipCode']";
        string checkMailingaddressissame = "input[id$='MailingAddressIsSame']";
        string txtAppPhonenumber = "input[id$='ApplicantPhoneNumber']";
        string txtAppEmailaddress = "input[id$='ApplicantEmailAddress']";
        string selectAppdobmonth = "select[id$='applicantDOBMonth']";
        string selectAppdobday = "select[id$='applicantDOBDay']";
        string selectAppdobyear = "select[id$='applicantDOBYear']";
        string radioAppGendermale = "input[id$='ApplicantGender-Male']";
        string radioAppGenderfemale = "input[id$='ApplicantGender-Female']";
        string radiowearernameitem1_0 = "input[id$='WearerName-Item#1-0']";
        string radiowearernameitem1_1 = "input[id$='WearerName-Item#1-1']";
        string radioConvictedofcrimeNo = "input[id$='ConvictedOfCrime-No']";
        string radioConvictedofcrimeMisdemeanor = "input[id$='ConvictedOfCrime-Misdemeanor']";
        string radioConvictedofcrimeFelony = "input[id$='ConvictedOfCrime-Felony']";
        string radioConvictedofcrimeBoth = "input[id$='ConvictedOfCrime-Misdemeanor & Felony']";
        string radioPriorlossexperiencedNo = "input[id$='PriorLossExperienced-No']";
        string radioPriorlossexperiencedYes = "input[id$='PriorLossExperienced-Yes']";
        string checkHasagreedtoterms = "input[id$='HasAgreedToTerms']";
        string btnAppWearerPageNext = "a[id$='applicantNext']";

        string txtMailingAddress = "input[id$='ApplicantMailingAddress']";
        string txtMailingApartment = "input[id$='ApplicantMailingApartmentSuite']";
        string txtMailingCity = "input[id$='ApplicantMailingCity']";
        string selectMailingstate = "select[id$='ApplicantMailingState']";
        string txtMailingZip = "input[id$='ApplicantMailingZipCode']";
        public BOLTApplicantWearerPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(txtAppfirstName);
        }

        public override void WaitForLoad()
        {
            //ApplicantFirstName
            WaitUntilElementVisible(driver, By.Id("ApplicantFirstName"));


        }

        public void verifyBOLTRetrievdContactInformation(string ApplicantFirstName, string ApplicantLastName, string ApplicantAddress, string ApplicantApartment, string ApplicantCity, string ApplicantState, string ApplicantZipCode, string ApplicantPhone, string ApplicantEmail)
        {
            WaitFor(driver.FindElement(By.XPath("//span[text()='To ensure accuracy, please review your entire application before submitting.']")));
            Console.WriteLine("I need to click on");
            IWebElement btnOKGotit = driver.FindElement(By.XPath("//button[text()='Ok, got it']"));
            btnOKGotit.Click();

            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            string CompleteAddress = "";
            IWebElement txtApplicantFirstName = driver.FindElement(By.XPath("//input[@id='ApplicantFirstName']"));
            IWebElement txtApplastName = driver.FindElement(By.XPath("//input[@id='ApplicantLastName']"));
            IWebElement txtAppaddress = driver.FindElement(By.XPath("//input[@id='ApplicantAddress']"));
            IWebElement txtAppaptsuite = driver.FindElement(By.XPath("//input[@id='ApplicantApartmentSuite']"));
            IWebElement txtAppcity = driver.FindElement(By.XPath("//input[@id='ApplicantCity']"));
            IWebElement selectAppstate = driver.FindElement(By.XPath("//select[@id='ApplicantState']"));
            IWebElement txtAppzipcode = driver.FindElement(By.XPath("//input[@id='ApplicantZipCode']"));
            IWebElement txtAppPhonenumber = driver.FindElement(By.XPath("//input[@id='ApplicantPhoneNumber']"));
            IWebElement txtAppEmailaddress = driver.FindElement(By.XPath("//input[@id='ApplicantEmailAddress']"));
            string Expected_Zip = "";
            CompleteAddress = CompleteAddress + ApplicantAddress;
            CompleteAddress = CompleteAddress + ApplicantApartment;
            CompleteAddress = CompleteAddress + ApplicantCity;

            comparevalue(ApplicantFirstName, txtApplicantFirstName.GetAttribute("value"), "ApplicantFirstName");
            comparevalue(ApplicantLastName, txtApplastName.GetAttribute("value"), "ApplicantLastName");
            comparevalue(ApplicantAddress, txtAppaddress.GetAttribute("value"), "ApplicantAddress");
            comparevalue(ApplicantApartment, txtAppaptsuite.GetAttribute("value"), "ApplicantApartment");
            comparevalue(ApplicantCity, txtAppcity.GetAttribute("value"), "ApplicantCity");
            if (txtAppzipcode.GetAttribute("value").Contains("-"))
            {
                string[] zip_list = txtAppzipcode.GetAttribute("value").Split('-');
                Expected_Zip = zip_list[0];
            }
            else
            {
                Expected_Zip = txtAppzipcode.GetAttribute("value");
            }
            comparevalue(ApplicantZipCode, Expected_Zip, "ApplicantZipCode");
            comparevalue(ApplicantPhone, txtAppPhonenumber.GetAttribute("value").Replace("(", "").Replace(")", "").Replace("-", ""), "ApplicantPhone");
            comparevalue(ApplicantEmail, txtAppEmailaddress.GetAttribute("value"), "ApplicantEmail");
            getState();
            //Console.WriteLine("Key is " + ApplicantState);
            string temp_State = urlDictionary[ApplicantState.ToUpper()];
            temp_State = ApplicantState.ToUpper();
            Console.WriteLine("value is " + temp_State);
            CompleteAddress = CompleteAddress + "," + temp_State;
            CompleteAddress = CompleteAddress + ApplicantZipCode;
            //  RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            CompleteAddress = CompleteAddress.Replace(" ", "");
            RegKey.SetValue("ACC_ADDRESS", CompleteAddress);
            Console.WriteLine("temp_State is " + temp_State);
            Console.WriteLine("selectAppstate.GetAttribute('value') is " + selectAppstate.Text);
            comparevalue(ApplicantState.ToUpper(), selectAppstate.GetAttribute("value"), "ApplicantState");

        }

        public void SetTheContactInformationForBOLT(string IsMailingAddressSame, string ApplicantContactPref, string AppDOB, string ApplicantGender)
        {
            string isMailingAddressIsSame_Checked;
            IWebElement IsChecked = driver.FindElement(By.CssSelector(checkMailingaddressissame));
            isMailingAddressIsSame_Checked = IsChecked.GetAttribute("checked");
            Console.WriteLine("value is : " + isMailingAddressIsSame_Checked);
            Console.WriteLine("Caption is : " + IsMailingAddressSame.ToLower().Trim());
            switch (IsMailingAddressSame.ToLower().Trim())
            {
                case "yes":
                    if (isMailingAddressIsSame_Checked == "false")
                    {
                        JavaScriptClick(IsChecked);
                        pause();
                    }
                    break;
                case "no":

                    if (isMailingAddressIsSame_Checked == "true")
                    {
                        pause();
                        JavaScriptClick(IsChecked);
                        pause();
                    }
                    break;
                default:
                    break;

            }

            switch (ApplicantContactPref.ToLower().Trim())
            {
                case "phone":
                    IWebElement IWSelectPhone = driver.FindElement(By.XPath("//input[@id='contactPreference-Phone']"));
                    JavaScriptClick(IWSelectPhone);
                    pause();
                    break;
                case "email":
                    IWebElement IWSelectEmail = driver.FindElement(By.XPath("//input[@id='contactPreference-Email']"));
                    JavaScriptClick(IWSelectEmail);
                    pause();
                    break;
                default:
                    break;

            }
            DateTime datevalue = (Convert.ToDateTime(AppDOB.ToString()));
            String DOB_Day = datevalue.Day.ToString();
            String DOB_Month = datevalue.Month.ToString();
            String DOB_Year = datevalue.Year.ToString();
            UIAction(selectAppdobmonth, DOB_Month, "selectbox");
            UIAction(selectAppdobday, DOB_Day, "selectbox");
            List<IWebElement> SelectDOBYear = driver.FindElements(By.CssSelector(selectAppdobyear)).ToList();
            SelectDOBYear[0].Click();
            SelectByText(SelectDOBYear[0], DOB_Year);


            pause();
            //UIAction(selectAppdobyear, DOB_Year, "selectbox");
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

        public void getPrimaryContact()
        {
            IWebElement txtApplicantFirstName = driver.FindElement(By.XPath("//input[@id='ApplicantFirstName']"));
            IWebElement txtApplastName = driver.FindElement(By.XPath("//input[@id='ApplicantLastName']"));
            IWebElement txtAppPhonenumber = driver.FindElement(By.XPath("//input[@id='ApplicantPhoneNumber']"));
            IWebElement txtAppEmailaddress = driver.FindElement(By.XPath("//input[@id='ApplicantEmailAddress']"));
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            IWebElement txtAppaddress = driver.FindElement(By.XPath("//input[@id='ApplicantAddress']"));
            IWebElement txtAppaptsuite = driver.FindElement(By.XPath("//input[@id='ApplicantApartmentSuite']"));
            IWebElement txtAppcity = driver.FindElement(By.XPath("//input[@id='ApplicantCity']"));
            IWebElement selectAppstate = driver.FindElement(By.XPath("//select[@id='ApplicantState']"));
            IWebElement txtAppzipcode = driver.FindElement(By.XPath("//input[@id='ApplicantZipCode']"));

            string CompleteAddress= "";
            CompleteAddress = CompleteAddress + txtAppaddress.GetAttribute("value").Trim();
            CompleteAddress = CompleteAddress + txtAppaptsuite.GetAttribute("value").Trim();
            CompleteAddress = CompleteAddress + txtAppcity.GetAttribute("value").Trim();
            CompleteAddress = CompleteAddress + "," + selectAppstate.GetAttribute("value").Trim();
            string Expected_Zip = "";

            if (txtAppzipcode.GetAttribute("value").Contains("-"))
            {
                string[] zip_list = txtAppzipcode.GetAttribute("value").Split('-');
                Expected_Zip = zip_list[0];
            }
            else
            {
                Expected_Zip = txtAppzipcode.GetAttribute("value");
            }
            CompleteAddress = CompleteAddress + Expected_Zip;

              CompleteAddress = CompleteAddress.Replace(" ", "");
            RegKey.SetValue("ACC_ADDRESS", CompleteAddress);
            RegKey.SetValue("PRIMARY_INSURED", txtApplicantFirstName.GetAttribute("value").Trim() + " " + txtApplastName.GetAttribute("value").Trim());
            RegKey.SetValue("PHONE", txtAppPhonenumber.GetAttribute("value").Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ",""));
            RegKey.SetValue("EMAIL", txtAppEmailaddress.GetAttribute("value").Trim());
        }
        public void getState()
        {


            urlDictionary.Add("AL", "Alabama");
            urlDictionary.Add("AK", "Alaska");
            urlDictionary.Add("AZ", "Arizona");
            urlDictionary.Add("AR", "Arkansas");
            urlDictionary.Add("CA", "California");
            urlDictionary.Add("CO", "Colorado");
            urlDictionary.Add("CT", "Connecticut");
            urlDictionary.Add("DE", "Delaware");
            urlDictionary.Add("FL", "Florida");
            urlDictionary.Add("GA", "Georgia");
            urlDictionary.Add("HI", "Hawaii");
            urlDictionary.Add("ID", "Idaho");
            urlDictionary.Add("IL", "Illinois");
            urlDictionary.Add("IN", "Indiana");
            urlDictionary.Add("IA", "Iowa");
            urlDictionary.Add("KS", "Kansas");
            urlDictionary.Add("KY", "Kentucky");
            urlDictionary.Add("LA", "Louisiana");
            urlDictionary.Add("ME", "Maine");
            urlDictionary.Add("MD", "Maryland");
            urlDictionary.Add("MA", "Massachusetts");
            urlDictionary.Add("MI", "Michigan");
            urlDictionary.Add("MN", "Minnesota");
            urlDictionary.Add("MS", "Mississippi");
            urlDictionary.Add("MO", "Missouri");
            urlDictionary.Add("MT", "Montana");
            urlDictionary.Add("NE", "Nebraska");
            urlDictionary.Add("NV", "Nevada");
            urlDictionary.Add("NH", "New Hampshire");
            urlDictionary.Add("NJ", "New Jersey");
            urlDictionary.Add("NM", "New Mexico");
            urlDictionary.Add("NY", "New York");
            urlDictionary.Add("NC", "North Carolina");
            urlDictionary.Add("ND", "North Dakota");
            urlDictionary.Add("OH", "Ohio");
            urlDictionary.Add("OK", "Oklahoma");
            urlDictionary.Add("OR", "Oregon");
            urlDictionary.Add("PA", "Pennsylvania");
            urlDictionary.Add("RI", "Rhode Island");
            urlDictionary.Add("SC", "South Carolina");
            urlDictionary.Add("SD", "South Dakota");
            urlDictionary.Add("TN", "Tennessee");
            urlDictionary.Add("TX", "Texas");
            urlDictionary.Add("UT", "Utah");
            urlDictionary.Add("VT", "Vermont");
            urlDictionary.Add("VA", "Virginia");
            urlDictionary.Add("WA", "Washington");
            urlDictionary.Add("WV", "West Virginia");
            urlDictionary.Add("WI", "Wisconsin");
            urlDictionary.Add("WY", "Wyoming");
            //Canada States:
            urlDictionary.Add("AB", "Alberta");
            urlDictionary.Add("BC", "British Columbia");
            urlDictionary.Add("MB", "Manitoba");
            urlDictionary.Add("NB", "New Brunswick");
            urlDictionary.Add("NL", "Newfoundland and Labrador");
            urlDictionary.Add("NT", "Northwest Territories");
            urlDictionary.Add("NS", "Nova Scotia");
            urlDictionary.Add("NU", "Nunavut");
            urlDictionary.Add("ON", "Ontario");
            urlDictionary.Add("PE", "Prince Edward Island");
            urlDictionary.Add("QC", "Quebec");
            urlDictionary.Add("SK", "Saskatchewan");
            urlDictionary.Add("YT", "Yukon");
        }



        public void comparevalue(string expectedvalue, string actualvalue, string paramater)
        {
            if (expectedvalue.Length > 0)
            {
                if (expectedvalue.ToLower().Trim().Equals(actualvalue.ToLower().Trim()))
                {
                    System.Console.WriteLine("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " matches");
                }
                else
                {
                    System.Console.WriteLine("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " do not matches");
                    Assert.Fail("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " do not matches");
                }
            }

        }


    }
}

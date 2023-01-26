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

namespace QuoteAndApplyPages.Pages.QNA
{
    public class ApplicantWearerPage : Page
    {
        public Dictionary<string, string> urlDictionary = new Dictionary<string, string>();
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
        public ApplicantWearerPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 200);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtAppfirstName);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("ApplicantFirstName"));

        }

        public void verifyErrorValidationMessages()
        {
            WaitUntilElementVisible(driver, By.Id("ApplicantFirstName"));

            IWebElement IwFirstName = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'First Name is required.')]"));
            IWebElement IwLastName = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Last Name is required.')]"));
            IWebElement IwAddress = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Address is required.')]"));
            IWebElement IwCity = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'City is required.')]"));
            IWebElement IwPhoneNumber = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Phone Number is required.')]"));

            //IWebElement IwContactPref = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Contact Preference is required.')]"));
            IWebElement IwDate = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Please enter a valid date.')]"));
            IWebElement IwGender = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Gender is required.')]"));
            IWebElement IwWearer = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Please select a wearer for this item.')]"));
            List<IWebElement> IwConvCrimeLossTheft = driver.FindElements(By.XPath("//span[@class='validationMessage'] [contains(text(),'This question is required.')]")).ToList();
            IWebElement IwInfoPrivacy = driver.FindElement(By.XPath("//span[@data-bind='validationMessage: hasAgreedToTerms']"));
            string sInfoPrivacy = (string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[arguments[1]].textContent;", IwInfoPrivacy, 0);
            Console.WriteLine("---Applicant Wearer Page error message validation ----- started------");
            Assert.IsTrue(IwFirstName.Text.Equals("First Name is required."), "Actual error message to verify First Name: " + IwFirstName.Text);
            Assert.IsTrue(IwLastName.Text.Equals("Last Name is required."), "Actual error message to verify Last Name: " + IwLastName.Text);
            Assert.IsTrue(IwAddress.Text.Equals("Address is required."), "Actual error message to verify Address: " + IwAddress.Text);
            Assert.IsTrue(IwCity.Text.Equals("City is required."), "Actual error message to verify City: " + IwCity.Text);
            Assert.IsTrue(IwPhoneNumber.Text.Equals("Phone Number is required."), "Actual error message to verify Phone Number: " + IwPhoneNumber.Text);

            //Assert.IsTrue(IwContactPref.Text.Equals("Contact Preference is required."), "Actual error message to verify Contact Preference: " + IwContactPref.Text);
            Assert.IsTrue(IwDate.Text.Equals("Please enter a valid date."), "Actual error message to verify Date: " + IwDate.Text);
            Assert.IsTrue(IwGender.Text.Equals("Gender is required."), "Actual error message to verify Gender: " + IwGender.Text);
            Assert.IsTrue(IwWearer.Text.Equals("Please select a wearer for this item."), "Actual error message to verify wearer: " + IwWearer.Text);
            Assert.IsTrue(IwConvCrimeLossTheft[0].Text.Equals("This question is required."), "Actual error message to verify Convicted Crime: " + IwConvCrimeLossTheft[0].Text);
            Assert.IsTrue(IwConvCrimeLossTheft[1].Text.Equals("This question is required."), "Actual error message to verify Loss Theft: " + IwConvCrimeLossTheft[1].Text);
            Console.WriteLine(ScenarioContext.Current["Application"].ToString().ToLower().Trim());
            switch ("WHat is this " + ScenarioContext.Current["Application"].ToString().ToLower().Trim())
            {
                case "QNA":
                case "QAGGS":
                case "QG":
                case "QP":
                case "PP":
                case "QABUNG":
                case "QABBT":
                    IWebElement IwEmailAddress = driver.FindElement(By.XPath("//span[@class='validationMessage'] [contains(text(),'Email Address is required.')]"));
                    Assert.IsTrue(IwEmailAddress.Text.Equals("Email Address is required."), "Actual error message to verify Email: " + IwEmailAddress.Text);
                    break;
                default:
                    break;
            }

            if (sInfoPrivacy != "You must agree to Jewelers Mutual Group's Terms of Use and Privacy Policy before you can continue.")
            {
                Assert.Fail("Actual error message to verify hasAgreedToTerms: " + sInfoPrivacy);
            }
            Console.WriteLine("----Applicant Wearer Page error message validation ----- complete------");
        }
        public void ApplicantMaillingAddress(string Address, string Apt, string City, string State, string Zip)
        {
            UIAction(txtMailingAddress, Address, "textbox");
            UIAction(txtMailingApartment, Apt, "textbox");
            UIAction(txtMailingCity, City, "textbox");
            UIAction(txtMailingZip, Zip, "textbox");
            UIAction(selectMailingstate, State, "selectbox");
        }
        public void EnterYourContactInformation(string ApplicantFirstName, string ApplicantLastName, string ApplicantAddress, string ApplicantApartment, string ApplicantCity, string ApplicantState, string ApplicantZipCode, string IsMailingAddressSame, string ApplicantPhone, string ApplicantEmail, string ApplicantContactPref, string AppDOB, string ApplicantGender)
        {
            string isMailingAddressIsSame_Checked;
            string CompleteAddress = "";
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            RegistryKey LNameRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            if (!(ApplicantFirstName.ToUpper().Equals("REGISTRY")))
            {
                ApplicantFirstName = ApplicantFirstName + Unique.ID;
                ApplicantFirstName = ApplicantFirstName.Substring(0, ApplicantFirstName.Length - 20);
                ApplicantFirstName = ApplicantFirstName.Replace(" ", "");
                RegKey.SetValue("FNAME", ApplicantFirstName);
                ApplicantLastName = ApplicantLastName + Unique.ID;
                ApplicantLastName = ApplicantLastName.Substring(0, ApplicantLastName.Length - 20);
                ApplicantLastName = ApplicantLastName.Replace(" ", "");
                RegKey.SetValue("LNAME", ApplicantLastName);
                RegKey.SetValue("PRIMARY_INSURED", ApplicantFirstName + " " + ApplicantLastName);
            }
            else
            {
                DataStorage temp = new DataStorage();
                if (ApplicantFirstName.ToUpper().Equals("REGISTRY"))
                {
                    ApplicantFirstName = temp.GetTempValue("FNAME");
                    ApplicantFirstName = ApplicantFirstName.Replace(" ", "");
                    ApplicantLastName = temp.GetTempValue("LNAME");
                    ApplicantLastName = ApplicantLastName.Replace(" ", "");
                    RegKey.SetValue("FNAME", ApplicantFirstName);
                    RegKey.SetValue("LNAME", ApplicantLastName);
                    RegKey.SetValue("PRIMARY_INSURED", ApplicantFirstName + " " + ApplicantLastName);
                }

            }

            UIAction(txtAppfirstName, ApplicantFirstName, "textbox");
            UIAction(txtApplastName, ApplicantLastName, "textbox");
            UIAction(txtAppaddress, ApplicantAddress, "textbox");
            CompleteAddress = ApplicantAddress;
            UIAction(txtAppaptsuite, ApplicantApartment, "textbox");
            CompleteAddress = CompleteAddress + ApplicantApartment;
            UIAction(txtAppcity, ApplicantCity, "textbox");
            CompleteAddress = CompleteAddress + ApplicantCity;
            UIAction(selectAppstate, ApplicantState, "selectbox");
            getState();
            string temp_State = urlDictionary[ApplicantState];
            CompleteAddress = CompleteAddress + "," + temp_State;
            //ACC_ADDRESS

            IWebElement ClearZipCode = driver.FindElement(By.CssSelector(txtAppzipcode));
            ClearZipCode.Clear();
            //UIAction(txtAppzipcode, "", "textbox");
            UIAction(txtAppzipcode, ApplicantZipCode, "textbox");
            RegKey.SetValue("ZIPCODE", ApplicantZipCode);

            IWebElement IsChecked = driver.FindElement(By.CssSelector(checkMailingaddressissame));
            isMailingAddressIsSame_Checked = IsChecked.GetAttribute("checked");
            Console.WriteLine("value is : " + isMailingAddressIsSame_Checked);
            Console.WriteLine("Caption is : " + IsMailingAddressSame.ToLower().Trim());

            CompleteAddress = CompleteAddress + "" + ApplicantZipCode;
            CompleteAddress = CompleteAddress.Replace(" ", "");

            RegKey.SetValue("ACC_ADDRESS", CompleteAddress);
            switch (IsMailingAddressSame.ToLower().Trim())
            {
                case "yes":
                    if (isMailingAddressIsSame_Checked == "false")
                    {
                        JavaScriptClick(IsChecked);
                    }
                    break;
                case "no":

                    if (isMailingAddressIsSame_Checked == "true")
                    {
                        JavaScriptClick(IsChecked);
                    }
                    break;
                default:
                    break;

            }
            IWebElement IWApplicantPhoneNumber = driver.FindElement(By.XPath("//input[@id='ApplicantPhoneNumber']"));
            IWApplicantPhoneNumber.Clear();
            JavaScriptClick(IWApplicantPhoneNumber);
            UIAction(txtAppPhonenumber, ApplicantPhone, "textbox");
            if (ApplicantEmail.ToLower().Contains("unique"))
            {
                ApplicantEmail = Unique.ID + "@apptest.jminsure.com";
            }
            else if (ApplicantEmail.ToLower().Equals("regedit"))
            {
                DataStorage temp = new DataStorage();
                ApplicantEmail = temp.GetTempValue("EMAIL");
            }
            RegKey.SetValue("EMAIL", ApplicantEmail);
            UIAction(txtAppEmailaddress, ApplicantEmail, "textbox");

            DateTime datevalue = (Convert.ToDateTime(AppDOB.ToString()));
            String DOB_Day = datevalue.Day.ToString();
            String DOB_Month = datevalue.Month.ToString();
            String DOB_Year = datevalue.Year.ToString();
            UIAction(selectAppdobmonth, DOB_Month, "selectbox");
            UIAction(selectAppdobday, DOB_Day, "selectbox");
            List<IWebElement> SelectDOBYear = driver.FindElements(By.CssSelector(selectAppdobyear)).ToList();
            SelectDOBYear[0].Click();
            SelectByText(SelectDOBYear[0], DOB_Year);

            switch (ApplicantGender.ToLower().Trim())
            {
                case "male":
                    UIAction(radioAppGendermale, string.Empty, "span");
                    break;
                case "female":
                    UIAction(radioAppGenderfemale, string.Empty, "span");
                    break;
                default:
                    break;
            }
        }
        public void WhowillwearthejeweleryItems(string ApplicantWearer)
        {
            switch (ApplicantWearer.ToLower().Trim())
            {
                case "primaryapplicant":
                    UIAction(radiowearernameitem1_1, string.Empty, "span");
                    break;
                case "wearer":
                    UIAction(radiowearernameitem1_0, string.Empty, "span");
                    break;
                default:
                    break;
            }
        }

        public void WhowillwearthejeweleryItemsforBOLT(Table table)
        {
            int iteration = 1;
            int Deatailsiteration = 1;
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string WearerType = ExpValues[0];
                string FirstName = ExpValues[1];
                string LastName = ExpValues[2];
                string AddressAsPriApp = ExpValues[3];
                string Address = ExpValues[4];
                string AptSuite = ExpValues[5];
                string City = ExpValues[6];
                string StateProv = ExpValues[7];
                string ZipCode = ExpValues[8];
                string PhoneNumber = ExpValues[9];
                string Email = ExpValues[10];
                string DOB = ExpValues[11];
                string Relationship = ExpValues[12];
                string Gender = ExpValues[13];
                DataStorage temp = new DataStorage();
                string isAddressSameAsApplicant_Checked;
                Console.WriteLine("Iteration: " + iteration);
                Console.WriteLine(WearerType.ToLower().Trim());

                switch (WearerType.ToLower().Trim())
                {
                    case "primaryapplicant":
                        string PRIMARY_INSURED = temp.GetTempValue("PRIMARY_INSURED");
                        Console.WriteLine(PRIMARY_INSURED);
                        List<IWebElement> IWClickApplicant = driver.FindElements(By.XPath("//i[text()='" + PRIMARY_INSURED + "']")).ToList();
                        JavaScriptClick(IWClickApplicant[iteration - 1]);
                        break;
                    case "wearer":
                        Deatailsiteration++;
                        string checkAddressSameAsApplicant = "input[id$='WearerAddressIsSame-" + Deatailsiteration + "']";
                        List<IWebElement> Id_text = driver.FindElements(By.XPath("//input[@id[contains(.,'WearerName-Item#')]]")).ToList();
                        Id_text[Id_text.Count() - 1].Click();
                        UIAction("input[id$='FirstNameWearer-" + Deatailsiteration + "']", FirstName, "textbox");
                        UIAction("input[id$='LastNameWearer-" + Deatailsiteration + "']", LastName, "textbox");
                        WaitUntilElementVisible(driver, By.Id("WearerAddressIsSame-" + Deatailsiteration));
                        IWebElement IsChecked = driver.FindElement(By.CssSelector(checkAddressSameAsApplicant));
                        isAddressSameAsApplicant_Checked = IsChecked.GetAttribute("checked");
                        Console.WriteLine("value of checked is " + isAddressSameAsApplicant_Checked);
                        switch (AddressAsPriApp.ToLower().Trim())
                        {
                            case "yes":
                                if (isAddressSameAsApplicant_Checked == "false")
                                {
                                    Console.WriteLine("Valus is false");
                                    UIAction(checkAddressSameAsApplicant, string.Empty, "a");
                                }
                                break;
                            case "no":
                                if (isAddressSameAsApplicant_Checked == "true")
                                {
                                    Console.WriteLine("Valus is true");
                                    IWebElement UnCheckAddressSame = driver.FindElement(By.XPath("//input[@id='WearerAddressIsSame-" + Deatailsiteration + "']"));
                                    JavaScriptClick(UnCheckAddressSame);
                                }
                                WaitUntilElementVisible(driver, By.Id("AddressWearer-" + Deatailsiteration));
                                UIAction("input[id$='AddressWearer-" + Deatailsiteration + "']", Address, "textbox");
                                UIAction("input[id$='ApartmentWearer-" + Deatailsiteration + "']", AptSuite, "textbox");
                                UIAction("input[id$='CityWearer-" + Deatailsiteration + "']", City, "textbox");
                                UIAction("select[id$='StateWearer-" + Deatailsiteration + "']", StateProv, "selectbox");
                                UIAction("input[id$='ZipCodeWearer-" + Deatailsiteration + "']", ZipCode, "textbox");
                                break;
                            default:
                                break;
                        }

                        IWebElement IWApplicantPhoneNumber = driver.FindElement(By.XPath("//input[@id='PhoneNumberWearer-" + Deatailsiteration + "']"));
                        IWApplicantPhoneNumber.Clear();
                        JavaScriptClick(IWApplicantPhoneNumber);
                        UIAction("input[id$='PhoneNumberWearer-" + Deatailsiteration + "']", PhoneNumber, "textbox");
                        UIAction("input[id$='EmailWearer-" + Deatailsiteration + "']", Email, "textbox");
                        DateTime datevalue = (Convert.ToDateTime(DOB.ToString()));
                        String DOB_Day = datevalue.Day.ToString();
                        String DOB_Month = datevalue.Month.ToString();
                        String DOB_Year = datevalue.Year.ToString();
                        UIAction("select[id$='DateOfBirthMonthWearer-" + Deatailsiteration + "']", DOB_Month, "selectbox");
                        UIAction("select[id$='DateOfBirthDayWearer-" + Deatailsiteration + "']", DOB_Day, "selectbox");
                        List<IWebElement> SelectDOBYear = driver.FindElements(By.CssSelector("select[id$='DateOfBirthYearWearer-" + Deatailsiteration + "']")).ToList();
                        SelectDOBYear[0].Click();
                        SelectByText(SelectDOBYear[0], DOB_Year);
                        UIAction("select[id$='ApplicantRelationshipWearer-" + Deatailsiteration + "']", Relationship, "selectbox");
                        switch (Gender.ToLower().Trim())
                        {
                            case "male":
                                UIAction("input[id$='WearerGender-" + Deatailsiteration + "-Male']", string.Empty, "span");
                                break;
                            case "female":
                                UIAction("input[id$='WearerGender-" + Deatailsiteration + "-Female']", string.Empty, "span");
                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }
                iteration++;
            }
        }


        public void WhowillwearthejeweleryItems(Table table)
        {


            int iteration = 1;
            int Deatailsiteration = 1;
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string WearerType = ExpValues[0];
                string FirstName = ExpValues[1];
                string LastName = ExpValues[2];
                string AddressAsPriApp = ExpValues[3];
                string Address = ExpValues[4];
                string AptSuite = ExpValues[5];
                string City = ExpValues[6];
                string StateProv = ExpValues[7];
                string ZipCode = ExpValues[8];
                string PhoneNumber = ExpValues[9];
                string Email = ExpValues[10];
                string DOB = ExpValues[11];
                string Relationship = ExpValues[12];
                string Gender = ExpValues[13];

                string isAddressSameAsApplicant_Checked;
                Console.WriteLine("Iteration: " + iteration);
                Console.WriteLine(WearerType.ToLower().Trim());
                switch (WearerType.ToLower().Trim())
                {

                    case "primaryapplicant":
                        IWebElement IWClickApplicant = driver.FindElement(By.XPath("//input[@id='WearerName-Item#" + iteration + "-1']"));
                        JavaScriptClick(IWClickApplicant);
                        break;
                    case "wearer":
                        Deatailsiteration++;
                        string checkAddressSameAsApplicant = "input[id$='WearerAddressIsSame-" + Deatailsiteration + "']";
                        UIAction("input[id$='WearerName-Item#" + iteration + "-0']", string.Empty, "span");
                        UIAction("input[id$='FirstNameWearer-" + Deatailsiteration + "']", FirstName, "textbox");
                        UIAction("input[id$='LastNameWearer-" + Deatailsiteration + "']", LastName, "textbox");

                        WaitUntilElementVisible(driver, By.Id("WearerAddressIsSame-" + Deatailsiteration));

                        IWebElement IsChecked = driver.FindElement(By.CssSelector(checkAddressSameAsApplicant));
                        isAddressSameAsApplicant_Checked = IsChecked.GetAttribute("checked");
                        Console.WriteLine("value of checked is " + isAddressSameAsApplicant_Checked);
                        switch (AddressAsPriApp.ToLower().Trim())
                        {
                            case "yes":
                                if (isAddressSameAsApplicant_Checked == "false")
                                {
                                    Console.WriteLine("Valus is false");
                                    UIAction(checkAddressSameAsApplicant, string.Empty, "a");
                                }
                                break;
                            case "no":
                                if (isAddressSameAsApplicant_Checked == "true")
                                {
                                    Console.WriteLine("Valus is true");
                                    IWebElement UnCheckAddressSame = driver.FindElement(By.XPath("//input[@id='WearerAddressIsSame-" + Deatailsiteration + "']"));
                                    JavaScriptClick(UnCheckAddressSame);
                                }
                                WaitUntilElementVisible(driver, By.Id("AddressWearer-" + Deatailsiteration));
                                UIAction("input[id$='AddressWearer-" + Deatailsiteration + "']", Address, "textbox");
                                UIAction("input[id$='ApartmentWearer-" + Deatailsiteration + "']", AptSuite, "textbox");
                                UIAction("input[id$='CityWearer-" + Deatailsiteration + "']", City, "textbox");
                                UIAction("select[id$='StateWearer-" + Deatailsiteration + "']", StateProv, "selectbox");
                                UIAction("input[id$='ZipCodeWearer-" + Deatailsiteration + "']", ZipCode, "textbox");
                                break;
                            default:
                                break;
                        }

                        IWebElement IWApplicantPhoneNumber = driver.FindElement(By.XPath("//input[@id='PhoneNumberWearer-" + Deatailsiteration + "']"));
                        IWApplicantPhoneNumber.Clear();
                        JavaScriptClick(IWApplicantPhoneNumber);
                        UIAction("input[id$='PhoneNumberWearer-" + Deatailsiteration + "']", PhoneNumber, "textbox");
                        UIAction("input[id$='EmailWearer-" + Deatailsiteration + "']", Email, "textbox");
                        DateTime datevalue = (Convert.ToDateTime(DOB.ToString()));
                        String DOB_Day = datevalue.Day.ToString();
                        String DOB_Month = datevalue.Month.ToString();
                        String DOB_Year = datevalue.Year.ToString();
                        UIAction("select[id$='DateOfBirthMonthWearer-" + Deatailsiteration + "']", DOB_Month, "selectbox");
                        UIAction("select[id$='DateOfBirthDayWearer-" + Deatailsiteration + "']", DOB_Day, "selectbox");
                        List<IWebElement> SelectDOBYear = driver.FindElements(By.CssSelector("select[id$='DateOfBirthYearWearer-" + Deatailsiteration + "']")).ToList();
                        SelectDOBYear[0].Click();
                        SelectByText(SelectDOBYear[0], DOB_Year);
                        UIAction("select[id$='ApplicantRelationshipWearer-" + Deatailsiteration + "']", Relationship, "selectbox");
                        switch (Gender.ToLower().Trim())
                        {
                            case "male":
                                UIAction("input[id$='WearerGender-" + Deatailsiteration + "-Male']", string.Empty, "span");
                                break;
                            case "female":
                                UIAction("input[id$='WearerGender-" + Deatailsiteration + "-Female']", string.Empty, "span");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                iteration++;
            }
        }

        public void EnterSentenceCompltionDetailes(string Date, string Conviction)
        {
            UIAction("input[id$='SentenceCompletionDate']", Date, "textbox");
            UIAction("select[id$='ConvictionType']", Conviction, "selectbox");
        }


        public void AddanotherLoss()
        {
            UIAction("a[id$='AddLossHistoryEvent']", string.Empty, "a");
        }

        public void EnterLossDetailes(string LossDate, string LossType, string LossAmount, int counter)
        {
            string txtLossDate = "input[id$='LossDate-" + counter + "']";
            string selectLossType = "select[id$='LossType-" + counter + "']";
            string txtLossAmount = "input[id$='LossAmount-" + counter + "']";
            UIAction(txtLossDate, LossDate, "textbox");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab);
            action.Perform();
            action.Release();
            UIAction(selectLossType, LossType, "selectbox");
            UIAction(txtLossAmount, LossAmount, "textbox");
            pause();
        }

        public void InTheLastTenYears(string ConvictedOfCrime, string PriorLossExperienced)
        {
            switch (ConvictedOfCrime.ToLower().Trim())
            {
                case "no":
                    UIAction(radioConvictedofcrimeNo, string.Empty, "span");
                    break;
                case "misdemeanor":
                    UIAction(radioConvictedofcrimeMisdemeanor, string.Empty, "span");
                    break;
                case "felony":
                    UIAction(radioConvictedofcrimeFelony, string.Empty, "span");
                    break;
                case "both":
                    UIAction(radioConvictedofcrimeBoth, string.Empty, "span");
                    break;
                default:
                    break;
            }

            switch (PriorLossExperienced.ToLower().Trim())
            {
                case "no":
                    UIAction(radioPriorlossexperiencedNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioPriorlossexperiencedYes, string.Empty, "span");
                    break;
                default:
                    break;

            }
        }
        public void ImpInfocheckox()
        {
            UIAction(checkHasagreedtoterms, string.Empty, "a");
        }
        public void ClickOnApplicantPageNextButton()
        {
            UIAction(btnAppWearerPageNext, string.Empty, "a");
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


        public void EnterYourContactInformationPartnerMode(string ApplicantAddress, string ApplicantApartment, string ApplicantCity, string ApplicantState, string ApplicantZipCode, string IsMailingAddressSame, string ApplicantContactPref, string AppDOB, string ApplicantGender)
        {
            string isMailingAddressIsSame_Checked;
            string CompleteAddress = "";
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            UIAction(txtAppaddress, ApplicantAddress, "textbox");
            CompleteAddress = ApplicantAddress;
            UIAction(txtAppaptsuite, ApplicantApartment, "textbox");
            CompleteAddress = CompleteAddress + ApplicantApartment;
            UIAction(txtAppcity, ApplicantCity, "textbox");
            CompleteAddress = CompleteAddress + ApplicantCity;
            UIAction(selectAppstate, ApplicantState, "selectbox");
            getState();
            string temp_State = urlDictionary[ApplicantState];
            CompleteAddress = CompleteAddress + "," + temp_State;
            IWebElement ClearZipCode = driver.FindElement(By.CssSelector(txtAppzipcode));
            ClearZipCode.Clear();
            UIAction(txtAppzipcode, ApplicantZipCode, "textbox");
            IWebElement IsChecked = driver.FindElement(By.CssSelector(checkMailingaddressissame));
            isMailingAddressIsSame_Checked = IsChecked.GetAttribute("checked");
            Console.WriteLine("value is : " + isMailingAddressIsSame_Checked);
            Console.WriteLine("Caption is : " + IsMailingAddressSame.ToLower().Trim());
            CompleteAddress = CompleteAddress + "" + ApplicantZipCode;
            CompleteAddress = CompleteAddress.Replace(" ", "");
            RegKey.SetValue("ACC_ADDRESS", CompleteAddress);
            switch (IsMailingAddressSame.ToLower().Trim())
            {
                case "yes":
                    if (isMailingAddressIsSame_Checked == "false")
                    {
                        JavaScriptClick(IsChecked);
                    }
                    break;
                case "no":

                    if (isMailingAddressIsSame_Checked == "true")
                    {
                        JavaScriptClick(IsChecked);
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
                    break;
                case "email":
                    IWebElement IWSelectEmail = driver.FindElement(By.XPath("//input[@id='contactPreference-Email']"));
                    JavaScriptClick(IWSelectEmail);
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


            switch (ApplicantGender.ToLower().Trim())
            {
                case "male":
                    UIAction(radioAppGendermale, string.Empty, "span");
                    break;
                case "female":
                    UIAction(radioAppGenderfemale, string.Empty, "span");
                    break;
                default:
                    break;
            }


        }
    }
}

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
using QuoteAndApplyPages.Pages.QNA;
using OpenQA.Selenium.Support.UI;

namespace QuoteAndApplyPages.Pages.SaveRetrieve
{
    public class RetrieveApplicantWearerPage : Page
    {
        public RetrieveApplicantWearerPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.Id("ApplicantFirstName"));
            WaitUntilElementEnabled(driver, By.Id("ApplicantFirstName"));
        }

        public void verifyRetrievdContactInformation(string ApplicantFirstName, string ApplicantLastName, string ApplicantAddress, string ApplicantApartment, string ApplicantCity, string ApplicantState, string ApplicantZipCode, string ApplicantPhone, string ApplicantEmail, string ApplicantContactPref, string AppDOB, string ApplicantGender)
        {


            IWebElement txtApplicantFirstName = driver.FindElement(By.XPath("//input[@id='ApplicantFirstName']"));
            IWebElement txtApplastName = driver.FindElement(By.XPath("//input[@id='ApplicantLastName']"));
            IWebElement txtAppaddress = driver.FindElement(By.XPath("//input[@id='ApplicantAddress']"));
            IWebElement txtAppaptsuite = driver.FindElement(By.XPath("//input[@id='ApplicantApartmentSuite']"));
            IWebElement txtAppcity = driver.FindElement(By.XPath("//input[@id='ApplicantCity']"));
            IWebElement selectAppstate = driver.FindElement(By.XPath("//select[@id='ApplicantState']"));
            IWebElement txtAppzipcode = driver.FindElement(By.XPath("//input[@id='ApplicantZipCode']"));
            IWebElement txtAppPhonenumber = driver.FindElement(By.XPath("//input[@id='ApplicantPhoneNumber']"));
            IWebElement txtAppEmailaddress = driver.FindElement(By.XPath("//input[@id='ApplicantEmailAddress']"));
            IWebElement selectAppdobmonth = driver.FindElement(By.XPath("//select[@id='applicantDOBMonth']"));
            IWebElement selectAppdobday = driver.FindElement(By.XPath("//select[@id='applicantDOBDay']"));
            IWebElement selectAppdobyear = driver.FindElement(By.XPath("//select[@id='applicantDOBYear']"));
            IWebElement radioAppGendermale = driver.FindElement(By.XPath("//input[@id='ApplicantGender-Male']"));
            IWebElement radioAppGenderfemale = driver.FindElement(By.XPath("//input[@id='ApplicantGender-Female']"));
            //IWebElement radioContactPrefrencePhone = driver.FindElement(By.XPath("//input[@id='contactPreference-Phone']"));
            //IWebElement radioContactPrefrenceEmail = driver.FindElement(By.XPath("//input[@id='contactPreference-Email']"));
            string Expected_Zip = "";
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
            ApplicantWearerPage PageState = new ApplicantWearerPage(driver);
            PageState.getState();
            string temp_State = PageState.urlDictionary[ApplicantState];

            // PageState.applicantStatePostalAbb(ApplicantState);
            comparevalue(temp_State, selectAppstate.GetAttribute("value"), "ApplicantState");
            DateTime datevalue = (Convert.ToDateTime(AppDOB.ToString()));
            String DOB_Day = datevalue.Day.ToString();
            String DOB_Month = datevalue.Month.ToString();
            String DOB_Year = datevalue.Year.ToString();
            comparevalue(DOB_Day, selectAppdobday.GetAttribute("value"), "ApplicantBirthDay");
            comparevalue(DOB_Month, selectAppdobmonth.GetAttribute("value"), "ApplicantBirthMonth");
            comparevalue(DOB_Year, selectAppdobyear.GetAttribute("value"), "ApplicantBirthYear");
            switch (ApplicantGender.ToLower().Trim())
            {
                case "male":
                    comparevalue("True", radioAppGendermale.GetAttribute("checked"), "ApplicantGenderMale");
                    break;
                case "female":
                    comparevalue("True", radioAppGenderfemale.GetAttribute("checked"), "ApplicantGenderFemale");
                    break;
                default:
                    break;
            }


            //switch (ApplicantContactPref.ToLower().Trim())
            //{
            //    case "phone":
            //        comparevalue("True", radioContactPrefrencePhone.GetAttribute("checked"), "ApplicantContactPrfrencePhone");
            //        break;
            //    case "email":
            //        comparevalue("True", radioContactPrefrenceEmail.GetAttribute("checked"), "ApplicantContactPrfrenceEmail");
            //        break;
            //    default:
            //        break;

            //}
        }


        public void verifyWhowillwearthejeweleryItems(Table table)
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
                string Expected_Zip;
                DataStorage temp = new DataStorage();
                string isAddressSameAsApplicant_Checked;
                Console.WriteLine("Iteration: " + iteration);
                Console.WriteLine(WearerType.ToLower().Trim());
                switch (WearerType.ToLower().Trim())
                {
                    case "primaryapplicant":

                        string PRIMARY_INSURED = temp.GetTempValue("PRIMARY_INSURED");
                        IWebElement IWClickApplicant = driver.FindElement(By.XPath("//i[text()='" + PRIMARY_INSURED + "']"));
                        Console.WriteLine("IWClickApplicant value " + IWClickApplicant.Text);
                        comparevalue(PRIMARY_INSURED, IWClickApplicant.Text, "Primaryapplicant");
                        break;
                    case "wearer":
                        int counter = 0;
                        List<IWebElement> Id_text = driver.FindElements(By.XPath("//input[@id[contains(.,'FirstNameWearer-')]]")).ToList();
                        Console.WriteLine("Count is " + Id_text.Count());
                        Console.WriteLine("Id_text value is for " + Id_text[counter].GetAttribute("id"));
                        string Deatailsiteration_Str = Id_text[counter].GetAttribute("id").Replace("FirstNameWearer-", "");
                        Deatailsiteration = Int32.Parse(Deatailsiteration_Str);
                        System.Console.WriteLine("id value is " + Deatailsiteration);
                        string checkAddressSameAsApplicant = "input[id$='WearerAddressIsSame-" + Deatailsiteration + "']";
                        IWebElement WearerFirstName = driver.FindElement(By.XPath("//input[@id='FirstNameWearer-" + Deatailsiteration + "']"));
                        comparevalue(FirstName, WearerFirstName.GetAttribute("value"), "WearerFirstName");
                        IWebElement WearerLastName = driver.FindElement(By.XPath("//input[@id='LastNameWearer-" + Deatailsiteration + "']"));
                        comparevalue(LastName, WearerLastName.GetAttribute("value"), "WearerLastName");
                        IWebElement IsChecked = driver.FindElement(By.CssSelector(checkAddressSameAsApplicant));
                        isAddressSameAsApplicant_Checked = IsChecked.GetAttribute("checked");

                        switch (AddressAsPriApp.ToLower().Trim())
                        {
                            case "yes":
                                comparevalue("true", IsChecked.GetAttribute("checked"), "AddressAsPriApp");
                                break;
                            case "no":

                                IWebElement WearerAddress = driver.FindElement(By.XPath("//input[@id='AddressWearer-" + Deatailsiteration + "']"));
                                comparevalue(Address, WearerAddress.GetAttribute("value"), "WearerAddress");
                                IWebElement WearerApartment = driver.FindElement(By.XPath("//input[@id='ApartmentWearer-" + Deatailsiteration + "']"));
                                comparevalue(AptSuite, WearerApartment.GetAttribute("value"), "WearerApartment");
                                IWebElement WearerCity = driver.FindElement(By.XPath("//input[@id='CityWearer-" + Deatailsiteration + "']"));
                                comparevalue(City, WearerCity.GetAttribute("value"), "WearerCity");
                                IWebElement WearerState = driver.FindElement(By.XPath("//select[@id='StateWearer-" + Deatailsiteration + "']"));
                                ApplicantWearerPage PageState = new ApplicantWearerPage(driver);
                                PageState.getState();
                                string temp_State = PageState.urlDictionary[StateProv];
                                //   string temp_State = PageState.applicantStatePostalAbb(StateProv);
                                comparevalue(temp_State, WearerState.GetAttribute("value"), "WearerState");
                                IWebElement WearerZipCode = driver.FindElement(By.XPath("//input[@id='ZipCodeWearer-" + Deatailsiteration + "']"));
                                if (WearerZipCode.GetAttribute("value").Contains("-"))
                                {
                                    string[] zip_list = WearerZipCode.GetAttribute("value").Split('-');
                                    Expected_Zip = zip_list[0];
                                }
                                else
                                {
                                    Expected_Zip = WearerZipCode.GetAttribute("value");
                                }
                                comparevalue(ZipCode, Expected_Zip, "WearerZipCode");
                                break;
                        }
                        IWebElement IWApplicantPhoneNumber = driver.FindElement(By.XPath("//input[@id='PhoneNumberWearer-" + Deatailsiteration + "']"));
                        comparevalue(PhoneNumber.Replace("-", ""), IWApplicantPhoneNumber.GetAttribute("value").Replace("-", ""), "IWApplicantPhoneNumber");
                        IWebElement IWApplicantEmail = driver.FindElement(By.XPath("//input[@id='EmailWearer-" + Deatailsiteration + "']"));
                        comparevalue(Email, IWApplicantEmail.GetAttribute("value"), "IWApplicantEmail");

                        DateTime datevalue = (Convert.ToDateTime(DOB.ToString()));
                        string DOB_Day = datevalue.Day.ToString();
                        string DOB_Month = datevalue.Month.ToString();
                        string DOB_Year = datevalue.Year.ToString();
                        IWebElement DateOfBirthMonthWearer = driver.FindElement(By.XPath("//select[@id='DateOfBirthMonthWearer-" + Deatailsiteration + "']"));
                        comparevalue(DOB_Month, DateOfBirthMonthWearer.GetAttribute("value"), "DOB_Month");
                        IWebElement DateOfBirthDayWearer = driver.FindElement(By.XPath("//select[@id='DateOfBirthDayWearer-" + Deatailsiteration + "']"));
                        comparevalue(DOB_Day, DateOfBirthDayWearer.GetAttribute("value"), "DOB_Day");
                        List<IWebElement> SelectDOBYear = driver.FindElements(By.CssSelector("select[id$='DateOfBirthYearWearer-" + Deatailsiteration + "']")).ToList();
                        comparevalue(DOB_Year, SelectDOBYear[0].GetAttribute("value"), "DOB_Year");
                        IWebElement WearerRelationship = driver.FindElement(By.XPath("//select[@id='ApplicantRelationshipWearer-" + Deatailsiteration + "']"));
                        SelectElement selectedValue = new SelectElement(WearerRelationship);
                        comparevalue(Relationship, selectedValue.Options[Int32.Parse(WearerRelationship.GetAttribute("value"))].Text, "Relationship");

                        switch (Gender.ToLower().Trim())
                        {
                            case "male":
                                IWebElement radioWearerGendermale = driver.FindElement(By.XPath("//input[@id='WearerGender-" + Deatailsiteration + "-Male']"));
                                comparevalue("True", radioWearerGendermale.GetAttribute("checked"), "WearerGenderMale");
                                break;
                            case "female":
                                IWebElement radioWearerGenderfemale = driver.FindElement(By.XPath("//input[@id='WearerGender-" + Deatailsiteration + "-Female']"));
                                comparevalue("True", radioWearerGenderfemale.GetAttribute("checked"), "WearerGenderFemale");
                                break;
                            default:
                                break;
                        }

                        counter++;
                        break;
                    default:
                        break;

                }
                iteration++;
            }
        }

        public void verifyQualificationQuestions(string ConvictedOfCrime, string PriorLossExperienced)
        {
            switch (ConvictedOfCrime.ToLower().Trim())
            {
                case "no":
                    IWebElement radioConvictedOfCrimeNo = driver.FindElement(By.XPath("//input[@id='ConvictedOfCrime-No']"));
                    comparevalue("True", radioConvictedOfCrimeNo.GetAttribute("checked"), "ConvictedOfCrimeNo");
                    break;
                case "misdemeanor":
                    IWebElement ConvictedOfCrimeMisdemeanor = driver.FindElement(By.XPath("//input[@id='ConvictedOfCrime-Misdemeanor']"));
                    comparevalue("True", ConvictedOfCrimeMisdemeanor.GetAttribute("checked"), "ConvictedOfCrimeMisdemeanor");
                    break;
                case "felony":
                    IWebElement ConvictedOfCrimeFelony = driver.FindElement(By.XPath("//input[@id='ConvictedOfCrime-Felony']"));
                    comparevalue("True", ConvictedOfCrimeFelony.GetAttribute("checked"), "ConvictedOfCrimeFelony");
                    break;
                case "both":
                    IWebElement ConvictedOfCrimeMisdemeanorFelony = driver.FindElement(By.XPath("//input[@id='ConvictedOfCrime-Misdemeanor & Felony']"));
                    comparevalue("True", ConvictedOfCrimeMisdemeanorFelony.GetAttribute("checked"), "ConvictedOfCrimeMisdemeanorFelony");
                    break;
                default:
                    break;
            }

            switch (PriorLossExperienced.ToLower().Trim())
            {
                case "no":
                    IWebElement PriorLossExperiencedNo = driver.FindElement(By.XPath("//input[@id='PriorLossExperienced-No']"));
                    comparevalue("True", PriorLossExperiencedNo.GetAttribute("checked"), "PriorLossExperiencedNo");
                    break;
                case "yes":
                    IWebElement PriorLossExperiencedYes = driver.FindElement(By.XPath("//input[@id='PriorLossExperienced-Yes']"));
                    comparevalue("True", PriorLossExperiencedYes.GetAttribute("checked"), "PriorLossExperiencedYes");
                    break;
                default:
                    break;

            }
        }

        public void verifySentenceCompltionDetailes(string Date, string Conviction)
        {
            IWebElement SentenceCompliationDate = driver.FindElement(By.XPath("//input[@id='SentenceCompletionDate']"));
            comparevalue(Date, SentenceCompliationDate.GetAttribute("value"), "SentenceCompliationDate");

            IWebElement ConvictionType = driver.FindElement(By.XPath("//select[@id='ConvictionType']"));
            SelectElement selectedValue = new SelectElement(ConvictionType);
            comparevalue(Conviction, selectedValue.Options[Int32.Parse(ConvictionType.GetAttribute("value"))].Text, "ConvictionType");

        }

        public void verifyLossDetailes(string LossDate, string LossType, string LossAmount, int counter)
        {
            IWebElement txtLossDate = driver.FindElement(By.XPath("//input[@id='LossDate-" + counter + "']"));
            comparevalue(LossDate, txtLossDate.GetAttribute("value"), "LossDate");
            IWebElement selectLossType = driver.FindElement(By.XPath("//select[@id='LossType-" + counter + "']"));
            SelectElement selectedValue = new SelectElement(selectLossType);
            comparevalue(LossType, selectedValue.Options[Int32.Parse(selectLossType.GetAttribute("value"))].Text, "LossType");
            IWebElement txtLossAmount = driver.FindElement(By.XPath("//input[@id='LossAmount-" + counter + "']"));
            comparevalue(LossAmount, txtLossAmount.GetAttribute("value"), "LossAmount");
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

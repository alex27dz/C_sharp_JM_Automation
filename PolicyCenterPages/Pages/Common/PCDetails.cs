using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;

namespace PolicyCenterPages.Pages.Common
{
    public class PCDetails : Page
    {
        string LinkPolicyNumber = "a[id$=':AccountFile_Summary_PolicyTermsLV:0:PolicyNumber']";
        string LinkWorkOrderNumber = "a[id$=':AccountFile_Summary_WorkOrdersLV:0:WorkOrderNumber']";

        string[] arrTblList;

        public PCDetails(IWebDriver driver) : base(driver)
        {
            pause();
            WaitForPageLoad(driver);
            SetActiveFrame();
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(logOut); 
        }

        public override void WaitForLoad()
        {
            //throw new NotImplementedException(); 
        }

        public void VerifyPolicyTerm(string PolicyNumber, string Status, string EffectiveDate)
        {

            pause();

            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_PolicyTermsLV:0:0")).ToList();
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            if (PolicyNumber.Length > 3)
            {
                if (arrTblList[0].ToString().Contains(PolicyNumber))
                {
                    Console.WriteLine("PolicyNumber  matches : Expected value  " + PolicyNumber + " Actual value " + PolicyNumber);
                }
                else
                {
                    Console.WriteLine("PolicyNumber do not  matches : Expected value  " + PolicyNumber + " Actual value " + arrTblList[0].ToString());
                    Assert.Fail("PolicyNumber  do not match : Expected value " + PolicyNumber + " Actual value " + arrTblList[0].ToString());

                }
            }

            if (arrTblList[0].ToString().Contains(Status))
            {
                Console.WriteLine("Status  matches : Expected value  " + Status + " Actual value " + Status);
            }
            else
            {
                Console.WriteLine("Status do not  matches : Expected value  " + Status + " Actual value " + arrTblList[0].ToString());
                //Assert.Fail("Status  do not match : Expected value " + Status + " Actual value " + arrTblList[0].ToString());
            }
            if (arrTblList[0].ToString().Contains(EffectiveDate))
            {
                Console.WriteLine("EffectiveDate  matches : Expected value  " + EffectiveDate + " Actual value " + EffectiveDate);

            }
            else
            {
                Console.WriteLine("EffectiveDate do not  matches : Expected value  " + EffectiveDate + " Actual value " + arrTblList[0].ToString());
                //Assert.Fail("EffectiveDate  do not match : Expected value " + EffectiveDate + " Actual value " + arrTblList[0].ToString());
            }


        }

        public void VerifyRightAccountDetails(string DistributionSource, string MethodofCommunication, string ApplicationTakenBy, string Paperless, string OktoSurvey, string MarketingMaterials, string ReceiveConfirmationEmails, string ProducerCode)
        {

            pause();
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:1")).ToList();
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < arrTblList.Count(); i++)
            {
                Console.WriteLine(i + " identifier " + arrTblList[i].ToString());
            }

            if (DistributionSource.Length > 2)
            {
                AccountDetailsComparision(DistributionSource, "Distribution Source", arrTblList);
            }
            if (MethodofCommunication.Length > 2)
            {
                AccountDetailsComparision(MethodofCommunication, "Preferred Method of Communication", arrTblList);
            }
            if (ApplicationTakenBy.Length > 2)
            {
                AccountDetailsComparision(ApplicationTakenBy, "Application Taken By", arrTblList);
            }
            if (Paperless.Length > 2)
            {
                AccountDetailsComparision(Paperless, "Paperless Delivery", arrTblList);
            }
            if (OktoSurvey.Length > 2)
            {
                AccountDetailsComparision(OktoSurvey, "Ok to Survey?", arrTblList);
            }
            if (MarketingMaterials.Length > 2)
            {
                AccountDetailsComparision(MarketingMaterials, "Marketing Materials?", arrTblList);
            }
            if (ReceiveConfirmationEmails.Length > 2)
            {
                AccountDetailsComparision(ReceiveConfirmationEmails, "Receive Confirmation Emails?", arrTblList);
            }
            if (ProducerCode.Length > 2)
            {
                AccountDetailsComparision(ProducerCode, "Producer Code", arrTblList);
            }
        }

        public void getDetailsforQuickClaim()
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");


            pause();
            int pos = 0;
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:0")).ToList();
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            for (int k = 0; k < arrTblList.Count(); k++)
            {
                Console.WriteLine(k + " " + arrTblList[k].ToString());
                if (arrTblList[k].ToString().Contains("Account Name"))
                {

                    Console.WriteLine(arrTblList[k].ToString());
                    pos = k;

                    String Actualvalue = arrTblList[pos].ToString();
                    Actualvalue = Actualvalue.Replace("Account Name", "");
                    Actualvalue = Actualvalue.Trim();

                    string[] Name = Actualvalue.Split(' ');
                    string lastname = Name[1];
                    RegKey.SetValue("LNAME", lastname);
                    Console.WriteLine("last name is " + lastname);
                }


                if (arrTblList[k].ToString().Contains("Address"))
                {
                    Console.WriteLine(arrTblList[k].ToString());
                    pos = k;
                    if ((arrTblList[pos + 2].ToString().Contains("County")))
                    {

                        String Actualvalue = arrTblList[pos + 1].ToString();
                        Actualvalue = Actualvalue.Trim();
                        string[] Address = Actualvalue.Split(' ');
                        string Zipcode = Address[Address.Count() - 1];
                        RegKey.SetValue("ZIPCODE", Zipcode);
                        Console.WriteLine("ZIPCODE is " + Zipcode);
                        break;
                    }
                    else
                    {

                        String Actualvalue = arrTblList[pos + 2].ToString();
                        Actualvalue = Actualvalue.Trim();
                        string[] Address = Actualvalue.Split(' ');
                        string Zipcode = Address[Address.Count() - 1];
                        RegKey.SetValue("ZIPCODE", Zipcode);
                        Console.WriteLine("ZIPCODE is " + Zipcode);
                        break;
                    }


                }


            }
            List<IWebElement> TablePolicyInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_PolicyTermsLV:0:0")).ToList();
            arrTblList = TablePolicyInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            string[] PolicyDetails = arrTblList[0].ToString().Split(' ');
            string PolicyNumber = PolicyDetails[0];
            RegKey.SetValue("PLCYNO", PolicyNumber);
            Console.WriteLine("Poloicy is " + PolicyNumber);








        }


        public void VerifyLeftAccountDetails(string PrimaryInsured, string Address, string PhonNo, string Email, string Status, string AddressType, string Gender, string Occupation, string DateofBirth)

        {


            pause();
            // for account details AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:0
            //List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV")).ToList();
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:0")).ToList();
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            for (int k = 0; k < arrTblList.Count(); k++)
            {
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
            }

            if (PrimaryInsured.Length > 2)
            {
                AccountDetailsComparision(PrimaryInsured, "Account Name", arrTblList);
            }
            if (DateofBirth.Length > 2)
            {
                AccountDetailsComparision(DateofBirth, "Date of Birth", arrTblList);
            }
            if (Address.Length > 2)
            {
                AccountDetailsComparision(Address, "Address", arrTblList);
            }
            if (PhonNo.Length > 2)
            {
                AccountDetailsComparision(PhonNo, "Phone Number", arrTblList);
            }
            if (Email.Length > 2)
            {
                AccountDetailsComparision(Email, "Email", arrTblList);
            }
            if (Status.Length > 2)
            {
                AccountDetailsComparision(Status, "Status", arrTblList);
            }
            if (AddressType.Length > 2)
            {
                AccountDetailsComparision(AddressType, "Address Type", arrTblList);
            }
            if (Gender.Length > 2)
            {
                AccountDetailsComparision(Gender, "Gender", arrTblList);
            }
            if (Occupation.Length > 2)
            {
                AccountDetailsComparision(Occupation, "Occupation", arrTblList);

            }












        }

        public void VerifyRightAccountDetailsQNA(string DistributionSource, string MethodofCommunication, string ApplicationTakenBy, string Paperless, string ProducerCode)
        {

            pause();
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:1")).ToList();
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < arrTblList.Count(); i++)
            {
                Console.WriteLine(i + " identifier " + arrTblList[i].ToString());
            }
            if (DistributionSource.Length > 1)
            {
                AccountDetailsComparision(DistributionSource, "Distribution Source", arrTblList);
            }
            if (MethodofCommunication.Length > 1)
            {
                AccountDetailsComparision(MethodofCommunication, "Preferred Method of Communication", arrTblList);
            }
            if (ApplicationTakenBy.Length > 1)
            {
                AccountDetailsComparision(ApplicationTakenBy, "Application Taken By", arrTblList);
            }
            if (Paperless.Length > 1)
            {
                AccountDetailsComparision(Paperless, "Paperless Delivery", arrTblList);
            }
            if (ProducerCode.Length > 1)
            {
                AccountDetailsComparision(ProducerCode, "Producer Code", arrTblList);
            }


        }

        public void AccountDetailsComparision(string ExpectedValue, string ParamName, string[] TempArray1)
        {
            int pos = 0;
            Console.WriteLine(TempArray1);
            //Console.WriteLine("Expected value is " + ExpectedValue + " ParamName name " + ParamName);
            for (int k = 0; k < TempArray1.Count(); k++)
            {
                Console.WriteLine(TempArray1[k].ToString());
                if (TempArray1[k].ToString().Contains(ParamName))
                {
                    Console.WriteLine("what happen");
                    // Console.WriteLine(TempArray1[k].ToString());
                    pos = k;
                    break;
                }



            }
            String Actualvalue = TempArray1[pos].ToString();
            Actualvalue = Actualvalue.Replace(ParamName, "");
            Actualvalue = Actualvalue.Trim();
            Actualvalue = Actualvalue.ToLower();
            ExpectedValue = ExpectedValue.Trim();
            ExpectedValue = ExpectedValue.ToLower();
            if (ParamName == "Address")
            {
                Console.WriteLine("test value " + TempArray1[pos + 2]);

                if ((TempArray1[pos + 2].ToString().Contains("County")))
                {
                    Console.WriteLine("Apartment do not exist");
                    Actualvalue = Actualvalue + TempArray1[pos + 1].ToString();
                }
                else
                {
                    Console.WriteLine("Apartment exist");
                    Actualvalue = Actualvalue + TempArray1[pos + 1].ToString() + TempArray1[pos + 2].ToString();
                }
                Actualvalue = Actualvalue.Replace(" ", "");
                Actualvalue = Actualvalue.Trim();
                Actualvalue = Actualvalue.ToLower();
                if (Actualvalue.Contains("-"))
                {
                    Actualvalue = Actualvalue.Substring(0, (Actualvalue.Length - 5));
                }


                //Console.WriteLine("Actualvalue in else logic is " + Actualvalue);
                //Console.WriteLine("ExpectedValue in else logic is " + ExpectedValue);
                //Console.WriteLine(" Paramater name under else : " + ParamName);
                if (string.Compare(Actualvalue, ExpectedValue) == 0)
                {
                    Console.WriteLine(ParamName + " matches : Expected value " + ExpectedValue + " actual value " + Actualvalue);

                }
                else
                {
                    Console.WriteLine(ParamName + " do not matches : Expected value " + ExpectedValue + " actual value " + Actualvalue);
                    Assert.Fail(ParamName + " do not match : Expected value " + ExpectedValue + " Actual value " + Actualvalue);
                }
            }
            else if (ParamName == "Producer Code")
            {
                Actualvalue = TempArray1[pos + 2].ToString();
                Actualvalue = Actualvalue.ToLower();
                if (Actualvalue.Contains(ExpectedValue))
                {
                    Console.WriteLine(ParamName + " matches : Expected value " + ExpectedValue + " actual value " + Actualvalue);
                }
                else
                {
                    Console.WriteLine(ParamName + " do not matches : Expected value " + ExpectedValue + " actual value " + Actualvalue);
                    Assert.Fail(ParamName + " do not match : Expected value " + ExpectedValue + " Actual value " + Actualvalue);
                }

            }
            //
            else if (ParamName == "Phone Number")
            {
                Actualvalue = Actualvalue.Replace("-", "");
                ExpectedValue = ExpectedValue.Replace("-", "");
                if (string.Compare(Actualvalue, ExpectedValue) == 0)
                {
                    Console.WriteLine(ParamName + " matches : Expected value " + ExpectedValue + " actual value " + Actualvalue);

                }
                else
                {
                    Console.WriteLine(ParamName + " do not matches : Expected value " + ExpectedValue + " actual value " + Actualvalue);
                    Assert.Fail(ParamName + " do not match : Expected value " + ExpectedValue + " Actual value " + Actualvalue);
                }
            }

            else
            {
                //Console.WriteLine("Actualvalue in else logic is " + Actualvalue);
                //Console.WriteLine("ExpectedValue in else logic is " + ExpectedValue);
                //Console.WriteLine(" Paramater name under else : " + ParamName);
                if (string.Compare(Actualvalue, ExpectedValue) == 0)
                {
                    Console.WriteLine(ParamName + " matches : Expected value " + ExpectedValue + " actual value " + Actualvalue);

                }
                else
                {
                    Console.WriteLine(ParamName + " do not matches : Expected value " + ExpectedValue + " actual value " + Actualvalue);
                    Assert.Fail(ParamName + " do not match : Expected value " + ExpectedValue + " Actual value " + Actualvalue);
                }


            }



        }


        public void SelectPolicyNumber()
        {
            pause();
            UIAction(LinkPolicyNumber, string.Empty, "a");
            pause();


        }


        public void SelectWorkOrderNumber()
        {
            pause();
            UIAction(LinkWorkOrderNumber, string.Empty, "a");
            pause();


        }
        public void GetCountryName()
        {
            pause();

        }


        public void VerifyQuoteTerm(string Status, string EffectiveDate)
        {

            pause();

            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_WorkOrdersLV:0:0")).ToList();
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            if (arrTblList[0].ToString().Contains(Status))
            {
                Console.WriteLine("Status  matches : Expected value  " + Status + " Actual value " + Status);
            }
            else
            {
                Console.WriteLine("Status do not  matches : Expected value  " + Status + " Actual value " + arrTblList[0].ToString());
                Assert.Fail("Status  do not match : Expected value " + Status + " Actual value " + arrTblList[0].ToString());
            }
            if (arrTblList[0].ToString().Contains(EffectiveDate))
            {
                Console.WriteLine("EffectiveDate  matches : Expected value  " + EffectiveDate + " Actual value " + EffectiveDate);

            }
            else
            {
                Console.WriteLine("EffectiveDate do not  matches : Expected value  " + EffectiveDate + " Actual value " + arrTblList[0].ToString());
                Assert.Fail("EffectiveDate  do not match : Expected value " + EffectiveDate + " Actual value " + arrTblList[0].ToString());
            }


        }

        public void VerifyCurrentActivities(string Activities, int counter)
        {
            pause();

            var drItemtable = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_ActivitiesLV:" + (counter - 1) + ":0"));
            List<IWebElement> lsGetTdElements = new List<IWebElement>(drItemtable.FindElements(By.TagName("td")));
            string sRowData = "";
            string sTableDate = "";
            int iToTalRows = 0;

            Console.WriteLine("Table counts is " + lsGetTdElements.Count);
            if (lsGetTdElements.Count > 0)
            {
                int iBillDates = 1;
                foreach (var oTdElement in lsGetTdElements)
                {
                    sRowData = (iBillDates == 1) ? sRowData = oTdElement.Text : sRowData + "|" + oTdElement.Text;
                    iBillDates = 0;
                }
                Console.WriteLine(sRowData);

            }

            string[] details = sRowData.Split('|');



            Console.WriteLine("Expected name " + details[2].ToString());

            string Actualvalue = details[2].ToString();
            Actualvalue = Actualvalue.Trim();
            Actualvalue = Actualvalue.ToLower();
            Activities = Activities.ToLower();

            if (string.Compare(Actualvalue, Activities) == 0)
            {
                Console.WriteLine("Activity matches : Expected value " + Activities + " actual value " + Actualvalue);

            }
            else
            {
                Console.WriteLine("Activity do not matches : Expected value " + Activities + " actual value " + Actualvalue);
                Assert.Fail("Activity do not match : Expected value " + Activities + " Actual value " + Actualvalue);
            }
        }



    }
}

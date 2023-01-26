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

namespace PolicyCenter9Pages.Pages.Common
{
    public class PCDetails_PC9 : Page
    {
        string btnEditAccount = "a[id$=':AccountFile_SummaryScreen:EditAccount']";

        string LinkWorkOrderNumber = "a[id$=':AccountFile_Summary_WorkOrdersLV:0:WorkOrderNumber']";

        public PCDetails_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnEditAccount);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("AccountFile_Summary:AccountFile_SummaryScreen:ttlBar"));
        }

        public void VerifyLeftAccountDetails(string PrimaryInsured, string Address, string PhonNo, string Email, string Status, string AddressType, string Gender, string Occupation, string DateofBirth)

        {


            IWebElement IW_PrimaryInsured = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:Name-inputEl"));
            IWebElement IW_Address = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:AddressShortInputSet:globalAddressContainer:GlobalAddressInputSet:AddressSummary-inputEl"));
            IWebElement IW_PhonNo = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:PhoneNumber-inputEl"));
            IWebElement IW_Email = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:Email-inputEl"));
            IWebElement IW_Status = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:AccountStatus-inputEl"));
            IWebElement IW_AddressType = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:AddressShortInputSet:AddressType-inputEl"));

            try
            {
                IWebElement IW_Gender = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:ContactDetailsInputSet:Gender-inputEl"));
                comparevalue(Gender, IW_Gender.Text, "Gender");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }


            string[] addresstemp = IW_Address.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            string Addresstemp = "";
            for (int i = 0; i < addresstemp.Count(); i++)
            {
                Addresstemp = Addresstemp + addresstemp[i];
            }
            if(Address.Length > 2)
            {
                comparevalue(Address, Addresstemp, "Address");
            }
            if (PrimaryInsured.Length > 2)
            {
                comparevalue(PrimaryInsured, IW_PrimaryInsured.Text, "PrimaryInsured");
            }
            if (PhonNo.Length > 2)
            {
                comparevalue(PhonNo, IW_PhonNo.Text, "PhonNo");
            }
            if (Email.Length > 2)
            {
                comparevalue(Email, IW_Email.Text, "Email");
            }

            if (Status.Length > 2)
            {
                comparevalue(Status, IW_Status.Text, "Status");
            }

            if (AddressType.Length > 2)
            {
                comparevalue(AddressType, IW_AddressType.Text, "AddressType");
            }

        }


        public void VerfiyJwelerID(string JwelerID)
        {
            try
            {
                IWebElement IW_JwelerID = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:Question_PLInputSet:Jeweler_JMInputSet:JewelersAppraiser-inputEl"));
                comparevalue(JwelerID, IW_JwelerID.Text, "JwelerID");
            }
            catch (Exception e)
            {


            }
        }

        public void VerifyRightAccountDetailsQNA(string DistributionSource, string MethodofCommunication, string ApplicationTakenBy, string Paperless, string ProducerCode)
        {
            IWebElement IW_DistributionSource = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:InsuredInfo_PLInputSet:HeardAbout-inputEl"));
            IWebElement IW_MethodofCommunication = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:InsuredInfo_PLInputSet:PreferredMethodComm-inputEl"));
            try
            {
                IWebElement IW_Paperless = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:InsuredInfo_PLInputSet:IsPaperlessDelivered-inputEl"));
                comparevalue(Paperless, IW_Paperless.Text, "Paperless");
            }
            catch (Exception e)
            {

            }
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:AccountPCsLV")).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[0].FindElements(By.TagName("td"));
            var value = tds[0].FindElements(By.TagName("div"));
            Console.WriteLine("Value is " + value[0].Text);
            if (ApplicationTakenBy.Length > 2)
            {
                IWebElement IW_ApplicationTakenBy = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:InsuredInfo_PLInputSet:applicationTakenBy-inputEl"));
                comparevalue(ApplicationTakenBy, IW_ApplicationTakenBy.Text, "ApplicationTakenBy");
            }

            comparevalue(DistributionSource, IW_DistributionSource.Text, "DistributionSource");
            comparevalue(MethodofCommunication, IW_MethodofCommunication.Text, "MethodofCommunication");

            comparevalue(ProducerCode, value[0].Text, "ProducerCode");

        }
        public void verifyPaymentPlan(string policyNumber)
        {
            IWebElement IW_PolicyNumber = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_PolicyTermsLV:0:PolicyNumber"));
            IW_PolicyNumber.Click();
            string paymentPlan = (string)ScenarioContext.Current["PaymentOption"];
            Console.WriteLine("Payment Option chosen is " + paymentPlan);
            UIActionExt(By.XPath("//span[text()='Payment']"), "click");
            if (paymentPlan == "1")
            {
                //Annually
                Assert.IsTrue(driver.FindElement(By.XPath("//div[text()='Annual Pay']")).Displayed);
            }
            else if (paymentPlan == "2")
            {
                //2
                Assert.IsTrue(driver.FindElement(By.XPath("//div[text()='2 Pay - Semi Annually']")).Displayed);
            }
            else if (paymentPlan == "4")
            {
                //4 Pay - Quarterly
                Assert.IsTrue(driver.FindElement(By.XPath("//div[text()='4 Pay - Quarterly']")).Displayed);
            }
            else if (paymentPlan == "8")
            {
                //8 Pay - Semi Quarterly
                Assert.IsTrue(driver.FindElement(By.XPath("//div[text()='8 Pay - Semi Quarterly']")).Displayed);
            }
            else if (paymentPlan == "12")
            {
                //Monthly
                Assert.IsTrue(driver.FindElement(By.XPath("//div[text()='12 Pay']")).Displayed);
            }

        }

        public void VerifyPolicyTerm(string PolicyNumber, string Status, string EffectiveDate)
        {
            IWebElement IW_PolicyNumber = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_PolicyTermsLV:0:PolicyNumber"));
            comparevalue(PolicyNumber, IW_PolicyNumber.Text, "PolicyNumber");

            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_PolicyTermsLV-body")).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[0].FindElements(By.TagName("td"));

            for (int i = 1; i < tds.Count; i++)
            {
                var value = tds[i].FindElements(By.TagName("div"));
                switch (i)
                {
                    case 3:
                        Console.WriteLine("Status is " + value[0].Text);
                        comparevalue(Status, value[0].Text, "Status");
                        break;
                    case 4:
                        Console.WriteLine("Effective Date is " + value[0].Text);
                        comparevalue(EffectiveDate, value[0].Text, "EffectiveDate");
                        break;

                }
            }



        }

        public void comparevalue(string expectedvalue, string actualvalue, string paramater)
        {
            if (expectedvalue.Length > 1)
            {
                switch (paramater.ToLower().Trim())
                {
                    case "address":
                        actualvalue = actualvalue.Replace("\n", "");
                        actualvalue = actualvalue.Replace(" ", "");
                        if (actualvalue.Contains("-"))
                        {
                            actualvalue = actualvalue.Substring(0, (actualvalue.Length - 5));
                        }
                        break;
                    case "phonno":
                        if (actualvalue.Contains("-"))
                        {
                            actualvalue = actualvalue.Replace("-", "");
                        }
                        break;
                }

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

        public void verifyActivityInSummary(string expectedActivities)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_ActivitiesLV-body")).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            string actual_Activity = "";
            for (int i = 0; i < rows.Count; i++)
            {
                actual_Activity = actual_Activity + driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_ActivitiesLV:" + i + ":Subject")).Text;
            }
            actual_Activity = actual_Activity.ToLower().Trim();
            if (expectedActivities.Contains(";"))
            {
                char[] delimiterChars = { ';' };
                string[] Expectedactivity = expectedActivities.Split(delimiterChars);
                foreach (string expected in Expectedactivity)
                {
                    Console.WriteLine(" expected value is " + expected);
                    if (actual_Activity.Contains(expected.ToLower().Trim()))
                    {
                        Console.WriteLine("expected value match " + expected.ToLower().Trim());
                    }
                    else
                    {
                        Console.WriteLine("expected value do not match " + expected.ToLower().Trim());
                        Assert.Fail("expected value do not match " + expected.ToLower().Trim());
                    }
                }
            }
            else
            {
                if (actual_Activity.Contains(expectedActivities.ToLower().Trim()))
                {
                    Console.WriteLine("expected value match " + expectedActivities.ToLower().Trim());
                }
                else
                {
                    Console.WriteLine("expected value do not match " + expectedActivities.ToLower().Trim());
                    Assert.Fail("expected value do not match " + expectedActivities.ToLower().Trim());
                }
            }
        }

        public void VerifyQuoteTerm(string Status, string EffectiveDate)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_WorkOrdersLV-body")).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[0].FindElements(By.TagName("td"));
            Console.WriteLine("TD count is " + tds.Count());

            for (int i = 0; i < tds.Count; i++)
            {
                //var value2 = tds[i].FindElement(By.TagName("div"));
                //Console.WriteLine("for counter " + i + " is " + value2.GetAttribute("innerHTML"));

                switch (i)
                {
                    case 0:
                        var value = tds[i].FindElement(By.TagName("div"));
                        Console.WriteLine("CreationDate is " + value.GetAttribute("innerHTML"));
                        comparevalue(EffectiveDate, value.GetAttribute("innerHTML"), "CreationDate");
                        break;
                    case 2:
                        var value1 = tds[i].FindElement(By.TagName("div"));
                        Console.WriteLine("Effective Date is " + value1.GetAttribute("innerHTML"));
                        comparevalue(Status, value1.GetAttribute("innerHTML"), "Status");
                        break;

                }
            }
        }

        public void SelectWorkOrderNumber()
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_WorkOrdersLV-body")).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[0].FindElements(By.TagName("td"));
            Console.WriteLine("TD count is " + tds.Count());
            var value1 = tds[1].FindElement(By.TagName("div"));
            value1.Click();
            var value2 = value1.FindElement(By.TagName("a"));
            value2.Click();
            //UIAction(LinkWorkOrderNumber, string.Empty, "a");
        }

        public void getDetailsforQuickClaim()
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            IWebElement IW_PrimaryInsured = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:Name-inputEl"));
            IWebElement IW_Address = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:AddressShortInputSet:globalAddressContainer:GlobalAddressInputSet:AddressSummary-inputEl"));
            IWebElement IW_PolicyNumber = driver.FindElement(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_PolicyTermsLV:0:PolicyNumber"));
            string name = IW_PrimaryInsured.Text;
            Console.WriteLine("Name value is " + name);
            string[] Name = name.Split(' ');
            string lastname = Name[1];
            RegKey.SetValue("LNAME", lastname);
            Console.WriteLine("last name is " + lastname);

            string firstname = Name[0];
            RegKey.SetValue("FNAME", firstname);
            Console.WriteLine("First name is " + firstname);

          
            string address = IW_Address.Text;
            address = address.Replace("\n", "");
            address = address.Replace(" ", "");
            string[] Zipcode = address.Split(',');
            string postalcode = Zipcode[1].Substring(2, Zipcode[1].Length - 2);
            RegKey.SetValue("ZIPCODE", postalcode);
            Console.WriteLine("Zip code is " + postalcode);
            string policynumber = IW_PolicyNumber.Text;
            RegKey.SetValue("PLCYNO", policynumber);
            Console.WriteLine("Poloicy is " + policynumber);


        }
    }
}

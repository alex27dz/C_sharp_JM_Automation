using AutomationFramework;
using HelperClasses;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading.Tasks;


namespace PolicyCenterPages.Pages.Common
{
    public class Contacts : Page
    {
       string tabConatctDetail = "span[id$=':AccountFile_ContactsScreen:AccountContactCV:AccountContactDetailCardTab']";

       string tabCreditConsent = "a[id$=':AccountContactCV:CreditConsentTab']";

        string CreditCheckValue = "span[id$=':AccountFile_ContactsScreen:AccountContactCV:CreditConsentPanelSet:CreditCheck']";


        string[] arrTblList;

        public Contacts(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();
            VerifyUIElementIsDisplayed(tabConatctDetail);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(tabConatctDetail));
        }

        public void VerifyCreditConsent(string creditConsent)
        {
            UIAction(tabCreditConsent, String.Empty, "span");
            pause();
            pause();
            IWebElement CreditCheckValue = driver.FindElement(By.XPath("//span[@id ='AccountFile_Contacts:AccountFile_ContactsScreen:AccountContactCV:CreditConsentPanelSet:CreditCheck']"));
            Console.WriteLine("Credit Consent value is " + CreditCheckValue.Text);
            switch (creditConsent.ToLower().Trim())
            {
                case "yes":

                    if (!(CreditCheckValue.Text.Equals("Yes")))
                    {
                        Assert.Fail("Credit Consent do not match");
                    }

                    break;
                default:
                    if (CreditCheckValue.Text.Equals("Yes"))
                    {
                        Assert.Fail("Credit Consent do not match");
                    }
                    break;
            }
        }

        public void verifyContactDetails(string Name, string Role, string Phone, string Email, int counter)
        {
            pause();

            var drItemtable = driver.FindElement(By.Id("AccountFile_Contacts:AccountFile_ContactsScreen:AccountContactsLV:" + (counter - 1) + ":0"));
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



            //Console.WriteLine("Expected name " + details[3].ToString());
            //Console.WriteLine("Expected Role " + details[4].ToString());
            //Console.WriteLine("Expected Phone " + details[5].ToString());
            //Console.WriteLine("Expected Email " + details[6].ToString());


            comapre_Item(Name, details[3].ToString(), "name");
            comapre_Item(Role, details[4].ToString(), "Role");
            comapre_Item(Phone, details[5].ToString(), "Phone");
            comapre_Item(Email, details[6].ToString(), "Email");


          
        }

        public void comapre_Item(string ExpectedValue, string Actualvalue, string ParamName)
        {
            switch (ParamName.ToLower().Trim())
            {
                case "role":
                    Actualvalue = Actualvalue.Replace(" ", "");
                    Actualvalue = Actualvalue.Replace(",", "");

                    ExpectedValue = ExpectedValue.Replace(" ", "");
                    ExpectedValue = ExpectedValue.Replace(",", "");
                    break;
            }
           

            //Console.WriteLine(" Expected value " + ExpectedValue);
            //Console.WriteLine(" Actual value " + Actualvalue);
            //Console.WriteLine(" ParamName " + ParamName);

            Actualvalue = Actualvalue.Trim();
            Actualvalue = Actualvalue.ToLower();
            ExpectedValue = ExpectedValue.ToLower();

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
        public void Comparision(string ExpectedValue, string ParamName, string[] TempArray1)
        {
            int pos = 0;
            Console.WriteLine(TempArray1);
            for (int k = 0; k < TempArray1.Count(); k++)
            {
                Console.WriteLine(TempArray1[k].ToString());
                if (TempArray1[k].ToString().Contains(ParamName))
                {
                    Console.WriteLine("what happen");
                    Console.WriteLine(TempArray1[k].ToString());
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
            Console.WriteLine("Actualvalue in else logic is " + Actualvalue);
            Console.WriteLine("ExpectedValue in else logic is " + ExpectedValue);
            Console.WriteLine(" Paramater name under else : " + ParamName);
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
}

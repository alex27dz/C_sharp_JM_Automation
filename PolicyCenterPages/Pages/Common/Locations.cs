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
    public class Locations : Page
    {
     //   string btnNext = "a[id='SubmissionWizard:Next']";
        

        string[] arrTblList;

        public Locations(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

        //    VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
         //   IsElementPresent(driver, By.CssSelector(btnNext));
        }

    

        public void verifyLocationDetails(string Active, string Loc, string AddreeType, string Address, int counter)
        {
            pause();

            var drItemtable = driver.FindElement(By.Id("AccountFile_Locations:AccountFile_LocationsScreen:AccountFile_LocationsLV:" + (counter - 1) + ":0"));
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



            //Console.WriteLine("Expected Active " + details[2].ToString());
            //Console.WriteLine("Expected Loc " + details[4].ToString());
            //Console.WriteLine("Expected Address Type " + details[5].ToString());
            //Console.WriteLine("Expected Address " + details[8].ToString());
          

            comapre_Item(Active, details[2].ToString(), "Active");
            comapre_Item(Loc, details[4].ToString(), "Loc");
            comapre_Item(AddreeType, details[5].ToString(), "AddressType");
            comapre_Item(Address, details[8].ToString(), "Address");


          
        }

        public void comapre_Item(string ExpectedValue, string Actualvalue, string ParamName)
        {
            switch (ParamName.ToLower().Trim())
            {
                case "Address":
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
     
    }
}

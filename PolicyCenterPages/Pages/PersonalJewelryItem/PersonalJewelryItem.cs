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


namespace PolicyCenterPages.Pages.CreateAccount
{
    public class PersonalJewelryItem : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";


        string[] arrTblList;

        public PersonalJewelryItem(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            //   VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
            // IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void VerifyAlarm(string activity)
        {
            pause();
            // for account details AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:0
            //List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV")).ToList();
            //PolicyFile_JwlryItems_JMIC_PL: PersonalItemJMICPLPanelSet: PersonalItemLV
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:1")).ToList();
            //  List<IWebElement> TableInputElements = driver.FindElements(By.Id("PolicyFile_JwlryItems_JMIC_PL: PersonalItemJMICPLPanelSet: PersonalItemLV")).ToList();
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            for (int k = 0; k < arrTblList.Count(); k++)
            {
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
            }


            Comparision(activity, "Alarm", arrTblList);


        }

        public void verifyItemDetails(string LocatedWith, string value, string Deductiable, string JeweleryItemsDescription, string Appraisal, string Alarm, string Location, int counter)
        {
            pause();

            var drItemtable = driver.FindElement(By.Id("PolicyFile_JwlryItems_JMIC_PL:PersonalItemJMICPLPanelSet:PersonalItemLV:" + (counter - 1) + ":0"));
            List<IWebElement> lsGetTdElements = new List<IWebElement>(drItemtable.FindElements(By.TagName("td")));
            string sRowData = "";
            string sTableDate = "";
            int iToTalRows = 0;

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



            Console.WriteLine("Expected name " + details[1].ToString());
            Console.WriteLine("Expected Location " + details[2].ToString());
            Console.WriteLine("Expected value " + details[3].ToString());
            Console.WriteLine("Expected deductible " + details[4].ToString());
            Console.WriteLine("Expected Description " + details[5].ToString());
            Console.WriteLine("Expected Appraisal Received " + details[6].ToString());
            Console.WriteLine("Expected Safe " + details[9].ToString());


            comapre_Item(LocatedWith, details[1].ToString(), "locatedwith");
            comapre_Item(Location, details[2].ToString(), "location");
            comapre_Item(Deductiable, details[4].ToString(), "deductble");
            comapre_Item(value, details[3].ToString(), "value");


            //// for account details AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV:0
            ////List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Summary:AccountFile_SummaryScreen:AccountFile_Summary_BasicInfoDV")).ToList();
            //Console.WriteLine ("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV:" + (counter - 1) + ":0" );
            //List<IWebElement> TableInputElements = driver.FindElements(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV:" + (counter-1) + ":0")).ToList();
            //arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "*********************" }, StringSplitOptions.None);
            //Console.WriteLine("count of array for account " + TableInputElements.Count());


            ////for (int k = 0; k < TableInputElements.Count(); k++)
            ////{
            ////    Console.WriteLine(k + " identifier " + TableInputElements[k].ToString());
            ////}

            //for (int k = 0; k < arrTblList.Count(); k++)
            //{
            //    Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
            //}
        }

        public void comapre_Item(string ExpectedValue, string Actualvalue, string ParamName)
        {
            switch (ParamName.ToLower().Trim())
            {
                case "location":
                    string[] details = Actualvalue.Split(':');
                    Actualvalue = details[1].ToString();
                    break;
                case "value":
                    string[] Sperator = new string[] { ".00" };
                    string[] details1 = Actualvalue.Split(Sperator, StringSplitOptions.None);
                    Actualvalue = details1[0].ToString();
                    Actualvalue = Actualvalue.Replace("$", "");
                    Actualvalue = Actualvalue.Replace(",", "");
                    break;
                case "deductble":
                    Actualvalue = Actualvalue.Replace("$", " ");
                    break;
            }
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

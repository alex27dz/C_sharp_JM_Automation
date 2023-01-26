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
using PolicyCenterPages.Pages.Common;

namespace PolicyCenterPages.Pages.Common
{
    public class PolicySummary : Page
    {
        string[] arrTblList;
     
        public PolicySummary(IWebDriver driver) : base(driver)
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

        public void VerifyPolicySummary(string Product, string Type, string TotalCost)
        {
         
            pause();
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_PolicyDV:0")).ToList();
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            AccountDetailsComparision(Product, "Product", arrTblList);

            List<IWebElement> TableInputElements1 = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_AssocJobDV:0")).ToList();
            arrTblList = TableInputElements1[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            AccountDetailsComparision(Type, "Type", arrTblList);

            List<IWebElement> TableInputElements3 = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_DatesDV:0")).ToList();
            arrTblList = TableInputElements3[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            AccountDetailsComparision(TotalCost, "Total Cost", arrTblList);



        }

    

        public void AccountDetailsComparision(string ExpectedValue, string ParamName, string[] TempArray1)
        {
            int pos =0;
          //  Console.WriteLine("Expected value is " + ExpectedValue + " ParamName name " + ParamName);
            for (int k = 0; k < TempArray1.Count(); k++)
            {
                if (TempArray1[k].ToString().Contains(ParamName))
                {
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
            //Console.WriteLine("Actualvalue is " + Actualvalue);
            //Console.WriteLine("Actualvalue in else logic is " + Actualvalue);
            //Console.WriteLine("ExpectedValue in else logic is " + ExpectedValue);
            //Console.WriteLine(" Paramater name under else : " + ParamName);
            if (ParamName == "Total Cost")
            {
               ExpectedValue = ExpectedValue.Replace(" ,", "");

            }
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

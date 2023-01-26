using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium.Interactions;
using System.Diagnostics;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgencyAutomationPages.Pages
{
    public class AgentAccountInormation : Page
    {
        //[FindsBy(How = How.XPath, Using = "//div[text()[contains(.,'Account Information')]]")]
        //public IWebElement lblAccountInformation;

        //string lblAccountInformation = "div[text()[contains(.,'Account Information')]]";

        // string linkAgentProfile = "a[id$='ProfileLink']";
        string[] valueList;
        string[] labelList;

        public AgentAccountInormation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }


        public override void VerifyPage()
        {
            pause();
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'Account Information')]]"));

        }

        public void getAccountDetails()
        {
            IList<IWebElement> valueName = driver.FindElements(By.XPath("//div[@class='containerRound-textbox col-md-8']")).ToList();
            IList<IWebElement> labelName = driver.FindElements(By.XPath("//div[@class='containerRound-label col-md-4']")).ToList();
            valueList = new string[valueName.Count - 1];
            labelList = new string[valueName.Count - 1];
            for (int i = 0; i < valueName.Count - 1; i++)
            {
                valueList[i] = valueName[i].Text;
                labelList[i] = labelName[i].Text;

            }

            string Accountname = getParametrvalue(labelList, valueList, "Account Name");
            string PrimaryAddress1 = getParametrvalue(labelList, valueList, "PrimaryAddress1");
            string PrimaryAddress2 = getParametrvalue(labelList, valueList, "PrimaryAddress2");
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PRIMARY_INSURED", Accountname);
            // tempData.StoreTempValue("guidewire", "ACC_ADDRESS", PrimaryAddress1.Replace(" ", "") + PrimaryAddress2.Replace(" ", ""));
            string Addres2, Addres1;
            Addres1 = PrimaryAddress1.Replace(" ", "");
            Addres2 = PrimaryAddress2.Replace(" ", "");
            if (Addres2.Contains("-"))
            {
                string[] address_temp = Addres2.Split('-');
                Addres2 = address_temp[0];
            }

            tempData.StoreTempValue("guidewire", "ACC_ADDRESS", Addres1 + Addres2);


            //Console.WriteLine("Account name is " + Accountname);
            //Console.WriteLine("address is " + PrimaryAddress1.Replace(" ", "") + PrimaryAddress2.Replace(" ", ""));

        }



        public string getParametrvalue(string[] TempArray1, string[] TempArray2, string paramName)
        {
            int pos = Array.IndexOf(TempArray1, paramName);
            string paramValue = "";
            paramValue = TempArray2[pos].ToString();
            return paramValue;

        }







    }
}

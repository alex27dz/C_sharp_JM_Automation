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
    public class AgentBillingInformation : Page
    {
        //[FindsBy(How = How.XPath, Using = "//div[text()[contains(.,'Account Information')]]")]
        //public IWebElement lblAccountInformation;

        //string lblAccountInformation = "div[text()[contains(.,'Account Information')]]";



        string[] valueList;
        string[] labelList;

        public AgentBillingInformation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }


        public override void VerifyPage()
        {
            pause();
        }

        public override void WaitForLoad()
        {


        }

        public void clickLefttab(string option)
        {
            WaitUntilElementVisible(driver, By.XPath("//h3[text()[contains(.,'Policy Summary - Billing')]]"));
            List<IWebElement> leftTabObject;
            switch (option.ToLower().Trim())
            {
                case "account information":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/AccountInformation/')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                case "policy information":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/PolicyInformation/')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                case "line information":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/PolicyInformation/LineInformation')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                case "location information":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/PolicyInformation/LocationInformation')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                case "temp coverages":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/PolicyInformation/BOPILMTempCoverages')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                case "billing information":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/BillingInformation/')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                case "claim information":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/ClaimInformation/')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                case "billing documents":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/BillingDocuments')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                case "policy documents":
                    leftTabObject = driver.FindElements(By.XPath("//a[@href[contains(.,'/AgentPortalInquiry/PolicyDocuments')]]")).ToList();
                    leftTabObject[0].Click();
                    break;
                default:
                    break;


            }

        }

        public void fetchBillingData()
        {
            DataStorage tempData = new DataStorage();
            IList<IWebElement> AccountNameSection = driver.FindElements(By.XPath("//div[@class='containerRound-row']")).ToList();
            for (int i = 0; i < AccountNameSection.Count - 1; i++)
            {
                //Console.WriteLine("label is " + AccountNameSection[i].FindElement(By.ClassName("containerRound-label")).Text);
                //Console.WriteLine("Value is " + AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                switch (AccountNameSection[i].FindElement(By.ClassName("containerRound-label")).Text)
                {
                    case "Account #":
                        Console.WriteLine("Account is " + AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        tempData.StoreTempValue("guidewire", "ACCNO", AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        break;
                    case "Address":
                        Console.WriteLine("ACC_ADDRESS is " + AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text + AccountNameSection[i + 1].FindElement(By.ClassName("containerRound-textbox")).Text);
                        string Addres2, Addres1;
                        Addres1 = AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text.Replace(" ", "");
                        Addres2 = AccountNameSection[i+1].FindElement(By.ClassName("containerRound-textbox")).Text.Replace(" ", "");
                        if (Addres2.Contains("-"))
                        {
                            string[] address_temp = Addres2.Split('-');
                            Addres2 = address_temp[0];
                        }

                        tempData.StoreTempValue("guidewire", "ACC_ADDRESS", Addres1 + Addres2);


                        //string address = AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text + AccountNameSection[i + 1].FindElement(By.ClassName("containerRound-textbox")).Text;
                        //address = address.Replace(" ", "");
                        //tempData.StoreTempValue("guidewire", "ACC_ADDRESS", address);
                        break;
                    case "Payment Plan":
                        Console.WriteLine("PAYMENTPLAN is " + AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        tempData.StoreTempValue("guidewire", "PAYMENTPLAN", AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        break;
                }
            }

        }



    }
}

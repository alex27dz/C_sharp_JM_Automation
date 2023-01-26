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
    public class AgentPolicyInormation : Page
    {
        //[FindsBy(How = How.XPath, Using = "//div[text()[contains(.,'Account Information')]]")]
        //public IWebElement lblAccountInformation;

        //string lblAccountInformation = "div[text()[contains(.,'Account Information')]]";

        // string linkAgentProfile = "a[id$='ProfileLink']";


        public AgentPolicyInormation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }


        public override void VerifyPage()
        {
            pause();
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'Policy Information')]]"));

        }

        public void getPolicyDetails()
        {
            IList<IWebElement> AccountNameSection = driver.FindElements(By.XPath("//div[@class='containerRound-row']")).ToList();
            DataStorage tempData = new DataStorage();
            for (int i = 0; i < AccountNameSection.Count; i++)
            {
                //Console.WriteLine(" value of i " + i);
                //Console.WriteLine(AccountNameSection[i].FindElement(By.ClassName("containerRound-label")).Text);
                //Console.WriteLine(AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                switch (AccountNameSection[i].FindElement(By.ClassName("containerRound-label")).Text)
                {
                    case "Effective Date":
                        Console.WriteLine("EffectiveDat is " + AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        tempData.StoreTempValue("guidewire", "EFFDATE", AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        break;
                    case "Expiration Date":
                        Console.WriteLine("ExpirationDate is " + AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        tempData.StoreTempValue("guidewire", "EXPDATE", AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        break;

                    case "Producer Code":
                        Console.WriteLine("ProducerCode is " + AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);
                        ScenarioContext.Current["ProducerCode"] = AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text;
                        tempData.StoreTempValue("guidewire", "PRODUCERCODE", AccountNameSection[i].FindElement(By.ClassName("containerRound-textbox")).Text);

                        break;

                }


            }
        }


    }
}

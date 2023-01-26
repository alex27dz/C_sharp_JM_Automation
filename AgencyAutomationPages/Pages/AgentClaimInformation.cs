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
    public class AgentClaimInformation : Page
    {
        //[FindsBy(How = How.XPath, Using = "//div[text()[contains(.,'Account Information')]]")]
        //public IWebElement lblAccountInformation;

        //string lblAccountInformation = "div[text()[contains(.,'Account Information')]]";

        string textLossDate = "input[id$='FNOLRequest_LossDate']";
        string texareatLossDescription = "textarea[id$='FNOLRequest_LossDescription']";
        string textLossCause = "input[placeholder[contains(.,'Select Loss Code')]]";
        string btnnext = "input[id$='btnNext']";
        string btnsubmit = "input[id$='btnSubmit']";


        public AgentClaimInformation(IWebDriver driver) : base(driver)
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

        public void selectFirstPolicyForClaim()
        {
            WaitUntilElementVisible(driver, By.XPath("//b[text()[contains(.,'First Notice of Loss')]]"));
            IList<IWebElement> Account = driver.FindElements(By.XPath("//input[@id='selectPolicy']")).ToList();
            IList<IWebElement> Date = driver.FindElements(By.XPath("//td[@id='expDt']")).ToList();
            ScenarioContext.Current["LossDate"] = Date[0].Text;
            Account[0].Click();



        }

        public void SetFirstNoticeofLose(string lossDate, string lossDescription, string lossCause)
        {
            WaitUntilElementVisible(driver, By.XPath("//b[text()[contains(.,'First Notice of Loss')]]"));
            UIAction(textLossDate, lossDate, "textbox");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab);
            pause();
            action.SendKeys(lossDescription);
            action.Perform();
            action.Release();
            IWebElement selectlossCause = driver.FindElement(By.XPath("//span[@data-dropdown='dropdown']"));
            Console.WriteLine("Class name is " + selectlossCause.GetAttribute("class"));
            selectlossCause.Click();
            List<IWebElement> PageInputElements = driver.FindElements(By.XPath("//li[@data-value ='" + lossCause + "']")).ToList();
            Console.WriteLine("Total {0} items: {1}", lossCause, PageInputElements.Count());
            Console.WriteLine("Total {0} items: {1}", lossCause, PageInputElements[0].GetAttribute("data-value"));
            PageInputElements[0].Click();
            UIAction(btnnext, String.Empty, "a");

        }

        public void SubmitClaim()
        {

            Console.WriteLine("Click on Submit button");
            UIAction(btnsubmit, String.Empty, "a");
        }

        public void VerifyClaimisSubmitted()
        {
            WaitUntilElementVisible(driver, By.XPath("//b[text()[contains(.,'First Notice of Loss Received')]]"));
            try
            {
                List<IWebElement> successMessage = driver.FindElements(By.XPath("//div[text()[contains(.,'The claim you have submitted has been successfully received by Jewelers Mutual. You will receive a confirmation email that the claim has been successfully submitted. This confirmation email will serve as your Loss Notice.')]]")).ToList();
                if (successMessage.Count > 0)
                {
                    Console.WriteLine("Claim is submitted successfully");
                }
                else
                {
                    Console.WriteLine("Claim is not submitted successfully");
                    Assert.Fail("Claim is not submitted successfully");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception message is " + e.Message);
                Assert.Fail("Claim is not submitted successfully");
            }

        }
    }
}

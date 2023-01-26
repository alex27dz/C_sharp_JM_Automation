using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace PLPortalPages.Pages
{
    public class PolicyDetailes : Page
    {
        string btnPayPremium = "img[alt='Pay My Premium']";
        string btnAddUpdateJewelry = "img[alt='Add Jewelry']";
        string btnuploadAppraisal = "img[alt='Upload Appraisal']";
        string btnChangePersonalInfo = "img[alt='Update Personal Information']";
        //string btnSubmitClaim = "img[alt='Submit a Claim']";
        string btnSubmitClaim = "img[alt='Submit/ View Claims']";
        string LinkPaperlessYes = "input[id$='btnEdelivery']";


        public PolicyDetailes(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(txtAppfirstName);
        }

        public override void WaitForLoad()
        {
        }
        public void MangePaperlessSetting(string paperlessFlag)
        {
            try
            {
                switch (paperlessFlag.ToLower())
                {
                    case "yes":
                        UIAction(LinkPaperlessYes, string.Empty, "a");
                        break;
                    case "no":
                        IWebElement Login_noPaperless = driver.FindElement(By.XPath("//a[contains(.,'No. Not Now.')]"));
                        Console.WriteLine("click on login link after regis." + Login_noPaperless);
                        Login_noPaperless.Click();

                        break;
                    default:
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void VerifyPolicyNumber(string PolicyNumber)
        {
            List<IWebElement> policydetailstableObj;
            policydetailstableObj = driver.FindElements(By.XPath("//table[@class='policyList']")).ToList();
            var rows = policydetailstableObj[0].FindElements(By.TagName("tr"));
            var tds = rows[1].FindElements(By.TagName("td"));
            Console.WriteLine(("Actual value is " + tds[0].Text).ToString() + " Expected value is " + PolicyNumber);
            if (PolicyNumber.Trim().Equals((tds[0].Text).ToString().Trim()))
            {
                System.Console.WriteLine("Policy Number format matched");
            }
            else
            {
                Assert.Fail("Policy Number format do not match");
            }

        }

        public void clickonvewDetailes()
        {
            System.Threading.Thread.Sleep(3000);
            //WaitUntilElementIsDisplayed(driver, By.XPath("//table[@class='policyList']"));
            //WaitUntilElementDisplay(driver, By.XPath("//a[contains(.,'View Details')]"));
            //pause();
            //pause();
            //pause();
            IWebElement ViewDetails = driver.FindElement(By.XPath("//a[contains(.,'View Details')]"));
            Console.WriteLine("click on login link after regis." + ViewDetails);
            ViewDetails.Click();

        }

        public void clickonMenuOption(string MenuOption)
        {
            pause();
            switch ((MenuOption.ToLower()).Trim())
            {
                case "premium":
                    switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
                    {
                        case "stage":
                            UIAction(btnPayPremium, string.Empty, "a");
                            break;
                        default:
                            break;
                    }
                    break;
                case "jewelry":
                    UIAction(btnAddUpdateJewelry, string.Empty, "a");
                    break;
                case "appraisal":
                    UIAction(btnuploadAppraisal, string.Empty, "a");
                    break;
                case "information":
                    UIAction(btnChangePersonalInfo, string.Empty, "a");
                    break;
                case "claim":
                    UIAction(btnSubmitClaim, string.Empty, "a");
                    break;

                default:
                    break;

            }
        }

    }

}

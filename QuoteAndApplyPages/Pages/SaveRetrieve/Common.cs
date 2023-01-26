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


namespace QuoteAndApplyPages.Pages.SaveRetrieve
{
    public class Common : Page
    {
      
        string btnSaveFinishLaterApplicantwWearer = "a[id$='applicationSaveFinish']";
        string btnSaveFinishLaterJewelryDetails = "a[id$='jewelryDetailsSaveFinish']";
        string btnSaveFinishLater = "a[id$='reviewSaveFinish']";
        string chckboxAgreeSave = "input[id$='SRAgreedToTerms']";
        string txtconfirmYourEmail = "input[id$='SRConfirmEmail']";





        public Common(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            // SetActiveFrame();
            pause(); 
           // VerifyUIElementIsDisplayed(btnSaveFinishLater);
        }

        public override void WaitForLoad()
        {
           // IsElementPresent(driver, By.Id(btnSaveFinishLater));
        }
        public void JewelrydetailssaveMyApplication()
        {
            UIAction(btnSaveFinishLaterJewelryDetails, String.Empty, "a");
        }
        public void ApplicantwWearersaveMyApplication()
        {
            UIAction(btnSaveFinishLaterApplicantwWearer, String.Empty, "a");
        }
        public void clickSaveFinishLater()
        {
            UIAction(btnSaveFinishLater, String.Empty, "a");
        }

        public void saveMyApplication()
        {
            IWebElement txtSaveFirstName;
            IWebElement txtSaveLastName;
            IWebElement txtSaveEmail;
            List<IWebElement> btnSaveFinish;
            DataStorage temp = new DataStorage();
            string ApplicantFirstName = temp.GetTempValue("FNAME");
            string ApplicantLastName = temp.GetTempValue("LNAME");
            string ApplicantEmail = temp.GetTempValue("EMAIL");

            txtSaveFirstName = driver.FindElement(By.XPath("//input[@id='SRFirstName']"));
            txtSaveLastName = driver.FindElement(By.XPath("//input[@id='SRLastName']"));
            txtSaveEmail = driver.FindElement(By.XPath("//input[@id='SREmail']"));

            if (!(ApplicantFirstName.ToLower().Equals(txtSaveFirstName.GetAttribute("value").ToLower())))
            {
                Assert.Fail("Applicant First name do not match");
            }

            if (!(ApplicantLastName.ToLower().Equals(txtSaveLastName.GetAttribute("value").ToLower())))
            {
                Assert.Fail("Applicant Last name do not match");
            }

            if (!(ApplicantEmail.ToLower().Equals(txtSaveEmail.GetAttribute("value").ToLower())))
            {
                Assert.Fail("Applicant Email name do not match");
            }

            pause();
            UIAction(chckboxAgreeSave, String.Empty, "a");
            UIAction(chckboxAgreeSave, String.Empty, "a");
            btnSaveFinish = driver.FindElements(By.XPath("//a[@class='btn jm-btn-primary pull-left btn-save-and-retrieve-save'][text()='Save & Finish Later']")).ToList();
            if (btnSaveFinish.Count() > 0)
            {
                btnSaveFinish[0].Click();
            }


        }

        public void actiononSavedApplication(string ActionType)
        {
            WaitFor(driver.FindElement(By.XPath("//h4[@class='modal-title'][text()='Save My Application']")));

            //  System.Threading.Thread.Sleep(3000);
            List<IWebElement> btnSaveAction;
            List<IWebElement> btnContinue;
            switch (ActionType.ToLower().Trim())
            {
                case "safely leave application":
                    btnSaveAction = driver.FindElements(By.XPath("//a[@class='btn jm-btn pull-left btn-save-and-retrieve-leave-app'][text()='Safely Leave Application']")).ToList();
                    if (btnSaveAction.Count() > 0)
                    {
                        btnSaveAction[0].Click();
                    }
                    pause();
                    break;
                case "continue application":
                    btnSaveAction = driver.FindElements(By.XPath("//a[@class='btn jm-btn-primary pull-left btn-save-and-retrieve-continue-app'][text()='Continue Application']")).ToList();
                    if (btnSaveAction.Count() > 0)
                    {
                        btnSaveAction[0].Click();
                    }
                    pause();
                    break;
                case "return to existing application":
                    btnSaveAction = driver.FindElements(By.XPath("//a[@class='btn jm-btn pull-left btn-return-to-existing-app'][text()='Return To Existing Application']")).ToList();
                    if (btnSaveAction.Count() > 0)
                    {
                        btnSaveAction[0].Click();
                    }
                    pause();
                    break;
                case "replace existing application":
                    btnSaveAction = driver.FindElements(By.XPath("//a[@class='btn jm-btn-primary pull-left btn-replace-existing-app'][text()='Replace Existing Application']")).ToList();
                    if (btnSaveAction.Count() > 0)
                    {
                        btnSaveAction[0].Click();
                    }
                    System.Threading.Thread.Sleep(2000);
                    DataStorage temp = new DataStorage();
                    UIAction(txtconfirmYourEmail, temp.GetTempValue("EMAIL"), "textbox");
                    pause();
                    btnContinue = driver.FindElements(By.XPath("//a[@class='btn jm-btn-primary pull-left btn-save-and-retrieve-continue-app'][text()='Save My Application']")).ToList();
                    if (btnContinue.Count() > 0)
                    {
                        btnContinue[0].Click();
                    }
                    break;
                case "cancel":
                    btnSaveAction = driver.FindElements(By.XPath("//a[@class='btn jm-btn pull-left btn-existing-app-cancel'][text()='Cancel']")).ToList();
                    if (btnSaveAction.Count() > 0)
                    {
                        btnSaveAction[0].Click();
                    }
                    pause();
                    break;
                default:
                    break;

            }
        }

        public void subactiononSavedApplication(string SubActionType)
        {
            List<IWebElement> btnSaveAction;
            switch (SubActionType.ToLower().Trim())
            {
                case "return to existing application":
                    btnSaveAction = driver.FindElements(By.XPath("//a[@class='btn jm-btn pull-left btn-return-to-existing-app'][text()='Return To Existing Application']")).ToList();
                    if (btnSaveAction.Count() > 0)
                    {
                        btnSaveAction[0].Click();
                    }
                    pause();
                    break;
                case "replace existing application":
                    btnSaveAction = driver.FindElements(By.XPath("//a[@class='btn jm-btn-primary pull-left btn-replace-existing-app'][text()='Replace Existing Application']")).ToList();
                    if (btnSaveAction.Count() > 0)
                    {
                        btnSaveAction[0].Click();
                    }
                    pause();
                    break;
                case "cancel":
                    btnSaveAction = driver.FindElements(By.XPath("//a[@class='btn jm-btn pull-left btn-existing-app-cancel'][text()='Cancel']")).ToList();
                    if (btnSaveAction.Count() > 0)
                    {
                        btnSaveAction[0].Click();
                    }
                    pause();
                    break;
                default:
                    break;

            }
        }
    }
}



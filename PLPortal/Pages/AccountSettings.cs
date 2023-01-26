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
using Microsoft.Win32;
namespace PLPortalPages.Pages
{
    public class AccountSettings : Page
    {

        //string txtareaDeniedCoverageReason = "textarea[id$='DeniedCoverageReason']";
        //string radioDoesHelpLiveWithYouYes = "input[id$='DoesHelpLiveWithYou' and value='True']";
        //string radioDoesHelpLiveWithYouNo = "input[id$='DoesHelpLiveWithYou' and value='False']";
        //string radioPatrolsFrequency24hrs = "input[id$='PatrolsFrequency' and value='1']";
        //string radioPatrolsFrequencyNightOnly = "input[id$='PatrolsFrequency' and value='2']";
        //string radioHasPatrolsYes = "input[id$='HasPatrols' and value='True']";
        //string radioHasPatrolsNo = "input[id$='HasPatrols' and value='False']";
        //string radioHasGuardsYes = "input[id$='HasGuards' and value='True']";
        //string radioHasGuardsNo = "input[id$='HasGuards' and value='False']";
        //string radioHasFenceYes = "input[id$='HasFence' and value='True']";
        //string radioHasFenceNo = "input[id$='HasFence' and value='False']";
        //string txtSafeDepositLocation = "input[id$='SafeDepositBoxLocation']";
        //string txtTypeofHelp = "input[id$='TypeofHelp']";
        //string txtHowLongEmployed = "input[id$='HowLongEmployed']";
        //string txtHowOften = "input[id$='HowOften']";
        //string selectJewelryWornFrequency = "select[id$='WearFrequency']";
        //string selectOvernightTravelFrequency = "select[id$='OverNightTravel']";
        //string btnAdditionalQuestionSave = "input[id$='save']";
        //string txtFirstName = "input[id$='FirstName']";
        //string txtPhone = "input[id$='Phone']";
        //string btnSubmit = "input[id$='submitButton']";
        //string btnBack = "input[id$='cancel']";


        //string radioTravelAbroadYes = "input[id$='TravelAbroad-Yes']";
        //string radioTravelAbroadNo = "input[id$='TravelAbroad-No']";
        //string btnadditionalQuestionsNext = "a[id$='additionalQuestionsNext']";
        //string selectTravelPrecautionType = "Select[id$='SafeGuards']";
        //string txtTravelPrecautionOther = "textarea[id$='TravelPrecautionOther']";


        string btnSubmitPaperless = "input[id$='btnPaperless']";
        string chckBoxPaperless = "input[id$='cbPaperlessDelivery']";

        public AccountSettings(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnSubmitPaperless);
        }

        public override void WaitForLoad()
        {
            //WaitUntilElementIsDisplayed(driver, By.Id("addItem"));
        }


        public void ClickPaperlessButton()
        {
            pause();
            UIAction(btnSubmitPaperless, string.Empty, "a");
        }

        public void ClickPaperlessCheckBox()
        {
            pause();
            UIAction(chckBoxPaperless, string.Empty, "a");
        }

        public void ClickAutoPay()
        {
            IWebElement AutoPayLink;
            AutoPayLink = driver.FindElement(By.XPath("//a[contains(.,'Get Started')]"));
            AutoPayLink.Click();
            pause();
        }
        public void VerifyPaperLessErrorMessage(string flag)
        {
            pause();
            IWebElement TxtErrorMessage;
            TxtErrorMessage = driver.FindElement(By.XPath("//div[@id='paperlessConfirmationMessage']"));
            Console.WriteLine("text is " + TxtErrorMessage.Text);
            if (flag.Equals("canceled"))
            {
                if (TxtErrorMessage.Text.Equals("You have successfully cancelled Paperless Delivery. In the future, your billing and policy documents will be mailed to you via US Postal Service."))
                {
                    Console.WriteLine(" Paper Less Canceled Message match.");
                }
                else
                {
                    Assert.Fail(" Paper Less Canceled Message do not match.");
                }
            }
            else
            {
                if (TxtErrorMessage.Text.Equals("You have successfully enrolled in Paperless Delivery. Your billing and policy documents will be available in your eDocuments."))
                {
                    Console.WriteLine(" Paper Less Set Message match.");
                }
                else
                {
                    Assert.Fail(" Paper Less Set Message do not match.");
                }

            }

        }

    }
}
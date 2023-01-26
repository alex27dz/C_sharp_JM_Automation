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

namespace PLPortalPages.Pages
{
    public class AddJewelryConfirmation : Page
    {

        string txtareaDeniedCoverageReason = "textarea[id$='DeniedCoverageReason']";
        string radioDoesHelpLiveWithYouYes = "input[id$='DoesHelpLiveWithYou' and value='True']";
        string radioDoesHelpLiveWithYouNo = "input[id$='DoesHelpLiveWithYou' and value='False']";
        string radioPatrolsFrequency24hrs = "input[id$='PatrolsFrequency' and value='1']";
        string radioPatrolsFrequencyNightOnly = "input[id$='PatrolsFrequency' and value='2']";
        string radioHasPatrolsYes = "input[id$='HasPatrols' and value='True']";
        string radioHasPatrolsNo = "input[id$='HasPatrols' and value='False']";
        string radioHasGuardsYes = "input[id$='HasGuards' and value='True']";
        string radioHasGuardsNo = "input[id$='HasGuards' and value='False']";
        string radioHasFenceYes = "input[id$='HasFence' and value='True']";
        string radioHasFenceNo = "input[id$='HasFence' and value='False']";
        string txtSafeDepositLocation = "input[id$='SafeDepositBoxLocation']";
        string txtTypeofHelp = "input[id$='TypeofHelp']";
        string txtHowLongEmployed = "input[id$='HowLongEmployed']";
        string txtHowOften = "input[id$='HowOften']";
        string selectJewelryWornFrequency = "select[id$='WearFrequency']";
        string selectOvernightTravelFrequency = "select[id$='OverNightTravel']";
        string btnAdditionalQuestionSave = "input[id$='save']";
        string txtFirstName = "input[id$='FirstName']";
        string txtPhone = "input[id$='Phone']";
        string btnSubmit = "input[id$='submitButton']";
        string btnBack = "input[id$='cancel']";


        string radioTravelAbroadYes = "input[id$='TravelAbroad-Yes']";
        string radioTravelAbroadNo = "input[id$='TravelAbroad-No']";
        string btnadditionalQuestionsNext = "a[id$='additionalQuestionsNext']";
        string selectTravelPrecautionType = "Select[id$='SafeGuards']";
        string txtTravelPrecautionOther = "textarea[id$='TravelPrecautionOther']";




        public AddJewelryConfirmation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(btnBack);
        }

        public override void WaitForLoad()
        {
            //WaitUntilElementIsDisplayed(driver, By.Id("addItem"));
        }


        public void ClickSubmit()
        {
            // WaitUntilElementIsDisplayed(driver, By.Id("submitButton"));
            pause();
            UIAction(btnSubmit, string.Empty, "a");
        }

        public void ManageAdditionalQuestions(string AdditionalQuestionType)
        {
            List<IWebElement> AdditionalQuestion;
            switch (AdditionalQuestionType.ToLower().Trim())
            {
                case "online":
                    AdditionalQuestion = driver.FindElements(By.XPath("//input[@id ='IsFilledOutOnline'and @value='True']")).ToList();
                    AdditionalQuestion[0].Click();
                    break;
                case "phone":
                    AdditionalQuestion = driver.FindElements(By.XPath("//input[@id ='IsFilledOutOnline'and @value='False']")).ToList();
                    AdditionalQuestion[0].Click();
                    break;
                default:
                    Console.WriteLine("the option is not correct");
                    break;
            }

        }
        public void SetPersonalHistory(string DeniedCoverage, string DeniedCoverageReason)
        {
            List<IWebElement> DeniedCoverageOption;
            switch (DeniedCoverage.ToLower().Trim())
            {
                case "no":
                    DeniedCoverageOption = driver.FindElements(By.XPath("//input[@id ='DoCancelDeny'and @value='False']")).ToList();
                    DeniedCoverageOption[0].Click();
                    break;
                case "yes":
                    DeniedCoverageOption = driver.FindElements(By.XPath("//input[@id ='DoCancelDeny'and @value='True']")).ToList();
                    DeniedCoverageOption[0].Click();
                    pause();
                    UIAction(txtareaDeniedCoverageReason, DeniedCoverageReason, "textbox");
                    break;
                default:
                    break;

            }
        }


        public void SetJewelryStorageDetails(string SafeDepositLocation, string SafeDepositAddress)
        {
            UIAction(txtSafeDepositLocation, SafeDepositLocation, "textbox");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab);
            pause();
            action.SendKeys(SafeDepositAddress);
            action.Perform();
            action.Release();
            pause();
            pause();


            //UIAction(txtSafeDepositAddress, string.Empty, "span");
            //UIAction(txtSafeDepositAddress, SafeDepositAddress, "textbox");
        }



        public void SetJewelryStorage(string SafeDeposit, string GatedCommunity, string DomesticHelp, string HomeHasOtherResidents, string JewelryWearFrequency, string ResidentsDesc)
        {
            List<IWebElement> SafeDepositOption;
            List<IWebElement> GatedCommunityOption;
            List<IWebElement> DomesticHelpOption;
            List<IWebElement> HomeHasOtherResidentsOption;

            switch (SafeDeposit.ToLower().Trim())
            {
                case "no":
                    SafeDepositOption = driver.FindElements(By.XPath("//input[@id ='HasSafeDepositBox'and @value='False']")).ToList();
                    SafeDepositOption[0].Click();
                    //UIAction(radioSafeDepositBoxNo, string.Empty, "span");
                    break;
                case "yes":
                    SafeDepositOption = driver.FindElements(By.XPath("//input[@id ='HasSafeDepositBox'and @value='True']")).ToList();
                    SafeDepositOption[0].Click();
                    //UIAction(radioSafeDepositBoxYes, string.Empty, "span");
                    pause();

                    break;
                default:
                    break;

            }

            switch (GatedCommunity.ToLower().Trim())
            {
                case "no":
                    GatedCommunityOption = driver.FindElements(By.XPath("//input[@id ='IsGated'and @value='False']")).ToList();
                    GatedCommunityOption[0].Click();
                    // UIAction(radioIsGatedNo, string.Empty, "span");
                    break;
                case "yes":
                    GatedCommunityOption = driver.FindElements(By.XPath("//input[@id ='IsGated'and @value='True']")).ToList();
                    GatedCommunityOption[0].Click();
                    //UIAction(radioIsGatedYes, string.Empty, "span");
                    pause();

                    break;
                default:
                    break;

            }

            switch (DomesticHelp.ToLower().Trim())
            {
                case "no":
                    DomesticHelpOption = driver.FindElements(By.XPath("//input[@id ='HasDomesticHelp'and @value='False']")).ToList();
                    DomesticHelpOption[0].Click();
                    //UIAction(radioHasDomesticHelpNo, string.Empty, "span");
                    break;
                case "yes":
                    DomesticHelpOption = driver.FindElements(By.XPath("//input[@id ='HasDomesticHelp'and @value='True']")).ToList();
                    DomesticHelpOption[0].Click();
                    //UIAction(radioHasDomesticHelpYes, string.Empty, "span");
                    pause();
                    break;
                default:
                    break;

            }

            switch (HomeHasOtherResidents.ToLower().Trim())
            {
                case "no":
                    HomeHasOtherResidentsOption = driver.FindElements(By.XPath("//input[@id ='HasOtherResident'and @value='False']")).ToList();
                    HomeHasOtherResidentsOption[0].Click();
                    //UIAction(radioHasOtherResidentNo, string.Empty, "span");
                    break;
                case "yes":
                    HomeHasOtherResidentsOption = driver.FindElements(By.XPath("//input[@id ='HasOtherResident'and @value='True']")).ToList();
                    HomeHasOtherResidentsOption[0].Click();
                    //UIAction(radioHasOtherResidentYes, string.Empty, "span");
                    pause();
                    Actions action = new Actions(driver);
                    action.SendKeys(Keys.Tab);
                    pause();
                    action.SendKeys(ResidentsDesc);
                    action.Perform();
                    action.Release();
                    pause();
                    pause();

                    break;
                default:
                    break;

            }

            UIAction(selectJewelryWornFrequency, JewelryWearFrequency, "selectbox");
        }

        public void SetGatedCommunityDetails(string GatedCommunityHasFence, string GatedCommunityHasGuard, string GatedCommunityGuardFrequency, string GatedCommunityHasPatrols, string Patrolfreuency, string GatedCommunityResidentEntranceDesc, string GatedCommunityGuestEntranceDesc)
        {
            List<IWebElement> GatedCommunityHasFenceOption;
            List<IWebElement> GatedCommunityHasGuardOption;
            List<IWebElement> GuardFrequencyOption;
            List<IWebElement> HasPatrolOption;
            List<IWebElement> PatrolsFrequencyOption;
            Actions action = new Actions(driver);
            switch (GatedCommunityHasFence.ToLower().Trim())
            {
                case "no":
                    GatedCommunityHasFenceOption = driver.FindElements(By.XPath("//input[@id ='HasFence'and @value='False']")).ToList();
                    GatedCommunityHasFenceOption[0].Click();
                    //UIAction(radioHasFenceNo, string.Empty, "span");
                    break;
                case "yes":
                    GatedCommunityHasFenceOption = driver.FindElements(By.XPath("//input[@id ='HasFence'and @value='True']")).ToList();
                    GatedCommunityHasFenceOption[0].Click();
                    //UIAction(radioHasFenceYes, string.Empty, "span");

                    break;
                default:
                    break;

            }

            switch (GatedCommunityHasGuard.ToLower().Trim())
            {
                case "no":
                    GatedCommunityHasGuardOption = driver.FindElements(By.XPath("//input[@id ='HasGuards'and @value='False']")).ToList();
                    GatedCommunityHasGuardOption[0].Click();
                    //UIAction(radioHasGuardsNo, string.Empty, "span");
                    break;
                case "yes":
                    GatedCommunityHasGuardOption = driver.FindElements(By.XPath("//input[@id ='HasGuards'and @value='True']")).ToList();
                    GatedCommunityHasGuardOption[0].Click();
                    //UIAction(radioHasGuardsYes, string.Empty, "span");
                    pause();
                    switch (GatedCommunityGuardFrequency.ToLower().Trim())
                    {
                        case "24 hours":
                            GuardFrequencyOption = driver.FindElements(By.XPath("//input[@id ='PatrolsFrequency'and @value='1']")).ToList();
                            GuardFrequencyOption[0].Click();
                            //UIAction(radioGuardFrequency24hrs, string.Empty, "span");
                            break;
                        case "night only":
                            GuardFrequencyOption = driver.FindElements(By.XPath("//input[@id ='PatrolsFrequency'and @value='2']")).ToList();
                            GuardFrequencyOption[0].Click();
                            //UIAction(radioPatrolsFrequencyNightOnly, string.Empty, "span");
                            pause();
                            break;
                        default:
                            break;

                    }
                    break;
                default:
                    break;

            }
            switch (GatedCommunityHasPatrols.ToLower().Trim())
            {
                case "no":
                    HasPatrolOption = driver.FindElements(By.XPath("//input[@id ='HasPatrols'and @value='False']")).ToList();
                    HasPatrolOption[0].Click();
                    //UIAction(radioHasPatrolsNo, string.Empty, "span");
                    break;
                case "yes":
                    HasPatrolOption = driver.FindElements(By.XPath("//input[@id ='HasPatrols'and @value='True']")).ToList();
                    HasPatrolOption[0].Click();
                    //UIAction(radioHasPatrolsYes, string.Empty, "span");
                    pause();
                    switch (Patrolfreuency.ToLower().Trim())
                    {
                        case "24 hours":
                            PatrolsFrequencyOption = driver.FindElements(By.XPath("//input[@id ='PatrolsFrequency'and @value='1']")).ToList();
                            PatrolsFrequencyOption[0].Click();
                            //UIAction(radioPatrolsFrequency24hrs, string.Empty, "span");
                            break;
                        case "night only":
                            PatrolsFrequencyOption = driver.FindElements(By.XPath("//input[@id ='PatrolsFrequency'and @value='2']")).ToList();
                            PatrolsFrequencyOption[0].Click();
                            //UIAction(radioPatrolsFrequencyNightOnly, string.Empty, "span");
                            pause();
                            break;
                        default:
                            break;

                    }

                    break;
                default:
                    break;

            }


            action.SendKeys(Keys.Tab);
            pause();
            action.SendKeys(GatedCommunityResidentEntranceDesc);
            pause();
            action.SendKeys(Keys.Tab);
            pause();
            action.SendKeys(GatedCommunityGuestEntranceDesc);
            pause();
            action.Perform();
            action.Release();
            pause();
            pause();

            //UIAction(txtareaDeniedCoverageReason, GatedCommunityResidentEntranceDesc, "textbox");
            //UIAction(txtareaDeniedCoverageReason, GatedCommunityGuestEntranceDesc, "textbox");

        }

        public void SetDomesticHelpDetails(string DomesticHelpDesc, string DomesticHelpEmploymentLength, string DomesticHelpIsLiveIn, string DomesticHelpFrequencyDesc)
        {
            List<IWebElement> DomesticHelpIsLiveInOption;
            UIAction(txtTypeofHelp, DomesticHelpDesc, "textbox");
            UIAction(txtHowLongEmployed, DomesticHelpEmploymentLength, "textbox");
            switch (DomesticHelpIsLiveIn.ToLower().Trim())
            {
                case "no":
                    DomesticHelpIsLiveInOption = driver.FindElements(By.XPath("//input[@id ='DoesHelpLiveWithYou'and @value='False']")).ToList();
                    DomesticHelpIsLiveInOption[0].Click();
                    //UIAction(radioDoesHelpLiveWithYouNo, string.Empty, "span");
                    pause();
                    UIAction(txtHowOften, DomesticHelpFrequencyDesc, "textbox");
                    break;
                case "yes":
                    DomesticHelpIsLiveInOption = driver.FindElements(By.XPath("//input[@id ='DoesHelpLiveWithYou'and @value='True']")).ToList();
                    DomesticHelpIsLiveInOption[0].Click();
                    //UIAction(radioDoesHelpLiveWithYouYes, string.Empty, "span");
                    pause();

                    break;
                default:
                    break;

            }
        }

        public void SetTavelDetails(string OvernightTravelFrequency, string TravelAbroad, string TravelPrecautionType, string TravelPrecautionOther)
        {
            List<IWebElement> TravelAbroadOption;
            UIAction(selectOvernightTravelFrequency, OvernightTravelFrequency, "selectbox");

            switch (TravelAbroad.ToLower().Trim())
            {
                case "no":
                    TravelAbroadOption = driver.FindElements(By.XPath("//input[@id ='IsTravelOverseas'and @value='True']")).ToList();
                    TravelAbroadOption[0].Click();
                    //UIAction(radioTravelAbroadNo, string.Empty, "span");
                    break;
                case "yes":
                    TravelAbroadOption = driver.FindElements(By.XPath("//input[@id ='IsTravelOverseas'and @value='False']")).ToList();
                    TravelAbroadOption[0].Click();
                    //UIAction(radioTravelAbroadYes, string.Empty, "span");
                    break;
                default:
                    break;

            }
            UIAction(selectTravelPrecautionType, TravelPrecautionType, "selectbox");
            if (string.Compare(TravelPrecautionType, "Other", StringComparison.OrdinalIgnoreCase) > 1)
            {
                UIAction(txtTravelPrecautionOther, TravelPrecautionOther, "selectbox");
            }


        }
        public void ClickSaveContinue()
        {
            UIAction(btnAdditionalQuestionSave, string.Empty, "a");
        }
        public void AddJewelry(string JewelryType, string ReplacingItem, string ValuedDate, string ReplacementValue, string Deductible, string JewelryWearer, string JewelryStored, string DateforCoverage, string AdditionalInformation)
        {
            WaitUntilElementIsDisplayed(driver, By.Id("jewelryitem_save"));
            pause();
            IList<IWebElement> ItemsType = driver.FindElements(By.XPath("//select[(id = 'JewelryItemType') and (text()='" + JewelryType + "')]")).ToList();
            Console.WriteLine("count is " + ItemsType.Count);
            if (ItemsType.Count > 0)
            {
                pause();
                ItemsType[ItemsType.Count - 1].Click();
            }

        }

    }
}

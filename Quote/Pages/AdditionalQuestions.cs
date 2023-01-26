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


namespace Quote.Pages
{
    class AdditionalQuestions : Page
    {
        string radioDeniedCoverageYes = "input[id$='DeniedCoverage-Yes']";
        string radioDeniedCoverageNo = "input[id$='DeniedCoverage-No']";
        string txtareaDeniedCoverageReason = "textarea[id$='DeniedCoverageReason']";
        string radioSafeDepositYes = "input[id$='SafeDeposit-Yes']";
        string radioSafeDepositNo = "input[id$='SafeDeposit-No']";
        string txtSafeDepositLocation = "input[id$='SafeDepositLocation']";
        string txtSafeDepositAddress = "input[id$='SafeDepositAddress']";
        string radioGatedCommunityYes = "input[id$='GatedCommunity-Yes']";
        string radioGatedCommunityNo = "input[id$='GatedCommunity-No']";
        string radioGatedCommunityHasFenceYes = "input[id$='GatedCommunityHasFence-Yes']";
        string radioGatedCommunityHasFenceNo = "input[id$='GatedCommunityHasFence-No']";
        string radioGatedCommunityHasGuardYes = "input[id$='GatedCommunityHasGuard-Yes']";
        string radioGatedCommunityHasGuardNo = "input[id$='GatedCommunityHasGuard-No']";
        string radioGatedCommunityGuardFrequency24Hours = "input[id$='GatedCommunityGuardFrequency-24 Hours']";
        string radioGatedCommunityGuardFrequencyNightonly = "input[id$='GatedCommunityGuardFrequency-Night only']";
        string radioGatedCommunityHasPatrolsYes = "input[id$='GatedCommunityHasPatrols-Yes']";
        string radioGatedCommunityHasPatrolsNo = "input[id$='GatedCommunityHasPatrols-No']";
        string radioGatedCommunityPatrolFrequency24Hours = "input[id$='GatedCommunityPatrolFrequency-24 Hours']";
        string radioGatedCommunityPatrolFrequencyNightonly = "input[id$='GatedCommunityPatrolFrequency-Night only']";
        string txtGatedCommunityResidentEntranceDesc = "textarea[id$='GatedCommunityResidentEntranceDesc']";
        string txtGatedCommunityGuestEntranceDesc = "textarea[id$='GatedCommunityGuestEntranceDesc']";
        string radioEmploysDomesticHelpYes = "input[id$='EmploysDomesticHelp-Yes']";
        string radioEmploysDomesticHelpNo = "input[id$='EmploysDomesticHelp-No']";
        string txtDomesticHelpDesc = "input[id$='DomesticHelpDesc']";
        string txtDomesticHelpEmploymentLength = "input[id$='DomesticHelpEmploymentLength']";
        string radioDomesticHelpIsLiveInYes = "input[id$='DomesticHelpIsLiveIn-Yes']";
        string radioDomesticHelpIsLiveInNo = "input[id$='DomesticHelpIsLiveIn-No']";
        string txtDomesticHelpFrequencyDesc = "input[id$='DomesticHelpFrequencyDesc']";
        string radioHomeHasOtherResidentsYes = "input[id$='HomeHasOtherResidents-Yes']";
        string radioHomeHasOtherResidentsNo = "input[id$='HomeHasOtherResidents-No']";
        string txtOtherResidentsDesc = "textarea[id$='OtherResidentsDesc']";
        string selectJewelryWearFrequency = "Select[id$='JewelryWearFrequency']";
        string selectOvernightTravelFrequency = "Select[id$='OvernightTravelFrequency']";
        string radioTravelAbroadYes = "input[id$='TravelAbroad-Yes']";
        string radioTravelAbroadNo = "input[id$='TravelAbroad-No']";
        string btnadditionalQuestionsNext = "a[id$='additionalQuestionsNext']";
        string selectTravelPrecautionType = "Select[id$='TravelPrecautionType']";
        string txtTravelPrecautionOther = "textarea[id$='TravelPrecautionOther']";






        public AdditionalQuestions(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnadditionalQuestionsNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(btnadditionalQuestionsNext));
        }

        public void SetPersonalHistory(string DeniedCoverage, string DeniedCoverageReason)
        {
            switch (DeniedCoverage.ToLower().Trim())
            {
                case "no":
                    UIAction(radioDeniedCoverageNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioDeniedCoverageYes, string.Empty, "span");
                    pause();
                    UIAction(txtareaDeniedCoverageReason, DeniedCoverageReason, "textbox");
                    break;
                default:
                    break;

            }
        }

        public void SetJewelryStorage(string SafeDeposit, string SafeDepositLocation, string SafeDepositAddress, string GatedCommunity, string DomesticHelp, string HomeHasOtherResidents, string ResidentsDesc, string JewelryWearFrequency)
        {
            switch (SafeDeposit.ToLower().Trim())
            {
                case "no":
                    UIAction(radioSafeDepositNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioSafeDepositYes, string.Empty, "span");
                    pause();
                    UIAction(txtSafeDepositLocation, SafeDepositLocation, "textbox");
                    UIAction(txtSafeDepositAddress, SafeDepositAddress, "textbox");
                    break;
                default:
                    break;

            }

            switch (GatedCommunity.ToLower().Trim())
            {
                case "no":
                    UIAction(radioGatedCommunityNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioGatedCommunityYes, string.Empty, "span");
                    pause();
                   
                    break;
                default:
                    break;

            }

            switch (DomesticHelp.ToLower().Trim())
            {
                case "no":
                    UIAction(radioEmploysDomesticHelpNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioEmploysDomesticHelpYes, string.Empty, "span");
                    pause();

                    break;
                default:
                    break;

            }

            switch (HomeHasOtherResidents.ToLower().Trim())
            {
                case "no":
                    UIAction(radioHomeHasOtherResidentsNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioHomeHasOtherResidentsYes, string.Empty, "span");
                    pause();
                    UIAction(txtOtherResidentsDesc, ResidentsDesc, "textbox");
                    break;
                default:
                    break;

            }

            UIAction(selectJewelryWearFrequency, JewelryWearFrequency.ToUpper(), "selectbox");
        }

        public void SetGatedCommunityDetails(string GatedCommunityHasFence, string GatedCommunityHasGuard, string GatedCommunityGuardFrequency, string GatedCommunityHasPatrols, string GatedCommunityResidentEntranceDesc, string GatedCommunityGuestEntranceDesc)
        {
            switch (GatedCommunityHasFence.ToLower().Trim())
            {
                case "no":
                    UIAction(radioGatedCommunityHasFenceNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioGatedCommunityHasFenceYes, string.Empty, "span");
                
                    break;
                default:
                    break;

            }

            switch (GatedCommunityHasGuard.ToLower().Trim())
            {
                case "no":
                    UIAction(radioGatedCommunityHasGuardNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioGatedCommunityHasGuardYes, string.Empty, "span");
                    pause();
                    switch (GatedCommunityGuardFrequency.ToLower().Trim())
                    {
                        case "24hours":
                            UIAction(radioGatedCommunityGuardFrequency24Hours, string.Empty, "span");
                            break;
                        case "night":
                            UIAction(radioGatedCommunityGuardFrequencyNightonly, string.Empty, "span");
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
                    UIAction(radioGatedCommunityHasPatrolsNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioGatedCommunityHasPatrolsYes, string.Empty, "span");
                    pause();
                    switch (GatedCommunityGuestEntranceDesc.ToLower().Trim())
                    {
                        case "24hours":
                            UIAction(radioGatedCommunityPatrolFrequency24Hours, string.Empty, "span");
                            break;
                        case "night":
                            UIAction(radioGatedCommunityPatrolFrequencyNightonly, string.Empty, "span");
                            pause();
                            break;
                        default:
                            break;

                    }
                    break;
                default:
                    break;

            }
  
            UIAction(txtareaDeniedCoverageReason, GatedCommunityResidentEntranceDesc, "textbox");
            UIAction(txtareaDeniedCoverageReason, GatedCommunityGuestEntranceDesc, "textbox");

        }

        public void SetDomesticHelpDetails(string DomesticHelpDesc, string DomesticHelpEmploymentLength, string DomesticHelpIsLiveIn, string DomesticHelpFrequencyDesc)
        {
            UIAction(txtDomesticHelpDesc, DomesticHelpDesc, "textbox");
            UIAction(txtDomesticHelpEmploymentLength, DomesticHelpEmploymentLength, "textbox");
            switch (DomesticHelpIsLiveIn.ToLower().Trim())
            {
                case "no":
                    UIAction(radioDomesticHelpIsLiveInNo, string.Empty, "span");
                    pause();
                    UIAction(txtDomesticHelpFrequencyDesc, DomesticHelpFrequencyDesc, "textbox");
                    break;
                case "yes":
                    UIAction(radioDomesticHelpIsLiveInYes, string.Empty, "span");
                    pause();

                    break;
                default:
                    break;

            }
        }

        public void SetTavelDetails(string OvernightTravelFrequency, string TravelAbroad, string TravelPrecautionType, string TravelPrecautionOther)
        {
            UIAction(selectOvernightTravelFrequency, OvernightTravelFrequency, "selectbox");

            switch (TravelAbroad.ToLower().Trim())
            {
                case "no":
                    UIAction(radioTravelAbroadNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioTravelAbroadYes, string.Empty, "span");
                   break;
                default:
                    break;

            }
            UIAction(selectTravelPrecautionType, TravelPrecautionType, "selectbox");
            if (string.Compare(TravelPrecautionType, "Other", StringComparison.OrdinalIgnoreCase) > 1)
            {
                UIAction(txtTravelPrecautionOther, TravelPrecautionOther, "selectbox");
            }
            pause();
            UIAction(btnadditionalQuestionsNext, string.Empty, "span");

        }
        }
    }

}

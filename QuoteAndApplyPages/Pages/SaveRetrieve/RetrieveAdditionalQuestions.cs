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
using OpenQA.Selenium.Support.UI;


namespace QuoteAndApplyPages.Pages.SaveRetrieve
{
    public class RetrieveAdditionalQuestions : Page
    {
       
        string btnadditionalQuestionsNext = "a[id$='additionalQuestionsNext']";
   




        public RetrieveAdditionalQuestions(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            // SetActiveFrame();

            VerifyUIElementIsDisplayed(btnadditionalQuestionsNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(btnadditionalQuestionsNext));
        }


        public void comparevalue(string expectedvalue, string actualvalue, string paramater)
        {
            if (expectedvalue.Length > 0)
            {
                if (expectedvalue.ToLower().Trim().Equals(actualvalue.ToLower().Trim()))
                {
                    System.Console.WriteLine("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " matches");
                }
                else
                {
                    System.Console.WriteLine("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " do not matches");
                    Assert.Fail("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " do not matches");
                }
            }

        }



        public void verifyPersonalHistory(string DeniedCoverage, string DeniedCoverageReason)
        {
            IWebElement radioDeniedCoverag;
            IWebElement txtareaDeniedCoverageReason;
            switch (DeniedCoverage.ToLower().Trim())
            {
               case "no":
                    radioDeniedCoverag = driver.FindElement(By.XPath("//input[@id='DeniedCoverage-No']"));
                    comparevalue("True", radioDeniedCoverag.GetAttribute("checked"), "DeniedCoverage-No");
                    break;
                case "yes":
                    radioDeniedCoverag = driver.FindElement(By.XPath("//input[@id='DeniedCoverage-Yes']"));
                    comparevalue("True", radioDeniedCoverag.GetAttribute("checked"), "DeniedCoverage-Yes");
                    txtareaDeniedCoverageReason = driver.FindElement(By.XPath("//input[@id='DeniedCoverageReason']"));
                    comparevalue(DeniedCoverageReason, txtareaDeniedCoverageReason.GetAttribute("value"), "DeniedCoverageReason");
                  
                    break;
                default:
                    break;

            }
        }


        public void verifyJewelryStorage(string SafeDeposit, string GatedCommunity, string DomesticHelp, string HomeHasOtherResidents, string JewelryWearFrequency, string ResidentsDesc)
        {
            IWebElement radioSafeDeposit;
            IWebElement radioGatedCommunity;
            IWebElement radioDomesticHelp;
            IWebElement radioHomeHasOtherResidents;
            IWebElement OtherResidentsDesc;
            IWebElement ListJewelryWearFrequency;
            switch (SafeDeposit.ToLower().Trim())
            {
                case "no":
                    radioSafeDeposit = driver.FindElement(By.XPath("//input[@id='SafeDeposit-No']"));
                    comparevalue("True", radioSafeDeposit.GetAttribute("checked"), "SafeDeposit-No");
                    break;
                case "yes":
                    radioSafeDeposit = driver.FindElement(By.XPath("//input[@id='SafeDeposit-Yes']"));
                    comparevalue("True", radioSafeDeposit.GetAttribute("checked"), "SafeDeposit-Yes");
                    break;
                default:
                    break;

            }

            switch (GatedCommunity.ToLower().Trim())
            {
                case "no":
                    radioGatedCommunity = driver.FindElement(By.XPath("//input[@id='GatedCommunity-No']"));
                    comparevalue("True", radioGatedCommunity.GetAttribute("checked"), "GatedCommunity-No");
                    break;
                case "yes":
                    radioGatedCommunity = driver.FindElement(By.XPath("//input[@id='GatedCommunity-Yes']"));
                    comparevalue("True", radioGatedCommunity.GetAttribute("checked"), "GatedCommunity-Yes");
                    break;
                default:
                    break;

            }

            switch (DomesticHelp.ToLower().Trim())
            {
                case "no":
                    radioDomesticHelp = driver.FindElement(By.XPath("//input[@id='EmploysDomesticHelp-No']"));
                    comparevalue("True", radioDomesticHelp.GetAttribute("checked"), "EmploysDomesticHelp-No");
                    break;
                case "yes":
                    radioDomesticHelp = driver.FindElement(By.XPath("//input[@id='EmploysDomesticHelp-Yes']"));
                    comparevalue("True", radioDomesticHelp.GetAttribute("checked"), "EmploysDomesticHelp-Yes");
                    break;
                default:
                    break;

            }

            switch (HomeHasOtherResidents.ToLower().Trim())
            {
                case "no":
                    radioHomeHasOtherResidents = driver.FindElement(By.XPath("//input[@id='HomeHasOtherResidents-No']"));
                    comparevalue("True", radioHomeHasOtherResidents.GetAttribute("checked"), "HomeHasOtherResidents-No");
                    break;
                case "yes":
                    radioHomeHasOtherResidents = driver.FindElement(By.XPath("//input[@id='HomeHasOtherResidents-Yes']"));
                    comparevalue("True", radioHomeHasOtherResidents.GetAttribute("checked"), "HomeHasOtherResidents-Yes");

                    OtherResidentsDesc = driver.FindElement(By.XPath("//textarea[@id='OtherResidentsDesc']"));
                    comparevalue(ResidentsDesc, OtherResidentsDesc.GetAttribute("value"), "OtherResidentsDesc");
                    break;
                default:
                    break;

            }

            ListJewelryWearFrequency = driver.FindElement(By.XPath("//select[@id='JewelryWearFrequency']"));
            SelectElement selectedValue = new SelectElement(ListJewelryWearFrequency);
            comparevalue(JewelryWearFrequency, selectedValue.Options[Int32.Parse(ListJewelryWearFrequency.GetAttribute("value"))].Text, "JewelryWearFrequency");
        }

        public void verifyJewelryStorageDetails(string SafeDepositLocation, string SafeDepositAddress)
        {
            IWebElement txtSafeDepositLocation;
            IWebElement txtareaSafeDepositAddress;

            txtSafeDepositLocation = driver.FindElement(By.XPath("//input[@id='SafeDepositLocation']"));
            comparevalue(SafeDepositLocation, txtSafeDepositLocation.GetAttribute("value"), "SafeDepositLocation");

            txtareaSafeDepositAddress = driver.FindElement(By.XPath("//textarea[@id='SafeDepositAddress']"));
            comparevalue(SafeDepositAddress, txtareaSafeDepositAddress.GetAttribute("value"), "SafeDepositAddress");


        }





        public void verifyCommunityDetails(string GatedCommunityHasFence, string GatedCommunityHasGuard, string GatedCommunityGuardFrequency, string GatedCommunityHasPatrols, string Patrolfreuency, string GatedCommunityResidentEntranceDesc, string GatedCommunityGuestEntranceDesc)
        {
            IWebElement radioGatedCommunityHasFence;
            IWebElement radioGatedCommunityHasGuard;
            IWebElement radioGatedCommunityGuardFrequency;
            IWebElement radioGatedCommunityHasPatro;
            IWebElement radioGatedCommunityPatrolFrequency;
            IWebElement txtareaGatedCommunityResidentEntranceDesc;
            IWebElement txtareaGatedCommunityGuestEntranceDesc;

            switch (GatedCommunityHasFence.ToLower().Trim())
            {
                case "no":
                    radioGatedCommunityHasFence = driver.FindElement(By.XPath("//input[@id=GatedCommunityHasFence-No']"));
                    comparevalue("True", radioGatedCommunityHasFence.GetAttribute("checked"), "GatedCommunityHasFence-No");
                    break;
                case "yes":
                    radioGatedCommunityHasFence = driver.FindElement(By.XPath("//input[@id=GatedCommunityHasFence-Yes']"));
                    comparevalue("True", radioGatedCommunityHasFence.GetAttribute("checked"), "GatedCommunityHasFence-Yes");
                    break;
                default:
                    break;

            }

            switch (GatedCommunityHasGuard.ToLower().Trim())
            {
                case "no":
                    radioGatedCommunityHasGuard = driver.FindElement(By.XPath("//input[@id=GatedCommunityHasGuard-No']"));
                    comparevalue("True", radioGatedCommunityHasGuard.GetAttribute("checked"), "GatedCommunityHasGuard-No");
                    break;
                case "yes":
                    radioGatedCommunityHasGuard = driver.FindElement(By.XPath("//input[@id=GatedCommunityHasGuard-Yes']"));
                    comparevalue("True", radioGatedCommunityHasGuard.GetAttribute("checked"), "GatedCommunityHasGuard-Yes");
                    switch (GatedCommunityGuardFrequency.ToLower().Trim())
                    {
                        case "24 hours":
                            radioGatedCommunityGuardFrequency = driver.FindElement(By.XPath("//input[@id=GatedCommunityGuardFrequency-24 Hours']"));
                            comparevalue("True", radioGatedCommunityGuardFrequency.GetAttribute("checked"), "GatedCommunityGuardFrequency-24 Hours");
                            break;
                        case "night only":
                            radioGatedCommunityGuardFrequency = driver.FindElement(By.XPath("//input[@id=GatedCommunityGuardFrequency-Night only']"));
                            comparevalue("True", radioGatedCommunityGuardFrequency.GetAttribute("checked"), "GatedCommunityGuardFrequency-Night only");

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
                    radioGatedCommunityHasPatro = driver.FindElement(By.XPath("//input[@id=GatedCommunityHasPatrols-No']"));
                     comparevalue("True", radioGatedCommunityHasPatro.GetAttribute("checked"), "GatedCommunityHasPatrols-No");
                     break;
                case "yes":
                    radioGatedCommunityHasPatro = driver.FindElement(By.XPath("//input[@id=GatedCommunityHasPatrols-Yes']"));
                    comparevalue("True", radioGatedCommunityHasPatro.GetAttribute("checked"), "GatedCommunityHasPatrols-Yes");

            switch (Patrolfreuency.ToLower().Trim())
                    {
                        case "24 hours":
                             radioGatedCommunityPatrolFrequency = driver.FindElement(By.XPath("//input[@id=GatedCommunityPatrolFrequency-24 Hours']"));
                            comparevalue("True", radioGatedCommunityPatrolFrequency.GetAttribute("checked"), "GatedCommunityPatrolFrequency-24 Hours");
                            break;
                        case "night only":
                            radioGatedCommunityPatrolFrequency = driver.FindElement(By.XPath("//input[@id=GatedCommunityPatrolFrequency-Night only']"));
                            comparevalue("True", radioGatedCommunityPatrolFrequency.GetAttribute("checked"), "GatedCommunityPatrolFrequency-Night only");
                            break;

                        default:
                            break;

                    }

                    break;
                default:
                    break;

            }

           

            txtareaGatedCommunityResidentEntranceDesc = driver.FindElement(By.XPath("//textarea[@id='GatedCommunityResidentEntranceDesc']"));
            comparevalue(GatedCommunityResidentEntranceDesc, txtareaGatedCommunityResidentEntranceDesc.GetAttribute("value"), "GatedCommunityResidentEntranceDesc");

            txtareaGatedCommunityGuestEntranceDesc = driver.FindElement(By.XPath("//textarea[@id='GatedCommunityGuestEntranceDesc']"));
            comparevalue(GatedCommunityGuestEntranceDesc, txtareaGatedCommunityGuestEntranceDesc.GetAttribute("value"), "GatedCommunityGuestEntranceDesc");
   
        }

        public void verifyDomesticHelpDetails(string DomesticHelpDesc, string DomesticHelpEmploymentLength, string DomesticHelpIsLiveIn, string DomesticHelpFrequencyDesc)
        {
            IWebElement txtDomesticHelpDesc;
            IWebElement txtDomesticHelpEmploymentLength;
            IWebElement radioDomesticHelpIsLiveIn;

            txtDomesticHelpDesc = driver.FindElement(By.XPath("//input[@id='DomesticHelpDesc']"));
            comparevalue(DomesticHelpDesc, txtDomesticHelpDesc.GetAttribute("value"), "DomesticHelpDesc");

            txtDomesticHelpEmploymentLength = driver.FindElement(By.XPath("//input[@id='DomesticHelpEmploymentLength']"));
            comparevalue(DomesticHelpEmploymentLength, txtDomesticHelpEmploymentLength.GetAttribute("value"), "DomesticHelpEmploymentLength");

            switch (DomesticHelpIsLiveIn.ToLower().Trim())
            {


                case "no":
                    radioDomesticHelpIsLiveIn = driver.FindElement(By.XPath("//input[@id='HomeHasOtherResidents-No']"));
                    comparevalue("True", radioDomesticHelpIsLiveIn.GetAttribute("checked"), "HomeHasOtherResidents-No");
                    txtDomesticHelpEmploymentLength = driver.FindElement(By.XPath("//textarea[@id='OtherResidentsDesc']"));
                    comparevalue(DomesticHelpEmploymentLength, txtDomesticHelpEmploymentLength.GetAttribute("value"), "OtherResidentsDesc");

                    break;
                case "yes":
                    radioDomesticHelpIsLiveIn = driver.FindElement(By.XPath("//input[@id='HomeHasOtherResidents-Yes']"));
                    comparevalue("True", radioDomesticHelpIsLiveIn.GetAttribute("checked"), "HomeHasOtherResidents-Yes");
                    break;
                default:
                    break;



               

            }
        }

        public void verifyTavelDetails(string OvernightTravelFrequency, string TravelAbroad, string TravelPrecautionType, string TravelPrecautionOther)
        {
            IWebElement selectOvernightTravelFrequency;
            IWebElement radioTravelAbroad;
            IWebElement selectTravelPrecaution;
            IWebElement txtareaTravelPrecautionOther;


            selectOvernightTravelFrequency = driver.FindElement(By.XPath("//select[@id='OvernightTravelFrequency']"));
            SelectElement selectedValue = new SelectElement(selectOvernightTravelFrequency);
            comparevalue(OvernightTravelFrequency, selectedValue.Options[Int32.Parse(selectOvernightTravelFrequency.GetAttribute("value"))].Text, "OvernightTravelFrequency");


            

            switch (TravelAbroad.ToLower().Trim())
            {
                case "no":
                    radioTravelAbroad = driver.FindElement(By.XPath("//input[@id='TravelAbroad-No']"));
                    comparevalue("True", radioTravelAbroad.GetAttribute("checked"), "TravelAbroad-No");
                    break;
                case "yes":
                    radioTravelAbroad = driver.FindElement(By.XPath("//input[@id='TravelAbroad-Yes']"));
                    comparevalue("True", radioTravelAbroad.GetAttribute("checked"), "TravelAbroad-Yes");
                    break;
                default:
                    break;
            }

            selectTravelPrecaution = driver.FindElement(By.XPath("//select[@id='TravelPrecautionType']"));
            selectedValue = new SelectElement(selectTravelPrecaution);
            comparevalue(TravelPrecautionType, selectedValue.Options[Int32.Parse(selectTravelPrecaution.GetAttribute("value"))].Text, "TravelPrecautionType");

           if (string.Compare(TravelPrecautionType, "Other", StringComparison.OrdinalIgnoreCase) > 1)
            {

                txtareaTravelPrecautionOther = driver.FindElement(By.XPath("//textarea[@id='TravelPrecautionOther']"));
                comparevalue(TravelPrecautionOther, txtareaTravelPrecautionOther.GetAttribute("value"), "TravelPrecautionOther");


            }
            pause();
            UIAction(btnadditionalQuestionsNext, string.Empty, "span");

        }
    }
}



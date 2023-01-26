using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;
using HelperClasses;
using OpenQA.Selenium.Interactions;

namespace PolicyCenter9Pages.Pages.JPA
{
    public class AdditionalUWPC9 : Page
    {
        string lblAdditionalUWDetaisl = "span[id$=':JPAUWQuestionsScreen:ListTitle']";
        string labelConsumerReportConsentNo = "input[Id$=':ApplicationConsentGivenId_false-inputEl']";
        string btnNextArticlesItem = "span[id$=':Next-btnInnerEl']";

        private const string additionalQuestionDetailsAvailableYesCSS = "input[id$=':hasAdditionalDetailsId_true-inputEl']";
        private const string additionalQuestionDetailsAvailableNoCSS = "input[id$=':hasAdditionalDetailsId_false-inputEl']";

        string radioGatedCommunityYes = "input[id$=':isgatedcommunityid_true-inputEl']";
        string radioGatedCommunityNo = "input[id$=':isgatedcommunityid_false-inputEl']";
        string radioEmploysDomesticHelpYes = "input[id$=':employdomestichelp_true-inputEl']";
        string radioEmploysDomesticHelpNo = "input[id$=':employdomestichelp_false-inputEl']";
        string radioHomeHasOtherResidentsYes = "input[id$=':doothersstayingathomeid_true-inputEl']";
        string radioHomeHasOtherResidentsNo = "input[id$=':doothersstayingathomeid_false-inputEl']";

        string radioGatedCommunityHasFenceYes = "input[id$=':isfencesorroundedID_true-inputEl']";
        string radioGatedCommunityHasFenceNo = "input[id$=':isfencesorroundedID_false-inputEl']";

        string radioGatedCommunityHasGuardYes = "input[id$=':arethranyguardsid_true-inputEl']";
        string radioGatedCommunityHasGuardNo = "input[id$=':arethranyguardsid_false-inputEl']";
        string selguardpresent = "input[id$=':guardsshift-inputEl']";

        string radioGatedCommunityHasPatrolsYes = "input[id$=':communitypatrolsid_true-inputEl']";
        string radioGatedCommunityHasPatrolsNo = "input[id$=':communitypatrolsid_false-inputEl']";
        string selfrequencypatrols = "input[id$=':frequencypatrolsid-inputEl']";

        string selgainentrance = "input[id$=':gainentranceid-inputEl']";
        string selguestentrance = "input[id$=':guestentranceid-inputEl']";

        string seldomeshelp = "input[id$=':typesofdomeshelpid-inputEl']";
        string seldomesemloyedlen = "input[id$=':durationdomeshelpid-inputEl']";

        string radioDomesticHelpIsLiveInYes = "input[id$=':domeshelpstayathomeid_true-inputEl']";
        string radioDomesticHelpIsLiveInNo = "input[id$=':domeshelpstayathomeid_false-inputEl']";

        string selDomesticHelpFrequencyDesc = "input[id$=':fredomeshelpathomeid-inputEl']";
        string selresideathome = "input[id$=':othersstatyingathoome-inputEl']";
        string selarticleworn = "input[id$=':frequencyofarticleswornid-inputEl']";
        string seloccuption = "input[id$=':occupationid-inputEl']";

        string selectOvernightTravelFrequency = "input[id$=':frequencyoftravelid-inputEl']";
        string radioTravelAbroadYes = "input[id$=':abroadtravelid_true-inputEl']";
        string radioTravelAbroadNo = "input[id$=':abroadtravelid_false-inputEl']";
        string selectTravelPrecautionType = "input[id$=':saveguardsid-inputEl']";


        public AdditionalUWPC9(IWebDriver driver) : base(driver)
        {


        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblAdditionalUWDetaisl);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblAdditionalUWDetaisl));
        }

        public void ClickNextButton()
        {
            UIAction(btnNextArticlesItem, string.Empty, "a");
            // WaitUntilElementVisible(driver, By.CssSelector(lblAdditionaldetails), 120);

        }

        // public void updatecommunityinformation()

        public void SetGatedCommunityDetails(string GatedCommunityHasFence, string GatedCommunityHasGuard, string GatedCommunityGuardFrequency, string GatedCommunityHasPatrols, string Patrolfreuency, string GatedCommunityResidentEntranceDesc, string GatedCommunityGuestEntranceDesc)
        {
            Actions action = new Actions(driver);
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


            switch (GatedCommunityGuestEntranceDesc.ToLower().Trim())
            {
                case "security guard":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selguestentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Security Guard']"))).Click();
                    break;
                case "keypad":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selguestentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Keypad']"))).Click();
                    break;
                case "card reader":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selguestentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Card Reader']"))).Click();
                    break;
                case "intercom":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selguestentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Intercom/Voice']"))).Click();
                    break;
                case "remote opener":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selguestentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Remote Opener']"))).Click();
                    break;
                case "other":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selguestentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Other']"))).Click();
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
                    WaitUntilElementVisible(driver, By.CssSelector(selguardpresent), 50);
                    switch (GatedCommunityGuardFrequency.ToLower().Trim())
                    {
                        case "24 hours":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selguardpresent)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='24 hours']"))).Click();
                            break;
                        case "night only":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selguardpresent)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Night Only']"))).Click();
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
                    WaitUntilElementVisible(driver, By.CssSelector(selfrequencypatrols), 50);
                    switch (Patrolfreuency.ToLower().Trim())
                    {
                        case "24 hours":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selfrequencypatrols)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='24 hours']"))).Click();
                            break;
                        case "night only":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selfrequencypatrols)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Night Only']"))).Click();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            switch (GatedCommunityResidentEntranceDesc.ToLower().Trim())
            {
                case "security guard":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selgainentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Security Guard']"))).Click();
                    break;
                case "keypad":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selgainentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Keypad']"))).Click();
                    break;
                case "card reader":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selgainentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Card Reader']"))).Click();
                    break;
                case "intercom":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selgainentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Intercom/Voice']"))).Click();
                    break;
                case "remote opener":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selgainentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Remote Opener']"))).Click();
                    break;
                case "other":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selgainentrance)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Other']"))).Click();
                    break;

                default:
                    break;

            }



            pause();
        }

        public void Setlocationdetails(string GatedCommunity, string DomesticHelp, string HomeHasOtherResidents, string selresideathomeoption, string additionalLocationDetails = "No")
        {
            switch (additionalLocationDetails.ToLower().Trim())
            {
                case "no":
                    JavaScriptClick(driver.FindElement(By.CssSelector(additionalQuestionDetailsAvailableNoCSS)));
                    break;
                case "yes":
                    JavaScriptClick(driver.FindElement(By.CssSelector(additionalQuestionDetailsAvailableYesCSS)));
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
                    break;
                default:
                    break;

            }

            switch (HomeHasOtherResidents.ToLower().Trim())
            {
                case "no":
                    //UIAction(radioHomeHasOtherResidentsNo, string.Empty, "span");
                    UIActionExt(By.CssSelector(radioHomeHasOtherResidentsNo), "click");
                    break;
                case "yes":
                    UIActionExt(By.CssSelector(radioHomeHasOtherResidentsYes), "click");


                    WaitUntilElementVisible(driver, By.CssSelector(selresideathome), 50);
                    //   UIActionExt(By.CssSelector(selresideathome), "click");
                    Console.WriteLine("outside partner");
                    switch (selresideathomeoption.ToLower().Trim())
                    {
                        case "parents":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selresideathome)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Parent(s)']"))).Click();
                            break;
                        case "children":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selresideathome)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Child(ren)']"))).Click();
                            break;
                        case "other relatives":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selresideathome)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Other Relative(s)']"))).Click();
                            break;
                        case "siblings":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selresideathome)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Siblings']"))).Click();
                            break;


                        case "partner":
                            Console.WriteLine("inside partner1");
                            driver.FindElement(By.CssSelector(selresideathome)).Click();
                            //JavaScriptClick(driver.FindElement(By.CssSelector(selresideathome)));
                            pause();
                            Console.WriteLine("inside partner");
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Partner']"))).Click();
                            break;
                        case "roomates":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selresideathome)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Roomate(s)']"))).Click();
                            break;
                        case "other":
                            JavaScriptClick(driver.FindElement(By.CssSelector(selresideathome)));
                            WaitFor(driver.FindElement(By.XPath("//li[text()='Other']"))).Click();
                            break;


                        default:
                            break;

                    }
                    break;
                default:
                    break;
            }

        }

        public void SetDomesticHelpDetails(string typeofhelp, string DomesticHelpEmploymentLength, string DomesticHelpIsLiveIn, string DomesticHelpFrequencyDesc)
        {
            switch (typeofhelp.ToLower().Trim())
            {
                case "housekeeper":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomeshelp)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Housekeeper/Maid']"))).Click();
                    break;
                case "medical assistant":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomeshelp)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Medical Assistant']"))).Click();
                    break;
                case "caregiver":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomeshelp)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Caregiver/Babysitter']"))).Click();
                    break;
                case "cook":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomeshelp)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Cook/Chef']"))).Click();
                    break;
                case "other":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomeshelp)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Other']"))).Click();
                    break;

                default:
                    break;

            }
            switch (DomesticHelpEmploymentLength.ToLower().Trim())
            {
                case "less than a month ago":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomesemloyedlen)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Less than a month ago']"))).Click();
                    break;
                case "less than 1 year ago":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomesemloyedlen)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Less than 1 year ago']"))).Click();
                    break;
                case "less than 2 year ago":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomesemloyedlen)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Less than 2 year ago']"))).Click();
                    break;
                case "more than 2 year ago":
                    JavaScriptClick(driver.FindElement(By.CssSelector(seldomesemloyedlen)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='More than 2 year ago']"))).Click();
                    break;


                default:
                    break;

            }
            switch (DomesticHelpIsLiveIn.ToLower().Trim())
            {
                case "no":
                    UIAction(radioDomesticHelpIsLiveInNo, string.Empty, "span");
                    break;
                case "yes":
                    UIAction(radioDomesticHelpIsLiveInYes, string.Empty, "span");
                    break;
                default:
                    break;
            }
            pause();
            switch (DomesticHelpFrequencyDesc.ToLower().Trim())
            {
                case "daily":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selDomesticHelpFrequencyDesc)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='Daily']"))).Click();
                    break;
                case "1-2 times a week":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selDomesticHelpFrequencyDesc)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='1-2 times a week']"))).Click();
                    break;
                case "3-5 times a week":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selDomesticHelpFrequencyDesc)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='3-5 times a week']"))).Click();
                    break;
                case "1-2 times a month":
                    JavaScriptClick(driver.FindElement(By.CssSelector(selDomesticHelpFrequencyDesc)));
                    WaitFor(driver.FindElement(By.XPath("//li[text()='1-2 times a month']"))).Click();
                    break;


                default:
                    break;

            }
        }


        public void SetContactDetails(string ArticlewornFrequency, string CurrentOccuption, string OvernightTravelFrequency, string TravelAbroad, string TravelPrecautionType)
        {
            var element = driver.FindElement(By.CssSelector(seloccuption));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

            JavaScriptClick(driver.FindElement(By.CssSelector(seloccuption)));
            WaitFor(driver.FindElement(By.XPath("//li[text()='" + CurrentOccuption + "']"))).Click();

            JavaScriptClick(driver.FindElement(By.CssSelector(selectOvernightTravelFrequency)));
            WaitFor(driver.FindElement(By.XPath("//li[text()='" + OvernightTravelFrequency + "']"))).Click();

            JavaScriptClick(driver.FindElement(By.CssSelector(selarticleworn)));
            WaitFor(driver.FindElement(By.XPath("//li[text()='" + ArticlewornFrequency + "']"))).Click();

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

            JavaScriptClick(driver.FindElement(By.CssSelector(selectTravelPrecautionType)));
            WaitFor(driver.FindElement(By.XPath("//li[text()='" + TravelPrecautionType + "']"))).Click();


        }


        public void SelectonLocation(int Itemcounter)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:JPAUWQuestionsScreen:JPAUWQuestionsPanelSet:JPALocationsLV-body")).ToList();
            System.Console.WriteLine("reservetableObj count is " + reservetableObj.Count());
            var tabletemp = reservetableObj[0].FindElements(By.TagName("table"));
            tabletemp[Itemcounter].Click();
            pause();
            pause();

        }

        public void SelectonContact(int Itemcounter)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:JPAUWQuestionsScreen:JPAUWQuestionsPanelSet:PolicyContactRoleDP:PolicyContactRoleLV-body")).ToList();
            System.Console.WriteLine("reservetableObj count is " + reservetableObj.Count());
            var tabletemp = reservetableObj[0].FindElements(By.TagName("table"));
            tabletemp[Itemcounter].Click();
            pause();
            pause();

        }

        public void SetContactDetails(string ArticlewornFrequency, string CurrentOccuption, string OvernightTravelFrequency)
        {
            var element = driver.FindElement(By.CssSelector(seloccuption));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

            JavaScriptClick(driver.FindElement(By.CssSelector(seloccuption)));
            WaitFor(driver.FindElement(By.XPath("//li[text()='" + CurrentOccuption + "']"))).Click();

            JavaScriptClick(driver.FindElement(By.CssSelector(selectOvernightTravelFrequency)));
            WaitFor(driver.FindElement(By.XPath("//li[text()='" + OvernightTravelFrequency + "']"))).Click();

            JavaScriptClick(driver.FindElement(By.CssSelector(selarticleworn)));
            WaitFor(driver.FindElement(By.XPath("//li[text()='" + ArticlewornFrequency + "']"))).Click();
        }

    }
}

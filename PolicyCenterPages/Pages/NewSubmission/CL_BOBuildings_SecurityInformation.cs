using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace PolicyCenterPages.Pages.NewSubmission
{


    public class CL_BOBuildings_SecurityInformation : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";
        string tabBuildingSecurityInfo = "a[id$=':BOPBuilding_SecurityCardTab']";
        string radioExtentofprotecationHighYes = "input[id$=':HighExtentOfProtect_JMIC_true']";
        string radioExtentofprotecationHighNo = "input[id$=':HighExtentOfProtect_JMIC_false']";

        string radioExtentofprotecationMediumYes = "input[id$=':ModExtentOfProtect_JMIC_true']";
        string radioExtentofprotecationMediumhNo = "input[id$=':ModExtentOfProtect_JMIC_false']";

        string radioExtentofprotecationLowYes = "input[id$=':LowExtentOfProtect_JMIC_true']";
        string radioExtentofprotecationLowNo = "input[id$=':LowExtentOfProtect_JMIC_false']";

        string radioFireAlarmYes = "input[id$=':CommonBuilding_SecurityInfoDV:P2_true']";
        string radioFireAlarmNo = "input[id$=':CommonBuilding_SecurityInfoDV:P2_false']";
        string radioprotectiveSafeguardNo = "input[id$=':CommonBuilding_SecurityInfoDV:P9_false']";
        string radioprotectiveSafeguardYes = "input[id$=':CommonBuilding_SecurityInfoDV:P9_true']";
        string listAlarmSystem = "select[id$=':BurglarAlarmSystem']";
        string listWatchManService = "select[id$=':WatchmanServiceType']";
        string btnUpdateBuilding = "a[id$=':Update']";
        string txtsafeguardDesc = "input[id$=':DescriptionOfSafeguard']";

        string radioservicecontractNo = "input[id$=':CommonBuilding_SecurityInfoDV:P4_false']";
        string radioservicecontractYes = "input[id$=':CommonBuilding_SecurityInfoDV:P4_true']";

     




        public CL_BOBuildings_SecurityInformation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            //  VerifyUIElementIsDisplayed(radioExtentofprotecation);
        }

        public override void WaitForLoad()
        {
            // IsElementPresent(driver, By.CssSelector(radioExtentofprotecation));
        }
        public void EnterSecurityInformation()
        {
            UIAction(tabBuildingSecurityInfo, string.Empty, "a");
            pause();
            UIAction(radioExtentofprotecationHighYes, string.Empty, "span");
            pause();
            UIAction(radioFireAlarmYes, string.Empty, "span");
            pause();
            UIAction(listAlarmSystem, "Local Alarm", "selectbox");
            pause();
            UIAction(radioprotectiveSafeguardNo, string.Empty, "span");

            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //js.ExecuteScript("document.getElementById('" + listAlarmSystem + "').selectedIndex='3'");

            pause();
            pause();

        }
        public void EnterSecurityInformation(string fireAlarm, string ProtectiveSafeGuard, string servicecontract, string WatchManservice, string Alarmsystem, string ExtentofprotecationHig, string ExtentofprotecationMid, string ExtentofprotecationLow)
        {
            UIAction(tabBuildingSecurityInfo, string.Empty, "a");
            // pause();
            //// UIAction(radioExtentofprotecation, string.Empty, "span");
            // pause();

            switch (Alarmsystem.ToLower().Trim())
            {
                case "central station with keys":
                    UIAction(listAlarmSystem, "Central Station With Keys", "selectbox");
                    break;
                case "central station without keys":
                    UIAction(listAlarmSystem, "Central Station Without Keys", "selectbox");
                    break;
                case "local alarm":
                    UIAction(listAlarmSystem, "Local Alarm", "selectbox");
                    break;
                case "no burglar alarm system":
                    UIAction(listAlarmSystem, "No Burglar Alarm System", "selectbox");
                    break;
                default:
                    break;
            }



            switch (WatchManservice.ToLower().Trim())
            {
                case "service does not signal or register":
                    UIAction(listWatchManService, "Service does not signal or register", "selectbox");
                    break;
                case "service signals only":
                    UIAction(listWatchManService, "Service signals only", "selectbox");
                    break;
                case "service registers only":
                    UIAction(listWatchManService, "Service registers only", "selectbox");
                    break;
                case "no watchman service":
                    UIAction(listWatchManService, "No Watchman Service", "selectbox");
                    break;
                default:
                    
                    break;
            }

            Console.WriteLine("ExtentofprotecationHig.Length is " + ExtentofprotecationHig.Length);
            Console.WriteLine("ExtentofprotecationHig.ToLower().Trim()  is " + ExtentofprotecationHig.ToLower().Trim());

            if (ExtentofprotecationHig.Length > 1)
            {
                if (ExtentofprotecationHig.ToLower().Trim().Equals("yes"))
                {
                    Console.WriteLine("ExtentofprotecationHig value is yes");
                   UIAction(radioExtentofprotecationHighYes, string.Empty, "span");

                }
                else
                {
                    Console.WriteLine("ExtentofprotecationHig value is no");
                    UIAction(radioExtentofprotecationHighNo, string.Empty, "span");
                }
                pause();
            }


            if (ExtentofprotecationMid.Length > 1)
            {
                if (ExtentofprotecationMid.ToLower().Trim().Equals("yes"))
                {
                    Console.WriteLine("ExtentofprotecationMid value is yes");
                    UIAction(radioExtentofprotecationMediumYes, string.Empty, "span");

                }
                else
                {
                    Console.WriteLine("ExtentofprotecationMid value is no");
                    UIAction(radioExtentofprotecationMediumhNo, string.Empty, "span");
                }
                pause();
            }


            if (ExtentofprotecationLow.Length > 1)
            {
                if (ExtentofprotecationLow.ToLower().Trim().Equals("yes"))
                {
                    Console.WriteLine("ExtentofprotecationLow value is yes");
                    UIAction(radioExtentofprotecationLowYes, string.Empty, "span");

                }
                else
                {
                    Console.WriteLine("ExtentofprotecationLow value is no");
                    UIAction(radioExtentofprotecationLowNo, string.Empty, "span");
                }
                pause();
            }


            if (fireAlarm.ToLower().Trim().Equals("yes"))
            {
                UIAction(radioFireAlarmYes, string.Empty, "span");
            }
            else
            {
                UIAction(radioFireAlarmNo, string.Empty, "span");
            }
            pause();

            if (ProtectiveSafeGuard.ToLower().Trim().Equals("yes"))
            {
                UIAction(radioprotectiveSafeguardYes, string.Empty, "span");
                pause();
                UIAction(txtsafeguardDesc, "text", "textbox");
            }
            else
            {
                UIAction(radioprotectiveSafeguardNo, string.Empty, "span");
            }
            pause();

            if (servicecontract.ToLower().Trim().Equals("yes"))
            {
                UIAction(radioservicecontractYes, string.Empty, "span");
            }
            else
            {
                UIAction(radioservicecontractNo, string.Empty, "span");
            }
            pause();


            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //js.ExecuteScript("document.getElementById('" + listAlarmSystem + "').selectedIndex='3'");

            pause();
            pause();

        }


    }
}

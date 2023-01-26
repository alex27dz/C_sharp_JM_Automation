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

namespace PolicyCenterPages.Pages.Common
{
    public class AdminTools : Page
    {
        string internalToolsDownArrow = "a[id$=':UnsupportedToolsTab_arrow']";

        string menuTestingSystemClock = "a[id$=':UnsupportedTools_SystemClock']";

        string inputSystemClockDate = "SystemClock:SystemClockScreen:Date";

        string lnkReturnToPC = "a[id='InternalToolsTabBar:ReturnTabBarLink']";

        string lnkLogout = "a[id$=':LogoutTabBarLink']";

        public AdminTools(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(lnkLogout);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lnkLogout));

        }

        public void getSystemDate()
        {


            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                
                     string currDate = DateTime.Now.ToString("MM/dd/yyyy");

                     Console.WriteLine("Current Date:" + currDate);

                    ScenarioContext.Current["SYSTEMDATE"] = currDate;
                    break;

                default:
                    pause();
                    WaitUntilElementVisible(driver, By.CssSelector(lnkLogout));

                    Actions action = new Actions(driver);

                    action.SendKeys(Keys.Alt + Keys.Shift + "T" + Keys.Alt + Keys.Shift).Build().Perform();

                    pause();

                    VerifyUIElementIsDisplayed(internalToolsDownArrow);

                    UIAction(internalToolsDownArrow, string.Empty, "a");

                    pause();

                    UIAction(menuTestingSystemClock, string.Empty, "a");

                    pause();

                    //     VerifyUIElementIsDisplayed(inputSystemClockDate);

                    string currNewDate = getJSElementValue(inputSystemClockDate);

                   // string currDate = "11/14/2017";

                  //  Console.WriteLine("Current Date:" + currDate);

                    ScenarioContext.Current["SYSTEMDATE"] = currNewDate;



                    UIAction(lnkReturnToPC, string.Empty, "a");

                    break;

            }

        }
    }
}


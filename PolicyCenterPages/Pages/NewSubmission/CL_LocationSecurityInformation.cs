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
   

    public class CL_LocationSecurityInformation : Page
    {
        string tabSecurityInformation = "a[id$=':SecurityInformationTab']";

    
        string burglarAlarmNo = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuilding_SecurityInfoDV:BurAlaWhenClosed_JMIC_false";

        string burglarAlarmYes = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuilding_SecurityInfoDV:BurAlaWhenClosed_JMIC_true";

        public CL_LocationSecurityInformation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(tabSecurityInformation);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(tabSecurityInformation));
        }

        public void EnterSecurityInfo(string BurglarAlarm)
        {
            UIAction(tabSecurityInformation, string.Empty, "a");

            pause();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           
            js.ExecuteScript("document.getElementById('" + burglarAlarmYes + "').checked=true");
        }

        public void EnterSecurityInfoNewYork(string BurglarAlarm)
        {
            UIAction(tabSecurityInformation, string.Empty, "a");

            pause();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("document.getElementById('" + burglarAlarmYes + "').checked=true");

            string SecurityCamera = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuilding_SecurityInfoDV:cameraSystem";
            pause();

            js.ExecuteScript("document.getElementById('" + SecurityCamera + "').selectedIndex='1'");


        }

        public void EnterCameraDetails(Table table)
        {
            string SecurityCamera = "ILMLocation_JMICPopup:ILMLocation_JMICCV:CommonBuilding_SecurityInfoDV:cameraSystem";
            pause();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + SecurityCamera + "').selectedIndex='1'");

        }
    }
}

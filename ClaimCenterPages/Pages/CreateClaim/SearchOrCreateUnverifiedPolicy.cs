using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace ClaimCenterPages.Pages.CreateClaim
{
    public class SearchOrCreateUnverifiedPolicy : Page
    {
        string policyNumber = "input[id$=':policySearch:policyNumber']";

        string btnSearch = "span[id$=':policySearch:Search_link']";

        string txtClaimLossData = "FNOLWizard:FNOLWizard_FindPolicyScreen:FNOLWizardFindPolicyPanelSet:Claim_LossDate";

        string radioCommercialLine = "input[id$='WizardClaimMode_true']";

        string radioCommercialLineQuickClaim = "input[id$='WizardClaimMode']";
                
        string btnNext = "a[id='FNOLWizard:Next']";



        public SearchOrCreateUnverifiedPolicy(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(policyNumber);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(policyNumber));
        }

        public void SearchPolicy(string PolicyNumber)
        {
            UIAction(policyNumber, PolicyNumber, "textbox");

            UIAction(btnSearch, string.Empty , "span");
        }

        public void EnterNewClaimDetails(string LossDate, string TypeOfClaim)
        {
           // string javaScript = "var keyTab = new Event('keydown');" +
        //                       " document.getElementById('" + txtClaimLossData + "').dispatchEvent(keyTab);";

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + txtClaimLossData + "').value='" + LossDate + "'");

            //   System.Threading.Thread.Sleep(3000);

            //    js.ExecuteScript(javaScript);

            //  UIAction(btnSearch, "", "span");

            //  Actions action = new Actions(driver);

            //  action.SendKeys(Keys.Tab).Build().Perform();

            //   System.Threading.Thread.Sleep(5000);

            pause();

            if(TypeOfClaim.ToLower().Contains("commercial")) 
                UIAction(radioCommercialLine, string.Empty , "radio");

           // System.Threading.Thread.Sleep(5000);

            pause();


            UIAction(btnNext, string.Empty , "a");

           


        }
    }
}

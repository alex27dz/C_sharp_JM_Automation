using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenterPages.Pages.CreateClaim
{
    public class NewExposure : Page
    {
        string chkEmployeeDishonesty = "input[id$=':TEMP_0_LV:0:7:_Checkbox']";

        string btnNewExposures = "a[id$=':NewExposureMenuTreePanelSet_tb:select']";

        string lnkExposureLineItem = "a[id$=':ExposuresLV:0:Order']";

        public NewExposure(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(chkEmployeeDishonesty);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(chkEmployeeDishonesty));
        }

     
        public void CreateExposures(string ExposureType)
        {
          

            switch (ExposureType.ToLower().Trim())
            {
                case "employee dishonesty":
                    pause();
                    UIAction(chkEmployeeDishonesty, string.Empty, "a");
                    pause();
                    UIAction(btnNewExposures, string.Empty, "a");
                    break;
                default:
                    break;
            }

            

            pause();

            WaitForPageLoad(driver);

          //  UIAction(lnkExposureLineItem, string.Empty, "a");

        }
    }
}

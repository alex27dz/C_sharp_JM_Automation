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
   

    public class CL_BOBuildings_BPPCoverages : Page
    {
        //   string btnNext = "a[id='SubmissionWizard:Next']";

        string btnUpdateBuilding = "a[id$=':Update']";

        string tabBuildingBPPCoverages = "a[id$=':BOPBuildingBPPCoveragesCardTab']";

        string txtBPPLimit = "input[id$=':BOPBPPBldgLimit']";
        public CL_BOBuildings_BPPCoverages(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

         //   VerifyUIElementIsDisplayed(btnAddILMBuilding);
        }

        public override void WaitForLoad()
        {
          //  IsElementPresent(driver, By.CssSelector(btnAddILMBuilding));
        }

        public void EnterBPPCoverages()
        {
            pause();

            UIAction(tabBuildingBPPCoverages, string.Empty , "a");

            IsElementPresent(driver, By.CssSelector(txtBPPLimit));

            UIAction(txtBPPLimit, "10000", "textbox");

            pause();

            pause();
            List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(btnUpdateBuilding)).ToList();

            pause();

            Console.WriteLine("Count++++" + PageInputElements.Count);
            WaitFor(PageInputElements[0]);

            pause();

            pause();
            pause();
            pause();

            WaitForPageLoad(driver);


            UIAction(btnUpdateBuilding, string.Empty, "a");

            pause();

            PageInputElements = driver.FindElements(By.CssSelector(btnUpdateBuilding)).ToList();

            if (PageInputElements.Count > 0)
                UIAction(btnUpdateBuilding, string.Empty, "a");
        }

        public void EnterBPPCoveragesWithBldCovg()
        {
            pause();

            UIAction(tabBuildingBPPCoverages, string.Empty, "a");

            IsElementPresent(driver, By.CssSelector(txtBPPLimit));

            string chkBuilding = "input[id='BOPBuildingPopup:BOPSingleBuildingDetailScreen:0:CoverageInputSet:CovPatternInputGroup:_checkbox']";

            driver.FindElement(By.CssSelector(chkBuilding)).Click();
            System.Threading.Thread.Sleep(2000);
            string txtBldLimit = "input[id='BOPBuildingPopup:BOPSingleBuildingDetailScreen:0:CoverageInputSet:CovPatternInputGroup:BOPBldgCovLimit']";
            //string txtRplCost = "input=[id='BOPBuildingPopup:BOPSingleBuildingDetailScreen:0:CoverageInputSet:CovPatternInputGroup:BOPBldgEstFullReplacementCostLimit']";
            UIAction(txtBldLimit, "10000", "textbox");
            System.Threading.Thread.Sleep(2000);
            //UIAction(txtRplCost, "10000", "textbox");

            UIAction(txtBPPLimit, "10000", "textbox");

            pause();

            pause();
            List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(btnUpdateBuilding)).ToList();

            pause();

            Console.WriteLine("Count++++" + PageInputElements.Count);
            WaitFor(PageInputElements[0]);

            pause();

            pause();
            pause();
            pause();

            WaitForPageLoad(driver);


            UIAction(btnUpdateBuilding, string.Empty, "a");

            pause();

            PageInputElements = driver.FindElements(By.CssSelector(btnUpdateBuilding)).ToList();

            if (PageInputElements.Count > 0)
                UIAction(btnUpdateBuilding, string.Empty, "a");
        }
    }
}

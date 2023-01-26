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
   

    public class CL_Locations : Page
    {
        //string btnNext = "a[id='SubmissionWizard:Next']";
        string btnNext = "a[id$=':Next']";

        string btnAddLocation = "a[id$='ILMLocation_JMICScreen:addLocationsOrBuildingsTB']";

        string menuExistingLocation = "span[id$='addExistingLocations']";

        string existingLocations = "a[id$='UnassignedAccountLocation']";

        string menuNewILMLocation = "a[id$='ILMLocation_JMICScreen:addLocationsOrBuildingsTB:AddNewLocation']";

        public CL_Locations(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void AddExistingLocation(string locNumber)
        {
            System.Threading.Thread.Sleep(4000);

            UIAction(btnAddLocation, string.Empty , "a");
            System.Threading.Thread.Sleep(2000);
            UIAction(menuExistingLocation, string.Empty , "span");

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(existingLocations)).ToList();

            Console.WriteLine("locations : "+ PageInputs.Count);

            pause();

            PageInputs[int.Parse(locNumber)-1].Click();

          //  UIAction(btnNext, string.Empty, "a");
        }

        public void LocationsNext()
        {
            WaitFor(driver.FindElement(By.CssSelector(btnNext)));

            UIAction(btnNext, string.Empty, "a");

        }
        public void AddNewILMLocations(int locNumber)
        {
            pause();
            UIAction(btnAddLocation, string.Empty, "a");
            UIAction(menuNewILMLocation, string.Empty, "a");
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(existingLocations)).ToList();
            Console.WriteLine("locations : " + PageInputs.Count);
            pause();
        }
    }
}

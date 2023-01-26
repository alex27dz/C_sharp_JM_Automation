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
    public class PL_Qualification : Page
    {
        string radioCSS = "input[class='radio']";

        string btnNext = "a[id='SubmissionWizard:Next__dup_1']";
        
        public PL_Qualification(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(radioCSS);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void selectQualitifications(string professionalAthelete, string previousLoss, string convictedOfCrime)
        {
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(radioCSS)).ToList();

            Console.WriteLine("object count" + PageInputs.Count);

            if (professionalAthelete.ToLower().Trim() == "yes")
                PageInputs[0].Click();
            else
                PageInputs[1].Click();

            if (previousLoss.ToLower().Trim() == "yes")
                PageInputs[2].Click();
            else
                PageInputs[3].Click();

            if (convictedOfCrime.ToLower().Trim() == "yes")
                PageInputs[4].Click();
            else
                PageInputs[5].Click();



            //   for (int i= 0;i< PageInputs.Count; i++ )
            //   {
            //       if (PageInputs[i].GetAttribute("id").Contains("false"))
            //           PageInputs[i].Click();
            //  }

            UIAction(btnNext, string.Empty, "a");
        }
    }
}

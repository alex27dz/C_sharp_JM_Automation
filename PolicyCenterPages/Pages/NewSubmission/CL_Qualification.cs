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
    public class CL_Qualification : Page
    {
        string radioCSS = "input[id$='BooleanRadioInput_false']";

        string radioSecondTypeCSS = "input[id$='BooleanRadioInput_NoPost_false']";

        string btnNext = "a[id='SubmissionWizard:Next__dup_1']";
        
        public CL_Qualification(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
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

        public void selectQualitifications(string radioOptions)
        {
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(radioCSS)).ToList();

            switch (radioOptions.ToLower())
            {
              
                case "no":
                    PageInputs = driver.FindElements(By.CssSelector(radioCSS)).ToList();

                    PageInputs[0].Click();

                   // pause();

                    PageInputs = driver.FindElements(By.CssSelector(radioSecondTypeCSS)).ToList();
                    for (int i = 0; i < PageInputs.Count ; i++)
                    {
                       
                        if (PageInputs[i].GetAttribute("id").Contains("false"))
                            PageInputs[i].Click();

                        pause();
                    }
                    break;
                default:
                    break;
            }

           

            UIAction(btnNext, string.Empty , "a");
        }

        public void Transct_selectQualitifications(string radioOptions)
        {
            pause();
            pause();
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(radioCSS)).ToList();

            switch (radioOptions.ToLower())
            {

                case "no":
                    PageInputs = driver.FindElements(By.CssSelector(radioCSS)).ToList();

                    PageInputs[0].Click();

                    // pause();

                    PageInputs = driver.FindElements(By.CssSelector(radioSecondTypeCSS)).ToList();
                    for (int i = 0; i < PageInputs.Count; i++)
                    {

                        if (PageInputs[i].GetAttribute("id").Contains("false"))
                            PageInputs[i].Click();

                        pause();
                    }
                    break;
                default:
                    break;
            }


            string btnNext = "a[id$=':Next']";
            IsElementPresent(driver, By.CssSelector(btnNext));

            pause();
            UIAction(btnNext, string.Empty, "a");
        }
    }
}

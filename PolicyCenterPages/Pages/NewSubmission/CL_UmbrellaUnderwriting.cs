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
   

    public class CL_UmbrellaUnderwriting : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";

        string radioUmbUnderwritingQ1 = "input[id$=':0:QuestionInputSet:BooleanRadioInput_false']";

        string radioUmbUnderwritingQ2 = "input[id$=':1:QuestionInputSet:BooleanRadioInput_false']";

        string radioUmbUnderwritingQ3 = "input[id$=':2:QuestionInputSet:BooleanRadioInput_false']";

        string radioUmbUnderwritingQ4 = "input[id$=':3:QuestionInputSet:BooleanRadioInput_false']";

        string radioUmbUnderwritingQ5 = "input[id$='0:QuestionInputSet:BooleanRadioInput_NoPost_false']";

        public CL_UmbrellaUnderwriting(IWebDriver driver) : base(driver)
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

      
        public void BOUmbrellaUnderwritingDetails()
        {

            UIAction(radioUmbUnderwritingQ1, string.Empty , "radio");

            pause();

            UIAction(radioUmbUnderwritingQ2, string.Empty , "radio");

            pause();

            UIAction(radioUmbUnderwritingQ3, string.Empty , "radio");

            pause();

            UIAction(radioUmbUnderwritingQ4, string.Empty , "radio");

            pause();

            UIAction(radioUmbUnderwritingQ5, string.Empty , "radio");

            pause();

            UIAction(btnNext, string.Empty , "a");
        }
    }
}

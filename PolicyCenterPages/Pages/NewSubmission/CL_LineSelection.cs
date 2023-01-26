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


    public class CL_LineSelection : Page
    {

        string titleLineSelection = "span[text()[contins(.,'Line Selection')]]";
        string btnNext = "a[id='SubmissionWizard:Next']";

        string umbrellaLine = "span[value='Umbrella Line']";

        string inlandMarineline = "span[value='Inland Marine Line']";

        string lineType = "td[class='lv-cell first-cell']";

        string lineTypeChkBox = "input[id$=':LineSelected']";
        public CL_LineSelection(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();
            VerifyUIElementIsDisplayed(btnNext);
            //VerifyUIElementIsDisplayed(titleLineSelection);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("SubmissionWizard"));
            //IsElementPresent(driver, By.CssSelector(titleLineSelection));
        }

        public void ClickNextbutton()
        {
            pause();

            UIAction(btnNext, string.Empty, "a");
        }

        public void SelectLines(string lines)
        {
            string[] lineItemArray = lines.Split(':');

            foreach (var line in lineItemArray)
            {
                List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(lineType)).ToList();

                for (var i = 0; i < PageInputElements.Count; i++)
                {
                    if (line.ToLower().Trim() == PageInputElements[i].Text.ToLower().Trim())
                    {
                        List<IWebElement> chkBoxes = driver.FindElements(By.CssSelector(lineTypeChkBox)).ToList();

                        Console.WriteLine("Line items count" + chkBoxes.Count);

                        Console.WriteLine("===" + chkBoxes[i].GetAttribute("checked"));
                        if (chkBoxes[i].GetAttribute("checked") != "true")

                            chkBoxes[i].Click();

                    }
                }

            }


            //  Console.WriteLine("Line items count" + PageInputElements.Count);



            //UIAction(selOfferingSelection, Offering , "selectbox");

            pause();

            UIAction(btnNext, string.Empty, "a");
        }
    }
}


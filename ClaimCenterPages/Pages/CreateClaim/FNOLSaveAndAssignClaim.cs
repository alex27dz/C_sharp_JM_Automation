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
    public class FNOLSaveAndAssignClaim : Page
    {
       
        string txtAssignClaim = "select[id$=':NewClaimWizard_AssignDV:CommonAssign']";

        string btnFinish = "a[id='FNOLWizard:Finish']";

        public FNOLSaveAndAssignClaim(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(txtAssignClaim);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtAssignClaim));
        }

     
        public void FinishClaimInformation()
        {

            bool isClaimSuccessful = false;

            UIAction(btnFinish, string.Empty , "a");

            IsElementPresent(driver, By.CssSelector("a[class='underlined']"));

            for (int j = 0; j < 4; j++)
                pause();


            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("a[class='underlined']")).ToList();

            Console.WriteLine("-------" + PageInputs.Count);

            for (int i = 0; i < PageInputs.Count; i++)
            {

                string Temp = "view ";

                Console.WriteLine("++++++" + PageInputs[i].Text);

                if (PageInputs[i].Text.ToLower().Trim().Contains(Temp))
                {
                    Console.WriteLine(i + "=" + PageInputs[i].Text);

                    pause();

                    string claimNumber = PageInputs[i].Text.Substring(Temp.Length, 9);

                    if (claimNumber != null)
                        isClaimSuccessful = true;
                    Console.WriteLine("Claim number" + claimNumber);

                    ScenarioContext.Current.Add("CLAIM", claimNumber);

                    PageInputs[i].Click();

                    break;
                }
            }
        }
    }
}

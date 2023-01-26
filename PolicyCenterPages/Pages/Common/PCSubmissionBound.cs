using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace PolicyCenterPages.Pages.Common
{
    public class PCSubmissionBound : Page
    {
        //string lnkYourSubmission = "div[id$='JobComplete:JobCompleteScreen:Message']";
        string lnkYourPolicy = "a[id$='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy']";
        string lblCanCelPolicyConfirmMsg = "div[id='JobComplete:JobCompleteScreen:Message']";
        public PCSubmissionBound(IWebDriver driver) : base(driver)
        {

            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {

            SetActiveFrame();
            //VerifyUIElementIsDisplayed(lnkYourPolicy);

        }

        public override void WaitForLoad()
        {
            //IsElementPresent(driver, By.CssSelector(lnkYourPolicy));
        }

        public void ClickIssuedPolicy()
        {
            System.Threading.Thread.Sleep(7000);
            WaitUntilElementVisible(driver, By.CssSelector(lblCanCelPolicyConfirmMsg));
            IWebElement CancelConfirmMesssage = driver.FindElement(By.CssSelector(lblCanCelPolicyConfirmMsg));
            Console.WriteLine(CancelConfirmMesssage.Text);
            UIAction(lnkYourPolicy, string.Empty, "a");
        }
    }
}

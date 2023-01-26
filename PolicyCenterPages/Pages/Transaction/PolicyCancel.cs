using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PolicyCenterPages.Pages.Transaction
{
    public class PolicyCancel : Page
    {
        string btnCloseOptions = "a[id$=':CloseOptions']";
        string btnBindOptions = "a[id$=':BindOptions']";
        string btnBindCancelPolicy = "a[id$=':BindOptions:SubmitCancellation']";
        string lblCanCelPolicyConfirmMsg = "div[id='JobComplete:JobCompleteScreen:Message']";
        //

        public PolicyCancel(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            SetActiveFrame();
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(btnCancel); 
        }

        public override void WaitForLoad()
        {
         //   IsElementPresent(driver, By.CssSelector(btnCloseOptions));
        }

        public void CLPolicyCancel()
        {
            IsElementPresent(driver, By.CssSelector(btnCloseOptions));


            UIAction(btnBindOptions, string.Empty, "a");

            pause();

            UIAction(btnBindCancelPolicy, string.Empty, "a");

            pause();

            try
            {
                driver.SwitchTo().Alert().Accept();
                //System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                // action.SendKeys(Keys.Enter).Build().Perform();
                // driver.SwitchTo().ActiveElement().Click();

                WaitForPageLoad(driver);

                System.Threading.Thread.Sleep(6000);

                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            pause();
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(lblCanCelPolicyConfirmMsg));
            IWebElement CancelConfirmMesssage = driver.FindElement(By.CssSelector(lblCanCelPolicyConfirmMsg));
            Console.WriteLine(CancelConfirmMesssage.Text);
        }

        public void PLPolicyCancel()
        {

            //Console.WriteLine("In CancelPolicy");

            pause();

            UIAction(btnBindOptions, string.Empty, "a");

            pause();

            UIAction(btnBindCancelPolicy, string.Empty, "a");

            pause();

            try
            {
                driver.SwitchTo().Alert().Accept();
                WaitForPageLoad(driver);
                System.Threading.Thread.Sleep(3000);
                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            pause();
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(lblCanCelPolicyConfirmMsg));
            IWebElement CancelConfirmMesssage = driver.FindElement(By.CssSelector(lblCanCelPolicyConfirmMsg));
            Console.WriteLine(CancelConfirmMesssage.Text);

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;

namespace PolicyCenterPages.Pages.Transaction
{
    public class PolicyStartReinstatement : Page
    {
        string toolbarReinstate = "div[class='content'][id*='ReinstatementWizard']";
        string btnNext = "a[id='ReinstatementWizard:Next']";
        string lstReason = "select[id$=':ReinstatePolicyDV:ReasonCode']";
        string btnQuote = "a[id$=':JobWizardToolbarButtonSet:QuoteOrReview']";
        string btWithDrawWorkOrder = "a[id$=':JobWizardToolbarButtonSet:WithdrawJob']";
        string btnReinstate = "a[id$=':JobWizardToolbarButtonSet:Reinstate']";
        string lblCanCelPolicyConfirmMsg = "div[id='JobComplete:JobCompleteScreen:Message']";
        public PolicyStartReinstatement(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(toolbarReinstate);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(toolbarReinstate));
        }
        public void EnterReinstatementDetails(string sReinsitateReason)
        {
            WaitUntilElementVisible(driver, By.CssSelector(lstReason));
            UIAction(lstReason, sReinsitateReason, "selectbox");
        }
        public void ClickNext()
        {
            WaitUntilElementVisible(driver, By.CssSelector(lstReason));
            UIAction(btnNext, string.Empty, "a");
        }
        public void ClickQuote()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            UIAction(btnQuote, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btWithDrawWorkOrder));
        }
        public void ClickReinstate()
        {

            WaitUntilElementVisible(driver, By.CssSelector(btnReinstate));
            UIAction(btnReinstate, string.Empty, "a");

            pause();

            try
            {
                driver.SwitchTo().Alert().Accept();
                //System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                // action.SendKeys(Keys.Enter).Build().Perform();
                // driver.SwitchTo().ActiveElement().Click();

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

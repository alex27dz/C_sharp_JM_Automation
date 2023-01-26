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
    public class NewCheck : Page
    {
       
        string btnCancel = "a[id$=':Cancel']";

        string btnNext = "a[id$=':Next']";

        string btnFinish = "a[id$=':Finish']";

        string btnClear = "a[id$=':WebMessageWorksheet_ClearButton']";

        string selPrimaryPayeeName = "select[id$=':NewCheckPayeeDV:PrimaryPayee_Name']";

        string selPrimaryPayeeType = "select[id$=':NewCheckPayeeDV:PrimaryPayee_Type']";

        string selReserveLineCategory = "select[id$=':NewPaymentDetailDV:tempLineCategory']";

        string selReserveLine = "select[id$=':NewPaymentDetailDV:Transaction_ReserveLine']";

        string selPaymentType = "select[id$=':NewPaymentDetailDV:Payment_PaymentType']";

        string txtAmount = "input[id$=':EditablePaymentLineItemsCLLV:0:Amount']";



        public NewCheck(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnCancel);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnCancel));
        }

        public void CheckPayment()
        {
            UIAction(selPrimaryPayeeName, "1", "selectbox");

            pause();

            UIAction(selPrimaryPayeeType, "Insured", "selectbox");

            pause();

            UIAction(btnNext, string.Empty, "a");

            pause();

            WaitForPageLoad(driver);

            UIAction(selReserveLineCategory, "Indemnity", "selectbox");

            pause();

            UIAction(selReserveLine, "1", "selectbox");

            pause();

            UIAction(selPaymentType, "Partial", "selectbox");

            pause();

            UIAction(txtAmount, "100", "textbox");

            pause();

            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();

            pause();
            pause();

       //     System.Threading.Thread.Sleep(5000);

            UIAction(btnNext, string.Empty, "a");

            System.Threading.Thread.Sleep(3000);

            pause();

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(btnFinish)).ToList();

            WaitFor(PageInputs[0]);

            WaitForPageLoad(driver);

            UIAction(btnFinish, string.Empty, "a");

            pause();

            UIAction(btnClear, string.Empty, "a");

            pause();

            UIAction(btnFinish, string.Empty, "a");

            


        }
       
    }
}

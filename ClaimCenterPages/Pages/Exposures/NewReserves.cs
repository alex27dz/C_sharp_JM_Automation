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
    public class NewReserves : Page
    {
       
        string selExposureRow0 = "select[id$=':EditableReservesLV:0:Exposure']";

        string selReserveRow0 = "select[id$=':EditableReservesLV:0:CostType']";

        string selReserveCategoryRow0 = "select[id$=':EditableReservesLV:0:CostCategory']";

        string selReserveAmountRow0 = "input[id$=':EditableReservesLV:0:NewAmount']";

        string selExposureRow1 = "select[id$=':EditableReservesLV:1:Exposure']";

        string selReserveRow1 = "select[id$=':EditableReservesLV:1:CostType']";

        string selReserveCategoryRow1 = "select[id$=':EditableReservesLV:1:CostCategory']";

        string selReserveAmountRow1 = "input[id$=':EditableReservesLV:1:NewAmount']";

        string btnSave = "a[id$=':Update']";

        string btnAdd = "a[id$=':Add']";

        public NewReserves(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnSave);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnSave));
        }

     
        public void CreateReserves()
        {
            UIAction(selExposureRow0, "1", "selectbox");

            pause();

            UIAction(selReserveRow0, "Expense", "selectbox");

            pause();

            UIAction(selReserveCategoryRow0, "A&O Expense", "selectbox");

            pause();

            UIAction(selReserveAmountRow0, "500", "textbox");



            pause();

            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();

            pause();
            pause();

            UIAction(btnAdd, string.Empty, "a");

            pause();
            pause();
            pause();
            pause();


            WaitForPageLoad(driver);

            UIAction(selExposureRow1, "1", "selectbox");

            pause();

            UIAction(selReserveRow1, "Indemnity", "selectbox");

            pause();

            UIAction(selReserveCategoryRow1, "Indemnity Category", "selectbox");

            pause();

            UIAction(selReserveAmountRow1, "500", "textbox");

            action.SendKeys(Keys.Tab).Build().Perform();

            pause();

            pause();
            pause();

            UIAction(btnSave, string.Empty, "a");

            pause();
            pause();


        }
    }
}

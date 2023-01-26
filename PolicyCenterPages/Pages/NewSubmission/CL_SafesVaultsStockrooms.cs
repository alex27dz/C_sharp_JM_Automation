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


    public class CL_SafesVaultsStockrooms : Page
    {
        string SafeVaultStockroomTab = "a[id$=':SafeVaultStockroomTab']";

        string totalLocationInSafe = "input[id$=':TotalInStrgPrcnt_JMIC']";

        string bankVault = "input[id$=':BankVaultPercent_JMIC']";

        string btnOK = "a[id$=':Update']";


        public CL_SafesVaultsStockrooms(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(SafeVaultStockroomTab);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(SafeVaultStockroomTab));
        }

        public void EnterSafesVaults(string TotalLocationInSafe, string BankVault)
        {
            UIAction(SafeVaultStockroomTab, string.Empty, "a");

            pause();
            if (!(String.IsNullOrEmpty(TotalLocationInSafe)))
            {
                UIAction(totalLocationInSafe, TotalLocationInSafe, "textbox");
            }


            pause();


            if (!(String.IsNullOrEmpty(BankVault)))
            {
                UIAction(bankVault, BankVault, "textbox");
            }

            UIAction(btnOK, string.Empty, "a");

        }

        public void ClickOKButton()
        {
            UIAction(btnOK, string.Empty, "a");
        }

    }
}

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
   

    public class CL_BOBlankets : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";

       
        public CL_BOBlankets(IWebDriver driver) : base(driver)
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

      
        public void BOBlanketsNext()
        {
            UIAction(btnNext, string.Empty , "a");
        }


        public void BOAddBlanket(Table table)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string btnAddBlanket = "a[id$=':BOPBlanket_tb:AddBlanket']";
            string lstBlanketType = "select[id='BOPBlanket_JMICPopup:BlanketType']";
            string lstGroupType = "select[id='BOPBlanket_JMICPopup:BlanketGroupType']";
            string lstLocation = "BOPBlanket_JMICPopup:BlanketLocation";
            string txtLimit = "input[id='BOPBlanket_JMICPopup:BOPBlanketCovLimit']";
            string btnShowCovgs = "a[id='BOPBlanket_JMICPopup:BOPBlanketCovLV_tb:ShowCoverages']";
            string chkSelectAll = "input[id='BOPBlanket_JMICPopup:BOPBlanketCovLV:_Checkbox']";
            string btnIncldSelCovgs = "a[id='BOPBlanket_JMICPopup:BOPBlanketCovLV_tb:AddCoverages']";
            string btnOK = "a[id='BOPBlanket_JMICPopup:Update']";
            string btnClear = "a[id='WebMessageWorksheet:WebMessageWorksheetScreen:WebMessageWorksheet_ClearButton']";
            string lstDed = "BOPBlanket_JMICPopup:BOPBlanketCovDeductible";

            UIAction(btnAddBlanket, string.Empty, "a");
            driver.FindElement(By.XPath("//html")).Click();
            System.Threading.Thread.Sleep(2000);
            UIAction(lstBlanketType, table.Rows[0]["BOP_Blanket_Type"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(lstGroupType, table.Rows[0]["BOP_Blanket_GroupType"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            if (table.Rows[0]["LocationNum"] == "1")
            {
                js.ExecuteScript("document.getElementById('" + lstLocation + "').selectedIndex='1'");
            }
            System.Threading.Thread.Sleep(2000);
            UIAction(btnShowCovgs, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(chkSelectAll)).Click();
            System.Threading.Thread.Sleep(2000);
            UIAction(btnIncldSelCovgs, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            UIAction(txtLimit, "20000", "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnOK, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnClear, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            //UIAction(lstDed, "500", "selectbox");
            js.ExecuteScript("document.getElementById('" + lstDed + "').selectedIndex='2'");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnOK, string.Empty, "a");

        }
    }
}

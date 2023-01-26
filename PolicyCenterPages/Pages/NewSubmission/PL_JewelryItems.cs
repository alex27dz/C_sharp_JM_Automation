using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace PolicyCenterPages.Pages.NewSubmission
{
    public class PL_JewelryItems : Page
    {
        //  string btnPolicyChangeAddJwelryItems = "a[id='PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV_tb:ToolbarButton1']";

        string btnAddJwelryItems = "a[id$=':LOBWizardStepGroup:LineWizardStepSet:ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:PersonalItemLV_tb:ToolbarButton1']";

      //  string btnAddJwelryItems = "a[id='PersonalItemJMICPLPanelSet:PersonalItemLV_tb:ToolbarButton1']";

        // string btnAddJwelryItems = "PersonalItemLV_tb:ToolbarButton1";

        string selLocatedWith = "select[id='JewelryItem_JMIC_PLPopup:LocatedWithPolicyRoleRangeInput']";

        string selLocatedWithCSS = "JewelryItem_JMIC_PLPopup:LocatedWithPolicyRoleRangeInput";

        string selJewelryClass = "select[id=JewelryItem_JMIC_PLPopup:ClassCodeTypeKeyInput']";

        string JewelryValue = "input[id='JewelryItem_JMIC_PLPopup:ValueInputCell']";

        string btnUpdateJewelryItem = "a[id='JewelryItem_JMIC_PLPopup:Update']";

        string personalItemTab = "span[id='JewelryItem_JMIC_PLPopup:ItemCV:PersonalItemCardTab']";

        string btnNext = "a[id$=':Next']";

        string selectJewelryBrand = "select[id='JewelryItem_JMIC_PLPopup:BrandTypeKeyInput']";

        string selectJewelryStyle = "select[id='JewelryItem_JMIC_PLPopup:StyleTypeKeyInput']";

        string selectItemWhereStored = "select[id='JewelryItem_JMIC_PLPopup:ItemWhereStored_JMIC']";

        string selectAlarmType = "select[id$=':ListDetailScrJMICPLScreen:PersonalItemJMICPLPanelSet:alarm']";


        public PL_JewelryItems(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
           SetActiveFrame("top_frame");

            VerifyUIElementIsDisplayed(btnAddJwelryItems);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnAddJwelryItems));
        }

        public void AddJewelryItems()
        {
            SetActiveFrame("top_frame");

            UIAction(btnAddJwelryItems, string.Empty, "a");

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            SelectByIndex(PageInputs[0], 1);

            pause();

            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            SelectByIndex(PageInputs[2], 1);

            pause();

            UIAction(JewelryValue, "1000", "textbox");
           
            pause();

            UIAction(btnUpdateJewelryItem, "", "a");

            pause();

            UIAction(btnNext, string.Empty, "a");

        }

        public void AddMultiJewelryItem(string LocatedWith, string itemClass, string ValueOfItem, string Deductible, string Appraisal, string AppraisalDate, int counter)
        {
            int Deductible_index = 0; 
            UIAction(btnAddJwelryItems, string.Empty, "a");

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            if (counter == 0)
            {
                if (LocatedWith.ToLower().Trim() == "self")
                {
                    SelectByIndex(PageInputs[0], 1);
                }
            }
            pause();

            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
            pause();
            //   SelectByIndex(PageInputs[2], 1);
            SelectByText(PageInputs[2], itemClass);
            pause();

            UIAction(JewelryValue, ValueOfItem, "textbox");
            pause();


            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
           switch (Deductible.ToLower().Trim())
            {
                case "100":
                    Deductible_index = 1;
                    break;
                case "250":
                    Deductible_index = 2;
                    break;
                case "500":
                    Deductible_index = 3;
                    break;
                case "1000":
                    Deductible_index = 4;
                    break;
                case "2500":
                    Deductible_index = 5;
                    break;
                case "5000":
                    Deductible_index = 6;
                    break;
                case "10000":
                    Deductible_index = 7;
                    break;
                case "25000":
                    Deductible_index = 8;
                    break;
                case "50000":
                    Deductible_index = 9;
                    break;
                case "100000":
                    Deductible_index = 10;
                    break;
            }
          SelectByIndex(PageInputs[5], Deductible_index);

            pause();

            if (Appraisal.ToLower().Trim() == "yes")
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_true']", string.Empty, "a");
            }
            else
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_false']", string.Empty, "a");
            }
            pause();
            UIAction(btnUpdateJewelryItem, string.Empty, "a");
        }

        public void ClickNextButton()
        {
            UIAction(btnNext, string.Empty, "a");
        }

        public void AddJewelryItem(string LocatedWith, string itemClass, string ValueOfItem, string Deductible)
        {

            UIAction(btnAddJwelryItems, string.Empty, "a");

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            if (LocatedWith.ToLower().Trim() == "self")
                try
                {
                    SelectByIndex(PageInputs[0], 1);
                }
                catch (Exception e)
                {

                }
            pause();

            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            pause();
            //   SelectByIndex(PageInputs[2], 1);
            SelectByText(PageInputs[2], itemClass);

            pause();

            UIAction(JewelryValue, ValueOfItem, "textbox");

            pause();

            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            SelectByIndex(PageInputs[5], 1);

            pause();

            UIAction(btnUpdateJewelryItem, string.Empty, "a");

            pause();

            UIAction(btnNext, string.Empty, "a");

        }

        public void UpdateAlarm(string AlarmType)
        {
            UIAction(selectAlarmType, AlarmType, "selectbox");
            pause();
        }

        public void AddMultiJewelryItemDetails(string LocatedWith, string itemClass, string ValueOfItem, string Deductible, string Appraisal, string AppraisalDate, string JewelryBrand, string JewelryStyle, string JewelryItemStored, int counter)
        {
            int Deductible_index = 0;
            UIAction(btnAddJwelryItems, string.Empty, "a");

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();

            if (counter == 0)
            {
                if (LocatedWith.ToLower().Trim() == "self")
                {
                    SelectByIndex(PageInputs[0], 1);
                }
            }

            pause();
            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
            pause();
            SelectByText(PageInputs[2], itemClass);
            pause();

            Console.WriteLine("adding item description");
            //PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
            //Console.WriteLine("id for item 3 is " + PageInputs[3].GetAttribute("id"));
            //Console.WriteLine("id for item 4 is " + PageInputs[4].GetAttribute("id"));
            //Console.WriteLine("id for item 8 is " + PageInputs[8].GetAttribute("id"));

            if (!(string.IsNullOrEmpty(JewelryBrand)))
            {
                UIAction(selectJewelryBrand, JewelryBrand, "selectbox");
                pause();
            }


            if (!(string.IsNullOrEmpty(JewelryStyle)))
            {
                UIAction(selectJewelryStyle, JewelryStyle, "selectbox");
                pause();
            }

            if (string.Equals(JewelryItemStored.ToLower(), "safe"))
            {
                UIAction(selectItemWhereStored, "Safe", "selectbox");
                pause();
            }


            UIAction(JewelryValue, ValueOfItem, "textbox");
            pause();


            PageInputs = driver.FindElements(By.CssSelector("select[class='select']")).ToList();
            switch (Deductible.ToLower().Trim())
            {
                case "100":
                    Deductible_index = 1;
                    break;
                case "250":
                    Deductible_index = 2;
                    break;
                case "500":
                    Deductible_index = 3;
                    break;
                case "1000":
                    Deductible_index = 4;
                    break;
                case "2500":
                    Deductible_index = 5;
                    break;
                case "5000":
                    Deductible_index = 6;
                    break;
                case "10000":
                    Deductible_index = 7;
                    break;
                case "25000":
                    Deductible_index = 8;
                    break;
                case "50000":
                    Deductible_index = 9;
                    break;
                case "100000":
                    Deductible_index = 10;
                    break;
            }
            SelectByIndex(PageInputs[5], Deductible_index);

            pause();

            if (Appraisal.ToLower().Trim() == "yes")
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_true']", string.Empty, "a");
            }
            else
            {
                UIAction("input[id = 'JewelryItem_JMIC_PLPopup:AppraisalReceived_false']", string.Empty, "a");
            }
            pause();
            UIAction(btnUpdateJewelryItem, string.Empty, "a");

        }
    }
}

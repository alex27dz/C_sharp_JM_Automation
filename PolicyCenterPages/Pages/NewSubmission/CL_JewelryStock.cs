using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace PolicyCenterPages.Pages.NewSubmission
{


    public class CL_JewelryStock : Page
    {
        string lnkJeweleryStock = "a[id$=':0:StockDescription']";

        string radioCompleteInv = "input[id$=':CompleteInventory_true']";

        string txtLastInvTotal = "input[id$=':LastInvTotal']";

        string dateTakenOn = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:ILMJewelryStock_JMICDetailsPanelSet:LastInvDate";

        string maxStockValue = "input[id$=':MaxStockValue']";

        string radioMaintainRecords = "input[id$=':IsCustPropertyRecorded_true']";

        string txtAvgAmtCustomersProperty = "input[id$=':CustomerPropertyAvg']";

        string txtAvgAmtMemoConsignment = "input[id$=':ConsignmentPropertyAvg']";

        string txtLooseDiamonds = "input[id$='0:PercentOfTotal']";

        string txtOutOfSafelimit = "input[id='0:ILMCovTermInputSet:DirectTermInput']";

        string coveragesTab = "a[id$=':CoveragesTab']";

        string stockAOPLimit = "input[id$='0:StockAOPLimit']";

        string stockFireDeductible = "select[id$=:1:ILMCovTermInputSet:OptionTermInput']";

        string btnOK = "a[id$=':Update']";


        public CL_JewelryStock(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(lnkJeweleryStock);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lnkJeweleryStock));
        }

        public void EnterJewelryStockInfoDetails(string LastInvTotal, string StockValue, string AvgAmtCustomersProperty, string AvgAmtMemoConsignment, string LooseDiamonds, string stockAOPLimittxt)
        {
            System.Threading.Thread.Sleep(4000);
            //IList<IWebElement> JewelryStockTable = driver.FindElements(By.XPath("//table[@id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']")).ToList();
            //IList<IWebElement> JewelryStockTable = driver.FindElements(By.CssSelector("table[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']")).ToList();
            string JSTable = "table[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']";
            IList<IWebElement> JewelryStockTable = driver.FindElements(By.CssSelector(JSTable)).ToList();
            Console.WriteLine("Stock Page Count: " + JewelryStockTable.Count());
            IList<IWebElement> JewelryStockRow = new List<IWebElement>(JewelryStockTable[JewelryStockTable.Count() - 1].FindElements(By.TagName("td")));
            Console.WriteLine("Stock table Count: " + JewelryStockRow.Count());
            Console.WriteLine("Get Total Locations");
            int TotalLocations = Convert.ToInt32(JewelryStockRow[JewelryStockRow.Count() - 3].Text);
            Console.WriteLine("Loc Num: " + TotalLocations);
            lnkJeweleryStock = "a[id$=':" + (TotalLocations - 1) + ":StockDescription']";
            System.Threading.Thread.Sleep(2000);
            UIAction(lnkJeweleryStock, string.Empty, "a");

            System.Threading.Thread.Sleep(4000);

            UIAction(radioCompleteInv, string.Empty, "a");

            UIAction(txtLastInvTotal, LastInvTotal, "textbox");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + dateTakenOn + "').value='12/12/2016'");

            UIAction(maxStockValue, StockValue, "textbox");

            UIAction(radioMaintainRecords, string.Empty, "a");

            UIAction(txtAvgAmtCustomersProperty, AvgAmtCustomersProperty, "textbox");

            UIAction(txtAvgAmtMemoConsignment, AvgAmtMemoConsignment, "textbox");

            UIAction(txtLooseDiamonds, LooseDiamonds, "textbox");

            UIAction(coveragesTab, string.Empty, "a");

            pause();

            WaitUntilElementIsDisplayed(driver, By.XPath("//div[id$='ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:0']"));

            UIAction(stockAOPLimit, stockAOPLimittxt, "textbox");

            pause();


            Actions action = new Actions(driver);

            action.SendKeys(Keys.Tab).Build().Perform();

            pause();
            pause();
            pause();

            IList<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(btnOK)).ToList();

            WaitFor(PageInputElements[0]);
            //   UIAction(stockFireDeductible, "1,000", "selectbox");

            UIAction(btnOK, string.Empty, "a");


        }

        public void EnterJewelryStockInfo()
        {
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("JS Wait exceed");
            //IList<IWebElement> JewelryStockTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']")).ToList();
            string JSTable = "table[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']";
            IList<IWebElement> JewelryStockTable = driver.FindElements(By.CssSelector(JSTable)).ToList();

            Console.WriteLine("Stock Page Count: " + JewelryStockTable.Count());
            IList<IWebElement> JewelryStockRow = new List<IWebElement>(JewelryStockTable[JewelryStockTable.Count() - 1].FindElements(By.TagName("td")));
            Console.WriteLine("Stock table Count: " + JewelryStockRow.Count());
            Console.WriteLine("Get Total Locations");
            int TotalLocations = Convert.ToInt32(JewelryStockRow[JewelryStockRow.Count() - 3].Text);
            Console.WriteLine("Loc Num: " + TotalLocations);
            lnkJeweleryStock = "a[id$=':" + (TotalLocations - 1) + ":StockDescription']";

            UIAction(lnkJeweleryStock, string.Empty, "a");

            pause();

            UIAction(radioCompleteInv, string.Empty, "a");

            UIAction(txtLastInvTotal, "100000", "textbox");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + dateTakenOn + "').value='12/12/2016'");

            UIAction(maxStockValue, "100000", "textbox");

            UIAction(radioMaintainRecords, string.Empty, "a");

            UIAction(txtAvgAmtCustomersProperty, "10000", "textbox");

            UIAction(txtAvgAmtMemoConsignment, "10000", "textbox");

            UIAction(txtLooseDiamonds, "100", "textbox");

            UIAction(coveragesTab, string.Empty, "a");

            pause();

            UIAction(stockAOPLimit, "200000", "textbox");

            pause();


            Actions action = new Actions(driver);

            action.SendKeys(Keys.Tab).Build().Perform();

            pause();
            pause();
            pause();

            IList<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(btnOK)).ToList();

            WaitFor(PageInputElements[0]);


            //  UIAction(stockFireDeductible, "1,000", "selectbox");

            UIAction(btnOK, string.Empty, "a");


        }

        public void EnterJewelryStockInfoJS()
        {
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("JS Wait exceed");
            //IList<IWebElement> JewelryStockTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']")).ToList();
            string JSTable = "table[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']";
            IList<IWebElement> JewelryStockTable = driver.FindElements(By.CssSelector(JSTable)).ToList();

            Console.WriteLine("Stock Page Count: " + JewelryStockTable.Count());
            IList<IWebElement> JewelryStockRow = new List<IWebElement>(JewelryStockTable[JewelryStockTable.Count() - 1].FindElements(By.TagName("td")));
            Console.WriteLine("Stock table Count: " + JewelryStockRow.Count());
            Console.WriteLine("Get Total Locations");
            int TotalLocations = Convert.ToInt32(JewelryStockRow[JewelryStockRow.Count() - 3].Text);
            Console.WriteLine("Loc Num: " + TotalLocations);
            lnkJeweleryStock = "a[id$=':" + (TotalLocations - 1) + ":StockDescription']";

            UIAction(lnkJeweleryStock, string.Empty, "a");

            pause();

            UIAction(radioCompleteInv, string.Empty, "a");

            UIAction(txtLastInvTotal, "100000", "textbox");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + dateTakenOn + "').value='12/12/2016'");

            UIAction(maxStockValue, "100000", "textbox");

            UIAction(radioMaintainRecords, string.Empty, "a");

            UIAction(txtAvgAmtCustomersProperty, "10000", "textbox");

            UIAction(txtAvgAmtMemoConsignment, "10000", "textbox");

            UIAction(txtLooseDiamonds, "100", "textbox");

            UIAction(coveragesTab, string.Empty, "a");

            pause();

            UIAction(stockAOPLimit, "200000", "textbox");

            pause();
            pause();
            pause();

            js.ExecuteScript("document.getElementById('ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:CovCategoryIterator:5:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput').value='1000'");

            //UIAction(txtOutOfSafelimit, string.Empty, "a");
            //pause();
            //UIAction(txtOutOfSafelimit, "1000", "textbox");

            pause();
            pause();

            Actions action = new Actions(driver);

            action.SendKeys(Keys.Tab).Build().Perform();

            pause();
            pause();
            pause();

            IList<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(btnOK)).ToList();

            WaitFor(PageInputElements[0]);


            //  UIAction(stockFireDeductible, "1,000", "selectbox");

            UIAction(btnOK, string.Empty, "a");


        }

        public void AddStockPeakCovg(Table table)
        {
            VerifyUIElementIsDisplayed(lnkJeweleryStock);
            pause();
            pause();
            string btnAddCoverage = "a[id$=':CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:ToolbarButton_arrow']";
            string lnkStockPeak = "a[id$=':CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:ToolbarButton:0:subItemCoverable']";

            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                pause();
                pause();
                string txtStockPeakLimit = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput']";
                string StockPeakDeductible = "select[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:OptionTermInput']";
                string StockPeakFrom = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:FromDate:DateTimeTermInput";
                string StockPeakTo = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ToDate:DateTimeTermInput";
                string StockPeakRecurringNo = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_false']";
                lnkJeweleryStock = "a[id$=':" + i + ":StockDescription']";

                UIAction(lnkJeweleryStock, string.Empty, "a");
                pause();
                pause();
                UIAction(coveragesTab, string.Empty, "a");
                pause();
                WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
                UIAction(btnAddCoverage, string.Empty, "a");
                pause();
                WaitUntilElementVisible(driver, By.CssSelector(lnkStockPeak));
                UIAction(lnkStockPeak, string.Empty, "a");
                pause();
                WaitUntilElementVisible(driver, By.CssSelector(txtStockPeakLimit));
                UIAction(txtStockPeakLimit, table.Rows[i]["SPLimit"], "textbox");
                pause();
                WaitUntilElementVisible(driver, By.CssSelector(StockPeakDeductible));
                UIAction(StockPeakDeductible, table.Rows[i]["SPDeductable"], "selectbox");

                var tempDate = "";
                DateTime CurrentDate = DateTime.Now;
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                if (table.Rows[i]["SPFrom"].ToLower().ToString() == "systemdate")
                {
                    DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                    tempDate = tempRetroDate.ToShortDateString();
                }
                else if (table.Rows[0]["SPFrom"].ToLower() == "currentdate")
                {
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
                }
                else if (table.Rows[0]["SPFrom"].Contains("+"))
                {
                    string[] details = table.Rows[0]["SPFrom"].Split('+');
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

                }
                js.ExecuteScript("document.getElementById('" + StockPeakFrom + "').value='" + tempDate + "'");
                pause();
                if (table.Rows[i]["SPTo"].ToLower().ToString() == "systemdate")
                {
                    DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                    tempDate = tempRetroDate.ToShortDateString();
                }
                else if (table.Rows[0]["SPTo"].ToLower() == "currentdate")
                {
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
                }
                else if (table.Rows[0]["SPTo"].Contains("+"))
                {
                    string[] details = table.Rows[0]["SPTo"].Split('+');
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

                }
                js.ExecuteScript("document.getElementById('" + StockPeakTo + "').value='" + tempDate + "'");

                pause();
                WaitUntilElementVisible(driver, By.CssSelector(StockPeakRecurringNo));
                UIAction(StockPeakRecurringNo, string.Empty, "input");
                pause();
                UIAction(btnOK, string.Empty, "a");
            }
        }


        public void EnterJewelryStockInfoDetails_JSP(string LastInvTotal, string StockValue, string AvgAmtCustomersProperty, string AvgAmtMemoConsignment, string LooseDiamonds, string stockAOPLimittxt)
        {
            System.Threading.Thread.Sleep(4000);
            //IList<IWebElement> JewelryStockTable = driver.FindElements(By.XPath("//table[@id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']")).ToList();
            //IList<IWebElement> JewelryStockTable = driver.FindElements(By.CssSelector("table[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']")).ToList();
            string JSTable = "table[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']";
            IList<IWebElement> JewelryStockTable = driver.FindElements(By.CssSelector(JSTable)).ToList();
            Console.WriteLine("Stock Page Count: " + JewelryStockTable.Count());
            IList<IWebElement> JewelryStockRow = new List<IWebElement>(JewelryStockTable[JewelryStockTable.Count() - 1].FindElements(By.TagName("td")));
            Console.WriteLine("Stock table Count: " + JewelryStockRow.Count());
            Console.WriteLine("Get Total Locations");
            int TotalLocations = Convert.ToInt32(JewelryStockRow[JewelryStockRow.Count() - 3].Text);
            Console.WriteLine("Loc Num: " + TotalLocations);
            lnkJeweleryStock = "a[id$=':" + (TotalLocations - 1) + ":StockDescription']";
            System.Threading.Thread.Sleep(2000);
            UIAction(lnkJeweleryStock, string.Empty, "a");

            System.Threading.Thread.Sleep(4000);

            UIAction(radioCompleteInv, string.Empty, "a");

            UIAction(txtLastInvTotal, LastInvTotal, "textbox");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + dateTakenOn + "').value='12/12/2016'");

            UIAction(maxStockValue, StockValue, "textbox");

            UIAction(radioMaintainRecords, string.Empty, "a");

            UIAction(txtAvgAmtCustomersProperty, AvgAmtCustomersProperty, "textbox");

            UIAction(txtAvgAmtMemoConsignment, AvgAmtMemoConsignment, "textbox");

            UIAction(txtLooseDiamonds, LooseDiamonds, "textbox");

            UIAction(coveragesTab, string.Empty, "a");

            pause();

            WaitUntilElementIsDisplayed(driver, By.XPath("//div[id$='ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:0']"));

            UIAction(stockAOPLimit, stockAOPLimittxt, "textbox");

            pause();


            Actions action = new Actions(driver);

            action.SendKeys(Keys.Tab).Build().Perform();

            pause();
            pause();
            pause();

            string txtStockPeakLimit = "input[id$='ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:CovCategoryIterator:5:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput']";
            UIAction(txtStockPeakLimit, "1000", "textbox");

            IList<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(btnOK)).ToList();

            WaitFor(PageInputElements[0]);
            //   UIAction(stockFireDeductible, "1,000", "selectbox");

            UIAction(btnOK, string.Empty, "a");


        }
    }
}

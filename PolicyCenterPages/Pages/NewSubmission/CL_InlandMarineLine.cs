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


    public class CL_InlandMarineLine : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";
        public CL_InlandMarineLine(IWebDriver driver) : base(driver)
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

        public void EnterInlandMarineDetails()
        {
            //UIAction(btnNext, string.Empty , "a");
        }
        public void ClickNextButton()
        {
            UIAction(btnNext, string.Empty, "a");
        }

        public void ClickTabILM(string tab)
        {
            IWebElement ilmtab;

            switch (tab.ToUpper().Trim())
            {
                case "AMOUNT WE PAY COVERAGES":
                    ilmtab = driver.FindElement(By.XPath("//a[text()= 'Amount We Pay Coverages']"));
                    JavaScriptClick(ilmtab);
                    break;
                case "OFF PREMISE COVERAGES":
                    System.Console.WriteLine("I am in case");
                    ilmtab = driver.FindElement(By.XPath("//a[text()= 'Off Premise Coverages']"));
                    JavaScriptClick(ilmtab);
                    break;
                case "COVERAGE EXTENSION":
                    ilmtab = driver.FindElement(By.XPath("//a[text()= 'Coverage Extension']"));
                    JavaScriptClick(ilmtab);
                    break;
                case "EXCLUSION AND CONDITIONS":
                    ilmtab = driver.FindElement(By.XPath("//a[text()= 'Exclusions & Conditions']"));
                    JavaScriptClick(ilmtab);
                    break;
                case "DEDUCTIBLE PROVISION":
                    ilmtab = driver.FindElement(By.XPath("//a[text()= 'Deductible Provision']"));
                    JavaScriptClick(ilmtab);
                    break;
                case "BLANKET COVERAGES":
                    ilmtab = driver.FindElement(By.XPath("//a[text()= 'Blanket Coverages']"));
                    JavaScriptClick(ilmtab);
                    break;

                default:
                    break;
            }


        }


        public void OffPermiseCoverage(string Tableid, int RowCount, string type, int coloumnCount, string value)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id(Tableid)).ToList();
            Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[RowCount - 1].FindElements(By.TagName("td"));

            switch (type.ToUpper().Trim())
            {
                case "TEXTBOX":
                    var Cellinputbox = tds[coloumnCount - 1].FindElements(By.TagName("input"));
                    Cellinputbox[0].SendKeys(Keys.Control + "a");
                    Cellinputbox[0].SendKeys(value);
                    //    Cellinputbox[0].SendKeys(Keys.Tab);
                    pause();

                    break;

                case "SELECT":
                    var CellSelectbox = tds[coloumnCount - 1].FindElements(By.TagName("select"));
                    SelectByText(CellSelectbox[0], value);
                    int n;
                    bool isNumeric = int.TryParse(value, out n);
                    if (isNumeric)
                        SelectByIndex(CellSelectbox[0], int.Parse(value));
                    else
                        SelectByText(CellSelectbox[0], value);

                    pause();
                    break;
                case "WEBELEMENT":
                    var CellCheckbox = tds[coloumnCount - 1].FindElements(By.TagName("input"));
                    try
                    {
                        CellCheckbox[0].Click();
                    }
                    catch (Exception e)
                    {

                    }
                    pause();
                    pause();
                    break;
            }







        }

        public void Updatecoverage(string coveragetype, string limit, string deductible)
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//div[id$='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoverages']"));
            string tableid;
            switch (coveragetype.ToLower().Trim())
            {
                case "usps registered mail":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:0:ILMCoverageInputSet:CovPatternInputGroup";
                    break;
                case "usps priority mail express":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:1:ILMCoverageInputSet:CovPatternInputGroup";
                    break;
                case "to & from the post office":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:2:ILMCoverageInputSet:CovPatternInputGroup";
                    break;
                case "unspecified carriers":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:3:ILMCoverageInputSet:CovPatternInputGroup";
                    break;
                case "armored car services":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:4:ILMCoverageInputSet:CovPatternInputGroup";
                    break;
                case "goods in custody of jewelry dealers":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:5:ILMCoverageInputSet:CovPatternInputGroup";
                    break;
                case "property in safe or vault in bank":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:6:ILMCoverageInputSet:CovPatternInputGroup";
                    OffPermiseCoverage(tableid, 1, "WEBELEMENT", 3, "");
                    OffPermiseCoverage(tableid, 2, "TEXTBOX", 5, limit);
                    OffPermiseCoverage(tableid, 3, "SELECT", 5, deductible);
                    break;
                case "included travel":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:7:ILMCoverageInputSet:CovPatternInputGroup";
                    break;
                case "maximum travel aggregate":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:8:ILMCoverageInputSet:CovPatternInputGroup";
                    OffPermiseCoverage(tableid, 2, "TEXTBOX", 5, limit);
                    OffPermiseCoverage(tableid, 3, "SELECT", 5, deductible);
                    break;
                case "property otherwise away":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:9:ILMCoverageInputSet:CovPatternInputGroup";
                    OffPermiseCoverage(tableid, 1, "WEBELEMENT", 3, "");
                    OffPermiseCoverage(tableid, 2, "TEXTBOX", 5, limit);
                    OffPermiseCoverage(tableid, 3, "SELECT", 5, deductible);
                    break;

            }
        }


        public void AddILMBlankets(Table table)
        {
            ClickTabILM("BLANKET COVERAGES");
            System.Threading.Thread.Sleep(2000);
            string chkStockBlanket = "input[id$='ILMLineCoveragesPanelSet:CovCategoryIterator:0:ILMCoverageInputSet:CovPatternInputGroup:_checkbox']";
            WaitUntilElementVisible(driver, By.CssSelector(chkStockBlanket));
            //UIAction(chkStockBlanket, string.Empty, "span");
            driver.FindElement(By.CssSelector(chkStockBlanket)).Click();
            string txtStockLimit = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput']";
            string txtPremium = "input[id$=':0:ILMCoverageInputSet:CovPatternInputGroup:2:ILMCovTermInputSet:DirectTermInput']";
            WaitUntilElementVisible(driver, By.CssSelector(txtStockLimit));
            UIAction(txtStockLimit, table.Rows[0]["StockLimit"], "textbox");
            WaitUntilElementVisible(driver, By.CssSelector(txtPremium));
            UIAction(txtPremium, table.Rows[0]["Premium"], "textbox");

        }

    }
}

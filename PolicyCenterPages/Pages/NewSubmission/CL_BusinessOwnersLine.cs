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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenterPages.Pages.NewSubmission
{


    public class CL_BusinessOwnersLine : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";

        string RetroDateCSS = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:BOPLinePanelSet:BOPLiabilityDV:5:CoverageInputSet:CovPatternInputGroup:BOPEmplmtPrctcLiabRetroDateTerm_date";
        string SelClaimLimit = "select[id$='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:BOPLinePanelSet:BOPLiabilityDV:5:CoverageInputSet:CovPatternInputGroup:BOPEmplmtPrctcLiabLimTerm']";

        string SelDeductible = "select[id$='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:BOPLinePanelSet:BOPLiabilityDV:5:CoverageInputSet:CovPatternInputGroup:BOPEmplmtPrctcLiabDedTerm']";


        //SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:BOPLinePanelSet:BOPLiabilityDV:5:CoverageInputSet:CovPatternInputGroup:BOPEmplmtPrctcLiabRetroDateTerm_date
        string RetroCyberCSS = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:BOPLinePanelSet:BOPLiabilityDV:0:CoverageInputSet:CovPatternInputGroup:CyberRetroDate_date";
        string tabPackageCoverages = "a[id$=':BOP_PackageCoveragesCardTab']";

        string selPackageLevel = "select[id$=':PackageLevel']";

        public CL_BusinessOwnersLine(IWebDriver driver) : base(driver)
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

        public void UpdateEmploymentRelatedPracticesLiability(string PerClaimLimit, string Deductible)
        {
            UIAction(SelClaimLimit, PerClaimLimit, "selectbox");
            pause();
            pause();
            UIAction(SelDeductible, Deductible, "selectbox");
            pause();
        }

        public void UpdateBusinnessOwnerLineDetails(string date, string Packagetype)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (date.ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());

                var tempDate = tempRetroDate.ToShortDateString();

                Console.WriteLine("ppppp" + tempDate);

                pause();

                js.ExecuteScript("document.getElementById('" + RetroCyberCSS + "').value='" + tempDate + "'");

                if (ScenarioContext.Current["country"].ToString().ToLower() != "canada")
                {
                    js.ExecuteScript("document.getElementById('" + RetroDateCSS + "').value='" + tempDate + "'");
                }
            }
            else

            {
                js.ExecuteScript("document.getElementById('" + RetroCyberCSS + "').value='" + date + "'");

                if (ScenarioContext.Current["country"].ToString().ToLower() != "canada")
                {
                    js.ExecuteScript("document.getElementById('" + RetroDateCSS + "').value='" + date + "'");
                }
            }

            UIAction(tabPackageCoverages, string.Empty, "a");

            UIAction(selPackageLevel, Packagetype, "selectbox");

            pause();

            pause();

            pause();


          
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



        public void Updatecoverage(string Coveragetype, string IncludedLimit, string OverrideLimit, string RetainedLimitofInsurance, string FacultativeReinsuranceCost, string IncludedDeductible, string OverrideDeductible)
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//div[id$='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:BOP_PackageCoveragesCard']"));
            string tableid;
            switch (Coveragetype.ToLower().Trim())
            {
                case "accounts receivable":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:0:CoverageInputSet:CovPatternInputGroup";
                    break;
                case "appraisal equipment, including master stones":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:1:CoverageInputSet:CovPatternInputGroup";
                    break;
                case "employee dishonesty":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:3:CoverageInputSet:CovPatternInputGroup";
                 //   OffPermiseCoverage(tableid, 3, "WEBELEMENT", 3, "");
                    OffPermiseCoverage(tableid, 3, "SELECT", 5, OverrideLimit);
                    pause();
                    OffPermiseCoverage(tableid, 4, "SELECT", 5, RetainedLimitofInsurance);
                    pause();
                    OffPermiseCoverage(tableid, 5, "TEXTBOX", 5, FacultativeReinsuranceCost);
                    pause();
                    OffPermiseCoverage(tableid, 7, "SELECT", 5, OverrideDeductible);
                    pause();
                    break;
                case "forgery or alteration":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:4:CoverageInputSet:CovPatternInputGroup";
                    break;
                case "money and securities - off premises":
                    //tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:6:CoverageInputSet:CovPatternInputGroup";
                    string sCoverage = "Money and Securities Season Increase - Off Premises";
                    string lnkBOPAddlCoverage = "a[id$=':BOPScreen:BOP_AdditionalCardTab']";
                    string btnBOPAddlCoverage = "a[id$= ':BOPScreen:AdditionalBOPCoverages_JMICPanelSet:AdditionalCoveragesDV_tb:Add']";
                    string txtKeyWord = "input[id$=':CoveragePatternSearchScreen:CoveragePatternSearchDV:Keyword']";
                    string btnSearch = "span[id$=':SearchAndResetInputSet:SearchLinksInputSet:Search_link']";
                    string chkCoverage = "input[id$=':CoveragePatternSearchResultsLV:0:_Checkbox']";
                    string btnSelectCoverage = "a[id$=':CoveragePatternSearchResultsLV_tb:AddCoverageButton']";
                    string txtMASLimit = "input[id$=':BOPScreen:AdditionalBOPCoverages_JMICPanelSet:AdditionalCoveragesDV:1:CoverageInputSet:CovPatternInputGroup:0:CovTermInputSet:DirectTermInput']";
                    string txtFromDt = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:AdditionalBOPCoverages_JMICPanelSet:AdditionalCoveragesDV:1:CoverageInputSet:CovPatternInputGroup:2:TempFromOrTempToDateTerm";
                    string txtToDt = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:AdditionalBOPCoverages_JMICPanelSet:AdditionalCoveragesDV:1:CoverageInputSet:CovPatternInputGroup:3:TempFromOrTempToDateTerm";
                    UIAction(lnkBOPAddlCoverage, string.Empty, "a");
                    WaitUntilElementVisible(driver, By.CssSelector(btnBOPAddlCoverage));
                    UIAction(btnBOPAddlCoverage, string.Empty, "a");
                    WaitUntilElementVisible(driver, By.CssSelector(txtKeyWord));
                    UIAction(txtKeyWord, sCoverage, "textbox");
                    UIAction(btnSearch, string.Empty, "span");
                    WaitUntilElementVisible(driver, By.CssSelector(chkCoverage));
                    UIAction(chkCoverage, string.Empty, "a");
                    pause();
                    pause();
                    UIAction(btnSelectCoverage, string.Empty, "a");
                    WaitUntilElementVisible(driver, By.CssSelector(txtMASLimit));
                    pause();
                    pause();
                    UIAction(txtMASLimit, "1000", "textbox");
                    var tempDate = "";
                    DateTime CurrentDate = DateTime.Now;
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                    tempDate = tempRetroDate.ToShortDateString();
                    js.ExecuteScript("document.getElementById('" + txtFromDt + "').value='" + tempDate + "'");
                    pause();
                    tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(30));
                    js.ExecuteScript("document.getElementById('" + txtToDt + "').value='" + tempDate + "'");
                    pause();
                    break;
                case "signs coverage (stationary) - off premises":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:10:CoverageInputSet:CovPatternInputGroup";
                    break;
                case "unspecified personal property off premises":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:11:CoverageInputSet:CovPatternInputGroup";
                  
                    break;
                case "unattended vehicle coverage":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:12:CoverageInputSet:CovPatternInputGroup";
                    break;
                case "valuable papers and records - off premises":
                    tableid = "SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:PackageCoveragesPanelSet:AdditionalCoveragesDV:13:CoverageInputSet:CovPatternInputGroup";
                    //OffPermiseCoverage(tableid, 2, "TEXTBOX", 5, limit);
                    //OffPermiseCoverage(tableid, 3, "SELECT", 5, deductible);
                    break;
             

            }

        }
        public void clickNextButton()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));

            UIAction(btnNext, string.Empty, "a");
        }

        public void EnterBusinnessOwnerLineDetails(string RetroDate)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (RetroDate.ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());

                var tempDate = tempRetroDate.ToShortDateString();

                Console.WriteLine("ppppp" + tempDate);

                pause();

                js.ExecuteScript("document.getElementById('" + RetroCyberCSS + "').value='" + tempDate + "'");

                if (ScenarioContext.Current["country"].ToString().ToLower() != "canada")
                {
                    js.ExecuteScript("document.getElementById('" + RetroDateCSS + "').value='" + tempDate + "'");
                }
            }
            else

            {
                js.ExecuteScript("document.getElementById('" + RetroCyberCSS + "').value='" + RetroDate + "'");

                if (ScenarioContext.Current["country"].ToString().ToLower() != "canada")
                {
                    js.ExecuteScript("document.getElementById('" + RetroDateCSS + "').value='" + RetroDate + "'");
                }
            }

            UIAction(tabPackageCoverages, string.Empty, "a");

            UIAction(selPackageLevel, "Silver", "selectbox");

            pause();

            pause();

            pause();


            IsElementPresent(driver, By.CssSelector(btnNext));

            UIAction(btnNext, string.Empty, "a");



        }

        public void UpdateBOPEPLI_Verify()
        {
            string[] ClaimLimit = new string[] { "250,000", "500,000", "1,000,000" };
            string btnQuote = "a[id$=':QuoteOrReview']";
            string btnClear = "a[id$='WebMessageWorksheet:WebMessageWorksheetScreen:WebMessageWorksheet_ClearButton']";
            Actions action = new Actions(driver);
            for (int i = 0; i <= ClaimLimit.Length - 1; i++)
            {
                bool verifyError = false;
                System.Threading.Thread.Sleep(3000);
                UIAction(SelClaimLimit, ClaimLimit[i], "selectbox");

                action.SendKeys(Keys.Tab).Build().Perform();
                System.Threading.Thread.Sleep(3000);
                WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
                UIAction(btnQuote, string.Empty, "a");
                System.Threading.Thread.Sleep(6000);
                WaitUntilElementVisible(driver, By.CssSelector(btnClear));
                string errorMessage = driver.FindElement(By.XPath("//*[@id='WebMessageWorksheet:WebMessageWorksheetScreen:grpMsgs_msgs']")).Text;
                Console.WriteLine("Error message for " + ClaimLimit[i] + ":\n" + errorMessage);
                //if ((errorMessage.Contains("Error : An invalid quote was generated.")) && (errorMessage.Contains("Guidewire Coverage: BOPEmplmtPrctcLiabCov_JMIC")))
                //{
                //    verifyError = true;
                //}

                //if (verifyError == false)
                //{
                //    Assert.Fail("Unable verify EPLI Ratabase error");
                //}
                System.Threading.Thread.Sleep(3000);
                WaitUntilElementVisible(driver, By.CssSelector(btnClear));
                UIAction(btnClear, string.Empty, "a");
            }

            System.Threading.Thread.Sleep(3000);
            UIAction(SelClaimLimit, "100,000", "selectbox");
        }


        public void EnterBusinnessOwnerLineDetails_BOPSelect(string RetroDate)
        {

            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;

            if (RetroDate.ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (RetroDate.ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (RetroDate.Contains("+"))
            {
                string[] details = RetroDate.Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            else if (RetroDate.Contains("-"))
            {
                string[] details = RetroDate.Split('-');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));

            }
            else
            {
                tempDate = RetroDate;
            }

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + RetroCyberCSS + "').value='" + tempDate + "'");
            System.Threading.Thread.Sleep(3000);
            UIAction(tabPackageCoverages, string.Empty, "a");

            UIAction(selPackageLevel, "Silver", "selectbox");
            System.Threading.Thread.Sleep(3000);


            string lnkExclusionsTab = "a[id$=':BOPScreen:ExclusionsAndConditionsCardTab']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkExclusionsTab));
            UIAction(lnkExclusionsTab, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);

            string btnAddExcCon = "a[id$=':AdditionalExclusionsAndConditionsPanelSet:AddExclusionsOrCondition']";
            WaitUntilElementVisible(driver, By.CssSelector(btnAddExcCon));
            UIAction(btnAddExcCon, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);

            string txtKeyWord = "input[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchDV:Keyword']";
            WaitUntilElementVisible(driver, By.CssSelector(txtKeyWord));
            UIAction(txtKeyWord, "Absolute", "textbox");
            System.Threading.Thread.Sleep(2000);

            string btnSearch = "span[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search_link']";
            WaitUntilElementVisible(driver, By.CssSelector(btnSearch));
            UIAction(btnSearch, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);

            string chkAbsLiabCovg = "input[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchResultsLV:1:_Checkbox']";
            WaitUntilElementVisible(driver, By.CssSelector(chkAbsLiabCovg));
            UIAction(chkAbsLiabCovg, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);

            string btnAddCoverage = "a[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchResultsLV_tb:AddCoverageButton']";
            WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
            UIAction(btnAddCoverage, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);


            IsElementPresent(driver, By.CssSelector(btnNext));

            UIAction(btnNext, string.Empty, "a");



        }
    }
}

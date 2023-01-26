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
using System.Data;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCommonCore;
using Microsoft.Win32;

namespace PolicyCenterPages.Pages.Transaction
{
    public class PolicyRewriteFullTerm : Page
    {
        string btnQuote = "a[id$=':JobWizardToolbarButtonSet:QuoteOrReview']";
        string btnBindRewrite = "a[id$=':BindRewrite']";
        string uwIssuesMessage = "div[id$='UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle']";
        string uwIssuesPresent = "span[id$='ApproveDV:0:ShortDescriptionAndSize']";
        string btnDetails = "a[id$=':DetailsButton']";

        bool isPolicySuccessful = false;
        //string btnNext = "a[id$='SubmissionWizard:Next']";
        string btnNext = "a[id$=':Next']";

        public PolicyRewriteFullTerm(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            //VerifyUIElementIsDisplayed(btnBindRewrite);

        }

        public override void WaitForLoad()
        {
            //IsElementPresent(driver, By.CssSelector(btnBindRewrite));
        }


        public void SpecialApproveBlockingBindissues()
        {
            bool isSpecialApproveFlg;
            List<IWebElement> PageInputs;
            do
            {
                List<IWebElement> reservetableObj2;
                reservetableObj2 = driver.FindElements(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:RiskEvaluationPanelSet:1")).ToList();
                var rows2 = reservetableObj2[0].FindElements(By.TagName("tr"));
                var data = rows2[1].FindElements(By.TagName("td"));
                var Celldata = data[4].FindElement(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:RiskEvaluationPanelSet:1:UWIssueRowSet:SpecialApprove_container"));
                Celldata.Click();
                pause();
                driver.SwitchTo().Alert().Accept();
                pause();
                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();

                    break;
                }
                pause();
                isSpecialApproveFlg = IsElementPresent(driver, By.CssSelector("span[id='SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:RiskEvaluationPanelSet:1:UWIssueRowSet:SpecialApprove_container']"));

            } while (isSpecialApproveFlg);
        }

        public void IssuePolicy()
        {
            List<IWebElement> PageInputs;
            Actions action = new Actions(driver);
            System.Threading.Thread.Sleep(5000);

            pause();
            pause();
            UIAction(btnBindRewrite, string.Empty, "a");
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
            Console.WriteLine("First UW Issue");
            IssueReWritePolicy();

            Console.WriteLine("Second UW Issue");
            IssueReWritePolicy();

            Console.WriteLine("Third UW Issue");
            IssueReWritePolicy();
        }
        public void IssueReWritePolicy()
        {
            List<IWebElement> PageInputs;
            bool isPolicySuccessful = false;
            pause();
            pause();
            //UIAction(btnDetails, string.Empty, "a");
            bool uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesPresent));
            Console.WriteLine("UWISsues =====" + uwIssues);
            if (uwIssues)
            {
                IWebElement btnUSIssues = driver.FindElement(By.CssSelector(btnDetails));
                WaitForEnabled(btnUSIssues);
                Console.WriteLine("UW issues present");
                UIAction(btnDetails, string.Empty, "a");
                pause();
                PageInputs = driver.FindElements(By.CssSelector("span[id$=':SpecialApprove_link']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    Console.WriteLine("TExt" + PageInputs[i].Text);
                    if (PageInputs[i].Text.ToLower().Trim() == "special approve")
                    {
                        Console.WriteLine("Found");
                        PageInputs[i].Click();
                        System.Threading.Thread.Sleep(3000);
                    }
                    break;
                }
                System.Threading.Thread.Sleep(3000);
                driver.SwitchTo().Alert().Accept();
                System.Threading.Thread.Sleep(5000);
                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();
                    break;
                }
                System.Threading.Thread.Sleep(3000);
                UIAction(btnBindRewrite, string.Empty, "a");
                System.Threading.Thread.Sleep(3000);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                System.Threading.Thread.Sleep(10000);

                //isPolicySuccessful = IsElementPresent(driver, By.CssSelector("div[id='JobComplete:JobCompleteScreen:Message']"));
                //do{
                //    System.Threading.Thread.Sleep(3000);
                //    isPolicySuccessful = IsElementPresent(driver, By.CssSelector("div[id='JobComplete:JobCompleteScreen:Message']"));
                //} while (isPolicySuccessful);

            }
            Console.WriteLine("Out of loop");
        }
        public void ClickQuoteNextButton()
        {
            UIAction(btnNext, string.Empty, "a");
        }
        public void ClickQuote()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            UIAction(btnQuote, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnBindRewrite));
        }

        public void VerifyRewritePolicy()
        {
            string lnkPolicyBound = "div[class='info'][id='JobComplete:JobCompleteScreen:Message']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkPolicyBound));
            string sPolicyChangeStatus = driver.FindElement(By.CssSelector(lnkPolicyBound)).Text;

            if (sPolicyChangeStatus.EndsWith("has been bound."))
            {
                Console.WriteLine("Policy Rewrite Status: " + sPolicyChangeStatus);
            }
            else
            {
                Assert.Fail("Unable to bound Policy Rewrite");
            }
        }


        public void issueRewriteNewterm()
        {
            List<IWebElement> PageInputs;
            Actions action = new Actions(driver);
            System.Threading.Thread.Sleep(12000);

            pause();
            pause();
            UIAction(btnBindRewrite, string.Empty, "a");
            pause();
            try
            {
                driver.SwitchTo().Alert().Accept();
                WaitForPageLoad(driver);
                System.Threading.Thread.Sleep(5000);
                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            System.Threading.Thread.Sleep(5000);
            string lnkPolicyBound = "div[class='info'][id='JobComplete:JobCompleteScreen:Message']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkPolicyBound));
            string sPolicyChangeStatus = driver.FindElement(By.CssSelector(lnkPolicyBound)).Text;

            if (sPolicyChangeStatus.EndsWith("has been bound."))
            {
                Console.WriteLine("Policy RewriteNewterm Status: " + sPolicyChangeStatus);
            }
            else
            {
                Assert.Fail("Unable to bound Policy RewriteNewterm");
            }
        }


        public void RewriteRemainderAddILMEmpDisHon(Table table)
        {
            string chkEmpDisHon = "input[id$='RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:CoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:0:ILMCoverageInputSet:CovPatternInputGroup:_checkbox']";
            string lstEmpDisHonLimit = "select[id$='RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:CoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:0:ILMCoverageInputSet:CovPatternInputGroup:0:EmpDshnstLimt_JMIC']";
            string lstEmpDisHonDed = "select[id$='RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:CoveragesPanel:ILMLineCoveragesPanelSet:CovCategoryIterator:0:ILMCoverageInputSet:CovPatternInputGroup:1:DeductibleTermInput']";

            driver.FindElement(By.CssSelector(chkEmpDisHon)).Click();
            System.Threading.Thread.Sleep(2000);
            UIAction(lstEmpDisHonLimit, table.Rows[0]["EmployeeDishonesty_Limit"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(lstEmpDisHonDed, table.Rows[0]["EmployeeDishonesty_Deductible"], "selectbox");
            System.Threading.Thread.Sleep(2000);
        }

        public void UpdateStockAOPLimit_StockPeak(Table table)
        {
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            string ILMLocJStock = "a[id='RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV:" + (locationNum - 1) + ":StockDescription']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLocJStock));
            UIAction(ILMLocJStock, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string coveragesTab = "a[id$=':CoveragesTab']";
            WaitUntilElementVisible(driver, By.CssSelector(coveragesTab));
            UIAction(coveragesTab, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string stockAOPLimit = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:CovCategoryIterator:0:ILMCoverageInputSet:CovPatternInputGroup:0:StockAOPLimit";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + stockAOPLimit + "').value=''");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();
            System.Threading.Thread.Sleep(3000);
            //UIAction(stockAOPLimit, table.Rows[0]["StockAOP_Limit"], "textbox");
            js.ExecuteScript("document.getElementById('" + stockAOPLimit + "').value='" + table.Rows[0]["StockAOP_Limit"] + "'");
            action.SendKeys(Keys.Tab).Build().Perform();
            System.Threading.Thread.Sleep(3000);
            string lstStockDed = "select[id$='1:StockAOPDeductible']";
            WaitUntilElementVisible(driver, By.CssSelector(lstStockDed));
            UIAction(lstStockDed, table.Rows[0]["AOP_Deductible"], "selectbox");
            pause();


            string btnAddCoverage = "a[id$=':CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:ToolbarButton_arrow']";
            string lnkStockPeak = "a[id$=':CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:ToolbarButton:0:subItemCoverable']";

            pause();
            pause();
            string txtStockPeakLimit = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput']";
            string StockPeakDeductible = "select[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:OptionTermInput']";
            string StockPeakFrom = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:FromDate:DateTimeTermInput";
            string StockPeakTo = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ToDate:DateTimeTermInput";
            string StockPeakRecurringNo = "input[id$=':0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_false']";

            WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
            UIAction(btnAddCoverage, string.Empty, "a");
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(lnkStockPeak));
            UIAction(lnkStockPeak, string.Empty, "a");
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(txtStockPeakLimit));
            UIAction(txtStockPeakLimit, table.Rows[0]["StockPeak_Limit"], "textbox");
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(StockPeakDeductible));
            UIAction(StockPeakDeductible, table.Rows[0]["StockPeak_Deductible"], "selectbox");

            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            if (table.Rows[0]["StockPeak_StartDate"].ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (table.Rows[0]["StockPeak_StartDate"].ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (table.Rows[0]["StockPeak_StartDate"].Contains("+"))
            {
                string[] details = table.Rows[0]["SPFrom"].Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            js.ExecuteScript("document.getElementById('" + StockPeakFrom + "').value='" + tempDate + "'");
            pause();
            if (table.Rows[0]["StockPeak_EndDate"].ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (table.Rows[0]["StockPeak_EndDate"].ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (table.Rows[0]["StockPeak_EndDate"].Contains("+"))
            {
                string[] details = table.Rows[0]["StockPeak_EndDate"].Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            js.ExecuteScript("document.getElementById('" + StockPeakTo + "').value='" + tempDate + "'");

            pause();
            WaitUntilElementVisible(driver, By.CssSelector(StockPeakRecurringNo));
            UIAction(StockPeakRecurringNo, string.Empty, "input");
            pause();


            string btnOK = "a[id$='ILMJewelryStock_JMICPopup:Update']";
            System.Threading.Thread.Sleep(3000);
            UIAction(btnOK, string.Empty, "a");
            System.Threading.Thread.Sleep(3000);


        }


        public void DeleteILMLocations(int locNumber)
        {
            //pause();
            //pause();
            //string chkLocation = "input[id$='RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV:" + (locNumber - 1) + ":_Checkbox']";
            //string btnRemove = "a[id$='RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:Remove']";

            System.Threading.Thread.Sleep(5000);
            string chkLocation = "input[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV:" + (locNumber - 1) + ":_Checkbox']";
            string btnRemove = "a[id$=':LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:Remove']";
            driver.FindElement(By.CssSelector(chkLocation)).Click();
            UIAction(btnRemove, string.Empty, "a");
            System.Threading.Thread.Sleep(3000);
        }

        public void AddAIonILMBOLocs(Table table)
        {
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            int ILMlocationNum = Convert.ToInt32(table.Rows[0]["ILMLoc"]);
            System.Threading.Thread.Sleep(5000);
            string ILMLoc = "span[label='Loc. #'][value='" + ILMlocationNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLoc));
            UIAction(ILMLoc, string.Empty, "span");

            System.Threading.Thread.Sleep(2000);
            string AddILMLOCAddlIntrests = "a[id$='ILMLocation_JMICPopup:ILMLocation_JMICCV:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:AddContactsButton_arrow']";
            WaitUntilElementVisible(driver, By.CssSelector(AddILMLOCAddlIntrests));
            UIAction(AddILMLOCAddlIntrests, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string AddCompany = "a[id$='ILMLocation_JMICPopup:ILMLocation_JMICCV:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:AddContactsButton:0:ContactType']";
            WaitUntilElementVisible(driver, By.CssSelector(AddCompany));
            UIAction(AddCompany, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string lstIntrestType = "select[id$='NewAdditionalInterestPopup:ContactDetailScreen:AdditionalInterestInfoDV:Type']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstIntrestType));
            UIAction(lstIntrestType, table.Rows[0]["Interest_Type"], "selectbox");
            RegistryKey RegKey;
            string CompanyName = table.Rows[0]["AI_Name"] + GetUniqueValue();
            RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            RegKey.SetValue("PC_AddInsrd_ILM", CompanyName);

            string txtAddlIntrestName = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:CompanyName']";
            WaitUntilElementVisible(driver, By.CssSelector(txtAddlIntrestName));
            UIAction(txtAddlIntrestName, CompanyName, "textbox");
            string IsJewelerYesPL = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:IsAccountHolderJeweler_true']";
            string IsJewelerNoPL = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:IsAccountHolderJeweler_false']";
            switch (table.Rows[0]["Is_Jeweler"].ToLower().Trim())
            {
                case "yes":
                    UIAction(IsJewelerYesPL, string.Empty, "button");
                    break;
                case "no":
                    UIAction(IsJewelerNoPL, string.Empty, "button");
                    break;
                default:
                    break;
            }
            string AddressLine1 = "input[id$=':AddressLine1']";
            string City = "input[id$=':City']";
            string State = "select[id$=':State']";
            string ZipCode = "NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";
            string btnOK = "a[id$='NewAdditionalInterestPopup:ContactDetailScreen:ForceDupCheckUpdate']";
            string btnLocOK = "a[id$=':Update']";
            UIAction(AddressLine1, table.Rows[0]["Address_Line1"], "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            UIAction(State, table.Rows[0]["State"], "selectbox");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + table.Rows[0]["ZipCode"] + "'");
            System.Threading.Thread.Sleep(5000);
            UIAction(btnOK, string.Empty, "button");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnLocOK, string.Empty, "button");
            string lnkBusinessOwners = "a[id$='RewriteWizard:LOBWizardStepGroup:BOPWizardStepGroup']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkBusinessOwners));
            UIAction(lnkBusinessOwners, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string chkInterruption = "input[id$='RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPScreen:BOPLinePanelSet:BOPIncExpDV:1:CoverageInputSet:CovPatternInputGroup:_checkbox']";
            UIAction(chkInterruption, string.Empty, "input");
            driver.FindElement(By.CssSelector(chkInterruption)).Click();
            System.Threading.Thread.Sleep(2000);
            UIAction(btnNext, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string BOLoc = "span[label='Loc. #'][value='" + locationNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(BOLoc));
            UIAction(BOLoc, string.Empty, "span");
            js.ExecuteScript("document.getElementById('BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:LocationDetailInputSet:AddressInputSet:PostalCode').value=''");
            System.Threading.Thread.Sleep(2000);
            js.ExecuteScript("document.getElementById('BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:LocationDetailInputSet:AddressInputSet:AddressLine1').value=''");
            System.Threading.Thread.Sleep(2000);
            js.ExecuteScript("document.getElementById('BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:LocationDetailInputSet:AddressInputSet:City').value=''");
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.CssSelector(AddressLine1)).Click();
            System.Threading.Thread.Sleep(5000);
            UIAction(AddressLine1, "36 Jewelers Park Dr", "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            UIAction(State, table.Rows[0]["State"], "selectbox");
            js.ExecuteScript("document.getElementById('BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:LocationDetailInputSet:AddressInputSet:PostalCode').value='" + table.Rows[0]["ZipCode"] + "'");
            driver.FindElement(By.CssSelector(AddressLine1)).Click();
            System.Threading.Thread.Sleep(2000);
            string VerifyAddress = "a[id$=':verifyAddress_JMIC']";
            string selectVerifiedAddress = "span[id$=':selectAddress_link']";
            string acceptAddressChkBox = "input[id$=':acceptKeyInAddress']";
            string acceptAddress = "a[id$='VerifyAddress_JMIC_Popup:Update']";
            UIAction(VerifyAddress, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();
            if (PageInputs.Count > 0)
            {
                UIAction(selectVerifiedAddress, string.Empty, "a");
                UIAction(acceptAddressChkBox, string.Empty, "a");
                UIAction(acceptAddress, string.Empty, "button");
                pause();
            }
            System.Threading.Thread.Sleep(2000);
            UIAction(btnLocOK, string.Empty, "button");
            RewriteRemainder_AddAI_BOP(table);
        }

        public string GetUniqueValue()
        {
            DateTime myDateTime = DateTime.Now;
            string day = myDateTime.Day.ToString();
            string hour = myDateTime.Hour.ToString();
            string minute = myDateTime.Minute.ToString();
            string second = myDateTime.Second.ToString();
            string GetUniqueValue = day + hour + minute + second;
            return GetUniqueValue;
        }

        public void RewriteRemainder_AddAI_BOP(Table table)
        {
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            System.Threading.Thread.Sleep(5000);
            string BOLoc = "span[label='Loc. #'][value='" + locationNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(BOLoc));
            UIAction(BOLoc, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string AddBoLOCAddlIntrests = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationAdditionalInsureds_JMICDV:AdditionalInsuredLV_tb:AddContactsButton_arrow']";
            WaitUntilElementVisible(driver, By.CssSelector(AddBoLOCAddlIntrests));
            UIAction(AddBoLOCAddlIntrests, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string AddCompany = "a[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationAdditionalInsureds_JMICDV:AdditionalInsuredLV_tb:AddContactsButton:0:ContactType']";
            WaitUntilElementVisible(driver, By.CssSelector(AddCompany));
            UIAction(AddCompany, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string lstIntrestType = "select[id$='NewAdditionalInsuredPopup:ContactDetailScreen:AdditionalInsuredInfoDV:Type']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstIntrestType));
            UIAction(lstIntrestType, table.Rows[0]["Insured_Type"], "selectbox");
            RegistryKey RegKey;
            string CompanyName = table.Rows[0]["AI_Name_BOP"] + GetUniqueValue();
            RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            RegKey.SetValue("PC_AddInsrd_BOPLoc", CompanyName);
            string txtAddlIntrestName = "input[id$='NewAdditionalInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:CompanyName']";
            System.Threading.Thread.Sleep(4000);
            UIAction(txtAddlIntrestName, CompanyName, "textbox");
            string IsJewelerYesPL = "input[id$='NewAdditionalInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:IsAccountHolderJeweler_true']";
            string IsJewelerNoPL = "input[id$='NewAdditionalInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:IsAccountHolderJeweler_false']";
            switch (table.Rows[0]["Is_Jeweler_BOP"].ToLower().Trim())
            {
                case "yes":
                    UIAction(IsJewelerYesPL, string.Empty, "button");
                    break;
                case "no":
                    UIAction(IsJewelerNoPL, string.Empty, "button");
                    break;
                default:
                    break;
            }
            string AddressLine1 = "input[id$=':AddressLine1']";
            string City = "input[id$=':City']";
            string State = "select[id$=':State']";
            string ZipCode = "NewAdditionalInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";
            string btnOK = "a[id$='NewAdditionalInsuredPopup:ContactDetailScreen:ForceDupCheckUpdate']";
            string btnLocOK = "a[id$=':Update']";
            UIAction(AddressLine1, table.Rows[0]["Address_Line1_BOP"], "textbox");
            UIAction(City, table.Rows[0]["City_BOP"], "textbox");
            UIAction(State, table.Rows[0]["State_BOP"], "selectbox");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + table.Rows[0]["ZipCode_BOP"] + "'");
            System.Threading.Thread.Sleep(5000);
            UIAction(btnOK, string.Empty, "button");
            string txtAInsIntrest = "input[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationAdditionalInsureds_JMICDV:AdditionalInsuredLV:0:Interest_JMIC']";
            WaitUntilElementVisible(driver, By.CssSelector(txtAInsIntrest));
            UIAction(txtAInsIntrest, table.Rows[0]["BOPLocation_AI_Interest"], "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnLocOK, string.Empty, "button");

            //
        }

        public void AddNewBOLocs(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                string lnkNewLocation = "a[id$=':LocationsEdit_DP_tb:Add']";
                WaitUntilElementVisible(driver, By.CssSelector(lnkNewLocation));
                UIAction(lnkNewLocation, string.Empty, "a");

                string AddressLine1 = "input[id$=':AddressLine1']";
                string City = "input[id$=':City']";
                string State = "select[id$=':State']";
                string ZipCode = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:LocationDetailInputSet:AddressInputSet:PostalCode";
                string selectVerifiedAddress = "span[id$=':selectAddress_link']";
                string acceptAddressChkBox = "input[id$=':acceptKeyInAddress']";
                string acceptAddress = "a[id$='VerifyAddress_JMIC_Popup:Update']";
                string VerifyAddress = "a[id$=':verifyAddress_JMIC']";

                IWebElement IAddressline = driver.FindElement(By.CssSelector(AddressLine1));
                WaitForEnabled(IAddressline);
                UIAction(AddressLine1, table.Rows[i]["AddressLine1"], "textbox");

                UIAction(City, table.Rows[i]["City"], "textbox");
                UIAction(State, table.Rows[i]["State"], "selectbox");
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + table.Rows[i]["ZipCode"] + "'");
                System.Threading.Thread.Sleep(2000);
                //driver.FindElement(By.CssSelector(AddressLine1)).Click();
                if (ScenarioContext.Current["country"].ToString().ToLower() == "canada")
                {
                    VerifyAddress = "a[id$=':validateAddress_JMIC']";
                }

                UIAction(VerifyAddress, string.Empty, "a");
                System.Threading.Thread.Sleep(4000);
                
                List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();
                if (PageInputs.Count > 0)
                {
                    UIAction(selectVerifiedAddress, string.Empty, "a");
                    UIAction(acceptAddressChkBox, string.Empty, "a");
                    UIAction(acceptAddress, string.Empty, "button");
                    System.Threading.Thread.Sleep(2000);
                }

                string txtRetailPercent = "input[id$=':BOPLineLocationDetailInputSet:Retail_JMIC']";
                string txtCastingPercent = "input[id$=':BOPLineLocationDetailInputSet:Casting_JMIC']";
                string txtFullTimeEmp = "input[id$=':BOPLineLocationDetailInputSet:FullTimeEmployees_JMIC']";
                string txtPartTimeEmp = "input[id$=':BOPLineLocationDetailInputSet:PartTimeEmployees_JMIC']";
                string lstPublicProtection = "select[id$=':BOPLineLocationDetailInputSet:PublicProtection_JMIC']";
                string lstLocationType = "select[id$=':BOPLineLocationDetailInputSet:LocationType_JMIC']";
                string lnkPackageCoverageTab = "a[id$=':LocationDetailCV:PackageCoveragesTab']";
                string lstBOPPackageLevel = "select[id$=':LocationDetailCV:PackageLevel']";
                string btnLocOK = "a[id$=':Update']";


                WaitUntilElementVisible(driver, By.CssSelector(txtRetailPercent));
                UIAction(txtRetailPercent, table.Rows[i]["RetailPercent"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(txtCastingPercent));
                UIAction(txtCastingPercent, table.Rows[i]["CastingPercent"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(txtFullTimeEmp));
                UIAction(txtFullTimeEmp, table.Rows[i]["FullTimeEmp"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(txtPartTimeEmp));
                UIAction(txtPartTimeEmp, table.Rows[i]["PartTimeEmp"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(lstPublicProtection));
                UIAction(lstPublicProtection, table.Rows[0]["PublicProtection"], "selectbox");
                WaitUntilElementVisible(driver, By.CssSelector(lstLocationType));
                UIAction(lstLocationType, table.Rows[0]["LocationType"], "selectbox");
                System.Threading.Thread.Sleep(4000);
                WaitUntilElementVisible(driver, By.CssSelector(lnkPackageCoverageTab));
                UIAction(lnkPackageCoverageTab, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lstBOPPackageLevel));
                UIAction(lstBOPPackageLevel, table.Rows[0]["BOPPackageLevel"], "selectbox");

                WaitUntilElementVisible(driver, By.CssSelector(btnLocOK));
                UIAction(btnLocOK, string.Empty, "a");
            }
        }

        public void AddBOLocBldgs(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                System.Threading.Thread.Sleep(4000);
                int locationNum = Convert.ToInt32(table.Rows[i]["LocNumber"]);
                string btnBldAdd = "a[id$=':BOPLocationBuildingsLV_tb:Add']";
                string btnUpdate = "a[id$=':Update']";
                string searchPredominantBuildingOccupancy = "a[id$=':BOPBuildingClassCodeRange:SelectOrganization']";
                string selectFirstSearchResult = "span[id$=':0:_Select_link']";
                string selBuildingCodeEffectivenessGrade = "select[id$=':BuildingCodeEffectivenessGrade']";
                string radioTheftExclusionIndicatorFalse = "input[id$=':BOPTheftExclusionIndicator_false']";
                string radioBrandsAndLabelsIndicatorFalse = "input[id$=':BOPBrandsAndLabelsIndicator_false']";
                string ConstructionType = "BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_DetailsDV:CommonBuildingInfoBOPInputSet:ConstructionType";
                string TotalArea = "BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_DetailsDV:CommonBuildingInfoBOPInputSet:TotalArea";
                string AreaOccupied = "BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_DetailsDV:CommonBuildingInfoBOPInputSet:AreaOccupied";
                string PercentSprinklered = "BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_DetailsDV:CommonBuildingInfoBOPInputSet:PercentSprinklered";
                string lnkBPPCoveragesTab = "a[id$=':BOPBuildingBPPCoveragesCardTab']";
                string txtBPPLimit = "input[id$=':BOPBPPBldgLimit']";
                string lnkBPPSecirityInfoTab = "a[id$=':BOPBuilding_SecurityCardTab']";
                string radioAutomaticFireAlarm = "input[id$=':CommonBuilding_SecurityInfoDV:P2_true']";
                string radioServiceContract = "input[id$=':CommonBuilding_SecurityInfoDV:P4_false']";
                string radioOtherProtectiveGuard = "input[id$=':CommonBuilding_SecurityInfoDV:P9_false']";
                //string lnkLocationBld = "a[id$=':BOPLocationsLV:" + (locationNum - 1) + ":_ViewDetail']";

                Console.WriteLine("Locations: " + locationNum);
                if (locationNum - 1 > 0)
                {
                    string lnkLocationBld = "a[id$=':BOPLocationsLV:" + (locationNum - 1) + ":_ViewDetail']";
                    WaitUntilElementVisible(driver, By.CssSelector(lnkLocationBld));
                    UIAction(lnkLocationBld, string.Empty, "span");
                }

                //WaitUntilElementVisible(driver, By.CssSelector(lnkLocationBld));
                //UIAction(lnkLocationBld, string.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(btnBldAdd));
                UIAction(btnBldAdd, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(searchPredominantBuildingOccupancy));
                UIAction(searchPredominantBuildingOccupancy, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(selectFirstSearchResult));
                UIAction(selectFirstSearchResult, string.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(selBuildingCodeEffectivenessGrade));
                UIAction(selBuildingCodeEffectivenessGrade, "2", "selectbox");
                WaitUntilElementVisible(driver, By.CssSelector(radioTheftExclusionIndicatorFalse));
                UIAction(radioTheftExclusionIndicatorFalse, string.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(radioBrandsAndLabelsIndicatorFalse));
                UIAction(radioBrandsAndLabelsIndicatorFalse, string.Empty, "span");
                System.Threading.Thread.Sleep(2000);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('" + ConstructionType + "').selectedIndex='1'");
                System.Threading.Thread.Sleep(2000);
                js.ExecuteScript("document.getElementById('" + TotalArea + "').value='" + table.Rows[i]["TotBldgArea"] + "'");
                System.Threading.Thread.Sleep(2000);
                js.ExecuteScript("document.getElementById('" + AreaOccupied + "').value='" + table.Rows[i]["AreaOccuped"] + "'");
                System.Threading.Thread.Sleep(2000);
                js.ExecuteScript("document.getElementById('" + PercentSprinklered + "').selectedIndex='2'");
                System.Threading.Thread.Sleep(2000);
                UIAction(lnkBPPCoveragesTab, string.Empty, "a");
                UIAction(txtBPPLimit, table.Rows[i]["BPPLimt"], "textbox");
                driver.FindElement(By.Id("BOPBuildingPopup:BOPSingleBuildingDetailScreen:1:CoverageInputSet:CovPatternInputGroup:BOPBPPEstRplcmntCostLim")).Click();
                System.Threading.Thread.Sleep(2000);
                UIAction(lnkBPPSecirityInfoTab, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(radioAutomaticFireAlarm));
                UIAction(radioAutomaticFireAlarm, string.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(radioServiceContract));
                UIAction(radioServiceContract, string.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(radioOtherProtectiveGuard));
                UIAction(radioOtherProtectiveGuard, string.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(btnUpdate));
                UIAction(btnUpdate, string.Empty, "a");
                //string lnkLocationBld2 = "a[id$=':BOPLocationsLV:" + (locationNum - 2) + ":_ViewDetail']";
                //WaitUntilElementVisible(driver, By.CssSelector(lnkLocationBld2));
                //UIAction(lnkLocationBld2, string.Empty, "span");
                if (locationNum - 2 >= 0)
                {
                    string lnkLocationBld2 = "a[id$=':BOPLocationsLV:" + (locationNum - 2) + ":_ViewDetail']";
                    WaitUntilElementVisible(driver, By.CssSelector(lnkLocationBld2));
                    UIAction(lnkLocationBld2, string.Empty, "span");
                }
            }
        }
        public void AddNewBOLocsNewyork(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                string lnkNewLocation = "a[id$=':LocationsEdit_DP_tb:Add']";
                WaitUntilElementVisible(driver, By.CssSelector(lnkNewLocation));
                UIAction(lnkNewLocation, string.Empty, "a");

                string AddressLine1 = "input[id$=':AddressLine1']";
                string City = "input[id$=':City']";
                string State = "select[id$=':State']";
                string ZipCode = "BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationDetailDV:LocationDetailInputSet:AddressInputSet:PostalCode";
                string selectVerifiedAddress = "span[id$=':selectAddress_link']";
                string acceptAddressChkBox = "input[id$=':acceptKeyInAddress']";
                string acceptAddress = "a[id$='VerifyAddress_JMIC_Popup:Update']";
                string VerifyAddress = "a[id$=':verifyAddress_JMIC']";

                IWebElement IAddressline = driver.FindElement(By.CssSelector(AddressLine1));
                WaitForEnabled(IAddressline);
                UIAction(AddressLine1, table.Rows[i]["AddressLine1"], "textbox");

                UIAction(City, table.Rows[i]["City"], "textbox");
                UIAction(State, table.Rows[i]["State"], "selectbox");
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + table.Rows[i]["ZipCode"] + "'");
                System.Threading.Thread.Sleep(2000);
                //driver.FindElement(By.CssSelector(AddressLine1)).Click();
                UIAction(VerifyAddress, string.Empty, "a");
                System.Threading.Thread.Sleep(4000);
                List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();
                if (PageInputs.Count > 0)
                {
                    UIAction(selectVerifiedAddress, string.Empty, "a");
                    UIAction(acceptAddressChkBox, string.Empty, "a");
                    UIAction(acceptAddress, string.Empty, "button");
                    pause();
                }

                string txtRetailPercent = "input[id$=':BOPLineLocationDetailInputSet:Retail_JMIC']";
                string txtCastingPercent = "input[id$=':BOPLineLocationDetailInputSet:Casting_JMIC']";
                string txtFullTimeEmp = "input[id$=':BOPLineLocationDetailInputSet:FullTimeEmployees_JMIC']";
                string txtPartTimeEmp = "input[id$=':BOPLineLocationDetailInputSet:PartTimeEmployees_JMIC']";
                string lstPublicProtection = "select[id$=':BOPLineLocationDetailInputSet:PublicProtection_JMIC']";
                string lstLocationType = "select[id$=':BOPLineLocationDetailInputSet:LocationType_JMIC']";
                string lnkPackageCoverageTab = "a[id$=':LocationDetailCV:PackageCoveragesTab']";
                string lstBOPPackageLevel = "select[id$=':LocationDetailCV:PackageLevel']";
                string lstTerrorProp = "select[id$=':TerrorismTerritoryProp']";
                string lstTerrorLiab = "select[id$=':TerrorismTerritoryLiab']";
                string btnLocOK = "a[id$=':Update']";


                WaitUntilElementVisible(driver, By.CssSelector(txtRetailPercent));
                UIAction(txtRetailPercent, table.Rows[i]["RetailPercent"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(txtCastingPercent));
                UIAction(txtCastingPercent, table.Rows[i]["CastingPercent"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(txtFullTimeEmp));
                UIAction(txtFullTimeEmp, table.Rows[i]["FullTimeEmp"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(txtPartTimeEmp));
                UIAction(txtPartTimeEmp, table.Rows[i]["PartTimeEmp"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(lstPublicProtection));
                UIAction(lstPublicProtection, table.Rows[0]["PublicProtection"], "selectbox");
                WaitUntilElementVisible(driver, By.CssSelector(lstLocationType));
                UIAction(lstLocationType, table.Rows[0]["LocationType"], "selectbox");
                System.Threading.Thread.Sleep(4000);

                WaitUntilElementVisible(driver, By.CssSelector(lstTerrorProp));
                UIAction(lstTerrorProp, "001", "selectbox");
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(lstTerrorLiab));
                UIAction(lstTerrorLiab, "001", "selectbox");

                WaitUntilElementVisible(driver, By.CssSelector(lnkPackageCoverageTab));
                UIAction(lnkPackageCoverageTab, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lstBOPPackageLevel));
                UIAction(lstBOPPackageLevel, table.Rows[0]["BOPPackageLevel"], "selectbox");

                WaitUntilElementVisible(driver, By.CssSelector(btnLocOK));
                UIAction(btnLocOK, string.Empty, "a");
            }
        }

        public void DeleteBOLocBld(int PrimaryLoc, int locationNum, int LocBuildings)
        {
            string chkPriBoLoc = "input[id$=':LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPLocationsScreen:BOPLocationsPanelSet:LocationsEdit_DP:LocationsEdit_LV:" + (PrimaryLoc - 1) + ":_Checkbox']";
            string chkBoLoc = "input[id$=':LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPLocationsScreen:BOPLocationsPanelSet:LocationsEdit_DP:LocationsEdit_LV:" + (locationNum - 1) + ":_Checkbox']";
            string btnRemove = "a[id$=':Remove']";
            string BldLoc = "a[id$=':LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationsLV:" + locationNum + ":_ViewDetail']";
            string btnSetPrimary = "a[id$=':setToPrimary']";
            string btnBOBldRemove = "a[id$='LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationBuildingsLV_tb:Remove']";
            string btnBack = "a[id$=':Prev']";
            System.Threading.Thread.Sleep(2000);
            UIAction(btnNext, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
            if (locationNum != 1)
            {
                BldLoc = "a[id$=':LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationsLV:" + locationNum + ":_ViewDetail']";
                //WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
                UIAction(BldLoc, string.Empty, "span");
            }


            for (int i = 0; i < LocBuildings; i++)
            {

                string chkBoBldAddIns = "input[id$='LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationBuildingsLV:" + i + ":_Checkbox']";
                WaitUntilElementVisible(driver, By.CssSelector(chkBoBldAddIns));
                UIAction(chkBoBldAddIns, string.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(btnBOBldRemove));
                UIAction(btnBOBldRemove, string.Empty, "span");
            }
            System.Threading.Thread.Sleep(2000);
            UIAction(btnBack, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(chkPriBoLoc));
            UIAction(chkPriBoLoc, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(btnSetPrimary));
            UIAction(btnSetPrimary, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);

            WaitUntilElementVisible(driver, By.CssSelector(chkBoLoc));
            UIAction(chkBoLoc, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(btnRemove));
            UIAction(btnRemove, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
        }
        public void DeleteALLBldinLoc(int locationNum)
        {

            string chkBoLoc = "input[id$=':LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPLocationsScreen:BOPLocationsPanelSet:LocationsEdit_DP:LocationsEdit_LV:" + (locationNum - 1) + ":_Checkbox']";
            string btnRemove = "a[id$=':Remove']";
            string BldLoc = "a[id$=':LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationsLV:" + (locationNum - 1) + ":_ViewDetail']";
            string chkSelctAllBuldgs = "input[id$=':LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationBuildingsLV:_Checkbox']";
            string btnBOBldRemove = "a[id$='LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationBuildingsLV_tb:Remove']";
            string btnBack = "a[id$=':Prev']";
            System.Threading.Thread.Sleep(2000);
            UIAction(btnNext, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
            UIAction(BldLoc, string.Empty, "span");

            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(chkSelctAllBuldgs));
            UIAction(chkSelctAllBuldgs, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(btnBOBldRemove));
            UIAction(btnBOBldRemove, string.Empty, "span");

            System.Threading.Thread.Sleep(2000);
            UIAction(btnBack, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);


            WaitUntilElementVisible(driver, By.CssSelector(chkBoLoc));
            UIAction(chkBoLoc, string.Empty, "span");
            WaitUntilElementVisible(driver, By.CssSelector(btnRemove));
            UIAction(btnRemove, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
        }

        public void DeleteBOLocBld(Table table)
        {
            string btnBOBldRemove = "a[id$='LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationBuildingsLV_tb:Remove']";
            if ((table.Rows[0]["LocNumber"] == "1") && (table.Rows[0]["BuildingNum"] == "1"))
            {
                string chkBoBldAddIns = "input[id$='LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationBuildingsLV:0:_Checkbox']";
                //PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationBuildingsLV:0:_Checkbox
                WaitUntilElementVisible(driver, By.CssSelector(chkBoBldAddIns));
                UIAction(chkBoBldAddIns, string.Empty, "span");
                WaitUntilElementVisible(driver, By.CssSelector(btnBOBldRemove));
                UIAction(btnBOBldRemove, string.Empty, "span");
            }

        }


        public void IssuePolicy_JSPSCR3()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            UIAction(btnQuote, string.Empty, "a");
            List<IWebElement> PageInputs;
            bool isPolicySuccessful = false;
            pause();
            pause();

            IWebElement btnUSIssues = driver.FindElement(By.CssSelector(btnDetails));
            WaitForEnabled(btnUSIssues);
            Console.WriteLine("UW issues present");
            UIAction(btnDetails, string.Empty, "a");
            pause();

            for (int j = 1; j <= 4; j++)
            {
                pause();
                PageInputs = driver.FindElements(By.CssSelector("span[id$=':SpecialApprove_link']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    Console.WriteLine("TExt" + PageInputs[i].Text);
                    if (PageInputs[i].Text.ToLower().Trim() == "special approve")
                    {
                        Console.WriteLine("Found");
                        PageInputs[i].Click();
                        System.Threading.Thread.Sleep(3000);
                    }
                    break;
                }
                System.Threading.Thread.Sleep(3000);
                driver.SwitchTo().Alert().Accept();
                System.Threading.Thread.Sleep(5000);

                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();
                    break;
                }
                System.Threading.Thread.Sleep(5000);

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

            }
            Console.WriteLine("Out of loop");
        }

        public void propertyOtherwiseAway(Table table)
        {
            string PropOthAwayLimit = "input[id$=':ILMLineCoveragesPanelSet:CovCategoryIterator:9:ILMCoverageInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:DirectTermInput']";
            string AvgDaily = "input[id$=':ILMLineCoveragesPanelSet:CovCategoryIterator:5:ILMCoverageInputSet:CovPatternInputGroup:2:GdsAtJwlrExposure_JMIC']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(PropOthAwayLimit));
            UIAction(PropOthAwayLimit, table.Rows[0]["PropertyOtherwiseAwayLimit"], "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(AvgDaily));
            UIAction(AvgDaily, table.Rows[0]["AvgDayilyLimit"], "textbox");
        }

        public void BOUmbrellaLineDetails()
        {
            string selSelfInsuredRetention = "select[id$=':0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBSI']";
            pause();

            UIAction(selSelfInsuredRetention, "2", "selectbox");

            //  IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            // js.ExecuteScript("document.getElementById('" + selSelfInsuredRetention + "').value='0'");

            UIAction(btnNext, string.Empty, "a");
        }

        public void BOUmbrellaUnderwritingDetails()
        {
            string radioUmbUnderwritingQ1 = "input[id$=':0:QuestionInputSet:BooleanRadioInput_false']";

            string radioUmbUnderwritingQ2 = "input[id$=':1:QuestionInputSet:BooleanRadioInput_false']";

            string radioUmbUnderwritingQ3 = "input[id$=':2:QuestionInputSet:BooleanRadioInput_false']";

            string radioUmbUnderwritingQ4 = "input[id$=':3:QuestionInputSet:BooleanRadioInput_false']";

            string radioUmbUnderwritingQ5 = "input[id$='0:QuestionInputSet:BooleanRadioInput_NoPost_false']";

            UIAction(radioUmbUnderwritingQ1, string.Empty, "radio");

            pause();

            UIAction(radioUmbUnderwritingQ2, string.Empty, "radio");

            pause();

            UIAction(radioUmbUnderwritingQ3, string.Empty, "radio");

            pause();

            UIAction(radioUmbUnderwritingQ4, string.Empty, "radio");

            pause();

            UIAction(radioUmbUnderwritingQ5, string.Empty, "radio");

            pause();

            UIAction(btnNext, string.Empty, "a");
        }

        public void SelectOffering(string Offering)
        {
            string selOfferingSelection = "select[id$=':OfferingSelection']";
            pause();

            UIAction(selOfferingSelection, Offering, "selectbox");

            pause();

            IsElementPresent(driver, By.CssSelector(btnNext));

            pause();

            UIAction(btnNext, string.Empty, "a");
        }

        public void SelectLines(string lines)
        {
            string umbrellaLine = "span[value='Umbrella Line']";

            string lineType = "td[class='lv-cell first-cell']";

            string lineTypeChkBox = "input[id$=':LineSelected']";
            string[] lineItemArray = lines.Split(':');

            foreach (var line in lineItemArray)
            {
                List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(lineType)).ToList();

                for (var i = 0; i < PageInputElements.Count; i++)
                {
                    if (line.ToLower().Trim() == PageInputElements[i].Text.ToLower().Trim())
                    {
                        List<IWebElement> chkBoxes = driver.FindElements(By.CssSelector(lineTypeChkBox)).ToList();

                        Console.WriteLine("Line items count" + chkBoxes.Count);

                        Console.WriteLine("===" + chkBoxes[i].GetAttribute("checked"));
                        if (chkBoxes[i].GetAttribute("checked") != "true")

                            chkBoxes[i].Click();

                    }
                }

            }
            pause();

            UIAction(btnNext, string.Empty, "a");
        }

        public void SelectBOPLocation(int locNum)
        {
            System.Threading.Thread.Sleep(2000);
            string ILMLoc = "span[label='Loc. #'][value='" + locNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLoc));
            UIAction(ILMLoc, string.Empty, "span");
        }
    }
}

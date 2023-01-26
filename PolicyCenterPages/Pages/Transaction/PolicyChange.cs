using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenterPages.Pages.Transaction
{
    public class PolicyChange : Page
    {
        string rewriteIssue = "a[id ='RewriteWizard:RewriteWizard_QuoteScreen:JobWizardToolbarButtonSet:BindRewrite']";
        string riskAnalysisIssue = "a[id ='RewriteWizard:Job_RiskAnalysisScreen:JobWizardToolbarButtonSet:BindRewrite']";

        string btnIssuePolicyRewrite = "a[id$=':JobWizardToolbarButtonSet:BindRewrite']";
        string radioCSS = "input[class='radio']";
        string issueNowDownArrow = "a[id$=':BindOptions_arrow']";
        string bindAndRenew = "a[id$=':SendToRenewal']";
        string txtEffectiveDate = "input[id$=':StartPolicyChangeDV:EffectiveDateJMIC_date']";
        string listChangeReason = "select[id$=':PolicyChangeReason_JMICPanelSet:Test']";

        string txtDescription = "input[id$=':PolicyChangeReason_JMICPanelSet:Description']";

        string btnPolicyChangeNext = "a[id$=':StartPolicyChangeScreen:NewPolicyChange']";

        string btnWithdraWorkOrder = "a[id$='PolicyChangeWizard:PolicyChangeWizard_MultiLine_QuoteScreen:JobWizardToolbarButtonSet:WithdrawJob']";

        string txtChangeEffDt = "StartPolicyChange:StartPolicyChangeScreen:StartPolicyChangeDV:EffectiveDateJMIC_date";

        string btnNewChangeNext = "a[id$=':StartPolicyChangeScreen:NewPolicyChange']";

        string btnNext = "a[id$=':Next']";
        string lnkLogout = "a[id$=':LogoutTabBarLink']";
        string btnQuote = "a[id$=':JobWizardToolbarButtonSet:QuoteOrReview']";
        string btnIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindPolicyChange']";
        string btnRenewalNext = "a[id$='RenewalWizard:Next']";
        string btnReviewQuote = "a[id$=':JobWizardToolbarButtonSet:RenewalQuote']";

        string ChangePrimaryReason = "select[id$= 'PolicyChangeReason_JMICPanelSet:0:PrimaryChangeReason']";
        string ChangeReasonNext = "select[id$= 'PolicyChangeReason_JMICPanelSet:0:ChangeReason']";
        string ChangeReasonCategory = "select[id$= ':PolicyChangeReason_JMICPanelSet:0:ChangeReasonCat']";

        string uwIssuesMessage = "div[id='UWBlockProgressIssuesPopup']";

        string btnDetails = "a[id$=':DetailsButton']";

        string btnEditWorkOrder = "a[id$=':JobWizardToolbarButtonSet:EditPolicyWorkflow']";


        string txtAddressline1 = "input[id='EditPolicyAddressPopup:PolicyAddressInputSet:AddressInputSet:AddressLine1']";
        string txtCity = "input[id='EditPolicyAddressPopup:PolicyAddressInputSet:AddressInputSet:City']";
        string selectState = "select[id='EditPolicyAddressPopup:PolicyAddressInputSet:AddressInputSet:State']";
        string btnvalidateAddress = "a[id$=':validateAddress_JMIC']";
        string btnOkAddressDetails = "a[id$='EditPolicyAddressPopup:Update']";
        string ZipCode = "EditPolicyAddressPopup:PolicyAddressInputSet:AddressInputSet:PostalCode";

        string btnAddressButtonMenuIcon = "a[id$=':ChangePolicyAddressButton:ChangePolicyAddressButtonMenuIcon']";
        string btnEditCurrentAddress = "a[id$=':ChangePolicyAddressButton:EditPolicyAddressMenuItem']";

        string selectVerifiedAddress = "span[id$=':selectAddress_link']";
        string acceptAddressChkBox = "input[id$=':acceptKeyInAddress']";

        string acceptAddress = "a[id$='VerifyAddress_JMIC_Popup:Update']";

        string btnEditPrerenewal = "a[id='PreRenewalDirectionPage:PreRenewalDirectionScreen:Edit']";
        string btnUpdatePrerenewal = "a[id='PreRenewalDirectionPage:PreRenewalDirectionScreen:Update']";
        string selectPrerenewalDirection = "select[id='PreRenewalDirectionPage:PreRenewalDirectionScreen:PreRenewalDirection']";
        string selectPrerenewalDirectionReason = "select[id='PreRenewalDirectionPage:PreRenewalDirectionScreen:NonRenewReason']";


        public PolicyChange(IWebDriver driver) : base(driver)
        {
            pause();
            WaitForPageLoad(driver);
            SetActiveFrame();
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(btnPolicyChangeNext); 
        }

        public override void WaitForLoad()
        {
            //throw new NotImplementedException(); 
        }

     public void UpdatePreRenewal(string Direction, string Text, string NonRenewReason)
        {
            pause();
            pause();
          //  WaitUntilElementIsDisplayed(driver, By.Id("PreRenewalDirectionPage:PreRenewalDirectionScreen:Edit"));
            UIAction(btnEditPrerenewal, string.Empty, "a");
            pause();
            pause();
            //WaitUntilElementIsDisplayed(driver, By.Id("PreRenewalDirectionPage:PreRenewalDirectionScreen:Update"));
            UIAction(selectPrerenewalDirection, Direction, "selectbox");
            pause();
            UIAction(selectPrerenewalDirectionReason, NonRenewReason, "selectbox");
            pause();

            IWebElement txtareaText;

            txtareaText = driver.FindElement(By.XPath("//textarea[@id='PreRenewalDirectionPage:PreRenewalDirectionScreen:Text']"));
            txtareaText.SendKeys(Text);
            pause();

            UIAction(btnUpdatePrerenewal, string.Empty, "a");

        }

        public void updatePOlicyCHange(string EffectiveDate, string ChangeReason)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            DateTime date = DateTime.Now;
            Actions action = new Actions(driver);
            string SetDate = "";
            string ExpDate = "";

            if (EffectiveDate.ToLower() == "currentdate")
            {
              SetDate = string.Format("{0:MM/dd/yyyy}", date);
             }
            else if (EffectiveDate.Contains("+"))
            {
                string[] details = EffectiveDate.Split('+');
                SetDate = string.Format("{0:MM/dd/yyyy}", date.AddDays(Int32.Parse(details[1])));
              
            }
            else if (EffectiveDate.Contains("-"))
            {
                string[] details = EffectiveDate.Split('-');
                SetDate = string.Format("{0:MM/dd/yyyy}", date.AddDays(Int32.Parse("-" + details[1])));

            }
            else
            {
                SetDate = EffectiveDate;
            }
         
            string text = SetDate.ToString();
            text = text.Replace("/", "");
            Console.WriteLine("date to enter is : " + text);
            Console.WriteLine("Changes are " + ChangeReason);
            UIAction(txtEffectiveDate, text, "textbox");
            action.SendKeys(Keys.Tab);
            action.Perform();
            action.Release();

            pause();
            UIAction(listChangeReason, ChangeReason, "selectbox");
            pause();
            UIAction(btnPolicyChangeNext, string.Empty, "span");
           
        }

        public void ChangeEffectiveDate(string PolicyChangeEffDate)
        {
            Console.WriteLine("inside Method" + PolicyChangeEffDate);
            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            if (PolicyChangeEffDate.ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (PolicyChangeEffDate.ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (PolicyChangeEffDate.Contains("+"))
            {
                string[] details = PolicyChangeEffDate.Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            else if (PolicyChangeEffDate.Contains("-"))
            {
                string[] details = PolicyChangeEffDate.Split('-');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));

            }
            else
            {
                tempDate = PolicyChangeEffDate;
            }
            Console.WriteLine("Change Effective Date:" + tempDate);
            pause();
            pause();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("document.getElementById('" + txtChangeEffDt + "').value='" + tempDate + "'");
            GWSetCalanderDt(tempDate);
            pause();

        }
        public void ClickNext()
        {
            UIAction(btnNewChangeNext, string.Empty, "a");
        }

        public void ClickILMLink()
        {
            string lnkILMLink = "a[id$=':LOBWizardStepGroup:ILMWizardStepGroup']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkILMLink));
            UIAction(lnkILMLink, string.Empty, "a");
        }
        public void ClickOffPremiseCoveragesTab()
        {
            string tabOffPremises = "a[id$=':ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesTab']";
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(tabOffPremises));
            UIAction(tabOffPremises, string.Empty, "a");
        }

        public void AddTradeshowCoverage(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                string SearchText;
                string btnAddCoverage = "a[id$=':ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton_arrow']";
                string lstTradeShow = "a[id$=':ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton:5:subItemCoverable']";
                string imgTradeShowSearchIcon = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TradeshowPicker:SelectTradeshowPicker']";
                string btnResetSearch = "span[id$=':SearchAndResetInputSet:SearchLinksInputSet:Reset_link']";
                string lnkTimeFrame = "span[id$='Tradeshow_JMICSearchPopup:TradeShows_JMICLV:TradeshowTimeFrameHeader_link']";
                string lstHowMerch_Transported = "select[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:TypekeyTermInput']";
                string txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:ILMCovTermInputSet:DirectTermInput']";
                string lstDeductible = "select[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ILMCovTermInputSet:OptionTermInput']";
                string txtTransit_Days = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:5:ILMCovTermInputSet:DirectTermInput']";
                string radioRecurringYes = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:13:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_true']";
                string radioRecurringNo = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:13:RecurringCovTerm:ILMCovTermInputSet:BooleanTermInput_false']";
                string imgTmpChangeReason = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
                string btnReasonSelect = "span[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:0:_Select_link']";
                string lstTradeShowState = "select[id$='Tradeshow_JMICSearchPopup:TradeShow_JMICSearchDV:ShowState']";
                //string txtShowName = "input[id$='Tradeshow_JMICSearchPopup:TradeShow_JMICSearchDV:ShowName']";
                string btnSearch = "span[id$='Tradeshow_JMICSearchPopup:TradeShow_JMICSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search_link']";
                pause();
                WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
                UIAction(btnAddCoverage, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lstTradeShow));
                UIAction(lstTradeShow, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(imgTradeShowSearchIcon));
                UIAction(imgTradeShowSearchIcon, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(btnResetSearch));
                UIAction(btnResetSearch, string.Empty, "span");
                //WaitUntilElementVisible(driver, By.CssSelector(txtShowName));
                //UIAction(txtShowName, table.Rows[i]["Tradeshow_State"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(lstTradeShowState));
                UIAction(lstTradeShowState, table.Rows[i]["Tradeshow_State"], "selectbox");
                WaitUntilElementVisible(driver, By.CssSelector(btnSearch));
                UIAction(btnSearch, string.Empty, "a");
                //string EffDate = driver.FindElement(By.CssSelector("span[id='PolicyChangeWizard:JobWizardInfoBar:EffectiveDate_link']")).Text.Replace("Eff. ", string.Empty);
                WaitUntilElementVisible(driver, By.CssSelector(lnkTimeFrame));
                UIAction(lnkTimeFrame, string.Empty, "span");

                string sEffDate = "span[id$=':JobWizardInfoBar:EffectiveDate_link']";
                WaitUntilElementVisible(driver, By.CssSelector(sEffDate));

                string EffDate = driver.FindElement(By.CssSelector(sEffDate)).Text.Replace("Eff. ", string.Empty);
                string sTradeshowYear = Convert.ToDateTime(EffDate).AddMonths(3).Year.ToString();
                string CurrMonth = Convert.ToDateTime(EffDate).ToString("MMM");
                switch (CurrMonth.ToString())
                {
                    case "Jan":
                    case "Feb":
                    case "Mar":
                        SearchText = "April-June";
                        break;
                    case "Apr":
                    case "May":
                    case "Jun":
                        SearchText = "July-Sept";
                        break;
                    case "Jul":
                    case "Aug":
                    case "Sep":
                        SearchText = "Oct-Dec";
                        break;
                    default:
                        SearchText = "Jan-March";
                        break;
                }
                Console.WriteLine("EffDate: {0}\nTradeshowYear: {1}\nMonth: {2}\nSearchText: {3}", EffDate, sTradeshowYear, CurrMonth, SearchText);
                SelectElement AllPages = new SelectElement(driver.FindElement(By.Id("Tradeshow_JMICSearchPopup:TradeShows_JMICLV:_ListPaging")));
                string lstPages = "select[id='Tradeshow_JMICSearchPopup:TradeShows_JMICLV:_ListPaging']";
                int iTotPages = AllPages.Options.Count;
                bool bTradeshowFound = false;
                //Console.WriteLine("TradeShowPages: " + AllPages.Options.Count);
                for (int j = 0; j < iTotPages; j++)
                {
                    if (bTradeshowFound == true)
                        break;
                    if (j > 0)
                    {
                        System.Threading.Thread.Sleep(5000);
                        WaitUntilElementVisible(driver, By.CssSelector(lstPages));
                        UIAction(lstPages, j.ToString(), "selectbox");
                        System.Threading.Thread.Sleep(5000);
                    }
                    Console.WriteLine("Selected Page : " + driver.FindElement(By.CssSelector(lstPages)).GetAttribute("value"));
                    string tblShowNameID = "Tradeshow_JMICSearchPopup:TradeShows_JMICLV:";
                    List<IWebElement> tblShowRows = driver.FindElements(By.CssSelector("tr[id^='" + tblShowNameID + "']")).ToList();
                    int TradeShowsRowCount = tblShowRows.Count();
                    for (int k = 1; k <= TradeShowsRowCount - 1; k++)
                    {
                        if (bTradeshowFound == true)
                            break;
                        string lblTimeFrame = "Tradeshow_JMICSearchPopup:TradeShows_JMICLV:" + (k - 1) + ":TradeshowTimeFrame";
                        string lblTimeFrameSelect = "Tradeshow_JMICSearchPopup:TradeShows_JMICLV:" + (k - 1) + ":_Select_link";
                        string sTimeFrame = driver.FindElement(By.Id(lblTimeFrame)).Text;
                        //Console.WriteLine("Page: {0}\tRow: {1}\tTimeFrame:{2}",j+1,k, sTimeFrame);
                        if (sTimeFrame == SearchText)
                        {
                            pause();
                            driver.FindElement(By.Id(lblTimeFrame)).Click();
                            pause();
                            string tblShowYearID = "Tradeshow_JMICSearchPopup:TradeShowOccurrences_JMICLV:";
                            List<IWebElement> tblShowYearRows = driver.FindElements(By.CssSelector("tr[id^='" + tblShowYearID + "']")).ToList();
                            int TradeShowsYrsRowCount = tblShowYearRows.Count();
                            for (int l = 1; l <= TradeShowsYrsRowCount - 1; l++)
                            {
                                //string lblTimeFrameYear = "Tradeshow_JMICSearchPopup:TradeShowOccurrences_JMICLV:" + (l - 1) + ":Year";
                                //string sTimeFrameYear = driver.FindElement(By.Id(lblTimeFrameYear)).Text;
                                string lblTimeFrameYear = "Tradeshow_JMICSearchPopup:TradeShowOccurrences_JMICLV:" + (l - 1) + ":EndDate";
                                string sYear = driver.FindElement(By.Id(lblTimeFrameYear)).Text;
                                string sTimeFrameYear = sYear.Substring(sYear.Length - 4);
                                Console.WriteLine("Page: {0}\t\tRow: {1}\t\tTimeFrame:{2}\t\t\tYear: {3}", j + 1, k, sTimeFrame, sTimeFrameYear);
                                if (sTimeFrameYear == sTradeshowYear)
                                {
                                    pause();
                                    driver.FindElement(By.Id(lblTimeFrameSelect)).Click();
                                    pause();
                                    bTradeshowFound = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                WaitUntilElementVisible(driver, By.CssSelector(lstHowMerch_Transported));
                UIAction(lstHowMerch_Transported, table.Rows[i]["HowMerch_Transported"], "selectbox");
                WaitUntilElementVisible(driver, By.CssSelector(txtLimit));
                UIAction(txtLimit, table.Rows[i]["Limit"], "textbox");
                WaitUntilElementVisible(driver, By.CssSelector(lstDeductible));
                UIAction(lstDeductible, table.Rows[i]["Deductible"], "selectbox");
                WaitUntilElementVisible(driver, By.CssSelector(txtTransit_Days));
                UIAction(txtTransit_Days, table.Rows[i]["Transit_Days"], "textbox");
                switch (table.Rows[i]["Recurring"].ToLower().Trim())
                {
                    case "true":
                        WaitUntilElementVisible(driver, By.CssSelector(radioRecurringYes));
                        UIAction(radioRecurringYes, string.Empty, "radio");
                        break;
                    default:
                        WaitUntilElementVisible(driver, By.CssSelector(radioRecurringNo));
                        UIAction(radioRecurringNo, string.Empty, "radio");
                        break;
                }
                switch (table.Rows[i]["PolicyChange"].ToLower().Trim())
                {
                    case "yes":
                        WaitUntilElementVisible(driver, By.CssSelector(imgTradeShowSearchIcon));
                        UIAction(imgTmpChangeReason, string.Empty, "a");
                        WaitUntilElementVisible(driver, By.CssSelector(btnReasonSelect));
                        UIAction(btnReasonSelect, string.Empty, "span");
                        break;
                    default:
                        break;
                }

            }

        }


        public void TempChangeTradeshow_JBP(Table table)
        //public void TempChangeTradeshow_JBP(string sChangeReason, string sChangeReasonNext, string sChangeReasonCategory, string sTradeshow_Type, string sLimit, string sDeductible, string sShowName_City_State, string sTradeshow_State, string sHowMerch_Transported, string sTransit_Days, string sRecurring)
        {
            //string btnNext = "a[id$=':StartPolicyChangeScreen:NewPolicyChange']";
            //string ChangePrimaryReason = "select[id$= 'PolicyChangeReason_JMICPanelSet:0:PrimaryChangeReason']";
            //string ChangeReasonNext = "select[id$= 'PolicyChangeReason_JMICPanelSet:0:ChangeReason']";
            //string ChangeReasonCategory = "select[id$= ':PolicyChangeReason_JMICPanelSet:0:ChangeReasonCat']";
            string Tradeshow_Type = "select[id$= ':PolicyChangeReason_JMICPanelSet:0:RangeTypekeyInputChoice1']";
            string Limit = "input[id$= ':PolicyChangeReason_JMICPanelSet:0:InputInteger1']";
            string Deductible = "input[id$= ':PolicyChangeReason_JMICPanelSet:0:InputInteger2']";
            string ShowName_City_State = "input[id$= ':PolicyChangeReason_JMICPanelSet:0:InputMediumText1']";
            //string Tradeshow_State = "a[id$= '']";
            //string HowMerch_Transported = "a[id$= '']";
            //string Transit_Days = "a[id$= '']";
            //string Recurring = "a[id$= '']";
            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(Tradeshow_Type));
            UIAction(Tradeshow_Type, table.Rows[0]["Tradeshow_Type"], "selectbox");
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(Limit));
            UIAction(Limit, table.Rows[0]["Limit"], "textbox");
            WaitUntilElementVisible(driver, By.CssSelector(Deductible));
            UIAction(Deductible, string.Empty, "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(Deductible));
            UIAction(Deductible, table.Rows[0]["Deductible"], "textbox");
            WaitUntilElementVisible(driver, By.CssSelector(ShowName_City_State));
            UIAction(ShowName_City_State, string.Empty, "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(ShowName_City_State));
            UIAction(ShowName_City_State, table.Rows[0]["ShowName_City_State"], "textbox");
            System.Threading.Thread.Sleep(2000);
            ClickNext();
            pause();
        }

        public void PermChangeStockPeak_JBP(Table table)
        {
            string radioIncludeAppYes = "input[id$=':StartPolicyChangeDV:IncludeAppNeeded_true']";
            //string listLocation = "select[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeInputChoice1']";
            string txtLimit = "input[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputInteger1']";
            string txtStartDate = "StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputDate1";
            string txtEndDate = "StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputDate2";
            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
            UIAction(radioIncludeAppYes, string.Empty, "span");
            System.Threading.Thread.Sleep(5000);
            //IWebElement SelectLocation = driver.FindElement(By.CssSelector(listLocation)).FindElement(By.CssSelector("option[order='"+ table.Rows[0]["LocNumber"] + "']")).
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            IWebElement ListLocation = driver.FindElement(By.XPath("//select[@id='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeInputChoice1']"));
            SelectElement selectedLocation = new SelectElement(ListLocation);
            selectedLocation.SelectByIndex(locationNum);
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(txtLimit));
            UIAction(txtLimit, table.Rows[0]["StockPeak_Limit"], "textbox");
            System.Threading.Thread.Sleep(2000);
            JSSetDate(table.Rows[0]["StockPeak_StartDate"], txtStartDate);
            System.Threading.Thread.Sleep(2000);
            JSSetDate(table.Rows[0]["StockPeak_EndDate"], txtEndDate);
            System.Threading.Thread.Sleep(5000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");


            System.Threading.Thread.Sleep(2000);
            string ILMLink = "a[id$='PolicyChangeWizard:LOBWizardStepGroup:ILMWizardStepGroup']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLink));
            UIAction(ILMLink, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            string ILMLocLink = "a[id$='PolicyChangeWizard:Next']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLocLink));
            UIAction(ILMLocLink, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            string ILMLocJStock = "a[id='PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV:" + (locationNum - 1) + ":StockDescription']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLocJStock));
            UIAction(ILMLocJStock, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string coveragesTab = "a[id$=':CoveragesTab']";
            WaitUntilElementVisible(driver, By.CssSelector(coveragesTab));
            UIAction(coveragesTab, string.Empty, "a");

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
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
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
            UIAction(btnOK, string.Empty, "a");
            //}
        }
        public void PermChangeStockAOP_JBP(Table table)
        {
            string radioIncludeAppYes = "input[id$=':StartPolicyChangeDV:IncludeAppNeeded_true']";
            string txtLimit = "input[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputInteger1']";
            string lstChange = "select[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeTypekeyInputChoice1']";

            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
            UIAction(radioIncludeAppYes, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstChange));
            UIAction(lstChange, table.Rows[0]["AOP_Change"], "selectbox");
            System.Threading.Thread.Sleep(5000);
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            IWebElement ListLocation = driver.FindElement(By.XPath("//select[@id='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeInputChoice2']"));
            SelectElement selectedLocation = new SelectElement(ListLocation);
            selectedLocation.SelectByIndex(locationNum);
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(txtLimit));
            UIAction(txtLimit, table.Rows[0]["StockAOP_Limit"], "textbox");
            System.Threading.Thread.Sleep(5000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");

            System.Threading.Thread.Sleep(2000);
            string ILMLink = "a[id$='PolicyChangeWizard:LOBWizardStepGroup:ILMWizardStepGroup']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLink));
            UIAction(ILMLink, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            string ILMLocLink = "a[id$='PolicyChangeWizard:Next']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLocLink));
            UIAction(ILMLocLink, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            string ILMLocJStock = "a[id='PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV:" + (locationNum - 1) + ":StockDescription']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLocJStock));
            UIAction(ILMLocJStock, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string coveragesTab = "a[id$=':CoveragesTab']";
            WaitUntilElementVisible(driver, By.CssSelector(coveragesTab));
            UIAction(coveragesTab, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string stockAOPLimit = "ILMJewelryStock_JMICPopup:ILMJewelryStock_JMICCV:CoveragesPanel:ILMJewelryStock_JMICCoveragesPanelSet:CovCategoryIterator:0:ILMCoverageInputSet:CovPatternInputGroup:0:StockAOPLimit";
            //WaitUntilElementVisible(driver, By.CssSelector(stockAOPLimit));
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
            string btnOK = "a[id$='ILMJewelryStock_JMICPopup:Update']";
            System.Threading.Thread.Sleep(3000);
            UIAction(btnOK, string.Empty, "a");
            System.Threading.Thread.Sleep(3000);
        }

        public void PermChangeAddAI_JBP(Table table)
        {
            string radioIncludeAppYes = "input[id$=':StartPolicyChangeDV:IncludeAppNeeded_true']";
            string lstAIType = "select[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeTypekeyInputChoice1']";
            string lstChange = "select[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeTypekeyInputChoice2']";
            string lstOffering = "select[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeTypekeyInputChoice3']";
            string txtDescription = "textarea[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:TextAreaMediumText1']";

            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
            UIAction(radioIncludeAppYes, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstAIType));
            UIAction(lstAIType, table.Rows[0]["AI_Type"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstChange));
            UIAction(lstChange, table.Rows[0]["AI_Change_Type"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstOffering));
            UIAction(lstOffering, table.Rows[0]["Offering"], "selectbox");
            System.Threading.Thread.Sleep(5000);
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            IWebElement ListLocation = driver.FindElement(By.XPath("//select[@id='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeInputChoice4']"));
            SelectElement selectedLocation = new SelectElement(ListLocation);
            selectedLocation.SelectByIndex(locationNum);
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(txtDescription));
            UIAction(txtDescription, table.Rows[0]["Description"], "textbox");
            System.Threading.Thread.Sleep(5000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string ILMLink = "a[id$='PolicyChangeWizard:LOBWizardStepGroup:ILMWizardStepGroup']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLink));
            UIAction(ILMLink, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            string ILMLocLink = "a[id$='PolicyChangeWizard:Next']";
            WaitUntilElementVisible(driver, By.CssSelector(ILMLocLink));
            UIAction(ILMLocLink, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            string ILMLoc = "span[label='Loc. #'][value='" + locationNum + "']";
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
        }

        public void PermChangeDeleteAI_JBP(Table table)
        {
            string radioIncludeAppYes = "input[id$=':StartPolicyChangeDV:IncludeAppNeeded_true']";
            string lstAIType = "select[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeTypekeyInputChoice1']";
            //string lstChange = "select[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeTypekeyInputChoice2']";
            string lstOffering = "select[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeTypekeyInputChoice2']";
            string txtDescription = "textarea[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:TextAreaMediumText1']";
            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
            UIAction(radioIncludeAppYes, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstAIType));
            UIAction(lstAIType, table.Rows[0]["AI_Type"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstOffering));
            UIAction(lstOffering, table.Rows[0]["Offering"], "selectbox");
            System.Threading.Thread.Sleep(5000);
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            IWebElement ListLocation = driver.FindElement(By.XPath("//select[@id='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:RangeInputChoice3']"));
            SelectElement selectedLocation = new SelectElement(ListLocation);
            selectedLocation.SelectByIndex(locationNum);
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(txtDescription));
            UIAction(txtDescription, table.Rows[0]["Description"], "textbox");
            System.Threading.Thread.Sleep(6000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);

            NavigatetoBOLocs();
            System.Threading.Thread.Sleep(2000);
            string btnBOLocations = "a[id$='PolicyChangeWizard:Next']";
            UIAction(btnBOLocations, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            //int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            System.Threading.Thread.Sleep(5000);
            string BOLoc = "span[label='Loc. #'][value='" + locationNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(BOLoc));
            UIAction(BOLoc, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string BldLoc = "span[label='Bldg. #'][value='1']";
            WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
            UIAction(BldLoc, string.Empty, "span");
            string chkBoBldAddIns = "input[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:AdditionalInterestDetailsDV:AdditionalInterestLV:0:_Checkbox']";
            WaitUntilElementVisible(driver, By.CssSelector(chkBoBldAddIns));
            UIAction(chkBoBldAddIns, string.Empty, "span");
            string btnBOBldRemove = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:Remove']";
            WaitUntilElementVisible(driver, By.CssSelector(btnBOBldRemove));
            UIAction(btnBOBldRemove, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string btnBoBldUpdate = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:Update']";
            WaitUntilElementVisible(driver, By.CssSelector(btnBoBldUpdate));
            UIAction(btnBoBldUpdate, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
        }

        public void NavigatetoBOLocs()
        {
            string lnkBusinessOwners = "a[id$='PolicyChangeWizard:LOBWizardStepGroup:BOPWizardStepGroup']";
            string lnkBoLocations = "a[id$='PolicyChangeWizard:LOBWizardStepGroup:BOPWizardStepGroup:Locations']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkBusinessOwners));
            UIAction(lnkBusinessOwners, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lnkBoLocations));
            UIAction(lnkBoLocations, string.Empty, "a");
        }

        public void PermChangeAddAI_BOP(Table table)
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
            //WaitUntilElementVisible(driver, By.CssSelector(txtAddlIntrestName));
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

            System.Threading.Thread.Sleep(2000);
            string btnBOLocations = "a[id$='PolicyChangeWizard:Next']";
            UIAction(btnBOLocations, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(BOLoc));
            UIAction(BOLoc, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string BldLoc = "span[label='Bldg. #'][value='1']";
            WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
            UIAction(BldLoc, string.Empty, "span");


            string AddBoBldAddlIntrests = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:AddContactsButton_arrow']";
            WaitUntilElementVisible(driver, By.CssSelector(AddBoBldAddlIntrests));
            UIAction(AddBoBldAddlIntrests, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string AddPerson = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:AdditionalInterestDetailsDV:AdditionalInterestLV_tb:AddContactsButton:1:ContactType']";
            WaitUntilElementVisible(driver, By.CssSelector(AddPerson));
            UIAction(AddPerson, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string lstPersonIntrestType = "select[id$='NewAdditionalInterestPopup:ContactDetailScreen:AdditionalInterestInfoDV:Type']";
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstPersonIntrestType));
            UIAction(lstPersonIntrestType, table.Rows[0]["Interest_Type1"], "selectbox");

            string PersonFName = table.Rows[0]["FirstName"];
            string PersonLName = table.Rows[0]["LastName"] + GetUniqueValue();
            RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            RegKey.SetValue("PC_AddInsrd_BOPBld", PersonFName + " " + PersonLName);
            string txtAddlIntrestFName = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:FirstName']";
            WaitUntilElementVisible(driver, By.CssSelector(txtAddlIntrestFName));
            UIAction(txtAddlIntrestFName, PersonFName, "textbox");
            string txtAddlIntrestLName = "input[id$='NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:PolicyContactRoleNameInputSet:LastName']";
            WaitUntilElementVisible(driver, By.CssSelector(txtAddlIntrestLName));
            UIAction(txtAddlIntrestLName, PersonLName, "textbox");

            UIAction(AddressLine1, table.Rows[0]["Address_Line1"], "textbox");
            UIAction(City, table.Rows[0]["City"], "textbox");
            UIAction(State, table.Rows[0]["State"], "selectbox");
            string BldZipCode = "NewAdditionalInterestPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";
            js.ExecuteScript("document.getElementById('" + BldZipCode + "').value='" + table.Rows[0]["ZipCode"] + "'");
            System.Threading.Thread.Sleep(5000);
            btnOK = "a[id$='NewAdditionalInterestPopup:ContactDetailScreen:ForceDupCheckUpdate']";
            UIAction(btnOK, string.Empty, "button");
            System.Threading.Thread.Sleep(2000);
            string btnBoBldUpdate = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:Update']";
            WaitUntilElementVisible(driver, By.CssSelector(btnBoBldUpdate));
            UIAction(btnBoBldUpdate, string.Empty, "a");
            //
        }


        public void PermChangeTradeshow_JBP(Table table)
        {
            string radioIncludeAppYes = "input[id$=':StartPolicyChangeDV:IncludeAppNeeded_true']";
            string txtLimit = "input[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputInteger1']";
            string txtDeductable = "input[id$=':StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputInteger2']";
            string txtShowName = "input[id$='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputShortText1']";

            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
            UIAction(radioIncludeAppYes, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtLimit));
            UIAction(txtLimit, table.Rows[0]["Limit"], "textbox");
            UIAction(txtDeductable, "", "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtDeductable));
            UIAction(txtDeductable, table.Rows[0]["Deductible"], "textbox");
            UIAction(txtShowName, "", "textbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(txtShowName));
            UIAction(txtShowName, table.Rows[0]["ShowName_City_State"], "textbox");
            System.Threading.Thread.Sleep(6000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
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
        public void GWSetCalanderDt(string date)
        {
            DateTime CurrDate = Convert.ToDateTime(date);

            string lnkCalender = "a[id$=':EffectiveDateJMIC_date_calendar']";
            string lstMonth = "select[class='calendarSelect'],[id='calendarMonth']";
            string lnkDay = "a[class='calendarDays'][id^='calendarDay']";
            string sYear = CurrDate.Year.ToString();
            string sMonth = CurrDate.ToString("MMMM");
            string sDay = CurrDate.Day.ToString();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            Console.WriteLine("Year: {0} \nMonth: {1} \nDay: {2}", sYear, sMonth, sDay);
            UIAction(lnkCalender, string.Empty, "a");
            System.Threading.Thread.Sleep(3000);
            js.ExecuteScript("document.getElementById('calendarYear').value='" + sYear + "'");
            pause();
            UIAction(lstMonth, sMonth, "selectbox");
            List<IWebElement> IWDays = driver.FindElements(By.CssSelector(lnkDay)).ToList();
            for (int i = 0; i <= IWDays.Count - 1; i++)
            {
                if (IWDays[i].Text == sDay)
                {
                    IWDays[i].Click();
                    i = IWDays.Count;
                    break;
                }
                //Console.WriteLine("i: {0}\t\t\t text: {1}", IWDays[i].GetAttribute("id"), IWDays[i].Text);
            }

        }

        public void ClickAllNextButtons()
        {
            List<IWebElement> lstBtnNext = driver.FindElements(By.CssSelector(btnNext)).ToList();
            while (lstBtnNext.Any())
            {
                System.Threading.Thread.Sleep(2000);
                UIAction(btnNext, string.Empty, "a");
                System.Threading.Thread.Sleep(2000);
                IsElementPresent(driver, By.CssSelector(lnkLogout));
                // get the Delete links again so we can return to the start of the `while` and see if it's still not empty
                lstBtnNext = driver.FindElements(By.CssSelector(btnNext)).ToList();
            }

            //UIAction(btnNext, string.Empty, "a");
        }
        public void ClickQuote()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            UIAction(btnQuote, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            WaitUntilElementVisible(driver, By.CssSelector(btnIssuePolicy));
        }

        public void IssueCLPolicyChange()
        {
            UIAction(btnIssuePolicy, string.Empty, "a");
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
        }
        public void VerifyCLPolicyChange()
        {
            System.Threading.Thread.Sleep(10000);
            string lnkPolicyBound = "div[class='info'][id='JobComplete:JobCompleteScreen:Message']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkPolicyBound));
            string sPolicyChangeStatus = driver.FindElement(By.CssSelector(lnkPolicyBound)).Text;

            if (sPolicyChangeStatus.EndsWith("has been bound."))
            {
                Console.WriteLine("Policy Change Status: " + sPolicyChangeStatus);
            }
            else
            {
                Assert.Fail("Unable to bound Policy Change");
            }
        }

        public void issuePolicyTransaction(string TransType)
        {
            switch (TransType.ToString().ToLower())
            {
                case "Rewrite Fullterm":
                    //string btnIssuePolicy = "a[id$='RewriteWizard:RewriteWizard_QuoteScreen:JobWizardToolbarButtonSet:BindRewrite']";
                    //string btnIssuePolicy = "a[id$='RewriteWizard:RewriteWizard_MultiLine_QuoteScreen:JobWizardToolbarButtonSet:BindRewrite']";
                    string btnIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindRewrite']";

                    string uwIssuesMessage = "div[id$='UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle']";
                    string uwIssuesPresent = "span[id$='ApproveDV:0:ShortDescriptionAndSize']";
                    string btnDetails = "a[id$=':DetailsButton']";
                    bool isPolicySuccessful = false;
                    UIAction(btnIssuePolicy, string.Empty, "a");
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

                    pause();
                    pause();
                    break;
                default:
                    break;
            }
        }
        public void JSSetDate(string PolicyChangeEffDate, string txtChangeEffDt)
        {
            Console.WriteLine("inside Method" + PolicyChangeEffDate);
            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            if (PolicyChangeEffDate.ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (PolicyChangeEffDate.ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (PolicyChangeEffDate.Contains("+"))
            {
                string[] details = PolicyChangeEffDate.Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            else if (PolicyChangeEffDate.Contains("-"))
            {
                string[] details = PolicyChangeEffDate.Split('-');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));

            }
            else
            {
                tempDate = PolicyChangeEffDate;
            }
            Console.WriteLine("Change Effective Date:" + tempDate);
            pause();
            pause();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + txtChangeEffDt + "').value='" + tempDate + "'");
            //GWSetCalanderDt(tempDate);
            pause();

        }

        public void WithDraworkOder()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnWithdraWorkOrder));
            UIAction(btnWithdraWorkOrder, string.Empty, "a");
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
        }

        public void VerifyCLPolicyCancelSchedule()
        {
            string lnkPolicyBound = "div[class='info'][id='JobComplete:JobCompleteScreen:Message']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkPolicyBound));
            string sPolicyChangeStatus = driver.FindElement(By.CssSelector(lnkPolicyBound)).Text;

            if (sPolicyChangeStatus.Contains("has been scheduled"))
            {
                Console.WriteLine("Policy Cancel Schedule Status: " + sPolicyChangeStatus);
            }
            else
            {
                Assert.Fail("Unable to bound Policy Cancel Schedule");
            }
        }

        public void RescindPolicy()
        {
            string lnkCloseOptionsDownArrow = "a[id$='CancellationWizard:CancellationWizard_MultiLine_QuoteScreen:JobWizardToolbarButtonSet:CloseOptions_arrow']";
            string lnkRescindCancellation = "a[id$='CancellationWizard:CancellationWizard_MultiLine_QuoteScreen:JobWizardToolbarButtonSet:CloseOptions:RescindCancellation']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkCloseOptionsDownArrow));
            UIAction(lnkCloseOptionsDownArrow, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(lnkRescindCancellation));
            UIAction(lnkRescindCancellation, string.Empty, "a");
        }

        public void VerifyCLPolicyRescind()
        {
            string lnkPolicyBound = "div[class='info'][id='JobComplete:JobCompleteScreen:Message']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkPolicyBound));
            string sPolicyChangeStatus = driver.FindElement(By.CssSelector(lnkPolicyBound)).Text;

            if (sPolicyChangeStatus.EndsWith("has been rescinded."))
            {
                Console.WriteLine("Policy Rescind Status: " + sPolicyChangeStatus);
            }
            else
            {
                Assert.Fail("Unable to bound Policy rescind");
            }
        }


        public void ClickRevewiQuote()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnReviewQuote));
            UIAction(btnReviewQuote, string.Empty, "a");
            pause();
            pause();
        }

        public void IssuePLPolicyChange()
        {
            List<IWebElement> PageInputs;
            bool isPolicyChangeSuccessful = false;
            Actions action = new Actions(driver);
            UIAction(btnIssuePolicy, string.Empty, "a");
            driver.SwitchTo().Alert().Accept();
            pause();
            bool uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesMessage));
            Console.WriteLine("value of uwIssues is " + uwIssues);
            if (uwIssues)
            {
                do
                {

                    UIAction(btnDetails, string.Empty, "a");
                    PageInputs = driver.FindElements(By.CssSelector("span[class='bigButton_link']")).ToList();
                    Console.WriteLine("Button Count is " + PageInputs.Count());
                    for (int i = 0; i < PageInputs.Count; i++)
                    {
                        if (PageInputs[i].Text.ToLower().Trim() == "approve")
                            PageInputs[i].Click();

                        break;
                    }

                    PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();

                    for (int i = 0; i < PageInputs.Count; i++)
                    {
                        if (PageInputs[i].Text.ToLower().Trim() == "ok")
                            PageInputs[i].Click();

                        break;
                    }

                    pause();
                    UIAction(btnIssuePolicy, string.Empty, "a");
                    pause();
                    driver.SwitchTo().Alert().Accept();
                    pause();
                    uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesMessage));
                } while ((uwIssues));
            }
            System.Threading.Thread.Sleep(3000);



        }

        public void ClickRenewalNextButton()
        {
            UIAction(btnRenewalNext, string.Empty, "a");
        }

        public void ClickEditWorkOrder()
        {
            pause();
            UIAction(btnEditWorkOrder, string.Empty, "a");
            pause();
            driver.SwitchTo().Alert().Accept();

        }


        public void ActionPolicyAddressCA(string policyActionAddressType, string policyAddressLIne1, string policyCity, string policyState, string policyZipCode)
        {


            UIAction(btnAddressButtonMenuIcon, string.Empty, "a");
            pause();
            IList<IWebElement> EditCurrentAddressBtn = driver.FindElements(By.Id("PolicyChangeWizard:LOBWizardStepGroup:PolicyChangeWizard_PolicyInfoScreen:PolicyChangeWizard_PolicyInfoDV:AccountInfoInputSet:ChangePolicyAddressButton:EditPolicyAddressMenuItem")).ToList();
            JavaScriptClick(EditCurrentAddressBtn[0]);
            //UIAction(btnEditCurrentAddress, string.Empty, "a");
            //pause();
            pause();
            pause();

            UIAction(txtAddressline1, policyAddressLIne1, "textbox");
            UIAction(txtCity, policyCity, "textbox");
            UIAction(selectState, policyState, "selectbox");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + policyZipCode + "'");
            UIAction(btnvalidateAddress, string.Empty, "a");
            pause();
            pause();
            pause();
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(selectVerifiedAddress)).ToList();


            if (PageInputs.Count > 0)
            {
                UIAction(selectVerifiedAddress, "", "a");

                UIAction(acceptAddressChkBox, string.Empty, "a");

                UIAction(acceptAddress, string.Empty, "button");
            }

            UIAction(btnOkAddressDetails, string.Empty, "a");
        }

        public void VerifyCLPolicyCancel()
        {
            string lnkPolicyBound = "div[class='info'][id='JobComplete:JobCompleteScreen:Message']";
            WaitUntilElementVisible(driver, By.CssSelector(lnkPolicyBound));
            string sPolicyChangeStatus = driver.FindElement(By.CssSelector(lnkPolicyBound)).Text;

            if (sPolicyChangeStatus.Contains("has been bound."))
            {
                Console.WriteLine("Policy Cancel Status: " + sPolicyChangeStatus);
            }
            else
            {
                Assert.Fail("Unable to bound Policy Cancel");
            }
        }

        public void removeTradeshow()
        {
            ClickOffPremiseCoveragesTab();
            pause();
            pause();
            string chkTradeshows = "input[id$='RewriteWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLineCoveragesScreen:OffPremiseCoveragesPanel:ILMLineCoveragesPanelSet:SubCoverablesPanelSet:ILMSubCoverablesPanelSet:0:ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:_checkbox']";
            //WaitUntilElementInvisible(driver,By.CssSelector(chkTradeshows));
            driver.FindElement(By.CssSelector(chkTradeshows)).Click();
            //UIAction(chkTradeshows, string.Empty, "a");
            pause();
        }

        public void InactiveAIOnLocation(Table table)
        {
            int locationNum = Convert.ToInt32(table.Rows[0]["LocNumber"]);
            System.Threading.Thread.Sleep(5000);
            string BOLoc = "span[label='Loc. #'][value='" + locationNum + "']";
            WaitUntilElementVisible(driver, By.CssSelector(BOLoc));
            UIAction(BOLoc, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string chkAdditionalIntrest = "input[id$='BOPLocationPopup:LocationScreen:LocationDetailPanelSet:LocationDetailCV:LocationAdditionalInsureds_JMICDV:AdditionalInsuredLV:0:isInactive']";
            WaitUntilElementVisible(driver, By.CssSelector(chkAdditionalIntrest));
            UIAction(chkAdditionalIntrest, string.Empty, "a");
            System.Threading.Thread.Sleep(2000);
            string btnLocOK = "a[id$=':Update']";
            WaitUntilElementVisible(driver, By.CssSelector(btnLocOK));
            UIAction(btnLocOK, string.Empty, "button");
            System.Threading.Thread.Sleep(2000);
        }

        public void ClickNextButton()
        {
            string btnNext = "a[id$=':Next']";
            System.Threading.Thread.Sleep(2000);
            IsElementPresent(driver, By.CssSelector(btnNext));

            pause();
            UIAction(btnNext, string.Empty, "a");
        }

        public void ClickQuoteRewrite()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            UIAction(btnQuote, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnIssuePolicyRewrite));
        }


        public void selectQualitificationsRetrieve(string professionalAthelete, string previousLoss, string convictedOfCrime)
        {
            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(radioCSS)).ToList();
            string btnNextQualificationRewrite = "a[id='RewriteWizard:Next']";

            Console.WriteLine("object count" + PageInputs.Count);

            if (professionalAthelete.ToLower().Trim() == "yes")
            {
                PageInputs[0].Click();
            }
            else
            {
                PageInputs[1].Click();
            }
            if (previousLoss.ToLower().Trim() == "yes")
            {
                PageInputs[2].Click();

            }
            else
            {
                PageInputs[3].Click();
            }
            if (convictedOfCrime.ToLower().Trim() == "yes")
            {
                PageInputs[4].Click();
            }
            else
            {
                PageInputs[5].Click();
            }
            pause();


            //   for (int i= 0;i< PageInputs.Count; i++ )
            //   {
            //       if (PageInputs[i].GetAttribute("id").Contains("false"))
            //           PageInputs[i].Click();
            //  }

            UIAction(btnNextQualificationRewrite, string.Empty, "a");
        }

        public void permChng_AddILMLoc(Table table)
        {
            string radioIncludeAppYes = "input[id$=':StartPolicyChangeDV:IncludeAppNeeded_true']";
            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            System.Threading.Thread.Sleep(2000);
			List<IWebElement> radioIncludeApp = driver.FindElements(By.CssSelector(radioIncludeAppYes)).ToList();
            if (radioIncludeApp.Count == 1)
            {
                WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
                UIAction(radioIncludeAppYes, string.Empty, "span");
                System.Threading.Thread.Sleep(2000);
            }
            //WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
            //UIAction(radioIncludeAppYes, string.Empty, "span");
            //System.Threading.Thread.Sleep(2000);
            string txtLocNum = "input[id$='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputShortText1']";
            UIAction(txtLocNum, table.Rows[0]["LocNumber"], "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");
        }


        public void permChng_DeleteILMLoc(Table table)
        {
            string radioIncludeAppYes = "input[id$=':StartPolicyChangeDV:IncludeAppNeeded_true']";
            string lstLocationLOBNum = "select[id$=':0:RangeInputChoice1']";
            string lstLocationLOB = "select[id$=':0:RangeTypekeyInputChoice2']";
            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            System.Threading.Thread.Sleep(2000);
			List<IWebElement> radioIncludeApp = driver.FindElements(By.CssSelector(radioIncludeAppYes)).ToList();
            if (radioIncludeApp.Count == 1)
            {
                WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
                UIAction(radioIncludeAppYes, string.Empty, "span");
                System.Threading.Thread.Sleep(2000);
            }			
            //WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
            //UIAction(radioIncludeAppYes, string.Empty, "span");
            //System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstLocationLOBNum));
            UIAction(lstLocationLOBNum, table.Rows[0]["LocNumber"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            WaitUntilElementVisible(driver, By.CssSelector(lstLocationLOB));
            UIAction(lstLocationLOB, table.Rows[0]["Offering"], "selectbox");
            //string txtLocNum = "input[id$='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputShortText1']";
            //UIAction(txtLocNum, table.Rows[0]["LocNumber"], "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
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

        public void TempEndorse_OOSPlcyChange(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                System.Threading.Thread.Sleep(2000);
                if (i != 0)
                {
                    string btnAdd = "a[id$= ':Add']";
                    WaitUntilElementVisible(driver, By.CssSelector(btnAdd));
                    UIAction(btnAdd, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                }
                string ChangePrimaryReason = "select[id$= ':" + i + ":PrimaryChangeReason']";
                string ChangeReasonNext = "select[id$= ':" + i + ":ChangeReason']";
                string ChangeReasonCategory = "select[id$= ':" + i + ":ChangeReasonCat']";
                WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
                UIAction(ChangePrimaryReason, table.Rows[i]["ChangeReason"], "selectbox");
                WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
                UIAction(ChangeReasonNext, table.Rows[i]["ChangeReasonNext"], "selectbox");
                WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
                UIAction(ChangeReasonCategory, table.Rows[i]["ChangeReasonCategory"], "selectbox");
                System.Threading.Thread.Sleep(2000);

                if (table.Rows[i]["Integer1"].ToString() != "")
                {
                    string txtInteger1 = "input[id$= ':" + i + ":InputInteger1']";
                    WaitUntilElementVisible(driver, By.CssSelector(txtInteger1));
                    UIAction(txtInteger1, table.Rows[i]["Integer1"], "textbox");
                    driver.FindElement(By.XPath("//html")).Click();
                    System.Threading.Thread.Sleep(2000);
                }
                if (table.Rows[i]["Integer2"].ToString() != "")
                {
                    string txtInteger2 = "input[id$= ':" + i + ":InputInteger2']";
                    WaitUntilElementVisible(driver, By.CssSelector(txtInteger2));
                    UIAction(txtInteger2, table.Rows[i]["Integer2"], "textbox");
                    driver.FindElement(By.XPath("//html")).Click();
                    System.Threading.Thread.Sleep(2000);
                }
                if (table.Rows[i]["Integer3"].ToString() != "")
                {
                    string txtInteger3 = "input[id$= ':" + i + ":InputInteger3']";
                    WaitUntilElementVisible(driver, By.CssSelector(txtInteger3));
                    UIAction(txtInteger3, table.Rows[i]["Integer3"], "textbox");
                    driver.FindElement(By.XPath("//html")).Click();
                    System.Threading.Thread.Sleep(2000);
                }
                if (table.Rows[i]["ShortText1"].ToString() != "")
                {
                    string txtShortText1 = "input[id$= ':" + i + ":InputShortText1']";
                    WaitUntilElementVisible(driver, By.CssSelector(txtShortText1));
                    UIAction(txtShortText1, table.Rows[i]["ShortText1"], "textbox");
                    driver.FindElement(By.XPath("//html")).Click();
                    System.Threading.Thread.Sleep(2000);
                }
                if (table.Rows[i]["ShortText2"].ToString() != "")
                {
                    string txtShortText2 = "input[id$= ':" + i + ":InputShortText2']";
                    WaitUntilElementVisible(driver, By.CssSelector(txtShortText2));
                    UIAction(txtShortText2, table.Rows[i]["ShortText2"], "textbox");
                    driver.FindElement(By.XPath("//html")).Click();
                    System.Threading.Thread.Sleep(2000);
                }
                if (table.Rows[i]["MediumText1"].ToString() != "")
                {
                    if (i == 3)
                    {

                        string txtMeduimText1 = "textarea[id$= ':" + i + ":TextAreaMediumText1']";
                        WaitUntilElementVisible(driver, By.CssSelector(txtMeduimText1));
                        UIAction(txtMeduimText1, table.Rows[i]["MediumText1"], "textbox");
                        driver.FindElement(By.XPath("//html")).Click();
                        System.Threading.Thread.Sleep(2000);

                    }
                    else
                    {
                        string txtMeduimText1 = "input[id$= ':" + i + ":InputMediumText1']";
                        WaitUntilElementVisible(driver, By.CssSelector(txtMeduimText1));
                        UIAction(txtMeduimText1, table.Rows[i]["MediumText1"], "textbox");
                        driver.FindElement(By.XPath("//html")).Click();
                        System.Threading.Thread.Sleep(2000);
                    }
                }

            }
            System.Threading.Thread.Sleep(2000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");
        }

        public void SetCalanderDate(string DateToEnter, string lnkCalender)
        {
            Console.WriteLine("inside Method" + DateToEnter);
            var tempDate = "";
            DateTime CurrentDate = DateTime.Now;
            if (DateToEnter.ToLower().ToString() == "systemdate")
            {
                DateTime tempRetroDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
                tempDate = tempRetroDate.ToShortDateString();
            }
            else if (DateToEnter.ToLower() == "currentdate")
            {
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate);
            }
            else if (DateToEnter.Contains("+"))
            {
                string[] details = DateToEnter.Split('+');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse(details[1])));

            }
            else if (DateToEnter.Contains("-"))
            {
                string[] details = DateToEnter.Split('-');
                tempDate = string.Format("{0:MM/dd/yyyy}", CurrentDate.AddDays(Int32.Parse("-" + details[1])));

            }
            else
            {
                tempDate = DateToEnter;
            }
            Console.WriteLine("DateToEnter: " + tempDate);
            pause();
            pause();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("document.getElementById('" + txtChangeEffDt + "').value='" + tempDate + "'");
            GWSetCalanderDt(tempDate, lnkCalender);
            pause();

        }

        public void GWSetCalanderDt(string date, string lnkCalender)
        {
            DateTime CurrDate = Convert.ToDateTime(date);

            //string lnkCalender = "a[id$=':EffectiveDateJMIC_date_calendar']";
            string lstMonth = "select[class='calendarSelect'],[id='calendarMonth']";
            string lnkDay = "a[class='calendarDays'][id^='calendarDay']";
            string sYear = CurrDate.Year.ToString();
            string sMonth = CurrDate.ToString("MMMM");
            string sDay = CurrDate.Day.ToString();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            Console.WriteLine("Year: {0} \nMonth: {1} \nDay: {2}", sYear, sMonth, sDay);
            UIAction(lnkCalender, string.Empty, "a");
            System.Threading.Thread.Sleep(3000);
            js.ExecuteScript("document.getElementById('calendarYear').value='" + sYear + "'");
            pause();
            UIAction(lstMonth, sMonth, "selectbox");
            List<IWebElement> IWDays = driver.FindElements(By.CssSelector(lnkDay)).ToList();
            for (int i = 0; i <= IWDays.Count - 1; i++)
            {
                if (IWDays[i].Text == sDay)
                {
                    IWDays[i].Click();
                    i = IWDays.Count;
                    break;
                }
                //Console.WriteLine("i: {0}\t\t\t text: {1}", IWDays[i].GetAttribute("id"), IWDays[i].Text);
            }

        }

        public void ClickTempCoveragesTab()
        {
            string tabTempCovrgs = "a[id$=':ILMWizardStepGroup:ILMLineCoveragesScreen:OneTimeCoveragesTab']";
            pause();
            WaitUntilElementVisible(driver, By.CssSelector(tabTempCovrgs));
            UIAction(tabTempCovrgs, string.Empty, "a");
        }

        public void AddILMTempCoverages(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                string lnkSubTab;
                string lstCategory;
                string txtFromTravel;
                string txtToTravel;
                string txtLimit;
                string lstDed;
                string txtWP;
                string lnkSearchReason;
                string btnSelectReason;
                string lstCarrierName;
                string txtDed;
                string CovgLimit;
                string txtCoverageDesc;

                string btnAddCoverage = "a[id$=':OneTimeCoveragesPanel:ILMLineCoveragesPanelSet:ToolbarButton']";
                WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverage));
                UIAction(btnAddCoverage, string.Empty, "a");
                System.Threading.Thread.Sleep(1000);
                switch (table.Rows[i]["TempCoverage"].ToLower())
                {
                    case "off premise travel":
                        lnkSubTab = "a[id$='ToolbarButton:1:subItemCoverable']";
                        WaitUntilElementVisible(driver, By.CssSelector(lnkSubTab));
                        UIAction(lnkSubTab, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        lstCategory = "select[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:TypekeyTermInput']";
                        txtFromTravel = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:FromDate:DateTimeTermInput_calendar']";
                        txtToTravel = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ToDate:DateTimeTermInput_calendar']";
                        txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput']";
                        lstDed = "select[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:ILMCovTermInputSet:OptionTermInput']";
                        txtWP = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:5:ILMCovTermInputSet:DirectTermInput']";
                        lnkSearchReason = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
                        btnSelectReason = "a[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:1:_Select']";
                        UIAction(lstCategory, "Inside Territory", "selectbox");
                        driver.FindElement(By.XPath("//html")).Click();
                        System.Threading.Thread.Sleep(2000);
                        SetCalanderDate("SYSTEMDATE", txtFromTravel);
                        SetCalanderDate("SYSTEMDATE+30", txtToTravel);
                        UIAction(txtLimit, "200000", "textbox");
                        UIAction(lstDed, "2,500", "selectbox");
                        UIAction(txtWP, "500", "textbox");
                        UIAction(lnkSearchReason, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        UIAction(btnSelectReason, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "shipments inside territory":
                        lnkSubTab = "a[id$='ToolbarButton:3:subItemCoverable']";
                        WaitUntilElementVisible(driver, By.CssSelector(lnkSubTab));
                        UIAction(lnkSubTab, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        lstCarrierName = "select[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:TempEndShipInTerrSubCat_JMIC:TypekeyTermInput']";
                        txtFromTravel = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:FromDate:DateTimeTermInput_calendar']";
                        txtToTravel = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ToDate:DateTimeTermInput_calendar']";
                        txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput']";
                        txtDed = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:ILMCovTermInputSet:DirectTermInput']";
                        CovgLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:6:ILMCovTermInputSet:DirectTermInput']";
                        lnkSearchReason = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
                        btnSelectReason = "a[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:2:_Select']";
                        UIAction(lstCarrierName, "Fed Ex", "selectbox");
                        driver.FindElement(By.XPath("//html")).Click();
                        System.Threading.Thread.Sleep(2000);
                        SetCalanderDate("SYSTEMDATE", txtFromTravel);
                        SetCalanderDate("SYSTEMDATE+30", txtToTravel);
                        UIAction(txtLimit, "200000", "textbox");
                        UIAction(txtDed, "2500", "textbox");
                        UIAction(CovgLimit, "200000", "textbox");
                        UIAction(lnkSearchReason, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        UIAction(btnSelectReason, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "shipments outside territory":
                        lnkSubTab = "a[id$='ToolbarButton:4:subItemCoverable']";
                        WaitUntilElementVisible(driver, By.CssSelector(lnkSubTab));
                        UIAction(lnkSubTab, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        lstCarrierName = "select[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:TypekeyTermInput']";
                        txtFromTravel = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:FromDate:DateTimeTermInput_calendar']";
                        txtToTravel = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ToDate:DateTimeTermInput_calendar']";
                        txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput']";
                        txtDed = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:4:ILMCovTermInputSet:DirectTermInput']";
                        CovgLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:6:ILMCovTermInputSet:DirectTermInput']";
                        lnkSearchReason = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
                        btnSelectReason = "a[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:3:_Select']";
                        UIAction(lstCarrierName, "Fed Ex", "selectbox");
                        driver.FindElement(By.XPath("//html")).Click();
                        System.Threading.Thread.Sleep(2000);
                        SetCalanderDate("SYSTEMDATE", txtFromTravel);
                        SetCalanderDate("SYSTEMDATE+30", txtToTravel);
                        UIAction(txtLimit, "200000", "textbox");
                        UIAction(txtDed, "2500", "textbox");
                        UIAction(CovgLimit, "200000", "textbox");
                        UIAction(lnkSearchReason, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        UIAction(btnSelectReason, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "all other":
                        lnkSubTab = "a[id$='ToolbarButton:5:subItemCoverable']";
                        WaitUntilElementVisible(driver, By.CssSelector(lnkSubTab));
                        UIAction(lnkSubTab, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        txtCoverageDesc = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:0:ILMCovTermInputSet:StringTermInput']";
                        txtFromTravel = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:1:FromDate:DateTimeTermInput_calendar']";
                        txtToTravel = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:2:ToDate:DateTimeTermInput_calendar']";
                        txtLimit = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:3:ILMCovTermInputSet:DirectTermInput']";
                        txtWP = "input[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:5:ILMCovTermInputSet:DirectTermInput']";
                        lnkSearchReason = "a[id$=':" + i + ":ILMAdditionalSubItemCoveragesDV:0:ILMCoverageWithToFromDateInputSet:CovPatternInputGroup:TempChangeReasonInputSet:CommonTempChangeReasonTerm_JMICInputSet:PolicyChangeReason:SelectPolicyChangeReason']";
                        btnSelectReason = "a[id$='PolicyChangeReason_JMICPopup:PolicyChangeReasonsLV:0:_Select']";
                        UIAction(txtCoverageDesc, "Test Automation", "textbox");
                        SetCalanderDate("SYSTEMDATE", txtFromTravel);
                        SetCalanderDate("SYSTEMDATE+30", txtToTravel);
                        UIAction(txtLimit, "200000", "textbox");
                        UIAction(txtWP, "200", "textbox");
                        UIAction(lnkSearchReason, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        UIAction(btnSelectReason, string.Empty, "a");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    default:
                        break;
                }
            }
        }

		
		
		 public void PLIssuePolicyRewrite()
        {
            List<IWebElement> PageInputs;
            bool isPolicySuccessful = false;

            Actions action = new Actions(driver);

            pause();
            pause();
            pause();
            UIAction(rewriteIssue, string.Empty, "a");

            pause();

            driver.SwitchTo().Alert().Accept();

            pause();


            bool uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesMessage));

            do
            {

                UIAction(btnDetails, string.Empty, "a");

                PageInputs = driver.FindElements(By.CssSelector("span[class='bigButton_link']")).ToList();
                Console.WriteLine("Button Count is " + PageInputs.Count());
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "approve")
                        PageInputs[i].Click();

                    break;
                }

                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();

                    break;
                }

                pause();
                Console.WriteLine("second rewrite issue buton");
                UIAction(btnIssuePolicyRewrite, string.Empty, "a");

                pause();

                driver.SwitchTo().Alert().Accept();
                pause();
                uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesMessage));
            } while ((uwIssues));
        }




        public void BOBuildingAddCovg(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                int locationNum = Convert.ToInt32(table.Rows[i]["LocNumber"]);

                Console.WriteLine("Location Num: " + locationNum);
                if (locationNum - 1 > 0)
                {
                    Console.WriteLine("Location Num: " + (locationNum - 1));
                    string lnkLocationBld = "a[id$=':BOPLocationsLV:" + (locationNum - 1) + ":_ViewDetail']";
                    WaitUntilElementVisible(driver, By.CssSelector(lnkLocationBld));
                    UIAction(lnkLocationBld, string.Empty, "span");
                }
                string BldLoc = "span[label='Bldg. #'][value='1']";
                WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
                UIAction(BldLoc, string.Empty, "span");

                string lnkAddCovgTab = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_AdditionalCoveragesCardTab']";
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(lnkAddCovgTab));
                UIAction(lnkAddCovgTab, string.Empty, "a");

                string btnAddCoverages = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:AdditionalCoveragesPanelSet:AdditionalCoveragesDV_tb:Add']";
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(btnAddCoverages));
                UIAction(btnAddCoverages, string.Empty, "a");
                System.Threading.Thread.Sleep(2000);
                string txtKeyWord = "input[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchDV:Keyword']";
                WaitUntilElementVisible(driver, By.CssSelector(txtKeyWord));
                UIAction(txtKeyWord, table.Rows[i]["BldgAddlCoverages"], "textbox");
                string btnSeach = "span[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search_link']";
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(btnSeach));
                UIAction(btnSeach, string.Empty, "button");
                System.Threading.Thread.Sleep(2000);
                string chkCoverage = "input[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchResultsLV:0:_Checkbox']";
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(chkCoverage));
                driver.FindElement(By.CssSelector(chkCoverage)).Click();
                string btnAddSelectedCovg = "a[id$='CoveragePatternSearchPopup:CoveragePatternSearchScreen:CoveragePatternSearchResultsLV_tb:AddCoverageButton']";
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(btnAddSelectedCovg));
                UIAction(btnAddSelectedCovg, string.Empty, "a");

                string lnkDetailsTab = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_DetailsCardTab']";
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(lnkDetailsTab));
                UIAction(lnkDetailsTab, string.Empty, "a");

                string lstBldgClass = "select[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_DetailsDV:BOPBuildingClass']";
                string lstEQTerritory = "select[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:BOPBuilding_DetailsDV:BOPEQTerritory']";
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(lstBldgClass));
                UIAction(lstBldgClass, table.Rows[i]["BuildingClass"], "selectbox");
                System.Threading.Thread.Sleep(2000);
                WaitUntilElementVisible(driver, By.CssSelector(lstEQTerritory));
                //UIAction(lstEQTerritory, table.Rows[i]["EQTerritory"], "selectbox");
                var selectEQTerritory = new SelectElement(driver.FindElement(By.CssSelector(lstEQTerritory)));
                selectEQTerritory.SelectByValue(table.Rows[i]["EQTerritory"]);

                System.Threading.Thread.Sleep(2000);
                string btnBoBldUpdate = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:Update']";
                WaitUntilElementVisible(driver, By.CssSelector(btnBoBldUpdate));
                UIAction(btnBoBldUpdate, string.Empty, "a");
            }
        }

        public void permChng_AddBuilding(Table table)
        {
            string radioIncludeAppYes = "input[id$=':StartPolicyChangeDV:IncludeAppNeeded_true']";
            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            System.Threading.Thread.Sleep(2000);
            List<IWebElement> radioIncludeApp = driver.FindElements(By.CssSelector(radioIncludeAppYes)).ToList();
            if (radioIncludeApp.Count == 1)
            {
                WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
                UIAction(radioIncludeAppYes, string.Empty, "span");
                System.Threading.Thread.Sleep(2000);
            }


            string lstChange = "select[id$=':0:RangeTypekeyInputChoice1']";
            string lstLocation = "select[id$=':0:RangeInputChoice2']";
            string txtBuilding = "input[id$=':0:InputInteger1']";
            string txtCoverage = "input[id$=':0:InputShortText1']";


            WaitUntilElementVisible(driver, By.CssSelector(lstChange));
            UIAction(lstChange, table.Rows[0]["Change"], "selectbox");
            System.Threading.Thread.Sleep(2000);

            WaitUntilElementVisible(driver, By.CssSelector(lstLocation));
            UIAction(lstLocation, table.Rows[0]["Location"], "selectbox");
            System.Threading.Thread.Sleep(2000);

            WaitUntilElementVisible(driver, By.CssSelector(txtBuilding));
            UIAction(txtBuilding, table.Rows[0]["Building"], "textbox");
            System.Threading.Thread.Sleep(2000);

            WaitUntilElementVisible(driver, By.CssSelector(txtCoverage));
            UIAction(txtCoverage, "", "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(txtCoverage, table.Rows[0]["Coverage"], "textbox");
            System.Threading.Thread.Sleep(2000);

            //string txtLocNum = "input[id$='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputShortText1']";
            //UIAction(txtLocNum, table.Rows[0]["LocNumber"], "textbox");
            //System.Threading.Thread.Sleep(2000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");
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


        public void permChng_AddILMLocJS(Table table)
        {

            WaitUntilElementVisible(driver, By.CssSelector(ChangePrimaryReason));
            UIAction(ChangePrimaryReason, table.Rows[0]["ChangeReason"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonNext));
            UIAction(ChangeReasonNext, table.Rows[0]["ChangeReasonNext"], "selectbox");
            WaitUntilElementVisible(driver, By.CssSelector(ChangeReasonCategory));
            UIAction(ChangeReasonCategory, table.Rows[0]["ChangeReasonCategory"], "selectbox");
            //System.Threading.Thread.Sleep(2000);
            //WaitUntilElementVisible(driver, By.CssSelector(radioIncludeAppYes));
            //UIAction(radioIncludeAppYes, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            string txtLocNum = "input[id$='StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputShortText1']";

            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("document.getElementById('StartPolicyChange:StartPolicyChangeScreen:PolicyChangeReason_JMICPanelSet:0:InputShortText1').value='" + table.Rows[0]["LocNumber"]+"'");


            UIAction(txtLocNum, table.Rows[0]["LocNumber"], "textbox");
            System.Threading.Thread.Sleep(2000);
            UIAction(btnPolicyChangeNext, string.Empty, "span");
        }


        public void SelectLines_BOPSelect(string lines)
        {
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

    }
	
	
}
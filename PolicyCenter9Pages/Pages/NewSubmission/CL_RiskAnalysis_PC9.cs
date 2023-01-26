
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class CL_RiskAnalysis_PC9 : Page
    {
        string lblRiskAnalysis = "span[id$=':Job_RiskAnalysisScreen:0']";
        string btnQuote = "span[id$=':QuoteOrReview-btnInnerEl']";
        //string btnQuote_Write = "span[id$=':QuoteOrReview-btnInnerEl']";
        string btnNext = "span[id$=':Next-btnInnerEl']";
        string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";
        string ClickIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions']";
        string lnkOfferings = "td[id$=':Offering']";
        string lblOfferings = "span[id$=':OfferingScreen:ttlBar']";
        string lblLineSel = "span[id$=':CPPLineSelectionScreen:ttlBar']";
        string lblQualification = "span[id$=':SubmissionWizard_PreQualificationScreen:ttlBar']";
        string lblPolicyInfo = "span[id$=':SubmissionWizard_PolicyInfoScreen:ttlBar']";
        string lblILMLine = "span[id$=':ILMLineCoveragesScreen:ttlBar']";
        string lblILMLoc = "span[id$=':ILMLocation_JMICScreen:ttlBar']";
        string lblILMModifiers = "span[id$=':ILMLocationModifiers_JMICScreen:ttlBar']";
        string lblILMLineReview = "span[id$=':ILMWizardStepGroup:CPPLineReviewScreen:ttlBar']";
        string lblBOLine = "span[id$=':BOPWizardStepGroup:BOPScreen:ttlBar']";
        string lblBOLocation = "span[id$=':BOPLocationsScreen:ttlBar']";
        string lblBOBuilding = "span[id$=':BOPBuildingsScreen:ttlBar']";
        string lblBOBlanket = "span[id$=':BOPBlanket_JMICScreen:ttlBar']";
        string lblBOModifier = "span[id$=':BOPModifiers_JMICScreen:ttlBar']";
        string lblBOLineReview = "span[id$=':BOPWizardStepGroup:CPPLineReviewScreen:ttlBar']";
        string lblUmbrellaLine = "span[id$=':UMBLineCoveragesScreen:ttlBar']";
        string lblUMBModifiers = "span[id$=':UMBModifiersScreen:ttlBar']";
        string lblUMBUnderWriting = "span[id$=':UMBUnderwritingScreen:ttlBar']";
        string lblUMBLineReview = "span[id$=':CPPLineReviewScreen:ttlBar']";
        string bttRenewQuote = "span[id$=':RenewalQuote-btnInnerEl']";
        string lnkLRBuilding = "a[id$=':ReviewSummaryCV:PolicyLineSummaryPanelSet:0:BuildingsDV:0:BuildingDetails']";


        string policyNumber = "";
        string txtBillingMethod = "input[id$=':BillingAdjustmentsDV:BillingMethod-inputEl']";
        string ClickIssuePolicyChamgeJPA = "a[id$=':JobWizardToolbarButtonSet:BindPolicyChange']";
        string ClickIssuePolicyRewriteJPA = "a[id$=':JobWizardToolbarButtonSet:BindRewrite']";
        string BindIssuePolicy = "a[id$=':JobWizardToolbarButtonSet:BindOptions:BindAndIssue-itemEl']";
        string btnOK = "a[id='button-1005']";
        string lnkPlcy = "div[id$='JobComplete:JobCompleteScreen:JobCompleteDV:ViewPolicy-inputEl']";
        string tblInstallmentPlan = "div[id$=':InstallmentPlan:BillingAdjustmentsInstallmentsLV-body']";
        // string btnDetails = "a[id='UWBlockProgressIssuesPopup:IssuesScreen:DetailsButton']";
        string lblPaymentscreen = "span[id$='_PaymentScreen:ttlBar']";
        string btnDetails = "a[id$=':DetailsButton']";
        string btnRiskApprovalDetailsok = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
        string viewYourPlcy = "view your policy (#";
        string policyInfo = "//span[text()='Policy Info']";
        string insuranceScore = "div[id$='PolicyFile_PolicyInfo:PolicyFile_PolicyInfoScreen:PolicyFile_PolicyInfoDV:InsuranceScore-inputEl'";
        string btnSplApprove = "a[id$=':UWIssueRowSet:SpecialApprove']";
        string lblRiskApproveDetails = "span[id$='RiskApprovalDetailsPopup:ttlBar']";
        string btnRAOK = "span[id$='RiskApprovalDetailsPopup:Update-btnInnerEl']";
        string LeftLnkRiskAnalysis = "td[id$='SubmissionWizard:RiskAnalysis']";
        string tabFraudwarning = "span[id$=':RiskAnalysisCV:FraudWarningidTab-btnInnerEl']";
        string radioJMApplication = "input[id$=':RiskAnalysisCV:ApplicationStatementId_true-inputEl']";
        string tabUWIssues = "span[id$=':RiskAnalysisCV:EvaluationIssuesCardTab-btnInnerEl']";

        public void RiskAnalysisQuote_ST()
        {
            if(!IsElementPresent(driver, By.CssSelector(lnkLRBuilding)))
            {
                AddLossHistoryType();
            }         
            JavaScriptClick(driver.FindElement(By.CssSelector(btnQuote)));
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(ClickIssuePolicy), 30);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //Thread.Sleep(15000);
            if (!IsElementPresent(driver, By.CssSelector(ClickIssuePolicy)))
            {
                verifyQuoteErrors();
            }          
            //WaitUntilElementVisible(driver, , 30);                      
        }
        public void RiskAnalysisQuote_Rewrite()
        {
            driver.FindElement(By.CssSelector(btnQuote)).Click();
            verifyQuoteErrors();
        }
        public void RiskAnalysis_QuoteClear()
        {
            if (IsElementPresent(driver, By.CssSelector(btnQuote)) == false)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            }
            AddLossHistoryType();
            driver.FindElement(By.CssSelector(btnQuote)).Click();
            verifyQuoteErrors();
            WaitUntilElementVisible(driver, By.CssSelector(btnClear));
            driver.FindElement(By.CssSelector(btnClear)).Click();
            WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
        }
        public void RiskAnalysis_QuoteClear_JBP07()
        {
            if (IsElementPresent(driver, By.CssSelector(btnQuote)) == false)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            }
            AddLossHistoryType();
            driver.FindElement(By.CssSelector(btnQuote)).Click();
            // verifyQuoteErrors();
            Thread.Sleep(30000);
            if (driver.FindElements(By.CssSelector(btnClear)).Count() > 0)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnClear));
                driver.FindElement(By.CssSelector(btnClear)).Click();
                WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
                RiskAnalysis_NavigateAllPages();
                RiskAnalysisQuote_ST();
            }
        }
        public void AddLossHistoryType()
        {
            //click Loss history
            Console.WriteLine("Click Prior Loss");
            driver.FindElement(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:JPARiskAnalysisPanelSet:RiskAnalysisCV:LossHistoryCardTab-btnInnerEl")).Click();
            System.Threading.Thread.Sleep(3000);
            string historyType = "input[id$=':LossHistoryType-inputEl']";
            try
            {
                WaitUntilElementVisible(driver, By.CssSelector(historyType), 15);
            }
            catch (Exception e)
            {
                Console.WriteLine("Known Exception: " + e);
            }
            if(IsElementPresent(driver, By.CssSelector(historyType + "[value='Please Select']")))
            {
                UIActionExt(By.CssSelector(historyType), "Text", " ");
                UIActionExt(By.CssSelector(historyType), "List", "No Loss History");
            }
        }
        public void RiskAnalysis_NavigateAllPages()
        {
            driver.FindElement(By.CssSelector(lnkOfferings)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));              
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblLineSel));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblQualification));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblPolicyInfo));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLoc));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMModifiers));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLocation));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBuilding));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBlanket));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOModifier));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
        }

        public void RiskAnalysis_NavigateAllPages_BOP()
        {
            driver.FindElement(By.CssSelector(lnkOfferings)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblLineSel));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblQualification));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblPolicyInfo));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLocation));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBuilding));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBlanket));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOModifier));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
        }
        public void RiskAnalysis_NavigateAllPages_UMB()
        {
            WaitUntilElementInvisible(driver, By.CssSelector(lblLineSel));
            driver.FindElement(By.CssSelector(lnkOfferings)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblLineSel));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblQualification));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblPolicyInfo));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLoc));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMModifiers));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLocation));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBuilding));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBlanket));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOModifier));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();

            WaitUntilElementVisible(driver, By.CssSelector(lblUmbrellaLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblUMBUnderWriting));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblUMBLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));

        }
        public void RiskAnalysis_NavAllPages_UMB_WithModifier()
        {
            driver.FindElement(By.CssSelector(lnkOfferings)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblLineSel));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblQualification));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblPolicyInfo));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLoc));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMModifiers));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLocation));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBuilding));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBlanket));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOModifier));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();

            WaitUntilElementVisible(driver, By.CssSelector(lblUmbrellaLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblUMBModifiers));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblUMBUnderWriting));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblUMBLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));

        }
        public void RiskAnalysisCLQuote()
        {
            if (IsElementPresent(driver, By.CssSelector(btnQuote)) == false)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnQuote));
            }
            AddLossHistoryType();
            driver.FindElement(By.CssSelector(btnQuote)).Click();
            verifyQuoteErrors();
            WaitUntilElementVisible(driver, By.CssSelector(ClickIssuePolicy), 620);
        }
        public void RiskAnalysis_QuoteClearRenew()
        {
            if (IsElementPresent(driver, By.CssSelector(bttRenewQuote)) == false)
            {
                WaitUntilElementVisible(driver, By.CssSelector(bttRenewQuote));
            }
            driver.FindElement(By.CssSelector(bttRenewQuote)).Click();
            verifyQuoteErrors();
            WaitUntilElementVisible(driver, By.CssSelector(btnClear));
            driver.FindElement(By.CssSelector(btnClear)).Click();
            WaitUntilElementInvisible(driver, By.CssSelector(lblOfferings));
        }
        public void RiskAnalysis_NavigateAllPages_Renew()
        {
            string lblPolicyInfo = "span[id$='_PolicyInfoScreen:ttlBar']";

            driver.FindElement(By.CssSelector(lnkOfferings)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblOfferings));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblLineSel));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            //WaitUntilElementVisible(driver, By.CssSelector(lblQualification));
            //driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblPolicyInfo));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLoc));

            IWebElement tblILLocsMainDiv = WaitFor(driver.FindElement(By.CssSelector("div[id$=':ILMStockAndLocationsLV-body']")));
            IList<IWebElement> tblILMLocs = tblILLocsMainDiv.FindElements(By.TagName("table")).ToList();
            int ILMLocs = tblILMLocs.Count;
            Console.WriteLine("ILMLocs: " + ILMLocs);
            for (int i = 0; i <= ILMLocs - 1; i++)
            {
                string linkILMLocation = "a[id$=':ILMStockAndLocationsLV:" + (i) + ":LocationNumber']";
                string lblILMLocTitle = "span[id='ILMLocation_JMICPopup:ttlBar']";
                string btnOk = "span[id$=':Update-btnInnerEl']";
                driver.FindElement(By.CssSelector(linkILMLocation)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(lblILMLocTitle));
                driver.FindElement(By.CssSelector(btnOk)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(lblILMLoc));
            }
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMModifiers));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblILMLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLine));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLocation));

            IWebElement tblBOLocsMainDiv = WaitFor(driver.FindElement(By.CssSelector("div[id$=':LocationsEdit_LV-body']")));
            IList<IWebElement> tblBOLocs = tblBOLocsMainDiv.FindElements(By.TagName("table")).ToList();
            int BOLocs = tblBOLocs.Count;
            Console.WriteLine("BOLocs: " + BOLocs);
            for (int i = 0; i <= BOLocs - 1; i++)
            {
                string linkBOLocation = "a[id$=':LocationsEdit_LV:" + (i) + ":Loc']";
                string lblBOLoc = "span[id='BOPLocationPopup:LocationScreen:ttlBar']";
                string btnOk = "span[id$=':Update-btnInnerEl']";
                driver.FindElement(By.CssSelector(linkBOLocation)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(lblBOLoc));
                driver.FindElement(By.CssSelector(btnOk)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(lblBOLocation));
            }
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBuilding));

            for (int i = 0; i <= BOLocs - 1; i++)
            {
                if (i != 0)
                {
                    IWebElement tblbodyBOLocs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':BOPLocationBuildingsPanelSet:BOPLocationsLV-body']")));
                    IList<IWebElement> tblBOBldLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
                    IList<IWebElement> tblBOBldLocstdAddr = tblBOBldLocs[i].FindElements(By.TagName("td")).ToList();
                    IList<IWebElement> tblBOBldLocsDivAddr = tblBOBldLocstdAddr[3].FindElements(By.TagName("div")).ToList();
                    string locAddr = tblBOBldLocsDivAddr[0].Text;
                    int j = i + 1;
                    char[] dSpace = { ' ' }, dComma = { ',' };
                    string[] SplitBySpace = locAddr.Split(dSpace);
                    string CompZipCode = SplitBySpace[SplitBySpace.Length - 1];
                    string LocAddrNoAddr1 = "";
                    string LocAddr = locAddr.Replace(CompZipCode, "").TrimEnd();
                    string[] SplitByComma = LocAddr.Split(dComma);
                    Console.WriteLine(LocAddr);
                    Console.WriteLine(SplitByComma.Length);
                    if (SplitByComma.Length > 3)
                    {
                        for (int k = 0; k < SplitByComma.Length; k++)
                        {
                            if (k != 1)
                                if (k == 0)
                                    LocAddrNoAddr1 = SplitByComma[k];
                                else
                                    LocAddrNoAddr1 = LocAddrNoAddr1 + "," + SplitByComma[k];
                        }
                    }
                    else
                    {
                        LocAddrNoAddr1 = LocAddr;
                    }
                    LocAddrNoAddr1 = (i + 1) + ": " + LocAddrNoAddr1;
                    Console.WriteLine(tblBOBldLocsDivAddr[0].Text);
                    Console.WriteLine("LocAddrNoAddr1: " + LocAddrNoAddr1);
                    LocAddrNoAddr1 = LocAddrNoAddr1.Substring(0, LocAddrNoAddr1.Length - 4);
                    Console.WriteLine("LocAddrNoAddr1TRIM: " + LocAddrNoAddr1);
                    tblBOBldLocsDivAddr[0].Click();
                    if (IsElementPresent(driver, By.CssSelector("div[id$=':BOPLocationBuildingsPanelSet:BOPLocationsLV-body']")) == false)
                    {
                        WaitUntilElementVisible(driver, By.CssSelector("div[id$=':BOPLocationBuildingsPanelSet:BOPLocationsLV-body']"));
                    }
                    tblbodyBOLocs = driver.FindElement(By.CssSelector("div[id$=':BOPLocationBuildingsPanelSet:BOPLocationsLV-body']"));
                    tblBOBldLocs = tblbodyBOLocs.FindElements(By.TagName("table")).ToList();
                    UIActionExt(By.CssSelector("table[id='" + tblBOBldLocs[i].GetAttribute("id") + "']"), "ispresent");
                    WaitUntilElementVisible(driver, By.XPath("//div[text()[contains(.,'" + LocAddrNoAddr1 + "')]]"), 5);

                }

                IWebElement tblbodyBOLocsBldgs = WaitFor(driver.FindElement(By.CssSelector("div[id$=':BOPLocationBuildingsPanelSet:BOPLocationBuildingsLV-body']")));
                IList<IWebElement> tblBOBldLocsBldgs = tblbodyBOLocsBldgs.FindElements(By.TagName("table")).ToList();
                int BOLocBldgs = tblBOBldLocsBldgs.Count;
                Console.WriteLine("BOLocBldgs: " + BOLocBldgs);
                for (int j = 0; j <= BOLocBldgs - 1; j++)
                {
                    string linkBOLocationBldg = "a[id$=':BOPLocationBuildingsLV:" + (j) + ":BuildingNumEdit']";
                    string lblBOLocBldgDetail = "span[id='BOPBuildingPopup:BOPSingleBuildingDetailScreen:ttlBar']";
                    string btnUpdateBldg = "span[id$=':Update-btnInnerEl']";
                    driver.FindElement(By.CssSelector(linkBOLocationBldg)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(lblBOLocBldgDetail));
                    driver.FindElement(By.CssSelector(btnUpdateBldg)).Click();
                    WaitUntilElementVisible(driver, By.CssSelector(lblBOBuilding));
                }

            }
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOBlanket));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOModifier));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblBOLineReview));
            driver.FindElement(By.CssSelector(btnNext)).Click();
            WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
        }
        public void RiskAnalysisQuote_Renew()
        {
            driver.FindElement(By.CssSelector(bttRenewQuote)).Click();
            verifyQuoteErrors();
            WaitUntilElementVisible(driver, By.CssSelector(ClickIssuePolicy), 420);
        }

        public void verifyQuoteErrors()
        {
            //try
            //{
            //	UIActionExt(By.CssSelector(btnClear), "ispresent", "", 0, 24, 5);
            //}
            //catch (Exception e)
            //{
            //	Console.WriteLine("Exception Caught" + e);
            //}
            //if (IsElementPresent(driver, By.CssSelector(btnClear)) == true)
            //{
            //	string RatabaseError = "//div[text()[contains(.,'Ratabase Error:')]]";
            //	if (IsElementPresent(driver, By.XPath(RatabaseError)) == true)
            //	{
            //		Assert.Fail("Error: " + driver.FindElement(By.XPath(RatabaseError)).Text);
            //	}
            //}
            bool uwIssues = false;
            try
            {
                WaitUntilElementVisible(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"), 30);
                uwIssues = IsElementPresent(driver, By.Id("UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle"));
                Console.WriteLine("Value of uwIssues is " + uwIssues);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }         
            if (uwIssues)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnDetails), 30);
                UIAction(btnDetails, string.Empty, "a");
                WaitUntilElementVisible(driver, By.CssSelector(lblRiskAnalysis));
                driver.FindElement(By.CssSelector(btnQuote)).Click();
                WaitUntilElementVisible(driver, By.CssSelector(ClickIssuePolicy), 30);
            }
        }
        public CL_RiskAnalysis_PC9(IWebDriver driver) : base(driver)
        {
        }
        public override void VerifyPage()
        {
        }
        public override void WaitForLoad()
        {
        }
    }
}


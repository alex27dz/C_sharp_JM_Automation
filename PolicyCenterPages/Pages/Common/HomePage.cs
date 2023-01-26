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

namespace PolicyCenterPages.Pages.Common
{
    public class HomePage : Page
    {
        [FindsBy(How = How.Id, Using = "TabBar:SearchTab_arrow")]

        public IWebElement SearchMenuArrow;

        string actionMenuArrow = "a[id$=':DesktopMenuActions_arrow']";

        //   string SearchMenuArrow = "a[id$=':SearchTab_arrow']";

        string SearchPolicies = "a[id$=':Search_PolicySearch']";

        string SearchAccounts = "a[id$=':Search_AccountSearch']";

        string actionworkOrderMenu = "a[id$=':PolicyFileMenuActions_arrow']";

        string actionChangePOlicy = "a[id$=':PolicyFileMenuActions_ChangePolicy']";

        string actionAccountMenu = "a[id$=':AccountFileMenuActions_arrow']";

        string menuItemNewAccount = "a[id$=':DesktopMenuActions_NewAccount']";

        string menuItemNewSubmission = "a[id$=':AccountFileMenuActions_NewSubmission']";

        string lnkLogout = "a[id$=':LogoutTabBarLink']";

        string searchLink = "a[id$='TabBar:SearchTab']";

        string leftWorkOrder = "a[id='PolicyFile:MenuLinks:PolicyFile_PolicyFile_Jobs']";

        string leftReinsurance = "a[id$='SubmissionWizard:Reinsurance']";

        string leftContacts = "a[id$=':MenuLinks:AccountFile_AccountFile_Contacts']";

        string leftSummary = "a[id$=':MenuLinks:AccountFile_AccountFile_Summary']";

        string leftRiskAnalysis = "a[id$='SubmissionWizard:RiskAnalysis']";

        string leftpersonaljewelryitemsWorkOrder = "a[id$=':LOBWizardStepGroup:personalItemDetailsStep']";

        string leftpersonaljewelryitemsPolicy = "a[id$=':PolicyMenuItemSet:policyfile_menuitemset_jwlryitem']";

        string leftContactsAccont = "a[id$=':MenuLinks:AccountFile_AccountFile_Contacts']";

        string leftLocationsAccont = "a[id$=':MenuLinks:AccountFile_AccountFile_Locations']";

        string leftSummaryAccont = "a[id$=':MenuLinks:AccountFile_AccountFile_Summary']";

        string leftDocumentAccont = "a[id$=':MenuLinks:AccountFile_AccountFile_Documents']";

        string leftNavBusinessOwners = "a[id$=':BOPWizardStepGroup']";

        string btnClearButton = "a[id$=':WebMessageWorksheet_ClearButton']";

        string linkPolicyInfo = "a[id$='SubmissionWizard:LOBWizardStepGroup:PolicyInfo']";


        string actionCancelPOlicy = "a[id$=':PolicyFileMenuActions_CancelPolicy']";

        string actionReinstatePolicy = "a[id$=':PolicyFileMenuActions_ReinstatePolicy']";

        string actionRewriteRemainderOfTermPolicy = "a[id$=':StartRewriteMenuItemSet:RewriteRemainderOfTerm']";

        string actionRewriteNewTermPolicy = "a[id$=':StartRewriteMenuItemSet:RewriteNewTerm']";

        string actionRewritefullTermPolicy = "a[id$=':StartRewriteMenuItemSet:RewriteFullTerm']";

        string actionPreRenewalDirection = "a[id$=':PolicyFileMenuActions_PreRenewalDirection']";

        string actionRescindCancel = "span[id$=':PolicyFileMenuActions_RescindCancellation']";
        string actionRescindNonPament = "a[id$=':PolicyFileMenuActions_RescindCancellation:0:item']";
        string actionRenewPolicy = "a[id ='PolicyFile:PolicyFileMenuActions:PolicyFileMenuActions_NewWorkOrder:PolicyFileMenuActions_RenewPolicy']";

        string leftDocumentPolicy = "a[id$='PolicyFile:MenuLinks:PolicyFile_PolicyFile_Documents']";


        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(lnkLogout);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lnkLogout));
        }

        public void SelectActionMenu(string menuOption)
        {
            switch (menuOption.ToLower().Trim())
            {
                case "new account":

                    UIAction(actionMenuArrow, string.Empty, "a");


                    UIAction(menuItemNewAccount, string.Empty, "a");

                    break;

                case "new submission":

                    UIAction(actionAccountMenu, string.Empty, "a");

                    UIAction(menuItemNewSubmission, string.Empty, "a");

                    break;

                default:

                    break;
            }
        }

        public void SelectActionMenuForWorkOrder(string menuOption)
        {
            System.Threading.Thread.Sleep(4000);
            switch (menuOption.ToLower().Trim())
            {
                case "policy chnage":

                    UIAction(actionworkOrderMenu, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionChangePOlicy, string.Empty, "a");

                    break;
                case "policy cancel":

                    UIAction(actionworkOrderMenu, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionCancelPOlicy, string.Empty, "a");

                    break;
                case "reinstate policy":

                    UIAction(actionworkOrderMenu, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionReinstatePolicy, string.Empty, "a");

                    break;
                case "rewriteremainderofterm policy":

                    UIAction(actionworkOrderMenu, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionRewriteRemainderOfTermPolicy, string.Empty, "a");

                    break;
                case "rewritenewterm policy":

                    UIAction(actionworkOrderMenu, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionRewriteNewTermPolicy, string.Empty, "a");

                    break;
                case "rewrite fullterm policy":

                    UIAction(actionworkOrderMenu, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionRewritefullTermPolicy, string.Empty, "a");

                    break;

                case "pre-renewal direction":
                    UIAction(actionworkOrderMenu, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionPreRenewalDirection, string.Empty, "a");

                    break;
                case "renew policy":

                    UIAction(actionworkOrderMenu, string.Empty, "a");

                    System.Threading.Thread.Sleep(2000);

                    UIAction(actionRenewPolicy, string.Empty, "a");

                    System.Threading.Thread.Sleep(2000);

                    try
                    {
                        driver.SwitchTo().Alert().Accept();
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine("Exception is " + e.Message);
                    }
                    System.Threading.Thread.Sleep(5000);
                    break;

                case "rescind cancellation":

                    UIAction(actionworkOrderMenu, string.Empty, "a");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionRescindCancel, string.Empty, "span");
                    System.Threading.Thread.Sleep(2000);
                    UIAction(actionRescindNonPament, string.Empty, "a");

                    break;
                default:

                    break;
            }
            System.Threading.Thread.Sleep(2000);
        }

        public void Logout()
        {

            IWebElement btnLogout = driver.FindElement(By.CssSelector(lnkLogout));

            WaitForEnabled(btnLogout);

            UIAction(lnkLogout, string.Empty, "a");

        }

        public void NavigateTabBar(string TabName, string TabMenuItem)
        {
            switch (TabName.ToLower().Trim())
            {
                case "search":
                    if (string.IsNullOrEmpty(TabMenuItem))
                    {
                        UIAction(searchLink, string.Empty, "span");
                        pause();
                    }
                    else
                    {
                        Console.WriteLine("I am in Else loop");
                        switch (TabMenuItem.ToLower().Trim())
                        {
                            case "policies":
                                // UIAction(SearchMenuArrow, string.Empty, "a");
                                JavaScriptClick(SearchMenuArrow);
                                Console.WriteLine("I clicked Arrow");
                                UIAction(SearchPolicies, string.Empty, "a");
                                Console.WriteLine("I clicked sub menu");
                                break;
                            case "accounts":
                                //UIAction(SearchMenuArrow, string.Empty, "a");
                                JavaScriptClick(SearchMenuArrow);
                                Console.WriteLine("I clicked Arrow");
                                UIAction(SearchAccounts, string.Empty, "a");
                                Console.WriteLine("I clicked sub menu");
                                break;
                        }
                    }

                    break;

                case "desktop":
                    if (string.IsNullOrEmpty(TabMenuItem))
                    {
                        //UIAction(desktopLink, string.Empty, "span");
                        //pause();
                    }

                    break;
                default:
                    break;
            }

        }

        public void selectLeftNavMenu(string leftNavMenu)
        {
            pause();
            string[] menuOption = leftNavMenu.Split(':');

            switch (menuOption[0].ToLower().Trim())
            {
                case "riskanalysis":
                    pause();
                    UIAction(leftRiskAnalysis, string.Empty, "a");
                    break;
                case "personaljewelryitemsworkorder":
                    Console.WriteLine("I clicked leftJewelryItems");
                    pause();
                    UIAction(leftpersonaljewelryitemsWorkOrder, string.Empty, "a");
                    break;
                case "personaljewelryitemspolicy":
                    pause();
                    UIAction(leftpersonaljewelryitemsPolicy, string.Empty, "a");
                    break;
                case "accontlocations":
                    pause();
                    UIAction(leftLocationsAccont, string.Empty, "a");
                    break;
                case "accontcontacts":
                    pause();
                    UIAction(leftContactsAccont, string.Empty, "a");
                    break;
                case "accontsummary":
                    pause();
                    UIAction(leftSummaryAccont, string.Empty, "a");
                    break;
                case "businessowners":
                    pause();
                    UIAction(leftNavBusinessOwners, string.Empty, "a");
                    break;
                case "documents":
                    pause();
                    UIAction(leftDocumentAccont, string.Empty, "a");
                    break;
                case "contacts":
                    pause();
                    UIAction(leftContacts, string.Empty, "a");
                    break;
                case "summary":
                    pause();
                    UIAction(leftSummary, string.Empty, "a");
                    break;
                case "reinsurance":
                    pause();
                    UIAction(leftReinsurance, string.Empty, "a");
                    break;
                case "work orders":
                    pause();
                    UIAction(leftWorkOrder, string.Empty, "a");
                    break;
                case "documentspolicy":
                    pause();
                    UIAction(leftDocumentPolicy, string.Empty, "a");
                    break;

                default:
                    break;
            }

        }

        public void SelectSearchMenu(string menuOption)
        {
            switch (menuOption.ToLower().Trim())
            {
                case "new account":

                    UIAction(actionMenuArrow, string.Empty, "a");

                    UIAction(menuItemNewAccount, string.Empty, "a");

                    break;

                case "new submission":

                    UIAction(actionAccountMenu, string.Empty, "a");

                    UIAction(menuItemNewSubmission, string.Empty, "a");

                    break;

                default:

                    break;
            }
        }

        public void ClickClearButton()
        {
            pause();
            pause();
            //if (IsElementPresent(driver, By.CssSelector(btnClearButton))==true)
            UIAction(btnClearButton, string.Empty, "a");
        }
        public void ClickPolicyInfoLink()
        {
            //pause();
            //pause();
            WaitUntilElementEnabled(driver, By.CssSelector(linkPolicyInfo));
            UIAction(linkPolicyInfo, string.Empty, "a");
        }

        public void NavigateAll_ILM_Pages()
        {
            string lnkILM = "a[id$='SubmissionWizard:LOBWizardStepGroup:ILMWizardStepGroup']";
            UIAction(lnkILM, string.Empty, "a");
            string btnILMBOPNext = "a[id$=':Next']";
            string lnkLocation;
            WaitUntilElementEnabled(driver, By.CssSelector(btnILMBOPNext));
            UIAction(btnILMBOPNext, string.Empty, "a");
            pause();
            pause();

            List<IWebElement> ILMLocationsTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:ILMWizardStepGroup:ILMLocation_JMICScreen:ILMStockAndLocationsLV']")).ToList();
            IList<IWebElement> ILMLocationRows = new List<IWebElement>(ILMLocationsTable[0].FindElements(By.TagName("tr")));
            Console.WriteLine("ILM locations Table Rows: " + ILMLocationRows.Count);
            pause();
            for (int i = 1; i < ILMLocationRows.Count(); i++)
            {
                string btnOK = "a[id$='ILMLocation_JMICPopup:Update']";
                lnkLocation = "a[id$=':" + (i - 1) + ":LocationNumber']";
                WaitUntilElementEnabled(driver, By.CssSelector(lnkLocation));
                UIAction(lnkLocation, string.Empty, "a");
                pause();
                pause();
                pause();
                UIAction(btnOK, string.Empty, "a");
            }
            WaitUntilElementEnabled(driver, By.CssSelector(btnILMBOPNext));
            UIAction(btnILMBOPNext, string.Empty, "a");
            WaitUntilElementEnabled(driver, By.CssSelector(btnILMBOPNext));
            UIAction(btnILMBOPNext, string.Empty, "a");
            WaitUntilElementEnabled(driver, By.CssSelector(btnILMBOPNext));
            UIAction(btnILMBOPNext, string.Empty, "a");
        }

        public void NavigateAll_BO_Pages()
        {
            string lnkBO = "a[id$='SubmissionWizard:LOBWizardStepGroup:BOPWizardStepGroup']";
            UIAction(lnkBO, string.Empty, "a");
            string btnBOPNext = "a[id$=':Next']";
            string lnkLocation;
            WaitUntilElementEnabled(driver, By.CssSelector(btnBOPNext));
            UIAction(btnBOPNext, string.Empty, "a");
            pause();
            pause();
            List<IWebElement> BOLocationsTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPLocationsScreen:BOPLocationsPanelSet:LocationsEdit_DP:LocationsEdit_LV']")).ToList();
            IList<IWebElement> BOLocationRows = new List<IWebElement>(BOLocationsTable[0].FindElements(By.TagName("tr")));
            Console.WriteLine("BO locations Table Rows: " + BOLocationRows.Count);
            pause();
            for (int i = 1; i < BOLocationRows.Count(); i++)
            {
                string btnLocOK = "a[id$='BOPLocationPopup:LocationScreen:Update']";
                lnkLocation = "a[id$=':" + (i - 1) + ":Loc']";
                WaitUntilElementEnabled(driver, By.CssSelector(lnkLocation));
                UIAction(lnkLocation, string.Empty, "a");
                pause();
                pause();
                pause();
                UIAction(btnLocOK, string.Empty, "a");
            }


            WaitUntilElementEnabled(driver, By.CssSelector(btnBOPNext));
            UIAction(btnBOPNext, string.Empty, "a");
            pause();
            pause();
            List<IWebElement> BOLocBuildingsTable = driver.FindElements(By.XPath("//table[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:BOPWizardStepGroup:BOPBuildingsScreen:BOPBuildingsCV:BOPLocationBuildingsPanelSet:BOPLocationsLV']")).ToList();
            IList<IWebElement> BOLocBuildingsRows = new List<IWebElement>(BOLocBuildingsTable[0].FindElements(By.TagName("tr")));
            Console.WriteLine("BO loc Buildings Table Rows: " + BOLocBuildingsRows.Count);
            pause();
            for (int i = 1; i < BOLocBuildingsRows.Count(); i++)
            {
                string btnbldOK = "a[id$='BOPBuildingPopup:BOPSingleBuildingDetailScreen:Update']";
                string lnkLocationBld = "a[id$=':BOPLocationsLV:" + (i - 1) + ":_ViewDetail']";
                if (i == 1)
                    lnkLocationBld = "span[id$=':BOPLocationsLV:" + (i - 1) + ":_ViewDetail']";
                WaitUntilElementVisible(driver, By.CssSelector(lnkLocationBld));
                UIAction(lnkLocationBld, string.Empty, "span");
                pause();
                pause();
                string BldLoc = "span[label='Bldg. #'][value='1']";
                WaitUntilElementVisible(driver, By.CssSelector(BldLoc));
                UIAction(BldLoc, string.Empty, "span");

                pause();
                pause();
                pause();
                UIAction(btnbldOK, string.Empty, "a");
            }
            WaitUntilElementEnabled(driver, By.CssSelector(btnBOPNext));
            UIAction(btnBOPNext, string.Empty, "a");
            WaitUntilElementEnabled(driver, By.CssSelector(btnBOPNext));
            UIAction(btnBOPNext, string.Empty, "a");
            WaitUntilElementEnabled(driver, By.CssSelector(btnBOPNext));
            UIAction(btnBOPNext, string.Empty, "a");
            WaitUntilElementEnabled(driver, By.CssSelector(btnBOPNext));
            UIAction(btnBOPNext, string.Empty, "a");
        }

        public void VerifyWorkOrderDetails(string expectedType, string expectedStatus)
        {
            List<IWebElement> reservetableObj1;
            reservetableObj1 = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_JobsInProgressLV")).ToList();
            var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
            pause();
            string type = "";
            string status = "";
            Console.WriteLine("Count is " + rows1.Count());
            for (int i = 1; i < rows1.Count(); i++)
            {
                var tds = rows1[i].FindElements(By.TagName("td"));
                type = type + " " + tds[4].Text;
                status = status + " " + tds[3].Text;
            }


            //Console.WriteLine("Type is " + type);
            //if (type.ToUpper().Contains(expectedType.ToUpper()))




            //    var tds = rows1[rows1.Count-1].FindElements(By.TagName("td"));
            //string status = tds[3].Text;
            //string type = tds[4].Text;
            Console.WriteLine("Status is " + status);
            Console.WriteLine("type is " + type);

            //if(expectedType.ToUpper().Equals(type.ToUpper()))
            if (type.ToUpper().Contains(expectedType.ToUpper()))
            {
                Console.WriteLine("Type matches");
            }
            else
            {
                Console.WriteLine("Type donot matches");
                Assert.Fail("Type donot matches");
            }
            if (status.ToUpper().Contains(expectedStatus.ToUpper()))
            //if (expectedStatus.ToUpper().Equals(status.ToUpper()))
            {
                Console.WriteLine("status matches");
            }
            else
            {
                Console.WriteLine("status donot matches");
                Assert.Fail("status donot matches");
            }

        }

        public void Verify_RenewalButton_Check(string flag)
        {
            UIAction(actionworkOrderMenu, string.Empty, "a");

            System.Threading.Thread.Sleep(2000);
            List<IWebElement> btnRenew = driver.FindElements(By.Id("PolicyFile:PolicyFileMenuActions:PolicyFileMenuActions_NewWorkOrder:PolicyFileMenuActions_RenewPolicy")).ToList();
            if (flag.ToLower().Equals("yes"))
            {
                if (btnRenew.Count() > 0)
                {
                    Console.WriteLine("Renew button exist which is expected");
                }
                else
                {
                    Assert.Fail("Renew button do not exist which is not expected");
                }

            }
            else
            {
                if (btnRenew.Count() > 0)
                {
                    Assert.Fail("Renew button exist which is not expected");
                }
                else
                {
                    Console.WriteLine("Renew button do not exist which is expected");
                }

            }
        }


        public void Verify_RenewalButton_Check(string Offering, int diffdate)
        {
            UIAction(actionworkOrderMenu, string.Empty, "a");

            System.Threading.Thread.Sleep(2000);
            List<IWebElement> btnRenew = driver.FindElements(By.Id("PolicyFile:PolicyFileMenuActions:PolicyFileMenuActions_NewWorkOrder:PolicyFileMenuActions_RenewPolicy")).ToList();

            //switch (Offering.ToUpper())
            //{
            //    case "JEWELERS BLOCK":
            //    case "JEWELERS BLOCK PAK":

            //        if(diffdate > 46 & diffdate <= 100)
            //        {
            //            if(btnRenew.Count() >0 )
            //            {
            //                Console.WriteLine("Renew button exist which is expected");
            //            }
            //            else
            //            {
            //                Assert.Fail("Renew button do not exist which is not expected");
            //            }

            //        }
            //        else if(diffdate > 0 & diffdate <= 46)
            //            {
            //                if (btnRenew.Count() > 0)
            //                {
            //                     Assert.Fail("Renew button exist which is not expected");
            //                 }
            //                else
            //                {
            //                     Console.WriteLine("Renew button do not exist which is expected");
            //                }

            //            }

            //        break;

            //    case "BUSINESSOWNERS":
            //    case "JEWELERS STANDARD":
            //    case "JEWELERS STANDARD PAK":
            //        if (diffdate > 46 & diffdate <= 100)
            //        {
            //            if (btnRenew.Count() > 0)
            //            {
            //                Console.WriteLine("Renew button exist");
            //            }
            //            else
            //            {
            //                Assert.Fail("Renew button do not exist");
            //            }

            //        }
            //        else if (diffdate > 0 & diffdate <= 46)
            //        {
            //            if (btnRenew.Count() > 0)
            //            {
            //                Assert.Fail("Renew button exist");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Renew button do not exist");
            //            }

            //        }


            //        break;
            //}

        }

        public void VerifyTransaction(string expectedType)
        {
            List<IWebElement> reservetableObj1;
            reservetableObj1 = driver.FindElements(By.Id("PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_TransactionsLV")).ToList();
            var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
            pause();

            string type = "";
            Console.WriteLine("Count is " + rows1.Count());
            for (int i = 1; i < rows1.Count(); i++)
            {
                var tds = rows1[i].FindElements(By.TagName("td"));
                type = type + " " + tds[4].Text;
            }


            Console.WriteLine("Type is " + type);
            if (type.ToUpper().Contains(expectedType.ToUpper()))
            {
                Console.WriteLine("Type matches");
            }
            else
            {
                Console.WriteLine("Type donot matches");
                Assert.Fail("Type donot matches");
            }
        }

        public void verifyCLRenewal(string Offering)
        {
            IWebElement labelPolicyExpiryeDate = driver.FindElement(By.XPath("//span[@id='PolicyFile_Summary:Policy_SummaryScreen:Policy_Summary_DatesDV:PolicyPerExpirDate']"));
            string TempDate = labelPolicyExpiryeDate.GetAttribute("value");
            Console.WriteLine("Tem Date is " + TempDate);
            DateTime effectivedate = (DateTime.Parse(TempDate)).Date;
            int DateDiff = (effectivedate - DateTime.Today).Days;
            ScenarioContext.Current["DateDiff"] = DateDiff;
            Console.WriteLine("DateDiff is " + DateDiff);
            switch (Offering.ToUpper())
            {
                case "JEWELERS BLOCK":
                case "JEWELERS BLOCK PAK":
                    if ((DateDiff > 0) & (DateDiff <= 31))
                    {
                        VerifyWorkOrderDetails("Renewal", "Draft");
                        Verify_RenewalButton_Check("no");
                        //Verify_RenewalButton_Check(Offering, DateDiff);
                    }
                    else if ((DateDiff > 31) & (DateDiff <= 46))
                    {
                        VerifyWorkOrderDetails("Renewal", "Draft");
                        Verify_RenewalButton_Check("no");
                        //Verify_RenewalButton_Check(Offering, DateDiff);
                    }
                    else if ((DateDiff > 46) & (DateDiff <= 75))
                    {
                        Verify_RenewalButton_Check("yes");
                        //Verify_RenewalButton_Check(Offering, DateDiff);
                    }

                    else if ((DateDiff > 75) & (DateDiff <= 100))
                    {
                        Verify_RenewalButton_Check("yes");
                        //Verify_RenewalButton_Check(Offering, DateDiff);
                    }


                    break;
                case "BUSINESSOWNERS":
                case "JEWELERS STANDARD":
                case "JEWELERS STANDARD PAK":
                    if ((DateDiff > 0) & (DateDiff <= 31))
                    {
                        VerifyTransaction("Renewal");
                        Verify_RenewalButton_Check("yes");
                        //Verify_RenewalButton_Check(Offering, DateDiff);
                    }
                    else if ((DateDiff > 31) & (DateDiff <= 46))
                    {

                        VerifyWorkOrderDetails("Renewal", "Renewing");
                        Verify_RenewalButton_Check("no");
                        //Verify_RenewalButton_Check(Offering, DateDiff);
                    }

                    else if ((DateDiff > 46) & (DateDiff <= 75))
                    {
                        Verify_RenewalButton_Check("yes");
                        //Verify_RenewalButton_Check(Offering, DateDiff);
                    }

                    else if ((DateDiff > 75) & (DateDiff <= 100))
                    {
                        Verify_RenewalButton_Check(Offering, DateDiff);
                        Verify_RenewalButton_Check("yes");
                    }


                    break;
            }

            //labelPolicyExpiryeDate.Click();
            //pause();
        }

    }
}

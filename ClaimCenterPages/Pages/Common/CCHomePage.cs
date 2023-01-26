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
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace ClaimCenterPages.Pages.Common
{
    public class CCHomePage : Page
    {
        string actionMenuArrow = "a[id$=':ClaimMenuActions']";

        string menuItemAssignClaim = "a[id$=':ClaimMenuActions_Assign']";

        string menuItemCheck = "a[id$=':ClaimMenuActions_NewTransaction_CheckSet']";

        string menuItemCloseClaim = "a[id$=':ClaimMenuActions_CloseClaim']";

        string menuItemNewExposure = "a[id$=':CustomNewExposureID']";

        string menuItemNewReserve = "a[id$=':ClaimMenuActions_NewTransaction_ReserveSet']";

        string lnkLogout = "a[id$=':LogoutTabBarLink']";

        string TabClaim_arrow = "a[id$=':ClaimTab_arrow']";

        string TabClaim = "a[id$='TabBar:ClaimTab']";

        string ClaimMenuOption = "a[id$=':ClaimTab_FNOLWizard']";

        string leftNavPartiesInvolved = "a[id$='MenuLinks:Claim_ClaimPartiesGroup']";

        string newDocument = "a[id$=':ClaimNewDocumentMenuItemSet_Create']";

        string leftNavDocuments = "a[id$='MenuLinks:Claim_ClaimDocumentsGroup']";

        [FindsBy(How = How.Id, Using = "TabBar:ClaimTab_arrow")]

        public IWebElement btnClaimArrow;

        [FindsBy(How = How.Id, Using = "TabBar:ClaimTab:ClaimTab_FindClaim_Button")]

        public IWebElement btnSearchClaimClaimTab;

        string AdmininistationTab = "a[id$=':AdminTab']";

        public CCHomePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
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

        public void SelectTabMenu(string TabName, string TabMenuOption)
        {
            switch (TabName.ToLower().Trim())
            {
                case "claim":
                    UIAction(TabClaim_arrow, string.Empty, "a");

                    switch (TabMenuOption.ToLower())
                    {
                        case "new claim":
                            UIAction(ClaimMenuOption, string.Empty, "a");
                            break;
                        default:
                            break;
                    }

                    break;


                case "administration":

                    UIAction(AdmininistationTab, string.Empty, "a");

                    break;


                default:

                    break;
            }
        }

        public void SelectActionMenu(string menuOption)
        {
            UIAction(TabClaim, string.Empty, "a");
            pause();

            switch (menuOption.ToLower().Trim())
            {
                case "assign claim":

                    UIAction(actionMenuArrow, string.Empty, "a");

                    UIAction(menuItemAssignClaim, string.Empty, "a");

                    break;

                case "new exposure":

                    UIAction(actionMenuArrow, string.Empty, "a");

                    UIAction(menuItemNewExposure, string.Empty, "a");

                    break;

                case "reserve":

                    UIAction(actionMenuArrow, string.Empty, "a");

                    UIAction(menuItemNewReserve, string.Empty, "a");

                    break;

                case "create from template":

                    UIAction(actionMenuArrow, string.Empty, "a");

                    UIAction(newDocument, string.Empty, "a");

                    break;

                case "check":

                    UIAction(actionMenuArrow, string.Empty, "a");

                    UIAction(menuItemCheck, string.Empty, "a");

                    break;

                case "close claim":

                    UIAction(actionMenuArrow, string.Empty, "a");

                    UIAction(menuItemCloseClaim, string.Empty, "a");

                    break;


                default:
                    Console.WriteLine("No option selected from action menu.");
                    break;
            }
        }

        public void SelectLeftNavigationMenu(string menuOption)
        {
            switch (menuOption.ToLower().Trim())
            {
                case "parties involved":
                    pause();
                    UIAction(leftNavPartiesInvolved, string.Empty, "a");
                    pause();

                    break;

                case "documents":
                    UIAction(leftNavDocuments, string.Empty, "a");
                    pause();

                    break;
                default:
                    break;
            }
        }

        public void Logout()
        {
            UIAction(lnkLogout, string.Empty, "a");

        }

        public void searchClaimNumberUsingClaimTab(string ClaimNumber)
        {
            JavaScriptClick(btnClaimArrow);
            pause();
            btnClaimArrow.SendKeys(Keys.Down);
            ClaimNumber = ClaimNumber.Replace("-", string.Empty);
            btnClaimArrow.SendKeys(ClaimNumber);
            Thread.Sleep(3000);
            // claimNumberClaimTab.Click();
            // claimNumberClaimTab.SendKeys(ClaimNumber);
            // UIAction(claimNumberClaimTab, ClaimNumber, "input");
            JavaScriptClick(btnSearchClaimClaimTab);

        }

        public void verifyCalimTaggedToPolicy(string Policynumber)
        {
            pause();
            string Summary_Content;
            List<IWebElement> PageInputElements = driver.FindElements(By.Id("Claim:ClaimInfoBar:PolicyNumber_link")).ToList();
            Summary_Content = PageInputElements[0].Text;
            Console.WriteLine("Details arer " + Summary_Content);

            if (Summary_Content.Contains(Policynumber))
            {
                Console.WriteLine("Correct Policy is referred");
            }
            else
            {
                Console.WriteLine("Correct Policy is not referred");
                Assert.Fail("Correct Policy is not referred");

            }
        }

    }
}

using OpenQA.Selenium;
using System;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.Common
{
    public class CCHomePage_CC9 : Page
    {
        string logOut = "span[id=':TabLinkMenuButton-btnIconEl']";
		string logOutLink = "span[id='TabBar:LogoutTabBarLink-textEl']";
        string SearchTab = "span[id$='TabBar:SearchTab-btnInnerEl']";
        string AdmininistationTab = "span[id$='TabBar:AdminTab-btnInnerEl']";
        string actionMenuArrow = "a[id$=':ClaimMenuActions']";
        string menuItemAssignClaim = "span[id$=':ClaimMenuActions_Assign-textEl']";
        string menuItemCheck = "a[id$='ClaimMenuActions_NewTransaction_CheckSet-itemEl']";
        string menuItemCloseClaim = "span[id$=':ClaimMenuActions_CloseClaim-textEl']";
        string menuItemNewExposure = "span[id$=':CustomNewExposureID-textEl']";
        string TabClaim_arrow = "span[id$='TabBar:ClaimTab-btnEl']";
        string ClaimMenuOption = "span[id$='TabBar:ClaimTab:ClaimTab_FNOLWizard-textEl']";
        string newDocument = "a[id$=':ClaimNewDocumentMenuItemSet_Create-itemEl']";
		string menuItemReopenClaim = "span[id$=':ClaimMenuActions_ReopenClaim-textEl']";
		string menuItemNewReserve = "a[id='Claim:ClaimMenuActions:ClaimMenuActions_NewTransaction:ClaimMenuActions_NewTransaction_ReserveSet-itemEl']";
		string menuItemRecovery = "a[id='Claim:ClaimMenuActions:ClaimMenuActions_NewTransaction:ClaimMenuActions_NewTransaction_Recovery_Wizard-itemEl']";

        public void SelectTabMenu(string TabName, string TabMenuOption)
        {
			WaitUntilElementIsDisplayed(driver, By.XPath("//div[id$= ':tabs-innerCt']"));
			switch (TabName.ToLower().Trim())
            {
                case "claim":
					UIActionExt(By.CssSelector(TabClaim_arrow), "ispresent");
					switch (TabMenuOption.ToLower())
                    {
                        case "new claim":
							driver.FindElement(By.CssSelector(TabClaim_arrow)).SendKeys(Keys.ArrowDown);
							UIActionExt(By.CssSelector(ClaimMenuOption), "ispresent");
							UIActionExt(By.CssSelector(ClaimMenuOption), "click");
							break;
						default:
                            break;
                    }
                    break;
                case "administration":
					UIActionExt(By.CssSelector(AdmininistationTab), "click");
					break;
                case "search":
					UIActionExt(By.CssSelector(SearchTab), "click");
					break;
                default:
                    break;
            }
        }

        public void SelectActionMenu(string menuOption)
        {
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector(actionMenuArrow),10);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			UIActionExt(By.CssSelector(actionMenuArrow), "ispresent");
			UIActionExt(By.CssSelector(actionMenuArrow), "click");
			switch (menuOption.ToLower().Trim())
            {
                case "assign claim":
					UIActionExt(By.CssSelector(menuItemAssignClaim), "ispresent");
					UIActionExt(By.CssSelector(menuItemAssignClaim), "click");
					break;
                case "new exposure":
					UIActionExt(By.CssSelector(menuItemNewExposure), "ispresent");
					UIActionExt(By.CssSelector(menuItemNewExposure), "click");
					break;
                case "reserve":
					UIActionExt(By.CssSelector(menuItemNewReserve), "ispresent");
					UIActionExt(By.CssSelector(menuItemNewReserve), "click");
					break;
                case "recovery":
					UIActionExt(By.CssSelector(menuItemRecovery), "ispresent");
					UIActionExt(By.CssSelector(menuItemRecovery), "click");
					break;
                case "create from template":
					UIActionExt(By.CssSelector(newDocument), "ispresent");
					UIActionExt(By.CssSelector(newDocument), "click");
					break;
                case "check":
					UIActionExt(By.CssSelector(menuItemCheck), "ispresent");
					UIActionExt(By.CssSelector(menuItemCheck), "click");
					break;
                case "close claim":
					UIActionExt(By.CssSelector(menuItemCloseClaim), "ispresent");
					UIActionExt(By.CssSelector(menuItemCloseClaim), "click");
					break;
                case "reopen claim":
					UIActionExt(By.CssSelector(menuItemReopenClaim), "ispresent");
					UIActionExt(By.CssSelector(menuItemReopenClaim), "click");
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
					UIActionExt(By.XPath("//span[text()= 'Parties Involved']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Parties Involved']"), "click");
					break;
                case "documents":
					UIActionExt(By.XPath("//span[text()= 'Documents']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Documents']"), "click");
					break;
                case "workplan":
					UIActionExt(By.XPath("//span[text()= 'Workplan']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Workplan']"), "click");
					break;
                case "exposures":
					UIActionExt(By.XPath("//span[text()= 'Exposures']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Exposures']"), "click");
					break;
                case "reinsurance":
					UIActionExt(By.XPath("//span[text()= 'Reinsurance']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Reinsurance']"), "click");
					break;
                case "lossdetails":
					UIActionExt(By.XPath("//span[text()= 'Loss Details']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Loss Details']"), "click");
					break;
                case "status":
					UIActionExt(By.XPath("//span[text()= 'Status']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Status']"), "click");
					break;
                case "policy":
					UIActionExt(By.XPath("//span[text()= 'Policy']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Policy']"), "click");
					break;
                case "jewelry items (0)":
					UIActionExt(By.XPath("//span[text()= 'Jewelry Items (0)']"), "ispresent");
					UIActionExt(By.XPath("//span[text()= 'Jewelry Items (0)']"), "click");
					break;
                default:
                    break;
            }
        }

        public void LogoutOfCC()
        {
			UIActionExt(By.CssSelector(logOut), "ispresent");
			UIActionExt(By.CssSelector(logOut), "click");
			UIActionExt(By.CssSelector(logOutLink), "click");
		}

		public CCHomePage_CC9(IWebDriver driver) : base(driver)
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

using OpenQA.Selenium;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.Common
{
    public class CCAdminPage_CC9 : Page
    {

        string logOut = "span[id=':TabLinkMenuButton-btnIconEl']";
        string logOutLink = "span[id='TabBar:LogoutTabBarLink-textEl']";
        string AdminUserSecurity = "td[id$='Admin:MenuLinks:Admin_UsersAndSecurity']";
        string AdminSearchforUser = "td[id$=':UsersAndSecurity_AdminUserSearchPage']";
        string txtUserName = "input[id$=':UserSearchDV:Username-inputEl']";
        string btnSearch = "a[id$=':SearchAndResetInputSet:SearchLinksInputSet:Search']";
        string SearchResultUser = "a[id$=':AdminUserSearchResultsLV:0:DisplayName']";
        string TabAuthorityLimits = "span[id$=':UserDetailScreen:AuthorityLimitsCardTab-btnInnerEl']";
        string btnEdit = "span[id$=':UserDetailToolbarButtonSet:Edit-btnInnerEl']";
        string btnUpdate = "span[id$=':UserDetailScreen:UserDetailToolbarButtonSet:Update-btnInnerEl']";
        string selAuthorityLimits = "input[id$=':UserDetailScreen:UserAuthorityLimitsDV:AuthorityLimitsProfile-inputEl']";
        string TabDesktop = "span[id$='TabBar:DesktopTab-btnInnerEl']";
        string btnReset = "a[id$=':SearchAndResetInputSet:SearchLinksInputSet:Reset']";
        string TabBasics = "span[id$=':UserDetailScreen:BasicsCardTab-btnInnerEl']";
        string txtPassword = "input[id$=':UserDetailCommons:UserDetailInputSet:PasswordInputWidget-inputEl']";
        string radioUserActiveTrue = "input[id$=':UserDetailCommons:UserDetailInputSet:Active_true-inputEl'";
        string radioUserLockedFalse = "input[id$=':UserDetailCommons:UserDetailInputSet:AccountLocked_false-inputEl'";
        string txtConfirmPassword = "input[id$=':UserDetailCommons:UserDetailInputSet:ConfirmInputWidget-inputEl']";

        public void SearchUserAndSetProfile(string UserName, string profile)
        {
			UIActionExt(By.CssSelector(AdminUserSecurity), "click");
			UIActionExt(By.CssSelector(AdminSearchforUser), "click");
			UIActionExt(By.CssSelector(txtUserName), "Text", UserName);
			UIActionExt(By.CssSelector(btnSearch), "click");
			UIActionExt(By.CssSelector(SearchResultUser), "click");
			UIActionExt(By.CssSelector(TabAuthorityLimits), "click");
			UIActionExt(By.CssSelector(btnEdit), "click");
			UIActionExt(By.CssSelector(selAuthorityLimits), "Text", profile);
			UIActionExt(By.CssSelector(btnUpdate), "ispresent");
			UIActionExt(By.CssSelector(btnUpdate), "click");
			UIActionExt(By.CssSelector(TabDesktop), "click");
        }

        public void Logoff()
        {
			UIActionExt(By.CssSelector(logOut), "click");
			UIActionExt(By.CssSelector(logOutLink), "click");
		}

        public void SearchUserAndSetProfile(string UserName, string password, string profile)
        {

			string usrVacation = "input[id$=':UserDetailCommons:UserDetailInputSet:VacationStatus-inputEl']";
			string lnkProfile = "span[id$='UserDetailPage:UserDetailScreen:ProfileCardTab-btnInnerEl']";
			string txtWorkPhNum = "input[id$=':UserPreferencesContactInputSet:UserWorkPhone:GlobalPhoneInputSet:NationalSubscriberNumber-inputEl']";

			UIActionExt(By.CssSelector(AdminUserSecurity), "click");
			UIActionExt(By.CssSelector(AdminSearchforUser), "click");
			UIActionExt(By.CssSelector(btnReset), "click");
			UIActionExt(By.CssSelector(txtUserName), "Text", UserName);
			UIActionExt(By.CssSelector(btnSearch), "click");
			UIActionExt(By.CssSelector(SearchResultUser), "click");
			UIActionExt(By.CssSelector(TabAuthorityLimits), "click");
			UIActionExt(By.CssSelector(btnEdit), "click");

			UIActionExt(By.CssSelector(selAuthorityLimits), "List", profile);
			UIActionExt(By.CssSelector(TabBasics), "click");

			UIActionExt(By.CssSelector(txtPassword), "Text", password);
			UIActionExt(By.CssSelector(txtConfirmPassword), "Text", password);
			UIActionExt(By.CssSelector(radioUserActiveTrue), "click");
			UIActionExt(By.CssSelector(radioUserLockedFalse), "click");

			if (driver.FindElement(By.CssSelector(usrVacation)).GetAttribute("value") != "At work")
			{
				UIActionExt(By.CssSelector(usrVacation), "List", "At work");
			}
			UIActionExt(By.CssSelector(lnkProfile), "click");
			WaitUntilElementVisible(driver, By.CssSelector(txtWorkPhNum));
			if (driver.FindElement(By.CssSelector(txtWorkPhNum)).GetAttribute("value") == "")
			{
				UIActionExt(By.CssSelector(txtWorkPhNum), "List", "920-400-1866");
			}
			UIActionExt(By.CssSelector(btnUpdate), "click");
		}
		public CCAdminPage_CC9(IWebDriver driver) : base(driver)
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

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

namespace ClaimCenterPages.Pages.Common
{
    public class CCAdminPage : Page
    {

        string actionMenuArrow = "a[id$=':DesktopMenuActions_arrow']";

        string actionAccountMenu = "a[id$=':AccountFileMenuActions_arrow']";

        string menuItemNewAccount = "a[id$=':DesktopMenuActions_NewAccount']";

        string menuItemNewSubmission = "a[id$=':AccountFileMenuActions_NewSubmission']";

        string lnkLogout = "a[id$=':LogoutTabBarLink']";

        string AdminSearchforUser = "a[id$=':Admin_AdminUserSearchPage']";

        string txtUserName = "input[id$=':UserSearchDV:Username']";

        string btnSearch = "span[id$=':Search_link']";

        string SearchResultUser = "a[id$=':UserSearchResultsLV:0:DisplayName']";

        string TabAuthorityLimits = "a[id$=':AuthorityLimitsCardTab']";

        string btnEdit = "a[id$=':Edit']";

        string btnUpdate = "a[id$=':Update']";

        string selAuthorityLimits = "select[id$=':AuthorityLimitsProfile']";

        string TabDesktop = "a[id$=':DesktopTab']";

        string EventmessageOption = "a[id$='Admin:MenuLinks:Admin_MessagingDestinationControlList']";

        string resumeBtn = "a[id$=':MessagingDestinationControlList_ResumeButton']";

        string SuspendBtn = "a[id$=':MessagingDestinationControlList_SuspendButton']";

        string[] arrTblList;

        public CCAdminPage(IWebDriver driver) : base(driver)
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
        
        public void SearchUserAndSetProfile(string UserName, string profile)
        {
            UIAction(AdminSearchforUser, string.Empty , "a");

            UIAction(txtUserName, UserName, "textbox");

            UIAction(btnSearch, string.Empty , "span");

            UIAction(SearchResultUser, string.Empty , "a");

            UIAction(TabAuthorityLimits, string.Empty , "a");

            UIAction(btnEdit, string.Empty , "a");

            UIAction(selAuthorityLimits, profile, "selectbox");

            pause();

            UIAction(btnUpdate, string.Empty , "a");

            UIAction(TabDesktop, string.Empty , "a");

        }

        public void ManageTransport()
        {
            bool flag = false;
            int counter = 0;
            UIAction(EventmessageOption, string.Empty, "a");
            pause();
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("MessagingDestinationControlList:MessagingDestinationControlListScreen:MessagingDestinationsControlLV")).ToList();
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Console.WriteLine("count of array for account " + arrTblList.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int k = 0; k < arrTblList.Count(); k++)
            {
                string CheckboxID = "";
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
                if (arrTblList[k].ToString().Contains("Suspended"))
                {
                    if (flag == false)
                    {
                        counter = k;
                        flag = true;
                    }
                    //Console.WriteLine("inside Suspended logic ");
                    //Console.WriteLine("Counter is " + counter);
                    CheckboxID = "input[id$=':MessagingDestinationsControlLV:" + (k - counter) + ":_Checkbox']";
                    UIAction(CheckboxID, string.Empty, "radio");
                    UIAction(resumeBtn, string.Empty, "a");

                }
                else if (arrTblList[k].ToString().Contains("Started"))
                {
                    if (flag == false)
                    {
                        counter = k;
                        flag = true;
                    }
                }
            }
            UIAction(TabDesktop, string.Empty, "a");
            pause();
        }

    }
}

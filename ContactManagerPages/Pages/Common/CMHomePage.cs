using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace ContactManagerPages.Pages.Common
{
    public class CMHomePage : Page
    {
        string logOut = "span[id=':TabLinkMenuButton-btnIconEl']";
        string logOutLink = "span[id='TabBar:LogoutTabBarLink-textEl']";
        string desktopLink = "span[id$=DesktopTab-btnInnerEl']";
        string actionMenuArrow = "span[id='ABContacts:ContactsMenuActions-btnEl']";
        string actionMenuNewPerson = "span[id=':ContactsMenuActions:ContactsMenuActions_NewPersonMenuItem-textEl']";
        string contactsArrow = "span[id$='TabBar:ContactsTab-btnWrap']";
        string contactSearch = "a[id$=':ContactsTab:ABContacts_ABContactSearch-itemEl']";
        public CMHomePage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(logOut);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(logOut));
        }


        public void NavigateTabBar(string TabName, string TabMenuItem)
        {
            switch (TabName.ToLower().Trim())
            {
                case "contacts":
					UIActionExt(By.CssSelector(contactsArrow), "ispresent");
					UIActionExt(By.CssSelector(contactsArrow), "click");
                    if (string.IsNullOrEmpty(TabMenuItem))
                    {
						UIActionExt(By.CssSelector(contactSearch), "ispresent");
						UIActionExt(By.CssSelector(contactSearch), "click");
					}
                    break;

                case "desktop":
                    if (string.IsNullOrEmpty(TabMenuItem))
                    {
						UIActionExt(By.CssSelector(desktopLink), "ispresent");
						UIActionExt(By.CssSelector(desktopLink), "click");
					}
                    break;
                default:
                    break;
            }
        }

        public void SelectFromActionMenu(string menuOption)
        {
            Console.WriteLine("In Here");

            string[] menuItems = menuOption.Split(':');
            switch (menuItems[0].ToLower().Trim())
            {
                case "new person":
					UIActionExt(By.CssSelector(actionMenuArrow), "ispresent");
					UIActionExt(By.CssSelector(actionMenuArrow), "click");
					UIActionExt(By.CssSelector(actionMenuNewPerson), "ispresent");
					UIActionExt(By.CssSelector(actionMenuNewPerson), "click");
					break;
                default:
                    break;
            }
        }


        //public void selectLeftNavMenu(string leftNavMenu)
        //{
        //    pause();
        //    string[] menuOption = leftNavMenu.Split(':');

        //    switch (menuOption[0].ToLower().Trim())
        //    {

        //        default:
        //            break;
        //    }

        //}



        public void LogoutOfBC()
        {
			UIActionExt(By.CssSelector(logOut), "ispresent");
			UIActionExt(By.CssSelector(logOut), "click");
			UIActionExt(By.CssSelector(logOutLink), "click");
		}
    }
}

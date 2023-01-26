using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace ContactManagerPages.Pages.Common
{
    public class CMLoginPage : Page
    {
        string username = "input[id$=':username-inputEl']";

        string password = "input[id$=':password-inputEl']";

        string btnLogin = "span[id$=':submit-btnInnerEl']";
        public CMLoginPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(username);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(username));
        }

        public void LoginIntoCM(string userName, string passWord)
        {
			UIActionExt(By.CssSelector(username), "ispresent");
			UIActionExt(By.CssSelector(username), "Text", userName);
			UIActionExt(By.CssSelector(password), "Text", passWord);
			UIActionExt(By.CssSelector(btnLogin), "click");
		}
	}
}

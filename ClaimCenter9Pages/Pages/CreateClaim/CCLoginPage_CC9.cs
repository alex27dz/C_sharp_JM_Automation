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

namespace ClaimCenter9Pages.Pages.Common
{
    public class CCLoginPage_CC9 : Page
    {
        string username = "input[id$=':username-inputEl']";
        string password = "input[id$=':password-inputEl']";
        string btnLogin = "span[id$=':submit-btnInnerEl']";

        public CCLoginPage_CC9(IWebDriver driver) : base(driver)
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

        public void LoginIntoBC(string userName, string passWord)
        {
            IWebElement test = driver.FindElement(By.CssSelector(username));

            Console.WriteLine("User Login Page displayed: " + test.Displayed);
			UIActionExt(By.CssSelector(username), "Text", userName);
			UIActionExt(By.CssSelector(password), "Text", passWord);
			UIActionExt(By.CssSelector(btnLogin), "click");

		}


	}
}

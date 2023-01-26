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

namespace PolicyCenter9Pages.Pages.Common
{
	public class LoginPage_PC9 : Page
	{
		string inputUserName = "input[id$=':username-inputEl']";
		string inputPassword = "input[id$=':password-inputEl']";
		string login = "span[id$=':submit-btnInnerEl']";

		public LoginPage_PC9(IWebDriver driver) : base(driver)
		{

		}
		public override void VerifyPage()
		{
			VerifyUIElementIsDisplayed(inputUserName);
		}

		public override void WaitForLoad()
		{
			IsElementPresent(driver, By.CssSelector(inputUserName));
		}

		public void EnterLoginDetailsPC9(string UserName, string Password)
		{
			UIAction(inputUserName, UserName, "textbox");
			UIAction(inputPassword, Password, "textbox");
			UIAction(login, string.Empty, "button");
		}
	}
}

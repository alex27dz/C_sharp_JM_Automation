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

namespace PolicyCenter9Pages.Pages.Common
{
	public class AdminTools_PC9 : Page
	{
		string lnkLogout = "span[id=':TabLinkMenuButton-btnIconEl']";
		string lblTodaysDate = "span[id='TabBar:todaysdateTabBarLink-textEl']";

		public AdminTools_PC9(IWebDriver driver) : base(driver)
		{
			WaitForPageLoad(driver);

		}

		public override void VerifyPage()
		{
			VerifyUIElementIsDisplayed(lnkLogout);
		}

		public override void WaitForLoad()
		{
			IsElementPresent(driver, By.CssSelector(lnkLogout));
		}

		public void getPC9SystemDate()
		{
			switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
			{
				case "stage":

					string currDate = DateTime.Now.ToString("MM/dd/yyyy");

					Console.WriteLine("Current Date:" + currDate);

					ScenarioContext.Current["SYSTEMDATE"] = currDate;
					break;

				default:
					WaitFor(driver.FindElement(By.CssSelector(lnkLogout)));
					UIAction(lnkLogout, string.Empty, "a");
					WaitFor(driver.FindElement(By.CssSelector(lblTodaysDate)));
					DateTime PCSysTemDate = DateTime.Parse((driver.FindElement(By.CssSelector(lblTodaysDate)).Text).Substring(13));
					Console.WriteLine("App System Date: {0}", PCSysTemDate.ToString(format: "MM/dd/yyyy"));
					ScenarioContext.Current["SYSTEMDATE"] = PCSysTemDate.ToString(format: "MM/dd/yyyy");
					UIAction(lnkLogout, string.Empty, "a");
					break;

			}

		}
	}
}
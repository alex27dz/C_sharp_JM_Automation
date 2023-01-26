using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using HelperClasses;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactManagerPages.Pages.Common;
using BillingCenterPages.Pages.Common;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    public sealed class ContactManagerSteps : TestBase
    {

        [Given(@"I enter (.*) and (.*) on the CM Login page")]
        public void GivenIEnterSuAndCmOnTheCMLoginPage(string userName, string passWord)
        {
            CMLoginPage cmLogin = new CMLoginPage(getDriver());

			userName = System.Configuration.ConfigurationManager.AppSettings[userName];
			passWord = System.Configuration.ConfigurationManager.AppSettings[passWord];
			if (userName.ToString() == string.Empty)
			{
				Assert.Fail("UserName can't be empty or null");
			}
			else
			{
				if (ScenarioContext.Current.ContainsKey("GWCMUSER") == false)
				{
					ScenarioContext.Current.Add("GWCMUSER", userName);
				}
				else
				{
					if (ScenarioContext.Current["GWCMUSER"].ToString() != userName)
					{
						ScenarioContext.Current["GWCMUSER"] = userName;
					}
				}
			}
			cmLogin.LoginIntoCM(userName, passWord);
		}

        [Given(@"I select (.*) from Actions Menu")]
        public void GivenISelectNewPersonPersonFromActionsMenu(string menuOption)
        {
            CMLoginPage cmLogin = new CMLoginPage(getDriver());

            //cmLogin.LoginIntoCM(userName, passWord);
        }

        [Given(@"I click search on Contacts Tab")]
        public void GivenIClickSearchOnContactsTab()
        {
            CMHomePage clickSearch = new CMHomePage(getDriver());
            clickSearch.NavigateTabBar("Contacts", "Search");
        }

        [Given(@"I verify below search details on search page")]
        public void GivenIVerifyBelowSearchDetailsOnSearchPage(Table table)
        {
            CMSearchPage EnterSearchPageDetails = new CMSearchPage(getDriver());
            EnterSearchPageDetails.SearchContactPageDetails(table);
        }
    }
}

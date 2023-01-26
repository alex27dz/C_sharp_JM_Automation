using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SupportCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCommonCore;

namespace PolicyCenterPages.Pages.CreateAccount
{
    public class EnterAccountInformation : Page
    {
        string CompanyName = "input[id$=':Name']";

        string FirstName = "input[id$=':FirstName']";

        string LastName = "input[id$=':LastName']";

        string searchBtn = "span[id$=':Search_link']";

        string srchResultsCreateNewAccDownArrow = "a[id$=':NewAccountButton_arrow']";

        string newAccountPerson = "a[id$=':NewAccount_Person']";

        string newAccountCompany = "a[id$=':NewAccount_Company']";
        public EnterAccountInformation(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(FirstName);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(FirstName));
        }

        public void SearchPersonalAccount(string firstName, string lastName)
        {

            UIAction(FirstName , firstName , "textbox" );

            UIAction(LastName , lastName , "textbox" );

            pause();

            UIAction(searchBtn , string.Empty, "span" );

            pause();

            UIAction(srchResultsCreateNewAccDownArrow , string.Empty, "a" );

            UIAction( newAccountPerson , string.Empty, "a" );

        }

        public void SearchCompany(string companyName)
        {

            UIAction(CompanyName, companyName, "textbox");

            System.Threading.Thread.Sleep(2000);

            UIAction(searchBtn, string.Empty , "span");

            System.Threading.Thread.Sleep(2000);

            UIAction(srchResultsCreateNewAccDownArrow, string.Empty , "a");
            System.Threading.Thread.Sleep(2000);
            UIAction(newAccountCompany, string.Empty , "a");
            System.Threading.Thread.Sleep(2000);
        }
    }
}

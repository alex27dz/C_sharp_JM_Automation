using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;
using HelperClasses;

namespace PolicyCenter9Pages.Pages.CreateAccount
{
	public class EnterAccountInformation_PC9 : Page
	{
		string CompanyName = "input[id$=':NewAccountSearchDV:GlobalContactNameInputSet:Name-inputEl']";

		string FirstName = "input[id$=':NewAccountSearchDV:GlobalPersonNameInputSet:FirstName-inputEl']";

		string LastName = "input[id$=':NewAccountSearchDV:GlobalPersonNameInputSet:LastName-inputEl']";

		string searchBtn = "a[id$=':NewAccountSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";

		string srchResultsCreateNewAcct = "span[id='NewAccount:NewAccountScreen:NewAccountButton-btnInnerEl']";

		string newAccountPerson = "span[id$=':NewAccountScreen:NewAccountButton:NewAccount_Person-textEl']";

		string newAccountCompany = "span[id$=':NewAccountScreen:NewAccountButton:NewAccount_Company-textEl']";

		string PrimaryEmail = "input[id$=':EmailAddress1-inputEl']";
		public EnterAccountInformation_PC9(IWebDriver driver) : base(driver)
		{

		}

		public override void VerifyPage()
		{
			VerifyUIElementIsDisplayed(FirstName);
		}

		public override void WaitForLoad()
		{
			IsElementPresent(driver, By.CssSelector(FirstName));
		}


		public void SearchCompany(string companyName)
		{
			UIAction(CompanyName, companyName, "textbox");
			UIAction(searchBtn, string.Empty, "span");
			WaitUntilElementVisible(driver, By.CssSelector(srchResultsCreateNewAcct));
			WaitFor(driver.FindElement(By.CssSelector(srchResultsCreateNewAcct))).Click();
			WaitUntilElementInvisible(driver, By.CssSelector(PrimaryEmail));
			UIAction(newAccountCompany, string.Empty, "a");
			WaitUntilElementVisible(driver, By.CssSelector(PrimaryEmail));
		}


		public void SearchPersonalDetail(string firstName, string lastName)
        {
            UIAction(FirstName, firstName, "textbox");
            UIAction(LastName, lastName, "textbox");
            UIActionExt(By.CssSelector(searchBtn), "click");
            UIActionExt(By.CssSelector(srchResultsCreateNewAcct), "Sync");
            UIActionExt(By.CssSelector(srchResultsCreateNewAcct), "click");
            UIActionExt(By.CssSelector(newAccountPerson), "click");
            UIActionExt(By.CssSelector(PrimaryEmail), "Sync");
        }
    }
}

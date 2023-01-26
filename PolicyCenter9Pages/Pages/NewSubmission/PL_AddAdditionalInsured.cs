using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using WebCommonCore;
using Microsoft.Win32;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class PL_AddAdditionalInsured : Page
	{
		string btnAddIns = "span[id$=':NamedInsuredInputSet:NamedInsuredsLV_tb:AddContactsButton-btnInnerEl']";
		//string btnAddCompany = "span[id$=':NamedInsuredInputSet:NamedInsuredsLV_tb:AddContactsButton:0:ContactType-textEl']";
		string btnAddPerson = "span[id$=':NamedInsuredInputSet:NamedInsuredsLV_tb:AddContactsButton:1:ContactType-textEl']";

		string txtFirstName = "input[id$=':PolicyContactDetailsDV:PolicyContactRoleNameInputSet:GlobalPersonNameInputSet:FirstName-inputEl']";
		string txtLastName = "input[id$=':PolicyContactDetailsDV:PolicyContactRoleNameInputSet:GlobalPersonNameInputSet:LastName-inputEl']";

		string AddressLine1 = "input[id$=':AddressLine1-inputEl']";
		string City = "input[id$=':City-inputEl']";
		string ZipCode = "input[id$=':PostalCode-inputEl']";
		string State = "input[id$=':State-inputEl']";


		string btnOK = "span[id$=':ContactDetailScreen:ForceDupCheckUpdate-btnInnerEl']";
		string btnNext = "span[id$=':Next-btnInnerEl']";

		public void AddAdditionalInsured(Table table)
		{
			string AIFirstName, AILastName, AICompanyName;
			RegistryKey RegKey;
			for (int i = 0; i <= table.RowCount - 1; i++)
			{
				UIAction(btnAddIns, string.Empty, "a");
				switch (table.Rows[i]["AddType"].ToLower().Trim())
				{
					case "newperson":
						UIAction(btnAddPerson, string.Empty, "a");
						AIFirstName = table.Rows[i]["FirstName"] + GetUniqueValue();
						AILastName = table.Rows[i]["LastName"] + GetUniqueValue();
						RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
						RegKey.SetValue("PL_ADDITIONAL_INSURED", AIFirstName + " " + AILastName);

						WaitUntilElementVisible(driver, By.CssSelector(txtFirstName));
						UIAction(txtFirstName, AIFirstName, "textbox");
						UIAction(txtLastName, AILastName, "textbox");
						break;
					case "newcompany":
						//UIAction(btnAddCompany, string.Empty, "a");
						//WaitUntilElementVisible(driver, By.CssSelector(txtRelPriNameIns));

						//AIFirstName = table.Rows[i]["FirstName"] + GetUniqueValue();
						//AICompanyName = table.Rows[i]["CompanyName"] + GetUniqueValue();
						//RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
						//RegKey.SetValue("CL_ADDITIONAL_INSURED", AICompanyName);
						//UIAction(txtCompanyName, AICompanyName, "textbox");
						//switch (table.Rows[i]["IsJeweler"].ToLower().Trim())
						//{
						//	case "yes":
						//		UIAction(radioIsJewelerTrue, string.Empty, "a");
						//		break;
						//	default:
						//		UIAction(radioIsJewelerFalse, string.Empty, "a");
						//		break;
						//}
						//break;
					default:
						break;
				}

				UIAction(AddressLine1, table.Rows[0]["AddrLine1"], "textbox");
				UIAction(City, table.Rows[0]["City"], "textbox");
				driver.FindElement(By.CssSelector(City)).SendKeys(Keys.Tab);

				driver.FindElement(By.CssSelector(State)).Click();
				driver.FindElement(By.CssSelector(State)).Clear();
				UIAction(State, table.Rows[0]["State"], "textbox");
				driver.FindElement(By.CssSelector(State)).SendKeys(Keys.Tab);
				WaitUntilElementVisible(driver, By.CssSelector(State + "[value='" + table.Rows[0]["State"] + "']"));

				if (IsElementPresent(driver, By.CssSelector(ZipCode)) == false)
				{
					WaitUntilElementVisible(driver, By.CssSelector(ZipCode));
				}
				UIAction(ZipCode, table.Rows[0]["ZipCode"], "textbox");
				driver.FindElement(By.CssSelector(City)).SendKeys(Keys.Tab);
				WaitUntilElementVisible(driver, By.CssSelector(ZipCode + "[value^='" + table.Rows[0]["ZipCode"] + "']"));
				UIAction(btnOK, string.Empty, "a");
				WaitUntilElementVisible(driver, By.CssSelector(btnNext));
			}

		}
		public string GetUniqueValue()
		{
			DateTime myDateTime = DateTime.Now;
			string day = myDateTime.Day.ToString();
			string hour = myDateTime.Hour.ToString();
			string minute = myDateTime.Minute.ToString();
			string second = myDateTime.Second.ToString();
			string GetUniqueValue = day + hour + minute + second;
			return GetUniqueValue;
		}
		public PL_AddAdditionalInsured(IWebDriver driver) : base(driver)
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



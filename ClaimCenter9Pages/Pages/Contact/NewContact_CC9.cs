using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class NewContact_CC9 : Page
    {
        string btnNewContact = "a[id$=':ClaimContacts_CreateNewContactButton']";
		string btnUpdate = "a[id$=':CustomUpdateButton']";
        string btnAdd = "a[id$=':Add']";
        string txtFirstName = "input[id$=':FirstName-inputEl']";
        string txtLastName = "input[id$=':LastName-inputEl']";
        string txtTaxID = "input[id$=':AdditionalInfoInputSet:TaxID-inputEl']";
        string txtComapnyTaxID = "input[id$=':ContactBasicsDV:V_EIN-inputEl']";
        string txtCompanyName = "input[id$=':GlobalContactNameInputSet:Name-inputEl']";


        public NewContact_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnNewContact);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNewContact));
        }


        public void verifyContactManagerIntegeration()
        {
            string tempvalue = "";
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.Id("ClaimContacts:ClaimContactsScreen:PeopleInvolvedDetailedListDetail:PeopleInvolvedDetailedLV-body")).ToList();
            Console.WriteLine("div object count is " + reservetableObj.Count());
            var table = reservetableObj[0].FindElements(By.TagName("table"));
            Console.WriteLine("table object count is " + table.Count());

            for (int tablecount = 0; tablecount < table.Count(); tablecount++)
            {
                var row = table[tablecount].FindElements(By.TagName("tr"));
                Console.WriteLine("row object count is " + row.Count() + " fortable counter " + tablecount);

                var cell = row[0].FindElements(By.TagName("td"));
                Console.WriteLine("cell object count is " + cell.Count() + " fortable counter " + tablecount);

                for (int cellcount = 0; cellcount < cell.Count(); cellcount++)
                {
                    var tempDiv = cell[cellcount].FindElements(By.TagName("div"));

                    System.Console.WriteLine("count for tempDiv is " + tempDiv.Count());
                    //string tempName = 
                    try
                    {
                       
                        System.Console.WriteLine(" text  is " + tempDiv[0].Text);
                        tempvalue = tempDiv[0].Text;
                        if (tempvalue.Length>0)
                        {
                            if (tempvalue.ToLower().Trim().Equals(ScenarioContext.Current["INSURED"].ToString().ToLower().Trim()))
                            {
                                row[0].Click();
                                pause();
                                break;

                            }

                        }

                     }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(" exception for  cell counter " + cellcount + " is " + e);
                    }
                }


            }


            //Verify CC CM Integration 
            pause();
            List<IWebElement> lstContactManagerSync = driver.FindElements(By.XPath("//div[@id='ClaimContacts:ClaimContactsScreen:PeopleInvolvedDetailedListDetail:ContactBasicsDV:ContactBasicsHeaderInputSet:LinkStatusMessage-inputEl']")).ToList();
            if (lstContactManagerSync.Count > 0)
            {
                if (lstContactManagerSync[0].Text != "This contact is linked to the Address Book and is in sync")
                {
                    Assert.Fail("Claim Center integration with Contact Manager broke");
                }
            }
            else
            {
                Assert.Fail("Claim Center integration with Contact Manager broke");
            }
            Console.WriteLine("CC and CM Integration Passed");



        }

        public void AddContactType(string menuOption)
        {

            UIAction(btnNewContact, string.Empty, "a");
            IWebElement IWSelectEmail;
            pause();

            switch (menuOption.ToLower().Trim())
            {
                case "person":
                    IWSelectEmail = driver.FindElement(By.XPath("//span[text()= 'Person']"));
                    JavaScriptClick(IWSelectEmail);
                    break;
                case "vendor":
                    IWSelectEmail = driver.FindElement(By.XPath("//span[text()= 'Vendor']"));
                    JavaScriptClick(IWSelectEmail);
                    break;
                case "company":
                    IWSelectEmail = driver.FindElement(By.XPath("//span[text()= 'Company']"));
                    JavaScriptClick(IWSelectEmail);
                    break;
                case "legal":
                    IWSelectEmail = driver.FindElement(By.XPath("//span[text()= 'Legal']"));
                    JavaScriptClick(IWSelectEmail);
                    break;
                case "vendor:jeweler":
                    IWebElement IWSelectPerson = driver.FindElement(By.XPath("//span[text()= 'Person']"));
                    IWSelectEmail = driver.FindElement(By.XPath("//span[text()= 'Vendor']"));
					JavaScriptClick(IWSelectEmail);
					driver.FindElement(By.XPath("//span[text()= 'Vendor']")).SendKeys(Keys.ArrowRight);
                    IWSelectEmail = driver.FindElement(By.XPath("//span[text()= 'Jeweler']"));
                    JavaScriptClick(IWSelectEmail);
                    break;
                default:
                    break;
            }


        }

        public void AddContactRole(string menuOption)
        {

            WaitUntilElementIsDisplayed(driver, By.XPath("//a[id$=':Add']"));
			UIActionExt(By.CssSelector(btnAdd), "click");
			string tblReserve = "div[id$=':ContactBasicsHeaderInputSet:EditableClaimContactRolesLV-body']";
			List<IWebElement> reservetableObj = driver.FindElement(By.CssSelector(tblReserve)).FindElements(By.TagName("table")).ToList();
			Console.WriteLine("table object count is " + reservetableObj.Count());
            var rows = reservetableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[0].FindElements(By.TagName("td"));
            Console.WriteLine("cell count is " + tds.Count());
			JavaScriptClick(tds[2]);
			tds[2].SendKeys(menuOption);
			tds[2].SendKeys(Keys.LeftShift+Keys.Tab);
		}

        public void AddCompanyContactDetails(string CompanyName, string TaxID)
        {
            RegistryKey RegKey;
            if (CompanyName.ToUpper().Trim() == "UNIQUE")
            {
                CompanyName = "Jeweler" + GetUniqueValue();
                RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                RegKey.SetValue("CC_Jeweler", CompanyName);
            }
			UIActionExt(By.CssSelector(txtCompanyName), "Text", CompanyName);
			UIActionExt(By.CssSelector(txtComapnyTaxID), "Text", TaxID);
			UIActionExt(By.CssSelector(btnUpdate), "click");
			WaitUntilElementInvisible(driver, By.CssSelector("input[name='Role']"), 30);
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector("span[id$=':DuplicateContact_CancelButton-btnInnerEl']"), 30);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			if (driver.FindElements(By.XPath("//span[@id='DuplicateContactPopup:ttlBar'][text()='Duplicate Contact Found']")).ToList().Count > 0)
			{
				driver.FindElement(By.CssSelector("span[id$=':DuplicateContact_CancelButton-btnInnerEl']")).Click();
				UIActionExt(By.CssSelector(btnUpdate), "ispresent");
				UIAction(btnUpdate, string.Empty, "a");
			}
		}
		public void AddPersonalContactDetails(string FirstName, string LastName, string TaxID)
        {
			string txtAddr1 = "input[id$=':AddressLine1-inputEl']";
			string txtCity = "input[id$=':City-inputEl']";
			string txtZipCode = "input[id$=':PostalCode-inputEl']";
			string lststate = "input[id$=':State-inputEl']";

			UIActionExt(By.CssSelector(txtFirstName), "ispresent");
			UIActionExt(By.CssSelector(txtFirstName), "Text", FirstName);
			UIActionExt(By.CssSelector(txtLastName), "Text", LastName);
			UIActionExt(By.CssSelector(txtTaxID), "Text", TaxID);
			UIActionExt(By.CssSelector(txtAddr1), "Text", "48 Jewelers Park Dr");
			UIActionExt(By.CssSelector(txtCity), "Text", "Neenah");
			UIActionExt(By.CssSelector(lststate), "List", "Wisconsin");
			UIActionExt(By.CssSelector(txtZipCode), "ispresent");
			UIActionExt(By.CssSelector(txtZipCode), "List", "54956");
			UIActionExt(By.CssSelector(txtZipCode), "ispresent");
			if (IsElementPresent(driver, By.XPath("//div[text()[contains(.,'Verified')]]"))==false)
			{
				UIActionExt(By.CssSelector("span[id$=':verifyAddress_JMIC-btnInnerEl']"), "click");
				UIActionExt(By.XPath("//div[text()[contains(.,'Verified')]]"), "ispresent");
			}
			UIActionExt(By.CssSelector(btnUpdate), "click");
			WaitUntilElementInvisible(driver, By.CssSelector("input[name='Role']"), 30);
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector("span[id$=':DuplicateContact_CancelButton-btnInnerEl']"), 30);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			if (driver.FindElements(By.XPath("//span[@id='DuplicateContactPopup:ttlBar'][text()='Duplicate Contact Found']")).ToList().Count > 0)
			{
				driver.FindElement(By.CssSelector("span[id$=':DuplicateContact_CancelButton-btnInnerEl']")).Click();
				UIActionExt(By.CssSelector(btnUpdate), "ispresent");
				UIAction(btnUpdate, string.Empty, "a");
			}
		}

        public void AddCLContactRole(string menuOption)
        {
			string AddContactTable = "div[id$=':ContactBasicsDV:ContactBasicsHeaderInputSet:EditableClaimContactRolesLV-body']";

			WaitUntilElementIsDisplayed(driver, By.XPath("//a[id$=':Add']"));
			UIActionExt(By.CssSelector(btnAdd), "click");
			UIActionExt(By.CssSelector(AddContactTable), "ispresent");
			IWebElement tblContact = driver.FindElement(By.CssSelector(AddContactTable));
			IList<IWebElement> tblTDContact = tblContact.FindElements(By.TagName("td")).ToList();
			DoubleClick(driver,tblTDContact[2]);
			UIActionExt(By.CssSelector("input[name='Role']"), "ispresent");
			UIActionExt(By.CssSelector("input[name='Role']"), "List", menuOption);
		}


		public void AddJewelryContactDetails(string CompanyName, string TaxID)
        {
            string txtJewelerName = "input[id$='ContactDetailScreen:ContactBasicsDV:OrganizationName-inputEl']";
			RegistryKey RegKey;
            string txtAddr1 = "input[id$=':AddressLine1-inputEl']";
            string txtCity = "input[id$=':City-inputEl']";
            string txtZipCode = "input[id$=':PostalCode-inputEl']";
            string lststate = "input[id$=':State-inputEl']";

            UIActionExt(By.CssSelector(txtAddr1), "Text", "48 Jewelers Park Dr");
            UIActionExt(By.CssSelector(txtCity), "Text", "Neenah");
            UIActionExt(By.CssSelector(lststate), "List", "Wisconsin");
            UIActionExt(By.CssSelector(txtZipCode), "ispresent");
            UIActionExt(By.CssSelector(txtZipCode), "List", "54956");
            UIActionExt(By.CssSelector(txtZipCode), "ispresent");
            if (CompanyName.ToUpper().Trim() == "UNIQUE")
            {
                CompanyName = "Jeweler" + GetUniqueValue();
                RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                RegKey.SetValue("CC_Jeweler", CompanyName);
            }
			UIActionExt(By.CssSelector(txtJewelerName), "ispresent");
			UIActionExt(By.CssSelector(txtJewelerName), "Text", CompanyName);
			UIActionExt(By.CssSelector(txtComapnyTaxID), "Text", TaxID);
			UIActionExt(By.CssSelector(btnUpdate), "ispresent");
			UIActionExt(By.CssSelector(btnUpdate), "click");
			WaitUntilElementInvisible(driver, By.CssSelector("input[name='Role']"), 30);
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector("span[id$=':DuplicateContact_CancelButton-btnInnerEl']"), 30);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
			}
			if (driver.FindElements(By.XPath("//span[@id='DuplicateContactPopup:ttlBar'][text()='Duplicate Contact Found']")).ToList().Count > 0)
			{
				driver.FindElement(By.CssSelector("span[id$=':DuplicateContact_CancelButton-btnInnerEl']")).Click();
                //add addresses
                Console.WriteLine("Add New contact address");
                AddNewContactAddress();
                Console.WriteLine("New contact address added");
                UIActionExt(By.CssSelector(btnUpdate), "ispresent");
				UIAction(btnUpdate, string.Empty, "a");
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

        public void AddNewContactAddress()
        {
            //Add address
            string AddressLine1 = "input[id$=':AddressLine1-inputEl']";
            string City = "input[id$=':City-inputEl']";
            string ZipCode = "input[id$=':PostalCode-inputEl']";
            string State = "input[id$=':State-inputEl']";
            string Country = "input[id$=':Country-inputEl']";
            UIActionExt(By.CssSelector(AddressLine1), "Text", "1981 Kings Rd");
            UIActionExt(By.CssSelector(City), "List", "Jacksonville");
            UIActionExt(By.CssSelector(State), "List", "Florida");
           // UIActionExt(By.CssSelector(Country), "List", "United States of America");
            UIActionExt(By.CssSelector(ZipCode), "List", "32209");
        }
    }
}

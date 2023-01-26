using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
namespace PolicyCenterPages.Pages.NewSubmission
{
    public class PL_AddAdditionalInsured : Page
    {
        string btnNext = "a[id='SubmissionWizard:Next']";
        //string btAddAI = "a[id$=:NamedInsuredInputSet:NamedInsuredsLV_tb:AddContactsButton]";
        string btnAddAIArrow = "a[id$=':AddContactsButton_arrow']";
        string btnAddCompany = "a[id$=':NamedInsuredInputSet:NamedInsuredsLV_tb:AddContactsButton:0:ContactType']";
        string btnAddPerson = "a[id$=':NamedInsuredInputSet:NamedInsuredsLV_tb:AddContactsButton:1:ContactType']";
        string btnOK = "a[id$=':ForceDupCheckUpdate']";
        string txtCompanyName = "input[id$=':CompanyName']";
        string radioIsJewelerTrue = "input[id$=':IsAccountHolderJeweler_true']";
        string radioIsJewelerFalse = "input[id$=':IsAccountHolderJeweler_false']";
        string txtFirstName = "input[id$=':PolicyContactDetailsDV:PolicyContactRoleNameInputSet:FirstName']";
        string txtLastName = "input[id$=':PolicyContactDetailsDV:PolicyContactRoleNameInputSet:LastName']";
        string AddressLine1 = "input[id$=':AddressLine1']";
        string City = "input[id$=':City']";
        string State = "select[id$=':State']";
        string ZipCode = "NewAdditionalNamedInsuredPopup:ContactDetailScreen:NewPolicyContactRoleDetailsCV:PolicyContactDetailsDV:AddressInputSet:PostalCode";
        string VerifyAddress = "a[id$=':verifyAddress_JMIC']";
        public PL_AddAdditionalInsured(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void AddAdditionalInsured(Table table)
        {
            string AIFirstName, AILastName, AICompanyName;
            RegistryKey RegKey;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                WaitUntilElementVisible(driver, By.CssSelector(btnAddAIArrow));
                UIAction(btnAddAIArrow, string.Empty, "a");
                pause();

                switch (table.Rows[i]["AddType"].ToLower().Trim())
                {
                    case "newperson":
                        UIAction(btnAddPerson, string.Empty, "a");
                        WaitForEnabled(driver.FindElement(By.CssSelector(AddressLine1)));
                        AIFirstName = table.Rows[i]["FirstName"] + GetUniqueValue();
                        AILastName = table.Rows[i]["LastName"] + GetUniqueValue();
                        RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                        RegKey.SetValue("PL_ADDITIONAL_INSURED", AIFirstName + " " + AILastName);

                        UIAction(txtFirstName, AIFirstName, "textbox");
                        UIAction(txtLastName, AILastName, "textbox");
                        break;
                    case "newcompany":
                        UIAction(btnAddCompany, string.Empty, "a");
                        WaitForEnabled(driver.FindElement(By.CssSelector(AddressLine1)));
                        AIFirstName = table.Rows[i]["FirstName"] + GetUniqueValue();
                        AICompanyName = table.Rows[i]["CompanyName"] + GetUniqueValue();
                        RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                        RegKey.SetValue("CL_ADDITIONAL_INSURED", AICompanyName);
                        UIAction(txtCompanyName, AICompanyName, "textbox");
                        switch (table.Rows[i]["IsJeweler"].ToLower().Trim())
                        {
                            case "yes":
                                UIAction(radioIsJewelerTrue, string.Empty, "a");
                                break;
                            default:
                                UIAction(radioIsJewelerFalse, string.Empty, "a");
                                break;
                        }
                        break;
                    default:
                        break;
                }

                UIAction(AddressLine1, table.Rows[i]["AddrLine1"], "textbox");
                UIAction(City, table.Rows[i]["City"], "textbox");
                UIAction(State, table.Rows[i]["State"], "selectbox");
                js.ExecuteScript("document.getElementById('" + ZipCode + "').value='" + table.Rows[i]["ZipCode"] + "'");
                pause();
                UIAction(VerifyAddress, string.Empty, "a");
                pause();
                UIAction(btnOK, string.Empty, "a");
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

    }
}

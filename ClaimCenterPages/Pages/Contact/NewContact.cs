using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenterPages.Pages.CreateClaim
{
    public class NewContact : Page
    {
        string btnNewContact = "a[id$=':ClaimContacts_CreateNewContactButton']";

        string newContactButtonArrow = "a[id$=':ClaimContacts_CreateNewContactButton_arrow']";

        string newContactPerson = "a[id$=':ClaimContacts_CreateNewContactButton:ClaimContacts_NewPerson']";

        string btnUpdate = "a[id$=':Update']";

        string btnAdd = "a[id$=':Add']";

        string selRole = "select[id$=':EditableClaimContactRolesLV:0:Role']";

        string txtFirstName = "input[id$=':FirstName']";

        string txtLastName = "input[id$=':LastName']";

        string txtTaxID = "input[id$=':AdditionalInfoInputSet:TaxID']";

        public NewContact(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnNewContact);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNewContact));
        }

        public void AddContactType(string menuOption)
        {
            UIAction(newContactButtonArrow, string.Empty, "a");

            pause();

            switch (menuOption.ToLower().Trim())
            {
                case "person":
                    UIAction(newContactPerson, string.Empty, "a");

                    break;
                default:
                    break;
            }


        }

        public void AddContactRole(string menuOption)
        {

            UIAction(btnAdd, string.Empty, "a");

            pause();

            pause();

            pause();

            UIAction(selRole, menuOption, "selectbox");

        }

        public void AddContactDetails(string FirstName, string LastName, string TaxID)
        {
            UIAction(txtFirstName, FirstName, "textbox");

            UIAction(txtLastName, LastName, "textbox");

            UIAction(txtTaxID, TaxID, "textbox");

            UIAction(btnUpdate, string.Empty, "a");
        }



    }
}

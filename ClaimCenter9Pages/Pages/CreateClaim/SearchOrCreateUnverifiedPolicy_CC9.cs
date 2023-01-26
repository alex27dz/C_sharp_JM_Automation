using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class SearchOrCreateUnverifiedPolicy_CC9 : Page
    {
        string policyNumber = "input[id$='policySearch:policyNumber-inputEl']";
        string btnSearch = "a[id$=':FNOLWizardFindPolicyPanelSet:policySearch:Search']";
        string txtClaimLossData = "input[id$=':Claim_LossDate-inputEl']";
        string btnNext = "a[id='FNOLWizard:Next']";

        string txtClaimsMadeDate = "input[id$=':ClaimsMadeDate-inputEl']";
        string txtDateofNotice = "input[id$=':Notification_ReportedDate-inputEl']";
		string txtPolicyType = "input[id$=':Type-inputEl']";
		string ChckboxLegacyPolicy = "input[id$=':Claim_IsClaimForLegacyPolicy-inputEl']";
		string txtLossDate = "input[id$=':Claim_LossDate-inputEl']";
        string txtEffectiveDate = "input[id$=':EffectiveDate-inputEl']";
        string txtExpirationDate = "input[id$=':ExpirationDate-inputEl']";
        string linkInsuredOption = "a[id$=':Insured_Name:Insured_NameMenuIcon']";
        string menuOptionperson = "span[id$=':NewContactPickerMenuItemSet_NewPerson-textEl']";
        string btnupdate = "span[id$=':CustomUpdateButton-btnInnerEl']";

        public SearchOrCreateUnverifiedPolicy_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(policyNumber);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$='policySearch:policyNumber-inputEl']"));
        }

        public void SearchLegecyPolicy(string PolicyNumber)
        {
			UIActionExt(By.CssSelector(policyNumber), "Text", PolicyNumber);
			UIActionExt(By.CssSelector(btnSearch), "click");
			UIActionExt(By.XPath("//a[text()[.='Select']]"),"ispresent");
            List<IWebElement> tblMutltilePolicies = driver.FindElements(By.XPath("//a[text()[.='Select']]")).ToList();
            System.Console.WriteLine("Count is " + tblMutltilePolicies.Count());
            if (tblMutltilePolicies.Count > 0)
                tblMutltilePolicies[tblMutltilePolicies.Count() - 1].Click();
        }
        public void SearchPolicy(string PolicyNumber)
        {
			UIActionExt(By.CssSelector(policyNumber), "Text", PolicyNumber);
			UIActionExt(By.CssSelector(btnSearch), "click");
			WaitUntilElementInvisible(driver, By.CssSelector(btnupdate),30);
            List<IWebElement> tblMutltilePolicies = driver.FindElements(By.XPath("//a[@id='FNOLWizard:FNOLWizard_FindPolicyScreen:FNOLWizardFindPolicyPanelSet:policySearch:PolicyResultLV:0:selectButton']")).ToList();
			if (tblMutltilePolicies.Count > 0)
				tblMutltilePolicies[0].Click();
		}

        public void EnterNewClaimDetails(string LossDate, string TypeOfClaim)
        {
			UIActionExt(By.CssSelector(txtClaimLossData), "ispresent");
			UIActionExt(By.CssSelector(txtClaimLossData), "Text", LossDate);
            switch (TypeOfClaim.ToLower().Trim())
            {
                case "property":
					UIActionExt(By.XPath("//label[text()= 'Property']"), "click");
					break;
                case "commerciallinequickclaim":
					UIActionExt(By.XPath("//label[text()= 'Commercial Line - Quick Claim']"), "click");
					break;
                case "commercialclaim":
					UIActionExt(By.XPath("//label[text()= 'Commercial Line']"), "click");
					break;
                default:
                    break;
            }
            pause();
			UIActionExt(By.XPath("//a[@id= 'FNOLWizard:Next']"), "click");
			//UIActionExt(By.XPath("//a[@id= 'FNOLWizard:Next']"), "ispresent");
			//UIActionExt(By.XPath("//a[@id= 'FNOLWizard:Next']"), "click");
		}

		public void EnterNewClaimDetails(string LossDate, string TypeOfClaim, string ClaimsMadeClaim)
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$='FNOLWizard:FNOLWizard_FindPolicyScreen:FNOLWizardFindPolicyPanelSet:Claim_LossDate-inputEl']"));
            switch (ClaimsMadeClaim.ToLower().Trim())
            {
                case "yes":
                case "true":
					UIActionExt(By.XPath("//input[@id= 'FNOLWizard:FNOLWizard_FindPolicyScreen:SERP_Select-inputEl']"), "click");

                    break;
                default:
                    break;
            }
			UIActionExt(By.CssSelector(txtClaimLossData), "Text", LossDate);
			UIActionExt(By.CssSelector(txtClaimsMadeDate), "Text", LossDate);
			UIActionExt(By.CssSelector(txtDateofNotice), "Text", LossDate);
            switch (TypeOfClaim.ToLower().Trim())
            {
                case "property":
					UIActionExt(By.XPath("//label[text()= 'Property']"), "click");
					break;
                case "commerciallinequickclaim":
					UIActionExt(By.XPath("//label[text()= 'Commercial Line - Quick Claim']"), "click");
					break;
                case "commercialclaim":
					UIActionExt(By.XPath("//label[text()= 'Commercial Line']"), "click");
                    break;
                default:

                    break;
            }
			UIActionExt(By.CssSelector(btnNext), "click");
        }

        public void CreateUnverfiedPolicy(string PolicyType, string FirstName, string Lastname, string Address1, string Zip, string legcyPolicyNumber)
        {
            DateTime date = DateTime.Now;
            string LossDate = string.Format("{0:MM/dd/yyyy}", date);
            string EffectiveDate = string.Format("{0:MM/dd/yyyy}", date.AddMonths(-1));
            string ExpirationDate = string.Format("{0:MM/dd/yyyy}", date.AddYears(1));
            string radioCreateUnverifiedPolicy = "input[id$='FNOLWizard:FNOLWizard_FindPolicyScreen:ScreenMode_false-inputEl']";
            Console.WriteLine("LossDate is " + LossDate);
            Console.WriteLine("EffectiveDate is " + EffectiveDate);
            Console.WriteLine("ExpirationDate is " + ExpirationDate);


            WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$='FNOLWizard:FNOLWizard_FindPolicyScreen:ScreenMode_false-inputEl']"));
			UIActionExt(By.CssSelector(radioCreateUnverifiedPolicy), "click");

			WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$='FNOLWizard:FNOLWizard_FindPolicyScreen:FNOLWizardFindPolicyPanelSet:Type-inputEl']"));
			UIActionExt(By.CssSelector(txtPolicyType), "Text", PolicyType);

            WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$='FNOLWizard:FNOLWizard_FindPolicyScreen:FNOLWizardFindPolicyPanelSet:Claim_LossDate-inputEl']"));
			UIActionExt(By.CssSelector(ChckboxLegacyPolicy), "click");
			UIActionExt(By.CssSelector(legcyPolicyNumber), "Text", legcyPolicyNumber);

			UIActionExt(By.CssSelector(txtLossDate), "Text", LossDate);
			UIActionExt(By.CssSelector(txtEffectiveDate), "Text", LossDate);
			UIActionExt(By.CssSelector(txtExpirationDate), "Text", LossDate);
			UIActionExt(By.CssSelector(linkInsuredOption), "click");
			UIActionExt(By.CssSelector(menuOptionperson), "click");

			updateNewPerson(FirstName, Lastname, Address1, Zip);
			WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$='FNOLWizard:FNOLWizard_FindPolicyScreen:ScreenMode_false-inputEl']"));
			UIActionExt(By.CssSelector(btnNext), "click");

		}

		public void updateNewPerson(string firstname, string lastName, string address1, string zipcode)
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[id$='NewContactPopup:ContactDetailScreen:ContactBasicsDV_tb:ContactDetailToolbarButtonSet:CustomUpdateButton-btnInnerEl']"));
			
			string txtFirstName = "input[id$=':FirstName-inputEl']";
			string txtLastName = "input[id$=':LastName-inputEl']";
			string txtAddress1 = "input[id$ =':AddressLine1-inputEl']";
			string txtZip = "input[id$ =':PostalCode-inputEl']";

			UIActionExt(By.CssSelector(txtFirstName), "Text", firstname);
			UIActionExt(By.CssSelector(txtLastName), "Text", lastName);
			UIActionExt(By.CssSelector(txtAddress1), "Text", address1);
			UIActionExt(By.CssSelector(txtZip), "List", zipcode);
			UIActionExt(By.CssSelector(txtZip), "ispresent");
			UIActionExt(By.CssSelector(btnupdate), "click");
        }
    }
}

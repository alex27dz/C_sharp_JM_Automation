using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class FNOLSaveAndAssignClaim_CC9 : Page
    {
        string btnFinish = "span[id='FNOLWizard:Finish-btnInnerEl']";
        public FNOLSaveAndAssignClaim_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnFinish);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[id='FNOLWizard:Finish-btnInnerEl']"));
        }
       

		public void FinishClaimInformation()
		{
			string lblClaimNumber = "label[id='NewClaimSaved:NewClaimSavedScreen:NewClaimSavedDV:Header']";
			string lnkGotoClaim = "div[id='NewClaimSaved:NewClaimSavedScreen:NewClaimSavedDV:GoToClaim-inputEl']";
			UIActionExt(By.CssSelector(btnFinish), "click");

			WaitUntilElementVisible(driver, By.CssSelector(lblClaimNumber));
			IWebElement IWClaimNumber = driver.FindElement(By.CssSelector(lblClaimNumber));
			Console.WriteLine(IWClaimNumber.Text);
			string ClaimNumber = IWClaimNumber.Text.Replace("Claim ", string.Empty).Replace(" has been successfully saved.", string.Empty);

			if (ClaimNumber != null)
			{
				Console.WriteLine("Claim Number: " + ClaimNumber);
				DataStorage tempData = new DataStorage();
				tempData.StoreTempValue("guidewire", "CLAIMNO", ClaimNumber);
				if (ScenarioContext.Current.ContainsKey("CLAIM") == false)
				{
					ScenarioContext.Current.Add("CLAIM", ClaimNumber);
				}
				else
				{
					ScenarioContext.Current["CLAIM"] = ClaimNumber;
				}
				UIActionExt(By.CssSelector(lnkGotoClaim), "click");
			}
			else
			{
				Assert.Fail("Unable to create Claim");
			}
		}

	}
}

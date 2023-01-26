using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenter9.Pages.CreateClaim
{
    public class FNOLStep2CLQuickClaim_CC9 : Page
    {
        string btnCancel = "span[id='FNOLWizard:Cancel-btnInnerEl']";
        string btnFinish = "span[id='FNOLWizard:Finish-btnInnerEl']";
        string lstReportedByName = "input[id$=':QuickClaimDV:ReportedBy_Name-inputEl']";
        string lstRelationToInsured = "input[id$=':QuickClaimDV:Claim_ReportedByType-inputEl']";
        string lstLossCause = "input[id$=':QuickClaimDV:Claim_LossCause-inputEl']";
        string lstSecLossCause = "input[id$=':QuickClaimDV:SecondaryLossCause-inputEl']";
        string lblinsuredName = "div[id$=':QuickClaimDV:Insured_Name-inputEl']";
        string txtClaimDesciption = "textarea[id$=':QuickClaimDV:Claim_Description-inputEl']";
        string radioIncidentTrueOnly = "input[id$=':QuickClaimDV:Status_IncidentReport_true-inputEl']";
        string radioIncidentFalseOnly = "input[id$=':QuickClaimDV:Status_IncidentReport_false-inputEl']";
        string radioCoverageQTrueOnly = "input[id$=':QuickClaimDV:Status_CoverageQuestion_true-inputEl']";
        string radioCoverageQFalseOnly = "input[id$=':QuickClaimDV:Status_CoverageQuestion_false-inputEl']";
        string txtDateOfNotice = "input[id$=':QuickClaimDV:Notification_ReportedDate-inputEl']";
        string lblClaimNumber = "label[id='NewClaimSaved:NewClaimSavedScreen:NewClaimSavedDV:Header']";
        string lnkGotoClaim = "div[id='NewClaimSaved:NewClaimSavedScreen:NewClaimSavedDV:GoToClaim-inputEl']";
        public FNOLStep2CLQuickClaim_CC9(IWebDriver driver) : base(driver)
        {
        }
        public override void VerifyPage()
        {

        }
        public override void WaitForLoad()
        {

        }
        public void CLQuickClaimDetails(Table table)
        {
			WaitUntilElementVisible(driver, By.CssSelector(btnCancel));
			DataStorage tempData = new DataStorage();
			string tempLossDate = tempData.GetTempValue("TESTINGSYSTEMCLOCK");
            string sDateOfNotice = table.Rows[0]["DateOfNotice"];
			UIActionExt(By.CssSelector(lblinsuredName), "ispresent");
			List<IWebElement> PageInputElements;
            PageInputElements = driver.FindElements(By.CssSelector(lblinsuredName)).ToList();
			string sInsuredName = PageInputElements[0].Text;
            Console.WriteLine("Insured Name: " + sInsuredName);
            if (sInsuredName != string.Empty)
            {
                if (ScenarioContext.Current.ContainsKey("INSURED") == false)
                {
                    ScenarioContext.Current.Add("INSURED", sInsuredName);
                }
            }

			UIActionExt(By.CssSelector(lstReportedByName), "List", sInsuredName);
			UIActionExt(By.CssSelector(lstRelationToInsured), "List", table.Rows[0]["RelatedToInsured"]);
			UIActionExt(By.CssSelector(txtClaimDesciption), "Text", table.Rows[0]["Description"]);
			UIActionExt(By.CssSelector(lstLossCause), "List", table.Rows[0]["LossCause"]);
			if (table.Rows[0]["SecondaryLossCause"].ToString() !=string.Empty)
			{
				UIActionExt(By.CssSelector(lstSecLossCause), "List", table.Rows[0]["SecondaryLossCause"]);
			}
            switch (table.Rows[0]["IncidentOnly"].ToString().ToLower().Trim())
            {
                case "yes":
					UIActionExt(By.CssSelector(radioIncidentTrueOnly), "click");
					break;
                default:
					UIActionExt(By.CssSelector(radioIncidentFalseOnly), "click");
					break;
            }
            switch (table.Rows[0]["CoverageInQuestion"].ToString().ToLower().Trim())
            {
                case "yes":
					UIActionExt(By.CssSelector(radioCoverageQTrueOnly), "click");
					break;
                default:
					UIActionExt(By.CssSelector(radioCoverageQFalseOnly), "click");
					break;
            }
            switch (sDateOfNotice.ToUpper().Trim())
            {
                case "TESTINGSYSTEMCLOCK":
                case "SYSTEMDATE":
					UIActionExt(By.CssSelector(txtDateOfNotice), "List", tempLossDate);
					break;
                default:
					UIActionExt(By.CssSelector(txtDateOfNotice), "List", sDateOfNotice);
					break;
            }
        }
        public void ClickFinishButton()
        {
			UIActionExt(By.CssSelector(btnFinish), "click");
			WaitUntilElementInvisible(driver, By.CssSelector(lblClaimNumber), 15);
			try
			{
				WaitUntilElementVisible(driver, By.CssSelector(btnFinish), 10);
			}
			catch (Exception e)
			{
				Console.WriteLine("Caught exception : " + e);
			}
			List<IWebElement> IbtnFinish = driver.FindElements(By.CssSelector(btnFinish)).ToList();
			if (IbtnFinish.Count() > 0)
				UIActionExt(By.CssSelector(btnFinish), "click");
		}
		public void SaveAndGotoClaim()
        {
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

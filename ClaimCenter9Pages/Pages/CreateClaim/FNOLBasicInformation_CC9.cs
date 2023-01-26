using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class FNOLBasicInformation_CC9 : Page
    {
        string lblinsuredName = "div[id$=':NewClaimPeopleDV:Insured_Name-inputEl']";
        string btnNext = "a[id='FNOLWizard:Next']";
        string ReportedByName = "input[id$=':ReportedBy_Name-inputEl']";
        string RelatedToInsured = "input[id$=':Claim_ReportedByType-inputEl']";

        public FNOLBasicInformation_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(ReportedByName);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$=':ReportedBy_Name-inputEl']"));
        }

        public void EnterBasicInformation(string ReportedName, string RelationToInsured)
        {
			UIActionExt(By.CssSelector(ReportedByName), "ispresent");
			string sInsuredName = "";
			List<IWebElement> PageInputElements;
			PageInputElements = driver.FindElements(By.CssSelector(lblinsuredName)).ToList();
			sInsuredName = PageInputElements[0].Text;
			Console.WriteLine("Insured Name: " + sInsuredName);
			if (sInsuredName != string.Empty)
			{
				if (ScenarioContext.Current.ContainsKey("INSURED") == false)
				{
					ScenarioContext.Current.Add("INSURED", sInsuredName);
				}
			}
			UIActionExt(By.CssSelector(ReportedByName), "List", sInsuredName);
			UIActionExt(By.CssSelector(RelatedToInsured), "List", RelationToInsured);
			UIActionExt(By.CssSelector(btnNext), "click");
        }

    }
}

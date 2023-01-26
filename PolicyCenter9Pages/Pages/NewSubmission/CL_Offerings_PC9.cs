using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_Offerings_PC9 : Page
	{
		string selOfferingSelection = "input[id$=':OfferingScreen:OfferingSelection-inputEl']";
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string tblLineSelection = "div[id$=':CPPLineSelectionScreen:CPPLineSelectionDV:1-body']";
		string lblOffering = "a[id$=':JobWizardInfoBar:OfferingLabel']";
		public void SelectOffering(Table table)
		{
			UIActionExt(By.CssSelector(selOfferingSelection), "List", table.Rows[0]["Offering"]);
			UIActionExt(By.CssSelector(lblOffering), "ispresent", "", 0, 12, 5);

			ClickNext();
		}
		public void ClickNext()
		{
			UIActionExt(By.CssSelector(btnNext), "click");
			UIActionExt(By.CssSelector(tblLineSelection), "ispresent");
		}

		public CL_Offerings_PC9(IWebDriver driver) : base(driver)
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

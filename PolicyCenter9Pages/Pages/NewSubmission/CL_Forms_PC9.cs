
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_Forms_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string txtBillingMethod = "input[id$=':BillingAdjustmentsDV:BillingMethod-inputEl']";
		public void VerifyFormsList()
		{
			string tblForms = "SubmissionWizard:FormsScreen:FormsDV:FormsLV-body";
			var drMainTable = driver.FindElement(By.Id(tblForms));
			List<IWebElement> lsGetTrElements = new List<IWebElement>(drMainTable.FindElements(By.TagName("tr")));
			if (lsGetTrElements.Count() <= 1)
			{
				Assert.Fail("Forms not available");
			}
			else
			{
				//Console.WriteLine("----------------Forms List:-----------------");
				//for (int i = 1; i < lsGetTrElements.Count(); i++)
				//{
				//	Console.WriteLine(i + "-----" + lsGetTrElements[i].Text);
				//}
				//Console.WriteLine("----------------Forms List:-----------------");
			}
			ClickNext();
		}
		public void ClickNext()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(txtBillingMethod));
		}
		public CL_Forms_PC9(IWebDriver driver) : base(driver)
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


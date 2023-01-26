
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using WebCommonCore;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace PolicyCenter9Pages.Pages.CreateAccount
{
	public class CL_Qualification_PC9 : Page
	{
		string PolicySignatureDate = "input[id$=':PolicyInfoCLDetailsInputSet:SignatureDate-inputEl']";
		string btnNext = "span[id$=':Next-btnInnerEl']";

		public void selectQualitifications(string sRadioOption)
		{
			if (sRadioOption.ToLower() == "no")
			{
				sRadioOption = "false";
			}
			else if (sRadioOption.ToLower() == "yes")
			{
				sRadioOption = "true";
			}
			SelectQuestions(sRadioOption);
			//try
			//{
				UIAction(btnNext, string.Empty, "span");
				WaitUntilElementVisible(driver, By.CssSelector(PolicySignatureDate), 5);
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine("Exception Caught: " + e);
			//	if (IsElementPresent(driver, By.CssSelector("div[class='message']")) == true)
			//	{
			//		Console.WriteLine("SecondTime");
			//		SelectQuestions(sRadioOption);
			//		UIAction(btnNext, string.Empty, "span");
			//		WaitUntilElementVisible(driver, By.CssSelector(PolicySignatureDate), 5);
			//	}
			//}
		}


		public void SelectQuestions(string sRadioOption)
		{
			string sID = "";
			List<IWebElement> tblAllRows = new List<IWebElement>(driver.FindElements(By.CssSelector("input[inputvalue='" + sRadioOption + "']")));
			for (int i = 0; i < tblAllRows.Count; i++)
			{
				int dLoop = 6;
				bool ElementClicked = false;
				do
				{
					dLoop = dLoop - 1;
					try
					{
						List<IWebElement> tblRadioBtn = new List<IWebElement>(driver.FindElements(By.CssSelector("input[inputvalue='" + sRadioOption + "']")));
						sID = tblRadioBtn[i].GetAttribute("id");
						WaitForEnabled(tblRadioBtn[i]);
						tblRadioBtn[i].Click();
						JavaScriptClick(tblRadioBtn[i]);
						if (i == 0)
						{
							WaitUntilElementInvisible(driver, By.Id(sID), 3);
						}
						ElementClicked = true;
					}
					catch (Exception e)
					{
						Console.WriteLine("@row {0}, loop {1}, Exception Caught: {2}", i, dLoop, e);
					}
				} while ((dLoop == 0) || (ElementClicked == false));
			}
		}


		public CL_Qualification_PC9(IWebDriver driver) : base(driver)
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

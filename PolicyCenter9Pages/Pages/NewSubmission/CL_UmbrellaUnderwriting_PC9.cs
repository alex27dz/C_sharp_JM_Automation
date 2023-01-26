using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using WebCommonCore;
using OpenQA.Selenium.Support.UI;

namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_UmbrellaUnderwriting_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lblLineLCovg = "label[id$=':CPPLineReviewScreen:ReviewSummaryCV:PolicyLineSummaryPanelSet:LineDV:0']";
		public void BOUmbrellaUnderwritingDetails(string sRadioOption)
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
			try
			{
				UIAction(btnNext, string.Empty, "span");
				WaitUntilElementVisible(driver, By.CssSelector(lblLineLCovg), 5);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception Caught: " + e);
				if (IsElementPresent(driver, By.CssSelector("div[class='message']")) == true)
				{
					Console.WriteLine("SecondTime");
					SelectQuestions(sRadioOption);
					UIAction(btnNext, string.Empty, "span");
					WaitUntilElementVisible(driver, By.CssSelector(lblLineLCovg), 5);
				}
			}
		}

		public void SelectQuestions(string sRadioOption)
		{
			for (int i = 0; i < 5; i++)
			{
				int dLoop = 6;
				bool ElementClicked = false;
				do
				{
					dLoop = dLoop - 1;
					try
					{
						List<IWebElement> tblRadioBtn = new List<IWebElement>(driver.FindElements(By.CssSelector("input[inputvalue='" + sRadioOption + "']")));
						string sID = tblRadioBtn[i].GetAttribute("id");
						JavaScriptClick(tblRadioBtn[i]);
						WaitUntilElementInvisible(driver, By.Id(sID), 1);
						ElementClicked = true;
					}
					catch (Exception e)
					{
						Console.WriteLine("@row {0}, loop {1}, Exception Caught: {2}", i, dLoop, e);
					}
				} while ((dLoop == 0) || (ElementClicked == false));
			}
		}
		public CL_UmbrellaUnderwriting_PC9(IWebDriver driver) : base(driver)
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


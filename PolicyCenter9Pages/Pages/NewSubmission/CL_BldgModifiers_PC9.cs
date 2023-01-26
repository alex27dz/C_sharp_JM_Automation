
using OpenQA.Selenium;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_BldgModifiers_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lnkLRBuilding = "a[id$=':ReviewSummaryCV:PolicyLineSummaryPanelSet:0:BuildingsDV:0:BuildingDetails']";
		public void ClickNext()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lnkLRBuilding));
		}
		public CL_BldgModifiers_PC9(IWebDriver driver) : base(driver)
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



using OpenQA.Selenium;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_Modifiers_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lnkLRLocs = "a[id$=':ilmLocation:0:BuildingsDV:LocationDetails']";
		public void ModifiersNext()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lnkLRLocs));
		}
		public CL_Modifiers_PC9(IWebDriver driver) : base(driver)
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

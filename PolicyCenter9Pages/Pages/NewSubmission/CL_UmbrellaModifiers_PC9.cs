using OpenQA.Selenium;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{

	public class CL_UmbrellaModifiers_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lblUMBUnderwriting = "label[id$=':UMBWizardStepGroup:UMBUnderwritingScreen:QuestionSetsDV:0:0']";
		public void ClickNext()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lblUMBUnderwriting));
		}
		public CL_UmbrellaModifiers_PC9(IWebDriver driver) : base(driver)
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


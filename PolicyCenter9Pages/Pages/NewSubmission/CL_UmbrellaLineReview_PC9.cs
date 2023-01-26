using OpenQA.Selenium;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{

	public class CL_UmbrellaLineReview_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string btnReqAppl = "span[id$=':RiskAnalysisCV_tb:RequestApproval-btnInnerEl']";
		public void ClickNext()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(btnReqAppl));
		}
		public CL_UmbrellaLineReview_PC9(IWebDriver driver) : base(driver)
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


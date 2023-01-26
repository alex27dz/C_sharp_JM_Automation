
using OpenQA.Selenium;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_BldgLineReview_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string txtUMBLmt = "input[id$=':UMBLineStandardCoveragesDV:0:0:UMBCoverageInputSet:CovPatternInputGroup:UMBLimit-inputEl']";
		string btnReqAppl = "span[id$=':RiskAnalysisCV_tb:RequestApproval-btnInnerEl']";
		public void ClickNext_ST()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(txtUMBLmt));
		}
		public void ClickNext_NoUMB()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(btnReqAppl));
		}
		public CL_BldgLineReview_PC9(IWebDriver driver) : base(driver)
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


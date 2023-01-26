
using OpenQA.Selenium;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{

	public class CL_LineReview_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string txtBOAnnAgg = "input[id$=':0:CoverageInputSet:CovPatternInputGroup:CyberAnnualAggregate-inputEl']";
		string btnReqAppl = "span[id$=':RiskAnalysisCV_tb:RequestApproval-btnInnerEl']";
		public void LineReviewNext_ST()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(txtBOAnnAgg));
		}
		public void CL_LineReviewNextNoUMB()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(btnReqAppl));

		}
		public CL_LineReview_PC9(IWebDriver driver) : base(driver)
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

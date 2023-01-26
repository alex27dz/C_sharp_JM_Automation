using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.Common
{
    public class CCLossDetailsPage_CC9 : Page
    {
        [FindsBy(How = How.Id, Using = "ClaimLossDetails:ClaimLossDetailsScreen:LossDetailsPanelSet:LossDetailsCardCV:LossDetailsDV:CoverageInQuestion_true-boxLabelEl")]
        public IWebElement radioCoverageinQuestionYes;

        [FindsBy(How = How.Id, Using = "ClaimLossDetails:ClaimLossDetailsScreen:LossDetailsPanelSet:LossDetailsCardCV:LossDetailsDV:CoverageInQuestion_false-inputEl")]
        public IWebElement radioCoverageinQuestionNo;

        [FindsBy(How = How.Id, Using = "ClaimLossDetails:ClaimLossDetailsScreen:Edit-btnEl")]
        public IWebElement btnEdit;

        [FindsBy(How = How.Id, Using = "ClaimLossDetails:ClaimLossDetailsScreen:Update-btnInnerEl")]
        public IWebElement btnUpdate;

        public CCLossDetailsPage_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[id$= 'ClaimLossDetails:ClaimLossDetailsScreen:Edit-btnEl']"));
        }

      public void updateCoverageinQuestion(string CoverageinQuestion)
        {
            JavaScriptClick(btnEdit);
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[id$= 'ClaimLossDetails:ClaimLossDetailsScreen:Update-btnInnerEl']"));
            if (CoverageinQuestion.ToLower().Trim().Equals("no"))
            {
                JavaScriptClick(radioCoverageinQuestionNo);
            }
            else
            {
                JavaScriptClick(radioCoverageinQuestionYes);
            }
            JavaScriptClick(btnUpdate);
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[id$= 'ClaimLossDetails:ClaimLossDetailsScreen:Edit-btnEl']"));
        }


      
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace PolicyCenterPages.Pages.NewSubmission
{
    public class PL_RiskAnalysis : Page
    {
        //string btnNext = "a[id='SubmissionWizard:Next']";
        string btnNext = "a[id$=':Next']";
        string tabConviction = "a[id$=':RiskAnalysisCV:ConvictionsTab']";
        string radioCaonvictedOfFelonyTrue = "input[id$=':ConvictionsDV:ConvictedOfFelony_Input_true']";
        string radioCaonvictedOfFelonyFalse = "input[id$=':ConvictionsDV:ConvictedOfFelony_Input_false']";

        string radioCaonvictedOfMisdemeanorTrue = "input[id$=':ConvictionsDV:ConvictedOfMisdemeanor_Input_true']";
        string radioCaonvictedOfMisdemeanorFalse = "input[id$=':ConvictionsDV:ConvictedOfMisdemeanor_Input_false']";

        string btnAddSentence = "a[id$=':ConvictionsDV:ConvictionsPanelLV_tb:Add']";


        public PL_RiskAnalysis(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnNext);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void ClickNext()
        {
            pause();

            UIAction(btnNext, string.Empty, "a");
        }
        public void UpdateConvictionDetails(string ConvictedFelony, string ConvictedMisdemeanor)
        {
            pause();
            UIAction(tabConviction, string.Empty, "a");
            pause();
            if (ConvictedFelony.ToLower().Equals("no"))
            {
                UIAction(radioCaonvictedOfFelonyFalse, string.Empty, "a");
            }
            else if (ConvictedFelony.ToLower().Equals("yes"))
            {
                UIAction(radioCaonvictedOfFelonyTrue, string.Empty, "a");
            }



            if (ConvictedMisdemeanor.ToLower().Equals("no"))
            {
                UIAction(radioCaonvictedOfMisdemeanorFalse, string.Empty, "a");
            }
            else if (ConvictedMisdemeanor.ToLower().Equals("yes"))
            {
                UIAction(radioCaonvictedOfMisdemeanorTrue, string.Empty, "a");
            }

        }

        public void UpdateSentenceCompilationDetails(string SentenceCompilationDate, string ConvictionType, string OtherConvictionType, int Itemcounter)
        {
            UIAction(btnAddSentence, string.Empty, "a");
            //string txtSentenceCompletionDate = "input[id=': ConvictionsDV: ConvictionsPanelLV: " + Itemcounter + ":SenetenceDate']";
            //string selectConvictionType = "select[id$=': ConvictionsDV: ConvictionsPanelLV: " + Itemcounter + ":ConvictionType_JMIC']";
            //string txtareaOtherConvictionType = "textarea[id$=': ConvictionsDV: ConvictionsPanelLV: " + Itemcounter + ":OtherConvictionType']";

            string SentenceCompletionDateId = "SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:ConvictionsLV:ConvictionsDV:ConvictionsPanelLV:" + Itemcounter + ":SenetenceDate";
            string ConvictionTypeId = "SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:ConvictionsLV:ConvictionsDV:ConvictionsPanelLV:" + Itemcounter + ":ConvictionType_JMIC";
            string AreaOtherConvictionTypeId = "SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:ConvictionsLV:ConvictionsDV:ConvictionsPanelLV:" + Itemcounter + ":OtherConvictionType";

            IWebElement txtSentenceCompletionDate = driver.FindElement(By.Id(SentenceCompletionDateId));
            IWebElement selectConvictionType = driver.FindElement(By.Id(ConvictionTypeId));
            IWebElement txtareaOtherConvictionType = driver.FindElement(By.Id(AreaOtherConvictionTypeId));



            pause();
            txtSentenceCompletionDate.SendKeys(SentenceCompilationDate);
            selectConvictionType.SendKeys(ConvictionType);
            txtareaOtherConvictionType.SendKeys(OtherConvictionType);
            //UIAction(txtSentenceCompletionDate, SentenceCompilationDate, "textbox");
            //UIAction(selectConvictionType, ConvictionType, "selectbox");
            //UIAction(txtareaOtherConvictionType, OtherConvictionType, "textbox");

        }
    }
}

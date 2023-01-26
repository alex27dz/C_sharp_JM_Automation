using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;
using HelperClasses;

namespace PolicyCenter9Pages.Pages.JPA
{
    public class AdditionalDetailsPC9 : Page
    {
        string lblAdditionalDetaisl = "span[id$=':JPAAdditionalDetailsScreen:ttlBar']";
        string labelConsumerReportConsentNo = "input[Id$=':ApplicationConsentGivenId_false-inputEl']";
        string labelConsumerReportConsentYes = "input[Id$=':ApplicationConsentGivenId_true-inputEl']";
        string labelFaudWarningConsentYes = "input[Id$=':ApplicationStamntId_true-inputEl']";
        string labelFaudWarningConsentNo = "input[Id$=':ApplicationStamntId_true-inputEl']";
        string labelPossessionofItemYes = "";
        string labelPossessionofItemNo = "";
        string btnNextArticlesItem = "span[id$=':Next-btnInnerEl']";
        string lblAdditionaldetails = "span[id$= ':JPAAdditionalDetailsScreen:ttlBar']";
        public AdditionalDetailsPC9(IWebDriver driver) : base(driver)
        {


        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblAdditionalDetaisl);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblAdditionalDetaisl));
        }

        public void ClickNextButton()
        {
            UIAction(btnNextArticlesItem, string.Empty, "a");
            // WaitUntilElementVisible(driver, By.CssSelector(lblAdditionaldetails), 120);

        }

        public void updateAdditionalDetails(string PossessionofItem, string FaudWarningConsent, string ConsumerReportConsent)
        {
            if (PossessionofItem.Length > 1)
            {
                List<IWebElement> reservetableObj;
                reservetableObj = driver.FindElements(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:JPAAdditionalDetailsScreen:JPAAdditionalDetailsPanelSet:SupplemenetalQuestionSetsDV:QuestionSetsDV:0:QuestionSetLV-body")).ToList();
                System.Console.WriteLine("reservetableObj count is " + reservetableObj.Count());
                var rows = reservetableObj[0].FindElements(By.TagName("input"));
                System.Console.WriteLine("row count is " + rows.Count());
                int rocCount = rows.Count();

                switch (PossessionofItem.ToUpper().Trim())
                {
                    case "YES":

                        Console.WriteLine("for yes value");
                        JavaScriptClick(rows[0]);
                        break;
                    case "NO":
                        Console.WriteLine("for no value");
                        JavaScriptClick(rows[1]);
                        break;
                }
            }
            switch (FaudWarningConsent.ToUpper().Trim())
            {
                case "YES":
                    Console.WriteLine("for yes value");
                    JavaScriptClick(driver.FindElement(By.CssSelector(labelFaudWarningConsentYes)));
                    break;
                case "NO":
                    Console.WriteLine("for no value");
                    JavaScriptClick(driver.FindElement(By.CssSelector(labelFaudWarningConsentNo)));
                    break;
            }

            switch (ConsumerReportConsent.ToUpper().Trim())
            {
                case "YES":
                    Console.WriteLine("for yes value");
                    JavaScriptClick(driver.FindElement(By.CssSelector(labelConsumerReportConsentYes)));
                    break;
                case "NO":
                    Console.WriteLine("for no value");
                    JavaScriptClick(driver.FindElement(By.CssSelector(labelConsumerReportConsentNo)));
                    break;


            }

        }

        public void updateAdditionalDetailsPolicyChange(string PossessionofItem, string FaudWarningConsent, string ConsumerReportConsent)
        {
            if (PossessionofItem.Length > 1)
            {
                List<IWebElement> reservetableObj;
                reservetableObj = driver.FindElements(By.Id("PolicyChangeWizard:LOBWizardStepGroup:LineWizardStepSet:JPAAdditionalDetailsScreen:JPAAdditionalDetailsPanelSet:SupplemenetalQuestionSetsDV:QuestionSetsDV:0:QuestionSetLV-body")).ToList();
                System.Console.WriteLine("reservetableObj count is " + reservetableObj.Count());
                var rows = reservetableObj[0].FindElements(By.TagName("input"));
                System.Console.WriteLine("row count is " + rows.Count());
                int rocCount = rows.Count();

                switch (PossessionofItem.ToUpper().Trim())
                {
                    case "YES":

                        Console.WriteLine("for yes value");
                        JavaScriptClick(rows[0]);
                        break;
                    case "NO":
                        Console.WriteLine("for no value");
                        JavaScriptClick(rows[1]);
                        break;
                }
            }
            switch (FaudWarningConsent.ToUpper().Trim())
            {
                case "YES":
                    Console.WriteLine("for yes value");
                    JavaScriptClick(driver.FindElement(By.CssSelector(labelFaudWarningConsentYes)));
                    break;
                case "NO":
                    Console.WriteLine("for no value");
                    JavaScriptClick(driver.FindElement(By.CssSelector(labelFaudWarningConsentNo)));
                    break;
            }

            switch (ConsumerReportConsent.ToUpper().Trim())
            {
                case "YES":
                    Console.WriteLine("for yes value");
                    JavaScriptClick(driver.FindElement(By.CssSelector(labelConsumerReportConsentYes)));
                    break;
                case "NO":
                    Console.WriteLine("for no value");
                    JavaScriptClick(driver.FindElement(By.CssSelector(labelConsumerReportConsentNo)));
                    break;


            }

        }

    }
}

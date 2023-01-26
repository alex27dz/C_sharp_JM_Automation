using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;
using HelperClasses;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenter9Pages.Pages.JPA
{
    public class PolicyContactsPC9 : Page
    {
        string txtcontactFirstName = "input[id$= ':FirstName-inputEl']";
        string txtcontactLastName = "input[id$= ':LastName-inputEl']";
        string txtcontactDOB = "input[id$= ':DateOfBirth-inputEl']";
        string txtcontactReleationship = "input[id$= ':RelationshipToPrimaryInsured-inputEl']";
        string txtcontactLocation = "input[id$= 'Location-inputEl']";


        string btnAddcontact = "span[id$= ':Add-btnInnerEl']";
        string btnNext = "a[id$= ':Next']";
        string lblPolicyContacts = "span[id$= ':PolicyContactScreen:ttlBar']";
        string txtDOB = "input[id$= ':PolicyContactInputSet:DateOfBirth-inputEl']";
        string lblDeniedCoverageyes = "label[id$= ':PolicyContactInputSet:Iscoveragedenied_true-boxLabelEl']";
        string lblDeniedCoverageno = "label[id$= ':PolicyContactInputSet:Iscoveragedenied_false-boxLabelEl']";
        string selDeniedCoveragereason = "input[id$ =':PolicyContactInputSet:Denialreasons-inputEl']";
        //   SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PolicyContactScreen:PolicyContactPanelSet:PolicyContactRoleDP:PolicyContactCV:
        //    string selDeniedCoveragereasonwrap = "div[id$ =':PolicyContactInputSet:Denialreasons-inputWrap']";
        public PolicyContactsPC9(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyContacts);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyContacts));
        }

        public void updateDob(string DOB)
        {
            driver.FindElement(By.CssSelector(txtDOB)).Clear();
            UIAction(txtDOB, String.Empty, "a");
            UIAction(txtDOB, DOB, "textbox");
        }

        public void updaterelationship(string releation)
        {
            driver.FindElement(By.CssSelector(txtcontactReleationship)).Clear();
            UIAction(txtcontactReleationship, String.Empty, "a");
            UIAction(txtcontactReleationship, releation, "textbox");
        }

        public void updatelocation(string location)
        {
            driver.FindElement(By.CssSelector(txtcontactLocation)).Clear();
            UIAction(txtcontactLocation, String.Empty, "a");
            UIAction(txtcontactLocation, location, "textbox");
        }

        public void updateDeniedCoverage(string DeniedCoveragestat, string reason)
        {
            switch (DeniedCoveragestat.ToLower())
            {
                case "yes":
                    UIAction(lblDeniedCoverageyes, String.Empty, "a");

                    WaitUntilElementVisible(driver, By.XPath("//span[text()[contains(.,'Reason')]]"), 20);
                    driver.FindElement(By.XPath("//span[text()[contains(.,'Reason')]]")).Click();
                    //   driver.FindElement(By.XPath("//span[text()[contains(.,'Reason')]]")).Clear();
                    driver.FindElement(By.XPath("//input[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PolicyContactScreen:PolicyContactPanelSet:PolicyContactRoleDP:PolicyContactCV:PolicyContactInputSet:Denialreasons-inputEl']")).Clear();

                    driver.FindElement(By.XPath("//input[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:PolicyContactScreen:PolicyContactPanelSet:PolicyContactRoleDP:PolicyContactCV:PolicyContactInputSet:Denialreasons-inputEl']")).SendKeys(reason);
                    //UIAction(selDeniedCoveragereasonwrap, String.Empty, "a");
                    //UIAction(selDeniedCoveragereason, reason, "textbox");

                    break;

                case "no":
                    UIAction(lblDeniedCoverageno, String.Empty, "a");
                    break;
            }
        }

        public void UpdateNewContactDetails(Table table)
        {

            string contactFirstName = table.Rows[0]["contactFirstName"];
            string contactLastName = table.Rows[0]["contactLastName"];
            //   string contactDOB = table.Rows[0]["contactDOB"];
            string contactReleationship = table.Rows[0]["contactReleationship"];
            string contactLocation = table.Rows[0]["contactLocation"];
            // string DeniedCoveragestat = table.Rows[0]["deniedcoverage"];
            //  string Reason = table.Rows[0]["reason"];


            UIAction(btnAddcontact, string.Empty, "span");
            pause();
            //    WaitUntilElementVisible(driver,By.XPath("//div[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:JPALocationsScreen:JPALocationsPanelSet:LocationDetailInputSet:LocationInfo-inputEl'][text()[contains(.,'<empty>')]"),100);
            UIAction(txtcontactFirstName, contactFirstName, "textbox");
            UIAction(txtcontactLastName, contactLastName, "textbox");

            updaterelationship(contactReleationship);
            updatelocation(contactLocation);

            System.Threading.Thread.Sleep(5000);
        }
        public void clickNextButton()
        {
            UIAction(btnNext, String.Empty, "a");
        }

        public void ClickOnRiskTab()
        {
            string rickTab = "span[id$=':PolicyContactCV:ContactRiskTab-btnInnerEl']";
            UIAction(rickTab, String.Empty, "span");
        }

        public void AddRecordsToManuallyReportTable(string recordDate, string convictionType, string convictionCategory)
        {
            string btnAdd = "a[id$=':PolicyContactPanelSet:PolicyContactRoleDP:PolicyContactCV:ContactConvictionLV_tb:Add']";
            string manuallyReportTableBody = "div[id$=':PolicyContactCV:ContactConvictionLV-body']";
            string inputRecordDate = "input[name$='ConvictionRecordDate']";
            string inputCovictionType = "input[name$='ConvictionType']";
            string inputCovictionCategory = "input[name$='ConvictionCategory']";

            // UIAction(btnAdd, String.Empty, "a");
            JavaScriptClick(driver.FindElement(By.CssSelector(btnAdd)));

            WaitFor(driver.FindElement(By.CssSelector(manuallyReportTableBody)));
            IWebElement blockBindBody = driver.FindElement(By.CssSelector(manuallyReportTableBody));
            List<IWebElement> tableElements = new List<IWebElement>(blockBindBody.FindElements(By.TagName("table")));
            Console.WriteLine(" tableElements Count " + tableElements.Count());
            List<IWebElement> lsGetTdElemets = new List<IWebElement>(tableElements[0].FindElements(By.TagName("td")));

            if (lsGetTdElemets.Count > 5)
            {
                EnterRecordData(inputRecordDate, lsGetTdElemets[1], recordDate, null);
                EnterRecordData(inputCovictionType, lsGetTdElemets[3], convictionType, null);
                EnterRecordData(inputCovictionCategory, lsGetTdElemets[4], convictionCategory, lsGetTdElemets[5]);
            }
            else
            {
                Assert.Fail("table has less columns");
            }
        }

        private void EnterRecordData(string inputLocator, IWebElement recordDataElement, string recordData, IWebElement nextElement)
        {
            JavaScriptClick(recordDataElement);
            recordDataElement.Click();
            UIAction(inputLocator, String.Empty, "a");
            UIAction(inputLocator, recordData, "textbox");

            if (nextElement != null)
            {
                JavaScriptClick(nextElement);
            }
        }
    }
}

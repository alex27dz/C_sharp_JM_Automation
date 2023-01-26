using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenterPages.Pages.CreateClaim
{
    public class NewDocument : Page
    {
        string btnNewContact = "a[id$=':ClaimContacts_CreateNewContactButton']";

        string btnCancel = "a[id$=':NewDocumentFromTemplate_CustomCancel']";

        string selectTemplatePicker = "a[id$=':SelectTemplatePicker']";

        string btnSearch = "span[id$=':Search_link']";

        string txtKeywords = "input[id$=':Keywords']";

        string btnSelect = "span[id$=':0:_Select_link']";

        string selSendTo = "select[id$=':NewTemplateDocumentDV:send_to']";

        string btnCreateDocument = "a[id$=':CreateDocument']";

        string btnFinish = "a[id$=':Finish']";

        string btnSubmitDocument = "a[id$=':SubmitDocument']";

        public NewDocument(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnCancel);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnCancel));
        }

        public void CreateNewDocument()
        {
            UIAction(selectTemplatePicker, string.Empty, "a");

            UIAction(txtKeywords, "Agent_Loss_Notice", "textbox");



            UIAction(btnSearch, string.Empty, "a");

            pause();

            UIAction(btnSelect, string.Empty, "a");

            UIAction(selSendTo, "1", "selectbox");

            UIAction(btnCreateDocument, string.Empty, "a");

            //UIAction(btnFinish, string.Empty, "a");

            pause();

            UIAction(btnSubmitDocument, string.Empty, "a");



        }

       

    }
}

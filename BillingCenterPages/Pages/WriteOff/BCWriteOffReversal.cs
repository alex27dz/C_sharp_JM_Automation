using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace BillingCenterPages.Pages.WriteOff
{
    public class BCWriteOffReversal : Page
    {
        string WriteoffReversalWizardTargetStep = "a[id='AccountNewWriteoffReversalWizard:NewWriteoffReversalAccountWriteoffsScreen:ttlBar']";

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffReversalWizard:Finish-btnInnerEl")]
        public IWebElement btnFinishWriteOffReversal;

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffReversalWizard:NewWriteoffReversalConfirmationScreen:NewWriteoffReversalConfirmationDV:Reason-inputEl")]

        public IWebElement txtWriteOffReversalReason;

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffReversalWizard:NewWriteoffReversalAccountWriteoffsScreen:WriteoffSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search")]

        public IWebElement btnSearchWriteOffReversal;

        [FindsBy(How = How.Id, Using = "AccountNewWriteoffReversalWizard:NewWriteoffReversalAccountWriteoffsScreen:NewWriteoffReversalWriteoffsLV:0:Select")]

        public IWebElement btnSelect;

        public BCWriteOffReversal(IWebDriver driver) : base(driver)
        {
            IsElementPresent(driver, By.CssSelector(WriteoffReversalWizardTargetStep));
        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {

        }

        public void WriteOffReversal(string WriteOffReversalReason)
        {
            btnSearchWriteOffReversal.Click();

            JavaScriptClick(btnSearchWriteOffReversal);

            pause();

            btnSelect.Click();

            pause();

            txtWriteOffReversalReason.Clear();

            txtWriteOffReversalReason.SendKeys(WriteOffReversalReason);

            btnFinishWriteOffReversal.Click();

            pause();

        }

    }
}


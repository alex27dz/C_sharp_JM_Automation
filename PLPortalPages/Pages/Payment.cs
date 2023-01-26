using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PLPortalPages.Pages
{
    public class Payment : Page
    {
        //Credit <a href="#" class="toggle-tabs" data-tab="tab-CC">Credit</a>
        //Echeck <a href="#" class="toggle-tabs" data-tab="tab-DD">E-Check</a>

        //string btnMakePayment    <a href="make-payment-wizard.action?CSRF_TOKEN=1531932166369-4ecb1e02bf19d4f248a16416d7a81343" class="btn-action">Make a Payment</a>
        //string btnManageWallet <a href="my-wallet.action?CSRF_TOKEN=1531932166369-4ecb1e02bf19d4f248a16416d7a81343" class="btn-action">Manage Wallet</a>
        //string btnAutoPay  <a href="schedules.action?CSRF_TOKEN=1531932166369-4ecb1e02bf19d4f248a16416d7a81343&amp;RQ_ENTRY_POINT=myAccounts" class="btn-action">AutoPay</a>
        //string btnBacktoAutoPay   <a href="schedules.action?CSRF_TOKEN=1531932454143-237bfb011900017e6840b72c70a15945" class="btn-action btn-mobile btn-back-schedules">Back to AutoPay</a>

        string btnContinue = "a[class='btn-action btn-type-next ']";
        string btnReturnPaymentSummary = "a[class='btn-action btn-type-back-to-payments ']";

        string radioPayNow = "div[id$='payNowOrLater-1']";
        string radioPayLater = "div[id$='payNowOrLater-2']";
        string txtPaymentDate = "div[id$='fromPayLaterBtn']";
        string linkAddPaymentMethod = "a[id$='pm-add-button']";

        string btnAddPaymentMethod = "a[class='btn-action modalAddPayment ']";
        string btnBackPaymentMethod = "a[class='btn-action btn-type-prev ']";
        string btnContinuePayment = "a[class='btn-action btn-type-next ']";
        string chckAgreTermCondition = "input[id$='acceptTermsAndConditions-1']";
        string btnConfirmPayment = "a[data-id$='btn-payment-confirmation']";
        string btnConfirmAutoPaySchedule = "a[data-id$='btn-schedule-confirm']";




        //Credit Card
        string txtCardNumber = "input[id$='add-cardNumberCC-1']";
        string txtcvvCC = "input[id$='add-cvvCC']";
        string txtexpiryDateMonth = "input[id$='add-expiryDateMonthCC']";
        string txtexpiryDateYearCC = "input[id$='add-expiryDateYearCC']";
        string txtcardHolderNameCC = "input[id$='add-cardHolderNameCC']";
        string txtzipCode = "input[id$='add-zipCode']";


        //Echeck 

        string radioChecking = "input[id$='add-radio-pmt-chq']";
        string radioSaving = "input[id$='add-radio-pmt-sav']";
        string txtroutingNumber = "input[id$='add-routingNumber']";
        string txtaccountNumber = "input[id$='add-accountNumber']";
        string txtbankName = "input[id$='add-bankName']";
        string txtaccountHolderName = "input[id$='add-accountHolderName']";
        string chckAuthorizeACHPayment = "input[id$='add-radio-ach-add']";




        public Payment(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(txtAppfirstName);
        }

        public override void WaitForLoad()
        {
        }

    }

}

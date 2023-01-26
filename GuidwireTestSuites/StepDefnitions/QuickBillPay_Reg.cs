
using QuickBillPayPages.Pages;
using TechTalk.SpecFlow;
using WebCommonCore;


namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class QuickBillPay_Reg : TestBase
    {
        [Given(@"I run sql query and update account and policy details for below scenario")]
        public void GivenIRunSqlQueryAndUpdateAccountAndPolicyDetailsForBelowScenario(Table table)
        {
            SQL_Queries RunSqlQuery = new SQL_Queries(getDriver());
            RunSqlQuery.getAccountNumberFromDb(table);
        }
        [When(@"I verify below details on Policy details page")]
        public void WhenIVerifyBelowDetailsOnPolicyDetailsPage(Table table)
        {
            BC_DetailsPage verifyBCDetailsPage = new BC_DetailsPage(getDriver());
            verifyBCDetailsPage.verifyDetailsPage(table);
        }
        [When(@"I save below details in Registry from Policy details page")]
        public void WhenISaveBelowDetailsInRegistryFromPolicyDetailsPage(Table table)
        {
            BC_DetailsPage SaveBCDetailsPage = new BC_DetailsPage(getDriver());
            SaveBCDetailsPage.UpdateRegistry(table);
        }

        [Given(@"I enter below details on Quick Bill Pay page and verify for Account Number")]
        public void GivenIEnterBelowDetailsOnQuickBillPayPageAndVerifyForAccountNumber(Table table)
        {
            QuickBillPayPage QBPPageDetails = new QuickBillPayPage(getDriver());
            QBPPageDetails.AddPrimaryInfo(table);
            QBPPageDetails.VerifyBackBtn();
            QBPPageDetails.verifyEmailZipAcct();
        }

        [Given(@"I enter below details on Quick Bill Pay page")]
        public void GivenIEnterBelowDetailsOnQuickBillPayPage(Table table)
        {
            QuickBillPayPage QBPPageDetails = new QuickBillPayPage(getDriver());
            QBPPageDetails.AddPrimaryInfo(table);
            QBPPageDetails.VerifyBackBtn();
        }

        [Given(@"I enter below details on Quick Bill Pay page and verify inactive active")]
        public void GivenIEnterBelowDetailsOnQuickBillPayPageAndVerifyInactiveActive(Table table)
        {
            QuickBillPayPage QBPPageDetails = new QuickBillPayPage(getDriver());
            QBPPageDetails.AddPrimaryInfo(table);
            QBPPageDetails.VerifyAccountInactive();
        }


        [Given(@"I select below Payment Amount")]
        public void GivenISelectBelowPaymentAmount(Table table)
        {
            ChoosePaymentAmt Choose = new ChoosePaymentAmt(getDriver());
            Choose.PaymentAmount(table);
        }
        [Given(@"I enter (.*) Payment Info and click on Continue button")]
        public void GivenIEnterBelowPaymentInfoAndClickOnContinueButton(string CCorACH)
        {
            EnterPaymentInfo Payment = new EnterPaymentInfo(getDriver());
            Payment.MakePayment(CCorACH);
        }

        [When(@"I verify (.*) and PaymentAmount on Payments Page")]
        public void WhenIVerifyAndPaymentAmountOnPaymentsPage(string CCorACH)
        {
            BC_DetailsPage VerifyBCDetailsPage = new BC_DetailsPage(getDriver());
            VerifyBCDetailsPage.verifyPayInstPayAmt(CCorACH);
        }

        [Given(@"I verify if PastDue is listed")]
        public void GivenIVerifyIfPastDueIsListed()
        {
            ChoosePaymentAmt Choose = new ChoosePaymentAmt(getDriver());
            Choose.verifyPastDueRadio();
        }

    }
}

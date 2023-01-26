using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Pages
{
    public class ReviewPage:Page
    {
        
        string checkHasAcknowledge = "//*[@id='HasAcknowledgedLegalTerms']";
        string checkAcceptPaperless = "//*[@id='AcceptPaperlessDelivery']";
        string btnContinueToPayment = "//*[@id=ContinueToPayment]";
        public ReviewPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();
            VerifyUIElementIsDisplayed(btnContinueToPayment);
        }

        public void acceptReviewPageTerms()
        {
            UIAction(checkHasAcknowledge, string.Empty, "checkbox");
            UIAction(checkAcceptPaperless, string.Empty, "checkbox");
            UIAction(btnContinueToPayment, string.Empty, "span");
        }
    }
}

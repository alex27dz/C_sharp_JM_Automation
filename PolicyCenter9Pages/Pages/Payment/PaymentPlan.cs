using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace PolicyCenter9Pages.Pages.Payment
{

    public class PaymentPlan : Page
    {
        string lblPayment = "span[id$= ':SubmissionWizard_PaymentScreen:ttlBar']";
        string XpathPaymentPalnTb = "//*[@id='SubmissionWizard:SubmissionWizard_PaymentScreen:BillingAdjustmentsDV:PaymentsPlanDV:PaymentsPlanInputSet:InstallmentPlan:BillingAdjustmentsInstallmentsLV-body']";

        public PaymentPlan(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPayment);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPayment));
        }

        public void VerifyIsPaymentPlan(int whichPlan)
        {
            IWebElement planTable = driver.FindElement(By.XPath(XpathPaymentPalnTb));
            List<IWebElement> lsGetTrElements = new List<IWebElement>(planTable.FindElements(By.TagName("table")));
            bool contain = false;
            System.Console.WriteLine("----------------Plan Table:-----------------");
            for (int i = 0; i < lsGetTrElements.Count(); i++)
            {
                string lineText = lsGetTrElements[i].Text;
                if (lineText.Contains(whichPlan + " Pay"))
                {
                    contain = true;
                }
            }
            if (!contain)
            {
                Assert.Fail(whichPlan + " pay is not in payment plan");
            }
        }

        public void VerifyNoPaymentPlan(int whichPlan)
        {
            IWebElement planTable = driver.FindElement(By.XPath(XpathPaymentPalnTb));
            List<IWebElement> lsGetTrElements = new List<IWebElement>(planTable.FindElements(By.TagName("table")));
            bool contain = false;
            System.Console.WriteLine("plan table rows: " + lsGetTrElements.Count());
            System.Console.WriteLine("----------------Plan Table:-----------------");
            for (int i = 0; i < lsGetTrElements.Count(); i++)
            {
                string lineText = lsGetTrElements[i].Text;
                if (lineText.Contains(whichPlan + " Pay"))
                {
                    System.Console.WriteLine("contain " + whichPlan + " Pay");
                    contain = true;
                }
            }
            if (contain)
            {
                Assert.Fail(whichPlan + " pay is not in payment plan");
            }
        }

        public void SelectPaymentPlan(int payTimes)
        {
            string datarecordindex = "";

            switch (payTimes)
            {
                case 2:
                    datarecordindex = "0";
                    break;
                case 4:
                    datarecordindex = "1";
                    break;
                case 9:
                    datarecordindex = "2";
                    break;
                default:
                    Assert.Fail("Please verify installment plan");
                    break;
            }

            IWebElement planTable = driver.FindElement(By.XPath(XpathPaymentPalnTb));
            List<IWebElement> TrAsTableElements = new List<IWebElement>(planTable.FindElements(By.TagName("table")));
            Console.WriteLine("TrAsTableElements.Count(): " + TrAsTableElements.Count());
            for (int i = 1; i < TrAsTableElements.Count(); i++)
            {
                IWebElement planSubTable = driver.FindElement(By.XPath(XpathPaymentPalnTb + "/div/div/table[" + i + "]"));
                List<IWebElement> TdElements = new List<IWebElement>(planSubTable.FindElements(By.TagName("td")));
                System.Console.WriteLine("----------------Plan Sub Table:-----------------");

                Console.WriteLine("payment plan is: " + TdElements[1].Text);
                if (TdElements[1].Text.ToLower().Contains(payTimes + " pay"))
                {
                    Console.WriteLine("this payment plan is " + payTimes);
                    string paymentxPath = "//table[@data-recordindex='" + datarecordindex + "']//td[1]/div/div";
                    driver.FindElement(By.XPath(paymentxPath)).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(paymentxPath)));
                    driver.FindElement(By.XPath(paymentxPath)).SendKeys(Keys.Space);
                    //JavaScriptClick(TdElements[0]);
                    break;
                }
            }

        }

    }
}

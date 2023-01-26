using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace QuickBillPayPages.Pages
{
    public class ChoosePaymentAmt : Page
    {
        public void PaymentAmount(Table table)
        {
            string sPaymentAmt = table.Rows[0]["Option"];
            string lnkPastDue = "input[data-description='Amount Past Due']";
            string lnkOutStanding = "input[data-description='Total Outstanding Balance']";
            string lnkYearly = "input[data-description='Total Yearly Balance']";

            switch (sPaymentAmt.ToUpper())
            {
                case "AMOUNTPASTDUE":
                    UIActionExt(By.CssSelector(lnkPastDue), "ispresent");
                    UIActionExt(By.CssSelector(lnkPastDue), "click");
                    float PasDueAmount = float.Parse(driver.FindElement(By.CssSelector(lnkPastDue)).GetAttribute("data-amount"), CultureInfo.InvariantCulture.NumberFormat);
                    float TotOutstandingAmount = float.Parse(driver.FindElement(By.CssSelector(lnkOutStanding)).GetAttribute("data-amount"), CultureInfo.InvariantCulture.NumberFormat);
                    if (TotOutstandingAmount > PasDueAmount)
                    {
                        UIActionExt(By.CssSelector("a[id='btnPayPastDueOnly'][class='btn btn-secondary']"), "ispresent");
                        UIActionExt(By.CssSelector("a[id='btnPayPastDueOnly'][class='btn btn-secondary']"), "click");
                    }
                    break;
                case "OUTSTANDING":
                    UIActionExt(By.CssSelector(lnkOutStanding), "ispresent");
                    UIActionExt(By.CssSelector(lnkOutStanding), "click");
                    break;
                case "YEARLY":
                    UIActionExt(By.CssSelector(lnkYearly), "ispresent");
                    UIActionExt(By.CssSelector(lnkYearly), "click");
                    break;
                default:
                    break;
            }
            WaitUntilElementVisible(driver, By.XPath("//iframe[@id='paymentusIframe']"));
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='paymentusIframe']")));
            UIActionExt(By.CssSelector("input[name='continueButton']"), "ispresent");

            string sPaymentAmount = driver.FindElement(By.CssSelector("input[id='header.paymentAmount']")).GetAttribute("value");
            if (ScenarioContext.Current.ContainsKey("PaymentAmount") == true)
            {
                if (ScenarioContext.Current["PaymentAmount"].ToString() != sPaymentAmount)
                {
                    ScenarioContext.Current["PaymentAmount"] = sPaymentAmount;
                }
            }
            else
            {
                ScenarioContext.Current.Add("PaymentAmount", sPaymentAmount);
            }
        }

        public void verifyPastDueRadio()
        {
            string lnkPastDue = "input[data-description='Amount Past Due']";
            string btnBack = "";
            DataStorage RetrieveRegValue = new DataStorage();
            string sProductName = RetrieveRegValue.GetTempValue("PRODUCT");
            if (sProductName.Contains("Commercial"))
            {
                btnBack = "a[href='/QuickBillPay/?mixpanelsuppressinits=True&productLine=CL']";
            }
            else
            {
                btnBack = "a[href='/QuickBillPay/?mixpanelsuppressinits=True&productLine=PL']";
            }
            UIActionExt(By.CssSelector(btnBack), "ispresent");
            if (IsElementPresent(driver, By.XPath(lnkPastDue)) == true)
            {
                Assert.Fail("Past Due radio button available which is not expected.");
            }
            else
            {
                Console.WriteLine("Pass - Past due not available as expected.");
            }
        }
        public ChoosePaymentAmt(IWebDriver driver) : base(driver)
        {
        }

        public override void VerifyPage()
        {
        }

        public override void WaitForLoad()
        {
        }
    }
}

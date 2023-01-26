using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace ClaimCenter9.Pages.Reinsurance
{
    public class CL_Reinsurance_CC9 : Page
    {
        public CL_Reinsurance_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {

        }
        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath("//span[@id='ReinsuranceSummary:ttlBar'][text()='Reinsurance Financials Summary']"));
        }

        public void ValidateCLReinsuraceDetails(Table table)
        {
            double dblDirectPaid = double.Parse(table.Rows[0]["DirectPaid"], NumberStyles.Currency);
            double NetPaidOnClaim, TotalIncurred, TotalRIRecoverable, CededReserves, TotalRI, RIretention, RInonAdjustments, PaymentRecoverable;

            //Direct Paid
            NetPaidOnClaim = double.Parse(driver.FindElement(By.XPath("//div[@id='ReinsuranceSummary:FinancialsDetailsDV:NetPaidOnClaim-inputEl']")).Text, NumberStyles.Currency);
            //Direct Incured
            TotalIncurred = double.Parse(driver.FindElement(By.XPath("//div[@id='ReinsuranceSummary:FinancialsDetailsDV:TotalIncurred-inputEl']")).Text, NumberStyles.Currency);
            //Total RI Recoverable
            TotalRIRecoverable = double.Parse(driver.FindElement(By.XPath("//div[@id='ReinsuranceSummary:FinancialsDetailsDV:TotalRIRecoverable-inputEl']")).Text, NumberStyles.Currency);
            //RI Open Ceded Reserves 
            CededReserves = double.Parse(driver.FindElement(By.XPath("//div[@id='ReinsuranceSummary:FinancialsDetailsDV:CededReserves-inputEl']")).Text, NumberStyles.Currency);
            //Total ceded Incured 
            TotalRI = double.Parse(driver.FindElement(By.XPath("//div[@id='ReinsuranceSummary:FinancialsDetailsDV:TotalRI-inputEl']")).Text, NumberStyles.Currency);
            //RI Retentation
            RIretention = double.Parse(driver.FindElement(By.XPath("//div[@id='ReinsuranceSummary:FinancialsDetailsDV:RIretention-inputEl']")).Text, NumberStyles.Currency);
            //RI with no adjustments
            RInonAdjustments = double.Parse(driver.FindElement(By.XPath("//div[@id='ReinsuranceSummary:FinancialsDetailsDV:RInonAdjustments-inputEl']")).Text, NumberStyles.Currency);
            //RI recoverable
            var TblHdr = driver.FindElement(By.CssSelector("div[id='ReinsuranceSummary:ReinsuranceSummaryLV-body']"));
            List<IWebElement> TableHeader = TblHdr.FindElements(By.XPath(".//*")).ToList();
            string sTblHdrID = TableHeader[0].GetAttribute("id");
            var tblReserveRows = driver.FindElements(By.XPath("//table[@data-boundview='" + sTblHdrID + "']")).ToList();
            List<IWebElement> tblGetTdElements = new List<IWebElement>(tblReserveRows[3].FindElements(By.TagName("td")));
            PaymentRecoverable = double.Parse(tblGetTdElements[3].Text, NumberStyles.Currency);

            if (dblDirectPaid == NetPaidOnClaim)
                Console.WriteLine("CL Reinsurance: Net Paid on Claim match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", dblDirectPaid, NetPaidOnClaim);
            else
                Assert.Fail("CL Reinsurance: Net Paid on Claim didn't match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", dblDirectPaid, NetPaidOnClaim);

            if (dblDirectPaid == TotalIncurred)
                Console.WriteLine("CL Reinsurance: Total Incured on Claim match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", dblDirectPaid, TotalIncurred);
            else
                Assert.Fail("CL Reinsurance: Total Incured on Claim didn't match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", dblDirectPaid, TotalIncurred);

            if ((dblDirectPaid - TotalRIRecoverable) == RIretention)
                Console.WriteLine("CL Reinsurance: RI retention on Claim match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", (dblDirectPaid - TotalRIRecoverable), RIretention);
            else
                Assert.Fail("CL Reinsurance: RI retention on Claim didn't match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", (dblDirectPaid - TotalRIRecoverable), RIretention);

            if ((NetPaidOnClaim - RIretention) == TotalRI)
                Console.WriteLine("CL Reinsurance: Total RI on Claim match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", (NetPaidOnClaim - RIretention), TotalRI);
            else
                Assert.Fail("CL Reinsurance: Total RI on Claim didn't match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", (NetPaidOnClaim - RIretention), TotalRI);

            if ((NetPaidOnClaim - RIretention) == RInonAdjustments)
                Console.WriteLine("CL Reinsurance: RI non Adjustments on Claim match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", (NetPaidOnClaim - RIretention), RInonAdjustments);
            else
                Assert.Fail("CL Reinsurance: RI non Adjustments on Claim didn't match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", (NetPaidOnClaim - RIretention), RInonAdjustments);

            if ((NetPaidOnClaim - RIretention) == PaymentRecoverable)
                Console.WriteLine("CL Reinsurance: Payment Recoverable on Claim match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", (NetPaidOnClaim - RIretention), PaymentRecoverable);
            else
                Assert.Fail("CL Reinsurance: Payment Recoverable on Claim didn't match\n\t\tExpected Value: {0}\n\t\tActual Value: {1}", (NetPaidOnClaim - RIretention), PaymentRecoverable);

            //Console.WriteLine("NetPaidOnClaim: " + NetPaidOnClaim);
            //Console.WriteLine("TotalIncurred: " + TotalIncurred);
            //Console.WriteLine("TotalRIRecoverable: " + TotalRIRecoverable);
            //Console.WriteLine("CededReserves: " + CededReserves);
            //Console.WriteLine("TotalRI: " + TotalRI);
            //Console.WriteLine("RIretention: " + RIretention);
            //Console.WriteLine("RInonAdjustments: " + RInonAdjustments);
            //Console.WriteLine("PaymentRecoverable: " + PaymentRecoverable);
        }
    }
}

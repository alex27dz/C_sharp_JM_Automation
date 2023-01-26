using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace QuickBillPayPages.Pages
{
    public class BC_DetailsPage:Page
    {
        public void verifyDetailsPage(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                string sFieldName = table.Rows[i]["FieldName"];
                string sActualValue = "";
                switch (sFieldName)
                {
                    case "TotalPastDue":
                        string lblPastDueAmount = "div[id$=':AccountPastDueAmount-inputEl']";
                        if (table.Rows[i]["Value"].ToString() == "NotNull")
                        {
                            UIActionExt(By.CssSelector(lblPastDueAmount), "ispresent");
                            sActualValue = driver.FindElement(By.CssSelector(lblPastDueAmount)).Text;
                            if (sActualValue.Contains("$"))
                            {
                                Console.WriteLine("Pass - Total Past Due Amount: "+ sActualValue);
                            }
                            else
                            {
                                //Console.WriteLine("Fail - Total Past Due Amount: " + sActualValue +" Expected any value or amount");
                                Assert.Fail("Total Past Due Amount: " + sActualValue + " Expected any value or amount");
                            }
                        }
                        break;
                    case "PaymentStatus":
                        string tblOpenPlcyStatus = "div[id$=':AccountDetailSummaryScreen:AccountPoliciesLV-body']";
                        UIActionExt(By.CssSelector(tblOpenPlcyStatus), "ispresent");
                        IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblOpenPlcyStatus));
                        IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("td")).ToList();
                        sActualValue = tblTDplcyChng[4].Text;
                        Console.WriteLine("Actual Payment Status: " + sActualValue);

                        if (table.Rows[i]["Value"].ToString().Contains(":"))
                        {
                            string[] arrFieldValue = table.Rows[i]["Value"].ToString().Split(':');
                            if ((arrFieldValue[0] == sActualValue) || (arrFieldValue[1] == sActualValue)) 
                            {
                                Console.WriteLine("Pass - PaymentStatus: " + sActualValue);
                            }
                            else
                            {
                                //Console.WriteLine("Fail - PaymentStatus: " + sActualValue + " Expected : " + table.Rows[i]["Value"].ToString());
                                Assert.Fail("PaymentStatus Actual Value: " + sActualValue + " Expected : " + arrFieldValue[0] + " or "+ arrFieldValue[1]);
                            }
                        }
                        else if(table.Rows[i]["Value"].ToString()!="")
                        {
                            if (table.Rows[i]["Value"].ToString() == sActualValue) 
                            {
                                Console.WriteLine("Pass - PaymentStatus: " + sActualValue);
                            }
                            else
                            {
                                //Console.WriteLine("Fail - PaymentStatus: " + sActualValue + " Expected : " + table.Rows[i]["Value"].ToString());
                                Assert.Fail("PaymentStatus Actual Value: " + sActualValue + " Expected : " + table.Rows[i]["Value"].ToString());
                            }
                        }
                        break;
                    default:
                        Assert.Fail("Unknown Field");
                        break;
                }
            }
        }
        public void UpdateRegistry(Table table)
        {
            string tblOpenPlcyStatus = "div[id$=':AccountDetailSummaryScreen:AccountPoliciesLV-body']";
            string[] arrFirstLastName;
            UIActionExt(By.CssSelector(tblOpenPlcyStatus), "ispresent");
            IWebElement tblPlcyChng = driver.FindElement(By.CssSelector(tblOpenPlcyStatus));
            IList<IWebElement> tblTDplcyChng = tblPlcyChng.FindElements(By.TagName("td")).ToList();
            string sProductValue = tblTDplcyChng[3].Text;
            Console.WriteLine("PRODUCT: " + sProductValue);
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");

            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                string RegistryName = table.Rows[i]["RegDetails"];
                string RegistryValue = "";
                switch (RegistryName)
                {
                    case "ACC_NAME":
                        RegistryValue = driver.FindElement(By.CssSelector("div[id$=':AccountDetailSummaryScreen:AccountDetailDV:PrimaryContact-inputEl']")).Text;
                        RegKey.SetValue("ACC_NAME", RegistryValue);
                        Console.WriteLine("ACC_NAME: " + RegistryValue);
                        break;
                    case "EMAIL":
                        RegistryValue = driver.FindElement(By.CssSelector("div[id$=':AccountDetailSummaryScreen:AccountDetailDV:Email-inputEl']")).Text;
                        RegKey.SetValue("EMAIL", RegistryValue);
                        Console.WriteLine("EMAIL: " + RegistryValue);
                        break;
                    case "FNAME":
                        RegistryValue = driver.FindElement(By.CssSelector("div[id$=':AccountDetailSummaryScreen:AccountDetailDV:PrimaryContact-inputEl']")).Text;
                        arrFirstLastName = RegistryValue.Split(' ');
                        if ((sProductValue == "Personal Lines") || (sProductValue == "JPAPersonalArticles"))
                        {
                            RegKey.SetValue("FNAME", arrFirstLastName[0]);
                            Console.WriteLine("FNAME: " + arrFirstLastName[0]);
                        }
                        break;
                    case "LNAME":
                        RegistryValue = driver.FindElement(By.CssSelector("div[id$=':AccountDetailSummaryScreen:AccountDetailDV:PrimaryContact-inputEl']")).Text;
                        arrFirstLastName = RegistryValue.Split(' ');
                        if ((sProductValue == "Personal Lines")||(sProductValue == "JPAPersonalArticles"))
                        {
                            RegKey.SetValue("LNAME", arrFirstLastName[arrFirstLastName.Length-1]);
                            Console.WriteLine("LNAME: " + arrFirstLastName[arrFirstLastName.Length - 1]);
                        }
                        break;
                    case "PRODUCT":
                        RegKey.SetValue("PRODUCT", sProductValue);
                        break;
                    case "ZIPCODE":
                        string[] AddressSplit = driver.FindElement(By.CssSelector("div[id$=':AccountDetailSummaryScreen:AccountDetailDV:Address-inputEl']")).Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        AddressSplit = AddressSplit[1].Split(' ');
                        if (AddressSplit[AddressSplit.Length-1].Length==3)
                        {
                            RegistryValue = AddressSplit[AddressSplit.Length - 2] +" "+ AddressSplit[AddressSplit.Length - 1];
                        }
                        else
                        {
                            RegistryValue = AddressSplit[AddressSplit.Length - 1];
                        }
                        RegKey.SetValue("ZIPCODE", RegistryValue);
                        Console.WriteLine("ZIPCODE: " + RegistryValue);
                        break;
                    default:
                        Assert.Fail("Unknown Reg Values");
                        break;
                }
            }
        }

        public void verifyPayInstPayAmt(string CCorACH)
        {
            string lblAcctDetails = "span[id$='AccountDetailSummary:AccountDetailSummaryScreen:ttlBar']";
            string lblPayments = "span[id$='AccountPayments:AccountDetailPaymentsScreen:ttlBar']";
            string lnkPayments = "//span[text()='Payments']";
            string lnkOverview = "//span[text()='Overview']";

            //string tblPayments = "div[id$=':DirectBillPaymentsListDetail:AccountDBPaymentsLV-body']";
            UIActionExt(By.CssSelector(lblAcctDetails), "ispresent");
            UIActionExt(By.XPath(lnkPayments), "click");
            UIActionExt(By.CssSelector(lblPayments), "ispresent");
            UIActionExt(By.CssSelector("div[id$=':DirectBillPaymentsListDetail:AccountDBPaymentsLV-body']"), "ispresent");
            IWebElement divPaymentsTable = driver.FindElement(By.CssSelector("div[id$=':DirectBillPaymentsListDetail:AccountDBPaymentsLV-body']"));
            IList<IWebElement> lstTable = divPaymentsTable.FindElements(By.TagName("table")).ToList();
            IList<IWebElement> lstTimeFrame = lstTable[lstTable.Count - 1].FindElements(By.TagName("td")).ToList();
            string sPaymentAmount = "$" + ScenarioContext.Current["PaymentAmount"].ToString();
            if (lstTimeFrame[3].Text.ToString().ToLower().Contains(CCorACH.ToLower())==false)
            {
                Console.WriteLine("Payment Type, Expected: {0} Actual: {1}", CCorACH, lstTimeFrame[3].Text);
                Assert.Fail("PaymentType mismatch");
            }
            if ((lstTimeFrame[6].Text.ToString().Replace(",", "") == sPaymentAmount) == false)
            {
                Console.WriteLine("Payment Amount, Expected: {0} Actual: {1}", sPaymentAmount, lstTimeFrame[6].Text);
                Assert.Fail("PaymentAmount mismatch");
            }
            UIActionExt(By.XPath(lnkOverview), "click");
            UIActionExt(By.CssSelector(lblAcctDetails), "ispresent");
        }
        public BC_DetailsPage(IWebDriver driver) : base(driver)
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

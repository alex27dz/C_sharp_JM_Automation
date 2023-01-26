using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class QuickBillPayPage:Page
    {
        public void AddPrimaryInfo(Table table)
        {
            DataStorage RetrieveRegValue = new DataStorage();
            string sProductName = "";
            string sAccountNumber = "";
            string sEmail = "";
            string sZipCode = "";
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                string sFieldName = table.Rows[i]["FieldName"];
                switch (sFieldName.ToString().ToUpper())
                {
                    case "PRODUCT":
                        sProductName = RetrieveRegValue.GetTempValue("PRODUCT");
                        if (sProductName.Contains("Commercial"))
                        {
                            string lnkCL = "a[href='/QuickBillPay/?mixpanelsuppressinits=&productLine=CL']";
                            UIActionExt(By.CssSelector(lnkCL), "ispresent");
                            UIActionExt(By.CssSelector(lnkCL), "click");
                        }
                        else
                        {
                            string lnkPL = "a[href='/QuickBillPay/?mixpanelsuppressinits=&productLine=PL']";
                            UIActionExt(By.CssSelector(lnkPL), "ispresent");
                        }
                        break;
                    case "EMAIL":
                        string txtEmail = "input[id$='EmailOrAccount']";
                        if (table.Rows[i]["Value"].ToString().ToUpper()== "REGISTRY")
                        {
                            sEmail = RetrieveRegValue.GetTempValue("EMAIL");
                        }
                        else
                        {
                            sEmail = table.Rows[i]["Value"];
                        }
                        if (sEmail != "")
                        {
                            UIActionExt(By.CssSelector(txtEmail), "ispresent");
                            UIActionExt(By.CssSelector(txtEmail), "List", sEmail);
                        }
                        else
                        {
                            Assert.Fail("EMAIL can't be empty");
                        }
                        break;
                    case "ACCOUNT_NUMBER":
                        string txtAccount = "input[id$='EmailOrAccount']";
                        if (table.Rows[i]["Value"].ToString().ToUpper() == "REGISTRY")
                        {
                            sAccountNumber = RetrieveRegValue.GetTempValue("ACCNO");
                        }
                        else
                        {
                            sAccountNumber = table.Rows[i]["Value"];
                        }
                        if (sAccountNumber != "")
                        {
                            UIActionExt(By.CssSelector(txtAccount), "ispresent");
                            UIActionExt(By.CssSelector(txtAccount), "List", sAccountNumber);
                        }
                        else
                        {
                            Assert.Fail("Account Number can't be empty");
                        }

                        break;
                    case "LASTORBUSINESSNAME":
                        sProductName = RetrieveRegValue.GetTempValue("PRODUCT");
                        string txtLBName = "input[id='LastName']";
                        UIActionExt(By.CssSelector(txtLBName), "ispresent");
                        if (sProductName.Contains("Commercial"))
                        {
                            string sAccountName = RetrieveRegValue.GetTempValue("ACC_NAME");
                            UIActionExt(By.CssSelector(txtLBName), "List", sAccountName);
                        }
                        else
                        {
                            string sLastName = RetrieveRegValue.GetTempValue("LNAME");
                            UIActionExt(By.CssSelector(txtLBName), "List", sLastName);
                        }
                        break;
                    case "ZIPCODE":
                        sZipCode = RetrieveRegValue.GetTempValue("ZIPCODE");
                        string txtZipCode = "input[id='ZipCode']";
                        UIActionExt(By.CssSelector(txtZipCode), "ispresent");
                        UIActionExt(By.CssSelector(txtZipCode), "List", sZipCode);
                        break;
                    default:
                        break;
                }
            }

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].setAttribute('value', 'true')", driver.FindElement(By.CssSelector("input[id='BypassRecaptcha']")));

            string btnContinue = "div[id='continueButton']";
            UIActionExt(By.CssSelector(btnContinue), "ispresent");
            UIActionExt(By.CssSelector(btnContinue), "click");
        }
        public void VerifyBackBtn()
        {
            DataStorage RetrieveRegValue = new DataStorage();
            string sProductName = RetrieveRegValue.GetTempValue("PRODUCT");
            string btnBack = "";
            if (sProductName.Contains("Commercial"))
            {
                btnBack = "a[href='/QuickBillPay/?mixpanelsuppressinits=True&productLine=CL']";
            }
            else
            {
                btnBack = "a[href='/QuickBillPay/?mixpanelsuppressinits=True&productLine=PL']";
            }
            UIActionExt(By.CssSelector(btnBack), "ispresent");
        }
        public void VerifyAccountInactive()
        {
            // string btnContinue = "div[id='continueButton']";
            // UIActionExt(By.CssSelector(btnContinue), "ispresent");
            //*[@id='lookupForm']/div/div[1]
            // Console.WriteLine(driver.FindElement(By.XPath("//li[text()='Sorry, your account is no longer active. Please call Customer Care at 800-336-5642, Ext. 2185.']")));
            if (IsElementPresent(driver,By.XPath("//*[@id='lookupForm']/div/div[1]"))==false)
            {
                Assert.Fail("Account Inactive message not displayed.");
            }
            else
            {
                Console.WriteLine("Pass - Account is Inactive");
            }
        }
        public void verifyEmailZipAcct()
        {
            DataStorage RetrieveRegValue = new DataStorage();
            string sProductName = RetrieveRegValue.GetTempValue("PRODUCT");
            string sAccountNumber = RetrieveRegValue.GetTempValue("ACCNO"); 
            string sEmail = RetrieveRegValue.GetTempValue("EMAIL");
            string sZipCode = RetrieveRegValue.GetTempValue("ZIPCODE");
            string btnBack = "";
            if (sProductName.Contains("Commercial"))
            {
                btnBack = "a[href='/QuickBillPay/?mixpanelsuppressinits=True&productLine=CL']";
            }
            else
            {
                btnBack = "a[href='/QuickBillPay/?mixpanelsuppressinits=True&productLine=PL']";
            }
            UIActionExt(By.CssSelector(btnBack), "ispresent");
            string CLPageSource = driver.PageSource;
            if (sEmail != "")
            {
                if ((CLPageSource.Contains("AccountNumber: '" + sAccountNumber + "'") == false) || (CLPageSource.Contains("ZipCode: '" + sZipCode + "'") == false))
                {
                    Assert.Fail("Account Number and ZipCode didn't match");
                }
                else
                {
                    Console.WriteLine("Pass. Account Number: {0} and ZipCode: {1} matches for email:{2}.", sAccountNumber, sZipCode, sEmail);
                }
            }
            else
            {
                Assert.Fail("Email can't be null. Please select different email. ");
            }

            UIActionExt(By.CssSelector(btnBack), "click");
        }
        public QuickBillPayPage(IWebDriver driver) : base(driver)
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

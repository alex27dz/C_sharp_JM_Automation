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


namespace BillingCenterPages.Pages.Common
{

    public class BCDetails : Page
    {
        [FindsBy(How = How.Id, Using = "AccountDetailSummary:AccountDetailSummaryScreen:AccountPoliciesLV:0:PolicyNumber")]
        public IWebElement LinkPolicyNumber;

        [FindsBy(How = How.Id, Using = "AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV:DefaultPaymentInstrument-inputEl")]
        public IWebElement LabelAutoPayState;

        [FindsBy(How = How.Id, Using = "AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV:Address-inputEl")]
        public IWebElement PolicyAddress;

        string[] arrTblList;
        string[] arrTblList2;

        string btnActions = "a[id$='AccountDetailSummary:AccountDetailSummaryScreen:AccountDBPaymentsLV:0:ActionButton']";
        string reverseInActions = "span[id$='AccountDetailSummary:AccountDetailSummaryScreen:AccountDBPaymentsLV:0:ActionButton:ReversePayment-textEl']";
       
        public BCDetails(IWebDriver driver) : base(driver)
        {
            pause();
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(logOut); 
        }

        public override void WaitForLoad()
        {
            //throw new NotImplementedException(); 
        }
        public void VerifyDetailsAgentInquiry(string Address, string PaymentPlan)
        {
            WaitFor(driver.FindElement(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV-table")));

            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV-table")).ToList();

            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            if (Address.Length > 2)
            {
                AccountDetailsComparision(Address, "Address", arrTblList);
            }


            // for Policy details 
            List<IWebElement> TableInputElements2 = driver.FindElements(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountPoliciesLV-body")).ToList();

            arrTblList2 = TableInputElements2[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            if (PaymentPlan == "2 PAY - SEMI ANNUALLY" || PaymentPlan.ToUpper() == "2 PAY")
            {
                PaymentPlan = "Two Pay - Semi Annually";
            }
            else if (PaymentPlan.ToUpper() == "4 PAY" || PaymentPlan.ToUpper() == "4 PAY - QUARTERLY")
            {
                PaymentPlan = "Four Pay - Quarterly";
            }
            else if (PaymentPlan.ToUpper() == "8 PAY")
            {
                PaymentPlan = "Eight Pay";
            }
            else if (PaymentPlan.ToUpper() == "12 PAY")
            {
                PaymentPlan = "Twelve Pay";
            }
            else
            {
                Console.WriteLine("Expected PaymentPlan is " + PaymentPlan);
                PolicyDetailComparison(PaymentPlan, arrTblList2, "Payment Plan");
            }

        }

        public void verifyAutopay(string AutoPay)
        {
            string autopaystate = LabelAutoPayState.Text;
            Console.WriteLine("Auto Pay text is " + autopaystate);

            if (string.Compare(AutoPay.ToLower(), autopaystate.ToLower()) == 0)
            {
                Console.WriteLine(" Auto pay state matches : Expected value " + AutoPay + " actual value " + autopaystate);

            }
            else
            {
                Console.WriteLine(" Auto pay state do not matches : Expected value " + AutoPay + " actual value " + autopaystate);
                Assert.Fail("Auto pay state do not match.");
            }

        }

        public void VerifyDetails(string PrimaryInsured, string Address, string PolicyNo, string PaymentPlan, string EffectiveDate, string ExpireDate, string PaymentInstrument)

        {
            // for account details 
            WaitFor(driver.FindElement(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV-table")));

            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV-table")).ToList();

            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            //for (int k = 0; k < arrTblList.Count(); k++)
            //{
            //    Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
            //}
            DateTime dt = Convert.ToDateTime(EffectiveDate);
            if (PrimaryInsured.Length > 2)
            {
                AccountDetailsComparision(PrimaryInsured, "Account Name", arrTblList);
            }
            if (Address.Length > 2)
            {
                AccountDetailsComparision(Address, "Address", arrTblList);
            }
            AccountDetailsComparision(dt.AddDays(19).ToString("MM/dd/yyyy"), "Due Date", arrTblList);

            if ((ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim()) == "stage")
            {
                if (PaymentInstrument.Length > 2)
                {
                    AccountDetailsComparision(PaymentInstrument, "Payment Instrument", arrTblList);
                }
            }



            // for Policy details 
            List<IWebElement> TableInputElements2 = driver.FindElements(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountPoliciesLV-body")).ToList();

            arrTblList2 = TableInputElements2[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int k = 0; k < arrTblList2.Count(); k++)
            {
                Console.WriteLine(k + " identifier " + arrTblList2[k].ToString());
            }
            if (PolicyNo.Length > 4)
            {
                PolicyDetailComparison(PolicyNo + "-1", arrTblList2, "Policy Number");
            }
            if (EffectiveDate.Length > 3)
            {
                PolicyDetailComparison(EffectiveDate, arrTblList2, "Effictive Date");
            }

            if (ExpireDate.Length > 3)
            {
                PolicyDetailComparison(ExpireDate, arrTblList2, "Expire Date");
            }


            if (PolicyNo.Length > 5)
            {
                if (PolicyNo.Contains("24-"))
                {
                    PolicyDetailComparison("Personal Lines", arrTblList2, "Product");

                }
                else if (PolicyNo.Contains("55-"))
                {
                    PolicyDetailComparison("Commercial Lines", arrTblList2, "Product");
                }
                else
                {
                    Console.WriteLine("personal artical line will be included later");
                    PolicyDetailComparison("TBD", arrTblList2, "Product");
                }
            }

            if (PaymentPlan == "2 PAY - SEMI ANNUALLY" || PaymentPlan.ToUpper() == "2 PAY")
            {
                PaymentPlan = "Two Pay - Semi Annually";
            }
            else if (PaymentPlan.ToUpper() == "4 PAY")
            {
                PaymentPlan = "Four Pay - Quarterly";
            }
            else if (PaymentPlan.ToUpper() == "8 PAY")
            {
                PaymentPlan = "Eight Pay";
            }
            else if (PaymentPlan.ToUpper() == "12 PAY")
            {
                PaymentPlan = "Twelve Pay";
            }
            else
            {
                PolicyDetailComparison(PaymentPlan, arrTblList2, "Payment Plan");
            }
        }

        public void PolicyDetailComparison(string ExpectedValue, string[] TempArray, string ParamName)
        {
            int pos = Array.IndexOf(TempArray, ExpectedValue);
            string Actualvalue = "NA";
            switch (ParamName)
            {
                case "Policy Number":
                    Actualvalue = TempArray[0].ToString();
                    break;
                case "Effictive Date":
                    Actualvalue = TempArray[5].ToString();
                    break;
                case "Expire Date":
                    Actualvalue = TempArray[6].ToString();
                    break;
                case "Product":
                    Actualvalue = TempArray[3].ToString();
                    break;
                case "Payment Plan":
                    Actualvalue = TempArray[1].ToString();
                    break;
            }
            if (pos > -1)
            {
                Console.WriteLine(ParamName + " matches : Expected value  " + ExpectedValue + " Actual value " + Actualvalue);
            }
            else
            {
                Console.WriteLine(ParamName + " do not matches : Expected value  " + ExpectedValue + " Actual value " + Actualvalue);
                Assert.Fail(ParamName + " do not match : Expected value " + ExpectedValue + " Actual value " + Actualvalue);
                //Assert.Fail("\nExpected :\t {0}\nActual :\t {1}", ExpectedValue, TempArray[0].ToString());
            }

        }

        public void AccountDetailsComparision(string ExpectedValue, string ParamName, string[] TempArray1)
        {

            int pos = Array.IndexOf(TempArray1, ParamName);
            if (pos > -1)
            {
                if (ParamName == "Address")
                {
                    int pos_limit = Array.IndexOf(TempArray1, "Phone");
                    int k = 1;
                    string actual_address = "";
                    Console.WriteLine(" Paramater name under Address : " + ParamName);
                    Console.WriteLine(" inital counter is : " + pos);
                    Console.WriteLine(" limit counter is : " + pos_limit);
                    for (int i = pos; i < pos_limit - 2; i++)
                    {
                        actual_address = actual_address + TempArray1[pos + k].ToString();
                        Console.WriteLine(" k : " + k);
                        k = k + 1;
                    }
                    //+ TempArray1[pos + 2].ToString() + TempArray1[pos + 3].ToString() ;
                    Console.WriteLine(" actual_address is : " + actual_address);
                    actual_address = actual_address.Replace(" ", "");
                    actual_address = actual_address.Trim();
                    actual_address = actual_address.ToLower();
                    ExpectedValue = ExpectedValue.ToLower();
                    ExpectedValue = ExpectedValue.Trim();
                    ExpectedValue = ExpectedValue.Replace(",", "");
                    actual_address = actual_address.Replace(",", "");
                    if (actual_address.Contains("-"))
                    {
                        actual_address = actual_address.Substring(0, (actual_address.Length - 5));
                    }

                    if (string.Compare(actual_address, ExpectedValue) == 0)
                    {
                        Console.WriteLine(ParamName + " matches : Expected value " + ExpectedValue + " actual value " + actual_address);

                    }
                    else
                    {
                        Console.WriteLine(ParamName + " do not matches : Expected value " + ExpectedValue + " actual value " + actual_address);
                        //Assert.Fail("\nExpected Adrress :\t {0}\nActual Address :\t {1}", ExpectedValue, actual_address);
                        Assert.Fail(ParamName + " do not match.");
                    }
                }
                else if (ParamName == "Payment Instrument")
                {
                    Console.WriteLine(" Paramater name under Address : " + ParamName);
                    string actual_PaymentInstrument = TempArray1[pos + 1].ToString();
                    actual_PaymentInstrument = actual_PaymentInstrument.ToLower();
                    actual_PaymentInstrument = actual_PaymentInstrument.Trim();
                    ExpectedValue = ExpectedValue.ToLower();
                    ExpectedValue = ExpectedValue.Trim();
                    //char[] delimiters = new char[] { '*'};
                    //string[] actual_PaymentInstrumen_temp = actual_PaymentInstrument.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    //actual_PaymentInstrument = actual_PaymentInstrumen_temp[0];
                    if (string.Compare(actual_PaymentInstrument, ExpectedValue) == 0)
                    {
                        Console.WriteLine(ParamName + " matches : Expected value " + ExpectedValue + " actual value " + actual_PaymentInstrument);

                    }
                    else
                    {
                        Console.WriteLine(ParamName + " do not matches : Expected value " + ExpectedValue + " actual value " + actual_PaymentInstrument);
                        //Assert.Fail("\nExpected " + ParamName + " :\t {0}\nActual " + ParamName + ":\t {1}", ExpectedValue, TempArray1[pos + 1].ToString());
                        Assert.Fail(ParamName + " do not match.");
                    }

                }
                else
                {
                    Console.WriteLine(" Paramater name under else : " + ParamName);
                    if (string.Compare(TempArray1[pos + 1].ToString(), ExpectedValue) == 0)
                    {
                        Console.WriteLine(ParamName + " matches : Expected value " + ExpectedValue + " actual value " + TempArray1[pos + 1].ToString());

                    }
                    else
                    {
                        Console.WriteLine(ParamName + " do not matches : Expected value " + ExpectedValue + " actual value " + TempArray1[pos + 1].ToString());
                        //Assert.Fail("\nExpected " + ParamName + " :\t {0}\nActual " + ParamName + ":\t {1}", ExpectedValue, TempArray1[pos + 1].ToString());
                        Assert.Fail(ParamName + " do not match.");
                    }


                }

            }

        }

        public void SelectPolicyNumber()
        {
            WaitFor(LinkPolicyNumber);
            pause();
            LinkPolicyNumber.Click();

            pause();

            WaitForPageLoad(driver);
        }

        //public void BillDateComparision(string ExpectedValue, string ParamName)
        //{

        //    //    [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Invoices')]]")]
        //    //    public IWebElement leftNavInvoices;
        //}
        public void GetCountryNameDueDate()
        {
            pause();
            pause();
            WaitForPageLoad(driver);
            WaitFor(driver.FindElement(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV:NextPaymentDue-inputEl")));
            string[] CountrySplit = PolicyAddress.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            ScenarioContext.Current["CountryAddress"] = CountrySplit[CountrySplit.Length - 1];
            //Get Payment DueDate
            IWebElement PolicyPayDueDate = driver.FindElement(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV:NextPaymentDue-inputEl"));
            string PaymentDueDate = PolicyPayDueDate.Text.ToString();
            Console.WriteLine("Total Amount Due: " + PaymentDueDate);
            ScenarioContext.Current["NextPaymentDueDate"] = PaymentDueDate;
        }

        public void GetTotalAmountDue()
        {
            System.Threading.Thread.Sleep(5000);
            WaitForPageLoad(driver);
            bool IsNegativeAmount = false;
            WaitFor(driver.FindElement(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV:AccountFullAmountDue-inputEl")));
            IWebElement PolicyType = driver.FindElement(By.Id("AccountDetailSummary:AccountDetailSummaryScreen:AccountDetailDV:AccountFullAmountDue-inputEl"));

            string TotalAmountDue = PolicyType.Text.ToString();
            Console.WriteLine("Total Amount Due: " + TotalAmountDue);
            //Console.WriteLine("Total Amount Due: " + TotalAmountDue.Length);
            if (TotalAmountDue.Contains("(") || TotalAmountDue.Contains(")"))
            {
                TotalAmountDue = TotalAmountDue.Replace("(", "");
                TotalAmountDue = TotalAmountDue.Replace(")", "");
                IsNegativeAmount = true;
            }
            if (TotalAmountDue.Contains(","))
            {
                TotalAmountDue = TotalAmountDue.Replace(",", "");
            }
            TotalAmountDue = TotalAmountDue.Substring(1, TotalAmountDue.Length - 4);

            if (IsNegativeAmount)
            {
                TotalAmountDue = "-" + TotalAmountDue;
            }
            Console.WriteLine("Total Amount Due: " + TotalAmountDue);
            ScenarioContext.Current["TotalAmountDue"] = TotalAmountDue;
        }

        public void SelectActionInRecentPaymentSection(string actionType)
        {
            WaitFor(driver.FindElement(By.CssSelector(btnActions)));
            UIAction(btnActions, string.Empty, "a");
            JavaScriptClick(driver.FindElement(By.CssSelector(btnActions)));
           
            Actions action = new Actions(driver);
            switch (actionType.ToLower().Trim())
            {
                case "reverse":
                    action.MoveToElement(driver.FindElement(By.CssSelector(btnActions))).SendKeys(driver.FindElement(By.CssSelector(reverseInActions)), Keys.ArrowDown).Build().Perform();
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
         }
    }

}





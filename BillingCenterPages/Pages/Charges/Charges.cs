using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace BillingCenterPages.Pages.Charges
{
    public class Charges : Page

    {
        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Charges')]]")]
        public IWebElement pageHdrCharges;

        [FindsBy(How = How.XPath, Using = "//td[@data-columnid=gridcolumn-1250']")]
        public IWebElement TypeOfCharge;

        string pageHDRCharges = "span[id$= ':AccountDetailChargesScreen:ttlBar']";



        public Charges(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);

        
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(pageHDRCharges);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(pageHDRCharges));
        }

        public string getChargeType()
        {
            IList<IWebElement> tableElement = driver.FindElements(By.TagName("table"));
            string ChargeType = "";

            int tableVal = 0;

            for (int i = tableElement.Count - 1; i > 0; i--)
            {
                //  Console.WriteLine("Row"+i+"=="+tableElement[i].Text);
                if (tableElement[i].Text.Contains("Actions"))
                {

                    Console.WriteLine("i val" + i);
                    tableVal = i;
                    IWebElement x = tableElement[tableVal];
                    IList<IWebElement> tableRow = x.FindElements(By.TagName("td")).ToList();
                    if (tableRow.Count < 15)
                    {
                        Console.WriteLine(tableRow[6].Text);
                        ChargeType = ChargeType + ";" + tableRow[6].Text;
                    }
                    else
                    {
                        break;
                    }

                }
            }

            //   Console.WriteLine(tableElement.Count);

            //  IWebElement x = tableElement[22];


            //Console.WriteLine("ChargeType length is " + ChargeType.Length);
            ChargeType = ChargeType.Substring(1, ChargeType.Length-1);
            Console.WriteLine("ChargeType value is " + ChargeType);
            return ChargeType.Trim();



        }

        public string getAmount(string feeType)
        {
            IList<IWebElement> tableElement = driver.FindElements(By.TagName("table"));
            string amount = "";
            int tableVal = 0;
            Console.WriteLine("table element number: " + tableElement.Count);
            for (int i = tableElement.Count - 1; i > 0; i--)
            {
                Console.WriteLine("Row" + i + "==" + tableElement[i].Text);
                if (tableElement[i].Text.Contains("Actions"))
                {
                    Console.WriteLine("i val " + i);
                    tableVal = i;
                    IWebElement x = tableElement[tableVal];
                    IList<IWebElement> tableRow = x.FindElements(By.TagName("td")).ToList();
                    Console.WriteLine("Action row number: " + tableRow.Count);
                    if (tableRow.Count < 15)
                    {
                        Console.WriteLine("charge type tableRow[6]: " + tableRow[6].Text.ToLower().Trim());
                        switch (feeType.ToLower().Trim())
                        {
                            case "rewrite":
                                if (tableRow[6].Text.ToLower().Trim().Equals("rewrite fee"))
                                {
                                    Console.WriteLine("rewrite amount tableRow[11]: " + tableRow[11].Text);
                                    amount = tableRow[11].Text;
                                    break;
                                }
                                break;
                            case "reinstatement":
                                if (tableRow[6].Text.ToLower().Trim().Equals("reinstatement fee"))
                                {
                                    Console.WriteLine("reinstate amount tableRow[11]: " + tableRow[11].Text);
                                    amount = tableRow[11].Text;
                                    break;
                                }
                                break;
                            case "nsf":
                                if (tableRow[6].Text.ToLower().Trim().Equals("payment reversal fee"))
                                {
                                    Console.WriteLine("reversal amount tableRow[11]: " + tableRow[11].Text);
                                    amount = tableRow[11].Text;
                                    break;
                                }
                                break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
            return amount.Trim();
        }
    }
}

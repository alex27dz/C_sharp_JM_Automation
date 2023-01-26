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


namespace BillingCenterPages.Pages.Disbursement
{
    public class Disbursements : Page
    {
        //[FindsBy(How = How.ClassName, Using = "x-grid-item-container")]
        //public IWebElement ElemetAmount;
        public Disbursements(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            //CssSelector(btnFinish)).ToList();
        }




        public override void VerifyPage()
        {
            //throw new NotImplementedException();
        }

        public override void WaitForLoad()
        {
            //throw new NotImplementedException();
        }

        public void DisbursementPaymentStatus(string paymentAmount, string status)
        {
            pause();
            pause();
            List<IWebElement> TableInputElements = driver.FindElements(By.ClassName("x-grid-item-container")).ToList();
            string temp = TableInputElements[1].Text;

            Console.WriteLine("Temp Val"+temp);
            string[] arrTblList = TableInputElements[1].Text.Split(new string[] { "Default" }, StringSplitOptions.None);
            Console.WriteLine(arrTblList.Count());
            Console.WriteLine(arrTblList[arrTblList.Count() - 1].ToString());
            string replacement = Regex.Replace(arrTblList[arrTblList.Count() - 1].ToString(), @"\t|\n|\r", "");
            Console.WriteLine(replacement);
            if (replacement.Contains(paymentAmount))
            {
                if (replacement.Contains(status))
                {
                    Console.WriteLine("For Amount " + paymentAmount + " Status matched");
                }
                else
                {
                    Console.WriteLine("For Amount " + paymentAmount + " Status do not match");
                }
            }
            else
            {
                Console.WriteLine(" Disbursement Payment Amount is not there");
            }


        }
    }





}


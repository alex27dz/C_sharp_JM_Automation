using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace QuoteAndApplyPages.Pages.QNA
{
    public class PaymentPlan : Page
    {

        
        public PaymentPlan(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  SetActiveFrame();
            pause();

         
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.XPath("//p[text()='1. Select a Payment Plan']"));
                
        }

        public void selectPaymentPlan(string PaymentPlan)
        {
            IList<IWebElement> Paymentoption;
            switch (PaymentPlan.ToLower().Trim())
            {

                case "annual":
                    Paymentoption = driver.FindElements(By.XPath("//label[text()='Annual Payment']")).ToList();
                    if (Paymentoption.Count > 0)
                        JavaScriptClick(Paymentoption[0]);
                    break;
                case "2 payment":
                    Paymentoption = driver.FindElements(By.XPath("//label[text()='2 Payments']")).ToList();
                    if (Paymentoption.Count > 0)
                        JavaScriptClick(Paymentoption[0]);
                    break;
                case "4 payment":
                    Paymentoption = driver.FindElements(By.XPath("//label[text()='4 Payments']")).ToList();
                    if (Paymentoption.Count > 0)
                        JavaScriptClick(Paymentoption[0]);
                    break;
                default:
                    
                    break;
            }
            
        }


    }
}

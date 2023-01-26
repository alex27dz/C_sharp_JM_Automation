using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace BillingCenterPages.Pages.PaymentWallet
{
    public class PaymentWallet : Page
    {
        // string btnAddPaymentMethod = ".btn-action.addNewPm";
        [FindsBy(How = How.Id, Using = "AccountDetailPaymentManagerWallet_JMIC:AccountDetailPaymentInstrumentScreen:manageAutoPayTab")]
        public IWebElement btnManageAutoPay;


        [FindsBy(How = How.Id, Using = "AccountDetailPaymentManagerWallet_JMIC:AccountDetailPaymentInstrumentScreen:ToolbarButton")]
        public IWebElement btnAddPaymentMethod;

        [FindsBy(How = How.ClassName, Using = "btn-action btn-mobile back-to-payments")]
        public IWebElement btnReturnToSummary;

        public PaymentWallet(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            WaitFor(btnAddPaymentMethod);

        }

        public override void WaitForLoad()
        {
            WaitFor(btnAddPaymentMethod);

        }
        public void verifyPaymentMethods(string CardType)
        {
            System.Threading.Thread.Sleep(3000);
            SetActiveIFrame();
            string Payments_Content;
            string CardNumber = "";
            //pause();
            System.Threading.Thread.Sleep(5000);
            List<IWebElement> PageInputElements = driver.FindElements(By.Id("wallet-id-0")).ToList();
            Console.WriteLine("Details arer " + PageInputElements[0].GetAttribute("data-pm"));
            Payments_Content = PageInputElements[0].GetAttribute("data-pm").ToString();
            switch (CardType.ToLower().Trim())
            {
                case "visa":
                    CardNumber = "Visa ************8291";
                    break;
                case "master":
                    CardNumber = "Mastercard ************5454";
                    break;
                case "amex":
                    CardNumber = "Amex ************8431";
                    break;
                case "discover":
                    CardNumber = "Discover ************1234";
                    break;
                default:
                    break;
            }

            if (Payments_Content.Contains(CardNumber))
            {
                Console.WriteLine("Payment Method is avaialble");
            }
            else
            {
                Assert.Fail("Apprisial not Uploaded");
                Console.WriteLine("Payment Method is avaialble");
            }
            driver.SwitchTo().DefaultContent();
        }
        //btnManageAutoPay

        public void clickonManageAutoPay()
        {
            btnManageAutoPay.Click();
            pause();
            pause();
            pause();
        }

        public void removeExistingPaymentTypes()
        {
			System.Threading.Thread.Sleep(10000);
			SetActiveIFrame();
            //pause();
            System.Threading.Thread.Sleep(3000);


            List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(".btn-action.btn-cancel.activePm")).ToList();

            Console.WriteLine("[[[[[[[[[" + PageInputElements.Count);

            if (PageInputElements.Count > 0)
            {
                JavaScriptClick(PageInputElements[0]);
                //PageInputElements[0].Click();
                //pause();
                System.Threading.Thread.Sleep(3000);

                PageInputElements = driver.FindElements(By.CssSelector(".btn-action.btnConfirm")).ToList();

                Console.WriteLine("[[[[[[[[[" + PageInputElements.Count);

                if (PageInputElements.Count > 0)
                    PageInputElements[0].Click();
                //pause();
                System.Threading.Thread.Sleep(3000);
            }

            PageInputElements = driver.FindElements(By.CssSelector(".btn-action.btn-cancel.activePm")).ToList();

            Console.WriteLine("[[[[[[[[[" + PageInputElements.Count);

            if (PageInputElements.Count > 0)
            {
                PageInputElements[0].Click();
                //pause();
                System.Threading.Thread.Sleep(3000);

                PageInputElements = driver.FindElements(By.CssSelector(".btn-action.btnConfirm")).ToList();

                Console.WriteLine("[[[[[[[[[" + PageInputElements.Count);

                if (PageInputElements.Count > 0)
                    PageInputElements[0].Click();
                //pause();
                System.Threading.Thread.Sleep(3000);
            }

            driver.SwitchTo().DefaultContent();


        }

        public void VerifyAutoPay(string CardType)
        {
            SetActiveIFrame();
            //   WaitFor(btnReturnToSummary);
            string CardNumber = "";
            string Payments_Content;
            //pause();
            WaitUntilElementVisible(driver, By.XPath("//div[@class='grid__item four-fifths lap-one-whole palm-one-whole'][@id='main-container']"), 60);
            //WaitUntilElementIsDisplayed(driver, By.XPath("//div[@class='grid__item four-fifths lap-one-whole palm-one-whole'][@id='main-container']"));

            // System.Threading.Thread.Sleep(5000);
            //   List<IWebElement> PageInputElements = driver.FindElements(By.Id("main-container")).ToList();

            List<IWebElement> PageInputElements = driver.FindElements(By.XPath("//div[@class='grid__item four-fifths lap-one-whole palm-one-whole'][@id='main-container']")).ToList();

            //List<IWebElement> PageInputElements = driver.FindElements(By.Id("main-container")).ToList();
            // Console.WriteLine("Details arer " + PageInputElements[0].GetAttribute("data-pm"));
            Payments_Content = PageInputElements[0].Text;
            Console.WriteLine("Details arer " + Payments_Content);


            switch (CardType.ToLower().Trim())
            {
                case "visa":
                    CardNumber = "**8291";
                    break;
                case "master":
                    CardNumber = "**5454";
                    break;
                case "amex":
                    CardNumber = "**8431";
                    break;
                case "discover":
                    CardNumber = "**1234";
                    break;
                default:
                    break;
            }

            if (Payments_Content.Contains(CardNumber))
            {
                Console.WriteLine("Payment Method is avaialble");
            }
            else
            {
                Assert.Fail("Apprisial not Uploaded");
                Console.WriteLine("Payment Method is avaialble");
            }
            driver.SwitchTo().DefaultContent();


        }

    }
}

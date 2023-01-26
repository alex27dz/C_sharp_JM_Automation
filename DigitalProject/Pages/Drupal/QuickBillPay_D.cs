using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebCommonCore;

namespace DigitalProject.Pages.Drupal
{
    public class QuickBillPay_D : Page
    {

        string txtQuickBillPay = "//h1[text()='Quick Bill Pay']";
        string txtQuickBillPayDesc = "//h5[text()='Pay your bill without logging in or creating an account.']";
        string txtLetsLookYouUp = "//h3[contains(text(),' look you up.')]";
        string txtPersonalEmailAccounttext = "//label[text()='Email Address or Account Number']";
        string txtlastName = "//label[text()='Last Name']";
        string txtZipCode = "//label[text()='Zip/Postal Code']";
        string btnContinue = "//div[@id='continueButton']";
        string txtLogInHere = "//span[contains(text(),'Need to make more changes?')]";
        string linkLogInHere = "//a[text()='Log in here']";
        string tabPersonal = "//a[text()='Personal']";
        string tabBusiness = "//a[text()='Business']";
        string txtWhereDoIFindInfo = "//span[@id='helpInvoice']";

        QuickBillPay_D_V QuickBillPay_D_V = new QuickBillPay_D_V();

        public QuickBillPay_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            // Add all the elements you want to verify
            VerifyUIElementIsDisplayed(txtQuickBillPay);

            VerifyUIElementIsDisplayed(txtQuickBillPayDesc);
            VerifyUIElementIsDisplayed(txtLetsLookYouUp);
            VerifyUIElementIsDisplayed(txtPersonalEmailAccounttext);
            VerifyUIElementIsDisplayed(txtlastName);
            VerifyUIElementIsDisplayed(txtZipCode);
            VerifyUIElementIsDisplayed(btnContinue);
            VerifyUIElementIsDisplayed(txtLogInHere);
            VerifyUIElementIsDisplayed(linkLogInHere);
            VerifyUIElementIsDisplayed(tabPersonal);
           
          
        }

        public void verifyQuickBillPay()
        {
            //txtQuickBillPay
            string QuickBillPay = driver.FindElement(By.XPath(txtQuickBillPay)).GetAttribute("innerText");
            Console.WriteLine("txtQuickBillPay");
            Assert.AreEqual(QuickBillPay.ToLower().Trim(), QuickBillPay_D_V.lblQuickBillPay.ToLower().Trim(), "The Text " + QuickBillPay_D_V.lblQuickBillPay + " doesn't match");


            //txtQuickBillPayDesc
            string QuickBillPayDesc = driver.FindElement(By.XPath(txtQuickBillPayDesc)).GetAttribute("innerText");
            Console.WriteLine("txtQuickBillPayDesc");
            Assert.AreEqual(QuickBillPayDesc.ToLower().Trim(), QuickBillPay_D_V.lblQuickBillPayDesc.ToLower().Trim(), "The Text " + QuickBillPay_D_V.lblQuickBillPayDesc + " doesn't match");

            //txtLetsLookYouUp
            string LetsLookYouUp = driver.FindElement(By.XPath(txtLetsLookYouUp)).GetAttribute("innerText");
            Console.WriteLine("txtLetsLookYouUp");
            Assert.AreEqual(LetsLookYouUp.ToLower().Trim(), QuickBillPay_D_V.lblLetsLookYouUp.ToLower().Trim(), "The Text " + QuickBillPay_D_V.lblLetsLookYouUp + " doesn't match");

            //txtPersonalEmailAccounttext
            string PersonalEmailAccounttext = driver.FindElement(By.XPath(txtPersonalEmailAccounttext)).GetAttribute("innerText");
            Console.WriteLine("txtPersonalEmailAccounttext");
            Assert.AreEqual(PersonalEmailAccounttext.ToLower().Trim(), QuickBillPay_D_V.lblPersonalEmailAccounttext.ToLower().Trim(), "The Text " + QuickBillPay_D_V.lblPersonalEmailAccounttext + " doesn't match");

            //txtlastName
            string lastName = driver.FindElement(By.XPath(txtlastName)).GetAttribute("innerText");
            Console.WriteLine("txtlastName");
            Assert.AreEqual(lastName.ToLower().Trim(), QuickBillPay_D_V.lbllastName.ToLower().Trim(), "The Text " + QuickBillPay_D_V.lbllastName + " doesn't match");

            //txtZipCode
            string ZipCode = driver.FindElement(By.XPath(txtZipCode)).GetAttribute("innerText");
            Console.WriteLine("txtZipCode");
            Assert.AreEqual(ZipCode.ToLower().Trim(), QuickBillPay_D_V.lblZipCode.ToLower().Trim(), "The Text " + QuickBillPay_D_V.lblZipCode + " doesn't match");

            //txtLogInHere
            string LogInHere = driver.FindElement(By.XPath(txtLogInHere)).GetAttribute("innerText");
            Console.WriteLine("value is " + LogInHere);
            Console.WriteLine("txtLogInHere");
            Assert.AreEqual(LogInHere.ToLower().Trim(), QuickBillPay_D_V.txtLogInHere.ToLower().Trim(), "The Text " + QuickBillPay_D_V.txtLogInHere + " doesn't match");

          
        }


    }
}

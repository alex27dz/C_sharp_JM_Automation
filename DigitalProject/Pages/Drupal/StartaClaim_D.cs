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
    public class StartaClaim_D : Page
    {

        string txtStartaClaimPayXpath = "//h1[text()='Start a Claim']";
        string txtStartaClaimDescXpath = "//h5[text()='Start your claim without logging in or creating an account.']";
        string txtLetsLookYouUpXpath = "//h3[contains(text(),' look you up.')]";
        string txtPersonalEmailAccounttextXpath = "//label[text()='Email Address or Policy Number']";
        string txtlastNameXpath = "//label[text()='Last Name']";
        string txtZipCodeXpath = "//label[text()='Zip/Postal Code']";
        string btnContinueXpath = "//div[@id='continueButton']";
        string txtLogInHereXpath = "//h5[contains(text(),'Need to make more changes? ')]";
        string linkLogInHereXpath = "//a[text()='Log in here']";
        

        StartaClaim_D_V StartaClaim_D_V = new StartaClaim_D_V();

        public StartaClaim_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
         //   VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            // Add all the elements you want to verify
            VerifyUIElementIsDisplayed(txtStartaClaimPayXpath);
            VerifyUIElementIsDisplayed(txtStartaClaimDescXpath);
            VerifyUIElementIsDisplayed(txtLetsLookYouUpXpath);
            VerifyUIElementIsDisplayed(txtPersonalEmailAccounttextXpath);
            VerifyUIElementIsDisplayed(txtlastNameXpath);
            VerifyUIElementIsDisplayed(txtZipCodeXpath);
            VerifyUIElementIsDisplayed(btnContinueXpath);
            VerifyUIElementIsDisplayed(txtLogInHereXpath);
            VerifyUIElementIsDisplayed(linkLogInHereXpath);



        }

        public void verifyStartaClaim()
        {
            //txtQuickBillPay
            string StartaClaim = driver.FindElement(By.XPath(txtStartaClaimPayXpath)).GetAttribute("innerText");
            Console.WriteLine("txtQuickBillPay");
            Assert.AreEqual(StartaClaim.ToLower().Trim(), StartaClaim_D_V.lblStartaClaim.ToLower().Trim(), "The Text " + StartaClaim_D_V.lblStartaClaim + " doesn't match");


            //txtQuickBillPayDesc
            string StartaClaimDesc = driver.FindElement(By.XPath(txtStartaClaimDescXpath)).GetAttribute("innerText");
            Console.WriteLine("txtQuickBillPayDesc");
            Assert.AreEqual(StartaClaimDesc.ToLower().Trim(), StartaClaim_D_V.lblStartaClaimDesc.ToLower().Trim(), "The Text " + StartaClaim_D_V.lblStartaClaimDesc + " doesn't match");

            //txtLetsLookYouUp
            string LetsLookYouUp = driver.FindElement(By.XPath(txtLetsLookYouUpXpath)).GetAttribute("innerText");
            Console.WriteLine("txtLetsLookYouUp");
            Assert.AreEqual(LetsLookYouUp.ToLower().Trim(), StartaClaim_D_V.lblLetsLookYouUp.ToLower().Trim(), "The Text " + StartaClaim_D_V.lblLetsLookYouUp + " doesn't match");

            //txtPersonalEmailAccounttext
            string PersonalEmailAccounttext = driver.FindElement(By.XPath(txtPersonalEmailAccounttextXpath)).GetAttribute("innerText");
            Console.WriteLine("txtPersonalEmailAccounttext");
            Assert.AreEqual(PersonalEmailAccounttext.ToLower().Trim(), StartaClaim_D_V.lblPersonalEmailAccounttext.ToLower().Trim(), "The Text " + StartaClaim_D_V.lblPersonalEmailAccounttext + " doesn't match");

            //txtlastName
            string lastName = driver.FindElement(By.XPath(txtlastNameXpath)).GetAttribute("innerText");
            Console.WriteLine("txtlastName");
            Assert.AreEqual(lastName.ToLower().Trim(), StartaClaim_D_V.lbllastName.ToLower().Trim(), "The Text " + StartaClaim_D_V.lbllastName + " doesn't match");

            //txtZipCode
            string ZipCode = driver.FindElement(By.XPath(txtZipCodeXpath)).GetAttribute("innerText");
            Console.WriteLine("txtZipCode");
            Assert.AreEqual(ZipCode.ToLower().Trim(), StartaClaim_D_V.lblZipCode.ToLower().Trim(), "The Text " + StartaClaim_D_V.lblZipCode + " doesn't match");

            //txtLogInHere
            string LogInHere = driver.FindElement(By.XPath(txtLogInHereXpath)).GetAttribute("innerText");
            Console.WriteLine("value is " + LogInHere);
            Console.WriteLine("txtLogInHere");
            Assert.AreEqual(LogInHere.ToLower().Trim(), StartaClaim_D_V.txtLogInHere.ToLower().Trim(), "The Text " + StartaClaim_D_V.txtLogInHere + " doesn't match");


        }


}
}

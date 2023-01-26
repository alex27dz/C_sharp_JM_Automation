using DigitalProject.Pages.Drupal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace DigitalProject.Pages.Drupal
{
    public class Quote_D : Page
    {
        // Find Your Future txtHeader
        public string txtHeaderQuestionXpath = "//label[.='Questions?']";
        public string txtHeaderPhoneXpath = "//span[text()='888-884-2424']";
        public string txtHeaderEmailXpath = "//span[text()='Email']";
        public string txtHeaderFAQXpath = "//span[text()='FAQ']";

        // Find Your Future txtHeaderRibbon
        //public string txtHeaderRibbonQUOTEXpath = "//span[.='QUOTE']";
        //public string txtHeaderRibbonApplicantWearerXpath = "//span[.='APPLICANT & WEARERS']";
        //public string txtHeaderRibbonJewlryDetailsXpath = "//span[.='JEWELRY DETAILS']";
        //public string txtHeaderRibbonReviewXpath = "//span[.='REVIEW']";
        //public string txtHeaderRibbonPaymentXpath = "//span[.='PAYMENT']";

        public string txtQuotoInfoTitle1Xpath = "//h1[.='Get Your Free Jewelry Insurance Quote']";
        public string txtQuotoInfoTitle2Xpath = "//h5[.='Already have a quote?  Retrieve your saved quote or application']";


        public string txtQuoteTitle1Xpath = "//p[.='1.  Enter the Zip/Postal Code of the Jewelry Wearer']";
        public string txtQuoteTitle2Xpath = "//p[.='2. Tell Us About Your Jewelry Item(s)']";
        public string txtQuoteTitle3Xpath = "//label[.='Jewelry Type']";
        public string txtQuoteTitle4Xpath = "//label[.='Value']";
        public string imgquestion = "//img[@alt='Jewelry Value Help']";
        public string txtQuoteTitle5Xpath = "//a[@id='AddJewelryItemQuoteInfo']";
        public string txtQuoteTitle6Xpath = "//a[@id='quoteInfoNext']";

        public string txtFooterTitle1Xpath = "//a[@id='privacyPolicy-footer']";
        public string txtFooterTitle2Xpath = "//a[@id='termsOfUse-footer']";
        public string txtFooterTitle3Xpath = "//div[.='© 2021 Jewelers Mutual Group. All Rights Reserved.']";

        public string txtRightCovePageTitle1Xpath = "//div[contains(text(),'Coverage Includes:')]";
        public string txtRightCovePageTitle2Xpath = "//span[.='Loss']";
        public string txtRightCovePageTitle3Xpath = "//span[.='Theft']";
        public string txtRightCovePageTitle4Xpath = "//span[.='Damage']";
        public string txtRightCovePageTitle5Xpath = "//span[.='Worldwide Travel']";
        public string txtRightCovePageTitle6Xpath = "//span[.='Disappearance']";
        public string txtRightCovePageTitle7Xpath = "//a[.='Additional Coverage Details']";




        Quote_D_V Quote_D_V = new Quote_D_V();

        public Quote_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            // VerifyLinksOnPage(driver);
            //  CheckForBrokenImages(driver);
        }
        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
            VerifyUIElementIsDisplayed(txtQuoteTitle1Xpath);
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtHeaderQuestionXpath);
            VerifyUIElementIsDisplayed(txtHeaderPhoneXpath);
            VerifyUIElementIsDisplayed(txtHeaderEmailXpath);
            VerifyUIElementIsDisplayed(txtHeaderFAQXpath);
            //VerifyUIElementIsDisplayed(txtHeaderRibbonQUOTEXpath);
            //VerifyUIElementIsDisplayed(txtHeaderRibbonApplicantWearerXpath);
            //VerifyUIElementIsDisplayed(txtHeaderRibbonJewlryDetailsXpath);
            //VerifyUIElementIsDisplayed(txtHeaderRibbonReviewXpath);
            //VerifyUIElementIsDisplayed(txtHeaderRibbonPaymentXpath);
            VerifyUIElementIsDisplayed(txtQuotoInfoTitle1Xpath);
            VerifyUIElementIsDisplayed(txtQuotoInfoTitle2Xpath);
            VerifyUIElementIsDisplayed(txtQuoteTitle1Xpath);
            VerifyUIElementIsDisplayed(txtQuoteTitle2Xpath);
            VerifyUIElementIsDisplayed(txtQuoteTitle3Xpath);
            VerifyUIElementIsDisplayed(txtQuoteTitle4Xpath);
            VerifyUIElementIsDisplayed(imgquestion);

            VerifyUIElementIsDisplayed(txtQuoteTitle5Xpath);
            VerifyUIElementIsDisplayed(txtQuoteTitle6Xpath);
            VerifyUIElementIsDisplayed(txtFooterTitle1Xpath);
            VerifyUIElementIsDisplayed(txtFooterTitle2Xpath);
            VerifyUIElementIsDisplayed(txtFooterTitle3Xpath);
            VerifyUIElementIsDisplayed(txtRightCovePageTitle1Xpath);
            VerifyUIElementIsDisplayed(txtRightCovePageTitle2Xpath);
            VerifyUIElementIsDisplayed(txtRightCovePageTitle3Xpath);
            VerifyUIElementIsDisplayed(txtRightCovePageTitle4Xpath);
            VerifyUIElementIsDisplayed(txtRightCovePageTitle5Xpath);
            VerifyUIElementIsDisplayed(txtRightCovePageTitle6Xpath);
            VerifyUIElementIsDisplayed(txtRightCovePageTitle7Xpath);


        }



        public void verifyHeader()
        {

            // JEWELERS MUTUAL IN THE NEWS
            string HeaderQuestion = driver.FindElement(By.XPath(txtHeaderQuestionXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderQuestion.ToLower().Trim(), Quote_D_V.txtHeaderQuestion.ToLower().Trim(), "The Text doesn't match");


            string HeaderPhone = driver.FindElement(By.XPath(txtHeaderPhoneXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderPhone.ToLower().Trim(), Quote_D_V.txtHeaderPhone.ToLower().Trim(), "The Text doesn't match");


            string HeaderEmail = driver.FindElement(By.XPath(txtHeaderEmailXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderEmail.ToLower().Trim(), Quote_D_V.txtHeaderEmail.ToLower().Trim(), "The Text doesn't match");


            string HeaderFAQ = driver.FindElement(By.XPath(txtHeaderFAQXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderFAQ.ToLower().Trim(), Quote_D_V.txtHeaderFAQ.ToLower().Trim(), "The Text doesn't match");

        }



        public void verifyHeaderRibbon()
        {
            //string HeaderRibbonQUOTE = driver.FindElement(By.XPath(txtHeaderRibbonQUOTEXpath)).GetAttribute("innerText");
            //Assert.AreEqual(HeaderRibbonQUOTE.ToLower().Trim(), Quote_D_V.txtHeaderRibbonQUOTE.ToLower().Trim(), "The Text doesn't match");

            //string HeaderRibbonApplicantWearer = driver.FindElement(By.XPath(txtHeaderRibbonApplicantWearerXpath)).GetAttribute("innerText");
            //Assert.AreEqual(HeaderRibbonApplicantWearer.ToLower().Trim(), Quote_D_V.txtHeaderRibbonApplicantWearer.ToLower().Trim(), "The Text doesn't match");

            //string HeaderRibbonJewlryDetails = driver.FindElement(By.XPath(txtHeaderRibbonJewlryDetailsXpath)).GetAttribute("innerText");
            //Assert.AreEqual(HeaderRibbonJewlryDetails.ToLower().Trim(), Quote_D_V.txtHeaderRibbonJewlryDetails.ToLower().Trim(), "The Text doesn't match");

            //string HeaderRibbonReview = driver.FindElement(By.XPath(txtHeaderRibbonReviewXpath)).GetAttribute("innerText");
            //Assert.AreEqual(HeaderRibbonReview.ToLower().Trim(), Quote_D_V.txtHeaderRibbonReview.ToLower().Trim(), "The Text doesn't match");

            //string HeaderRibbonPayment = driver.FindElement(By.XPath(txtHeaderRibbonPaymentXpath)).GetAttribute("innerText");
            //Assert.AreEqual(HeaderRibbonPayment.ToLower().Trim(), Quote_D_V.txtHeaderRibbonPayment.ToLower().Trim(), "The Text doesn't match");

            string QuotoInfoTitle1 = driver.FindElement(By.XPath(txtQuotoInfoTitle1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(QuotoInfoTitle1.ToLower().Trim(), Quote_D_V.txtQuotoInfoTitle1.ToLower().Trim(), "The Text doesn't match");

            string QuotoInfoTitle2 = driver.FindElement(By.XPath(txtQuotoInfoTitle2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(QuotoInfoTitle2.ToLower().Trim(), Quote_D_V.txtQuotoInfoTitle2.ToLower().Trim(), "The Text doesn't match");

        }


        public void verifyMainContent()
        {
            string txtQuoteTitle1 = driver.FindElement(By.XPath(txtQuoteTitle1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtQuoteTitle1.ToLower().Trim(), Quote_D_V.txtQuoteTitle1.ToLower().Trim(), "The Text doesn't match");

            string txtQuoteTitle2 = driver.FindElement(By.XPath(txtQuoteTitle2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtQuoteTitle2.ToLower().Trim(), Quote_D_V.txtQuoteTitle2.ToLower().Trim(), "The Text doesn't match");

            string txtQuoteTitle3 = driver.FindElement(By.XPath(txtQuoteTitle3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtQuoteTitle3.ToLower().Trim(), Quote_D_V.txtQuoteTitle3.ToLower().Trim(), "The Text doesn't match");

            string txtQuoteTitle4 = driver.FindElement(By.XPath(txtQuoteTitle4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtQuoteTitle4.ToLower().Trim(), Quote_D_V.txtQuoteTitle4.ToLower().Trim(), "The Text doesn't match");

            string txtQuoteTitle5 = driver.FindElement(By.XPath(txtQuoteTitle5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtQuoteTitle5.ToLower().Trim(), Quote_D_V.txtQuoteTitle5.ToLower().Trim(), "The Text doesn't match");

            string txtQuoteTitle6 = driver.FindElement(By.XPath(txtQuoteTitle6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtQuoteTitle6.ToLower().Trim(), Quote_D_V.txtQuoteTitle6.ToLower().Trim(), "The Text doesn't match");
        }



        public void verifyRightCove()
        {
            string txtRightCovePageTitle1 = driver.FindElement(By.XPath(txtRightCovePageTitle1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRightCovePageTitle1.ToLower().Trim(), Quote_D_V.txtRightCovePageTitle1.ToLower().Trim(), "The Text doesn't match");

            string txtRightCovePageTitle2 = driver.FindElement(By.XPath(txtRightCovePageTitle2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRightCovePageTitle2.ToLower().Trim(), Quote_D_V.txtRightCovePageTitle2.ToLower().Trim(), "The Text doesn't match");

            string txtRightCovePageTitle3 = driver.FindElement(By.XPath(txtRightCovePageTitle3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRightCovePageTitle3.ToLower().Trim(), Quote_D_V.txtRightCovePageTitle3.ToLower().Trim(), "The Text doesn't match");

            string txtRightCovePageTitle4 = driver.FindElement(By.XPath(txtRightCovePageTitle4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRightCovePageTitle4.ToLower().Trim(), Quote_D_V.txtRightCovePageTitle4.ToLower().Trim(), "The Text doesn't match");

            string txtRightCovePageTitle5 = driver.FindElement(By.XPath(txtRightCovePageTitle5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRightCovePageTitle5.ToLower().Trim(), Quote_D_V.txtRightCovePageTitle5.ToLower().Trim(), "The Text doesn't match");

            string txtRightCovePageTitle6 = driver.FindElement(By.XPath(txtRightCovePageTitle6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRightCovePageTitle6.ToLower().Trim(), Quote_D_V.txtRightCovePageTitle6.ToLower().Trim(), "The Text doesn't match");

            string txtRightCovePageTitle7 = driver.FindElement(By.XPath(txtRightCovePageTitle7Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRightCovePageTitle7.ToLower().Trim(), Quote_D_V.txtRightCovePageTitle7.ToLower().Trim(), "The Text doesn't match");


        }



        public void verifyFooter()
        {
            //string txtFooterTitle1 = driver.FindElement(By.XPath(txtFooterTitle1Xpath)).GetAttribute("innerText");
            //Assert.AreEqual(txtFooterTitle1.ToLower().Trim(), Quote_D_V.txtFooterTitle1.ToLower().Trim(), "The Text doesn't match");

            //string txtFooterTitle2 = driver.FindElement(By.XPath(txtFooterTitle2Xpath)).GetAttribute("innerText");
            //Assert.AreEqual(txtFooterTitle2.ToLower().Trim(), Quote_D_V.txtFooterTitle2.ToLower().Trim(), "The Text doesn't match");

            string txtFooterTitle3 = driver.FindElement(By.XPath(txtFooterTitle3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooterTitle3.ToLower().Trim(), Quote_D_V.txtFooterTitle3.ToLower().Trim(), "The Text doesn't match");

        }
    }
}

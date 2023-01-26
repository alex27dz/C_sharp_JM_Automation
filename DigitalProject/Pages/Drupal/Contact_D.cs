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
    public class Contact_D : Page
    {
        // Elements  

        // Contact Page Images




        // Contact Header
        string headerGetInTouchSXpath = "div.hero__content > h4";
        string titleProudXpath = "h1";

        // Contact Information 


        string headerContactFromXpath = "//h1[text()='Proud to call Neenah, Wisconsin home.']";
        string textContactInformationXpath = "//h2[text()='Contact Information']";
        string textEmailXpath = "//h4[text()='Email Us']";
        string textEmaildescXpath = "//p[text()='One of our customer service team members will respond as soon as possible.']";
        string textEmailClaimXpath = "//strong[text()='Claims']";
        string textEmailClaimidXpath = "//a[text()='claims@jminsure.com']";
        string textJweleryBusinessXpath = "//strong[text()='Jewelry Businesses']";
        string textJweleryBusinessidXpath = "//a[text()='csu@jminsure.com']";
        string textMediaInquiriesXpath = "//strong[text()='Media Inquiries']";
        string textMediaInquiriesidXpath = "//a[text()='mediainquiries@jminsure.com']";
        string textPersonalJewelryXpath = "//strong[text()='Personal Jewelry']";
        string textPersonalJewelryidXpath = "//a[text()='personaljewelry@jminsure.com']";
        string textSalesMarketingXpath = "//strong[text()='Sales and Marketing']";
        string textSalesMarketingidXpath = "//a[text()='sales@jminsure.com']";

        string textCallusXpath = "//h4[text()='Call Us']";
        string textCalldescXpath = "//p[text()='Give us a call to speak to a representative.']";
        string textBusinessPolicytimeXpath = "//p[contains(text(),'M-F 7am-5pm')]";
        string textPersonalPolicytimeXpath = "//p[contains(text(),'M-Th 7am-7pm')]";



        Contact_D_V Contact_D_V = new Contact_D_V();
        public Contact_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify
            VerifyUIElementIsDisplayed(headerContactFromXpath);

            VerifyUIElementIsDisplayed(textContactInformationXpath);
            VerifyUIElementIsDisplayed(textEmailXpath);
            VerifyUIElementIsDisplayed(textEmaildescXpath);
            VerifyUIElementIsDisplayed(textEmailClaimXpath);
            VerifyUIElementIsDisplayed(textEmailClaimidXpath);
            VerifyUIElementIsDisplayed(textJweleryBusinessXpath);
            VerifyUIElementIsDisplayed(textJweleryBusinessidXpath);
            VerifyUIElementIsDisplayed(textMediaInquiriesXpath);
            VerifyUIElementIsDisplayed(textMediaInquiriesidXpath);
            VerifyUIElementIsDisplayed(textPersonalJewelryXpath);
            VerifyUIElementIsDisplayed(textPersonalJewelryidXpath);
            VerifyUIElementIsDisplayed(textSalesMarketingXpath);
            VerifyUIElementIsDisplayed(textSalesMarketingidXpath);
            VerifyUIElementIsDisplayed(textCallusXpath);
            VerifyUIElementIsDisplayed(textCalldescXpath);
            VerifyUIElementIsDisplayed(textBusinessPolicytimeXpath);
            VerifyUIElementIsDisplayed(textPersonalPolicytimeXpath);


        }


        public void verifyContactInformationCallus()
        {
            //textCallus
            string Callus = driver.FindElement(By.XPath(textCallusXpath)).GetAttribute("innerText");
            Console.WriteLine("Callus");
            Assert.AreEqual(Callus.ToLower().Trim(), Contact_D_V.txtTitleCallUs.ToLower().Trim(), "The Text " + Contact_D_V.txtTitleCallUs + " doesn't match");

            //textCalldesc
            string Calldesc = driver.FindElement(By.XPath(textCalldescXpath)).GetAttribute("innerText");
            Calldesc = Calldesc.Replace(System.Environment.NewLine, "");
            //string Calldesc1 = Regex.Replace(Calldesc, @"\n", "");
            Console.WriteLine("Callus");
            Assert.AreEqual(Calldesc.ToLower().Trim(), Contact_D_V.txtInfoCallUs.ToLower().Trim(), "The Text " + Contact_D_V.txtInfoCallUs + " doesn't match");

            //textBusinessPolicy
            string BusinessPolicy = driver.FindElement(By.XPath(textBusinessPolicytimeXpath)).GetAttribute("innerText");
            BusinessPolicy = BusinessPolicy.Replace(System.Environment.NewLine, "");
            Console.WriteLine(" VALUE IS " + BusinessPolicy);
            Assert.AreEqual(BusinessPolicy.ToLower().Trim(), Contact_D_V.txtTitleBP.ToLower().Trim(), "The Text " + Contact_D_V.txtTitleBP + " doesn't match");

            //textPersonalPolicy
            string PersonalPolicy = driver.FindElement(By.XPath(textPersonalPolicytimeXpath)).GetAttribute("innerText");
            PersonalPolicy = PersonalPolicy.Replace(System.Environment.NewLine, "");
            Console.WriteLine(" VALUE IS " + PersonalPolicy);
            Assert.AreEqual(PersonalPolicy.ToLower().Trim(), Contact_D_V.txtTitlePP.ToLower().Trim(), "The Text " + Contact_D_V.txtTitlePP + " doesn't match");




        }

        public void verifyContactInformationEmail()
        {


            //contactInformation
            string ContactInformation = driver.FindElement(By.XPath(textContactInformationXpath)).GetAttribute("innerText");
            Console.WriteLine("contactInformation");
            Assert.AreEqual(ContactInformation.ToLower().Trim(), Contact_D_V.txtHeaderContacttxtInformation.ToLower().Trim(), "The Text " + Contact_D_V.txtEmailUs + " doesn't match");

            //Email
            string Emailus = driver.FindElement(By.XPath(textEmailXpath)).GetAttribute("innerText");
            Console.WriteLine("Email");
            Assert.AreEqual(Emailus.ToLower().Trim(), Contact_D_V.txtEmailUs.ToLower().Trim(), "The Text " + Contact_D_V.txtEmailUs + " doesn't match");

            //Email text
            string Emaildesc = driver.FindElement(By.XPath(textEmaildescXpath)).GetAttribute("innerText");
            Console.WriteLine("Email text");
            Assert.AreEqual(Emaildesc.ToLower().Trim(), Contact_D_V.txtEmailDesc.ToLower().Trim(), "The Text " + Contact_D_V.txtEmailDesc + " doesn't match");

            //Email Claims
            string Emailclaim = driver.FindElement(By.XPath(textEmailClaimXpath)).GetAttribute("innerText");
            Console.WriteLine("Email Claims");
            Assert.AreEqual(Emailclaim.ToLower().Trim(), Contact_D_V.txtEmailClaims.ToLower().Trim(), "The Text " + Contact_D_V.txtEmailClaims + " doesn't match");

            //Email Claimsid
            string Emailclaimid = driver.FindElement(By.XPath(textEmailClaimidXpath)).GetAttribute("innerText");
            Console.WriteLine("Email Claimsid");
            Assert.AreEqual(Emailclaimid.ToLower().Trim(), Contact_D_V.hrefClaimsA.ToLower().Trim(), "The Text " + Contact_D_V.hrefClaimsA + " doesn't match");

            //Email JweleryBusiness
            string EmailJweleryBusiness = driver.FindElement(By.XPath(textJweleryBusinessXpath)).GetAttribute("innerText");
            Console.WriteLine("Email JweleryBusiness");
            Assert.AreEqual(EmailJweleryBusiness.ToLower().Trim(), Contact_D_V.txtEmailJB.ToLower().Trim(), "The Text " + Contact_D_V.txtEmailJB + " doesn't match");

            //Email JweleryBusinessid
            string EmailJweleryBusinessid = driver.FindElement(By.XPath(textJweleryBusinessidXpath)).GetAttribute("innerText");
            Console.WriteLine("Email JweleryBusinessid");
            Assert.AreEqual(EmailJweleryBusinessid.ToLower().Trim(), Contact_D_V.hrefJB.ToLower().Trim(), "The Text " + Contact_D_V.hrefJB + " doesn't match");


            //Email MediaInquiry
            string EmailMediaInquiries = driver.FindElement(By.XPath(textMediaInquiriesXpath)).GetAttribute("innerText");
            Console.WriteLine("Email MediaInquiry");
            Assert.AreEqual(EmailMediaInquiries.ToLower().Trim(), Contact_D_V.txtTitleMedia.ToLower().Trim(), "The Text " + Contact_D_V.txtTitleMedia + " doesn't match");

            //Email MediaInquiryid
            string EmailMediaInquiriesid = driver.FindElement(By.XPath(textMediaInquiriesidXpath)).GetAttribute("innerText");
            Console.WriteLine("Email MediaInquiryid");
            Assert.AreEqual(EmailMediaInquiriesid.ToLower().Trim(), Contact_D_V.hrefMedia.ToLower().Trim(), "The Text " + Contact_D_V.hrefMedia + " doesn't match");


            //Email PersonalJewelry
            string EmailPersonalJewelry = driver.FindElement(By.XPath(textPersonalJewelryXpath)).GetAttribute("innerText");
            Console.WriteLine("Email PersonalJewelry");
            Assert.AreEqual(EmailPersonalJewelry.ToLower().Trim(), Contact_D_V.txtTitlePJ.ToLower().Trim(), "The Text " + Contact_D_V.txtTitlePJ + " doesn't match");

            //Email PersonalJewelryid
            string EmailPersonalJewelryid = driver.FindElement(By.XPath(textPersonalJewelryidXpath)).GetAttribute("innerText");
            Console.WriteLine("Email PersonalJewelryid");
            Assert.AreEqual(EmailPersonalJewelryid.ToLower().Trim(), Contact_D_V.hrefPJ.ToLower().Trim(), "The Text " + Contact_D_V.hrefPJ + " doesn't match");

            //Email salesMarketing
            string EmailSalesMarketing = driver.FindElement(By.XPath(textSalesMarketingXpath)).GetAttribute("innerText");
            Console.WriteLine("Email salesMarketing");
            Assert.AreEqual(EmailSalesMarketing.ToLower().Trim(), Contact_D_V.txtTitleSales.ToLower().Trim(), "The Text " + Contact_D_V.txtTitleSales + " doesn't match");

            //Email SalesMarketingid
            string EmailSalesMarketingid = driver.FindElement(By.XPath(textSalesMarketingidXpath)).GetAttribute("innerText");
            Console.WriteLine("Email SalesMarketingid");
            Assert.AreEqual(EmailSalesMarketingid.ToLower().Trim(), Contact_D_V.hrefSales.ToLower().Trim(), "The Text " + Contact_D_V.hrefSales + " doesn't match");



        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
        }

        public void verifyNavBar()
        {
            DrupalCommonPage drupalCommon = new DrupalCommonPage();
            drupalCommon.verifyNavBar(driver);


        }
        public void verifyFooter()
        {
            DrupalCommonPage drupalCommon = new DrupalCommonPage();
            drupalCommon.verifyFooter(driver);

        }

        public void verifyContactPageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyContactInformationEmail();
            verifyContactInformationCallus();
        }



    }
}

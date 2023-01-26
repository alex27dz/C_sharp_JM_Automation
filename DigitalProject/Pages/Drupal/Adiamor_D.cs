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
    class Adiamor_D : Page
    {
        // Elements  

        // Adiamor Page Images
               
        // Nav Bar                 
        string jmLogoCSS = ".nav__logo-lg";
        string navPersonalCSS = "a[href='/Personal']";
        string navPersonalInsuranceCSS = "a[href=' / jewelry - engagement - ring - insurance - quote']";
        string navGetAQuoteCSS = "a[href = '/Personal/Get-a-Quote']";
        string navClaimsCSS = "a href ='/jewelry-insurance-claims']";
        string navFAQCSS = "a[href='/jewelry-insurance-policy-information']";
        string navPLBlogCSS = "a[href='/the-jewelry-box']";
        string navPLPayMyBillCSS = "a[href='/Personal/Manage-My-Policy']";
        string navManageMyPolicyCSS = ".btn[href='/Personal/Manage-My-Policy']";
        string navBusinessCSS = "a[href='/Business']";
        string navJewelryBusinessCSS = "a[href='/jewelry-business-jewelers-block-bop-insurance']";
        string navShippingCSS = "a[href='/Shipping']";
        string navPawnbrokersCSS = "a[href='/pawn']";
        string navJMUniversityCSS = "a[href='/jm-university-retail-loss-prevention-tools']";
        string navJewelerProgramsCSS = "a[href='/customer-loyalty-programs-for-jewelers']";
        string navCLBlogCSS = "a[href='/clarity-blog']";
        string navCLPayMyBillCSS = "a[href='/Business/Pay-My-Bill']";
        string navAboutUsMenuCSS = "a[href='/About']";
        string navAboutUsCSS = "a[href='/About']";
        string navSocialResponsibilityCSS = "a[href='/social-responsibility']";
        string navCareersCSS = "a[href='/About/Careers']";
        string navLogInCSS = "a[href='/Log-In']";
        string navPersonalJewelryCSS = "a[href='/Log-In/Personal-Jewelry']";
        string navAgentCSS = "a[href='/Log-In/Agent']";

        // Footer
        string ftContactCSS = "a[href='/contact']";
        string ftPrivacyPolicyCSS = "a[href='/privacy-policy']";
        string ftTermsofUseCSS = "a[href='/terms-of-use']";
        string ftShareYourConcernsCSS = "a[href='/complaint-resolution-process']";
        string ftCareersCSS = "a[href='/careers']";
        string ftNewsroomCSS = "a[href='/Newsroom']";
        string ftFacebookCSS = "a[href='http://www.facebook.com/JewelersMutual'] use";
        string ftInstagramCSS = "a[href = 'http://www.instagram.com/JewelersMutual'] > .footer__social - icon";
        string ftTwitterCSS = "a[href='http://www.twitter.com/JewelersMutual'] use";
        string ftLinkedInCSS = "a[href='https://www.linkedin.com/company/jewelers-mutual-insurance-company'] use";
        string ftCoverageDisclaimerCSS = "div#block-legaltextinfooter p";
        string ftCopyrightYearCSS = "div.block-copyrightinformationinfooter--2 p";

        // Insurance Header
        string headerInsuranceCSS = "h4";
        string infoProtectCSS = "h1";

        // Get Covered Fast
        string iconCompanyCSS = "[alt='Adiamor']";
        string titleGetCoveredFastCSS = "h3";
        string infoGetCoveredFastCSS = "div.text-medium-left > p";
        string btnGetMyQuoteCSS = ".btn--primary";
        string linkStillWantAQuoteCSS = "h6 > a";
        string infoArrowCSS = "h6";

        Adiamor_D_V Adiamor_D_V = new Adiamor_D_V();
        public Adiamor_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify
            VerifyUIElementIsDisplayed(jmLogoCSS);
            VerifyUIElementIsDisplayed(navPersonalCSS);
            VerifyUIElementIsDisplayed(navPersonalInsuranceCSS);
            VerifyUIElementIsDisplayed(navGetAQuoteCSS);
            VerifyUIElementIsDisplayed(navClaimsCSS);
            VerifyUIElementIsDisplayed(navFAQCSS);
            VerifyUIElementIsDisplayed(navPLBlogCSS);
            VerifyUIElementIsDisplayed(navPLPayMyBillCSS);
            VerifyUIElementIsDisplayed(navManageMyPolicyCSS);
            VerifyUIElementIsDisplayed(navBusinessCSS);
            VerifyUIElementIsDisplayed(navJewelryBusinessCSS);
            VerifyUIElementIsDisplayed(navShippingCSS);
            VerifyUIElementIsDisplayed(navPawnbrokersCSS);
            VerifyUIElementIsDisplayed(navJMUniversityCSS);
            VerifyUIElementIsDisplayed(navJewelerProgramsCSS);
            VerifyUIElementIsDisplayed(navCLBlogCSS);
            VerifyUIElementIsDisplayed(navCLPayMyBillCSS);
            VerifyUIElementIsDisplayed(navAboutUsMenuCSS);
            VerifyUIElementIsDisplayed(navAboutUsCSS);
            VerifyUIElementIsDisplayed(navSocialResponsibilityCSS);
            VerifyUIElementIsDisplayed(navCareersCSS);
            VerifyUIElementIsDisplayed(navLogInCSS);
            VerifyUIElementIsDisplayed(navPersonalJewelryCSS);
            VerifyUIElementIsDisplayed(navAgentCSS);
            VerifyUIElementIsDisplayed(ftContactCSS);
            VerifyUIElementIsDisplayed(ftPrivacyPolicyCSS);
            VerifyUIElementIsDisplayed(ftTermsofUseCSS);
            VerifyUIElementIsDisplayed(ftShareYourConcernsCSS);
            VerifyUIElementIsDisplayed(ftCareersCSS);
            VerifyUIElementIsDisplayed(ftNewsroomCSS);
            VerifyUIElementIsDisplayed(ftFacebookCSS);
            VerifyUIElementIsDisplayed(ftInstagramCSS);
            VerifyUIElementIsDisplayed(ftTwitterCSS);
            VerifyUIElementIsDisplayed(ftLinkedInCSS);
            VerifyUIElementIsDisplayed(ftCoverageDisclaimerCSS);
            VerifyUIElementIsDisplayed(ftCopyrightYearCSS);
            VerifyUIElementIsDisplayed(headerInsuranceCSS);
            VerifyUIElementIsDisplayed(infoProtectCSS);
            VerifyUIElementIsDisplayed(iconCompanyCSS);
            VerifyUIElementIsDisplayed(titleGetCoveredFastCSS);
            VerifyUIElementIsDisplayed(infoGetCoveredFastCSS);
            VerifyUIElementIsDisplayed(btnGetMyQuoteCSS);
            VerifyUIElementIsDisplayed(linkStillWantAQuoteCSS);
            VerifyUIElementIsDisplayed(infoArrowCSS);

        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
        }

        public void verifyNavBar()
        {
            //Personal
            string NavPersonal = driver.FindElement(By.CssSelector(navPersonalCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPersonal, Adiamor_D_V.hrefPersonal, "The Text doesn't match");

            string NavPersonalInsurance = driver.FindElement(By.CssSelector(navPersonalInsuranceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPersonalInsurance, Adiamor_D_V.hrefPersonalInsurance, "The Text doesn't match");

            string NavGetAQuote = driver.FindElement(By.CssSelector(navGetAQuoteCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavGetAQuote, Adiamor_D_V.hrefGetAQuote, "The Text doesn't match");

            string NavClaims = driver.FindElement(By.CssSelector(navClaimsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavClaims, Adiamor_D_V.hrefClaims, "The Text doesn't match");

            string NavFAQ = driver.FindElement(By.CssSelector(navFAQCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavFAQ, Adiamor_D_V.hrefFAQ, "The Text doesn't match");

            string NavPLBlog = driver.FindElement(By.CssSelector(navPLBlogCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPLBlog, Adiamor_D_V.hrefPLBlog, "The Text doesn't match");

            string NavPLPayMyBill = driver.FindElement(By.CssSelector(navPLPayMyBillCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPLPayMyBill, Adiamor_D_V.hrefPLPayMyBill, "The Text doesn't match");

            string NavManageMyPolicy = driver.FindElement(By.CssSelector(navManageMyPolicyCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavManageMyPolicy, Adiamor_D_V.hrefManageMyPolicy, "The Text doesn't match");

            //Business
            string NavBusiness = driver.FindElement(By.CssSelector(navBusinessCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavBusiness, Adiamor_D_V.hrefBusiness, "The Text doesn't match");

            string NavJewelryBusiness = driver.FindElement(By.CssSelector(navJewelryBusinessCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavJewelryBusiness, Adiamor_D_V.hrefJewelryBusiness, "The Text doesn't match");

            string NavShipping = driver.FindElement(By.CssSelector(navShippingCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavShipping, Adiamor_D_V.hrefShipping, "The Text doesn't match");

            string NavPawnbrokers = driver.FindElement(By.CssSelector(navPawnbrokersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPawnbrokers, Adiamor_D_V.hrefPawnbrokers, "The Text doesn't match");

            string NavJMUniversity = driver.FindElement(By.CssSelector(navJMUniversityCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavJMUniversity, Adiamor_D_V.hrefJMUniversity, "The Text doesn't match");

            string NavJewelerPrograms = driver.FindElement(By.CssSelector(navJewelerProgramsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavClaims, Adiamor_D_V.hrefJewelerPrograms, "The Text doesn't match");

            string NavCLBlog = driver.FindElement(By.CssSelector(navCLBlogCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavCLBlog, Adiamor_D_V.hrefCLBlog, "The Text doesn't match");

            string NavCLPayMyBill = driver.FindElement(By.CssSelector(navCLPayMyBillCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavCLPayMyBill, Adiamor_D_V.hrefCLPAyMyBill, "The Text doesn't match");

            //About Us
            string NavAboutUsMenu = driver.FindElement(By.CssSelector(navAboutUsMenuCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavAboutUsMenu, Adiamor_D_V.hrefAboutUsMenu, "The Text doesn't match");

            string NavAboutUs = driver.FindElement(By.CssSelector(navAboutUsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavAboutUs, Adiamor_D_V.hrefAboutUs, "The Text doesn't match");

            string NavSocialResponsibility = driver.FindElement(By.CssSelector(navSocialResponsibilityCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavSocialResponsibility, Adiamor_D_V.hrefSocialResponsibilty, "The Text doesn't match");

            string NavCareers = driver.FindElement(By.CssSelector(navCareersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPawnbrokers, Adiamor_D_V.hrefCareers, "The Text doesn't match");

            //Log In
            string NavLogIn = driver.FindElement(By.CssSelector(navLogInCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavLogIn, Adiamor_D_V.hrefLogIn, "The Text doesn't match");

            string NavPersonalJewelry = driver.FindElement(By.CssSelector(navPersonalJewelryCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPersonalJewelry, Adiamor_D_V.hrefPersonalJewelry, "The Text doesn't match");

            string NavAgent = driver.FindElement(By.CssSelector(navAgentCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavAgent, Adiamor_D_V.hrefAgent, "The Text doesn't match");
        }
        public void verifyFooter()
        {
            //Footer
            string FtContact = driver.FindElement(By.CssSelector(ftContactCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtContact, Adiamor_D_V.hrefContact, "The Text doesn't match");

            string FtPrivacyPolicy = driver.FindElement(By.CssSelector(ftPrivacyPolicyCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtPrivacyPolicy, Adiamor_D_V.hrefPrivacyPolicy, "The Text doesn't match");

            string FtTermsofUse = driver.FindElement(By.CssSelector(ftTermsofUseCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtTermsofUse, Adiamor_D_V.hrefTermsofUse, "The Text doesn't match");

            string FtShareYourConcerns = driver.FindElement(By.CssSelector(ftShareYourConcernsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtShareYourConcerns, Adiamor_D_V.hrefShareYourConcern, "The Text doesn't match");

            string FtCareers = driver.FindElement(By.CssSelector(ftCareersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtCareers, Adiamor_D_V.hrefFTCareers, "The Text doesn't match");

            string FtNewsroom = driver.FindElement(By.CssSelector(ftNewsroomCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtNewsroom, Adiamor_D_V.hrefNewesroom, "The Text doesn't match");

            string FtCoverageDisclaimer = driver.FindElement(By.CssSelector(ftCoverageDisclaimerCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtCoverageDisclaimer, Adiamor_D_V.txtCoverageDisclaimer, "The Text doesn't match");

            string FtCopyrightYear = driver.FindElement(By.CssSelector(ftCopyrightYearCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtCopyrightYear, Adiamor_D_V.txtCopyrightYear, "The Text doesn't match");
        }

        public void verifyPJHeader()
        {
            // Insurance Header 
            string HeaderInsurance = driver.FindElement(By.CssSelector(headerInsuranceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderInsurance, Adiamor_D_V.txtHeaderInsurance, "The Text doesn't match");

            string InfoProtect = driver.FindElement(By.CssSelector(infoProtectCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoProtect, Adiamor_D_V.txtinfoProtect, "The Text doesn't match");

        }

        public void verifyWhatsCovered()
        {
            // Get Covered Fast
            string TitleGetCoveredFast = driver.FindElement(By.CssSelector(titleGetCoveredFastCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleGetCoveredFast, Adiamor_D_V.txtTitleGetCoveredFast, "The Text doesn't match");

            string InfoGetCoveredFast = driver.FindElement(By.CssSelector(infoGetCoveredFastCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoGetCoveredFast, Adiamor_D_V.txtInfoGetCoveredFast, "The Text doesn't match");

            string BtnGetMyQuote = driver.FindElement(By.CssSelector(btnGetMyQuoteCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnGetMyQuote, Adiamor_D_V.btnGetMyQuote, "The Text doesn't match");

            string LinkStillWantAQuote = driver.FindElement(By.CssSelector(linkStillWantAQuoteCSS)).GetAttribute("InnerText");
            Assert.AreEqual(LinkStillWantAQuote, Adiamor_D_V.hrefStillWantAQuote, "The Text doesn't match");

            string InfoArrow = driver.FindElement(By.CssSelector(infoArrowCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoArrow, Adiamor_D_V.txtInfoArrow, "The Text doesn't match");

        }
    }
}

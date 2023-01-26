using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalProject.Pages.Drupal
{
    class DrupalCommonPage
    {
        // logo
        string jmLogoCSS = "a[title='Home']";

        // Nav Bar - Personal                 
        string navPersonalXpath = "//a[text()='Personal']";
        string navPersonalInsuranceXpath = "//a[text()='Personal Insurance']";
        string navGetAQuoteXpath = "//a[text()='Get a Quote']";
        string navPLPayMyBillXpath = "//a[text()='Pay My Bill']";
        string navPLClaimsXpath = "//a[text()='Claims']";
        string navManageMyPolicyXpath = "//a[text()='Manage My Policy']";
        string navPLBlogXpath = "//a[text()='Blog']";
        //string navFAQXpath = "//a[text()='FAQ']";


        // Nav Bar - Business   
        string navBusinessXpath = "//a[text()='Business']";
        string navJewelryBusinessXpath = "//a[.='Business Insurance']";
        string navCLClaimsXpath = "//a[.='Claims']";
        string navCLPayMyBillXpath = "//a[text()='Pay My Bill']";
        string navZingPlatformXpath = "//a[.='Zing™ Platform']";
        string navShippingXpath = "//a[text()='JM Shipping Solution']";
        string navJMCarePlanXpath = "//a[.='JM Care Plan']";
        string navJewelerProgramsXpath = "//a[text()='Jeweler Programs']";
        string navPawnbrokersXpath = "//a[text()='Pawnbrokers']";
        //string navJMUniversityXpath = "//a[text()='JM University®']";
        //string navCLBlogXpath = "//a[text()='Blog']";

        //Nav Bar Answers
        string navAnswersXpath = "//a[.='Answers']";
        string navJewelryInsurance101Xpath = "//a[.='Jewelry Insurance 101']";
        string navFAQXpath = "//li[@class='menu-item menu-item--link-faq']/a[.='FAQ']";

        // Nav Bar - About Us 
        //string navAboutUsMenuXpath = "//li[@class='menu-item menu-item--link-about-us menu-item--expanded menu-item--top-level']/a[.='About Us']";
        string navAboutUsMenuXpath = "//a[.='About Us']";
        string navAboutUsXpath = "//a[text()='About Us']";
        string navSocialResponsibilityXpath = "//a[text()='Social Responsibility']";
        string navCareersXpath = "//a[text()='Careers']";

        // Nav Bar - Log In
        string navLogInXpath = "//a[text()='Log In']";
        string navPersonalJewelryLoginXpath = "//a[text()='Personal Jewelry']";
        string navAgentLoginXpath = "//a[text()='Agent']";
        string navZingPlatformLoginXpath = "//a[@href='https://zing.jewelersmutual.com']";

        // Footer
        //string ftContactXpath = "//a[text()='Contact']"
        string ftContactXpath = "//a[.='Contact Us']";
        string ftPrivacyXpath = "//a[@data-drupal-link-system-path='node/581']";
        string ftTermsofUseXpath = "//a[text()='Terms of Use']";
        string ftShareYourConcernsXpath = "//a[text()='Share Your Concerns']";
        string ftCareersXpath = "//a[text()='Careers']";
        string ftNewsroomXpath = "//a[text()='Newsroom']";
        string ftFacebookCSS = "div#block-socialmedialinks a[href *='www.facebook.com']";
        string ftInstagramCSS = "div#block-socialmedialinks a[href *='http://www.instagram.com/JewelersMutual']";
        string ftTwitterCSS = "div#block-socialmedialinks a[href *='http://www.twitter.com/JewelersMutual']";
        string ftLinkedInCSS = "div#block-socialmedialinks a[href *='https://www.linkedin.com/company/jewelers-mutual-insurance-company']";
        string ftCoverageDisclaimer1Xpath = "//p[contains(.,'Coverage is subject to underwriting review and approval, and to the actual policy terms and conditions. Any descriptions are a brief summary of coverage and are not part of any policies, nor a substitute for the actual policy language.')]";
        string ftCoverageDisclaimer2Xpath = "//p[contains(.,'Coverage is offered by a member insurer of the Jewelers Mutual Group, either Jewelers Mutual Insurance Company, SI (a stock insurer) or JM Specialty Insurance Company. Policyholders of both insurers are members of Jewelers Mutual Holding Company.')]";
        string ftCopyrightYearXpath = "//p[contains(.,'© 2021 Jewelers Mutual - All Rights Reserved')]";

        Home_D_V home_D_V = new Home_D_V();
        public void verifyNavBar(IWebDriver driver)
        {

            //Personal
            string NavPersonal = driver.FindElement(By.XPath(navPersonalXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavPersonal.ToLower().Trim(), home_D_V.hrefPersonal.ToLower().Trim(), "The Text doesn't match");

            string NavPersonalInsurance = driver.FindElement(By.XPath(navPersonalInsuranceXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavPersonalInsurance.ToLower().Trim(), home_D_V.hrefPersonalInsurance.ToLower().Trim(), "The Text doesn't match");

            string NavGetAQuote = driver.FindElement(By.XPath(navGetAQuoteXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavGetAQuote.ToLower().Trim(), home_D_V.hrefGetAQuote.ToLower().Trim(), "The Text doesn't match");

            string NavPLPayMyBill = driver.FindElement(By.XPath(navPLPayMyBillXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavPLPayMyBill.ToLower().Trim(), home_D_V.hrefPLPayMyBill.ToLower().Trim(), "The Text doesn't match");

            string NavClaims = driver.FindElement(By.XPath(navPLClaimsXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavClaims.ToLower().Trim(), home_D_V.hrefPLClaims.ToLower().Trim(), "The Text doesn't match");

            string NavManageMyPolicy = driver.FindElement(By.XPath(navManageMyPolicyXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavManageMyPolicy.ToLower().Trim(), home_D_V.hrefManageMyPolicy.ToLower().Trim(), "The Text doesn't match");

            string NavPLBlog = driver.FindElement(By.XPath(navPLBlogXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavPLBlog.ToLower().Trim(), home_D_V.hrefPLBlog.ToLower().Trim(), "The Text doesn't match");


            //Business
            string NavBusiness = driver.FindElement(By.XPath(navBusinessXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavBusiness.ToLower().Trim(), home_D_V.hrefBusiness.ToLower().Trim(), "The Text doesn't match");

            string NavJewelryBusiness = driver.FindElement(By.XPath(navJewelryBusinessXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavJewelryBusiness.ToLower().Trim(), home_D_V.hrefJewelryBusiness.ToLower().Trim(), "The Text doesn't match");

            string NavCLClaims = driver.FindElement(By.XPath(navCLClaimsXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavCLClaims.ToLower().Trim(), home_D_V.hrefCLClaims.ToLower().Trim(), "The Text doesn't match");

            string NavCLPayMyBill = driver.FindElement(By.XPath(navCLPayMyBillXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavCLPayMyBill.ToLower().Trim(), home_D_V.hrefCLPayMyBill.ToLower().Trim(), "The Text doesn't match");

            string NavZingPlatform = driver.FindElement(By.XPath(navZingPlatformXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavZingPlatform.ToLower().Trim(), home_D_V.hrefZingPlatform.ToLower().Trim(), "The Text doesn't match");

            string NavShipping = driver.FindElement(By.XPath(navShippingXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavShipping.ToLower().Trim(), home_D_V.hrefShipping.ToLower().Trim(), "The Text doesn't match");

            string NavJMCarePlan = driver.FindElement(By.XPath(navJMCarePlanXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavJMCarePlan.ToLower().Trim(), home_D_V.hrefJMCarePlan.ToLower().Trim(), "The Text doesn't match");

            string NavJewelerPrograms = driver.FindElement(By.XPath(navJewelerProgramsXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavJewelerPrograms.ToLower().Trim(), home_D_V.hrefJewelerPrograms.ToLower().Trim(), "The Text doesn't match");

            string NavPawnbrokers = driver.FindElement(By.XPath(navPawnbrokersXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavPawnbrokers.ToLower().Trim(), home_D_V.hrefPawnbrokers.ToLower().Trim(), "The Text doesn't match");

            //string NavJMUniversity = driver.FindElement(By.XPath(navJMUniversityXpath)).GetAttribute("innerText");
            //Assert.AreEqual(NavJMUniversity.ToLower().Trim(), home_D_V.hrefJMUniversity.ToLower().Trim(), "The Text doesn't match");

            //string NavCLBlog = driver.FindElement(By.XPath(navCLBlogXpath)).GetAttribute("innerText");
            //Assert.AreEqual(NavCLBlog.ToLower().Trim(), home_D_V.hrefCLBlog.ToLower().Trim(), "The Text doesn't match");

            //Answers
            string NavAnswers = driver.FindElement(By.XPath(navAnswersXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavAnswers.ToLower().Trim(), home_D_V.hrefAnswers.ToLower().Trim(), "The Text doesn't match");

            string NavJewelryInsurance101 = driver.FindElement(By.XPath(navJewelryInsurance101Xpath)).GetAttribute("innerText");
            Assert.AreEqual(NavJewelryInsurance101.ToLower().Trim(), home_D_V.hrefJewelryInsurance101.ToLower().Trim(), "The Text doesn't match");

            string NavFAQ = driver.FindElement(By.XPath(navFAQXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavFAQ.ToLower().Trim(), home_D_V.hrefFAQ.ToLower().Trim(), "The Text doesn't match");

            //About Us
            string NavAboutUsMenu = driver.FindElement(By.XPath(navAboutUsMenuXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavAboutUsMenu.ToLower().Trim(), home_D_V.hrefAboutUsMenu.ToLower().Trim(), "The Text doesn't match");

            string NavAboutUs = driver.FindElement(By.XPath(navAboutUsXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavAboutUs.ToLower().Trim(), home_D_V.hrefAboutUs.ToLower().Trim(), "The Text doesn't match");

            string NavSocialResponsibility = driver.FindElement(By.XPath(navSocialResponsibilityXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavSocialResponsibility.ToLower().Trim(), home_D_V.hrefSocialResponsibilty.ToLower().Trim(), "The Text doesn't match");

            string NavCareers = driver.FindElement(By.XPath(navCareersXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavCareers.ToLower().Trim(), home_D_V.hrefCareers.ToLower().Trim(), "The Text doesn't match");

            //Log In
            string NavLogIn = driver.FindElement(By.XPath(navLogInXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavLogIn.ToLower().Trim(), home_D_V.hrefLogIn.ToLower().Trim(), "The Text doesn't match");

            string NavPersonalJewelryLogin = driver.FindElement(By.XPath(navPersonalJewelryLoginXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavPersonalJewelryLogin.ToLower().Trim(), home_D_V.hrefPersonalJewelryLogin.ToLower().Trim(), "The Text doesn't match");

            string NavAgentLogin = driver.FindElement(By.XPath(navAgentLoginXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavAgentLogin.ToLower().Trim(), home_D_V.hrefAgentLogin.ToLower().Trim(), "The Text doesn't match");

            string NavZingPlatformLogin = driver.FindElement(By.XPath(navZingPlatformLoginXpath)).GetAttribute("innerText");
            Assert.AreEqual(NavZingPlatformLogin.ToLower().Trim(), home_D_V.hrefZingPlatformLogin.ToLower().Trim(), "The Text doesn't match");

        }
        public void verifyFooter(IWebDriver driver)
        {
            //Footer
            string FtContact = driver.FindElement(By.XPath(ftContactXpath)).GetAttribute("innerText");
            Assert.AreEqual(FtContact.ToLower().Trim(), home_D_V.hrefContact.ToLower().Trim(), "The Text doesn't match");

            string FtPrivacy = driver.FindElement(By.XPath(ftPrivacyXpath)).GetAttribute("innerText");
            Assert.AreEqual(FtPrivacy.ToLower().Trim(), home_D_V.hrefPrivacyPolicy.ToLower().Trim(), "The Text doesn't match");

            string FtTermsofUse = driver.FindElement(By.XPath(ftTermsofUseXpath)).GetAttribute("innerText");
            Assert.AreEqual(FtTermsofUse.ToLower().Trim(), home_D_V.hrefTermsofUse.ToLower().Trim(), "The Text doesn't match");

            string FtShareYourConcerns = driver.FindElement(By.XPath(ftShareYourConcernsXpath)).GetAttribute("innerText");
            Assert.AreEqual(FtShareYourConcerns.ToLower().Trim(), home_D_V.hrefShareYourConcern.ToLower().Trim(), "The Text doesn't match");

            string FtCareers = driver.FindElement(By.XPath(ftCareersXpath)).GetAttribute("innerText");
            Assert.AreEqual(FtCareers.ToLower().Trim(), home_D_V.hrefFTCareers.ToLower().Trim(), "The Text doesn't match");

            string FtNewsroom = driver.FindElement(By.XPath(ftNewsroomXpath)).GetAttribute("innerText");
            Assert.AreEqual(FtNewsroom.ToLower().Trim(), home_D_V.hrefNewesroom.ToLower().Trim(), "The Text doesn't match");

            string FtCoverageDisclaimer1 = driver.FindElement(By.XPath(ftCoverageDisclaimer1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(FtCoverageDisclaimer1.ToLower().Trim(), home_D_V.txtCoverageDisclaimer1.ToLower().Trim(), "The Text doesn't match");

            string FtCoverageDisclaimer2 = driver.FindElement(By.XPath(ftCoverageDisclaimer2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(FtCoverageDisclaimer2.ToLower().Trim(), home_D_V.txtCoverageDisclaimer2.ToLower().Trim(), "The Text doesn't match");

            string FtCopyrightYear = driver.FindElement(By.XPath(ftCopyrightYearXpath)).GetAttribute("innerText");
            Assert.AreEqual(FtCopyrightYear.ToLower().Trim(), home_D_V.txtCopyrightYear.ToLower().Trim(), "The Text doesn't match");

        }
    }
}

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
    class EarringInsurance_D : Page
    {
        //Elements

        // Earring Insurance Page Images


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

        // Red. Set. Protect. Header
        string headerReadyCSS = "h1";
        string titleThreeStepsCSS = "div.hero__content > p";
        string btnStartQuoteNowCSS = "div.hero__content > .btn";

        // What's covered?
        string headerWhatsCoveredCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s covered?\" block'] h2";
        string infoWhatsCoveredCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s covered?\" block'] p";
        string iconDamageCSS = "[alt='damaged earrings graphic']";
        string titleDamageCSS = ".spacing--bottom.info-grid > div:nth-of-type(1) > h4";
        string infoDamageCSS = ".spacing--bottom.info-grid > div:nth-of-type(1) p";
        string iconDisappearanceCSS = "[alt='disappearing earrings graphic']";
        string titleDisappearanceCSS = ".spacing--bottom.info-grid > div:nth-of-type(2) > h4";
        string infoDisappearanceCSS = ".spacing--bottom.info-grid > div:nth-of-type(2) p";
        string iconLossCSS = "[alt='loss graphic']";
        string titleLossCSS = ".spacing--bottom.info-grid > div:nth-of-type(3) > h4";
        string infoLossCSS = ".spacing--bottom.info-grid > div:nth-of-type(3) p";
        string iconTheftCSS = "[alt='ski mask graphic']";
        string titleTheftCSS = ".spacing--bottom.info-grid > div:nth-of-type(4) > h4";
        string infoTheftCSS = ".spacing--bottom.info-grid > div:nth-of-type(4) p";       
        string iconWorldWideCoverageCSS = "[alt='worldwide map graphic']";
        string titleWorldWideCoverageCSS = ".spacing--bottom.info-grid > div:nth-of-type(5) > h4";
        string infoWorldWideCoverageCSS = ".spacing--bottom.info-grid > div:nth-of-type(5) p";

        // What's not covered?
        string headerWhatnotCoveredCSS = "div.background-color- h2";
        string iconCrittersCSS = "[alt='critters graphic']";
        string titleCrittersCSS = "div.background-color- div:nth-of-type(1) > h4";
        string infoCrittersfCSS = "div.background-color- .info-grid > div:nth-of-type(1) p";
        string iconDeteriorationCSS = "[alt='deteriorating earrings graphic']";
        string titleDeteriorationCSS = "div.background-color- div:nth-of-type(2) > h4";
        string infoDeteriorationCSS = "div.background-color- .info-grid > div:nth-of-type(2) p";
        string iconIntentionalActionsCSS = "[alt='intentional actions graphic']";
        string titleIntentionalActionsCSS = "div.background-color- div:nth-of-type(3) > h4";
        string infoIntentionalActionsCSS = "div.background-color- div:nth-of-type(3) p";
        string iconWarCSS = "[alt='shield graphic']";
        string titleWareCSS = "div.background-color- div:nth-of-type(4) > h4";
        string infoWarCSS = "div.background-color- div:nth-of-type(4) p";

        // What about homeowners?
        string headerHomeownersCSS = "div[data-layout-content-preview-placeholder-label='\"What about homeowners?\" block'] h2";
        string infoHomeownersCSS = "div[data-layout-content-preview-placeholder-label='\"What about homeowners?\" block'] p";

        // What Our Policyholders Say
        string headerPolicyholdersCSS = "div.block--type-block-content13310d8b-6ea7-46ff-8378-d84a47f524f9 h2";

        //Questions
        string headerQuestionsCSS = "div.block--type-inline-blockaccordion h2";
        string titleWhoisJMCSS = "h4[aria-controls='ui-id-2']";
        string infoWhoeisJMCSS = "div[aria-labelledby='ui-id-1'] > p";
        string titleInsuranceWorkCSS = "h4[aria-controls='ui-id-4']";
        string infoInsuranceWork1CSS = "div[aria-labelledby='ui-id-3'] > p:nth-of-type(1)";
        string infoInsuranceWork2CSS = "div[aria-labelledby='ui-id-3'] > p:nth-of-type(2)";
        string titleCostCSS = "h4[aria-controls='ui-id-6']";
        string infoCostCSS = "div[aria-labelledby='ui-id-5'] > p";

        // It all comes down to trust
        string headerTrustCSS = "div.feature-row h2";
        string infoTrustCSS = "div.spacing-4x > p";
        string btnDownloadCSS = "div.feature-row .btn";


        EarringInsurance_D_V EarringInsurance_D_V = new EarringInsurance_D_V();
        public EarringInsurance_D(IWebDriver driver) : base(driver)
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
            VerifyUIElementIsDisplayed(ftCoverageDisclaimerCSS);
            VerifyUIElementIsDisplayed(ftCopyrightYearCSS);
            VerifyUIElementIsDisplayed(headerReadyCSS);
            VerifyUIElementIsDisplayed(titleThreeStepsCSS);
            VerifyUIElementIsDisplayed(btnStartQuoteNowCSS);
            VerifyUIElementIsDisplayed(headerWhatsCoveredCSS);
            VerifyUIElementIsDisplayed(infoWhatsCoveredCSS);
            VerifyUIElementIsDisplayed(iconDamageCSS);
            VerifyUIElementIsDisplayed(titleDamageCSS);
            VerifyUIElementIsDisplayed(infoDamageCSS);
            VerifyUIElementIsDisplayed(iconDisappearanceCSS);
            VerifyUIElementIsDisplayed(titleDisappearanceCSS);
            VerifyUIElementIsDisplayed(infoDisappearanceCSS);
            VerifyUIElementIsDisplayed(iconLossCSS);
            VerifyUIElementIsDisplayed(titleLossCSS);
            VerifyUIElementIsDisplayed(infoLossCSS);
            VerifyUIElementIsDisplayed(iconTheftCSS);
            VerifyUIElementIsDisplayed(titleTheftCSS);
            VerifyUIElementIsDisplayed(infoTheftCSS);
            VerifyUIElementIsDisplayed(iconWorldWideCoverageCSS);
            VerifyUIElementIsDisplayed(titleWorldWideCoverageCSS);
            VerifyUIElementIsDisplayed(infoWorldWideCoverageCSS);
            VerifyUIElementIsDisplayed(ftCoverageDisclaimerCSS);
            VerifyUIElementIsDisplayed(ftCopyrightYearCSS);
            VerifyUIElementIsDisplayed(headerWhatnotCoveredCSS);
            VerifyUIElementIsDisplayed(iconCrittersCSS);
            VerifyUIElementIsDisplayed(titleCrittersCSS);
            VerifyUIElementIsDisplayed(infoCrittersfCSS);
            VerifyUIElementIsDisplayed(iconDeteriorationCSS);
            VerifyUIElementIsDisplayed(titleDeteriorationCSS);
            VerifyUIElementIsDisplayed(infoDeteriorationCSS);
            VerifyUIElementIsDisplayed(iconIntentionalActionsCSS);
            VerifyUIElementIsDisplayed(titleIntentionalActionsCSS);
            VerifyUIElementIsDisplayed(infoIntentionalActionsCSS);
            VerifyUIElementIsDisplayed(iconWarCSS);
            VerifyUIElementIsDisplayed(titleWareCSS);
            VerifyUIElementIsDisplayed(infoWarCSS);
            VerifyUIElementIsDisplayed(headerHomeownersCSS);
            VerifyUIElementIsDisplayed(infoHomeownersCSS);
            VerifyUIElementIsDisplayed(headerPolicyholdersCSS);
            VerifyUIElementIsDisplayed(headerQuestionsCSS);
            VerifyUIElementIsDisplayed(titleWhoisJMCSS);
            VerifyUIElementIsDisplayed(infoWhoeisJMCSS);
            VerifyUIElementIsDisplayed(titleInsuranceWorkCSS);
            VerifyUIElementIsDisplayed(infoInsuranceWork1CSS);
            VerifyUIElementIsDisplayed(infoInsuranceWork2CSS);
            VerifyUIElementIsDisplayed(titleCostCSS);
            VerifyUIElementIsDisplayed(infoCostCSS);
            VerifyUIElementIsDisplayed(headerTrustCSS);
            VerifyUIElementIsDisplayed(infoTrustCSS);
            VerifyUIElementIsDisplayed(btnDownloadCSS);
  
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
        }

        public void verifyNavBar()
        {
            //Personal
            string NavPersonal = driver.FindElement(By.CssSelector(navPersonalCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPersonal, EarringInsurance_D_V.hrefPersonal, "The Text doesn't match");

            string NavPersonalInsurance = driver.FindElement(By.CssSelector(navPersonalInsuranceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPersonalInsurance, EarringInsurance_D_V.hrefPersonalInsurance, "The Text doesn't match");

            string NavGetAQuote = driver.FindElement(By.CssSelector(navGetAQuoteCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavGetAQuote, EarringInsurance_D_V.hrefGetAQuote, "The Text doesn't match");

            string NavClaims = driver.FindElement(By.CssSelector(navClaimsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavClaims, EarringInsurance_D_V.hrefClaims, "The Text doesn't match");

            string NavFAQ = driver.FindElement(By.CssSelector(navFAQCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavFAQ, EarringInsurance_D_V.hrefFAQ, "The Text doesn't match");

            string NavPLBlog = driver.FindElement(By.CssSelector(navPLBlogCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPLBlog, EarringInsurance_D_V.hrefPLBlog, "The Text doesn't match");

            string NavPLPayMyBill = driver.FindElement(By.CssSelector(navPLPayMyBillCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPLPayMyBill, EarringInsurance_D_V.hrefPLPayMyBill, "The Text doesn't match");

            string NavManageMyPolicy = driver.FindElement(By.CssSelector(navManageMyPolicyCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavManageMyPolicy, EarringInsurance_D_V.hrefManageMyPolicy, "The Text doesn't match");

            //Business
            string NavBusiness = driver.FindElement(By.CssSelector(navBusinessCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavBusiness, EarringInsurance_D_V.hrefBusiness, "The Text doesn't match");

            string NavJewelryBusiness = driver.FindElement(By.CssSelector(navJewelryBusinessCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavJewelryBusiness, EarringInsurance_D_V.hrefJewelryBusiness, "The Text doesn't match");

            string NavShipping = driver.FindElement(By.CssSelector(navShippingCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavShipping, EarringInsurance_D_V.hrefShipping, "The Text doesn't match");

            string NavPawnbrokers = driver.FindElement(By.CssSelector(navPawnbrokersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPawnbrokers, EarringInsurance_D_V.hrefPawnbrokers, "The Text doesn't match");

            string NavJMUniversity = driver.FindElement(By.CssSelector(navJMUniversityCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavJMUniversity, EarringInsurance_D_V.hrefJMUniversity, "The Text doesn't match");

            string NavJewelerPrograms = driver.FindElement(By.CssSelector(navJewelerProgramsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavClaims, EarringInsurance_D_V.hrefJewelerPrograms, "The Text doesn't match");

            string NavCLBlog = driver.FindElement(By.CssSelector(navCLBlogCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavCLBlog, EarringInsurance_D_V.hrefCLBlog, "The Text doesn't match");

            string NavCLPayMyBill = driver.FindElement(By.CssSelector(navCLPayMyBillCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavCLPayMyBill, EarringInsurance_D_V.hrefCLPAyMyBill, "The Text doesn't match");

            //About Us
            string NavAboutUsMenu = driver.FindElement(By.CssSelector(navAboutUsMenuCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavAboutUsMenu, EarringInsurance_D_V.hrefAboutUsMenu, "The Text doesn't match");

            string NavAboutUs = driver.FindElement(By.CssSelector(navAboutUsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavAboutUs, EarringInsurance_D_V.hrefAboutUs, "The Text doesn't match");

            string NavSocialResponsibility = driver.FindElement(By.CssSelector(navSocialResponsibilityCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavSocialResponsibility, EarringInsurance_D_V.hrefSocialResponsibilty, "The Text doesn't match");

            string NavCareers = driver.FindElement(By.CssSelector(navCareersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPawnbrokers, EarringInsurance_D_V.hrefCareers, "The Text doesn't match");

            //Log In
            string NavLogIn = driver.FindElement(By.CssSelector(navLogInCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavLogIn, EarringInsurance_D_V.hrefLogIn, "The Text doesn't match");

            string NavPersonalJewelry = driver.FindElement(By.CssSelector(navPersonalJewelryCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavPersonalJewelry, EarringInsurance_D_V.hrefPersonalJewelry, "The Text doesn't match");

            string NavAgent = driver.FindElement(By.CssSelector(navAgentCSS)).GetAttribute("InnerText");
            Assert.AreEqual(NavAgent, EarringInsurance_D_V.hrefAgent, "The Text doesn't match");
        }
        public void verifyFooter()
        {
            //Footer
            string FtContact = driver.FindElement(By.CssSelector(ftContactCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtContact, EarringInsurance_D_V.hrefContact, "The Text doesn't match");

            string FtPrivacyPolicy = driver.FindElement(By.CssSelector(ftPrivacyPolicyCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtPrivacyPolicy, EarringInsurance_D_V.hrefPrivacyPolicy, "The Text doesn't match");

            string FtTermsofUse = driver.FindElement(By.CssSelector(ftTermsofUseCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtTermsofUse, EarringInsurance_D_V.hrefTermsofUse, "The Text doesn't match");

            string FtShareYourConcerns = driver.FindElement(By.CssSelector(ftShareYourConcernsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtShareYourConcerns, EarringInsurance_D_V.hrefShareYourConcern, "The Text doesn't match");

            string FtCareers = driver.FindElement(By.CssSelector(ftCareersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtCareers, EarringInsurance_D_V.hrefFTCareers, "The Text doesn't match");

            string FtNewsroom = driver.FindElement(By.CssSelector(ftNewsroomCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtNewsroom, EarringInsurance_D_V.hrefNewesroom, "The Text doesn't match");

            string FtCoverageDisclaimer = driver.FindElement(By.CssSelector(ftCoverageDisclaimerCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtCoverageDisclaimer, EarringInsurance_D_V.txtCoverageDisclaimer, "The Text doesn't match");

            string FtCopyrightYear = driver.FindElement(By.CssSelector(ftCopyrightYearCSS)).GetAttribute("InnerText");
            Assert.AreEqual(FtCopyrightYear, EarringInsurance_D_V.txtCopyrightYear, "The Text doesn't match");
        }

        public void verifyReady()
        {
            // Red. Set. Protect. Header
            string HeaderReady = driver.FindElement(By.CssSelector(headerReadyCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderReady, EarringInsurance_D_V.txtHeaderReady, "The Text doesn't match");

            string TitleThreeSteps = driver.FindElement(By.CssSelector(titleThreeStepsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleThreeSteps, EarringInsurance_D_V.txtTitleThreeSteps, "The Text doesn't match");

            string BtnStartQuoteNow = driver.FindElement(By.CssSelector(btnStartQuoteNowCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnStartQuoteNow, EarringInsurance_D_V.btnCalculateMyRate, "The Text doesn't match");
            
        }

        public void verifyWhatsCovered()
        {
            // What's covered?
            string HeaderWhatsCovered = driver.FindElement(By.CssSelector(headerWhatsCoveredCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderWhatsCovered, EarringInsurance_D_V.txtHeaderWhatsCovered, "The Text doesn't match");

            string InfoWhatsCovered = driver.FindElement(By.CssSelector(infoWhatsCoveredCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWhatsCovered, EarringInsurance_D_V.txtInfoWhatsCovered, "The Text doesn't match");

            string TitleDamage = driver.FindElement(By.CssSelector(titleDamageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDamage, EarringInsurance_D_V.txtTitleDamage, "The Text doesn't match");

            string InfoDamage = driver.FindElement(By.CssSelector(infoDamageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDamage, EarringInsurance_D_V.txtInfoDamage, "The Text doesn't match");

            string TitleDisappearance = driver.FindElement(By.CssSelector(titleDisappearanceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDisappearance, EarringInsurance_D_V.txtTitleDisappearance, "The Text doesn't match");

            string InfoDisappearance = driver.FindElement(By.CssSelector(infoDisappearanceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDisappearance, EarringInsurance_D_V.txtInfoDisappearance, "The Text doesn't match");

            string TitleLoss = driver.FindElement(By.CssSelector(titleLossCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDamage, EarringInsurance_D_V.txtTitleLoss, "The Text doesn't match");

            string InfoLoss = driver.FindElement(By.CssSelector(infoLossCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDamage, EarringInsurance_D_V.txtInfoLoss, "The Text doesn't match");

            string TitleTheft = driver.FindElement(By.CssSelector(titleTheftCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDisappearance, EarringInsurance_D_V.txtTitleTheft, "The Text doesn't match");

            string InfoTheft = driver.FindElement(By.CssSelector(infoTheftCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDisappearance, EarringInsurance_D_V.txtInfoTheft, "The Text doesn't match");

            string TitleWorldWideCoverage = driver.FindElement(By.CssSelector(titleWorldWideCoverageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWorldWideCoverage, EarringInsurance_D_V.txtTitleWorldWideCoverage, "The Text doesn't match");

            string InfoWorldWideCoverage = driver.FindElement(By.CssSelector(infoWorldWideCoverageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWorldWideCoverage, EarringInsurance_D_V.txtInfoWorldWideCoverage, "The Text doesn't match");
        }

        public void verifyNotCovered()
        {
            // What's not covered?
            string HeaderWhatnotCovered = driver.FindElement(By.CssSelector(headerWhatnotCoveredCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderWhatnotCovered, EarringInsurance_D_V.txtHeaderWhatnotCovered, "The Text doesn't match");

            string TitleCritters = driver.FindElement(By.CssSelector(titleCrittersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleCritters, EarringInsurance_D_V.txtTitleCritters, "The Text doesn't match");

            string InfoCrittersf = driver.FindElement(By.CssSelector(infoCrittersfCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoCrittersf, EarringInsurance_D_V.txtInfoCritters, "The Text doesn't match");

            string TitleDeterioration = driver.FindElement(By.CssSelector(titleDeteriorationCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDeterioration, EarringInsurance_D_V.txtTitleDeterioration, "The Text doesn't match");

            string InfoDeterioration = driver.FindElement(By.CssSelector(infoDeteriorationCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDeterioration, EarringInsurance_D_V.txtInfoDeterioration, "The Text doesn't match");

            string TitleIntentionalActions = driver.FindElement(By.CssSelector(titleIntentionalActionsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleIntentionalActions, EarringInsurance_D_V.txtTitleIntentionalActions, "The Text doesn't match");

            string InfoIntentionalActions = driver.FindElement(By.CssSelector(infoIntentionalActionsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoIntentionalActions, EarringInsurance_D_V.txtInfoIntentionalActions, "The Text doesn't match");

            string TitleWare = driver.FindElement(By.CssSelector(titleWareCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWare, EarringInsurance_D_V.txtTitleWar, "The Text doesn't match");

            string InfoWar = driver.FindElement(By.CssSelector(infoWarCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWar, EarringInsurance_D_V.txtInfoWar, "The Text doesn't match");
        }

        public void verifyHomeowners()
        {
            // What about homeowners?

            string HeaderHomeowners = driver.FindElement(By.CssSelector(headerHomeownersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderHomeowners, EarringInsurance_D_V.txtHeaderHomeowners, "The Text doesn't match");

            string InfoHomeowners = driver.FindElement(By.CssSelector(infoHomeownersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoHomeowners, EarringInsurance_D_V.txtInfoHomeowners, "The Text doesn't match");
        }

        public void verifyQuestions()
        {
            //Questions

            string HeaderQuestions = driver.FindElement(By.CssSelector(headerQuestionsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderQuestions, EarringInsurance_D_V.txtHeaderQuestions, "The Text doesn't match");

            string TitleWhoisJM = driver.FindElement(By.CssSelector(titleWhoisJMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWhoisJM, EarringInsurance_D_V.txtTitleWhoisJM, "The Text doesn't match");

            string InfoWhoeisJM = driver.FindElement(By.CssSelector(infoWhoeisJMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWhoeisJM, EarringInsurance_D_V.txtInfoWhoeisJM, "The Text doesn't match");

            string TitleInsuranceWork = driver.FindElement(By.CssSelector(titleInsuranceWorkCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleInsuranceWork, EarringInsurance_D_V.txtTitleInsuranceWork, "The Text doesn't match");

            string InfoInsuranceWork1 = driver.FindElement(By.CssSelector(infoInsuranceWork1CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoInsuranceWork1, EarringInsurance_D_V.txtInfoInsuranceWork1, "The Text doesn't match");

            string InfoInsuranceWork2 = driver.FindElement(By.CssSelector(infoInsuranceWork2CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoInsuranceWork2, EarringInsurance_D_V.txtInfoInsuranceWork2, "The Text doesn't match");

            string TitleCost = driver.FindElement(By.CssSelector(titleCostCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleCost, EarringInsurance_D_V.txtTitleCost, "The Text doesn't match");

            string InfoCost = driver.FindElement(By.CssSelector(infoCostCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoCost, EarringInsurance_D_V.txtInfoCost, "The Text doesn't match");

        }

        public void verifyDownToTrust()
        {
            // It all comes down to trust

            string HeaderTrust = driver.FindElement(By.CssSelector(headerTrustCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderTrust, EarringInsurance_D_V.txtHeaderTrust, "The Text doesn't match");

            string InfoTrust = driver.FindElement(By.CssSelector(infoTrustCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTrust, EarringInsurance_D_V.txtInfoTrust, "The Text doesn't match");

            string BtnDownload = driver.FindElement(By.CssSelector(btnDownloadCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnDownload, EarringInsurance_D_V.btnDownload, "The Text doesn't match");

        }
    }
}

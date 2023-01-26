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
    class Homeowners_D : Page
    {
        // Elements  

        // Homeowners Page Images


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

        // Homeowners Header
        string headerMasterpieceCSS = "h1";
        string infoMasterpieceCSS = "div.hero__content > p";
        string btnWhatWillCSS = "div.hero__content > .btn";
        string iconFeaturedCSS = ".hero__tout";

        // How the Big Names Compare to the Experts
        string headerBigNamesCSS = "div.block--type-block-content6ceb88eb-b3e2-4db5-a9f7-6d9f5902e33f h2";
        string infoSeeHowWeCompareCSS = "thead th:nth-of-type(1)";
        string infoJewelersMutualCSS = "thead th:nth-of-type(2)";
        string infoTypicalHomeownersCSS = "thead th:nth-of-type(3)";
        string chartLossCSS = "tbody > tr:nth-of-type(1) > td:nth-of-type(1)";
        string chartLossCheckmarkCSS = "tbody > tr:nth-of-type(1) [alt='checkmark']";
        string chartLossXCSS = "tbody > tr:nth-of-type(1) [alt='X symbol']";
        string chartTheftCSS = "tbody > tr:nth-of-type(2) > td:nth-of-type(1)";
        string chartTheftCheckmark1CSS = "tbody > tr:nth-of-type(2) > td:nth-of-type(2) > [alt='checkmark']";
        string chartTheftCheckmark2CSS = "tbody > tr:nth-of-type(2) > td:nth-of-type(3) > [alt='checkmark']";
        string chartDamageCSS = "tbody > tr:nth-of-type(3) > td:nth-of-type(1)";
        string chartDamageCheckmarkCSS = "tbody > tr:nth-of-type(3) [alt='checkmark']";
        string chartDamageNotCSS = "tbody > tr:nth-of-type(3) > td:nth-of-type(3)";
        string chartDisappearanceCSS = "tbody > tr:nth-of-type(4) > td:nth-of-type(1)";
        string chartDisappearanceCheckmarkCSS = "tbody > tr:nth-of-type(4) [alt='checkmark']";
        string chartDisapperanceXCSS = "tbody > tr:nth-of-type(4) [alt='X symbol']";
        string chartFloodCSS = "tbody > tr:nth-of-type(5) > td:nth-of-type(1)";
        string chartFloodCheckmarkCSS = "tbody > tr:nth-of-type(5) [alt='checkmark']";
        string chartFloodNotCSS = "tbody > tr:nth-of-type(5) > td:nth-of-type(3)";
        string chartWorldwideCSS = "tbody > tr:nth-of-type(6) > td:nth-of-type(1)";
        string chartWorldwideCheckmark1CSS = "tbody > tr:nth-of-type(6) > td:nth-of-type(2) > [alt='checkmark']";
        string chartWorldwideCheckmark2CSS = "tbody > tr:nth-of-type(6) > td:nth-of-type(3) > [alt='checkmark']";
        string chartOutofPocketCSS = "tbody > tr:nth-of-type(7) > td:nth-of-type(1)";
        string chartOutofPocket0CSS = "tbody > tr:nth-of-type(7) > td:nth-of-type(2)";
        string chartHomeownersCSS = "tbody > tr:nth-of-type(7) > td:nth-of-type(3)";
        string chartEffectsofClaimsCSS = ".jm-rt-title";
        string chartInfoCSS = ".jm-rt-subtitle";
        string iconChartCSS = "[alt='illustrated house']";

        // Tell me more
        string titleTellMeMoreCSS = "div#basic-code-block-tell-me-more h4";
        string info5MinuteCSS = "div#basic-code-block-tell-me-more span";
        string infoTellMeMore1CSS = "div#basic-code-block-tell-me-more .content-lg > p:nth-of-type(1)";
        string linkReadMoreCSS = ".more-details--show";
        string infoTellMeMore2CSS = "div.more-details > p:nth-of-type(1)";
        string infoTellMeMore3CSS = "div.more-details > p:nth-of-type(2)";
        string infoTellMeMore4CSS = "div.more-details > p:nth-of-type(3)";
        string linkCloseCSS = ".more-details--close";

        // What Jewelers Mutual Covers
        string headerWhatsCoveredCSS = "div.title-row > h2";
        string infoWhatsCoveredCSS = "div.title-row p";
        string iconLossCSS = "[alt='dotted circle']";
        string titleLossCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] div:nth-of-type(1) > h4";
        string infoLossCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] .info-grid > div:nth-of-type(1) p";
        string iconTheftCSS = "[alt='ski mask graphic']";
        string titleTheftCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] div:nth-of-type(2) > h4";
        string infoTheftCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] .info-grid > div:nth-of-type(2) p";
        string iconDamageCSS = "[alt='damaged ring graphic']";
        string titleDamageCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] div:nth-of-type(3) > h4";
        string infoDamageCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] div:nth-of-type(3) p";
        string iconDisappearanceCSS = "[alt='disappearance graphic']";
        string titleDisappearanceCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] div:nth-of-type(4) > h4";
        string infoDisappearanceCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] div:nth-of-type(4) p";
        string iconWorldWideCoverageCSS = "[alt='world map graphic']";
        string titleWorldWideCoverageCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] div:nth-of-type(5) > h4";
        string infoWorldWideCoverageCSS = "div[data-layout-content-preview-placeholder-label='\"What\'s Covered info grid\" block'] div:nth-of-type(5) p";

        // What Jewelers Mutual Doesn’t Cover
        string headerWhatnotCoveredCSS = "div.background-color-gray h2";
        string iconWarCSS = "[alt='shield graphic']";
        string titleWareCSS = "div.background-color-gray div:nth-of-type(1) > h4";
        string infoWarCSS = "div.background-color-gray .info-grid > div:nth-of-type(1) p";
        string iconDeteriorationCSS = "[alt='deterioration graphic']";
        string titleDeteriorationCSS = "div.background-color-gray div:nth-of-type(2) > h4";
        string infoDeteriorationCSS = "[alt='intentional actions graphic']";
        string iconIntentionalActionsCSS = "div.grid-layout-three > div:nth-of-type(1) li:nth-of-type(3)";
        string titleIntentionalActionsCSS = "div.background-color-gray div:nth-of-type(3) > h4";
        string infoIntentionalActionsCSS = "div.background-color-gray div:nth-of-type(3) p";
        string iconCrittersCSS = "[alt='critters graphic']";
        string titleCrittersCSS = "div.background-color-gray div:nth-of-type(4) > h4";
        string infoCrittersfCSS = "div.background-color-gray div:nth-of-type(4) p";

        // What Our Policyholders Say
        string headerPolicyholdersCSS = "div.block--type-block-content13310d8b-6ea7-46ff-8378-d84a47f524f9 h2";

        // What it Costs
        string headerWhatItCostsCSS = "div[data-layout-content-preview-placeholder-label='\" What it Costs\" block'] h2";
        string icon72CSS = "div.grid-layout-two > div:nth-of-type(1) > .text-val";
        string icon72yearlyMCSS = "div.grid-layout-two > div:nth-of-type(1) > .text-yr";
        string info72JMCSS = "div.grid-layout-two > div:nth-of-type(1) p";
        string icon38CSS = "div.grid-layout-two > div:nth-of-type(2) > .text-val";
        string icon38yearlyMCSS = "div.grid-layout-two > div:nth-of-type(2) > .text-yr";
        string info38JMCSS = "div.grid-layout-two > div:nth-of-type(2) p";
        string icon50CSS = "div.grid-layout-two > div:nth-of-type(3) > .text-val";
        string icon50yearlyMCSS = "div.grid-layout-two > div:nth-of-type(3) > .text-yr";
        string info50JMCSS = "div.grid-layout-two > div:nth-of-type(3) p";
        string icon98CSS = "div.grid-layout-two > div:nth-of-type(4) > .text-val";
        string icon98yearlyMCSS = "div.grid-layout-two > div:nth-of-type(4) > .text-yr";
        string info98JMCSS = "div.grid-layout-two > div:nth-of-type(4) p";
        string icon93CSS = "div.grid-layout-two > div:nth-of-type(5) > .text-val";
        string icon93yearlyMCSS = "div.grid-layout-two > div:nth-of-type(5) > .text-yr";
        string info93JMCSS = "div.grid-layout-two > div:nth-of-type(5) p";
        string icon55CSS = "div.grid-layout-two > div:nth-of-type(6) > .text-val";
        string icon55yearlyMCSS = "div.grid-layout-two > div:nth-of-type(6) > .text-yr";
        string info55JMCSS = "div.grid-layout-two > div:nth-of-type(6) p";
        string icon36CSS = "div.grid-layout-two > div:nth-of-type(7) > .text-val";
        string icon36yearlyMCSS = "div.grid-layout-two > div:nth-of-type(7) > .text-yr";
        string info36JMCSS = "div.grid-layout-two > div:nth-of-type(7) p";
        string icon84CSS = "div.grid-layout-two > div:nth-of-type(8) > .text-val";
        string icon84yearlyMCSS = "div.grid-layout-two > div:nth-of-type(8) > .text-yr";
        string info84JMCSS = "div.grid-layout-two > div:nth-of-type(8) p";

        // Check Your Rate
        string headerCheckYourRateCSS = ".text-center.content-lg > h2";
        string infoCheckYourRateCSS = ".text-center.content-lg p";
        string btnGetPricingCSS = ".text-center.content-lg > .btn";

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
        string headerTrustCSS = "div.background-color--white h2";
        string infoTrustCSS = "div.background-color--white p";
        string btnDownloadCSS = "div.background-color--white .btn";

        Homeowners_D_V Homeowners_D_V = new Homeowners_D_V();
        public Homeowners_D(IWebDriver driver) : base(driver)
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
            VerifyUIElementIsDisplayed(headerMasterpieceCSS);
            VerifyUIElementIsDisplayed(infoMasterpieceCSS);
            VerifyUIElementIsDisplayed(btnWhatWillCSS);
            VerifyUIElementIsDisplayed(iconFeaturedCSS);
            VerifyUIElementIsDisplayed(headerBigNamesCSS);
            VerifyUIElementIsDisplayed(infoSeeHowWeCompareCSS);
            VerifyUIElementIsDisplayed(infoJewelersMutualCSS);
            VerifyUIElementIsDisplayed(infoTypicalHomeownersCSS);
            VerifyUIElementIsDisplayed(chartLossCSS);
            VerifyUIElementIsDisplayed(chartLossCheckmarkCSS);
            VerifyUIElementIsDisplayed(chartLossXCSS);
            VerifyUIElementIsDisplayed(chartTheftCSS);
            VerifyUIElementIsDisplayed(chartTheftCheckmark1CSS);
            VerifyUIElementIsDisplayed(chartTheftCheckmark2CSS);
            VerifyUIElementIsDisplayed(chartDamageCSS);
            VerifyUIElementIsDisplayed(chartDamageCheckmarkCSS);
            VerifyUIElementIsDisplayed(chartDamageNotCSS);
            VerifyUIElementIsDisplayed(chartDisappearanceCSS);
            VerifyUIElementIsDisplayed(chartDisappearanceCheckmarkCSS);
            VerifyUIElementIsDisplayed(chartDisapperanceXCSS);
            VerifyUIElementIsDisplayed(titleLossCSS);
            VerifyUIElementIsDisplayed(infoLossCSS);
            VerifyUIElementIsDisplayed(titleTheftCSS);
            VerifyUIElementIsDisplayed(infoTheftCSS);
            VerifyUIElementIsDisplayed(titleDamageCSS);
            VerifyUIElementIsDisplayed(infoDamageCSS);
            VerifyUIElementIsDisplayed(titleDisappearanceCSS);
            VerifyUIElementIsDisplayed(infoDisappearanceCSS);
            VerifyUIElementIsDisplayed(chartFloodCSS);
            VerifyUIElementIsDisplayed(chartFloodCheckmarkCSS);
            VerifyUIElementIsDisplayed(chartFloodNotCSS);
            VerifyUIElementIsDisplayed(chartWorldwideCSS);
            VerifyUIElementIsDisplayed(chartWorldwideCheckmark1CSS);
            VerifyUIElementIsDisplayed(chartWorldwideCheckmark2CSS);
            VerifyUIElementIsDisplayed(chartOutofPocketCSS);
            VerifyUIElementIsDisplayed(chartOutofPocket0CSS);
            VerifyUIElementIsDisplayed(chartHomeownersCSS);
            VerifyUIElementIsDisplayed(chartEffectsofClaimsCSS);
            VerifyUIElementIsDisplayed(chartInfoCSS);
            VerifyUIElementIsDisplayed(iconChartCSS);
            VerifyUIElementIsDisplayed(titleTellMeMoreCSS);
            VerifyUIElementIsDisplayed(info5MinuteCSS);
            VerifyUIElementIsDisplayed(infoTellMeMore1CSS);
            VerifyUIElementIsDisplayed(linkReadMoreCSS);
            VerifyUIElementIsDisplayed(infoTellMeMore2CSS);
            VerifyUIElementIsDisplayed(infoTellMeMore3CSS);
            VerifyUIElementIsDisplayed(infoTellMeMore4CSS);
            VerifyUIElementIsDisplayed(linkCloseCSS);
            VerifyUIElementIsDisplayed(headerWhatsCoveredCSS);
            VerifyUIElementIsDisplayed(infoWhatsCoveredCSS);
            VerifyUIElementIsDisplayed(iconLossCSS);
            VerifyUIElementIsDisplayed(titleLossCSS);
            VerifyUIElementIsDisplayed(infoLossCSS);
            VerifyUIElementIsDisplayed(iconTheftCSS);
            VerifyUIElementIsDisplayed(titleTheftCSS);
            VerifyUIElementIsDisplayed(infoTheftCSS);
            VerifyUIElementIsDisplayed(iconDamageCSS);
            VerifyUIElementIsDisplayed(titleDamageCSS);
            VerifyUIElementIsDisplayed(infoDamageCSS);
            VerifyUIElementIsDisplayed(iconDisappearanceCSS);
            VerifyUIElementIsDisplayed(titleDisappearanceCSS);
            VerifyUIElementIsDisplayed(infoDisappearanceCSS);
            VerifyUIElementIsDisplayed(iconWorldWideCoverageCSS);
            VerifyUIElementIsDisplayed(titleWorldWideCoverageCSS);
            VerifyUIElementIsDisplayed(infoWorldWideCoverageCSS);
            VerifyUIElementIsDisplayed(headerWhatnotCoveredCSS);
            VerifyUIElementIsDisplayed(iconWarCSS);
            VerifyUIElementIsDisplayed(titleWareCSS);
            VerifyUIElementIsDisplayed(infoWarCSS);
            VerifyUIElementIsDisplayed(iconDeteriorationCSS);
            VerifyUIElementIsDisplayed(titleDeteriorationCSS);
            VerifyUIElementIsDisplayed(infoDeteriorationCSS);
            VerifyUIElementIsDisplayed(iconIntentionalActionsCSS);
            VerifyUIElementIsDisplayed(titleIntentionalActionsCSS);
            VerifyUIElementIsDisplayed(infoIntentionalActionsCSS);
            VerifyUIElementIsDisplayed(iconCrittersCSS);
            VerifyUIElementIsDisplayed(titleCrittersCSS);
            VerifyUIElementIsDisplayed(infoCrittersfCSS);
            VerifyUIElementIsDisplayed(headerPolicyholdersCSS);
            VerifyUIElementIsDisplayed(headerWhatItCostsCSS);
            VerifyUIElementIsDisplayed(icon72CSS);
            VerifyUIElementIsDisplayed(icon72yearlyMCSS);
            VerifyUIElementIsDisplayed(info72JMCSS);
            VerifyUIElementIsDisplayed(icon38CSS);
            VerifyUIElementIsDisplayed(icon38yearlyMCSS);
            VerifyUIElementIsDisplayed(info38JMCSS);
            VerifyUIElementIsDisplayed(icon50CSS);
            VerifyUIElementIsDisplayed(icon50yearlyMCSS);
            VerifyUIElementIsDisplayed(info50JMCSS);
            VerifyUIElementIsDisplayed(icon98CSS);
            VerifyUIElementIsDisplayed(icon98yearlyMCSS);
            VerifyUIElementIsDisplayed(info98JMCSS);
            VerifyUIElementIsDisplayed(icon93CSS);
            VerifyUIElementIsDisplayed(icon93yearlyMCSS);
            VerifyUIElementIsDisplayed(info93JMCSS);
            VerifyUIElementIsDisplayed(icon55CSS);
            VerifyUIElementIsDisplayed(icon55yearlyMCSS);
            VerifyUIElementIsDisplayed(info55JMCSS);
            VerifyUIElementIsDisplayed(icon36CSS);
            VerifyUIElementIsDisplayed(icon36yearlyMCSS);
            VerifyUIElementIsDisplayed(info36JMCSS);
            VerifyUIElementIsDisplayed(icon84CSS);
            VerifyUIElementIsDisplayed(icon84yearlyMCSS);
            VerifyUIElementIsDisplayed(info84JMCSS);
            VerifyUIElementIsDisplayed(headerCheckYourRateCSS);
            VerifyUIElementIsDisplayed(infoCheckYourRateCSS);
            VerifyUIElementIsDisplayed(btnGetPricingCSS);
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
            DrupalCommonPage drupalCommon = new DrupalCommonPage();
            drupalCommon.verifyNavBar(driver);
        }
        public void verifyFooter()
        {
            DrupalCommonPage drupalCommon = new DrupalCommonPage();
            drupalCommon.verifyFooter(driver);
        }

        public void verifyJB()
        {
            // Homeowners Header
            string HeaderMasterpiece = driver.FindElement(By.CssSelector(headerMasterpieceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderMasterpiece, Homeowners_D_V.txtHeaderMasterpiece, "The Text doesn't match");

            string InfoMasterpiece = driver.FindElement(By.CssSelector(infoMasterpieceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoMasterpiece, Homeowners_D_V.txtInfoMasterpiece, "The Text doesn't match");

            string BtnWhatWill = driver.FindElement(By.CssSelector(btnWhatWillCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnWhatWill, Homeowners_D_V.btnWhatWill, "The Text doesn't match");

            string IconFeatured = driver.FindElement(By.CssSelector(iconFeaturedCSS)).GetAttribute("InnerText");
            Assert.AreEqual(IconFeatured, Homeowners_D_V.txtFeatured, "The Text doesn't match");

        }

        public void verifyComparetoExperts()
        {
            // How the Big Names Compare to the Experts
            string HeaderBigNames = driver.FindElement(By.CssSelector(headerBigNamesCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderBigNames, Homeowners_D_V.txtHeaderBigNames, "The Text doesn't match");

            string InfoSeeHowWeCompare = driver.FindElement(By.CssSelector(infoSeeHowWeCompareCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoSeeHowWeCompare, Homeowners_D_V.txtSeeHowWeCompare, "The Text doesn't match");

            string InfoJewelersMutual = driver.FindElement(By.CssSelector(infoJewelersMutualCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoJewelersMutual, Homeowners_D_V.txtJewelersMutual, "The Text doesn't match");

            string InfoTypicalHomeowners = driver.FindElement(By.CssSelector(infoTypicalHomeownersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTypicalHomeowners, Homeowners_D_V.txtTypicalHomeowners, "The Text doesn't match");

            string ChartLoss = driver.FindElement(By.CssSelector(chartLossCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartLoss, Homeowners_D_V.txtLossChart, "The Text doesn't match");

            string ChartTheft = driver.FindElement(By.CssSelector(chartTheftCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartTheft, Homeowners_D_V.txtTheftChart, "The Text doesn't match");

            string ChartDamage = driver.FindElement(By.CssSelector(chartDamageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartDamage, Homeowners_D_V.txtDamageChart, "The Text doesn't match");

            string ChartDamageNot = driver.FindElement(By.CssSelector(chartDamageNotCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartDamageNot, Homeowners_D_V.txtDamagaChartNot, "The Text doesn't match");

            string ChartDisappearance = driver.FindElement(By.CssSelector(chartDisappearanceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartDisappearance, Homeowners_D_V.txtDisapperanceChart, "The Text doesn't match");

            string ChartFlood = driver.FindElement(By.CssSelector(chartFloodCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartFlood, Homeowners_D_V.txtFloodChart, "The Text doesn't match");

            string ChartFloodNot = driver.FindElement(By.CssSelector(chartFloodNotCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartFloodNot, Homeowners_D_V.txtFloodChartNot, "The Text doesn't match");

            string ChartWorldwide = driver.FindElement(By.CssSelector(chartWorldwideCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartWorldwide, Homeowners_D_V.txtWorldideTravel, "The Text doesn't match");

            string ChartOutofPocket = driver.FindElement(By.CssSelector(chartOutofPocketCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartOutofPocket, Homeowners_D_V.txtxtOutofPocketCost, "The Text doesn't match");

            string ChartOutofPocket0 = driver.FindElement(By.CssSelector(chartOutofPocket0CSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartOutofPocket0, Homeowners_D_V.txt0, "The Text doesn't match");

            string ChartHomeowners = driver.FindElement(By.CssSelector(chartHomeownersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartHomeowners, Homeowners_D_V.txtHomeownersDedcuctible, "The Text doesn't match");

            string ChartEffectsofClaims = driver.FindElement(By.CssSelector(chartEffectsofClaimsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartEffectsofClaims, Homeowners_D_V.txtEffectsofClaims, "The Text doesn't match");

            string ChartInfo = driver.FindElement(By.CssSelector(chartInfoCSS)).GetAttribute("InnerText");
            Assert.AreEqual(ChartInfo, Homeowners_D_V.txtEffectsofClaimsInfo, "The Text doesn't match");
        }


        public void verifyTellMeMore()
        {
            // Tell me more
            string TitleTellMeMore = driver.FindElement(By.CssSelector(titleTellMeMoreCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleTellMeMore, Homeowners_D_V.txtTitleTellMeMore, "The Text doesn't match");

            string Info5Minute = driver.FindElement(By.CssSelector(info5MinuteCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info5Minute, Homeowners_D_V.txtInfo5Minute, "The Text doesn't match");

            string InfoTellMeMore1 = driver.FindElement(By.CssSelector(infoTellMeMore1CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTellMeMore1, Homeowners_D_V.txtInfoTellMeMore1, "The Text doesn't match");

            string LinkReadMore = driver.FindElement(By.CssSelector(linkReadMoreCSS)).GetAttribute("InnerText");
            Assert.AreEqual(LinkReadMore, Homeowners_D_V.hrefReadMore, "The Text doesn't match");

            string InfoTellMeMore2 = driver.FindElement(By.CssSelector(infoTellMeMore2CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTellMeMore2, Homeowners_D_V.txtInfoTellMeMore2, "The Text doesn't match");

            string InfoTellMeMore3 = driver.FindElement(By.CssSelector(infoTellMeMore3CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTellMeMore3, Homeowners_D_V.txtInfoTellMeMore3, "The Text doesn't match");

            string InfoTellMeMore4 = driver.FindElement(By.CssSelector(infoTellMeMore4CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTellMeMore4, Homeowners_D_V.txtInfoTellMeMore4, "The Text doesn't match");

            string LinkClose = driver.FindElement(By.CssSelector(linkCloseCSS)).GetAttribute("InnerText");
            Assert.AreEqual(LinkClose, Homeowners_D_V.hrefClose, "The Text doesn't match");
        }

        public void verifyWhatsCovered()
        {
            // What Jewelers Mutual Covers
            string HeaderWhatsCovered = driver.FindElement(By.CssSelector(headerWhatsCoveredCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderWhatsCovered, Homeowners_D_V.txtHeaderWhatsCovered, "The Text doesn't match");

            string InfoWhatsCovered = driver.FindElement(By.CssSelector(infoWhatsCoveredCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWhatsCovered, Homeowners_D_V.txtInfoWhatsCovered, "The Text doesn't match");

            string TitleLoss = driver.FindElement(By.CssSelector(titleLossCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleLoss, Homeowners_D_V.txtTitleLoss, "The Text doesn't match");

            string InfoLoss = driver.FindElement(By.CssSelector(infoLossCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoLoss, Homeowners_D_V.txtInfoLoss, "The Text doesn't match");

            string TitleTheft = driver.FindElement(By.CssSelector(titleTheftCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleTheft, Homeowners_D_V.txtTitleTheft, "The Text doesn't match");

            string InfoTheft = driver.FindElement(By.CssSelector(infoTheftCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTheft, Homeowners_D_V.txtInfoTheft, "The Text doesn't match");

            string TitleDamage = driver.FindElement(By.CssSelector(titleDamageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDamage, Homeowners_D_V.txtTitleDamageSS, "The Text doesn't match");

            string InfoDamage = driver.FindElement(By.CssSelector(infoDamageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDamage, Homeowners_D_V.txtInfoDamage, "The Text doesn't match");

            string TitleDisappearance = driver.FindElement(By.CssSelector(titleDisappearanceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDisappearance, Homeowners_D_V.txtTitleDisappearance, "The Text doesn't match");

            string InfoDisappearance = driver.FindElement(By.CssSelector(infoDisappearanceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDisappearance, Homeowners_D_V.txtInfoDisappearance, "The Text doesn't match");

            string TitleWorldWideCoverage = driver.FindElement(By.CssSelector(titleWorldWideCoverageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWorldWideCoverage, Homeowners_D_V.txtTitleWorldWideCoverage, "The Text doesn't match");

            string InfoWorldWideCoverage = driver.FindElement(By.CssSelector(infoWorldWideCoverageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWorldWideCoverage, Homeowners_D_V.txtInfoWorldWideCoverage, "The Text doesn't match");
        }

        public void verifyNotCovered()
        {
            // What Jewelers Mutual Doesn’t Cover
            string HeaderWhatnotCovered = driver.FindElement(By.CssSelector(headerWhatnotCoveredCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderWhatnotCovered, Homeowners_D_V.txtHeaderWhatnotCovered, "The Text doesn't match");

            string TitleWare = driver.FindElement(By.CssSelector(titleWareCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWare, Homeowners_D_V.txtTitleWare, "The Text doesn't match");

            string InfoWar = driver.FindElement(By.CssSelector(infoWarCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWar, Homeowners_D_V.txtInfoWar, "The Text doesn't match");

            string TitleDeterioration = driver.FindElement(By.CssSelector(titleDeteriorationCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDeterioration, Homeowners_D_V.txtTitleDeterioration, "The Text doesn't match");

            string InfoDeterioration = driver.FindElement(By.CssSelector(infoDeteriorationCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDeterioration, Homeowners_D_V.txtInfoDeterioration, "The Text doesn't match");

            string TitleIntentionalActions = driver.FindElement(By.CssSelector(titleIntentionalActionsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleIntentionalActions, Homeowners_D_V.txtTitleIntentionalActions, "The Text doesn't match");

            string InfoIntentionalActions = driver.FindElement(By.CssSelector(infoIntentionalActionsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoIntentionalActions, Homeowners_D_V.txtInfoIntentionalActions, "The Text doesn't match");

            string TitleCritters = driver.FindElement(By.CssSelector(titleCrittersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleCritters, Homeowners_D_V.txtTitleCritters, "The Text doesn't match");

            string InfoCrittersf = driver.FindElement(By.CssSelector(infoCrittersfCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoCrittersf, Homeowners_D_V.txtInfoCrittersf, "The Text doesn't match");
        }

        public void verifyPolicyholders()
        {
            // What Our Policyholders Say

            string HeaderPolicyholders = driver.FindElement(By.CssSelector(headerPolicyholdersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderPolicyholders, Homeowners_D_V.txtHeaderPolicyholders, "The Text doesn't match");
        }

        public void verifyWhatitCosts()
        {
            // What it Costs

            string HeaderWhatItCosts = driver.FindElement(By.CssSelector(headerWhatItCostsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderWhatItCosts, Homeowners_D_V.txtHeaderWhatItCosts, "The Text doesn't match");

            string Info72JM = driver.FindElement(By.CssSelector(info72JMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info72JM, Homeowners_D_V.txtInfo72JM, "The Text doesn't match");

            string Info38JM = driver.FindElement(By.CssSelector(info38JMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info38JM, Homeowners_D_V.txtInfo38JM, "The Text doesn't match");

            string Info50JM = driver.FindElement(By.CssSelector(info50JMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info50JM, Homeowners_D_V.txtInfo50JM, "The Text doesn't match");

            string Info98JM = driver.FindElement(By.CssSelector(info98JMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info98JM, Homeowners_D_V.txtInfo98JM, "The Text doesn't match");

            string Info93JM = driver.FindElement(By.CssSelector(info93JMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info93JM, Homeowners_D_V.txtInfo93JM, "The Text doesn't match");

            string Info55JM = driver.FindElement(By.CssSelector(info55JMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info55JM, Homeowners_D_V.txtInfo55JM, "The Text doesn't match");

            string Info36JM = driver.FindElement(By.CssSelector(info36JMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info36JM, Homeowners_D_V.txtInfo36JM, "The Text doesn't match");

            string Info84JM = driver.FindElement(By.CssSelector(info84JMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(Info84JM, Homeowners_D_V.txtInfo84JM, "The Text doesn't match");

        }

        public void verifyCheckYourRate()
        {
            // Check Your Rate

            string HeaderCheckYourRate = driver.FindElement(By.CssSelector(headerCheckYourRateCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderCheckYourRate, Homeowners_D_V.txtHeaderCheckYourRate, "The Text doesn't match");

            string InfoCheckYourRate = driver.FindElement(By.CssSelector(infoCheckYourRateCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoCheckYourRate, Homeowners_D_V.txtInfoCheckYourRate, "The Text doesn't match");

            string BtnGetPricing = driver.FindElement(By.CssSelector(btnGetPricingCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnGetPricing, Homeowners_D_V.btnGetPricing, "The Text doesn't match");
        }

        public void verifyQuestions()
        {
            //Questions

            string HeaderQuestions = driver.FindElement(By.CssSelector(headerQuestionsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderQuestions, Homeowners_D_V.txtHeaderQuestions, "The Text doesn't match");

            string TitleWhoisJM = driver.FindElement(By.CssSelector(titleWhoisJMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWhoisJM, Homeowners_D_V.txtTitleWhoisJM, "The Text doesn't match");

            string InfoWhoeisJM = driver.FindElement(By.CssSelector(infoWhoeisJMCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWhoeisJM, Homeowners_D_V.txtInfoWhoeisJM, "The Text doesn't match");

            string TitleInsuranceWork = driver.FindElement(By.CssSelector(titleInsuranceWorkCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleInsuranceWork, Homeowners_D_V.txtTitleInsuranceWork, "The Text doesn't match");

            string InfoInsuranceWork1 = driver.FindElement(By.CssSelector(infoInsuranceWork1CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoInsuranceWork1, Homeowners_D_V.txtInfoInsuranceWork1, "The Text doesn't match");

            string InfoInsuranceWork2 = driver.FindElement(By.CssSelector(infoInsuranceWork2CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoInsuranceWork2, Homeowners_D_V.txtInfoInsuranceWork2, "The Text doesn't match");

            string TitleCost = driver.FindElement(By.CssSelector(titleCostCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleCost, Homeowners_D_V.txtTitleCost, "The Text doesn't match");

            string InfoCost = driver.FindElement(By.CssSelector(infoCostCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoCost, Homeowners_D_V.txtInfoCost, "The Text doesn't match");

        }

        public void verifyDownToTrust()
        {
            // It all comes down to trust

            string HeaderTrust = driver.FindElement(By.CssSelector(headerTrustCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderTrust, Homeowners_D_V.txtHeaderTrust, "The Text doesn't match");

            string InfoTrust = driver.FindElement(By.CssSelector(infoTrustCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTrust, Homeowners_D_V.txtInfoTrust, "The Text doesn't match");

            string BtnDownload = driver.FindElement(By.CssSelector(btnDownloadCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnDownload, Homeowners_D_V.btnDownload, "The Text doesn't match");

        }

        public void verifyHomeownersPageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyJB();
            verifyComparetoExperts();
            verifyTellMeMore();
            verifyWhatsCovered();
            verifyNotCovered();
            verifyPolicyholders();
            verifyWhatitCosts();
            verifyCheckYourRate();
            verifyQuestions();
            verifyDownToTrust();

        }

    }
}

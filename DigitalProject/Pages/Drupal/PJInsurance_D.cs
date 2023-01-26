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
    class PJInsurance_D : Page
    {
        // Elements  

        // PJ Insurance Page Images




        // Personal Jewelery Insurance Header
        string headerPJInsuranceFromCSS = "div.hero__content > h4";
        string infoPJInsuranceFromCSS = "h1";
        string btnWhatWillItCostMeCSS = "div.hero__content > .btn";
        string linkRetreveYourSavedCSS = "div.hero__cta-footer a";

        // Protecting All Things Jewelry Since 1913
        string titleProtectingAllThingsCSS = "div.text-medium-left > h2";
        string infoProtectAllThingsCSS = "div.text-medium-left > p";
        string linkMoreAboutOurHistoryCSS = "div.text-medium-left [href='/about-us']";
        string iconValutCSS = "[alt='Safe Image']";

        // What's Covered
        string titleWhatsCoveredCSS = "div.title-row > h2";
        string infoWhatsCovered1CSS = "div.title-row p:nth-of-type(1)";
        string infoWhatsCovered2CSS = "div.title-row p:nth-of-type(2)";
        string titleLossCSS = "div.info-grid > div:nth-of-type(1) > h4";
        string infoLossCSS = "div.info-grid > div:nth-of-type(1) p";
        string titleTheftCSS = "div.info-grid > div:nth-of-type(2) > h4";
        string infoTheftCSS = "div.info-grid > div:nth-of-type(2) p";
        string titleDamageCSS = "div.info-grid > div:nth-of-type(3) > h4";
        string infoDamageCSS = "div.info-grid > div:nth-of-type(3) p";
        string titleDisappearanceCSS = "div.info-grid > div:nth-of-type(4) > h4";
        string infoDisappearanceCSS = "div.info-grid > div:nth-of-type(4) p";

        //The Case Against Homeowners
        string titleWhyNotHomeownersCSS = "div[data-layout-content-preview-placeholder-label='\"Why Not Homeowners?\" block'] h2";
        string infoWhyNotHomeowners1CSS = "div[data-layout-content-preview-placeholder-label='\"Why Not Homeowners?\" block'] p:nth-of-type(1)";
        string infoWhyNotHomeowners2CSS = "div[data-layout-content-preview-placeholder-label='\"Why Not Homeowners?\" block'] p:nth-of-type(2)";
        string linkSeeOurFAQCSS = "div[data-layout-content-preview-placeholder-label='\"Why Not Homeowners?\" block'] [href='/jewelry-insurance-policy-information']";

        // Check Your Rate
        string iconCheckYourRateCSS = "[alt='list icon with checkmark']";
        string titleCheckYourRateCSS = "div.background-color--gray h2";
        string infoCheckYourRate1CSS = "div.background-color--gray .formatted_text > p:nth-of-type(1)";
        string infoCheckYourRate2CSS = "div.background-color--gray p:nth-of-type(2)";
        string infoCheckYourRate3CSS = "div.background-color--gray p:nth-of-type(3)";
        string linkRetriveYourApplicationCSS = "div.background-color--gray .formatted_text a";
        string btnGetPricingCSS = "div.background-color--gray .btn";
        string disclaimerCheckYourRateCSS = "div.background-color--gray .disclaimer > p";

        //How It All Works
        string titleHowItAllWorksCSS = "div[data-layout-content-preview-placeholder-label='\"How It All Works title bar\" block'] h2";
        string iconCheckmarkRingCSS = "[alt='ring with check mark']";
        string icon1CSS = "div.block--type-inline-blocktimeline > .block--content > div:nth-of-type(1) .numbering";
        string titleEstimateYourRateCSS = "div.block--type-inline-blocktimeline > .block--content > div:nth-of-type(1) h4:nth-of-type(2)";
        string infoEstimateYourRateCSS = "div.block--type-inline-blocktimeline > .block--content > div:nth-of-type(1) p";
        string icon2CSS = "div.block--type-inline-blocktimeline > .block--content > div:nth-of-type(2) .numbering";
        string titleApplyForCoverageCSS = "div.block--type-inline-blocktimeline > .block--content > div:nth-of-type(2) h4:nth-of-type(2)";
        string infoApplyForCoverageCSS = "div.block--type-inline-blocktimeline > .block--content > div:nth-of-type(2) p";
        string iconDocumentCSS = "[alt='document']";
        string iconDiamonRingCSS = "[alt='ring sparkling']";
        string icon3CSS = "div.block--type-inline-blocktimeline div:nth-of-type(3) .numbering";
        string titleWearYourJewelryCSS = "div.block--type-inline-blocktimeline div:nth-of-type(3) h4:nth-of-type(2)";
        string infoWearYourJewelryCSS = "div.block--type-inline-blocktimeline div:nth-of-type(3) p";
        string icon4CSS = "div.block--type-inline-blocktimeline div:nth-of-type(4) .numbering";
        string titleFileaClaimCSS = "div.block--type-inline-blocktimeline div:nth-of-type(4) h4:nth-of-type(2)";
        string infoFileaClaimCSS = "div.block--type-inline-blocktimeline div:nth-of-type(4) p";
        string iconPhoneCSS = "[alt='cell phone']";

        //All Things Jewelry Insurance, ALL in One Place
        string titleAllThingsJewelryCSS = ".spacing.feature-row h2";
        string infoAllthingsJewelryCSS = ".spacing.feature-row p";
        string btnDownloadYourGuideCSS = ".spacing.feature-row .btn";


        PJInsurance_D_V PJInsurance_D_V = new PJInsurance_D_V();
        public PJInsurance_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify

            VerifyUIElementIsDisplayed(headerPJInsuranceFromCSS);
            VerifyUIElementIsDisplayed(infoPJInsuranceFromCSS);
            VerifyUIElementIsDisplayed(btnWhatWillItCostMeCSS);
            VerifyUIElementIsDisplayed(linkRetreveYourSavedCSS);
            VerifyUIElementIsDisplayed(titleProtectingAllThingsCSS);
            VerifyUIElementIsDisplayed(infoProtectAllThingsCSS);
            VerifyUIElementIsDisplayed(linkMoreAboutOurHistoryCSS);
            VerifyUIElementIsDisplayed(iconValutCSS);
            VerifyUIElementIsDisplayed(titleWhatsCoveredCSS);
            VerifyUIElementIsDisplayed(infoWhatsCovered1CSS);
            VerifyUIElementIsDisplayed(infoWhatsCovered2CSS);
            VerifyUIElementIsDisplayed(titleLossCSS);
            VerifyUIElementIsDisplayed(infoLossCSS);
            VerifyUIElementIsDisplayed(titleTheftCSS);
            VerifyUIElementIsDisplayed(infoTheftCSS);
            VerifyUIElementIsDisplayed(titleDamageCSS);
            VerifyUIElementIsDisplayed(infoDamageCSS);
            VerifyUIElementIsDisplayed(titleDisappearanceCSS);
            VerifyUIElementIsDisplayed(infoDisappearanceCSS);
            VerifyUIElementIsDisplayed(titleWhyNotHomeownersCSS);
            VerifyUIElementIsDisplayed(infoWhyNotHomeowners1CSS);
            VerifyUIElementIsDisplayed(infoWhyNotHomeowners2CSS);
            VerifyUIElementIsDisplayed(linkSeeOurFAQCSS);
            VerifyUIElementIsDisplayed(iconCheckYourRateCSS);
            VerifyUIElementIsDisplayed(titleCheckYourRateCSS);
            VerifyUIElementIsDisplayed(infoCheckYourRate1CSS);
            VerifyUIElementIsDisplayed(infoCheckYourRate2CSS);
            VerifyUIElementIsDisplayed(infoCheckYourRate3CSS);
            VerifyUIElementIsDisplayed(linkRetriveYourApplicationCSS);
            VerifyUIElementIsDisplayed(btnGetPricingCSS);
            VerifyUIElementIsDisplayed(disclaimerCheckYourRateCSS);
            VerifyUIElementIsDisplayed(infoLossCSS);
            VerifyUIElementIsDisplayed(titleTheftCSS);
            VerifyUIElementIsDisplayed(infoTheftCSS);
            VerifyUIElementIsDisplayed(titleDamageCSS);
            VerifyUIElementIsDisplayed(infoDamageCSS);
            VerifyUIElementIsDisplayed(titleDisappearanceCSS);
            VerifyUIElementIsDisplayed(infoDisappearanceCSS);
            VerifyUIElementIsDisplayed(titleWhyNotHomeownersCSS);
            VerifyUIElementIsDisplayed(infoWhyNotHomeowners1CSS);
            VerifyUIElementIsDisplayed(infoWhyNotHomeowners2CSS);
            VerifyUIElementIsDisplayed(linkSeeOurFAQCSS);
            VerifyUIElementIsDisplayed(iconCheckYourRateCSS);
            VerifyUIElementIsDisplayed(titleCheckYourRateCSS);
            VerifyUIElementIsDisplayed(infoCheckYourRate1CSS);
            VerifyUIElementIsDisplayed(infoCheckYourRate2CSS);
            VerifyUIElementIsDisplayed(infoCheckYourRate3CSS);
            VerifyUIElementIsDisplayed(linkRetriveYourApplicationCSS);
            VerifyUIElementIsDisplayed(btnGetPricingCSS);
            VerifyUIElementIsDisplayed(disclaimerCheckYourRateCSS);
            VerifyUIElementIsDisplayed(titleHowItAllWorksCSS);
            VerifyUIElementIsDisplayed(iconCheckmarkRingCSS);
            VerifyUIElementIsDisplayed(icon1CSS);
            VerifyUIElementIsDisplayed(titleEstimateYourRateCSS);
            VerifyUIElementIsDisplayed(infoEstimateYourRateCSS);
            VerifyUIElementIsDisplayed(icon2CSS);
            VerifyUIElementIsDisplayed(titleApplyForCoverageCSS);
            VerifyUIElementIsDisplayed(infoApplyForCoverageCSS);
            VerifyUIElementIsDisplayed(iconDocumentCSS);
            VerifyUIElementIsDisplayed(iconDiamonRingCSS);
            VerifyUIElementIsDisplayed(icon3CSS);
            VerifyUIElementIsDisplayed(titleWearYourJewelryCSS);
            VerifyUIElementIsDisplayed(infoWearYourJewelryCSS);
            VerifyUIElementIsDisplayed(icon4CSS);
            VerifyUIElementIsDisplayed(titleFileaClaimCSS);
            VerifyUIElementIsDisplayed(infoFileaClaimCSS);
            VerifyUIElementIsDisplayed(iconPhoneCSS);
            VerifyUIElementIsDisplayed(titleAllThingsJewelryCSS);
            VerifyUIElementIsDisplayed(infoAllthingsJewelryCSS);
            VerifyUIElementIsDisplayed(btnDownloadYourGuideCSS);

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

        public void verifyPJHeader()
        {
            // PJ Header 
            string HeaderPJInsuranceFrom = driver.FindElement(By.CssSelector(headerPJInsuranceFromCSS)).GetAttribute("InnerText");
            Assert.AreEqual(HeaderPJInsuranceFrom, PJInsurance_D_V.txtheaderPJInsuranceFrom, "The Text doesn't match");

            string InfoPJInsuranceFrom = driver.FindElement(By.CssSelector(infoPJInsuranceFromCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoPJInsuranceFrom, PJInsurance_D_V.txtinfoPJInsuranceFrom, "The Text doesn't match");

            string BtnWhatWillItCostMe = driver.FindElement(By.CssSelector(btnWhatWillItCostMeCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnWhatWillItCostMe, PJInsurance_D_V.btnWhatWillItCostMe, "The Text doesn't match");

            string LinkRetreveYourSaved = driver.FindElement(By.CssSelector(linkRetreveYourSavedCSS)).GetAttribute("InnerText");
            Assert.AreEqual(LinkRetreveYourSaved, PJInsurance_D_V.linkRetrieveYourSaved, "The Text doesn't match");
        }

        public void verifyProtectingAllThings()
        {
            //Protecting All Things Jewelry Since 1913
            string TitleProtectingAllThings = driver.FindElement(By.CssSelector(titleProtectingAllThingsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleProtectingAllThings, PJInsurance_D_V.txtProtectingAllThings, "The Text doesn't match");

            string InfoProtectAllThings = driver.FindElement(By.CssSelector(infoProtectAllThingsCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoProtectAllThings, PJInsurance_D_V.txtProtectingAllThingsInfo, "The Text doesn't match");

            string LinkMoreAboutOurHistory = driver.FindElement(By.CssSelector(linkMoreAboutOurHistoryCSS)).GetAttribute("InnerText");
            Assert.AreEqual(LinkMoreAboutOurHistory, PJInsurance_D_V.hrefMoreAboutOurHistory, "The Text doesn't match");

        }

        public void verifyWhatsCovered()
        {
            //What's Covered
            string TitleWhatsCovered = driver.FindElement(By.CssSelector(titleWhatsCoveredCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWhatsCovered, PJInsurance_D_V.txtWhatsCovered, "The Text doesn't match");

            string InfoWhatsCovered1 = driver.FindElement(By.CssSelector(infoWhatsCovered1CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWhatsCovered1, PJInsurance_D_V.txtWhatsCoveredInfo1, "The Text doesn't match");

            string InfoWhatsCovered2 = driver.FindElement(By.CssSelector(infoWhatsCovered2CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWhatsCovered2, PJInsurance_D_V.txtWhatsCoveredInfo2, "The Text doesn't match");

            string TitleLoss = driver.FindElement(By.CssSelector(titleLossCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleLoss, PJInsurance_D_V.txtLoss, "The Text doesn't match");

            string InfoLoss = driver.FindElement(By.CssSelector(infoLossCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoLoss, PJInsurance_D_V.txtLossInfo, "The Text doesn't match");

            string TitleTheft = driver.FindElement(By.CssSelector(titleTheftCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleTheft, PJInsurance_D_V.txtTheft, "The Text doesn't match");

            string InfoTheft = driver.FindElement(By.CssSelector(infoTheftCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoTheft, PJInsurance_D_V.txtTheftInfo, "The Text doesn't match");

            string TitleDamage = driver.FindElement(By.CssSelector(titleDamageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDamage, PJInsurance_D_V.txtDamage, "The Text doesn't match");

            string InfoDamage = driver.FindElement(By.CssSelector(infoDamageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDamage, PJInsurance_D_V.txtDamageInfo, "The Text doesn't match");

            string TitleDisappearance = driver.FindElement(By.CssSelector(titleDisappearanceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleDisappearance, PJInsurance_D_V.txtDisappearance, "The Text doesn't match");

            string InfoDisappearance = driver.FindElement(By.CssSelector(infoDisappearanceCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoDisappearance, PJInsurance_D_V.txtDisappearanceInfo, "The Text doesn't match");

        }

        public void verifyTheCaseAgainst()
        {
            //The Case Against Homeowners
            string TitleWhyNotHomeowners = driver.FindElement(By.CssSelector(titleWhyNotHomeownersCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWhyNotHomeowners, PJInsurance_D_V.txttitleWhyNotHomeowners, "The Text doesn't match");

            string InfoWhyNotHomeowners1 = driver.FindElement(By.CssSelector(infoWhyNotHomeowners1CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWhyNotHomeowners1, PJInsurance_D_V.txtInfoWhyNotHomeowners1, "The Text doesn't match");

            string InfoWhyNotHomeowners2 = driver.FindElement(By.CssSelector(infoWhyNotHomeowners2CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWhyNotHomeowners2, PJInsurance_D_V.txtTInfoWhyNotHomeowners, "The Text doesn't match");

            string LinkSeeOurFAQ = driver.FindElement(By.CssSelector(linkSeeOurFAQCSS)).GetAttribute("InnerText");
            Assert.AreEqual(LinkSeeOurFAQ, PJInsurance_D_V.hrefSeeOurFAQ, "The Text doesn't match");

        }

        public void verifyCheckYourRate()
        {
            //Check Your Rate
            string TitleCheckYourRate = driver.FindElement(By.CssSelector(titleCheckYourRateCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleCheckYourRate, PJInsurance_D_V.txtCheckYourRate, "The Text doesn't match");

            string InfoCheckYourRate1 = driver.FindElement(By.CssSelector(infoCheckYourRate1CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoCheckYourRate1, PJInsurance_D_V.txtCheckYourRate1, "The Text doesn't match");

            string InfoCheckYourRate2 = driver.FindElement(By.CssSelector(infoCheckYourRate2CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoCheckYourRate2, PJInsurance_D_V.txtCheckYourRate2, "The Text doesn't match");

            string InfoCheckYourRate3 = driver.FindElement(By.CssSelector(infoCheckYourRate3CSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoCheckYourRate3, PJInsurance_D_V.txtCheckYourRate3, "The Text doesn't match");

            string LinkRetriveYourApplication = driver.FindElement(By.CssSelector(linkRetriveYourApplicationCSS)).GetAttribute("InnerText");
            Assert.AreEqual(LinkRetriveYourApplication, PJInsurance_D_V.hrefRetrieveSavedQuote, "The Text doesn't match");

            string BtnGetPricing = driver.FindElement(By.CssSelector(btnGetPricingCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnGetPricing, PJInsurance_D_V.btnGetaQuote, "The Text doesn't match");

            string DisclaimerCheckYourRate = driver.FindElement(By.CssSelector(disclaimerCheckYourRateCSS)).GetAttribute("InnerText");
            Assert.AreEqual(DisclaimerCheckYourRate, PJInsurance_D_V.txtDisclaimerCheckYourRate, "The Text doesn't match");
        }

        public void verifyHowItAllWorks()
        {
            //How It All Works
            string TitleHowItAllWorks = driver.FindElement(By.CssSelector(titleHowItAllWorksCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleHowItAllWorks, PJInsurance_D_V.txtHowItAllWorks, "The Text doesn't match");

            string TitleEstimateYourRate = driver.FindElement(By.CssSelector(titleEstimateYourRateCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleEstimateYourRate, PJInsurance_D_V.txtEstimate, "The Text doesn't match");

            string InfoEstimateYourRate = driver.FindElement(By.CssSelector(infoEstimateYourRateCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoEstimateYourRate, PJInsurance_D_V.txtEstimateInfo, "The Text doesn't match");

            string TitleApplyForCoverage = driver.FindElement(By.CssSelector(titleApplyForCoverageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleApplyForCoverage, PJInsurance_D_V.txtApplyForCoverage, "The Text doesn't match");

            string InfoApplyForCoverage = driver.FindElement(By.CssSelector(infoApplyForCoverageCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoApplyForCoverage, PJInsurance_D_V.txtApplyForCoverageInfo, "The Text doesn't match");

            string TitleWearYourJewelry = driver.FindElement(By.CssSelector(titleWearYourJewelryCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleWearYourJewelry, PJInsurance_D_V.txtWearYourJewelry, "The Text doesn't match");

            string InfoWearYourJewelry = driver.FindElement(By.CssSelector(infoWearYourJewelryCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoWearYourJewelry, PJInsurance_D_V.txtWearYourJewelryInfo, "The Text doesn't match");

            string TitleFileaClaim = driver.FindElement(By.CssSelector(titleFileaClaimCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleFileaClaim, PJInsurance_D_V.txtFileaClaim, "The Text doesn't match");

            string InfoFileaClaim = driver.FindElement(By.CssSelector(infoFileaClaimCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoFileaClaim, PJInsurance_D_V.txtFileaClaimInfo, "The Text doesn't match");
        }

        public void verifyAllThingsJewelry()
        {
            //All Things Jewelry Insurance, All in One Place
            string TitleAllThingsJewelry = driver.FindElement(By.CssSelector(titleAllThingsJewelryCSS)).GetAttribute("InnerText");
            Assert.AreEqual(TitleAllThingsJewelry, PJInsurance_D_V.txtAllThings, "The Text doesn't match");

            string InfoAllthingsJewelry = driver.FindElement(By.CssSelector(infoAllthingsJewelryCSS)).GetAttribute("InnerText");
            Assert.AreEqual(InfoAllthingsJewelry, PJInsurance_D_V.txtAllThingsInfo, "The Text doesn't match");

            string BtnDownloadYourGuide = driver.FindElement(By.CssSelector(btnDownloadYourGuideCSS)).GetAttribute("InnerText");
            Assert.AreEqual(BtnDownloadYourGuide, PJInsurance_D_V.btnDownloadYourGuide, "The Text doesn't match");
        }

        public void verifyPJInsurancePageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyPJHeader();
            verifyProtectingAllThings();
            verifyWhatsCovered();
            verifyTheCaseAgainst();
            verifyCheckYourRate();
            verifyHowItAllWorks();
            verifyAllThingsJewelry();
        }
    }
}

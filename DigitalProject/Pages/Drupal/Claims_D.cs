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
    public class Claims_D : Page
    {
        // Claims Header
        string headerClaims1Xpath = "//h4[.='CLAIMS']";
        string headerClaims2Xpath = "//h1[.='Jewelry Insurance Claims']";
        string btnStartAClaimXpath = "//div[@class='hero__content hero__content-align-center']/a[.='START A CLAIM']";
        string infoHeaderBodyXpath = "//div[@class='hero__cta-footer']";
        //  string linkLoggingInToYourAccountXpath = "div.hero__cta-footer a:nth-of-type(1)";
        //   string linkPhoneXpath = "div.hero__cta-footer [href='tel:+18888842424']";

        // What's Needed
        string titleWhatsNeededXpath = "//h2[.=\"What's Needed\"]";
        string infoWhatsNeededXpath = "//p[contains(.,'When your jewelry is damaged, lost or stolen, all you want is to get it back')]";
        string titleProodofOwnershipXpath = "//h4[.='Proof of Ownership']";
        string infoProofofOwnershipXpath = "//p[contains(.,'Any documentation, like a receipt, appraisal or dated photo of the jewelry, that')]";
        string titleWritteStatementXpath = "//h4[.='Written Statement']";
        string infoWrittenStatementXpath = "//p[contains(.,'A short statement explaining what happened, including a list of damage if your')]";
        string titlePoliceReportXpath = "//h4[.='Police Report']";
        string infoPoliceReportXpath = "//p[contains(.,'A police report, depending on the jewelry and how it was lost or stolen.')]";

        // How It All Works
        string titleHowItAllWorksXpath = "//h2[.='How It All Works']";
        string infoHowItAllWorksXpath = "//p[contains(.,'Our goal is to repair or replace your jewelry with same kind and quality as fast')]";
        string icon1Xpath = "//h3[.='1']";
        string titleStartYourClaimXpath = "//h3[.='Start Your Claim']";
        string infoLetUsKnowXpath = "//div[@class='column text-center text-medium-left']/p[contains(.,'Let us know')]";
        string linkStartYourClaimOnlineXpath = "//a[.='Start your claim online']";
        //string infoOrCallUsXpath = "div[data-layout-content-preview-placeholder-label='\"Start Your Claim\" block'] p";
        string linkPhoneClaimXpath = "//div[@class='content']//div[@class='block-layout-builder block--type-inline-blocktext-image-row']//a[.='888-884-2424']";
        string iconDesktopXpath = "//img[@alt='computer illustration']";
        string iconStoreXpath = "//img[@alt='storefront illustration']";
        string icon2Xpath = "//h3[.='2']";
        string titleChooseaJewelerXpath = "//h3[.='Choose a Jeweler']";
        string infoChooseaJeweler1Xpath = "//strong[.='Choose a jeweler to repair or replace your item.']";
        string infoChooseaJeweler2Xpath = "//div[@class='content']//div[@class='layout__region layout__region--content']/div[8]//p[1]";
        string icon3Xpath = "//h3[.='3']";
        string titlePayYourDedectibleXpath = "//h3[.='Pay Your Deductible']";
        string infoPayYourDedectible1Xpath = "//strong[.='If your policy has a deductible, pay that amount to your jeweler.']";
        string infoPayYourDedectible2Xpath = "//div[@class='content']//div[@class='layout__region layout__region--content']/div[9]//p[1]";
        string iconMoneyXpath = "//img[@alt='payment illustration']";
        string iconRingXpath = "//img[@alt='ring with checkmark illustration']";
        string icon4Xpath = "//h3[.='4']";
        string titleInsureYourReplacementXpath = "//h3[.='Insure Your Replacement Jewelry']";
        string infoInsure1Xpath = "//strong[.=\"If your jewelry was replaced entirely, we'll help you add that to your policy.\"]";
        string infoInsure2Xpath = "//div[@class='content']//div[@class='layout__region layout__region--content']/div[10]//p[1]";

        // Claims Satisfaction Rate
        string iconStarsXpath = "//img[@alt='stars illustration']";
        string infoRatingXpath = "//h4[.='4.89 out of 5 stars']";
        string titleClaimsRateXpath = "//h2[.='Claims Satisfaction Rate']";
        string infoClaimsRateXpath = "//p[contains(.,'Jewelers Mutual customers who have experienced a claim give the process 4.89 out')]";

        //What Is and Isn't Covered
        string titleWhatIsCoveredXpath = "//h2[.=\"What Is and Isn't Covered\"]";
        string iconcheck1Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[1]/img[@alt='check mark']";
        string titleLossXpath = "//h4[.='Loss']";
        string infoLossXpath = "//p[.='Like losing your ring at the beach']";
        string iconCheck2Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[2]/img[@alt='check mark']";
        string titleTheftXpath = "//h4[.='Theft']";
        string infoTheftXpath = "//p[.='Like having your watch swiped from your hotel room']";
        string iconcheck3Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[3]/img[@alt='check mark']";
        string titleDamageXpath = "//h4[.='Damage']";
        string infoDamageXpath = "//p[.='Like stepping on an earring and breaking the post']";
        string iconCheck4Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[4]/img[@alt='check mark']";
        string titleDisappearanceXpath = "//h4[.='Disappearance']";
        string infoDisappearanceXpath = "//p[contains(.,\"Like when you just can't find your favorite necklace\")]";
        string iconCheck5Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[5]/img[@alt='check mark']";
        string titleWorldwideTravelXpath = "//h4[.='Worldwide Travel']";
        string infoWorldwideTravelXpath = "//p[.='Coverage follows you everywhere you travel, worldwide']";
        string iconX6Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[6]/img[@alt='an X']";
        string titleDeteriorationXpath = "//h4[.='Deterioration']";
        string infoDeteriorationXpath = "//p[contains(.,'Like small scratches on the underside of a ring')]";
        string iconX7Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[7]/img[@alt='an X']";
        string titleVoluntaryXpath = "//h4[.='Voluntary Parting']";
        string infoVoluntaryXpath = "//p[contains(.,'Like selling your jewelry just to have the check bounce')]";
        string iconX8Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[8]/img[@alt='an X']";
        string titleIntentionalXpath = "//h4[.='Intentional Actions']";
        string infoIntentionalXpath = "//p[contains(.,'Like purposely damaging or losing your jewelry')]";
        string iconX9Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[9]/img[@alt='an X']";
        string titleCrittersXpath = "//h4[.='Critters']";
        string infoCrittersXpath = "//p[contains(.,'Like damage from vermin, rodents or insects')]";
        string iconX10Xpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-center border-bottom checklist-grid']/div[10]/img[@alt='an X']";
        string titleWarXpath = "//h4[.='War & Authority']";
        string infoWarXpath = "//p[.='Like having your jewelry seized by law enforcement']";

        //FAQ
        string titleFAQXpath = "//h2[text()='FAQ']";
        string titleCanIReceiveCashXpath = "//h4[contains(text(),'Can I receive cash?')]";
        string infoCanIReseiceCashXpath = "//p[contains(text(),'No. We specifically created a repair or replacement jewelry insurance policy bec')]";
        string titleCanIUpgradeXpath = "//h4[contains(text(),'Can I upgrade?')]";
        string infoCanIUpgradeXpath = "//p[contains(text(),'Yes, if your item needs to be entirely replaced rather than repaired. You can ch')]";
        string titleCanIChooseXpath = "//h4[contains(text(),'Can I choose any jeweler?')]";
        string infoCanIChooseXpath = "//p[contains(text(),'Yes. You choose the jeweler you trust and we will partner with them to repair or')]";
        string titleWhatisaDeductibleXpath = "//h4[contains(text(),'What is a deductible?')]";
        string infoWhatisaDeductibleXpath = "//p[contains(text(),'A deductible is what you pay before your insurance company replaces your item an')]";
        string titleWhatProofXpath = "//h4[contains(text(),'What proof is needed for a claim?')]";
        string infoWhatProofXpath = "//p[contains(text(),'Documentation (like a receipt, appraisal or dated photo of the jewelry) that pro')]";
        string titleWhatifIFindXpath = "//h4[contains(text(),'What if I find my jewelry after making a claim?')]";
        string infoWhatifIFindXpath = "//p[contains(text(),'gotten your repair or replacement yet, just let us know and')]";
        string titleHowSoonXpath = "//h4[contains(text(),'How soon after damage or a loss should I submit a claim?')]";
        string infoHowSoonXpath = "//p[contains(text(),'Generally, as soon as possible. However, in cases like mysterious disappearance,')]";
        string titleWhatIfXpath = "//h4[contains(text(),'t find the same stone I had?')]";
        string infoWhatIfXpath = "//p[contains(text(),'We’ll authorize the jeweler to replace your insured item with same kind and qual')]";

        //Start a Claim
        string titleStartAClaimXpath = "//h2[text()='Start a Claim']";
        string infoStartAClaimXpath = "//p[contains(text(),'You can start a claim instantly by using our ')]";
        string linkQuickClaimToolXpath = "//a[text()='Quick Claim tool']";
        string linkLogInToXpath = "//a[text()='log in to your account']";
        string linkClaimPhoneXpath = "//a[3]";
        string btnStartAClaim2Xpath = "//div[@class='feature-row background-color--blue spacing--top']//a[.='START A CLAIM']";

        Claims_D_V Claims_D_V = new Claims_D_V();
        public Claims_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify

            //VerifyUIElementIsDisplayed(headerClaims1Xpath);
            //VerifyUIElementIsDisplayed(headerClaims2Xpath);
            //VerifyUIElementIsDisplayed(btnStartAClaimXpath);
            VerifyUIElementIsDisplayed(infoHeaderBodyXpath);
            // VerifyUIElementIsDisplayed(linkLoggingInToYourAccountXpath);
            //   VerifyUIElementIsDisplayed(linkPhoneXpath);
            //VerifyUIElementIsDisplayed(titleWhatsNeededXpath);
            VerifyUIElementIsDisplayed(infoWhatsNeededXpath);
            VerifyUIElementIsDisplayed(titleProodofOwnershipXpath);
            VerifyUIElementIsDisplayed(infoProofofOwnershipXpath);
            VerifyUIElementIsDisplayed(titleWritteStatementXpath);
            VerifyUIElementIsDisplayed(infoWrittenStatementXpath);
            VerifyUIElementIsDisplayed(titlePoliceReportXpath);
            VerifyUIElementIsDisplayed(infoPoliceReportXpath);
            //VerifyUIElementIsDisplayed(titleHowItAllWorksXpath);
            //VerifyUIElementIsDisplayed(infoHowItAllWorksXpath);
            VerifyUIElementIsDisplayed(icon1Xpath);
            //VerifyUIElementIsDisplayed(titleStartYourClaimXpath);
            VerifyUIElementIsDisplayed(infoLetUsKnowXpath);
            VerifyUIElementIsDisplayed(linkStartYourClaimOnlineXpath);
            // VerifyUIElementIsDisplayed(infoOrCallUsXpath);
            VerifyUIElementIsDisplayed(linkPhoneClaimXpath);
            //VerifyUIElementIsDisplayed(iconDesktopXpath);
            //VerifyUIElementIsDisplayed(iconStoreXpath);
            VerifyUIElementIsDisplayed(icon2Xpath);
            //VerifyUIElementIsDisplayed(titleChooseaJewelerXpath);
            VerifyUIElementIsDisplayed(infoChooseaJeweler1Xpath);
            VerifyUIElementIsDisplayed(infoChooseaJeweler2Xpath);
            VerifyUIElementIsDisplayed(icon3Xpath);
            //VerifyUIElementIsDisplayed(titlePayYourDedectibleXpath);
            VerifyUIElementIsDisplayed(infoPayYourDedectible1Xpath);
            VerifyUIElementIsDisplayed(infoPayYourDedectible2Xpath);
            //VerifyUIElementIsDisplayed(iconMoneyXpath);
            //VerifyUIElementIsDisplayed(iconRingXpath);
            VerifyUIElementIsDisplayed(icon4Xpath);
            //VerifyUIElementIsDisplayed(titleInsureYourReplacementXpath);
            VerifyUIElementIsDisplayed(infoInsure1Xpath);
            VerifyUIElementIsDisplayed(infoInsure2Xpath);
            //VerifyUIElementIsDisplayed(iconStarsXpath);
            //VerifyUIElementIsDisplayed(infoRatingXpath);
            VerifyUIElementIsDisplayed(titleClaimsRateXpath);
            //VerifyUIElementIsDisplayed(infoClaimsRateXpath);
            //VerifyUIElementIsDisplayed(titleWhatIsCoveredXpath);
            //VerifyUIElementIsDisplayed(iconcheck1Xpath);
            VerifyUIElementIsDisplayed(titleLossXpath);
            VerifyUIElementIsDisplayed(infoLossXpath);
//            VerifyUIElementIsDisplayed(iconCheck2Xpath);
            VerifyUIElementIsDisplayed(titleTheftXpath);
            VerifyUIElementIsDisplayed(infoTheftXpath);
//            VerifyUIElementIsDisplayed(iconcheck3Xpath);
            VerifyUIElementIsDisplayed(titleDamageXpath);
            VerifyUIElementIsDisplayed(infoDamageXpath);
//            VerifyUIElementIsDisplayed(iconCheck4Xpath);
            VerifyUIElementIsDisplayed(titleDisappearanceXpath);
            VerifyUIElementIsDisplayed(infoDisappearanceXpath);
//            VerifyUIElementIsDisplayed(iconCheck5Xpath);
            VerifyUIElementIsDisplayed(titleWorldwideTravelXpath);
            VerifyUIElementIsDisplayed(infoWorldwideTravelXpath);
//            VerifyUIElementIsDisplayed(iconX6Xpath);
            VerifyUIElementIsDisplayed(titleDeteriorationXpath);
            VerifyUIElementIsDisplayed(infoDeteriorationXpath);
//            VerifyUIElementIsDisplayed(iconX7Xpath);
            VerifyUIElementIsDisplayed(titleVoluntaryXpath);
            VerifyUIElementIsDisplayed(infoVoluntaryXpath);
//            VerifyUIElementIsDisplayed(iconX8Xpath);
            VerifyUIElementIsDisplayed(titleIntentionalXpath);
            VerifyUIElementIsDisplayed(infoIntentionalXpath);
//            VerifyUIElementIsDisplayed(iconX9Xpath);
            VerifyUIElementIsDisplayed(titleCrittersXpath);
            VerifyUIElementIsDisplayed(infoCrittersXpath);
 //           VerifyUIElementIsDisplayed(iconX10Xpath);
            VerifyUIElementIsDisplayed(titleWarXpath);
            VerifyUIElementIsDisplayed(infoWarXpath);
//            VerifyUIElementIsDisplayed(titleFAQXpath);
            VerifyUIElementIsDisplayed(titleCanIReceiveCashXpath);
            VerifyUIElementIsDisplayed(infoCanIReseiceCashXpath);
            VerifyUIElementIsDisplayed(titleCanIUpgradeXpath);
            VerifyUIElementIsDisplayed(infoCanIUpgradeXpath);
            VerifyUIElementIsDisplayed(titleCanIChooseXpath);
            VerifyUIElementIsDisplayed(infoCanIChooseXpath);
            VerifyUIElementIsDisplayed(titleWhatisaDeductibleXpath);
            VerifyUIElementIsDisplayed(infoWhatisaDeductibleXpath);
            VerifyUIElementIsDisplayed(titleWhatProofXpath);
            VerifyUIElementIsDisplayed(infoWhatProofXpath);
            VerifyUIElementIsDisplayed(titleWhatifIFindXpath);
            VerifyUIElementIsDisplayed(infoWhatifIFindXpath);
            VerifyUIElementIsDisplayed(titleHowSoonXpath);
            VerifyUIElementIsDisplayed(infoHowSoonXpath);
            VerifyUIElementIsDisplayed(titleWhatIfXpath);
            VerifyUIElementIsDisplayed(infoWhatIfXpath);
//            VerifyUIElementIsDisplayed(titleStartAClaimXpath);
            VerifyUIElementIsDisplayed(infoStartAClaimXpath);
            VerifyUIElementIsDisplayed(linkQuickClaimToolXpath);
            VerifyUIElementIsDisplayed(linkLogInToXpath);
            VerifyUIElementIsDisplayed(linkClaimPhoneXpath);
//            VerifyUIElementIsDisplayed(btnStartAClaim2Xpath);

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

        public void verifyAllClaimsPageContent()
        {
            //verifyNavBar();
            verifyFooter();
            //verifyJewelryClaims();
            //verifyWhatsNeeded();
//            verifyHowItAllWorks();
//            verifyClaimsRate();
//            verifyWhatIs();
//            verifyTheCaseAgainst();
//            verifyStartAClaim();
        }

        public void verifyJewelryClaims()
        {
            //Jewelry Insurance Claims
            string HeaderClaims1 = driver.FindElement(By.XPath(headerClaims1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderClaims1.ToLower().Trim(), Claims_D_V.txtClaims.ToLower().Trim(), "The Text doesn't match");

            string HeaderClaims2 = driver.FindElement(By.XPath(headerClaims2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderClaims2, Claims_D_V.txtJewelryInsuranceClaims, "The Text doesn't match");

            string BtnStartAClaim = driver.FindElement(By.XPath(btnStartAClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnStartAClaim, Claims_D_V.btnStartAClaim, "The Text doesn't match");

            string InfoHeaderBody = driver.FindElement(By.XPath(infoHeaderBodyXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHeaderBody, Claims_D_V.txtClaimsInfo, "The Text doesn't match");

            /*  string LinkLoggingInToYourAccount = driver.FindElement(By.XPath(linkLoggingInToYourAccountXpath)).GetAttribute("innerText");
              Assert.AreEqual(LinkLoggingInToYourAccount, Claims_D_V.hrefLogging, "The Text doesn't match");

              string LinkPhone = driver.FindElement(By.XPath(linkPhoneXpath)).GetAttribute("innerText");
              Assert.AreEqual(LinkPhone, Claims_D_V.hrefPhone, "The Text doesn't match"); */
        }

        public void verifyWhatsNeeded()
        {
            //What's Needed
            string TitleWhatsNeeded = driver.FindElement(By.XPath(titleWhatsNeededXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatsNeeded, Claims_D_V.txtWhatsNeeded, "The Text doesn't match");

            string InfoWhatsNeeded = driver.FindElement(By.XPath(infoWhatsNeededXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatsNeeded, Claims_D_V.txtWhatsNeededInfo, "The Text doesn't match");

            string TitleProodofOwnership = driver.FindElement(By.XPath(titleProodofOwnershipXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleProodofOwnership, Claims_D_V.txtProof, "The Text doesn't match");

            string InfoProofofOwnership = driver.FindElement(By.XPath(infoProofofOwnershipXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoProofofOwnership, Claims_D_V.txtProofInfo, "The Text doesn't match");

            string TitleWritteStatementXpath = driver.FindElement(By.XPath(titleWritteStatementXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWritteStatementXpath, Claims_D_V.txtWritten, "The Text doesn't match");

            string InfoWrittenStatementXpath = driver.FindElement(By.XPath(infoWrittenStatementXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWrittenStatementXpath, Claims_D_V.txtWrittenInfo, "The Text doesn't match");

            string TitlePoliceReport = driver.FindElement(By.XPath(titlePoliceReportXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitlePoliceReport, Claims_D_V.txtPolice, "The Text doesn't match");

            string InfoPoliceReport = driver.FindElement(By.XPath(infoPoliceReportXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoPoliceReport, Claims_D_V.txtPoliceInfo, "The Text doesn't match");
        }

        public void verifyHowItAllWorks()
        {
            //How It All Works
            //    string TitleHowItAllWorks = driver.FindElement(By.XPath(titleHowItAllWorksXpath)).GetAttribute("innerText");
            //   Assert.AreEqual(TitleHowItAllWorks, Claims_D_V.txtHowItAllWorks, "The Text doesn't match");

            string TitleHowItAllWorks = driver.FindElement(By.XPath(titleHowItAllWorksXpath)).GetAttribute("innerText");
            if (!TitleHowItAllWorks.ToLower().Trim().Contains(Claims_D_V.txtHowItAllWorks.ToLower().Trim()))
                Assert.Fail("Expected: " + Claims_D_V.txtHowItAllWorks.ToLower() + "Actual:" + TitleHowItAllWorks + "The Text doesn't match");


            string InfoHowItAllWorks = driver.FindElement(By.XPath(infoHowItAllWorksXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHowItAllWorks, Claims_D_V.txtHowItAllWorksInfo, "The Text doesn't match");

            string TitleStartYourClaim = driver.FindElement(By.XPath(titleStartYourClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleStartYourClaim, Claims_D_V.txtStartYourClaim, "The Text doesn't match");

            string InfoLetUsKnow = driver.FindElement(By.XPath(infoLetUsKnowXpath)).GetAttribute("innerText");
            //  Assert.AreEqual(InfoLetUsKnow, Claims_D_V.txtStartYourClaimInfo1, "The Text doesn't match");
            if (!InfoLetUsKnow.ToLower().Trim().Contains(Claims_D_V.txtStartYourClaimInfo1.ToLower().Trim()))
                Assert.Fail("Expected: " + Claims_D_V.txtStartYourClaimInfo1.ToLower() + "Actual:" + InfoLetUsKnow + "The Text doesn't match");


            string LinkStartYourClaimOnline = driver.FindElement(By.XPath(linkStartYourClaimOnlineXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkStartYourClaimOnline, Claims_D_V.hrefStartYourClaim, "The Text doesn't match");

            //   string InfoOrCallUs = driver.FindElement(By.XPath(infoOrCallUsXpath)).GetAttribute("innerText");
            //  Assert.AreEqual(InfoOrCallUs, Claims_D_V.txtOrCallUs, "The Text doesn't match");

            string LinkPhoneClaimXpath = driver.FindElement(By.XPath(linkPhoneClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkPhoneClaimXpath, Claims_D_V.hrefPhone2, "The Text doesn't match");

            string TitleChooseaJeweler = driver.FindElement(By.XPath(titleChooseaJewelerXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleChooseaJeweler, Claims_D_V.txtChoose, "The Text doesn't match");

            string InfoChooseaJeweler1 = driver.FindElement(By.XPath(infoChooseaJeweler1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoChooseaJeweler1, Claims_D_V.txtChooseInfo1, "The Text doesn't match");

            string InfoChooseaJeweler2 = driver.FindElement(By.XPath(infoChooseaJeweler2Xpath)).GetAttribute("innerText");
            // Assert.AreEqual(InfoChooseaJeweler2, Claims_D_V.txtChooseInfo2, "The Text doesn't match");
            if (!InfoChooseaJeweler2.ToLower().Trim().Contains(Claims_D_V.txtChooseInfo2.ToLower().Trim()))
                Assert.Fail("Expected: " + Claims_D_V.txtChooseInfo2.ToLower() + "Actual:" + InfoChooseaJeweler2 + "The Text doesn't match");


            string TitlePayYourDedectible = driver.FindElement(By.XPath(titlePayYourDedectibleXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitlePayYourDedectible, Claims_D_V.txtPay, "The Text doesn't match");

            string InfoPayYourDedectible1 = driver.FindElement(By.XPath(infoPayYourDedectible1Xpath)).GetAttribute("innerText");
            //   Assert.AreEqual(InfoPayYourDedectible1, Claims_D_V.txtPayInfo1, "The Text doesn't match");
            if (!InfoPayYourDedectible1.ToLower().Trim().Contains(Claims_D_V.txtPayInfo1.ToLower().Trim()))
                Assert.Fail("Expected: " + Claims_D_V.txtPayInfo1.ToLower() + "Actual:" + InfoPayYourDedectible1 + "The Text doesn't match");


            string InfoPayYourDedectible2 = driver.FindElement(By.XPath(infoPayYourDedectible2Xpath)).GetAttribute("innerText");
            //  Assert.AreEqual(InfoPayYourDedectible2, Claims_D_V.txtPayInfo2, "The Text doesn't match");
            if (!InfoPayYourDedectible2.ToLower().Trim().Contains(Claims_D_V.txtPayInfo2.ToLower().Trim()))
                Assert.Fail("Expected: " + Claims_D_V.txtPayInfo2.ToLower() + "Actual:" + InfoPayYourDedectible2 + "The Text doesn't match");


            string TitleInsureYourReplacementXpath = driver.FindElement(By.XPath(titleInsureYourReplacementXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleInsureYourReplacementXpath, Claims_D_V.txtInsure, "The Text doesn't match");

            string InfoInsure1 = driver.FindElement(By.XPath(infoInsure1Xpath)).GetAttribute("innerText");
            // Assert.AreEqual(InfoInsure1, Claims_D_V.txtInsure1, "The Text doesn't match");
            if (!InfoInsure1.ToLower().Trim().Contains(Claims_D_V.txtInsure1.ToLower().Trim()))
                Assert.Fail("Expected: " + Claims_D_V.txtInsure1.ToLower() + "Actual:" + InfoInsure1 + "The Text doesn't match");


            string InfoInsure2 = driver.FindElement(By.XPath(infoInsure2Xpath)).GetAttribute("innerText");
            //  Assert.AreEqual(InfoInsure2, Claims_D_V.txtInsure2, "The Text doesn't match");
            if (!InfoInsure2.ToLower().Trim().Contains(Claims_D_V.txtInsure2.ToLower().Trim()))
                Assert.Fail("Expected: " + Claims_D_V.txtInsure2.ToLower() + "Actual:" + InfoInsure2 + "The Text doesn't match");

        }

        public void verifyClaimsRate()
        {
            //Claims Satisfaction Rate

            string InfoRating = driver.FindElement(By.XPath(infoRatingXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoRating.ToLower().Trim(), Claims_D_V.txtRating.ToLower().Trim(), "The Text doesn't match");

            string TitleClaimsRate = driver.FindElement(By.XPath(titleClaimsRateXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleClaimsRate.ToLower().Trim(), Claims_D_V.txtClaimsSatisfactionRate.ToLower().Trim(), "The Text doesn't match");

            // string InfoClaimsRate = driver.FindElement(By.XPath(infoClaimsRateXpath)).GetAttribute("innerText");
            // Assert.AreEqual(InfoClaimsRate.ToLower().Trim(), Claims_D_V.txtClaimsSatisfactionRateInfo.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyWhatIs()
        {
            //What Is and Isn't Covered
            string TitleWhatIsCovered = driver.FindElement(By.XPath(titleWhatIsCoveredXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatIsCovered, Claims_D_V.txtWhatIs, "The Text doesn't match");

            string TitleLoss = driver.FindElement(By.XPath(titleLossXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleLoss, Claims_D_V.txtLoss, "The Text doesn't match");

            string InfoLoss = driver.FindElement(By.XPath(infoLossXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoLoss, Claims_D_V.txtLossInfo, "The Text doesn't match");

            string TitleTheft = driver.FindElement(By.XPath(titleTheftXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleTheft, Claims_D_V.txtTheft, "The Text doesn't match");

            string InfoTheft = driver.FindElement(By.XPath(infoTheftXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTheft, Claims_D_V.txtTheftInfo, "The Text doesn't match");

            string TitleDamage = driver.FindElement(By.XPath(titleDamageXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDamage, Claims_D_V.txtDamage, "The Text doesn't match");

            string InfoDamage = driver.FindElement(By.XPath(infoDamageXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDamage, Claims_D_V.txtDamageInfo, "The Text doesn't match");

            string TitleDisappearance = driver.FindElement(By.XPath(titleDisappearanceXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDisappearance, Claims_D_V.txtDisappearance, "The Text doesn't match");

            string InfoDisappearance = driver.FindElement(By.XPath(infoDisappearanceXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDisappearance.ToLower().Trim(), Claims_D_V.txtDisappearanceInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleWorldwideTravel = driver.FindElement(By.XPath(titleWorldwideTravelXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWorldwideTravel, Claims_D_V.txtWorldwideTravel, "The Text doesn't match");

            string InfoWorldwideTravel = driver.FindElement(By.XPath(infoWorldwideTravelXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWorldwideTravel.ToLower().Trim(), Claims_D_V.txtWorldwideTravelInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleDeterioration = driver.FindElement(By.XPath(titleDeteriorationXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDeterioration.ToLower().Trim(), Claims_D_V.txtDeterioration.ToLower().Trim(), "The Text doesn't match");

            string InfoDeterioration = driver.FindElement(By.XPath(infoDeteriorationXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDeterioration.ToLower().Trim(), Claims_D_V.txtDeteriorationInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleVoluntary = driver.FindElement(By.XPath(titleVoluntaryXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleVoluntary.ToLower().Trim(), Claims_D_V.txtVoluntary.ToLower().Trim(), "The Text doesn't match");

            string InfoVoluntary = driver.FindElement(By.XPath(infoVoluntaryXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoVoluntary.ToLower().Trim(), Claims_D_V.txtVoluntaryInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleIntentional = driver.FindElement(By.XPath(titleIntentionalXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleIntentional.ToLower().Trim(), Claims_D_V.txtIntentional.ToLower().Trim(), "The Text doesn't match");

            string InfoIntentional = driver.FindElement(By.XPath(infoIntentionalXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoIntentional.ToLower().Trim(), Claims_D_V.txtIntentionalInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleCritters = driver.FindElement(By.XPath(titleCrittersXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleCritters.ToLower().Trim(), Claims_D_V.txtCritters.ToLower().Trim(), "The Text doesn't match");

            string InfoCritters = driver.FindElement(By.XPath(infoCrittersXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCritters.ToLower().Trim(), Claims_D_V.txtCrittersInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleWar = driver.FindElement(By.XPath(titleWarXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWar.ToLower().Trim(), Claims_D_V.txtWar.ToLower().Trim(), "The Text doesn't match");

            string InfoWar = driver.FindElement(By.XPath(infoWarXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWar.ToLower().Trim(), Claims_D_V.txtWarInfo.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyTheCaseAgainst()
        {
            //FAQ
            string TitleFAQ = driver.FindElement(By.XPath(titleFAQXpath)).GetAttribute("innerText");
            Console.WriteLine("Value is " + TitleFAQ);
            Assert.AreEqual(TitleFAQ.ToLower().Trim(), Claims_D_V.hrefFAQ.ToLower().Trim(), "The Text doesn't match");

            string TitleCanIReceiveCash = driver.FindElement(By.XPath(titleCanIReceiveCashXpath)).GetAttribute("innerText");
            Console.WriteLine("Value is " + TitleCanIReceiveCash);
            Assert.AreEqual(TitleCanIReceiveCash.ToLower().Trim(), Claims_D_V.txtCanIReceiveCash.ToLower().Trim(), "The Text doesn't match");

            string TitleCanIReceiveCashInfo = driver.FindElement(By.XPath(infoCanIReseiceCashXpath)).GetAttribute("innerText");
            TitleCanIReceiveCashInfo = Regex.Replace(TitleCanIReceiveCashInfo, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();
            TitleCanIReceiveCashInfo = Regex.Replace(TitleCanIReceiveCashInfo, @"\n", "", RegexOptions.Multiline).TrimEnd();
            Assert.AreEqual(TitleCanIReceiveCashInfo.ToLower().Trim(), Claims_D_V.txtCanIReceiveCashInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleCanIUpgrade = driver.FindElement(By.XPath(titleCanIUpgradeXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleCanIUpgrade.ToLower().Trim(), Claims_D_V.txtCanIUpgrade.ToLower().Trim(), "The Text doesn't match");

            string InfoCanIUpgrade = driver.FindElement(By.XPath(infoCanIUpgradeXpath)).GetAttribute("innerText");
            InfoCanIUpgrade = Regex.Replace(InfoCanIUpgrade, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();
            InfoCanIUpgrade = Regex.Replace(InfoCanIUpgrade, @"\n", "", RegexOptions.Multiline).TrimEnd();
            Assert.AreEqual(InfoCanIUpgrade.ToLower().Trim(), Claims_D_V.txtCanIUpgradeInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleCanIChoose = driver.FindElement(By.XPath(titleCanIChooseXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleCanIChoose.ToLower().Trim(), Claims_D_V.txtCanIChoose.ToLower().Trim(), "The Text doesn't match");

            string InfoCanIChoose = driver.FindElement(By.XPath(infoCanIChooseXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCanIChoose.ToLower().Trim(), Claims_D_V.txtCanIChooseInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleWhatisaDeductible = driver.FindElement(By.XPath(titleWhatisaDeductibleXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatisaDeductible.ToLower().Trim(), Claims_D_V.txtWhatIsA.ToLower().Trim(), "The Text doesn't match");

            string InfoWhatisaDeductible = driver.FindElement(By.XPath(infoWhatisaDeductibleXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatisaDeductible.ToLower().Trim(), Claims_D_V.txtWhatIsAInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleWhatProof = driver.FindElement(By.XPath(titleWhatProofXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatProof.ToLower().Trim(), Claims_D_V.txtWhatProof.ToLower().Trim(), "The Text doesn't match");

            string InfoWhatProof = driver.FindElement(By.XPath(infoWhatProofXpath)).GetAttribute("innerText");
            // InfoWhatProof = Regex.Replace(InfoWhatProof, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();
            InfoWhatProof = InfoWhatProof.Replace(System.Environment.NewLine, "");
            // InfoWhatProof = Regex.Replace(InfoWhatProof, @"\n", "", RegexOptions.Multiline).TrimEnd();
            Console.WriteLine("Expected value" + InfoWhatProof);
            Assert.AreEqual(InfoWhatProof.ToLower().Trim(), Claims_D_V.txtWhatProofInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleWhatifIFind = driver.FindElement(By.XPath(titleWhatifIFindXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatifIFind.ToLower().Trim(), Claims_D_V.txtWhatIfI.ToLower().Trim(), "The Text doesn't match");

            string InfoWhatifIFind = driver.FindElement(By.XPath(infoWhatifIFindXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatifIFind.ToLower().Trim(), Claims_D_V.txtWhatIfIInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleHowSoon = driver.FindElement(By.XPath(titleHowSoonXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleHowSoon.ToLower().Trim(), Claims_D_V.txtHowSoon.ToLower().Trim(), "The Text doesn't match");

            string InfoHowSoon = driver.FindElement(By.XPath(infoHowSoonXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHowSoon.ToLower().Trim(), Claims_D_V.txtHowSoonInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleWhatIf = driver.FindElement(By.XPath(titleWhatIfXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatIf.ToLower().Trim(), Claims_D_V.txtWhatIfThe.ToLower().Trim(), "The Text doesn't match");

            string InfoWhatIf = driver.FindElement(By.XPath(infoWhatIfXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatIf.ToLower().Trim(), Claims_D_V.txtWhatIfTheInfo.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyStartAClaim()
        {
            //Start a Claim
            string TitleStartAClaimXpath = driver.FindElement(By.XPath(titleStartAClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleStartAClaimXpath, Claims_D_V.txtStartAClaim, "The Text doesn't match");

            string InfoStartAClaim = driver.FindElement(By.XPath(infoStartAClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoStartAClaim, Claims_D_V.txtStartAClaimInfo, "The Text doesn't match");

            string LinkQuickClaimTool = driver.FindElement(By.XPath(linkQuickClaimToolXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkQuickClaimTool, Claims_D_V.hrefQuickClaimTool, "The Text doesn't match");

            string LinkLogInTo = driver.FindElement(By.XPath(linkLogInToXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkLogInTo, Claims_D_V.hrefLogInToYourAccount, "The Text doesn't match");

            string LinkClaimPhone = driver.FindElement(By.XPath(linkClaimPhoneXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkClaimPhone, Claims_D_V.hrefPhone3, "The Text doesn't match");

            string BtnStartAClaim2 = driver.FindElement(By.XPath(btnStartAClaim2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnStartAClaim2, Claims_D_V.btnStartAClaim2, "The Text doesn't match");
        }
    }
}

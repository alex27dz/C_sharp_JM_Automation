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
    public class JewelryBusiness_D : Page
    {
        // Elements  

        // Jewelry Business Insurance Page Images

        // JB Header
        string headerBusinessInsuranceXpath = "//h4[contains(.,'Business Insurance')]";
        string titleProtectWorthXpath = "//h1[.='Protect your business for all its worth.']";
        string headerProtectBusinessXpath = "//h2[.='Protecting your business is our business']";
        string infoWereCommitedXpath = "//p[contains(.,\"We're committed to protecting your jewelry business. No one is more passionate \")]";

        // Our Cusotmer Stories
        string headerOurCustomerStoriesXpath = "//h2[.='Our Customer Stories']";
        string titleHeasWhatJewelersXpath = "//strong[.='Hear what jewelers are saying about Jewelers Mutual.']";
        string infoHearWhatJewelersXpath = "//p[contains(.,'\"I know if I do need Jewelers Mutual, I’m not going to be asked to prove 11 diff')]";
        string videoJBXpath = "//img[@alt='photo of man in suit with play button over it']";
        string nameJohnXpath = "//strong[.='John Carter']";
        string descOwnerXpath = "//i[.='Owner, Jack Lewis Jewelers']";


        // Our Core Policies
        string headerOurCorePoliciesXpath = "//h2[.='Our Core Policies']";
        string infoOurCorePoliciesXpath = "//p[contains(.,\"We’re here to help you find the right insurance coverage to meet the needs\")]";
        string titleJBXpath = "//h4[contains(.,'Jewelers Block and Jewelers Standard Policy')]";
        string infoJBXpath = "//p[contains(.,'Protect your inventory, stock on memo or consignment,')]";
        string infoJBCrimeXpath = "//li[.='Crime']";
        string infoJBShoppingXpath = "//li[.='Shopping and travel-related risks']";
        string infoJBFireXpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-left top-border-colors spacing']/div[1]//li[.='Fire']";
        string infoJBNaturalXpath = "//li[.='Natural Disaster']";
        string titleBOPXpath = "//h4[contains(.,'Businessowners Policy (BOP)')]";
        string infoBOPXpath = "//p[contains(.,'Get protection for your business personal property, building, non-jewelry invent')]";
        string infoBOPLiabilityXpath = "//li[.='Liability-related risks']";
        string infoBOPDamagefXpath = "//li[.='Damage due to crime']";
        string infoBOPFireXpath = "//div[@class='info-grid row content-lg grid-layout-three text-align-left top-border-colors spacing']/div[2]//li[.='Fire']";
        string infoBOPNatrualXpath = "//li[.='Natural disaster']";
        string titleCommXpath = "//h4[contains(.,'Commercial Umbrella Liability Policy')]";
        string infoCommlXpath = "//p[contains(.,'Add extra protection for extraordinary liabilities that may go beyond the limits')]";
        string infoComm2Xpath = "//p[.='Be covered for loss amounts that exceed the underlying coverage limits for:']";
        string infoCommBodilyXpath = "//li[.='Bodily Injury']";
        string infoCommPropertyXpath = "//li[.='Property Damage']";
        string infoCommPersonalXpath = "//li[.='Personal Injury']";
        string infoCommAdvertisingXpath = "//li[.='Advertising Injury']";

        //Add-ons
        string headerAddonsXpath = "//h2[.='Add-ons']";
        string infoAddonsyXpath = "//p[contains(.,'Additional coverages that will help customize your policy.')]";
        string titleAppraisalXpath = "//h4[.='Appraisal Liability']";
        string infoAppraisalXpath = "//p[.='Covers errors or omissions in performing written appraisals on jewelry.']";
        string titleEmploymentXpath = "//h4[.='Employment Practices Liability']";
        string infoEmploymentXpath = "//p[contains(.,'Protection from the financial consequences associated with a variety of employme')]";
        string titleDataXpath = "//h4[.='Data Breach & Cyber Related Protection']";
        string infoDataXpath = "//p[contains(.,'Coverage for data compromise, e-commerce, computer fraud/funds transfer fraud')]";
        string titleTradeXpath = "//h4[.='Trade shows']";
        string infoTradeXpath = "//p[contains(.,'Additional protection provided while attending jewelry industry events, as well')]";
        string titleHiredXpath = "//h4[.='Hired & Non-Owned Auto Liability']";
        string infoHiredXpath = "//p[contains(.,'Covers bodily injury or property damage arising out of the use of an auto')]";
        string titleStockXpath = "//h4[.='Stock Disappearance']";
        string infoStockXpath = "//p[contains(.,'Covers unexplained losses other than those discovered taking inventory or from p')]";
        string titleWorkmanshipXpath = "//h4[.='Workmanship']";
        string infoWorkmansipXpath = "//p[contains(.,'Covers loss or damage to property belonging to others not in the jewelry')]";

        // James Testimonal
        string imgJamesXpath = "//img[@alt='James']";
        string quoteJamesXpath = "//p[contains(.,'We would recommend Jewelers Mutual to anyone in our business. We have been in g')]";
        string nameJamesXpath = "//span[contains(.,'James')]";

        // Tip Of The Week
        string iconComboXpath = "//img[@alt='icon of a timer']";
        string desTipXpath = "//h4[.='TIP OF THE WEEK']";
        string titleHurricaneXpath = "//h2[.='What to do After a Hurricane']";
        string infoHurricaneXpath = "//p[contains(.,'As soon as you’re able to safely return to your business, the first thing you sh')]";
        string emailJBClaimsXpath = "//a[.='claims@jminsure.com']";
        string linkGetMoreTipsXpath = "//a[.='Get more tips on The Clarity Blog']";

        // Have an Agent Contact You
        string iconDocumentXpath = "//img[@alt='checklist icon']";
        string titleHaveAnAgentXpath = "//h2[.='Have an Agent Contact You']";
        string infoHaveAnAgentXpath = "//p[contains(.,'Jewelers Mutual is represented by independent agents throughout the U.S. and Can')]";
        string formFNXpath = "//div[.='First Name']";
        string formLNXpath = "//div[.='Last Name']";
        string formNBXpath = "//div[.='Name of Business']";
        string formZipXpath = "//div[.='Zip/Postal Code']";
        string formTypeXpath = "//div[.='Type of Business']";
        string formNeedXpath = "//div[.='Need Insurance By']";
        string formEmailXpath = "//div[.='Email']";
        string formPhoneXpath = "//div[.='Phone']";
        string formPCMXpath = "//div[.='Preferred Contact Method']";
        string captchaTextXpath = "//label[@id='recaptcha-anchor-label']";
        string captchaIconXpath = "//div[@class='rc-anchor-logo-img rc-anchor-logo-img-portrait']";
        string btnSubmitXpath = "//input[@name='submit']";


        // Want to Chat Now?
        string titleWantXpath = "//h3[.='Want to Chat Now?']";
        string infoWantXpath = "//p[contains(.,'Contact us via email or give one of our experienced agents a call for')]";
        string iconPhoneJBXpath = "//img[@alt='Phone']";
        string titlePhoneXpath = "//h5[.='Phone']";
        string linkPhoneXpath = "//a[.='800-336-5642, ext. 2118']";
        string iconEmailXpath = "//img[@alt='envelope']";
        string titleEmailXpath = "//h5[.='Email']";
        string emailSalesXpath = "//a[.='sales@jminsure.com']";

        // Founded in 1913 for jewelers, by jewelers.
        string titleFoundedXpath = "//h2[.='Founded in 1913 for jewelers, by jewelers.']";
        string infoFoundedXpath = "//p[.=\"We've been serving the jewelry industry for over 100 years.\"]";
        string btnReadOutStoryXpath = "//a[.='Read our story']";

        /*
        // Meber Advantages
        string headerMemberXpath = "div[data-layout-content-preview-placeholder-label='\"Member Advantages title bar\" block'] h2";
        string infoMemberXpath = "div[data-layout-content-preview-placeholder-label='\"Member Advantages title bar\" block'] p";
        string iconRelieveXpath = "[alt='person with heart icon']";
        string titleRelieveXpath = "div.icon-styles > div:nth-of-type(1) > h4";
        string infoRelieveXpath = "div.icon-styles > div:nth-of-type(1) p";
        string iconCareXpath = "[alt='document icon']";
        string titleCareXpath = "div.icon-styles > div:nth-of-type(2) > h4";
        string infoCareXpath = "div.icon-styles > div:nth-of-type(2) p";
        string iconLinkXpath = "[alt='diamond with checkmark']";
        string titleLinkXpath = "div.icon-styles > div:nth-of-type(3) > h4";
        string infoLinkXpath = "div.icon-styles > div:nth-of-type(3) p";
        string iconShippingXpath = "[alt='chart']";
        string titleShippingXpath = "div.icon-styles > div:nth-of-type(4) > h4";
        string infoShippingXpath = "div.icon-styles > div:nth-of-type(4) p";

        // Mary Testmional
        string imgMaryXpath = "[src='/sites/default/files/styles/testimonial_1x_705_x_440/public/2019-07/Mary.jpg?itok=CgxxrEyk']";
        string quoteMaryXpath = "div[data-layout-content-preview-placeholder-label='\"Mary Testimonial\" block'] p";
        string nameMaryXpath = "div[data-layout-content-preview-placeholder-label='\"Mary Testimonial\" block'] .author > [property='name']";

        //All the knowledge you'll need
        string iconKnowledgeXpath = "[alt='toolbox icon']";
        string titleKnowledgeXpath = "div[data-layout-content-preview-placeholder-label='\"Knowledge feature\" block'] h2";
        string infoKnowledgeXpath = "div[data-layout-content-preview-placeholder-label='\"Knowledge feature\" block'] p";
        string btnExploreXpath = ".btn[href='/jm-university-retail-loss-prevention-tools']";
        */

        JewelryBusiness_D_V JewelryBusiness_D_V = new JewelryBusiness_D_V();
        public JewelryBusiness_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify

            VerifyUIElementIsDisplayed(headerBusinessInsuranceXpath);
            VerifyUIElementIsDisplayed(titleProtectWorthXpath);
            VerifyUIElementIsDisplayed(headerProtectBusinessXpath);
            VerifyUIElementIsDisplayed(infoWereCommitedXpath);
            VerifyUIElementIsDisplayed(headerOurCustomerStoriesXpath);
            VerifyUIElementIsDisplayed(titleHeasWhatJewelersXpath);
            VerifyUIElementIsDisplayed(infoHearWhatJewelersXpath);
            VerifyUIElementIsDisplayed(videoJBXpath);
            VerifyUIElementIsDisplayed(nameJohnXpath);
            VerifyUIElementIsDisplayed(descOwnerXpath);
            VerifyUIElementIsDisplayed(headerOurCorePoliciesXpath);
            VerifyUIElementIsDisplayed(infoOurCorePoliciesXpath);
            VerifyUIElementIsDisplayed(titleJBXpath);
            VerifyUIElementIsDisplayed(infoJBXpath);
            VerifyUIElementIsDisplayed(infoJBCrimeXpath);
            VerifyUIElementIsDisplayed(infoJBShoppingXpath);
            VerifyUIElementIsDisplayed(infoJBFireXpath);
            VerifyUIElementIsDisplayed(infoJBNaturalXpath);
            VerifyUIElementIsDisplayed(titleBOPXpath);
            VerifyUIElementIsDisplayed(infoBOPXpath);
            VerifyUIElementIsDisplayed(infoBOPLiabilityXpath);
            VerifyUIElementIsDisplayed(infoBOPDamagefXpath);
            VerifyUIElementIsDisplayed(infoBOPFireXpath);
            VerifyUIElementIsDisplayed(infoBOPNatrualXpath);
            VerifyUIElementIsDisplayed(titleCommXpath);
            VerifyUIElementIsDisplayed(infoCommlXpath);
            VerifyUIElementIsDisplayed(infoComm2Xpath);
            VerifyUIElementIsDisplayed(infoCommBodilyXpath);
            VerifyUIElementIsDisplayed(infoCommPropertyXpath);
            VerifyUIElementIsDisplayed(infoCommPersonalXpath);
            VerifyUIElementIsDisplayed(infoCommAdvertisingXpath);
            VerifyUIElementIsDisplayed(headerAddonsXpath);
            VerifyUIElementIsDisplayed(infoAddonsyXpath);
            VerifyUIElementIsDisplayed(titleAppraisalXpath);
            VerifyUIElementIsDisplayed(infoAppraisalXpath);
            VerifyUIElementIsDisplayed(titleEmploymentXpath);
            VerifyUIElementIsDisplayed(infoEmploymentXpath);
            VerifyUIElementIsDisplayed(titleDataXpath);
            VerifyUIElementIsDisplayed(infoDataXpath);
            VerifyUIElementIsDisplayed(titleTradeXpath);
            VerifyUIElementIsDisplayed(infoTradeXpath);
            VerifyUIElementIsDisplayed(titleHiredXpath);
            VerifyUIElementIsDisplayed(infoHiredXpath);
            VerifyUIElementIsDisplayed(titleStockXpath);
            VerifyUIElementIsDisplayed(infoStockXpath);
            VerifyUIElementIsDisplayed(titleWorkmanshipXpath);
            VerifyUIElementIsDisplayed(infoWorkmansipXpath);
            VerifyUIElementIsDisplayed(imgJamesXpath);
            VerifyUIElementIsDisplayed(quoteJamesXpath);
            VerifyUIElementIsDisplayed(nameJamesXpath);
            VerifyUIElementIsDisplayed(iconComboXpath);
            VerifyUIElementIsDisplayed(desTipXpath);
            VerifyUIElementIsDisplayed(titleHurricaneXpath);
            VerifyUIElementIsDisplayed(infoHurricaneXpath);
            VerifyUIElementIsDisplayed(emailJBClaimsXpath);
            VerifyUIElementIsDisplayed(linkGetMoreTipsXpath);
            VerifyUIElementIsDisplayed(iconDocumentXpath);
            VerifyUIElementIsDisplayed(titleHaveAnAgentXpath);
            VerifyUIElementIsDisplayed(infoHaveAnAgentXpath);
            VerifyUIElementIsDisplayed(titleWantXpath);
            VerifyUIElementIsDisplayed(infoWantXpath);
            VerifyUIElementIsDisplayed(iconPhoneJBXpath);
            VerifyUIElementIsDisplayed(titlePhoneXpath);
            VerifyUIElementIsDisplayed(linkPhoneXpath);
            VerifyUIElementIsDisplayed(iconEmailXpath);
            VerifyUIElementIsDisplayed(titleEmailXpath);
            VerifyUIElementIsDisplayed(emailSalesXpath);
            VerifyUIElementIsDisplayed(titleFoundedXpath);
            VerifyUIElementIsDisplayed(infoFoundedXpath);
            VerifyUIElementIsDisplayed(btnReadOutStoryXpath);
            driver.SwitchTo().Frame(0);
            VerifyUIElementIsDisplayed(formFNXpath);
            VerifyUIElementIsDisplayed(formLNXpath);
            VerifyUIElementIsDisplayed(formNBXpath);
            VerifyUIElementIsDisplayed(formZipXpath);
            VerifyUIElementIsDisplayed(formTypeXpath);
            VerifyUIElementIsDisplayed(formNeedXpath);
            VerifyUIElementIsDisplayed(formEmailXpath);
            VerifyUIElementIsDisplayed(formPhoneXpath);
            VerifyUIElementIsDisplayed(formPCMXpath);
            driver.SwitchTo().ParentFrame();
            //  driver.SwitchTo().Frame(1);
            // VerifyUIElementIsDisplayed(captchaTextXpath);
            //VerifyUIElementIsDisplayed(captchaIconXpath);
            //VerifyUIElementIsDisplayed(btnSubmitXpath);
            /* VerifyUIElementIsDisplayed(headerMemberXpath);
             VerifyUIElementIsDisplayed(infoMemberXpath);
             VerifyUIElementIsDisplayed(iconRelieveXpath);
             VerifyUIElementIsDisplayed(titleRelieveXpath);
             VerifyUIElementIsDisplayed(infoRelieveXpath);
             VerifyUIElementIsDisplayed(iconCareXpath);
             VerifyUIElementIsDisplayed(titleCareXpath);
             VerifyUIElementIsDisplayed(infoCareXpath);
             VerifyUIElementIsDisplayed(iconLinkXpath);
             VerifyUIElementIsDisplayed(titleLinkXpath);
             VerifyUIElementIsDisplayed(infoLinkXpath);
             VerifyUIElementIsDisplayed(iconShippingXpath);
             VerifyUIElementIsDisplayed(titleShippingXpath);
             VerifyUIElementIsDisplayed(infoShippingXpath);
             VerifyUIElementIsDisplayed(imgMaryXpath);
             VerifyUIElementIsDisplayed(quoteMaryXpath);
             VerifyUIElementIsDisplayed(nameMaryXpath);
             VerifyUIElementIsDisplayed(iconKnowledgeXpath);
             VerifyUIElementIsDisplayed(titleKnowledgeXpath);
             VerifyUIElementIsDisplayed(infoKnowledgeXpath);
             VerifyUIElementIsDisplayed(btnExploreXpath); */

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

        public void verifyAllJewelryBusinessPageContent()
        {
            verifyJB();
            verifyCustomerStories();
            verifyCorePolicies();
            verifyAddOns();
            verifyJamesTest();
            verifyTipWeek();
            verifyChatNow();
            verifyAgentContact();

        }

        public void verifyJB()
        {
            //JB Insurance Header
            string HeaderBusinessInsurance = driver.FindElement(By.XPath(headerBusinessInsuranceXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderBusinessInsurance.ToLower().Trim(), JewelryBusiness_D_V.txtBusinessInsurance.ToLower().Trim(), "The Text doesn't match");

            string TitleProtectWorth = driver.FindElement(By.XPath(titleProtectWorthXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleProtectWorth.ToLower().Trim(), JewelryBusiness_D_V.txtProtectWorth.ToLower().Trim(), "The Text doesn't match");

            string HeaderProtectBusiness = driver.FindElement(By.XPath(headerProtectBusinessXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderProtectBusiness.ToLower().Trim(), JewelryBusiness_D_V.txtProtectBusiness.ToLower().Trim(), "The Text doesn't match");

            string InfoWereCommited = driver.FindElement(By.XPath(infoWereCommitedXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWereCommited.ToLower().Trim(), JewelryBusiness_D_V.txtWereCommited.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyCustomerStories()
        {
            // Our Cusotmer Stories
            string HeaderOurCustomerStories = driver.FindElement(By.XPath(headerOurCustomerStoriesXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderOurCustomerStories.ToLower().Trim(), JewelryBusiness_D_V.txtOurCustomerStories.ToLower().Trim(), "The Text doesn't match");

            string TitleHeasWhatJewelers = driver.FindElement(By.XPath(titleHeasWhatJewelersXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleHeasWhatJewelers.ToLower().Trim(), JewelryBusiness_D_V.txtHeasWhatJewelers.ToLower().Trim(), "The Text doesn't match");

            string InfoHearWhatJewelers = driver.FindElement(By.XPath(infoHearWhatJewelersXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHearWhatJewelers.ToLower().Trim(), JewelryBusiness_D_V.txtHearWhatJewelers.ToLower().Trim(), "The Text doesn't match");

            string NameJohn = driver.FindElement(By.XPath(nameJohnXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameJohn.ToLower().Trim(), JewelryBusiness_D_V.txtJohn.ToLower().Trim(), "The Text doesn't match");

            string DescOwner = driver.FindElement(By.XPath(descOwnerXpath)).GetAttribute("innerText");
            Assert.AreEqual(DescOwner.ToLower().Trim(), JewelryBusiness_D_V.txtOwner.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyCorePolicies()
        {
            // Our Core Policies
            string HeaderOurCorePolicies = driver.FindElement(By.XPath(headerOurCorePoliciesXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderOurCorePolicies.ToLower().Trim(), JewelryBusiness_D_V.txtOurCorePoliciesTitle.ToLower().Trim(), "The Text doesn't match");

            string InfoOurCorePolicies = driver.FindElement(By.XPath(infoOurCorePoliciesXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoOurCorePolicies.ToLower().Trim(), JewelryBusiness_D_V.txtOurCorePoliciesInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleJB = driver.FindElement(By.XPath(titleJBXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJB.ToLower().Trim(), JewelryBusiness_D_V.txtJB.ToLower().Trim(), "The Text doesn't match");

            string InfoJB = driver.FindElement(By.XPath(infoJBXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJB.ToLower().Trim(), JewelryBusiness_D_V.txtJBInfo.ToLower().Trim(), "The Text doesn't match");

            string InfoJBCrime = driver.FindElement(By.XPath(infoJBCrimeXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJBCrime.ToLower().Trim(), JewelryBusiness_D_V.txtJBCrime.ToLower().Trim(), "The Text doesn't match");

            string InfoJBShopping = driver.FindElement(By.XPath(infoJBShoppingXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJBShopping.ToLower().Trim(), JewelryBusiness_D_V.txtJBShopping.ToLower().Trim(), "The Text doesn't match");

            string InfoJBFire = driver.FindElement(By.XPath(infoJBFireXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJBFire.ToLower().Trim(), JewelryBusiness_D_V.txtJBFire.ToLower().Trim(), "The Text doesn't match");

            string InfoJBNatural = driver.FindElement(By.XPath(infoJBNaturalXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJBNatural.ToLower().Trim(), JewelryBusiness_D_V.txtJBNatural.ToLower().Trim(), "The Text doesn't match");

            string TitleBOP = driver.FindElement(By.XPath(titleBOPXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleBOP.ToLower().Trim(), JewelryBusiness_D_V.txtBOP.ToLower().Trim(), "The Text doesn't match");

            string InfoBOP = driver.FindElement(By.XPath(infoBOPXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBOP.ToLower().Trim(), JewelryBusiness_D_V.txtBOPInfo.ToLower().Trim(), "The Text doesn't match");

            string InfoBOPLiability = driver.FindElement(By.XPath(infoBOPLiabilityXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBOPLiability.ToLower().Trim(), JewelryBusiness_D_V.txtBOPLiability.ToLower().Trim(), "The Text doesn't match");

            string InfoBOPDamagef = driver.FindElement(By.XPath(infoBOPDamagefXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBOPDamagef.ToLower().Trim(), JewelryBusiness_D_V.txtBOPDamagef.ToLower().Trim(), "The Text doesn't match");

            string InfoBOPFire = driver.FindElement(By.XPath(infoBOPFireXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBOPFire.ToLower().Trim(), JewelryBusiness_D_V.txtBOPFire.ToLower().Trim(), "The Text doesn't match");

            string InfoBOPNatrual = driver.FindElement(By.XPath(infoBOPNatrualXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBOPNatrual.ToLower().Trim(), JewelryBusiness_D_V.txtBOPNatrual.ToLower().Trim(), "The Text doesn't match");

            string TitleComm = driver.FindElement(By.XPath(titleCommXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleComm.ToLower().Trim(), JewelryBusiness_D_V.txtComm.ToLower().Trim(), "The Text doesn't match");

            string InfoComml = driver.FindElement(By.XPath(infoCommlXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoComml.ToLower().Trim(), JewelryBusiness_D_V.txtCommInfol.ToLower().Trim(), "The Text doesn't match");

            string InfoComm2 = driver.FindElement(By.XPath(infoComm2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoComm2.ToLower().Trim(), JewelryBusiness_D_V.txtCommInfo2.ToLower().Trim(), "The Text doesn't match");

            string InfoCommBodily = driver.FindElement(By.XPath(infoCommBodilyXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCommBodily.ToLower().Trim(), JewelryBusiness_D_V.txtCommBodily.ToLower().Trim(), "The Text doesn't match");

            string InfoCommProperty = driver.FindElement(By.XPath(infoCommPropertyXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCommProperty.ToLower().Trim(), JewelryBusiness_D_V.txtCommProperty.ToLower().Trim(), "The Text doesn't match");

            string InfoCommPersonal = driver.FindElement(By.XPath(infoCommPersonalXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCommPersonal.ToLower().Trim(), JewelryBusiness_D_V.txtCommPersonal.ToLower().Trim(), "The Text doesn't match");

            string InfoCommAdvertising = driver.FindElement(By.XPath(infoCommAdvertisingXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCommAdvertising.ToLower().Trim(), JewelryBusiness_D_V.txtCommAdvertising.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyAddOns()
        {
            //Add-ons

            string HeaderAddons = driver.FindElement(By.XPath(headerAddonsXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderAddons.ToLower().Trim(), JewelryBusiness_D_V.txtAddons.ToLower().Trim(), "The Text doesn't match");

            string InfoAddonsy = driver.FindElement(By.XPath(infoAddonsyXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAddonsy.ToLower().Trim(), JewelryBusiness_D_V.txtAddonsInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleAppraisal = driver.FindElement(By.XPath(titleAppraisalXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleAppraisal.ToLower().Trim(), JewelryBusiness_D_V.txtAppraisal.ToLower().Trim(), "The Text doesn't match");

            string InfoAppraisal = driver.FindElement(By.XPath(infoAppraisalXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAppraisal.ToLower().Trim(), JewelryBusiness_D_V.txtAppraisalInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleEmployment = driver.FindElement(By.XPath(titleEmploymentXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleEmployment.ToLower().Trim(), JewelryBusiness_D_V.txtEmployment.ToLower().Trim(), "The Text doesn't match");

            string InfoEmployment = driver.FindElement(By.XPath(infoEmploymentXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoEmployment.ToLower().Trim(), JewelryBusiness_D_V.txtEmploymentInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleData = driver.FindElement(By.XPath(titleDataXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleData.ToLower().Trim(), JewelryBusiness_D_V.txtData.ToLower().Trim(), "The Text doesn't match");

            string InfoData = driver.FindElement(By.XPath(infoDataXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoData.ToLower().Trim(), JewelryBusiness_D_V.txtDataInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleTrade = driver.FindElement(By.XPath(titleTradeXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleTrade.ToLower().Trim(), JewelryBusiness_D_V.txtTrade.ToLower().Trim(), "The Text doesn't match");

            string InfoTrade = driver.FindElement(By.XPath(infoTradeXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTrade.ToLower().Trim(), JewelryBusiness_D_V.txtTradeInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleHired = driver.FindElement(By.XPath(titleHiredXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleHired.ToLower().Trim(), JewelryBusiness_D_V.txtHired.ToLower().Trim(), "The Text doesn't match");

            string InfoHired = driver.FindElement(By.XPath(infoHiredXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHired.ToLower().Trim(), JewelryBusiness_D_V.txtHiredInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleStock = driver.FindElement(By.XPath(titleStockXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleStock.ToLower().Trim(), JewelryBusiness_D_V.txtStock.ToLower().Trim(), "The Text doesn't match");

            string InfoStock = driver.FindElement(By.XPath(infoStockXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoStock.ToLower().Trim(), JewelryBusiness_D_V.txtStockInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleWorkmanship = driver.FindElement(By.XPath(titleWorkmanshipXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWorkmanship.ToLower().Trim(), JewelryBusiness_D_V.txtWorkmanship.ToLower().Trim(), "The Text doesn't match");

            string InfoWorkmansip = driver.FindElement(By.XPath(infoWorkmansipXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWorkmansip.ToLower().Trim(), JewelryBusiness_D_V.txtWorkmansipInfo.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyJamesTest()
        {
            //James Testimonal
            string QuoteJames = driver.FindElement(By.XPath(quoteJamesXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuoteJames.ToLower().Trim(), JewelryBusiness_D_V.txtJames.ToLower().Trim(), "The Text doesn't match");

            string NameJames = driver.FindElement(By.XPath(nameJamesXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameJames.ToLower().Trim(), JewelryBusiness_D_V.txtJamesName.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyTipWeek()
        {
            //Tip Of The Week

            string DesTip = driver.FindElement(By.XPath(desTipXpath)).GetAttribute("innerText");
            Assert.AreEqual(DesTip.ToLower().Trim(), JewelryBusiness_D_V.txtTip.ToLower().Trim(), "The Text doesn't match");

            string TitleHurricane = driver.FindElement(By.XPath(titleHurricaneXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleHurricane.ToLower().Trim(), JewelryBusiness_D_V.txtHurricane.ToLower().Trim(), "The Text doesn't match");

            string InfoHurricane = driver.FindElement(By.XPath(infoHurricaneXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHurricane.ToLower().Trim(), JewelryBusiness_D_V.txtHurricaneInfo.ToLower().Trim(), "The Text doesn't match");

            string EmailJBClaims = driver.FindElement(By.XPath(emailJBClaimsXpath)).GetAttribute("innerText");
            Assert.AreEqual(EmailJBClaims.ToLower().Trim(), JewelryBusiness_D_V.hrefJBClaims.ToLower().Trim(), "The Text doesn't match");

            string LinkGetMoreTips = driver.FindElement(By.XPath(linkGetMoreTipsXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkGetMoreTips.ToLower().Trim(), JewelryBusiness_D_V.hrefGetMoreTips.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyAgentContact()
        {
            //Have an Agent Contact You

            string TitleHaveAnAgent = driver.FindElement(By.XPath(titleHaveAnAgentXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleHaveAnAgent, JewelryBusiness_D_V.txtHaveAnAgent, "The Text doesn't match");

            string InfoHaveAnAgent = driver.FindElement(By.XPath(infoHaveAnAgentXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHaveAnAgent, JewelryBusiness_D_V.txtHaveAnAgentInfo, "The Text doesn't match");

            driver.SwitchTo().Frame(0);

            string FormFN = driver.FindElement(By.XPath(formFNXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormFN, JewelryBusiness_D_V.formFN, "The Text doesn't match");

            string FormLN = driver.FindElement(By.XPath(formLNXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormLN, JewelryBusiness_D_V.formLN, "The Text doesn't match");

            string FormNBC = driver.FindElement(By.XPath(formNBXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormNBC, JewelryBusiness_D_V.formNB, "The Text doesn't match");

            string FormZip = driver.FindElement(By.XPath(formZipXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormZip, JewelryBusiness_D_V.formZip, "The Text doesn't match");

            string FormType = driver.FindElement(By.XPath(formTypeXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormType, JewelryBusiness_D_V.formType, "The Text doesn't match");

            string FormNeed = driver.FindElement(By.XPath(formNeedXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormNeed, JewelryBusiness_D_V.formNeed, "The Text doesn't match");

            string FormEmail = driver.FindElement(By.XPath(formEmailXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormEmail, JewelryBusiness_D_V.formhref, "The Text doesn't match");

            string FormPhone = driver.FindElement(By.XPath(formPhoneXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormPhone, JewelryBusiness_D_V.formPhone, "The Text doesn't match");

            string FormPCM = driver.FindElement(By.XPath(formPCMXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormPCM, JewelryBusiness_D_V.formPCM, "The Text doesn't match");



        }

        public void verifyChatNow()
        {
            //What to Chat Now?

            string TitleWant = driver.FindElement(By.XPath(titleWantXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWant, JewelryBusiness_D_V.txtWant, "The Text doesn't match");

            string InfoWant = driver.FindElement(By.XPath(infoWantXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWant, JewelryBusiness_D_V.txtWantInfo, "The Text doesn't match");

            string TitlePhone = driver.FindElement(By.XPath(titlePhoneXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitlePhone, JewelryBusiness_D_V.txtPhone, "The Text doesn't match");

            string LinkPhone = driver.FindElement(By.XPath(linkPhoneXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkPhone, JewelryBusiness_D_V.hrefPhone, "The Text doesn't match");

            string TitleEmail = driver.FindElement(By.XPath(titleEmailXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleEmail, JewelryBusiness_D_V.txtEmail, "The Text doesn't match");

            string EmailSales = driver.FindElement(By.XPath(emailSalesXpath)).GetAttribute("innerText");
            Assert.AreEqual(EmailSales, JewelryBusiness_D_V.hrefSales, "The Text doesn't match");
        }

        public void verifyFounded1913()
        {
            //Founded in 1913 for jewelers, by jewelers.

            string TitleFounded = driver.FindElement(By.XPath(titleFoundedXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleFounded, JewelryBusiness_D_V.txtFounded, "The Text doesn't match");

            string InfoFounded = driver.FindElement(By.XPath(infoFoundedXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoFounded, JewelryBusiness_D_V.txtFoundedInfo, "The Text doesn't match");

            string BtnReadOutStory = driver.FindElement(By.XPath(btnReadOutStoryXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnReadOutStory, JewelryBusiness_D_V.btnReadOutStory, "The Text doesn't match");
        }

        //public void verifyMemeberAdvantages()
        //{
        //    // Meber Advantages

        //    string HeaderMember = driver.FindElement(By.XPath(headerMemberXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(HeaderMember, JewelryBusiness_D_V.txtMember, "The Text doesn't match");

        //    string InfoMember = driver.FindElement(By.XPath(infoMemberXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoMember, JewelryBusiness_D_V.txtMemberInfo, "The Text doesn't match");

        //    string TitleRelieve = driver.FindElement(By.XPath(titleRelieveXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(TitleRelieve, JewelryBusiness_D_V.txtRelieve, "The Text doesn't match");

        //    string InfoRelieve = driver.FindElement(By.XPath(infoRelieveXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoRelieve, JewelryBusiness_D_V.txtRelieveInfo, "The Text doesn't match");

        //    string TitleCare = driver.FindElement(By.XPath(titleCareXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(TitleCare, JewelryBusiness_D_V.txtCare, "The Text doesn't match");

        //    string InfoCare = driver.FindElement(By.XPath(infoCareXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoCare, JewelryBusiness_D_V.txtCareInfo, "The Text doesn't match");

        //    string TitleLink = driver.FindElement(By.XPath(titleLinkXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(TitleLink, JewelryBusiness_D_V.txLink, "The Text doesn't match");

        //    string InfoLink = driver.FindElement(By.XPath(infoLinkXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoLink, JewelryBusiness_D_V.txtLinkInfo, "The Text doesn't match");

        //    string TitleShipping = driver.FindElement(By.XPath(titleShippingXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(TitleShipping, JewelryBusiness_D_V.txtShipping, "The Text doesn't match");

        //    string InfoShipping = driver.FindElement(By.XPath(infoShippingXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoShipping, JewelryBusiness_D_V.txtShippingInfo, "The Text doesn't match");
        //}
        //public void verifyMaryTest()
        //{
        //    //Mary Testmional

        //    string QuoteMary = driver.FindElement(By.XPath(quoteMaryXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(QuoteMary, JewelryBusiness_D_V.txtMary, "The Text doesn't match");

        //    string NameMary = driver.FindElement(By.XPath(nameMaryXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(NameMary, JewelryBusiness_D_V.txtMaryName, "The Text doesn't match");
        //}

        //public void verifyKnowledge()
        //{
        //    //All the knowledge you'll need

        //    string TitleKnowledge = driver.FindElement(By.XPath(titleKnowledgeXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(TitleKnowledge, JewelryBusiness_D_V.txtKnowledge, "The Text doesn't match");

        //    string InfoKnowledge = driver.FindElement(By.XPath(infoKnowledgeXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoKnowledge, JewelryBusiness_D_V.txtKnowledgeInfo, "The Text doesn't match");

        //    string BtnExplore = driver.FindElement(By.XPath(btnExploreXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(BtnExplore, JewelryBusiness_D_V.btnExplore, "The Text doesn't match");
        //}
    }
}

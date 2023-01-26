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
    public class TermsOfUse_D : Page
    {
        // Terms of Use Page Images



        // Terms of Use Header
        string headerTermsofUseXpath = "//h1[text()='Terms of Use']";
        string titleTermsofUSeXpath = "//h2[text()='Terms of Use']";
        string infoUpdated2020Xpath = "//p[contains(.,'(Updated 1/2/2020)')]";

        //Introduction
        string titleIntroductionXpath = "//h3[text()='Introduction']";
        string infoIntroduction1Xpath = "//p[contains(text(),'Welcome to this website of Jewelers Mutual Insurance Company')]";
        string infoIntroduction2Xpath = "//p[contains(text(),'Please read the Terms of Use carefully before using the ')]";


        //Changes to the Terms of Use
        string titleChangesTUXpath = "//h3[text()='Changes to the Terms of Use']";
        string infoChangesTUXpath = "//p[contains(text(),'We may revise and update these Terms of Use from time to time')]";

        // Restrictions on Use
        string titleRestrictionsXpath = "//h3[text()='Restrictions on Use']";
        string infoRestrictionsXpath = "//p[contains(text(),'You may use the website only for lawful purposes and in accordance with these Te')]";

        //Accessing the Website and Account Security
        string titleAccessingXpath = "//h3[text()='Accessing the Website and Account Security']";
        string infoAccessing1Xpath = "//p[contains(text(),'We reserve the right to withdraw or amend any service we provide on the website')]";
        string infoAccessing2Xpath = "//p[contains(text(),'If you choose, or you are provided with, a user name, password or any other info')]";

        //Privacy and Information Collection
        string titlePrivacyXpath = "//h3[text()='Privacy and Information Collection']";
        string infoPrivacyXpath = "//p[contains(text(),'Jewelers Mutual is committed to protecting your personal and financial informati')]";
        string linkPrivacyXpath = "//a[text()='Privacy Policy']";

        //Links
        string titleLinksXpath = "//h3[text()='Links']";
        string infoLinksXpath = "//p[contains(text(),'The Jewelers Mutual website contains links to websites provided by third parties')]";

        //Intellectual Property Rights
        string titlePropertyRightsXpath = "//h3[text()='Intellectual Property Rights']";
        string infoPropertyRights1Xpath = "//p[contains(text(),'The entire contents of the website (including all information, software, text, d')]";
        string infoPropertyRights2Xpath = "//p[contains(text(),'Images displayed on this website are the property of, or under license to, Jewel')]";

        //Reliance on Information Posted
        string titleRelianceXpath = "//h3[text()='Reliance on Information Posted']";
        string infoRelianceXpath = "//p[contains(text(),'The information presented on or through the website is made available solely for')]";

        //Disclaimer
        string titleDisclaimerXpath = "//h3[text()='Disclaimer']";
        string infoDisclaimer1Xpath = "//p[contains(text(),'We strive to provide accurate, useful and current information; however, insuranc')]";
        string infoDisclaimer2Xpath = "//p[contains(text(),'THE MATERIALS ON THIS WEBSITE ARE PROVIDED ')]";
        string infoDisclaimer3Xpath = "//p[contains(text(),'NEITHER JEWELERS MUTUAL NOR ANY PERSON ASSOCIATED WITH JEWELERS MUTUAL MAKES ANY')]";

        //Limitation of Liability
        string titleLimitationXpath = "//h3[text()='Limitation of Liability']";
        string infoLimitation1Xpath = "//p[contains(text(),'IN NO EVENT WILL JEWELERS MUTUAL, ITS SERVICE PROVIDERS, OR ANY OF OUR OR THEIR')]";
        string infoLimitation2Xpath = "//p[contains(text(),'The foregoing does not affect any liability which cannot be excluded or limited')]";

        //Insurance Coverages
        string titleCoveragesXpath = "//h3[text()='Insurance Coverages']";
        string infoCoveragesXpath = "//p[contains(text(),'This website contains only general descriptions of coverages offered by us and d')]";

        //Certificate of Authority
        string titleAuthorityXpath = "//h3[text()='Certificate of Authority']";
        string infoAuthorityXpath = "//p[contains(text(),'Jewelers Mutual is licensed in all 50 states and the District of Columbia')]";

        //Questions or Comments
        string titleQuestionsTSXpath = "//h3[text()='Questions or Comments']";
        string infoQuestionsTSXpath = "//p[contains(text(),'This website is operated by Jewelers Mutual Insurance Company, SI, 24 Jewelers Park Dr, Neenah, Wisconsin 54956')]";
        string linkQuestionsTSXpath = "//a[text()='Contact Us']";


        TermsOfUse_D_V TermsOfUse_D_V = new TermsOfUse_D_V();
        public TermsOfUse_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify

            VerifyUIElementIsDisplayed(headerTermsofUseXpath);
            VerifyUIElementIsDisplayed(titleTermsofUSeXpath);
            VerifyUIElementIsDisplayed(infoUpdated2020Xpath);
            VerifyUIElementIsDisplayed(titleIntroductionXpath);
            VerifyUIElementIsDisplayed(infoIntroduction1Xpath);
            VerifyUIElementIsDisplayed(infoIntroduction2Xpath);
            VerifyUIElementIsDisplayed(titleChangesTUXpath);
            VerifyUIElementIsDisplayed(infoChangesTUXpath);
            VerifyUIElementIsDisplayed(titleRestrictionsXpath);
            VerifyUIElementIsDisplayed(infoRestrictionsXpath);
            VerifyUIElementIsDisplayed(titleAccessingXpath);
            VerifyUIElementIsDisplayed(infoAccessing1Xpath);
            VerifyUIElementIsDisplayed(infoAccessing2Xpath);
            VerifyUIElementIsDisplayed(titlePrivacyXpath);
            VerifyUIElementIsDisplayed(infoPrivacyXpath);
            VerifyUIElementIsDisplayed(linkPrivacyXpath);
            VerifyUIElementIsDisplayed(titleLinksXpath);
            VerifyUIElementIsDisplayed(infoLinksXpath);
            VerifyUIElementIsDisplayed(titlePropertyRightsXpath);
            VerifyUIElementIsDisplayed(infoPropertyRights1Xpath);
            VerifyUIElementIsDisplayed(infoPropertyRights2Xpath);
            VerifyUIElementIsDisplayed(titleRelianceXpath);
            VerifyUIElementIsDisplayed(infoRelianceXpath);
            VerifyUIElementIsDisplayed(titleDisclaimerXpath);
            VerifyUIElementIsDisplayed(infoDisclaimer1Xpath);
            VerifyUIElementIsDisplayed(infoDisclaimer2Xpath);
            VerifyUIElementIsDisplayed(infoDisclaimer3Xpath);
            VerifyUIElementIsDisplayed(titleLimitationXpath);
            VerifyUIElementIsDisplayed(infoLimitation1Xpath);
            VerifyUIElementIsDisplayed(infoLimitation2Xpath);
            VerifyUIElementIsDisplayed(titleCoveragesXpath);
            VerifyUIElementIsDisplayed(infoCoveragesXpath);
            VerifyUIElementIsDisplayed(titleAuthorityXpath);
            VerifyUIElementIsDisplayed(infoAuthorityXpath);
            VerifyUIElementIsDisplayed(titleQuestionsTSXpath);
            VerifyUIElementIsDisplayed(infoQuestionsTSXpath);
            VerifyUIElementIsDisplayed(linkQuestionsTSXpath);
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

        public void verifyTermsofUse()
        {
            //Terms of Use Header
            string HeaderTermsofUse = driver.FindElement(By.XPath(headerTermsofUseXpath)).Text;
            Assert.AreEqual(HeaderTermsofUse.ToLower().Trim(), TermsOfUse_D_V.txtHeaderTermsofUse.ToLower().Trim(), "The Text doesn't match");

            string TitleTermsofUSe = driver.FindElement(By.XPath(titleTermsofUSeXpath)).Text;
            Assert.AreEqual(TitleTermsofUSe.ToLower().Trim(), TermsOfUse_D_V.txtTitleTermsofUSe.ToLower().Trim(), "The Text doesn't match");

            string InfoUpdated2020 = driver.FindElement(By.XPath(infoUpdated2020Xpath)).Text;
            Assert.AreEqual(InfoUpdated2020.ToLower().Trim(), TermsOfUse_D_V.txtInfoUpdated2020.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Terms of Use Header");
        }

        public void verifyIntroductionTU()
        {
            //Introduction
            string TitleIntroduction = driver.FindElement(By.XPath(titleIntroductionXpath)).Text;
            Assert.AreEqual(TitleIntroduction.ToLower().Trim(), TermsOfUse_D_V.txtTitleIntroduction.ToLower().Trim(), "The Text doesn't match");

            string InfoIntroduction1 = driver.FindElement(By.XPath(infoIntroduction1Xpath)).Text;
            InfoIntroduction1 = InfoIntroduction1.Replace("\"", "'");
            Assert.AreEqual(InfoIntroduction1.ToLower().Trim(), TermsOfUse_D_V.txtInfoIntroduction1.ToLower().Trim(), "The Text doesn't match");

            string InfoIntroduction2 = driver.FindElement(By.XPath(infoIntroduction2Xpath)).Text;
            Assert.AreEqual(InfoIntroduction2.ToLower().Trim(), TermsOfUse_D_V.txtInfoIntroduction2.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Introduction");



        }

        public void verifyChangesTU()
        {
            //Changes to the Terms of Use
            string TitleChangesTU = driver.FindElement(By.XPath(titleChangesTUXpath)).Text;
            Assert.AreEqual(TitleChangesTU.ToLower().Trim(), TermsOfUse_D_V.txtTitleChangesTU.ToLower().Trim(), "The Text doesn't match");

            string InfoChangesTU = driver.FindElement(By.XPath(infoChangesTUXpath)).Text;
            Assert.AreEqual(InfoChangesTU.ToLower().Trim(), TermsOfUse_D_V.txtInfoChangesTU.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Changes to the Terms of Use");
        }

        public void verifyRestrictions()
        {
            // Restrictions on Use
            string TitleRestrictions = driver.FindElement(By.XPath(titleRestrictionsXpath)).Text;
            Assert.AreEqual(TitleRestrictions.ToLower().Trim(), TermsOfUse_D_V.txtTitleRestrictions.ToLower().Trim(), "The Text doesn't match");

            string InfoRestrictions = driver.FindElement(By.XPath(infoRestrictionsXpath)).Text;
            Assert.AreEqual(InfoRestrictions.ToLower().Trim(), TermsOfUse_D_V.txtInfoRestrictions.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine(" Restrictions on Use");
        }

        public void verifyAccessing()
        {
            //Accessing the Website and Account Security
            string TitleAccessing = driver.FindElement(By.XPath(titleAccessingXpath)).Text;
            Assert.AreEqual(TitleAccessing.ToLower().Trim(), TermsOfUse_D_V.txtTitleAccessing.ToLower().Trim(), "The Text doesn't match");

            string InfoAccessing1 = driver.FindElement(By.XPath(infoAccessing1Xpath)).Text;
            Assert.AreEqual(InfoAccessing1.ToLower().Trim(), TermsOfUse_D_V.txtInfoAccessing1.ToLower().Trim(), "The Text doesn't match");

            string InfoAccessing2 = driver.FindElement(By.XPath(infoAccessing2Xpath)).Text;
            Assert.AreEqual(InfoAccessing2.ToLower().Trim(), TermsOfUse_D_V.txtInfoAccessing2.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Accessing the Website and Account Security");
        }

        public void verifyPrivacy()
        {
            //Privacy and Information Collection
            string TitlePrivacy = driver.FindElement(By.XPath(titlePrivacyXpath)).Text;
            Assert.AreEqual(TitlePrivacy.ToLower().Trim(), TermsOfUse_D_V.txtTitlePrivacy.ToLower().Trim(), "The Text doesn't match");

            string InfoPrivacy = driver.FindElement(By.XPath(infoPrivacyXpath)).Text;
            Assert.AreEqual(InfoPrivacy.ToLower().Trim(), TermsOfUse_D_V.txtInfoPrivacy.ToLower().Trim(), "The Text doesn't match");

            string LinkPrivacy = driver.FindElement(By.XPath(linkPrivacyXpath)).Text;
            Assert.AreEqual(LinkPrivacy.ToLower().Trim(), TermsOfUse_D_V.hrefPrivacy.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Privacy and Information Collection");
        }

        public void verifyLinks()
        {
            //Links
            string TitleLinks = driver.FindElement(By.XPath(titleLinksXpath)).Text;
            Assert.AreEqual(TitleLinks.ToLower().Trim(), TermsOfUse_D_V.txtTitlehrefs.ToLower().Trim(), "The Text doesn't match");

            string InfoLinks = driver.FindElement(By.XPath(infoLinksXpath)).Text;
            Assert.AreEqual(InfoLinks.ToLower().Trim(), TermsOfUse_D_V.txtInfohrefs.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Links");

        }

        public void verifyPropertRights()
        {
            //Intellectual Property Rights
            string TitlePropertyRights = driver.FindElement(By.XPath(titlePropertyRightsXpath)).Text;
            Assert.AreEqual(TitlePropertyRights.ToLower().Trim(), TermsOfUse_D_V.txtTitlePropertyRights.ToLower().Trim(), "The Text doesn't match");

            string InfoPropertyRights1 = driver.FindElement(By.XPath(infoPropertyRights1Xpath)).Text;
            Assert.AreEqual(InfoPropertyRights1.ToLower().Trim(), TermsOfUse_D_V.txtInfoPropertyRights1.ToLower().Trim(), "The Text doesn't match");

            string InfoPropertyRights2 = driver.FindElement(By.XPath(infoPropertyRights2Xpath)).Text;
            Assert.AreEqual(InfoPropertyRights2.ToLower().Trim(), TermsOfUse_D_V.txtInfoPropertyRights2.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Intellectual Property Rights");
        }

        public void verifyReliance()
        {
            //Reliance on Information Posted
            string TitleReliance = driver.FindElement(By.XPath(titleRelianceXpath)).Text;
            Assert.AreEqual(TitleReliance.ToLower().Trim(), TermsOfUse_D_V.txtTitleReliance.ToLower().Trim(), "The Text doesn't match");

            string InfoReliance = driver.FindElement(By.XPath(infoRelianceXpath)).Text;
            Assert.AreEqual(InfoReliance.ToLower().Trim(), TermsOfUse_D_V.txtInfoReliance.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Reliance on Information Posted");
        }

        public void verifyDisclaimer()
        {
            //Disclaimer

            string TitleDisclaimer = driver.FindElement(By.XPath(titleDisclaimerXpath)).Text;
            Assert.AreEqual(TitleDisclaimer.ToLower().Trim(), TermsOfUse_D_V.txtTitleDisclaimer.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclaimer1 = driver.FindElement(By.XPath(infoDisclaimer1Xpath)).Text;
            Assert.AreEqual(InfoDisclaimer1.ToLower().Trim(), TermsOfUse_D_V.txtInfoDisclaimer1.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclaimer2 = driver.FindElement(By.XPath(infoDisclaimer2Xpath)).Text;
            InfoDisclaimer2 = InfoDisclaimer2.Replace("\"", "'");
            Assert.AreEqual(InfoDisclaimer2.ToLower().Trim(), TermsOfUse_D_V.txtInfoDisclaimer2.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclaimer3 = driver.FindElement(By.XPath(infoDisclaimer3Xpath)).Text;
            Assert.AreEqual(InfoDisclaimer3.ToLower().Trim(), TermsOfUse_D_V.txtInfoDisclaimer3.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Disclaimer");
        }

        public void verifyLimitation()
        {
            //Limitation of Liability

            string TitleLimitation = driver.FindElement(By.XPath(titleLimitationXpath)).Text;
            Assert.AreEqual(TitleLimitation.ToLower().Trim(), TermsOfUse_D_V.txtTitleLimitation.ToLower().Trim(), "The Text doesn't match");

            string InfoLimitation1 = driver.FindElement(By.XPath(infoLimitation1Xpath)).Text;
            Assert.AreEqual(InfoLimitation1.ToLower().Trim(), TermsOfUse_D_V.txtInfoLimitation1.ToLower().Trim(), "The Text doesn't match");

            string InfoLimitation2 = driver.FindElement(By.XPath(infoLimitation2Xpath)).Text;
            Assert.AreEqual(InfoLimitation2.ToLower().Trim(), TermsOfUse_D_V.txtInfoLimitation2.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Limitation of Liability");
        }

        public void verifyInsuranceCoverages()
        {
            //Insurance Coverages

            string TitleCoverages = driver.FindElement(By.XPath(titleCoveragesXpath)).Text;
            Assert.AreEqual(TitleCoverages.ToLower().Trim(), TermsOfUse_D_V.txtTitleCoverages.ToLower().Trim(), "The Text doesn't match");

            string InfoCoverages = driver.FindElement(By.XPath(infoCoveragesXpath)).Text;
            Assert.AreEqual(InfoCoverages.ToLower().Trim(), TermsOfUse_D_V.txtInfoCoverages.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Insurance Coverages");
        }
        public void verifyAuthority()
        {
            //Certificate of Authority

            string TitleAuthority = driver.FindElement(By.XPath(titleAuthorityXpath)).Text;
            Assert.AreEqual(TitleAuthority.ToLower().Trim(), TermsOfUse_D_V.txtTitleAuthority.ToLower().Trim(), "The Text doesn't match");

            string InfoAuthority = driver.FindElement(By.XPath(infoAuthorityXpath)).Text;
            Assert.AreEqual(InfoAuthority.ToLower().Trim(), TermsOfUse_D_V.txtInfoAuthority.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Certificate of Authority");

        }

        public void verifyQuestionsorComments()
        {
            //Questions or Comments

            string TitleQuestionsTS = driver.FindElement(By.XPath(titleQuestionsTSXpath)).Text;
            Assert.AreEqual(TitleQuestionsTS.ToLower().Trim(), TermsOfUse_D_V.txtTitleQuestionsTS.ToLower().Trim(), "The Text doesn't match");

            string InfoQuestionsTS = driver.FindElement(By.XPath(infoQuestionsTSXpath)).Text;
            Assert.AreEqual(InfoQuestionsTS.ToLower().Trim(), TermsOfUse_D_V.txtInfoQuestionsTS.ToLower().Trim(), "The Text doesn't match");

            string LinkQuestionsTS = driver.FindElement(By.XPath(linkQuestionsTSXpath)).Text;
            Assert.AreEqual(LinkQuestionsTS.ToLower().Trim(), TermsOfUse_D_V.hrefQuestionsTS.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Questions or Comments");

        }

        public void verifyTermsOfUsePageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyTermsofUse();
            verifyIntroductionTU();
            verifyChangesTU();
            verifyRestrictions();
            verifyAccessing();
            verifyPrivacy();
            verifyLinks();
            verifyPropertRights();
            verifyReliance();
            verifyDisclaimer();
            verifyLimitation();
            verifyInsuranceCoverages();
            verifyAuthority();
            verifyQuestionsorComments();
        }

    }
}

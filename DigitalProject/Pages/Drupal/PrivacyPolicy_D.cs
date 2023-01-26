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
    public class PrivacyPolicy_D : Page
    {
        // Elements  

        // Privacy Policy Page Images




        // Privacy Policy Header
        string headerPrivacyPolicyXpath = "//h1[text()='Privacy Policy']";

        // Privacy Policy Body
        string headerPPBodyXpath = "//h2[text()='Privacy Policy']";
        string infoUpdated2019Xpath = "//p[contains(.,'(Updated 12/19/2019)')]";

        //Introduction
        string titleIntroductionXpath = "//h4[text()='Introduction']";
        string infoIntroductionXpath = "//p[contains(text(),'Jewelers Mutual Insurance Company, SI and its subsidiaries and affiliated companies')]";
        string titleChangesXpath = "//h4[text()='Changes to our Privacy Policy']";
        string infoChangesXpath = "//p[contains(text(),'We may make changes to this Privacy Policy from time to time')]";

        // Information We Collect or Acquire
        string titleWeCollectXpath = "//h4[text()='Information We Collect or Acquire']";
        string infoWeCollectXpath = "//p[contains(text(),'Depending upon the relationship you choose to have with us, we will collect an a')]";

        //Information that You Give Us
        string titleGiveUsXpath = "//h4[text()='Information that You Give Us']";
        string infoGiveUsXpath1 = "//p[contains(text(),'You may provide us information about yourself when you buy a product from us, us')]";
        string infoGiveUsXpath2 = "//p[contains(text(),'During the quoting, application or claims handling processes we collect such information')]";
        string infoGiveUsXpath3 = "//p[contains(text(),'If you provide us with information about individuals other than yourself, such a')]";

        //Information from Our Affiliates
        string titleAffiliatesXpath = "//h4[text()='Information from Our Affiliates']";
        string infoAffiliatesXpath = "//p[contains(text(),'We may obtain information about your transactions with our affiliates in accorda')]";

        //Information from Third Parties
        string titleThirdPartiesXpath = "//h4[text()='Information from Third Parties']";
        string infoTP1Xpath = "//p[contains(text(),'We may obtain some information about you from non-affiliated third parties. Thes')]";
        string infoTP2Xpath = "//li[text()='Consumer reporting agencies;']";
        string infoTP3Xpath = "//li[text()='Service providers;']";
        string infoTP4Xpath = "//li[contains(text(),'Publicly-available sources such as government databases, media coverage, or other data sources that are available to the public')]";
        string infoTP5Xpath = "//li[text()='Insurance agents and brokers;']";
        string infoTP6Xpath = "//li[text()='Insurance companies;']";
        string infoTP7Xpath = "//li[text()='Social media; and']";
        string infoTP8Xpath = "//li[contains(text(),'Other third parties whom you have authorized to provide us information or as oth')]";

        //Information Collected Automatically
        string titleColletedAutomaticallyXpath = "//h4[text()='Information Collected Automatically']";
        string infoCA1Xpath = "//p[contains(text(),'As you use our services, we may use automatic data collection technologies to co')]";
        string infoCA2Xpath = "//li[contains(text(),'Information about your computer or device and internet connection, including you')]";
        string infoCA3Xpath = "//li[contains(text(),'Details of your visits to our website, including traffic data, location data, lo')]";
        string infoCA4Xpath = "//p[contains(text(),'We also may use these technologies to collect information about your online acti')]";
        string infoCA5Xpath = "//p[contains(text(),'The information we collect automatically may include personal information, or we')]";
        string infoCA6Xpath = "//li[text()='Estimate our audience and usage patterns;']";
        string infoCA7Xpath = "//li[contains(text(),'Store information about your preferences, allowing us to customize our services')]";
        string infoCA8Xpath = "//li[text()='Speed up your searches; and']";
        string infoCA09Xpath = "//li[text()='Recognize you when you return to our services.']";
        string infoCA10Xpath = "//p[text()='The technologies we use for the automatic data collection may include:']";
        string infoCA11Xpath = "//i[text()='Website-specific information']";
        string infoCA12Xpath = "//li[contains(text(),'If you submit an electronic application for insurance with us, for verification means we will gather your IP address, along with the time and date when the application is submitted')]";
        string infoCA13Xpath = "//li[contains(text(),'Our website pages may contain electronic images known as web beacons (also called single-pixel gifs) that permit us to count users who have visited those pages')]";

        string infoCA14Xpath = "//div[@id='text-block-2426']/ul[4]/li[3]";
        string infoCA15Xpath = "//li[text()='Administer and allow personalization of the website;']";
        string infoCA16Xpath = "//li[text()='Quote and administer a policy or other requests;']";
        string infoCA17Xpath = "//li[text()='Obtain website analytics; and']";
        string infoCA18Xpath = "//li[contains(text(),'Retarget or advertise to you on third-party sites.')]";
        string infoCA19Xpath = "//p[contains(text(),'Your web browser can be set to notify you of a cookie and allow you to accept it')]";


        //Uses Made of Your Information
        string titleUsesMadeXpath = "//h4[text()='Uses Made of Your Information']";
        string infoUM1Xpath = "//p[contains(text(),'Generally, we use your personal information to provide you with the products and')]";
        string infoUM2Xpath = "//li[contains(text(),'communicate with you about your account, business relationship, products, or ser')]";
        string infoUM3Xpath = "//li[text()='provide information to you about changes to our products;']";
        string infoUM4Xpath = "//li[contains(.,'let you know about new features, products, or services that may be available to')]";
        string infoUM5Xpath = "//li[text()='underwrite or rate insurance policies;']";
        string infoUM6Xpath = "//li[text()='process, investigate, adjust, and administer your claims;']";
        string infoUM7Xpath = "//li[text()='manage, investigate, or resolve disputes or complaints;']";
        string infoUM8Xpath = "//li[text()='bill you, process payments, and collect on amounts that you may owe us;']";
        string infoUM9Xpath = "//li[text()='confirm your identity;']";
        string infoUM10Xpath = "//li[text()='determine your eligibility for products or services;']";
        string infoUM11Xpath = "//li[text()='personalize your experience with us;']";
        string infoUM12Xpath = "//li[contains(text(),'market other products and services to you, including those that we or our affili')]";
        string infoUM13Xpath = "//li[contains(text(),'market our products and services to those who have similar characteristics to yo')]";
        string infoUM14Xpath = "//li[text()='improve our products, services, website, and operations;']";
        string infoUM15Xpath = "//li[contains(.,'facilitate social media sharing and communications;')]";
        string infoUM16Xpath = "//li[text()='conduct audits, data analysis and research;']";
        string infoUM17Xpath = "//li[contains(text(),'permit you to enter contests, sweepstakes, and similar promotions (which may hav')]";
        string infoUM18Xpath = "//li[contains(text(),'detect, investigate, and prevent activities that may be fraudulent, illegal, or')]";
        string infoUM19Xpath = "//li[contains(text(),'comply with our internal policies and procedures, as well as the laws, rules, an')]";
        string infoUM20Xpath = "//li[text()='respond to requests for information from governmental authorities;']";
        string infoUM21Xpath = "//li[contains(text(),'establish or defend our legal rights and responsibilities, or those of our affil')]";
        string infoUM22Xpath = "//li[text()='perform other activities as permitted by applicable law.']";

        //Disclosure of Your Information
        string titleDisclosureXpath = "//h4[text()='Disclosure of Your Information']";
        string infoDisclosure1Xpath = "//p[contains(.,'We do not sell your personal information to third parties for any purpose. We train our employees to safeguard your personal information and access to all personal information is restricted to only those employees who need the information to perform their official duties. We may, however, disclose your personal information to the following third parties:')]";
        string infoDisclosure2Xpath = "//li[contains(.,'Contractors and service providers we use to support our business and who are bound by contractual obligations to hold the information in confidence and not use such information for any other purpose.')]";
        string infoDisclosure3Xpath = "//li[text()='Your agent or broker, if applicable.']";
        string infoDisclosure4Xpath = "//li[contains(.,'Among our group of companies to offer you additional products and services.')]";
        string infoDisclosure5Xpath = "//li[contains(.,'Our reinsurers.')]";
        string infoDisclosure6Xpath = "//li[contains(.,'Consumer reporting agencies as permitted by law.')]";
        string infoDisclosure7Xpath = "//li[contains(.,'Insurance support organizations that detect and prevent fraud.')]";
        string infoDisclosure8Xpath = "//li[contains(.,'State insurance departments or other governmental or law enforcement authorities if required by law or to protect our legal interests or in cases of suspected fraud or illegal activities.')]";
        string infoDisclosure9Xpath = "//li[contains(.,'Those we are required to share with under a subpoena, search warrant, court or administrative order, or other legal process.')]";
        string infoDisclosure10Xpath = "//li[contains(.,'We reserve the right to transfer your information we have about you in the event we sell or transfer all or a portion of our business or assets.')]";

        // Security of Your Information
        string titleSecurityofYouInformationXpath = "//h4[contains(.,'Security of Your Information')]";
        string infoSecuirtyofYourInformationXpath = "//p[contains(text(),'We use physical, technical and administrative safeguards in protecting your personal information')]";

        // Aggregated or De-identified Data
        string titleAggregatedXpath = "//h4[text()='Aggregated or De-identified Data']";
        string infoAggregatedXpath = "//p[contains(text(),'We may aggregate or de-identify information collected in such a way that removes')]";

        // Choices About Your Information
        string titleChoicesXpath = "//h4[contains(.,'Choices About Your Information')]";
        string infoChoicesXpath = "//p[contains(text(),'Based on the law applicable to the use of your personal information, you may be able')]";
        string titleRightOpOutXpath = "//strong[contains(.,'Right to opt-out')]";
        string infoRightOptOutXpath = "//p[contains(text(),'If you do not want to have your information used by us to promote our products or services')]";
        string titleRightCorrectionXpath = "//strong[contains(.,'Right to correction')]";
        string infoRightCorrectionXpath = "//p[22]";
        string titleRightAcessXpath = "//strong[contains(.,'Right to access')]";
        string infoRightAcessXpath = "//p[contains(text(),'You are entitled to a copy of your personal information we hold about you and to learn details')]";
        string titleRightDeletionXpath = "//strong[contains(.,'Right to deletion')]";
        string infoDeletion1Xpath = "//p[contains(text(),'In certain circumstances, you have the right to ask us to delete your personal information')]";
        string infoDeletion2Xpath = "//p[contains(text(),'You may request to exercise the foregoing rights by emailing')]";
        string infoDeletion3Xpath = "//p[contains(text(),'We will maintain an audit history of any requests to access or delete personal information')]";

        //Contact Us
        string titleContactUsXpath = "//h4[contains(.,'Contact Us')]";
        string infoContactUsXpath = "//p[contains(text(),'This website is operated by Jewelers Mutual Group, 24 Jewelers Park Dr., Neenah, Wisconsin 54956.')]";
        string linkContactUsXpath = "//a[text()='Contact Us']";

        //Questions or Comments
        string titleQuestionsorCommentsXpath = "//h4[text()='Questions or Comments']";
        string infoQuestionsorCommentsXpath = "//p[contains(text(),'To ask questions or comment about this Privacy Policy or our privacy practices')]";

        // string phoneContactUsXpath = "a[href='tel:18005586411']";

        PrivacyPolicy_D_V PrivacyPolicy_D_V = new PrivacyPolicy_D_V();
        public PrivacyPolicy_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }


        public override void VerifyPage()
        {// Add all the elements you want to verify

            VerifyUIElementIsDisplayed(headerPrivacyPolicyXpath);
            VerifyUIElementIsDisplayed(headerPPBodyXpath);
            VerifyUIElementIsDisplayed(infoUpdated2019Xpath);
            VerifyUIElementIsDisplayed(titleIntroductionXpath);
            VerifyUIElementIsDisplayed(infoIntroductionXpath);
            VerifyUIElementIsDisplayed(titleChangesXpath);
            VerifyUIElementIsDisplayed(infoChangesXpath);
            VerifyUIElementIsDisplayed(titleWeCollectXpath);
            VerifyUIElementIsDisplayed(infoWeCollectXpath);
            VerifyUIElementIsDisplayed(titleGiveUsXpath);
            VerifyUIElementIsDisplayed(infoGiveUsXpath1);
            VerifyUIElementIsDisplayed(infoGiveUsXpath2);
            VerifyUIElementIsDisplayed(infoGiveUsXpath3);
            VerifyUIElementIsDisplayed(titleAffiliatesXpath);
            VerifyUIElementIsDisplayed(infoAffiliatesXpath);
            VerifyUIElementIsDisplayed(titleThirdPartiesXpath);
            VerifyUIElementIsDisplayed(infoTP1Xpath);
            VerifyUIElementIsDisplayed(infoTP2Xpath);
            VerifyUIElementIsDisplayed(infoTP3Xpath);
            VerifyUIElementIsDisplayed(infoTP4Xpath);
            VerifyUIElementIsDisplayed(infoTP5Xpath);
            VerifyUIElementIsDisplayed(infoTP6Xpath);
            VerifyUIElementIsDisplayed(infoTP7Xpath);
            VerifyUIElementIsDisplayed(infoTP8Xpath);
            VerifyUIElementIsDisplayed(titleColletedAutomaticallyXpath);
            VerifyUIElementIsDisplayed(infoCA1Xpath);
            VerifyUIElementIsDisplayed(infoCA2Xpath);
            VerifyUIElementIsDisplayed(infoCA3Xpath);
            VerifyUIElementIsDisplayed(infoCA4Xpath);
            VerifyUIElementIsDisplayed(infoCA5Xpath);
            VerifyUIElementIsDisplayed(infoCA6Xpath);
            VerifyUIElementIsDisplayed(infoCA7Xpath);
            VerifyUIElementIsDisplayed(infoCA8Xpath);
            VerifyUIElementIsDisplayed(infoCA09Xpath);
            VerifyUIElementIsDisplayed(infoCA10Xpath);
            VerifyUIElementIsDisplayed(infoCA11Xpath);
            VerifyUIElementIsDisplayed(infoCA12Xpath);
            VerifyUIElementIsDisplayed(infoCA13Xpath);
            VerifyUIElementIsDisplayed(infoCA14Xpath);
            VerifyUIElementIsDisplayed(infoCA15Xpath);
            VerifyUIElementIsDisplayed(infoCA16Xpath);
            VerifyUIElementIsDisplayed(infoCA17Xpath);
            VerifyUIElementIsDisplayed(infoCA18Xpath);
            VerifyUIElementIsDisplayed(infoCA19Xpath);
            VerifyUIElementIsDisplayed(titleUsesMadeXpath);
            VerifyUIElementIsDisplayed(infoUM1Xpath);
            VerifyUIElementIsDisplayed(infoUM2Xpath);
            VerifyUIElementIsDisplayed(infoUM3Xpath);
            VerifyUIElementIsDisplayed(infoUM4Xpath);
            VerifyUIElementIsDisplayed(infoUM5Xpath);
            VerifyUIElementIsDisplayed(infoUM6Xpath);
            VerifyUIElementIsDisplayed(infoUM7Xpath);
            VerifyUIElementIsDisplayed(infoUM8Xpath);
            VerifyUIElementIsDisplayed(infoUM9Xpath);
            VerifyUIElementIsDisplayed(infoUM10Xpath);
            VerifyUIElementIsDisplayed(infoUM11Xpath);
            VerifyUIElementIsDisplayed(infoUM12Xpath);
            VerifyUIElementIsDisplayed(infoUM13Xpath);
            VerifyUIElementIsDisplayed(infoUM14Xpath);
            VerifyUIElementIsDisplayed(infoUM15Xpath);
            VerifyUIElementIsDisplayed(infoUM16Xpath);
            VerifyUIElementIsDisplayed(infoUM17Xpath);
            VerifyUIElementIsDisplayed(infoUM18Xpath);
            VerifyUIElementIsDisplayed(infoUM19Xpath);
            VerifyUIElementIsDisplayed(infoUM20Xpath);
            VerifyUIElementIsDisplayed(infoUM21Xpath);
            VerifyUIElementIsDisplayed(infoUM22Xpath);
            VerifyUIElementIsDisplayed(titleDisclosureXpath);
            VerifyUIElementIsDisplayed(infoDisclosure1Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure2Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure3Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure4Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure5Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure6Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure7Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure8Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure9Xpath);
            VerifyUIElementIsDisplayed(infoDisclosure10Xpath);
            VerifyUIElementIsDisplayed(titleSecurityofYouInformationXpath);
            VerifyUIElementIsDisplayed(infoSecuirtyofYourInformationXpath);
            VerifyUIElementIsDisplayed(titleAggregatedXpath);
            VerifyUIElementIsDisplayed(infoAggregatedXpath);
            VerifyUIElementIsDisplayed(titleChoicesXpath);
            VerifyUIElementIsDisplayed(infoChoicesXpath);
            VerifyUIElementIsDisplayed(titleRightOpOutXpath);
            VerifyUIElementIsDisplayed(infoRightOptOutXpath);
            VerifyUIElementIsDisplayed(titleRightCorrectionXpath);
            VerifyUIElementIsDisplayed(infoRightCorrectionXpath);
            VerifyUIElementIsDisplayed(titleRightAcessXpath);
            VerifyUIElementIsDisplayed(infoRightAcessXpath);
            VerifyUIElementIsDisplayed(titleRightDeletionXpath);
            VerifyUIElementIsDisplayed(infoDeletion1Xpath);
            VerifyUIElementIsDisplayed(infoDeletion2Xpath);
            VerifyUIElementIsDisplayed(infoDeletion3Xpath);
            VerifyUIElementIsDisplayed(titleContactUsXpath);
            VerifyUIElementIsDisplayed(infoContactUsXpath);
            VerifyUIElementIsDisplayed(linkContactUsXpath);
            VerifyUIElementIsDisplayed(titleQuestionsorCommentsXpath);
            VerifyUIElementIsDisplayed(infoQuestionsorCommentsXpath);

            Console.WriteLine("end of page load");
            //  VerifyUIElementIsDisplayed(phoneContactUsXpath);
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
        public void verifyPrivacyPolicy()
        {
            Console.WriteLine("Privacy Policy sTART");
            // Privacy Policy 
            string HeaderPrivacyPolicy = driver.FindElement(By.XPath(headerPrivacyPolicyXpath)).Text;
            Console.WriteLine("HeaderPrivacyPolicy is " + HeaderPrivacyPolicy);
            Assert.AreEqual(HeaderPrivacyPolicy, PrivacyPolicy_D_V.txtHeaderPrivacyPolicy, "The Text doesn't match");

            string HeaderPPBody = driver.FindElement(By.XPath(headerPPBodyXpath)).Text;
            Console.WriteLine("HeaderPPBody is " + HeaderPPBody);
            Assert.AreEqual(HeaderPPBody, PrivacyPolicy_D_V.txtHeaderPPBody, "The Text doesn't match");

            string InfoUpdated2019 = driver.FindElement(By.XPath(infoUpdated2019Xpath)).Text;
            Console.WriteLine("InfoUpdated2018 is " + InfoUpdated2019);
            Assert.AreEqual(InfoUpdated2019, PrivacyPolicy_D_V.txtInfoUpdated2019, "The Text doesn't match");
            Console.WriteLine("Privacy Policy main");
        }

        public void verifyIntroduction()
        {
            //Introduction
            string TitleIntroduction = driver.FindElement(By.XPath(titleIntroductionXpath)).Text;
            Assert.AreEqual(TitleIntroduction, PrivacyPolicy_D_V.txtTitleIntroduction, "The Text doesn't match");

            string InfoIntroduction = driver.FindElement(By.XPath(infoIntroductionXpath)).Text;
            Console.WriteLine("InfoIntroduction " + InfoIntroduction);
            InfoIntroduction = InfoIntroduction.Replace("\"", "'");
            Assert.AreEqual(InfoIntroduction.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoIntroduction.ToLower().Trim(), "The Text doesn't match");

            //Assert.AreEqual(ContactInformation.ToLower().Trim(), Contact_D_V.txtHeaderContacttxtInformation.ToLower().Trim(), "The Text " + Contact_D_V.txtEmailUs + " doesn't match");

        }

        public void verifyChanges()
        {
            //Changes to our Privacy Policy
            string TitleChanges = driver.FindElement(By.XPath(titleChangesXpath)).Text;
            Console.WriteLine("TitleChanges " + TitleChanges);
            Assert.AreEqual(TitleChanges, PrivacyPolicy_D_V.txtTitleChanges, "The Text doesn't match");

            string InfoChanges = driver.FindElement(By.XPath(infoChangesXpath)).Text;
            Console.WriteLine("InfoChanges " + InfoChanges);
            Assert.AreEqual(InfoChanges, PrivacyPolicy_D_V.txtInfoChanges, "The Text doesn't match");
        }

        public void verifyWeCollect()
        {
            // Information We Collect or Acquire
            string TitleWeCollect = driver.FindElement(By.XPath(titleWeCollectXpath)).Text;
            Assert.AreEqual(TitleWeCollect, PrivacyPolicy_D_V.txtTitleWeCollect, "The Text doesn't match");

            string InfoWeCollect = driver.FindElement(By.XPath(infoWeCollectXpath)).Text;
            Assert.AreEqual(InfoWeCollect.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoWeCollect.ToLower().Trim(), "The Text doesn't match");
            Console.WriteLine("Information We Collect or Acquire");
        }

        public void verifyGiveUs()
        {
            // Information that You Give Us
            string TitleGiveUs = driver.FindElement(By.XPath(titleGiveUsXpath)).Text;
            Assert.AreEqual(TitleGiveUs, PrivacyPolicy_D_V.txtTitleGiveUs, "The Text doesn't match");

            string InfoGiveUs1 = driver.FindElement(By.XPath(infoGiveUsXpath1)).Text;
            Assert.AreEqual(InfoGiveUs1.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoGiveUs1.ToLower().Trim(), "The Text doesn't match");

            string InfoGiveUs2 = driver.FindElement(By.XPath(infoGiveUsXpath2)).Text;
            Assert.AreEqual(InfoGiveUs2.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoGiveUs2.ToLower().Trim(), "The Text doesn't match");

            string InfoGiveUs3 = driver.FindElement(By.XPath(infoGiveUsXpath3)).Text;
            Assert.AreEqual(InfoGiveUs3.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoGiveUs3.ToLower().Trim(), "The Text doesn't match");
            Console.WriteLine("Information that You Give Us");

        }

        public void verifyAffiliates()
        {
            // Information from Our Affiliates
            string TitleAffiliates = driver.FindElement(By.XPath(titleAffiliatesXpath)).Text;
            Assert.AreEqual(TitleAffiliates.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleAffiliates.ToLower().Trim(), "The Text doesn't match");

            string InfoAffiliates = driver.FindElement(By.XPath(infoAffiliatesXpath)).Text;
            Assert.AreEqual(InfoAffiliates.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoAffiliates.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Information from Our Affiliates");
        }

        public void verifyThirdParties()
        {
            // Information from Third Parties
            string TitleThirdParties = driver.FindElement(By.XPath(titleThirdPartiesXpath)).Text;
            Assert.AreEqual(TitleThirdParties.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleThirdParties.ToLower().Trim(), "The Text doesn't match");

            string InfoTP1 = driver.FindElement(By.XPath(infoTP1Xpath)).Text;
            Assert.AreEqual(InfoTP1.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoTP1.ToLower().Trim(), "The Text doesn't match");

            string InfoTP2 = driver.FindElement(By.XPath(infoTP2Xpath)).Text;
            Assert.AreEqual(InfoTP2.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoTP2.ToLower().Trim(), "The Text doesn't match");

            string InfoTP3 = driver.FindElement(By.XPath(infoTP3Xpath)).Text;
            Assert.AreEqual(InfoTP3.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoTP3.ToLower().Trim(), "The Text doesn't match");

            string InfoTP4 = driver.FindElement(By.XPath(infoTP4Xpath)).Text;
            Assert.AreEqual(InfoTP4.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoTP4.ToLower().Trim(), "The Text doesn't match");

            string InfoTP5 = driver.FindElement(By.XPath(infoTP5Xpath)).Text;
            Assert.AreEqual(InfoTP5.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoTP5.ToLower().Trim(), "The Text doesn't match");

            string InfoTP6 = driver.FindElement(By.XPath(infoTP6Xpath)).Text;
            Assert.AreEqual(InfoTP6.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoTP6.ToLower().Trim(), "The Text doesn't match");

            string InfoTP7 = driver.FindElement(By.XPath(infoTP7Xpath)).Text;
            Assert.AreEqual(InfoTP7.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoTP7.ToLower().Trim(), "The Text doesn't match");

            string InfoTP8 = driver.FindElement(By.XPath(infoTP8Xpath)).Text;
            Assert.AreEqual(InfoTP8.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoTP8.ToLower().Trim(), "The Text doesn't match");


            Console.WriteLine("Information from Third Parties");

        }

        public void verifyCollected()
        {

            //Information Collected Automatically
            string TitleColletedAutomatically = driver.FindElement(By.XPath(titleColletedAutomaticallyXpath)).Text;
            Assert.AreEqual(TitleColletedAutomatically.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleColletedAutomatically.ToLower().Trim(), "The Text doesn't match");

            string InfoCA1 = driver.FindElement(By.XPath(infoCA1Xpath)).Text;
            Assert.AreEqual(InfoCA1.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA1.ToLower().Trim(), "The Text doesn't match");

            string InfoCA2 = driver.FindElement(By.XPath(infoCA2Xpath)).Text;
            Assert.AreEqual(InfoCA2.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA2.ToLower().Trim(), "The Text doesn't match");

            string InfoCA3 = driver.FindElement(By.XPath(infoCA3Xpath)).Text;
            Assert.AreEqual(InfoCA3.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA3.ToLower().Trim(), "The Text doesn't match");

            string InfoCA4 = driver.FindElement(By.XPath(infoCA4Xpath)).Text;
            Assert.AreEqual(InfoCA4.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA4.ToLower().Trim(), "The Text doesn't match");

            string InfoCA5 = driver.FindElement(By.XPath(infoCA5Xpath)).Text;
            Assert.AreEqual(InfoCA5.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA5.ToLower().Trim(), "The Text doesn't match");

            string InfoCA6 = driver.FindElement(By.XPath(infoCA6Xpath)).Text;
            Assert.AreEqual(InfoCA6.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA6.ToLower().Trim(), "The Text doesn't match");

            string InfoCA7 = driver.FindElement(By.XPath(infoCA7Xpath)).Text;
            Assert.AreEqual(InfoCA7.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA7.ToLower().Trim(), "The Text doesn't match");

            string InfoCA8 = driver.FindElement(By.XPath(infoCA8Xpath)).Text;
            Assert.AreEqual(InfoCA8.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA8.ToLower().Trim(), "The Text doesn't match");

            string InfoCA09 = driver.FindElement(By.XPath(infoCA09Xpath)).Text;
            Assert.AreEqual(InfoCA09.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA9.ToLower().Trim(), "The Text doesn't match");

            string InfoCA10 = driver.FindElement(By.XPath(infoCA10Xpath)).Text;
            Assert.AreEqual(InfoCA10.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA10.ToLower().Trim(), "The Text doesn't match");

            string InfoCA11 = driver.FindElement(By.XPath(infoCA11Xpath)).Text;
            Assert.AreEqual(InfoCA11.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA11.ToLower().Trim(), "The Text doesn't match");

            string InfoCA12 = driver.FindElement(By.XPath(infoCA12Xpath)).Text;
            Assert.AreEqual(InfoCA12.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA12.ToLower().Trim(), "The Text doesn't match");

            string InfoCA13 = driver.FindElement(By.XPath(infoCA13Xpath)).Text;
            Assert.AreEqual(InfoCA13.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA13.ToLower().Trim(), "The Text doesn't match");

            string InfoCA14 = driver.FindElement(By.XPath(infoCA14Xpath)).Text;
            System.Console.WriteLine("before New line" + InfoCA14);
            InfoCA14 = InfoCA14.Replace(System.Environment.NewLine, "");
            System.Console.WriteLine("After New line" + InfoCA14);
            Assert.AreEqual(InfoCA14.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA14.ToLower().Trim(), "The Text doesn't match");

            //string InfoCA15 = driver.FindElement(By.XPath(infoCA15Xpath)).Text;
            //Assert.AreEqual(InfoCA15.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA15.ToLower().Trim(), "The Text doesn't match");

            //string InfoCA16 = driver.FindElement(By.XPath(infoCA16Xpath)).Text;
            //Assert.AreEqual(InfoCA16.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA16.ToLower().Trim(), "The Text doesn't match");

            //string InfoCA17 = driver.FindElement(By.XPath(infoCA17Xpath)).Text;
            //Assert.AreEqual(InfoCA17.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA17.ToLower().Trim(), "The Text doesn't match");

            //string InfoCA18 = driver.FindElement(By.XPath(infoCA18Xpath)).Text;
            //Assert.AreEqual(InfoCA18.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA18.ToLower().Trim(), "The Text doesn't match");

            string InfoCA19 = driver.FindElement(By.XPath(infoCA19Xpath)).Text;
            Assert.AreEqual(InfoCA19.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoCA19.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Information Collected Automatically");

        }

        public void verifyUseofInformation()
        {
            //Uses Made of Your Information

            string TitleUsesMade = driver.FindElement(By.XPath(titleUsesMadeXpath)).Text;
            Assert.AreEqual(TitleUsesMade.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleUsesMade.ToLower().Trim(), "The Text doesn't match");

            string InfoUM1 = driver.FindElement(By.XPath(infoUM1Xpath)).Text;
            Assert.AreEqual(InfoUM1.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM1.ToLower().Trim(), "The Text doesn't match");

            string InfoUM2 = driver.FindElement(By.XPath(infoUM2Xpath)).Text;
            Assert.AreEqual(InfoUM2.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM2.ToLower().Trim(), "The Text doesn't match");

            string InfoUM3 = driver.FindElement(By.XPath(infoUM3Xpath)).Text;
            Assert.AreEqual(InfoUM3.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM3.ToLower().Trim(), "The Text doesn't match");

            string InfoUM4 = driver.FindElement(By.XPath(infoUM4Xpath)).Text;
            Assert.AreEqual(InfoUM4.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM4.ToLower().Trim(), "The Text doesn't match");

            string InfoUM5 = driver.FindElement(By.XPath(infoUM5Xpath)).Text;
            Assert.AreEqual(InfoUM5.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM5.ToLower().Trim(), "The Text doesn't match");

            string InfoUM6 = driver.FindElement(By.XPath(infoUM6Xpath)).Text;
            Assert.AreEqual(InfoUM6.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM6.ToLower().Trim(), "The Text doesn't match");

            string InfoUM7 = driver.FindElement(By.XPath(infoUM7Xpath)).Text;
            Assert.AreEqual(InfoUM7.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM7.ToLower().Trim(), "The Text doesn't match");

            string InfoUM8 = driver.FindElement(By.XPath(infoUM8Xpath)).Text;
            Assert.AreEqual(InfoUM8.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM8.ToLower().Trim(), "The Text doesn't match");

            string InfoUM9 = driver.FindElement(By.XPath(infoUM9Xpath)).Text;
            Assert.AreEqual(InfoUM9.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM9.ToLower().Trim(), "The Text doesn't match");

            string InfoUM10 = driver.FindElement(By.XPath(infoUM10Xpath)).Text;
            Assert.AreEqual(InfoUM10.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM10.ToLower().Trim(), "The Text doesn't match");

            string InfoUM11 = driver.FindElement(By.XPath(infoUM11Xpath)).Text;
            Assert.AreEqual(InfoUM11.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM11.ToLower().Trim(), "The Text doesn't match");

            string InfoUM12 = driver.FindElement(By.XPath(infoUM12Xpath)).Text;
            Assert.AreEqual(InfoUM12.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM12.ToLower().Trim(), "The Text doesn't match");

            string InfoUM13 = driver.FindElement(By.XPath(infoUM13Xpath)).Text;
            Assert.AreEqual(InfoUM13.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM13.ToLower().Trim(), "The Text doesn't match");

            string InfoUM14 = driver.FindElement(By.XPath(infoUM14Xpath)).Text;
            Assert.AreEqual(InfoUM14.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM14.ToLower().Trim(), "The Text doesn't match");

            string InfoUM15 = driver.FindElement(By.XPath(infoUM15Xpath)).Text;
            Assert.AreEqual(InfoUM15.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM15.ToLower().Trim(), "The Text doesn't match");

            string InfoUM16 = driver.FindElement(By.XPath(infoUM16Xpath)).Text;
            Assert.AreEqual(InfoUM16.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM16.ToLower().Trim(), "The Text doesn't match");

            string InfoUM17 = driver.FindElement(By.XPath(infoUM17Xpath)).Text;
            Assert.AreEqual(InfoUM17.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM17.ToLower().Trim(), "The Text doesn't match");

            string InfoUM18 = driver.FindElement(By.XPath(infoUM18Xpath)).Text;
            Assert.AreEqual(InfoUM18.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM18.ToLower().Trim(), "The Text doesn't match");

            string InfoUM19 = driver.FindElement(By.XPath(infoUM19Xpath)).Text;
            Assert.AreEqual(InfoUM19.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM19.ToLower().Trim(), "The Text doesn't match");

            string InfoUM20 = driver.FindElement(By.XPath(infoUM20Xpath)).Text;
            Assert.AreEqual(InfoUM20.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM20.ToLower().Trim(), "The Text doesn't match");

            string InfoUM21 = driver.FindElement(By.XPath(infoUM21Xpath)).Text;
            Assert.AreEqual(InfoUM21.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM21.ToLower().Trim(), "The Text doesn't match");

            string InfoUM22 = driver.FindElement(By.XPath(infoUM22Xpath)).Text;
            Assert.AreEqual(InfoUM22.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoUM22.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Uses Made of Your Information");
        }

        public void verifyDisclosure()
        {
            //Disclosure of Your Information
            string TitleDisclosure = driver.FindElement(By.XPath(titleDisclosureXpath)).Text;
            Assert.AreEqual(TitleDisclosure.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleDisclosure.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure1 = driver.FindElement(By.XPath(infoDisclosure1Xpath)).Text;
            Assert.AreEqual(InfoDisclosure1.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure1.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure2 = driver.FindElement(By.XPath(infoDisclosure2Xpath)).Text;
            Assert.AreEqual(InfoDisclosure2.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure2.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure3 = driver.FindElement(By.XPath(infoDisclosure3Xpath)).Text;
            Assert.AreEqual(InfoDisclosure3.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure3.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure4 = driver.FindElement(By.XPath(infoDisclosure4Xpath)).Text;
            Assert.AreEqual(InfoDisclosure4.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure4.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure5 = driver.FindElement(By.XPath(infoDisclosure5Xpath)).Text;
            Assert.AreEqual(InfoDisclosure5.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure5.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure6 = driver.FindElement(By.XPath(infoDisclosure6Xpath)).Text;
            Assert.AreEqual(InfoDisclosure6.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure6.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure7 = driver.FindElement(By.XPath(infoDisclosure7Xpath)).Text;
            Assert.AreEqual(InfoDisclosure7.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure7.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure8 = driver.FindElement(By.XPath(infoDisclosure8Xpath)).Text;
            Assert.AreEqual(InfoDisclosure8.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure8.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure9 = driver.FindElement(By.XPath(infoDisclosure9Xpath)).Text;
            Assert.AreEqual(InfoDisclosure9.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure9.ToLower().Trim(), "The Text doesn't match");

            string InfoDisclosure10 = driver.FindElement(By.XPath(infoDisclosure10Xpath)).Text;
            Assert.AreEqual(InfoDisclosure10.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDisclosure10.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Disclosure of Your Information");
        }

        public void verifySecurity()
        {
            //Aggregated or De-identified Data

            string TitleSecurityofYouInformation = driver.FindElement(By.XPath(titleSecurityofYouInformationXpath)).Text;
            Assert.AreEqual(TitleSecurityofYouInformation.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleSecurity.ToLower().Trim(), "The Text doesn't match");

            string InfoSecuirtyofYourInformation = driver.FindElement(By.XPath(infoSecuirtyofYourInformationXpath)).Text;
            Assert.AreEqual(InfoSecuirtyofYourInformation.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoSecuity.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Security of Your Information");
        }


        public void verifyAggregated()
        {
            //Aggregated or De-identified Data

            string TitleAggregated = driver.FindElement(By.XPath(titleAggregatedXpath)).Text;
            Assert.AreEqual(TitleAggregated.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleAggregated.ToLower().Trim(), "The Text doesn't match");

            string InfoAggregated = driver.FindElement(By.XPath(infoAggregatedXpath)).Text;
            Assert.AreEqual(InfoAggregated.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoAggregated.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Aggregated or De-identified Data");
        }

        public void verifyInformation()
        {
            //Choices about How We Use and Disclose Your Information

            string TitleChoices = driver.FindElement(By.XPath(titleChoicesXpath)).Text;
            Assert.AreEqual(TitleChoices.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleChoices.ToLower().Trim(), "The Text doesn't match");

            string InfoChoices = driver.FindElement(By.XPath(infoChoicesXpath)).Text;
            Assert.AreEqual(InfoChoices.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoChoices.ToLower().Trim(), "The Text doesn't match");

            string TitleRightOpOut = driver.FindElement(By.XPath(titleRightOpOutXpath)).Text;
            Assert.AreEqual(TitleRightOpOut.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleRightOptOut.ToLower().Trim(), "The Text doesn't match");

            string InfoRightOptOut = driver.FindElement(By.XPath(infoRightOptOutXpath)).Text;
            System.Console.WriteLine("before New line" + InfoRightOptOut);
            InfoRightOptOut = InfoRightOptOut.Replace(System.Environment.NewLine, "");
            System.Console.WriteLine("After New line" + InfoRightOptOut);
            Assert.AreEqual(InfoRightOptOut.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoRightOptOut.ToLower().Trim(), "The Text doesn't match");

            string TitleRightCorrection = driver.FindElement(By.XPath(titleRightCorrectionXpath)).Text;
            Assert.AreEqual(TitleRightCorrection.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleRightCorrection.ToLower().Trim(), "The Text doesn't match");

            string InfoRightCorrection = driver.FindElement(By.XPath(infoRightCorrectionXpath)).Text;
            System.Console.WriteLine("before New line" + InfoRightCorrection);
            InfoRightCorrection = InfoRightCorrection.Replace(System.Environment.NewLine, "");
            System.Console.WriteLine("After New line" + InfoRightCorrection);
            Assert.AreEqual(InfoRightCorrection.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoRightCorrection.ToLower().Trim(), "The Text doesn't match");

            string TitleRightAcess = driver.FindElement(By.XPath(titleRightAcessXpath)).Text;
            Assert.AreEqual(TitleRightAcess.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleRightAcess.ToLower().Trim(), "The Text doesn't match");

            string InfoRightAcess = driver.FindElement(By.XPath(infoRightAcessXpath)).Text;
            System.Console.WriteLine("before New line" + InfoRightAcess);
            InfoRightAcess = InfoRightAcess.Replace(System.Environment.NewLine, "");
            InfoRightAcess = Regex.Replace(InfoRightAcess, @".  ", ".", RegexOptions.Multiline).TrimEnd();
            System.Console.WriteLine("After New line" + InfoRightAcess);
            Assert.AreEqual(InfoRightAcess.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoRightAcess.ToLower().Trim(), "The Text doesn't match");

            string TitleRightDeletion = driver.FindElement(By.XPath(titleRightDeletionXpath)).Text;
            Assert.AreEqual(TitleRightDeletion.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleRightDeletion.ToLower().Trim(), "The Text doesn't match");

            string InfoDeletion1 = driver.FindElement(By.XPath(infoDeletion1Xpath)).Text;
            System.Console.WriteLine("before New line" + InfoDeletion1);
            InfoDeletion1 = InfoDeletion1.Replace(System.Environment.NewLine, "");
            System.Console.WriteLine("After New line" + InfoDeletion1);
            Assert.AreEqual(InfoDeletion1.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDeletion1.ToLower().Trim(), "The Text doesn't match");

            string InfoDeletion2 = driver.FindElement(By.XPath(infoDeletion2Xpath)).Text;
            Assert.AreEqual(InfoDeletion2.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDeletion2.ToLower().Trim(), "The Text doesn't match");

            string InfoDeletion3 = driver.FindElement(By.XPath(infoDeletion3Xpath)).Text;
            Assert.AreEqual(InfoDeletion3.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoDeletion3.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Choices About Your Information");

        }

        public void verifyContactUs()
        {
            //Accessing and Correcting Your Information

            string TitleContactUs = driver.FindElement(By.XPath(titleContactUsXpath)).Text;
            Assert.AreEqual(TitleContactUs.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleContactUs.ToLower().Trim(), "The Text doesn't match");

            string InfoContactUs = driver.FindElement(By.XPath(infoContactUsXpath)).Text;
            Assert.AreEqual(InfoContactUs.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoContactUs.ToLower().Trim(), "The Text doesn't match");

            string LinkContactUs = driver.FindElement(By.XPath(linkContactUsXpath)).Text;
            Assert.AreEqual(LinkContactUs.ToLower().Trim(), PrivacyPolicy_D_V.hrefContactUs.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Contact Us");
        }

        public void verifyQuestions()
        {
            //Questions or Comments

            string TitleQuestionsorComments = driver.FindElement(By.XPath(titleQuestionsorCommentsXpath)).Text;
            Console.WriteLine("value is " + TitleQuestionsorComments);
            Assert.AreEqual(TitleQuestionsorComments.ToLower().Trim(), PrivacyPolicy_D_V.txtTitleQuestionsorComments.ToLower().Trim(), "The Text doesn't match");

            //string InfoQuestionsorComments = driver.FindElement(By.XPath(infoQuestionsorCommentsXpath)).GetAttribute("innerText");
            //InfoQuestionsorComments = InfoQuestionsorComments.Replace(System.Environment.NewLine, "");
            //InfoQuestionsorComments = Regex.Replace(InfoQuestionsorComments, @"\n", "", RegexOptions.Multiline).TrimEnd();
            //InfoQuestionsorComments = Regex.Replace(InfoQuestionsorComments, @"y @", "y@", RegexOptions.Multiline).TrimEnd();
            //Console.WriteLine("value is " + InfoQuestionsorComments);
            //Assert.AreEqual(InfoQuestionsorComments.ToLower().Trim(), PrivacyPolicy_D_V.txtInfoQuestionsorComments.ToLower().Trim(), "The Text doesn't match");

            Console.WriteLine("Questions or Comments");
        }

        public void verifyPJInsurancePageContent()
        {
            verifyNavBar();
            verifyFooter();
            VerifyPage();
            verifyPrivacyPolicy();
            verifyIntroduction();
            verifyChanges();
            verifyWeCollect();
            verifyGiveUs();
            verifyAffiliates();
            verifyThirdParties();
            verifyCollected();
            verifyUseofInformation();
            verifyDisclosure();
            verifySecurity();
            verifyAggregated();
            verifyInformation();
            verifyContactUs();
            verifyQuestions();
        }
    }
}
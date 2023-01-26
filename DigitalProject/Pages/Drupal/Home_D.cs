using DigitalProject.Pages.Drupal;
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
    public class Home_D : Page
    {
        // Elements  
        string jmLogoCSS = "//*[@id='block-jewelers-mutual-branding']/a[1]";
        string navPersonalInsuranceXpath = "//a[text()='Personal Insurance']";
        string navGetAQuoteXpath = "//a[text()='Get a Quote']";
        string navPLPayMyBillXpath = "//a[text()='Pay My Bill']";
        string navClaimsXpath = "//a[text()='Claims']";
        string navManageMyPolicyXpath = "//a[text()='Manage My Policy']";
        string navPLBlogXpath = "//a[text()='Blog']";
        string navJewelryBusinessXpath = "//a[.='Business Insurance']";
        string navCLClaims = "//a[.='Claims']";
        string navCLPayMyBillXpath = "//a[@href='/business/pay-my-bill']";
        string navbarclaimsbussiness = "//*[@id='block-jewelers-mutual-main-menu']/ul/div/li[2]/ul/li[2]/a";
        string navZingPlatform = "//a[.='Zing™ Platform']"; 
        string navShippingXpath = "//a[.='JM™ Shipping Solution']"; 
        string navJewelerProgramsXpath = "//a[.='Jeweler Programs']";
        string navCarePlanXpath = "//a[text()='JM™ Care Plan']";
        string navPawnbrokersXpath = "//a[text()='Pawnbrokers']";
        string navAnswersMenuXpath = "//a[.='Answers']";
        string navFAQXpath = "//li[@class='menu-item menu-item--link-faq']/a[.='FAQ']";
        string navJewelryInsurance101Xpath = "//li[@class='menu-item menu-item--link-jewelry-insurance-101']/a[.='Jewelry Insurance 101']";
        string navAboutUsMenuXpath = "//li[@class='menu-item menu-item--link-about-us menu-item--expanded menu-item--top-level']/a[.='About Us']";
        string navAboutUsXpath = "//li[@class='menu-item menu-item--link-about-us']/a[text()='About Us']";
        string navNewsroomXpath = "//li[@class='menu-item menu-item--link-newsroom']/a[text()='Newsroom']";
        string navNewsroom = "//li[@class='menu-item menu-item--link-newsroom menu-item--active-trail']/a[text()='Newsroom']";
        string navSocialResponsibilityXpath = "//a[text()='Social Responsibility']";
        string navCareersXpath = "//a[text()='Careers']";
        string navLogInXpath = "//a[text()='Log In']";
        string navPersonalJewelryLoginXpath = "//a[text()='Personal Jewelry']";
        string navAgentLoginXpath = "//a[text()='Agent']";
        string navZingplatformXpath = "//a[@href='https://zing.jewelersmutual.com/']";
        string navZingLoginXpath = "//a[@href='https://zing.jewelersmutual.com']";
        string ftContactXpath = "//a[.='Contact Us']";
        string ftPrivacyPolicyXpath = "//a[@href='/privacy-policy']";
        string ftTermsofUseXpath = "//a[@href='/terms-of-use']"; 
        string ftShareYourConcernsXpath = "//a[text()='Share Your Concerns']";
        string ftCareersXpath = "//a[text()='Careers']";
        string ftNewsroomXpath = "//a[text()='Newsroom']";
        string ftFacebookCSS = "div#block-socialmedialinks a[href *='www.facebook.com']";
        string ftInstagramCSS = "div#block-socialmedialinks a[href *='http://www.instagram.com/JewelersMutual']";
        string ftTwitterCSS = "div#block-socialmedialinks a[href *='http://www.twitter.com/JewelersMutual']";
        string ftLinkedInCSS = "div#block-socialmedialinks a[href *='https://www.linkedin.com/company/jewelers-mutual-insurance-company']";
        string ftCoverageDisclaimer1Xpath = "//p[contains(.,'Coverage is offered by a member insurer of Jewelers Mutual Insurance Group and is subject to underwriting review and approval, and to the actual policy terms and conditions. Any descriptions are a brief summary of coverage and are not part of any policies, nor a substitute for the actual policy language.')]";
        string ftCoverageDisclaimer2Xpath = "//p[contains(.,'Coverage is offered by a member insurer of the Jewelers Mutual Group, either Jewelers Mutual Insurance Company, SI (a stock insurer) or JM Specialty Insurance Company. Policyholders of both insurers are members of Jewelers Mutual Holding Company.')]";
        string ftCopyrightYearXpath = "//p[text()='© 2020 Jewelers Mutual - All Rights Reserved']";
        string headerHonoringXpath = "//h1[contains(., 'Honoring and protecting')]";
        string headerSinceXpath = "//h1[contains(., 'jewelry since 1913.')]";
        string btnExplorePJIXpath = "//a[contains(.,'Explore personal jewelry insurance')]";
        string linkTellMeAboutXpath = "//a[text()='Tell me about jewelry business insurance.']";
        string headerPersonalPolicyCenterXpath = "//h2[contains(.,'Personal Policy Center')]";

        // start point of Elements on page
        string iconManageMyAccountXpath = "//img[@alt='Account Icon']";
        string iconMakeaPaymentXpath = "//img[@alt='Payment Icon']";
        // //*[@id="feature-row-141"]/div/h2
        string titleItAllComesXpath = "//h2[contains(.,'It All Comes Down to Trust')]";
        string titleManageMyAccountXpath = "//h4[text()='Manage My Account']";
        string infoManageMyAccountXpath = "//p[text()='Review and make changes to your policy through your secure online account.']";
        string linkLogInXpath = "//a[text()='Log in']";
        string linkRegisterAccountXpath = "//a[text()='Register for an online account']";
        string linkAddanItemXpath = "//a[text()='Add an item to my policy']";
        string titleMakeaPaymentXpath = "//h4[text()='Make a Payment']";
        string infoMakeaPaymentXpath = "//p[text()='Pay your bill online quickly and easily – anytime, anywhere.']";
        string linkPayMyBillXpath = "//a[text()='Pay my bill']";
        string iconStartaClaimXpath = "//img[@alt='document icon']";
        string titleStartaClaimXpath = "//h4[text()='Start a Claim']";
        string infoStartaClaimXpath = "//p[contains(.,'Start a new claim online – or call our claims team at 888-884-2424, 7AM - 6PM CDT, Monday through Friday')]";
        string linkStartaClaimXpath = "//a[text()='Start a claim']";
        string linkLearnAboutClaimsXpath = "//a[text()='Learn about claims']";
        string headerExpertiseXpath = "//h2[contains(.,'Expertise Since 1913')]";
        string titleFoundedByJewelersXpath = "//h4[text()='Founded By Jewelers, For Jewelers']";
        string infoFoundedByJewelersXpath = "//p[contains(.,'Jewelers Mutual was founded by jewelers determined')]";
        string titleJewelersOwnJewelryXpath = "//h4[text()='Jewelers Own Jewelry, Too']";
        string infoJewelersOwnJewelryXpath = "//p[contains(.,'Those jewelers later realized another unmet')]";
        string titleEndorsedByAllXpath = "//h4[text()='Endorsed By All the Experts']";
        string infoEndorsedByAllXpath = "//p[contains(.,'Jewelers Mutual is the only jewelry insurer')]";
        string titleExpertsThenXpath = "//h4[text()='Experts Then, Experts Still']";
        string infoExpertsThenXpath = "//p[contains(.,'Just as the founders were jewelry experts, so is our staff today. We’re proud to')]";
        //string imgDarrylXpath = "//img[@alt='Darryl']";
        string quoteDarrylTestimonialXpath = "//p[contains(.,'Excellent company – reasonable rates,')]";
        string nameDarrylXpath = "//span[contains(.,'Darryl')]";
        string infoItAllComesXpath = "//p[contains(.,'You trust your home to your homeowners insurance. Trust your jewelry to the actu')]";
        string btnExplorePersonalJewelryInsuranceXpath = "//a[contains(.,'Explore Personal Jewelry Insurance')]";
        string linkmanagemyaccount_loginXpath = "//a[text()='Log in']";
        string linkmanagemyaccount_registerforanonlineaccountXpath = "//a[.='Register for an online account']";
        string linkmanagemyaccount_addanitemtomypolicyXpath = "//a[.='Add an item to my policy']";
        string linkmakeapayment_paymybillXpath = "//a[.='Pay my bill']";
        string linkstartaclaim_startaclaimXpath = "//a[.='Start a claim']";
        string linkcheckyourrate_getaquoteXpath = "//nav[@id='block-footerplmenu']//a[.='Get a Quote']";
        // Embedded Quote 
        //string titleEQFreeXpath = "//h2[.='Get a Free Quote']";
        //string infoEQInfo1Xpath = "//p[contains(.,'Rates depend on where you live. But for most people, jewelry insurance costs 1-2')]";
        //string infoEQInfo2Xpath = "//p[.='For example, a $10,000 ring costs about $100 per year to insure.']";
        //string step1EQJewelryTypeXpath = "//label[.='Jewelry Type']";
        //string step1EQReplacementValueXpath = "//label[.='Replacement Value']";
        //string step1EQPostalCodeXpath = "//label[.='Wearer\'s Zip/Postal Code']"; 
        //string step1EQMultipleItemsXpath = "//*[@id='step1']/form/div[3]/a";
        //string step1EQEstimateMyRateXpath = "//button[contains(.,'Estimate my rate')]";

        Home_D_V home_D_V = new Home_D_V();
        public Home_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public void verifyAllHomePageContent()
        {
            verifyNavBar();
            verifyFooter();
            //verifycheckYourRate();
            verifyPersonalPolicyCenter();
            //verifyCheckRate();
            //verifyEmbeddedQuote();
            verifyexpertiseSince1913();
            //verifyDarrylTestimonial();
            verifyItAllComesDownToTrust();
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(headerHonoringXpath);
            VerifyUIElementIsDisplayed(headerSinceXpath);
            VerifyUIElementIsDisplayed(btnExplorePJIXpath);
            //VerifyUIElementIsDisplayed(linkTellMeAboutXpath);
            VerifyUIElementIsDisplayed(headerPersonalPolicyCenterXpath);
            VerifyUIElementIsDisplayed(iconManageMyAccountXpath);
            VerifyUIElementIsDisplayed(titleManageMyAccountXpath);
            VerifyUIElementIsDisplayed(infoManageMyAccountXpath);
            VerifyUIElementIsDisplayed(linkLogInXpath);
            VerifyUIElementIsDisplayed(linkRegisterAccountXpath);
            VerifyUIElementIsDisplayed(linkAddanItemXpath);
            VerifyUIElementIsDisplayed(iconMakeaPaymentXpath);
            VerifyUIElementIsDisplayed(titleMakeaPaymentXpath);
            VerifyUIElementIsDisplayed(infoMakeaPaymentXpath);
            VerifyUIElementIsDisplayed(linkPayMyBillXpath);
            VerifyUIElementIsDisplayed(iconStartaClaimXpath);
            VerifyUIElementIsDisplayed(titleStartaClaimXpath);
            VerifyUIElementIsDisplayed(infoStartaClaimXpath);
            VerifyUIElementIsDisplayed(linkStartaClaimXpath);
            VerifyUIElementIsDisplayed(linkLearnAboutClaimsXpath);
            //VerifyUIElementIsDisplayed(iconCheckYourRateXpath);
            //VerifyUIElementIsDisplayed(titleCheckYourRateXpath);
            //VerifyUIElementIsDisplayed(infoCheckYourRate1Xpath);
            //VerifyUIElementIsDisplayed(infoCheckYourRate2Xpath);
            //VerifyUIElementIsDisplayed(infoCheckYourRate3Xpath);
            //VerifyUIElementIsDisplayed(linkRetriveYourApplicationXpath);
            //VerifyUIElementIsDisplayed(btnGetaQuoteXpath);
            //VerifyUIElementIsDisplayed(disclaimerCheckYourRateXpath);
            //VerifyUIElementIsDisplayed(titleEQFreeXpath);
            //VerifyUIElementIsDisplayed(infoEQInfo1Xpath);
            //VerifyUIElementIsDisplayed(infoEQInfo2Xpath);
            //VerifyUIElementIsDisplayed(step1EQJewelryTypeXpath);
            //VerifyUIElementIsDisplayed(step1EQReplacementValueXpath);
            //VerifyUIElementIsDisplayed(step1EQPostalCodeXpath);
            //VerifyUIElementIsDisplayed(step1EQMultipleItemsXpath);
            //VerifyUIElementIsDisplayed(step1EQEstimateMyRateXpath);
            VerifyUIElementIsDisplayed(headerExpertiseXpath);
            VerifyUIElementIsDisplayed(titleFoundedByJewelersXpath);
            VerifyUIElementIsDisplayed(infoFoundedByJewelersXpath);
            VerifyUIElementIsDisplayed(titleJewelersOwnJewelryXpath);
            VerifyUIElementIsDisplayed(infoJewelersOwnJewelryXpath);
            VerifyUIElementIsDisplayed(titleEndorsedByAllXpath);
            VerifyUIElementIsDisplayed(infoEndorsedByAllXpath);
            VerifyUIElementIsDisplayed(titleExpertsThenXpath);
            VerifyUIElementIsDisplayed(infoExpertsThenXpath);
            //VerifyUIElementIsDisplayed(imgDarrylXpath);
            //VerifyUIElementIsDisplayed(quoteDarrylTestimonialXpath);
            //VerifyUIElementIsDisplayed(nameDarrylXpath);
            VerifyUIElementIsDisplayed(titleItAllComesXpath);
            VerifyUIElementIsDisplayed(infoItAllComesXpath);
            VerifyUIElementIsDisplayed(btnExplorePersonalJewelryInsuranceXpath);
            VerifyUIElementIsDisplayed(linkmanagemyaccount_loginXpath);
            VerifyUIElementIsDisplayed(linkmanagemyaccount_registerforanonlineaccountXpath);
            VerifyUIElementIsDisplayed(linkmanagemyaccount_addanitemtomypolicyXpath);
            VerifyUIElementIsDisplayed(linkmakeapayment_paymybillXpath);
            VerifyUIElementIsDisplayed(linkstartaclaim_startaclaimXpath);
            VerifyUIElementIsDisplayed(linkcheckyourrate_getaquoteXpath);

        }

        public void selectLinkToNavigate(string linkToNavigate)
        {
            switch (linkToNavigate.ToLower().Trim())
            {

            //PERSONAL GROUP
                case "personal:personal insurance":
                    JavaScriptClick(driver.FindElement(By.XPath(navPersonalInsuranceXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "personal:get a quote":
                    JavaScriptClick(driver.FindElement(By.XPath(navGetAQuoteXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "personal:pay my bill":
                    JavaScriptClick(driver.FindElement(By.XPath(navPLPayMyBillXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "personal:claims":
                    JavaScriptClick(driver.FindElement(By.XPath(navClaimsXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "personal:manage my policy":
                    JavaScriptClick(driver.FindElement(By.XPath(navManageMyPolicyXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "personal:blog":
                    JavaScriptClick(driver.FindElement(By.XPath(navPLBlogXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

            // BUSSINESS 

                case "business:business insurance":
                    JavaScriptClick(driver.FindElement(By.XPath(navJewelryBusinessXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "business:claims":
                    JavaScriptClick(driver.FindElement(By.XPath(navbarclaimsbussiness)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "business:pay my bill":
                    JavaScriptClick(driver.FindElement(By.XPath(navCLPayMyBillXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "business:zing platform":
                    JavaScriptClick(driver.FindElement(By.XPath(navZingPlatform)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "business:shipping solution":
                    JavaScriptClick(driver.FindElement(By.XPath(navShippingXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "business:jm care plan":
                    JavaScriptClick(driver.FindElement(By.XPath(navCarePlanXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "business:jeweler programs":
                    JavaScriptClick(driver.FindElement(By.XPath(navJewelerProgramsXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "business:pawnbrokers":
                    JavaScriptClick(driver.FindElement(By.XPath(navPawnbrokersXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                // ANSWERS GROUP

                case "answers:jewelry insurance 101":
                    JavaScriptClick(driver.FindElement(By.XPath(navJewelryInsurance101Xpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;
         
                case "answers:faq":
                    JavaScriptClick(driver.FindElement(By.XPath(navFAQXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;


                // ABOUT US
                case "about us:newsroom":
                    JavaScriptClick(driver.FindElement(By.XPath(navNewsroomXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "about us:about us":
                    JavaScriptClick(driver.FindElement(By.XPath(navAboutUsXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "about us:social responsibility":
                    JavaScriptClick(driver.FindElement(By.XPath(navSocialResponsibilityXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "about us:careers":
                    JavaScriptClick(driver.FindElement(By.XPath(navCareersXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

  
                // LOG IN 
                case "login:personal jewelry":
                    JavaScriptClick(driver.FindElement(By.XPath(navPersonalJewelryLoginXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "login:agent":
                    JavaScriptClick(driver.FindElement(By.XPath(navAgentLoginXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "login:zing platform":
                    JavaScriptClick(driver.FindElement(By.XPath(navZingLoginXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;


                //FOOTER
                case "contact":
                    JavaScriptClick(driver.FindElement(By.XPath(ftContactXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "privacy policy":
                    JavaScriptClick(driver.FindElement(By.XPath(ftPrivacyPolicyXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "terms of use":
                    JavaScriptClick(driver.FindElement(By.XPath(ftTermsofUseXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "share your concerns":
                    JavaScriptClick(driver.FindElement(By.XPath(ftShareYourConcernsXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "careers":
                    JavaScriptClick(driver.FindElement(By.XPath(ftCareersXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "newsroom":
                    JavaScriptClick(driver.FindElement(By.XPath(ftNewsroomXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "explore personal jewelry insurance":
                    JavaScriptClick(driver.FindElement(By.XPath(btnExplorePJIXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "tell me about jewelry business insurance":
                    JavaScriptClick(driver.FindElement(By.XPath(linkTellMeAboutXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "log in":
                    JavaScriptClick(driver.FindElement(By.XPath(linkLogInXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "register for an online account":
                    JavaScriptClick(driver.FindElement(By.XPath(linkRegisterAccountXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "add an item to my policy":
                    JavaScriptClick(driver.FindElement(By.XPath(linkAddanItemXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;


                case "pay my bill":
                    JavaScriptClick(driver.FindElement(By.XPath(linkPayMyBillXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "start a claim":
                    JavaScriptClick(driver.FindElement(By.XPath(linkStartaClaimXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "learn about claims":
                    JavaScriptClick(driver.FindElement(By.XPath(linkLearnAboutClaimsXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;


                case "trust:explore personal jewelry insurance":
                    JavaScriptClick(driver.FindElement(By.XPath(btnExplorePersonalJewelryInsuranceXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;



                case "managemyaccount:login":
                    JavaScriptClick(driver.FindElement(By.XPath(linkmanagemyaccount_loginXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;


                case "managemyaccount:registerforanonlineaccount":
                    JavaScriptClick(driver.FindElement(By.XPath(linkmanagemyaccount_registerforanonlineaccountXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "managemyaccount:addanitemtomypolicy":
                    JavaScriptClick(driver.FindElement(By.XPath(linkmanagemyaccount_addanitemtomypolicyXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "makeapayment:paymybill":
                    JavaScriptClick(driver.FindElement(By.XPath(linkmakeapayment_paymybillXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;


                case "startaclaim:startaclaim":
                    JavaScriptClick(driver.FindElement(By.XPath(linkstartaclaim_startaclaimXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;

                case "checkyourrate:getaquote":
                    JavaScriptClick(driver.FindElement(By.XPath(linkcheckyourrate_getaquoteXpath)));
                    WaitForPageLoad(driver);
                    Console.WriteLine("page clicked");
                    break;


                default:
                    break;
            }

        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
            //VerifyUIElementIsDisplayed(jmLogoCSS);
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

        public void verifycheckYourRate()
        {
            //Home Page Header
            string HeaderHonoring = driver.FindElement(By.XPath(headerHonoringXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderHonoring.ToLower().Trim(), home_D_V.txtHeaderHonoring.ToLower().Trim(), "The Text doesn't match");

            string HeaderSince = driver.FindElement(By.XPath(headerSinceXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderSince.ToLower().Trim(), home_D_V.txtHeaderSince.ToLower().Trim(), "The Text doesn't match");

            string BtnExplorePJI = driver.FindElement(By.XPath(btnExplorePJIXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnExplorePJI.ToLower().Trim(), home_D_V.btnExplorePJI.ToLower().Trim(), "The Text doesn't match");

            //string LinkTellMeAbout = driver.FindElement(By.XPath(linkTellMeAboutXpath)).GetAttribute("innerText");
            //Assert.AreEqual(LinkTellMeAbout.ToLower().Trim(), home_D_V.hrefTellMeAbout.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyPersonalPolicyCenter()
        {
            //Personal Policy Center
            string HeaderPersonalPolicyCenter = driver.FindElement(By.XPath(headerPersonalPolicyCenterXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderPersonalPolicyCenter.ToLower().Trim(), home_D_V.txtPersonalPolicyCenterTitle.ToLower().Trim(), "The Text doesn't match");

            string TitleManageMyAccount = driver.FindElement(By.XPath(titleManageMyAccountXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleManageMyAccount.ToLower().Trim(), home_D_V.txtManageMyAccount.ToLower().Trim(), "The Text doesn't match");

            string InfoManageMyAccount = driver.FindElement(By.XPath(infoManageMyAccountXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoManageMyAccount.ToLower().Trim(), home_D_V.txtManageMyAccountInfo.ToLower().Trim(), "The Text doesn't match");

            string LinkLogIn = driver.FindElement(By.XPath(linkLogInXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkLogIn.ToLower().Trim(), home_D_V.hrefPPCLogIn.ToLower().Trim(), "The Text doesn't match");

            string LinkRegisterAccount = driver.FindElement(By.XPath(linkRegisterAccountXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkRegisterAccount.ToLower().Trim(), home_D_V.hrefRegisterAccount.ToLower().Trim(), "The Text doesn't match");

            string LinkAddanItem = driver.FindElement(By.XPath(linkAddanItemXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkAddanItem.ToLower().Trim(), home_D_V.hrefAddanItem.ToLower().Trim(), "The Text doesn't match");

            string TitleMakeaPayment = driver.FindElement(By.XPath(titleMakeaPaymentXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleMakeaPayment.ToLower().Trim(), home_D_V.txtMakeaPayment.ToLower().Trim(), "The Text doesn't match");

            string InfoMakeaPayment = driver.FindElement(By.XPath(infoMakeaPaymentXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoMakeaPayment.ToLower().Trim(), home_D_V.txtMakeaPaymentInfo.ToLower().Trim(), "The Text doesn't match");

            string LinkPayMyBill = driver.FindElement(By.XPath(linkPayMyBillXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkPayMyBill.ToLower().Trim(), home_D_V.hrefPayMyBill.ToLower().Trim(), "The Text doesn't match");

            string TitleStartaClaim = driver.FindElement(By.XPath(titleStartaClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleStartaClaim.ToLower().Trim(), home_D_V.txtStartaClaim.ToLower().Trim(), "The Text doesn't match");

            string InfoStartaClaim = driver.FindElement(By.XPath(infoStartaClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoStartaClaim.ToLower().Trim(), home_D_V.txtStartaClaimInfo.ToLower().Trim(), "The Text doesn't match");

            string LinkStartaClaim = driver.FindElement(By.XPath(linkStartaClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkStartaClaim.ToLower().Trim(), home_D_V.hrefStartaclaim.ToLower().Trim(), "The Text doesn't match");

            string LinkLearnAboutClaims = driver.FindElement(By.XPath(linkLearnAboutClaimsXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkLearnAboutClaims.ToLower().Trim(), home_D_V.hrefLearnAboutClaims.ToLower().Trim(), "The Text doesn't match");
        }

        //public void verifyCheckRate()
        //{

        //    //Check Your Rate
        //    string TitleCheckYourRate = driver.FindElement(By.XPath(titleCheckYourRateXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(TitleCheckYourRate.ToLower().Trim(), home_D_V.txtCheckYourRate.ToLower().Trim(), "The Text doesn't match");

        //    string InfoCheckYourRate1 = driver.FindElement(By.XPath(infoCheckYourRate1Xpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoCheckYourRate1.ToLower().Trim(), home_D_V.txtCheckYourRate1.ToLower().Trim(), "The Text doesn't match");

        //    string InfoCheckYourRate2 = driver.FindElement(By.XPath(infoCheckYourRate2Xpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoCheckYourRate2.ToLower().Trim(), home_D_V.txtCheckYourRate2.ToLower().Trim(), "The Text doesn't match");

        //    string InfoCheckYourRate3 = driver.FindElement(By.XPath(infoCheckYourRate3Xpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoCheckYourRate3.ToLower().Trim(), home_D_V.txtCheckYourRate3.ToLower().Trim(), "The Text doesn't match");

        //    string LinkRetriveYourApplication = driver.FindElement(By.XPath(linkRetriveYourApplicationXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(LinkRetriveYourApplication.ToLower().Trim(), home_D_V.hrefRetrieveSavedQuote.ToLower().Trim(), "The Text doesn't match");

        //    string BtnGetaQuote = driver.FindElement(By.XPath(btnGetaQuoteXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(BtnGetaQuote.ToLower().Trim(), home_D_V.btnGetaQuote.ToLower().Trim(), "The Text doesn't match");

        //    string DisclaimerCheckYourRate = driver.FindElement(By.XPath(disclaimerCheckYourRateXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(DisclaimerCheckYourRate.ToLower().Trim(), home_D_V.txtDisclaimerCheckYourRate.ToLower().Trim(), "The Text doesn't match");
        //}

        //public void verifyEmbeddedQuote()
        //{
        //    // Embedded Quote

        //    string TitleEQFree = driver.FindElement(By.XPath(titleEQFreeXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(TitleEQFree.ToLower().Trim(), home_D_V.txtTitleEQFree.ToLower().Trim(), "The Text doesn't match");

        //    string InfoEQInfo1 = driver.FindElement(By.XPath(infoEQInfo1Xpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoEQInfo1.ToLower().Trim(), home_D_V.txtEQInfo1.ToLower().Trim(), "The Text doesn't match");

        //    string InfoEQInfo2 = driver.FindElement(By.XPath(infoEQInfo2Xpath)).GetAttribute("innerText");
        //    Assert.AreEqual(InfoEQInfo2.ToLower().Trim(), home_D_V.txtEQInfo2.ToLower().Trim(), "The Text doesn't match");

        //    string Step1EQJewelryType = driver.FindElement(By.XPath(step1EQJewelryTypeXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(Step1EQJewelryType.ToLower().Trim(), home_D_V.txtJewelryType.ToLower().Trim(), "The Text doesn't match");

        //    string step1EQReplacementValue = driver.FindElement(By.XPath(step1EQReplacementValueXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(step1EQReplacementValue.ToLower().Trim(), home_D_V.txtReplacementValue.ToLower().Trim(), "The Text doesn't match");

        //    string Step1EQPostalCode = driver.FindElement(By.XPath(step1EQPostalCodeXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(Step1EQPostalCode.ToLower().Trim(), home_D_V.txtPostalCode.ToLower().Trim(), "The Text doesn't match");

        //    string Step1EQMultipleItems = driver.FindElement(By.XPath(step1EQMultipleItemsXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(Step1EQMultipleItems.ToLower().Trim(), home_D_V.txtMultipleItems.ToLower().Trim(), "The Text doesn't match");

        //    string Step1EQEstimateMyRate = driver.FindElement(By.XPath(step1EQEstimateMyRateXpath)).GetAttribute("innerText");
        //    Assert.AreEqual(Step1EQEstimateMyRate.ToLower().Trim(), home_D_V.txtEstimateMyRate.ToLower().Trim(), "The Text doesn't match");
        //}

        public void verifyexpertiseSince1913()
        {
            //Expertise Since 1913
            string HeaderExpertise = driver.FindElement(By.XPath(headerExpertiseXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderExpertise.ToLower().Trim(), home_D_V.txtExpertiseSince1913.ToLower().Trim(), "The Text doesn't match");

            string TitleFoundedByJewelers = driver.FindElement(By.XPath(titleFoundedByJewelersXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleFoundedByJewelers.ToLower().Trim(), home_D_V.txtFoundedByJewelers.ToLower().Trim(), "The Text doesn't match");

            string InfoFoundedByJewelers = driver.FindElement(By.XPath(infoFoundedByJewelersXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoFoundedByJewelers.ToLower().Trim(), home_D_V.txtFoundedbyJewelersInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleJewelersOwnJewelry = driver.FindElement(By.XPath(titleJewelersOwnJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJewelersOwnJewelry.ToLower().Trim(), home_D_V.txtJewelersOwnJewelry.ToLower().Trim(), "The Text doesn't match");

            string InfoJewelersOwnJewelry = driver.FindElement(By.XPath(infoJewelersOwnJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJewelersOwnJewelry.ToLower().Trim(), home_D_V.txtJewelersOwnJewelryInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleEndorsedByAll = driver.FindElement(By.XPath(titleEndorsedByAllXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleEndorsedByAll.ToLower().Trim(), home_D_V.txtEndorsedByAll.ToLower().Trim(), "The Text doesn't match");

            string InfoEndorsedByAll = driver.FindElement(By.XPath(infoEndorsedByAllXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoEndorsedByAll.ToLower().Trim(), home_D_V.txtEndorsedByAllInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleExpertsThen = driver.FindElement(By.XPath(titleExpertsThenXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleExpertsThen.ToLower().Trim(), home_D_V.txtExpertsThen.ToLower().Trim(), "The Text doesn't match");

            string InfoExpertsThen = driver.FindElement(By.XPath(infoExpertsThenXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoExpertsThen.ToLower().Trim(), home_D_V.txtExpertsThenInfo.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyDarrylTestimonial()
        {
            //Quote
            string DarrylTestimonal = driver.FindElement(By.XPath(quoteDarrylTestimonialXpath)).GetAttribute("innerText");
            Assert.AreEqual(DarrylTestimonal.ToLower().Trim(), home_D_V.txtDarrylTestomonial.ToLower().Trim(), "The Text doesn't match");

            //Name
            string DarrylName = driver.FindElement(By.XPath(nameDarrylXpath)).GetAttribute("innerText");
            Assert.AreEqual(DarrylName.ToLower().Trim(), home_D_V.txtDarrylName.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyItAllComesDownToTrust()
        {
            //Title
            string TitleItAllComes = driver.FindElement(By.XPath(titleItAllComesXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleItAllComes.ToLower().Trim(), home_D_V.txtItAllComesDowntoTrustTitle.ToLower().Trim(), "The Text doesn't match");

            //Info
            string InfoItAllComes = driver.FindElement(By.XPath(infoItAllComesXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoItAllComes.ToLower().Trim(), home_D_V.txtItAllComesDowntoTrustInfo.ToLower().Trim(), "The Text doesn't match");

            //Button
            string ExplorePersonalJewelryInsurance = driver.FindElement(By.XPath(btnExplorePersonalJewelryInsuranceXpath)).GetAttribute("innerText");
            Assert.AreEqual(ExplorePersonalJewelryInsurance.ToLower().Trim(), home_D_V.btnExplorePersonalJewelryInsurance.ToLower().Trim(), "The Text doesn't match");
        }
    }
}

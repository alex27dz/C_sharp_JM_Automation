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
    public class AboutUs_D : Page
    {
        // Elements  

        // logo
        string jmLogoCSS = "a[title='Home']";

        // About US Header
        string headerAboutUSXpath = "//h4[.='ABOUT US']";
        string titleAboutUsXpath = "//h1[.='Honoring and protecting jewelry since 1913.']";
        string headerSuperiorRatingXpath = "//h2[.='A+ Superior Rating from A.M. Best']";
        string infoSuperiorRatingXpath = "//p[contains(.,'Jewelers Mutual Insurance Company has earned its 33rd consecutive')]";

        // We Have Jewelry in Our Name
        string headerJewelryInOurNameXpath = "//h2[contains(.,'We Have Jewelry in Our Name')]";
        string infoJeweleryInOurName1Xpath = "//p[contains(text(),'Since our inception in 1913, we’ve been strengthening the jewelry industry')]";
        string infoJeweleryInOurName2Xpath = "//strong[text()='Watch the video to learn how Jewelers Mutual has continued to honor and protect jewelry for over 100 years.']";
        string videoJewelersXpath = "//img[contains(@alt,'Jewelers Mutual About Us Video')]";

        // Partnerships
        string headerPartnershipsXpath = "//h2[.='Partnerships']";
        string infoPArtnershipsXpath = "//p[contains(.,'We’re proud to be endorsed by our partner organizations')]";
        string titleAGSXpath = "//h4[.='American Gem Society']";
        string infoAGEXpath = "//p[contains(.,'Focused on setting and maintaining the highest possible standards')]";
        string titleJoAXpath = "//h4[.='Jewelers of America']";
        string infoJoAXpath = "//p[contains(.,'Advocates professionalism and adherence to high ethical, social')]";
        string titleJSAXpath = "//h4[.=\"Jewelers' Security Alliance\"]";
        string infoJSAXpath = "//p[contains(.,'Provides crime information and assistance to the jewelry industry')]";
        string titleCJAXpath = "//h4[.='Canadian Jewellers Association']";
        string infoCJAXpath = "//p[contains(.,'Serves as the voice of the Canadian jewelry industry, providing leadership')]";
        string titleCJGXpath = "//h4[.='Canadian Jewellers Group']";
        string infoCJGXpath = "//p[contains(.,'Negotiates terms and conditions with suppliers and then passes 100% of the')]";
        string titleJVCXpath = "//h4[.='Jewellers Vigilance Canada']";
        string infoJVCXpath = "//p[contains(.,'Strives to fulfill its mandate to advance ethical practices, establish')]";
        string titleMJSAXpath = "//h4[.='Manufacturing Jewelers and Suppliers of America']";
        string infoMJSAXpath = "//p[contains(.,'Provides the resources needed by manufacturers, jewelers, suppliers, and artisan')]";

        //Giving back to the community
        string iconGivingXpath = "//img[@alt='shaking hands graphic']";
        string titleGivingXpath = "//h2[contains(.,'Giving Back Brilliantly Since 1913')]";
        string infoGiving1Xpath = "//p[contains(.,'Jewelers Mutual has an extensive history of supporting the jewelry industry and, just as importantly, the communities in which our policyholders and employees call home.')]";
        string infoGiving2Xpath = "//p[contains(.,'From scholarships that help promote the jewelry trade to future generations to our Band Together national charitable giveback campaign powered by our policyholders, Jewelers Mutual takes pride in being a responsible corporate citizen.')]";
        string btnLearnHowXpath = "//a[contains(.,'LEARN HOW WE GIVE BACK')]";

        // Leadership
        string headerLeadershipXpath = "//h2[.='Leadership']";
        string titleExecutiveXpath = "//h3[.='Executive Officers']";
        string titleScottXpath = "//div[@class='layout__region layout__region--content']//div[1]/h4[.='Scott Murphy']";
        string infoScottXpath = "//p[.='President and CEO']";
        string titleMikeAlexXpath = "//h4[.='Mike Alexander']";
        string infoMikeAlexXpath = "//div[@class='layout__region layout__region--content']//div[@class='info-grid row content-lg grid-layout-three text-align-left']/div[2]//p[.='Executive Vice President']";
        string titleAngelaXpath = "//h4[.='Angela Creel']";
        string infoAngelaXpath = "//p[.='Chief Human Resources Officer']";
        string titleJamieXpath = "//h4[.='Jamie Luce']";
        string infoJamieXpath = "//div[@class='layout__region layout__region--content']//div[4]//p[.='Executive Vice President']";
        string titleBryonXpath = "//h4[.='Bryon Nelson']";
        string infoBryonXpath = "//p[.='Vice President, Product and Risk Management']";
        string titleMikePeltoXpath = "//h4[.='Mike Pelto']";
        string infoMikePeltoXpath = "//p[.='Senior Vice President, Chief Technology Officer']";
        string titleMarkXpath = "//h4[.='Mark Willson']";
        string infoMarkXpath = "//p[.='Vice President, General Counsel']";

        // Business Leaders
        string headerBusinessLeadersXpath = "//h3[.='Business Leaders']";
        string titleJeffBXpath = "//h4[.='Jeff Baker']";
        string infoJeffBXpath = "//p[.='JM Insurance Services--Agency']";
        string titleJayDXpath = "//h4[.='Jay Davidson']";
        string infoJayDXpath = "//p[.='Information Technology']";
        string titleMarkDXpath = "//h4[.='Mark Devereaux']";
        string infoMarkDXpath = "//p[.='Sales and Strategic Partnerships']";
        string titleJohnFXpath = "//h4[.='John Fierst']";
        string infoJohnFXpath = "//p[.='Commercial Lines']";
        string titleDavidMXpath = "//h4[.='David McDonald']";
        string infoDavidMSS = "//p[.='Retail Jeweler Programs and JM Care Plan']";
        string titleKenMXpath = "//h4[.='Ken Murray']";
        string infoKenMXpath = "//p[.='Digital and Marketing']";
        string titleTinaOXpath = "//h4[.='Tina Olm']";
        string infoTinaOXpath = "//p[.='Shipping/Logistics']";
        string titleDylanPXpath = "//h4[.='Dylan Place']";
        string infoDylanPXpath = "//p[.='Actuarial Services']";

        // Our Board of Directors
        string headerDirectorsXpath = "//h3[.='Our Board of Directors']";
        string titleAlexBXpath = "//h4[.='Alex Barcados']";
        //string infoAlexBXpath = "//p[.='Vice Chair of the Governance Committee']";
        string titleJonathanBXpath = "//h4[.='Jonathan Bridge']";
        //string infoJonathanBXpath = "//p[.='Chair of the Investment Committee']";
        string titleMarkFDXpath = "//h4[.='Mark Fiebrink']";
        string infoMarkFXpath = "//p[.='Chair of the Board']";
        string titleDioneKXpath = "//h4[.='Dione Kenyon']";
        //string infoDioneKXpath = "//p[.='Chair of the Audit Committee']";
        string titleDavidLXpath = "//h4[.='David Lundgren']";
        //string infoDavidLXpath = "//p[.='Chair of the Compensation Committee']";
        string titleSherryMXpath = "//h4[.='Sherry Manetta']";
        //string infoSherryMXpath = "//p[.='Vice Chair of the Investment Committee']";
        string titleMarianneMXpath = "//h4[.='Marianne Marck']";
        //string infoMarianneMXpath = "//p[.='Vice Chair of the Compensation Committee']";
        string titleScottMurphyXpath = "//h4[.='Scott Murphy']";
        string infoScottyMurphyOXpath = "//p[.='President & CEO of Jewelers Mutual']";
        string titleRobertRXpath = "//h4[.='Robert Reeg']";
        //string infoRobertRXpath = "//p[.='Vice Chair of the Audit Committee']";
        string titleKurtSXpath = "//h4[.='Kurt Steckbeck']";
        string infoKurtSXpath = "//p[.='Vice Chair of the Board']";
        string titleCraigUXpath = "//h4[.='Craig Underwood']";
        //string infoCraigUXpath = "//p[.='Vice Chair of the Compensation Committee']";

        // A Little More About Us
        string headerALittleMoreXpath = "//h2[.='A Little More About Us']";

        string titleWhatsInANameXpath = "//h3[.=\"What's in a name\"]";
        string infoWhatsInANameXpath = "//p[contains(.,'The name Jewelers Mutual came about when 115 members of the Wisconsin Retail Jew')]";
        string btnViewOurAnnualXpath = "//a[.='VIEW OUR ANNUAL REPORT']";
        string iconStoreXpath = "//img[@alt='storefront illustration']";
        string iconJewelryXpath = "//img[@alt=\"jeweler's workstation illustration\"]";
        string titleWeLoveJewelryXpath = "//h3[.='We love jewelry.']";
        string infoWeLoveJewelryXpath = "//p[contains(.,'We insure what we love and, for us, our passion and specialty is jewelry')]";
        string btnScheduleXpath = "//a[.='SCHEDULE A VISIT']";
        string titleWorkWithUsXpath = "//h3[.='Love jewelry, too? Work with us.']";
        string infoWorkWithUsXpath = "//p[contains(.,'Jewelers Mutual was founded on relationships and driven by passion. We’re proud')]";
        string btnWorkWithUsXpath = "//a[.='WORK WITH US']";
        string iconGroupXpath = "//img[@alt='illustration of people']";

        AboutUs_D_V aboutUs_D_V = new AboutUs_D_V();
        public AboutUs_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);

        }

        public void verifyAllAboutUsPageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyAboutUs();
            verifyCustomerStories();
            verfiyGivingBack();
            verifyLeadership();
            verifyAddOns();
            verifyBOD();
            verifyLittleMore();
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(headerAboutUSXpath);
            VerifyUIElementIsDisplayed(titleAboutUsXpath);
            VerifyUIElementIsDisplayed(headerSuperiorRatingXpath);
            VerifyUIElementIsDisplayed(infoSuperiorRatingXpath);
            VerifyUIElementIsDisplayed(headerJewelryInOurNameXpath);
            VerifyUIElementIsDisplayed(infoJeweleryInOurName1Xpath);
            VerifyUIElementIsDisplayed(infoJeweleryInOurName2Xpath);
            VerifyUIElementIsDisplayed(videoJewelersXpath);
            VerifyUIElementIsDisplayed(headerPartnershipsXpath);
            VerifyUIElementIsDisplayed(infoPArtnershipsXpath);
            VerifyUIElementIsDisplayed(titleAGSXpath);
            VerifyUIElementIsDisplayed(infoAGEXpath);
            VerifyUIElementIsDisplayed(titleJoAXpath);
            VerifyUIElementIsDisplayed(infoJoAXpath);
            VerifyUIElementIsDisplayed(titleJSAXpath);
            VerifyUIElementIsDisplayed(infoJSAXpath);
            VerifyUIElementIsDisplayed(titleCJAXpath);
            VerifyUIElementIsDisplayed(infoCJAXpath);
            VerifyUIElementIsDisplayed(titleCJGXpath);
            VerifyUIElementIsDisplayed(infoCJGXpath);
            VerifyUIElementIsDisplayed(titleJVCXpath);
            VerifyUIElementIsDisplayed(infoJVCXpath);
            VerifyUIElementIsDisplayed(titleMJSAXpath);
            VerifyUIElementIsDisplayed(infoMJSAXpath);
            VerifyUIElementIsDisplayed(iconGivingXpath);
            VerifyUIElementIsDisplayed(titleGivingXpath);
            VerifyUIElementIsDisplayed(infoGiving1Xpath);
            VerifyUIElementIsDisplayed(infoGiving2Xpath);
            VerifyUIElementIsDisplayed(btnLearnHowXpath);
            VerifyUIElementIsDisplayed(headerLeadershipXpath);
            VerifyUIElementIsDisplayed(titleExecutiveXpath);
            VerifyUIElementIsDisplayed(titleScottXpath);
            VerifyUIElementIsDisplayed(infoScottXpath);
            VerifyUIElementIsDisplayed(titleMikeAlexXpath);
            VerifyUIElementIsDisplayed(infoMikeAlexXpath);
            VerifyUIElementIsDisplayed(titleAngelaXpath);
            VerifyUIElementIsDisplayed(infoAngelaXpath);
            VerifyUIElementIsDisplayed(titleJamieXpath);
            VerifyUIElementIsDisplayed(infoJamieXpath);
            VerifyUIElementIsDisplayed(titleBryonXpath);
            VerifyUIElementIsDisplayed(infoBryonXpath);
            VerifyUIElementIsDisplayed(titleMikePeltoXpath);
            VerifyUIElementIsDisplayed(infoMikePeltoXpath);
            VerifyUIElementIsDisplayed(titleMarkXpath);
            VerifyUIElementIsDisplayed(infoMarkXpath);
            VerifyUIElementIsDisplayed(headerBusinessLeadersXpath);
            VerifyUIElementIsDisplayed(titleJeffBXpath);
            VerifyUIElementIsDisplayed(infoJeffBXpath);
            VerifyUIElementIsDisplayed(titleJayDXpath);
            VerifyUIElementIsDisplayed(infoJayDXpath);
            VerifyUIElementIsDisplayed(titleMarkDXpath);
            VerifyUIElementIsDisplayed(infoMarkDXpath);
            VerifyUIElementIsDisplayed(titleJohnFXpath);
            VerifyUIElementIsDisplayed(infoJohnFXpath);
            VerifyUIElementIsDisplayed(titleDavidMXpath);
            VerifyUIElementIsDisplayed(infoDavidMSS);
            VerifyUIElementIsDisplayed(titleKenMXpath);
            VerifyUIElementIsDisplayed(infoKenMXpath);
            VerifyUIElementIsDisplayed(titleTinaOXpath);
            VerifyUIElementIsDisplayed(infoTinaOXpath);
            VerifyUIElementIsDisplayed(titleDylanPXpath);
            VerifyUIElementIsDisplayed(infoDylanPXpath);
            VerifyUIElementIsDisplayed(headerDirectorsXpath);
            VerifyUIElementIsDisplayed(titleAlexBXpath);
            //VerifyUIElementIsDisplayed(infoAlexBXpath);
            VerifyUIElementIsDisplayed(titleJonathanBXpath);
            //VerifyUIElementIsDisplayed(infoJonathanBXpath);
            VerifyUIElementIsDisplayed(titleMarkFDXpath);
            VerifyUIElementIsDisplayed(infoMarkFXpath);
            VerifyUIElementIsDisplayed(titleDioneKXpath);
            //VerifyUIElementIsDisplayed(infoDioneKXpath);
            VerifyUIElementIsDisplayed(titleDavidLXpath);
            //VerifyUIElementIsDisplayed(infoDavidLXpath);
            VerifyUIElementIsDisplayed(titleSherryMXpath);
            //VerifyUIElementIsDisplayed(infoSherryMXpath);
            VerifyUIElementIsDisplayed(titleMarianneMXpath);
            //VerifyUIElementIsDisplayed(infoMarianneMXpath);
            VerifyUIElementIsDisplayed(titleScottMurphyXpath);
            VerifyUIElementIsDisplayed(infoScottyMurphyOXpath);
            VerifyUIElementIsDisplayed(titleRobertRXpath);
            //VerifyUIElementIsDisplayed(infoRobertRXpath);
            VerifyUIElementIsDisplayed(titleKurtSXpath);
            VerifyUIElementIsDisplayed(infoKurtSXpath);
            VerifyUIElementIsDisplayed(titleCraigUXpath);
            //VerifyUIElementIsDisplayed(infoCraigUXpath);
            VerifyUIElementIsDisplayed(headerALittleMoreXpath);
            VerifyUIElementIsDisplayed(titleWhatsInANameXpath);
            VerifyUIElementIsDisplayed(infoWhatsInANameXpath);
            VerifyUIElementIsDisplayed(btnViewOurAnnualXpath);
            VerifyUIElementIsDisplayed(iconStoreXpath);
            VerifyUIElementIsDisplayed(iconJewelryXpath);
            VerifyUIElementIsDisplayed(titleWeLoveJewelryXpath);
            VerifyUIElementIsDisplayed(infoWeLoveJewelryXpath);
            VerifyUIElementIsDisplayed(btnScheduleXpath);
            VerifyUIElementIsDisplayed(titleWorkWithUsXpath);
            VerifyUIElementIsDisplayed(infoWorkWithUsXpath);
            VerifyUIElementIsDisplayed(btnWorkWithUsXpath);
            VerifyUIElementIsDisplayed(iconGroupXpath);

        }

        public void selectLinkToNavigate(string linkToNavigate)
        {
            switch (linkToNavigate.ToLower().Trim())
            {

                case "btn: see if your organization is eligible":
                    driver.FindElement(By.XPath(btnLearnHowXpath)).Click();
                    WaitForPageLoad(driver);
                    break;

                case "btn: view our annaul report":
                    driver.FindElement(By.XPath(btnViewOurAnnualXpath)).Click();
                    WaitForPageLoad(driver);
                    break;
                case "btn: work with us":
                    driver.FindElement(By.XPath(btnWorkWithUsXpath)).Click();
                    WaitForPageLoad(driver);
                    break;

                default:
                    break;
            }

        }
        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
            VerifyUIElementIsDisplayed(jmLogoCSS);
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

        public void verifyAboutUs()
        {
            // About Us Header
            string HeaderAboutUS = driver.FindElement(By.XPath(headerAboutUSXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderAboutUS.ToLower().Trim(), aboutUs_D_V.txtHeaderAboutUS.ToLower().Trim(), "The Text doesn't match");

            string TitleAboutUs = driver.FindElement(By.XPath(titleAboutUsXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleAboutUs.ToLower().Trim(), aboutUs_D_V.txtTitleAboutUs.ToLower().Trim(), "The Text doesn't match");

            string HeaderSuperiorRating = driver.FindElement(By.XPath(headerSuperiorRatingXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderSuperiorRating.ToLower().Trim(), aboutUs_D_V.txtHeaderSuperiorRating.ToLower().Trim(), "The Text doesn't match");

            string InfoSuperiorRating = driver.FindElement(By.XPath(infoSuperiorRatingXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoSuperiorRating.ToLower().Trim(), aboutUs_D_V.txtInfoSuperiorRating.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyJewelryOurName()
        {
            // We Have Jewelry in Our Name
            string HeaderJewelryInOurName = driver.FindElement(By.XPath(headerJewelryInOurNameXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderJewelryInOurName.ToLower().Trim(), aboutUs_D_V.txtHeaderJewelryInOurName.ToLower().Trim(), "The Text doesn't match");

            string InfoJeweleryInOurName1 = driver.FindElement(By.XPath(infoJeweleryInOurName1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJeweleryInOurName1.ToLower().Trim(), aboutUs_D_V.txtInfoJeweleryInOurName1.ToLower().Trim(), "The Text doesn't match");

            string InfoJeweleryInOurName2 = driver.FindElement(By.XPath(infoJeweleryInOurName2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJeweleryInOurName2.ToLower().Trim(), aboutUs_D_V.txtInfoJeweleryInOurName2.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyCustomerStories()
        {
            // Partnerships
            string HeaderPartnerships = driver.FindElement(By.XPath(headerPartnershipsXpath)).GetAttribute("innerText");
            Console.Write("$$$$" + HeaderPartnerships.ToLower().Trim() + ":" + aboutUs_D_V.txtHeaderPartnerships.ToLower().Trim());
            Assert.AreEqual(HeaderPartnerships.ToLower().Trim(), aboutUs_D_V.txtHeaderPartnerships.ToLower().Trim(), "The Text doesn't match");

            string InfoPArtnerships = driver.FindElement(By.XPath(infoPArtnershipsXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoPArtnerships.ToLower().Trim(), aboutUs_D_V.txtInfoPArtnerships.ToLower().Trim(), "The Text doesn't match");

            string TitleAGS = driver.FindElement(By.XPath(titleAGSXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleAGS.ToLower().Trim(), aboutUs_D_V.txtTitleAGS.ToLower().Trim(), "The Text doesn't match");

            string InfoAGE = driver.FindElement(By.XPath(infoAGEXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAGE.ToLower().Trim(), aboutUs_D_V.txtInfoAGE.ToLower().Trim(), "The Text doesn't match");

            string TitleJoA = driver.FindElement(By.XPath(titleJoAXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJoA.ToLower().Trim(), aboutUs_D_V.txtTitleJoA.ToLower().Trim(), "The Text doesn't match");

            string InfoJoA = driver.FindElement(By.XPath(infoJoAXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJoA.ToLower().Trim(), aboutUs_D_V.txtInfoJoA.ToLower().Trim(), "The Text doesn't match");

            string TitleJSA = driver.FindElement(By.XPath(titleJSAXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJSA.ToLower().Trim(), aboutUs_D_V.txtTitleJSA.ToLower().Trim(), "The Text doesn't match");

            string InfoJSA = driver.FindElement(By.XPath(infoJSAXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJSA.ToLower().Trim(), aboutUs_D_V.txtInfoJSA.ToLower().Trim(), "The Text doesn't match");

            string TitleCJA = driver.FindElement(By.XPath(titleCJAXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleCJA.ToLower().Trim(), aboutUs_D_V.txtTitleCJA.ToLower().Trim(), "The Text doesn't match");

            string InfoCJA = driver.FindElement(By.XPath(infoCJAXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCJA.ToLower().Trim(), aboutUs_D_V.txtInfoCJA.ToLower().Trim(), "The Text doesn't match");

            string TitleCJG = driver.FindElement(By.XPath(titleCJGXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleCJG.ToLower().Trim(), aboutUs_D_V.txtTitleCJG.ToLower().Trim(), "The Text doesn't match");

            string InfoCJG = driver.FindElement(By.XPath(infoCJGXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCJG.ToLower().Trim(), aboutUs_D_V.txtInfoCJG.ToLower().Trim(), "The Text doesn't match");

            string TitleJVC = driver.FindElement(By.XPath(titleJVCXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJVC.ToLower().Trim(), aboutUs_D_V.txtTitleJVC.ToLower().Trim(), "The Text doesn't match");

            string InfoJVC = driver.FindElement(By.XPath(infoJVCXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJVC.ToLower().Trim(), aboutUs_D_V.txtInfoJVC.ToLower().Trim(), "The Text doesn't match");

            string TitleMJSA = driver.FindElement(By.XPath(titleMJSAXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleMJSA.ToLower().Trim(), aboutUs_D_V.txtTitleMJSA.ToLower().Trim(), "The Text doesn't match");

            string InfoMJSA = driver.FindElement(By.XPath(infoMJSAXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoMJSA.ToLower().Trim(), aboutUs_D_V.txtInfoMJSA.ToLower().Trim(), "The Text doesn't match");
        }

        public void verfiyGivingBack()
        {
            //Giving back to the community
            string TitleGiving = driver.FindElement(By.XPath(titleGivingXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleGiving.ToLower().Trim(), aboutUs_D_V.txtTitleGiving.ToLower().Trim(), "The Text doesn't match");

            string InfoGiving1 = driver.FindElement(By.XPath(infoGiving1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoGiving1.ToLower().Trim(), aboutUs_D_V.txtInfoGiving1.ToLower().Trim(), "The Text doesn't match");

            string InfoGiving2 = driver.FindElement(By.XPath(infoGiving2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoGiving2.ToLower().Trim(), aboutUs_D_V.txtInfoGiving2.ToLower().Trim(), "The Text doesn't match");

            string BtnSeeIfYourOrg = driver.FindElement(By.XPath(btnLearnHowXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnSeeIfYourOrg.ToLower().Trim(), aboutUs_D_V.btnLearnHow.ToLower().Trim(), "The Text doesn't match");
        }
        public void verifyLeadership()
        {
            // Leadership
            string HeaderLeadership = driver.FindElement(By.XPath(headerLeadershipXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderLeadership.ToLower().Trim(), aboutUs_D_V.txtHeaderLeadership.ToLower().Trim(), "The Text doesn't match");

            string TitleExecutive = driver.FindElement(By.XPath(titleExecutiveXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleExecutive.ToLower().Trim(), aboutUs_D_V.txtTitleExecutive.ToLower().Trim(), "The Text doesn't match");

            string TitleScott = driver.FindElement(By.XPath(titleScottXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleScott.ToLower().Trim(), aboutUs_D_V.txtTitleScott.ToLower().Trim(), "The Text doesn't match");

            string InfoScott = driver.FindElement(By.XPath(infoScottXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoScott.ToLower().Trim(), aboutUs_D_V.txtInfoScott.ToLower().Trim(), "The Text doesn't match");

            string TitleMikeAlex = driver.FindElement(By.XPath(titleMikeAlexXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleMikeAlex.ToLower().Trim(), aboutUs_D_V.txtTitleMikeAlex.ToLower().Trim(), "The Text doesn't match");

            string InfoMikeAlex = driver.FindElement(By.XPath(infoMikeAlexXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoMikeAlex.ToLower().Trim(), aboutUs_D_V.txtInfoMikeAlex.ToLower().Trim(), "The Text doesn't match");

            string TitleAngela = driver.FindElement(By.XPath(titleAngelaXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleAngela.ToLower().Trim(), aboutUs_D_V.txtTitleAngela.ToLower().Trim(), "The Text doesn't match");

            string InfoAngela = driver.FindElement(By.XPath(infoAngelaXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAngela.ToLower().Trim(), aboutUs_D_V.txtInfoAngela.ToLower().Trim(), "The Text doesn't match");

            string TitleJamie = driver.FindElement(By.XPath(titleJamieXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJamie.ToLower().Trim(), aboutUs_D_V.txtTitleJamie.ToLower().Trim(), "The Text doesn't match");

            string InfoJamie = driver.FindElement(By.XPath(infoJamieXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJamie.ToLower().Trim(), aboutUs_D_V.txtInfoJamie.ToLower().Trim(), "The Text doesn't match");

            string TitleBryon = driver.FindElement(By.XPath(titleBryonXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleBryon.ToLower().Trim(), aboutUs_D_V.txtTitleBryon.ToLower().Trim(), "The Text doesn't match");

            string InfoBryon = driver.FindElement(By.XPath(infoBryonXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBryon.ToLower().Trim(), aboutUs_D_V.txtInfoBryon.ToLower().Trim(), "The Text doesn't match");

            string TitleMikePelto = driver.FindElement(By.XPath(titleMikePeltoXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleMikePelto.ToLower().Trim(), aboutUs_D_V.txtTitleMikePelto.ToLower().Trim(), "The Text doesn't match");

            string InfoMikePelto = driver.FindElement(By.XPath(infoMikePeltoXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoMikePelto.ToLower().Trim(), aboutUs_D_V.txtInfoMikePelto.ToLower().Trim(), "The Text doesn't match");

            string TitleMark = driver.FindElement(By.XPath(titleMarkXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleMark.ToLower().Trim(), aboutUs_D_V.txtTitleMark.ToLower().Trim(), "The Text doesn't match");

            string InfoMark = driver.FindElement(By.XPath(infoMarkXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoMark.ToLower().Trim(), aboutUs_D_V.txtInfoMark.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyAddOns()
        {
            // Business Leaders

            string HeaderBusinessLeaders = driver.FindElement(By.XPath(headerBusinessLeadersXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderBusinessLeaders.ToLower().Trim(), aboutUs_D_V.txtHeaderBusinessLeaders.ToLower().Trim(), "The Text doesn't match");

            string TitleJeffB = driver.FindElement(By.XPath(titleJeffBXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJeffB.ToLower().Trim(), aboutUs_D_V.txtTitleJeffB.ToLower().Trim(), "The Text doesn't match");

            string InfoJeffB = driver.FindElement(By.XPath(infoJeffBXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJeffB.ToLower().Trim(), aboutUs_D_V.txtInfoJeffB.ToLower().Trim(), "The Text doesn't match");

            string TitleJayD = driver.FindElement(By.XPath(titleJayDXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJayD.ToLower().Trim(), aboutUs_D_V.txtTitleJayD.ToLower().Trim(), "The Text doesn't match");

            string InfoJayD = driver.FindElement(By.XPath(infoJayDXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJayD.ToLower().Trim(), aboutUs_D_V.txtInfoJayD.ToLower().Trim(), "The Text doesn't match");

            string TitleMarkD = driver.FindElement(By.XPath(titleMarkDXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleMarkD.ToLower().Trim(), aboutUs_D_V.txtTitleMarkD.ToLower().Trim(), "The Text doesn't match");

            string InfoMarkD = driver.FindElement(By.XPath(infoMarkDXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoMarkD.ToLower().Trim(), aboutUs_D_V.txtInfoMarkD.ToLower().Trim(), "The Text doesn't match");

            string TitleJohnF = driver.FindElement(By.XPath(titleJohnFXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJohnF.ToLower().Trim(), aboutUs_D_V.txtTitleJohnF.ToLower().Trim(), "The Text doesn't match");

            string InfoJohnF = driver.FindElement(By.XPath(infoJohnFXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJohnF.ToLower().Trim(), aboutUs_D_V.txtInfoJohnF.ToLower().Trim(), "The Text doesn't match");

            string TitleDavidM = driver.FindElement(By.XPath(titleDavidMXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDavidM.ToLower().Trim(), aboutUs_D_V.txtTitleDavidM.ToLower().Trim(), "The Text doesn't match");

            string InfoDavidM = driver.FindElement(By.XPath(infoDavidMSS)).GetAttribute("innerText");
            Assert.AreEqual(InfoDavidM.ToLower().Trim(), aboutUs_D_V.txtInfoDavidM.ToLower().Trim(), "The Text doesn't match");

            string TitleKenM = driver.FindElement(By.XPath(titleKenMXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleKenM.ToLower().Trim(), aboutUs_D_V.txtTitleKenM.ToLower().Trim(), "The Text doesn't match");

            string InfoKenM = driver.FindElement(By.XPath(infoKenMXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoKenM.ToLower().Trim(), aboutUs_D_V.txtInfoKenM.ToLower().Trim(), "The Text doesn't match");

            string TitleTinaO = driver.FindElement(By.XPath(titleTinaOXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleTinaO.ToLower().Trim(), aboutUs_D_V.txtTitleTinaO.ToLower().Trim(), "The Text doesn't match");

            string InfoTinaO = driver.FindElement(By.XPath(infoTinaOXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTinaO.ToLower().Trim(), aboutUs_D_V.txtInfoTinaO.ToLower().Trim(), "The Text doesn't match");

            string TitleDylanP = driver.FindElement(By.XPath(titleDylanPXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDylanP.ToLower().Trim(), aboutUs_D_V.txtTitleDylanP.ToLower().Trim(), "The Text doesn't match");

            string InfoDylanP = driver.FindElement(By.XPath(infoDylanPXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDylanP.ToLower().Trim(), aboutUs_D_V.txtInfoDylanP.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyBOD()
        {
            // Our Board of Directors

            string HeaderDirectors = driver.FindElement(By.XPath(headerDirectorsXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderDirectors.ToLower().Trim(), aboutUs_D_V.txtHeaderDirectors.ToLower().Trim(), "The Text doesn't match");

            string TitleAlexB = driver.FindElement(By.XPath(titleAlexBXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleAlexB.ToLower().Trim(), aboutUs_D_V.txtTitleAlexB.ToLower().Trim(), "The Text doesn't match");

            //string InfoAlexB = driver.FindElement(By.XPath(infoAlexBXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoAlexB.ToLower().Trim(), aboutUs_D_V.txtInfoAlexB.ToLower().Trim(), "The Text doesn't match");

            string TitleJonathanB = driver.FindElement(By.XPath(titleJonathanBXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleJonathanB.ToLower().Trim(), aboutUs_D_V.txtTitleJonathanB.ToLower().Trim(), "The Text doesn't match");

            //string InfoJonathanB = driver.FindElement(By.XPath(infoJonathanBXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoJonathanB.ToLower().Trim(), aboutUs_D_V.txtInfoJonathanB.ToLower().Trim(), "The Text doesn't match");

            string TitleMarkFD = driver.FindElement(By.XPath(titleMarkFDXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleMarkFD.ToLower().Trim(), aboutUs_D_V.txtTitleMarkFD.ToLower().Trim(), "The Text doesn't match");

            string InfoMarkF = driver.FindElement(By.XPath(infoMarkFXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoMarkF.ToLower().Trim(), aboutUs_D_V.txtInfoMarkF.ToLower().Trim(), "The Text doesn't match");

            string TitleDioneK = driver.FindElement(By.XPath(titleDioneKXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDioneK.ToLower().Trim(), aboutUs_D_V.txtTitleDioneK.ToLower().Trim(), "The Text doesn't match");

            //string InfoDioneK = driver.FindElement(By.XPath(infoDioneKXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoDioneK.ToLower().Trim(), aboutUs_D_V.txtInfoDioneK.ToLower().Trim(), "The Text doesn't match");

            string TitleDavidL = driver.FindElement(By.XPath(titleDavidLXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDavidL.ToLower().Trim(), aboutUs_D_V.txtTitleDavidL.ToLower().Trim(), "The Text doesn't match");

            //string InfoDavidL = driver.FindElement(By.XPath(infoDavidLXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoDavidL.ToLower().Trim(), aboutUs_D_V.txtInfoDavidL.ToLower().Trim(), "The Text doesn't match");

            string TitleSherryM = driver.FindElement(By.XPath(titleSherryMXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleSherryM.ToLower().Trim(), aboutUs_D_V.txtTitleSherryM.ToLower().Trim(), "The Text doesn't match");

            //string InfoSherryM = driver.FindElement(By.XPath(infoSherryMXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoSherryM.ToLower().Trim(), aboutUs_D_V.txtInfoSherryM.ToLower().Trim(), "The Text doesn't match");

            string TitleMarianneM = driver.FindElement(By.XPath(titleMarianneMXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleMarianneM.ToLower().Trim(), aboutUs_D_V.txtTitleMarianneM.ToLower().Trim(), "The Text doesn't match");

            //string InfoMarianneM = driver.FindElement(By.XPath(infoMarianneMXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoMarianneM.ToLower().Trim(), aboutUs_D_V.txtInfoMarianneM.ToLower().Trim(), "The Text doesn't match");

            string TitleScottMurphy = driver.FindElement(By.XPath(titleScottMurphyXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleScottMurphy.ToLower().Trim(), aboutUs_D_V.txtTitleScottMurphy.ToLower().Trim(), "The Text doesn't match");

            string InfoScottyMurphyO = driver.FindElement(By.XPath(infoScottyMurphyOXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoScottyMurphyO.ToLower().Trim(), aboutUs_D_V.txtInfoScottyMurphy.ToLower().Trim(), "The Text doesn't match");

            string TitleRobertR = driver.FindElement(By.XPath(titleRobertRXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleRobertR.ToLower().Trim(), aboutUs_D_V.txtTitleRobertR.ToLower().Trim(), "The Text doesn't match");

            //string InfoRobertR = driver.FindElement(By.XPath(infoRobertRXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoRobertR.ToLower().Trim(), aboutUs_D_V.txtInfoRobertR.ToLower().Trim(), "The Text doesn't match");

            string TitleKurtS = driver.FindElement(By.XPath(titleKurtSXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleKurtS.ToLower().Trim(), aboutUs_D_V.txtTitleKurtS.ToLower().Trim(), "The Text doesn't match");

            string InfoKurtS = driver.FindElement(By.XPath(infoKurtSXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoKurtS.ToLower().Trim(), aboutUs_D_V.txtInfoKurtS.ToLower().Trim(), "The Text doesn't match");

            string TitleCraigU = driver.FindElement(By.XPath(titleCraigUXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleCraigU.ToLower().Trim(), aboutUs_D_V.txtTitleCraigU.ToLower().Trim(), "The Text doesn't match");

            //string InfoCraigU = driver.FindElement(By.XPath(infoCraigUXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoCraigU.ToLower().Trim(), aboutUs_D_V.txtInfoCraigU.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyLittleMore()
        {
            // A Little More About Us

            string HeaderALittleMore = driver.FindElement(By.XPath(headerALittleMoreXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderALittleMore.ToLower().Trim(), aboutUs_D_V.txtHeaderALittleMore.ToLower().Trim(), "The Text doesn't match");

            string TitleWhatsInAName = driver.FindElement(By.XPath(titleWhatsInANameXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatsInAName.ToLower().Trim(), aboutUs_D_V.txtTitleWhatsInAName.ToLower().Trim(), "The Text doesn't match");

            string InfoWhatsInAName = driver.FindElement(By.XPath(infoWhatsInANameXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatsInAName.ToLower().Trim(), aboutUs_D_V.txtInfoWhatsInAName.ToLower().Trim(), "The Text doesn't match");

            string BtnViewOurAnnual = driver.FindElement(By.XPath(btnViewOurAnnualXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnViewOurAnnual.ToLower().Trim(), aboutUs_D_V.btnViewOurAnnual.ToLower().Trim(), "The Text doesn't match");

            string TitleWeLoveJewelry = driver.FindElement(By.XPath(titleWeLoveJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWeLoveJewelry.ToLower().Trim(), aboutUs_D_V.txtTitleWeLoveJewelry.ToLower().Trim(), "The Text doesn't match");

            string InfoWeLoveJewelry = driver.FindElement(By.XPath(infoWeLoveJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWeLoveJewelry.ToLower().Trim(), aboutUs_D_V.txtInfoWeLoveJewelry.ToLower().Trim(), "The Text doesn't match");

            string BtnSchedule = driver.FindElement(By.XPath(btnScheduleXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnSchedule.ToLower().Trim(), aboutUs_D_V.btnSchedule.ToLower().Trim(), "The Text doesn't match");

            string TitleWorkWithUs = driver.FindElement(By.XPath(titleWorkWithUsXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWorkWithUs.ToLower().Trim(), aboutUs_D_V.txtTitleWorkWithUs.ToLower().Trim(), "The Text doesn't match");

            string InfoWorkWithUs = driver.FindElement(By.XPath(infoWorkWithUsXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWorkWithUs.ToLower().Trim(), aboutUs_D_V.txtInfoWorkWithUs.ToLower().Trim(), "The Text doesn't match");

            string BtnWorkWithUs = driver.FindElement(By.XPath(btnWorkWithUsXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnWorkWithUs.ToLower().Trim(), aboutUs_D_V.btnWorkWithUs.ToLower().Trim(), "The Text doesn't match");
        }
    }
}

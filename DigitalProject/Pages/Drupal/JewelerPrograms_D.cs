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
    public class JewelerPrograms_D : Page
    {
        // Elements  

        //Jeweler Programs Page Images

        // Jeweler Programs Header
        string headerJPXpath = "//h4[.='JEWELER PROGRAMS']";
        string infoJPXpath = "//h1[.='Realize multi-faceted benefits.']";

        // What;s in it for you
        string headerWhatsInItForYouXpath = "//h2[.=\"What's in it for you\"]";
        string iconCustomerCareXpath = "//img[@alt='customer care graphic']";
        string titleCustomerCareXpath = "//h4[.='Customer Care']";
        string infoCustomerCareXpath = "//p[contains(.,'Mentioning personal jewelry insurance shows your customers that you stand by you')]";
        string iconEasyXpath = "//img[@alt='chart graphic']";
        string titleEasyXpath = "//h4[.='Easy Claim Payments']";
        string infoEasyXpath = "//p[contains(.,'Jewelers Mutual pays you directly for claim-related work. You’ll also receive fr')]";
        string iconFlexibilityXpath = "//img[@alt='flexibility graphic']";
        string titleFlexibilityXpath = "//h4[.='Flexibility']";
        string infoFlexibilityXpath = "//p[contains(.,'Insured customers have the flexibility to choose their preferred jeweler for cla')]";
        string iconGrowXpath = "//img[@alt='trophy graphic']";
        string titleGrowXpath = "//h4[.='Grow Your Business']";
        string infoGrowXpath = "//p[contains(.,'Return visits to your store for repairs or replacements provide opportunities fo')]";

        //James Testmional
        string imgJamesXpath = "//img[@alt='James photo']";
        string quoteJamesXpath = "//p[contains(.,'We would recommend Jewelers Mutual to anyone in our business.')]";
        string nameJamesXpath = "//span[contains(.,'James')]";

        // Strengthen Customer Relations
        string headerStrengthenXpath = "//h2[.='Strengthen Customer Relations']";
        string titleProvideXpath = "//h4[.='Provide a premium level of service']";
        string infoProvideXpath = "//p[contains(.,'Give your customers the information they need to learn how to protect their new')]";
        string btnOrderXpath = "//a[.='ORDER FREE RESOURCES']";

        // There are more advantages where this came from.
        // string iconAdvantagesXpath = "[alt='toolbox graphic']";
        string titleAdvantagesXpath = "//h2[contains(.,'There are more advantages where this came from.')]";
        string infoAdvantagesXpath = "//p[.='See how JM University helps our policyholders build a safe and strong business.']";
        string btnTourJMXpath = "//a[contains(.,'TOUR JM UNIVERSITY')]";

        // Request to be part of a program
        string iconDocumentXpath = "//img[@alt='document icon']";
        string titleRequestXpath = "//h2[.='Request to be part of a program']";
        string formFNXpath = "//div[.='First Name']";
        string formLNXpath = "//div[.='Last Name']";
        string formNBXpath = "//div[.='Name of Business']";
        string formZipXpath = "//div[.='Zip/Postal Code']";
        //  string formTypeXpath = "div.slds-grid > div:nth-of-type(5) > div:nth-of-type(1)";
        // string formNeedXpath = "div.slds-grid > div:nth-of-type(6) > div:nth-of-type(1)";
        string formEmailXpath = "//div[.='Email']";
        string formPhoneXpath = "//div[.='Phone']";
        string formPCMXpath = "//div[.='Preferred Contact Method']";
        // string captchaTextXpath = "#recaptcha-anchor-label";
        // string captchaIconXpath = ".rc-anchor-logo-img";
        // string btnSubmitXpath = "[name='submit']";

        JewelerPrograms_D_V JewelerPrograms_D_V = new JewelerPrograms_D_V();
        public JewelerPrograms_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify

            VerifyUIElementIsDisplayed(headerJPXpath);
//            VerifyUIElementIsDisplayed(infoJPXpath);
//            VerifyUIElementIsDisplayed(headerWhatsInItForYouXpath);
            VerifyUIElementIsDisplayed(iconCustomerCareXpath);
            VerifyUIElementIsDisplayed(titleCustomerCareXpath);
            VerifyUIElementIsDisplayed(infoCustomerCareXpath);
            VerifyUIElementIsDisplayed(iconEasyXpath);
            VerifyUIElementIsDisplayed(titleEasyXpath);
            VerifyUIElementIsDisplayed(infoEasyXpath);
            VerifyUIElementIsDisplayed(iconFlexibilityXpath);
            VerifyUIElementIsDisplayed(titleFlexibilityXpath);
            VerifyUIElementIsDisplayed(infoFlexibilityXpath);
            VerifyUIElementIsDisplayed(iconGrowXpath);
            VerifyUIElementIsDisplayed(titleGrowXpath);
            VerifyUIElementIsDisplayed(infoGrowXpath);
//            VerifyUIElementIsDisplayed(imgJamesXpath);
//            VerifyUIElementIsDisplayed(quoteJamesXpath);
//            VerifyUIElementIsDisplayed(nameJamesXpath);
//            VerifyUIElementIsDisplayed(headerStrengthenXpath);
//            VerifyUIElementIsDisplayed(titleProvideXpath);
//            VerifyUIElementIsDisplayed(infoProvideXpath);
//            VerifyUIElementIsDisplayed(btnOrderXpath);
            //   VerifyUIElementIsDisplayed(iconAdvantagesXpath);
//            VerifyUIElementIsDisplayed(titleAdvantagesXpath);
            VerifyUIElementIsDisplayed(infoAdvantagesXpath);
//            VerifyUIElementIsDisplayed(btnTourJMXpath);
//            VerifyUIElementIsDisplayed(iconDocumentXpath);
//            VerifyUIElementIsDisplayed(titleRequestXpath);
            driver.SwitchTo().Frame(0);
            VerifyUIElementIsDisplayed(formFNXpath);
            VerifyUIElementIsDisplayed(formLNXpath);
            VerifyUIElementIsDisplayed(formNBXpath);
            VerifyUIElementIsDisplayed(formZipXpath);
            //   VerifyUIElementIsDisplayed(formTypeXpath);
            //   VerifyUIElementIsDisplayed(formNeedXpath);
            VerifyUIElementIsDisplayed(formEmailXpath);
            VerifyUIElementIsDisplayed(formPhoneXpath);
            VerifyUIElementIsDisplayed(formPCMXpath);
            driver.SwitchTo().ParentFrame();
            //    VerifyUIElementIsDisplayed(captchaTextXpath);
            //    VerifyUIElementIsDisplayed(captchaIconXpath);
            //   VerifyUIElementIsDisplayed(btnSubmitXpath);
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

        public void verifyAllJewelerProgramsPageContent()
        {
            verifyJP();
            verifyWhatInItForYou();
            //verifyJamesTest();
            //verifyCustomerRelations();
            verifyAdvantages();
            verifyRequstProgram();
        }
        public void verifyJP()
        {
            // Jeweler Programs Header
            string HeaderJP = driver.FindElement(By.XPath(headerJPXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderJP, JewelerPrograms_D_V.headerJP, "The Text doesn't match");

            //string InfoJP = driver.FindElement(By.XPath(infoJPXpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoJP, JewelerPrograms_D_V.txtInfoJP, "The Text doesn't match");

        }

        public void verifyWhatInItForYou()
        {
            // What's in it for you
            //string HeaderWhatsInItForYou = driver.FindElement(By.XPath(headerWhatsInItForYouXpath)).GetAttribute("innerText");
            //Assert.AreEqual(HeaderWhatsInItForYou, JewelerPrograms_D_V.txtHeaderWhatsInItForYou, "The Text doesn't match");

            string TitleCustomerCare = driver.FindElement(By.XPath(titleCustomerCareXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleCustomerCare, JewelerPrograms_D_V.txtTitleCustomerCare, "The Text doesn't match");

            string InfoCustomerCare = driver.FindElement(By.XPath(infoCustomerCareXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCustomerCare, JewelerPrograms_D_V.txtInfoCustomerCare, "The Text doesn't match");

            string TitleEasy = driver.FindElement(By.XPath(titleEasyXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleEasy, JewelerPrograms_D_V.txtTitleEasy, "The Text doesn't match");

            string InfoEasy = driver.FindElement(By.XPath(infoEasyXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoEasy, JewelerPrograms_D_V.txtInfoEasy, "The Text doesn't match");

            string TitleFlexibility = driver.FindElement(By.XPath(titleFlexibilityXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleFlexibility, JewelerPrograms_D_V.txtTitleFlexibilitySS, "The Text doesn't match");

            string InfoFlexibility = driver.FindElement(By.XPath(infoFlexibilityXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoFlexibility, JewelerPrograms_D_V.txtInfoFlexibility, "The Text doesn't match");

            string TitleGrow = driver.FindElement(By.XPath(titleGrowXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleGrow, JewelerPrograms_D_V.txtTitleGrow, "The Text doesn't match");

            string InfoGrow = driver.FindElement(By.XPath(infoGrowXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoGrow, JewelerPrograms_D_V.txtInfoGrow, "The Text doesn't match");
        }

        public void verifyJamesTest()
        {
            //James Testmional
            //string QuoteJames = driver.FindElement(By.XPath(quoteJamesXpath)).GetAttribute("innerText");
            //Assert.AreEqual(QuoteJames, JewelerPrograms_D_V.txtQuoteJames, "The Text doesn't match");

            string NameJames = driver.FindElement(By.XPath(nameJamesXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameJames, JewelerPrograms_D_V.txtNameJames, "The Text doesn't match");
        }

        public void verifyCustomerRelations()
        {
            // Strengthen Customer Relations
            //string HeaderStrengthen = driver.FindElement(By.XPath(headerStrengthenXpath)).GetAttribute("innerText");
            //Assert.AreEqual(HeaderStrengthen, JewelerPrograms_D_V.txtHeaderStrengthen, "The Text doesn't match");

//            string TitleProvide = driver.FindElement(By.XPath(titleProvideXpath)).GetAttribute("innerText");
//            Assert.AreEqual(TitleProvide, JewelerPrograms_D_V.txtTitleProvide, "The Text doesn't match");

            string InfoProvide = driver.FindElement(By.XPath(infoProvideXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoProvide, JewelerPrograms_D_V.txtInfoProvide, "The Text doesn't match");

            string BtnOrder = driver.FindElement(By.XPath(btnOrderXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnOrder, JewelerPrograms_D_V.btnOrder, "The Text doesn't match");

        }

        public void verifyAdvantages()
        {
            // There are more advantages where this came from.

            string TitleAdvantages = driver.FindElement(By.XPath(titleAdvantagesXpath)).GetAttribute("innerText");
            Console.WriteLine(TitleAdvantages);
            Assert.AreEqual(TitleAdvantages, JewelerPrograms_D_V.txtTitleAdvantages, "The Text doesn't match");

            string InfoAdvantages = driver.FindElement(By.XPath(infoAdvantagesXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdvantages, JewelerPrograms_D_V.txtInfoAdvantages, "The Text doesn't match");

            string BtnTourJM = driver.FindElement(By.XPath(btnTourJMXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnTourJM, JewelerPrograms_D_V.btnTourJM, "The Text doesn't match");

        }

        public void verifyRequstProgram()
        {
            // Request to be part of a program

            string TitleRequest = driver.FindElement(By.XPath(titleRequestXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleRequest, JewelerPrograms_D_V.txtTitleRequest, "The Text doesn't match");

            driver.SwitchTo().Frame(0);

            string FormFN = driver.FindElement(By.XPath(formFNXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormFN, JewelerPrograms_D_V.formFN, "The Text doesn't match");

            string FormLN = driver.FindElement(By.XPath(formLNXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormLN, JewelerPrograms_D_V.formLN, "The Text doesn't match");

            string FormNBC = driver.FindElement(By.XPath(formNBXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormNBC, JewelerPrograms_D_V.formNB, "The Text doesn't match");

            string FormZip = driver.FindElement(By.XPath(formZipXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormZip, JewelerPrograms_D_V.formZip, "The Text doesn't match");

            //string FormType = driver.FindElement(By.XPath(formTypeXpath)).GetAttribute("innerText");
            //Assert.AreEqual(FormType, JewelerPrograms_D_V.formType, "The Text doesn't match");

            //string FormNeed = driver.FindElement(By.XPath(formNeedXpath)).GetAttribute("innerText");
            //Assert.AreEqual(FormNeed, JewelerPrograms_D_V.formNeed, "The Text doesn't match");

            string FormEmail = driver.FindElement(By.XPath(formEmailXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormEmail, JewelerPrograms_D_V.formhref, "The Text doesn't match");

            string FormPhone = driver.FindElement(By.XPath(formPhoneXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormPhone, JewelerPrograms_D_V.formPhone, "The Text doesn't match");

            string FormPCM = driver.FindElement(By.XPath(formPCMXpath)).GetAttribute("innerText");
            Assert.AreEqual(FormPCM, JewelerPrograms_D_V.formPCM, "The Text doesn't match");

            //string CaptchaText = driver.FindElement(By.XPath(captchaTextXpath)).GetAttribute("innerText");
            //Assert.AreEqual(CaptchaText, JewelerPrograms_D_V.captchaText, "The Text doesn't match");

            //string BtnSubmit = driver.FindElement(By.XPath(btnSubmitXpath)).GetAttribute("innerText");
            //Assert.AreEqual(BtnSubmit, JewelerPrograms_D_V.btnSubmit, "The Text doesn't match");

            driver.SwitchTo().ParentFrame();
        }
    }
}

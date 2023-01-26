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
    public class Shipping_D : Page
    {
        // Elements  



        // Shipping Header
        string headerShippingXpath = "//h1[text()='Rethink the Way You Ship']";
        string infoShippingXpath = "//p[text()='Compare options side-by-side, access incentive programs and intelligently insure your packages, all from one, easy-to-use platform - JM Shipping Solution™.']";
        string btnGetStartedXpath = "//a[text()='Get Started']";

        // Benefits
        string headerBenefitsXpath = "//h2[text()='Benefits for Your Business']";
        string titleSimplictyXpath = "//h4[text()='Simplicity and Convenience']";
        string infoSimplicty1Xpath = "//p[contains(text(),'Travel websites make it easy to plan')]";
        string infoSimplicty2Xpath = "//li[text()='Compare pricing and buy labels and insurance from a single dashboard']";
        string infoSimplicty3Xpath = "//li[text()='Set preferences for common packaging materials, destination addresses, and carriers']";
        string infoSimplicty4Xpath = "//li[text()='Integrate with existing business systems, e-commerce platforms, and shipping software']";
        string titleDiscountsXpath = "//h4[text()='Discounts and Savings']";
        string infoDiscounts1Xpath = "//p[text()='We know the impact of risk management on insurance costs, and now we buy freight in bulk to give you another advantage.']";
        string infoDiscounts2Xpath = "//li[text()='Receive a $2 credit for each qualifying USPS Priority Mail Express Label']";
        string infoDiscounts3Xpath = "//li[text()='Access pricing normally reserved for large enterprises and maximize savings using the power of choice']";
        string infoDiscounts4Xpath = "//li[text()='Save up to 50% of shipping coverage costs when compared to jewelers block policies']";
        string titlePeaceXpath = "//h4[text()='Peace of Mind']";
        string infoPeace1Xpath = "//p[text()='Buy only the coverage you need, when you need it and monitor the status of your package.']";
        string infoPeace2Xpath = "//li[text()='Receive guidance on packaging and service-type options to ensure deliveries are successful']";
        string infoPeace3Xpath = "//li[text()='Track packages with all carriers, including return shipments']";
        string infoPeace4Xpath = "//li[text()='Trust in the same excellent claim service Jewelers Mutual is known for']";


        //How It Works
        string headerHowItWorksXpath = "//h2[text()='How It Works']";
        string titleStep1Xpath = "//h4[text()='Step 1: Enter Details']";
        string infoStep1Xpath = "//p[text()='Enter the value, packaging, weight, origin, and destination of the package.']";
        string titleStep2Xpath = "//h4[text()='Step 2: Choose Carrier']";
        string infoStep2Xpath = "//p[text()='Choose the carrier and service-type that fit your needs and budget.']";
        string titleStep3Xpath = "//h4[text()='Step 3: Print']";
        string infoStep3Xpath = "//p[text()='Print the bar-coded shipping label.']";

        // Testmionals 
        string imgLeftArrowXpath = "//img[@src='/themes/custom/jewelers_mutual/images/icons/left-arrow.svg']";
        string imgRightArrowXpath = "//img[@src='/themes/custom/jewelers_mutual/images/icons/right-arrow.svg']";
        string quote1Xpath = "//div[@class='carousel__text spacing-3x'][contains(text(),'The program cut our shipping costs and time spent preparing shipments')]";
        string name1Xpath = "//div[@class='carousel__headline'][contains(text(),'Ann Marie Hanrahan')]";
        string jeweler1Xpath = "//div[@class='carousel__title-company'][contains(text(),'R. F. Moeller Jeweler')]";
        string quote2Xpath = "//div[@class='carousel__text spacing-3x'][contains(text(),'Our business has literally changed the way we ship because of JM Shipping Solution. We')]";
        string name2Xpath = "//div[@class='carousel__headline'][contains(text(),'Gregory Vana')]";
        string jeweler2Xpath = "//div[@class='carousel__title-company'][contains(text(),'Time Delay Corporation')]";
        string quote3Xpath = "//div[@class='carousel__slide carousel__slide--align-left slick-slide slick-current slick-active']//div[@class='carousel__text spacing-3x']";
        string name3Xpath = "//div[@class='carousel__slide carousel__slide--align-left slick-slide slick-current slick-active']//div[@class='carousel__headline']";
        string jeweler3Xpath = "//div[@class='carousel__slide carousel__slide--align-left slick-slide slick-current slick-active']//div[@class='carousel__title-company']";

        // Start Shipping Differently
        string headerStartShippingXpath = "//h2[text()='Start Shipping Differently']";
        string infoStartShippingXpath = "//p[contains(text(),'Tell us a little about yourself and one of our dedicated shipping experts will r')]";
        string linkSignUpXpath = "//a[text()='sign up on your own to get started now']";
        string formFNXpath = "//div[text()='First Name']";
        string formLNXpath = "//div[text()='Last Name']";
        string formNBXpath = "//div[text()='Name of Business']";
        string formZipXpath = "//div[text()='Zip/Postal Code']";
        //string formTypeXpath = "";
        //string formNeedXpath = "divtext()slds-grid > div:nth-of-type(6) > div:nth-of-type(1)";
        string formEmailXpath = "//div[text()='Email']";
        string formPhoneXpath = "//div[text()='Phone']";
        string formPCMXpath = "//div[text()='Preferred Contact Method']";
        string btnSubmitXpath = "//input[@name='submit']";
        string imgShippingFooter = "//div[@class='shipping-footer']";

        Shipping_D_V Shipping_D_V = new Shipping_D_V();
        public Shipping_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify



            //VerifyUIElementIsDisplayed(headerShippingXpath);
            //VerifyUIElementIsDisplayed(infoShippingXpath);
//            VerifyUIElementIsDisplayed(btnGetStartedXpath);

            VerifyUIElementIsDisplayed(headerBenefitsXpath);
            VerifyUIElementIsDisplayed(titleSimplictyXpath);
            VerifyUIElementIsDisplayed(infoSimplicty1Xpath);
//            VerifyUIElementIsDisplayed(infoSimplicty2Xpath);
            VerifyUIElementIsDisplayed(infoSimplicty3Xpath);
//            VerifyUIElementIsDisplayed(infoSimplicty4Xpath);
            VerifyUIElementIsDisplayed(titleDiscountsXpath);
//            VerifyUIElementIsDisplayed(infoDiscounts1Xpath);
//            VerifyUIElementIsDisplayed(infoDiscounts2Xpath);
//            VerifyUIElementIsDisplayed(infoDiscounts3Xpath);
            VerifyUIElementIsDisplayed(infoDiscounts4Xpath);
            VerifyUIElementIsDisplayed(titlePeaceXpath);
            VerifyUIElementIsDisplayed(infoPeace1Xpath);
            VerifyUIElementIsDisplayed(infoPeace2Xpath);
            VerifyUIElementIsDisplayed(infoPeace3Xpath);
//            VerifyUIElementIsDisplayed(infoPeace4Xpath);
            VerifyUIElementIsDisplayed(headerHowItWorksXpath);
            VerifyUIElementIsDisplayed(titleStep1Xpath);
            VerifyUIElementIsDisplayed(infoStep1Xpath);
            VerifyUIElementIsDisplayed(titleStep2Xpath);
            VerifyUIElementIsDisplayed(infoStep2Xpath);
            VerifyUIElementIsDisplayed(titleStep3Xpath);
            VerifyUIElementIsDisplayed(infoStep3Xpath);
//            VerifyUIElementIsDisplayed(imgShippingFooter);

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

        public void verifyShipping()
        {

            // Shipping Header
            string HeaderShipping = driver.FindElement(By.XPath(headerShippingXpath)).Text;
            Assert.AreEqual(HeaderShipping, Shipping_D_V.txtHeaderShipping, "The Text doesn't match");

            string InfoShipping = driver.FindElement(By.XPath(infoShippingXpath)).Text;
            Assert.AreEqual(InfoShipping, Shipping_D_V.txtInfoShipping, "The Text doesn't match");

            string BtnGetStarted = driver.FindElement(By.XPath(btnGetStartedXpath)).Text;
            Assert.AreEqual(BtnGetStarted, Shipping_D_V.btnGetStarted, "The Text doesn't match");

        }

        public void verifyCustomerStories()
        {
            // Our Cusotmer Stories

            //string infoAllYourOptions1Xpath = "//p[contains(.,'Shop for carriers, types of service, and packaging using dashboards that simplif')]";
            //string infoAllYourOptions2Xpath = "//li[contains(.,'Integrate with existing business systems, e-commerce platforms, and shipping sof')]";
            //string infoAllYourOptions3Xpath = "//li[contains(.,'Set preferences for common packaging materials, destination addresses')]";
            //string infoAllYourOptions4Xpath = "//li[.='Waive the requirement to declare value to the USPS on Registered Mail*']";


            string HeaderBenefits = driver.FindElement(By.XPath(headerBenefitsXpath)).Text;
            Assert.AreEqual(HeaderBenefits, Shipping_D_V.txtHeaderBenefits, "The Text doesn't match");

            string TitleSimplicty = driver.FindElement(By.XPath(titleSimplictyXpath)).Text;
            Assert.AreEqual(TitleSimplicty, Shipping_D_V.txtTitleSimplicty, "The Text doesn't match");

            string InfoSimplicty1 = driver.FindElement(By.XPath(infoSimplicty1Xpath)).Text;
            Assert.AreEqual(InfoSimplicty1, Shipping_D_V.txtInfoSimplicty1, "The Text doesn't match");

            string InfoSimplicty2 = driver.FindElement(By.XPath(infoSimplicty2Xpath)).Text;
            Assert.AreEqual(InfoSimplicty2, Shipping_D_V.txtInfoSimplicty2, "The Text doesn't match");

            string InfoSimplicty3 = driver.FindElement(By.XPath(infoSimplicty3Xpath)).Text;
            Assert.AreEqual(InfoSimplicty3, Shipping_D_V.txtInfoSimplicty3, "The Text doesn't match");

            string InfoSimplicty4 = driver.FindElement(By.XPath(infoSimplicty4Xpath)).Text;
            Assert.AreEqual(InfoSimplicty4, Shipping_D_V.txtInfoSimplicty4, "The Text doesn't match");

            string TitleDiscounts = driver.FindElement(By.XPath(titleDiscountsXpath)).Text;
            Assert.AreEqual(TitleDiscounts, Shipping_D_V.txtTitleDiscounts, "The Text doesn't match");

            string InfoDiscounts1 = driver.FindElement(By.XPath(infoDiscounts1Xpath)).Text;
            Assert.AreEqual(InfoDiscounts1, Shipping_D_V.txtInfoDiscounts1, "The Text doesn't match");

            string InfoDiscounts2 = driver.FindElement(By.XPath(infoDiscounts2Xpath)).Text;
            Assert.AreEqual(InfoDiscounts2, Shipping_D_V.txtInfoDiscounts2, "The Text doesn't match");

            string InfoDiscounts3 = driver.FindElement(By.XPath(infoDiscounts3Xpath)).Text;
            Assert.AreEqual(InfoDiscounts3, Shipping_D_V.txtInfoDiscounts3, "The Text doesn't match");

            string InfoDiscounts4 = driver.FindElement(By.XPath(infoDiscounts4Xpath)).Text;
            Assert.AreEqual(InfoDiscounts4, Shipping_D_V.txtInfoDiscounts4, "The Text doesn't match");

            string TitlePeace = driver.FindElement(By.XPath(titlePeaceXpath)).Text;
            Assert.AreEqual(TitlePeace, Shipping_D_V.txtTitlePeace, "The Text doesn't match");

            string InfoPeace1 = driver.FindElement(By.XPath(infoPeace1Xpath)).Text;
            Assert.AreEqual(InfoPeace1, Shipping_D_V.txtInfoPeace1, "The Text doesn't match");

            string InfoPeace2 = driver.FindElement(By.XPath(infoPeace2Xpath)).Text;
            Assert.AreEqual(InfoPeace2, Shipping_D_V.txtInfoPeace2, "The Text doesn't match");

            string InfoPeace3 = driver.FindElement(By.XPath(infoPeace3Xpath)).Text;
            Assert.AreEqual(InfoPeace3, Shipping_D_V.txtInfoPeace3, "The Text doesn't match");

            string InfoPeace4 = driver.FindElement(By.XPath(infoPeace4Xpath)).Text;
            Assert.AreEqual(InfoPeace4, Shipping_D_V.txtInfoPeace4, "The Text doesn't match");

        }

        public void verifyHowItWorks()
        {
            //How It Works
            string HeaderHowItWorks = driver.FindElement(By.XPath(headerHowItWorksXpath)).Text;
            Assert.AreEqual(HeaderHowItWorks, Shipping_D_V.txtHeaderHowItWorks, "The Text doesn't match");

            string TitleStep1 = driver.FindElement(By.XPath(titleStep1Xpath)).Text;
            Assert.AreEqual(TitleStep1, Shipping_D_V.txtTitleStep1, "The Text doesn't match");

            string InfoStep1 = driver.FindElement(By.XPath(infoStep1Xpath)).Text;
            Assert.AreEqual(InfoStep1, Shipping_D_V.txtInfoStep1, "The Text doesn't match");

            string TitleStep2 = driver.FindElement(By.XPath(titleStep2Xpath)).Text;
            Assert.AreEqual(TitleStep2, Shipping_D_V.txtTitleStep2, "The Text doesn't match");

            string InfoStep2 = driver.FindElement(By.XPath(infoStep2Xpath)).Text;
            Assert.AreEqual(InfoStep2, Shipping_D_V.txtInfoStep2, "The Text doesn't match");

            string TitleStep3 = driver.FindElement(By.XPath(titleStep3Xpath)).Text;
            Assert.AreEqual(TitleStep3, Shipping_D_V.txtTitleStep3, "The Text doesn't match");

            string InfoStep3 = driver.FindElement(By.XPath(infoStep3Xpath)).Text;
            Assert.AreEqual(InfoStep3, Shipping_D_V.txtInfoStep3, "The Text doesn't match");

        }



        public void verifyTestmionals()
        {
            // Testmionals 
            //string ImgLeftArrow = driver.FindElement(By.XPath(imgLeftArrowXpath)).Text;
            //Assert.AreEqual(ImgLeftArrow, Shipping_D_V.txtQuote1, "The Text doesn't match");

            //string ImgRightArrow = driver.FindElement(By.XPath(imgRightArrowXpath)).Text;
            //Assert.AreEqual(ImgRightArrow, Shipping_D_V.txtName1, "The Text doesn't match");


            string Quote1 = driver.FindElement(By.XPath(quote1Xpath)).Text;
            Assert.AreEqual(Quote1, Shipping_D_V.txtQuote1, "The Text doesn't match");

            string Name1 = driver.FindElement(By.XPath(name1Xpath)).Text;
            Assert.AreEqual(Name1, Shipping_D_V.txtName1, "The Text doesn't match");

            string Jeweler1 = driver.FindElement(By.XPath(jeweler1Xpath)).Text;
            Assert.AreEqual(Jeweler1, Shipping_D_V.txtJeweler1, "The Text doesn't match");

            JavaScriptClick(driver.FindElement(By.XPath(imgRightArrowXpath)));
            //UIAction(imgRightArrowXpath, String.Empty, "a");
            pause();

            string Quote2 = driver.FindElement(By.XPath(quote2Xpath)).Text;
            Assert.AreEqual(Quote2, Shipping_D_V.txtQuote2, "The Text doesn't match");

            string Name2 = driver.FindElement(By.XPath(name2Xpath)).Text;
            Assert.AreEqual(Name2, Shipping_D_V.txtName2, "The Text doesn't match");

            string Jeweler2 = driver.FindElement(By.XPath(jeweler2Xpath)).Text;
            Assert.AreEqual(Jeweler2, Shipping_D_V.txtJeweler2, "The Text doesn't match");


            JavaScriptClick(driver.FindElement(By.XPath(imgRightArrowXpath)));
            pause();

            string Quote3 = driver.FindElement(By.XPath(quote3Xpath)).Text;
            Console.WriteLine("vLUA IS " + Quote3);
            Console.WriteLine("vLUA2  IS " + driver.FindElement(By.XPath(quote3Xpath)).GetAttribute("InnerText"));
            Assert.AreEqual(Quote3, Shipping_D_V.txtQuote3, "The Text doesn't match");

            string Name3 = driver.FindElement(By.XPath(name3Xpath)).Text;
            Assert.AreEqual(Name3, Shipping_D_V.txtName3, "The Text doesn't match");

            string Jeweler3 = driver.FindElement(By.XPath(jeweler3Xpath)).Text;
            Assert.AreEqual(Jeweler3, Shipping_D_V.txtJeweler3, "The Text doesn't match");

        }

        public void verifyShipingDifferently()
        {
            //// Start Shipping Differently

            string HeaderStartShipping = driver.FindElement(By.XPath(headerStartShippingXpath)).Text;
            Assert.AreEqual(HeaderStartShipping, Shipping_D_V.txtHeaderStartShipping, "The Text doesn't match");

            string InfoStartShipping = driver.FindElement(By.XPath(infoStartShippingXpath)).Text;
            Assert.AreEqual(InfoStartShipping, Shipping_D_V.txtInfoStartShipping, "The Text doesn't match");

            string LinkSignUp = driver.FindElement(By.XPath(linkSignUpXpath)).Text;
            Assert.AreEqual(LinkSignUp, Shipping_D_V.hrefSignUp, "The Text doesn't match");

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='shipping-form-iframe']")));


            VerifyUIElementIsDisplayed(formFNXpath);
            VerifyUIElementIsDisplayed(formLNXpath);
            VerifyUIElementIsDisplayed(formNBXpath);
            VerifyUIElementIsDisplayed(formZipXpath);
            VerifyUIElementIsDisplayed(formEmailXpath);
            VerifyUIElementIsDisplayed(formPhoneXpath);
            VerifyUIElementIsDisplayed(formPCMXpath);
            VerifyUIElementIsDisplayed(btnSubmitXpath);


            string FormFN = driver.FindElement(By.XPath(formFNXpath)).Text;
            Assert.AreEqual(FormFN, Shipping_D_V.formFN, "The Text doesn't match");

            string FormLN = driver.FindElement(By.XPath(formLNXpath)).Text;
            Assert.AreEqual(FormLN, Shipping_D_V.formLN, "The Text doesn't match");

            string FormNBC = driver.FindElement(By.XPath(formNBXpath)).Text;
            Assert.AreEqual(FormNBC, Shipping_D_V.formNB, "The Text doesn't match");

            string FormZip = driver.FindElement(By.XPath(formZipXpath)).Text;
            Assert.AreEqual(FormZip, Shipping_D_V.formZip, "The Text doesn't match");


            string FormEmail = driver.FindElement(By.XPath(formEmailXpath)).Text;
            Assert.AreEqual(FormEmail, Shipping_D_V.formhref, "The Text doesn't match");

            string FormPhone = driver.FindElement(By.XPath(formPhoneXpath)).Text;
            Assert.AreEqual(FormPhone, Shipping_D_V.formPhone, "The Text doesn't match");

            string FormPCM = driver.FindElement(By.XPath(formPCMXpath)).Text;
            Assert.AreEqual(FormPCM, Shipping_D_V.formPCM, "The Text doesn't match");



            string BtnSubmit = driver.FindElement(By.XPath(btnSubmitXpath)).GetAttribute("value");
            Assert.AreEqual(BtnSubmit, Shipping_D_V.btnSubmit, "The Text doesn't match");
        }


        public void verifyShippingPageContent()
        {
            //verifyNavBar();
            verifyFooter();
            //verifyShipping();
            //verifyCustomerStories();
            verifyHowItWorks();
            //verifyTestmionals();
            //verifyShipingDifferently();
        }
    }
}

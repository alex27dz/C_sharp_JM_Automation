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
    public class Pawnbrokers_D : Page
    {
        // Elements  

        // Get A Quote
        //Verfiy Text
        string txtHeaderPawnbrokers1Xpath = "//h1[contains(text(),'Insurance for Pawnbrokers')]";
        string txtHeaderPawnbrokers2Xpath = "//h2[contains(text(),'Protect your business with comprehensive coverage and grow with exclusive progra')]";


        string txtContent1Xpath = "//p[contains(text(),'Jewelers Mutual’s commitment to protecting every business that sells jewelry has')]";
        string txtContent2Xpath = "//p[contains(.,'as well, because after all, what business isn')]";
        string txtContent3Xpath = "//p[contains(text(),'s how we can help your business:')]";
        string txtContent4Xpath = "//h4[text()='Comprehensive Coverage']";
        string txtContent5Xpath = "//p[contains(text(),'Our core, jewelry-based policies have been enhanced in collaboration with other')]";
        string txtContent6Xpath = "//h4[text()='JM Shipping Solution™']";
        string txtContent7Xpath = "//p[contains(text(),'Save time and money by comparing and selecting shipping options with exclusive d')]";
        string txtContent8Xpath = "//h4[text()='Personal Jewelry Insurance']";
        string txtContent8_1Xpath = "//p[contains(text(),'Take advantage of additional benefits by making your customers aware of the opti')]";
        string txtContent9Xpath = "//h4[text()='Get a personalized risk assessment and quote!']";
        string txtContent10Xpath = "//p[contains(text(),'Provide us with a few pieces of information — we')]";

        string txtContent11Xpath = "//span[text()='First Name']";
        string txtContent12Xpath = "//span[text()='Last Name']";
        string txtContent13Xpath = "//span[text()='Company Name']";
        string txtContent14Xpath = "//span[text()='Postal Code']";
        string txtContent15Xpath = "//span[text()='Email']";
        string txtContent16Xpath = "//span[text()='Phone Number']";
        string txtContent17Xpath = "//span[text()='Preferred Contact Method']";
        string txtContent18Xpath = "//span[text()='Best Time to Call']";
        string txtContent19Xpath = "//strong[text()='What insurance needs do you have?']";
        string txtContent20Xpath = "//em[text()='(Check all that apply)']";
        string txtContent21Xpath = "//span[text()='Business property']";
        string txtContent22Xpath = "//span[text()='General liability']";
        string txtContent23Xpath = "//span[text()='Gun liability']";
        string txtContent24Xpath = "//span[text()='Cyber liability']";
        string txtContent25Xpath = "//span[text()='Shipping']";
        string txtContent26Xpath = "//input[@class='hs-button primary large']";
        //string txtContent27Xpath = "//a[contains(.,'Privacy Policy')]";

        string Image1Xpath = "//img[@alt='Coverage Icon']";
        string Image2Xpath = "//img[@alt='Shipping Icon']";
        string Image3Xpath = "//img[@alt='Money Icon']";







        Pawnbrokers_D_V pawnbrokers_D_V = new Pawnbrokers_D_V();
        public Pawnbrokers_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtHeaderPawnbrokers1Xpath);
            VerifyUIElementIsDisplayed(txtContent1Xpath);
            VerifyUIElementIsDisplayed(txtContent2Xpath);
            VerifyUIElementIsDisplayed(txtContent3Xpath);
            VerifyUIElementIsDisplayed(txtContent4Xpath);
            VerifyUIElementIsDisplayed(txtContent5Xpath);
            VerifyUIElementIsDisplayed(txtContent6Xpath);
            VerifyUIElementIsDisplayed(txtContent7Xpath);
            VerifyUIElementIsDisplayed(txtContent8Xpath);
            VerifyUIElementIsDisplayed(txtContent8_1Xpath);
            VerifyUIElementIsDisplayed(txtContent9Xpath);
            VerifyUIElementIsDisplayed(txtContent10Xpath);
            VerifyUIElementIsDisplayed(Image1Xpath);
            VerifyUIElementIsDisplayed(Image2Xpath);
            VerifyUIElementIsDisplayed(Image3Xpath);






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

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
            VerifyUIElementIsDisplayed(txtHeaderPawnbrokers2Xpath);
        }

        public void verifyPawnbrokers()
        {
            verifyNavBar();
            //verifyFooter();

            string HeaderPawnbrokers1 = driver.FindElement(By.XPath(txtHeaderPawnbrokers1Xpath)).Text;
            Assert.AreEqual(HeaderPawnbrokers1.ToLower().Trim(), pawnbrokers_D_V.txtHeaderPawnbrokers1.ToLower().Trim(), "The Text doesn't match");

            string HeaderPawnbrokers2 = driver.FindElement(By.XPath(txtHeaderPawnbrokers2Xpath)).Text;
            Assert.AreEqual(HeaderPawnbrokers2.ToLower().Trim(), pawnbrokers_D_V.txtHeaderPawnbrokers2.ToLower().Trim(), "The Text doesn't match");

            string txtContent1 = driver.FindElement(By.XPath(txtContent1Xpath)).Text;
            Assert.AreEqual(txtContent1.ToLower().Trim(), pawnbrokers_D_V.txtContent1.ToLower().Trim(), "The Text doesn't match");

            string txtContent2 = driver.FindElement(By.XPath(txtContent2Xpath)).Text;
            Assert.AreEqual(txtContent2.ToLower().Trim(), pawnbrokers_D_V.txtContent2.ToLower().Trim(), "The Text doesn't match");

            string txtContent3 = driver.FindElement(By.XPath(txtContent3Xpath)).Text;
            Assert.AreEqual(txtContent3.ToLower().Trim(), pawnbrokers_D_V.txtContent3.ToLower().Trim(), "The Text doesn't match");

            string txtContent4 = driver.FindElement(By.XPath(txtContent4Xpath)).Text;
            Assert.AreEqual(txtContent4.ToLower().Trim(), pawnbrokers_D_V.txtContent4.ToLower().Trim(), "The Text doesn't match");

            string txtContent5 = driver.FindElement(By.XPath(txtContent5Xpath)).Text;
            Assert.AreEqual(txtContent5.ToLower().Trim(), pawnbrokers_D_V.txtContent5.ToLower().Trim(), "The Text doesn't match");

            string txtContent6 = driver.FindElement(By.XPath(txtContent6Xpath)).Text;
            Assert.AreEqual(txtContent6.ToLower().Trim(), pawnbrokers_D_V.txtContent6.ToLower().Trim(), "The Text doesn't match");

            string txtContent7 = driver.FindElement(By.XPath(txtContent7Xpath)).Text;
            Assert.AreEqual(txtContent7.ToLower().Trim(), pawnbrokers_D_V.txtContent7.ToLower().Trim(), "The Text doesn't match");

            string txtContent8 = driver.FindElement(By.XPath(txtContent8Xpath)).Text;
            Assert.AreEqual(txtContent8.ToLower().Trim(), pawnbrokers_D_V.txtContent8.ToLower().Trim(), "The Text doesn't match");

            string txtContent8_1 = driver.FindElement(By.XPath(txtContent8_1Xpath)).Text;
            Assert.AreEqual(txtContent8_1.ToLower().Trim(), pawnbrokers_D_V.txtContent8_1.ToLower().Trim(), "The Text doesn't match");

            string txtContent9 = driver.FindElement(By.XPath(txtContent9Xpath)).Text;
            Assert.AreEqual(txtContent9.ToLower().Trim(), pawnbrokers_D_V.txtContent9.ToLower().Trim(), "The Text doesn't match");

            string txtContent10 = driver.FindElement(By.XPath(txtContent10Xpath)).Text;
            Assert.AreEqual(txtContent10.ToLower().Trim(), pawnbrokers_D_V.txtContent10.ToLower().Trim(), "The Text doesn't match");

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='hs-form-iframe-0']")));

            VerifyUIElementIsDisplayed(txtContent11Xpath);
            VerifyUIElementIsDisplayed(txtContent12Xpath);
            VerifyUIElementIsDisplayed(txtContent13Xpath);
            VerifyUIElementIsDisplayed(txtContent14Xpath);
            VerifyUIElementIsDisplayed(txtContent15Xpath);
            VerifyUIElementIsDisplayed(txtContent16Xpath);
            VerifyUIElementIsDisplayed(txtContent17Xpath);
            VerifyUIElementIsDisplayed(txtContent18Xpath);
            VerifyUIElementIsDisplayed(txtContent19Xpath);
            VerifyUIElementIsDisplayed(txtContent20Xpath);
            VerifyUIElementIsDisplayed(txtContent21Xpath);
            VerifyUIElementIsDisplayed(txtContent22Xpath);
            VerifyUIElementIsDisplayed(txtContent23Xpath);
            VerifyUIElementIsDisplayed(txtContent24Xpath);
            VerifyUIElementIsDisplayed(txtContent25Xpath);
            VerifyUIElementIsDisplayed(txtContent26Xpath);
            //VerifyUIElementIsDisplayed(txtContent27Xpath);

            string txtContent11 = driver.FindElement(By.XPath(txtContent11Xpath)).Text;
            Assert.AreEqual(txtContent11.ToLower().Trim(), pawnbrokers_D_V.txtContent11.ToLower().Trim(), "The Text doesn't match");

            string txtContent12 = driver.FindElement(By.XPath(txtContent12Xpath)).Text;
            Assert.AreEqual(txtContent12.ToLower().Trim(), pawnbrokers_D_V.txtContent12.ToLower().Trim(), "The Text doesn't match");

            string txtContent13 = driver.FindElement(By.XPath(txtContent13Xpath)).Text;
            Assert.AreEqual(txtContent13.ToLower().Trim(), pawnbrokers_D_V.txtContent13.ToLower().Trim(), "The Text doesn't match");

            string txtContent14 = driver.FindElement(By.XPath(txtContent14Xpath)).Text;
            Assert.AreEqual(txtContent14.ToLower().Trim(), pawnbrokers_D_V.txtContent14.ToLower().Trim(), "The Text doesn't match");

            string txtContent15 = driver.FindElement(By.XPath(txtContent15Xpath)).Text;
            Assert.AreEqual(txtContent15.ToLower().Trim(), pawnbrokers_D_V.txtContent15.ToLower().Trim(), "The Text doesn't match");

            string txtContent16 = driver.FindElement(By.XPath(txtContent16Xpath)).Text;
            Assert.AreEqual(txtContent16.ToLower().Trim(), pawnbrokers_D_V.txtContent16.ToLower().Trim(), "The Text doesn't match");

            string txtContent17 = driver.FindElement(By.XPath(txtContent17Xpath)).Text;
            Assert.AreEqual(txtContent17.ToLower().Trim(), pawnbrokers_D_V.txtContent17.ToLower().Trim(), "The Text doesn't match");

            string txtContent18 = driver.FindElement(By.XPath(txtContent18Xpath)).Text;
            Assert.AreEqual(txtContent18.ToLower().Trim(), pawnbrokers_D_V.txtContent18.ToLower().Trim(), "The Text doesn't match");

            string txtContent19 = driver.FindElement(By.XPath(txtContent19Xpath)).Text;
            Assert.AreEqual(txtContent19.ToLower().Trim(), pawnbrokers_D_V.txtContent19.ToLower().Trim(), "The Text doesn't match");

            string txtContent20 = driver.FindElement(By.XPath(txtContent20Xpath)).Text;
            Assert.AreEqual(txtContent20.ToLower().Trim(), pawnbrokers_D_V.txtContent20.ToLower().Trim(), "The Text doesn't match");

            string txtContent21 = driver.FindElement(By.XPath(txtContent21Xpath)).Text;
            Assert.AreEqual(txtContent21.ToLower().Trim(), pawnbrokers_D_V.txtContent21.ToLower().Trim(), "The Text doesn't match");

            string txtContent22 = driver.FindElement(By.XPath(txtContent22Xpath)).Text;
            Assert.AreEqual(txtContent22.ToLower().Trim(), pawnbrokers_D_V.txtContent22.ToLower().Trim(), "The Text doesn't match");

            string txtContent23 = driver.FindElement(By.XPath(txtContent23Xpath)).Text;
            Assert.AreEqual(txtContent23.ToLower().Trim(), pawnbrokers_D_V.txtContent23.ToLower().Trim(), "The Text doesn't match");

            string txtContent24 = driver.FindElement(By.XPath(txtContent24Xpath)).Text;
            Assert.AreEqual(txtContent24.ToLower().Trim(), pawnbrokers_D_V.txtContent24.ToLower().Trim(), "The Text doesn't match");

            string txtContent25 = driver.FindElement(By.XPath(txtContent25Xpath)).Text;
            Assert.AreEqual(txtContent25.ToLower().Trim(), pawnbrokers_D_V.txtContent25.ToLower().Trim(), "The Text doesn't match");

            string txtContent26 = driver.FindElement(By.XPath(txtContent26Xpath)).GetAttribute("value");
            Assert.AreEqual(txtContent26.ToLower().Trim(), pawnbrokers_D_V.txtContent26.ToLower().Trim(), "The Text doesn't match");

            //string txtContent27 = driver.FindElement(By.XPath(txtContent27Xpath)).Text;
            //Assert.AreEqual(txtContent27.ToLower().Trim(), pawnbrokers_D_V.txtContent27.ToLower().Trim(), "The Text doesn't match");


        }
    }
}

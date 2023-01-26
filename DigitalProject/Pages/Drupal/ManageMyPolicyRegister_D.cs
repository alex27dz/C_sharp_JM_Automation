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
    public class ManageMyPolicyRegister_D : Page
    {
        //txtHeader
        public string txtHeader1Xpath = "//a[@id='policyholder-login']";
        public string txtHeader2Xpath = "//a[@id='agent-login']";

        //txtHeaderRibbon
        public string txtHeaderRibbon1Xpath = "//a[text()='Personal Jewelry Insurance']";
        public string txtHeaderRibbon2Xpath = "//a[text()='Business Jewelry Insurance']";
        public string txtHeaderRibbon3Xpath = "//a[text()='About Us']";
        public string txtHeaderRibbon4Xpath = "//a[text()='Careers']";
        public string txtHeaderRibbon5Xpath = "//a[text()='Contact Us']";
        public string txtHeaderRibbon6Xpath = "//a[text()='JM University']";

        //Main Contant
        public string txtRegister2Xpath = "//div[@id='wizard-step-1']";
        public string txtRegister3Xpath = "//div[@id='wizard-step-2']";
        public string txtRegister4Xpath = "//div[@id='wizard-step-3']";
        public string txtRegister5Xpath = "//h2[contains(text(),'Register for Online Policy Access')]";
        public string txtRegister6Xpath = "//p[contains(text(),'Already registered?')]";
        public string txtRegister7Xpath = "//h2[text()='Policy Information']";
        public string txtRegister8Xpath = "//td[@class='register-instruction']";
        public string txtRegister9Xpath = "//label[contains(text(),'Account or Policy Number')]";
        public string txtRegister10Xpath = "//label[text()='First Name']";
        public string txtRegister11Xpath = "//label[text()='Last Name']";
        public string txtRegister12Xpath = "//label[text()='Residence Zip/Postal Code']";
        public string txtRegister13Xpath = "//input[@id='register_submit']";


        //Footer
        public string txtFooter1Xpath = "//a[text()='Privacy Policy']";
        public string txtFooter2Xpath = "//a[text()='Better Business Bureau®']";
        public string txtFooter3Xpath = "//a[text()='Terms of Use']";
        public string txtFooter4Xpath = "//p[contains(.,'© 2020 Jewelers Mutual Group. All Rights Reserved.')]";
        public string txtFooter5Xpath = "//span[@class='fn org']";
        public string txtFooter6Xpath = "//span[@class='street-address']";
        public string txtFooter7Xpath = "//span[@class='locality']";
        public string txtFooter8Xpath = "//span[@class='region']";
        public string txtFooter9Xpath = "//span[@class='postal-code']";
        public string txtFooter10Xpath = "//div[.='Phone: 888-884-2424']";

        ManageMyPolicy_D_v ManageMyPolicy_D_v = new ManageMyPolicy_D_v();
        public ManageMyPolicyRegister_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }
        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
            VerifyUIElementIsDisplayed(txtHeader1Xpath);
        }
        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtHeader1Xpath);
            VerifyUIElementIsDisplayed(txtHeader2Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon1Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon2Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon3Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon4Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon5Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon6Xpath);
            VerifyUIElementIsDisplayed(txtRegister2Xpath);
            VerifyUIElementIsDisplayed(txtRegister3Xpath);
            VerifyUIElementIsDisplayed(txtRegister4Xpath);
            VerifyUIElementIsDisplayed(txtRegister5Xpath);
            VerifyUIElementIsDisplayed(txtRegister6Xpath);
            VerifyUIElementIsDisplayed(txtRegister7Xpath);
            VerifyUIElementIsDisplayed(txtRegister8Xpath);
            VerifyUIElementIsDisplayed(txtRegister9Xpath);
            VerifyUIElementIsDisplayed(txtRegister10Xpath);
            VerifyUIElementIsDisplayed(txtRegister11Xpath);
            VerifyUIElementIsDisplayed(txtRegister12Xpath);
            VerifyUIElementIsDisplayed(txtRegister13Xpath);
            VerifyUIElementIsDisplayed(txtFooter1Xpath);
            //VerifyUIElementIsDisplayed(txtFooter2Xpath);
            VerifyUIElementIsDisplayed(txtFooter3Xpath);
            VerifyUIElementIsDisplayed(txtFooter4Xpath);
            VerifyUIElementIsDisplayed(txtFooter5Xpath);
            VerifyUIElementIsDisplayed(txtFooter6Xpath);
            VerifyUIElementIsDisplayed(txtFooter7Xpath);
            VerifyUIElementIsDisplayed(txtFooter8Xpath);
            VerifyUIElementIsDisplayed(txtFooter9Xpath);
            VerifyUIElementIsDisplayed(txtFooter10Xpath);

        }



        public void verifyHeader()
        {
            //Personal
            string txtHeader1 = driver.FindElement(By.XPath(txtHeader1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeader1.ToLower().Trim(), ManageMyPolicy_D_v.txtHeader1.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeader2 = driver.FindElement(By.XPath(txtHeader2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeader2.ToLower().Trim(), ManageMyPolicy_D_v.txtHeader2.ToLower().Trim(), "The Text doesn't match");

        }



        public void verifyHeaderRibbon()
        {
            //Personal
            string txtHeaderRibbon1 = driver.FindElement(By.XPath(txtHeaderRibbon1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon1.ToLower().Trim(), ManageMyPolicy_D_v.txtHeaderRibbon1.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon2 = driver.FindElement(By.XPath(txtHeaderRibbon2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon2.ToLower().Trim(), ManageMyPolicy_D_v.txtHeaderRibbon2.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon3 = driver.FindElement(By.XPath(txtHeaderRibbon3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon3.ToLower().Trim(), ManageMyPolicy_D_v.txtHeaderRibbon3.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon4 = driver.FindElement(By.XPath(txtHeaderRibbon4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon4.ToLower().Trim(), ManageMyPolicy_D_v.txtHeaderRibbon4.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon5 = driver.FindElement(By.XPath(txtHeaderRibbon5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon5.ToLower().Trim(), ManageMyPolicy_D_v.txtHeaderRibbon5.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon6 = driver.FindElement(By.XPath(txtHeaderRibbon6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon6.ToLower().Trim(), ManageMyPolicy_D_v.txtHeaderRibbon6.ToLower().Trim(), "The Text doesn't match");

        }



        public void verifyMainContent()
        {
            Console.WriteLine("value is");
            //Personal
            string txtRegister2 = driver.FindElement(By.XPath(txtRegister2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister2.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister2.ToLower().Trim(), "The Text doesn't match");

            string txtRegister3 = driver.FindElement(By.XPath(txtRegister3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister3.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister3.ToLower().Trim(), "The Text doesn't match");

            string txtRegister4 = driver.FindElement(By.XPath(txtRegister4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister4.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister4.ToLower().Trim(), "The Text doesn't match");

            string txtRegister5 = driver.FindElement(By.XPath(txtRegister5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister5.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister5.ToLower().Trim(), "The Text doesn't match");

            string txtRegister6 = driver.FindElement(By.XPath(txtRegister6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister6.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister6.ToLower().Trim(), "The Text doesn't match");

            string txtRegister7 = driver.FindElement(By.XPath(txtRegister7Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister7.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister7.ToLower().Trim(), "The Text doesn't match");

            string txtRegister8 = driver.FindElement(By.XPath(txtRegister8Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister8.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister8.ToLower().Trim(), "The Text doesn't match");

            string txtRegister9 = driver.FindElement(By.XPath(txtRegister9Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister9.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister9.ToLower().Trim(), "The Text doesn't match");

            string txtRegister10 = driver.FindElement(By.XPath(txtRegister10Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister10.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister10.ToLower().Trim(), "The Text doesn't match");

            string txtRegister11 = driver.FindElement(By.XPath(txtRegister11Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister11.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister11.ToLower().Trim(), "The Text doesn't match");

            string txtRegister12 = driver.FindElement(By.XPath(txtRegister12Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtRegister12.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister12.ToLower().Trim(), "The Text doesn't match");

            string txtRegister13 = driver.FindElement(By.XPath(txtRegister13Xpath)).GetAttribute("value");
            Assert.AreEqual(txtRegister13.ToLower().Trim(), ManageMyPolicy_D_v.txtRegister13.ToLower().Trim(), "The Text doesn't match");




        }

        public void verifyFooter()
        {
            string txtFooter1 = driver.FindElement(By.XPath(txtFooter1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter1.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter1.ToLower().Trim(), "The Text doesn't match");

            //string txtFooter2 = driver.FindElement(By.XPath(txtFooter2Xpath)).GetAttribute("innerText");
            //Assert.AreEqual(txtFooter2.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter2.ToLower().Trim(), "The Text doesn't match");

            string txtFooter3 = driver.FindElement(By.XPath(txtFooter3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter3.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter3.ToLower().Trim(), "The Text doesn't match");

            string txtFooter4 = driver.FindElement(By.XPath(txtFooter4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter4.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter4.ToLower().Trim(), "The Text doesn't match");

            string txtFooter5 = driver.FindElement(By.XPath(txtFooter5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter5.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter5.ToLower().Trim(), "The Text doesn't match");

            string txtFooter6 = driver.FindElement(By.XPath(txtFooter6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter6.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter6.ToLower().Trim(), "The Text doesn't match");

            string txtFooter7 = driver.FindElement(By.XPath(txtFooter7Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter7.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter7.ToLower().Trim(), "The Text doesn't match");

            string txtFooter8 = driver.FindElement(By.XPath(txtFooter8Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter8.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter8.ToLower().Trim(), "The Text doesn't match");

            string txtFooter9 = driver.FindElement(By.XPath(txtFooter9Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter9.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter9.ToLower().Trim(), "The Text doesn't match");

            string txtFooter10 = driver.FindElement(By.XPath(txtFooter10Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter10.ToLower().Trim(), ManageMyPolicy_D_v.txtFooter10.ToLower().Trim(), "The Text doesn't match");

        }


    }
}

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
    public class AgentPortal_D : Page
    {
        //txtHeader
        public string txtHeader1Xpath = "//a[@id='policyholder-login']";
        public string txtHeader2Xpath = "//a[@id='agent-login']";
        public string txtHeader3Xpath = "//a[@id='Jeweler-login']";

        //txtHeaderRibbon
        public string txtHeaderRibbon1Xpath = "//a[text()='Personal Jewelry Insurance']";
        public string txtHeaderRibbon2Xpath = "//a[text()='Business Jewelry Insurance']";
        public string txtHeaderRibbon3Xpath = "//a[text()='About Us']";
        public string txtHeaderRibbon4Xpath = "//a[text()='Careers']";
        public string txtHeaderRibbon5Xpath = "//a[text()='Contact Us']";
        public string txtHeaderRibbon6Xpath = "//a[text()='JM University']";

        //Main Contant
        public string txtContant1Xpath = "//a[text()='Member Advantages']";
        public string txtContant2Xpath = "//a[text()='Safety & Security']";
        public string txtContant3Xpath = "//a[text()='Industry Partners']";
        public string txtContant4Xpath = "//a[text()='Why a Jewelers Mutual Policy?']";
        public string txtContant5Xpath = "//a[text()='Policyholder Info']";
        public string txtContant6Xpath = "//b[text()='Agent Login']";
        public string txtContant7Xpath = "//a[text()='Forgot password?']";
        public string txtContant8Xpath = "//span[@class='rememberme']";
        public string txtContant9Xpath = "//p[contains(text(),'For technical support, please contact the Jewelers Mutual Sales team between 8:0')]";
        public string txtContant10Xpath = "//p[contains(text(),'First time users should contact their designated Agency Portal Administrator to')]";
        public string txtContant11Xpath = "//p[contains(text(),'CONFIDENTIALITY NOTICE: This information is published for the internal use and d')]";
        public string textboxUsernameXpath = "//input[@id='UserName']";
        public string textboxPasswordXpath = "//input[@id='Password']";
        public string btnLoginXpath = "//input[@id='Password']";

        //Footer
        public string txtFooter1Xpath = "//a[text()='Privacy Policy']";
        public string txtFooter2Xpath = "//a[text()='Better Business Bureau®']";
        public string txtFooter3Xpath = "//a[text()='Terms of Use']";
        public string txtFooter4Xpath = "//p[text()='© 2020 Jewelers Mutual. All rights reserved.']";
        public string txtFooter5Xpath = "//span[@class='fn org']";
        public string txtFooter6Xpath = "//span[@class='street-address']";
        public string txtFooter7Xpath = "//span[@class='locality']";
        public string txtFooter8Xpath = "//span[@class='region']";
        public string txtFooter9Xpath = "//span[@class='postal-code']";
        public string txtFooter10Xpath = "//p[@class='col one-third-col']";

        AgentPortal_D_v AgentPortal_D_v = new AgentPortal_D_v();
        public AgentPortal_D(IWebDriver driver) : base(driver)
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
            Console.WriteLine("text is ");
            VerifyUIElementIsDisplayed(txtHeader1Xpath);
            VerifyUIElementIsDisplayed(txtHeader2Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon1Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon2Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon3Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon4Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon5Xpath);
            VerifyUIElementIsDisplayed(txtHeaderRibbon6Xpath);
            Console.WriteLine("Contant start ");
            VerifyUIElementIsDisplayed(txtContant1Xpath);
            VerifyUIElementIsDisplayed(txtContant2Xpath);
            VerifyUIElementIsDisplayed(txtContant3Xpath);
            VerifyUIElementIsDisplayed(txtContant4Xpath);
            VerifyUIElementIsDisplayed(txtContant5Xpath);
            VerifyUIElementIsDisplayed(txtContant6Xpath);
            VerifyUIElementIsDisplayed(txtContant7Xpath);
            VerifyUIElementIsDisplayed(txtContant8Xpath);
            VerifyUIElementIsDisplayed(txtContant9Xpath);
            VerifyUIElementIsDisplayed(txtContant10Xpath);
            VerifyUIElementIsDisplayed(txtContant11Xpath);
            Console.WriteLine("Footer start ");
            VerifyUIElementIsDisplayed(txtFooter1Xpath);
            VerifyUIElementIsDisplayed(txtFooter2Xpath);
            VerifyUIElementIsDisplayed(txtFooter3Xpath);
            VerifyUIElementIsDisplayed(txtFooter4Xpath);
            VerifyUIElementIsDisplayed(txtFooter5Xpath);
            VerifyUIElementIsDisplayed(txtFooter6Xpath);
            VerifyUIElementIsDisplayed(txtFooter7Xpath);
            VerifyUIElementIsDisplayed(txtFooter8Xpath);
            VerifyUIElementIsDisplayed(txtFooter9Xpath);
            VerifyUIElementIsDisplayed(txtFooter10Xpath);

            Console.WriteLine("Image start ");
            VerifyUIElementIsDisplayed(textboxUsernameXpath);
            VerifyUIElementIsDisplayed(textboxPasswordXpath);
            VerifyUIElementIsDisplayed(btnLoginXpath);

        }



        public void verifyHeader()
        {
            //Personal
            string txtHeader1 = driver.FindElement(By.XPath(txtHeader1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeader1.ToLower().Trim(), AgentPortal_D_v.txtHeader1.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeader2 = driver.FindElement(By.XPath(txtHeader2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeader2.ToLower().Trim(), AgentPortal_D_v.txtHeader2.ToLower().Trim(), "The Text doesn't match");

        }



        public void verifyHeaderRibbon()
        {
            //Personal
            string txtHeaderRibbon1 = driver.FindElement(By.XPath(txtHeaderRibbon1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon1.ToLower().Trim(), AgentPortal_D_v.txtHeaderRibbon1.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon2 = driver.FindElement(By.XPath(txtHeaderRibbon2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon2.ToLower().Trim(), AgentPortal_D_v.txtHeaderRibbon2.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon3 = driver.FindElement(By.XPath(txtHeaderRibbon3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon3.ToLower().Trim(), AgentPortal_D_v.txtHeaderRibbon3.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon4 = driver.FindElement(By.XPath(txtHeaderRibbon4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon4.ToLower().Trim(), AgentPortal_D_v.txtHeaderRibbon4.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon5 = driver.FindElement(By.XPath(txtHeaderRibbon5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon5.ToLower().Trim(), AgentPortal_D_v.txtHeaderRibbon5.ToLower().Trim(), "The Text doesn't match");

            //Personal
            string txtHeaderRibbon6 = driver.FindElement(By.XPath(txtHeaderRibbon6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtHeaderRibbon6.ToLower().Trim(), AgentPortal_D_v.txtHeaderRibbon6.ToLower().Trim(), "The Text doesn't match");

        }



        public void verifyMainContent()
        {
            //Personal
            string txtContant1 = driver.FindElement(By.XPath(txtContant1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant1.ToLower().Trim(), AgentPortal_D_v.txtContant1.ToLower().Trim(), "The Text doesn't match");

            string txtContant2 = driver.FindElement(By.XPath(txtContant2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant2.ToLower().Trim(), AgentPortal_D_v.txtContant2.ToLower().Trim(), "The Text doesn't match");

            string txtContant3 = driver.FindElement(By.XPath(txtContant3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant3.ToLower().Trim(), AgentPortal_D_v.txtContant3.ToLower().Trim(), "The Text doesn't match");

            string txtContant4 = driver.FindElement(By.XPath(txtContant4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant4.ToLower().Trim(), AgentPortal_D_v.txtContant4.ToLower().Trim(), "The Text doesn't match");


            string txtContant5 = driver.FindElement(By.XPath(txtContant5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant5.ToLower().Trim(), AgentPortal_D_v.txtContant5.ToLower().Trim(), "The Text doesn't match");

            string txtContant6 = driver.FindElement(By.XPath(txtContant6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant6.ToLower().Trim(), AgentPortal_D_v.txtContant6.ToLower().Trim(), "The Text doesn't match");

            string txtContant7 = driver.FindElement(By.XPath(txtContant7Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant7.ToLower().Trim(), AgentPortal_D_v.txtContant7.ToLower().Trim(), "The Text doesn't match");

            string txtContant8 = driver.FindElement(By.XPath(txtContant8Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant8.ToLower().Trim(), AgentPortal_D_v.txtContant8.ToLower().Trim(), "The Text doesn't match");


            string txtContant9 = driver.FindElement(By.XPath(txtContant9Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant9.ToLower().Trim(), AgentPortal_D_v.txtContant9.ToLower().Trim(), "The Text doesn't match");


            string txtContant10 = driver.FindElement(By.XPath(txtContant10Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant10.ToLower().Trim(), AgentPortal_D_v.txtContant10.ToLower().Trim(), "The Text doesn't match");


            string txtContant11 = driver.FindElement(By.XPath(txtContant11Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtContant11.ToLower().Trim(), AgentPortal_D_v.txtContant11.ToLower().Trim(), "The Text doesn't match");




        }

        public void verifyFooter()
        {
            string txtFooter1 = driver.FindElement(By.XPath(txtFooter1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter1.ToLower().Trim(), AgentPortal_D_v.txtFooter1.ToLower().Trim(), "The Text doesn't match");

            string txtFooter2 = driver.FindElement(By.XPath(txtFooter2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter2.ToLower().Trim(), AgentPortal_D_v.txtFooter2.ToLower().Trim(), "The Text doesn't match");

            string txtFooter3 = driver.FindElement(By.XPath(txtFooter3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter3.ToLower().Trim(), AgentPortal_D_v.txtFooter3.ToLower().Trim(), "The Text doesn't match");

            string txtFooter4 = driver.FindElement(By.XPath(txtFooter4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter4.ToLower().Trim(), AgentPortal_D_v.txtFooter4.ToLower().Trim(), "The Text doesn't match");

            string txtFooter5 = driver.FindElement(By.XPath(txtFooter5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter5.ToLower().Trim(), AgentPortal_D_v.txtFooter5.ToLower().Trim(), "The Text doesn't match");

            string txtFooter6 = driver.FindElement(By.XPath(txtFooter6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter6.ToLower().Trim(), AgentPortal_D_v.txtFooter6.ToLower().Trim(), "The Text doesn't match");

            string txtFooter7 = driver.FindElement(By.XPath(txtFooter7Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter7.ToLower().Trim(), AgentPortal_D_v.txtFooter7.ToLower().Trim(), "The Text doesn't match");

            string txtFooter8 = driver.FindElement(By.XPath(txtFooter8Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter8.ToLower().Trim(), AgentPortal_D_v.txtFooter8.ToLower().Trim(), "The Text doesn't match");

            string txtFooter9 = driver.FindElement(By.XPath(txtFooter9Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter9.ToLower().Trim(), AgentPortal_D_v.txtFooter9.ToLower().Trim(), "The Text doesn't match");

            string txtFooter10 = driver.FindElement(By.XPath(txtFooter10Xpath)).GetAttribute("innerText");
            Assert.AreEqual(txtFooter10.ToLower().Trim(), AgentPortal_D_v.txtFooter10.ToLower().Trim(), "The Text doesn't match");

        }


    }
}

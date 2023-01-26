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
    public class JMUniversity_D : Page
    {
        // Elements  

        // JMUniversity Insurance Page Images


        // Nav Bar                 


        // Footer


        // JM University Header
        string headerJMUXPath = "//h4[text()='JM UNIVERSITY®']";
        string titleToolsXPath = "//h1[text()='The tools you need for your business.']";

        // Here's What You'll Get
        string headerWhatYoullGetXPath = "//h2[contains(text(),'s What You')]";
        string infoWhatYoullGetXPath = "//p[contains(text(),'s preeminent online training resource features educational')]";
        string iconLossXPath = "//img[@alt='staff graphic']";
        string titleLossXPath = "//h4[text()='Loss Prevention Self Audit']";
        string infoLossXPath = "//p[contains(text(),'Identify potential weaknesses in your security procedures and learn how your ent')]";
        string iconDangerXPath = "//img[@alt='lock graphic']";
        string titleDangerXPath = "//h4[text()='Danger on the Road']";
        string infoDangerXPath = "//p[contains(text(),'Learn a comprehensive approach of how to protect yourself - and your property -')]";
        string iconSellingXPath = "//img[@alt='selling with security graphic']";
        string titleSellingXPath = "//h4[text()='Selling with Security']";
        string infoSellingXPath = "//p[contains(text(),'Follow a step-by-step guide for protecting your merchandise while interacting wi')]";

        //Enroll
        string headerEnrollXPath = "//h2[text()='Enroll']";
        string btnCurrentXPath = "//a[text()='CURRENT USER? SIGN IN']";
        string btnNewXPath = "//a[text()='NEW USER? REGISTER TODAY']";

        JMUniversity_D_V JMUniversity_D_V = new JMUniversity_D_V();
        public JMUniversity_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify

            VerifyUIElementIsDisplayed(headerJMUXPath);
            VerifyUIElementIsDisplayed(titleToolsXPath);
            VerifyUIElementIsDisplayed(headerWhatYoullGetXPath);
            VerifyUIElementIsDisplayed(infoWhatYoullGetXPath);
            VerifyUIElementIsDisplayed(iconLossXPath);
            VerifyUIElementIsDisplayed(titleLossXPath);
            VerifyUIElementIsDisplayed(infoLossXPath);
            VerifyUIElementIsDisplayed(iconDangerXPath);
            VerifyUIElementIsDisplayed(titleDangerXPath);
            VerifyUIElementIsDisplayed(infoDangerXPath);
            VerifyUIElementIsDisplayed(iconSellingXPath);
            VerifyUIElementIsDisplayed(titleSellingXPath);
            VerifyUIElementIsDisplayed(infoSellingXPath);
            VerifyUIElementIsDisplayed(headerEnrollXPath);
            VerifyUIElementIsDisplayed(btnCurrentXPath);
            VerifyUIElementIsDisplayed(btnNewXPath);
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

        public void verifyJMU()
        {
            // JM University Header
            string HeaderJMU = driver.FindElement(By.XPath(headerJMUXPath)).Text;
            Assert.AreEqual(HeaderJMU, JMUniversity_D_V.txtHeaderJMU, "The Text doesn't match");

            string TitleTools = driver.FindElement(By.XPath(titleToolsXPath)).Text;
            Assert.AreEqual(TitleTools, JMUniversity_D_V.txtTitleTools, "The Text doesn't match");

        }

        public void verifyWhatYoullGet()
        {
            // Here's What You'll Get
            string HeaderWhatYoullGet = driver.FindElement(By.XPath(headerWhatYoullGetXPath)).Text;
            Assert.AreEqual(HeaderWhatYoullGet, JMUniversity_D_V.txtHeaderWhatYoullGet, "The Text doesn't match");

            string InfoWhatYoullGet = driver.FindElement(By.XPath(infoWhatYoullGetXPath)).Text;
            Assert.AreEqual(InfoWhatYoullGet, JMUniversity_D_V.txtInfoWhatYoullGet, "The Text doesn't match");

            string TitleLoss = driver.FindElement(By.XPath(titleLossXPath)).Text;
            Assert.AreEqual(TitleLoss, JMUniversity_D_V.txtTitleLoss, "The Text doesn't match");

            string InfoLoss = driver.FindElement(By.XPath(infoLossXPath)).Text;
            Assert.AreEqual(InfoLoss, JMUniversity_D_V.txttxtInfoLoss, "The Text doesn't match");

            string TitleDanger = driver.FindElement(By.XPath(titleDangerXPath)).Text;
            Assert.AreEqual(TitleDanger, JMUniversity_D_V.txtTitleDanger, "The Text doesn't match");

            string InfoDanger = driver.FindElement(By.XPath(infoDangerXPath)).Text;
            Assert.AreEqual(InfoDanger, JMUniversity_D_V.txttxtInfoDanger, "The Text doesn't match");

            string TitleSelling = driver.FindElement(By.XPath(titleSellingXPath)).Text;
            Assert.AreEqual(TitleSelling, JMUniversity_D_V.txtTitleSelling, "The Text doesn't match");

            string InfoSelling = driver.FindElement(By.XPath(infoSellingXPath)).Text;
            Assert.AreEqual(InfoSelling, JMUniversity_D_V.txtInfoSelling, "The Text doesn't match");

        }

        public void verifyEnroll()
        {
            //Enroll
            string HeaderEnroll = driver.FindElement(By.XPath(headerEnrollXPath)).Text;
            Assert.AreEqual(HeaderEnroll, JMUniversity_D_V.txtHeaderEnroll, "The Text doesn't match");

            string BtnCurrent = driver.FindElement(By.XPath(btnCurrentXPath)).Text;
            Assert.AreEqual(BtnCurrent, JMUniversity_D_V.btnCurrent, "The Text doesn't match");

            string BtnNew = driver.FindElement(By.XPath(btnNewXPath)).Text;
            Assert.AreEqual(BtnNew, JMUniversity_D_V.btnNew, "The Text doesn't match");

        }

        public void verifyJMUniversityPageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyJMU();
            verifyWhatYoullGet();
            verifyEnroll();
        }
    }
}

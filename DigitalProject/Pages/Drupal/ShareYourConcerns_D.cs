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
    public class ShareYourConcerns_D : Page
    {
        // Elements  

        // Share Your Concerns Page Images




        // Share Your Concerns Header
        string headerShareYourConcernsCSS = "//h1[text()='Share Your Concerns']";
        string titleShareYourConcernsCSS = "//h2[text()='Share Your Concerns']";
        string infoShareYourConcernsCSS = "//p[contains(text(),'Your satisfaction is very important to us. Jewelers Mutual Insurance Company ')]";

        // STEP ONE: Contact Us 
        string titleStepOneCSS = "//h4[text()='STEP ONE: Contact Us']";
        string infoStepOneCSS = "//p[contains(text(),'In most circumstances, a complaint can be resolved by simply sharing it with the')]";

        //STEP TWO: Contact the Consumer Affairs Office at Jewelers Mutual
        string titleStepTwoCSS = "//h4[text()='STEP TWO: Contact the Consumer Affairs Office at Jewelers Mutual']";
        string infoStepTwo1CSS = "//p[contains(text(),'If you are not satisfied with the outcome of the previous step, bring your compl')]";
        string infoStepTwo2CSS = "//p[4]";

        //STEP THREE: Contact an Outside Organization for Assistance
        string titleStepThreeCSS = "//h4[text()='STEP THREE: Contact an Outside Organization for Assistance']";
        string infoStepThree1CSS = "//p[contains(text(),'If we have been unable to resolve your complaint to your satisfaction and you wi')]";
        string infoUSACSS = "//li[contains(text(),'Refer to your policy documents for contact information for yo')]";
        string infoUSA1CSS = "//li[contains(text(),'Contact the Financial Consumer Agency of Canada (FCAC), t')]";
        string linkCanada2CSS = "//a[text()='www.fcac-acfc.gc.ca']";
        string linkCanada3CSS = "//a[text()='www.giocanada.org']";
        string linkCanada4CSS = "//a[text()='www.lautorite.qc.ca']";

        ShareYourConcerns_D_V ShareYourConcerns_D_V = new ShareYourConcerns_D_V();
        public ShareYourConcerns_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify

            VerifyUIElementIsDisplayed(headerShareYourConcernsCSS);
            VerifyUIElementIsDisplayed(titleShareYourConcernsCSS);
            VerifyUIElementIsDisplayed(infoShareYourConcernsCSS);
            VerifyUIElementIsDisplayed(titleStepOneCSS);
            VerifyUIElementIsDisplayed(infoStepOneCSS);
            VerifyUIElementIsDisplayed(titleStepTwoCSS);
            VerifyUIElementIsDisplayed(infoStepTwo1CSS);
            VerifyUIElementIsDisplayed(infoStepTwo2CSS);
            VerifyUIElementIsDisplayed(titleStepThreeCSS);
            VerifyUIElementIsDisplayed(infoStepThree1CSS);
            VerifyUIElementIsDisplayed(infoUSACSS);
            VerifyUIElementIsDisplayed(infoUSA1CSS);
            VerifyUIElementIsDisplayed(linkCanada2CSS);
            VerifyUIElementIsDisplayed(linkCanada3CSS);
            VerifyUIElementIsDisplayed(linkCanada4CSS);
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

        public void verifyShareConcerns()
        {
            // Share Your Concerns Header
            string HeaderShareYourConcerns = driver.FindElement(By.XPath(headerShareYourConcernsCSS)).Text;
            Assert.AreEqual(HeaderShareYourConcerns.ToLower().Trim(), ShareYourConcerns_D_V.txtHeaderShareYourConcerns.ToLower().Trim(), "The Text doesn't match");

            string TitleShareYourConcerns = driver.FindElement(By.XPath(titleShareYourConcernsCSS)).Text;
            Assert.AreEqual(TitleShareYourConcerns.ToLower().Trim(), ShareYourConcerns_D_V.txtTitleShareYourConcerns.ToLower().Trim(), "The Text doesn't match");

            string InfoShareYourConcerns = driver.FindElement(By.XPath(infoShareYourConcernsCSS)).Text;
            Assert.AreEqual(InfoShareYourConcerns.ToLower().Trim(), ShareYourConcerns_D_V.txtInfoShareYourConcerns.ToLower().Trim(), "The Text doesn't match");
            Console.WriteLine(" Share Your Concerns Header");
        }

        public void verifyStepOne()
        {
            // STEP ONE: Contact Us 
            string TitleStepOne = driver.FindElement(By.XPath(titleStepOneCSS)).Text;
            Assert.AreEqual(TitleStepOne.ToLower().Trim(), ShareYourConcerns_D_V.txtTitleStepOne.ToLower().Trim(), "The Text doesn't match");

            string InfoStepOne = driver.FindElement(By.XPath(infoStepOneCSS)).Text;
            Assert.AreEqual(InfoStepOne.ToLower().Trim(), ShareYourConcerns_D_V.txtInfoStepOne.ToLower().Trim(), "The Text doesn't match");
            Console.WriteLine("STEP ONE: Contact Us ");
        }

        public void verifyStepTwo()
        {
            //STEP TWO: Contact the Consumer Affairs Office at Jewelers Mutual
            string TitleStepTwo = driver.FindElement(By.XPath(titleStepTwoCSS)).Text;
            Assert.AreEqual(TitleStepTwo.ToLower().Trim(), ShareYourConcerns_D_V.txtTitleStepTwo.ToLower().Trim(), "The Text doesn't match");

            string InfoStepTwo1 = driver.FindElement(By.XPath(infoStepTwo1CSS)).Text;
            Assert.AreEqual(InfoStepTwo1.ToLower().Trim(), ShareYourConcerns_D_V.txtInfoStepTwo1.ToLower().Trim(), "The Text doesn't match");

            string InfoStepTwo2 = driver.FindElement(By.XPath(infoStepTwo2CSS)).Text;
            InfoStepTwo2 = InfoStepTwo2.Replace(System.Environment.NewLine, "");
            Assert.AreEqual(InfoStepTwo2.ToLower().Trim(), ShareYourConcerns_D_V.txtInfoStepTwo2.ToLower().Trim(), "The Text doesn't match");
            Console.WriteLine("STEP TWO: Contact the Consumer Affairs Office at Jewelers Mutual");
        }

        public void verifyStepThree()
        {
            //STEP THREE: Contact an Outside Organization for Assistance
            string TitleStepThree = driver.FindElement(By.XPath(titleStepThreeCSS)).Text;
            Assert.AreEqual(TitleStepThree.ToLower().Trim(), ShareYourConcerns_D_V.txtTitleStepThree.ToLower().Trim(), "The Text doesn't match");

            string InfoStepThree1 = driver.FindElement(By.XPath(infoStepThree1CSS)).Text;
            Assert.AreEqual(InfoStepThree1.ToLower().Trim(), ShareYourConcerns_D_V.txtInfoStepThree1.ToLower().Trim(), "The Text doesn't match");

            string InfoUSA = driver.FindElement(By.XPath(infoUSACSS)).Text;
            Console.WriteLine("valus is " + InfoUSA);
            Assert.AreEqual(InfoUSA.ToLower().Trim(), ShareYourConcerns_D_V.txtInfoUSA.ToLower().Trim(), "The Text doesn't match");

            string InfoUSA1 = driver.FindElement(By.XPath(infoUSA1CSS)).Text;
            InfoUSA1 = InfoUSA1.Replace(System.Environment.NewLine, "");
            Console.WriteLine("valus is " + InfoUSA1);
            Assert.AreEqual(InfoUSA1.ToLower().Trim(), ShareYourConcerns_D_V.txtInfoCanada.ToLower().Trim(), "The Text doesn't match");

            string LinkCanada2 = driver.FindElement(By.XPath(linkCanada2CSS)).Text;
            Assert.AreEqual(LinkCanada2.ToLower().Trim(), ShareYourConcerns_D_V.hrefCanada2.ToLower().Trim(), "The Text doesn't match");

            string LinkCanada3 = driver.FindElement(By.XPath(linkCanada3CSS)).Text;
            Assert.AreEqual(LinkCanada3.ToLower().Trim(), ShareYourConcerns_D_V.hrefCanada3.ToLower().Trim(), "The Text doesn't match");

            string LinkCanada4 = driver.FindElement(By.XPath(linkCanada4CSS)).Text;
            Assert.AreEqual(LinkCanada4.ToLower().Trim(), ShareYourConcerns_D_V.hrefCanada4.ToLower().Trim(), "The Text doesn't match");
            Console.WriteLine("STEP THREE: Contact an Outside Organization for Assistance");
        }

        public void verifyShareYourConcernsPageContent()
        {
            verifyNavBar();
            verifyFooter();
            VerifyPage();
            verifyShareConcerns();
            verifyStepOne();
            verifyStepTwo();
            verifyStepThree();
        }



    }
}

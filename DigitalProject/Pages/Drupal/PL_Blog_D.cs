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
    public class PL_Blog_D : Page
    {

        public string txtHeaderPLBlog1Xpath = "//h4[text()='FOR SMART, STYLISH JEWELRY LOVERS EVERYWHERE']";
        public string txtHeaderPLBlog2Xpath = "//h1[text()='The Jewelry Box Blog']";

        PL_Blog_D_V PL_Blog_D_V = new PL_Blog_D_V();
        public PL_Blog_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {
            System.Threading.Thread.Sleep(3000);
            VerifyUIElementIsDisplayed(txtHeaderPLBlog1Xpath);
            //VerifyUIElementIsDisplayed(txtHeaderPLBlog2Xpath);
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
            VerifyUIElementIsDisplayed(txtHeaderPLBlog1Xpath);
        }

        public void verifyPLBlog()

        {
            string txtHeaderPLBlog1 = driver.FindElement(By.XPath(txtHeaderPLBlog1Xpath)).Text;
            Assert.AreEqual(txtHeaderPLBlog1.ToLower().Trim(), PL_Blog_D_V.txtHeaderPLBlog1.ToLower().Trim(), "The Text doesn't match");

            string txtHeaderPLBlog2 = driver.FindElement(By.XPath(txtHeaderPLBlog2Xpath)).Text;
            Assert.AreEqual(txtHeaderPLBlog2.ToLower().Trim(), PL_Blog_D_V.txtHeaderPLBlog2.ToLower().Trim(), "The Text doesn't match");

        }

    }
}

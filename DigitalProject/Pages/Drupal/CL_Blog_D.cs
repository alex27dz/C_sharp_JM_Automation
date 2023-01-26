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
    public class CL_Blog_D : Page
    {

        public string txtHeaderCLBlog1Xpath = "//h4[text()='HELPING JEWELERS BE SAFE, SECURE, AND SUCCESSFUL']";
        public string txtHeaderCLBlog2Xpath = "//h1[text()='The Clarity Blog']";

        CL_Blog_D_V CL_Blog_D_V = new CL_Blog_D_V();
        public CL_Blog_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtHeaderCLBlog1Xpath);
            VerifyUIElementIsDisplayed(txtHeaderCLBlog2Xpath);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
            VerifyUIElementIsDisplayed(txtHeaderCLBlog1Xpath);
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

        public void verifyCLBlog()

        {
            string txtHeaderCLBlog1 = driver.FindElement(By.XPath(txtHeaderCLBlog1Xpath)).Text;
            Assert.AreEqual(txtHeaderCLBlog1.ToLower().Trim(), CL_Blog_D_V.txtHeaderCLBlog1.ToLower().Trim(), "The Text doesn't match");

            string txtHeaderCLBlog2 = driver.FindElement(By.XPath(txtHeaderCLBlog2Xpath)).Text;
            Assert.AreEqual(txtHeaderCLBlog2.ToLower().Trim(), CL_Blog_D_V.txtHeaderCLBlog2.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyCLBlogPageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyCLBlog();

        }

    }
}

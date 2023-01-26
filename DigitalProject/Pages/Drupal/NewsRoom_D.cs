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
    public class NewsRoom_D : Page
    {
        string jmLogoCSS = "a[title='Home']";
        // Find Your Future Header
        string headerNewsRoomXpath = "//strong[text()='JEWELERS MUTUAL IN THE NEWS']";
        string titleNewsRoomXpath = "//h1[text()='Newsroom']";
        NewsRoom_D_V NewsRoom_D_V = new NewsRoom_D_V();

        public NewsRoom_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }
        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
            VerifyUIElementIsDisplayed(headerNewsRoomXpath);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(headerNewsRoomXpath);
            VerifyUIElementIsDisplayed(titleNewsRoomXpath);
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

        public void verifyNewsRoom()
        {
            //   verifyNavBar();
            //   verifyFooter();
            // JEWELERS MUTUAL IN THE NEWS
            string HeaderNewsRoom = driver.FindElement(By.XPath(headerNewsRoomXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderNewsRoom.ToLower().Trim(), NewsRoom_D_V.txtHeaderNewsRoom.ToLower().Trim(), "The Text doesn't match");

            //Newsroom
            string TitleNewsRoom = driver.FindElement(By.XPath(titleNewsRoomXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleNewsRoom.ToLower().Trim(), NewsRoom_D_V.txtTitleNewsRoom.ToLower().Trim(), "The Text doesn't match");
        }

    }
}

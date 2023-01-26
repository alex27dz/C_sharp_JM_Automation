using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DigitalProject.Pages
{
    public class AboutUs : Page
    {

        string linkAbcCSS = null;

        #region Required
        public AboutUs(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {
              VerifyUIElementIsDisplayed(linkAbcCSS);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA"));
        }

        #endregion


        #region Elements
        string VerifyPageElement = "a[id$ ='p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA']";

        #region Leadership Bios
        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(1) > div:nth-child(3) > div:nth-child(2)")]
        public IWebElement btnScottMurphyDropdown;

        [FindsBy(How = How.CssSelector, Using = ".leadership__bio--is-open > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement ScottMurphyText;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(2) > div:nth-child(3) > div:nth-child(2)")]
        public IWebElement btnMikeAlexanderDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(2) > div:nth-child(3) > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement MikeAlexanderText;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(3) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1)")]
        public IWebElement btnMarkDeveeauxDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(3) > div:nth-child(3) > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement MarkDevereauxText;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(4) > div:nth-child(3) > div:nth-child(2)")]
        public IWebElement btnVickiLindamoodDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(4) > div:nth-child(3) > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement VickiLindamoodText;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(5) > div:nth-child(3) > div:nth-child(2)")]
        public IWebElement btnBryonNelsonDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(5) > div:nth-child(3) > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement BryonNelsonText;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(6) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1)")]
        public IWebElement btnMichaelPeltoDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(6) > div:nth-child(3) > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement MichaelPeltoText;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(7) > div:nth-child(3) > div:nth-child(2)")]
        public IWebElement btnDylanPlaceDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(7) > div:nth-child(3) > div:nth-child(2)")]
        public IWebElement DylanPlaceText;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(8) > div:nth-child(3) > div:nth-child(2)")]
        public IWebElement btnDavidSextonDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(8) > div:nth-child(3) > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement DavidSextonText;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(9) > div:nth-child(3) > div:nth-child(2)")]
        public IWebElement btnMarkWillsonDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.leadership__officer:nth-child(9) > div:nth-child(3) > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement MarkWillsonText;
        #endregion

        #region Buttons
        [FindsBy(How = How.Id, Using = "p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA")]
        public IWebElement btnSeeIfYourOrganazationIsElegible;

        [FindsBy(How = How.CssSelector, Using = "#p_lt_ctl02_pageplaceholder_p_lt_ctl04_JewelersMutual_Story_repItems_ctl00_divItem > div:nth-child(2) > a:nth-child(3)")]
        public IWebElement btnViewOurAnnualReport;

        [FindsBy(How = How.CssSelector, Using = "#p_lt_ctl02_pageplaceholder_p_lt_ctl04_JewelersMutual_Story_repItems_ctl01_divItem > div:nth-child(2) > a:nth-child(3)")]
        public IWebElement btnScheduleAVisit;

        [FindsBy(How = How.CssSelector, Using = "#p_lt_ctl02_pageplaceholder_p_lt_ctl04_JewelersMutual_Story_repItems_ctl02_divItem > div:nth-child(2) > a:nth-child(3)")]
        public IWebElement btnWorkWithUs;
        #endregion

        #endregion


        #region Methods

        public void GoToAboutUsPage()
        {
            GoToUrl("about-us");
        }

        #region Leadership bios
        public void verifyLeadershipBios()
        {
            btnScottMurphyDropdown.Click();
            string smt = ScottMurphyText.Text;
            Console.WriteLine("Scott Murphy text =  " + ScottMurphyText.Text + "Expected Scott Murphy Text" + "");
            Assert.IsTrue(smt.Contains("Scott Murphy is the president and CEO of Jewelers Mutual Insurance Company."));

            btnMikeAlexanderDropdown.Click();
            string ma = MikeAlexanderText.Text;
            Console.WriteLine("Mike Alexander text =  " + MikeAlexanderText.Text + " supposed to contain = " + "Mike Alexander is the Senior Vice President of Commercial Lines at Jewelers Mutual Insurance Company.");
            Assert.IsTrue(ma.Contains("Mike Alexander is the Senior Vice President of Commercial Lines at Jewelers Mutual Insurance Company."), "Mike Alexander text did not match");

            btnMarkDeveeauxDropdown.Click();
            string md = MarkDevereauxText.Text;
            Assert.IsTrue(md.Contains("Mark Devereaux is Vice President of Sales at Jewelers Mutual Insurance Company."), "Mark Deveeaux text did not match");

            btnVickiLindamoodDropdown.Click();
            string vl = VickiLindamoodText.Text;
            Assert.IsTrue(vl.Contains("Vicki Lindamood is the chief human resources officer at Jewelers Mutual Insurance Company."), "VickiLindamood text did not match");

            btnBryonNelsonDropdown.Click();
            string bl = BryonNelsonText.Text;
            Assert.IsTrue(bl.Contains("Bryon Nelson is the vice president of product and risk management at Jewelers Mutual Insurance Company."), "Byron Nelson text did not match" + bl);

            btnMichaelPeltoDropdown.Click();
            string mp = MichaelPeltoText.Text;
            Assert.IsTrue(mp.Contains("Michael Pelto is the Chief Information Officer at Jewelers Mutual Insurance Company."), "Michael Pelto Text did not match" + mp);


            btnDylanPlaceDropdown.Click();
            //  string dp = DylanPlaceText.Text;
            //  Assert.IsTrue(dp.Contains("Dylan Place is the vice president of Actuary Services at Jewelers Mutual Insurance Company."), "Dylan Place text did not match " + dp);

            btnDavidSextonDropdown.Click();
            string ds = DavidSextonText.Text;
            Assert.IsTrue(ds.Contains("David Sexton, CPCU, is vice president of loss prevention consulting at Jewelers Mutual Insurance Company."), "David Sexton text did not match" + ds);

            btnMarkWillsonDropdown.Click();
            string mw = MarkWillsonText.Text;
            Assert.IsTrue(mw.Contains("Mark Willson is general counsel and corporate secretary at Jewelers Mutual Insurance Company."), "Mark Willson text did not match" + mw);
        }

        #endregion
        public void VerifySeeIfButtonsOnAboutUsPageWork()
        {
            IsElementVisible(btnSeeIfYourOrganazationIsElegible);
            string siy = btnSeeIfYourOrganazationIsElegible.GetAttribute("href");
            Assert.IsTrue(siy.Contains("https://www.cffoxvalley.org/grants/jewelers-mutual/"), "Actual Url = " + siy);

            string voa = btnViewOurAnnualReport.GetAttribute("href");
            Assert.IsTrue(voa.Contains("https://jewelersmutual.uberflip.com/i/817452-jewelers-mutual-2016-annual-report"), "Actual Url = " + voa);

            string sav = btnScheduleAVisit.GetAttribute("href");
            Assert.IsTrue(sav.Contains("mailto:gallery@jminsure.com"), "Actual Url = " + sav);

            string wwu = btnWorkWithUs.GetAttribute("href");
            Assert.IsTrue(wwu.Contains("/careers"), "Actual Url = " + wwu);


        }

        public void CheckForBrokenImages()
        {
            AboutUsCheckForBrokenImages(driver);
            
        }



        public void TakeAScreenShotOfEntirePage()
        {

            backGround.Click();
            backGround.SendKeys(Keys.Alt + Keys.Shift + "p");

        }


        #endregion


        #region Temp
        [FindsBy(How = How.Id, Using = "p_lt_ctl02_pageplaceholder_p_lt_ctl01_JewelersMutual_Info_lblTitle")]
        public IWebElement backGround;


        public void GoToAboutUsPageInTest()
        {
            string url = "www.test.testjewelersmutual.com/";
            this.driver.Url = url;
        }

        public static void AboutUsCheckForBrokenImages(IWebDriver driver)
        {
            List<IWebElement> images = driver.FindElements(By.CssSelector("img")).ToList();

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            Console.WriteLine("Images Count : {0}", images.Count);

            for (int i = 0; i < images.Count; i++)
            {
                IWebElement currentImage = images[i];

                Boolean imagePresent = (Boolean)(js.ExecuteScript("return arguments[0].complete && typeof arguments[0].naturalWidth != \"undefined\" && arguments[0].naturalWidth > 0", currentImage));

                Console.WriteLine("Image Natural width");
                if (!imagePresent)
                {
                    Assert.Fail("Images not present");
                }
                else
                {
                    Console.WriteLine("Image is Loaded.");
                }
            }
        }

        #endregion

        #region Commoon
        public void GoToUrl(string url2)
        {
            String currentURL = driver.Url;

            int index = currentURL.LastIndexOf(".com/");

            if (index > 0)
                currentURL = currentURL.Remove(currentURL.LastIndexOf(".com/") + 5);

            this.driver.Url = currentURL + url2;
        }
        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed;
        }

        public void CheckImages(IWebDriver driver)
        {
            IList<IWebElement> images;
            images = driver.FindElements(By.TagName("img")).ToList();

            Console.WriteLine("there should be a list of images here" + images);
            for (int i = 0; i < images.Count; i++)
            {

                //  HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(images[i + 6].GetAttribute("href"));
                //         request.Method = "HEAD";

                //bool exists;
                //try
                //{
                //    request.GetResponse();
                //    exists = true;
                //}
                //catch
                //{
                //    exists = false;
                //}

                // Console.WriteLine("Does image exist: " + exists);

                string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();
                string imagename = images[i].GetAttribute("src");
                string shortenedImage = null;
                // HttpWebRequest re = HttpWebRequest.Create();
                //  re = (HttpWebRequest)WebRequest.Create(images[i].GetAttribute("href"));
                // var response = (HttpWebResponse)re.GetResponse();
                // System.Console.WriteLine($"Images: {images[i].GetAttribute("href")} status is : {response.StatusCode}");
                //Assert.IsTrue(imagename.Contains("a"));
                //if (imagename.Contains(".com"))
                shortenedImage = imagename.Substring(imagename.IndexOf(".com") + 4);
                Console.WriteLine("image exension = " + shortenedImage);

                string naturalWidth = images[i].GetAttribute("naturalWidth");
                string naturalHeight = images[i].GetAttribute("naturalHeight");
                string x = images[i].GetAttribute("x");

                Console.WriteLine("Natural Width is: " + naturalWidth);
                Console.WriteLine("X axis :" + x);

                //   re = (HttpWebRequest)WebRequest.Create(images[i].GetAttribute("href"));
            }
        }
    }
    #endregion

}

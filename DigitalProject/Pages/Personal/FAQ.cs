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

namespace DigitalProject.Pages.Personal
{
    public class FAQ : Page
    {
        #region Required
        public FAQ(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {
            //  VerifyUIElementIsDisplayed(VerifyPageElement);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("a[id$ ='p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA"));
        }

        #endregion
        #region Common
        public void GoToUrl(string url2)
        {
            String currentURL = driver.Url;

            int index = currentURL.LastIndexOf(".com/");

            if (index > 0)
                currentURL = currentURL.Remove(currentURL.LastIndexOf(".com/") + 5);

            this.driver.Url = currentURL + url2;
        }


        #endregion
        #region Elements
        string VerifyPageElement = "a[id$ ='p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA']";


        [FindsBy(How = How.CssSelector, Using = ".testimonial__quote")]
        public IWebElement DarrylTestimonial;
        #endregion

        #region Methods

        public void VerifyFAQTestimonial()
        {
            string vft = DarrylTestimonial.Text;
            Assert.IsTrue(vft.Contains("\"Excellent company – reasonable rates, great coverage and prompt and courteous service. Applying is easy and claims service is exactly as advertised…wonderful.\""), "Testimonial text did not match, actual text =" + vft);
        }

        public void GoToFAQPage()
        {
            GoToUrl("jewelry-insurance-policy-information");
        }

        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed;
        }

        public void CheckImages(IWebDriver driver)
        {
            IList<IWebElement> images;
            images = driver.FindElements(By.TagName("img")).ToList();
            for (int i = 0; i < images.Count; i++)
            {
                string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();
                string imagename = images[i].GetAttribute("src");
                string shortenedImage = null;
                Assert.IsTrue(imagename.Contains("a"));

                if (imagename.Contains(".com"))
                    shortenedImage = imagename.Substring(imagename.IndexOf(".com") + 4);
                Console.WriteLine("image exension = " + shortenedImage);

                if (currEnvironment.Contains("dev1"))
                    Assert.IsTrue(
                            shortenedImage.Equals("/jmweb/assets/img/placeholder/policy1-lg.jpg?ext=.jpg") ||
                            shortenedImage.Equals("/jmweb/assets/img/Testimonials/Darryl.jpg?ext=.jpg") ||
                            shortenedImage.Equals("/jmweb/assets/img/placeholder/policy2-sm.jpg?ext=.jpg"),
                            "Image name is no in current list of acceptable images for FAQ page " + shortenedImage);
                else if (currEnvironment.Contains("test"))
                    Assert.IsTrue(
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/policy1-lg.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/Darryl.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/policy2-sm.jpg?ext=.jpg"),
                        "Image name is no in current list of acceptable images for FAQ page " + imagename);
                else if (currEnvironment.Contains("Stage"))
                    Assert.IsTrue(
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/policy1-lg.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/Darryl.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/policy2-sm.jpg?ext=.jpg"),
                        "Image name is no in current list of acceptable images for FAQ page " + imagename);
                else if (currEnvironment.Contains("prod"))
                    Assert.IsTrue(
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/policy1-lg.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/Darryl.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/policy2-sm.jpg?ext=.jpg"),
                        "Image name is no in current list of acceptable images for FAQ page " + imagename);
            }
        }


    }
    #endregion

}

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
namespace DigitalProject.Pages.Business
{
    public class BusinessInsurance : Page
    {

        #region Required
        public BusinessInsurance(IWebDriver driver) : base(driver)
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
            IsElementPresent(driver, By.LinkText("GET STARTED"));
        }

        #endregion
        #region Elements
        string VerifyPageElement = "a[id$ ='p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA']";

        //[FindsBy(How = How.CssSelector, Using = "#p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Info_ucTestimonial_divTestimonial > blockquote:nth-child(2)")]

        

    [FindsBy(How = How.CssSelector, Using = "form#form .testimonial__quote")]
        public IWebElement DarrlTestimonial;


        //  [FindsBy(How = How.CssSelector, Using = "#p_lt_ctl02_pageplaceholder_p_lt_ctl06_JewelersMutual_Info1_ucTestimonial_divTestimonial > blockquote:nth-child(2)")]
        // [FindsBy(How = How.CssSelector, Using = "div.info--centered.testimonial__quote")]
        //  [FindsBy(How = How.CssSelector, Using = "#p_lt_ctl02_pageplaceholder_p_lt_ctl07_JewelersMutual_Info1_ucTestimonial_imgAuthor > blockquote:nth-child(2)")]
        [FindsBy(How = How.CssSelector, Using ="blockquote:contains('Thanks to JM')]")]
          public IWebElement MaryTestimonial;
        #endregion

        #region Methods
        public void GoToBusinessInsurancePage()
        {
            GoToUrl("jewelry-business-jewelers-block-bop-insurance");
        }

        public void VerifyBusinessInsuranceTestimonials()
        {
            string dt = DarrlTestimonial.Text;
            string mt = MaryTestimonial.Text;

            Assert.IsTrue(dt.Contains("\"We would recommend Jewelers Mutual to anyone in our business. We have been in good hands for over 20 years.\""), "Darrl Testimonial did not match as expected, actual text =" + dt);
            Assert.IsTrue(mt.Contains("\"Thanks to JM, I have my family business back and my employees have a future.\""), "Mary Testimonial text did not match as expected, actual text = " + mt);
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
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/businesshome-lg.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/James.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/Mary.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/business1-sm.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/business1-lg.jpg?ext=.jpg"),
                        "Image name is no in current list of acceptable images for FAQ page " + shortenedImage);
                else if (currEnvironment.Contains("test"))
                    Assert.IsTrue(
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/businesshome-lg.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/James.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/Mary.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/business1-sm.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/business1-lg.jpg?ext=.jpg"),
                        "Image name is no in current list of acceptable images for FAQ page " + shortenedImage);
                else if (currEnvironment.Contains("Stage"))
                    Assert.IsTrue(
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/businesshome-lg.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/James.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/Mary.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/business1-sm.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/business1-lg.jpg?ext=.jpg"),
                        "Image name is no in current list of acceptable images for FAQ page " + shortenedImage);
                else if (currEnvironment.Contains("prod"))
                    Assert.IsTrue(
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/businesshome-lg.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/James.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/Testimonials/Mary.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/business1-sm.jpg?ext=.jpg") ||
                        shortenedImage.Equals("/jmweb/assets/img/placeholder/business1-lg.jpg?ext=.jpg"),
                        "Image name is no in current list of acceptable images for FAQ page " + shortenedImage);
            }
        }

        #endregion


        #region common methods
        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed;
        }
        public void AssertElementIsNotVisible(IWebElement element)
        {
            Assert.IsFalse(element.Displayed);
        }

        public void GoToUrl(string url2)
        {
            String currentURL = driver.Url;

            int index = currentURL.LastIndexOf(".com/");

            if (index > 0)
                currentURL = currentURL.Remove(currentURL.LastIndexOf(".com/") + 5);

            this.driver.Url = currentURL + url2;

        }

        public void GetUrlClickElementVerifySameEnvironment(IWebElement element)
        {
            String currentURL = driver.Url;

            int baseUrl = currentURL.LastIndexOf(".com/");

            if (baseUrl > 0)
            {
                currentURL = currentURL.Remove(currentURL.LastIndexOf(".com/") + 5);

            }
            Console.Write("     First URL was =  " + currentURL + "   |");

            element.Click();

            System.Threading.Thread.Sleep(4000);

            String newUrl = driver.Url;

            int newBaseUrl = newUrl.LastIndexOf(".com/");

            if (newBaseUrl > 0)
            {
                newUrl = newUrl.Remove(newUrl.LastIndexOf(".com/") + 5);

            }
            Console.Write("     Second URL was = " + newUrl + "    ");

            if (string.Compare(currentURL, newUrl) == 0)
                newUrl = currentURL;
            else
            {
                Assert.Fail(" URL do not match : Expected value " + currentURL + " Actual value " + newUrl);

            }
        }
        public void IsNullOrEmpty(IWebElement element)
        {
            Assert.IsNull(element);
        }
        #endregion


    }
}

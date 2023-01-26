using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace DigitalProject.Pages.Landing_Pages
{
    public class GroomsPage : Page
    {
        #region Required
        public GroomsPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {
            // VerifyUIElementIsDisplayed(VerifyPageElement);
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

        #endregion

        #region Methods

        public void GoToGroomspage()
        {
            GoToUrl("engagement-ring-insurance");
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

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(images[i + 6].GetAttribute("href"));
                request.Method = "HEAD";

                bool exists;
                try
                {
                    request.GetResponse();
                    exists = true;
                }
                catch
                {
                    exists = false;
                }

                Console.WriteLine("Does image exist: " + exists);

                string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();
                string imagename = images[i].GetAttribute("src");
                string shortenedImage = null;
                //HttpWebRequest re = HttpWebRequest.Create();
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

                // re = (HttpWebRequest) WebRequest.Create(images[i].GetAttribute("href"));



                if (images[i] != null)
                {
                    if (images[i] != null)
                    {
                        // re = (HttpWebRequest)WebRequest.Create(images[i].GetAttribute("href"));
                        try
                        {
                            //  var response = (HttpWebResponse)re.GetResponse();
                            //  System.Console.WriteLine($"Images: {images[i].GetAttribute("src")} statis is : {response.StatusCode}");
                        }
                        catch (WebException e)
                        {
                            var errorResponse = (HttpWebResponse)e.Response;
                       //     Console.WriteLine($"Images: {images[i].GetAttribute("href")} status is:{errorResponse.StatusCode} ");

                        }
                    }
                }
            }
        }

    }
    #endregion



}


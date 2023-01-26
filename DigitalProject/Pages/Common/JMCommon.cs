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
using System.Configuration;
using System.Net;

namespace DigitalProject.Pages.Common
{
    public class JMCommon : Page
    {
        #region required stuff

        public JMCommon(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
            
        }

        public override void VerifyPage()
        {
            //IsElementPresent(driver, By.Id("p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA"));
        }

        public override void WaitForLoad()
        {
            //IsElementPresent(driver, By.Id("p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA"));
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


        public void GoToSpecficUrl(string url)
        {
            this.driver.Url = url;
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
        public void GetCurrentEnvironment()
        {
            string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();
            Console.WriteLine("current environment is" + currEnvironment);
        }

        public void VerifyPLPortalLinksAreCorrectEnvironment(IWebDriver driver)
        {

            IList<IWebElement> urls;

            urls = driver.FindElements(By.TagName("a")).ToList();
            for (int i = 0; i < urls.Count; i++)
            {
                if (!(urls[i].Text == ""))
                {
                    string baseurl = null;

                    Console.WriteLine(urls[i].GetAttribute("href"));
                    string fullurl = urls[i].GetAttribute("href");

                    if (fullurl.Contains(".com/"))
                        baseurl = fullurl.Remove(fullurl.LastIndexOf(".com/") + 4);
                    else if (fullurl.Contains("my.jewelersmutual.com"))
                        baseurl = fullurl.Remove(fullurl.LastIndexOf("my.jewelersmutual.com") + 21);
                    else if (fullurl.Contains("jewelersnt.local"))
                        baseurl = fullurl.Remove(fullurl.LastIndexOf("jewelersnt.local") + 16);
                    else if (fullurl.Contains("@jminsure.com"))
                        baseurl = "@jminsure.com";
                    else if (fullurl.Contains("tel:"))
                        baseurl = "phone";
                    else if (fullurl.Contains("mailto:"))
                        baseurl = "email";
                    //else if (fullurl.Contains("info.jewelersmutual.com"))
                    //    baseurl = fullurl.Remove(fullurl.LastIndexOf(".com") + 4);
                    else if (fullurl.Contains("cffoxvalley.org"))
                        baseurl = fullurl.Remove(fullurl.LastIndexOf("ley.org") + 7);
                    else
                        Console.WriteLine(fullurl + "Url is not in current list of accepted ursl");

                    string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();


                    if (currEnvironment.Contains("dev1"))
                        Assert.IsTrue(
                                baseurl.Equals("https://dev.testjewelersmutual.com") ||
                                baseurl.Equals("https://my.jewelersmutual.com") ||
                                baseurl.Equals("http://mydev01.jewelersnt.local") ||
                                baseurl.Equals("https://info.jewelersmutual.com") ||
                                baseurl.Equals("http://info.jewelersmutual.com") ||
                                baseurl.Equals("phone") ||
                                baseurl.Equals("https://jewelersmutual.uberflip.com") ||
                                baseurl.Equals("http://ishipjm.com") ||
                                baseurl.Equals("https://www.ishipjm.com") ||
                                baseurl.Equals("@jminsure.com") ||
                                baseurl.Equals("email") ||
                                baseurl.Equals("https://advantagemember.van.fedex.com") ||
                                baseurl.Equals("https://jmuniversity.litmos.com") ||
                                baseurl.Equals("https://www.cffoxvalley.org"),
                                "URL is pointing to wrong environment. URL is " + baseurl);
                    else if (currEnvironment.Contains("test"))
                        Assert.IsTrue(
                            baseurl.Equals("https://test.testjewelersmutual.com") ||
                            baseurl.Contains("https://mytest04.jewelers"),
                            "URL is pointing to wrong environment. URL is " + fullurl);
                    else if (currEnvironment.Contains("Stage"))
                        Assert.IsTrue(
                            baseurl.Equals("https://testjewelersmutual.com") ||
                            baseurl.Contains("https://mytest04.jewelers"),
                            "URL is pointing to wrong environment. URL is " + fullurl);
                    else if (currEnvironment.Contains("prod"))
                        Assert.IsTrue(
                            baseurl.Equals("https://jewelersmutual.com") ||
                            baseurl.Equals("https://my.jewelersmutual.com"),
                            "URL is pointing to wrong environment. URL is " + fullurl);
                }
            }
        }


        #endregion

    }
}

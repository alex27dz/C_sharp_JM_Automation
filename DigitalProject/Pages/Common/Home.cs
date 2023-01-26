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

namespace DigitalProject.Pages.Common
{
    public class Home : Page
    {
        //Elements
        string ExplorePersonalJewelryinsurance = "a[id$ =' :p_lt_ctl02_pageplaceholder_p_lt_ctl07_JewelersMutual_Tout_lnkCTA']";
        //string btnLogIntoYourAccount = "a[id$ = 'p_lt_ctl02_pageplaceholder_p_lt_ctl01_JewelersMutual_MainHero_lnkCTA']";

        [FindsBy(How = How.Id, Using = "p_lt_ctl02_pageplaceholder_p_lt_ctl01_JewelersMutual_MainHero_lnkCTA")]
        public IWebElement btnExplorePersonalJewelry;

        [FindsBy(How = How.Id, Using = "p_lt_ctl02_pageplaceholder_p_lt_ctl07_JewelersMutual_Tout_lnkCTA")]
        public IWebElement btnExplorePersonalJewelryTrust;

        [FindsBy(How = How.LinkText, Using = "ABOUT US")]
        public IWebElement AboutUs;

        [FindsBy(How = How.Id, Using = "p_lt_ctl02_pageplaceholder_p_lt_ctl05_JewelersMutual_Tout2_lnkCTA")]
        public IWebElement btnLogIntoYourAccount;

        [FindsBy(How = How.LinkText, Using = "Log in")]
        public IWebElement linkLogIn;

        [FindsBy(How = How.CssSelector, Using = ".testimonial__quote")]
        public IWebElement DarrlTestimonial;

        #region I Want To insure Dropdown and elements in the dropdown
        [FindsBy(How = How.CssSelector, Using = "label.form__text:nth-child(1)")]
        public IWebElement btnIWantToInsureDropdown;

        [FindsBy(How = How.CssSelector, Using = "li.form__select-js-item:nth-child(1)")]
        public IWebElement ring;
        #endregion

        [FindsBy(How = How.Id, Using = "p_lt_ctl02_pageplaceholder_p_lt_ctl04_JewelersMutual_QuickQuoteTool_formSubmitButton")]
        public IWebElement btnEstimateMyRate;

        #region required stuff

        public Home(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(ExplorePersonalJewelryinsurance);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(ExplorePersonalJewelryinsurance));
        }


        #endregion 
        public void DoesExplorePersonalJewelryInsuranceButtonExist()
        {
        }

        public void AssertQuickQuoteDoesNotExist()
        {
            AssertElementIsNotVisible(btnEstimateMyRate);
        }


        #region Navigation
        public void GotoAboutUsPage()
        {
            IsElementVisible(btnExplorePersonalJewelry);
            GoToUrl("about-us");
        }

        public void GoToGroomsPage()
        {
            GoToUrl("jewelry-engagement-ring-insurance-quote");
        }


        #endregion
        public void ClickIWantToInsureDropdown()
        {
            btnIWantToInsureDropdown.Click();
            //          ring.GetAttribute.
            Console.Write("Ring Text" + ring);

        }

        public void LogIntoYourAccountBTN()
        {
            // LogIn = new driver.FindElement(By.Id("p_lt_ctl02_pageplaceholder_p_lt_ctl05_JewelersMutual_Tout2_lnkCTA"));
            btnLogIntoYourAccount.Click();
            System.Threading.Thread.Sleep(2000);

        }

        public void ClickAndAssertExplorePJ()
        {
            GetUrlClickElementVerifySameEnvironment(btnExplorePersonalJewelryTrust);

        }


        #region temp

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

        //public void GoToUrl(string url)
        //{
        //    this.driver.Url = url;
        //}

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
        public void Environment()
        {
            //estConfiguration.ConfigurationSection("EnvToExecute").ToString();
            //string config = ConfigurationSettings.GetConfig("EnvToExecute").ToString();
            //Console.Write("config" + config);

            string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();
            Console.WriteLine("current environment is" + currEnvironment);

        }
        #endregion

        public void VerifyHomeTestimonial()
        {
            string vht = DarrlTestimonial.Text;
            Assert.IsTrue(vht.Contains("\"Excellent company – reasonable rates, great coverage and prompt and courteous service. Applying is easy and claims service is exactly as advertised…wonderful.\""), "Testimonial text did not match expect, actual text = " + vht);
        }
    }
}

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
    public class JewelersPrograms : Page
    {

        #region Required
        public JewelersPrograms(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  VerifyUIElementIsDisplayed(VerifyPageElement);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.LinkText("CALCULATE MY RATE"));
        }

        #endregion


        #region Methods
        public void GoToJewelerProgramsPage()
        {
            GoToUrl("customer-loyalty-programs-for-jewelers");
        }

        #endregion

        #region Elements
        string VerifyPageElement = "a[id$ ='p_lt_ctl02_pageplaceholder_p_lt_ctl02_JewelersMutual_Tout_lnkCTA']";
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

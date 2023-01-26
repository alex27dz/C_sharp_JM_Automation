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
    public class JMUniversity : Page
    {
        #region Required
        public JMUniversity(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
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

        #endregion

        #region Methods

        public void GoToJMUniversityPage()
        {
            GoToUrl("jm-university-retail-loss-prevention-tools");
        }

        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed;
        }

        public void CheckHeaderImage()
        {
            throw new NotImplementedException();
        }

        public void CheckFeaturedInImages()
        {
            throw new NotImplementedException();
        }

        public void CheckWhatsCoveredImages()
        {
            throw new NotImplementedException();
        }

        public void CheckWhatsNotCoveredImages()
        {
            throw new NotImplementedException();
        }

        public void CheckComparisonSectionImage()
        {
            throw new NotImplementedException();
        }

        public void CheckFooterImage()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

}

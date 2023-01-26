using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace QuoteAndApplyPages.Pages.JMPG
{
    public class GetAQuote : Page
    {
        // Menu Bar
        string jmpgLogo = "//*[@id='HeaderImages']/a[2]/img[1]";
        string questionLable = "//label[text()='Questions?']";
        string mobileLink = "//a[@id='JmPhoneNumber_Mobile']/u/span";
        string emailLink = "//a[@id='JmEmailAddress']/u/span";
        string faqLink = "//label[4]/a/u/span";
        string logoutLink = "//span[text()='Log Out']";
        string goToJMPGLink = "//span[text()='Go To JM Partner Gateway']";
        string startNewApplicationLink = "//*[@id='PartnerHeader']/a[3]/span";
        string welcomeUserLabel = "//i[text()='Welcome, Ryan Rose']";
        string welcomeUserOnProdLabel = "//i[text()='Welcome, Smoke Two Test']";
        string partnerModeLabel = "//span[text()='Partner Mode']";
        string limpsLabel = "//span[text()=' - limps']";
        string virginiaBeachLabel = "//span[text()=' - Virginia Beach']";
        string oxbloodDandleLabel = "//span[text()=' - oxblood dandle']";
        string firstPipe = "//*[@id='PartnerHeader']/span[3]";
        string secondPipe = "//*[@id='PartnerHeader']/span[6]";
        string thirdPipe = "//*[@id='PartnerHeader']/span[5]";

        // Summary Container
        string coverageInclude = "//*[@id='summaryContainer']/div[4]/div[1]";
        string textLoss = "//span[text()='Loss']";
        string textDamage = "//span[text()='Damage']";
        string textWorldwideTravel = "//span[text()='Worldwide Travel']";
        string textTheft = "//span[text()='Theft']";
        string textDisappearance  = "//span[text()='Disappearance']";
        string linkAdditionalCoverageDetails = "//a[text()='Additional Coverage Details']";

        // Quote Container
        string startQuote = "//h1[text()='Start Your Quote']";
        string labelEnterZipCode = "//p[text()='1.  Enter the Zip/Postal Code of the Jewelry Wearer']";
        string labelTellUs = "//p[text()='2. Tell Us About Your Jewelry Item(s)']";
        string jewlryType = "//label[text()='Jewelry Type']";
        string value = "//label[text()='Value']";
        string displayJewelryValueHelpIcon = "//img[@alt='Jewelry Value Help']";
        string showMyQuote = "//a[@id='quoteInfoNext']";
        string addAnotherItem = "//a[@id='AddJewelryItemQuoteInfo']";

        // Footer
        string privacyPolicy = "//a[@id='privacyPolicy-footer']";
        string termsOfUse = "//a[@id='termsOfUse-footer']";
        string footerRight = "//div[@class='footerRight']";
       

        public GetAQuote(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            // WaitForLoad();
        }

        public override void VerifyPage()
        {
            pause();
        }

        public override void WaitForLoad()
        {
            pause();
            pause();
            WaitUntilElementVisible(driver, By.XPath(showMyQuote));
        }

        public void verifyGetAGuotePage()
        {
            Console.WriteLine("----JMPG Get A Quote Page error message validation ----- started------");
            verifyMenuBar();
            verifyFooter();
            verifyQuoteContainer();
            verifySummaryContainer();
            Console.WriteLine("----JMPG Get A Quote Page error message validation ----- complete------");
        }

        public void verifyFooter()
        {
            IWebElement linkPrivacyPolicy = driver.FindElement(By.XPath(privacyPolicy));
            IWebElement linkTermsOfUsey = driver.FindElement(By.XPath(termsOfUse));
            IWebElement linkFooterRight = driver.FindElement(By.XPath(footerRight));
            Assert.IsTrue(linkPrivacyPolicy.Text.Contains("Privacy Notice"), "Actual text content to verify Privacy Notice of Get A Quote Footer: " + linkPrivacyPolicy.Text);
            Assert.IsTrue(linkTermsOfUsey.Text.Contains("Terms of Use"), "Actual text content to verify Terms of Use of Get A Quote Footer: " + linkTermsOfUsey.Text);
            Assert.IsTrue(linkFooterRight.Text.Contains("© 2020 Jewelers Mutual. All Rights Reserved"), "Actual text content to verify Footer Right of Get A Quote Footer: " + linkFooterRight.Text);
        }

        public void verifyMenuBar()
        {
            IWebElement linkMobile = driver.FindElement(By.XPath(mobileLink));
            IWebElement linkEmail = driver.FindElement(By.XPath(emailLink));
            IWebElement linkFAQ = driver.FindElement(By.XPath(faqLink));
            IWebElement linkStartNewApplication = driver.FindElement(By.XPath(startNewApplicationLink));

            VerifyUIElementIsDisplayed(jmpgLogo);
            VerifyUIElementIsDisplayed(questionLable);
            VerifyUIElementIsDisplayed(logoutLink);
            VerifyUIElementIsDisplayed(goToJMPGLink);            
            VerifyUIElementIsDisplayed(partnerModeLabel);
            
            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "prod")
            {
                VerifyUIElementIsDisplayed(welcomeUserOnProdLabel);
                VerifyUIElementIsDisplayed(virginiaBeachLabel);
                Assert.IsTrue(linkMobile.Text.Contains("888-903-9174"), "Actual text content to verify Mobile Link of Get A Quote Menu Bar: " + linkMobile.Text);
            }
            else
            {
                if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "stage")
                {
                    VerifyUIElementIsDisplayed(limpsLabel);
                }
                else
                {
                    VerifyUIElementIsDisplayed(oxbloodDandleLabel);
                }
                VerifyUIElementIsDisplayed(welcomeUserLabel);               
                Assert.IsTrue(linkMobile.Text.Contains("888-182-4446"), "Actual text content to verify Mobile Link of Get A Quote Menu Bar: " + linkMobile.Text);
            }
                
            
            Assert.IsTrue(linkEmail.Text.Contains("Email"), "Actual text content to verify Email Link of Get A Quote Menu Bar: " + linkEmail.Text);
            Assert.IsTrue(linkFAQ.Text.Contains("FAQ"), "Actual text content to verify FAQ Link of Get A Quote Menu Bar: " + linkFAQ.Text);
            Assert.IsTrue(linkStartNewApplication.Text.Contains("Start New Application"), "Actual text content to verify Start New Application Link of Get A Quote Menu Bar: " + linkStartNewApplication.Text);
        }

        public void verifyQuoteContainer()
        {
            VerifyUIElementIsDisplayed(startQuote);
            VerifyUIElementIsDisplayed(labelEnterZipCode);
            VerifyUIElementIsDisplayed(labelTellUs);
            VerifyUIElementIsDisplayed(jewlryType);
            VerifyUIElementIsDisplayed(value);
            VerifyUIElementIsDisplayed(displayJewelryValueHelpIcon);
            VerifyUIElementIsDisplayed(firstPipe);
            VerifyUIElementIsDisplayed(secondPipe);
            VerifyUIElementIsDisplayed(thirdPipe);

            IWebElement buttonShowMyQuote = driver.FindElement(By.XPath(showMyQuote));
            IWebElement linkAddAnotherItem = driver.FindElement(By.XPath(addAnotherItem));
            
            Assert.IsTrue(buttonShowMyQuote.Text.Contains("Show My Quote"), "Actual text content to verify Show My Quote Button of Get A Quote Container: " + buttonShowMyQuote.Text);
            Assert.IsTrue(linkAddAnotherItem.Text.Contains("Add another item"), "Actual text content to verify Add Another Item Link of Get A Quote Container: " + linkAddAnotherItem.Text);
           
        }

        public void verifySummaryContainer()
        {
            VerifyUIElementIsDisplayed(textDamage);
            VerifyUIElementIsDisplayed(textDisappearance);
            VerifyUIElementIsDisplayed(textLoss);
            VerifyUIElementIsDisplayed(textWorldwideTravel);
            VerifyUIElementIsDisplayed(textTheft);
            VerifyUIElementIsDisplayed(linkAdditionalCoverageDetails);

            Console.WriteLine("----JMPG Get A Quote Page Summary Container Check Marks Image validation ----- started------");

            string imgIconXpathPrefix = "//*[@id='summaryContainer']//div[1]/div[";
            string imgIconXpathPostFix = "]/img";
            string imgIconXpath;

            for(int i = 1; i <= 3; i++)
            {
                imgIconXpath = imgIconXpathPrefix + i + imgIconXpathPostFix;
                VerifyUIElementIsDisplayed(imgIconXpath);
            }

            imgIconXpathPrefix = "//*[@id='summaryContainer']//div[2]/div[";

            for (int i = 1; i <= 2; i++)
            {
                imgIconXpath = imgIconXpathPrefix + i + imgIconXpathPostFix;
                VerifyUIElementIsDisplayed(imgIconXpath);
            }
            Console.WriteLine("----JMPG Get A Quote Page Summary Container Check Marks Image validation ----- complete------");

            IWebElement headingCoverageInclude = driver.FindElement(By.XPath(coverageInclude));
            Assert.IsTrue(headingCoverageInclude.Text.Contains("Coverage Includes:"), "Actual text content to verify Coverage Include of Get A Quote Summary Container: " + headingCoverageInclude.Text);
        }

        public void clickGoToJMPG()
        {
            string confirmButton = "//a[text()='Yes, get me to JM Partner Gateway']";

            driver.FindElement(By.XPath(goToJMPGLink)).Click();

            WaitUntilElementEnabled(driver, By.XPath(confirmButton));

            driver.FindElement(By.XPath(confirmButton)).Click();

        }
     }
}

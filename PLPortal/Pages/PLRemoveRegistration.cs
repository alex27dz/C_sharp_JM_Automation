using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using WebCommonCore;
namespace PLPortalPages.Pages
{
    public class PLRemoveRegistration : Page
    {

        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Remove Portal Registration')]")]
        public IWebElement linkRemovePLPortalREgistration;

        public PLRemoveRegistration(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {
            Console.WriteLine("WaitforLoad");
            WaitUntilElementVisible(driver, By.XPath("//a[contains(., 'Remove Portal Registration')]"));
        }


        public void PLUnregister(string Email)
        {
            Console.WriteLine("In Main Function");
            linkRemovePLPortalREgistration.Click();
            IWebElement loginName = driver.FindElement(By.Id("LoginName"));
            IWebElement btnFindloginName = driver.FindElement(By.Id("viewRegistrationForLogin"));

            WaitUntilElementVisible(driver, By.XPath("//input[@id='LoginName']"));
            loginName.SendKeys(Email);
            pause();
            btnFindloginName.Click();
            pause();
            bool FalgRemoveReg = false;
            try
            {
                //pause();
                WaitUntilElementVisible(driver, By.XPath("//li[contains(.,'No registrations found.')]"), 10);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FalgRemoveReg = true;
            }

            if (FalgRemoveReg)
            {
                WaitUntilElementVisible(driver, By.XPath("//button[@id='removeRegistration']"), 10);
                IWebElement btnRemoveRegistration = driver.FindElement(By.Id("removeRegistration"));
                btnRemoveRegistration.Click();
                WaitUntilElementVisible(driver, By.XPath("//div[contains(.,'Removal successful.')]"));
                Console.WriteLine("Email un-registered successfully");

            }

        }


    }
}


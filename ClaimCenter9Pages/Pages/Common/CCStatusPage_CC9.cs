using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.Common
{
    public class CCStatusPage_CC9 : Page
    {
        public CCStatusPage_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[id$= 'ClaimStatus:ttlBar']"));
        }

        public void VerifyisClaimforLegecyPolicy()
        {
            IWebElement legacyStatus;
            legacyStatus = driver.FindElement(By.XPath("//div[@id='ClaimStatus:Claim_IsClaimForLegacyPolicy-inputEl']"));
            Console.WriteLine("legacyStatus text is " + legacyStatus.Text.ToString());
            Console.WriteLine("legacyStatus value is " + legacyStatus.GetAttribute("value"));
            if (legacyStatus.Text.ToString().ToLower().Equals("yes"))
            {
                Console.WriteLine("Status of Is Claim for Legacy Policy is Yes");
            }
            else
            {
                Console.WriteLine("Status of Is Claim for Legacy Policy is not Yes");
                Assert.Fail("Status of Is Claim for Legacy Policy is not Yes");
            }
        }

    }
}

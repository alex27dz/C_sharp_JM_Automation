using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace AgencyAutomationPages.Pages
{
    public class AgentPortalLogin : Page
    {
        string inputUserName = "input[id$='UserName']";

        string inputPassword = "input[id$='Password']";

        string login = "input[id$='submitButton']";
        public AgentPortalLogin(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(inputUserName);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(inputUserName));

        }

        public void EnterLoginDetails(string UserName, string Password)
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch (NoAlertPresentException Ex)
            {
                //          Console.WriteLine(Ex.InnerException.ToString());
            }

            UIAction(inputUserName, UserName, "textbox");

            UIAction(inputPassword, Password, "textbox");

            UIAction(login, string.Empty, "button");

            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch (NoAlertPresentException Ex)
            {
                //          Console.WriteLine(Ex.InnerException.ToString());
            }


        }
    }
}

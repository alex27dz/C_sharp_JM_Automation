using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace DigitalProject.Pages.Drupal_Portal
{
   public class Portalloginpage:Page
    {
        string btnLoginCSS = "input[id$='edit-submit']";
        string txtUsernameCSS = "input[id$='edit-name']";
        string txtPasswordCSS = "input[id$='edit-pass']";
        public Portalloginpage(IWebDriver driver) : base(driver)
		{
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnLoginCSS);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(btnLoginCSS));
        }

        public void logintoportal(string username, string password)
        {
            UIActionExt(By.CssSelector(txtUsernameCSS), "listbox", username);
            UIActionExt(By.CssSelector(txtPasswordCSS), "listbox", password);
            UIActionExt(By.CssSelector(btnLoginCSS), "click");
        }
    }
}

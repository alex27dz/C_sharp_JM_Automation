using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace DigitalProject.Pages.Drupal_Portal
{
   public class CreateMarketingpage : Page
    {
        string lblCreateMarketingheaderXapth = "//h1[text()='Create Marketing Page']";
        string txtTitleCSS = "input[id$='edit-title-0-value']";
        string btnSaveCSS = "input[id$='edit-submit']";

  
        public CreateMarketingpage(IWebDriver driver) : base(driver)
		{
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblCreateMarketingheaderXapth);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(lblCreateMarketingheaderXapth));
          
        }

        public void UpdateTitle(string title)
        {
            UIActionExt(By.CssSelector(txtTitleCSS), "listbox", title);
            UIActionExt(By.CssSelector(btnSaveCSS), "click");
        }
       
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class Quotepage:Page
    {
        string lblPersonalQuoteHeaderXpath = "//h2[@class='gw-page-section-title gw-as-page-title ng-binding']";
        string linkDetailsforUWXpath = "//a[.='Click here for details and options.']";
        //string btnContinueXpath = "//button[@class='gw-btn-primary ng-binding']";
		string btnContinueXpath = "//button[text()[contains(.,'Continue')]]";
		public Quotepage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPersonalQuoteHeaderXpath);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(btnContinueXpath), 180);
          
        }

        public void ClickdetailsforUW()
        {
           WaitUntilElementVisible(driver, By.XPath(linkDetailsforUWXpath), 180);
            JavaScriptClick(driver.FindElement(By.XPath(linkDetailsforUWXpath)));
        }

        public void ClickContinue()
        {
			//   WaitUntilElementVisible(driver, By.XPath(lblPersonalQuoteHeaderXpath), 180);
			//JavaScriptClick(driver.FindElement(By.XPath(btnContinueXpath)));
			UIActionExt(By.XPath(btnContinueXpath), "ispresent");
			UIActionExt(By.XPath(btnContinueXpath), "click");

		}
	}
}

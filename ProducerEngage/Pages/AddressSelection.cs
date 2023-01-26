using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class AddressSelection : Page
    {
        string lblAddressNotLocatedXpath = "//h1[contains(.,'Address Not Located')]";
        string btnSelectAddress = "button[$class='gw-btn-primary ng-binding']";
        string btnFirstSelectButtonXpath = "//table[@class='jm-address-search-result-table gw-table ng-scope']/tbody/tr[1]/td[1]/button";

        public AddressSelection(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);

        }

        public override void VerifyPage()
        {

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.XPath(lblAddressNotLocatedXpath));
        }
    
        public void verifySelectAddressButton()
        {
            IsElementPresent(driver, By.CssSelector(btnSelectAddress));
        }

        public void SelectFirstAddress()
        {
            JavaScriptClick(driver.FindElement(By.XPath(btnFirstSelectButtonXpath)));
        }
    }
}

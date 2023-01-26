using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace PolicyCenterPages.Pages.Administration
{
    public class ProducerCode : Page
    {       
        string tabMenu = "a[id$=':tabs-menu-trigger']";      
        string lnkAdministrationInTabMenu = "div[eventId$='TabBar:AdminTab']";
       
        string lnkProducerCodeInLeftMenu = "//span[text()[contains(.,'Producer Codes')]]";

        string lblProducerCodesSearchPage = "span[id$=':AdminProducerCodeSearchScreen:ttlBar']";
        string inputAgencyCode = "input[id$=':ProducerCodeSearchDV:Code-inputEl']"; 
        string inputOrganization = "input[id$=':ProducerCodeSearchDV:Organization-inputEl']";
        string btnSearch = "a[id$=':ProducerCodeSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";
        string linkProducerCode = "a[id$=':AdminProducerCodeSearchLV:0:Code']";

        string lblProducerCodeDetailsScreen = "span[id$=':ProducerCodeDetailScreen:ttlBar']";
        string productAvailabilityTab = "span[id$=':ProducerCodeDetail_ProductAvailabilityTab-btnInnerEl']";
        string btnEdit = "span[id$=':ProducerCodeDetailScreen:Edit-btnInnerEl']";
        string btnAdd = "span[id$=':ProducerCodeDetail_ProductAvailabilityLV_tb:Add-btnInnerEl']";
        string btnRemove = "span[id$=':ProducerCodeDetail_ProductAvailabilityLV_tb:Remove-btnInnerEl']";
        string btnUpdate = "span[id$=':ProducerCodeDetailScreen:Update-btnInnerEl']";

        string productAvailabilityTableBody = "div[id$=':ProducerCodeDetail_ProductAvailabilityLV-body']";
        string inputEffectiveDate = "input[name$='EffectiveDate']";
        string inputExpiryDate = "input[name$='ExpiryDate']";
        
        string errorMessage = "div[id$='AdminProducerCodeDetail:ProducerCodeDetailScreen:_msgs']";
       
        public ProducerCode(IWebDriver driver) : base(driver)
        {           
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            
        }

        public override void WaitForLoad()
        {
            
        }

        public void SelectFromAdministrationTab(string menuOption)
        {
            WaitFor(driver.FindElement(By.CssSelector(tabMenu)));
            UIAction(tabMenu, string.Empty, "a");
            pause();

            WaitFor(driver.FindElement(By.CssSelector(lnkAdministrationInTabMenu)));
            UIAction(lnkAdministrationInTabMenu, string.Empty, "a");
            JavaScriptClick(driver.FindElement(By.CssSelector(lnkAdministrationInTabMenu)));
            pause();

            switch (menuOption.ToLower().Trim())
            {
              case "producer code":
                    WaitFor(driver.FindElement(By.XPath(lnkProducerCodeInLeftMenu))).Click();
                    IsElementPresent(driver, By.CssSelector(lblProducerCodesSearchPage));
                    break;
              default:
                    Console.WriteLine("None");
                    break;
            }
        }

        public void SearchAgencyByCode(string agencyCode)
        {
            WaitFor(driver.FindElement(By.CssSelector(inputOrganization))).Click();
            driver.FindElement(By.CssSelector(inputOrganization)).Clear();

            JavaScriptClick(driver.FindElement(By.CssSelector(inputAgencyCode)));
            UIAction(inputAgencyCode, String.Empty, "a");
            UIAction(inputAgencyCode, agencyCode, "textbox");

            JavaScriptClick(driver.FindElement(By.CssSelector(btnSearch)));
        }

        public void ClickProducerCode()
        {
            WaitUntilElementVisible(driver, By.CssSelector(linkProducerCode));
            UIAction(linkProducerCode, String.Empty, "a");
            IsElementPresent(driver, By.CssSelector(lblProducerCodeDetailsScreen));
        }

        public void ClickProductAvailabilityTab()
        {
            JavaScriptClick(driver.FindElement(By.CssSelector(productAvailabilityTab)));
        }

        public void ClickEditButton()
        {
            JavaScriptClick(driver.FindElement(By.CssSelector(btnEdit)));
        }

        public void ClickAddButton()
        {
            JavaScriptClick(driver.FindElement(By.CssSelector(btnAdd)));
        }

        public void ClickRemoveButton()
        {
            IWebElement btnRemoveElement = driver.FindElement(By.CssSelector(btnRemove));
            if (btnRemoveElement.Enabled)
            {
                JavaScriptClick(btnRemoveElement);
            }
            else
            {
                Assert.Fail("Remove button is not enable");
            } 
        }

        public void ClickUpdateButton()
        {
            JavaScriptClick(driver.FindElement(By.CssSelector(btnUpdate)));
        }

        public void EnterProductDetails(string productToEnter, string stateToEnter, string effectiveDate, string expiryDate)
        {
            string state;
            string product;
            string howManyEntries = "1";
            if (stateToEnter.Contains(":"))
            {
                state = (stateToEnter.Split(':')[0]).Trim();
                howManyEntries = (stateToEnter.Split(':')[1]).Trim();
            }
            else
            {
                state = stateToEnter;
            }

            if (productToEnter.Contains(":"))
            {
                product = (productToEnter.Split(':')[0]).Trim();
                howManyEntries = (productToEnter.Split(':')[1]).Trim();
            }
            else
            {
                product = productToEnter;
            }

            IWebElement productAvailabilityBody = driver.FindElement(By.CssSelector(productAvailabilityTableBody));
            List<IWebElement> tableElements = new List<IWebElement>(productAvailabilityBody.FindElements(By.TagName("table")));
            Console.WriteLine(" tableElements Count " + tableElements.Count());
            if (tableElements.Count() > 0)
            {
                int i = Int32.Parse(howManyEntries) - 1;

                List<IWebElement> lsGetTdElemets = new List<IWebElement>(tableElements[i].FindElements(By.TagName("td")));

                if (lsGetTdElemets.Count > 4)
                {
                    //enter product
                    JavaScriptClick(lsGetTdElemets[1]); ;
                    WaitFor(driver.FindElement(By.XPath("//li[text()='" + product + "']"))).Click();

                    //enter state
                    if (!state.Equals(""))
                    {
                        JavaScriptClick(lsGetTdElemets[2]); ;
                        WaitFor(driver.FindElement(By.XPath("//li[text()='" + state + "']"))).Click();
                    }

                    //enter effective date
                    if (!effectiveDate.Equals(""))
                    {
                        JavaScriptClick(lsGetTdElemets[3]);
                        UIAction(inputEffectiveDate, String.Empty, "a");
                        UIAction(inputEffectiveDate, effectiveDate, "textbox");
                    }

                    //enter expiry date
                    if (!expiryDate.Equals(""))
                    {
                        JavaScriptClick(lsGetTdElemets[4]);
                        UIAction(inputExpiryDate, String.Empty, "a");
                        UIAction(inputExpiryDate, expiryDate, "textbox");
                    }
                }
                else
                {
                    Assert.Fail("table has less columns");
                }
            }
        }


        public void NoErrorMessage()
        {
           if(IsElementPresent(driver, By.CssSelector(errorMessage)))
            {
                Assert.Fail("Failure in adding product");
            }
        }

        public void ErrorMessage()
        {
            Console.WriteLine("Error message: " + driver.FindElement(By.CssSelector(errorMessage)).Text);
            if (!IsElementPresent(driver, By.CssSelector(errorMessage)))
            {
                Assert.Fail("Product is not available. Error message should be appeared");
            }
        }

        public void SelectEnteredProduct()
        {
            string boxXpath = "//*[@id=\"AdminProducerCodeDetail:ProducerCodeDetailScreen:ProducerCodeDetail_ProductAvailabilityLV\"]/div[2]/div/div/div[1]/div/span/span/span";
            JavaScriptClick(driver.FindElement(By.XPath(boxXpath)));
        }
    }
}

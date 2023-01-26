using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class QuickEstimatepage : Page
    {
        string lblQuickEstimateXpath = "//h1[contains(.,'Quick Estimate')]";
        string item1TypeSelectXpath = "//*[@id='Form']/div/form/div[1]/div[1]/div/div/select";
        string item1SubtypeSelectXpath = "//*[@id='Form']/div/form/div[1]/div[2]/div/div/select";
        string item1GenderSelectXpath = "//*[@id='Form']/div/form/div[1]/div[3]/div/div/select";
        string item1ValueXpath = "//*[@id='Form']/div/form/div[1]/div[4]/div/div/input";
        string btnEstimateXpath = "//span[contains(.,'Estimate')]";
        string txtEstimatedAnnualPremiumXpath = "//*[@class='qq']/div[3]/div[3]/div";
       // string txtEstimatedPolicyValueXpath = "//*[@class='qq']/div[3]/div[2]/div/div[2]";
        string btnPrintQQXpath = "//*[@id='actions']/div/button[2]";
        string btnApplyXpath = "//button[contains(.,'Apply')]";

        public QuickEstimatepage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);
        }

        public override void VerifyPage()
        {
            IsElementPresent(driver, By.XPath(lblQuickEstimateXpath));           
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.XPath(lblQuickEstimateXpath));          
        }

        public void AddItem(string itemType, string itemSubType, string gender, string itemValue)
        {
            try
            {
                WaitUntilElementVisible(driver, By.XPath(lblQuickEstimateXpath));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Thread.Sleep(1000);
            JavaScriptClick(driver.FindElement(By.XPath(item1TypeSelectXpath)));
            WaitFor(driver.FindElement(By.XPath("//option[text()='" + itemType + "']"))).Click();

            if (!itemSubType.Equals(""))
            {
                JavaScriptClick(driver.FindElement(By.XPath(item1SubtypeSelectXpath)));
                WaitFor(driver.FindElement(By.XPath("//option[text()='" + itemSubType + "']"))).Click();
            }

            if (!gender.Equals(""))
            {
                JavaScriptClick(driver.FindElement(By.XPath(item1GenderSelectXpath)));
                WaitFor(driver.FindElement(By.XPath("//option[text()='" + gender + "']"))).Click();
            }

            UIActionExt(By.XPath(item1ValueXpath), "listbox", itemValue);          
        }

        public void ClickEstimateButton()
        {
            WaitUntilElementVisible(driver, By.XPath(btnEstimateXpath));           
            JavaScriptClick(driver.FindElement(By.XPath(btnEstimateXpath)));
            Thread.Sleep(1000);           
        }

        public void VerifyEstimatedAnnualPremiumIsReturned()
        {
            WaitUntilElementEnabled(driver, By.XPath(btnApplyXpath));       
           
            string premium = driver.FindElement(By.XPath(txtEstimatedAnnualPremiumXpath)).Text;
            string premiumNum = premium.Split('$')[1];
            
            if (Int64.Parse(premiumNum) <= 0)
            {
                Assert.Fail("Quick Estimate is failed with invalid annual premium");
            }
        }      

        public void VerifyQQPdfPrintButtonIsEnable()
        {
            if (driver.FindElement(By.XPath(btnPrintQQXpath)).Enabled)
            {
                Console.WriteLine("Print QQ button is Enable");
            }
            else
            {
                Assert.Fail("Print QQ button is not able to work");
            }
        }

        public void ClickApplyButton()
        {          
            JavaScriptClick(driver.FindElement(By.XPath(btnApplyXpath)));
            Thread.Sleep(1000);
        }

    }
}


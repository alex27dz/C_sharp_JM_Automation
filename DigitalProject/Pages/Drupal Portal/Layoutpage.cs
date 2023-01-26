using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace DigitalProject.Pages.Drupal_Portal
{
    public class Layoutpage:Page
    {
        string btnLayoutXpath = "//a[text()='Layout']";
        string lblSuccessfultextXpath = "//div[@class='messages messages--status'][contains(.,'The layout override has been saved.')]";
        string txtPlaceholderTitleXpath = "//div[@class ='title-bar content-lg spacing clearfix']//h2";
        string txtPlaceholderHeadlineXpath = "//div[@class ='feature-row background-color--white']//h2";
        string txtPlaceholderTextXpath = "//div[@class ='formatted_text spacing-4x']//p";

        public Layoutpage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnLayoutXpath);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(btnLayoutXpath));
            
        }

        public void VerifySuccessfullMessage()
        {
            WaitUntilElementVisible(driver, By.XPath(lblSuccessfultextXpath));
        }

        public void VerifyTitletext(string title)
        {
            WaitUntilElementVisible(driver, By.XPath(btnLayoutXpath));
            string actualtext = driver.FindElement(By.XPath(txtPlaceholderTitleXpath)).Text;
            if (string.Compare(actualtext.ToLower(), title.ToLower()) == 0)
            {
                Console.WriteLine("Expected title and actual title matches");
            }
            else
            {
                Console.WriteLine("Expected title and actual title do not matches");
                Assert.Fail("Actual text is " + actualtext + " Expected text is " + title);
            }
        }
        public void VerifyHeadlinetext(string headline)
        {
            WaitUntilElementVisible(driver, By.XPath(btnLayoutXpath));
            string actualtext = driver.FindElement(By.XPath(txtPlaceholderHeadlineXpath)).Text;
            if (string.Compare(actualtext.ToLower(), headline.ToLower()) == 0)
            {
                Console.WriteLine("Expected headline and actual headline matches");
            }
            else
            {
                Console.WriteLine("Expected headline and actual headline do not matches");
                Assert.Fail("Actual text is " + actualtext + " Expected text is " + headline);
            }
        }
        public void VerifyTexttext(string text)
        {
            WaitUntilElementVisible(driver, By.XPath(btnLayoutXpath));
            string actualtext = driver.FindElement(By.XPath(txtPlaceholderTextXpath)).Text;
            if (string.Compare(actualtext.ToLower(), text.ToLower()) == 0)
            {
                Console.WriteLine("Expected text and actual text matches");
            }
            else
            {
                Console.WriteLine("Expected text and actual text do not matches");
                Assert.Fail("Actual text is " + actualtext + " Expected text is " + text);
            }
        }

    }
}

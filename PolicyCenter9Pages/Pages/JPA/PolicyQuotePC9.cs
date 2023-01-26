using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace PolicyCenter9Pages.Pages.JPA
{
    public class PolicyQuotePC9 : Page
    {
        string lblQuoteXpath = "//span[text()[contains(.,'Quote')]]";
        string taxesDataForPolicyChange = "PolicyChangeWizard:PolicyChangeWizard_QuoteScreen:RatingCumulDetailsPanelSet:2-body";
       
        public PolicyQuotePC9(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblQuoteXpath);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(lblQuoteXpath));
        }

        public void VerifyTaxesAreProrated()
        {
            var taxesDataTable = driver.FindElement(By.Id(taxesDataForPolicyChange));
            List<IWebElement> tableElements = new List<IWebElement>(taxesDataTable.FindElements(By.TagName("table")));
            Console.WriteLine(" tableElements Count " + tableElements.Count());

            if (tableElements.Count() > 0)
            {
                for (int i = 0; i < tableElements.Count(); i++)
                {
                    //policy change divids both MUN_TAX and STATE_TAX to be two lines each
                    if (i > 3) break; 
                    
                    Console.WriteLine(i + " === " + tableElements[i].Text);
                    List<IWebElement> taxesInfo = new List<IWebElement>(tableElements[i].FindElements(By.TagName("td")));
                    float proration = float.Parse(taxesInfo[3].Text);
                    Console.WriteLine("proration: " + proration);

                    if (Double.Equals(Math.Round((Double)proration, 2), 1.00))
                    {
                        Assert.Fail("Tax is not prorating");
                    }

                    float amount = float.Parse(taxesInfo[4].Text.Split('$')[1]);
                    Console.WriteLine("amount: " + amount);
                    float annualizedAmount = float.Parse(taxesInfo[5].Text.Split('$')[1]);
                    Console.WriteLine("annualizedAmount: " + annualizedAmount);
                    float resultOfMultiple = proration * annualizedAmount;
                    Console.WriteLine("resultOfMultiple: " + resultOfMultiple);

                    if (!Double.Equals(Math.Round((Double)resultOfMultiple, 2), Math.Round((Double)amount, 2)))
                    {
                        Assert.Fail("Tax prorating is not correct");
                    }
                }
            }
            else
            {
                Assert.Fail("Taxes information is not displayed");
            }
        }
    }
}

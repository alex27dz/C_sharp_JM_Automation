using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using WebCommonCore;

namespace ClaimCenter9Pages.Pages.Common
{
    public class CCSearchClaimPage_CC9 : Page
    {

        string txtClaimNumber = "input[id='SimpleClaimSearch:SimpleClaimSearchScreen:SimpleClaimSearchDV:ClaimNumber-inputEl']";
        string btnsearch = "a[id$=':SimpleClaimSearchDV:ClaimSearchAndResetInputSet:Search']";		
        string linkClaim = "a[id='SimpleClaimSearch:SimpleClaimSearchScreen:SimpleClaimSearchResultsLV:0:ClaimNumber']";	

        public CCSearchClaimPage_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {

        }
        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$= 'SimpleClaimSearch:SimpleClaimSearchScreen:SimpleClaimSearchDV:ClaimNumber-inputEl']"));
        }

        public void SearchClaim(string CLaimNumber)
        {
			UIActionExt(By.CssSelector(txtClaimNumber), "Text", CLaimNumber);
			UIActionExt(By.CssSelector(btnsearch), "click");
        }

        public void verifyPolivyClaimRefrence(string Policy)
        {
			UIActionExt(By.CssSelector(btnsearch), "click");
            WaitUntilElementIsDisplayed(driver, By.XPath("//div[id$= 'SimpleClaimSearch:SimpleClaimSearchScreen:SimpleClaimSearchResultsLV-body']"));
            List<IWebElement> reserveDivObj;
            reserveDivObj = driver.FindElements(By.XPath("//div[@id= 'SimpleClaimSearch:SimpleClaimSearchScreen:SimpleClaimSearchResultsLV-body']")).ToList();
            Console.WriteLine("Div object count is " + reserveDivObj.Count());
            var reserveTableObj = reserveDivObj[0].FindElements(By.TagName("table"));
            Console.WriteLine("table object count is " + reserveTableObj.Count());
            var rows = reserveTableObj[0].FindElements(By.TagName("tr"));
            Console.WriteLine("Row count is " + rows.Count());
            var tds = rows[0].FindElements(By.TagName("td"));
            Console.WriteLine("text value is " + Equals(tds[6].Text));
            if (Policy.Trim().Equals(tds[6].Text))
            {
                Console.WriteLine("Claim number is referred to correct policy");
            }
            else
            {
                Console.WriteLine("Claim number is not referred to correct policy");
                Assert.Fail("Claim number not referred to correct policy");

            }
        }

		 public void ClickonClaim()
        {
			UIActionExt(By.CssSelector(linkClaim), "click");
		}
	}
}

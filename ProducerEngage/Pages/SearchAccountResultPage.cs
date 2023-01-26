using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class SearchAccountResultpage:Page
    {
        string btnCancel = "button[ng-click='setCancelState()']";
        string btnSearchAgain = "button[ng-click='resetSearch()']";
        string btnNewCustomer = "button[ng-click='newQuote()']";

        string searchResults = "div[ng-show='showResultsTable']";

        string txtFirstnameXpath = "//div[contains(@label,'First Name')]/div/div/div/input[@ng-model='model.value']";
        string txtLastnameXpath = "//div[contains(@label,'Last Name')]/div/div/div/input[@ng-model='model.value']";
        string btnSearch = "button[ng-click='setNextState(form)']";
        string linkAccountNumberXpath = "//div[@ng-show='showResultsTable']/table/tbody/tr/td[2]/a";
        string lblPossibleAccountMatchXpath = "//h1[contains(.,'Possible Account Matches')]";
        string lblIssuePoliciesXpath = "//span[contains(.,'Issued Policies')]";

        public SearchAccountResultpage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnCancel);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnCancel));

        }

        public void AtionOnSerachResult(string Actiontype)
        {
            switch (Actiontype.ToLower().Trim())
            {
                case "cancel":
                    JavaScriptClick(driver.FindElement(By.CssSelector(btnCancel)));
                    break;
                case "searchagain":
                    JavaScriptClick(driver.FindElement(By.CssSelector(btnSearchAgain)));
                    break;
                case "newcustomer":
                    JavaScriptClick(driver.FindElement(By.CssSelector(btnNewCustomer)));
                    break;
                default:
                    break;
            }
        }

        public void SearchAccountByName(string firstName, string lastName)
        {
            if (firstName.ToLower().Equals("unique") && lastName.ToLower().Equals("unique"))
            {
                RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                firstName = (string)RegKey.GetValue("FNAME");
                lastName = (string)RegKey.GetValue("LNAME");
                Console.WriteLine("first name: " + firstName);
                Console.WriteLine("last name: " + lastName);
            }

            UIActionExt(By.XPath(txtFirstnameXpath), "listbox", firstName);
            UIActionExt(By.XPath(txtLastnameXpath), "listbox", lastName);
            UIAction(btnSearch, String.Empty, "a");

        }

        public void VerifyAccount(string firstName, string lastName)
        {
            if (firstName.ToLower().Equals("unique") && lastName.ToLower().Equals("unique"))
            {
                RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                firstName = (string)RegKey.GetValue("FNAME");
                lastName = (string)RegKey.GetValue("LNAME");           
            }

            int found = 0;
            IWebElement searchResultsElement = driver.FindElement(By.CssSelector(searchResults));
            List<IWebElement> tableElements = new List<IWebElement>(searchResultsElement.FindElements(By.TagName("table")));
            Console.WriteLine("tableElements Count " + tableElements.Count());
            if (tableElements.Count() > 0)
            {
                List<IWebElement> lsGetTbodyElemets = new List<IWebElement>(tableElements[0].FindElements(By.TagName("tbody")));
                Console.WriteLine("tbody count " + lsGetTbodyElemets.Count());
                if (lsGetTbodyElemets.Count() > 0)
                {
                    List<IWebElement> lsGetTdElemets = new List<IWebElement>(tableElements[0].FindElements(By.TagName("td")));
                    Console.WriteLine(" lsGetTdElemets Count " + lsGetTdElemets.Count());
                    for (int i = 0; i < lsGetTdElemets.Count; i++)
                    {
                        Console.WriteLine("td Element " + i + ": " + (lsGetTdElemets[i].Text));
                        if (lsGetTdElemets[i].Text.Contains(firstName + " " + lastName))
                        {
                            found = found + 1;
                            Console.WriteLine("Found Existing Account ...");
                            break;
                        }                       
                    }
                    Console.WriteLine("Found " + found + " accounts matched");
                    if ( found == 0)
                    {
                        Assert.Fail("Account with name: " + firstName + " " + lastName + " is not found");
                    }
                }
                else
                {
                    Assert.Fail("No found any results in search result table");
                }
            }
            else
            {
                Assert.Fail("No Any Results Are Returned");
            }
        }

        public void ClickAccountLink()
        {
            WaitUntilElementVisible(driver, By.XPath(lblPossibleAccountMatchXpath));
            JavaScriptClick(driver.FindElement(By.XPath(linkAccountNumberXpath)));
            WaitUntilElementVisible(driver, By.XPath(lblIssuePoliciesXpath));         
        }
    }
}

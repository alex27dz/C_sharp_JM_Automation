using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;
using TechTalk.SpecFlow;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManagerPages.Pages.Common
{
    public class CMSearchPage : Page
    {
        string logOut = "span[id=':TabLinkMenuButton-btnIconEl']";
        string lstContactType = "input[id$=':ContactSearchDV:ContactSubtype-inputEl']";
        string btnSearch = "a[id$=':ContactSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']";
        string txtFirstName = "input[id$=':ContactSearchDV:GlobalPersonNameInputSet:FirstName-inputEl']";
        string txtLastName = "input[id$=':ContactSearchDV:GlobalPersonNameInputSet:LastName-inputEl']";
        string btnReset = "a[id$='ContactSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Reset']";
        string txtJewelerName = "input[id$=':ContactSearchDV:GlobalContactNameInputSet:Name-inputEl']";
        string personList = "a[id$=':ContactSearchResultsLV:0:DisplayName']";
        public CMSearchPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(logOut);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(logOut));
        }

        public void SearchContactPageDetails(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                DataStorage temp = new DataStorage();
                WaitUntilElementVisible(driver, By.CssSelector(lstContactType));
                Console.WriteLine("Verifying Contact Type: " + table.Rows[i]["ContactType"]);
				UIActionExt(By.CssSelector(lstContactType), "List", table.Rows[i]["ContactType"]);
				switch (table.Rows[i]["ContactType"].ToLower().Trim())
                {
                    case "person":
						if ((table.Rows[i]["FirstName"].ToUpper().Trim() == "REGISTRY") || ((table.Rows[i]["LastName"].ToUpper().Trim() == "REGISTRY")))
                        {
                            List<string> NameList = temp.GetTempValue("PL_ADDITIONAL_INSURED").Split(null).ToList();
							UIActionExt(By.CssSelector(txtFirstName), "Text", NameList[0]);
							UIActionExt(By.CssSelector(txtLastName), "Text", NameList[1]);
						}
						ClickSearchButton();
						UIActionExt(By.CssSelector(personList), "ispresent");
						if (driver.FindElement(By.CssSelector(personList)).Text == temp.GetTempValue("PL_ADDITIONAL_INSURED"))
                        {
                            Console.WriteLine("Verifying Person Contact is successful : " + driver.FindElement(By.CssSelector(personList)).Text);
                        }
                        else
                        {
                            Assert.Fail("Verifying Person Contact is not successful ");
                        }
                        break;
                    case "jeweler":
                        if (table.Rows[i]["CompanyName"].ToUpper().Trim() == "REGISTRY")
                        {
							UIActionExt(By.CssSelector(txtJewelerName), "Text", temp.GetTempValue("CC_Jeweler"));

						}
						ClickSearchButton();
						UIActionExt(By.CssSelector(personList), "ispresent");
						if (driver.FindElement(By.CssSelector(personList)).Text == temp.GetTempValue("CC_Jeweler"))
                        {
                            Console.WriteLine("Verifying Jeweler Contact is successful : " + driver.FindElement(By.CssSelector(personList)).Text);
                        }
                        else
                        {
                            Assert.Fail("Verifying Jeweler is not successful ");
                        }
                        break;
                    default:
                        break;

                }
                ClickResetButton();
            }
        }


		public void ClickSearchButton()
        {
			UIActionExt(By.CssSelector(btnSearch), "ispresent");
			UIActionExt(By.CssSelector(btnSearch), "click");
		}
		public void ClickResetButton()
        {
			UIActionExt(By.CssSelector(btnReset), "ispresent");
			UIActionExt(By.CssSelector(btnReset), "click");
		}
    }
}

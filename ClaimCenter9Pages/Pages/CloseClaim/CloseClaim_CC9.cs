using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium.Support.UI;

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class CloseClaim_CC9 : Page
    {
        string btnCloseClaim = "span[id$='CloseClaimPopup:CloseClaimScreen:Update-btnEl']";

        string txtCloseClaimNote = "textarea[id$=':CloseClaimInfoDV:Note-inputEl']";
		string txtCloseClaimOutcome = "input[id$=':Outcome-inputEl']";
		string lblCloseClaim = "span[id$=':State-btnInnerEl']";

        public CloseClaim_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnCloseClaim);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//a[id$='CloseClaimPopup:CloseClaimScreen:Update-btnInnerEl']"));

        }

        public void CloseCurrentClaim()
        {
			UIActionExt(By.CssSelector(txtCloseClaimNote), "Text", "Selenium Test Note");
			UIActionExt(By.CssSelector(txtCloseClaimOutcome), "List", "Payments Complete");
			UIActionExt(By.XPath("//span[text()[.='Force Close?']]"), "click");
			UIActionExt(By.CssSelector(btnCloseClaim), "click");
		}

        public void CloseCurrentClaim(Table table)
        {
			UIActionExt(By.CssSelector(txtCloseClaimNote), "Text", table.Rows[0]["Note"]);
			UIActionExt(By.CssSelector(txtCloseClaimOutcome), "List", table.Rows[0]["OutCome"]);
            if (table.Rows[0]["ForceClose"].ToLower().Trim() == "yes")
				UIActionExt(By.XPath("//span[text()[.='Force Close?']]"), "click");
			UIActionExt(By.CssSelector(btnCloseClaim), "click");
			VerifyClaimStatus(table.Rows[0]["ClaimStatus"]);
        }

        public void VerifyClaimStatus(string ClaimStatus)
        {
            string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";
            switch (ClaimStatus.ToLower().Trim())
            {
                case "open":
					UIActionExt(By.XPath("//span[@class='infobar_elem_val'][contains(text(),'Open')]"), "ispresent");
					Console.WriteLine("Claim " + driver.FindElement(By.CssSelector(lblCloseClaim)).Text);
                    List<IWebElement> IWbtnClear = driver.FindElements(By.CssSelector(btnClear)).ToList();
                    if (IWbtnClear.Count > 0)
                    {
                        IWbtnClear[0].Click();
                    }
                    break;
                default:
					UIActionExt(By.XPath("//span[@class='infobar_elem_val'][contains(text(),'Closed')]"), "ispresent","",0,12,5);
					Console.WriteLine("Claim " + driver.FindElement(By.CssSelector(lblCloseClaim)).Text);
                    break;
            }
        }

    }
}

using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;
namespace ClaimCenter9.Pages.Exposures
{
    public class ExposureTransactions_CC9 : Page
    {
        string btnReopenExposure = "span[id$='ClaimExposures:ClaimExposuresScreen:reopenExposure-btnInnerEl']";
        string txtReopenNote = "textarea[id='ReopenExposurePopup:ReopenExposureScreen:ReopenExposureInfoDV:Note-inputEl']";
        string btnReopenExp = "span[id='ReopenExposurePopup:ReopenExposureScreen:Update-btnInnerEl']";
		string lstReopenReason = "input[id$='ReopenExposureInfoDV:Reason-inputEl']";
		string lstCloseOutCome = "input[id$=':CloseExposureInfoDV:Outcome-inputEl']";
        string btnCloseExposure = "span[id$='ClaimExposures:ClaimExposuresScreen:ClaimExposures_CloseExposure-btnInnerEl']";
        string txtCloseNote = "textarea[id='CloseExposurePopup:CloseExposureScreen:CloseExposureInfoDV:Note-inputEl']";
        public ExposureTransactions_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {
        }
        public override void WaitForLoad()
        {
        }
        public void RepoenCloseExposure(Table table)
        {
			string btnUCloseExposure = "span[id$=':Update-btnInnerEl']";
			UIActionExt(By.XPath("//div[@class='x-grid-checkcolumn']"), "ispresent");
			List<IWebElement> selectAll = driver.FindElements(By.XPath("//div[@class='x-grid-checkcolumn']")).ToList();
			JavaScriptClick(selectAll[0]);
			switch (table.Rows[0]["Transaction"].ToLower().Trim())
			{
				case "reopen":
					UIActionExt(By.CssSelector(btnReopenExposure), "click");
					UIActionExt(By.CssSelector(txtReopenNote), "Text", table.Rows[0]["Note"]);
					UIActionExt(By.CssSelector(lstReopenReason), "List", table.Rows[0]["Reason"]);
					UIActionExt(By.CssSelector(btnReopenExp), "click");
					break;
				case "close":
					UIActionExt(By.CssSelector(btnCloseExposure), "click");
					UIActionExt(By.CssSelector(txtCloseNote), "Text", table.Rows[0]["Note"]);
					UIActionExt(By.CssSelector(lstCloseOutCome), "List", table.Rows[0]["Reason"]);
					UIActionExt(By.CssSelector(btnUCloseExposure), "click");
					UIActionExt(By.XPath("//span[@data-ref='btnInnerEl'][text()='OK']"), "click");
					WaitUntilElementVisible(driver, By.CssSelector("span[id='ClaimExposures:ClaimExposuresScreen:ttlBar']"));
					break;
				default:
					break;
			}
		}

	}
}

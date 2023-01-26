using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
namespace ClaimCenter9.Pages.ReopenClaim
{

    public class ReopenClaim_CC9 : Page
    {
        string btnReopenClaim = "span[id='ReopenClaimPopup:ReopenClaimScreen:Update-btnInnerEl']";
        string txtReopenClaimNote = "textarea[id='ReopenClaimPopup:ReopenClaimScreen:ReopenClaimInfoDV:Note-inputEl']";
		string lstReason = "input[id$=':Reason-inputEl']";
		string lblReopenClaim = "span[id$='Claim:ClaimInfoBar:State-btnInnerEl']";

        public ReopenClaim_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {

        }
        public override void WaitForLoad()
        {

        }
        public void ReopenCurrentClaim(Table table)
        {
			UIActionExt(By.CssSelector(txtReopenClaimNote), "ispresent");
			UIActionExt(By.CssSelector(txtReopenClaimNote), "Text", table.Rows[0]["Note"]);
			UIActionExt(By.CssSelector(lstReason), "List", table.Rows[0]["Reason"]);
			UIActionExt(By.CssSelector(btnReopenClaim), "click");
			UIActionExt(By.XPath("//span[@class='infobar_elem_val'][contains(text(),'Open')]"), "ispresent", "", 0, 12, 5);
			Console.WriteLine("Claim " + driver.FindElement(By.CssSelector(lblReopenClaim)).Text);
		}

    }
}

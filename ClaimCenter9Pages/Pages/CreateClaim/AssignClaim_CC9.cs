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

namespace ClaimCenter9Pages.Pages.CreateClaim
{
    public class AssignClaim_CC9 : Page
    {
         string btnAssign = "span[id$=':AssignmentPopupScreen_ButtonButton-btnInnerEl']";


        [FindsBy(How = How.Id, Using = "AssignClaimsPopup:AssignmentPopupScreen:AssignmentPopupDV:SelectFromList-inputEl")]
        public IWebElement txtAssignClaim;

        public AssignClaim_CC9(IWebDriver driver) : base(driver)
        {
            //WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //VerifyUIElementIsDisplayed(btnAssign);
        }

        public override void WaitForLoad()
        {
            //IsElementPresent(driver, By.CssSelector(btnAssign));
        }


      
        public void AssignClaimAction(string user)
        {
			string txtAssignClaim = "input[id$=':SelectFromList-inputEl']";
			//txtAssignClaim.Clear();
			//txtAssignClaim.SendKeys(user);
			//txtAssignClaim.SendKeys(Keys.Tab);
			//pause();
			//pause();
			//pause();
			//Console.WriteLine("click oin assgin button");
			//UIAction(btnAssign, string.Empty, "span");
			//pause();
			//pause();
			UIActionExt(By.CssSelector(txtAssignClaim), "ispresent");
			UIActionExt(By.CssSelector(txtAssignClaim), "List", user);
			UIActionExt(By.CssSelector(btnAssign), "click");
		}

		public void ReAssignClaimAction()
        {
			//pause();
			//UIAction(btnAssign, string.Empty, "span");
			//pause();
			UIActionExt(By.CssSelector(btnAssign), "ispresent");
			UIActionExt(By.CssSelector(btnAssign), "click");

		}


	}
}

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
using BillingCenterPages.Pages.Search;

namespace BillingCenterPages.Pages.NewPayment
{
    public class Payments : Page
    {

        //  string pmtActions = "a[id$=':ActionButton']";

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Actions')]]")]
        public IWebElement pmtActions;

        string menuReverse = "span[id$=':ActionButton:ReversePayment-textEl']";

        string menuMoveToAcct = "span[id$=':ActionButton:MoveToAccount-textEl']";
        string selAccountSearch = "a[id$=':AccountNumber:AccountPicker']";
        string btnExecuteWODistribution = "span[id$=':ExecuteWithoutDistribution-btnInnerEl']";

        [FindsBy(How = How.Id, Using = "AccountPayments:AccountDetailPaymentsScreen:ttlBar")]
        public IWebElement paymentsTitle;

        string selPmtReversalReason = "div[id$=':Reason-trigger-picker']";

        string btnOk = "span[id$=':Update-btnInnerEl']";

        [FindsBy(How = How.XPath, Using = "//li[text()[contains(.,'Applied')]]")]
        public IWebElement selOptionAppliedInError;

        [FindsBy(How = How.XPath, Using = "//li[text()[contains(.,'Reversal')]]")]
        public IWebElement selOptionReversalOnly;


        public Payments(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            WaitFor(paymentsTitle);

        }

        public override void WaitForLoad()
        {
            WaitFor(paymentsTitle);
        }

        public void ReverserPayment()
        {
            WaitFor(driver.FindElement(By.LinkText("Actions")));
            List<IWebElement> PageInputElements = driver.FindElements(By.LinkText("Actions")).ToList();
            for (int i = 0; i < PageInputElements.Count; i++)
            {
                PageInputElements[i].Click();
                WaitFor(driver.FindElement(By.CssSelector(menuReverse)));
                UIAction(menuReverse, string.Empty, "a");
                WaitFor(driver.FindElement(By.XPath("//*[@id='DBPaymentReversalConfirmationPopup:Reason-inputEl']")));
                switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
                {
                    case "stage":
                    case "qa2":
                        UIActionExt(By.XPath("//*[@id='DBPaymentReversalConfirmationPopup:Reason-inputEl']"), "List", "Applied in Error");
                        break;
                    default:
                        if(driver.FindElements(By.XPath("//li[text()[contains(.,'Reversal')]]")).Count() != 0)
                        {
                            UIActionExt(By.XPath("//*[@id='DBPaymentReversalConfirmationPopup:Reason-inputEl']"), "List", "Reversal Only");
                        }
                        else
                        {
                            UIActionExt(By.XPath("//*[@id='DBPaymentReversalConfirmationPopup:Reason-inputEl']"), "List", "Applied in Error");
                        }
                        break;
                }
                pause();
                UIAction(btnOk, string.Empty, "a");
                pause();
                break;
            }
        }

        public void MoveToAccount(string MovingAccount)
        {
            WaitFor(driver.FindElement(By.LinkText("Actions")));
            List<IWebElement> PageInputElements = driver.FindElements(By.LinkText("Actions")).ToList();
            for (int i = 0; i < PageInputElements.Count; i++)
            {
                PageInputElements[i].Click();
                pause();
                WaitFor(driver.FindElement(By.CssSelector(menuMoveToAcct)));
                UIAction(menuMoveToAcct, string.Empty, "a");
                pause();
                WaitFor(driver.FindElement(By.CssSelector(selAccountSearch)));
                UIAction(selAccountSearch, string.Empty, "a");
                pause();
                SearchAccounts searchAccounts = new SearchAccounts(driver);
                searchAccounts.SearchAccount(MovingAccount);
                pause();
                IWebElement BtnClickSelect = driver.FindElement(By.XPath("//a[text()[contains(.,'Select')]]"));
                BtnClickSelect.Click();
                pause();
                UIAction(btnExecuteWODistribution, string.Empty, "a");
                driver.FindElement(By.Id("AccountGroup:MenuLinks:AccountGroup_AccountOverview")).Click();
                break;
            }

        }


		public void ReverserAllPayments()
		{
			string lblPayments = "span[id$='AccountPayments:AccountDetailPaymentsScreen:ttlBar']";
			WaitUntilElementVisible(driver, By.CssSelector(lblPayments));
			List<IWebElement> PageInputElements = driver.FindElements(By.LinkText("Actions")).ToList();
			Console.WriteLine("Total Payments:" + PageInputElements.Count);
			if (PageInputElements.Count >= 0)
			{
				for (int i = 0; i < PageInputElements.Count; i++)
				{
					ReversePay();
					WaitUntilElementVisible(driver, By.CssSelector(lblPayments));
				}
			}
		}

		public void ReversePay()
		{
			List<IWebElement> PageInputElements = driver.FindElements(By.LinkText("Actions")).ToList();
			PageInputElements[0].Click();
			WaitFor(driver.FindElement(By.CssSelector(menuReverse)));
			UIAction(menuReverse, string.Empty, "a");
            //WaitFor(driver.FindElement(By.CssSelector(selPmtReversalReason)));
            //UIAction(selPmtReversalReason, string.Empty, "a");
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
			{
				case "stage":
                case "qa2":
                    //WaitFor(selOptionAppliedInError);
                    //selOptionAppliedInError.Click();
                    UIActionExt(By.XPath("//*[@id='DBPaymentReversalConfirmationPopup:Reason-inputEl']"), "Text", "Applied in Error");
                    break;
				default:
					WaitFor(selOptionReversalOnly);
					selOptionReversalOnly.Click();
					break;
			}
			UIAction(btnOk, string.Empty, "a");
		}

	}

}

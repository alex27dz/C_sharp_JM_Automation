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
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace PolicyCenter9Pages.Pages.Common
{
	public class AdminPage_PC9 : Page
	{
		string lnkAdministration = "span[id='TabBar:AdminTab-btnInnerEl']";
		string lnkDesktop = "span[id='TabBar:DesktopTab-btnInnerEl']";
		string lnkMonitoring = "//span[text()[contains(.,'Monitoring')]]";
		string lnkMsgQueues = "//span[text()[contains(.,'Message Queues')]]";
		string TblMsgQueues = "div[id$=':MessagingDestinationsControlLV-body']";
		string btnResume = "span[id$=':MessagingDestinationControlList_ResumeButton-btnInnerEl']";
		string btnSuspend = "span[id$=':MessagingDestinationControlList_SuspendButton-btnInnerEl']";
		string lblMessages = "span[id$='MessageSearch:MessageSearchScreen:ttlBar']";
		string lblMsgQueues = "span[id$='MessagingDestinationControlList:MessagingDestinationControlListScreen:ttlBar']";
		string lblMyActivities = "span[id$='DesktopActivities:DesktopActivitiesScreen:0']";
		string lnkMenu = "span[id=':tabs-menu-trigger-btnIconEl']";
		string lnkAdminInMenu = "//span[text()[contains(.,'Administration')]]";
		string lnkThunderHeadTransport = "a[id$=':MessagingDestinationsControlLV:0:DestinationName']";
		string messageFilter = "input[id$=':MessageControlForDestinationListLV:SOOMessageFilter-inputEl']";
		//string lnkAccountNo = "a[id$=':MessageControlForDestinationListLV:0:SOOName']";
		//string lnkSubmission = "a[id$=':MessageControlForSOOListLV:0:MessageName']";

		public AdminPage_PC9(IWebDriver driver) : base(driver)
		{
			WaitForPageLoad(driver);
		}

		public override void VerifyPage()
		{
			VerifyUIElementIsDisplayed(lnkAdministration);
		}

		public override void WaitForLoad()
		{
			IsElementPresent(driver, By.Id(lnkAdministration));
		}


		public void ManagePC9Trasport(string MsgServerStatus)
		{
			bool blNotStarted = false;
			bool blNotSuspended = false;
			openMessageQueue();
			Console.WriteLine("Status to verify: " + MsgServerStatus);
			var MsgMainTable = driver.FindElement(By.CssSelector(TblMsgQueues));
			List<IWebElement> lsGetTblElements = new List<IWebElement>(MsgMainTable.FindElements(By.TagName("table")));
			Console.WriteLine("Msg Queues Count: " + lsGetTblElements.Count);
			Console.WriteLine("Message Server\t\t\t\t\tStatus");
			for (int i = 0; i <= lsGetTblElements.Count - 1; i++)
			{
				List<IWebElement> lsGetTdElements = new List<IWebElement>(lsGetTblElements[i].FindElements(By.TagName("td")));
				Console.WriteLine("{0}\t\t\t\t\t{1}", lsGetTdElements[1].Text, lsGetTdElements[3].Text);
				if (lsGetTdElements[3].Text != MsgServerStatus)
				{

					switch (lsGetTdElements[3].Text.ToString().ToLower().Trim())
					{
						case "suspended":
							blNotStarted = true;
							string eleClass = lsGetTdElements[0].GetAttribute("class");
							lsGetTdElements[0].Click();
							if (eleClass != lsGetTdElements[0].GetAttribute("class") + " x-grid-item-focused")
								lsGetTdElements[0].SendKeys(Keys.Space);
							break;
						case "started":
							blNotSuspended = true;
							string ele_Class = lsGetTdElements[0].GetAttribute("class");
							lsGetTdElements[0].Click();
							if (ele_Class != lsGetTdElements[0].GetAttribute("class") + " x-grid-item-focused")
								lsGetTdElements[0].SendKeys(Keys.Space);
							break;
						default:
							break;
					}
				}
			}
			if (blNotStarted)
			{
				WaitFor(driver.FindElement(By.CssSelector(btnResume))).Click();
				WaitFor(driver.FindElement(By.CssSelector(lnkDesktop)));
			}
			if (blNotSuspended)
			{
				WaitFor(driver.FindElement(By.CssSelector(btnSuspend))).Click();
				WaitFor(driver.FindElement(By.CssSelector(lnkDesktop)));
			}
			JavaScriptClick(driver.FindElement(By.CssSelector(lnkDesktop)));
			WaitUntilElementVisible(driver, By.CssSelector(lblMyActivities));
		}
		public void verifyPayload(string payloadType)
		{
			openMessageQueue();
			UIAction(lnkThunderHeadTransport, string.Empty, "a");
			driver.FindElement(By.CssSelector(messageFilter)).Clear();
			UIAction(messageFilter, "Accounts with any unfinished messages", "textbox");
			driver.FindElement(By.CssSelector(messageFilter)).Click();
			string accountNo = (string)ScenarioContext.Current["ACCOUNT"];
			driver.FindElement(By.LinkText(accountNo)).Click();
			switch (payloadType.ToString().ToLower().Trim())
			{
				case "submission":
					IList<IWebElement> events =  driver.FindElements(By.LinkText("IssueSubmission"));
					events[0].Click();
					string payload = driver.FindElement(By.Id("MessagePayloadPopup:MessagePayloadScreen:PayLoadDV:Payload-inputEl")).Text;
					XmlDocument xmlDoc = new XmlDocument();
					xmlDoc.LoadXml(payload);
					var documentNodes = xmlDoc.GetElementsByTagName("DocumentName");
					var accNoNodes = xmlDoc.GetElementsByTagName("AccountNumber");
					Console.WriteLine(documentNodes[0].InnerText);
					Console.WriteLine(accNoNodes[0].InnerText);
					Assert.AreEqual(accountNo, accNoNodes[0].InnerText, false, "account number doesn't match");
					Assert.AreEqual("Submission", documentNodes[0].InnerText);
					string returnToAccNo = "Return to Account Number: " + accountNo;
					driver.FindElement(By.LinkText(returnToAccNo)).Click();
					//Look for thank you email payload
					if(ScenarioContext.Current.ContainsKey("Product"))
                    {
						//check for no thank you email
						Console.WriteLine(ScenarioContext.Current["Product"].ToString());
						Assert.IsTrue(events.Count == 1);
                    }
                    else
                    {
						Console.WriteLine("Check for thank you email payload");
						IList<IWebElement> eventNames = driver.FindElements(By.LinkText("IssueSubmission"));

						eventNames[1].Click();
						string thanksEmailPayload = driver.FindElement(By.Id("MessagePayloadPopup:MessagePayloadScreen:PayLoadDV:Payload-inputEl")).Text;
						XmlDocument thanksXmlDoc = new XmlDocument();
						xmlDoc.LoadXml(thanksEmailPayload);
						//var thanksEmailPayload = thanksXmlDoc.GetElementsByTagName("DocumentName");
						//Console.WriteLine(documentNodes[0].InnerText);
						Console.WriteLine(thanksEmailPayload);


						driver.FindElement(By.LinkText(returnToAccNo)).Click();
						//check fpr thank you email
					}				
					break;
				default:
					break;
			}
			System.Threading.Thread.Sleep(5000);
			ManagePC9Trasport("Started");
		}
		private void openMessageQueue()
		{
			try
			{
				WaitFor(driver.FindElement(By.CssSelector(lnkMenu)));
				UIAction(lnkMenu, string.Empty, "a");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			IList<IWebElement> adminToolbarButton = driver.FindElements(By.XPath(lnkAdminInMenu));
			Console.WriteLine("Number of Admin button is " + adminToolbarButton.Count());
			if (adminToolbarButton.Count() == 2)
			{
				Console.WriteLine("Going to clikc Admin button in Menu");
				IWebElement adminInMenu = adminToolbarButton[1];
				adminInMenu.Click();
			}
			else
			{
				WaitFor(driver.FindElement(By.CssSelector(lnkAdministration))).Click();
				//adminToolbarButton[0].Click();
			}
			WaitFor(driver.FindElement(By.XPath(lnkMonitoring))).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lblMessages));
			WaitFor(driver.FindElement(By.XPath(lnkMsgQueues))).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lblMsgQueues));
			WaitFor(driver.FindElement(By.CssSelector(TblMsgQueues)));
		}

	}
}

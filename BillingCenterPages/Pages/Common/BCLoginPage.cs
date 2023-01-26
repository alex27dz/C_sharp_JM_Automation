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
using OpenQA.Selenium.Interactions;

namespace BillingCenterPages.Pages.Common
{
    public class BCLoginPage : Page
    {
        string username = "input[id$=':username-inputEl']";

        string password = "input[id$=':password-inputEl']";

        string btnLogin = "span[id$=':submit-btnInnerEl']";
        public BCLoginPage(IWebDriver driver) : base(driver)
        {
           // System.Threading.Thread.Sleep(5000);
           
            WaitForPageLoad(driver);

            
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(username);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(username));
        }

        public void LoginIntoBC(string userName, string passWord)
        {
			UIActionExt(By.CssSelector(username), "Text", userName);
			UIActionExt(By.CssSelector(password), "Text", passWord);
			UIActionExt(By.CssSelector(btnLogin), "click");
			////List<string> lstWindow = driver.WindowHandles.ToList();
			////foreach (var handle in lstWindow)
			////{
			////    Console.WriteLine(handle);
			////}

			////Actions action = new Actions(driver);

			////action.SendKeys(userName).Build().Perform();

			////action.SendKeys(Keys.Tab).Build().Perform();

			////action.SendKeys(passWord).Build().Perform();

			////action.SendKeys(Keys.Tab).Build().Perform();

			////action.DoubleClick();
			////pause();
			////pause();
			////IList<IWebElement> Popup = driver.FindElements(By.Id("tool-1011")).ToList();
			////Console.WriteLine("Popups: " + Popup.Count());
			////if (Popup.Count() > 0)
			////{
			////    Popup[0].Click();
			////}

			//IWebElement test = driver.FindElement(By.CssSelector(username));

			//Console.WriteLine("User Login Page displayed: " + test.Displayed);

			//// System.Threading.Thread.Sleep(30000);

			//WaitForEnabled(driver.FindElement(By.CssSelector(username)));

			////   IList<IWebElement> userNam = driver.FindElements(By.CssSelector(username)).ToList();

			////  Console.WriteLine("Username:" + userNam.Count);

			//// Actions action = new Actions(driver);

			//// userNam[0].Click();

			//// action.SendKeys(userName).SendKeys(Keys.Tab).Build().Perform();
			//// action.Release();
			//System.Threading.Thread.Sleep(5000);
			//IList<IWebElement> DOMDialogBox = driver.FindElements(By.XPath("//a[@id='button-1005']")).ToList();
			//Console.WriteLine("DOM Dialogbox: " + DOMDialogBox.Count);
			//if (DOMDialogBox.Count == 1)
			//{
			//    //DOMDialogBox[0].Click();
			//    Console.WriteLine("-------START-PageSource before clicking DOM button\n\n");
			//    Console.WriteLine(driver.PageSource);
			//    Console.WriteLine("\n\n-------END-PageSource before clicking DOM button");

			//    IJavaScriptExecutor jsBtn = (IJavaScriptExecutor)driver;
			//    jsBtn.ExecuteScript("document.getElementById('button-1005').click()");
			//    System.Threading.Thread.Sleep(2000);
			//    Console.WriteLine("Clicked DOM Storage button");
			//    System.Threading.Thread.Sleep(5000);
			//    Console.WriteLine("-------START-PageSource after clicking DOM button\n\n");
			//    Console.WriteLine(driver.PageSource);
			//    Console.WriteLine("\n\n-------END-PageSource after clicking DOM button");
			//    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
			//    js.ExecuteScript("document.getElementById('Login:LoginScreen:LoginDV:username-inputEl').value='su'");
			//    System.Threading.Thread.Sleep(2000);
			//    js.ExecuteScript("document.getElementById('Login:LoginScreen:LoginDV:password-inputEl').value='gw'");
			//    System.Threading.Thread.Sleep(2000);
			//    js.ExecuteScript("document.getElementById('Login:LoginScreen:LoginDV:submit-btnInnerEl').click()");
			//    System.Threading.Thread.Sleep(2000);
			//    System.Threading.Thread.Sleep(5000);
			//    Console.WriteLine("-------START-PageSource after clicking Submit button\n\n");
			//    Console.WriteLine(driver.PageSource);
			//    Console.WriteLine("\n\n-------END-PageSource after clicking Submit button");
			//    driver.Navigate().Refresh();
			//    System.Threading.Thread.Sleep(5000);
			//    IList<IWebElement> DOMDialogBox2 = driver.FindElements(By.XPath("//a[@id='button-1005']")).ToList();
			//    Console.WriteLine("DOM Dialogbox: " + DOMDialogBox2.Count);
			//    if (DOMDialogBox2.Count == 1)
			//    {
			//        IJavaScriptExecutor jsBtn1 = (IJavaScriptExecutor)driver;
			//        jsBtn1.ExecuteScript("document.getElementById('button-1005').click()");
			//        System.Threading.Thread.Sleep(2000);
			//        Console.WriteLine("Clicked DOM Storage button");
			//    }
			//    driver.Manage().Window.Maximize();
			//    System.Threading.Thread.Sleep(5000);
			//    Console.WriteLine("-------START-PageSource after doing page refresh\n\n");
			//    Console.WriteLine(driver.PageSource);
			//    Console.WriteLine("\n\n-------END-PageSource after doing page refresh");
			//}

			//else
			//{

			//    //--
			//    UIAction(username, userName, "textbox");
			//    // action = new Actions(driver);
			//    // IList<IWebElement> userpwd = driver.FindElements(By.CssSelector(password)).ToList();

			//    // userpwd[0].Click();

			//    //action.SendKeys(passWord).Build().Perform();


			//    //  userpwd[0].SendKeys(passWord);

			//    // Console.WriteLine("====="+driver.PageSource);

			//    UIAction(password, passWord, "textbox");

			//    // System.Threading.Thread.Sleep(30000);


			//    UIAction(btnLogin, string.Empty, "span");

			//    // System.Threading.Thread.Sleep(30000);
			//    //--
			//    pause();

			//    //System.Threading.Thread.Sleep(30000);


			//    for (int i = 0; i <= 3; i++)
			//    {

			//        try
			//        {
			//            IAlert alert = driver.SwitchTo().Alert();
			//            alert.Accept();
			//        }
			//        catch (NoAlertPresentException Ex)
			//        {
			//            //   Console.WriteLine(Ex.InnerException.ToString());
			//        }
			//    }
			//}
			////  for(int i=0;i<=3;i++)
			////  { 

			////      try
			////      {
			////          IAlert alert = driver.SwitchTo().Alert();
			////          alert.Accept();
			////      }
			////      catch (NoAlertPresentException Ex)
			////      {
			////          //   Console.WriteLine(Ex.InnerException.ToString());
			////      }
			////  }

			////  WaitForPageLoad(driver);

			//////  Actions action = new Actions(driver);

			////  for (int i=0;i<16;i++)
			////  {

			////      Console.WriteLine("Here"+i);

			////      action.SendKeys(Keys.Tab).Build().Perform();
			////  //    System.Windows.Forms.SendKeys.SendWait("{TAB}");
			////      pause();
			////  }
			////  //  System.Windows.Forms.SendKeys.SendWait("{ENTER}");
			////  action.SendKeys(Keys.Enter).Build().Perform();

			////  action.Release();

			////  System.Threading.Thread.Sleep(30000);
		}
    }
}

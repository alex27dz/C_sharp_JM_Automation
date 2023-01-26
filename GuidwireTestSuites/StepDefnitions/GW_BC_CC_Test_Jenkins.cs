using System;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    public class GW_BC_CC_Test_Jenkins : TestBase
    {
        [Given(@"I enter below details to login into (.*) application")]
        [When(@"I enter below details to login into (.*) application")]
        public void GivenIEnterBelowDetailsToLoginIntoApplication(string App, Table table)
        {
            string userName = table.Rows[0]["UserName"].ToString();
            string password = table.Rows[0]["Password"].ToString();

            LoginBC_CCApp LoginToCCBCFrmJenkins = new LoginBC_CCApp(getDriver());
            LoginToCCBCFrmJenkins.LoginIntoCCJenkinsTest(App, userName, password);
        }
        [Given(@"I enter below details to login into (.*) application using Javascript")]
        [When(@"I enter below details to login into (.*) application using Javascript")]
        public void GivenIEnterBelowDetailsToLoginIntoApplicationUsingJavascript(string App, Table table)
        {
            string userName = table.Rows[0]["UserName"].ToString();
            string password = table.Rows[0]["Password"].ToString();

            LoginBC_CCApp LoginToCCBCFrmJenkins = new LoginBC_CCApp(getDriver());
            LoginToCCBCFrmJenkins.LoginIntoCCJenkinsTest_JavaScript(App, userName, password);
        }
        [Given(@"I enter below details to login into (.*) application using WebDriver")]
        [Then(@"I enter below details to login into (.*) application using WebDriver")]
        public void ThenIEnterBelowDetailsToLoginIntoApplicationUsingWebDriver(string App, Table table)
        {
            string url = table.Rows[0]["url"].ToString();
            string userName = table.Rows[0]["UserName"].ToString();
            string password = table.Rows[0]["Password"].ToString();
            string txtusername = "input[id$=':username-inputEl']";
            string txtpassword = "input[id$=':password-inputEl']";
            string btnLogin = "span[id$=':submit-btnInnerEl']";
            string logOut = "span[id=':TabLinkMenuButton-btnIconEl']";
            string logOutLink = "span[id='TabBar:LogoutTabBarLink-textEl']";

            
            System.Threading.Thread.Sleep(2000);
            //System.Environment.SetEnvironmentVariable("webdriver.ie.driver", @"C:\IEDriver\IEDriverServer.exe");
            //DesiredCapabilities capabilities = DesiredCapabilities.InternetExplorer();
            //capabilities.SetCapability("ignoreProtectedModeSettings", true);
            //capabilities.SetCapability("webStorageEnabled",true);
            //newWebDriver = new InternetExplorerDriver(capabilities);
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.EnsureCleanSession = true;
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            options.RequireWindowFocus = true;
            //options.EnableNativeEvents = false;
            options.UnexpectedAlertBehavior = InternetExplorerUnexpectedAlertBehavior.Dismiss;
            options.AddAdditionalCapability("webStorageEnabled", true);
            IWebDriver newWebDriver = new InternetExplorerDriver(@"C:\IEDriver", options);
            newWebDriver.Navigate().GoToUrl(url);
            newWebDriver.Manage().Window.Maximize();
			System.Threading.Thread.Sleep(5000);
			//IJavaScriptExecutor js1 = (IJavaScriptExecutor)newWebDriver;
			//Console.WriteLine("LocalStorageValue NewWebDriver" + (String)js1.ExecuteScript("return localStorage.getItem('key')"));

			IList<IWebElement> DOMDialogBox = newWebDriver.FindElements(By.XPath("//a[@id='button-1005']")).ToList();
            Console.WriteLine("DOM Dialogbox: " + DOMDialogBox.Count);
            if (DOMDialogBox.Count == 1)
            {
                
                DOMDialogBox[0].Click();
                System.Threading.Thread.Sleep(2000);
            }
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " before submitting user name------------------------");
            Console.WriteLine(newWebDriver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " before submitting user name------------------------");
            System.Threading.Thread.Sleep(2000);
            newWebDriver.FindElement(By.CssSelector(txtusername)).SendKeys(userName);
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " username------------------------");
            Console.WriteLine(newWebDriver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " username------------------------");
            System.Threading.Thread.Sleep(2000);
            newWebDriver.FindElement(By.CssSelector(txtpassword)).SendKeys(password);
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " password------------------------");
            Console.WriteLine(newWebDriver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " password------------------------");
            System.Threading.Thread.Sleep(2000);
            newWebDriver.FindElement(By.CssSelector(btnLogin)).Click();
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " after submit------------------------");
            Console.WriteLine(newWebDriver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE CC after submit------------------------");

            newWebDriver.FindElement(By.CssSelector(logOut)).Click();
            System.Threading.Thread.Sleep(2000);
            newWebDriver.FindElement(By.CssSelector(logOutLink)).Click();
            System.Threading.Thread.Sleep(2000);
            newWebDriver.Quit();
        }

    }

    public class LoginBC_CCApp : Page
    {
        string txtusername = "input[id$=':username-inputEl']";
        string txtpassword = "input[id$=':password-inputEl']";
        string btnLogin = "span[id$=':submit-btnInnerEl']";
        public LoginBC_CCApp(IWebDriver driver) : base(driver)
        {
            //System.Threading.Thread.Sleep(2000);
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtusername);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtusername));
        }

        public void LoginIntoCCJenkinsTest(string App, string userName, string passWord)
        {
            IWebElement test = driver.FindElement(By.CssSelector(txtusername));
            Console.WriteLine("User Login Page displayed: " + test.Displayed);
            System.Threading.Thread.Sleep(5000);
			//IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
			//Console.WriteLine("LocalStorageValue Regular" + (String)js1.ExecuteScript("return localStorage.getItem('key')"));
			IList<IWebElement> DOMDialogBox = driver.FindElements(By.XPath("//a[@id='button-1005']")).ToList();
            Console.WriteLine("DOM Dialogbox: " + DOMDialogBox.Count);
            if (DOMDialogBox.Count == 1)
            {
                DOMDialogBox[0].Click();
                System.Threading.Thread.Sleep(2000);
            }
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " before submitting user name------------------------");
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " before submitting user name------------------------");
            UIAction(txtusername, userName, "textbox");
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " username------------------------");
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " username------------------------");
            UIAction(txtpassword, passWord, "textbox");
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " password------------------------");
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " password------------------------");
            UIAction(btnLogin, string.Empty, "span");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " after submit------------------------");
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE CC after submit------------------------");
        }

        public void LoginIntoCCJenkinsTest_JavaScript(string App, string userName, string passWord)
        {
            IWebElement test = driver.FindElement(By.CssSelector(txtusername));
            Console.WriteLine("User Login Page displayed: " + test.Displayed);
            System.Threading.Thread.Sleep(5000);
			//IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
			//Console.WriteLine("LocalStorageValue JavaScript" + (String)js1.ExecuteScript("return localStorage.getItem('key')"));
			IList<IWebElement> DOMDialogBox = driver.FindElements(By.XPath("//a[@id='button-1005']")).ToList();
            Console.WriteLine("DOM Dialogbox: " + DOMDialogBox.Count);
            if (DOMDialogBox.Count == 1)
            {
                //DOMDialogBox[0].Click();
                IJavaScriptExecutor jsBtn = (IJavaScriptExecutor)driver;
                jsBtn.ExecuteScript("document.getElementById('button-1005').click()");
                System.Threading.Thread.Sleep(2000);
            }

            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " before submitting user name------------------------");
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " before submitting user name------------------------");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('Login:LoginScreen:LoginDV:username-inputEl').value='su'");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " username------------------------");
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " username------------------------");
            js.ExecuteScript("document.getElementById('Login:LoginScreen:LoginDV:password-inputEl').value='gw'");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " password------------------------");
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE " + App + " password------------------------");
            js.ExecuteScript("document.getElementById('Login:LoginScreen:LoginDV:submit-btnInnerEl').click()");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("---------------------------------START PAGE SOURCE " + App + " after submit------------------------");
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("---------------------------------END PAGE SOURCE CC after submit------------------------");
        }

    }


}

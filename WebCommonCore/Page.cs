using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebCommonCore
{
    /// <summary>
    /// Class for the Page
    /// </summary>
    public abstract class Page
    {
        /// <summary>
        /// Variable for the logger class
        /// </summary>
        public static readonly ILog logger = LogManager.GetLogger(typeof(Page));
        
        /// <summary>
        /// The active driver 
        /// </summary>
        public IWebDriver driver { get; set; }

        /// <summary>
        /// The Wait object
        /// </summary>
        public WebDriverWait wait { get; set; }

        /// <summary>
        /// Abstract method VerifyPage, which needs to be implemented in the class derived from the page class.
        /// </summary>
        public abstract void VerifyPage();

        /// <summary>
        /// Abstract method WaitForLoad, which needs to be implemented in the class derived from the page class.
        /// </summary>
        public abstract void WaitForLoad();

        /// <summary>
        /// Constructor for the Page class
        /// </summary>
        /// <param name="driver">Active driver</param>
        protected Page(IWebDriver driver)
        {
            logger.Info("Initializing page.");

            this.driver = driver;

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

            PageFactory.InitElements(driver, this);

            driver.SwitchTo().DefaultContent();

            WaitForLoad();

            VerifyPage();

        }

        /// <summary>
        /// Method to wait for the page to comlete loading
        /// </summary>
        /// <param name="driver">Active Driver</param>
        /// <param name="timeoutSec">Timeout</param>
        public static void WaitForPageLoad(IWebDriver driver, double timeoutSec = 30)
        {
            // WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec));
            // wait.Until(wd => wd.ExecuteScript("return document.readyState") == "complete");
            //  (((IJavaScriptExecutor)driver.ExecuteScript("return document.readyState"),"complete");

            //  ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);

            //    IWait<IWebDriver> pageWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

            IWait<IWebDriver> pageWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSec));

            pageWait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

        }

        /// <summary>
        /// Method to wait until the element is visible
        /// </summary>
        /// <param name="currentDriver">Current Webdriver</param>
        /// <param name="byDetail">By Location mechanism</param>
        /// <param name="timeoutSec">Timeout</param>
        /// <returns>true or false, based on the visibility of the element</returns>
        public bool WaitUntilElementVisible(IWebDriver currentDriver, By byDetail, double timeoutSec = BaseClass.TIME_TO_WAIT)
        {
            bool condition = true;

            try
            {
                WebDriverWait wait = new WebDriverWait(currentDriver, System.TimeSpan.FromSeconds(timeoutSec));

                wait.Until(ExpectedConditions.ElementIsVisible(byDetail));
            }
            catch (System.Exception ex)
            {
                condition = false;
                throw ex;

            }
            return condition;
        }

        /// <summary>
        /// Method to wait until the element is enabled
        /// </summary>
        /// <param name="currentDriver">Current Webdriver</param>
        /// <param name="byDetail">By Location mechanism</param>
        /// <param name="timeoutSec">Timeout</param>
        /// <returns>true or false, based on the element being enabled or disabled</returns>
        public bool WaitUntilElementEnabled(IWebDriver currentDriver, By byDetail, double timeoutSec = BaseClass.TIME_TO_WAIT)
        {
            bool condition = true;

            try
            {
                WebDriverWait wait = new WebDriverWait(currentDriver, System.TimeSpan.FromSeconds(timeoutSec));

                wait.Until(ExpectedConditions.ElementToBeClickable(byDetail));
            }
            catch (System.Exception ex)
            {
                condition = false;
                throw ex;

            }
            return condition;
        }

        /// <summary>
        /// Method to wait until the element is Invisible
        /// </summary>
        /// <param name="currentDriver">Current Webdriver</param>
        /// <param name="byDetail">By Location mechanism</param>
        /// <param name="timeoutSec">Timeout</param>
        /// <returns>true or false, based on the Invisibility of the element</returns>
        public bool WaitUntilElementInvisible(IWebDriver currentDriver, By byDetail , double timeoutSec = BaseClass.TIME_TO_WAIT)
        {
            bool condition = true;

            try
            {
                WebDriverWait wait = new WebDriverWait(currentDriver, System.TimeSpan.FromSeconds(timeoutSec));

                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(byDetail));
            }
            catch (System.Exception ex)
            {
                condition = false;
                throw ex;

            }
            return condition;
        }

        /// <summary>
        /// Method to wait until the element is Displayed
        /// </summary>
        /// <param name="currentDriver">Current Webdriver</param>
        /// <param name="byDetail">By Location mechanism</param>
        /// <returns>true or false, based on weather the element is displayed or not</returns>
        public static void WaitUntilElementIsDisplayed(IWebDriver currentDriver, By byDetail)
        {
            bool isElementDisplayed = false;

            do
            {
                System.Threading.Thread.Sleep(500);

                isElementDisplayed = IsElementPresent(currentDriver, byDetail);

            } while (isElementDisplayed);

            //    if (isElementDisplayed)
            //        elementFound = true;
            //    else
            //        Assert.Fail("Element not displayed:"+byDetail);

        }

        /// <summary>
        /// Method to Select an radio box or Check box
        /// </summary>
        /// <param name="item">Item</param>
        public void SelectBox(IWebElement item)
        {
            if (!item.Selected)
                item.Click();
        }


        /// <summary>
        /// Method to Unselect Select an radio box or Check box
        /// </summary>
        /// <param name="item">Item</param>
        public void UnSelectBox(IWebElement item)
        {
            if (item.Selected)
                item.Click();
        }

        /// <summary>
        /// Method to Select a value from a dropdown list box 
        /// </summary>
        /// <param name="selElement">Drop down list box</param>
        /// <param name="text">Text to select from the dropdown list</param>
        public void SelectByText(IWebElement selElement, String text)
        {
            SelectElement item = new SelectElement(selElement);

            item.SelectByText(text);
        }

        /// <summary>
        /// Method to Select a value based on index from a dropdown list box 
        /// </summary>
        /// <param name="selElement">Drop down list box</param>
        /// <param name="index">Imdex of the value to select from the dropdown list</param>
        public void SelectByIndex(IWebElement selElement, int index)
        {
            SelectElement item = new SelectElement(selElement);

            item.SelectByIndex(index);
        }

        /// <summary>
        /// Method to Select a value from a dropdown list box 
        /// </summary>
        /// <param name="selElement">Drop down list box</param>
        /// <param name="value">Value to select from the dropdown list</param>
        public void SelectByValue(IWebElement selElement, String value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return;
            }

            SelectElement item = new SelectElement(selElement);

            item.SelectByValue(value);
        }

        /// <summary>
        /// Method to special click on a WebElement
        /// </summary>
        /// <param name="element">The WebElement to click on</param>
        public void SpecialClick(IWebElement element)
        {
            Actions actions = new Actions(driver);

            actions.MoveToElement(element);

            actions.Click().Build().Perform();

        }

        /// <summary>
        /// Method to perform a click on a webelement using Java Script
        /// </summary>
        /// <param name="element">The WebElement to click on</param>
        public void JavaScriptClick(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
        }

        /// <summary>
        /// Method to change the Wait time
        /// </summary>
        /// <param name="waitTime">Wait time value</param>
        public void ChangeWait(int waitTime)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(waitTime));
        }

        /// <summary>
        /// Method to reset the wait time
        /// </summary>
        public void ResetWait()
        {
            driver.Manage().Timeouts().ImplicitlyWait(BaseClass.ImplicitWait);
        }

        /// <summary>
        /// Method to wait for an element to be ready to continue using it
        /// </summary>
        /// <param name="element">The WebElement we are waiting on</param>
        /// <returns>The WebElement which is ready for use.</returns>
        protected IWebElement WaitFor(IWebElement element)
        {
            ExpectedConditions.ElementSelectionStateToBe(element, false);

            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        /// <summary>
        ///  Method to wait for an element to be ready to selected
        /// </summary>
        /// <param name="element">The WebElement we are waiting on to be selected.</param>
        protected void WaitForSelected(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeSelected(element));
        }

        /// <summary>
        ///  Method to wait for an element to be populated
        /// </summary>
        /// <param name="element">The WebElement we are waiting on to be populated.</param>
        /// <param name="text">The text to verify on the WebElement.</param>
        protected void WaitForPopulated(IWebElement element, String text)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementValue(element, text));
        }

        /// <summary>
        /// Method to wait for an element to be Enabled
        /// </summary>
        /// <param name="element">The WebElement we are waiting on to be enabled</param>
        protected void WaitForEnabled(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        /// <summary>
        /// Method to pause for half a second.
        /// </summary>
        public void pause()
        {
            System.Threading.Thread.Sleep(500);
        }

        /// <summary>
        /// MMethod to perform a key board action by pressing the enter key.
        /// </summary>
        /// <param name="driver">The Current driver</param>
        public void ClickEnter(IWebDriver driver)
        {
            Actions action = new Actions(driver);

            action.KeyUp(Keys.Enter);

        }

        /// <summary>
        /// Method to select a value from a dropdown list box using a Xpath
        /// </summary>
        /// <param name="driver">The Current Driver</param>
        /// <param name="elementXpath">Xpath of the element</param>
        /// <param name="value">Value which you want to select</param>
        public void SelectFromDropdownByXpath(IWebDriver driver, string elementXpath, string value)
        {
            IWebElement element = driver.FindElement(By.XPath(elementXpath));

            element.Click();

            IList<IWebElement> list = driver.FindElements(By.XPath(elementXpath));

            foreach (IWebElement options in list)
            {
                if (options.Text.Equals(value))
                {
                    options.Click();
                }
            }


        }

        /// <summary>
        /// Method to refresh the page curently having focus
        /// </summary>
        /// <param name="driver">The current driver</param>
        public void PageRefresh(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//body")).SendKeys(Keys.F5);
        }

        /// <summary>
        /// Method to verify if an element is present.
        /// </summary>
        /// <param name="driver">Current Webdriver</param>
        /// <param name="by">By Location mechanism</param>
        /// <returns>true or false based on whether the element is present or not</returns>
        public static bool IsElementPresent(IWebDriver driver, By by)
        {
            driver.Manage().Timeouts().ImplicitlyWait(BaseClass.NoWait);

            try
            {
                if (driver.FindElement(by).Displayed)
                    return true;

                driver.Manage().Timeouts().ImplicitlyWait(BaseClass.ImplicitWait);

                return driver.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                driver.Manage().Timeouts().ImplicitlyWait(BaseClass.ImplicitWait);

                return false;
            }
        }

        /// <summary>
        /// Method to check for brokwn images on the current page
        /// </summary>
        /// <param name="driver">The current driver</param>
        public static void CheckForBrokenImages(IWebDriver driver)
        {
            List<IWebElement> images = driver.FindElements(By.CssSelector("img")).ToList();

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            Console.WriteLine("Images Count : {0}", images.Count);

            for (int i = 0; i < images.Count; i++)
            {
                IWebElement currentImage = images[i];

                Console.WriteLine("Base URI: " + currentImage.GetAttribute("src").ToString());

                Boolean imagePresent = false;

                try
                {
                    imagePresent = (Boolean)(js.ExecuteScript("return arguments[0].complete && typeof arguments[0].naturalWidth != \"undefined\" && arguments[0].naturalWidth > 0", currentImage));

                    if (!imagePresent)
                        imagePresent = currentImage.Displayed;

                    if (!imagePresent)
                    {
                        Assert.Inconclusive("Image is not loaded:");
                    }
                    else
                    {
                        Console.WriteLine("Image is Loaded.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                
            }
        }

        /// <summary>
        /// Method to verify if the UI element is displayed.
        /// </summary>
        /// <param name="CSS">CSS selector of the UI element</param>
        public void VerifyUIElementIsDisplayed(string CSS)
        {
            List<IWebElement> PageInputElements = null;

            string prefix = CSS.Substring(0, 2);
            if (prefix.Equals("//"))
            {
                PageInputElements = driver.FindElements(By.XPath(CSS)).ToList();

                if (!(PageInputElements.Count > 0))
                    Assert.Fail("Element Not displayed.{0}", CSS);
            }
            else
            {
                PageInputElements = driver.FindElements(By.CssSelector(CSS)).ToList();

                if (!(PageInputElements.Count > 0))
                    Assert.Fail("Element Not displayed.{0}", CSS);
            }
            
        }

        /// <summary>
        /// Method to verify a message displayed on the application.
        /// </summary>
        /// <param name="message">Message text to verify.</param>
        public void verifyMessage(string message)
        {
            string messageCSS = "div[class='message']";

            List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(messageCSS)).ToList();

            Assert.AreEqual(PageInputs[0].Text.ToLower().Trim(), message.ToLower().Trim(), "Values dont match");

        }

        /// <summary>
        /// Method to get a value of a Element using Java script
        /// </summary>
        /// <param name="Element">Element which we want to get the value from.</param>
        /// <returns></returns>
        public string getJSElementValue(string Element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            string currentValue = (string)js.ExecuteScript("return document.getElementById('" + Element + "').value");

            return currentValue;

        }

        /// <summary>
        /// Method to perform an UI Action, such as Entering a value into a textbox, select a value from drop down etc.,
        /// </summary>
        /// <param name="CSS">CSS selector of th element</param>
        /// <param name="valueToEnter">If we want to enter a value into textbox, we pass this value, for all others is left as blank</param>
        /// <param name="objType">Type of the UI object</param>
        public void UIAction(string CSS, string valueToEnter, string objType)
        {
            Console.WriteLine("Trying to get object with CSS:{0} and object type:{1}", CSS, objType);

            List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(CSS)).ToList();

            if (PageInputElements.Count > 0)
            {
                switch (objType.ToLower().Trim())
                {
                    case "textbox":
                        Console.WriteLine("Value to Enter:{0}", valueToEnter);
                        PageInputElements[0].SendKeys(valueToEnter);
                        break;

                    case "button":
                    case "a":
                    case "span":
                    case "radio":
                        Console.WriteLine("Trying to click on a button, link , radio or span .Objects Count" + PageInputElements.Count);
                        PageInputElements[0].Click();
                        break;

                    case "selectbox":
                        Console.WriteLine("Trying to select a value from dropdown:{0}", valueToEnter);
                        int n;
                        bool isNumeric = int.TryParse(valueToEnter, out n);
                        if (isNumeric)
                            SelectByIndex(PageInputElements[0], int.Parse(valueToEnter));
                        else
                            SelectByText(PageInputElements[0], valueToEnter);
                        break;

                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine("Element with CSS {0) not displayed.", CSS.ToString());
            }

        }

        /// <summary>
        /// Method to perform an UI Action, such as Entering a value into a textbox, select a value from drop down , sync elementetc.,
        /// </summary>
        /// <param name="ByElement"> Locator </param>
        /// <param name="ActionType"> Type of action to perform</param>
        /// <param name="ValueToEnter">Value to Enter</param>
        /// <param name="iIndex">index of the element</param>
        /// <param name="bLoop">Break Loop</param>
        /// <param name="iWaitTime">Wait time passed to WaitUntilElementVisible method</param>
        public void UIActionExt(By ByElement, string ActionType = "verify", string ValueToEnter = "", int iIndex = 0, int bLoop = 5, double iWaitTime = 5)
        {
            int ibloop = 1;
            bool Done = false;
            do
            {
                try
                {
                    if (IsElementPresent(driver, ByElement) == false)
                    {
                        WaitUntilElementVisible(driver, ByElement, 1);
                    }
                    List<IWebElement> ThisWebElement = driver.FindElements(ByElement).ToList();

                    if ((ThisWebElement.Count > 1) && (iIndex == 0))
                    {
                        int i = 1;
                        Console.WriteLine("--------------More than 1 Item Found------------");
                        foreach (var item in ThisWebElement)
                        {
                            if (item.Text != "")
                            {
                                Console.WriteLine("{0}.Text: {1}", i, item.Text);
                            }
                            else if (item.GetAttribute("innerHTML") != "")
                            {
                                Console.WriteLine("{0}.innerHTML: {1}", i, item.GetAttribute("innerHTML"));
                            }
                            else if (item.GetAttribute("value") != "")
                            {
                                Console.WriteLine("{0}.value: {1}", i, item.GetAttribute("value"));
                            }
                            i++;
                        }
                        Console.WriteLine("------------------------------------------------");
                    }
                    switch (ActionType.ToLower())
                    {
                        case "click":
                        case "link":
                            JavaScriptClick(ThisWebElement[iIndex]);
                            Console.WriteLine("Success: Click event performed on, " + ByElement.ToString());
                            Done = true;
                            break;
                        case "list":
                        case "listbox":
                            ThisWebElement[iIndex].Click();
                            ThisWebElement[iIndex].Clear();
                            ThisWebElement[iIndex].SendKeys(ValueToEnter);
                            ThisWebElement[iIndex].SendKeys(Keys.LeftShift + Keys.Tab);
                            Console.WriteLine("Success: Selecting value: {0} | for,  {1}|", ValueToEnter, ByElement.ToString());
                            Done = true;
                            break;
                        case "text":
                        case "textbox":
                            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                            js.ExecuteScript("document.getElementById('" + ThisWebElement[iIndex].GetAttribute("id") + "').value=''");
                            js.ExecuteScript("document.getElementById('" + ThisWebElement[iIndex].GetAttribute("id") + "').value='" + ValueToEnter + "'");
                            Console.WriteLine("Success: Entering value: {0} | for,  {1}|", ValueToEnter, ByElement.ToString());
                            Done = true;
                            break;
                        case "sync":
                            if (IsElementPresent(driver, ByElement) == false)
                            {
                                WaitUntilElementVisible(driver, ByElement, iWaitTime);
                            }
                            if (IsElementPresent(driver, ByElement) == true)
                            {
                                Console.WriteLine("Success: Syncing: {0} done" + ByElement.ToString());
                            }
                            Done = true;
                            break;
                        case "verify":
                        case "ispresent":
                            WaitFor(ThisWebElement[iIndex]);
                            Done = true;
                            break;
                        default:
                            Assert.Fail("Unknown Action type.");
                            break;
                    }

                }
                catch (Exception e)
                {
                    if (ibloop == bLoop)
                    {
                        Console.WriteLine("UIActionExt: |ActiontType={0}, |ByElement={1}|", ActionType, ByElement.ToString());
                        Console.WriteLine("           : |valToEnter={0}, |index={1}, |breakloop={2}, |waitTime={3}|", ValueToEnter, iIndex, bLoop, iWaitTime);
                        Console.WriteLine("{0}.Caught Exception: {1}", ibloop, e);
                    }
                }
                if (ibloop == bLoop)
                {
                    Assert.Fail("Unable to perform this action:\n|ActiontType={0}, |ByElement={1}|", ActionType, ByElement.ToString());
                    break;
                }
                ibloop++;
            } while (Done == false);

        }



        /// <summary>
        /// Method to set up a frame, mostly used in Guidewire application.
        /// </summary>
        /// <param name="frameName">The name of the active frame </param>
        public void SetActiveFrame(string frameName = "top_frame")
        {
            Console.WriteLine("Setting up active frame to:{0}", frameName);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@id='" + frameName + "']")));
        }
        
        /// <summary>
        ///  Method to set up the iFrame, mostly used for the Guidewire 9 applications
        /// </summary>
        /// <param name="iframeName"></param>
        public void SetActiveIFrame(string iframeName = "inetframe")
        {
            Console.WriteLine("Setting up active Iframe to:{0}", iframeName);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='" + iframeName + "']")));
        }

        /// <summary>
        ///  Method to switch to iframe
        /// </summary>
        /// <param name="iframe">iframe web element</param>
        public void SwitchToIFrame(IWebElement iframe)
        {
            driver.SwitchTo().Frame(iframe);
        }

        /// <summary>
        ///  Method to switch to default content. Useful for switching back to the main content from an iframe
        /// </summary>
        public void SwitchToDefaultContent()
        {
            driver.SwitchTo().DefaultContent();
        }

        /// <summary>
        /// Method to Verify if all the links on the page are broken or not.
        /// </summary>
        /// <param name="driver">The Current driver.</param>
        public static void VerifyLinksOnPage(IWebDriver driver)
        {
            HttpWebRequest request = null;

            //  var urls = driver.FindElements(By.TagName("a")).Take(10);

            var urls = driver.FindElements(By.TagName("a"));

            foreach (var url in urls)
            {
                if (!(url.Text == ""))
                {
                    Console.WriteLine("URL:" + url.GetAttribute("href").ToString());

                    if (url.GetAttribute("href").ToString().ToLower().Substring(0, 4) == "http")
                    {
                        request = (HttpWebRequest)WebRequest.Create(url.GetAttribute("href").ToString());
                        request.AllowAutoRedirect = false;
                       // request.Timeout = 5000;

                        driver.Manage().Timeouts().ImplicitlyWait(BaseClass.NoWait);

                        try
                        {
                            var response = (HttpWebResponse)request.GetResponse();

                            Console.WriteLine("URL status code is : " + response.StatusCode);

                            int statusCode = (int)response.StatusCode;

                            if (statusCode >= 100 && statusCode < 400)
                            {
                                Console.WriteLine("URL: " + url.GetAttribute("href") + " status is " + response.StatusCode);

                                response.Close();
                            }
                            else

                            {
                                Console.WriteLine("URL: " + url.GetAttribute("href") + "is broken");

                                logger.Error("URL: " + url.GetAttribute("href") + " is broken");
                            }
                            

                            /*  if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Redirect)
                              {
                                  //   Console.WriteLine($"URL: {url.GetAttribute("href")} status is : {response.StatusCode}");
                                  Console.WriteLine("URL: " + url.GetAttribute("href") + " status is " + response.StatusCode);

                                  response.Close();
                              }
                              else
                                  // Console.WriteLine($"URL: {url.GetAttribute("href")}" + "is broken");
                                  Console.WriteLine("URL: " + url.GetAttribute("href") + "is broken");
                                  */

                        }
                        catch (WebException e)
                        {
                            string errorResponse = e.StackTrace;

                            // Console.WriteLine($"URL: {url.GetAttribute("href")}:" + "Exception :"errorResponse);
                            Console.WriteLine("URL: " + url.GetAttribute("href") + "Exception :" + errorResponse);
                        }

                        driver.Manage().Timeouts().ImplicitlyWait(BaseClass.ImplicitWait);
                    }
                }
            }
        }

        /// <summary>
        /// Method to move the mouse pointer to a UI element.
        /// </summary>
        /// <param name="driver">The current driver</param>
        /// <param name="element">The UI element</param>
        public void MouseOver(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);

            action.MoveToElement(element).Build().Perform();
        }

        /// <summary>
        /// Method to double click on a UI element.
        /// </summary>
        /// <param name="driver">The current driver</param>
        /// <param name="element">The UI element</param>
        public void DoubleClick(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);

            action.DoubleClick(element).Build().Perform();
        }

        /// <summary>
        /// Method to Drag a element and Drop it on a different element.
        /// </summary>
        /// <param name="driver">The Current driver</param>
        /// <param name="sourceElement">Source UI Element</param>
        /// <param name="targetElement">Target UI Element</param>
        public void DragAndDrop(IWebDriver driver, IWebElement sourceElement, IWebElement targetElement)
        {
            Actions action = new Actions(driver);

            action.DragAndDrop(sourceElement, targetElement).Build().Perform();
        }

        /// <summary>
        /// Method to move the mouse pointer to a given position.
        /// </summary>
        /// <param name="driver">The current driver</param>
        /// <param name="element">The UI element</param>
        public void MoveToCoordinates(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);

            action.MoveByOffset(element.Location.X, element.Location.Y).Build().Perform();
        }

        /// <summary>
        /// Method to scroll down till an element is in view.
        /// </summary>
        /// <param name="driver">The Current driver</param>
        /// <param name="element">The UI element </param>
        public void ScrollDownTillElement(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            try { js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                } catch (StaleElementReferenceException e)
                { pause();
                  js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                }

        }

    }
}

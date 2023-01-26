using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;
using System.Diagnostics;
using System.IO;

namespace WebCommonCore
{
    /// <summary>
    /// Class for Test Base , which is the base class for all the feature file step implementations. 
    /// </summary>
    public abstract class TestBase : JMSharedBase
    {
        /// <summary>
        /// Private WebDriver
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// IE Driver Path in the local file system
        /// </summary>
        private const string IE_DRIVER_PATH = @"c:\IEDriver";

        /// <summary>
        /// Chrome Driver Path in the local file system
        /// </summary>
        private const string CHROME_DRIVER_PATH = @"c:\ChromeDriver";

        /// <summary>
        /// Firefox Driver path in the local file system
        /// </summary>
        private const string FF_DRIVER_PATH = @"c:\FireFoxDriver";

        /// <summary>
        /// Folder where the error screenshots are saved
        /// </summary>
        private const string ERRORS_PATH = @"C:\tmp\Errors";

        /// <summary>
        /// Chrome Options to be set with chrome.
        /// </summary>
        ChromeOptions chromeOptns;

        /// <summary>
        /// Chrome driver service to be set with Chrome browser.
        /// </summary>
        ChromeDriverService chromeService;

        /// <summary>
        /// Method to get the current active driver
        /// </summary>
        /// <returns>The active webdriver</returns>
        public override IWebDriver getDriver()
        {
            if (!ScenarioContext.Current.ContainsKey("WebDriver"))
            {
                var targetBrowser = ScenarioContext.Current["BrowserType"].ToString();

                var targetType = ScenarioContext.Current["TargetType"].ToString();

                string URL = null;

                DesiredCapabilities currCapability = null;

                //   var targetCapability = ScenarioContext.Current["Capability"].ToString();
                Console.WriteLine("WebCommonCore Version 1.0.334");
                Console.WriteLine("US24661 and US23344 updated");
                switch (ScenarioContext.Current["Application"].ToString().ToLower().Trim())
                {
                    case "pc":
                    case "bc":
                    case "cc":
                    case "cm":
                    case "kentico":
                    case "drupal":
                    case "drupalapp":
                        ApplicationSetUpInfo.GWSetUpInfo setUpInfo = new ApplicationSetUpInfo.GWSetUpInfo();

                        URL = setUpInfo.getEnvironmentURL(ScenarioContext.Current["Application"].ToString());

                        break;

                    case "qna":
                    case "qaggs":
                    case "qg":
                    case "qi":
                    case "qp":
                    case "qps":
                    case "jmpg":
                    case "pp":
                    case "qabung":
                    case "qabbt":
                    case "clp":
                    case "plp":
                    case "ap":
                    case "ai":
                    case "ca":
                    case "plreg":
                    case "qnablt":
                    case "peportal":
                    case "loos":
                    case "qaadiamor":
                    case "qabluenile":
                    case "qabgdiamond":
                    case "qawhiteflash":
                    case "qajallen":
                    case "qbp":
                        ApplicationSetUpInfo.QuoteAndAppSetUpInfo QNAsetUpInfo = new ApplicationSetUpInfo.QuoteAndAppSetUpInfo();

                        URL = QNAsetUpInfo.getEnvironmentURL(ScenarioContext.Current["Application"].ToString());

                        break;

                    default:
                        Console.WriteLine("Please enter a valid application name.");
                        break;
                }
                
                switch (targetType.ToLower())
                {
                    case "browserstack":
                        
                        string browserstackuser = "";
                        string browserstackkey = "";

                        switch (targetBrowser.ToLower())
                        {
                            case "edge":
                                currCapability = new DesiredCapabilities();
                                currCapability.SetCapability("browserstack.user", browserstackuser);
                                currCapability.SetCapability("browserstack.key", browserstackkey);
                                currCapability.SetCapability("browser", "Edge");
                                currCapability.SetCapability("browser_version", "15.0");
                                currCapability.SetCapability("os", "Windows");
                                currCapability.SetCapability("os_version", "10");
                                currCapability.SetCapability("resolution", "1024x768");
                                currCapability.SetCapability("browserstack.local", "true");
                                break;

                            case "chrome":
                                currCapability = new DesiredCapabilities();
                                currCapability.SetCapability("browserstack.user", browserstackuser);
                                currCapability.SetCapability("browserstack.key", browserstackkey);
                                currCapability.SetCapability("browserstack.local", "true");
                                currCapability.SetCapability("acceptSslCert", "true");
                                currCapability.SetCapability("browser", "chrome");
                                currCapability.SetCapability("browser_version", "52.0");
                                currCapability.SetCapability("os", "Windows");
                                currCapability.SetCapability("os_version", "10");
                                break;

                            case "ie11":
                                currCapability = new DesiredCapabilities();
                                currCapability.SetCapability("browserstack.user", browserstackuser);
                                currCapability.SetCapability("browserstack.key", browserstackkey);
                                currCapability.SetCapability("browserstack.local", "true");
                                currCapability.SetCapability("acceptSslCert", "true");
                                currCapability.SetCapability("browser", "IE");
                                currCapability.SetCapability("browser_version", "11.0");
                                currCapability.SetCapability("os", "Windows");
                                currCapability.SetCapability("os_version", "10");
                                currCapability.SetCapability("resolution", "1024x768");
                                break;

                            case "safari":
                                currCapability = new DesiredCapabilities();
                                currCapability.SetCapability("browserstack.user", browserstackuser);
                                currCapability.SetCapability("browserstack.key", browserstackkey);
                                currCapability.SetCapability("browserstack.local", "true");
                                currCapability.SetCapability("acceptSslCert", "true");
                                currCapability.SetCapability("browser", "Safari");
                                currCapability.SetCapability("browser_version", "9.1");
                                currCapability.SetCapability("os", "OS X");
                                currCapability.SetCapability("os_version", "El Capitan");
                                currCapability.SetCapability("resolution", "1024x768");
                                break;

                            case "iphone8":
                                currCapability = new DesiredCapabilities();
                                currCapability.SetCapability("browserName", "iPhone");
                                currCapability.SetCapability("device", "iPhone 8");
                                currCapability.SetCapability("realMobile", "true");
                                currCapability.SetCapability("os_version", "11.0");
                                currCapability.SetCapability("browserstack.user", browserstackuser);
                                currCapability.SetCapability("browserstack.key", browserstackkey);
                                break;

                        }

                        RemoteWebDriver CurrDriver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), currCapability);

                        driver = CurrDriver;

                        SessionId sessionID = CurrDriver.SessionId;

                        Console.WriteLine("Session ID ----" + sessionID.ToString());

                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(BaseClass.TIME_TO_WAIT));

                        driver.Navigate().GoToUrl(URL);

                        ScenarioContext.Current.Add("WebDriver", driver);

                        break;

                    case "mobile":

                        var capabilityType = ScenarioContext.Current["Capability"].ToString();

                        Capabilities currMobile = new Capabilities();

                        currCapability = currMobile.getCapability(capabilityType);

                        System.Threading.Thread.Sleep(5000);

                        RemoteWebDriver CurrMobDriver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), currCapability);

                        driver = CurrMobDriver;

                        SessionId sessionIDs = CurrMobDriver.SessionId;

                        Console.WriteLine("Session ID ----" + sessionIDs.ToString());

                        ScenarioContext.Current.Add("WebDriver", driver);

                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(BaseClass.TIME_TO_WAIT));

                        driver.Navigate().GoToUrl(URL);

                        System.Threading.Thread.Sleep(5000);

                        break;

                    case "desktop":

                        switch (targetBrowser.ToLower())
                        {
                            case "ie":

                                InternetExplorerOptions ieOptions = new InternetExplorerOptions
                                {
                                    InitialBrowserUrl = URL,
                                    UnexpectedAlertBehavior = InternetExplorerUnexpectedAlertBehavior.Ignore,
                                    IntroduceInstabilityByIgnoringProtectedModeSettings = true
                                };

                                ieOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;

                                driver = new InternetExplorerDriver(IE_DRIVER_PATH, ieOptions);

                                ScenarioContext.Current["WebDriver"] = driver;

                                break;

                            case "chrome":

                                ChromeOptions chromeOptions = new ChromeOptions();

                                chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);

                                driver = new ChromeDriver(CHROME_DRIVER_PATH, chromeOptions);

                                ScenarioContext.Current["WebDriver"] = driver;

                                break;

                            case "firefox":

                                FirefoxDriverService ffService = FirefoxDriverService.CreateDefaultService(FF_DRIVER_PATH, "geckodriver.exe");

                                // ffService.Port = 64444;

                                // ffService.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";

                                driver = new FirefoxDriver(ffService);

                                ScenarioContext.Current["WebDriver"] = driver;

                                break;

                        }

                        driver.Navigate().GoToUrl(URL);

                        driver.Manage().Window.Maximize();

                        ScenarioContext.Current["WebDriver"] = driver;

                        return (IWebDriver)ScenarioContext.Current["WebDriver"];

                }
                return (IWebDriver)ScenarioContext.Current["WebDriver"];
            }
            else
                return (IWebDriver)ScenarioContext.Current["WebDriver"];
        }

        /// <summary>
        /// Method to start the browser stack local process
        /// </summary>
        public void startBrowserStackLocal()
        {
            Process browLocal = new Process();

            browLocal.StartInfo.FileName = @"C:\BrowserStackLocal\BrowserStackLocal.exe";

            //      browLocal.StartInfo.Arguments = System.Configuration.ConfigurationManager.AppSettingd["browserstackkey"];

            browLocal.StartInfo.Arguments = "XUqhaKhi7TKTwpRptseR";

            browLocal.Start();

        }

        /// <summary>
        /// Method to capture the snapshot of the applciation when an error occurs
        /// </summary>
        /// <param name="captureType">Capture type</param>
        public void CaptureApplicationSnapshot(string captureType)
        {
            //string fileBaseName = null;

            //try
            //{
            //    Console.WriteLine("Capture Type:" + captureType);

            //    Console.WriteLine("ScenarioContext:" + ScenarioContext.Current.ScenarioInfo.Title.ToString());

            //    Console.WriteLine("Date Time:" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));

            //    switch (captureType.ToLower().Trim())
            //    {
            //        case "error":
            //            fileBaseName = string.Format("error_{0}_{1}", ScenarioContext.Current.ScenarioInfo.Title.ToString(), DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            //            break;
            //        case "info":
            //            fileBaseName = string.Format("info_{0}_{1}", ScenarioContext.Current.ScenarioInfo.Title.ToString(), DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            //            break;
            //        default:
            //            break;
            //    }

            //    Console.WriteLine("FileName:" + fileBaseName);

            //    string pageSource = driver.PageSource;

            //    Console.WriteLine("Page Source:" + pageSource);

            //    string sourceFilePath = Path.Combine(@"c:\Tmp\Errors", fileBaseName + "_source.html");

            //    Console.WriteLine("File Path:" + sourceFilePath);

            //    File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8); 

            //    //     Screenshot takescreenshot = driver as ITakesScreenshot;

            //    Screenshot takescreenshot =  ((ITakesScreenshot)driver).GetScreenshot();

            //    if (takescreenshot != null)
            //       {
                               
            //        string screenShorFilePath = Path.Combine(ERRORS_PATH, fileBaseName + "_screenshot.png");

            //        Console.WriteLine("screenShorFilePath:" + screenShorFilePath);
                    
            //        takescreenshot.SaveAsFile(screenShorFilePath, ScreenshotImageFormat.Png);

            //        Console.WriteLine("Screenshot : {0}", new Uri(screenShorFilePath));
            //    }
        
            //}
            //catch (Exception ex)
            //{
                
            //    Console.WriteLine("Error while capturing screenshot : " + ex.Message);
            //    Console.WriteLine("Error Stacktrace : " + ex.StackTrace);
            //}

        }

        /// <summary>
        /// Method to get the GetBrowserStackDetails
        /// </summary>
        /// <param name="userName">userName</param>
        /// <param name="key">key</param>
        public void GetBrowserStackDetails(string userName, string key)
        {

            // Pass values to this from config files
            Console.WriteLine("User Name: " + userName);
            Console.WriteLine("Key: " + key);
        }
    }
}

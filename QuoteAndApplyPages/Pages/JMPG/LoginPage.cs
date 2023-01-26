using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace QuoteAndApplyPages.Pages.JMPG
{
    public class LoginPage : Page
    {
        // icon
        string quartzLogoXpath = "//img[@class='quartz-logo']";
        string helpDeskIconXpath = "//img[@class='helpdesk-icon']";
        string showPasswordIconCSS = "img[id$='showPwdIcon']";

        // label
        string labelEmailAddressXpath = "//label[@for='Email']";
        string labelPwdXpath = "//label[@for='pwdInput']";

        // link
        string linkForgotPwdXpath = "//a[@class='sub-label']";
        string linkPhoneStageXpath = "//a[@href='tel:1-833-970-9464']";
        string linkPhoneQAXPath = "//a[@href='tel:+1 (833) 970-9464']";
       // string linkColorModeXpath = "//a[@class='high']";

        // help desk content
        string divHelpDeskXpath = "//div[@class='heading-14-light-onyx mt-3 helpdesk-number']";


        // Login Page Heading
        string loginPageHeadingXpath = "//div[contains(text(), 'Welcome to JM Partner Gateway')]";

        // input
        string inputUsernameCSS = "input[id$='Email']";
        string inputPasswordCSS = "input[id$='pwdInput']";

        //button
        string buttonloginCSS = "button[id$='loginbutton']";

    
        public LoginPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            WaitUntilElementVisible(driver, By.Id("Email"));
        }


        public override void VerifyPage()
        {
            pause();
        }

        public override void WaitForLoad()
        {
            pause();
            pause();
        }

        public void loginJMPG(string username, string password)
        {        
            UIAction(inputUsernameCSS, username, "textbox");
            UIAction(inputPasswordCSS, password, "textbox");
            pause();
            UIAction(buttonloginCSS, string.Empty, "a");
        }

        public void verifyPageContent()
        {
            VerifyUIElementIsDisplayed(quartzLogoXpath);
            VerifyUIElementIsDisplayed(helpDeskIconXpath);
            VerifyUIElementIsDisplayed(showPasswordIconCSS);
            VerifyUIElementIsDisplayed(inputUsernameCSS);
            VerifyUIElementIsDisplayed(inputPasswordCSS);

            IWebElement loginHeading = driver.FindElement(By.XPath(loginPageHeadingXpath));
            IWebElement emailAddressLabel = driver.FindElement(By.XPath(labelEmailAddressXpath));
            IWebElement pwdLabel = driver.FindElement(By.XPath(labelPwdXpath));
            IWebElement forgotPwdLink = driver.FindElement(By.XPath(linkForgotPwdXpath));
          //  IWebElement colorModeLink = driver.FindElement(By.XPath(linkColorModeXpath));
            IWebElement loginButton = driver.FindElement(By.CssSelector(buttonloginCSS));
            IWebElement helpDeskDiv = driver.FindElement(By.XPath(divHelpDeskXpath));
            IWebElement phoneLink;

            string pwdLabelText = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].firstChild.textContent;", pwdLabel)).Trim();
            string needHelpText = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].firstChild.textContent;", helpDeskDiv)).Trim();
            string callText = ((string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].childNodes[2].textContent;", helpDeskDiv)).Trim();

            Console.WriteLine("----JMPG Login Page error message validation ----- started------");
            Assert.IsTrue(loginHeading.Text.Equals("Welcome to JM Partner Gateway"), "Actual text content to verify Login Page Heading: " + loginHeading.Text);
            Assert.IsTrue(emailAddressLabel.Text.Equals("Email Address"), "Actual text content to verify Email Address Label: " + emailAddressLabel.Text);
            Assert.IsTrue(pwdLabelText.Equals("Password"), "Actual text content to verify Password Label: " + pwdLabelText);
            Assert.IsTrue(forgotPwdLink.Text.Equals("Forgot Password?"), "Actual text content to verify Forgot Password Link: " + forgotPwdLink.Text);
            Assert.IsTrue(loginButton.Text.Equals("LOGIN"), "Actual text content to verify Login Button: " + loginButton.Text);
          //  Assert.IsTrue(colorModeLink.Text.Equals("High Contrast Color Mode."), "Actual text content to verify Footer Color Mode Link: " + colorModeLink.Text);
            Assert.IsTrue(needHelpText.Equals("Need Assistance?"), "Actual text content to verify Help Desk Content: " + needHelpText);
            Assert.IsTrue(callText.Equals("Call"), "Actual text content to verify Help Desk Content: " + callText);
           

            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "stage" || ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim() == "prod")
            {
                phoneLink = driver.FindElement(By.XPath(linkPhoneStageXpath));
                Assert.IsTrue(phoneLink.Text.Equals("1-833-970-9464"), "Actual text content to verify Phone Link: " + phoneLink.Text);
            }
            else
            {
                phoneLink = driver.FindElement(By.XPath(linkPhoneQAXPath));
                Assert.IsTrue(phoneLink.Text.Equals("+1 (833) 970-9464"), "Actual text content to verify Phone Link: " + phoneLink.Text);
            }

            verifyFooter();

            Console.WriteLine("----JMPG Login Page error message validation ----- complete------");

        }

        public void verifyFooter()
        {
            CommonPageElements footer = new CommonPageElements(driver);
            footer.verifLoginAndMyAccountyFooter();
        }
    }
}


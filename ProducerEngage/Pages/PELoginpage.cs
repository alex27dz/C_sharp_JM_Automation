using OpenQA.Selenium;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class PELoginPage : Page
    {
        private const string emailInputID = "Email";
        private const string passwordInputID = "pwdInput";
        private const string loginButtonID = "loginbutton";

        public PELoginPage(IWebDriver driver) : base(driver) { }

        public override void VerifyPage()
        {
            WaitUntilElementEnabled(driver, By.Id(loginButtonID), 30);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver, 180);
        }

        public void EnterEmail(string email)
        {
            WaitUntilElementEnabled(driver, By.Id(emailInputID), 30);
            driver.FindElement(By.Id(emailInputID)).Clear();
            driver.FindElement(By.Id(emailInputID)).SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            WaitUntilElementEnabled(driver, By.Id(passwordInputID), 30);
            driver.FindElement(By.Id(passwordInputID)).Clear();
            driver.FindElement(By.Id(passwordInputID)).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            WaitUntilElementEnabled(driver, By.Id(loginButtonID), 30);
            driver.FindElement(By.Id(loginButtonID)).Click();
        }
    }
}

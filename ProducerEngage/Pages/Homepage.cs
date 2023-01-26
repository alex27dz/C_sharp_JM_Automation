using OpenQA.Selenium;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class HomePage : Page
    {
        private const string startNewQuoteButtonCSS = "a[ui-sref='newQuoteSearch'] button";
        private const string searchButtonCSS = "a[ui-sref='existingQuoteSearch']";

        public HomePage(IWebDriver driver) : base(driver) { }

        public override void VerifyPage()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(startNewQuoteButtonCSS), 30);
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver, 180);
        }

        public void ClickStartNewQuoteButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(startNewQuoteButtonCSS), 30);
            driver.FindElement(By.CssSelector(startNewQuoteButtonCSS)).Click();
        }

        public void ClickSearchButton()
        {
            WaitUntilElementEnabled(driver, By.CssSelector(searchButtonCSS), 30);
            driver.FindElement(By.CssSelector(searchButtonCSS)).Click();
        }
    }
}

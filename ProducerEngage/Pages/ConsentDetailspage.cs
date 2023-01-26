using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class ConsentDetailspage:Page
    {


        string lblPersonalArticleHeaderXpath = "//div[@class='gw-page-title gw-page-title-pc ng-scope']/div[contains(.,'Personal Articles Quote')]";
        string btnAddLossXpath = "//button[@class='gw-btn-primary ng-binding']";
        string txtLossDateXpath = "//input[@id='localDateChooser']";
        string selLossTypeXpath = "//select[@class='ng-scope ng-isolate-scope gw-pl-select']";
        string txtLossAmountXpath = "//input[@class='ng-pristine ng-untouched ng-valid ng-scope ng-empty']";
        string btnLossYesXpath = "//div[@name='IsSelfReportedLoss']//label[@class='gw-first']";
        string btnLossNoXpath = "//div[@name='IsSelfReportedLoss']//label[@class='gw-second']";
        string btnpossessionYesXpath = "//div[@name='IsIndividualInPossessionOfItem']//label[@class='gw-first']";
        string btnpossessionNoXpath = "//div[@name='IsIndividualInPossessionOfItem']//label[@class='gw-second']";
        string btnStatmentYesXpath = "//div[@name='IsBackgroundConsentGiven']//label[@class='gw-first']";
        string btnStatmentNoXpath = "//div[@name='IsBackgroundConsentGiven']//label[@class='gw-second']";
        string btnReportYesXpath = "//div[@name='IsReportConsentGiven']//label[@class='gw-first']";
        string btnReportNoXpath = "//div[@name='IsReportConsentGiven']//label[@class='gw-second']";
        string btnNextXapth = "//button[@ng-show='showNext']";
       
       

        public ConsentDetailspage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 400);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPersonalArticleHeaderXpath);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(lblPersonalArticleHeaderXpath));
         //   IsElementPresent(driver, By.XPath(lblPersonalArticleHeaderXpath));

        }
        public void LossDetails(Table table)
        {
            int iteration = 0;
           
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string LossDate = ExpValues[0];
                string LossType = ExpValues[1];
                string LossAmount = ExpValues[2];
                EnterLossDetails(LossDate, LossType, LossAmount, iteration);
                iteration = iteration + 1;


            }
        }
        public void EnterLossDetails(string lossDate, string lossType, string lossAmount, int counter)
        {
            WaitUntilElementVisible(driver, By.XPath(btnAddLossXpath), 30);
            JavaScriptClick(driver.FindElement(By.XPath(btnAddLossXpath)));

            List<IWebElement> lossDateobj;
            do
            {
                lossDateobj = driver.FindElements(By.XPath(txtLossDateXpath)).ToList();
                Console.WriteLine("object counter is " + lossDateobj.Count);
                Console.WriteLine("counter is " + counter);
                pause();
            } while (lossDateobj.Count <= counter);

            List<IWebElement> lossTypeobj = driver.FindElements(By.XPath(selLossTypeXpath)).ToList();
            List<IWebElement> lossAmountobj = driver.FindElements(By.XPath(txtLossAmountXpath)).ToList();
            lossDateobj[lossDateobj.Count - 1].SendKeys(lossDate);
            SelectByText(lossTypeobj[lossTypeobj.Count-1], lossType);
            lossAmountobj[lossAmountobj.Count - 1].SendKeys(lossAmount);
        }

        public void SetLossConsent(string lossConsent)
        {
            WaitUntilElementVisible(driver, By.XPath(btnLossYesXpath), 120);
            if (lossConsent.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnLossYesXpath)));
            }
            else
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnLossNoXpath)));
            }
        }
        public void SetPossessionConsent(string possessionConsent)
        {
            WaitUntilElementVisible(driver, By.XPath(btnpossessionYesXpath), 120);
            if (possessionConsent.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnpossessionYesXpath)));
            }
            else
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnpossessionNoXpath)));
            }
            //System.Threading.Thread.Sleep(1000);
        }
        public void SetStatmentConsent(string statmentConsent)
        {
            WaitUntilElementVisible(driver, By.XPath(btnStatmentYesXpath), 120);
            if (statmentConsent.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnStatmentYesXpath)));
                //UIActionExt(By.XPath(btnStatmentYesXpath),"click");
            }
            else
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnStatmentNoXpath)));
            }
        }
        public void SetReportConsent(string reportConsent)
        {
            WaitUntilElementVisible(driver, By.XPath(btnReportYesXpath), 120);
            if (reportConsent.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnReportYesXpath)));
            }
            else
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnReportNoXpath)));
            }
        }
        public void ClickNext()
        {
            JavaScriptClick(driver.FindElement(By.XPath(btnNextXapth)));
        }

    }
}

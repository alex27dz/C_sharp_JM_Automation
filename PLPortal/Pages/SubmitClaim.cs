using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PLPortalPages.Pages
{
    public class SubmitClaim : Page
    {

        string ring = "//*[@id='root']/div[2]/div/div[2]/div/article/div/form/div/div[1]/div";
        string state = "state";
        string city = "city";
        string btnreport = "//*[@id='root']/div[2]/div/div[2]/div/article/div/form/div[3]/div";
        string btmnext6 = "//*[@id='root']/div[2]/div/div[2]/div/article/div/form/div/div[1]/div";
        string btmnext = "//*[@id='root']/div[2]/div/div[2]/div/article/footer/button[2]";
        string btmphysicaldamage = "//*[@id='root']/div[2]/div/div[2]/div/article/div/form/div[4]/div";
        string btmdamaged = "//*[@id='root']/div[2]/div/div[2]/div/article/div/form/div[1]/div";
        string btmbegin = "//*[@id='root']/div[2]/div/div[2]/div/footer/button";
        string btnStartClaim = "//*[@id='root']/div[2]/div/div[1]/div[2]/a";
        string txtLossDate = "input[id$='LossDiscoveryDate']";
        string btnContinueClaim = "input[id$='continueClaim']";
        string btnClaimDetailContinue = "input[id$='claimDetailContinue']";


        //Preferred Jeweler Yes
        //<input type="radio" name="preferredJewelerYesNo" value="yes" id="yes">
        //<input type="radio" name="preferredJewelerYesNo" value="no" id="no">






        public SubmitClaim(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
           // VerifyUIElementIsDisplayed(btnStartClaim);
        }

        public override void WaitForLoad()
        {

        }


        public void StartNewCliam(string LossDate, string Description, string LosssCause, string LossDescription, string Comments)
        {
            // start
            System.Threading.Thread.Sleep(3000);
            JavaScriptClick(driver.FindElement(By.XPath(btnStartClaim)));
            System.Threading.Thread.Sleep(3000);
            // begin
            JavaScriptClick(driver.FindElement(By.XPath(btmbegin)));
            System.Threading.Thread.Sleep(3000);
            // Next 
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            System.Threading.Thread.Sleep(3000);
            // damaged 
            IWebElement damaged = driver.FindElement(By.XPath(btmdamaged));
            damaged.Click();
            System.Threading.Thread.Sleep(3000);
            // Next 
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            System.Threading.Thread.Sleep(3000);
            // pysical damage
            IWebElement physdam = driver.FindElement(By.XPath(btmphysicaldamage));
            physdam.Click();
            System.Threading.Thread.Sleep(3000);
            // Next
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            System.Threading.Thread.Sleep(3000);
            // date
            List<IWebElement> DatePicker = driver.FindElements(By.Id("lossDate")).ToList();
            DatePicker[0].SendKeys(LossDate);
            DatePicker[0].Click();
            System.Threading.Thread.Sleep(3000);
            // description
            List<IWebElement> Describe = driver.FindElements(By.Id("lossDescription")).ToList();
            Describe[0].SendKeys("loss type Fire");
            System.Threading.Thread.Sleep(3000);
            // report yes 
            IWebElement report = driver.FindElement(By.XPath(btnreport));
            report.Click();
            System.Threading.Thread.Sleep(3000);
            // Next
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            System.Threading.Thread.Sleep(3000);
            // date2
            List<IWebElement> DatePicker2 = driver.FindElements(By.Id("dateFiled")).ToList();
            DatePicker2[0].SendKeys(LossDate);
            DatePicker2[0].Click();
            System.Threading.Thread.Sleep(3000);
            // city 
            List<IWebElement> City = driver.FindElements(By.Id(city)).ToList();
            City[0].SendKeys("Neenah");
            System.Threading.Thread.Sleep(3000);
            // state
            JavaScriptClick(driver.FindElement(By.Id(state)));
            System.Threading.Thread.Sleep(3000);
            JavaScriptClick(driver.FindElement(By.XPath("//*[@id='state']/div[2]/div[2]")));
            System.Threading.Thread.Sleep(3000);
            // Next
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            System.Threading.Thread.Sleep(3000);
            // ladies ring
            IWebElement ringbtn = driver.FindElement(By.XPath(ring));
            ringbtn.Click();
            System.Threading.Thread.Sleep(5000);
            // Next
            JavaScriptClick(driver.FindElement(By.XPath(btmnext6)));
            System.Threading.Thread.Sleep(5000);
            // Next 
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            System.Threading.Thread.Sleep(5000);
            // Review 
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Review");
            // Submit 
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            JavaScriptClick(driver.FindElement(By.XPath(btmnext)));
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Submit");
            // Claim number
            var claimnumsub = driver.FindElement(By.XPath("//*[@id='root']/div[2]/div/div[2]/div/article/div/div/p")).Text;
            Console.WriteLine(claimnumsub);
            // Back to claims
            JavaScriptClick(driver.FindElement(By.XPath("//*[@id='root']/div[2]/div/div[2]/div/article/div/div/div[3]/a")));
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Claim submitted");
            // Back to Account details
            JavaScriptClick(driver.FindElement(By.XPath("//*[@id='root']/div[1]/nav/ul/li[1]/a")));
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Account details");

        }

        public void StartNewCliamold(string LossDate, string Description, string LosssCause, string LossDescription, string Comments)
        {
            UIAction(btnStartClaim, string.Empty, "a");
            pause();
            UIAction(txtLossDate, LossDate, "textbox");
            pause();
            List<IWebElement> DatePicker = driver.FindElements(By.XPath("//img[@class='ui-datepicker-trigger']")).ToList();
            DatePicker[0].Click();
            //Actions action = new Actions(driver);
            //action.SendKeys(Keys.Tab);
            //pause();
            pause();
            pause();
            UIAction(btnContinueClaim, string.Empty, "a");
            pause();
            Console.WriteLine("Claim Deatils");
            WaitUntilElementIsDisplayed(driver, By.XPath("input[id$='claimDetailContinue']"));
            Console.WriteLine("Claim Deatils");
            List<IWebElement> txtareaDescription = driver.FindElements(By.XPath("//textarea[@id='itemDescriptionTextArea']")).ToList();
            txtareaDescription[0].SendKeys(Description);
            ClickLosssCause(LosssCause);
            List<IWebElement> txtareaLossDescription = driver.FindElements(By.XPath("//textarea[@id='LossDescription']")).ToList();
            txtareaLossDescription[0].SendKeys(LossDescription);
            List<IWebElement> txtareaComments = driver.FindElements(By.XPath("//textarea[@id='Comments']")).ToList();
            txtareaComments[0].SendKeys(Comments);

        }

        public void ClickLosssCause(string LossCause)
        {
            List<IWebElement> looscauseID;
            switch (LossCause.ToLower())
            {
                case "accidental loss":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Accidental Loss']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "mysterious disappearance":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Mysterious Disappearance']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "Accidental Loss":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Armed Robbery']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "burglary":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Burglary']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "fire":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Fire']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    //looscauseID[0].Click();
                    break;
                case "shipping":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Shipping']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "theft":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Theft']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "other":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Other']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "damaged stone":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Damaged Stone']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "wear & tear":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Wear & Tear']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "damaged during work by jeweler":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Damaged During Work by Jeweler']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "physical damage":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Physical Damage']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;
                case "loss of stone":
                    looscauseID = driver.FindElements(By.XPath("//input[@id ='LossCause'and @value='Loss of Stone']")).ToList();
                    JavaScriptClick(looscauseID[0]);
                    break;



            }
        }

        public void ClickContinue()
        {
            UIAction(btnClaimDetailContinue, string.Empty, "a");
            pause();
        }
    }

}

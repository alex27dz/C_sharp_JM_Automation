using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace QuoteAndApplyPages.Pages.QNA
{
    public class PartnerModeHome : Page
    {
        string txtUsername = "input[id$='UserName']";
        string txtPassword = "input[id$='Password']";
        string txtSuperUsername = "input[id$='Email']";
        string txtSuperPassword = "input[id$='pwdInput']";
        string btnContinue = "a[id$='partnerNext']";
        string buttonsubmit = "input[id$='submitButton']";
        string buttonlogin = "button[id$='loginbutton']";
      

        public PartnerModeHome(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //  SetActiveFrame();
            pause();
            //VerifyUIElementIsDisplayed(txtUsername);
        }

        public override void WaitForLoad()
        {
            pause();
            pause();
           
        }

        public void loginPartnerMode(string username, string password)
        {
            WaitUntilElementVisible(driver, By.Id("UserName"));
            UIAction(txtUsername, username, "textbox");
            UIAction(txtPassword, password, "textbox");
            pause();
            UIAction(buttonsubmit, string.Empty, "a");
        }

        public void loginSuperPartnerMode(string username, string password)
        {
            WaitUntilElementVisible(driver, By.Id("Email"));
            UIAction(txtSuperUsername, username, "textbox");
            UIAction(txtSuperPassword, password, "textbox");
            pause();
            Console.WriteLine(ScenarioContext.Current["AUTEnv"].Equals("stage"));
            //var element;
            if (ScenarioContext.Current["AUTEnv"].Equals("stage"))
            {
                var element = driver.FindElement(By.CssSelector("[href*='tel:1-833-970-9464']"));
                Actions actions = new Actions(driver);
                actions.MoveToElement(element);
                actions.Perform();
            }
            else
            {
                var element = driver.FindElement(By.CssSelector("[href*='tel:+1 (833) 970-9464']"));
                Actions actions = new Actions(driver);
                actions.MoveToElement(element);
                actions.Perform();
            }
            //By.CssSelector("[href*='https://dev-zing.jewelersmutual.com/signup']")
            //<a href="https://dev-zing.jewelersmutual.com/signup">Sign up here.</a>
            /////href="tel:+1 (833) 970-9464"
            /////href="tel:1-833-970-9464"
            
            UIAction(buttonlogin, string.Empty, "a");
        }


        public void selectAgency(string AgencyName)
        {
            try
            {
                string chckAgency = "input[id$='ReferralSources-" + AgencyName + "']";
                UIAction(chckAgency, string.Empty, "a");
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
           
        }

        public void clickContinuebtn()
        {
            UIAction(btnContinue, string.Empty, "a");
        }



    }
}

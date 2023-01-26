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
using System.Text.RegularExpressions;
using System.Threading;
using HelperClasses;
using iTextSharp.text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;


namespace DigitalProject.ClaimsApp
{
    public class Loss_Damage_Screen : Page
    {

        #region Required
        public Loss_Damage_Screen(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lossB);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id("loss"));
        }

        #endregion

        #region Elements

        [FindsBy(How = How.ClassName, Using = "jm-loss-damage-group")]
        public IWebElement LossDamageContainer;

        [FindsBy(How = How.Id, Using = "loss")]
        public IWebElement LossButton;

        string lossB = "input[id$='loss']";  //Input class = btn jm-loss-damage-btn
        // input.#loss.btn.jm-loss-damage-btn

        [FindsBy(How = How.XPath, Using = "//*[@id=\"loss\"]")]
        public IWebElement LossButton2;

        [FindsBy(How = How.Id, Using = "damage")]
        public IWebElement DamageButton;

        [FindsBy(How = How.CssSelector, Using = ".field-validation-error")]
        public IWebElement LossDamageError;

        [FindsBy(How = How.CssSelector, Using = "input.btn:nth-child(8)")]
        public IWebElement LossDamageContinue;

        [FindsBy(How = How.CssSelector, Using = "#LossType > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > label:nth-child(1) > span:nth-child(3)")]
        public IWebElement AccidentalLoss;

        [FindsBy(How = How.CssSelector, Using = "#DamageType > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > label:nth-child(1) > span:nth-child(3)")]
        public IWebElement DamagedStone;

        [FindsBy(How = How.LinkText, Using = "I have more than one type of loss or damage.")]
        public IWebElement IHaveMoreThanOneTypeOfLossLink;


        #endregion

        public void ClickLoss()
        {

            //Thread.Sleep(4000);
            // LossButton.Click();
            // JavaScriptClick(LossButton);
            //LossButton2.Click();
            // LossButton2.Click();
            UIAction(lossB, string.Empty, "button");

        }

        public void ClickLossType(string LossType)
        {
            IWebElement radioLosstype;

            switch (LossType.ToLower().Trim())
            {
                case "accidental loss":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlAccidentalLoss']"));
                    radioLosstype.Click();
                    break;
                case "mysterious disappearance":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlMysteriousDisappearance']"));
                    radioLosstype.Click();
                    break;
                case "armed robbery":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlArmedRobbery']"));
                    radioLosstype.Click();
                    break;
                case "burglary":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlBurglary']"));
                    radioLosstype.Click();
                    break;
                case "fire":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlFire']"));
                    radioLosstype.Click();
                    break;
                case "shipping":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlShipping']"));
                    radioLosstype.Click();
                    break;
                case "theft":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlTheft']"));
                    radioLosstype.Click();
                    break;
                case "other":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlOther'][@class='loss']"));
                    radioLosstype.Click();
                    break;

                default:
                    break;
            }
        }


        public void ClickDamageType(string LossType)
        {
            IWebElement radioLosstype;
        

            switch (LossType.ToLower().Trim())
            {
                case "damaged stone":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlDamagedStone']"));
                    radioLosstype.Click();
                    break;
                case "wear & tear":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlWear&Tear']"));
                    radioLosstype.Click();
                    break;
                case "damaged during work by jeweler":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlDamagedDuringWorkbyJeweler']"));
                    radioLosstype.Click();
                    break;
                case "physical damage":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlPhysicalDamage']"));
                    radioLosstype.Click();
                    break;
                case "loss of stone":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlLossofStone']"));
                    radioLosstype.Click();
                    break;
                case "shipping":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlShipping']"));
                    radioLosstype.Click();
                    break;
                case "theft":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlTheft']"));
                    radioLosstype.Click();
                    break;
                case "other":
                    radioLosstype = driver.FindElement(By.XPath("//input[@id='rdlOther'][@class='damage']"));
                    radioLosstype.Click();
                    break;

                default:
                    break;
            }
        }

        public void ClickAccidentalLoss()
        {
            AccidentalLoss.Click();
        }

        public void ClickContinueLossDamage()
        {
            LossDamageContinue.Click();
        }


        public void DamageLossErrors()
        {
            Assert.IsTrue(LossDamageError.Text.Equals("Please select the type of loss or damage."), "Actual Damage loss Name Error Message" + LossDamageError.Text);
        }

    }
}

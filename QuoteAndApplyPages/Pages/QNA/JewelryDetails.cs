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

namespace QuoteAndApplyPages.Pages.QNA
{
    public class JewelryDetails : Page
    {
        string buttonjewelryDetailsNext = "a[id$='jewelryDetailsNext']";
        string containerjewelryDetail = "div[id$='jewelryDetailsContainer']";
        string textareaDescription = "textarea[id$='UserDescription-JI-2']";
        string radioHasAlarmNo = "input[id$='HasAlarm-No']";
        string txtEfficitveDate = "input[id$='EffectiveDate']";
        string radioHasAlarmMonioredAlarm = "input[id$='HasAlarm-Monitored Alarm System']";
        string radioHasAlarmLocal = "input[id$='HasAlarm-Local Alarm']";

        string radioUWYes = "input[id$='AdditionalUWNeeded-Yes']";
        string radioUWNo = "input[id$='AdditionalUWNeeded-No']";

        IList<IWebElement> JewelrySubtypeList;
        IList<IWebElement> JewelryGenderList;
        IList<IWebElement> SelectAppraisalList;
        IList<IWebElement> TextEditItem;
        IList<IWebElement> BtnUpdateItem;

        public JewelryDetails(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver, 200);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(radioHasAlarmNo);
        }

        public override void WaitForLoad()
        {
            // IsElementPresent(driver, By.Id("jewelryDetailsNext"));
            WaitFor(driver.FindElement(By.Id("jewelryDetailsNext")));
        }

        public void UpdateItemValue(string JewelryItem, int counter)
        {
            JewelryGenderList = driver.FindElements(By.XPath("//a[@id='EditJewelryItemInlineSummary-" + counter + "']")).ToList();
            Console.WriteLine("JewelryGenderList count is " + JewelryGenderList.Count());
            if (JewelryGenderList.Count() > 0)
            {
                JewelryGenderList[0].Click();
                IsElementPresent(driver, By.Id("summary-edit-value-" + counter));
                TextEditItem = driver.FindElements(By.XPath("//input[@id='summary-edit-value-" + counter + "']")).ToList();
                Console.WriteLine("TextEditItem count is " + TextEditItem.Count());
                if (TextEditItem.Count() > 0)
                {
                    TextEditItem[0].Clear();
                    TextEditItem[0].SendKeys(JewelryItem);
                    Actions action = new Actions(driver);

                    action.SendKeys(Keys.Tab).Build().Perform();

                    BtnUpdateItem = driver.FindElements(By.XPath("//a[@id='SaveJewelryItemInlineSummary-" + counter + "']")).ToList();
                    Console.WriteLine("BtnUpdateItem count is " + BtnUpdateItem.Count());
                    if (BtnUpdateItem.Count() > 0)
                    {
                        JavaScriptClick(BtnUpdateItem[0]);
                        //BtnUpdateItem[0].Click();
                    }
                }
            }
        }

        public void selectJewelry(string itemType, int counter)
        {
            string listJewelryType = "select[id$='express-itemType-"+counter+"']";
            Console.WriteLine("ListJew: {0}", listJewelryType);
            UIAction(listJewelryType, itemType, "selectbox");
        }
        public void JewelryDetails_Details_Group(string JewelrySubType, string JewelryGender, int counter)
        {

            Console.WriteLine("JewelryGender for counter " + counter + " is " + JewelryGender);
            if (JewelryGender.Length > 0)
            {
                JewelryGenderList = driver.FindElements(By.XPath("//input[@name='JewelryGender-" + counter + "']")).ToList();
                Console.WriteLine("JewelryGenderList count is " + JewelryGenderList.Count());
                if (JewelryGenderList.Count() > 0)
                {
                    IsElementPresent(driver, By.Name("JewelryGender-" + counter));
                    switch (JewelryGender.ToLower().Trim())
                    {
                        case "men's":
                            JewelryGenderList[0].Click();
                            break;
                        case "women's":
                            JewelryGenderList[1].Click();
                            break;
                    }
                }
            }
            if (JewelrySubType.Length > 0)
            {
                Console.WriteLine("JewelrySubType for counter " + counter + " is " + JewelrySubType);
                if (!JewelrySubType.ToLower().Equals("other"))
                {
                    IWebElement JewelrySubtype = driver.FindElement(By.XPath("//input[@id='JewelrySubType-" + counter + "-" + JewelrySubType + "']"));

                    JewelrySubtype.Click();
                }
                else
                {
                    JewelrySubtypeList = driver.FindElements(By.XPath("//textarea[@id='UserDescription-JI-" + counter + "']")).ToList();
                    if (JewelrySubtypeList.Count > 0)
                    {
                        JewelrySubtypeList[0].Click();
                        JewelrySubtypeList[0].SendKeys("test");
                    }
                }
            }
        }

        public void SetEffectiveDate(string EffectiveDate)
        {
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            DateTime date = DateTime.Now;
            Actions action = new Actions(driver);
            string SetDate = "";
            string ExpDate = "";
            if (EffectiveDate.ToLower() == "currentdate")
            {
                Console.WriteLine("----------------");
                SetDate = string.Format("{0:MM/dd/yyyy}", date);
                ExpDate = string.Format("{0:MM/dd/yyyy}", date.AddYears(1));
            }
            else if (EffectiveDate.Contains("+"))
            {
                Console.WriteLine("---dATE +--------");
                string[] details = EffectiveDate.Split('+');
                Console.WriteLine(Int32.Parse(details[1]));
                Console.WriteLine(date);
                Console.WriteLine(date.AddDays(Int32.Parse(details[1])));
                SetDate = string.Format("{0:MM/dd/yyyy}", date.AddDays(Int32.Parse(details[1])));
                Console.WriteLine("under logic ");
                DateTime parsedDate = DateTime.Parse(SetDate);
                ExpDate = string.Format("{0:MM/dd/yyyy}", parsedDate.AddYears(1));
                Console.WriteLine(SetDate);
                Console.WriteLine(ExpDate);
            }
            else
            {
                SetDate = EffectiveDate;
                ExpDate = string.Format("{00:MMM d, yyyy}", date.AddYears(1));
            }
            Console.WriteLine("Magic date is " + SetDate);

            IList<IWebElement> EffictiveDate = driver.FindElements(By.XPath("//input[@id='EffectiveDate']")).ToList();
            if (EffictiveDate.Count > 0)
            {
                EffictiveDate[0].SendKeys(SetDate.Trim());
                action.SendKeys(Keys.Tab);
                action.Perform();
                action.Release();
            }
            RegKey.SetValue("EFFDATE", SetDate);
            RegKey.SetValue("EXPDATE", ExpDate);
            pause();
        }

        public void SelectAlarm(string Alarm)
        {


            switch (Alarm.ToLower().Trim())
            {
                case "no":
                    UIAction(radioHasAlarmNo, string.Empty, "radio");
                    break;
                case "monitored alarm system":
                    UIAction(radioHasAlarmMonioredAlarm, string.Empty, "radio");
                    break;
                case "local alarm":
                    UIAction(radioHasAlarmLocal, string.Empty, "radio");
                    break;
                default:
                    break;
            }
        }

       

        public void SetAdditionalUnderwritingNeeded(string Uwquetsions)
        {
            switch (Uwquetsions.ToLower().Trim())
            {
                case "no":
                    UIAction(radioUWNo, string.Empty, "radio");
                    break;
                case "yes":
                    UIAction(radioUWYes, string.Empty, "radio");
                    break;
               
                default:
                    break;
            }
        }

        public void SelectAppraisal(int counter)
        {
            SelectAppraisalList = driver.FindElements(By.XPath("//span[@id='UploadAppraisal-JI-" + counter + "']")).ToList();
            if (SelectAppraisalList.Count > 0)
            {
                SelectAppraisalList[0].Click();
                Console.WriteLine("Clicked Apprisial Button");
                Process UpLoadFile = new Process();
                UpLoadFile.StartInfo.FileName = "H:\\Public\\Penguins.jpg";
                Console.WriteLine("Select File");
                UpLoadFile.StartInfo.CreateNoWindow = true;
                UpLoadFile.Start();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Upload task complete");
            }
        }

        public void ClickApprisalDate(string ApprisalPurchaseDate, int counter)
        {
            DateTime date = DateTime.Now;
            Actions action = new Actions(driver);
            string SetDate = ApprisalPurchaseDate;
            IList<IWebElement> EffictiveDate = driver.FindElements(By.XPath("//input[@id='AppraisalDate-JI-" + counter + "']")).ToList();
            if (EffictiveDate.Count > 0)
            {
                EffictiveDate[0].SendKeys(SetDate.Trim());
                action.SendKeys(Keys.Tab);
                action.Perform();
                action.Release();
            }
        }
        public void ClickNext()
        {
            IsElementPresent(driver, By.Id("jewelryDetailsNext"));
            JavaScriptClick(driver.FindElement(By.Id("jewelryDetailsNext")));

            //UIAction(buttonjewelryDetailsNext, string.Empty, "a");
        }
    }
}

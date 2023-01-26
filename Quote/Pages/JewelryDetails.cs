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

namespace Quote.Pages
{
    public class JewelryDetails : Page
    {
        string containerjewelryDetail = "div[id$='jewelryDetailsContainer']";
        string textareaDescription = "textarea[id$='UserDescription-JI-2']";
        string radioHasAlarmNo = "input[id$='HasAlarm-No']";
        string radioHasAlarmMonioredAlarm = "input[id$='HasAlarm-Monitored Alarm System']";
        string radioHasAlarmLocal = "input[id$='HasAlarm-Local Alarm']";
        IList<IWebElement> JewelrySubtypeList;
        IList<IWebElement> JewelryGenderList;
        IList<IWebElement> SelectAppraisalList;

        public JewelryDetails(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(containerjewelryDetail);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(containerjewelryDetail));
        }

        public void JewelryDetails_Details_Group( string JewelrySubType, string JewelryGender, int counter )
        {

        
            if (JewelrySubType!= null)
            {
                JewelrySubtypeList = driver.FindElements(By.XPath("//input[@name='JewelrySubType-'+ counter]")).ToList();
                if (JewelrySubtypeList.Count > 1)
                {
                    JewelrySubtypeList[0].Click();
                }
            }

            if (JewelryGender != null)
            {
                JewelryGenderList = driver.FindElements(By.XPath("//input[@name='JewelryGender-'+ counter]")).ToList();
                if (JewelryGenderList.Count > 1)
                {
                    JewelryGenderList[0].Click();
                }
            }


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

        public void SelectAppraisal(int counter)
        {
            SelectAppraisalList = driver.FindElements(By.XPath("//input[id$='UploadAppraisal-JI'+ counter]")).ToList();
            pause();
            Process UpLoadFile = new Process();
            UpLoadFile.StartInfo.FileName = "H:\\Information Technology\\QA\\01.The Team\\AutoIT\\ApprisalUpLoad_SF.exe";
            UpLoadFile.StartInfo.Arguments = "H:\\\"Information Technology\"\\QA\\\"01.The Team\\AutoIT\"\\Penguins.jpg";
            UpLoadFile.StartInfo.CreateNoWindow = true;
            UpLoadFile.Start();
        }

    }
}

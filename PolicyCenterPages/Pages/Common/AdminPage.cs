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
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyCenterPages.Pages.Common
{
   public class AdminPage : Page
    {
        string Administrationmenu = "a[id$='TabBar:AdminTab']";
        string EventmessageOption = "a[id$='Admin:MenuLinks:Admin_Messages']";
        string resumeBtn = "a[id$=':MessagingDestinationControlList_ResumeButton']";
        string SuspendBtn = "a[id$=':MessagingDestinationControlList_SuspendButton']";
        string DesktopTab = "a[id$='TabBar:DesktopTab']";
        string[] arrTblList;
        public AdminPage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(Administrationmenu);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.Id(Administrationmenu));
        }

        //public void ManageTrasport(string Environemnttoexecute)
        //{
        //    UIAction(Administrationmenu, string.Empty, "a");
        //    pause();
        //    UIAction(EventmessageOption, string.Empty, "a");
        //    pause();
        //    Console.WriteLine("Main Logic");
        //    List<IWebElement> TableInputElements = driver.FindElements(By.Id("MessagingDestinationControlList:MessagingDestinationControlListScreen:MessagingDestinationsControlLV")).ToList();
        //    Console.WriteLine("count of array for account " + TableInputElements.Count());
        //    arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
        //    Console.WriteLine("count of array for account " + TableInputElements.Count());
        //    arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

        //    for (int k = 0; k < arrTblList.Count(); k++)
        //    {
        //        string CheckboxID = "";
        //        Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
        //        if (arrTblList[k].ToString().Contains("Suspended"))
        //        {
        //            Console.WriteLine("inside Suspended logic ");
        //            CheckboxID = "input[id$=':MessagingDestinationsControlLV:"+ (k-9) +":_Checkbox']";
        //            UIAction(CheckboxID, string.Empty, "radio");
        //            UIAction(resumeBtn, string.Empty, "a");
        //        }
             
        //        if (!Environemnttoexecute.Equals("stage"))
        //            {
        //                if (arrTblList[k].ToString().Contains("ContactMessageTransport"))
        //                {
        //                    Console.WriteLine(Environemnttoexecute.Equals("stage"));
        //                    CheckboxID = "input[id$=':MessagingDestinationsControlLV:" + (k - 9) + ":_Checkbox']";
        //                    UIAction(CheckboxID, string.Empty, "radio");
        //                    UIAction(SuspendBtn, string.Empty, "a");
        //                }
        //        }
                    
        //            //System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];

        //    }
        //    UIAction(DesktopTab, string.Empty, "a");
        //    pause();
        //}

        public void ManageTrasport(string Environemnttoexecute)
        {
            UIAction(Administrationmenu, string.Empty, "a");
            pause();
            UIAction(EventmessageOption, string.Empty, "a");
            pause();
            Console.WriteLine("Main Logic");
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("MessagingDestinationControlList:MessagingDestinationControlListScreen:MessagingDestinationsControlLV")).ToList();
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            for (int k = 0; k < arrTblList.Count(); k++)
            {
                string CheckboxID = "";
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
                if (arrTblList[k].ToString().Contains("Suspended"))
                {
                    Console.WriteLine("inside Suspended logic ");
                    CheckboxID = "input[id$=':MessagingDestinationsControlLV:" + (k - 9) + ":_Checkbox']";
                    UIAction(CheckboxID, string.Empty, "radio");
                    UIAction(resumeBtn, string.Empty, "a");
                }
                switch (Environemnttoexecute.ToLower().Trim())
                {
                    case "qa9":
                    case "qa8":
                    case "qa7":
                        CheckboxID = "input[id$=':MessagingDestinationsControlLV:" + (k - 9) + ":_Checkbox']";
                        UIAction(CheckboxID, string.Empty, "radio");
                        UIAction(SuspendBtn, string.Empty, "a");
                        break;

                    default:
                        break;

                }
                //if (!Environemnttoexecute.Equals("stage"))
                //    {
                //        if (arrTblList[k].ToString().Contains("ContactMessageTransport"))
                //        {
                //            Console.WriteLine(Environemnttoexecute.Equals("stage"));
                //            CheckboxID = "input[id$=':MessagingDestinationsControlLV:" + (k - 9) + ":_Checkbox']";
                //            UIAction(CheckboxID, string.Empty, "radio");
                //            UIAction(SuspendBtn, string.Empty, "a");
                //        }
                //}

                //System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];

            }
            UIAction(DesktopTab, string.Empty, "a");
            pause();
        }

    }
}

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
using TechTalk.SpecFlow;

namespace PLPortalPages.Pages
{
    public class CommonPLPortal : Page
    {

        string[] arrTblList;

        string linkAccountSummary = "a[href$='.*/PLPortal/Account']";

        string linkaddDocument = "a[id$='AddDocument']";

        string btnSubmitAppraisal = "input[id$='submit']";

        string btnChooseFile;



        public CommonPLPortal(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            // VerifyUIElementIsDisplayed(btnSubmitClaim);
        }

        public override void WaitForLoad()
        {

        }

        public void GetClaimNumber()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//div[@class='saveSuccess']"));

            IList<IWebElement> lblBoundPolicyNumber = driver.FindElements(By.XPath("//div[@class='internal-left-col']")).ToList();
            Console.WriteLine("total count on confirmation page are " + lblBoundPolicyNumber.Count());
            arrTblList = lblBoundPolicyNumber[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);


            for (int k = 0; k < arrTblList.Count(); k++)
            {
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
            }

            if (arrTblList[0].ToString().Equals("Claim Successfully Submitted"))
            {
                string claimnumber = "";
                claimnumber = arrTblList[1].ToString().Substring(21, 9);
                Console.WriteLine("Claim number is " + claimnumber);
                ScenarioContext.Current["CLAIM"] = claimnumber;
            }

        }

        public void VerifyJewelryAdded()
        {
            Boolean Confirm_Flag = false;
            System.Threading.Thread.Sleep(3000);
            DataStorage temp = new DataStorage();
            string Date = temp.GetTempValue("EMAIL");
            IList<IWebElement> lblBoundPolicyNumber = driver.FindElements(By.XPath("//div[@class='internal-left-col']")).ToList();
            Console.WriteLine("total count on confirmation page are " + lblBoundPolicyNumber.Count());
            arrTblList = lblBoundPolicyNumber[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Console.WriteLine("Email address is " + Date);

            for (int k = 0; k < arrTblList.Count(); k++)
            {
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
                if (arrTblList[k].ToString().Contains("An email has been sent to you " + Date + " for your records. We will contact you within 2 business days with any questions regarding your item. If you need to correct this update, please call us at 888-884-2424."))
                {
                    Confirm_Flag = true;
                    break;
                }

                if (arrTblList[k].ToString().Contains("An email has been sent to " + Date + " for your records. We will contact you within 2 business days with any questions."))
                {
                    Confirm_Flag = true;
                    break;
                }


            }

            //Equals("An email has been sent to you " + Date + " for your records. We will contact you within 2 business days with any questions regarding your item. If you need to correct this update, please call us at 888-884-2424."))
            if (Confirm_Flag)
            {
                Console.WriteLine("Jwelery Added successfully");
            }
            else
            {
                Assert.Fail("Jwelry not added");
            }

        }

        public void ManageleftNavigation(string NavigationOption)
        {
            pause();
            pause();
            List<IWebElement> linkNavigation;
            switch (NavigationOption.ToLower().Trim())
            {
                case "account summary":
                    linkNavigation = driver.FindElements(By.XPath("//a[contains(text(),'Account Summary')]")).ToList();
                    Console.WriteLine("count is " + linkAccountSummary.Count());
                    linkNavigation[0].Click();
                    //UIAction(linkAccountSummary, string.Empty, "a");
                    break;
                case "pay my premium":
                    linkNavigation = driver.FindElements(By.XPath("//a[contains(text(),'Pay My Premium')]")).ToList();
                    Console.WriteLine("count is " + linkAccountSummary.Count());
                    linkNavigation[0].Click();
                    break;
                case "account settings":
                    linkNavigation = driver.FindElements(By.XPath("//a[contains(text(),'Account Settings')]")).ToList();
                    Console.WriteLine("count is " + linkAccountSummary.Count());
                    linkNavigation[0].Click();
                    break;
                case "edocuments":
                    linkNavigation = driver.FindElements(By.XPath("//a[contains(text(),'eDocuments')]")).ToList();
                    Console.WriteLine("count is " + linkAccountSummary.Count());
                    linkNavigation[0].Click();
                    break;
                case "log out":
                    linkNavigation = driver.FindElements(By.XPath("//a[contains(text(),'Log Out')]")).ToList();
                    Console.WriteLine("count is " + linkAccountSummary.Count());
                    linkNavigation[0].Click();
                    break;
            }
            pause();

        }


        public void UploadApprisial(int count)
        {
            //WaitUntilElementIsDisplayed(driver, By.XPath("//input[@id='submit']"));
            pause();
            for (int i = 0; i < count; i++)
            {

                if (i != 0)
                {
                    UIAction(linkaddDocument, string.Empty, "a");
                }
                btnChooseFile = "input[id$='Files_" + i + "_']";

                UIAction(btnChooseFile, string.Empty, "a");


                pause();
                Process UpLoadFile = new Process();
                UpLoadFile.StartInfo.FileName = "H:\\Information Technology\\QA\\01.The Team\\AutoIT\\ApprisalUpLoad_SF.exe";
                UpLoadFile.StartInfo.Arguments = "H:\\\"Information Technology\"\\QA\\\"01.The Team\\AutoIT\"\\Penguins.jpg";
                pause();
                pause();
                pause();
                UpLoadFile.StartInfo.CreateNoWindow = true;
                pause();
                pause();
                pause();
                UpLoadFile.Start();
                pause();
                pause();
                pause();
                pause();





            }
            UIAction(btnSubmitAppraisal, string.Empty, "a");
        }

        public void VerifyApprisialUploaded()
        {
            Boolean Confirm_Flag = false; ;
            System.Threading.Thread.Sleep(3000);
            DataStorage temp = new DataStorage();
            string Email = temp.GetTempValue("EMAIL");
            IList<IWebElement> lblBoundPolicyNumber = driver.FindElements(By.XPath("//div[@class='internal-left-col']")).ToList();
            Console.WriteLine("total count on confirmation page are " + lblBoundPolicyNumber.Count());
            arrTblList = lblBoundPolicyNumber[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);


            for (int k = 0; k < arrTblList.Count(); k++)
            {
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
                if (arrTblList[k].ToString().Equals("A confirmation email has been sent to you at " + Email + ". Should we have additional questions, we will contact you."))
                {
                    Confirm_Flag = true;
                    break;
                }

            }
            if (Confirm_Flag)
            {
                Console.WriteLine("Apprisial uploaded successfully");
            }
            else
            {
                Assert.Fail("Apprisial not uploaded successfully");
            }

        }



    }

}

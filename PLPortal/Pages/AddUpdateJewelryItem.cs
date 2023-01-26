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
    public class AddUpdateJewelryItem : Page
    {

        string btnAddItemSaveContinue = "input[id$='jewelryitem_save']";
        string btnAddItem = "input[id$='addItem']";
        string btnUpdateItem = "input[id$='updateItem']";

        string listJewelryItemType = "select[id$='JewelryItemType']";
        string chckReplaceItem = "input[id$='ReplacementItem']";
        string txtAppraisedDate = "input[id$='LastAppraisedDate']";
        string txtRetailValue = "input[id$='RetailReplacementValue']";
        string listDeductible = "select[id$='Deductible']";
        string listJewelryWearer = "select[id$='JewelryWearerCorrelationId']";
        string listJewelryStorage = "select[id$='JewelryStorageLocation']";
        string txtCoverageDate = "input[id$='CoverageBeginDate']";
        string txtComments = "textarea[id$='Comments']";
        string chckJewelryItemType = "input[id$='JewelryItems_0__IsSelected']";
        string txtUpdatedValue = "input[id$='JewelryItems_0__UpdatedValue']";
        //string btncontinueQuote = "input[vlaue ='Continue to Quote']";
        string btncontinueQuote = "input[id$='continueQuote']";
        string txtAppraisalDate = "input[id$='JewelryItems_0__LastAppraisedDate']";
        string btnUploadFile = "input[id$='MultiFile1']";
        string btnsaveQuote = "input[id$='saveQuote']";



        string btnSubmitClaim = "input[id$='verifyAndSubmit']";
        string txtContactPhone = "input[id$='contactPhoneField']";
        string txtContactCity = "input[id$='ContactCity']";
        string txtContactState = "input[id$='ContactState']";
        string txtContactPostal = "input[id$='ContactPostalCode']";
        string txtContactAddr1 = "input[id$='ContactAddr1']";
        string txtContactAddr2 = "input[id$='ContactAddr2']";
        string txtContactEmail = "input[id$='ContactEmail']";
        string chckNewAddress = "input[id$='IsNewAddress']";




        public AddUpdateJewelryItem(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnAddItem);
        }

        public override void WaitForLoad()
        {

        }


        public void ClickonManageButton(string actiontype)
        {

            switch ((actiontype.ToLower().Trim()))
            {
                case "add":
                    UIAction(btnAddItem, string.Empty, "a");
                    break;
                case "update":
                    UIAction(btnUpdateItem, string.Empty, "a");
                    break;
                default:

                    break;


            }
        }

        public void UpdateJewelry(string UpdatedValue, string ApprisialDate)
        {

            pause();
            pause();
            //  WaitUntilElementIsDisplayed(driver, By.Id("JewelryItems_0__IsSelected"));

            UIAction(chckJewelryItemType, string.Empty, "a");

            // Upload file

            UIAction(btnUploadFile, string.Empty, "a");
            pause();
            Process UpLoadFile = new Process();
            UpLoadFile.StartInfo.FileName = "H:\\Information Technology\\QA\\01.The Team\\AutoIT\\ApprisalUpLoad_SF.exe";
            UpLoadFile.StartInfo.Arguments = "H:\\\"Information Technology\"\\QA\\\"01.The Team\\AutoIT\"\\Penguins.jpg";
            UpLoadFile.StartInfo.CreateNoWindow = true;
            UpLoadFile.Start();
            pause();
            pause();
            UIAction(txtUpdatedValue, UpdatedValue, "textbox");
            pause();
            UIAction(txtAppraisalDate, ApprisialDate, "textbox");

            //// IList<IWebElement> btnContinueList2 = driver.FindElements(By.XPath("//[@id='infoIcon']")).ToList();

            //Console.WriteLine("Count is btnContinueList" + btnContinueList.Count());
            //btnContinueList[0].Click();
            //   btnContinueList2[0].Click();
            // JavaScriptClick(btnContinueList[0]);
            //bool isSavebuttonDisplayed = false;
            //IList<IWebElement> btnContinueList;
            //IList<IWebElement> btnSave;
            //int Count = 1;
            //Console.WriteLine("Im befor click button");
            //try
            //{
            //    do
            //    {
            //        btnContinueList = driver.FindElements(By.XPath("//input[@id='continueQuote']")).ToList();
            //        Console.WriteLine("Count is btnContinueList" + btnContinueList.Count());
            //        btnContinueList[0].Click();
            //        //UIAction(btncontinueQuote, string.Empty, "a");
            //        pause();
            //        btnSave = driver.FindElements(By.XPath("//input[@id='saveQuote']")).ToList();
            //        Console.WriteLine("Count is btnContinueList" + btnSave.Count());
            //        Count = Count + 1;
            //    } while (btnSave.Count > 0 || Count < 5);
            //}catch(Exception e)
            //{

            //}
            UIAction(btncontinueQuote, string.Empty, "a");
            pause();
            pause();
            UIAction(btnsaveQuote, string.Empty, "a");



        }

        public void AddJewelry(string JewelryType, string ReplacingItem, string ValuedDate, string ReplacementValue, string Deductible, string JewelryWearer, string JewelryStored, string DateforCoverage, string AdditionalInformation)
        {
            // WaitUntilElementIsDisplayed(driver, By.Id("jewelryitem_save"));
            pause();
            pause();
            UIAction(listJewelryItemType, JewelryType, "selectbox");
            if (ReplacingItem.ToLower().Trim() == "yes")
            {
                UIAction(chckReplaceItem, string.Empty, "a");
                pause();
                IList<IWebElement> btnCheck;
                //        btnContinueList[0].Click();
                //        //UIAction(btncontinueQuote, string.Empty, "a");
                //        pause();
                btnCheck = driver.FindElements(By.XPath("//input[@name='SelectedExistingItems']")).ToList();

                if (btnCheck.Count() > 0)
                {
                    btnCheck[0].Click();
                }


                //UIAction("input[@name='SelectedExistingItems' and value='1' ]", string.Empty, "a");


            }
            if (!string.IsNullOrEmpty(ValuedDate))
            {
                UIAction(txtAppraisedDate, ValuedDate, "textbox");
            }
            UIAction(txtRetailValue, ReplacementValue, "textbox");
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab);
            pause();
            action.Perform();
            action.Release();
            UIAction(listDeductible, Deductible, "selectbox");
            UIAction(listJewelryWearer, JewelryWearer, "selectbox");
            UIAction(listJewelryStorage, JewelryStored, "selectbox");
            if (!string.IsNullOrEmpty(DateforCoverage))
            {
                UIAction(txtCoverageDate, DateforCoverage, "textbox");
            }
            if (!string.IsNullOrEmpty(AdditionalInformation))
            {
                List<IWebElement> txtareaDescription = driver.FindElements(By.XPath("//textarea[@id='Comments']")).ToList();
                txtareaDescription[0].SendKeys(AdditionalInformation);
            }
            UIAction(btnAddItemSaveContinue, string.Empty, "a");
        }

        public void UpdateContactInformation(string ContactAddress1, string ContactAddress2, string ContactCity, string ContactState, string ContactPhone, string ContactEmail, string ContactZip, string IsNerwAddress)
        {

            if (!string.IsNullOrEmpty(ContactAddress1))
            {
                List<IWebElement> tempContactAddr1 = driver.FindElements(By.XPath("//input[@id='ContactAddr1']")).ToList();
                tempContactAddr1[0].Clear();
                UIAction(txtContactAddr1, ContactAddress1, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactAddress2))
            {
                List<IWebElement> tempContactAddr2 = driver.FindElements(By.XPath("//input[@id='ContactAddr2']")).ToList();
                tempContactAddr2[0].Clear();
                UIAction(txtContactAddr1, ContactAddress2, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactCity))
            {
                List<IWebElement> tempContactCity = driver.FindElements(By.XPath("//input[@id='ContactCity']")).ToList();
                tempContactCity[0].Clear();
                UIAction(txtContactCity, ContactCity, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactState))
            {
                List<IWebElement> tempContactState = driver.FindElements(By.XPath("//input[@id='ContactState']")).ToList();
                tempContactState[0].Clear();
                UIAction(txtContactState, ContactState, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactZip))
            {
                List<IWebElement> tempContactZip = driver.FindElements(By.XPath("//input[@id='ContactPostalCode']")).ToList();
                tempContactZip[0].Clear();
                UIAction(txtContactPostal, ContactZip, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactPhone))
            {
                Console.WriteLine("phone number valus is " + ContactPhone);
                List<IWebElement> tempContactPhone = driver.FindElements(By.XPath("//input[@id='contactPhoneField']")).ToList();
                tempContactPhone[0].Clear();
                UIAction(txtContactPhone, ContactPhone, "textbox");

            }

            if (!string.IsNullOrEmpty(ContactEmail))
            {
                List<IWebElement> tempContactEmail = driver.FindElements(By.XPath("//input[@id='ContactEmail']")).ToList();
                tempContactEmail[0].Clear();
                UIAction(txtContactEmail, ContactEmail, "textbox");

            }

            if (IsNerwAddress.ToLower().Trim() == "yes")
            {
                UIAction(chckNewAddress, string.Empty, "a");

            }
        }
    }

}

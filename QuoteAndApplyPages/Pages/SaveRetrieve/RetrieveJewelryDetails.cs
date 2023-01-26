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
using QuoteAndApplyPages.Pages.SaveRetrieve;
namespace QuoteAndApplyPages.Pages.SaveRetrieve
{
    public class RetrieveJewelryDetails : Page
    {
        string buttonjewelryDetailsNext = "a[id$='jewelryDetailsNext']";
        string containerjewelryDetail = "div[id$='jewelryDetailsContainer']";
        string textareaDescription = "textarea[id$='UserDescription-JI-2']";
        string radioHasAlarmNo = "input[id$='HasAlarm-No']";
        string txtEfficitveDate = "input[id$='EffectiveDate']";
        string radioHasAlarmMonioredAlarm = "input[id$='HasAlarm-Monitored Alarm System']";
        string radioHasAlarmLocal = "input[id$='HasAlarm-Local Alarm']";
        IList<IWebElement> JewelrySubtypeList;
        IList<IWebElement> JewelryGenderList;
        IList<IWebElement> SelectAppraisalList;
        IList<IWebElement> TextEditItem;
        IList<IWebElement> BtnUpdateItem;

        public RetrieveJewelryDetails(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);

        }

        public override void VerifyPage()
        {
            pause();

            VerifyUIElementIsDisplayed(radioHasAlarmNo);
        }

        public override void WaitForLoad()
        {
            pause();
            WaitFor(driver.FindElement(By.Id("jewelryDetailsNext")));

        }

        public void VerifyMainJewelry(string JewelryType, string JewelryValue, int counter, int mainCounter)
        {
            List<IWebElement> JewelryType_List = driver.FindElements(By.XPath("//label[@data-bind[contains(.,'visible: !$parent.isExpress || $parent, text: jewelryItem.jewelryTypeDescription')]]")).ToList();
            List<IWebElement> JewelryValue_List = driver.FindElements(By.XPath("//span[@data-bind='currency: jewelryItem.value']")).ToList();
            comparevalue(JewelryType, JewelryType_List[counter].Text, "JewelryType");
            comparevalue(JewelryValue, JewelryValue_List[counter + mainCounter].Text.Replace("$", "").Replace(".00", "").Replace(",", ""), "JewelryGenderType");
        }
        //public void UpdateItemValue(string JewelryItem, int counter)
        //{
        //    JewelryGenderList = driver.FindElements(By.XPath("//a[@id='EditJewelryItemInlineSummary-" + counter + "']")).ToList();
        //    Console.WriteLine("JewelryGenderList count is " + JewelryGenderList.Count());
        //    if (JewelryGenderList.Count() > 0)
        //    {
        //        JewelryGenderList[0].Click();
        //        pause();
        //        TextEditItem = driver.FindElements(By.XPath("//input[@id='summary-edit-value-" + counter + "']")).ToList();
        //        Console.WriteLine("TextEditItem count is " + TextEditItem.Count());
        //        if (TextEditItem.Count() > 0)
        //        {
        //            pause();
        //            TextEditItem[0].Clear();
        //            TextEditItem[0].SendKeys(JewelryItem);
        //            Actions action = new Actions(driver);

        //            action.SendKeys(Keys.Tab).Build().Perform();
        //         //   action.SendKeys(Keys.Tab).Build().Perform();
        //            pause();
        //            pause();
        //            pause();
        //            pause();

        //            BtnUpdateItem = driver.FindElements(By.XPath("//a[@id='SaveJewelryItemInlineSummary-" + counter + "']")).ToList();
        //            Console.WriteLine("BtnUpdateItem count is " + BtnUpdateItem.Count());
        //            if (BtnUpdateItem.Count() > 0)
        //            {
        //                pause();
        //                JavaScriptClick(BtnUpdateItem[0]);
        //                //BtnUpdateItem[0].Click();
        //            }
        //        }
        //    }
        //}

        //public void JewelryDetails_Details_Group(string JewelrySubType, string JewelryGender, int counter)
        //{
        //    if (JewelryGender != null)
        //    {
        //        JewelryGenderList = driver.FindElements(By.XPath("//input[@name='JewelryGender-" + counter + "']")).ToList();
        //        Console.WriteLine("JewelryGenderList count is " + JewelryGenderList.Count());
        //        if (JewelryGenderList.Count() > 0)
        //        {
        //            switch (JewelryGender.ToLower().Trim())
        //            {
        //                case "men's":
        //                    pause();
        //                    JewelryGenderList[0].Click();

        //                    //  JewelryGenderList = "input[id$='JewelryGender-" + counter + "-Men\'s ']";

        //                    //Console.WriteLine("Gender Male: {0}", JewelryGenderList.Count);

        //                    break;
        //                case "women's":
        //                    pause();
        //                    JewelryGenderList[1].Click();
        //                    //  JewelryGenderList = "input[id$='JewelryGender-" + counter + "-Women\'s ']";
        //                    // JewelryGenderList = driver.FindElements(By.XPath("//input[@name='JewelryGender-'+ counter + 'Women\'s\']")).ToList();
        //                    //Console.WriteLine("Gender FeMale: {0}", JewelryGenderList);
        //                    break;
        //                }
        //        }



        //    }

        //    if (JewelrySubType != null)
        //    {
        //        if (!JewelrySubType.ToLower().Equals("other"))
        //        {
        //            JewelrySubtypeList = driver.FindElements(By.XPath("//input[@name='JewelrySubType-" + counter + "']")).ToList();
        //            Console.WriteLine("JewelrySubtypeList count is " + JewelrySubtypeList.Count());
        //            if (JewelrySubtypeList.Count > 0)
        //            {
        //                JewelrySubtypeList[0].Click();
        //            }
        //        }
        //        else
        //        {
        //          JewelrySubtypeList = driver.FindElements(By.XPath("//textarea[@id='UserDescription-JI-" + counter + "']")).ToList();
        //            if (JewelrySubtypeList.Count > 0)
        //            {
        //                JewelrySubtypeList[0].Click();
        //                JewelrySubtypeList[0].SendKeys("test");
        //            }
        //        }
        //    }



        //}

        //public void SetEffectiveDate(string EffectiveDate)
        //{
        //    RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
        //    DateTime date = DateTime.Now;
        //    Actions action = new Actions(driver);
        //    string SetDate = "";
        //    string ExpDate = "";
        //    if (EffectiveDate.ToLower() == "currentdate")
        //    {
        //        //Console.WriteLine(date.ToString("MM/dd/yyyy"));
        //        ////Console.WriteLine(string.Format("{MM/dd/yyyy}", date));
        //        //Console.WriteLine(String.Format("{0:MM/dd/yyyy}", date));
        //        Console.WriteLine("----------------");
        //        SetDate = string.Format("{0:MM/dd/yyyy}", date);
        //        ExpDate = string.Format("{0:MM/dd/yyyy}", date.AddYears(1));
        //    }
        //    else if (EffectiveDate.Contains("+"))
        //    {
        //        Console.WriteLine("---dATE +--------");
        //        string[] details = EffectiveDate.Split('+');
        //        Console.WriteLine(Int32.Parse(details[1]));
        //        Console.WriteLine(date);
        //        Console.WriteLine(date.AddDays(Int32.Parse(details[1])));

        //        // Date expecteddate_temp = date.AddDays(Int32.Parse(details[1]));
        //        SetDate = string.Format("{0:MM/dd/yyyy}", date.AddDays(Int32.Parse(details[1])));
        //        Console.WriteLine("under logic ");
        //        DateTime parsedDate = DateTime.Parse(SetDate);
        //        ExpDate = string.Format("{0:MM/dd/yyyy}", parsedDate.AddYears(1));
        //        Console.WriteLine(SetDate);
        //        Console.WriteLine(ExpDate);
        //    }
        //    else
        //    {
        //        SetDate = EffectiveDate;
        //        ExpDate = string.Format("{00:MMM d, yyyy}", date.AddYears(1));
        //    }
        //    Console.WriteLine("Magic date is " + SetDate);

        //    IList<IWebElement> EffictiveDate = driver.FindElements(By.XPath("//input[@id='EffectiveDate']")).ToList();
        //    if (EffictiveDate.Count > 0)
        //    {
        //        // EffictiveDate[0].Click();
        //        //  EffictiveDate[0].Click();
        //        //   EffictiveDate[0].Clear();
        //        pause();
        //        EffictiveDate[0].SendKeys(SetDate.Trim());
        //        action.SendKeys(Keys.Tab);
        //        action.Perform();
        //        action.Release();
        //    }


        //    //SetDate = "July 20, 2018";
        //    //    UIAction(buttonjewelryDetailsNext, string.Empty, "a");
        //    //UIAction(txtEfficitveDate, SetDate, "textbox");

        //    //   IWebElement IWEffDate = driver.FindElement(By.Id("EffectiveDate"));
        //    //JavaScriptClick(IWEffDate);
        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    //js.ExecuteScript("document.getElementById('" + EffectiveDate + "').value='" + SetDate + "'");
        //    //UIAction(txtEfficitveDate, SetDate, "textbox");
        //    //Actions action = new Actions(driver);
        //    //     action.
        //    //     action.SendKeys(SetDate);
        //    //     pause();
        //    //action.Perform();
        //    //action.Release();
        //    //pause();
        //    //pause();

        //    RegKey.SetValue("EFFDATE", SetDate);
        //    RegKey.SetValue("EXPDATE", ExpDate);
        //}

        //public void SelectAlarm(string Alarm)
        //{
        //    switch (Alarm.ToLower().Trim())
        //    {
        //        case "no":
        //            UIAction(radioHasAlarmNo, string.Empty, "radio");
        //            break;
        //        case "monitored alarm system":
        //            UIAction(radioHasAlarmMonioredAlarm, string.Empty, "radio");
        //            break;
        //        case "local alarm":
        //            UIAction(radioHasAlarmLocal, string.Empty, "radio");
        //            break;
        //        default:
        //            break;


        //    }
        //}

        //public void SelectAppraisal(int counter)
        //{
        //    pause();
        //    pause();
        //    SelectAppraisalList = driver.FindElements(By.XPath("//span[@id='UploadAppraisal-JI-" + counter + "']")).ToList();
        //    if (SelectAppraisalList.Count > 0)
        //    {
        //        SelectAppraisalList[0].Click();
        //        pause();
        //        Process UpLoadFile = new Process();
        //        UpLoadFile.StartInfo.FileName = "H:\\Information Technology\\QA\\01.The Team\\AutoIT\\ApprisalUpLoad_SF.exe";
        //        UpLoadFile.StartInfo.Arguments = "H:\\\"Information Technology\"\\QA\\\"01.The Team\\AutoIT\"\\Penguins.jpg";
        //        UpLoadFile.StartInfo.CreateNoWindow = true;
        //        UpLoadFile.Start();
        //    }
        //    pause();
        //}
        //public void ClickApprisalDate(string ApprisalPurchaseDate, int counter)
        //{
        //    DateTime date = DateTime.Now;
        //    Actions action = new Actions(driver);
        //    string SetDate = ApprisalPurchaseDate;
        //    IList<IWebElement> EffictiveDate = driver.FindElements(By.XPath("//input[@id='AppraisalDate-JI-" + counter + "']")).ToList();
        //    if (EffictiveDate.Count > 0)
        //    {
        //        pause();
        //        EffictiveDate[0].SendKeys(SetDate.Trim());
        //        action.SendKeys(Keys.Tab);
        //        action.Perform();
        //        action.Release();
        //    }
        //}
        //public void ClickNext()
        //{
        //    UIAction(buttonjewelryDetailsNext, string.Empty, "a");
        //}

        public void verifyJewelryDetails_Details_Group(string JewelrySubType, string JewelryGender, int counter)
        {
            //    RetrieveApplicantWearerPage compareFun = new RetrieveApplicantWearerPage(driver);
            if (JewelryGender.Length > 0)
            {
                List<IWebElement> Gender_Id = driver.FindElements(By.XPath("//input[@name[contains(.,'JewelryGender-')]]")).ToList();
                string Gender_Id_str = Gender_Id[counter].GetAttribute("id").Replace("JewelryGender-", "");
                string[] subType_list = Gender_Id_str.Split('-');
                int genderType_Id_number = Int32.Parse(subType_list[0]);
                List<IWebElement> radioWearerGender = driver.FindElements(By.XPath("//input[@name='JewelryGender-" + genderType_Id_number + "']")).ToList();
                switch (JewelryGender.ToLower().Trim())
                {
                    case "men\'s":
                        comparevalue("True", radioWearerGender[0].GetAttribute("checked"), "JewelryGenderType");
                        break;
                    case "women\'s":
                        comparevalue("True", radioWearerGender[1].GetAttribute("checked"), "JewelryGenderType");
                        break;
                    default:
                        break;
                }
            }


            if (JewelrySubType.Length > 0)
            {
                if (!JewelrySubType.ToLower().Equals("other"))
                {
                    List<IWebElement> subType_Id = driver.FindElements(By.XPath("//input[@name[contains(.,'JewelrySubType-')]]")).ToList();
                    string subType = subType_Id[counter].GetAttribute("id").Replace("JewelrySubType-", "");
                    string[] subType_list = subType.Split('-');
                    int subType_Id_number = Int32.Parse(subType_list[0]);

                    IWebElement JewelrySubtypeList = driver.FindElement(By.XPath("//input[@id='JewelrySubType-" + subType_Id_number + "-" + JewelrySubType + "']"));
                    comparevalue("True", JewelrySubtypeList.GetAttribute("checked"), "JewelrySubtype");

                }
                else
                {
                    List<IWebElement> subType_Id = driver.FindElements(By.XPath("//textarea[@id[contains(.,'UserDescription-JI-')]]")).ToList();
                    comparevalue("test", subType_Id[0].GetAttribute("value"), "DescriptionOther");
                }
            }


        }
        public void comparevalue(string expectedvalue, string actualvalue, string paramater)
        {
            if (expectedvalue.Length > 0)
            {
                if (expectedvalue.ToLower().Trim().Equals(actualvalue.ToLower().Trim()))
                {
                    System.Console.WriteLine("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " matches");
                }
                else
                {
                    System.Console.WriteLine("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " do not matches");
                    Assert.Fail("Expected valus is " + expectedvalue + " actual value is " + actualvalue + " for paramter " + paramater + " do not matches");
                }
            }

        }

        public void verifyApprisalDate(string ApprisalPurchaseDate, int counter)
        {
            List<IWebElement> Id_text = driver.FindElements(By.XPath("//input[@id[contains(.,'AppraisalDate-JI-')]]")).ToList();
            comparevalue(ApprisalPurchaseDate, Id_text[counter].GetAttribute("value"), "JewelryAppraisalDate");

        }

        public void verifyEffectiveDate(string EffectiveDate)
        {

            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            DateTime date = DateTime.Now;
            Actions action = new Actions(driver);
            string SetDate = "";
            if (EffectiveDate.ToLower() == "currentdate")
            {

                Console.WriteLine("----------------");
                SetDate = string.Format("{0:MM/dd/yyyy}", date);

            }
            else if (EffectiveDate.Contains("+"))
            {
                string[] details = EffectiveDate.Split('+');
                SetDate = string.Format("{0:MM/dd/yyyy}", date.AddDays(Int32.Parse(details[1])));
            }
            else
            {
                SetDate = EffectiveDate;
            }
            IWebElement txtEffectivDate = driver.FindElement(By.XPath("//input[@id='EffectiveDate']"));
            comparevalue(SetDate, txtEffectivDate.GetAttribute("value"), "EffectivDate");
        }


        public void VerifyAlarm(string Alarm)
        {
            IWebElement JewelryAlarmtype;
            switch (Alarm.ToLower().Trim())
            {
                case "no":
                    JewelryAlarmtype = driver.FindElement(By.XPath("//input[@id='HasAlarm-No']"));
                    comparevalue("True", JewelryAlarmtype.GetAttribute("checked"), "JewelryAlarmtype-No");
                    break;
                case "monitored alarm system":
                    JewelryAlarmtype = driver.FindElement(By.XPath("//input[@id='HasAlarm-Monitored Alarm System']"));
                    comparevalue("True", JewelryAlarmtype.GetAttribute("checked"), "JewelryAlarmtype-Monitored Alarm System");
                    break;
                case "local alarm":
                    JewelryAlarmtype = driver.FindElement(By.XPath("//input[@id='HasAlarm-Local Alarm']"));
                    comparevalue("True", JewelryAlarmtype.GetAttribute("checked"), "JewelryAlarmtype-Local Alarm");

                    break;
                default:
                    break;


            }

        }


        public void RetrieveSetJewelryDetails_Details_Group(string JewelrySubType, string JewelryGender, int counter)
        {

            // Gander
            if (JewelryGender == "Women's")
            {
                IWebElement Gender = driver.FindElement(By.XPath("//*[@id='jmnfJewelryDetailsForm']/div[1]/div[2]/div[1]/div/div/div/label[2]/i"));
                Gender.Click();
            }



            else
            {
                IWebElement Gender = driver.FindElement(By.XPath("//*[@id='jmnfJewelryDetailsForm']/div[1]/div[2]/div[1]/div/div/div/label[1]/i"));
                Gender.Click();
            }
            // type 
            if (JewelrySubType == "Engagement Ring")
            {
                IWebElement type = driver.FindElement(By.XPath("//*[@id='jmnfJewelryDetailsForm']/div[1]/div[2]/div[2]/div/div/div/label[1]/i"));
                type.Click();
            }
            else
            {
                if (JewelrySubType == "Wedding Set")
                {
                    IWebElement type = driver.FindElement(By.XPath("//*[@id='jmnfJewelryDetailsForm']/div[1]/div[2]/div[2]/div/div/div/label[2]/i"));
                    type.Click();
                }

                else
                {
                    if (JewelrySubType == "Wedding Band")
                    {
                        IWebElement type = driver.FindElement(By.XPath("//*[@id='jmnfJewelryDetailsForm']/div[1]/div[2]/div[2]/div/div/div/label[3]/i"));
                        type.Click();
                    }
                    else
                    {
                        if (JewelrySubType == "Rolex")
                        {
                            IWebElement type = driver.FindElement(By.XPath("//*[@id='jmnfJewelryDetailsForm']/div[1]/div[2]/div[2]/div/div/div/label[1]/i"));
                            type.Click();
                        }
                        else
                        {
                            // Other  
                            // IWebElement type = driver.FindElement(By.XPath("//*[@id='jmnfJewelryDetailsForm']/div[1]/div[2]/div[2]/div/div/div/label[3]/i"));
                            // type.Click();
                        }
                    }
                }
            }

            try
            {
                System.Threading.Thread.Sleep(2000);
                IWebElement gander = driver.FindElement(By.XPath("//*[@id='jmnfJewelryDetailsForm']/div[2]/div[2]/div[1]/div/div/div/label[1]/i"));
                gander.Click();
            }
            catch
            {
                Console.WriteLine("Other selected");
            }
            try
            {
                System.Threading.Thread.Sleep(2000);
                IWebElement text = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[3]/div[1]/div[1]/div[6]/div/form/div[3]/div[2]/div[1]/div/div/textarea"));
                // text.Click();
                text.SendKeys("test");
            }
            catch
            {
                Console.WriteLine("txt window not selected");
            }


        }

        public void RetrieveSetSelectAppraisal(int counter, string browsertype)
        {
            pause();
            pause();
            //if (browsertype == "Chrome")
            //{ 


            //}
            List<IWebElement> Appraisal_Id = driver.FindElements(By.XPath("//span[@id[contains(.,'UploadAppraisal-JI-')]]")).ToList();
            string Appraisal_Id_str = Appraisal_Id[counter].GetAttribute("id").Replace("UploadAppraisal-JI-", "");
            int Appraisal_Id_number = Int32.Parse(Appraisal_Id_str);
            SelectAppraisalList = driver.FindElements(By.XPath("//span[@id='UploadAppraisal-JI-" + (Appraisal_Id_number + counter) + "']")).ToList();
            if (SelectAppraisalList.Count > 0)
            {
                SelectAppraisalList[0].Click();
                pause();
                Process UpLoadFile = new Process();
                UpLoadFile.StartInfo.FileName = "H:\\Information Technology\\QA\\01.The Team\\AutoIT\\ApprisalUpLoad_SF.exe";
                UpLoadFile.StartInfo.Arguments = "H:\\\"Information Technology\"\\QA\\\"01.The Team\\AutoIT\"\\Penguins.jpg";
                UpLoadFile.StartInfo.CreateNoWindow = true;
                UpLoadFile.Start();
            }
            pause();
        }


        public void RetrieveSetClickApprisalDate(string ApprisalPurchaseDate, int counter)
        {
            DateTime date = DateTime.Now;
            Actions action = new Actions(driver);
            string SetDate = ApprisalPurchaseDate;

            List<IWebElement> AppraisalDate_Id = driver.FindElements(By.XPath("//input[@id[contains(.,'AppraisalDate-JI-')]]")).ToList();
            string AppraisalDate_Id_str = AppraisalDate_Id[counter].GetAttribute("id").Replace("AppraisalDate-JI-", "");
            int AppraisalDate_Id_number = Int32.Parse(AppraisalDate_Id_str);



            IList<IWebElement> EffictiveDate = driver.FindElements(By.XPath("//input[@id='AppraisalDate-JI-" + (AppraisalDate_Id_number + counter) + "']")).ToList();
            if (EffictiveDate.Count > 0)
            {
                pause();
                EffictiveDate[0].SendKeys(SetDate.Trim());
                action.SendKeys(Keys.Tab);
                action.Perform();
                action.Release();
            }
        }
    }
}

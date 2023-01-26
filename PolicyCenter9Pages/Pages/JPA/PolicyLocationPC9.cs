using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebCommonCore;
using HelperClasses;
using TechTalk.SpecFlow;

namespace PolicyCenter9Pages.Pages.JPA
{
    public class PolicyLocationPC9 : Page
    {
        string lblPolicyLocation = "span[id$= ':JPALocationsScreen:ttlBar']";
        string btnAddSafe = "a[id$=':safesLV_tb:Add']";
        string btnNExt = "a[id$= ':Next']";
        string txtAlarmType = "input[id$= ':alarmTypeId-inputEl']";

        string txtLocationName = "input[id$= ':LocationName-inputEl']";
        string txtCareof = "input[id$= ':CareOf-inputEl']";
        string btnAddLoc = "span[id$= ':Add-btnInnerEl']";

        string txtAddress1 = "input[id$= ':AddressLine1-inputEl']";
        string txtAddress2 = "input[id$= ':AddressLine2-inputEl']";
        string txtcity = "input[id$= ':City-inputEl']";
        string txtstate = "input[id$= ':State-inputEl']";
        string txtzip = "input[id$= ':PostalCode-inputEl']";
        string btnverifyAddress = "a[id$=':verifyAddress_JMIC']";
        string VerifyAddrPageOK = "span[id='VerifyAddress_JMIC_Popup:Update-btnInnerEl']";
        string AddressErrorMsg = "//span[text()[contains(.,'Address is unverified. You must verify the address before updating contact information')]]";
        string VerifyAddressAccCreate = "span[id$=':verifyAddress_JMIC-btnInnerEl']";
        string AcceptThisAddress = "input[id='VerifyAddress_JMIC_Popup:acceptKeyInAddress-inputEl']";
        string txtphone = "input[id$=':NationalSubscriberNumber-inputEl']";

        public PolicyLocationPC9(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblPolicyLocation);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(lblPolicyLocation));
        }

        public void clickNextButton()
        {
            UIAction(btnNExt, String.Empty, "a");
        }

        public void UpdateNewLocationDetails(Table table)
        {
            string locationName = table.Rows[0]["locationName"];
            string careof = table.Rows[0]["CareOf"];
            string Address1 = table.Rows[0]["Address1"];
            string Address2 = table.Rows[0]["Address2"];
            string City = table.Rows[0]["City"];
            string State = table.Rows[0]["State"];
            string ZipCode = table.Rows[0]["ZipCode"];
            string PhoneNumber = table.Rows[0]["phone"];


            UIAction(btnAddLoc, string.Empty, "span");
            pause();
            //    WaitUntilElementVisible(driver,By.XPath("//div[@id='SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:JPALocationsScreen:JPALocationsPanelSet:LocationDetailInputSet:LocationInfo-inputEl'][text()[contains(.,'<empty>')]"),100);
            UIAction(txtLocationName, locationName, "textbox");
            UIAction(txtCareof, careof, "textbox");

            UIAction(txtAddress1, Address1, "textbox");
            UIAction(txtAddress2, Address2, "textbox");
            UIAction(txtcity, City, "textbox");
            driver.FindElement(By.CssSelector(txtcity)).SendKeys(Keys.Tab);
            driver.FindElement(By.CssSelector(txtstate)).Click();
            driver.FindElement(By.CssSelector(txtstate)).Clear();
            UIAction(txtstate, State, "textbox");
            driver.FindElement(By.CssSelector(txtstate)).SendKeys(Keys.Tab);
            WaitUntilElementVisible(driver, By.CssSelector(txtstate + "[value='" + State + "']"));
            if (IsElementPresent(driver, By.CssSelector(txtzip)) == false)
            {
                WaitUntilElementVisible(driver, By.CssSelector(txtzip));
            }

            UIAction(txtzip, ZipCode, "textbox");
            driver.FindElement(By.CssSelector(txtzip)).SendKeys(Keys.Tab);

            System.Threading.Thread.Sleep(5000);



            //WaitUntilElementInvisible(driver, By.XPath(AddressErrorMsg),20);
            //try
            //{
            //    IsElementPresent(driver, By.XPath(AddressErrorMsg));
            //    if (IsElementPresent(driver, By.CssSelector(VerifyAddressAccCreate)))
            //    {
            //        if (IsElementPresent(driver, By.CssSelector(AcceptThisAddress)))
            //        {
            //            driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();
            //            UIAction(VerifyAddrPageOK, string.Empty, "span");
            //        }
            //        else
            //        {
            //            UIAction(VerifyAddressAccCreate, string.Empty, "span");
            //        }
            //    }
            //    if (IsElementPresent(driver, By.CssSelector(AcceptThisAddress)))
            //    {
            //        driver.FindElement(By.CssSelector(AcceptThisAddress)).Click();
            //        UIAction(VerifyAddrPageOK, string.Empty, "span");
            //    }
            //}
            //catch
            //{

            //}
            ///*WaitUntilElementVisible*/(driver, By.Id("NewPolicyVaultContactPopup:ContactDetailScreen:ttlBar"), 60);

            //   WaitUntilElementVisible(driver, By.CssSelector(lblPolicyLocation), 60);
            //JavaScriptClick(By.CssSelector(txtphone));
            //   driver.FindElement(By.CssSelector(txtphone)).Click();
            // driver.FindElement(By.CssSelector(txtphone)).SendKeys(PhoneNumber);

            // UIAction(txtphone, PhoneNumber, "textbox");
        }

        public void UpdateAlarmType(string alartmtype)
        {
            //driver.FindElement(By.CssSelector(txtAlarmType)).Click();

            UIActionExt(By.CssSelector(txtAlarmType), "click");

            WaitFor(driver.FindElement(By.XPath("//li[text()='" + alartmtype + "']"))).Click();

            //    WaitUntilElementVisible(driver, By.CssSelector(txtAlarmType + "[value='" + alartmtype + "']"));
            //driver.FindElement(By.CssSelector(txtAlarmType)).Clear();
            //driver.FindElement(By.CssSelector(txtAlarmType)).SendKeys(alartmtype);
            //pause();
            //  driver.FindElement(By.CssSelector(txtAlarmType)).SendKeys(Keys.Tab);
            //UIAction(txtAlarmType, alartmtype, "textbox");
        }
        public void UpdateSafeDetails(Table table)
        {
            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                UIAction(btnAddSafe, String.Empty, "a");
                pause();
            }

            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                List<IWebElement> reservetableObj;
                reservetableObj = driver.FindElements(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:JPALocationsScreen:JPALocationsPanelSet:safesLV-body")).ToList();
                System.Console.WriteLine("reservetableObj count is " + reservetableObj.Count());
                var tabletemp = reservetableObj[0].FindElements(By.TagName("table"));
                System.Console.WriteLine("tabletemp count is " + tabletemp.Count());
                var data = tabletemp[i].FindElements(By.TagName("td"));
                if (table.Rows[i]["IsAnchred"].ToLower().Equals("yes"))
                {
                    var chck = data[2].FindElements(By.TagName("img"));
                    System.Console.WriteLine("chck count is " + chck.Count());
                    JavaScriptClick(chck[0]);
                }
            }

            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                List<IWebElement> reservetableObj1;
                reservetableObj1 = driver.FindElements(By.Id("SubmissionWizard:LOBWizardStepGroup:LineWizardStepSet:JPALocationsScreen:JPALocationsPanelSet:safesLV-body")).ToList();
                System.Console.WriteLine("reservetableObj1 count is " + reservetableObj1.Count());
                var tabletemp1 = reservetableObj1[0].FindElements(By.TagName("table"));
                System.Console.WriteLine("tabletemp count is " + tabletemp1.Count());
                var data = tabletemp1[i].FindElements(By.TagName("td"));
                var txt = data[3].FindElements(By.TagName("div"));
                txt[0].Click();
                WaitFor(driver.FindElement(By.XPath("//li[text()='" + table.Rows[i]["Weight"] + "']"))).Click();
                //txt[0].Clear();
                //txt[0].SendKeys(table.Rows[i]["Weight"]);
            }


        }


    }
}

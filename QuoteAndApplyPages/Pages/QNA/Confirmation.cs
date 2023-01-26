
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace QuoteAndApplyPages.Pages.QNA
{
    public class Confirmation : Page
    {
        string[] arrTblList;
        string btnContactJMIS = "a[id$='jmisContactBtn']";
        string radiocontactPrefJMIS = "input[id$='ContactPreference-Phone Call']";
        string btcontactPrefJMIS = "a[id$='jmisContactBtn']";
        string btnDownloadApplicationPdf = "a[id$='DownloadApplicationPdf']";
        string txtPLPortalPassword = "input[id$='RegistrationPassword']";
        //  string btnPLPortalregister = "a[text()='Register']";



        public Confirmation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            Console.WriteLine("VerifyPage");
            VerifyUIElementIsDisplayed(btnDownloadApplicationPdf);

        }

        public override void WaitForLoad()
        {
            Console.WriteLine("WaitForLoad");
            pause();
            if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim().Equals("stage"))
            {
                System.Threading.Thread.Sleep(12000);
            }
            WaitUntilElementVisible(driver, By.Id("DownloadApplicationPdf"));

        }

        public void CaptureAccountNumber()
        {
            Console.WriteLine("CaptureAccountNumber");

            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            string sAccountNumber;
            IWebElement IWAccountNumber = driver.FindElement(By.XPath("//span[@data-bind='text: $root.reviewViewModel().accountNumber']"));

            sAccountNumber = IWAccountNumber.Text;
            Console.WriteLine("Account Number: {0}", sAccountNumber);
            ScenarioContext.Current["ACCOUNT"] = sAccountNumber;
            RegKey.SetValue("ACCNO", sAccountNumber);

        }

        public void VerifyAutoPay(string AutoPay)
        {
            //pause();
            //pause();
            //pause();
            // IWebElement IWAutoPay = driver.FindElement(By.XPath("//span[@data-bind='text: $root.paymentViewModel().enrollInAutoPay() === true && $root.reviewViewModel().isApplicationPaymentComplete() === true ? \'Yes\' : \'No\' ']"));

            //IWebElement IWAutoPay = driver.FindElement(By.CssSelector("span[data-bind='text: $root.paymentViewModel().enrollInAutoPay() === true && $root.reviewViewModel().isApplicationPaymentComplete() === true ? \'Yes\' : \'No\' ']"));

            //Console.WriteLine(IWAutoPay.Text);


            //if (IWAutoPay.Text.ToLower().Trim() != AutoPay.ToLower().Trim())
            //{
            //    Assert.Fail("Auto Pay flag do not match");
            //}

            IList<IWebElement> lblInsuranceDetails = driver.FindElements(By.XPath("//div[@class='applicant-summary-content']")).ToList();
            Console.WriteLine("total count on confirmation page are " + lblInsuranceDetails.Count());
            arrTblList = lblInsuranceDetails[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);


            for (int k = 0; k < arrTblList.Count(); k++)
            {
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
                if (arrTblList[k].ToString() == "Enrolled in Auto Pay:")
                {
                    Console.WriteLine("Actual Value is " + arrTblList[k + 1].ToString().ToLower().Trim());
                    Console.WriteLine("Expected Value is " + AutoPay.ToLower().Trim());
                    //if (arrTblList[k + 1].ToString().ToLower().Trim() != AutoPay.ToLower().Trim())
                    //{
                    //    Assert.Fail("Auto Pay flag do not match");
                    //}

                }




            }
        }

        public void RegisterPLPortal(string Password)
        {
            pause();
            UIAction(txtPLPortalPassword, Password, "textbox");
            IList<IWebElement> btnregister;
            btnregister = driver.FindElements(By.XPath("//a[@class='btn jm-btn-primary']")).ToList();
            for (int i = 0; i < btnregister.Count(); i++)
            {
                Console.WriteLine(i + " counter value is " + btnregister[i].Text);
                if (btnregister[i].Text.Equals("Register"))
                {
                    btnregister[i].Click();
                    break;
                }
            }

            WaitUntilElementIsDisplayed(driver, By.XPath("//span[text()= 'You're registered. ']"));
            pause();
            pause();
            pause();
            Console.WriteLine("Account is registered in PL Portal");
        }



        public void VerifyAutoPayPolicyStatus(string AutoPay, string PolicyStatus)
        {
            pause();
            pause();
            pause();

            IList<IWebElement> lblInsuranceDetails = driver.FindElements(By.XPath("//div[@class='applicant-summary-content']")).ToList();
            Console.WriteLine("total count on confirmation page are " + lblInsuranceDetails.Count());
            arrTblList = lblInsuranceDetails[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);


            for (int k = 0; k < arrTblList.Count(); k++)
            {
                Console.WriteLine(k + " identifier " + arrTblList[k].ToString());

                if ((PolicyStatus.ToLower().Trim()) == "in force")
                {
                    if (arrTblList[k].ToString() == "Policy Number:")
                    {
                        Assert.AreNotEqual(arrTblList[k + 1].ToString(), "Retrieving…");
                    }

                }

                if (arrTblList[k].ToString() == "Enrolled in Auto Pay:")
                {
                    Console.WriteLine("Actual Value is " + arrTblList[k + 1].ToString().ToLower().Trim());
                    Console.WriteLine("Expected Value is " + AutoPay.ToLower().Trim());
                    if (arrTblList[k + 1].ToString().ToLower().Trim() != AutoPay.ToLower().Trim())
                    {
                        Assert.Fail("Auto Pay flag do not match");
                    }
                }




            }
        }
        public void VerifyConfirmationText(string expectedConfirmationContentValidation)
        {
            //   expectedConfirmationContentValidation = expectedConfirmationContentValidation.Replace("'", "’");
            string actualConfirmationContentValidation = "";
            IWebElement Confirmtextlist1 = driver.FindElement(By.XPath("//p[@data-bind='text: confirmationContentText']"));
            actualConfirmationContentValidation = Confirmtextlist1.Text.ToString();
            actualConfirmationContentValidation = actualConfirmationContentValidation.Replace("’", "'");
            //actualConfirmationContentValidation = Regex.Replace(actualConfirmationContentValidation, @"\u00A0", " ");
            Console.WriteLine("Confirmtextlist1:" + actualConfirmationContentValidation);
            Console.WriteLine("expectedConfirmationContentValidation:" + expectedConfirmationContentValidation);
            if (string.Equals(expectedConfirmationContentValidation.Trim().ToString(), actualConfirmationContentValidation.Trim().ToString(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Confirmation text match");
            }
            else
            {
                Assert.Fail();
                Console.WriteLine("Confirmation text do not match");
            }

        }
        public void CapturePolicyNumberDisplayed()
        {
            Console.WriteLine("CapturePolicyNumberDisplayed");
            string policyNumElement = "//*[@id='confirmationContainer']/div/div/div[2]/div[2]/div[1]/div[2]/div[2]/span";
            IWebElement policyNumberDisplayed = driver.FindElement(By.XPath(policyNumElement));
            
            if (policyNumberDisplayed.Text == "Retrieving..." || policyNumberDisplayed.Text == "Pending")
            {
                Assert.Fail("Policy number not displayed");
            }
            else 
            {
                Console.WriteLine("Policy number is Displayed " + policyNumberDisplayed.Text);
            }
        }
            


    
        #region Jmis
        public void ClickJMISButton()
        {
            ////WaitUntilElementDisplay(driver, By.XPath("//a[contains(.,'Contact JMIS')]"));
            //pause();
            //pause();
            //IWebElement ClickContactJMIC = driver.FindElement(By.XPath("//a[contains(.,'Contact JMIS')]"));
            //ClickContactJMIC.Click();
        }


        public void VerifyDetailsJMIS(string firstNameJMIS, string lastNameJMIS, string phoneNumberJMIS, string emailAddress)
        {
            //pause();
            //pause();
            //IWebElement IWFirstNameJMIS = driver.FindElement(By.Id("ContactFirstName"));
            //IWebElement IWLastNameJMIS = driver.FindElement(By.Id("ContactLastName"));
            //IWebElement IWPhoneJMIS = driver.FindElement(By.Id("ContactPhoneNumber"));
            //IWebElement IWEmailJMIS = driver.FindElement(By.Id("ContactEmail"));
            //WaitUntilElementVisible(driver, By.Id("ContactFirstName"));
            //string sActFirstNameJMIS = IWFirstNameJMIS.GetAttribute("value");
            //string sActLastNameJMIS = IWLastNameJMIS.GetAttribute("value");
            //string sActPhoneJMIS = IWPhoneJMIS.GetAttribute("value").Replace("(", "");
            //string sActEmailJMIS = IWEmailJMIS.GetAttribute("value");
            //sActPhoneJMIS = sActPhoneJMIS.Replace(")", "");
            //sActPhoneJMIS = sActPhoneJMIS.Replace("-", "");

            //Assert.AreEqual(firstNameJMIS, sActFirstNameJMIS);
            //Assert.AreEqual(lastNameJMIS, sActLastNameJMIS);
            //Assert.AreEqual(phoneNumberJMIS.Trim(), sActPhoneJMIS.Trim());
            //Assert.AreEqual(emailAddress, sActEmailJMIS);



        }
        public void ClickJMISContactPreference(string ContactPrefJMIS)
        {
            //pause();
            //pause();
            //WaitUntilElementIsDisplayed(driver, By.XPath("//a[contains(.,'Phone Call')]"));
            //Console.WriteLine(ContactPrefJMIS.ToLower().Trim());
            //switch (ContactPrefJMIS.ToLower().Trim())
            //{
            //    case "phone":
            //        IWebElement ClickByPhoneContactPref = driver.FindElement(By.Id("ContactPreference-Phone Call"));
            //        JavaScriptClick(ClickByPhoneContactPref);
            //        break;
            //    case "email":
            //        IWebElement ClickByEmailContactPref = driver.FindElement(By.Id("ContactPreference-Email"));
            //        JavaScriptClick(ClickByEmailContactPref);
            //        break;
            //    default:
            //        break;

            //}
        }
        public void ClickSendToJMIS()
        {
            //pause();
            //WaitUntilElementVisible(driver, By.XPath("//a[contains(.,'Send to JMIS')]"));
            //IWebElement ClickSendToJMIC = driver.FindElement(By.XPath("//a[contains(.,'Send to JMIS')]"));
            //ClickSendToJMIC.Click();
            //WaitUntilElementVisible(driver, By.XPath("//a[contains(.,'Close')]"));
            //IWebElement ClickCloseJMIC = driver.FindElement(By.XPath("//a[contains(.,'Close')]"));
            //ClickCloseJMIC.Click();
        }

        public void ClickGetQuotes()
        {
            //pause();
            //WaitUntilElementVisible(driver, By.Id("jmisGetQuoteBtn"));
            ////XPath("//a[id='jmisGetQuoteBtn']"));
            //IWebElement ClickGetQuotes = driver.FindElement(By.Id("jmisGetQuoteBtn"));
            //ClickGetQuotes.Click();
        }

        public void ClickGetQuotesGotIt()
        {
            //pause();
            //WaitUntilElementVisible(driver, By.Id("jmisAgree"));
            //IWebElement ClickGetQuotesGotit = driver.FindElement(By.Id("jmisAgree"));
            //ClickGetQuotesGotit.Click();
        }

        public void VerifyQuoteContnet()
        {
            //pause();
            //List<IWebElement> textGetQuotes = driver.FindElements(By.XPath("//p[contains(text(),'By clicking below, you acknowledge that in order to calculate your quotes and save you time, some of your information will be automatically sent to a website not owned or operated by Jewelers Mutual Insurance Company(JM).')]")).ToList();
            //if (textGetQuotes.Count() > 0)
            //{
            //    Console.WriteLine("Text Content is good and it matches ");
            //}
            //else
            //{
            //    Assert.Fail("Text Content do not matches ");
            //}

        }

        #endregion




    }
}


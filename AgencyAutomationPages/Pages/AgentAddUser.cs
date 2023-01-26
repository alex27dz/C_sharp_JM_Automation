using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using OpenQA.Selenium.Interactions;
using System.Diagnostics;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgencyAutomationPages.Pages
{
    public class AgentAddUser : Page
    {
        string txtFirstName = "input[id$='FirstName']";
        string txtLastName = "input[id$='LastName']";

        string selectPhoneType = "select[id$='ContactInfo_PrimaryPhoneType_SelectedPrimaryPhoneTypeValue']";
        string txtWorkPhone = "input[id$='ContactInfo_WorkPhone']";
        string txtCellPhone = "input[id$='ContactInfo_CellPhone']";
        string txtFax = "input[id$='ContactInfo_Fax']";
        string txtEmail = "input[id$='ContactInfo_Email']";
        string btnSaveUser = "input[id$='save']";


        public AgentAddUser(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnSaveUser);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnSaveUser));

        }

        public void AddUser(string FirstName, string LastName, string PhoneType, string WorkPhone, string CellPhone, string Fax, string Email, string Producer, string Subscribe)
        {
            bool flagtemp = true;
            int counter;
            pause();
            pause();
            pause();
            // IList<IWebElement> tableRow = x.FindElements(By.TagName("td")).ToList();
            IList<IWebElement> Producerobj;
            IWebElement Subscribeobj;
            ScenarioContext.Current["AgentName"] = FirstName + " " + LastName;
            //ScenarioContext.Current["AddedUserEmail"] = Email;
            UIAction(txtFirstName, FirstName, "textbox");
            UIAction(txtLastName, LastName, "textbox");
            switch ((PhoneType.ToLower()).Trim())
            {
                case "work":
                    UIAction(selectPhoneType, "Work", "selectbox");
                    break;
                case "cell":
                    UIAction(selectPhoneType, "Cell", "selectbox");
                    break;

            }
            if (!String.IsNullOrEmpty(WorkPhone))
            {
                UIAction(txtWorkPhone, WorkPhone, "textbox");
            }

            if (!String.IsNullOrEmpty(CellPhone))
            {
                UIAction(txtCellPhone, CellPhone, "textbox");
            }

            if (!String.IsNullOrEmpty(Fax))
            {
                UIAction(txtFax, Fax, "textbox");
            }

            if (!String.IsNullOrEmpty(Email))
            {
                if (Email.ToLower().Contains("unique"))
                {
                    Email = Unique.ID + "@jminsure.com";
                }
                else if (Email.ToLower().Equals("regedit"))
                {
                    DataStorage temp = new DataStorage();
                    Email = temp.GetTempValue("EMAIL");
                }
                System.Random random = new System.Random();
                Email = random.Next() + Email;
                UIAction(txtEmail, Email, "textbox");
            }

            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Build().Perform();
            System.Threading.Thread.Sleep(3500);

            //WaitUntilElementIsDisplayed(driver, By.XPath("//label[@for='AuthorizedProducers_0__Selected']"));
            if (Producer.Contains(";"))
            {
                string[] ProducerOptions = Producer.Split(';');
                for (int i = 0; i <= ProducerOptions.Count(); i++)
                {
                    int RowCount = 0;
                    counter = 0;
                    List<IWebElement> reservetableObj;
                    reservetableObj = driver.FindElements(By.Id("subagencyContainer")).ToList();
                    Console.WriteLine("table object count is " + reservetableObj.Count());
                    var rows = reservetableObj[0].FindElements(By.TagName("tr"));
                    Console.WriteLine("Row count is " + rows.Count());
                    for (int row_count = 0; row_count < rows.Count; row_count++)
                    {
                        var tds = rows[row_count].FindElements(By.TagName("td"));
                        Console.WriteLine("Cell count is " + tds.Count());
                        for (int cell_count = 0; cell_count < tds.Count; cell_count++)
                        {
                            var CellData = tds[cell_count].FindElements(By.Id("AuthorizedProducers_" + counter + "__Selected"));
                            counter = counter + 1;
                            if (CellData[0].Text == ProducerOptions[i])
                            {
                                CellData[0].Click();
                                break;
                            }
                        }

                    }



                    //Producerobj = driver.FindElements(By.XPath("//label[@for='AuthorizedProducers_0__Selected']"));
                    //Console.WriteLine("Elements count is " + Producerobj.Count());
                    //    for (int j = 0; j <= Producerobj.Count(); j++)
                    //    {
                    //        Console.WriteLine("Elements text is " + Producerobj[j].Text);
                    //        if (Producerobj[j].Text == ProducerOptions[i])
                    //        {
                    //            Producerobj[j].Click();
                    //            break;
                    //        }
                    //    }
                }


            }
            else
            {
                counter = 0;
                //Producerobj = driver.FindElements(By.XPath("//label[@for='AuthorizedProducers_0__Selected']"));
                //Console.WriteLine("Elements count is " + Producerobj.Count());

                List<IWebElement> reservetableObj;
                reservetableObj = driver.FindElements(By.Id("subagencyContainer")).ToList();
                Console.WriteLine("table object count is " + reservetableObj.Count());
                var rows = reservetableObj[0].FindElements(By.TagName("tr"));
                Console.WriteLine("Row count is " + rows.Count());
                for (int row_count = 0; row_count < rows.Count; row_count++)
                {
                    if (flagtemp)
                    {
                        var tds = rows[row_count].FindElements(By.TagName("td"));
                        Console.WriteLine("Cell count is " + tds.Count());
                        for (int cell_count = 0; cell_count < tds.Count; cell_count++)
                        {
                            var CellData = tds[cell_count].FindElements(By.Id("AuthorizedProducers_" + counter + "__Value"));
                            var CellSelector = tds[cell_count].FindElements(By.Id("AuthorizedProducers_" + counter + "__Selected"));


                            Console.WriteLine("counter is " + counter);
                            Console.WriteLine("Text is " + CellData[0].GetAttribute("value").ToString());
                            if (CellData[0].GetAttribute("value").ToString().ToUpper().Equals(Producer.ToUpper()))
                            {
                                Console.WriteLine("I am inside logic");
                                //JavaScriptClick(CellSelector[0]);
                                CellSelector[0].Click();
                                flagtemp = false;
                                break;

                            }
                            counter = counter + 1;
                        }
                    }



                }


                //for (int i = 0; i <= Producerobj.Count(); i++)
                //{
                //    Console.WriteLine("Elements text is " + Producerobj[i].Text);
                //    if (Producerobj[i].Text == Producer)
                //    {
                //        Producerobj[i].Click();
                //        break;
                //    }
                //}

            }

            if (!String.IsNullOrEmpty(Subscribe))
            {
                if (Subscribe.Contains(";"))
                {
                    string[] SubscribeOptions = Subscribe.Split(';');
                    for (int i = 0; i <= SubscribeOptions.Count(); i++)
                    {
                        Subscribeobj = driver.FindElement(By.XPath("//input[@id='sub" + SubscribeOptions[i] + "']"));
                        Subscribeobj.Click();
                        pause();
                    }
                }
                else
                {
                    Subscribeobj = driver.FindElement(By.XPath("//input[@id='sub" + Subscribe + "']"));
                    Subscribeobj.Click();
                }
            }
            UIAction(btnSaveUser, string.Empty, "button");
        }

    }
}

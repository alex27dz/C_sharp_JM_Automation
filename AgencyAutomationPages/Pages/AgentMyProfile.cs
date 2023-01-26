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
    public class AgentMyProfile : Page
    {

        string btnSave = "input[id$='UserInfoButton']";
        string btnDelete = "input[type$='button'][value$='Delete']";
        string txtFirstName = "input[id$='FirstName']";
        string txtLastName = "input[id$='LastName']";
        string txtUserName = "input[id$='UserName']";

        string selectPhoneType = "select[id$='ContactInfo_PrimaryPhoneType_SelectedPrimaryPhoneTypeValue']";
        string txtWorkPhone = "input[id$='ContactInfo_WorkPhone']";
        string txtCellPhone = "input[id$='ContactInfo_CellPhone']";
        string txtFax = "input[id$='ContactInfo_Fax']";
        string txtEmail = "input[id$='ContactInfo_Email']";
        string btnSaveChanges = "input[id$='UserInfoButton']";


        public AgentMyProfile(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(txtFirstName);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(txtFirstName));

        }

        public void SaveChanges()
        {
            UIAction(btnSave, String.Empty, "a");
        }

        public void SubscribeProducer(string Producer)
        {
            IList<IWebElement> Producerobj;
            string SubProd;
            if (Producer.Contains(";"))
            {



                string[] ProducerOptions = Producer.Split(';');
                for (int i = 0; i <= ProducerOptions.Count() - 1; i++)
                {
                    SubProd = "sub" + ProducerOptions[i];
                    Producerobj = driver.FindElements(By.XPath("//input[@id = '" + SubProd + "' ]"));
                    Console.WriteLine("Elements count is " + Producerobj.Count());
                    for (int j = 0; j <= Producerobj.Count() - 1; j++)
                    {
                        Console.WriteLine("Elements text is " + Producerobj[j].Text);
                        if (Producerobj[j].GetAttribute("value") == ProducerOptions[i])
                        {
                            Producerobj[j].Click();
                            break;
                        }
                    }
                }

            }
            else
            {
                SubProd = "sub" + Producer;
                Producerobj = driver.FindElements(By.XPath("//input[@id = '" + SubProd + "' ]"));
                Console.WriteLine("Elements count is " + Producerobj.Count());
                for (int i = 0; i <= Producerobj.Count() - 1; i++)
                {
                    Console.WriteLine("Elements text is " + Producerobj[i].Text);
                    if (Producerobj[i].Text == Producer)
                    {
                        Producerobj[i].Click();
                        break;
                    }
                }

            }
        }

        public void SelectProducer(string Producer)
        {
            IList<IWebElement> Producerobj;
            if (Producer.Contains(";"))
            {
                Producerobj = driver.FindElements(By.XPath("//label[@for[contains(., 'AuthorizedProducers_')]]"));
                Console.WriteLine("Elements count is " + Producerobj.Count());
                string[] ProducerOptions = Producer.Split(';');
                for (int i = 0; i <= ProducerOptions.Count() - 1; i++)
                {
                    for (int j = 0; j <= Producerobj.Count() - 1; j++)
                    {
                        Console.WriteLine("Elements text is " + Producerobj[j].Text);
                        if (Producerobj[j].Text == ProducerOptions[i])
                        {
                            Producerobj[j].Click();
                            break;
                        }
                    }
                }

            }
            else
            {
                Producerobj = driver.FindElements(By.XPath("//label[@for[contains(., 'AuthorizedProducers_')]]"));
                Console.WriteLine("Elements count is " + Producerobj.Count());
                for (int i = 0; i <= Producerobj.Count() - 1; i++)
                {
                    Console.WriteLine("Elements text is " + Producerobj[i].Text);
                    if (Producerobj[i].Text == Producer)
                    {
                        Producerobj[i].Click();
                        break;
                    }
                }

            }

        }

        public void VerifyAgentName()
        {

            IWebElement AgentNameHeading = driver.FindElement(By.XPath("//*[@id='userInfoContainer']/h3"));

            //Console.WriteLine("name is "+ AgentNameHeading.Text);
            //Console.WriteLine("name is in text" + driver.FindElement(By.XPath("//input[@id='FirstName']")).GetAttribute("value") + " " + driver.FindElement(By.XPath("//input[@id='LastName']")).GetAttribute("value"));

            if (!((AgentNameHeading.Text) == driver.FindElement(By.XPath("//input[@id='FirstName']")).GetAttribute("value") + " " + driver.FindElement(By.XPath("//input[@id='LastName']")).GetAttribute("value")))
            {
                Assert.Fail("Agent name do not match");
            }
            else
            {
                Console.WriteLine("Agent Name match");
            }
        }

        public void GetAgentName()
        {
            IWebElement FirstName;
            IWebElement LastName;
            IWebElement Email;
            FirstName = driver.FindElement(By.XPath("//input[@id='FirstName']"));
            LastName = driver.FindElement(By.XPath("//input[@id='LastName']"));
            Email = driver.FindElement(By.XPath("//input[@id='ContactInfo_Email']"));
            Console.WriteLine("First name is " + FirstName.GetAttribute("value"));
            Console.WriteLine("Last name is " + LastName.GetAttribute("value"));
            ScenarioContext.Current["AgentName"] = FirstName.GetAttribute("value") + " " + LastName.GetAttribute("value");
            ScenarioContext.Current["Email"] = Email.GetAttribute("value");

            Console.WriteLine("Agent name is " + ScenarioContext.Current["AgentName"]);
            Console.WriteLine("Email is " + ScenarioContext.Current["Email"]);
        }

        public void UpdateContactInfo(string PhoneType, string WorkPhone, string CellPhone, string Fax, string Email)
        {
            if (!string.IsNullOrEmpty(PhoneType))
            {
                Console.WriteLine("PhoneType");
                switch (PhoneType.ToLower().Trim())
                {
                    case "work":
                        UIAction(selectPhoneType, "Work", "selectbox");
                        break;
                    case "cell":
                        UIAction(selectPhoneType, "Cell", "selectbox");
                        break;
                    default:
                        break;
                }
            }
            if (!string.IsNullOrEmpty(WorkPhone))
            {
                Console.WriteLine("WorkPhone");
                List<IWebElement> WorkPhoneObj = driver.FindElements(By.XPath("//input[@id='ContactInfo_WorkPhone']")).ToList();
                WorkPhoneObj[0].Clear();
                UIAction(txtWorkPhone, WorkPhone, "textbox");
            }

            if (!string.IsNullOrEmpty(CellPhone))
            {
                Console.WriteLine("CellPhone");
                List<IWebElement> CellPhoneObj = driver.FindElements(By.XPath("//input[@id='ContactInfo_CellPhone']")).ToList();
                CellPhoneObj[0].Clear();
                UIAction(txtCellPhone, CellPhone, "textbox");

            }
            if (!string.IsNullOrEmpty(Fax))
            {
                Console.WriteLine("Fax");
                List<IWebElement> FaxObj = driver.FindElements(By.XPath("//input[@id='ContactInfo_Fax']")).ToList();
                FaxObj[0].Clear();
                FaxObj[0].SendKeys(Fax);
                //UIAction(txtFax, Fax, "textbox");

            }
            if (!string.IsNullOrEmpty(Email))
            {
                Console.WriteLine("Email");
                List<IWebElement> EmailObj = driver.FindElements(By.XPath("//input[@id='ContactInfo_Email']")).ToList();
                EmailObj[0].Clear();
                UIAction(txtEmail, Email, "textbox");

            }
            UIAction(btnSaveChanges, string.Empty, "button");
        }


    }
}

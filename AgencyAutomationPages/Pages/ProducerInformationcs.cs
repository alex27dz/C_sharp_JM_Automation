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
using AgencyAutomationPages.Pages;

namespace AgencyAutomationPages.Pages
{
    public class ProducerInformation : Page
    {
        string AgentInfoContainer = "div[id$='agentInfoContainer']";
        string txtLastName = "input[id$='LastName']";

        string selectPhoneType = "select[id$='ContactInfo_PrimaryPhoneType_SelectedPrimaryPhoneTypeValue']";
        string txtWorkPhone = "input[id$='ContactInfo_WorkPhone']";
        string txtCellPhone = "input[id$='ContactInfo_CellPhone']";
        string txtFax = "input[id$='ContactInfo_Fax']";
        string txtEmail = "input[id$='ContactInfo_Email']";
        string btnSaveUser = "input[id$='producerAccessButton']";



        public ProducerInformation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(AgentInfoContainer);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(AgentInfoContainer));

        }

        public void ClickonEditButton(string EditType)
        {
            List<IWebElement> EditButton;
            EditButton = driver.FindElements(By.XPath("//input[@type='button'][@title='Edit']")).ToList();
            Console.WriteLine("Count if edit object is " + EditButton.Count());
            switch (EditType.ToLower().Trim())
            {
                case "address":
                    EditButton[0].Click();
                    break;
                case "contactinfo":
                    EditButton[1].Click();
                    break;
                default:

                    break;
            }

        }


        public void VerifyEditButtoninProducerInformation(string AddressEditFlag, string ContactInformationEditFlag)
        {
            // WaitUntilElementIsDisplayed(driver, By.XPath("//div[@id='agentAddressContainer']"));
            pause();
            pause();
            List<IWebElement> AddressEditObj = driver.FindElement(By.Id("agentAddressContainer")).FindElements(By.XPath("//input[@class='btn btn-default'][@value='Edit']")).ToList();
            if(AddressEditFlag.ToLower().Equals("yes"))
            {
                if(AddressEditObj.Count()>0)
                {
                    Console.WriteLine("Edit button is in correct format for Producer Address");
                }
                else
                {
                    Console.WriteLine("Edit button is not in correct format for Producer Address");
                    Assert.Fail("Edit button is in correct format for Producer Address");
                }

            }
            else
            {
                if (AddressEditObj.Count() > 0)
                {
                    Console.WriteLine("Edit button is not in correct format for Contact Information");
                    Assert.Fail("Edit button is in correct format for Contact Information");
                }
                else
                {
                    Console.WriteLine("Edit button is in correct format for Contact Information");
                   
                  
                }
            }




            List<IWebElement> ContactInformationEditObj = driver.FindElement(By.Id("agentContactContainer")).FindElements(By.XPath("//input[@class='btn btn-default'][@value='Edit']")).ToList();
            if (ContactInformationEditFlag.ToLower().Equals("yes"))
            {
                if (ContactInformationEditObj.Count() > 0)
                {
                    Console.WriteLine("Edit button is in correct format for Contact Information");
                }
                else
                {
                    Console.WriteLine("Edit button is not in correct format for Producer Contact Information");
                    Assert.Fail("Edit button is not in correct format for Producer Contact Information");
                }

            }
            else
            {
                if (ContactInformationEditObj.Count() > 0)
                {
                    Console.WriteLine("Edit button is not in correct format for Producer Contact Information");
                    Assert.Fail("Edit button is not in correct format for Producer Contact Information");
                }
                else
                {
                    Console.WriteLine("Edit button is in correct format for Producer Contact Information");
                    

                }
            }




        }
        public void SelectProducer(string producer)
        {

            WaitUntilElementIsDisplayed(driver, By.XPath("//a[@id='producers']"));
            List<IWebElement> producerNameObj = driver.FindElement(By.Id("subagencyContainer")).FindElements(By.XPath("//div[@class='containerRound-label']")).ToList();
            List<IWebElement> producerNameClickObj = driver.FindElement(By.Id("subagencyContainer")).FindElements(By.XPath("//input[@class='btn btn-default'][@value='Select']")).ToList();
            Console.WriteLine("total number of user name object is " + producerNameObj.Count());
            Console.WriteLine("total number of user click object is " + producerNameClickObj.Count());
            Console.WriteLine("------");
            for (int i = 0; i <= producerNameObj.Count() - 1; i++)
            {
                Console.WriteLine(i + " producer object text is " + producerNameObj[i].Text);
                Console.WriteLine("text for agent click is " + producerNameClickObj[i].GetAttribute("onclick"));
                string Producer_Link = producerNameClickObj[i].GetAttribute("onclick").ToString();
                Console.WriteLine("link is " + Producer_Link);
                if (Producer_Link.Contains("="+ producer))
                {
                    Console.WriteLine("inside link logic");
                    JavaScriptClick(producerNameClickObj[i]);
                   // producerNameClickObj[i].Click();
                    break;
                }
            }
        }

        public void SelectUser(string userName)
        {


            List<IWebElement> UserNameObj = driver.FindElement(By.Id("userListContainer")).FindElements(By.XPath("//div[@class='containerRound-label']")).ToList();
            List<IWebElement> UserNameClickObj = driver.FindElement(By.Id("userListContainer")).FindElements(By.XPath("//input[@class='btn btn-default'][@value='Select']")).ToList();
            Console.WriteLine("total number of user name object is " + UserNameObj.Count());
            Console.WriteLine("total number of user click object is " + UserNameClickObj.Count());
            Console.WriteLine("------");
            for (int i = 0; i <= UserNameObj.Count() - 1; i++)
            {
                Console.WriteLine(i + " producer object text is " + UserNameObj[i].Text);
                Console.WriteLine("text for agent click is " + UserNameClickObj[i].GetAttribute("onclick"));
            }
        



            ////List<IWebElement> producerObj = driver.FindElements(By.XPath("//input[@class ='btn btn-default'][contains(.,'" + Producer + "')])")).ToList(); 
            ////var producerObj = driver.FindElements(By.Id("subagencyContainer")).ToList();
            //List<IWebElement> producerObj = driver.FindElement(By.Id("agentProducerContainer")).FindElements(By.XPath("//div[@class='containerRound-label']")).ToList();
            //Console.WriteLine("total number of producer object is " + producerObj.Count());
            //Console.WriteLine("------");
            //for (int i=0;i<= producerObj.Count()-1;i++)
            //{
            //   Console.WriteLine(i + " producer object text is " + producerObj[i].Text);
            //    if(producerObj[i].Text.ToString().ToLower()== Producer.ToLower())
            //    {
            //        IWebElement AgentClick = producerObj[i].FindElement(By.XPath("//input[@class='btn btn-default']"));
            //        Console.WriteLine("text for agent click is " + AgentClick.GetAttribute("value"));
            //      //  AgentClick.Click();
            //    }
            //}
            //Console.WriteLine("------");
            ////producerObj[0].Click();
        }
    }
}

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
    public class MasterAgency : Page
    {
        string AgentInfoContainer = "div[id$='agentInfoContainer']";
        string txtLastName = "input[id$='LastName']";

        string selectPhoneType = "select[id$='ContactInfo_PrimaryPhoneType_SelectedPrimaryPhoneTypeValue']";
        string txtWorkPhone = "input[id$='ContactInfo_WorkPhone']";
        string txtCellPhone = "input[id$='ContactInfo_CellPhone']";
        string txtFax = "input[id$='ContactInfo_Fax']";
        string txtEmail = "input[id$='ContactInfo_Email']";
        string btnSaveUser = "input[id$='producerAccessButton']";



        public MasterAgency(IWebDriver driver) : base(driver)
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


        public void VerifyUser()
        {
            string Username = ScenarioContext.Current["AgentName"].ToString();
            //Regression_AA @jminsure.com
            List<IWebElement> producerObj = driver.FindElements(By.XPath("//div[@class='containerRound-label']")).ToList();
            for (int i = 0; i <= producerObj.Count() - 1; i++)
            {
                if (producerObj[i].Text.Contains(Username))
                {
                    Console.WriteLine("user exist");
                    break;
                }
            }
        }

        public void SelectProducer(string Producer)
        {


            List<IWebElement> producerObj = driver.FindElement(By.Id("subagencyContainer")).FindElements(By.XPath("//input[@class='btn btn-default'][@value='Select']")).ToList();
            Console.WriteLine("total number of producer object is " + producerObj.Count());
            Console.WriteLine("------");
            for (int i = 0; i <= producerObj.Count() - 1; i++)
            {
                Console.WriteLine(i + " producer object text is " + producerObj[i].Text);
                Console.WriteLine("text for agent click is " + producerObj[i].GetAttribute("onclick"));
                if (producerObj[i].GetAttribute("onclick").Contains(Producer))
                {
                    producerObj[i].Click();
                    break;
                }
            }
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



            public void VerifyEditButtoninMasterAgency(string AddressEditFlag, string ContactInformationEditFlag)
        {
            // WaitUntilElementIsDisplayed(driver, By.XPath("//div[@id='agentAddressContainer']"));
            pause();
            pause();
            List<IWebElement> AddressEditObj = driver.FindElement(By.Id("agentAddressContainer")).FindElements(By.XPath("//input[@class='btn btn-default'][@value='Edit']")).ToList();
            if (AddressEditFlag.ToLower().Equals("yes"))
            {
                if (AddressEditObj.Count() > 0)
                {
                    Console.WriteLine("Edit button is in correct format for Master Agency Information Address");
                }
                else
                {
                    Console.WriteLine("Edit button is not in correct format for Master Agency Information Address");
                    Assert.Fail("Edit button is in correct format for Master Agency Information Address");
                }

            }
            else
            {
                if (AddressEditObj.Count() > 0)
                {
                    Console.WriteLine("Edit button is not in correct format for Master Agency Information Address");
                    Assert.Fail("Edit button is not in correct format for Master Agency Information Address");

                }
                else
                {
                    Console.WriteLine("Edit button is in correct format for Master Agency Information Address");
                   
                }
            }




            List<IWebElement> ContactInformationEditObj = driver.FindElement(By.Id("agentContactContainer")).FindElements(By.XPath("//input[@class='btn btn-default'][@value='Edit']")).ToList();
            if (ContactInformationEditFlag.ToLower().Equals("yes"))
            {
                if (ContactInformationEditObj.Count() > 0)
                {
                    Console.WriteLine("Edit button is in correct format for Master Agency Contact Information");
                }
                else
                {
                    Console.WriteLine("Edit button is not in correct format for Master Agency Contact Information");
                    Assert.Fail("Edit button is in correct format for Master Agency Contact Information");
                }

            }
            else
            {
                if (ContactInformationEditObj.Count() > 0)
                {
                    Console.WriteLine("Edit button is not in correct format for Master Agency Contact Information");
                    Assert.Fail("Edit button is not in correct format for Master Agency Contact Information");
                }
                else
                {
                    Console.WriteLine("Edit button is in correct format for Master Agency Contact Information");
                   

                }
            }




      
    }
    }
}

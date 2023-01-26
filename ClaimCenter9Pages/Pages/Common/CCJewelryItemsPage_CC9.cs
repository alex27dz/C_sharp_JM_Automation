using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace ClaimCenter9Pages.Pages.Common
{
    public class CCJewelryItemsPage_CC9 : Page
    {
        [FindsBy(How = How.Id, Using = "ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:PolicyJewelryItemDetailPanelSet:PolicyJewelryItemDetailDV:ClassCodeType-inputEl")]
        public IWebElement txtItemClass;

        [FindsBy(How = How.Id, Using = "ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:PolicyJewelryItemDetailPanelSet:PolicyJewelryItemDetailDV:Description-inputEl")]
        public IWebElement txtItemdescription;

        [FindsBy(How = How.Id, Using = "ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:PolicyJewelryItemDetailPanelSet:PolicyJewelryItemDetailDV:Value-inputEl")]
        public IWebElement txtItemValue;

        [FindsBy(How = How.Id, Using = "ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:PolicyJewelryItemDetailPanelSet:PolicyJewelryItemDetailDV:located_with-inputEl")]
        public IWebElement txtItemlocatedwith;

        [FindsBy(How = How.Id, Using = "ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:PolicyJewelryItemDetailPanelSet:PolicyJewelryItemDetailDV:located_with-trigger-picker")]
        public IWebElement txtLocatedwithPicker;

        [FindsBy(How = How.Id, Using = "ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:PolicyJewelryItemDetailPanelSet_tb:Update-btnInnerEl")]
        public IWebElement btnUpdate;

        [FindsBy(How = How.Id, Using = "ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:Add-btnInnerEl")]
        public IWebElement btnAdd;

        public CCJewelryItemsPage_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
        }
        public override void WaitForLoad()
        {
            WaitUntilElementIsDisplayed(driver, By.XPath("//span[id$= 'ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:ttlBar']"));
        }

        public void AddItems(string Class, string Description, string value, string locatedwith)
        {
            btnAdd.Click();
            WaitUntilElementIsDisplayed(driver, By.XPath("//input[id$= 'ClaimPolicyJewelryItems:ClaimPolicyJewelryItemsScreen:PolicyJewelryItemDetailPanelSet:PolicyJewelryItemDetailDV:ClassCodeType-inputEl']"));

            Actions action = new Actions(driver);
            txtItemClass.Clear();
            txtItemClass.SendKeys(Class);

            txtItemdescription.Click();
            txtItemdescription.SendKeys(Description);

            txtItemValue.SendKeys(value);

            txtItemlocatedwith.Clear();
            if (locatedwith.ToLower().Trim().Equals("default"))
            {
                //txtReserveLinePicker.Click();
                IAction act = action.Click(txtLocatedwithPicker).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Build();
                act.Perform();
            }
            else
            {
                txtItemlocatedwith.SendKeys(locatedwith);
            }
            pause();

            btnUpdate.Click();
            pause();

        }

    }
}

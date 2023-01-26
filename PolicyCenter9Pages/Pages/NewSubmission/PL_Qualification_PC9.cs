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

namespace PolicyCenter9Pages.Pages.NewSubmission
{
    public class PL_Qualification_PC9 : Page
    {
        string radioCSS = "input[class='x-form-field x-form-radio x-form-radio-default x-form-cb x-form-cb-default']";
        string btnAddIns = "span[id$=':AdditionalNamedInsuredsDV:NamedInsuredInputSet:NamedInsuredsLV_tb:AddContactsButton-btnInnerEl']";
        string btnNext = "span[id$=':Next-btnInnerEl']";

        public PL_Qualification_PC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnNext);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void selectPLQualitificationsPC9(string professionalAthelete, string previousLoss, string convictedOfCrime)
        {
            IWebElement ProfessionalYes = driver.FindElement(By.XPath("//*[contains(text(),'Professional athlete or entertainer?')]/parent::*/following-sibling::*/descendant::*/child::label[text()='Yes']/preceding-sibling::input"));
            IWebElement ProfessionalNo = driver.FindElement(By.XPath("//*[contains(text(),'Professional athlete or entertainer?')]/parent::*/following-sibling::*/descendant::*/child::label[text()='No']/preceding-sibling::input"));
            IWebElement HadAnyPreviouslossYes = driver.FindElement(By.XPath("//*[contains(text(),'Had any previous loss, theft or damage to any jewelry?')]/parent::*/following-sibling::*/descendant::*/child::label[text()='Yes']/preceding-sibling::input"));
            IWebElement HadAnyPreviouslossNo = driver.FindElement(By.XPath("//*[contains(text(),'Had any previous loss, theft or damage to any jewelry?')]/parent::*/following-sibling::*/descendant::*/child::label[text()='No']/preceding-sibling::input"));
            IWebElement ConvictedYes = driver.FindElement(By.XPath("//*[contains(text(),'Convicted of a crime, other than a traffic violation?')]/parent::*/following-sibling::*/descendant::*/child::label[text()='Yes']/preceding-sibling::input"));
            IWebElement ConvictedNo = driver.FindElement(By.XPath("//*[contains(text(),'Convicted of a crime, other than a traffic violation?')]/parent::*/following-sibling::*/descendant::*/child::label[text()='No']/preceding-sibling::input"));


            switch (professionalAthelete.ToLower().Trim())
            {
                case "yes":
                    JavaScriptClick(ProfessionalYes);
                    break;
                case "no":
                    JavaScriptClick(ProfessionalNo);
                    break;
            }

            switch (previousLoss.ToLower().Trim())
            {
                case "yes":
                    JavaScriptClick(HadAnyPreviouslossYes);
                    break;
                case "no":
                    JavaScriptClick(HadAnyPreviouslossNo);
                    break;
            }

            switch (convictedOfCrime.ToLower().Trim())
            {
                case "yes":
                    JavaScriptClick(ConvictedYes);
                    break;
                case "no":
                    JavaScriptClick(ConvictedNo);
                    break;
            }





            //List<IWebElement> PageInputs = driver.FindElements(By.CssSelector(radioCSS)).ToList();
            //if (professionalAthelete.ToLower().Trim() == "yes")
            //    PageInputs[0].Click();
            //else
            //    PageInputs[1].Click();

            //if (previousLoss.ToLower().Trim() == "yes")
            //    PageInputs[2].Click();
            //else
            //    PageInputs[3].Click();

            //if (convictedOfCrime.ToLower().Trim() == "yes")
            //    PageInputs[4].Click();
            //else
            //    PageInputs[5].Click();

            UIAction(btnNext, string.Empty, "a");
            WaitUntilElementVisible(driver, By.CssSelector(btnAddIns));
        }

        public void SelectRadiooption()
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace QuoteAndApplyPages.Pages.JMPG
{
    public class MyAccount : Page
    {
        // Menu Bar
        string jmpgLogo = "//a[@name='zing-logo']";
        string mainSidebarMenuBtn = "//a[@id='mainSidebarMenuBtn']";
        string helpDeskIcon = "i[class$='uil uil-phone']";
        string helpDesk = "//span[text()='Helpdesk']";
        string profileIcon = "i[class$='uil uil-user']";
        string profile = "//span[text()='Profile']";
        string notificationsIcon = "i[class$='dripicons-bell noti-icon']";
        string notifications = "//span[text()='Notifications']";

        //Account Settings Heading
        string accountSettingsTitle = "//*[@id='account-setting-step']/div[1]/div[1]";
        string goBackButton = "//*[@id='account-setting-step']/div[1]//button";
        string leftAngleBracketIcon = "//*[@id='account-setting-step']/div[1]//i";

        //Account Settings Left Nav
        string personalDetails = "//div[text()='Personal Details']";
        string leftNavYourProfileLink = "//nav/a[text()='Your Profile']";
        string leftNavPersonalSettingsLink = "//a[text()='Profile Settings ']";
        string businessDetails = "//div[text()='Business Details']";
        string leftNavYourCompnay = "//nav/a[text()='Your Company']";

        //Account Profile Info Label
        string accountInfo = "//div[text()=' Account Information ']";
        string yourProfile = "//div[text()=' Your Profile ']";
        string firstName = "//label[text()='First Name']";
        string middleName = "//label[text()='Middle Name']";
        string lastName = "//label[text()='Last Name']";
        string phoneNumber = "//label[text()='Phone Number']";
        string emailAddress = "//label[text()='Email Address']";
        string otherPhone = "//label[text()='Other Phone']";
        string skillsAndServices = "//label[text()='Skills and Services']";
        string addressDetails = "//label[text()='Address Details']";
        string addressLine1 = "//label[text()='Address Line 1 ']";
        string addressLine2 = "//label[text()='Address Line 2']";
        string city = "//label[text()='City']";
        string country = "//label[text()='Country']";
        string stateProvince = "//label[text()='State/Province']";
        string postalCode = "//label[text()='Postal code']";

        //Account Profile Info
        string userFirstName = "//input[@id='firstname']";
        string userLastName = "//input[@id='lastname']";
        string userPhoneNumber = "//input[@id='userCellPhone']";
        string userEmailAddress = "//input[@id='userEmail']";
        string userSkillsAndServices = "//input[@id='skills']";
        string userAddressLine1 = "//input[@id='addressLine1']";
        string userCity = "//input[@id='city']";
        string userCountry = "//input[@id='countryInput']";
        string userStateProvince = "//input[@id='stateInput']";
        string userPostalCode = "//input[@id='zipcode']";

        public MyAccount(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            WaitForLoad();
        }

        public override void VerifyPage()
        {
            pause();
        }

        public override void WaitForLoad()
        {
            pause();
            pause();
            WaitUntilElementVisible(driver, By.Id("account-setting-step"));
        }

        public void verifyMyAccount()
        {
            Console.WriteLine("----JMPG My Account Page error message validation ----- started------");
            verifyMyAccountMenuBar();
            verifyAccountSettingSetup();
           // verifyFooter();
            Console.WriteLine("----JMPG My Account Page error message validation ----- ended------");
        }

        public void verifyMyAccountMenuBar()
        {
            Console.WriteLine("----JMPG My Account Page Menu Bar error message validation ----- started------");
            VerifyUIElementIsDisplayed(jmpgLogo);
            VerifyUIElementIsDisplayed(mainSidebarMenuBtn);
            VerifyUIElementIsDisplayed(notificationsIcon);
            VerifyUIElementIsDisplayed(profileIcon);
            VerifyUIElementIsDisplayed(helpDeskIcon);

            IWebElement labelHelpDesk = driver.FindElement(By.XPath(helpDesk));
            IWebElement labelProfile = driver.FindElement(By.XPath(profile));
            IWebElement labelNotifications = driver.FindElement(By.XPath(notifications));
            Assert.IsTrue(labelProfile.Text.Equals("PROFILE"), "Actual text content to verify Profile of Dashboard Menu Bar: " + labelProfile.Text);
            Assert.IsTrue(labelNotifications.Text.Equals("NOTIFICATIONS"), "Actual text content to verify Profile of My Account Menu Bar: " + labelNotifications.Text);
            Assert.IsTrue(labelHelpDesk.Text.Equals("HELPDESK"), "Actual text content to verify Help Desk of My Account Menu Bar: " + labelHelpDesk.Text);
            Console.WriteLine("----JMPG My Account Page Menu Bar error message validation ----- ended------");

        }

        public void verifyFooter()
        {
            CommonPageElements footer = new CommonPageElements(driver);
            footer.verifLoginAndMyAccountyFooter();
        }

        public void verifyAccountSettingSetup()
        {
            verifyAccountSettingHeading();
            verifyLeftNavOfAccountSetting();
            verifyMyAccountProfilePanel();
        }

        public void verifyAccountSettingHeading()
        {
            VerifyUIElementIsDisplayed(leftAngleBracketIcon);
            IWebElement titleAccountSettings = driver.FindElement(By.XPath(accountSettingsTitle));
            IWebElement buttonGoBack = driver.FindElement(By.XPath(goBackButton));
            Assert.IsTrue(titleAccountSettings.Text.Equals("Account Settings"), "Actual text content to verify Account Settings Title of MyAccount Page: " + titleAccountSettings.Text);
            Assert.IsTrue(buttonGoBack.Text.Equals("GO BACK"), "Actual text content to verify Go Back Button of MyAccount Page: " + buttonGoBack.Text);
        }

        public void verifyLeftNavOfAccountSetting()
        {
            VerifyUIElementIsDisplayed(personalDetails);
            VerifyUIElementIsDisplayed(leftNavYourProfileLink);
            VerifyUIElementIsDisplayed(leftNavPersonalSettingsLink);
            VerifyUIElementIsDisplayed(businessDetails);
            VerifyUIElementIsDisplayed(leftNavYourCompnay);
        }

        public void verifyMyAccountProfilePanel()
        {
            verifyProfileLabelOfProfilePanel();
            verifyProfileInfoOfProfilePanel();
        }

        public void verifyProfileLabelOfProfilePanel()
        {
            Console.WriteLine("----Verify Profile Label Of Profile Panel ----- started------");
            VerifyUIElementIsDisplayed(accountInfo);
            VerifyUIElementIsDisplayed(yourProfile);
            VerifyUIElementIsDisplayed(firstName);
            VerifyUIElementIsDisplayed(middleName);
            VerifyUIElementIsDisplayed(lastName);
            VerifyUIElementIsDisplayed(phoneNumber);
            VerifyUIElementIsDisplayed(emailAddress);
            VerifyUIElementIsDisplayed(otherPhone);
            VerifyUIElementIsDisplayed(skillsAndServices);
            VerifyUIElementIsDisplayed(addressDetails);
            VerifyUIElementIsDisplayed(addressLine1);
            VerifyUIElementIsDisplayed(addressLine2);
            VerifyUIElementIsDisplayed(city);
            VerifyUIElementIsDisplayed(country);
            VerifyUIElementIsDisplayed(stateProvince);
            VerifyUIElementIsDisplayed(postalCode);
            
            Console.WriteLine("----Verify Profile Label Of Profile Panel ----- ended------");
        }

        public void verifyProfileInfoOfProfilePanel()
        {
            IWebElement inputFirstName = driver.FindElement(By.XPath(userFirstName));
            IWebElement inputLastName = driver.FindElement(By.XPath(userLastName));
            IWebElement inputPhoneNumber = driver.FindElement(By.XPath(userPhoneNumber));
            IWebElement inputEmailAddress = driver.FindElement(By.XPath(userEmailAddress));
            IWebElement inputSkills = driver.FindElement(By.XPath(userSkillsAndServices));
            IWebElement inputAddressLine1 = driver.FindElement(By.XPath(userAddressLine1));
            IWebElement inputCity = driver.FindElement(By.XPath(userCity));
            IWebElement inputCountry = driver.FindElement(By.XPath(userCountry));
            IWebElement inputStateProvince = driver.FindElement(By.XPath(userStateProvince));
            IWebElement inputPostalCode = driver.FindElement(By.XPath(userPostalCode));

            Assert.IsTrue(inputFirstName.GetAttribute("value").Equals("Ryan"), "Actual text content to verify First Name Value of MyAccount Information Panel: " + inputFirstName.GetAttribute("value"));
            Assert.IsTrue(inputLastName.GetAttribute("value").Equals("Rose"), "Actual text content to verify Last Name Value of MyAccount Information Panel: " + inputLastName.GetAttribute("value"));
            Assert.IsTrue(inputPhoneNumber.GetAttribute("value").Equals("+1 (555) 555-5555"), "Actual text content to verify Phone Number Value of MyAccount Information Panel: " + inputPhoneNumber.GetAttribute("value"));
            Assert.IsTrue(inputEmailAddress.GetAttribute("value").Equals("jmtestpartner+803@gmail.com"), "Actual text content to verify Email Address Value of MyAccount Information Panel: " + inputEmailAddress.GetAttribute("value"));
            Assert.IsTrue(inputSkills.GetAttribute("placeholder").Equals("No Skills and Services defined"), "Actual text content to verify Skills Value of MyAccount Information Panel: " + inputSkills.GetAttribute("placeholder"));
            Assert.IsTrue(inputAddressLine1.GetAttribute("value").Equals("101 W 103rd St"), "Actual text content to verify Address Line 1 Value of MyAccount Information Panel: " + inputAddressLine1.GetAttribute("value"));
            Assert.IsTrue(inputCity.GetAttribute("value").Equals("Indianapolis"), "Actual text content to verify City Value of MyAccount Information Panel: " + inputCity.GetAttribute("value"));
            Assert.IsTrue(inputCountry.GetAttribute("value").Equals("USA"), "Actual text content to verify Country Value of MyAccount Information Panel: " + inputCountry.GetAttribute("value"));
            Assert.IsTrue(inputStateProvince.GetAttribute("value").Equals("Indiana"), "Actual text content to verify State Province Value of MyAccount Information Panel: " + inputStateProvince.GetAttribute("value"));
            Assert.IsTrue(inputPostalCode.GetAttribute("value").Equals("46290"), "Actual text content to verify Postal Code Value of MyAccount Information Panel: " + inputPostalCode.GetAttribute("value"));
        }

        public void clickGoBackButton()
        {
            IWebElement buttonGoBack = driver.FindElement(By.XPath(goBackButton));
            buttonGoBack.Click();
        }

    }
}

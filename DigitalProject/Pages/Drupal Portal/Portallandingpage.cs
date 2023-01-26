using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace DigitalProject.Pages.Drupal_Portal
{
   public class Portallandingpage : Page
    {
        string linkWorkBenchCSS = "a[id$='toolbar-item-workbench']";

        string linktoolbarWorkBenchCSS = "a[id$='toolbar-link-workbench-content']";
        string linktoolbarcreatecontentCSS = "a[id$='toolbar-link-workbench-create_content']";
        string linktoolbarmanagecontentCSS = "//a[@class='toolbar-icon toolbar-icon-system-admin-content']";
        string linktoolbarmyeditesCSS = "a[id$='toolbar-link-workbench-my_edited']";
        string linktoolbarallcontentCSS = "a[id$='toolbar-link-workbench-all_content']";
        string linktoolbarconfigureCSS = "a[id$='toolbar-link-workbench-admin']";
        string linktaboptionsviewXpath = "//a[text()='View']";
        string linktaboptionslayoutXpath = "//a[text()='Layout']";
        string selChangetoStateCSS = "select[id$='edit-moderation-state-0-state']";
        string linkAddBlockXpath = "//a[.='Add Block in section 1, Content region']";
        string lblchhoseblockXpath = "//span[@class='ui-dialog-title'][contains(.,'Choose a block')]";
        string linkCrerateCustomblockXpath = "//a[.='Create custom block']";
        string lblAddNewlineblockXpath = "//span[@class='ui-dialog-title'][contains(.,'Add a new Inline Block')]";
        string linkAddblockfeatureXpath = "//div[@id='drupal-off-canvas']//a[text()='Feature']";
        string txtConfigureblockTitleXpath = "//input[@name='settings[label]']";
        string lblConfigureblockXpath = "//span[text()='Configure block']";
        string txtConfigureblockHeadlineXpath = "//input[@name='settings[block_form][field_feature][0][subform][field_headline][0][value]']";
        string txtConfigureblocktextXpath = "//body[@class='cke_editable cke_editable_themed cke_contents_ltr cke_show_borders']";
        string btnConfigureblockAddBlockXpath = "//input[@value='Add Block']";
        string btnConfigureblockupdateBlockXpath = "//input[@value='Update']";
        string txtPlaceholderTitleXpath = "//div[@class ='title-bar content-lg spacing clearfix']//h2";
        string txtPlaceholderHeadlineXpath = "//div[@class ='feature-row background-color--white']//h2";
        string txtPlaceholderTextXpath = "//div[@class ='formatted_text spacing-4x']//p";
        string lblunsavedChangesXpath = "//div[@class='messages messages--warning']";
        string btnSaveLayoutXpath = "//input[@id='edit-submit']";
        string linkHeaderManageXpath = "//a[@id='toolbar-item-administration']";
        string linkHeaderShortcutsXpath = "//a[@id='toolbar-item-shortcuts']";
        string linkHeaderSearchXpath = "//a[@id='toolbar-item-administration-search-tray']";

        public Portallandingpage(IWebDriver driver) : base(driver)
		{
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(linkWorkBenchCSS);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.CssSelector(linkWorkBenchCSS));
            IsElementPresent(driver, By.Id(linkWorkBenchCSS));
        }

        public void AddBloack(string option)
        {
            WaitUntilElementVisible(driver, By.XPath(lblchhoseblockXpath));
            UIActionExt(By.XPath(linkCrerateCustomblockXpath), "click");
            WaitUntilElementVisible(driver, By.XPath(lblAddNewlineblockXpath));
            switch (option.ToLower().Trim())
            {
                case "feature":
                    UIActionExt(By.XPath(linkAddblockfeatureXpath), "click");
                    break;
            }
           
            
        }

        public void verifyTitleCreatd()
        {
            List<IWebElement> successobj = driver.FindElements(By.XPath("//div[@class='messages messages--status'][contains(.,'has been created.')]")).ToList();
            if(successobj.Count >0)
            {
                Console.WriteLine("Title updated successfully");
            }
            else
            {
                Assert.Fail("Title not updated successfully");
               
            }

        }

        public void ActionOnMarkatingPageContent(string option)
        {
            switch (option.ToLower().Trim())
            {
                case "add block":
                    UIActionExt(By.XPath(linkAddBlockXpath), "click");
                    break;
            }
        }

        public void ClickOnToolHeaderoptions(string options)
        {
            switch (options.ToLower().Trim())
            {
                case "manage":
                    UIActionExt(By.XPath(linkHeaderManageXpath), "click");
                    break;
                case "shortcuts":
                    UIActionExt(By.XPath(linkHeaderShortcutsXpath), "click");
                    break;
                case "search":
                    UIActionExt(By.XPath(linkHeaderSearchXpath), "click");
                    break;
              
            }
        }
        public void ClickOnTaboptions(string options)
        {
            switch (options.ToLower().Trim())
            {
                case "layout":
                    UIActionExt(By.XPath(linktaboptionslayoutXpath), "click");
                    break;
                case "view":
                    UIActionExt(By.XPath(linktaboptionsviewXpath), "click");
                    break;
            }

        }
        public void verifyLayoutheader()
        {
            List<IWebElement> successobj = driver.FindElements(By.XPath("//p[contains(.,'This layout builder tool allows you to configure the layout of the main content')]")).ToList();
            if (successobj.Count > 0)
            {
                Console.WriteLine("Header text updated successfully");
            }
            else
            {
                Assert.Fail("Header text not updated successfully");

            }
        }

        public void SelectChangetoState(string option)
        {
            //UIActionExt(By.CssSelector(selChangetoStateCSS), "listbox", option);
            SelectByText(driver.FindElement(By.CssSelector(selChangetoStateCSS)), option);
        }
        public void ClickOnToolBaroptions(string options)
        {
            switch (options.ToLower().Trim())
            {
                case "workbench":
                    UIActionExt(By.CssSelector(linktoolbarWorkBenchCSS), "click");
                    break;
                    
                 case "managecontents":
                    UIActionExt(By.XPath(linktoolbarmanagecontentCSS), "click");
                    break;
                case "contents":
                    UIActionExt(By.CssSelector(linktoolbarcreatecontentCSS), "click");
                    break;
                case "edits":
                    UIActionExt(By.CssSelector(linktoolbarmyeditesCSS), "click");
                    break;
                case "recentcontents":
                    UIActionExt(By.CssSelector(linktoolbarallcontentCSS), "click");
                    break;
                case "configure":
                    UIActionExt(By.CssSelector(linktoolbarconfigureCSS), "click");
                    break;
                default:
                
                    break;

            }
        }

        public void UpdateConfigureBlock(string title, string headline, string text)
        {
            WaitUntilElementVisible(driver, By.XPath(lblConfigureblockXpath));
            UIActionExt(By.XPath(txtConfigureblockTitleXpath), "listbox", title);
            UIActionExt(By.XPath(txtConfigureblockHeadlineXpath), "listbox", headline);
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//div[@id='cke_1_contents']//iframe")));
            UIActionExt(By.XPath(txtConfigureblocktextXpath), "listbox", text);
            driver.SwitchTo().DefaultContent();
            pause();
            pause();
           
        }

        public void clickSavebutton()
        {
            //UIActionExt(By.XPath(btnConfigureblockAddBlockXpath), "click", "", 0);

            IList<IWebElement> objcount = driver.FindElements(By.XPath(btnConfigureblockAddBlockXpath)).ToList();
            Console.WriteLine("object count is " + objcount.Count);
            objcount[0].Click();
        }

        public void clickUpdatebutton()
        {
            //UIActionExt(By.XPath(btnConfigureblockupdateBlockXpath), "click", "", 0);
            IList<IWebElement> objcount = driver.FindElements(By.XPath(btnConfigureblockupdateBlockXpath)).ToList();
            Console.WriteLine("object count is " + objcount.Count);
            objcount[0].Click();
        }
    
        public void VerifyTitletext(string title)
        {
            WaitUntilElementVisible(driver, By.XPath(lblunsavedChangesXpath));
            string actualtext = driver.FindElement(By.XPath(txtPlaceholderTitleXpath)).Text;
            if (string.Compare(actualtext.ToLower(), title.ToLower()) == 0)
            {
                Console.WriteLine("Expected title and actual title matches");
            }
            else
            {
                Console.WriteLine("Expected title and actual title do not matches");
                Assert.Fail("Actual text is " + actualtext + " Expected text is " + title);
            }
        }
        public void VerifyHeadlinetext(string headline)
        {
            WaitUntilElementVisible(driver, By.XPath(lblunsavedChangesXpath));
            string actualtext = driver.FindElement(By.XPath(txtPlaceholderHeadlineXpath)).Text;
            if (string.Compare(actualtext.ToLower(), headline.ToLower()) == 0)
            {
                Console.WriteLine("Expected headline and actual headline matches");
            }
            else
            {
                Console.WriteLine("Expected headline and actual headline do not matches");
                Assert.Fail("Actual text is " + actualtext + " Expected text is " + headline);
            }
        }
        public void VerifyTexttext(string text)
        {
            WaitUntilElementVisible(driver, By.XPath(lblunsavedChangesXpath));
            string actualtext = driver.FindElement(By.XPath(txtPlaceholderTextXpath)).Text;
            if (string.Compare(actualtext.ToLower(), text.ToLower()) == 0)
            {
                Console.WriteLine("Expected text and actual text matches");
            }
            else
            {
                Console.WriteLine("Expected text and actual text do not matches");
                Assert.Fail("Actual text is " + actualtext + " Expected text is " + text);
            }
        }

        public void SaveLayout()
        {
            WaitUntilElementVisible(driver, By.XPath(btnSaveLayoutXpath));
            UIActionExt(By.XPath(btnSaveLayoutXpath), "click");
            pause();
            
        }

        public void ClickonEditPencilButtonForLayoutBuilder()
        {

            
            string lnkAddBlock = "//a[text()='Add Section ']";
            ScrollDownTillElement(driver, driver.FindElement(By.XPath(lnkAddBlock)));
            UIActionExt(By.XPath("//button[text()='Open Layout Builder Bug Test Title configuration options']"), "ispresent");
            MouseOver(driver,driver.FindElement(By.XPath("//button[text()='Open Layout Builder Bug Test Title configuration options']")));
            UIActionExt(By.XPath("//button[text()='Open Layout Builder Bug Test Title configuration options']"),"click");
             UIActionExt(By.XPath("//a[text()='Configure']"), "ispresent");
            UIActionExt(By.XPath("//a[text()='Configure']"),"click","",(driver.FindElements(By.XPath("//a[text()='Configure']")).ToList().Count-1));
            
        }
    }
}

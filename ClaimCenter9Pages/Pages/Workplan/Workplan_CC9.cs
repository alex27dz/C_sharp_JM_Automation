using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ClaimCenter9.Pages.Workplan
{
    public class Workplan_CC9 : Page
    {
        string btnEdit = "span[id$=':ClaimStatusNotificationDV_tb:Edit-btnInnerEl']";
        string btnComplete = "span[id='ClaimWorkplan:ClaimWorkplanScreen:ClaimWorkplan_CompleteButton-btnInnerEl']";
        //
        public Workplan_CC9(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }
        public override void VerifyPage()
        {

        }
        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.CssSelector(btnEdit));
        }
        public void selectAllActivities()
        {
            List<IWebElement> selectAll = driver.FindElements(By.XPath("//div[@class='x-grid-checkcolumn']")).ToList();
            Console.WriteLine(" Count is " + selectAll.Count());
            if (selectAll.Count > 0)
                selectAll[0].Click();
        }
        public void ClickCompleteButton()
        {
            UIAction(btnComplete, string.Empty, "a");
        }
        public void verifyActivity(Table table)
        {

            for (int i = 0; i <= table.RowCount - 1; i++)
            {
                List<IWebElement> ISubject = driver.FindElements(By.XPath("//a[contains(text(),'" + table.Rows[0]["ActivitySubject"] + "')]")).ToList();
                if (ISubject.Count > 0)
                {
                    Console.WriteLine("Activity Subject: " + ISubject[0].Text + " - found");
                    ISubject[0].Click();
                    pause();
                    List<IWebElement> IButton = driver.FindElements(By.XPath("//span[contains(text(),'" + table.Rows[0]["VerifyButton"] + "')]")).ToList();
                    if (IButton.Count > 0)
                    {
                        Console.WriteLine("Activity Button: " + IButton[0].Text + " - found");
                    }
                }
                IWebElement ICancelButton = driver.FindElement(By.XPath("//span[@id='ApprovalDetailWorksheet:ApprovalDetailScreen:ApprovalDetailWorksheet_CancelButton-btnInnerEl']"));
                ICancelButton.Click();
            }
        }
    }

}

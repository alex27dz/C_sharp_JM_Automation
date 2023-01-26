using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace PolicyCenterPages.Pages.NewSubmission
{
    public class CL_Forms : Page
    {
        string btnNext = "a[id$='SubmissionWizard:Next']";
        string tblForms = "SubmissionWizard:FormsScreen:FormsDV:FormsLV";
        //string bindAndIssue = "a[id$=':BindAndIssue']";
        public CL_Forms(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(btnNext);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnNext));
        }

        public void ClickNextOnFormsPage()
        {
            UIAction(btnNext, string.Empty, "a");
        }
        public void VerifyFormsList()
        {
            System.Threading.Thread.Sleep(3000);
            WaitFor(driver.FindElement(By.Id(tblForms)));

            var drMainTable = driver.FindElement(By.Id(tblForms));
            List<IWebElement> lsGetTrElements = new List<IWebElement>(drMainTable.FindElements(By.TagName("tr")));

            if (lsGetTrElements.Count() <= 1)
            {
                Assert.Fail("Forms not available");
            }
            else
            {
                Console.WriteLine("----------------Forms List:-----------------");
                for (int i = 1; i < lsGetTrElements.Count(); i++)
                {
                    Console.WriteLine(i + "-----" + lsGetTrElements[i].Text);
                }
            }

        }
    }
}

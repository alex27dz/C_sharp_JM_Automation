using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Data;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCommonCore;

namespace PolicyCenterPages.Pages.NewSubmission
{
    public class PL_Quote : Page
    {
        string issueNowDownArrow = "a[id$=':BindOptions_arrow']";

        string bindAndIssue = "a[id$=':BindAndIssue']";

        string uwIssuesMessage = "div[id='UWBlockProgressIssuesPopup']";

        string btnDetails = "a[id$=':DetailsButton']";

        string btnNext = "a[id$='SubmissionWizard:Next']";

        public PL_Quote(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();

            VerifyUIElementIsDisplayed(bindAndIssue);

        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(bindAndIssue));
        }


        public void IssuePolicy()
        {
            bool isPolicySuccessful = false;

            Actions action = new Actions(driver);

            pause();

            UIAction(issueNowDownArrow, string.Empty, "a");

            pause();

            UIAction(bindAndIssue, string.Empty, "a");

            pause();


            driver.SwitchTo().Alert().Accept();
            //System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            //  System.Windows.Forms.SendKeys("{ENTER}");
            // driver.SwitchTo().ActiveElement().Click();
            //  action.SendKeys(Keys.Enter).Build().Perform();

            pause();

            bool uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesMessage));

            if (uwIssues)
            {

                IWebElement btnUSIssues = driver.FindElement(By.CssSelector(btnDetails));

                WaitForEnabled(btnUSIssues);

                UIAction(btnDetails, string.Empty, "a");

                List<IWebElement> PageInputs = driver.FindElements(By.CssSelector("span[class='bigButton_link']")).ToList();
                Console.WriteLine("Button Count is " + PageInputs.Count());
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "approve")
                        PageInputs[i].Click();

                    break;
                }

                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();

                    break;
                }

                UIAction(issueNowDownArrow, string.Empty, "a");

                pause();

                UIAction(bindAndIssue, string.Empty, "a");

                pause();

                // System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                // action.SendKeys(Keys.Enter).Build().Perform();
                // driver.SwitchTo().ActiveElement().Click();
                driver.SwitchTo().Alert().Accept();
                pause();

                System.Threading.Thread.Sleep(12000);

                IsElementPresent(driver, By.CssSelector("a[class='underlined']"));

                for (int j = 0; j < 4; j++)
                    pause();


                PageInputs = driver.FindElements(By.CssSelector("a[class='underlined']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    string Temp = "view your policy (#";

                    if (PageInputs[i].Text.ToLower().Trim().Contains(Temp))
                    {
                        Console.WriteLine(i + "=" + PageInputs[i].Text);

                        pause();

                        string policyNumber = PageInputs[i].Text.Substring(Temp.Length, 9);

                        if (policyNumber != null)
                            isPolicySuccessful = true;
                        Console.WriteLine("policy number" + policyNumber);

                        //  ScenarioContext.Current.Add("PL_Policy" , policyNumber);

                        ScenarioContext.Current["POLICY"] = policyNumber;

                        //   File.AppendAllText(@"c:\tmp\data.txt", ScenarioContext.Current["ACCOUNT"].ToString()+"/"+policyNumber + Environment.NewLine);

                        break;
                    }
                }
            }

            if (!isPolicySuccessful)
                Assert.Fail("Policy is not Created.");
        }




        public void PLIssuePolicy()
        {
            List<IWebElement> PageInputs;
            bool isPolicySuccessful = false;

            Actions action = new Actions(driver);

            pause();

            UIAction(issueNowDownArrow, string.Empty, "a");

            pause();

            UIAction(bindAndIssue, string.Empty, "a");

            pause();


            driver.SwitchTo().Alert().Accept();
            //System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            //  System.Windows.Forms.SendKeys("{ENTER}");
            // driver.SwitchTo().ActiveElement().Click();
            //  action.SendKeys(Keys.Enter).Build().Perform();

            pause();

            bool uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesMessage));

            do
            {

                UIAction(btnDetails, string.Empty, "a");

                PageInputs = driver.FindElements(By.CssSelector("span[class='bigButton_link']")).ToList();
                Console.WriteLine("Button Count is " + PageInputs.Count());
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "approve")
                        PageInputs[i].Click();

                    break;
                }

                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();

                    break;
                }

                UIAction(issueNowDownArrow, string.Empty, "a");

                pause();

                UIAction(bindAndIssue, string.Empty, "a");

                pause();

                // System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                // action.SendKeys(Keys.Enter).Build().Perform();
                // driver.SwitchTo().ActiveElement().Click();
                driver.SwitchTo().Alert().Accept();
                pause();
                uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesMessage));
            } while ((uwIssues));

                   System.Threading.Thread.Sleep(12000);

                IsElementPresent(driver, By.CssSelector("a[class='underlined']"));

                for (int j = 0; j < 4; j++)
                    pause();


                PageInputs = driver.FindElements(By.CssSelector("a[class='underlined']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    string Temp = "view your policy (#";

                    if (PageInputs[i].Text.ToLower().Trim().Contains(Temp))
                    {
                        Console.WriteLine(i + "=" + PageInputs[i].Text);

                        pause();

                    string policyNumber = PageInputs[i].Text.Substring(Temp.Length, 10);
                    policyNumber = policyNumber.Replace(")", "");
                    policyNumber = policyNumber.Trim();

                    if (policyNumber != null)
                            isPolicySuccessful = true;
                        Console.WriteLine("policy number" + policyNumber);

                        //  ScenarioContext.Current.Add("PL_Policy" , policyNumber);

                        ScenarioContext.Current["POLICY"] = policyNumber;

                        //   File.AppendAllText(@"c:\tmp\data.txt", ScenarioContext.Current["ACCOUNT"].ToString()+"/"+policyNumber + Environment.NewLine);

                        break;
                    }
                }
            

            if (!isPolicySuccessful)
                Assert.Fail("Policy is not Created.");
        }
        public void ClickQuoteNextButton()
        {
            UIAction(btnNext, string.Empty, "a");
        }
    }
}

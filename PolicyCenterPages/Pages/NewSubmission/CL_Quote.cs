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
    public class CL_Quote : Page
    {
        string issueNowDownArrow = "a[id$=':BindOptions_arrow']";

        string bindAndIssue = "a[id$=':BindAndIssue']";

        string uwIssuesMessage = "div[id$='UWBlockProgressIssuesPopup:IssuesScreen:PreQuoteIssueTitle']";

        string uwIssuesPresent = "span[id$='ApproveDV:0:ShortDescriptionAndSize']";

        string btnDetails = "a[id$=':DetailsButton']";

        bool isPolicySuccessful = false;

        string btnNext = "a[id$=':Next']";

        //string btnNext = "a[id$='SubmissionWizard:Next']";

        public CL_Quote(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
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


        public void SpecialApproveBlockingBindissues()
        {
            bool isSpecialApproveFlg;
            List<IWebElement> PageInputs;
            do
            {
                List<IWebElement> reservetableObj2;
                reservetableObj2 = driver.FindElements(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:RiskEvaluationPanelSet:1")).ToList();
                var rows2 = reservetableObj2[0].FindElements(By.TagName("tr"));
                var data = rows2[1].FindElements(By.TagName("td"));
                var Celldata = data[4].FindElement(By.Id("SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:RiskEvaluationPanelSet:1:UWIssueRowSet:SpecialApprove_container"));
                Celldata.Click();
                pause();
                driver.SwitchTo().Alert().Accept();
                pause();
                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();

                    break;
                }
                pause();
                isSpecialApproveFlg = IsElementPresent(driver, By.CssSelector("span[id='SubmissionWizard:Job_RiskAnalysisScreen:RiskAnalysisCV:RiskEvaluationPanelSet:1:UWIssueRowSet:SpecialApprove_container']"));

            } while (isSpecialApproveFlg);
        }

    public void IssuePolicy()
        {
            List<IWebElement> PageInputs;

            Actions action = new Actions(driver);

            System.Threading.Thread.Sleep(5000);

            bool isPolicySuccessful = false;

            pause();

            UIAction(issueNowDownArrow, string.Empty, "a");

            pause();

            UIAction(bindAndIssue, string.Empty, "a");

            pause();

            try
            {
                driver.SwitchTo().Alert().Accept();
                //System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                // action.SendKeys(Keys.Enter).Build().Perform();
                // driver.SwitchTo().ActiveElement().Click();

                WaitForPageLoad(driver);

                System.Threading.Thread.Sleep(3000);

                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            pause();
            pause();

            bool uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesPresent));

            Console.WriteLine("UWISsues =====" + uwIssues);
            if (uwIssues)
            {

                IWebElement btnUSIssues = driver.FindElement(By.CssSelector(btnDetails));

                WaitForEnabled(btnUSIssues);

                Console.WriteLine("UW issues present");

                UIAction(btnDetails, string.Empty, "a");

                pause();

                PageInputs = driver.FindElements(By.CssSelector("span[id$=':SpecialApprove_link']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    Console.WriteLine("TExt" + PageInputs[i].Text);

                    if (PageInputs[i].Text.ToLower().Trim() == "special approve")
                    {
                        Console.WriteLine("Found");
                        PageInputs[i].Click();

                        pause();
                    }


                    break;
                }

                pause();

                driver.SwitchTo().Alert().Accept();
                //   System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                //  action.SendKeys(Keys.Enter).Build().Perform();
                // driver.SwitchTo().ActiveElement().Click();
                pause();

                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();

                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();

                    break;
                }

                pause();

                UIAction(issueNowDownArrow, string.Empty, "a");



                pause();

                pause();

                Console.WriteLine("Issue down arrow");

                UIAction(bindAndIssue, string.Empty, "a");

                Console.WriteLine("Bind and ISsue down arrow");

                pause();

                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                //action.SendKeys(Keys.Enter).Build().Perform();
                driver.SwitchTo().ActiveElement().Click();

                pause();

                //    System.Threading.Thread.Sleep(5000);

                isPolicySuccessful = IsElementPresent(driver, By.CssSelector("div[id='JobComplete:JobCompleteScreen:ttlBar']"));

                // if( !isPolicySuccessful)
                do
                {
                    pause();

                    isPolicySuccessful = IsElementPresent(driver, By.CssSelector("div[id='JobComplete:JobCompleteScreen:ttlBar']"));



                } while (isPolicySuccessful);

                //Console.WriteLine("Out of loop");

                //System.Threading.Thread.Sleep(5000);


                //PageInputs = driver.FindElements(By.CssSelector("a[class='underlined']")).ToList();

                //for (int i = 0; i < PageInputs.Count; i++)
                //{
                //    string Temp = "view your policy (#";

                //    if (PageInputs[i].Text.ToLower().Trim().Contains(Temp))
                //    {
                //        Console.WriteLine(i + "=" + PageInputs[i].Text);

                //        pause();

                //        string policyNumber = PageInputs[i].Text.Substring(Temp.Length, 9);

                //        if (policyNumber != null)
                //            isPolicySuccessful = true;
                //        Console.WriteLine("policy number" + policyNumber);

                //        ScenarioContext.Current["POLICY"] = policyNumber;

                //        // File.AppendAllText(@"c:\tmp\data.txt", ScenarioContext.Current["ACCOUNT"].ToString()+"/"+policyNumber + Environment.NewLine);

                //        break;
                //    }
                //}
            }

            Console.WriteLine("Out of loop");

           // System.Threading.Thread.Sleep(120000);

            bool Policy_Quote_Status = false;
            int count = 0;
            do
            {
                Console.WriteLine("inside loop");
                try
                {
                    PageInputs = driver.FindElements(By.CssSelector("a[class='underlined']")).ToList();
                    Console.WriteLine("Page total count is " + PageInputs.Count);
                    Console.WriteLine("Details are : " + PageInputs[0].Text);
                    pause();
                    pause();

                    // 
                    //TEst

                    for (int i = 0; i < PageInputs.Count; i++)
                    {
                        System.Threading.Thread.Sleep(7000);
                        string Temp = "view your policy (#";

                        if (PageInputs[i].Text.ToLower().Trim().Contains(Temp))
                        {
                            Console.WriteLine(i + "=" + PageInputs[i].Text);
                            Console.WriteLine(i + PageInputs[i].Text);

                            pause();

                            string policyNumber = PageInputs[i].Text.Substring(Temp.Length, 9);

                            if (policyNumber != null)
                                isPolicySuccessful = true;
                            Console.WriteLine("policy number" + policyNumber);

                            ScenarioContext.Current["POLICY"] = policyNumber;

                            // File.AppendAllText(@"c:\tmp\data.txt", ScenarioContext.Current["ACCOUNT"].ToString()+"/"+policyNumber + Environment.NewLine);

                            break;
                        }
                    }
                    if (PageInputs.Count > 1)
                        Policy_Quote_Status = true;

                }
                catch (Exception e)
                {

                }
                count = count + 1;
                // if (count > 6)
                if (count > 30)
                    Policy_Quote_Status = true;
                Console.WriteLine("policy status loop counter" + count);


            } while (Policy_Quote_Status == false);


            if (!isPolicySuccessful)
                Assert.Fail("Policy is not Created.");
        }
        public void ClickQuoteNextButton()
        {
            UIAction(btnNext, string.Empty, "a");
        }


        public void IssuePolicy_Blankets()
        {
            List<IWebElement> PageInputs;
            Actions action = new Actions(driver);
            System.Threading.Thread.Sleep(5000);
            bool isPolicySuccessful = false;
            pause();
            UIAction(issueNowDownArrow, string.Empty, "a");
            pause();
            UIAction(bindAndIssue, string.Empty, "a");
            pause();
            try
            {
                driver.SwitchTo().Alert().Accept();
                WaitForPageLoad(driver);
                System.Threading.Thread.Sleep(3000);
                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            pause();
            pause();
            bool uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesPresent));
            Console.WriteLine("UWISsues =====" + uwIssues);
            if (uwIssues)
            {
                IWebElement btnUSIssues = driver.FindElement(By.CssSelector(btnDetails));
                WaitForEnabled(btnUSIssues);
                Console.WriteLine("UW issues present");
                UIAction(btnDetails, string.Empty, "a");
                pause();
                PageInputs = driver.FindElements(By.CssSelector("span[id$=':SpecialApprove_link']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    Console.WriteLine("TExt" + PageInputs[i].Text);

                    if (PageInputs[i].Text.ToLower().Trim() == "special approve")
                    {
                        Console.WriteLine("Found");
                        PageInputs[i].Click();

                        pause();
                    }
                    break;
                }
                pause();
                driver.SwitchTo().Alert().Accept();
                pause();
                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();
                    break;
                }
                pause();
                //--------------
                pause();
                pause();
                PageInputs = driver.FindElements(By.CssSelector("span[id$=':SpecialApprove_link']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    Console.WriteLine("TExt" + PageInputs[i].Text);

                    if (PageInputs[i].Text.ToLower().Trim() == "special approve")
                    {
                        Console.WriteLine("Found");
                        PageInputs[i].Click();

                        pause();
                    }
                    break;
                }
                pause();
                driver.SwitchTo().Alert().Accept();
                pause();
                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();
                    break;
                }
                pause();
                //--------------
                UIAction(issueNowDownArrow, string.Empty, "a");
                pause();
                pause();
                Console.WriteLine("Issue down arrow");
                UIAction(bindAndIssue, string.Empty, "a");
                Console.WriteLine("Bind and ISsue down arrow");
                pause();
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                driver.SwitchTo().ActiveElement().Click();
                pause();
                //isPolicySuccessful = IsElementPresent(driver, By.CssSelector("div[id='JobComplete:JobCompleteScreen:ttlBar']"));
                //do
                //{
                //    pause();

                //    isPolicySuccessful = IsElementPresent(driver, By.CssSelector("div[id='JobComplete:JobCompleteScreen:ttlBar']"));
                //} while (isPolicySuccessful);
            }
            Console.WriteLine("Out of loop");
            bool Policy_Quote_Status = false;
            int count = 0;
            do
            {
                Console.WriteLine("inside loop");
                try
                {
                    PageInputs = driver.FindElements(By.CssSelector("a[class='underlined']")).ToList();
                    Console.WriteLine("Page total count is " + PageInputs.Count);
                    Console.WriteLine("Details are : " + PageInputs[0].Text);
                    pause();
                    pause();
                    for (int i = 0; i < PageInputs.Count; i++)
                    {
                        System.Threading.Thread.Sleep(7000);
                        string Temp = "view your policy (#";
                        if (PageInputs[i].Text.ToLower().Trim().Contains(Temp))
                        {
                            Console.WriteLine(i + "=" + PageInputs[i].Text);
                            Console.WriteLine(i + PageInputs[i].Text);
                            pause();
                            string policyNumber = PageInputs[i].Text.Substring(Temp.Length, 9);
                            if (policyNumber != null)
                                isPolicySuccessful = true;
                            Console.WriteLine("policy number" + policyNumber);
                            ScenarioContext.Current["POLICY"] = policyNumber;
                            break;
                        }
                    }
                    if (PageInputs.Count > 1)
                        Policy_Quote_Status = true;
                }
                catch (Exception e)
                {

                }
                count = count + 1;
                if (count > 30)
                    Policy_Quote_Status = true;
                Console.WriteLine("policy status loop counter" + count);
            } while (Policy_Quote_Status == false);
            if (!isPolicySuccessful)
                Assert.Fail("Policy is not Created.");
        }

        public void IssueBOPPolicy()
        {
            List<IWebElement> PageInputs;
            Actions action = new Actions(driver);
            System.Threading.Thread.Sleep(5000);
            bool isPolicySuccessful = false;
            pause();
            UIAction(issueNowDownArrow, string.Empty, "a");
            pause();
            UIAction(bindAndIssue, string.Empty, "a");
            pause();
            try
            {
                driver.SwitchTo().Alert().Accept();
                WaitForPageLoad(driver);
                System.Threading.Thread.Sleep(3000);
                pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            pause();
            pause();
            bool uwIssues = IsElementPresent(driver, By.CssSelector(uwIssuesPresent));
            Console.WriteLine("UWISsues =====" + uwIssues);
            if (uwIssues)
            {
                IWebElement btnUSIssues = driver.FindElement(By.CssSelector(btnDetails));
                WaitForEnabled(btnUSIssues);
                Console.WriteLine("UW issues present");
                UIAction(btnDetails, string.Empty, "a");
                pause();
                PageInputs = driver.FindElements(By.CssSelector("span[id$=':SpecialApprove_link']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    Console.WriteLine("TExt" + PageInputs[i].Text);

                    if (PageInputs[i].Text.ToLower().Trim() == "special approve")
                    {
                        Console.WriteLine("Found");
                        PageInputs[i].Click();

                        pause();
                    }
                    break;
                }
                pause();
                driver.SwitchTo().Alert().Accept();
                pause();
                PageInputs = driver.FindElements(By.CssSelector("a[class='button']")).ToList();
                for (int i = 0; i < PageInputs.Count; i++)
                {
                    if (PageInputs[i].Text.ToLower().Trim() == "ok")
                        PageInputs[i].Click();
                    break;
                }
                pause();
                //--------------

                //--------------
                UIAction(issueNowDownArrow, string.Empty, "a");
                pause();
                pause();
                Console.WriteLine("Issue down arrow");
                UIAction(bindAndIssue, string.Empty, "a");
                Console.WriteLine("Bind and ISsue down arrow");
                System.Threading.Thread.Sleep(4000);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                driver.SwitchTo().ActiveElement().Click();
                pause();
                //isPolicySuccessful = IsElementPresent(driver, By.CssSelector("div[id='JobComplete:JobCompleteScreen:ttlBar']"));
                //do
                //{
                //    pause();

                //    isPolicySuccessful = IsElementPresent(driver, By.CssSelector("div[id='JobComplete:JobCompleteScreen:ttlBar']"));
                //} while (isPolicySuccessful);
            }
            Console.WriteLine("Out of loop");
            bool Policy_Quote_Status = false;
            int count = 0;
            do
            {
                Console.WriteLine("inside loop");
                try
                {
                    PageInputs = driver.FindElements(By.CssSelector("a[class='underlined']")).ToList();
                    Console.WriteLine("Page total count is " + PageInputs.Count);
                    Console.WriteLine("Details are : " + PageInputs[0].Text);
                    pause();
                    pause();
                    for (int i = 0; i < PageInputs.Count; i++)
                    {
                        System.Threading.Thread.Sleep(7000);
                        string Temp = "view your policy (#";
                        if (PageInputs[i].Text.ToLower().Trim().Contains(Temp))
                        {
                            Console.WriteLine(i + "=" + PageInputs[i].Text);
                            Console.WriteLine(i + PageInputs[i].Text);
                            pause();
                            string policyNumber = PageInputs[i].Text.Substring(Temp.Length, 9);
                            if (policyNumber != null)
                                isPolicySuccessful = true;
                            Console.WriteLine("policy number" + policyNumber);
                            ScenarioContext.Current["POLICY"] = policyNumber;
                            break;
                        }
                    }
                    if (PageInputs.Count > 1)
                        Policy_Quote_Status = true;
                }
                catch (Exception e)
                {

                }
                count = count + 1;
                if (count > 30)
                    Policy_Quote_Status = true;
                Console.WriteLine("policy status loop counter" + count);
            } while (Policy_Quote_Status == false);
            if (!isPolicySuccessful)
                Assert.Fail("Policy is not Created.");
        }
    }
}

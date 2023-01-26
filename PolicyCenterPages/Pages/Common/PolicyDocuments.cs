using AutomationFramework;
using HelperClasses;
using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace PolicyCenterPages.Pages.Common
{
    public class PolicyDocuments : Page
    {
        //   string btnNext = "a[id='SubmissionWizard:Next']";
        string selectDocumentType = "select[id$='DocumentSearchDV:DocumentType']";
        string btnSearch = "span[id$=':SearchAndResetInputSet:SearchLinksInputSet:Search_link']";


        [FindsBy(How = How.Id, Using = "AccountFile_Documents:DocumentsScreen:DocumentSearchDV:DateFrom")]

        public IWebElement txtDateFrom;

        [FindsBy(How = How.Id, Using = "AccountFile_Documents:DocumentsScreen:DocumentSearchDV:DateTo")]

        public IWebElement txtDateTo;

        //public IWebElement tblDocumentContainer;

        //[FindsBy(How = How.Id, Using = "AccountFile_Documents:DocumentsScreen:DocumentsLV")]


        string[] arrTblList;

        public PolicyDocuments(IWebDriver driver) : base(driver)
        {

        }

        public override void VerifyPage()
        {
            SetActiveFrame();
			pause();
            pause();

            VerifyUIElementIsDisplayed(btnSearch);
        }

        public override void WaitForLoad()
        {
            IsElementPresent(driver, By.CssSelector(btnSearch));
        }

        public void DocumentSearch(string DocumentTypeName, string FromDate, string Todate)
        {
            UIAction(selectDocumentType, DocumentTypeName, "selectbox");
            pause();
            if (FromDate.Length > 3)
            {
                txtDateFrom.Clear();
                txtDateFrom.SendKeys(FromDate);
                txtDateTo.Clear();
                txtDateTo.SendKeys(Todate);

            }
            UIAction(btnSearch, string.Empty, "a");
        }

        public void VerifyDocuments(int Documentsavailable)
        {
            List<IWebElement> TableInputElements = driver.FindElements(By.Id("AccountFile_Documents:DocumentsScreen:DocumentsLV")).ToList();
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            arrTblList = TableInputElements[0].Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Console.WriteLine("count of array for account " + TableInputElements.Count());
            //for (int k = 0; k < arrTblList.Count(); k++)
            //{
            //    Console.WriteLine(k + " identifier " + arrTblList[k].ToString());
            //}
            try
            {
                if (Documentsavailable >= (arrTblList.Count() - 5))
                {
                    Console.WriteLine("Document Count match");
                }
                else
                {
                    Assert.Fail("Document Count do not match");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

		
		   public void VerifyDocuments(string Documentsavailable)
        {
            System.Threading.Thread.Sleep(4000);
            int Row = 0;
            List<IWebElement> reservetableObj1;
            Console.WriteLine("Table Row count is " + Row);
            try
            {
                reservetableObj1 = driver.FindElements(By.Id("PolicyFile_Documents:Policy_DocumentsScreen:DocumentsLV")).ToList();
                var rows1 = reservetableObj1[0].FindElements(By.TagName("tr"));
                Row = rows1.Count;
                Console.WriteLine("Table Row count is " + Row);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            if (Row > 1)
            {
                if (Documentsavailable.ToLower().Equals("yes"))
                {
                    Console.WriteLine("Document Status match");
                }
                else
                {
                    Assert.Fail("Document Status do not match");
                }

            }
            else
            {
                if (Documentsavailable.ToLower().Equals("yes"))
                {
                    Assert.Fail("Document Status do not match");
                }
                else
                {
                    Console.WriteLine("Document Status match");
                }
            }



        }

        public void CheckDocument(string DocName, string Offering, int DateDiff )
        {
         
            //if (DocName.Equals("Renewal"))
            //{
            //    DocName = "PRIOR NOTICE LETTER / RENEWAL REMINDER";
            //}
    
            DocumentSearch(DocName, "", "");
            pause();
            switch (Offering.ToUpper())
            {
                case "JEWELERS BLOCK":
                case "JEWELERS BLOCK PAK":
                    if((DateDiff > 75) & (DateDiff <= 100))
                    {
                        VerifyDocuments("no");
                    }
                    else
                    {
                        VerifyDocuments("yes");
                    }
                    break;
                case "BUSINESSOWNERS":
                case "JEWELERS STANDARD":
                case "JEWELERS STANDARD PAK":

                    VerifyDocuments("no");
                    break;

            }
        }
       public void  CLRenewDocument(int DateDiff, string Offering)
        {
            switch (Offering.ToUpper())
            {
                case "JEWELERS BLOCK":
                case "JEWELERS BLOCK PAK":
                    if ((DateDiff > 0) & (DateDiff <= 31))
                    {
                        CheckDocument("Renewal Statement", Offering, DateDiff);
                        CheckDocument("Renewal", Offering, DateDiff);
                    }
                    else if ((DateDiff > 31) & (DateDiff <= 46))
                    {
                        CheckDocument("Renewal Statement", Offering, DateDiff);
                        CheckDocument("Renewal", Offering, DateDiff);
                    }
                    else if ((DateDiff > 46) & (DateDiff <= 75))
                    {
                        CheckDocument("Renewal Statement", Offering, DateDiff);
                        CheckDocument("Renewal", Offering, DateDiff);
                    }
                    else if ((DateDiff > 75) & (DateDiff <= 100))
                    {
                        CheckDocument("Renewal Statement", Offering, DateDiff);
                    }
                    break;
                case "BUSINESSOWNERS":
                case "JEWELERS STANDARD":
                case "JEWELERS STANDARD PAK":
                    if ((DateDiff > 0) & (DateDiff <= 31))
                    {
                        CheckDocument("Renewal Statement", Offering, DateDiff);
                        CheckDocument("Renewal", Offering, DateDiff);
                    }
                    else if ((DateDiff > 31) & (DateDiff <= 46))
                    {
                        CheckDocument("Renewal Statement", Offering, DateDiff);
                        CheckDocument("Renewal", Offering, DateDiff);
                    }

                    else if ((DateDiff > 46) & (DateDiff <= 75))
                    {
                        CheckDocument("Renewal Statement", Offering, DateDiff);
                        CheckDocument("Renewal", Offering, DateDiff);
                    }

                    else if ((DateDiff > 75) & (DateDiff <= 100))
                    {
                        CheckDocument("Renewal Statement", Offering, DateDiff);
                    }


                    break;
            }

        }



    }
}

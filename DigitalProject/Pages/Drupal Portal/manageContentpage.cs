using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;

namespace DigitalProject.Pages.Drupal_Portal
{
 public  class ManageContentpage:Page
    {

        string lblAddContentheaderXapth = "//h1[text()='Content']";


        public ManageContentpage(IWebDriver driver) : base(driver)
		{
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblAddContentheaderXapth);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(lblAddContentheaderXapth));

        }

      

        public void DeleteTitle(string title)
        {
            List<IWebElement> reservetableObj;
            reservetableObj = driver.FindElements(By.TagName("table")).ToList();
            Console.WriteLine("Fac table object count is " + reservetableObj.Count());
            var tr = reservetableObj[0].FindElements(By.TagName("tr"));
            int Pre_RowCount = tr.Count;
            bool flag = false;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Row count is " + Pre_RowCount);
                var td = tr[i].FindElements(By.TagName("td"));
                for (int j = 0; j < td.Count; j++)
                {
                    Console.WriteLine("Cell count is " + td.Count);
                    var textname = td[1].FindElements(By.TagName("a"));
                    if (textname[0].Text.ToString().ToLower().Equals(title.ToLower()))
                    {
                        var chck1 = td[0].FindElements(By.TagName("input"));
                        Console.WriteLine("Checkbox count is " + chck1.Count);
                        chck1[0].Click();
                        pause();
                        var liobj = td[td.Count - 1].FindElements(By.TagName("li"));
                        Console.WriteLine("list1  count is " + liobj.Count);
                        liobj[1].Click();
                        pause();
                        var delobj = td[td.Count - 1].FindElements(By.TagName("li"));
                        Console.WriteLine("delobj  count is " + delobj.Count);
                        delobj[2].Click();
                        pause();
                        UIActionExt(By.Id("edit-submit"), "ispresent");
                        UIActionExt(By.Id("edit-submit"), "click", "", 0);
                        flag = true;


                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace DigitalPages.Pages.Common
{
    public class Home : Page
    {

        //Elements

            //Test



        public Home(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }


        public override void VerifyPage()
        {
            throw new NotImplementedException();
        }

        public override void WaitForLoad()
        {
            throw new NotImplementedException();
        }




    }
}

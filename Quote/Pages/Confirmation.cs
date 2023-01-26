
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Pages
{
    public class Confirmation:Page
    {

        string btnContactJMIS = "//*[@id='jmisContactBtn']";
        public Confirmation(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            SetActiveFrame();
            VerifyUIElementIsDisplayed(btnContactJMIS);
        }


    }
}

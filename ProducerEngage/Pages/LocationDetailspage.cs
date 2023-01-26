using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;

namespace ProducerEngage.Pages
{
    public class LocationDetailspage:Page
    {
        string lblLocationDetailsXpath = "//h2[text()='Location Details']";
        string selAlarmtypeXpath = "//div[@class='gw-panel-collapse gw-collapse gw-in']//select[@id='anAlarmType']";
        string btnAddSafeXpath = "//button[@on-click='addSafe({}, $event)']";
        string btnSafeIsAnchoredYes = "//gw-pl-inline-input-ctrl[@model='c.isAnchored']//label[1][@class='gw-first']";
        string btnSafeIsAnchoredNo = "//gw-pl-inline-input-ctrl[@model='c.isAnchored']//input[@value='false']";
        string selSafeWeightXpath = "//gw-pl-inline-input-ctrl[@class='ng-isolate-scope']//select";
        string btnNextXapth = "//button[@ng-show='showNext']";
        string btnGatedCommunityYes = "//gw-pl-yes-no-group[@model='locationVM.isGatedCommunity']//label[1][@class='gw-first']";
        string btnGattedCommunityNo = "//gw-pl-yes-no-group[@model='locationVM.isGatedCommunity']//input[@value='false']";
        string btnDomesticHelpYes = "//gw-pl-yes-no-group[@model='locationVM.isDomesticHelpEmployed']//label[1][@class='gw-first']";
        string btnDomesticHelpNo = "//gw-pl-yes-no-group[@model='locationVM.isDomesticHelpEmployed']//input[@value='false']";
        string btnOtherResdYes = "//gw-pl-yes-no-group[@model='locationVM.isAnyOtherPersonResidesAtHome']//label[1][@class='gw-first']";
        string btnOtherResdNo = "//gw-pl-yes-no-group[@model='locationVM.isAnyOtherPersonResidesAtHome']//input[@value='false']";


        public LocationDetailspage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblLocationDetailsXpath);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(lblLocationDetailsXpath));
        }

        public void AddSafe(string address, string safeweight, string safeAnchored, int counter, int prevSafeNum)
        {
            manageheader(address);
            WaitUntilElementVisible(driver, By.XPath(selAlarmtypeXpath), 20);
            if (safeweight.Contains(";"))
            {
                char[] delimiterChars = { ';' };
                string[] safeWeighttemp = safeweight.Split(delimiterChars);
                string[] safeAnchoredtemp = safeAnchored.Split(delimiterChars);
                //if(prevSafeNum == safeWeighttemp.Count())
                //{
                //    prevSafeNum = 0;
                //}
                for (int i = 0; i < safeWeighttemp.Count(); i++)
                {
                    List<IWebElement> btnSafeobj = driver.FindElements(By.XPath(btnAddSafeXpath)).ToList();
                    Console.WriteLine(btnSafeobj.Count());
                    JavaScriptClick(btnSafeobj[counter]);
                    if (safeAnchoredtemp[i].ToLower().Equals("yes"))
                    {
                        List<IWebElement> btnSafeIsAnchoredYesobj = driver.FindElements(By.XPath(btnSafeIsAnchoredYes)).ToList();
                        JavaScriptClick(btnSafeIsAnchoredYesobj[btnSafeIsAnchoredYesobj.Count - 1]);
                        //JavaScriptClick(btnSafeIsAnchoredYesobj[btnSafeIsAnchoredYesobj.Count - 1 - prevSafeNum]);

                    }
                    else
                    {
                        List<IWebElement> btnSafeIsAnchoredNoobj = driver.FindElements(By.XPath(btnSafeIsAnchoredNo)).ToList();
                        JavaScriptClick(btnSafeIsAnchoredNoobj[btnSafeIsAnchoredNoobj.Count - 1]);
                        //JavaScriptClick(btnSafeIsAnchoredNoobj[btnSafeIsAnchoredNoobj.Count - 1 - prevSafeNum]);
                    }
                    List<IWebElement> selSafeWeightXpathobj = driver.FindElements(By.XPath(selSafeWeightXpath)).ToList();
                    SelectByText(selSafeWeightXpathobj[selSafeWeightXpathobj.Count - 1], safeWeighttemp[i]);
                }
            }
            else
            {
                //if (prevSafeNum == 1)
                //{
                //    prevSafeNum = 0;
                //}
                List<IWebElement> btnSafeobj = driver.FindElements(By.XPath(btnAddSafeXpath)).ToList();
                JavaScriptClick(btnSafeobj[counter]);

                if (safeAnchored.ToLower().Equals("yes"))
                {
                    List<IWebElement> btnSafeIsAnchoredYesobj = driver.FindElements(By.XPath(btnSafeIsAnchoredYes)).ToList();
                    JavaScriptClick(btnSafeIsAnchoredYesobj[btnSafeIsAnchoredYesobj.Count - 1]);
                    //JavaScriptClick(driver.FindElement(By.XPath(btnSafeIsAnchoredYes)));
                    //JavaScriptClick(btnSafeIsAnchoredYesobj[btnSafeIsAnchoredYesobj.Count - 1 - prevSafeNum]);
                }
                else
                {
                    List<IWebElement> btnSafeIsAnchoredNoobj = driver.FindElements(By.XPath(btnSafeIsAnchoredNo)).ToList();
                    Console.WriteLine("btnSafeIsAnchoredNoobj " + btnSafeIsAnchoredNoobj.Count());
                    JavaScriptClick(btnSafeIsAnchoredNoobj[btnSafeIsAnchoredNoobj.Count - 1]);
                    //JavaScriptClick(btnSafeIsAnchoredNoobj[btnSafeIsAnchoredNoobj.Count - 1 - prevSafeNum]);
                    //JavaScriptClick(btnSafeIsAnchoredNoobj[0]);
                }
                List<IWebElement> selSafeWeightXpathobj = driver.FindElements(By.XPath(selSafeWeightXpath)).ToList();
                Console.WriteLine("selSafeWeightXpathobj " + selSafeWeightXpathobj.Count());
                SelectByText(selSafeWeightXpathobj[selSafeWeightXpathobj.Count - 1], safeweight);
                //SelectByText(selSafeWeightXpathobj[0], safeweight);
                //SelectByText(selSafeWeightXpathobj[selSafeWeightXpathobj.Count - 1 - prevSafeNum], safeweight);
            }

        }

        public void AddAlarmDetails(Table table)
        {

            int itemcounter = 0;
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string AddressRef = ExpValues[0];
                string Alarm = ExpValues[1];
                selectAlarm(AddressRef, Alarm, itemcounter);
                itemcounter = itemcounter + 1;

            }
        }

        public void AddSafeDetails(Table table)
        {
            //int itemcounter = table.RowCount - 1;
            int itemcounter = 0;
            int safeNum = 0;
            foreach (var Eachrow in table.Rows)
            {
                int safeWeightNum = 0;
                var ExpValues = Eachrow.Values.ToList();
                string AddressRef = ExpValues[0];
                string Safeweight = ExpValues[1];
                string SafeAnchored = ExpValues[2];
                //if (Safeweight.Contains(";"))
                //{
                //    char[] delimiterChars = { ';' };
                //    safeWeightNum = Safeweight.Split(delimiterChars).Count();
                //}
                //else
                //{
                //    safeWeightNum = 1;
                //}
                //safeNum += safeWeightNum;
                AddSafe(AddressRef, Safeweight, SafeAnchored, itemcounter, safeNum);               
                itemcounter = itemcounter + 1;

            }
        }

        public void  AddUWDetails(Table table)
        {
            int itemcounter = 0;
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string AddressRef = ExpValues[0];
                string GatedEnterance = ExpValues[1];
                string DomesticHelp = ExpValues[2];
                string HomeHasOtherResidents = ExpValues[3];
                System.Console.WriteLine("I am in Main ADDUW functions");
                SetUWMain(AddressRef,GatedEnterance, DomesticHelp, HomeHasOtherResidents, itemcounter);
                itemcounter = itemcounter + 1;

            }

        }

        public void SetUWMain(string address, string GatedCommunity, string DomesticHelp, string HomeHasOtherResidents, int counter)
        {
            manageheader(address);
            System.Console.WriteLine("I am in SetUW functions");
            List<IWebElement> gatedCommunityYesobj = driver.FindElements(By.XPath(btnGatedCommunityYes)).ToList();
            List<IWebElement> gatedCommunityNoobj = driver.FindElements(By.XPath(btnGattedCommunityNo)).ToList();
            List<IWebElement> domesticHelpYesobj = driver.FindElements(By.XPath(btnDomesticHelpYes)).ToList();
            List<IWebElement> domesticHelpNoobj = driver.FindElements(By.XPath(btnDomesticHelpNo)).ToList();
            List<IWebElement> otherResdYesobj = driver.FindElements(By.XPath(btnOtherResdYes)).ToList();
            List<IWebElement> otherResdNoobj = driver.FindElements(By.XPath(btnOtherResdNo)).ToList();
            System.Console.WriteLine("Count of object is " + gatedCommunityNoobj.Count());
            switch (GatedCommunity.ToLower().Trim())
            {
                  case "yes":
                    JavaScriptClick(gatedCommunityYesobj[counter]);
                    break;
                case "no":
                    JavaScriptClick(gatedCommunityNoobj[counter]);
                    break;
                default:
                    break;
            }

            switch (DomesticHelp.ToLower().Trim())
            {
                case "yes":
                    JavaScriptClick(domesticHelpYesobj[counter]);
                    break;
                case "no":
                    JavaScriptClick(domesticHelpNoobj[counter]);
                    break;
                default:
                    break;

            }

            switch (HomeHasOtherResidents.ToLower().Trim())
            {
                case "yes":
                    JavaScriptClick(otherResdYesobj[counter]);
                    break;
                case "no":
                    JavaScriptClick(otherResdNoobj[counter]);
                    break;
                default:
                    break;
            }
        }

        public void manageheader(string address)
        {
            
            List<IWebElement> headerobj;
            List<IWebElement> headerobjclosed;
            do
            {
                headerobj = driver.FindElements(By.XPath("//span[text()[contains(.,'" + address + "')]]")).ToList();
                Console.WriteLine("object counter is " + headerobj.Count);
                pause();
            } while (headerobj.Count != 1);

            try
            {
                headerobjclosed = driver.FindElements(By.XPath("//div[@gw-pl-accordion-transclude='gwPlHeading'][@class='ng-binding']//h2//div//span[text()[contains(.,'" + address + "')]]")).ToList();
                Console.WriteLine("object closed counter is " + headerobjclosed.Count);
                if (headerobjclosed.Count > 0)
                {
                    UIActionExt(By.XPath("//span[text()[contains(.,'" + address + "')]]"), "ispresent");
                    UIActionExt(By.XPath("//span[text()[contains(.,'" + address + "')]]"), "click");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Issue with closed tab " + e.Message);
            }

        }

        public void selectAlarm(string address, string alarmtype, int counter)
        {
            manageheader(address);
            WaitUntilElementVisible(driver, By.XPath(selAlarmtypeXpath), 20);
            SelectByText(driver.FindElement(By.XPath(selAlarmtypeXpath)), alarmtype);
        }

        public void ClickNext()
        {
            JavaScriptClick(driver.FindElement(By.XPath(btnNextXapth)));
        }


    }
}

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
    public class ContactDetailspage:Page
    {
        string lblheaderXpath = "//h2[@class='gw-accordion-title ng-scope']";
        string lblContactDetailsXpath = "//h2[@class='gw-page-section-title gw-as-page-title ng-binding'][text()='Contact Details']";
        string btnConvictedofCrimedYes = "//div[@class='gw-panel-collapse gw-collapse gw-in']//div[@name='selfReportedCrimeRecords']//label[@class='gw-first']";
        string btnConvictedofCrimedNo = "//div[@class='gw-panel-collapse gw-collapse gw-in']//div[@name='selfReportedCrimeRecords']//label[@class='gw-second']";
        string btnDeniedCoverageYes = "//div[@class='gw-panel-collapse gw-collapse gw-in']//div[@name='DeniedCoverage']//label[@class='gw-first']";
        string btnDeniedCoverageNo = "//div[@class='gw-panel-collapse gw-collapse gw-in']//div[@name='DeniedCoverage']//label[@class='gw-second']";
        string selDeniedcoveragereason = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-input-ctrl[@model='contactVM.deniedReason']/div/div/div//select";
        string btnAddRecord = "//div[@class='gw-panel-collapse gw-collapse gw-in']//button";
        string txtRetroDateXpath = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-inline-input-ctrl[@model='item.recordDate']//input";
        string selRecordTypeXpath = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-inline-input-ctrl[@model='item.recordType']//select";
        string selTypeXpath = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-inline-input-ctrl[@model='item.type']//select";
        string selCategoryXpath = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-inline-input-ctrl[@model='item.category']//select";
        string chckboxAdditionalNamedInsuredXpath = "//div[@class='gw-panel-collapse gw-collapse gw-in']//input[@ng-model='contactVM.isAdditionalNamedInsured.value']";
        string btnNextXapth = "//button[@ng-show='showNext']";
        string selDOBPrimaryContcatXpath = "//div[@class='gw-panel-collapse gw-collapse gw-in']//input[@id='localDateChooser']";

        string selfrequencyOfArticlesWorn = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-input-ctrl[@model='contactVM.frequencyOfArticlesWorn']/div/div/div//select";
        string seloccupationType = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-input-ctrl[@model='contactVM.occupationType']/div/div/div//select";
        string seltravelFrequency = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-input-ctrl[@model='contactVM.travelFrequency']/div/div/div//select";
        string selsaveguards = "//div[@class='gw-panel-collapse gw-collapse gw-in']//gw-pl-input-ctrl[@model='contactVM.saveguards']/div/div/div//select";
        string btnTravelAbroadYes = "//div[@class='gw-panel-collapse gw-collapse gw-in']//div[@name='HasTravelledAbroad']//label[@class='gw-first']";
        string btnTravelAbroadNo = "//div[@class='gw-panel-collapse gw-collapse gw-in']//div[@name='HasTravelledAbroad']//label[@class='gw-second']";

        public ContactDetailspage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);

        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(lblContactDetailsXpath);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(lblContactDetailsXpath));
        }

        public void SingleItemDetails(Table table, string Dob)
        {
            int itemcounter = 0;
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string ConvictedofCrime = ExpValues[0];
                string RecordDate = ExpValues[1];
                string RecordType = ExpValues[2];
                string Type = ExpValues[3];
                string Category = ExpValues[4];
                string DeniedCoverage = ExpValues[5];
                string Reason = ExpValues[6];
                string AdditionalNameInsured = ExpValues[7];
                AddItemDetails(ConvictedofCrime, RecordDate, RecordType, Type, Category, DeniedCoverage, Reason, AdditionalNameInsured, Dob, itemcounter);
                itemcounter = itemcounter + 1;

            }

        }

        public void CrimeDetails(Table table)
        {
            int itemcounter = 0;
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string ConvictedofCrime = ExpValues[0];
                string RecordDate = ExpValues[1];
                string RecordType = ExpValues[2];
                string Type = ExpValues[3];
                string Category = ExpValues[4];
                AddCrimeDetails(ConvictedofCrime, RecordDate, RecordType, Type, Category, itemcounter);
                itemcounter = itemcounter + 1;

            }
        }

        public void AdditionalUWQuestions(Table table)
        {
            int itemcounter = 0;
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
               
                string ArticleWorn = ExpValues[0];
                string CurrentOccuption = ExpValues[1];
                string TravelOvernightFreq = ExpValues[2];
                string TravelAbroad = ExpValues[3];
                string ProtectJwelryforTraveling = ExpValues[4];
                string DeniedCoverage = ExpValues[5];
                string Reason = ExpValues[6];
                string AdditionalNameInsured = ExpValues[7];
                AddAdditionalUW(ArticleWorn, CurrentOccuption, TravelOvernightFreq, TravelAbroad, ProtectJwelryforTraveling, DeniedCoverage, Reason, AdditionalNameInsured, itemcounter);
                itemcounter = itemcounter + 1;
            }
        }

        public void DeniedCoverage(Table table)
        {
            int itemcounter = 0;
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string DeniedCoverage = ExpValues[0];
                string Reason = ExpValues[1];
                string AdditionalNameInsured = ExpValues[2];
                AddDeniedCoverage(DeniedCoverage, Reason, AdditionalNameInsured, itemcounter);
                itemcounter = itemcounter + 1;
            }
        }

        public void AddAdditionalUW(string ArticleWorn, string CurrentOccuption, string TravelOvernightFreq, string TravelAbroad, string ProtectJwelryforTraveling, string deniedCoverage, string reason, string additionalNameInsured, int counter)
        {
            List<IWebElement> headerobj;
            do
            {
                headerobj = driver.FindElements(By.XPath(lblheaderXpath)).ToList();
                Console.WriteLine("object counter is " + headerobj.Count);
                Console.WriteLine("counter is " + counter);
                pause();
            } while (headerobj.Count == 0);
            JavaScriptClick(headerobj[counter]);
            pause();
            SelectByText(driver.FindElement(By.XPath(selfrequencyOfArticlesWorn)), ArticleWorn);
            SelectByText(driver.FindElement(By.XPath(seloccupationType)), CurrentOccuption);
            SelectByText(driver.FindElement(By.XPath(seltravelFrequency)), TravelOvernightFreq);
            SelectByText(driver.FindElement(By.XPath(selsaveguards)), ProtectJwelryforTraveling);
            if (TravelAbroad.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnTravelAbroadYes)));
                            }
            else
            {
              
                JavaScriptClick(driver.FindElement(By.XPath(btnTravelAbroadNo)));
            }
            if (deniedCoverage.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageYes)));
                WaitUntilElementVisible(driver, By.XPath(selDeniedcoveragereason), 30);
                SelectByText(driver.FindElement(By.XPath(selDeniedcoveragereason)), reason);
            }
            else
            {
                WaitUntilElementVisible(driver, By.XPath(btnDeniedCoverageNo), 30);
                JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageNo)));
            }

            if (additionalNameInsured.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(chckboxAdditionalNamedInsuredXpath)));
            }
        }
   
        public void AddItemDetails (string convictedofcrime, string recorddate, string recordtype, string type, string category, string deniedCoverage, string reason, string additionalNameInsured, string dob, int counter)
        {
            List<IWebElement> headerobj;
            do
            {
                headerobj = driver.FindElements(By.XPath(lblheaderXpath)).ToList();
                Console.WriteLine("object counter is " + headerobj.Count);
                Console.WriteLine("counter is " + counter);
                pause();

            }
            while (headerobj.Count == 0);
            if (counter != 0)
            {
                JavaScriptClick(headerobj[counter]);
            }
            // JavaScriptClick(headerobj[counter]);
            pause();
            if (convictedofcrime.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnConvictedofCrimedYes)));

                if (recorddate.Contains(";"))
                {
                    char[] delimiterChars = { ';' };
                    string[] recorddatetemp = recorddate.Split(delimiterChars);
                    string[] recordtypetemp = recordtype.Split(delimiterChars);
                    string[] typetemp = type.Split(delimiterChars);
                    string[] categorytemp = category.Split(delimiterChars);
                    Console.WriteLine("counter is " + recorddatetemp.Count());
                    for (int i = 0; i < recorddatetemp.Count(); i++)
                    {
                        JavaScriptClick(driver.FindElement(By.XPath(btnAddRecord)));
                        List<IWebElement> txtRetroDateobj = driver.FindElements(By.XPath(txtRetroDateXpath)).ToList();
                        Console.WriteLine("txtRetroDateobj counter is " + txtRetroDateobj.Count());
                        txtRetroDateobj[txtRetroDateobj.Count - 1].SendKeys(recorddatetemp[i]);
                        List<IWebElement> selRecordTypeXpathobj = driver.FindElements(By.XPath(selRecordTypeXpath)).ToList();
                        Console.WriteLine("selRecordTypeXpathobj counter is " + selRecordTypeXpathobj.Count());
                        SelectByText(selRecordTypeXpathobj[selRecordTypeXpathobj.Count - 1], recordtypetemp[i]);
                        List<IWebElement> selTypeXpathobj = driver.FindElements(By.XPath(selTypeXpath)).ToList();
                        Console.WriteLine("selTypeXpathobj counter is " + selTypeXpathobj.Count());
                        SelectByText(selTypeXpathobj[selTypeXpathobj.Count - 1], typetemp[i]);
                        List<IWebElement> selCategoryXpathobj = driver.FindElements(By.XPath(selCategoryXpath)).ToList();
                        Console.WriteLine("selCategoryXpathobj counter is " + selCategoryXpathobj.Count());
                        SelectByText(selCategoryXpathobj[selCategoryXpathobj.Count - 1], categorytemp[i]);
                    }
                }
                else
                {
                    UIActionExt(By.XPath(txtRetroDateXpath), "listbox", recorddate);
                    SelectByText(driver.FindElement(By.XPath(selRecordTypeXpath)), recordtype);
                    SelectByText(driver.FindElement(By.XPath(selTypeXpath)), type);
                    SelectByText(driver.FindElement(By.XPath(selCategoryXpath)), category);
                }
            }
            else if(convictedofcrime.ToLower().Equals("no"))
            {
                WaitUntilElementVisible(driver, By.XPath(btnConvictedofCrimedNo), 30);
                JavaScriptClick(driver.FindElement(By.XPath(btnConvictedofCrimedNo)));
            }
            pause();
            if (deniedCoverage.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageYes)));
                WaitUntilElementVisible(driver, By.XPath(selDeniedcoveragereason), 30);
                SelectByText(driver.FindElement(By.XPath(selDeniedcoveragereason)), reason);
            }
            else
            {
                WaitUntilElementVisible(driver, By.XPath(btnDeniedCoverageNo), 30);
                JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageNo)));
            }

            if (additionalNameInsured.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(chckboxAdditionalNamedInsuredXpath)));
            }

            pause();
            UIActionExt(By.XPath(selDOBPrimaryContcatXpath), "listbox", dob);

        }
        public void AddCrimeDetails(string convictedofcrime, string recorddate, string recordtype, string type, string category, int counter)
        {
            List<IWebElement> headerobj;
            do
            {
                headerobj = driver.FindElements(By.XPath(lblheaderXpath)).ToList();
                Console.WriteLine("object counter is " + headerobj.Count);
                Console.WriteLine("counter is " + counter);
                pause();
                
            }
            while (headerobj.Count == 0);
           if (counter != 0)
            {
                JavaScriptClick(headerobj[counter]);
            }
           // JavaScriptClick(headerobj[counter]);
            pause();
            if (convictedofcrime.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnConvictedofCrimedYes)));
              
                if (recorddate.Contains(";"))
                    {
                        char[] delimiterChars = { ';' };
                        string[] recorddatetemp = recorddate.Split(delimiterChars);
                        string[] recordtypetemp = recordtype.Split(delimiterChars);
                        string[] typetemp = type.Split(delimiterChars);
                        string[] categorytemp = category.Split(delimiterChars);
                        Console.WriteLine("counter is " + recorddatetemp.Count());
                        for (int i = 0; i < recorddatetemp.Count(); i++)
                        {
                            JavaScriptClick(driver.FindElement(By.XPath(btnAddRecord)));
                            List<IWebElement> txtRetroDateobj = driver.FindElements(By.XPath(txtRetroDateXpath)).ToList();
                            Console.WriteLine("txtRetroDateobj counter is " + txtRetroDateobj.Count());
                            txtRetroDateobj[txtRetroDateobj.Count - 1].SendKeys(recorddatetemp[i]);
                            List<IWebElement> selRecordTypeXpathobj = driver.FindElements(By.XPath(selRecordTypeXpath)).ToList();
                            Console.WriteLine("selRecordTypeXpathobj counter is " + selRecordTypeXpathobj.Count());
                            SelectByText(selRecordTypeXpathobj[selRecordTypeXpathobj.Count - 1], recordtypetemp[i]);
                            List<IWebElement> selTypeXpathobj = driver.FindElements(By.XPath(selTypeXpath)).ToList();
                            Console.WriteLine("selTypeXpathobj counter is " + selTypeXpathobj.Count());
                            SelectByText(selTypeXpathobj[selTypeXpathobj.Count - 1], typetemp[i]);
                            List<IWebElement> selCategoryXpathobj = driver.FindElements(By.XPath(selCategoryXpath)).ToList();
                            Console.WriteLine("selCategoryXpathobj counter is " + selCategoryXpathobj.Count());
                            SelectByText(selCategoryXpathobj[selCategoryXpathobj.Count - 1], categorytemp[i]);
                        }
                    }
                    else
                    {
                        UIActionExt(By.XPath(txtRetroDateXpath), "listbox", recorddate);
                        SelectByText(driver.FindElement(By.XPath(selRecordTypeXpath)), recordtype);
                        SelectByText(driver.FindElement(By.XPath(selTypeXpath)), type);
                        SelectByText(driver.FindElement(By.XPath(selCategoryXpath)), category);
                    }
            }
            else if (convictedofcrime.ToLower().Equals("no"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnConvictedofCrimedNo)));
            }

        }

        public void ClickNext()
        {
            JavaScriptClick(driver.FindElement(By.XPath(btnNextXapth)));
        }

        public void SetDateOfBirthforPrimaryContact(string dob)
        {
            List<IWebElement> headerobj;
            do
            {
                headerobj = driver.FindElements(By.XPath(lblheaderXpath)).ToList();
                Console.WriteLine("object counter is " + headerobj.Count);
                Console.WriteLine("counter is " + 0);
                pause();
            } while (headerobj.Count == 0);
            JavaScriptClick(headerobj[0]);
            pause();
            UIActionExt(By.XPath(selDOBPrimaryContcatXpath), "listbox", dob);
        }


        public void AddDeniedCoverage(string deniedCoverage, string reason, string additionalNameInsured, int counter)
        {
            List<IWebElement> headerobj;
            do
            {
                headerobj = driver.FindElements(By.XPath(lblheaderXpath)).ToList();
                Console.WriteLine("object counter is " + headerobj.Count);
                Console.WriteLine("counter is " + counter);
                pause();
            } while (headerobj.Count == 0);
            JavaScriptClick(headerobj[counter]);
            pause();
            if (deniedCoverage.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageYes)));
                WaitUntilElementVisible(driver, By.XPath(selDeniedcoveragereason), 30);
                SelectByText(driver.FindElement(By.XPath(selDeniedcoveragereason)), reason);
            }
            else
            {
                WaitUntilElementVisible(driver, By.XPath(btnDeniedCoverageNo), 30);
                JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageNo)));
            }

            if (additionalNameInsured.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(chckboxAdditionalNamedInsuredXpath)));
            }
        }

        public void setConvictedofCrimedToBeNoForQQ()
        {
            WaitUntilElementVisible(driver, By.XPath(btnConvictedofCrimedNo), 30);
            JavaScriptClick(driver.FindElement(By.XPath(btnConvictedofCrimedNo)));
        }

        public void setDeniedCoverageToBeNoForQQ() 
        {
            JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageNo)));
        }
    }
}

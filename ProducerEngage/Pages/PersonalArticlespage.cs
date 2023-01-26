using HelperClasses;
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
    public class PersonalArticlespage:Page
    {
        string btnAddArticleXapth = "//span[contains(.,'Add Article')]";
        string lblArticleXpath = "//span[.='Article']";
        string selArticleXpath = "//gw-pl-input-ctrl[@model='articleVM.articleName']//select";
        string selArticleSubTypeXpath = "//gw-pl-input-ctrl[@model='articleVM.articleSubtype']//select";
        string selGenderXpath = "//gw-pl-input-ctrl[@model='articleVM.gender']//select";
        string btnWearableTechYes = "//gw-pl-input-ctrl[@model='articleVM.isWearableTech']//label[1][@class='gw-first']";
        string btnWearableTechNo = "//gw-pl-input-ctrl[@model='articleVM.isWearableTech']//input[@value='false']";
        string selBrandXpath = "//gw-pl-input-ctrl[@model='articleVM.brand']//select";
        string selStyleXpath = "//gw-pl-input-ctrl[@model='articleVM.style']//select";
        string textValueXpath = "//input[@class='gw-currency-input__input ng-pristine ng-untouched ng-valid ng-empty']";
        string selDeductibleXpath = "//select[@gw-pl-select='articleVM.deductible.value']";
        string selLocatedXpath = "//select[@ng-model='articleVM.locatedWith.value']";
        string selLocationXpath = "//select[@ng-model='articleVM.location.value']";
        string btnDamageYesXpath = "//gw-pl-input-ctrl[@model='articleVM.isDamaged']//label[1][@class='gw-first']";
        string btnDamageNoXpath = "//gw-pl-input-ctrl[@model='articleVM.isDamaged']//input[@value='false']";
        string selDamageTypeXpath = "//gw-pl-input-ctrl[@model='articleVM.damageType']//select";
        string selArticleStoredXpath = "//select[@gw-pl-select='anArticleStoredType']";

       
        string txtFirstNameXpath = "//gw-pl-input-ctrl[@model='jmLocatedWithVM.firstName']/div/div/div//input[@ng-model='model.value']";
        string txtLastNameXpath = "//gw-pl-input-ctrl[@model='jmLocatedWithVM.lastName']/div/div/div//input[@ng-model='model.value']";
        string txtDOBXpath = "//input[@id='localDateChooser']";
        string selRelationshipXpath = "//gw-pl-input-ctrl[@model='jmLocatedWithVM.relationshipToLocatedwithContact']/div/div/div//select";
        string btnDeniedCoverageYes = "//gw-pl-input-ctrl[@model='jmLocatedWithVM.deniedCoverage']//label[1][@class='gw-first']";
        string btnDeniedCoverageNo = "//gw-pl-input-ctrl[@model='jmLocatedWithVM.deniedCoverage']//input[@value='false']";
        string selDeniedReasonXpath = "//gw-pl-input-ctrl[@model='jmLocatedWithVM.deniedReason']/div/div/div//select";
        string btnAddPersonXpath = "//button[@on-click='addLocatedWithAction(articleAddLocationForm)']";

        string txtAddress1Xpath = "//gw-pl-input-ctrl[@model='address.addressLine1']/div/div/div//input[@ng-model='model.value']";
        string txtAddress2Xpath = "//gw-pl-input-ctrl[@model='address.addressLine2']/div/div/div//input[@ng-model='model.value']";
        string txtCityXpath = "//gw-pl-input-ctrl[@model='address.city']/div/div/div//input[@ng-model='model.value']";
        string txtZipXpath = "//gw-pl-input-ctrl[@model='address.postalCode']/div/div/div//input[@ng-model='model.value']";
        string selstateXpath = "//select[@class='ng-scope ng-isolate-scope gw-pl-select']";
        string btnAddLocationXpath = "//button[@on-click='addLocationAction(addLocationForm)']";
        string btnVerifyAddress = "//span[contains(.,'Verify Address')]";
        string lbladdressverifiedXpath = "//span[.='Verified']";
        string btnNextXapth = "//button[@ng-show='showNext']";

        public PersonalArticlespage(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(btnAddArticleXapth);
        }

        public override void WaitForLoad()
        {
            WaitUntilElementVisible(driver, By.XPath(btnAddArticleXapth));
        }

        public void clickAdddArticle()
        {
            JavaScriptClick(driver.FindElement(By.XPath(btnAddArticleXapth)));
        }

        public void AddArticle(string article, string gender, string wearabletechType, string brand, string style, string articlesubtype, string value, string deductible, string damage, string damagetype, string articlestored, int counter)
        {
            List<IWebElement> articleobj;
             do
                {
                    articleobj = driver.FindElements(By.XPath(selArticleXpath)).ToList();
                    Console.WriteLine("object counter is " + articleobj.Count);
                    Console.WriteLine("counter is " + counter);
                    pause();
                } while (articleobj.Count <= counter);
           
            List<IWebElement> genderobj = driver.FindElements(By.XPath(selGenderXpath)).ToList();
            List<IWebElement> wearabletechTypeYesobj = driver.FindElements(By.XPath(btnWearableTechYes)).ToList();
            List<IWebElement> wearabletechTypeNoobj = driver.FindElements(By.XPath(btnWearableTechNo)).ToList();
            List<IWebElement> brandobj = driver.FindElements(By.XPath(selBrandXpath)).ToList();
            List<IWebElement> styleobj = driver.FindElements(By.XPath(selStyleXpath)).ToList();
            List<IWebElement> damageYesobj = driver.FindElements(By.XPath(btnDamageYesXpath)).ToList();
            List<IWebElement> damageNoobj = driver.FindElements(By.XPath(btnDamageNoXpath)).ToList();
            List<IWebElement> articlestoredobj = driver.FindElements(By.XPath(selArticleStoredXpath)).ToList();
            SelectByText(articleobj[articleobj.Count - 1], article);
            if (articlesubtype.Length > 0)
            {
                List<IWebElement> articlesubtypeobj = driver.FindElements(By.XPath(selArticleSubTypeXpath)).ToList();
                SelectByText(articlesubtypeobj[articlesubtypeobj.Count-1], articlesubtype);
            }
            SelectByText(genderobj[counter], gender);
            if (wearabletechType.Length > 0)
            {
                if (wearabletechType.ToLower().Equals("yes"))
                {
                    JavaScriptClick(wearabletechTypeYesobj[wearabletechTypeYesobj.Count-1]);
                }
                else
                {
                    JavaScriptClick(wearabletechTypeNoobj[wearabletechTypeNoobj.Count-1]);
                }
            }
            if (brand.Length > 0)
            {
                SelectByText(brandobj[brandobj.Count-1], brand);
            }
            if (style.Length > 0)
            {
                SelectByText(styleobj[styleobj.Count-1], brand);
            }
            UIActionExt(By.XPath(textValueXpath), "listbox", value);
            SelectByText(driver.FindElement(By.XPath(selDeductibleXpath)), deductible);
            if (damage.Length > 0)
            {
                if (damage.ToLower().Equals("yes"))
                {
                    JavaScriptClick(damageYesobj[damageYesobj.Count-1]);
                    List<IWebElement> damageTypeobj = driver.FindElements(By.XPath(selDamageTypeXpath)).ToList();
                    SelectByText(damageTypeobj[damageTypeobj.Count - 1], damagetype);

                }
                else
                {
                    JavaScriptClick(damageNoobj[damageNoobj.Count-1]);
                }
            }

            if (articlestored.Length > 0)
            {
                SelectByText(articlestoredobj[articlestoredobj.Count-1], articlestored);
            }
            Console.WriteLine("End of Function");
        }

        public void AddLocation(string adress1, string adress2, string city, string state, string zip)
        {
            List<IWebElement> locationWithobj = driver.FindElements(By.XPath(selLocationXpath)).ToList();
            SelectByText(locationWithobj[locationWithobj.Count - 1], "Other Location");
            WaitUntilElementVisible(driver, By.XPath(btnAddLocationXpath), 20);
            UIActionExt(By.XPath(txtAddress1Xpath), "listbox", adress1);
            if (adress2.Length > 0)
            {
                UIActionExt(By.XPath(txtAddress2Xpath), "listbox", adress1);
            }

            UIActionExt(By.XPath(txtCityXpath), "listbox", city);
            UIActionExt(By.XPath(txtZipXpath), "listbox", zip);
            List<IWebElement> selobj = driver.FindElements(By.XPath(selstateXpath)).ToList();
            Console.WriteLine("object count for list is " + selobj.Count);
            SelectByText(selobj[selobj.Count-2], state);
            //UIActionExt(By.XPath(btnVerifyAddress), "click");
            //WaitUntilElementVisible(driver, By.XPath(lbladdressverifiedXpath), 120);
            JavaScriptClick(driver.FindElement(By.XPath(btnAddLocationXpath)));
            WaitUntilElementVisible(driver, By.XPath(btnAddArticleXapth), 20);
        }
        public void AddPerson(string PFirstName, string PLirstName, string PDOB, string PReleation, string PCoverageDenied, string PCoverageDeniedReason)
        {
            List<IWebElement> locatedobj = driver.FindElements(By.XPath(selLocatedXpath)).ToList();
            SelectByText(locatedobj[locatedobj.Count - 1], "Other Person");
            WaitUntilElementVisible(driver, By.XPath(btnAddPersonXpath), 20);
            if (PFirstName.ToLower().Equals("unique"))
            {
                PFirstName = "PFN" + Unique.ID;
                PFirstName = PFirstName.Substring(0, PFirstName.Length - 20);
            }
            if (PLirstName.ToLower().Equals("unique"))
            {
                PLirstName = "PLN" + Unique.ID;
                PLirstName = PLirstName.Substring(0, PLirstName.Length - 20);
            }
            
            UIActionExt(By.XPath(txtFirstNameXpath), "listbox", PFirstName);
            UIActionExt(By.XPath(txtLastNameXpath), "listbox", PLirstName);
            UIActionExt(By.XPath(txtDOBXpath), "listbox", PDOB);
            SelectByText(driver.FindElement(By.XPath(selRelationshipXpath)), PReleation);
            if(PCoverageDenied.ToLower().Equals("yes"))
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageYes)));
                WaitUntilElementVisible(driver, By.XPath(selDeniedReasonXpath), 20);
                SelectByText(driver.FindElement(By.XPath(selDeniedReasonXpath)), PCoverageDeniedReason);
            }
            else
            {
                JavaScriptClick(driver.FindElement(By.XPath(btnDeniedCoverageNo)));
            }

            JavaScriptClick(driver.FindElement(By.XPath(btnAddPersonXpath)));
            WaitUntilElementVisible(driver, By.XPath(btnAddArticleXapth), 20);
        }
        public void AddArticleDetails(Table table)
        {

            int iteration = 0;
           
            foreach (var Eachrow in table.Rows)
            {
                var ExpValues = Eachrow.Values.ToList();
                string ArticleType = ExpValues[0];
                string Gender = ExpValues[1];
                string WearableTech = ExpValues[2];
                string Brand = ExpValues[3];
                string Style = ExpValues[4];
                string ArticleSubType = ExpValues[5];
                string Value = ExpValues[6];
                string Deductible = ExpValues[7];
                string Damage = ExpValues[8];
                string Damagetype = ExpValues[9];
                string ArticleStored = ExpValues[10];
                string LocatedWith = ExpValues[11];
                string PFirstName = ExpValues[12];
                string PLirstName = ExpValues[13];
                string PDOB = ExpValues[14];
                string PReleation = ExpValues[15];
                string PCoverageDenied = ExpValues[16];
                string PCoverageDeniedReason = ExpValues[17];
                string Location = ExpValues[18];
                string Ladress1 = ExpValues[19];
                string Ladress2 = ExpValues[20];
                string Lstate = ExpValues[23];
                string Lcity = ExpValues[21];
                string Lzip = ExpValues[22];
                clickAdddArticle();
                Console.WriteLine("iteration countert is " + iteration);
                AddArticle(ArticleType, Gender, WearableTech, Brand, Style, ArticleSubType, Value, Deductible, Damage, Damagetype, ArticleStored, iteration);
                if(LocatedWith.ToLower().Equals("other"))
                {
                    AddPerson(PFirstName, PLirstName, PDOB, PReleation, PCoverageDenied, PCoverageDeniedReason);
                }
                if (Location.ToLower().Equals("other"))
                {
                    AddLocation(Ladress1, Ladress2, Lcity, Lstate, Lzip);
                }

             
                iteration = iteration + 1;
            }

        }

        public void ClickNext()
        {
            JavaScriptClick(driver.FindElement(By.XPath(btnNextXapth)));
        }

        public void setDamageToBeBoForAnArticleForQQ()
        {
            List<IWebElement> damageNoobj = driver.FindElements(By.XPath(btnDamageNoXpath)).ToList();
            JavaScriptClick(damageNoobj[damageNoobj.Count - 1]);
        }

    }
}

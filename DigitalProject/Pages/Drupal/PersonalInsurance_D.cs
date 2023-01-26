using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;


namespace DigitalProject.Pages.Drupal
{
    public class PersonalInsurance_D : Page
    {
        string menuHowWeCompareXpath = "//a[contains(.,'How We Compare')]";
        string menuHistoryXpath = "//a[.='History']";
        string menuCoverageXpath = "//a[.='Coverage']";
        string menuReviewsXpath = "//a[.='Reviews']";
        string menuWhatItCostXpath = "//a[contains(.,'What It Costs')]";
        string menuCheckMyRateXpath = "//a[.='Check My Rate']";
        string titleBigNamesCompareXpath = "//h2[contains(.,'How the Big Names Compare to the Jewelry Insurance Experts')]";
        string infoBigNamesCompareXpath = "//p[contains(.,'Jewelry is typically covered under renters and homeowners insurance policies. But that coverage is not usually enough to cover')]";
        string infoSeeHowWeCompareXpath = "//th[.='See How We Compare']";
        string infoJewelersMutualXpath = "//th[.='Jewelers Mutual Group']";
        string infoTypicalHomeownersXpath = "//th[.='Typical Homeowners']";
        string chartLossXpath = "//td[.='Loss']";
        string chartLossCheckmarkXpath = "//tbody[1]/tr[1]//img[@alt='checkmark']";
        string chartLossXXpath = "//tbody[1]/tr[1]//img[@alt='X symbol']";
        string chartTheftXpath = "//td[.='Theft']";
        string chartTheftCheckmark1Xpath = "//tr[2]/td[2]/img[@alt='checkmark']";
        string chartTheftCheckmark2Xpath = "//tr[2]/td[3]/img[@alt='checkmark']";
        string chartDamageXpath = "//td[.='Damage']";
        string chartDamageCheckmarkXpath = "//tr[3]//img[@alt='checkmark']";
        string chartDamageNotXpath = "//tr[3]/td[.='Not always covered']";
        string chartDisappearanceXpath = "//td[.='Disappearance']";
        string chartDisappearanceCheckmarkXpath = "//tr[4]//img[@alt='checkmark']";
        string chartDisapperanceXXpath = "//tr[4]//img[@alt='X symbol']";
        string chartFloodXpath = "//td[.='Flood or Earthquake']";
        string chartFloodCheckmarkXpath = "//tr[5]//img[@alt='checkmark']";
        string chartFloodNotXpath = "//tr[5]/td[.='Not always covered']";
        string chartWorldwideXpath = "//td[.='Worldwide Travel']";
        string chartWorldwideCheckmark1Xpath = "//tr[6]/td[2]/img[@alt='checkmark']";
        string chartWorldwideCheckmark2Xpath = "//tr[6]/td[3]/img[@alt='checkmark']";
        string chartOutofPocketXpath = "//td[.='Out-of-Pocket Cost']";
        string chartOutofPocket0Xpath = "//td[.='$0 deductible option']";
        string chartHomeownersXpath = "//td[.='Homeowners deductible applies']";
        string chartEffectsofClaimsXpath = "//div[@class='jm-rt-title']";
        string chartInfoXpath = "//div[@class='jm-rt-subtitle']";
        string iconChartXpath = "//img[@alt='illustrated house']";
        string titleProtectingAllThingsXpath = "div[@class='column text-center text-medium-left']";
        string infoProtectAllThingsXpath = "//p[contains(.,'Jewelry insurance is only as good as the company standing behind it. Protect you')]";
        string linkMoreAboutOurHistoryXpath = "//a[.='More about our history']";
        string iconValutXpath = "//img[@alt='an icon of a jewelry safe']";
        string titleWhatsCoveredXpath = "//h2[contains(.,'What's Covered Under')]";
        string infoWhatsCovered1Xpath = "//p[contains(.,'We provide all types of jewelry insurance, including engagement ring insurance.')]";
        string infoWhatsCovered2Xpath = "//p[contains(.,\"No matter the type of jewelry you insure, it'll be protected by our comprehensiv\")]";
        string titleLossXpath = "//h4[.='Loss']";
        string infoLossXpath = "//p[contains(.,'You left your ring somewhere—on a beach towel or in a public bathroom. It’s out')]";
        string titleTheftXpath = "//h4[.='Theft']";
        string infoTheftXpath = "//p[contains(.,'We all know that feeling of dread when something we cherish is stolen.')]";
        string titleDamageXpath = "//h4[.='Damage']";
        string infoDamageXpath = "//p[contains(.,'You hit your diamond ring on the edge of a table and it cracks')]";
        string titleDisappearanceXpath = "//h4[.='Disappearance']";
        string infoDisappearanceXpath = "//p[contains(.,'Sometimes jewelry just disappears—it could be lost, stolen or hanging out')]";
        string titleWhatOurPolicyHoldersSayXpath = "//*[@id='title-4361']/h2";
        string headerWhatItCostsXpath = "//a[.='What It Costs']";
        string icon77Xpath = "//span[contains(.,'$77')]";
        string icon77yearlyXpath = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[@class='info-grid row content-lg grid-layout-two text-align-left border-bottom']//div[@class='info-grid row content-lg grid-layout-two text-align-left border-bottom']/div[1]//span[@class='text-yr']";
        string info77Xpath = "//p[contains(.,'for a $5,000 ring in Chicago (60614) with $100 deductible')]";
        string icon65Xpath = "//span[contains(.,'$65')]";
        string icon65yearlyXpath = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[@class='info-grid row content-lg grid-layout-two text-align-left border-bottom']/div[2]//span[@class='text-yr']";
        string info65Xpath = "//p[contains(.,'for a $7,000 watch in Ann Arbor (48103) with a $100 deductible')]";
        string icon25Xpath = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[3]//span[@class='text-val']";
        string icon25yearlyXpath = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[3]//span[@class='text-yr']";
        string info25Xpath = "//p[text()='for a $2,500 watch in Milwaukee (53202) with a $0 deductible ']";
        string icon25Xpath2nd = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[4]//span[@class='text-val']";
        string icon25yearlyXpath2nd = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[4]//span[@class='text-yr']";
        string info25Xpath2nd = "//p[contains(.,'for a $2,500 chain in Minneapolis (55416) with a $0 deductible')]";
        string icon55Xpath = "//span[contains(.,'$55')]";
        string icon55yearlyXpath = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[5]//span[@class='text-yr']";
        string info55Xpath = "//p[contains(.,'for a $5,000 ring in Columbus (43204) with $0 deductible')]";
        string icon80Xpath = "//span[contains(.,'$80')]";
        string icon80yearlyXpath = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[6]//span[@class='text-yr']";
        string info80Xpath = "//p[contains(.,'for an $8,000 ring in Indianapolis (46217) with a $0 deductible')]";
        string icon93Xpath = "//span[contains(.,'$93')]";
        string icon93yearlyXpath = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[7]//span[@class='text-yr']";
        string info93Xpath = "//p[contains(.,'for a $5,000 ring in New York (10016) with a $100 deductible')]";
        string icon47Xpath = "//span[contains(.,'$47')]";
        string icon47yearlyXpath = "//div[@class='block-block-content block--type-block-content801a616e-2e55-43c8-b0ce-4daf97a7ae44 block--info-grid background-color-']//div[8]//span[@class='text-yr']";
        string info47Xpath = "//p[contains(.,'for a $3,000 bracelet in Houston (77008) with a $0 deductible')]";
        string titleAllThingsJewelryXpath = "//*[@id='feature-row-4396']/div/h2";
        string infoAllthingsJewelryXpath = "//p[contains(.,'We’re here to make this choice as easy as possible for you, every step of the')]";
        string btnDownloadYourGuideXpath = "//a[.='Download your guide']";


        PersonalInsurance_D_V PersonalInsurance_D_V = new PersonalInsurance_D_V();
        
        public PersonalInsurance_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {
            VerifyUIElementIsDisplayed(menuHowWeCompareXpath);
            VerifyUIElementIsDisplayed(menuHistoryXpath);
            VerifyUIElementIsDisplayed(menuCoverageXpath);
            VerifyUIElementIsDisplayed(menuReviewsXpath);
            VerifyUIElementIsDisplayed(menuWhatItCostXpath);
            VerifyUIElementIsDisplayed(menuCheckMyRateXpath);
            VerifyUIElementIsDisplayed(titleBigNamesCompareXpath);
            VerifyUIElementIsDisplayed(infoBigNamesCompareXpath);
            VerifyUIElementIsDisplayed(infoSeeHowWeCompareXpath);
            VerifyUIElementIsDisplayed(infoJewelersMutualXpath);
            VerifyUIElementIsDisplayed(infoTypicalHomeownersXpath);
            VerifyUIElementIsDisplayed(chartLossXpath);
            VerifyUIElementIsDisplayed(chartLossCheckmarkXpath);
            VerifyUIElementIsDisplayed(chartLossXXpath);
            VerifyUIElementIsDisplayed(chartTheftXpath);
            VerifyUIElementIsDisplayed(chartTheftCheckmark1Xpath);
            VerifyUIElementIsDisplayed(chartTheftCheckmark2Xpath);
            VerifyUIElementIsDisplayed(chartDamageXpath);
            VerifyUIElementIsDisplayed(chartDamageCheckmarkXpath);
            VerifyUIElementIsDisplayed(chartDamageNotXpath);
            VerifyUIElementIsDisplayed(chartDisappearanceXpath);
            VerifyUIElementIsDisplayed(chartDisappearanceCheckmarkXpath);
            VerifyUIElementIsDisplayed(chartDisapperanceXXpath);
            VerifyUIElementIsDisplayed(titleLossXpath);
            VerifyUIElementIsDisplayed(infoLossXpath);
            VerifyUIElementIsDisplayed(titleTheftXpath);
            VerifyUIElementIsDisplayed(infoTheftXpath);
            VerifyUIElementIsDisplayed(titleDamageXpath);
            VerifyUIElementIsDisplayed(infoDamageXpath);
            VerifyUIElementIsDisplayed(titleDisappearanceXpath);
            VerifyUIElementIsDisplayed(infoDisappearanceXpath);
            VerifyUIElementIsDisplayed(chartFloodXpath);
            VerifyUIElementIsDisplayed(chartFloodCheckmarkXpath);
            VerifyUIElementIsDisplayed(chartFloodNotXpath);
            VerifyUIElementIsDisplayed(chartWorldwideXpath);
            VerifyUIElementIsDisplayed(chartWorldwideCheckmark1Xpath);
            VerifyUIElementIsDisplayed(chartWorldwideCheckmark2Xpath);
            VerifyUIElementIsDisplayed(chartOutofPocketXpath);
            VerifyUIElementIsDisplayed(chartOutofPocket0Xpath);
            VerifyUIElementIsDisplayed(chartHomeownersXpath);
            VerifyUIElementIsDisplayed(chartEffectsofClaimsXpath);
            VerifyUIElementIsDisplayed(chartInfoXpath);
            VerifyUIElementIsDisplayed(iconChartXpath);
            VerifyUIElementIsDisplayed(infoProtectAllThingsXpath);
            VerifyUIElementIsDisplayed(linkMoreAboutOurHistoryXpath);
            VerifyUIElementIsDisplayed(iconValutXpath);
            VerifyUIElementIsDisplayed(infoWhatsCovered1Xpath);
            VerifyUIElementIsDisplayed(infoWhatsCovered2Xpath);
            VerifyUIElementIsDisplayed(titleLossXpath);
            VerifyUIElementIsDisplayed(infoLossXpath);
            VerifyUIElementIsDisplayed(titleTheftXpath);
            VerifyUIElementIsDisplayed(infoTheftXpath);
            VerifyUIElementIsDisplayed(titleDamageXpath);
            VerifyUIElementIsDisplayed(infoDamageXpath);
            VerifyUIElementIsDisplayed(titleDisappearanceXpath);
            VerifyUIElementIsDisplayed(infoDisappearanceXpath);
            VerifyUIElementIsDisplayed(titleWhatOurPolicyHoldersSayXpath);
            VerifyUIElementIsDisplayed(headerWhatItCostsXpath);
            VerifyUIElementIsDisplayed(titleAllThingsJewelryXpath);
            VerifyUIElementIsDisplayed(infoAllthingsJewelryXpath);
            verifyMenuBar();
            verifyWhatOurPolicy();
        }


        public void verifyAllPersonalInsurancePageContent()
        {
            verifyFooter();
            verifyMenuBar();
            verifyWhatOurPolicy();
        }

        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
        }

        public void verifyNavBar()
        {
            DrupalCommonPage drupalCommon = new DrupalCommonPage();
            drupalCommon.verifyNavBar(driver);


        }
        public void verifyFooter()
        {
            DrupalCommonPage drupalCommon = new DrupalCommonPage();
            drupalCommon.verifyFooter(driver);

        }

        public void verifyMenuBar()
        {
            //Menu Bar
            string MenuHowWeCompare = driver.FindElement(By.XPath(menuHowWeCompareXpath)).GetAttribute("innerText");
            Assert.AreEqual(MenuHowWeCompare.ToLower().Trim(), PersonalInsurance_D_V.hrefHowWeCompare.ToLower().Trim(), "The Text doesn't match");

            string MenuHistory = driver.FindElement(By.XPath(menuHistoryXpath)).GetAttribute("innerText");
            Assert.AreEqual(MenuHistory.ToLower().Trim(), PersonalInsurance_D_V.hrefHistory.ToLower().Trim(), "The Text doesn't match");

            string MenuCoverage = driver.FindElement(By.XPath(menuCoverageXpath)).GetAttribute("innerText");
            Assert.AreEqual(MenuCoverage.ToLower().Trim(), PersonalInsurance_D_V.hrefCoverage.ToLower().Trim(), "The Text doesn't match");

            string MenuReviews = driver.FindElement(By.XPath(menuReviewsXpath)).GetAttribute("innerText");
            Assert.AreEqual(MenuReviews.ToLower().Trim(), PersonalInsurance_D_V.hrefReviews.ToLower().Trim(), "The Text doesn't match");

            string MenuHowItWorks = driver.FindElement(By.XPath(menuWhatItCostXpath)).GetAttribute("innerText");
            Assert.AreEqual(MenuHowItWorks.ToLower().Trim(), PersonalInsurance_D_V.hrefWhatItCost.ToLower().Trim(), "The Text doesn't match");

            string MenuCheckMyRate = driver.FindElement(By.XPath(menuCheckMyRateXpath)).GetAttribute("innerText");
            Assert.AreEqual(MenuCheckMyRate.ToLower().Trim(), PersonalInsurance_D_V.hrefCheckYourRate.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyTheCaseAgainst()
        {
            // How the Big Names Compare to the Experts
            string TitleBigNamesCompare = driver.FindElement(By.XPath(titleBigNamesCompareXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleBigNamesCompare.ToLower().Trim(), PersonalInsurance_D_V.txtTitleBigNamesCompare.ToLower().Trim(), "The Text doesn't match");

            string InfoBigNamesCompare = driver.FindElement(By.XPath(infoBigNamesCompareXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBigNamesCompare.ToLower().Trim(), PersonalInsurance_D_V.txtInfoBigNamesCompare.ToLower().Trim(), "The Text doesn't match");

            string InfoSeeHowWeCompare = driver.FindElement(By.XPath(infoSeeHowWeCompareXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoSeeHowWeCompare.ToLower().Trim(), PersonalInsurance_D_V.txtSeeHowWeCompare.ToLower().Trim(), "The Text doesn't match");

            string InfoJewelersMutual = driver.FindElement(By.XPath(infoJewelersMutualXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoJewelersMutual.ToLower().Trim(), PersonalInsurance_D_V.txtJewelersMutual.ToLower().Trim(), "The Text doesn't match");

            string InfoTypicalHomeowners = driver.FindElement(By.XPath(infoTypicalHomeownersXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTypicalHomeowners.ToLower().Trim(), PersonalInsurance_D_V.txtTypicalHomeowners.ToLower().Trim(), "The Text doesn't match");

            string ChartLoss = driver.FindElement(By.XPath(chartLossXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartLoss.ToLower().Trim(), PersonalInsurance_D_V.txtLossChart.ToLower().Trim(), "The Text doesn't match");

            string ChartTheft = driver.FindElement(By.XPath(chartTheftXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartTheft.ToLower().Trim(), PersonalInsurance_D_V.txtTheftChart.ToLower().Trim(), "The Text doesn't match");

            string ChartDamage = driver.FindElement(By.XPath(chartDamageXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartDamage.ToLower().Trim(), PersonalInsurance_D_V.txtDamageChart.ToLower().Trim(), "The Text doesn't match");

            string ChartDamageNot = driver.FindElement(By.XPath(chartDamageNotXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartDamageNot.ToLower().Trim(), PersonalInsurance_D_V.txtDamagaChartNot.ToLower().Trim(), "The Text doesn't match");

            string ChartDisappearance = driver.FindElement(By.XPath(chartDisappearanceXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartDisappearance.ToLower().Trim(), PersonalInsurance_D_V.txtDisapperanceChart.ToLower().Trim(), "The Text doesn't match");

            string ChartFlood = driver.FindElement(By.XPath(chartFloodXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartFlood.ToLower().Trim(), PersonalInsurance_D_V.txtFloodChart.ToLower().Trim(), "The Text doesn't match");

            string ChartFloodNot = driver.FindElement(By.XPath(chartFloodNotXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartFloodNot.ToLower().Trim(), PersonalInsurance_D_V.txtFloodChartNot.ToLower().Trim(), "The Text doesn't match");

            string ChartWorldwide = driver.FindElement(By.XPath(chartWorldwideXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartWorldwide.ToLower().Trim(), PersonalInsurance_D_V.txtWorldideTravel.ToLower().Trim(), "The Text doesn't match");

            string ChartOutofPocket = driver.FindElement(By.XPath(chartOutofPocketXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartOutofPocket.ToLower().Trim(), PersonalInsurance_D_V.txtxtOutofPocketCost.ToLower().Trim(), "The Text doesn't match");

            string ChartOutofPocket0 = driver.FindElement(By.XPath(chartOutofPocket0Xpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartOutofPocket0.ToLower().Trim(), PersonalInsurance_D_V.txt0.ToLower().Trim(), "The Text doesn't match");

            string ChartHomeowners = driver.FindElement(By.XPath(chartHomeownersXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartHomeowners.ToLower().Trim(), PersonalInsurance_D_V.txtHomeownersDedcuctible.ToLower().Trim(), "The Text doesn't match");

            string ChartEffectsofClaims = driver.FindElement(By.XPath(chartEffectsofClaimsXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartEffectsofClaims.ToLower().Trim(), PersonalInsurance_D_V.txtEffectsofClaims.ToLower().Trim(), "The Text doesn't match");

            string ChartInfo = driver.FindElement(By.XPath(chartInfoXpath)).GetAttribute("innerText");
            Assert.AreEqual(ChartInfo.ToLower().Trim(), PersonalInsurance_D_V.txtEffectsofClaimsInfo.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyProtectingAllThings()
        {
            //Protecting All Things Jewelry Since 1913
            string TitleProtectingAllThings = driver.FindElement(By.XPath(titleProtectingAllThingsXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleProtectingAllThings.ToLower().Trim(), PersonalInsurance_D_V.txtProtectingAllThings.ToLower().Trim(), "The Text doesn't match");

            string InfoProtectAllThings = driver.FindElement(By.XPath(infoProtectAllThingsXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoProtectAllThings.ToLower().Trim(), PersonalInsurance_D_V.txtProtectingAllThingsInfo.ToLower().Trim(), "The Text doesn't match");

            string LinkMoreAboutOurHistory = driver.FindElement(By.XPath(linkMoreAboutOurHistoryXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkMoreAboutOurHistory.ToLower().Trim(), PersonalInsurance_D_V.hrefMoreAboutOurHistory.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyWhatsCovered()
        {
            //What's Covered
            string TitleWhatsCovered = driver.FindElement(By.XPath(titleWhatsCoveredXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatsCovered.ToLower().Trim(), PersonalInsurance_D_V.txtWhatsCovered.ToLower().Trim(), "The Text doesn't match");

            string InfoWhatsCovered1 = driver.FindElement(By.XPath(infoWhatsCovered1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatsCovered1.ToLower().Trim(), PersonalInsurance_D_V.txtWhatsCoveredInfo1.ToLower().Trim(), "The Text doesn't match");

            string InfoWhatsCovered2 = driver.FindElement(By.XPath(infoWhatsCovered2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatsCovered2.ToLower().Trim(), PersonalInsurance_D_V.txtWhatsCoveredInfo2.ToLower().Trim(), "The Text doesn't match");

            string TitleLoss = driver.FindElement(By.XPath(titleLossXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleLoss.ToLower().Trim(), PersonalInsurance_D_V.txtLoss.ToLower().Trim(), "The Text doesn't match");

            string InfoLoss = driver.FindElement(By.XPath(infoLossXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoLoss.ToLower().Trim(), PersonalInsurance_D_V.txtLossInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleTheft = driver.FindElement(By.XPath(titleTheftXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleTheft.ToLower().Trim(), PersonalInsurance_D_V.txtTheft.ToLower().Trim(), "The Text doesn't match");

            string InfoTheft = driver.FindElement(By.XPath(infoTheftXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTheft.ToLower().Trim(), PersonalInsurance_D_V.txtTheftInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleDamage = driver.FindElement(By.XPath(titleDamageXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDamage.ToLower().Trim(), PersonalInsurance_D_V.txtDamage.ToLower().Trim(), "The Text doesn't match");

            string InfoDamage = driver.FindElement(By.XPath(infoDamageXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDamage.ToLower().Trim(), PersonalInsurance_D_V.txtDamageInfo.ToLower().Trim(), "The Text doesn't match");

            string TitleDisappearance = driver.FindElement(By.XPath(titleDisappearanceXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDisappearance.ToLower().Trim(), PersonalInsurance_D_V.txtDisappearance.ToLower().Trim(), "The Text doesn't match");

            string InfoDisappearance = driver.FindElement(By.XPath(infoDisappearanceXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDisappearance.ToLower().Trim(), PersonalInsurance_D_V.txtDisappearanceInfo.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyWhatOurPolicy()
        {
            string TitleWhatOurPolicyHoldersSay = driver.FindElement(By.XPath(titleWhatOurPolicyHoldersSayXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleWhatOurPolicyHoldersSay.ToLower().Trim(), PersonalInsurance_D_V.txtWhatOurPolicyHoldersSay.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyWhatitCosts()
        {
            // What it Costs

            string HeaderWhatItCosts = driver.FindElement(By.XPath(headerWhatItCostsXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderWhatItCosts.ToLower().Trim(), PersonalInsurance_D_V.txtHeaderWhatItCosts.ToLower().Trim(), "The Text doesn't match");

            string Info77 = driver.FindElement(By.XPath(info77Xpath)).GetAttribute("innerText");
            Assert.AreEqual(Info77.ToLower().Trim(), PersonalInsurance_D_V.txtInfo77JM.ToLower().Trim(), "The Text doesn't match");

            string Info65 = driver.FindElement(By.XPath(info65Xpath)).GetAttribute("innerText");
            Assert.AreEqual(Info65.ToLower().Trim(), PersonalInsurance_D_V.txtInfo65JM.ToLower().Trim(), "The Text doesn't match");

            string Info25 = driver.FindElement(By.XPath(info25Xpath)).GetAttribute("innerText");
            Assert.AreEqual(Info25.ToLower().Trim(), PersonalInsurance_D_V.txtInfo25JM.ToLower().Trim(), "The Text doesn't match");

            string Info252nd = driver.FindElement(By.XPath(info25Xpath2nd)).GetAttribute("innerText");
            Assert.AreEqual(Info252nd.ToLower().Trim(), PersonalInsurance_D_V.txtInfo25JM2nd.ToLower().Trim(), "The Text doesn't match");

            string Info55 = driver.FindElement(By.XPath(info55Xpath)).GetAttribute("innerText");
            Assert.AreEqual(Info55.ToLower().Trim(), PersonalInsurance_D_V.txtInfo55JM.ToLower().Trim(), "The Text doesn't match");

            string Info80 = driver.FindElement(By.XPath(info80Xpath)).GetAttribute("innerText");
            Assert.AreEqual(Info80.ToLower().Trim(), PersonalInsurance_D_V.txtInfo80JM.ToLower().Trim(), "The Text doesn't match");

            string Info93 = driver.FindElement(By.XPath(info93Xpath)).GetAttribute("innerText");
            Assert.AreEqual(Info93.ToLower().Trim(), PersonalInsurance_D_V.txtInfo93JM.ToLower().Trim(), "The Text doesn't match");

            string Info47 = driver.FindElement(By.XPath(info47Xpath)).GetAttribute("innerText");
            Assert.AreEqual(Info47.ToLower().Trim(), PersonalInsurance_D_V.txtInfo47JM.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyAllThingsJewelry()
        {
            //All Things Jewelry Insurance, All in One Place
            string TitleAllThingsJewelry = driver.FindElement(By.XPath(titleAllThingsJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleAllThingsJewelry.ToLower().Trim(), PersonalInsurance_D_V.txtAllThings.ToLower().Trim(), "The Text doesn't match");

            string InfoAllthingsJewelry = driver.FindElement(By.XPath(infoAllthingsJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAllthingsJewelry.ToLower().Trim(), PersonalInsurance_D_V.txtAllThingsInfo.ToLower().Trim(), "The Text doesn't match");

            string BtnDownloadYourGuide = driver.FindElement(By.XPath(btnDownloadYourGuideXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnDownloadYourGuide.ToLower().Trim(), PersonalInsurance_D_V.btnDownloadYourGuide.ToLower().Trim(), "The Text doesn't match");
        }
    }
}
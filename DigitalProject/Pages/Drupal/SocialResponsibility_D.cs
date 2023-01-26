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
    public class SocialResponsibility_D : Page
    {

        // Giving Back Brilliantly Since 1913
        string headerSRXpath = "//h4[contains(.,'SOCIAL RESPONSIBILITY')]";
        string infoSRXpath = "//h1[contains(.,'Giving Back Brilliantly Since 1913')]";


        // Our 2020 Band Togther Campaign 
        string titleBandTogther2020Xpath = "//h2[contains(.,'Our 2020 Band Together Campaign')]";
        string infoBandTogther2020p1Xpath = "//p[contains(.,'Jewelers Mutual is passionate about supporting worthy organizations as diverse as our policyholders. That’s why each year we select three, national non-profits to join with us in our Band Together campaign. This campaign encourages our policyholders to vote for a non-profit they feel most strongly about.')]";
        string infoBandTogther2020p2Xpath = "//p[contains(.,'At the end of 2020, Jewelers Mutual will donate $500,000 in total. Each non-profit is guaranteed a minimum of $100,000, and the remaining $200,000 is distributed based on the amount of votes each receives from our policyholders between 3/15/2020 and 11/15/2020. A donation will be made to comparable non-profits in Canada on behalf of our Canadian policyholders.')]";

        // 2020 Charity Choices 
        string iconFeedingAmericaXpath = "//img[@alt='Feeding America']";
        string titleFeedingAmericaXpath = "//h4[contains(.,'Feeding America®')]";
        string infoFeedingAmericaXpath = "//p[contains(text(),'Feeding America® seeks to feed America’s hungry through')]";
        string iconKidsXpath = "//img[@alt='Kids In Need']";
        string titleKidsXpath = "//h4[contains(.,'Kids In Need Foundation')]";
        string infoKidsXpath = "//p[contains(text(),'Kids in Need Foundation ensures that every')]";
        string iconStandUpXpath = "//img[@alt='Stand Up To Cancer']";
        string titleStandUpXpath = "//h4[contains(.,'Stand Up To Cancer')]";
        string infoStandUpXpath = "//p[contains(text(),'Stand Up To Cancer’s (SU2C) mission is to raise funds')]";
        string infoAddtionalXpath = "//p[contains(.,'In 2019, we donated 1,780,000 meals to Feeding America®, supplied over 21,000 students with school supplies through the Kids In Need Foundation, and helped train approximately 2,450 Special Olympics athletes as part of our inaugural campaign. This is the difference we can make. This is why we Band Together.')]";

        //Strengthening the Jewelry Industry
        string titleStrengtheningXpath = "//h2[contains(.,'Strengthening the Jewelry Industry')]";
        string infoStrengtheningXpath = "//p[contains(.,'We invest significantly in organizations and tools that benefit the jewelry industry as a whole. Our jewelry business policyholders enjoy free membership in the Jeweler Security Alliance loss prevention organization and access to our online trainings that encourage their continued education. Additionally, we support organizations that promote ethical business practices, like American Gem Society and Jewelers of America.')]";
        string iconStrengtheningXpath = "//img[@alt='jewelry industry illustration']";

        // Initiatives 
        string titleGreenXpath = "//h3[.='Green Initiatives']";
        string infoGreenXpath = "//p[contains(.,'In 2015, Jewelers Mutual installed 408 solar panels on the roof of our main corp')]";
        string iconGreenXpath = "//img[@alt='green initiatives illustration']";
        string iconDepartmentXpath = "//img[@alt='coats illustration']";
        string titleDepartmentXpath = "//h3[.='Department Efforts']";
        string infoDepartmentXpath = "//p[contains(.,'Individual departments are empowered to and often organize their own charitable')]";
        string titleScholarshipsXpath = "//h3[.='Scholarships']";
        string infoScholarshipsXpath = "//p[contains(.,'Our employees’ children are eligible to apply for educational scholarships each')]";
        string linkCommunityXpath = "//a[.='Community Foundation for the Fox Valley Region']";
        string iconScholarshipsXpath = "//img[@alt='scholarship illustration']";

        // Helping Our Employees Help Others
        string titleHelpingOurEmployeesXpath = "//h2[contains(.,'Helping Our Employees Help Others')]";
        string infoHelpingOurEmployeesXpath = "//p[contains(.,'Encouraging and supporting our employees to be socially responsible and involved in our community is a top priority. We can do so much more together.')]";
        string titleGiftMatchXpath = "//h4[contains(.,'Gift Match')]";
        string infoGiftMatchXpath = "//p[contains(.,'Our employees are generous givers. The company amplifies this generosity by matching their charitable donations 50%, to any eligible non-profit, nationwide.')]";
        string titleVolunteerHoursXpath = "//h4[contains(.,'Volunteer Hours')]";
        string infoVolunteerHoursXpath = "//p[contains(.,'All employees are given 12 paid volunteer hours each year and are encouraged to volunteer either individually or as a group through company-organized events.')]";
        string titleCGCXpath = "//h4[contains(.,'Charitable Giving Committee')]";
        string infoCGCXpath = "//p[contains(.,'Our corporate gifting initiatives are employee-lead through a cross-functional team that meets quarterly. The committee decides where our local philanthropic efforts are directed and assures each donation provides a positive impact on our community.')]";

        // Learn More About Us
        string headerLearnMoreXpath = "//h2[.='Learn More About Us']";
        string infoLearnMoreXpath = "//p[contains(.,'While our community contributions are a big deal, it’s also important to know ou')]";
        string btnLearnMoreXpath = "//a[.='LEARN MORE']";

        SocialResponsibility_D_V SocialResponsibility_D_V = new SocialResponsibility_D_V();
        public SocialResponsibility_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify
            VerifyUIElementIsDisplayed(headerSRXpath);
            VerifyUIElementIsDisplayed(infoSRXpath);
            VerifyUIElementIsDisplayed(titleBandTogther2020Xpath);
            VerifyUIElementIsDisplayed(infoBandTogther2020p1Xpath);
            VerifyUIElementIsDisplayed(infoBandTogther2020p2Xpath);
            VerifyUIElementIsDisplayed(iconFeedingAmericaXpath);
            VerifyUIElementIsDisplayed(titleFeedingAmericaXpath);
            VerifyUIElementIsDisplayed(infoFeedingAmericaXpath);
            VerifyUIElementIsDisplayed(iconKidsXpath);
            VerifyUIElementIsDisplayed(titleKidsXpath);
            VerifyUIElementIsDisplayed(infoKidsXpath);
            VerifyUIElementIsDisplayed(iconStandUpXpath);
            VerifyUIElementIsDisplayed(titleStandUpXpath);
            VerifyUIElementIsDisplayed(infoStandUpXpath);
            VerifyUIElementIsDisplayed(infoAddtionalXpath);
            VerifyUIElementIsDisplayed(titleStrengtheningXpath);
            VerifyUIElementIsDisplayed(infoStrengtheningXpath);
            VerifyUIElementIsDisplayed(iconStrengtheningXpath);
            VerifyUIElementIsDisplayed(titleGreenXpath);
            VerifyUIElementIsDisplayed(infoGreenXpath);
            VerifyUIElementIsDisplayed(iconGreenXpath);
            VerifyUIElementIsDisplayed(iconDepartmentXpath);
            VerifyUIElementIsDisplayed(titleDepartmentXpath);
            VerifyUIElementIsDisplayed(infoDepartmentXpath);
            VerifyUIElementIsDisplayed(titleScholarshipsXpath);
            VerifyUIElementIsDisplayed(infoScholarshipsXpath);
            VerifyUIElementIsDisplayed(linkCommunityXpath);
            VerifyUIElementIsDisplayed(iconScholarshipsXpath);
            VerifyUIElementIsDisplayed(titleHelpingOurEmployeesXpath);
            VerifyUIElementIsDisplayed(infoHelpingOurEmployeesXpath);
            VerifyUIElementIsDisplayed(titleGiftMatchXpath);
            VerifyUIElementIsDisplayed(infoGiftMatchXpath);
            VerifyUIElementIsDisplayed(titleVolunteerHoursXpath);
            VerifyUIElementIsDisplayed(infoVolunteerHoursXpath);
            VerifyUIElementIsDisplayed(titleCGCXpath);
            VerifyUIElementIsDisplayed(infoCGCXpath);
            VerifyUIElementIsDisplayed(headerLearnMoreXpath);
            VerifyUIElementIsDisplayed(infoLearnMoreXpath);
            VerifyUIElementIsDisplayed(btnLearnMoreXpath);
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

        public void verifySR()
        {
            //SR Header
            string HeaderSR = driver.FindElement(By.XPath(headerSRXpath)).Text;
            Assert.AreEqual(HeaderSR, SocialResponsibility_D_V.txtHeaderSR, "The Text doesn't match");

            string InfoSR = driver.FindElement(By.XPath(infoSRXpath)).Text;
            Assert.AreEqual(InfoSR, SocialResponsibility_D_V.txtTitleSR, "The Text doesn't match");
        }

        public void verifyBandTogther2020()
        {
            // Strengthening the Jewelry Industry
            string TitleBandTogther2020 = driver.FindElement(By.XPath(titleBandTogther2020Xpath)).Text;
            Assert.AreEqual(TitleBandTogther2020, SocialResponsibility_D_V.txtHeaderBandTogether2020, "The Text doesn't match");

            string InfoBandTogther2020p1 = driver.FindElement(By.XPath(infoBandTogther2020p1Xpath)).Text;
            Assert.AreEqual(InfoBandTogther2020p1, SocialResponsibility_D_V.txtBandTogetherInfo1, "The Text doesn't match");

            string InfoBandTogther2020p2 = driver.FindElement(By.XPath(infoBandTogther2020p2Xpath)).Text;
            Assert.AreEqual(InfoBandTogther2020p2, SocialResponsibility_D_V.txtBandTogetherInfo2, "The Text doesn't match");
        }

        public void verify2020Choices()
        {
            // 2020 Charity Choices
            string TitleFeedingAmerica = driver.FindElement(By.XPath(titleFeedingAmericaXpath)).Text;
            Assert.AreEqual(TitleFeedingAmerica, SocialResponsibility_D_V.txtTitleFeed, "The Text doesn't match");

            string InfoFeedingAmerica = driver.FindElement(By.XPath(infoFeedingAmericaXpath)).Text;
            Assert.AreEqual(InfoFeedingAmerica, SocialResponsibility_D_V.txtInfoFeed, "The Text doesn't match");

            string TitleKids = driver.FindElement(By.XPath(titleKidsXpath)).Text;
            Assert.AreEqual(TitleKids, SocialResponsibility_D_V.txtTitleKids, "The Text doesn't match");

            string InfoKids = driver.FindElement(By.XPath(infoKidsXpath)).Text;
            Assert.AreEqual(InfoKids, SocialResponsibility_D_V.txtInfoKids, "The Text doesn't match");

            string TitleStandUp = driver.FindElement(By.XPath(titleStandUpXpath)).Text;
            Assert.AreEqual(TitleStandUp, SocialResponsibility_D_V.txtTitleStandUp, "The Text doesn't match");

            string InfoStandUp = driver.FindElement(By.XPath(infoStandUpXpath)).Text;
            Assert.AreEqual(InfoStandUp, SocialResponsibility_D_V.txtInfoStandUp, "The Text doesn't match");

            string InfoAddtional = driver.FindElement(By.XPath(infoAddtionalXpath)).Text;
            Assert.AreEqual(InfoAddtional, SocialResponsibility_D_V.txtAddtionalInfo, "The Text doesn't match");

        }

        public void verifyStrengthening()
        {
            // Strengthening the Jewelry Industry

            string TitleStrengthening = driver.FindElement(By.XPath(titleStrengtheningXpath)).Text;
            Assert.AreEqual(TitleStrengthening, SocialResponsibility_D_V.txtTitleStrengthening, "The Text doesn't match");

            string InfoStrengthening = driver.FindElement(By.XPath(infoStrengtheningXpath)).Text;
            Assert.AreEqual(InfoStrengthening, SocialResponsibility_D_V.txtInfoStrengthening, "The Text doesn't match");
        }

        public void verifyInitiatives()
        {
            // Initiatives

            string TitleGreen = driver.FindElement(By.XPath(titleGreenXpath)).Text;
            Assert.AreEqual(TitleGreen, SocialResponsibility_D_V.txtTitleGreen, "The Text doesn't match");

            string InfoGreen = driver.FindElement(By.XPath(infoGreenXpath)).Text;
            Assert.AreEqual(InfoGreen, SocialResponsibility_D_V.txtInfoGreen, "The Text doesn't match");

            string TitleDepartment = driver.FindElement(By.XPath(titleDepartmentXpath)).Text;
            Assert.AreEqual(TitleDepartment, SocialResponsibility_D_V.txtTitleDepartment, "The Text doesn't match");

            string InfoDepartment = driver.FindElement(By.XPath(infoDepartmentXpath)).Text;
            Assert.AreEqual(InfoDepartment, SocialResponsibility_D_V.txtInfoDepartment, "The Text doesn't match");

            string TitleScholarships = driver.FindElement(By.XPath(titleScholarshipsXpath)).Text;
            Assert.AreEqual(TitleScholarships, SocialResponsibility_D_V.txtTitleScholarships, "The Text doesn't match");

            string InfoScholarships = driver.FindElement(By.XPath(infoScholarshipsXpath)).Text;
            Assert.AreEqual(InfoScholarships, SocialResponsibility_D_V.txtInfoScholarships, "The Text doesn't match");

            string LinkCommunity = driver.FindElement(By.XPath(linkCommunityXpath)).Text;
            Assert.AreEqual(LinkCommunity, SocialResponsibility_D_V.hrefCommunity, "The Text doesn't match");

        }

        public void verifyHelpingOthers()
        {
            //Addtional

            string TitleHelpingOurEmployees = driver.FindElement(By.XPath(titleHelpingOurEmployeesXpath)).Text;
            Assert.AreEqual(TitleHelpingOurEmployees, SocialResponsibility_D_V.txtTitleHelpingOurEmployees, "The Text doesn't match");

            string InfoHelpingOurEmployees = driver.FindElement(By.XPath(infoHelpingOurEmployeesXpath)).Text;
            Assert.AreEqual(InfoHelpingOurEmployees, SocialResponsibility_D_V.txtInfoHelpingOurEmployees, "The Text doesn't match");

            string TitleGiftMatch = driver.FindElement(By.XPath(titleGiftMatchXpath)).Text;
            Assert.AreEqual(TitleGiftMatch, SocialResponsibility_D_V.txtTitleGiftMatch, "The Text doesn't match");

            string InfoGiftMatch = driver.FindElement(By.XPath(infoGiftMatchXpath)).Text;
            Assert.AreEqual(InfoGiftMatch, SocialResponsibility_D_V.txtInfoGiftMatch, "The Text doesn't match");

            string TitleVolunteerHours = driver.FindElement(By.XPath(titleVolunteerHoursXpath)).Text;
            Assert.AreEqual(TitleVolunteerHours, SocialResponsibility_D_V.txtTitleVolunteerHours, "The Text doesn't match");

            string InfoVolunteerHours = driver.FindElement(By.XPath(infoVolunteerHoursXpath)).Text;
            Assert.AreEqual(InfoVolunteerHours, SocialResponsibility_D_V.txtInfoVolunteerHours, "The Text doesn't match");

            string TitleCGC = driver.FindElement(By.XPath(titleCGCXpath)).Text;
            Assert.AreEqual(TitleCGC, SocialResponsibility_D_V.txtTitleCGC, "The Text doesn't match");

            string InfoCGC = driver.FindElement(By.XPath(infoCGCXpath)).Text;
            Assert.AreEqual(InfoCGC, SocialResponsibility_D_V.txtInfoCGC, "The Text doesn't match");

        }

        public void verifyLearnMore()
        {
            // Learn More About Us
            string HeaderLearnMore = driver.FindElement(By.XPath(headerLearnMoreXpath)).Text;
            Assert.AreEqual(HeaderLearnMore, SocialResponsibility_D_V.txtHeaderLearnMore, "The Text doesn't match");

            string InfoLearnMore = driver.FindElement(By.XPath(infoLearnMoreXpath)).Text;
            Assert.AreEqual(InfoLearnMore, SocialResponsibility_D_V.txtInfoLearnMore, "The Text doesn't match");

            string BtnLearnMore = driver.FindElement(By.XPath(btnLearnMoreXpath)).Text;
            Assert.AreEqual(BtnLearnMore, SocialResponsibility_D_V.btnLearnMore, "The Text doesn't match");

        }

        public void verifySocialResponsibilityPageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifySR();
            verifyBandTogther2020();
            verify2020Choices();
            verifyStrengthening();
            verifyInitiatives();
            verifyHelpingOthers();
            verifyLearnMore();
        }
    }
}

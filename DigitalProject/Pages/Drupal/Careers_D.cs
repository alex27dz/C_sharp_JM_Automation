using DigitalProject.Pages.Drupal;
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
    public class Careers_D : Page
    {
        // Elements  

        // logo
        string jmLogoCSS = "a[title='Home']";



        // Find Your Future Header
        string headerFindYourFutureXpath = "//h4[text()='FIND YOUR FUTURE']";
        string titleYourCareerXpath = "//h1[text()='Your career at Jewelers Mutual awaits.']";

        // Life At Jewelers Mutual
        string iconLifeAtJMXpath = "//img[@alt ='diamond']";
        string headerLifeAtJMXpath = "//h2[text()='LIFE AT JEWELERS MUTUAL']";
        string infoLifeAtJMXpath = "//p[contains(text(),'We are a growing team of passionate, inspired, empowered professionals. Although')]";

        string iconDynamicXpath = "//img[@alt='chart line']";
        string titleDynamicXpath = "//h4[contains(text(),'RE DYNAMIC')]";
        string infoDynamicXpath = "//p[contains(text(),'The JM culture nurtures innovation and unleashes creativity so you can fuel what')]";
        string iconDrivenXpath = "//img[@alt='star']";
        string titleDrivenXpath = "//h4[contains(text(),'RE DRIVEN')]";
        string infoDrivenXpath = "//p[contains(text(),'Each day, our collaborative and dedicated team pushes to be better. We inspire e')]";
        string iconLoveXpath = "//img[@alt='heart']";
        string titleLoveJewelryXpath = "//h4[contains(text(),'WE LOVE JEWELRY')]";
        string infoLoveJewelryXpath = "//p[contains(text(),'In fact, we love it so much that it')]";




        // Our Benefits
        string iconBenefitsXpath = "//img[@alt ='diamond']";
        string titleBenefitsXpath = "//h2[text()='OUR BENEFITS']";
        string infoBenefitsXpath = "//p[contains(text(),'We believe our people are our greatest assets. With that guiding principle, we a')]";
        string iconCompensationXpath = "//img[@alt='piggy bank']";
        string infoCompensationXpath = "//div[text()='Compensation']";
        string hrefCompensationXpath = "//a[@href='#tabs-1']";
        string iconWellnessXpath = "//img[@alt='piggy bank']";
        string infoWellnessXpath = "//div[text()='Compensation']";
        string hrefWellnessXpath = "//a[@href='#tabs-2']";
        string iconInsuranceXpath = "//img[@alt='leaf']";
        string infoInsuranceXpath = "//div[text()='Wellness']";
        string hrefInsuranceXpath = "//a[@href='#tabs-3']";
        string iconTimeoffXpath = "//img[@alt='shield']";
        string infoTimeoffXpath = "//div[text()='Insurance']";
        string hrefTimeoffXpath = "//a[@href='#tabs-4']";
        string iconAdditionalXpath = "//img[@alt='thumbs up']";
        string infoAdditionalXpath = "//div[text()='Additional']";
        string hrefAdditionalXpath = "//a[@href='#tabs-5']";


        string infoCompensation1Xpath = "//p[contains(text(),'Your compensation doesn’t have to start and end with your salary or hourly pay.')]";
        string infoCompensation2Xpath = "//li[text()='Short Term Incentive (An annual bonus based on business results)']";
        string infoCompensation3Xpath = "//li[text()='401(k) Plan - We match 100% up to first 6% of your contribution']";
        string infoCompensation4Xpath = "//li[contains(.,'Annual Company-Paid Retirement Plan – Equal to an additional 6.5% of your base a')]";
        string imgCompensationXpath = "//img[@alt='family hugging outdoors']";
        //string infoWellness1Xpath = "(//div[@class='tab_section__content']//p)[2]";
        string infoWellness2Xpath = "//li[contains(.,'Onsite Fitness Center (Includes locker room and showers)')]";
        string infoWellness3Xpath = "//li[contains(.,'Full Service 24 Carat Café (Includes nutritious hot and cold breakfast and lunch options at subsidized prices)')]";
        string infoWellness4Xpath = "//li[contains(.,'Monthly Onsite Chair Massages')]";
        string infoWellness5Xpath = "//li[contains(.,'Employee Assistance Program')]";
        string imgWellnessXpath = "//img[@alt='person tying shoe']";

        string infoInsurance1Xpath = "//p[contains(text(),'Above and beyond your monetary compensation, we offer our employees the followin')]";
        string infoInsurance2Xpath = "//li[contains(.,'Medical – PPO plan')]";
        string infoInsurance3Xpath = "//li[contains(.,'Company-Sponsored Health Advocacy and Telehealth Resources')]";
        string infoInsurance4Xpath = "//li[contains(.,'Dental')]";
        string infoInsurance5Xpath = "//li[contains(.,'Vision')]";
        string infoInsurance6Xpath = "//li[contains(.,'Flexible Spending Account')]";
        string infoInsurance7Xpath = "//li[contains(.,'Company-Paid Life Insurance')]";
        string infoInsurance8Xpath = "//li[contains(.,'Company-Paid Short and Long Term Disability')]";
        string imgInsuranceXpath = "//img[@alt='couple pushing a stroller']";

        string infoTimeoff1Xpath = "//p[contains(text(),'We have a passion for what we do in the office and out, putting a high value on')]";
        string infoTimeoff2Xpath = "//li[contains(.,'21 days of Paid Time Off for new employees')]";
        string infoTimeoff3Xpath = "//li[contains(.,'Paid Holidays')]";
        string infoTimeoff4Xpath = "//li[contains(.,'Paid Volunteering Hours')]";
        string infoTimeoff5Xpath = "//li[contains(.,'Paid Parental Leave')]";
        string imgTimeoffXpath = "//img[@alt='group of people smiling outdoors']";

        string infoAdditional1Xpath = "//p[contains(text(),'Because traditional benefits are not enough, we take it one step further. We kee')]";
        string infoAdditional2Xpath = "//li[text()='Various employee events']";
        string infoAdditional3Xpath = "//li[text()='Education Expense Reimbursement Program']";
        string infoAdditional4Xpath = "//li[text()='Charitable Giving Gift Match']";
        string infoAdditional5Xpath = "//li[text()='Onsite Mail/Shipping Services (Home office only)']";
        string infoAdditional6Xpath = "//li[text()='Onsite Dry Cleaning Service']";
        string infoAdditional7Xpath = "//li[text()='Dependent Scholarship Program']";
        string infoAdditional8Xpath = "//li[text()='Adoption Financial Assistance']";
        string imgAdditionalXpath = "//img[@alt='three generations smiling']";

        // JM Employees Scrolling Bar

        string quoteAngelaXpath = "//div[contains(text(),'Jewelers Mutual does a wonderful job recognizing individual contributions and making each ')]";
        string nameAngelaXpath = "//div[text()='Angela Vogel ']";
        string roleAngelaXpath = "//div[text()='Program Analyst, Products and Risk Management']";
        string quoteDrewXpath = "//div[contains(text(),'The culture at JM is what excites me about my career. The understanding and caring that each ')]";
        string nameDrewXpath = "//div[text()='Drew Demerath ']";
        string roleDrewXpath = "//div[text()='Senior Software Engineer, Information Technology ']";
        string quoteKelseyXpath = "//div[contains(text(),'When I came to JM, I had no idea there would be so many additional benefits to enjoy.')]";
        string nameKelseyXpath = "//div[text()='Kelsey McElrath ']";
        string roleKelseyXpath = "//div[text()='Corporate Communications Specialist, Human Resources']";
        string quoteLauraXpath = "//div[contains(text(),'The wellness events are great to interact with your team in different ways and giving company time to be healthy!')]";
        string nameLauraXpath = "//div[text()='Laura Ronk']";
        string roleLauraXpath = "//div[text()='Product Manager, Information Technology']";
        string quoteLydiaXpath = "//div[contains(text(),'My favorite part about working at Jewelers Mutual is the fun atmosphere.')]";
        string nameLydiaXpath = "//div[text()='Lydia Schneider']";
        string roleLydiaXpath = "//div[text()='Software Engineer II, Information Technology']";
        string quoteMarkXpath = "//div[contains(text(),'I think the culture is one of curious, engaged people who are committed to continuing and building ')]";
        string nameMarkXpath = "//div[text()='Mark Willson']";
        string roleMarkXpath = "//div[text()='VP General Counsel, Executive']";
        string quoteOsngXpath = "//div[contains(text(),'The fun health-related activities/challenges that JM promotes show that they make efforts to be inclusive.')]";
        string nameOsngXpath = "//div[text()='Osng Kwon']";
        string roleOsngXpath = "//div[text()='Actuarial Supervisor, Actuarial Services']";
        string quotePhilXpath = "//div[contains(text(),'JM represents a company that is growing and, with it, provides great opportunities to its employees to really grow with it as well as ')]";
        string namePhilXpath = "//div[text()='Phil Nickolai']";
        string rolePhilXpath = "//div[text()='Director of Vendor Management, Information Technology']";

        // Hiring Process
        string iconHiringProcessXpath = "//img[@alt='diamond']";
        string titleHiringProcessXpath = "//h2[text()='Hiring Process']";
        string infoHiringProcessXpath = "//p[contains(text(),'Looking for the right position can be daunting as well as a considerable time co')]";

        string imgApplicationXpath = "//img[@alt='clipboard']";
        string imgcellphoneXpath = "//img[@alt='cell phone']";
        string imgOnsiteInterviewXpath = "//img[@alt='chat bubbles']";
        string imgBackgroundCheckXpath = "//img[@alt='lock']";


        string divApplicaitonXpath = "//div[text()='Application']";
        string titleApplicationXpath = "//h3[.='APPLICATION']";
        string infoApplicationXpath = "//p[contains(text(),'If you found the right job for you, the first step is to apply. We encourage all')]";
        string divPhoneInterviewXpath = "//div[text()='Phone Interview']";
        string infoPhoneInterviewXpath = "//p[contains(text(),'Qualified applicants will first be scheduled for a phone interview with our recr')]";
        string divOnsiteInterviewXpath = "//div[text()='Onsite Interview']";
        string infoOnsiteInterviewXpath = "//p[contains(text(),'Jewelers Mutual fosters a collaborative culture and we take a team approach to o')]";
        string divBackgroundCheckXpath = "//div[text()='Background Check']";
        string infoBackgroundCheckXpath = "//p[contains(text(),'Once you accept the position, we conduct a pre-employment background check and d')]";


        // Start Your JM Career
        string titleCareerXpath = "//h2[text()='Start Your JM Career']";
        string infoCareerXpath = "//p[contains(text(),'Apply directly for one of our open positions or create a presence to be notified')]";
        string btnViewAllOppXpath = "//a[text()='View All Opportunities']";

        // Our Location
        string titleOurLocationXpath = "//h2[text()='Our Location']";
        string infoOurLocation1Xpath = "//strong[contains(text(),'HEADQUARTERS')]";
        string infoOurLocation2Xpath = "//p[contains(text(),'Jewelers Mutual is part of the beautiful Fox Valley region located in Neenah')]";
        string infoOurLocation3Xpath = "//p[contains(text(),'The Fox Valley provides big city entertainment in a family-friendly community. J')]";
        string infoOurLocation4Xpath = "//p[contains(text(),'With a variety of chain and independent restaurants, plenty of green space, park')]";

        // Contact 
        string titleContactXpath = "//h3[text()='Contact']";
        string infoAdressXpath = "//p[text()='Jewelers Mutual']";
        string emailHRXpath = "//a[contains(.,'humanresources@jminsure.com')]";
        string iconClockXpath = "//img[@alt='clock']";
        string iconPhoneXpath = "//img[@alt='cell phone']";
        string infoHours1Xpath = "//h5[text()='Hours']";
        string infoPhone1Xpath = "//h5[text()='Phone']";
        string infoHours2Xpath = "//p[text()='M-F 8am - 6pm CST']";
        string hrefPhone2Xpath = "//a[text()='800-558-6411']";

        // Talk to us
        string headerTalktousXpath = "//h2[text()='Talk to us']";
        string infoNameXpath = "//label[text()='Name']";
        string infoEmailAddressXpath = "//label[text()='Email Address']";
        string infoPhoneNumberXpath = "//label[text()='Phone Number']";
        string infoMessageXpath = "//label[text()='Message']";
        string captchaXpath = "//div[@id='rc-anchor-container']";
        string btnSendMessageXpath = "//input[@id='edit-actions-submit']";

        Careers_D_V careers_D_V = new Careers_D_V();
        public Careers_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {

            VerifyUIElementIsDisplayed(headerFindYourFutureXpath);
            VerifyUIElementIsDisplayed(titleYourCareerXpath);
            VerifyUIElementIsDisplayed(iconLifeAtJMXpath);
            VerifyUIElementIsDisplayed(headerLifeAtJMXpath);
            VerifyUIElementIsDisplayed(infoLifeAtJMXpath);
            VerifyUIElementIsDisplayed(iconDynamicXpath);
            VerifyUIElementIsDisplayed(titleDynamicXpath);
            VerifyUIElementIsDisplayed(infoDynamicXpath);
            VerifyUIElementIsDisplayed(iconDrivenXpath);
            VerifyUIElementIsDisplayed(titleDrivenXpath);
            VerifyUIElementIsDisplayed(infoDrivenXpath);
            VerifyUIElementIsDisplayed(iconLoveXpath);
            VerifyUIElementIsDisplayed(titleLoveJewelryXpath);
            VerifyUIElementIsDisplayed(infoLoveJewelryXpath);


            VerifyUIElementIsDisplayed(iconBenefitsXpath);
            VerifyUIElementIsDisplayed(titleBenefitsXpath);
            VerifyUIElementIsDisplayed(infoBenefitsXpath);
            VerifyUIElementIsDisplayed(iconCompensationXpath);
            VerifyUIElementIsDisplayed(infoCompensationXpath);
            VerifyUIElementIsDisplayed(hrefCompensationXpath);
            VerifyUIElementIsDisplayed(iconWellnessXpath);
            VerifyUIElementIsDisplayed(infoWellnessXpath);
            VerifyUIElementIsDisplayed(hrefWellnessXpath);
            VerifyUIElementIsDisplayed(iconInsuranceXpath);
            VerifyUIElementIsDisplayed(infoInsuranceXpath);
            VerifyUIElementIsDisplayed(hrefInsuranceXpath);
            VerifyUIElementIsDisplayed(iconTimeoffXpath);
            VerifyUIElementIsDisplayed(infoTimeoffXpath);

            VerifyUIElementIsDisplayed(hrefTimeoffXpath);
            VerifyUIElementIsDisplayed(iconAdditionalXpath);
            VerifyUIElementIsDisplayed(infoAdditionalXpath);
            VerifyUIElementIsDisplayed(hrefAdditionalXpath);


            VerifyUIElementIsDisplayed(infoCompensation1Xpath);
            VerifyUIElementIsDisplayed(infoCompensation2Xpath);
            VerifyUIElementIsDisplayed(infoCompensation3Xpath);
            VerifyUIElementIsDisplayed(infoCompensation4Xpath);
            VerifyUIElementIsDisplayed(imgCompensationXpath);

            VerifyUIElementIsDisplayed(quoteAngelaXpath);
            VerifyUIElementIsDisplayed(nameAngelaXpath);
            VerifyUIElementIsDisplayed(roleAngelaXpath);
            VerifyUIElementIsDisplayed(quoteDrewXpath);
            VerifyUIElementIsDisplayed(nameDrewXpath);
            VerifyUIElementIsDisplayed(roleDrewXpath);
            VerifyUIElementIsDisplayed(quoteKelseyXpath);
            VerifyUIElementIsDisplayed(nameKelseyXpath);
            VerifyUIElementIsDisplayed(roleKelseyXpath);
            VerifyUIElementIsDisplayed(quoteLauraXpath);
            VerifyUIElementIsDisplayed(nameLauraXpath);
            VerifyUIElementIsDisplayed(roleLauraXpath);
            VerifyUIElementIsDisplayed(quoteLydiaXpath);
            VerifyUIElementIsDisplayed(nameLydiaXpath);
            VerifyUIElementIsDisplayed(roleLydiaXpath);
            VerifyUIElementIsDisplayed(quoteMarkXpath);
            VerifyUIElementIsDisplayed(nameMarkXpath);
            VerifyUIElementIsDisplayed(roleMarkXpath);
            VerifyUIElementIsDisplayed(quoteOsngXpath);
            VerifyUIElementIsDisplayed(nameOsngXpath);
            VerifyUIElementIsDisplayed(roleOsngXpath);
            VerifyUIElementIsDisplayed(quotePhilXpath);
            VerifyUIElementIsDisplayed(namePhilXpath);
            VerifyUIElementIsDisplayed(rolePhilXpath);

            VerifyUIElementIsDisplayed(iconHiringProcessXpath);
            VerifyUIElementIsDisplayed(titleHiringProcessXpath);
            VerifyUIElementIsDisplayed(infoHiringProcessXpath);
            VerifyUIElementIsDisplayed(imgApplicationXpath);
            VerifyUIElementIsDisplayed(imgcellphoneXpath);
            VerifyUIElementIsDisplayed(imgOnsiteInterviewXpath);
            VerifyUIElementIsDisplayed(imgBackgroundCheckXpath);
            VerifyUIElementIsDisplayed(divApplicaitonXpath);
            VerifyUIElementIsDisplayed(titleApplicationXpath);
            VerifyUIElementIsDisplayed(infoApplicationXpath);
            VerifyUIElementIsDisplayed(divPhoneInterviewXpath);
            VerifyUIElementIsDisplayed(infoPhoneInterviewXpath);
            VerifyUIElementIsDisplayed(divOnsiteInterviewXpath);
            VerifyUIElementIsDisplayed(infoOnsiteInterviewXpath);
            VerifyUIElementIsDisplayed(divBackgroundCheckXpath);
            VerifyUIElementIsDisplayed(infoBackgroundCheckXpath);

            VerifyUIElementIsDisplayed(titleCareerXpath);
            VerifyUIElementIsDisplayed(infoCareerXpath);
            VerifyUIElementIsDisplayed(btnViewAllOppXpath);
            VerifyUIElementIsDisplayed(titleOurLocationXpath);
            VerifyUIElementIsDisplayed(infoOurLocation1Xpath);
            VerifyUIElementIsDisplayed(infoOurLocation2Xpath);
            VerifyUIElementIsDisplayed(infoOurLocation3Xpath);
            VerifyUIElementIsDisplayed(infoOurLocation4Xpath);
            VerifyUIElementIsDisplayed(titleContactXpath);
            VerifyUIElementIsDisplayed(infoAdressXpath);
            VerifyUIElementIsDisplayed(emailHRXpath);
            VerifyUIElementIsDisplayed(iconClockXpath);
            VerifyUIElementIsDisplayed(iconPhoneXpath);
            VerifyUIElementIsDisplayed(infoHours1Xpath);
            VerifyUIElementIsDisplayed(infoPhone1Xpath);
            VerifyUIElementIsDisplayed(infoHours2Xpath);
            VerifyUIElementIsDisplayed(hrefPhone2Xpath);
            VerifyUIElementIsDisplayed(headerTalktousXpath);
            VerifyUIElementIsDisplayed(infoNameXpath);
            VerifyUIElementIsDisplayed(infoEmailAddressXpath);
            VerifyUIElementIsDisplayed(infoPhoneNumberXpath);
            VerifyUIElementIsDisplayed(infoMessageXpath);
            //VerifyUIElementIsDisplayed(captchaXpath);
            VerifyUIElementIsDisplayed(btnSendMessageXpath);



        }



        public override void WaitForLoad()
        {
            WaitForPageLoad(driver);
            VerifyUIElementIsDisplayed(jmLogoCSS);
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

        public void verifyCarrersPageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyFindYourFuture();
            verifyLifeAtJM();
            verifyOurBenefits();
            verifyJMEmployeesScrollingBar();
            verifyHiringProcess();
            verifyStartYourCareeratJM();
            verifyContact();
            verifyOurLocation();
            verifyTalktoUs();
        }

        public void verifyFindYourFuture()
        {
            // Find Your Future Header
            string HeaderFindYourFuture = driver.FindElement(By.XPath(headerFindYourFutureXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderFindYourFuture.ToLower().Trim(), careers_D_V.txtHeaderFindYourFuture.ToLower().Trim(), "The Text doesn't match");

            string TitleYourCareer = driver.FindElement(By.XPath(titleYourCareerXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleYourCareer.ToLower().Trim(), careers_D_V.txtTitleYourCareer.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyLifeAtJM()
        {
            // Life At Jewelers Mutual
            string HeaderLifeAtJM = driver.FindElement(By.XPath(headerLifeAtJMXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderLifeAtJM.ToLower().Trim(), careers_D_V.txtHeaderLifeAtJM.ToLower().Trim(), "The Text doesn't match");

            string InfoLifeAtJM = driver.FindElement(By.XPath(infoLifeAtJMXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoLifeAtJM.ToLower().Trim(), careers_D_V.txtInfoLifeAtJM.ToLower().Trim(), "The Text doesn't match");

            string TitleDynamic = driver.FindElement(By.XPath(titleDynamicXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDynamic.ToLower().Trim(), careers_D_V.txtTitleDynamic.ToLower().Trim(), "The Text doesn't match");

            string InfoDynamic = driver.FindElement(By.XPath(infoDynamicXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDynamic.ToLower().Trim(), careers_D_V.txtInfoDynamic.ToLower().Trim(), "The Text doesn't match");

            string TitleDriven = driver.FindElement(By.XPath(titleDrivenXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleDriven.ToLower().Trim(), careers_D_V.txtTitleDriven.ToLower().Trim(), "The Text doesn't match");

            string InfoDriven = driver.FindElement(By.XPath(infoDrivenXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDriven.ToLower().Trim(), careers_D_V.txtInfoDriven.ToLower().Trim(), "The Text doesn't match");

            string TitleLoveJewelry = driver.FindElement(By.XPath(titleLoveJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleLoveJewelry.ToLower().Trim(), careers_D_V.txtTitleLoveJewelry.ToLower().Trim(), "The Text doesn't match");

            string InfoLoveJewelry = driver.FindElement(By.XPath(infoLoveJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoLoveJewelry.ToLower().Trim(), careers_D_V.txtInfoLoveJewelry.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyOurBenefits()
        {
            // Our Benefits
            string TitleBenefits = driver.FindElement(By.XPath(titleBenefitsXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleBenefits.ToLower().Trim(), careers_D_V.txtTitleBenefits.ToLower().Trim(), "The Text doesn't match");

            string InfoBenefits = driver.FindElement(By.XPath(infoBenefitsXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBenefits.ToLower().Trim(), careers_D_V.txtInfoBenefits.ToLower().Trim(), "The Text doesn't match");

            string HrefCompensation = driver.FindElement(By.XPath(hrefCompensationXpath)).GetAttribute("innerText");
            Assert.AreEqual(HrefCompensation.ToLower().Trim(), careers_D_V.hrefCompensation.ToLower().Trim(), "The Text doesn't match");

            string InfoCompensation1 = driver.FindElement(By.XPath(infoCompensation1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCompensation1.ToLower().Trim(), careers_D_V.txtInfoCompensation1.ToLower().Trim(), "The Text doesn't match");

            string InfoCompensation2 = driver.FindElement(By.XPath(infoCompensation2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCompensation2.ToLower().Trim(), careers_D_V.txtInfoCompensation2.ToLower().Trim(), "The Text doesn't match");

            string InfoCompensation3 = driver.FindElement(By.XPath(infoCompensation3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCompensation3.ToLower().Trim(), careers_D_V.txtInfoCompensation3.ToLower().Trim(), "The Text doesn't match");

            string InfoCompensation4 = driver.FindElement(By.XPath(infoCompensation4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCompensation4.ToLower().Trim(), careers_D_V.txtInfoCompensation4.ToLower().Trim(), "The Text doesn't match");

            VerifyUIElementIsDisplayed(imgCompensationXpath);

            JavaScriptClick(driver.FindElement(By.XPath("//a[@href = '#tabs-2']")));
            pause();
            string HrefWellness = driver.FindElement(By.XPath(hrefWellnessXpath)).GetAttribute("innerText");
            Assert.AreEqual(HrefWellness.ToLower().Trim(), careers_D_V.hrefWellness.ToLower().Trim(), "The Text doesn't match");

            //string InfoWellness1 = driver.FindElement(By.XPath(infoWellness1Xpath)).GetAttribute("innerText");
            //Assert.AreEqual(InfoWellness1.ToLower().Trim(), careers_D_V.txtInfoWellness1.ToLower().Trim(), "The Text doesn't match");

            string InfoWellness2 = driver.FindElement(By.XPath(infoWellness2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWellness2.ToLower().Trim(), careers_D_V.txtInfoWellness2.ToLower().Trim(), "The Text doesn't match");

            string InfoWellness3 = driver.FindElement(By.XPath(infoWellness3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWellness3.ToLower().Trim(), careers_D_V.txtInfoWellness3.ToLower().Trim(), "The Text doesn't match");

            string InfoWellness4 = driver.FindElement(By.XPath(infoWellness4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWellness4.ToLower().Trim(), careers_D_V.txtInfoWellness4.ToLower().Trim(), "The Text doesn't match");

            string InfoWellness5 = driver.FindElement(By.XPath(infoWellness5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWellness5.ToLower().Trim(), careers_D_V.txtInfoWellness5.ToLower().Trim(), "The Text doesn't match");

            VerifyUIElementIsDisplayed(imgWellnessXpath);

            JavaScriptClick(driver.FindElement(By.XPath("//a[@href = '#tabs-3']")));
            pause();

            string HrefInsurance = driver.FindElement(By.XPath(hrefInsuranceXpath)).GetAttribute("innerText");
            Assert.AreEqual(HrefInsurance.ToLower().Trim(), careers_D_V.hrefInsurance.ToLower().Trim(), "The Text doesn't match");

            string InfoInsurance1 = driver.FindElement(By.XPath(infoInsurance1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoInsurance1.ToLower().Trim(), careers_D_V.txtInfoInsurance1.ToLower().Trim(), "The Text doesn't match");

            string InfoInsurance2 = driver.FindElement(By.XPath(infoInsurance2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoInsurance2.ToLower().Trim(), careers_D_V.txtInfoInsurance2.ToLower().Trim(), "The Text doesn't match");

            string InfoInsurance3 = driver.FindElement(By.XPath(infoInsurance3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoInsurance3.ToLower().Trim(), careers_D_V.txtInfoInsurance3.ToLower().Trim(), "The Text doesn't match");

            string InfoInsurance4 = driver.FindElement(By.XPath(infoInsurance4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoInsurance4.ToLower().Trim(), careers_D_V.txtInfoInsurance4.ToLower().Trim(), "The Text doesn't match");

            string InfoInsurance5 = driver.FindElement(By.XPath(infoInsurance5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoInsurance5.ToLower().Trim(), careers_D_V.txtInfoInsurance5.ToLower().Trim(), "The Text doesn't match");

            string InfoInsurance6 = driver.FindElement(By.XPath(infoInsurance6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoInsurance6.ToLower().Trim(), careers_D_V.txtInfoInsurance6.ToLower().Trim(), "The Text doesn't match");

            string InfoInsurance7 = driver.FindElement(By.XPath(infoInsurance7Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoInsurance7.ToLower().Trim(), careers_D_V.txtInfoInsurance7.ToLower().Trim(), "The Text doesn't match");

            string InfoInsurance8 = driver.FindElement(By.XPath(infoInsurance8Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoInsurance8.ToLower().Trim(), careers_D_V.txtInfoInsurance8.ToLower().Trim(), "The Text doesn't match");

            VerifyUIElementIsDisplayed(imgInsuranceXpath);

            JavaScriptClick(driver.FindElement(By.XPath("//a[@href = '#tabs-4']")));
            pause();

            string HrefTimeoff = driver.FindElement(By.XPath(hrefTimeoffXpath)).GetAttribute("innerText");
            Assert.AreEqual(HrefTimeoff.ToLower().Trim(), careers_D_V.hrefTimeoff.ToLower().Trim(), "The Text doesn't match");

            string InfoTimeoff1 = driver.FindElement(By.XPath(infoTimeoff1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTimeoff1.ToLower().Trim(), careers_D_V.txtInfoTimeoff1.ToLower().Trim(), "The Text doesn't match");

            string InfoTimeoff2 = driver.FindElement(By.XPath(infoTimeoff2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTimeoff2.ToLower().Trim(), careers_D_V.txtInfoTimeoff2.ToLower().Trim(), "The Text doesn't match");

            string InfoTimeoff3 = driver.FindElement(By.XPath(infoTimeoff3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTimeoff3.ToLower().Trim(), careers_D_V.txtInfoTimeoff3.ToLower().Trim(), "The Text doesn't match");

            string InfoTimeoff4 = driver.FindElement(By.XPath(infoTimeoff4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTimeoff4.ToLower().Trim(), careers_D_V.txtInfoTimeoff4.ToLower().Trim(), "The Text doesn't match");

            string InfoTimeoff5 = driver.FindElement(By.XPath(infoTimeoff5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoTimeoff5.ToLower().Trim(), careers_D_V.txtInfoTimeoff5.ToLower().Trim(), "The Text doesn't match");

            VerifyUIElementIsDisplayed(imgTimeoffXpath);

            JavaScriptClick(driver.FindElement(By.XPath("//a[@href = '#tabs-5']")));
            pause();

            string HrefAdditional = driver.FindElement(By.XPath(hrefAdditionalXpath)).GetAttribute("innerText");
            Assert.AreEqual(HrefAdditional.ToLower().Trim(), careers_D_V.hrefAdditional.ToLower().Trim(), "The Text doesn't match");

            string InfoAdditional1 = driver.FindElement(By.XPath(infoAdditional1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdditional1.ToLower().Trim(), careers_D_V.txtInfoAdditional1.ToLower().Trim(), "The Text doesn't match");

            string InfoAdditional2 = driver.FindElement(By.XPath(infoAdditional2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdditional2.ToLower().Trim(), careers_D_V.txtInfoAdditional2.ToLower().Trim(), "The Text doesn't match");

            string InfoAdditional3 = driver.FindElement(By.XPath(infoAdditional3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdditional3.ToLower().Trim(), careers_D_V.txtInfoAdditional3.ToLower().Trim(), "The Text doesn't match");

            string InfoAdditional4 = driver.FindElement(By.XPath(infoAdditional4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdditional4.ToLower().Trim(), careers_D_V.txtInfoAdditional4.ToLower().Trim(), "The Text doesn't match");

            string InfoAdditional5 = driver.FindElement(By.XPath(infoAdditional5Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdditional5.ToLower().Trim(), careers_D_V.txtInfoAdditional5.ToLower().Trim(), "The Text doesn't match");

            string InfoAdditional6 = driver.FindElement(By.XPath(infoAdditional6Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdditional6.ToLower().Trim(), careers_D_V.txtInfoAdditional6.ToLower().Trim(), "The Text doesn't match");

            string InfoAdditional7 = driver.FindElement(By.XPath(infoAdditional7Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdditional7.ToLower().Trim(), careers_D_V.txtInfoAdditional7.ToLower().Trim(), "The Text doesn't match");

            string InfoAdditional8 = driver.FindElement(By.XPath(infoAdditional8Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAdditional8.ToLower().Trim(), careers_D_V.txtInfoAdditional8.ToLower().Trim(), "The Text doesn't match");

            VerifyUIElementIsDisplayed(imgAdditionalXpath);

            JavaScriptClick(driver.FindElement(By.XPath("//a[@href = '#tabs-1']")));
            pause();
        }

        public void verifyJMEmployeesScrollingBar()
        {
            // JM Employees Scrolling Bar

            string QuoteAngela = driver.FindElement(By.XPath(quoteAngelaXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuoteAngela.ToLower().Trim(), careers_D_V.quoteAngela.ToLower().Trim(), "The Text doesn't match");

            string NameAngela = driver.FindElement(By.XPath(nameAngelaXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameAngela.ToLower().Trim(), careers_D_V.nameAngela.ToLower().Trim(), "The Text doesn't match");

            string RoleAngela = driver.FindElement(By.XPath(roleAngelaXpath)).GetAttribute("innerText");
            Assert.AreEqual(RoleAngela.ToLower().Trim(), careers_D_V.roleAngela.ToLower().Trim(), "The Text doesn't match");

            string QuoteDrew = driver.FindElement(By.XPath(quoteDrewXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuoteDrew.ToLower().Trim(), careers_D_V.quoteDrew.ToLower().Trim(), "The Text doesn't match");

            string NameDrew = driver.FindElement(By.XPath(nameDrewXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameDrew.ToLower().Trim(), careers_D_V.nameDrew.ToLower().Trim(), "The Text doesn't match");

            string RoleDrew = driver.FindElement(By.XPath(roleDrewXpath)).GetAttribute("innerText");
            Assert.AreEqual(RoleDrew.ToLower().Trim(), careers_D_V.roleDrew.ToLower().Trim(), "The Text doesn't match");

            string QuoteKelsey = driver.FindElement(By.XPath(quoteKelseyXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuoteKelsey.ToLower().Trim(), careers_D_V.quoteKelsey.ToLower().Trim(), "The Text doesn't match");

            string NameKelsey = driver.FindElement(By.XPath(nameKelseyXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameKelsey.ToLower().Trim(), careers_D_V.nameKelsey.ToLower().Trim(), "The Text doesn't match");

            string RoleKelsey = driver.FindElement(By.XPath(roleKelseyXpath)).GetAttribute("innerText");
            Assert.AreEqual(RoleKelsey.ToLower().Trim(), careers_D_V.roleKelsey.ToLower().Trim(), "The Text doesn't match");

            string QuoteLaura = driver.FindElement(By.XPath(quoteLauraXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuoteLaura.ToLower().Trim(), careers_D_V.quoteLaura.ToLower().Trim(), "The Text doesn't match");

            string NameLaura = driver.FindElement(By.XPath(nameLauraXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameLaura.ToLower().Trim(), careers_D_V.nameLaura.ToLower().Trim(), "The Text doesn't match");

            string RoleLaura = driver.FindElement(By.XPath(roleLauraXpath)).GetAttribute("innerText");
            Assert.AreEqual(RoleLaura.ToLower().Trim(), careers_D_V.roleLaura.ToLower().Trim(), "The Text doesn't match");

            string QuoteLydia = driver.FindElement(By.XPath(quoteLydiaXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuoteLydia.ToLower().Trim(), careers_D_V.quoteLydia.ToLower().Trim(), "The Text doesn't match");

            string NameLydia = driver.FindElement(By.XPath(nameLydiaXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameLydia.ToLower().Trim(), careers_D_V.nameLydia.ToLower().Trim(), "The Text doesn't match");

            string RoleLydiaXpath = driver.FindElement(By.XPath(roleLydiaXpath)).GetAttribute("innerText");
            Assert.AreEqual(RoleLydiaXpath.ToLower().Trim(), careers_D_V.roleLydia.ToLower().Trim(), "The Text doesn't match");

            string QuoteMark = driver.FindElement(By.XPath(quoteMarkXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuoteMark.ToLower().Trim(), careers_D_V.quoteMark.ToLower().Trim(), "The Text doesn't match");

            string NameMark = driver.FindElement(By.XPath(nameMarkXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameMark.ToLower().Trim(), careers_D_V.nameMark.ToLower().Trim(), "The Text doesn't match");

            string RoleMark = driver.FindElement(By.XPath(roleMarkXpath)).GetAttribute("innerText");
            Assert.AreEqual(RoleMark.ToLower().Trim(), careers_D_V.roleMark.ToLower().Trim(), "The Text doesn't match");

            string QuoteOsng = driver.FindElement(By.XPath(quoteOsngXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuoteOsng.ToLower().Trim(), careers_D_V.quoteOsng.ToLower().Trim(), "The Text doesn't match");

            string NameOsng = driver.FindElement(By.XPath(nameOsngXpath)).GetAttribute("innerText");
            Assert.AreEqual(NameOsng.ToLower().Trim(), careers_D_V.nameOsng.ToLower().Trim(), "The Text doesn't match");

            string RoleOsng = driver.FindElement(By.XPath(roleOsngXpath)).GetAttribute("innerText");
            Assert.AreEqual(RoleOsng.ToLower().Trim(), careers_D_V.roleOsng.ToLower().Trim(), "The Text doesn't match");

            string QuotePhil = driver.FindElement(By.XPath(quotePhilXpath)).GetAttribute("innerText");
            Assert.AreEqual(QuotePhil.ToLower().Trim(), careers_D_V.quotePhil.ToLower().Trim(), "The Text doesn't match");

            string NamePhil = driver.FindElement(By.XPath(namePhilXpath)).GetAttribute("innerText");
            Assert.AreEqual(NamePhil.ToLower().Trim(), careers_D_V.namePhil.ToLower().Trim(), "The Text doesn't match");

            string RolePhil = driver.FindElement(By.XPath(rolePhilXpath)).GetAttribute("innerText");
            Assert.AreEqual(RolePhil.ToLower().Trim(), careers_D_V.rolePhil.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyHiringProcess()
        {
            // Hiring Process

            string TitleHiringProcess = driver.FindElement(By.XPath(titleHiringProcessXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleHiringProcess.ToLower().Trim(), careers_D_V.txtTitleHiringProcess.ToLower().Trim(), "The Text doesn't match");

            string InfoHiringProcess = driver.FindElement(By.XPath(infoHiringProcessXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHiringProcess.ToLower().Trim(), careers_D_V.txtInfoHiringProcess.ToLower().Trim(), "The Text doesn't match");

            string DivApplicaiton = driver.FindElement(By.XPath(divApplicaitonXpath)).GetAttribute("innerText");
            Assert.AreEqual(DivApplicaiton.ToLower().Trim(), careers_D_V.txtApplicaiton.ToLower().Trim(), "The Text doesn't match");

            string TitleApplication = driver.FindElement(By.XPath(titleApplicationXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleApplication.ToLower().Trim(), careers_D_V.txtTitleApplication.ToLower().Trim(), "The Text doesn't match");

            string InfoApplication = driver.FindElement(By.XPath(infoApplicationXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoApplication.ToLower().Trim(), careers_D_V.txtInfoApplication.ToLower().Trim(), "The Text doesn't match");

            string DivPhoneInterview = driver.FindElement(By.XPath(divPhoneInterviewXpath)).GetAttribute("innerText");
            Assert.AreEqual(DivPhoneInterview.ToLower().Trim(), careers_D_V.txtPhoneInterview.ToLower().Trim(), "The Text doesn't match");

            string InfoPhoneInterview = driver.FindElement(By.XPath(infoPhoneInterviewXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoPhoneInterview.ToLower().Trim(), careers_D_V.txtInfoPhoneInterview.ToLower().Trim(), "The Text doesn't match");

            string DivOnsiteInterview = driver.FindElement(By.XPath(divOnsiteInterviewXpath)).GetAttribute("innerText");
            Assert.AreEqual(DivOnsiteInterview.ToLower().Trim(), careers_D_V.txtOnsiteInterview.ToLower().Trim(), "The Text doesn't match");

            string InfoOnsiteInterview = driver.FindElement(By.XPath(infoOnsiteInterviewXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoOnsiteInterview.ToLower().Trim(), careers_D_V.txtInfoOnsiteInterview.ToLower().Trim(), "The Text doesn't match");

            string DivBackgroundCheck = driver.FindElement(By.XPath(divBackgroundCheckXpath)).GetAttribute("innerText");
            Assert.AreEqual(DivBackgroundCheck.ToLower().Trim(), careers_D_V.txtBackgroundCheck.ToLower().Trim(), "The Text doesn't match");

            string InfoBackgroundCheck = driver.FindElement(By.XPath(infoBackgroundCheckXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoBackgroundCheck.ToLower().Trim(), careers_D_V.txtInfoBackgroundCheck.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyStartYourCareeratJM()
        {
            // Start Your JM Career

            string TitleCareer = driver.FindElement(By.XPath(titleCareerXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleCareer.ToLower().Trim(), careers_D_V.txtTitleCareer.ToLower().Trim(), "The Text doesn't match");

            string InfoCareer = driver.FindElement(By.XPath(infoCareerXpath)).GetAttribute("innerText");
            InfoCareer = InfoCareer.Replace(System.Environment.NewLine, "");
            Assert.AreEqual(InfoCareer.ToLower().Trim(), careers_D_V.txtInfoCareer.ToLower().Trim(), "The Text doesn't match");

            string BtnViewAllOpp = driver.FindElement(By.XPath(btnViewAllOppXpath)).GetAttribute("innerText");
            Assert.AreEqual(BtnViewAllOpp.ToLower().Trim(), careers_D_V.btnViewAllOpp.ToLower().Trim(), "The Text doesn't match");

        }

        public void verifyOurLocation()
        {
            // Our Location

            string TitleOurLocation = driver.FindElement(By.XPath(titleOurLocationXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleOurLocation.ToLower().Trim(), careers_D_V.txtTitleOurLocation.ToLower().Trim(), "The Text doesn't match");

            string InfoOurLocation1 = driver.FindElement(By.XPath(infoOurLocation1Xpath)).GetAttribute("innerText");
            InfoOurLocation1 = InfoOurLocation1.Replace(System.Environment.NewLine, "");
            Assert.AreEqual(InfoOurLocation1.ToLower().Trim(), careers_D_V.txtInfoOurLocation1.ToLower().Trim(), "The Text doesn't match");

            string InfoOurLocation2 = driver.FindElement(By.XPath(infoOurLocation2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoOurLocation2.ToLower().Trim(), careers_D_V.txtInfoOurLocation2.ToLower().Trim(), "The Text doesn't match");

            string InfoOurLocation3 = driver.FindElement(By.XPath(infoOurLocation3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoOurLocation3.ToLower().Trim(), careers_D_V.txtInfoOurLocation3.ToLower().Trim(), "The Text doesn't match");

            string InfoOurLocation4 = driver.FindElement(By.XPath(infoOurLocation4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoOurLocation4.ToLower().Trim(), careers_D_V.txtInfoOurLocation4.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyContact()
        {
            // Contact 

            string TitleContact = driver.FindElement(By.XPath(titleContactXpath)).GetAttribute("innerText");
            Assert.AreEqual(TitleContact.ToLower().Trim(), careers_D_V.txtTitleContact.ToLower().Trim(), "The Text doesn't match");

            string InfoAdress = driver.FindElement(By.XPath(infoAdressXpath)).GetAttribute("innerText");
            InfoAdress = InfoAdress.Replace(System.Environment.NewLine, "");
            Console.WriteLine("valus is " + InfoAdress);
            Assert.AreEqual(InfoAdress.ToLower().Trim(), careers_D_V.txtInfoAdress.ToLower().Trim(), "The Text doesn't match");

            string EmailHR = driver.FindElement(By.XPath(emailHRXpath)).GetAttribute("innerText");
            Assert.AreEqual(EmailHR.ToLower().Trim(), careers_D_V.emailHR.ToLower().Trim(), "The Text doesn't match");

            string InfoHours1 = driver.FindElement(By.XPath(infoHours1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHours1.ToLower().Trim(), careers_D_V.txtInfoHours1.ToLower().Trim(), "The Text doesn't match");

            string InfoPhone1 = driver.FindElement(By.XPath(infoPhone1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoPhone1.ToLower().Trim(), careers_D_V.txtInfoPhone1.ToLower().Trim(), "The Text doesn't match");

            string InfoHours2 = driver.FindElement(By.XPath(infoHours2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHours2.ToLower().Trim(), careers_D_V.txtInfoHours2.ToLower().Trim(), "The Text doesn't match");

            string HrefPhone2 = driver.FindElement(By.XPath(hrefPhone2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(HrefPhone2.ToLower().Trim(), careers_D_V.hrefPhone2.ToLower().Trim(), "The Text doesn't match");
        }

        public void verifyTalktoUs()
        {
            // Talk to us

            string HeaderTalktous = driver.FindElement(By.XPath(headerTalktousXpath)).GetAttribute("innerText");
            Assert.AreEqual(HeaderTalktous.ToLower().Trim(), careers_D_V.txtHeaderTalktous.ToLower().Trim(), "The Text doesn't match");

            string InfoName = driver.FindElement(By.XPath(infoNameXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoName.ToLower().Trim(), careers_D_V.txtInfoName.ToLower().Trim(), "The Text doesn't match");

            string InfoEmailAddress = driver.FindElement(By.XPath(infoEmailAddressXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoEmailAddress.ToLower().Trim(), careers_D_V.txtInfoEmailAddress.ToLower().Trim(), "The Text doesn't match");

            string InfoPhoneNumber = driver.FindElement(By.XPath(infoPhoneNumberXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoPhoneNumber.ToLower().Trim(), careers_D_V.txtInfoPhoneNumber.ToLower().Trim(), "The Text doesn't match");

            string InfoMessage = driver.FindElement(By.XPath(infoMessageXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoMessage.ToLower().Trim(), careers_D_V.txtInfoMessage.ToLower().Trim(), "The Text doesn't match");

            string BtnSendMessage = driver.FindElement(By.XPath(btnSendMessageXpath)).GetAttribute("value");
            Assert.AreEqual(BtnSendMessage.ToLower().Trim(), careers_D_V.btnSendMessage.ToLower().Trim(), "The Text doesn't match");
        }
    }
}

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
    public class FAQ_D : Page
    {
        // Elements  

        // FAQ Insurance Page Images


        // Nav Bar                 
        string jmLogoCSS = ".nav__logo-lg";



        // FAQ Header
        string headerFAQXpath = "//h4[text()='FAQ']";
        string titleTheInsXpath = "//h1[text()='The ins and outs of jewelry insurance.']";

        // Before You Get a Policy
        string headerBeforeYouXpath = "//h2[text()='Before You Get a Policy']";
        string titleDoYouHavesXpath = "//h4[text()='Do you have a sample policy I can review?']";
        string infoDoYouHaveXpath = "//p[contains(.,'Yes. You can review our sample policy to get more detail about specific situatio')]";
        string linkSamplePolicyXpath = "//a[text()='sample policy']";
        string titleWhatDeterminesXpath = "//h4[text()='What determines my policy limit?']";
        string infoWhatDeterminesXpath = "//p[contains(.,'The documentation you provide. Usually this is an appraisal, sometimes a detaile')]";
        string titleWhatDoesntXpath = "//h4[contains(text(),'t a rider to my homeowners')]";
        string infoWhatDoesnt1Xpath = "//p[contains(.,'Depending on your exact policy, a rider may still leave out coverage for mysteri')]";
        string infoWhatDoesnt2Xpath = "//li[contains(text(),'t affect coverage on your house and everything in it')]";
        string infoWhatDoesnt3Xpath = "//li[contains(.,'The promise to work with your jeweler, the one whom you already know and who kno')]";
        string infoWhatDoesnt4Xpath = "//li[text()='Experts who actually know jewelry to help you through the process']";
        string titleWhatIsADeductibleXpath = "//h4[text()='What is a deductible and how much will mine be?']";
        string infoWhatIsADeductible1Xpath = "//p[contains(.,'A deductible is an amount of money that you have to pay for something before an')]";
        string infoWhatIsADeductible2Xpath = "//p[text()='With Jewelers Mutual, you choose your deductible, with options starting at $0.']";
        string titleWhatIsAPremiumXpath = "//h4[text()='What is a premium?']";
        string infoWhatIsAPremiumXpath = "//p[text()='The amount paid to maintain insurance coverage, typically annually.']";
        string titleHowdoIFindXpath = "//h4[text()='How do I find a professional appraiser?']";
        string infoHowDoIFindXpath = "//p[contains(.,'We accept current appraisals or evaluations from any appraiser. We recommend you')]";
        string titleHowDoIKnowXpath = "//h4[text()='How do I know if my jewelry is worth insuring?']";
        string infoHowDoIKnowXpath = "//p[contains(.,'d be upset if your piece was ever lost, broken or stolen, then it')]";

        // Quick Links
        string titleQuickLinksXpath = "//h4[text()='Quick Links']";
        string linkPayMyBillXpath = "//a[text()='Pay My Bill']";
        string linkSubmitAClaimXpath = "//a[text()='Submit a Claim']";
        string linkGetAQuoteXpath = "//a[text()='Get a Quote'][last()]";
        string linkReviewXpath = "//a[text()='Review a Sample Policy']";
        string linkRegisterXpath = "//a[text()='Register for Online Account']";

        //After You Get a Policy
        string headerAfterPolicyXpath = "//h2[text()='After You Get a Policy']";
        string titleAfterMyJewelryXpath = "//h4[text()='After my jewelry is insured, is there anything else I need to do?']";
        string infoAfterMyJewelryXpath = "//p[contains(.,'Nope! As long as you have provided us with any necessary documentation we may re')]";
        string titleIfSomethingXpath = "//h4[text()='If something happens, how do I file a claim?']";
        string infoIfSomethingXpath = "//p[contains(.,'You can file a claim quickly and easily online. But if you prefer, feel free to')]";
        string linkFileAClaimXpath = "//a[text()='file a claim quickly and easily online']";
        string titleHowLongXpath = "//h4[text()='How long will it take for a claim to be settled?']";
        string infoHowLongXpath = "//p[contains(.,'We do our best to handle your claim quickly, professionally, and personally, and')]";
        string titleCanIChooseXpath = "//h4[text()='Can I choose my own jeweler during a claim?']";
        string infoCanIChooseXpath = "//p[contains(text(),' even need to approve your choice of jeweler; our claims professionals will')]";
        string titleWhatIfXpath = "//h4[contains(.,'What if something happens to my jewelry and the jeweler cannot find the same sto')]";
        string infoWhatIfXpath = "//p[contains(.,'We’ll authorize the jeweler to replace your insured item with same kind and qual')]";
        string titleHowDoIAddXpath = "//h4[text()='How do I add, remove or update the value of an item on my policy?']";
        string infoHowDoIAddXpath = "//p[contains(.,'Either log in to your online account or call us at 888-884-2424. If you haven')]";
        string linkLogInFAQXpath = "//a[text()='log in to your online account']";
        string linkRegisterForXpath = "//a[text()='register for yours today']";
        string titleHowDoICancelXpath = "//h4[text()='How do I cancel my policy?']";
        string infoHowDoICancelXpath = "//p[text()='To cancel an existing policy, please call us at 888-884-2424.']";
        string titleHowDoISubmitXpath = "//h4[text()='How do I submit an appraisal?']";
        string infoHowDoISubmitXpath = "//p[contains(.,'ax it to 920-969-1294 or mail it to Jewelers Mutual Insurance Group, 24 Jewelers Park Dr., P.O. Box 468, Neenah, WI 54957-0468.')]";
        string linkLogInToYourOnlineXpath = "//a[text()='log in to your online account'][last()]";
        string linkPJEmailFAWXpath = "//a[text()='personaljewelry@jminsure.com']";

        // Protecting personal jewelry since 1953
        string titleProtectingXpath = "//h2[text()='Protecting personal jewelry since 1953']";
        string infoProtectingXpath = "//p[contains(text(),'Founded in 1913, Jewelers Mutual got its start by offering premium service and p')]";
        string btnGetToKnowXpath = "//a[text()='GET TO KNOW JEWELERS MUTUAL']";

        FAQ_D_V FAQ_D_V = new FAQ_D_V();
        public FAQ_D(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
            VerifyLinksOnPage(driver);
            CheckForBrokenImages(driver);
        }

        public override void VerifyPage()
        {// Add all the elements you want to verify


            VerifyUIElementIsDisplayed(headerFAQXpath);
            VerifyUIElementIsDisplayed(titleTheInsXpath);
            VerifyUIElementIsDisplayed(headerBeforeYouXpath);
            VerifyUIElementIsDisplayed(titleDoYouHavesXpath);
            VerifyUIElementIsDisplayed(infoDoYouHaveXpath);
            VerifyUIElementIsDisplayed(linkSamplePolicyXpath);
            VerifyUIElementIsDisplayed(titleWhatDeterminesXpath);
            VerifyUIElementIsDisplayed(infoWhatDeterminesXpath);
            VerifyUIElementIsDisplayed(titleWhatDoesntXpath);
            VerifyUIElementIsDisplayed(infoWhatDoesnt1Xpath);
            VerifyUIElementIsDisplayed(infoWhatDoesnt2Xpath);
            VerifyUIElementIsDisplayed(infoWhatDoesnt3Xpath);
            VerifyUIElementIsDisplayed(infoWhatDoesnt4Xpath);
            VerifyUIElementIsDisplayed(titleWhatIsADeductibleXpath);
            VerifyUIElementIsDisplayed(infoWhatIsADeductible1Xpath);
            VerifyUIElementIsDisplayed(infoWhatIsADeductible2Xpath);
            VerifyUIElementIsDisplayed(titleWhatIsAPremiumXpath);
            VerifyUIElementIsDisplayed(infoWhatIsAPremiumXpath);
            VerifyUIElementIsDisplayed(titleHowdoIFindXpath);
            VerifyUIElementIsDisplayed(infoHowDoIFindXpath);
            VerifyUIElementIsDisplayed(titleHowDoIKnowXpath);
            VerifyUIElementIsDisplayed(infoHowDoIKnowXpath);
            VerifyUIElementIsDisplayed(titleQuickLinksXpath);
            VerifyUIElementIsDisplayed(linkPayMyBillXpath);
            VerifyUIElementIsDisplayed(linkSubmitAClaimXpath);
            VerifyUIElementIsDisplayed(linkGetAQuoteXpath);
            VerifyUIElementIsDisplayed(linkReviewXpath);
            VerifyUIElementIsDisplayed(linkRegisterXpath);
            VerifyUIElementIsDisplayed(headerAfterPolicyXpath);
            VerifyUIElementIsDisplayed(titleAfterMyJewelryXpath);
            VerifyUIElementIsDisplayed(infoAfterMyJewelryXpath);
            VerifyUIElementIsDisplayed(titleIfSomethingXpath);
            VerifyUIElementIsDisplayed(infoIfSomethingXpath);
            VerifyUIElementIsDisplayed(linkFileAClaimXpath);
            VerifyUIElementIsDisplayed(titleHowLongXpath);
            VerifyUIElementIsDisplayed(infoHowLongXpath);
            VerifyUIElementIsDisplayed(titleCanIChooseXpath);
            VerifyUIElementIsDisplayed(infoCanIChooseXpath);
            VerifyUIElementIsDisplayed(titleWhatIfXpath);
            VerifyUIElementIsDisplayed(infoWhatIfXpath);
            VerifyUIElementIsDisplayed(titleHowDoIAddXpath);
            VerifyUIElementIsDisplayed(infoHowDoIAddXpath);
            VerifyUIElementIsDisplayed(linkLogInFAQXpath);
            VerifyUIElementIsDisplayed(linkRegisterForXpath);
            VerifyUIElementIsDisplayed(titleHowDoICancelXpath);
            VerifyUIElementIsDisplayed(infoHowDoICancelXpath);
            VerifyUIElementIsDisplayed(titleHowDoISubmitXpath);
            VerifyUIElementIsDisplayed(infoHowDoISubmitXpath);
            VerifyUIElementIsDisplayed(linkLogInToYourOnlineXpath);
            VerifyUIElementIsDisplayed(linkPJEmailFAWXpath);
            VerifyUIElementIsDisplayed(titleProtectingXpath);
            VerifyUIElementIsDisplayed(infoProtectingXpath);
            VerifyUIElementIsDisplayed(btnGetToKnowXpath);


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


        public void verifyFAQ()
        {
            //FAQ Header
            string HeaderFAQ = driver.FindElement(By.XPath(headerFAQXpath)).Text;
            Console.WriteLine("Value is " + HeaderFAQ);
            Assert.AreEqual(HeaderFAQ, FAQ_D_V.txtFAQ, "The Text doesn't match");

            string TitleTheIns = driver.FindElement(By.XPath(titleTheInsXpath)).Text;
            Assert.AreEqual(TitleTheIns, FAQ_D_V.txtTheIns, "The Text doesn't match");

        }

        public void verifyBeforePolicy()
        {
            //Before You Get a Policy
            string HeaderBeforeYou = driver.FindElement(By.XPath(headerBeforeYouXpath)).Text;
            Assert.AreEqual(HeaderBeforeYou, FAQ_D_V.txtBeforePolicy, "The Text doesn't match");

            string TitleDoYouHaves = driver.FindElement(By.XPath(titleDoYouHavesXpath)).Text;
            Assert.AreEqual(TitleDoYouHaves, FAQ_D_V.txtDoYouHave, "The Text doesn't match");

            string InfoDoYouHave = driver.FindElement(By.XPath(infoDoYouHaveXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoDoYouHave, FAQ_D_V.txtDoYouHaveInfo, "The Text doesn't match");

            string LinkSamplePolicy = driver.FindElement(By.XPath(linkSamplePolicyXpath)).GetAttribute("innerText"); ;
            Assert.AreEqual(LinkSamplePolicy, FAQ_D_V.hrefSamplePolicy, "The Text doesn't match");

            string TitleWhatDetermines = driver.FindElement(By.XPath(titleWhatDeterminesXpath)).Text;
            Assert.AreEqual(TitleWhatDetermines, FAQ_D_V.txtWhatDetermines, "The Text doesn't match");

            string InfoWhatDetermines = driver.FindElement(By.XPath(infoWhatDeterminesXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatDetermines, FAQ_D_V.txtWhatDeterminesInfo, "The Text doesn't match");

            string TitleWhatDoesnt = driver.FindElement(By.XPath(titleWhatDoesntXpath)).Text;
            Assert.AreEqual(TitleWhatDoesnt, FAQ_D_V.txtWhatDoesnt, "The Text doesn't match");

            string InfoWhatDoesnt1 = driver.FindElement(By.XPath(infoWhatDoesnt1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatDoesnt1, FAQ_D_V.txtWhatDoesntInfo1, "The Text doesn't match");

            string InfoWhatDoesnt2 = driver.FindElement(By.XPath(infoWhatDoesnt2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatDoesnt2, FAQ_D_V.txtWhatDoesntInfo2, "The Text doesn't match");

            string InfoWhatDoesnt3 = driver.FindElement(By.XPath(infoWhatDoesnt3Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatDoesnt3, FAQ_D_V.txtWhatDoesntInfo3, "The Text doesn't match");

            string InfoWhatDoesnt4 = driver.FindElement(By.XPath(infoWhatDoesnt4Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatDoesnt4, FAQ_D_V.txtWhatDoesntInfo4, "The Text doesn't match");

            string TitleWhatIsADeductible = driver.FindElement(By.XPath(titleWhatIsADeductibleXpath)).Text;
            Assert.AreEqual(TitleWhatIsADeductible, FAQ_D_V.txtWhatIsADeductible, "The Text doesn't match");

            string InfoWhatIsADeductible1 = driver.FindElement(By.XPath(infoWhatIsADeductible1Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatIsADeductible1, FAQ_D_V.txtWhatIsADeductibleInfo1, "The Text doesn't match");

            string InfoWhatIsADeductible2 = driver.FindElement(By.XPath(infoWhatIsADeductible2Xpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatIsADeductible2, FAQ_D_V.txtWhatIsADeductibleInfo2, "The Text doesn't match");

            string TitleWhatIsAPremium = driver.FindElement(By.XPath(titleWhatIsAPremiumXpath)).Text;
            Assert.AreEqual(TitleWhatIsAPremium, FAQ_D_V.txtWhatIsAPremium, "The Text doesn't match");

            string InfoWhatIsAPremium = driver.FindElement(By.XPath(infoWhatIsAPremiumXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatIsAPremium, FAQ_D_V.txtWhatIsAPremiumInfo, "The Text doesn't match");

            string TitleHowdoIFind = driver.FindElement(By.XPath(titleHowdoIFindXpath)).Text;
            Assert.AreEqual(TitleHowdoIFind, FAQ_D_V.txtHowDoIFind, "The Text doesn't match");

            string InfoHowDoIFind = driver.FindElement(By.XPath(infoHowDoIFindXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHowDoIFind, FAQ_D_V.txtHowDOIFindInfo, "The Text doesn't match");

            string TitleHowDoIKnow = driver.FindElement(By.XPath(titleHowDoIKnowXpath)).Text;
            Assert.AreEqual(TitleHowDoIKnow, FAQ_D_V.txtHowDoIKnow, "The Text doesn't match");

            string InfoHowDoIKnow = driver.FindElement(By.XPath(infoHowDoIKnowXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHowDoIKnow, FAQ_D_V.txtHowDoIKnowInfo, "The Text doesn't match");

        }

        public void verifyQuickLinks()
        {
            //Quick Links
            string TitleQuickLinks = driver.FindElement(By.XPath(titleQuickLinksXpath)).Text;
            Assert.AreEqual(TitleQuickLinks, FAQ_D_V.txtQuickLinks, "The Text doesn't match");

            string LinkPayMyBill = driver.FindElement(By.XPath(linkPayMyBillXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkPayMyBill, FAQ_D_V.hrefPayMyBill, "The Text doesn't match");

            string LinkSubmitAClaim = driver.FindElement(By.XPath(linkSubmitAClaimXpath)).Text;
            Assert.AreEqual(LinkSubmitAClaim, FAQ_D_V.hrefSubmitaClaim, "The Text doesn't match");

            string LinkGetAQuote = driver.FindElement(By.XPath(linkGetAQuoteXpath)).GetAttribute("innerText");
            Console.WriteLine("valus is " + LinkGetAQuote);
            Assert.AreEqual(LinkGetAQuote, FAQ_D_V.hrefGetAQuoteFAQ, "The Text doesn't match");

            string LinkReview = driver.FindElement(By.XPath(linkReviewXpath)).Text;
            Assert.AreEqual(LinkReview, FAQ_D_V.hrefReviewASamplePolicy, "The Text doesn't match");

            string LinkRegister = driver.FindElement(By.XPath(linkRegisterXpath)).Text;
            Assert.AreEqual(LinkRegister, FAQ_D_V.hrefRegisterforOnlineAccount, "The Text doesn't match");

        }

        public void verifyAfterPolicy()
        {
            // After You Get a Policy

            string HeaderAfterPolicy = driver.FindElement(By.XPath(headerAfterPolicyXpath)).Text;
            Assert.AreEqual(HeaderAfterPolicy, FAQ_D_V.txtAfterPolicy, "The Text doesn't match");

            string TitleAfterMyJewelry = driver.FindElement(By.XPath(titleAfterMyJewelryXpath)).Text;
            Assert.AreEqual(TitleAfterMyJewelry, FAQ_D_V.txtAfterMyJewelry, "The Text doesn't match");

            string InfoAfterMyJewelry = driver.FindElement(By.XPath(infoAfterMyJewelryXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoAfterMyJewelry, FAQ_D_V.txtAfterMyJewelryInfo, "The Text doesn't match");

            string TitleIfSomething = driver.FindElement(By.XPath(titleIfSomethingXpath)).Text;
            Assert.AreEqual(TitleIfSomething, FAQ_D_V.txtIfSomethingHappens, "The Text doesn't match");

            string InfoIfSomething = driver.FindElement(By.XPath(infoIfSomethingXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoIfSomething, FAQ_D_V.txtIfSomethingHappensInfo, "The Text doesn't match");

            string LinkFileAClaim = driver.FindElement(By.XPath(linkFileAClaimXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkFileAClaim, FAQ_D_V.hrefFileAClaim, "The Text doesn't match");

            string TitleHowLong = driver.FindElement(By.XPath(titleHowLongXpath)).Text;
            Assert.AreEqual(TitleHowLong, FAQ_D_V.txtHowLong, "The Text doesn't match");

            string InfoHowLong = driver.FindElement(By.XPath(infoHowLongXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHowLong, FAQ_D_V.txtHowLongInfo, "The Text doesn't match");

            string TitleCanIChoose = driver.FindElement(By.XPath(titleCanIChooseXpath)).Text;
            Assert.AreEqual(TitleCanIChoose, FAQ_D_V.txtCanIChoose, "The Text doesn't match");

            string InfoCanIChoose = driver.FindElement(By.XPath(infoCanIChooseXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoCanIChoose, FAQ_D_V.txtCanIChooseInfo, "The Text doesn't match");

            string TitleWhatIf = driver.FindElement(By.XPath(titleWhatIfXpath)).Text;
            Assert.AreEqual(TitleWhatIf, FAQ_D_V.txtWhatIfSomething, "The Text doesn't match");

            string InfoWhatIf = driver.FindElement(By.XPath(infoWhatIfXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoWhatIf, FAQ_D_V.txtWhatIfSomethingInfo, "The Text doesn't match");

            string TitleHowDoIAdd = driver.FindElement(By.XPath(titleHowDoIAddXpath)).Text;
            Assert.AreEqual(TitleHowDoIAdd, FAQ_D_V.txtHowDoIAdd, "The Text doesn't match");

            string InfoHowDoIAdd = driver.FindElement(By.XPath(infoHowDoIAddXpath)).GetAttribute("innerText");
            //Console.WriteLine("Value is " + driver.FindElement(By.XPath(infoHowDoIAddXpath)).GetAttribute("innerText"));
            Assert.AreEqual(InfoHowDoIAdd, FAQ_D_V.txtHowDoIAddInfo, "The Text doesn't match");

            string LinkLogInFAQ = driver.FindElement(By.XPath(linkLogInFAQXpath)).GetAttribute("innerText");
            Console.WriteLine("Text is " + LinkLogInFAQ);
            Console.WriteLine("Text2 is " + driver.FindElement(By.XPath(linkLogInFAQXpath)).GetAttribute("innerText"));
            Assert.AreEqual(LinkLogInFAQ, FAQ_D_V.hrefLoginFAQ, "The Text doesn't match");

            string LinkRegisterFor = driver.FindElement(By.XPath(linkRegisterForXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkRegisterFor, FAQ_D_V.hrefRegisterFor, "The Text doesn't match");

            string TitleHowDoICancel = driver.FindElement(By.XPath(titleHowDoICancelXpath)).Text;
            Assert.AreEqual(TitleHowDoICancel, FAQ_D_V.txtHowDoICancel, "The Text doesn't match");

            string InfoHowDoICancel = driver.FindElement(By.XPath(infoHowDoICancelXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHowDoICancel, FAQ_D_V.txtHowDoICancelInfo, "The Text doesn't match");

            string TitleHowDoISubmit = driver.FindElement(By.XPath(titleHowDoISubmitXpath)).Text;
            Assert.AreEqual(TitleHowDoISubmit, FAQ_D_V.txtHowDoISubmit, "The Text doesn't match");

            string InfoHowDoISubmit = driver.FindElement(By.XPath(infoHowDoISubmitXpath)).GetAttribute("innerText");
            Assert.AreEqual(InfoHowDoISubmit, FAQ_D_V.txtHowDoISubmitInfo, "The Text doesn't match");

            string LinkLogInToYourOnline = driver.FindElement(By.XPath(linkLogInToYourOnlineXpath)).GetAttribute("innerText");
            Console.WriteLine("Text is " + LinkLogInToYourOnline);
            Console.WriteLine("Text2 is " + driver.FindElement(By.XPath(linkLogInToYourOnlineXpath)).GetAttribute("innerText"));
            Assert.AreEqual(LinkLogInToYourOnline, FAQ_D_V.hrefLogIngoYourOnline, "The Text doesn't match");

            string LinkPJEmailFAW = driver.FindElement(By.XPath(linkPJEmailFAWXpath)).GetAttribute("innerText");
            Assert.AreEqual(LinkPJEmailFAW, FAQ_D_V.hrefPJEmailFAQ, "The Text doesn't match");

        }

        public void verifyProtecting()
        {
            //Protecting personal jewelry since 1953
            string TitleProtecting = driver.FindElement(By.XPath(titleProtectingXpath)).Text;
            Assert.AreEqual(TitleProtecting, FAQ_D_V.txtProtecting, "The Text doesn't match");

            string InfoProtecting = driver.FindElement(By.XPath(infoProtectingXpath)).Text;
            Assert.AreEqual(InfoProtecting, FAQ_D_V.txtProtectingInfo, "The Text doesn't match");

            string BtnGetToKnow = driver.FindElement(By.XPath(btnGetToKnowXpath)).Text;
            Assert.AreEqual(BtnGetToKnow, FAQ_D_V.btnGetToKnow, "The Text doesn't match");

        }

        public void verifyCarrersPageContent()
        {
            verifyNavBar();
            verifyFooter();
            verifyFAQ();
            verifyBeforePolicy();
            verifyQuickLinks();
            verifyAfterPolicy();
            verifyProtecting();

        }


    }
}

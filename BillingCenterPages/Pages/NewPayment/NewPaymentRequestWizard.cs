using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TechTalk.SpecFlow;
using WebCommonCore;
using System.Net;
using System.IO;

namespace BillingCenterPages.Pages.NewPayment
{
    public class NewPaymentRequestWizard : Page
    {
		string sbtnContinue = "//a[text()[contains(.,'Continue')]]";
		[FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Continue')]]")]
        public IWebElement btnContinue;

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Pay')]]")]
        public IWebElement btnPay;

        [FindsBy(How = How.Id, Using = "AccountDetailNewPaymentRequestWizard:PaymentusPaymentRequest_JMICScreen:ToolbarButton")]
        public IWebElement btnCloseLayer;


        string btnClose = "span[id='AccountDetailNewPaymentRequestWizard:PaymentusPaymentRequest_JMICScreen:ToolbarButton-btnInnerEl']";

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-action btn-type-next ']")]
        public IWebElement btnContinueAfterPaymentType;

        [FindsBy(How = How.XPath, Using = "//a[@data-tab='tab-DD']")]
        public IWebElement tabEcheck;

        [FindsBy(How = How.XPath, Using = "//input[@id='acceptTermsAndConditions-1']")]
        public IWebElement chkIAgreeToConditions;

        [FindsBy(How = How.XPath, Using = "//span[@class='pMethodSlide methodMastercard']")]
        public IWebElement radMasterCard;

        [FindsBy(How = How.XPath, Using = "//span[@class='pMethodSlide methodCheck']")]
        public IWebElement radCheck;

        [FindsBy(How = How.XPath, Using = "//a[@data-tab='tab-CC']")]
        public IWebElement tabCredit;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Checking')]]")]
        public IWebElement radioEcheckAccTypeChecking;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'Savings')]]")]
        public IWebElement radioEcheckAccTypeSaving;

        [FindsBy(How = How.Id, Using = "add-cardNumberCC")]
        public IWebElement txtCardNumberCC;


        [FindsBy(How = How.Id, Using = "add-cvvCC")]
        public IWebElement txtCvvCC;


        [FindsBy(How = How.Id, Using = "paymentAmountOther")]
        public IWebElement txtPaymentAmountOther;

        [FindsBy(How = How.Id, Using = "add-expiryDateMonthCC")]
        public IWebElement selExpiryDateMonthCC;

        [FindsBy(How = How.Id, Using = "add-expiryDateYearCC")]
        public IWebElement selExpiryDateYearCC;


        [FindsBy(How = How.Id, Using = "add-cardHolderNameCC")]
        public IWebElement txtcardHolderNameCC;


        [FindsBy(How = How.Id, Using = "add-zipCodeCC")]
        public IWebElement txtZipCode;

        [FindsBy(How = How.Id, Using = "btn-action modalAddPayment")]
        public IWebElement btnAddCCPayment;

        [FindsBy(How = How.Id, Using = "add-radio-pmt-sav")]
        public IWebElement radioEcheckAccTypeSavings;

        [FindsBy(How = How.Id, Using = "add-routingNumber")]
        public IWebElement txtEcheckRoutingNumber;

        [FindsBy(How = How.Id, Using = "add-accountNumber")]
        public IWebElement txtEcheckAccountNumber;

        [FindsBy(How = How.Id, Using = "add-bankName")]
        public IWebElement txtEcheckBankName;

        [FindsBy(How = How.Id, Using = "add-accountHolderName")]
        public IWebElement txtEcheckAccountHolder;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'I authorize ACH direct debit')]]")]
        public IWebElement chkAuthorizeACH;

        [FindsBy(How = How.XPath, Using = "//span[text()[contains(.,'I authorize payment and agree to the Payment Authorization Terms')]]")]
        public IWebElement chkAuthorizeCC;

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Add')]]")]
        public IWebElement btnAdd;

        [FindsBy(How = How.Id, Using = "pm-add-button")]
        public IWebElement lnkAddNewPayment;

        //Canada ACH Payment Objects
        [FindsBy(How = How.Id, Using = "add-bankTransitNumber")]
        public IWebElement txtbankTransitNumber;
        //Canada ACH Payment Objects
        [FindsBy(How = How.Id, Using = "add-bankInstitutionId")]
        public IWebElement txtbankInstitutionId;

        [FindsBy(How = How.Id, Using = "payNowOrLater-1")]
        public IWebElement radioPaynow;

        [FindsBy(How = How.Id, Using = "payNowOrLater-2")]
        public IWebElement radioPaylater;

        public NewPaymentRequestWizard(IWebDriver driver) : base(driver)
        {
            WaitForPageLoad(driver);
        }

        public override void VerifyPage()
        {
            //      WaitFor(btnContinue);
        }

        public override void WaitForLoad()
        {
            //            WaitFor(btnContinue);
        }

        public void PayMyPremium(string paymentAmount, string paymentMethod, string PaymentType, string paymentDate)
        {
			System.Threading.Thread.Sleep(10000);
			switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                case "qa2":
                    SetActiveIFrame();
					if (IsElementPresent(driver, By.XPath("//*[text()[contains(.,'None of the requested accounts were found')]]")) == true)
					{
						Console.WriteLine("None of the requested accounts were found");
						string actionMenuArrow = "span[id$=':AccountDetailMenuActions-btnWrap']";
						string actionMenuNewPayment = "span[id$=':AccountDetailMenuActions_Payments-textEl']";
						string actionPaymentReq = "span[id$=':AccountDetailMenuActions_NewPaymentRequest-textEl']";
						UIActionExt(By.CssSelector(btnClose), "click");
						UIActionExt(By.CssSelector(actionMenuArrow), "click");
						UIActionExt(By.CssSelector(actionMenuNewPayment), "click");
						driver.FindElement(By.CssSelector(actionMenuNewPayment)).SendKeys(Keys.ArrowLeft);
						UIActionExt(By.CssSelector(actionPaymentReq), "click");
						System.Threading.Thread.Sleep(10000);
						UIActionExt(By.CssSelector(sbtnContinue), "ispresent");
						SetActiveIFrame();
					}
					WaitFor(btnContinue);
                    btnContinue.Click();
					System.Threading.Thread.Sleep(5000);
					WaitFor(lnkAddNewPayment);

                    long OtherPayment = Convert.ToInt64(ScenarioContext.Current["TotalAmountDue"].ToString());
                    if (OtherPayment <= 0)
                    {
                        Assert.Fail("\nTotal Bill Payment is : {0} . This payment amount is invalid", OtherPayment);
                    }

                    int n;
                    bool isAmountNumeric = int.TryParse(paymentAmount, out n);
                    if (isAmountNumeric)
                    {

                        int CurrpaymentAmount = Convert.ToInt32(paymentAmount);
                        if (OtherPayment < CurrpaymentAmount)
                        {
                            Assert.Fail("\nTotal Bill Payment is : {0} . \n Current Payment amount is {1}, which is invalid", OtherPayment, CurrpaymentAmount);
                        }
                        Console.WriteLine("Inside Numeric payment: " + CurrpaymentAmount);
                        txtPaymentAmountOther.SendKeys(paymentAmount);
                        paymentAmount = "other";

                    }
                    else
                    {
                        Console.WriteLine("Inside payment method: " + paymentAmount.ToLower().Trim());
                        switch (paymentAmount.ToLower().Trim())
                        {
                            case "totaldue":
                                IWebElement SelectCurrentDueAmount = driver.FindElement(By.XPath("//*[@for='radio-amountDue']"));
                                SelectCurrentDueAmount.Click();
                                Console.WriteLine("Inside Total Due payment");
                                paymentAmount = "totaldue";
                                break;
                            case "currentdue":
                                IWebElement SelectMinDueAmount = driver.FindElement(By.XPath("//*[@for='radio-minAmount']"));
                                SelectMinDueAmount.Click();
                                Console.WriteLine("Inside Current Due payment");
                                paymentAmount = "currentdue";
                                break;
                            default:
                                if (OtherPayment >= 10)
                                {
                                    OtherPayment = (OtherPayment * 10) / 100;
                                }
                                Console.WriteLine("Inside Other payment: " + OtherPayment);
                                txtPaymentAmountOther.SendKeys(OtherPayment.ToString());
                                paymentAmount = "other";
                                break;

                        }
                    }

                    Console.WriteLine("Outside Payment Date " + paymentDate);
                    DateTime NextpaymentDueDate = Convert.ToDateTime(ScenarioContext.Current["NextPaymentDueDate"]);
                    switch (paymentDate)
                    {

                        case "TESTINGSYSTEMCLOCK":
                            WaitFor(radioPaynow);
                            radioPaynow.Click();
                            break;
                        default:
                            char[] delimiterChars = { '+' };
                            int noOfDays = Convert.ToInt32(paymentDate.Split(delimiterChars)[1]);
                            Console.WriteLine("Total # of Days to be added: " + noOfDays);
                            DateTime futureDay = DateTime.Now.AddDays(noOfDays);
                            if (futureDay > NextpaymentDueDate)
                            {
                                futureDay = NextpaymentDueDate;
                                Console.WriteLine("@*********************************************Warning****************************************@");
                                Console.WriteLine("@\t Actual Later date is greater than due date. so, paying on due date : " + NextpaymentDueDate);
                                Console.WriteLine("@********************************************************************************************@");
                            }
                            Console.WriteLine("Future date is " + futureDay.ToString("MM/dd/yyyy"));
                            Console.WriteLine("Future Day is " + futureDay.Day);
                            Console.WriteLine("Future Month is " + futureDay.ToString("MMMM"));
                            Console.WriteLine("Future Year is " + futureDay.Year);
                            string futureDate = futureDay.ToString("MM/dd/yyyy");
							System.Threading.Thread.Sleep(5000);
							WaitFor(radioPaylater);
                            radioPaylater.Click();
							System.Threading.Thread.Sleep(5000);

							WaitFor(driver.FindElement(By.Id("fromPayLaterBtn")));
                            List<IWebElement> PageInputElementsDateSelector = driver.FindElements(By.Id("fromPayLaterBtn")).ToList();
                            PageInputElementsDateSelector[0].Click();
                            pause();
                            pause();

                            WaitFor(driver.FindElement(By.ClassName("picker__select--year")));
                            List<IWebElement> PageInputElementsYearSelector = driver.FindElements(By.ClassName("picker__select--year")).ToList();
                            PageInputElementsYearSelector[0].Click();
                            SelectByText(PageInputElementsYearSelector[0], futureDay.Year.ToString());
                            pause();
                            pause();

                            WaitFor(driver.FindElement(By.ClassName("picker__select--month")));
                            List<IWebElement> PageInputElementsMonthSelector = driver.FindElements(By.ClassName("picker__select--month")).ToList();
                            PageInputElementsMonthSelector[0].Click();
                            SelectByText(PageInputElementsMonthSelector[0], futureDay.ToString("MMMM"));
                            pause();
                            pause();

                            WaitFor(driver.FindElement(By.XPath("//*[@aria-label='" + futureDate + "']")));
                            IWebElement SelectLaterDate = driver.FindElement(By.XPath("//*[@aria-label='" + futureDate + "']"));
                            SelectLaterDate.Click();
                            pause();
                            pause();
                            break;
                    }


					System.Threading.Thread.Sleep(5000);

					string country = ScenarioContext.Current["CountryAddress"].ToString();

                    switch (paymentMethod.ToLower().Trim())
                    {
                        case "e-check":

                            lnkAddNewPayment.Click();

                            pause();

                            WaitFor(tabEcheck);

                            tabEcheck.Click();

                            pause();

                            switch (PaymentType.ToLower().Trim())
                            {
                                case "saving":
                                case "savings":
                                    radioEcheckAccTypeSaving.Click();
                                    pause();
                                    break;
                                case "checking":
                                    radioEcheckAccTypeChecking.Click();
                                    pause();
                                    break;
                                default:
                                    break;
                            }

                            if (country.ToLower().Trim() == "usa")
                            {
                                txtEcheckRoutingNumber.SendKeys("021210073");
                                pause();
                            }
                            else
                            {
                                txtbankTransitNumber.SendKeys("00420");
                                pause();
                                txtbankInstitutionId.SendKeys("010");
                                pause();
                            }
                            txtEcheckAccountNumber.SendKeys("222343332");
                            pause();
                            txtEcheckAccountHolder.SendKeys("Selenium ACH Payment");
                            pause();
                            chkAuthorizeACH.Click();
                            pause();
                            WaitFor(btnAdd);
                            btnAdd.Click();

                            break;
                        case "credit card":


                            lnkAddNewPayment.Click();
                            pause();
                            WaitFor(tabEcheck);
                            var CardCVV = new Random();
                            int rndValue = CardCVV.Next(1000);
                            string sCVV = rndValue.ToString("000");

                            string CCCardNumber = "";

                            switch (PaymentType.ToLower().Trim())
                            {
                                case "visa":
                                    CCCardNumber = "4111111111111111";
                                    break;
                                case "master":
                                    CCCardNumber = "5555555555554444";
                                    break;
                                case "amex":
                                    CCCardNumber = "378282246310005";
                                    sCVV = "4" + sCVV;
                                    break;
                                case "discover":
                                    CCCardNumber = "6011111111111117";
                                    if (country.ToLower().Trim() != "usa")
                                        Assert.Fail("Discover Card Payment is only applicable to USA. Current Country: " + country);
                                    break;
                                default:
                                    break;

                            }
                            txtCardNumberCC.SendKeys(CCCardNumber);
                            pause();


                            txtCvvCC.SendKeys(sCVV);
                            pause();

                            SelectByText(selExpiryDateMonthCC, "05 - May");
                            pause();

                            SelectByText(selExpiryDateYearCC, "2025");
                            pause();

                            txtcardHolderNameCC.SendKeys("Selenium CC Payment");
                            pause();
                            if (country.ToLower().Trim() == "usa")
                            {
                                txtZipCode.SendKeys("54956");
                            }
                            else
                            {
                                txtZipCode.SendKeys("T5M 4A9");
                            }
                            pause();
                            chkAuthorizeCC.Click();
                            pause();
                            WaitFor(btnAdd);
                            btnAdd.Click();


                            break;

                        default:
                            break;
                    }


                    System.Threading.Thread.Sleep(3000);
                    pause();
                    pause();

                    List<IWebElement> PageInputElements = driver.FindElements(By.CssSelector(".btn-action.btn-type-next")).ToList();

                    if (PageInputElements.Count > 0)
                    {
                        PageInputElements[1].Click();

                        pause();

                        WaitForPageLoad(driver);

                        pause();

                        System.Threading.Thread.Sleep(3000);

                        pause();
                        //pause();
                    }

                    System.Threading.Thread.Sleep(3000);



                    List<IWebElement> PagePmtDuplicateAlert = driver.FindElements(By.XPath("//h3[text()='Duplicate Payment Alert']")).ToList();

                    Console.WriteLine("$$$$$" + PagePmtDuplicateAlert.Count);

                    Console.WriteLine("ttt" + PagePmtDuplicateAlert[0].Displayed);

                    if (PagePmtDuplicateAlert[0].Displayed)

                    {
                        PageInputElements = driver.FindElements(By.CssSelector(".btn-action.btn-continue")).ToList();

                        Console.WriteLine("PPP" + PageInputElements.Count);
                        //System.Threading.Thread.Sleep(3000);
                        if (PageInputElements.Count > 0)
                        {
                            pause();

                            PageInputElements[0].Click();

                            pause();
                        }

                        //System.Threading.Thread.Sleep(3000);
                    }

                    //   WaitForPageLoad(driver);

                    //   pause();

                    IList<IWebElement> chkAcceptTermsAndCond = driver.FindElements(By.CssSelector("input#acceptTermsAndConditions-1"));


                    Console.WriteLine("%%%%%%" + chkAcceptTermsAndCond.Count);

                    JavaScriptClick(chkAcceptTermsAndCond[0]);

                    pause();

                    WaitForPageLoad(driver);

                    pause();

                    PageInputElements = driver.FindElements(By.CssSelector(".btn-action.btn-type-next.click-timeout")).ToList();

                    PageInputElements[0].Click();

                    //pause();

                    System.Threading.Thread.Sleep(3000);

                    WaitForPageLoad(driver);

                    pause();

                    System.Threading.Thread.Sleep(3000);
                    //pause();
                    Actions action = new Actions(driver);

                    action.SendKeys(Keys.PageUp).Build().Perform();
                    pause();
                    //System.Threading.Thread.Sleep(3000);

                    driver.SwitchTo().DefaultContent();
                    //    driver.SwitchTo().ActiveElement();

                    //  JavaScriptClick(btnCloseLayer);
                    //

                    UIAction(btnClose, string.Empty, "a");
                    //pause();
                    System.Threading.Thread.Sleep(3000);

                    break;

                default:
                    string AccNumber = ScenarioContext.Current["ACCOUNT"].ToString();
                    Console.WriteLine("Account Number:" + AccNumber);

                    string RefNumber = Guid.NewGuid().ToString().Replace("-", "") + Guid.NewGuid().ToString().Replace("-", "");

                    string authCode = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "").Replace("PM", "").Replace("AM", "");

                    string TxnRefNumber = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "").Replace("PM", "").Replace("AM", "");

                    string paymentusWSDL = "";

                    switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
                    {
                        case "qa1":
                            paymentusWSDL = "http://jmtsvc01/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa2":
                            paymentusWSDL = "http://jmtsvc02/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa3":
                            paymentusWSDL = "http://jmtsvc03/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa4":
                            paymentusWSDL = "http://jmtsvc04/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa5":
                            paymentusWSDL = "http://jmtsvc05/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa6":
                            paymentusWSDL = "http://jmtsvc06/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa7":
                            paymentusWSDL = "http://jmtsvc07/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa8":
                            paymentusWSDL = "http://jmtsvc08/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa9":
                            paymentusWSDL = "http://jmtsvc09/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa10":
                            paymentusWSDL = "http://jmtsvc10/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa11":
                            paymentusWSDL = "http://jmtsvc11/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa12":
                            paymentusWSDL = "http://jmtsvc12/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa13":
                            paymentusWSDL = "http://jmtsvc13/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                        case "qa15":
                            paymentusWSDL = "http://jtn-vm-svc015/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;
                    }

                    //if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim().IndexOf("qa")>=0)
                    //{
                    //    string CurrQAEnv = ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim().Replace("qa", "");
                    //    if (CurrQAEnv.Length == 1)
                    //        CurrQAEnv = "0" + CurrQAEnv;
                    //    paymentusWSDL = "http://jmtsvc"+ CurrQAEnv + "/ExternalPaymentService/ExternalPayment.svc?wsdl";
                    //}

                    string soapString = "";
                    string soapaction = "http://tempuri.org/IExternalPayment/PaymentNotification";

                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(paymentusWSDL);
                    webRequest.Headers.Add("SOAPAction", soapaction);
                    webRequest.ContentType = "text/xml;charset=\"utf-8\"";
                    webRequest.Accept = "text/xml";
                    webRequest.Method = "POST";

                    XmlDocument SOAPReqBody = new XmlDocument();

                    switch (paymentMethod.ToLower().Trim())
                    {
                        case "e-check":
                            soapString = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" 
            xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance"">
              <Body>
                <PaymentNotification xmlns=""http://tempuri.org/"">
                  <request>
                    <AccountNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">AccNumber</AccountNumber>
                    <Amount xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">50.00</Amount>
                    <ApplicationName xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">NEW_BUSINESS</ApplicationName>
                    <AuthorizationCode xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">AUTHCODE</AuthorizationCode>
                    <CardInfo xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">
                      <AutoPay>true</AutoPay>
                      <BankAccountType>Checking</BankAccountType>
                      <IsActive>true</IsActive>
                      <LastFourDigits>4567</LastFourDigits>
                    </CardInfo>
                    <PayeeContactInfo xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">
                      <BillingPostalCode>54956</BillingPostalCode>
                      <Country>US</Country>
                      <FirstName>Automation</FirstName>
                      <LastName>Selenium</LastName>
                      <PayeeName>Selenium Test</PayeeName>
                      <PhoneNumber>901-456-9087</PhoneNumber>
                      <State>WI</State>
                    </PayeeContactInfo>
                    <PaymentStatus xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">ACCEPTED</PaymentStatus>
                    <ReferenceNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">REFNUMBER</ReferenceNumber>
                    <TxnRefNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">TXNNUMBER</TxnRefNumber>
                  </request>
               </PaymentNotification>
              </Body>
            </Envelope>
            ";


                            break;
                        case "credit card":
                            soapString = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" 
xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance"">
  <Body>
    <PaymentNotification xmlns=""http://tempuri.org/"">
      <request>
        <AccountNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">AccNumber</AccountNumber>
        <Amount xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">50.00</Amount>
        <ApplicationName xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">NEW_BUSINESS</ApplicationName>
        <AuthorizationCode xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">AUTHCODE</AuthorizationCode>
        <CardInfo xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">
          <AutoPay>true</AutoPay>
          <CreditCardExpDate>2018-04-01T00:00:00</CreditCardExpDate>
          <CreditCardIssuer>Mastercard</CreditCardIssuer>
          <IsActive>true</IsActive>
          <LastFourDigits>3546</LastFourDigits>
        </CardInfo>
        <PayeeContactInfo xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">
          <BillingPostalCode>54956</BillingPostalCode>
          <Country>US</Country>
          <FirstName>Automation</FirstName>
          <LastName>Selenium</LastName>
          <PayeeName>Selenium Test</PayeeName>
          <PhoneNumber>901-456-9087</PhoneNumber>
          <State>WI</State>
        </PayeeContactInfo>
        <PaymentStatus xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">ACCEPTED</PaymentStatus>
        <ReferenceNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">REFNUMBER</ReferenceNumber>
        <TxnRefNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">TXNNUMBER</TxnRefNumber>
      </request>
   </PaymentNotification>
  </Body>
</Envelope>
";

                            break;
                        default:
                            break;
                    }

                            
                    soapString = soapString.Replace("AccNumber", AccNumber);
                    soapString = soapString.Replace("AUTHCODE", authCode);
                    soapString = soapString.Replace("REFNUMBER", RefNumber);
                    soapString = soapString.Replace("TXNNUMBER", TxnRefNumber);

                    XmlDocument soapEnvelopeDocument = new XmlDocument();
                    soapEnvelopeDocument.LoadXml(soapString);

                    using (Stream stream = webRequest.GetRequestStream())
                    {
                        soapEnvelopeDocument.Save(stream);
                    }

                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 |  SecurityProtocolType.Tls12;

                    // begin async call to web request.
                    IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

                    // suspend this thread until call is complete. You might want to
                    // do something usefull here like update your UI.
                    asyncResult.AsyncWaitHandle.WaitOne();

                    // get the response from the completed web request.
                    string soapResult;
                    using (WebResponse webResponse = webRequest.GetResponse())
                    {
                        using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                        {
                            soapResult = rd.ReadToEnd();
                        }
                        Console.Write(soapResult);

                        Assert.IsTrue(soapResult.Contains("Success"));
                    }

                    driver.SwitchTo().DefaultContent();
                    //    driver.SwitchTo().ActiveElement();

                    //  JavaScriptClick(btnCloseLayer);
                    //

                    UIAction(btnClose, string.Empty, "a");

                    break;
            }


        }


    }
}

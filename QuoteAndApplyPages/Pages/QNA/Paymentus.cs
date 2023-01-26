using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Net;
using System.Xml;
using TechTalk.SpecFlow;
using System.IO;
using Microsoft.Win32;


namespace QuoteAndApplyPages.Pages.QNA
{
    public class Paymentus : Page
    {
        //[FindsBy(How = How.Id, Using = "addPaymentPopupLink")]
        //public IWebElement linkPartnerAddPayment;

        string txtPartnerCardNumber = "input[id$='cardNumberField']";
        string txtPartnerCardExpirationDate = "input[id$='ccExpirationDate']";
        string txtPartnerCardZip = "input[id$='zipCode']";

        //  string linkPartnerAddPayment = "a[id$='addPaymentPopupLink']";
        string linkPartnerAddPayment = "a[id$='addPaymentPopupLink']";
        string linkPartnerBankAccount = "a[id$='ACHTabLink']";
        string linkPartnerCreditCard = "a[id$='creditCardTabLink']";
        string txtPartnerEcheckRoutingNumber = "input[id$='routingNumberField']";
        string txtPartnerzip = "input[id$='zipCode']";
        string txtPartnerEcheckAccountNumber = "input[id$='bankAccountField']";
        string chckboxPartnerAuthorize = "input[id$='achAgree']";
        string btnPartnerSaveAccount = "button[name$='submitBtn']";
        string chckAutoPay = "div[class$='radioAutoPayContainer']";
        string chckPartnerAutoPay = "input[id$='autopay']";
        string txtCCNumber = "input[id$='ccAccountNumber']";
        string txtCCCvv = "input[id$='ccCvv']";
        string selectCCExpMonth = "select[id$='ccExpiryDateMonth']";
        string selectCCExpYear = "select[id$='ccExpiryDateYear']";
        string txtCCHolderName = "input[id$='ccCardHolderName']";
        //string txtCCZip = "input[id$='customer.address.zipCode']";
        string btnContinue = "input[class$='btn-action']";
        //string acceptTerms="input[id$='acceptTermsAndConditions-1']";
        string submitApplication = "a[id$='make-payment-btn']";
        string submitApplicationPartnerMode = "a[id$='paymentSubmit']";

        //Ach Payments element
        string radioEcheckAccTypeSavings = "div[id$='radio-pmt-sav']";
        string radioEcheckAccTypeChecking = "div[id$='radio-pmt-chq']";

        string txtbankTransitNumber = "input[id$='ddBankTransitNumber']";

        string txtbankInstitutionId = "input[id$='ddBankInstitutionId']";
        string txtEcheckRoutingNumber = "input[id$='ddRoutingNumber']";
        string txtEcheckAccountNumber = "input[id$='ddAccountNumber']";
        string txtEcheckBankName = "input[id$='ddBankName']";
        string txtEcheckAccountHolder = "input[id$='ddAccountHolderName']";
        string chckAuthorizePaymeny = "input[id='acceptTermsAndConditions-1']";
        IList<IWebElement> AchAccountType;
        IList<IWebElement> AuthorizeAchPayment;
        string CardNumber;

        [FindsBy(How = How.Id, Using = "echeck-group-heading")]
        public IWebElement radioEcheckAccType;

        public Paymentus(IWebDriver driver) : base(driver)
        {
            try
            {
                // looking for payment plan select
                Console.WriteLine("Selecting Payment plan");
                WaitUntilElementVisible(driver, By.Id("plan-1"));
                pause();
                IWebElement selectPaymentPlan = driver.FindElement(By.Id("plan-1"));
                selectPaymentPlan.Click();
                
                Console.WriteLine("Payment plan selected - Annual Payment");
                // after payment selection it takes around 2 min for paymentus broken window to appear
                System.Threading.Thread.Sleep(200000);
            }
            catch
            {
                Console.WriteLine("Payment plan not located/selected or payment not including 100 items");
                pause();
            }
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                case "qa2":
                    System.Threading.Thread.Sleep(6000);
                    if (!(ScenarioContext.Current.ScenarioInfo.Title.ToString().Contains("QAPMGEICO")))
                    {
                        WaitUntilElementVisible(driver, By.Id("frameToPay"));
                        driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='frameToPay']")));
                        WaitForPageLoad(driver);
                        break;
                    }
                    break;
                default:
                    WaitForPageLoad(driver);
                    break;
            }
        }

        public override void VerifyPage()
        {
            // SetActiveFrame();
            pause();
            pause();
            //   VerifyUIElementIsDisplayed(btnContinue);
        }

        public override void WaitForLoad()
        {
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                case "qa2":
                    WaitUntilElementIsDisplayed(driver, By.Id("radioEcheckAccType"));
                    break;
                default:
                    WaitUntilElementIsDisplayed(driver, By.Name("continueButton"));
                    pause();
                    Console.WriteLine("Wait");
                    break;
            }

            //Id("radioEcheckAccType"));
        }

        public void MakeCCPayment(string CardType, string Country, string AutoPay)
        {
            string SOAPCardType = "";
            string SOAPLastfourdigit = "";
            string sCVV = "123";
            if(Country == "USA")
            {
                switch (CardType.ToLower().Trim())
                {
                    case "visa":
                        CardNumber = "4111111111111111";
                        SOAPCardType = "Visa";
                        SOAPLastfourdigit = "8291";
                        break;
                    case "master":
                        CardNumber = "5555555555554444";
                        SOAPCardType = "Mastercard";
                        SOAPLastfourdigit = "5454";
                        break;
                    case "amex":
                        CardNumber = "378282246310005";
                        sCVV = "1234";
                        SOAPCardType = "Amex";
                        SOAPLastfourdigit = "8431";
                        break;
                    case "discover":
                        CardNumber = "6011111111111117";
                        SOAPCardType = "Discover";
                        SOAPLastfourdigit = "1234";
                        if (Country.ToLower().Trim() != "usa")
                            Assert.Fail("Discover Card Payment is only applicable to USA. Current Country: " + Country);
                        break;
                    default:
                        break;
                }
            }else if(Country == "CA")
            {
                switch (CardType.ToLower().Trim())
                {
                    case "visa":
                        CardNumber = "4788250000028291";
                        SOAPCardType = "Visa";
                        SOAPLastfourdigit = "8291";
                        break;
                    case "master":
                        CardNumber = "5454545454545454";
                        SOAPCardType = "Mastercard";
                        SOAPLastfourdigit = "5454";
                        break;
                    case "amex":
                        CardNumber = "371449635398431";
                        sCVV = "1234";
                        SOAPCardType = "Amex";
                        SOAPLastfourdigit = "8431";
                        break;
                    case "discover":
                        CardNumber = "6011000995500000";
                        SOAPCardType = "Discover";
                        SOAPLastfourdigit = "1234";
                        if (Country.ToLower().Trim() != "usa")
                            Assert.Fail("Discover Card Payment is only applicable to USA. Current Country: " + Country);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("I am in Paymetus Page");
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                case "qa2":

                    // added generic time format, for Card date as a payment method
                    DateTime date1 = DateTime.Now;
                    string monthFull = date1.ToString("MMMM");
                    string monthShort = date1.ToString("MM");
                    string month = (monthShort + " - " + monthFull);
                    string ccyear = date1.ToString("yyyy");
                    string AccNumber = " ";
                    Console.WriteLine("I am in Paymetus logic");
                    WaitUntilElementVisible(driver, By.Id("ccAccountNumber"));
                    pause();

                    UIAction(txtCCNumber, CardNumber, "textbox");
                    pause();
                    UIAction(txtCCCvv, sCVV, "textbox");
                    List<IWebElement> SelectCCExpMonth = driver.FindElements(By.CssSelector(selectCCExpMonth)).ToList();
                    SelectCCExpMonth[0].Click();
                    SelectByText(SelectCCExpMonth[0], month);
                    pause();
                    pause();
                    //UIAction(selectCCExpYear, string.Empty, "select");
                    List<IWebElement> SelectCCExpYear = driver.FindElements(By.CssSelector(selectCCExpYear)).ToList();
                    SelectCCExpYear[0].Click();
                    SelectByText(SelectCCExpYear[0], ccyear);
                    pause();
                    UIAction(txtCCHolderName, "Smoke Test", "textbox");
                    pause();
                    if (AutoPay.ToLower().Trim() == "no")
                    {
                        UIAction(chckAutoPay, string.Empty, "a");
                    }

                    AuthroizePayment();
                    Console.WriteLine("After AuthroizePayment ");
                    break;
                default:

                    RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                    System.Threading.Thread.Sleep(15000);
                    string sAccountNumber;
                    IWebElement IWAccountNumber = driver.FindElement(By.XPath("//span[@data-bind='text: $root.reviewViewModel().accountNumber']"));
                    sAccountNumber = IWAccountNumber.GetAttribute("innerHTML");
                    Console.WriteLine("Account Number: {0} value is ", sAccountNumber);
                    ScenarioContext.Current["ACCOUNT"] = sAccountNumber;
                    RegKey.SetValue("ACCNO", sAccountNumber);

                    // IWebElement Account_Dom = driver.FindElement(By.XPath("//span[contains(text(),'text: $root.reviewViewModel().accountNumber')]"));
                    //AccNumber = Account_Dom.GetAttribute("text");
                    // Console.WriteLine("Account number fetched is " + AccNumber);
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
                            paymentusWSDL = "http://JTN-VM-SVC015/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;

                    }
                    string soapString = "";
                    string soapaction = "http://tempuri.org/IExternalPayment/PaymentNotification";

                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(paymentusWSDL);
                    webRequest.Headers.Add("SOAPAction", soapaction);
                    webRequest.ContentType = "text/xml;charset=\"utf-8\"";
                    webRequest.Accept = "text/xml";
                    webRequest.Method = "POST";

                    XmlDocument SOAPReqBody = new XmlDocument();
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
                                      <CreditCardExpDate>2019-07-01T00:00:00</CreditCardExpDate>
                                      <CreditCardIssuer>Card_Type</CreditCardIssuer>
                                      <IsActive>true</IsActive>
                                      <LastFourDigits>Lastfourdigit</LastFourDigits>
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
                    soapString = soapString.Replace("AccNumber", sAccountNumber);
                    soapString = soapString.Replace("AUTHCODE", authCode);
                    soapString = soapString.Replace("Card_Type", SOAPCardType);
                    soapString = soapString.Replace("Lastfourdigit", SOAPLastfourdigit);
                    soapString = soapString.Replace("REFNUMBER", RefNumber);
                    soapString = soapString.Replace("TXNNUMBER", TxnRefNumber);

                    XmlDocument soapEnvelopeDocument = new XmlDocument();
                    soapEnvelopeDocument.LoadXml(soapString);

                    using (Stream stream = webRequest.GetRequestStream())
                    {
                        soapEnvelopeDocument.Save(stream);
                    }
                    Console.WriteLine("XML SOAP : " + soapString);
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

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
                    pause();
                    Console.WriteLine("post defayultto frame");
                    driver.SwitchTo().DefaultContent();
                    Console.WriteLine("defayultto frame");
                    // driver.SwitchTo().ActiveElement();

                    //  JavaScriptClick(btnCloseLayer);
                    //

                    break;

            }

        }

        public void MakePartnerModeCardPayment(string CardType, string Country, string AutoPay)
        {
            string SOAPCardType = "";
            string SOAPLastfourdigit = "";

            switch (CardType.ToLower().Trim())
            {
                case "visa":
                    CardNumber = "4111111111111111";
                    SOAPCardType = "Visa";
                    SOAPLastfourdigit = "8291";
                    break;
                case "master":
                    CardNumber = "5555555555554444";
                    SOAPCardType = "Mastercard";
                    SOAPLastfourdigit = "5454";
                    break;
                case "amex":
                    CardNumber = "378282246310005";
                    SOAPCardType = "Amex";
                    SOAPLastfourdigit = "8431";
                    break;
                case "discover":
                    CardNumber = "6011111111111117";
                    SOAPCardType = "Discover";
                    SOAPLastfourdigit = "1234";
                    if (Country.ToLower().Trim() != "usa")
                        Assert.Fail("Discover Card Payment is only applicable to USA. Current Country: " + Country);
                    break;
                default:
                    break;
            }
            Console.WriteLine("I am in Paymetus Page");
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                case "qa2":

                    string month = "05 - May";
                    string ccyear = "2020";
                    string AccNumber = " ";
                    System.Threading.Thread.Sleep(4000);
                    UIAction(linkPartnerAddPayment, string.Empty, "a");
                    //WaitFor(linkPartnerAddPayment);
                    //linkPartnerAddPayment.Click();
                    WaitUntilElementVisible(driver, By.Id("creditCardTabLink"));
                    UIAction(linkPartnerCreditCard, string.Empty, "a");
                    System.Threading.Thread.Sleep(3000);
                    driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='PaymentIframe']")));

                    UIAction(txtPartnerCardNumber, CardNumber, "textbox");
                    pause();
                    UIAction(txtPartnerCardExpirationDate, "12/22", "textbox");
                    if (Country.ToLower().Trim() == "usa")
                    {
                        UIAction(txtPartnerzip, "54956", "textbox");
                    }
                    else
                    {
                        UIAction(txtPartnerzip, "T4R3P2", "textbox");
                    }

                    UIAction(btnPartnerSaveAccount, string.Empty, "a");

                    driver.SwitchTo().DefaultContent();

                    System.Threading.Thread.Sleep(3000);

                    WaitUntilElementVisible(driver, By.Id("autopay"));
                   
                    if (AutoPay.ToLower().Trim() == "yes")

                    {
                        Console.WriteLine("I am in Auto Pay");
                        JavaScriptClick(driver.FindElement(By.CssSelector(chckPartnerAutoPay)));
                        //UIAction(chckPartnerAutoPay, string.Empty, "a");
                    }
                    pause();
                    UIAction(submitApplicationPartnerMode, string.Empty, "a");
                    System.Threading.Thread.Sleep(5000);
                    break;


                default:

                    RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                    System.Threading.Thread.Sleep(15000);
                    string sAccountNumber;
                    IWebElement IWAccountNumber = driver.FindElement(By.XPath("//span[@data-bind='text: $root.reviewViewModel().accountNumber']"));
                    sAccountNumber = IWAccountNumber.GetAttribute("innerHTML");
                    Console.WriteLine("Account Number: {0} value is ", sAccountNumber);
                    ScenarioContext.Current["ACCOUNT"] = sAccountNumber;
                    RegKey.SetValue("ACCNO", sAccountNumber);

                    // IWebElement Account_Dom = driver.FindElement(By.XPath("//span[contains(text(),'text: $root.reviewViewModel().accountNumber')]"));
                    //AccNumber = Account_Dom.GetAttribute("text");
                    // Console.WriteLine("Account number fetched is " + AccNumber);
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
                            paymentusWSDL = "http://JTN-VM-SVC015/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;


                    }
                    string soapString = "";
                    string soapaction = "http://tempuri.org/IExternalPayment/PaymentNotification";

                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(paymentusWSDL);
                    webRequest.Headers.Add("SOAPAction", soapaction);
                    webRequest.ContentType = "text/xml;charset=\"utf-8\"";
                    webRequest.Accept = "text/xml";
                    webRequest.Method = "POST";

                    XmlDocument SOAPReqBody = new XmlDocument();
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
                                      <CreditCardExpDate>2019-07-01T00:00:00</CreditCardExpDate>
                                      <CreditCardIssuer>Card_Type</CreditCardIssuer>
                                     <IsActive>true</IsActive>
                                      <LastFourDigits>Lastfourdigit</LastFourDigits>
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
                    soapString = soapString.Replace("AccNumber", sAccountNumber);
                    soapString = soapString.Replace("AUTHCODE", authCode);
                    soapString = soapString.Replace("Card_Type", SOAPCardType);
                    soapString = soapString.Replace("Lastfourdigit", SOAPLastfourdigit);
                    soapString = soapString.Replace("REFNUMBER", RefNumber);
                    soapString = soapString.Replace("TXNNUMBER", TxnRefNumber);

                    XmlDocument soapEnvelopeDocument = new XmlDocument();
                    soapEnvelopeDocument.LoadXml(soapString);

                    using (Stream stream = webRequest.GetRequestStream())
                    {
                        soapEnvelopeDocument.Save(stream);
                    }
                    Console.WriteLine("XML SOAP : " + soapString);
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

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

                    break;

            }

        }
        public void MakePartnerModeACHPayment(string AchType, string Country, string AutoPay)
        {
            string SOAPCardType = "";
            switch (AchType.ToLower().Trim())
            {
                case "saving":
                case "savings":
                    SOAPCardType = "Savings";
                    break;
                case "checking":
                    SOAPCardType = "Checking";
                    break;
                default:
                    break;
            }

            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                case "qa2":
                    IList<IWebElement> PartnerRoutingNumber;
                    IList<IWebElement> PartnerAccountNumber;
                    IList<IWebElement> PartnerAuthorize;
                    IList<IWebElement> PartnerSaveBankAccount;
                    IList<IWebElement> PartnerAddPaymentMethod;

                    //   WaitFor(linkPartnerAddPayment);
                    //  pause();
                    System.Threading.Thread.Sleep(4000);
                    WaitUntilElementVisible(driver, By.XPath("//a[@id='addPaymentPopupLink']"));

                    PartnerAddPaymentMethod = driver.FindElements(By.XPath("//a[@id='addPaymentPopupLink']")).ToList();
                    JavaScriptClick(PartnerAddPaymentMethod[0]);
                    pause();
                    WaitUntilElementVisible(driver, By.Id("ACHTabLink"));
                    UIAction(linkPartnerBankAccount, string.Empty, "a");
                    System.Threading.Thread.Sleep(3000);
                    WaitUntilElementVisible(driver, By.XPath("//iframe[@id='PaymentIframe']"));
                    driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='PaymentIframe']")));


                    //WaitUntilElementVisible(driver, By.Id("addPaymentPopupLink"));
                    //UIAction(linkPartnerAddPayment, string.Empty, "a");
                    // linkPartnerAddPayment.Click();
                    //UIAction(linkPartnerAddPayment, string.Empty, "a");

                    //WaitUntilElementVisible(driver, By.Id("routingNumberField"));

                    //PartnerRoutingNumber = driver.FindElements(By.XPath("//input[@id='routingNumberField']")).ToList();
                    //Console.WriteLine(" PartnerRoutingNumber count is " + PartnerRoutingNumber.Count());
                    ////PartnerRoutingNumber[0].SendKeys("021210073");

                    //PartnerAccountNumber = driver.FindElements(By.XPath("//input[@id='bankAccountField']")).ToList();
                    //Console.WriteLine(" PartnerAccountNumber count is " + PartnerAccountNumber.Count());
                    ////PartnerAccountNumber[0].SendKeys("222343332");


                    UIAction(txtPartnerEcheckRoutingNumber, "021210073", "textbox");
                    pause();
                    UIAction(txtPartnerEcheckAccountNumber, "222343332", "textbox");
                    pause();

                    AchAccountType = driver.FindElements(By.XPath("//label[@class='form-check-label']")).ToList();
                    Console.WriteLine("AchAccountType count is " + AchAccountType.Count());
                    Console.WriteLine("Account ype is " + AchType.ToLower().Trim());
                    switch (AchType.ToLower().Trim())
                    {
                        case "saving":
                        case "savings":
                            AchAccountType[1].Click();
                            //Console.WriteLine("Inside saving logic");
                            //IWebElement SavingAchType = driver.FindElement(By.XPath("//input[@id='savings']"));
                            //SavingAchType.Click();
                            pause();
                            break;
                        case "checking":
                            //IWebElement CheckingAchType = driver.FindElement(By.XPath("//input[@id='checking']"));
                            //CheckingAchType.Click();
                            AchAccountType[0].Click();
                            pause();
                            break;
                        default:
                            break;
                    }

                    PartnerAuthorize = driver.FindElements(By.XPath("//input[@id='achAgree']")).ToList();
                    Console.WriteLine("PartnerAuthorize count is " + PartnerAuthorize.Count());
                    JavaScriptClick(PartnerAuthorize[0]);
                    //PartnerAuthorize[0].Click();

                    //UIAction(chckboxPartnerAuthorize, string.Empty, "a");
                    //pause();
                    //  PartnerSaveBankAccount


                    //PartnerSaveBankAccount = driver.FindElements(By.XPath("//button[@name='submitBtn']")).ToList();
                    //Console.WriteLine("PartnerSaveBankAccount count is " + PartnerSaveBankAccount.Count());
                    //PartnerSaveBankAccount[0].Click();

                    UIAction(btnPartnerSaveAccount, string.Empty, "a");
                    driver.SwitchTo().DefaultContent();

                    System.Threading.Thread.Sleep(3000);

                    WaitUntilElementVisible(driver, By.Id("autopay"));
                    if (AutoPay.ToLower().Trim() == "yes")
                    {
                        Console.WriteLine("I am in Auto Pay");
                        UIAction(chckPartnerAutoPay, string.Empty, "a");
                    }
                    pause();
                    UIAction(submitApplicationPartnerMode, string.Empty, "a");
                    System.Threading.Thread.Sleep(5000);
                    break;

                default:
                    RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                    System.Threading.Thread.Sleep(15000);
                    string sAccountNumber;
                    IWebElement IWAccountNumber = driver.FindElement(By.XPath("//span[@data-bind='text: $root.reviewViewModel().accountNumber']"));
                    sAccountNumber = IWAccountNumber.GetAttribute("innerHTML");
                    Console.WriteLine("Account Number: {0} value is ", sAccountNumber);
                    ScenarioContext.Current["ACCOUNT"] = sAccountNumber;
                    RegKey.SetValue("ACCNO", sAccountNumber);
                    Console.WriteLine("In SOAP for ACH");
                    // IWebElement Account_Dom = driver.FindElement(By.XPath("//span[contains(text(),'text: $root.reviewViewModel().accountNumber')]"));
                    //AccNumber = Account_Dom.GetAttribute("text");
                    // Console.WriteLine("Account number fetched is " + AccNumber);
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
                            paymentusWSDL = "http://JTN-VM-SVC015/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;

                    }
                    string soapString = "";
                    string soapaction = "http://tempuri.org/IExternalPayment/PaymentNotification";

                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(paymentusWSDL);
                    webRequest.Headers.Add("SOAPAction", soapaction);
                    webRequest.ContentType = "text/xml;charset=\"utf-8\"";
                    webRequest.Accept = "text/xml";
                    webRequest.Method = "POST";

                    XmlDocument SOAPReqBody = new XmlDocument();
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
                      <BankAccountType>Bank_Type</BankAccountType>
                      <IsActive>true</IsActive>
                      <LastFourDigits>3332</LastFourDigits>
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
                    soapString = soapString.Replace("AccNumber", sAccountNumber);
                    soapString = soapString.Replace("AUTHCODE", authCode);
                    soapString = soapString.Replace("Bank_Type", SOAPCardType);
                    soapString = soapString.Replace("REFNUMBER", RefNumber);
                    soapString = soapString.Replace("TXNNUMBER", TxnRefNumber);
                    XmlDocument soapEnvelopeDocument = new XmlDocument();
                    soapEnvelopeDocument.LoadXml(soapString);
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine(soapString);
                    Console.WriteLine("************************************************************************");


                    using (Stream stream = webRequest.GetRequestStream())
                    {
                        soapEnvelopeDocument.Save(stream);
                    }

                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

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

                    break;
            }

        }

        public void MakeACHPayment(string AchType, string Country, string AutoPay)
        {
            string SOAPCardType = "";
            switch (AchType.ToLower().Trim())
            {
                case "saving":
                case "savings":
                    SOAPCardType = "Savings";
                    break;
                case "checking":
                    SOAPCardType = "Checking";
                    break;
                default:
                    break;
            }

            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                case "qa2":
                    WaitUntilElementVisible(driver, By.Id("echeck-group-heading"));
                    pause();
                    radioEcheckAccType.Click();
                    pause();
                    AchAccountType = driver.FindElements(By.XPath("//span[@class='standard-label-msg']")).ToList();
                    Console.WriteLine("AchAccountType count is " + AchAccountType.Count());
                    switch (AchType.ToLower().Trim())
                    {
                        case "saving":
                        case "savings":
                            AchAccountType[1].Click();
                            pause();
                            break;
                        case "checking":
                            AchAccountType[0].Click();
                            pause();
                            break;
                        default:
                            break;
                    }
                    if (Country.ToLower().Trim() == "usa")
                    {
                        UIAction(txtEcheckRoutingNumber, "021210073", "textbox");
                        pause();
                    }
                    else
                    {

                        UIAction(txtbankTransitNumber, "00420", "textbox");
                        pause();
                        UIAction(txtbankInstitutionId, "010", "textbox");

                        pause();
                    }
                    UIAction(txtEcheckAccountNumber, "222343332", "textbox");
                    pause();
                    UIAction(txtEcheckAccountHolder, "Selenium ACH Payment", "textbox");
                    pause();

                    //AuthorizeAchPayment = driver.FindElements(By.XPath("//span[@class='standard-label-msg ach']")).ToList();
                    //Console.WriteLine("AuthorizeAchPayment count is " + AuthorizeAchPayment.Count());
                    //AuthorizeAchPayment[0].Click();
                    pause();
                    if (AutoPay.ToLower().Trim() == "no")
                    {
                        UIAction(chckAutoPay, string.Empty, "a");
                    }
                    AuthroizePayment();
                    break;
                default:
                    RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
                    System.Threading.Thread.Sleep(15000);
                    string sAccountNumber;
                    IWebElement IWAccountNumber = driver.FindElement(By.XPath("//span[@data-bind='text: $root.reviewViewModel().accountNumber']"));
                    sAccountNumber = IWAccountNumber.GetAttribute("innerHTML");
                    Console.WriteLine("Account Number: {0} value is ", sAccountNumber);
                    ScenarioContext.Current["ACCOUNT"] = sAccountNumber;
                    RegKey.SetValue("ACCNO", sAccountNumber);
                    Console.WriteLine("In SOAP for ACH");
                    // IWebElement Account_Dom = driver.FindElement(By.XPath("//span[contains(text(),'text: $root.reviewViewModel().accountNumber')]"));
                    //AccNumber = Account_Dom.GetAttribute("text");
                    // Console.WriteLine("Account number fetched is " + AccNumber);
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
                            paymentusWSDL = "http://JTN-VM-SVC015/ExternalPaymentService/ExternalPayment.svc?wsdl";
                            break;


                    }
                    string soapString = "";
                    string soapaction = "http://tempuri.org/IExternalPayment/PaymentNotification";

                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(paymentusWSDL);
                    webRequest.Headers.Add("SOAPAction", soapaction);
                    webRequest.ContentType = "text/xml;charset=\"utf-8\"";
                    webRequest.Accept = "text/xml";
                    webRequest.Method = "POST";

                    XmlDocument SOAPReqBody = new XmlDocument();
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
                      <BankAccountType>Bank_Type</BankAccountType>
                      <IsActive>true</IsActive>
                      <LastFourDigits>3332</LastFourDigits>
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
                    soapString = soapString.Replace("AccNumber", sAccountNumber);
                    soapString = soapString.Replace("AUTHCODE", authCode);
                    soapString = soapString.Replace("Bank_Type", SOAPCardType);
                    soapString = soapString.Replace("REFNUMBER", RefNumber);
                    soapString = soapString.Replace("TXNNUMBER", TxnRefNumber);
                    XmlDocument soapEnvelopeDocument = new XmlDocument();
                    soapEnvelopeDocument.LoadXml(soapString);

                    using (Stream stream = webRequest.GetRequestStream())
                    {
                        soapEnvelopeDocument.Save(stream);
                    }

                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

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

                    break;
            }

        }

        public void AuthroizePayment()
        {
            JavaScriptClick(driver.FindElement(By.Name("continueButton")));
            Console.WriteLine("------------------------------------------------------Next Page");
            WaitUntilElementVisible(driver, By.CssSelector(submitApplication), 100);
            IWebElement IacceptTerms = driver.FindElement(By.Id("acceptTermsAndConditions-1"));
            ScrollDownTillElement(driver, IacceptTerms);
            JavaScriptClick(IacceptTerms);
            UIAction(submitApplication, string.Empty, "a");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Paymentus completed");
        }


    }
}

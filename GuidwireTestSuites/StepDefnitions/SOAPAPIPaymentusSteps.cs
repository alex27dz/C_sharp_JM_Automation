//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TechTalk.SpecFlow;
//using SOAPApi;
//using System.Windows.Forms;
//using System.Net;
//using System.Xml;
//using System.IO;
//using SoapHttpClient;


//namespace GuidewireTestSuites.StepDefnitions
//{
//    [Binding]
//    public class SOAPAPIPaymentusSteps
//    {
//        [Given(@"I Accessed Paymentus soap api in (.*) environment")]
//        public void GivenIAccessedPaymentusSoapApiInQAEnvironment(string environment)
//        {

//            //   ServiceReference1.ExternalPaymentClient client = new ServiceReference1.ExternalPaymentClient();
//            //   client.BeginClaimPaymentNotification()

//            // local.jewelersnt.jmtsvc01.ClaimPaymentAdviceRequest abc = new local.jewelersnt.jmtsvc01()



//            SOAPGeneric soapGen = new SOAPGeneric();
//            //var _url = "http://jmtsvc01.jewelersnt.local/ExternalPaymentService/ExternalPayment.svc>";
//            var _url = "http://jmtsvc01.jewelersnt.local/ExternalPaymentService/ExternalPayment.svc?Wsdl";
//            var _action = "http://jmtsvc01.jewelersnt.local/ExternalPaymentService/ExternalPayment.svc?wsdl";
//            string soapEnv = @"<?xml version=""1.0"" encoding=""utf-8""?>
//<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
//  <soap:Body>
//    <PaymentNotification xmlns =""http://tempuri.org/"">
//        <request>
//          <AccountNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">3000719577</AccountNumber>
//            <Amount xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">147.00</Amount>
//             <ApplicationName xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">NEW_BUSINESS</ApplicationName>
//              <AuthorizationCode xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">12319577</AuthorizationCode>
//              <CardInfo xmlns=""http://jewelersmutual.com/externalpayment/2016/01"" >
//              <AutoPay>false</AutoPay>
//              <CreditCardExpDate>2018-04-01T00:00:00</CreditCardExpDate>
//              <CreditCardIssuer>Mastercard</CreditCardIssuer>
//              <IsActive>true</IsActive>
//              <LastFourDigits>3546</LastFourDigits>
//              </CardInfo>
//                  <PayeeContactInfo xmlns = ""http://jewelersmutual.com/externalpayment/2016/01"">
//                  <BillingPostalCode>54956</BillingPostalCode>
//                  <Country>US</Country>
//                  <FirstName>Vipin</FirstName>
//                  <LastName>Kumar</LastName>
//                  <PayeeName>Vipin Test</PayeeName>
//                  <PhoneNumber>901-456-9087</PhoneNumber>
//                  </PayeeContactInfo>
//               <PaymentStatus xmlns = ""http://jewelersmutual.com/externalpayment/2016/01"">ACCEPTED</PaymentStatus>
//               <ReferenceNumber xmlns = ""http://jewelersmutual.com/externalpayment/2016/01"">128F6DD9C08225921718852BB8D347B1714F1577</ReferenceNumber>
//               <TxnRefNumber xmlns = ""http://jewelersmutual.com/externalpayment/2016/01"">20419577</TxnRefNumber>
//            </request>
//        </PaymentNotification>
//      </soap:Body>
//      </soap:Envelope>";

//            //using (WebClient wc = new WebClient())
//            //{
//            //    var result = wc.UploadString(_url, soapEnv);
//            //}

//            ASCIIEncoding encoder = new ASCIIEncoding();
//            byte[] data = encoder.GetBytes(soapEnv);


//            //   XmlDocument soapEnvelopXML = soapGen.CreateSoapEnvelop(soapEnv);

//            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_url);

//            webRequest.Headers.Add(@"SOAP:Action");


//            webRequest.ContentType = "text/xml;charset=\"utf-8\"";

//           webRequest.ContentLength = data.Length;

//            webRequest.Accept = "text/xml";

//            webRequest.Method = "POST";

//            XmlDocument soapEnvelop = new XmlDocument();

//            soapEnvelop.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
//<p1:Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance"">
//  <p1:Body>
//    <PaymentNotification xmlns=""http://tempuri.org/"">
//      <request>
//        <AccountNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">3000719832</AccountNumber>
//        <Amount xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">147.00</Amount>
//        <ApplicationName xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">NEW_BUSINESS</ApplicationName>
//        <AuthorizationCode xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">12319832</AuthorizationCode>
//        <CardInfo xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">
//          <AutoPay>false</AutoPay>
//          <CreditCardExpDate>2018-04-01T00:00:00</CreditCardExpDate>
//          <CreditCardIssuer>Mastercard</CreditCardIssuer>
//          <IsActive>true</IsActive>
//          <LastFourDigits>3546</LastFourDigits>
//        </CardInfo>
//        <PayeeContactInfo xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">
//          <BillingPostalCode>54956</BillingPostalCode>
//          <Country>US</Country>
//          <FirstName>Vipin</FirstName>
//          <LastName>Kumar</LastName>
//          <PayeeName>Vipin Test</PayeeName>
//          <PhoneNumber>901-456-9087</PhoneNumber>
//        </PayeeContactInfo>
//        <PaymentStatus xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">ACCEPTED</PaymentStatus>
//        <ReferenceNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">128F6DD9C08225921718852BB8D347B1714F1832</ReferenceNumber>
//        <TxnRefNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">20419832</TxnRefNumber>
//      </request>
//    </PaymentNotification>
//  </p1:Body>
//</p1:Envelope>");


//            //<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
//            //  <soap:Body>
//            //    <PaymentNotification xmlns =""http://tempuri.org/"">
//            //        <request>
//            //          <AccountNumber xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">3000719577</AccountNumber>
//            //            <Amount xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">147.00</Amount>
//            //             <ApplicationName xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">NEW_BUSINESS</ApplicationName>
//            //              <AuthorizationCode xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">12319577</AuthorizationCode>
//            //              <CardInfo xmlns=""http://jewelersmutual.com/externalpayment/2016/01"">
//            //              <AutoPay>false</AutoPay>
//            //              <CreditCardExpDate>2018-04-01</CreditCardExpDate>
//            //              <CreditCardIssuer>Mastercard</CreditCardIssuer>
//            //              <IsActive>true</IsActive>
//            //              <LastFourDigits>3546</LastFourDigits>
//            //              </CardInfo>
//            //                  <PayeeContactInfo xmlns = ""http://jewelersmutual.com/externalpayment/2016/01"">
//            //                  <BillingPostalCode>54956</BillingPostalCode>
//            //                  <Country>US</Country>
//            //                  <FirstName>Vipin</FirstName>
//            //                  <LastName>Kumar</LastName>
//            //                  <PayeeName>Vipin Test</PayeeName>
//            //                  <PhoneNumber>901-456-9087</PhoneNumber>
//            //                  </PayeeContactInfo>
//            //               <PaymentStatus xmlns = ""http://jewelersmutual.com/externalpayment/2016/01"">ACCEPTED</PaymentStatus>
//            //               <ReferenceNumber xmlns = ""http://jewelersmutual.com/externalpayment/2016/01"">128F6DD9C08225921718852BB8D347B1714F1577</ReferenceNumber>
//            //               <TxnRefNumber xmlns = ""http://jewelersmutual.com/externalpayment/2016/01"">20419577</TxnRefNumber>
//            //            </request>
//            //        </PaymentNotification>
//            //      </soap:Body>
//            //      </soap:Envelope>");





//            //   soapGen.InsertSoapEnvelopIntoWebRequest(soapEnvelopXML, webRequest);

//            //    begin ASYNC call to the WebRequest
////                   IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

//      //       asyncResult.AsyncWaitHandle.WaitOne();

//            using (Stream dataStream = webRequest.GetRequestStream())
//            {
//                dataStream.Write(data, 0, data.Length);
//            }

//            //using (Stream stm = webRequest.GetRequestStream())
//            //{
//            //    using (StreamWriter stmw = new StreamWriter(stm))
//            //    {
//            //        stmw.Write(soapEnvelop);
//            //    }
//            //}


//            //using (Stream stream = webRequest.GetRequestStream())
//            //{
//            //     soapEnvelop.Save(stream);

//            //   // stream.Write(soapEnvelop);
//            //}
//            string soapResult;

//            //   get the response from the completed webrequest
//          //  using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
//              using (WebResponse webResponse = webRequest.GetResponse())
//           {
//                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
//                {
//                    soapResult = rd.ReadToEnd();

//                    Console.WriteLine("SoapREsult :" + soapResult);
//                }

//            }
            

//        }

//    }
//}

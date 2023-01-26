using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;

namespace SOAPApi
{
    public class SOAPGeneric
    {
        public HttpWebRequest  CreateWebRequest(string URL, string Action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(URL);

            webRequest.Headers.Add("SOAPAction", Action);

            webRequest.ContentType = "text/xml;charset=\"utf-8\"";

            webRequest.Accept = "text/xml";

            webRequest.Method = "POST";

            return webRequest;
        }

        public XmlDocument CreateSoapEnvelop(string soapXML)
        {
            Console.WriteLine("$$$"+ soapXML);
            XmlDocument soapEnvelop = new XmlDocument();

            soapEnvelop.LoadXml(soapXML);

            return soapEnvelop;
        }

        public void InsertSoapEnvelopIntoWebRequest(XmlDocument soapEnvXML, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvXML.Save(stream);
            }
        }

        //public void CallWebService()
        //{
        //    var _url = ".asmx";
        //    var _action = ".asmx?op=HelloWorld";
        //    string soapEnv = @"<SOAP-ENV:Envelop.......";

        //    XmlDocument soapEnvelopXML = CreateSoapEnvelop(soapEnv);

        //    HttpWebRequest webRequest = CreateWebRequest(_url , _action);

        //    InsertSoapEnvelopIntoWebRequest(soapEnvelopXML, webRequest);

        //    //begin ASYNC call to the WebRequest
        //    IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

        //    asyncResult.AsyncWaitHandle.WaitOne();

        //    string soapResult;

        //    //get the response from the completed webrequest
        //    using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
        //    {
        //        using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
        //        {
        //            soapResult = rd.ReadToEnd();
        //        }
        //        Console.WriteLine("SoapREsult :"+ soapResult);
        //    }

        //}
    }
}

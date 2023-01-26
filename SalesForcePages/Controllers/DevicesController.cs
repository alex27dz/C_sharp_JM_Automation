using Newtonsoft.Json;
using SalesForcePages.Models.MobileAdminApi.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SalesForcePages.Controllers
{
    public class DevicesController
    {
        public string devicesGet(string apiUrl, string apiOperation, string deviceId)
        {
            HttpWebRequest httpWebRequest = null;

            string getUrl = apiUrl + "/" + deviceId;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(getUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
           

            Console.WriteLine("Hash Code:" + httpResponse.StatusCode);
            
            ScenarioContext.Current.Add("ResponseCode", httpResponse.StatusCode);

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ScenarioContext.Current.Add("Response", result);
                Console.WriteLine("Content is " + ScenarioContext.Current["Response"].ToString());
            }
            
            return ScenarioContext.Current["Response"].ToString();
        }

        public string devicesPost(string apiUrl, string apiOperation, DevicePostModel deviceModel)
        {
            HttpWebRequest httpWebRequest = null;
            string json = null;
                        
            httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;
            
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(deviceModel);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            Console.WriteLine("JSON" + json);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string locaHeader = httpResponse.Headers.Get("Location");
            Console.WriteLine("Hash Code:" + httpResponse.StatusCode);
            Console.WriteLine("Location Header:" + locaHeader);

            string[] ids = locaHeader.Split('/');


            ScenarioContext.Current["DeviceID"] = ids[ids.Length-1];

            ScenarioContext.Current.Add("ResponseCode", httpResponse.StatusCode);

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ScenarioContext.Current.Add("Response", result);
                Console.WriteLine("Content is " + ScenarioContext.Current["Response"].ToString());
            }

            return ScenarioContext.Current["Response"].ToString();
        }

        public string devicesPut(string apiUrl, string apiOperation, string deviceId, DevicePutModel deviceModel)
        {
      
            HttpWebRequest httpWebRequest = null;
            string json = null;

            string putUrl = apiUrl + "/" + deviceId;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(putUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(deviceModel);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            Console.WriteLine("JSON" + json);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
           
            Console.WriteLine("Hash Code:" + httpResponse.StatusCode);
           
            ScenarioContext.Current.Add("ResponseCode", httpResponse.StatusCode);

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ScenarioContext.Current.Add("Response", result);
                Console.WriteLine("Content is " + ScenarioContext.Current["Response"].ToString());
            }

            return ScenarioContext.Current["Response"].ToString();
        }

        public string devicesDelete(string apiUrl, string apiOperation, string deviceId)
        {
            HttpWebRequest httpWebRequest = null;

            string getUrl = apiUrl + "/" + deviceId;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(getUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();


            Console.WriteLine("Hash Code:" + httpResponse.StatusCode);

            ScenarioContext.Current.Add("ResponseCode", httpResponse.StatusCode);

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ScenarioContext.Current.Add("Response", result);
                Console.WriteLine("Content is " + ScenarioContext.Current["Response"].ToString());
            }

            return ScenarioContext.Current["Response"].ToString();
        }

        public object getAPIResponse(string destinationUrl, string apiOperation, object viewModel)
        {
            HttpWebRequest httpWebRequest = null;

            httpWebRequest = (HttpWebRequest)WebRequest.Create(destinationUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            switch (apiOperation.ToLower().Trim())
            {

                case "post":
                case "put":
                    string json = null;
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        json = JsonConvert.SerializeObject(viewModel);

                        streamWriter.Write(json);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }

                    Console.WriteLine("JSON" + json);
                    break;
                default:
                    break;
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            Console.WriteLine("Hash Code:" + httpResponse.StatusCode);

            ScenarioContext.Current.Add("ResponseCode", httpResponse.StatusCode);

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ScenarioContext.Current.Add("Response", result);
                Console.WriteLine("Content is " + ScenarioContext.Current["Response"].ToString());
            }

            return ScenarioContext.Current["Response"].ToString();

        }

    }
}

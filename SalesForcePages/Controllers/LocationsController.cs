using Newtonsoft.Json;
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
    public class LocationsController
    {
        public string locationsGet(string apiUrl, string apiOperation, string id )
        {
            HttpWebRequest httpWebRequest = null;

            string getUrl = null;

            if (id.Trim() != "")
                getUrl = apiUrl + "/" + id;
            else
                getUrl = apiUrl;
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


        public string locationsGetUsers(string apiUrl, string apiOperation, string id, string isManager, string isListed, string hydrate, string count)
        {
            HttpWebRequest httpWebRequest = null;

            string getUrl = null;

            if (id.Trim() != "")
                getUrl = apiUrl + "/" + id + "/Users";

            if(isManager.Trim() != "" || isListed.Trim() != "" || hydrate.Trim() != "" || count.Trim() != "")
                getUrl = getUrl + "?";

            if (isManager.Trim() != "")
                getUrl = getUrl + "isManager="+ isManager + "&";

            if (isListed.Trim() != "")
                getUrl = getUrl + "isListed=" + isListed + "&";

            if (hydrate.Trim() != "")
                getUrl = getUrl + "hydrate=" + hydrate + "&";

            if (count.Trim() != "")
                getUrl = getUrl + "count=" + count + "&";

            if (getUrl.EndsWith("&"))
                getUrl = getUrl.Remove(getUrl.Length - 1, 1);

            Console.Write("URL"+ getUrl);

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


        public string locationsGetDevices(string apiUrl, string apiOperation, string id)
        {
            HttpWebRequest httpWebRequest = null;

            string getUrl = null;

            if (id.Trim() != "")
                getUrl = apiUrl + "/" + id + "/Devices";

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



    }
}

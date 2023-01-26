using Newtonsoft.Json;
using SalesForcePages.Models.MobileAdminApi.Users;
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
    public class UsersController
    {
        public string userGet(string apiUrl, string apiOperation, string id, string isManager, string isListed)
        {
            HttpWebRequest httpWebRequest = null;

            string getUrl = null;

            if (id.Trim() != "")
                getUrl = apiUrl + "/" + id + "/Locations";

            if (isManager.Trim() != "" || isListed.Trim() != "")
                getUrl = getUrl + "?";

            if (isManager.Trim() != "")
                getUrl = getUrl + "isManager=" + isManager + "&";

            if (isListed.Trim() != "")
                getUrl = getUrl + "isListed=" + isListed + "&";

            if (getUrl.EndsWith("&"))
                getUrl = getUrl.Remove(getUrl.Length - 1, 1);

            Console.Write("URL" + getUrl);

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


        public string userGetUserLocation(string apiUrl, string apiOperation, string id, string hydrate)
        {
            HttpWebRequest httpWebRequest = null;

            string getUrl = null;

            if (id.Trim() != "")
                getUrl = apiUrl + "/" + id + "/Users";


            if (hydrate.Trim() != "")
                getUrl = getUrl + "hydrate=" + hydrate + "&";

            if (getUrl.EndsWith("&"))
                getUrl = getUrl.Remove(getUrl.Length - 1, 1);

            Console.Write("URL" + getUrl);

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

        public string userPutUserLocation(string apiUrl, string apiOperation, string userId, string locationId, UserLocationModel userLocationModel)
        {

            HttpWebRequest httpWebRequest = null;
            string json = null;

            string putUrl = apiUrl + "/" + userId + "/Locations/" + locationId;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(putUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(userLocationModel);

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

        public string userPutUserPassword(string apiUrl, string apiOperation, string Id,  UserPasswordModel userPasswordModel)
        {

            HttpWebRequest httpWebRequest = null;
            string json = null;

            string putUrl = apiUrl + "/" + Id + "/Password";
            httpWebRequest = (HttpWebRequest)WebRequest.Create(putUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(userPasswordModel);

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

        public string userPut(string apiUrl, string apiOperation, string Id, object userModel)
        {

            HttpWebRequest httpWebRequest = null;
            string json = null;

            string putUrl = apiUrl + "/" + Id;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(putUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(userModel);

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

        public string userDelete(string apiUrl, string apiOperation, string userId)
        {
            HttpWebRequest httpWebRequest = null;

            string deleteUrl = apiUrl + "/" + userId;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(deleteUrl);
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

        public string userDeleteUserLocation(string apiUrl, string apiOperation, string userId, string locationId)
        {
            HttpWebRequest httpWebRequest = null;

            string deleteUrl = apiUrl + "/" + userId + "/Locations/" +  locationId;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(deleteUrl);
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

        public string userPost(string apiUrl, string apiOperation, object userModel)
        {
            HttpWebRequest httpWebRequest = null;
            string json = null;

            httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(userModel);

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


            ScenarioContext.Current["UserID"] = ids[ids.Length - 1];

            ScenarioContext.Current.Add("ResponseCode", httpResponse.StatusCode);

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ScenarioContext.Current.Add("Response", result);
                Console.WriteLine("Content is " + ScenarioContext.Current["Response"].ToString());
            }

            return ScenarioContext.Current["Response"].ToString();
        }

        public string userPostLogin(string apiUrl, string apiOperation, UserLoginModel userLoginModel)
        {
            HttpWebRequest httpWebRequest = null;
            string json = null;

            string postUrl = apiUrl + "/Login";
            httpWebRequest = (HttpWebRequest)WebRequest.Create(postUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(userLoginModel);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            Console.WriteLine("JSON" + json);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string locaHeader = httpResponse.Headers.Get("Location");
            Console.WriteLine("Hash Code:" + httpResponse.StatusCode);
            Console.WriteLine("Location Header:" + locaHeader);

              ScenarioContext.Current.Add("ResponseCode", httpResponse.StatusCode);

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ScenarioContext.Current.Add("Response", result);
                Console.WriteLine("Content is " + ScenarioContext.Current["Response"].ToString());
            }

            return ScenarioContext.Current["Response"].ToString();
        }

        public string userPostUserLocation(string apiUrl, string apiOperation, UserLocationModel userLocationModel)
        {
            HttpWebRequest httpWebRequest = null;
            string json = null;

            string postUrl = apiUrl + "/Locations";
            httpWebRequest = (HttpWebRequest)WebRequest.Create(postUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = apiOperation;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(userLocationModel);

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


            ScenarioContext.Current["UserID"] = ids[ids.Length - 1];

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

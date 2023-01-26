using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;
using BoltPages;
using BoltPages.Models;
using System.IO;
using Newtonsoft.Json;
using TechTalk.SpecFlow.Assist;
using BoltPages.Pages.QNA;
using Microsoft.Win32;
using AutomationFramework;
using HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;
using System.Xml;


namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class BOLT_QNA_Steps : WebCommonCore.TestBase
    {

        HttpWebRequest httpWebRequest = null;
        [Given(@"I execute BOLT API (.*) to perform (.*)")]
        public void GivenIExecuteBOLTAPIFullquotecreateboltToPerformPOST(string APIName, string APIOperation)
        {
            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];
            string API_url = "";
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    //API_url = "https://jm-s-ams-sharedapi.azure-api.net/qapi/v3/quote/fullquote";
                    API_url = "http://jmssvc01.jewelersnt.local/api/quote/v3/quote/fullquote";
                    break;
                case "qa4":
                    API_url = "http://jmtsvc04.jewelersnt.local/api/quote/v3/quote/fullquote";
                    break;
                case "qa6":
                    API_url = "https://jm-t-ams-sharedapi.azure-api.net/qapi/v3/quote/fullquote";
                    break;
                case "qa2":
                    API_url = "http://jmtsvc02.jewelersnt.local/api/quote/v3/quote/fullquote";
                    break;
            }
            switch (APIName.ToLower().Trim())
            {
                case "fullquotecreatebolt":
                    httpWebRequest = (HttpWebRequest)WebRequest.Create(API_url);
                    break;

            }

            string token = "34BA015D-AD88-41DE-BA18-EC04D71C024A|ab:686331";
            long ticks = DateTime.UtcNow.AddHours(1).Ticks;
            token = token + "|127.0.0.1|" + ticks.ToString();
            string auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(token));

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = APIOperation;
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    httpWebRequest.Headers.Add("ocp-apim-subscription-key", "a7325bbf74d74668af9bc1c82295f3d7");
                    break;
                case "qa6":
                    httpWebRequest.Headers.Add("ocp-apim-subscription-key", "baf2a786aeb249f4958c8c9566e8ab8e");
                    break;
                default:
                    break;
            }


            httpWebRequest.Headers.Add("X-AUTH-TOKEN", auth);
            httpWebRequest.Timeout = 80000;
            httpWebRequest.KeepAlive = false;

            ScenarioContext.Current.Add("httpWebRequest", httpWebRequest);
        }





        [When(@"I add Jewelry Item Details")]
        public void WhenIAddJewelryItemDetails(Table table)
        {
            IList<jewelryItems> jewelryitemsDetail = new List<jewelryItems>();

            string id = "";
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                jewelryItems jewelryitemsDetails = new jewelryItems();
                id = GetItemID(temp[0].ToString());
                jewelryitemsDetails.itemTypeId = id;
                jewelryitemsDetails.description = temp[0];
                jewelryitemsDetails.Value = temp[1];
                jewelryitemsDetail.Add(jewelryitemsDetails);


            }

            ScenarioContext.Current.Add("jewelryitemsDetails", jewelryitemsDetail);

        }
        [When(@"I Add producer code (.*)")]
        public void WhenIAddProducerCodeBD(string producer)
        {

        }


        [When(@"I Add other Details  (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIAddOtherDetailsAccountDuplicateJewelersParkDrNeenahWisconsinVsharmaJminsure_Com(string FirstName, string LastName, string Address, string Apartment, string City, string State, string AddressZipCode, string PhoneNumber, string EmailAddress, Table table)
        {
            CreateQuoteRootObject1 details = table.CreateInstance<CreateQuoteRootObject1>();
            RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium\Guidewire");
            if (!(FirstName.ToUpper().Equals("REGISTRY")))
            {
                FirstName = FirstName + GetUniqueValue();
                RegKey.SetValue("FNAME", FirstName);
                LastName = LastName + GetUniqueValue();
                RegKey.SetValue("LNAME", LastName);
                RegKey.SetValue("PRIMARY_INSURED", FirstName + " " + LastName);
            }
            else
            {
                DataStorage temp = new DataStorage();
                if (FirstName.ToUpper().Equals("REGISTRY"))
                {
                    FirstName = temp.GetTempValue("FNAME");
                    LastName = temp.GetTempValue("LNAME");
                }

            }
            if (EmailAddress.ToLower().Contains("unique"))
            {
                EmailAddress = GetUniqueValue() + "@jminsure.com";
            }
            else if (EmailAddress.ToLower().Equals("regedit"))
            {
                DataStorage temp = new DataStorage();
                EmailAddress = temp.GetTempValue("EMAIL");
            }
            RegKey.SetValue("EMAIL", EmailAddress);

            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();

                details.address1 = Address;
                details.address2 = Apartment;
                details.city = City;
                details.state = State;
                details.postalCode = AddressZipCode;
                if (temp[5].Length > 1)
                {
                    details.county = temp[5];
                }
                else
                {
                    details.county = "aaa";
                }

                details.countryId = temp[0];
                details.firstName = FirstName;
                details.lastName = LastName;
                details.emailAddress = EmailAddress;
                details.phoneNumber = PhoneNumber;
                details.agentId = temp[1];
                details.agentFirstName = temp[2];
                details.agentLastName = temp[3];
                if (temp[4].Length > 1)
                {
                    details.agencyProducerCode = temp[4];
                }

                ScenarioContext.Current.Add("addressLine1", Address);
                ScenarioContext.Current.Add("addressLine2", Apartment);
                ScenarioContext.Current.Add("city", City);
                ScenarioContext.Current.Add("state", State);
                ScenarioContext.Current.Add("postalCode", AddressZipCode);
                if (temp[5].Length > 1)
                {
                    ScenarioContext.Current.Add("county", temp[5]);
                }
                else
                {
                    ScenarioContext.Current.Add("county", "aaa");
                }

                ScenarioContext.Current.Add("countryId", temp[0]);
                ScenarioContext.Current.Add("firstName", FirstName);
                ScenarioContext.Current.Add("lastName", LastName);
                ScenarioContext.Current.Add("emailAddress", EmailAddress);
                ScenarioContext.Current.Add("phoneNumber", PhoneNumber);
                ScenarioContext.Current.Add("agentId", temp[1]);
                ScenarioContext.Current.Add("agentFirstName", temp[2]);
                ScenarioContext.Current.Add("agentLastName", temp[3]);
                if (temp[4].Length > 1)
                {
                    ScenarioContext.Current.Add("agencyProducerCode", temp[4]); ;
                }
                else
                {
                    ScenarioContext.Current.Add("agencyProducerCode", ""); ;
                }


            }

        }


        [When(@"I create API request with Policy Details")]
        public void WhenICreateAPIRequestWithPolicyDetails(Table table)
        {
            CreateQuoteRootObject1 apiRequest = table.CreateInstance<CreateQuoteRootObject1>();
            //apiRequest.addressLine1
            apiRequest.address1 = ScenarioContext.Current["addressLine1"].ToString();
            apiRequest.address2 = ScenarioContext.Current["addressLine2"].ToString();
            apiRequest.city = ScenarioContext.Current["city"].ToString();
            apiRequest.state = ScenarioContext.Current["state"].ToString();
            apiRequest.postalCode = ScenarioContext.Current["postalCode"].ToString();
            apiRequest.county = ScenarioContext.Current["county"].ToString();
            apiRequest.countryId = ScenarioContext.Current["countryId"].ToString();
            apiRequest.firstName = ScenarioContext.Current["firstName"].ToString();
            apiRequest.lastName = ScenarioContext.Current["lastName"].ToString();
            apiRequest.emailAddress = ScenarioContext.Current["emailAddress"].ToString();
            apiRequest.phoneNumber = ScenarioContext.Current["phoneNumber"].ToString();
            apiRequest.agentId = ScenarioContext.Current["agentId"].ToString();
            apiRequest.agentFirstName = ScenarioContext.Current["agentFirstName"].ToString();
            apiRequest.agentLastName = ScenarioContext.Current["agentLastName"].ToString();
            if (ScenarioContext.Current["agencyProducerCode"].ToString().Length > 1)
            {
                apiRequest.agencyProducerCode = ScenarioContext.Current["agencyProducerCode"].ToString();
            }
            apiRequest.jewelryItems = (List<jewelryItems>)ScenarioContext.Current["jewelryitemsDetails"];
            string json = "";
            HttpWebRequest httpWebRequest = (HttpWebRequest)ScenarioContext.Current["httpWebRequest"];
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(apiRequest);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            Console.WriteLine("JSON" + json);
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Console.WriteLine("Hash Code:" + httpResponse.StatusCode);
            ScenarioContext.Current.Add("ResponseCode", httpResponse.StatusCode);
            //if (httpResponse.StatusCode != HttpStatusCode.OK)
            //   Assert.Fail("Status code not 200");
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                ScenarioContext.Current.Add("Response", result);
                //   

                // string responseContent = httpResponse.ContentType.ReadAsStringAsync().ConfigureAwait(false);


                Console.WriteLine("Content is " + ScenarioContext.Current["Response"].ToString());

            }
        }


        [Then(@"I get API response")]
        [When(@"I get API response")]
        public void ThenIGetAPIResponse()
        {
            string response = ScenarioContext.Current["Response"].ToString();
            Console.WriteLine(response);
            var results = JsonConvert.DeserializeObject<dynamic>(response);
            Console.WriteLine("clientId is " + (results.data["clientId"]));
            ScenarioContext.Current.Add("clientId", results.data["clientId"]);

        }

        [Then(@"I get API response with failure")]
        public void ThenIGetAPIResponseWithFailure(Table table)
        {
            string response = ScenarioContext.Current["Response"].ToString();
            Console.WriteLine(response);
            var results = JsonConvert.DeserializeObject<dynamic>(response);
            Console.WriteLine("clientId is " + (results.errors[0]));
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                //String(results.errors[0];
                //Assert.IsTrue(results.errors[0].Contains(temp[0]), " doesn't contains 'Post published1.'");  
                Assert.AreEqual(temp[0], results.errors[0].Value);
            }
        }



        [When(@"I enetr ApplicationID")]
        public void WhenIEnetrApplicationID()
        {
            BOLTQNAHomePage BOLTquote = new BOLTQNAHomePage(getDriver());
            BOLTquote.setUniqueId(ScenarioContext.Current["clientId"].ToString());
        }



        [When(@"I verify Contact Information (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) in applicant wearer page for BOLT")]
        public void WhenIVerifyContactInformationInApplicantWearerPageForBOLT(string FirstName, string LastName, string Address, string Apartment, string City, string State, string AddressZipCode, string PhoneNumber, string EmailAddress)
        {

            BOLTApplicantWearerPage RetrieveApplicantpage = new BOLTApplicantWearerPage(getDriver());
            DataStorage temp = new DataStorage();
            switch (FirstName.ToUpper().Trim())
            {
                case "REGISTRY":
                    FirstName = temp.GetTempValue("FNAME");
                    break;
                default:

                    break;
            }

            switch (LastName.ToUpper().Trim())
            {
                case "REGISTRY":
                    LastName = temp.GetTempValue("LNAME");
                    break;
                default:

                    break;
            }
            EmailAddress = temp.GetTempValue("EMAIL");
            RetrieveApplicantpage.verifyBOLTRetrievdContactInformation(FirstName, LastName, Address, Apartment, City, State, AddressZipCode, PhoneNumber, EmailAddress);
        }

        [When(@"I Enter the Contact Information  (.*) , (.*) , (.*) , (.*) for BOLT")]
        public void IEnterTheContactInformationForBOLT(string IsMailingAddress, string ContactPreference, string GWDateofBirth, string Gender)
        {
            BOLTApplicantWearerPage RetrieveApplicantpage = new BOLTApplicantWearerPage(getDriver());
            RetrieveApplicantpage.SetTheContactInformationForBOLT(IsMailingAddress, ContactPreference, GWDateofBirth, Gender);
        }


        [When(@"I get Primary applicant from applicant wearer page")]
        public void IGetPrimaryApplicantFromApplicantWearerPage()
        {
            BOLTApplicantWearerPage Applicantpage = new BOLTApplicantWearerPage(getDriver());
            Applicantpage.getPrimaryContact();
        }


        public string GetUniqueValue()
        {
            DateTime myDateTime = DateTime.Now;
            string day = myDateTime.Day.ToString();
            string hour = myDateTime.Hour.ToString();
            string minute = myDateTime.Minute.ToString();
            string second = myDateTime.Second.ToString();
            string GetUniqueValue = day + hour + minute + second;
            return GetUniqueValue;


        }

        public string GetItemID(string Itemtype)
        {
            string GetItemID = "";
            switch (Itemtype.ToLower().Trim())
            {
                case "ring":
                    GetItemID = "1";
                    break;
                case "earrings":
                    GetItemID = "2";
                    break;
                case "bracelet":
                    GetItemID = "3";
                    break;
                case "necklace":
                    GetItemID = "4";
                    break;
                case "watch":
                    GetItemID = "5";
                    break;
                case "pendant":
                    GetItemID = "6";
                    break;
                case "chain":
                    GetItemID = "7";
                    break;
                case "other":
                    GetItemID = "8";
                    break;
                case "loose stone":
                    GetItemID = "9";
                    break;
                case "brooch":
                    GetItemID = "10";
                    break;
            }
            return GetItemID;
        }



    }
}

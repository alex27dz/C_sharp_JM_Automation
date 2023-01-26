using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RestAPICore.RestAPIs
{
    public class PostalTerritoryRestAPI
    {
        public void PostalTerritoryRestAPIOperation(string[] envArray, string OperationType, string PostalCode, string EffectiveDate, string TransType)
        {
            RestClient client = new RestClient(envArray[0]);

            switch (OperationType.ToLower().Trim())
            {
                case "post":
                    var request = new RestRequest(envArray[1], Method.POST);
                    request.AddParameter("PostalCode", PostalCode);
                    request.AddParameter("EffectiveDate", DateTimeOffset.Parse(EffectiveDate));
                    request.AddParameter("TransType", TransType);

                    IRestResponse response = client.Execute(request);
                    
                    ScenarioContext.Current.Add("TERRITORYRESPONSE", response);
                    break;
                default:
                    Console.WriteLine("Invalid Operation Type");
                    break;
            }
        }
    }
}

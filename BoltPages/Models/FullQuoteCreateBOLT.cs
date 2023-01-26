using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltPages.Models
{
    class FullQuoteCreateBOLT
    {
    }
    public class jewelryItems
    {
        public string itemTypeId { get; set; }
        public string description { get; set; }
        public string Value { get; set; }

    }

    public class Details
    {

    }

    public class CreateQuoteRootObject1
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public string countryId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public string agentId { get; set; }
        public string agentFirstName { get; set; }
        public string agentLastName { get; set; }
        public string agencyProducerCode { get; set; }
        public List<jewelryItems> jewelryItems { get; set; }

    }
}

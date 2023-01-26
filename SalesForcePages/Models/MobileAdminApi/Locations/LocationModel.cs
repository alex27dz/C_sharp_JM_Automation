using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcePages.Models.MobileAdminApi.Locations
{
    public class LocationModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostal { get; set; }
        public string Country { get; set; }
        public string ParentId { get; set; }
        public bool IsSetup { get; set; }
    }
}

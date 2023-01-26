using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcePages.Models.MobileAdminApi.Users
{
    public class UserLocationModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string LocationId { get; set; }
        public bool IsManager { get; set; }
        public bool IsListed { get; set; }
    }
}

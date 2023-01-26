using SalesForcePages.Models.MobileAdminApi.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcePages.Models.MobileAdminApi.Users
{
    public class UserModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ManagerId { get; set; }
        public string Role { get; set; }
        public string FailedAttempts { get; set; }
        public bool PasswordResetRequired { get; set; }
        public string LINKAccountId { get; set; }
        public string PrimaryLocationId { get; set; }
        public bool UserActive { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public List<UserLocationModel> UserLocations { get; set; }
        public List<LocationModel> Locations { get; set; }
    }
}


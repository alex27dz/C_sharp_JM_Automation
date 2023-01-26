using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcePages.Models.MobileAdminApi.Devices
{
    public class DevicePutModel
    {
        public string Id { get; set; }
        public string DeviceId { get; set; }
        public string OS { get; set; }
        public string OSVersion { get; set; }
        public string Brand { get; set; }
        public string DeviceType { get; set; }
        public string DeviceSubType { get; set; }
        public string DeviceVersion { get; set; }
        public string LocationId { get; set; }
        public bool Inactive { get; set; }
        public bool LINKEnabled { get; set; }
    }
}

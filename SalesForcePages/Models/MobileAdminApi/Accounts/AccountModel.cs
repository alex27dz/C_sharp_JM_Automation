﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForcePages.Models.MobileAdminApi.Accounts
{
    public class AccountModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentAccountId { get; set; }
        public bool Inactive { get; set; }
        public string HierarchyLevel { get; set; }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfUserService.model
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserIdendity.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
    }
}
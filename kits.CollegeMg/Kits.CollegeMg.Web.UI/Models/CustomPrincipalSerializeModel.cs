using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kits.CollegeMg.Web.UI.Models
{
    public class CustomPrincipalSerializeModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] roles { get; set; }
    }
}
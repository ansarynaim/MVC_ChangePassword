using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ChangePassword.Models
{
    public class changepassword
    {
        public string oldpassword { get; set; }

        public string newpassword { get; set; }

        public string confirmnewpassword { get; set; }
    }
}
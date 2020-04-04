using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionApp.Authentication.Models
{
    public class AppUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Uid { get; set; }
    }
}

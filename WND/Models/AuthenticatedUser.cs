using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WND.Models
{
    public class AuthenticatedUser : User
    {
        
        public string Username { get; set; }

        public string Password { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }
    }
}

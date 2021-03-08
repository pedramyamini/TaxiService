using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WND.Models;

namespace WND.Utility
{
    public static class Session
    {
        public static AuthenticatedUser CurrentUser { get; set; }
    }
}

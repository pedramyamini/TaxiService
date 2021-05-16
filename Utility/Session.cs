using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Session
    {
        public static AuthenticatedUser CurrentUser { get; set; }

        public static bool RecentlyLogedIn { get; set; }

        public static bool RecentlyRegisteredAdmin { get; set; }

        public static object LoginForm { get; set; }

    }
}

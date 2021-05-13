using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace WND.Utility
{
    public static class Session
    {
        public static AuthenticatedUser CurrentUser { get; set; }

        public static bool RecentlyRegisteredAdmin { get; set; }

    }
}

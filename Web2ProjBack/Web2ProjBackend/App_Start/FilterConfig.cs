﻿using System.Web;
using System.Web.Mvc;

namespace Web2ProjBackend
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

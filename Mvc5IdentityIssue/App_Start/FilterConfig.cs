﻿using System.Web;
using System.Web.Mvc;

namespace Mvc5IdentityIssue
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
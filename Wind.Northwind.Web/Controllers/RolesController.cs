﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wind.Northwind.Web.Controllers
{
    public class RolesController : NorthwindControllerBase
    {
        // GET: Roles
        public ActionResult Index()
        {
            return View();
        }
    }
}
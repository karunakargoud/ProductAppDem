﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductAppDem.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult AddProduct()
        {
            return View();
        }
    }
}
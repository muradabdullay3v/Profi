﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Areas.ProfiAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("ProfiAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

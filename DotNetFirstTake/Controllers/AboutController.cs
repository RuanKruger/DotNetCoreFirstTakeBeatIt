﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFirstTake.Controllers
{
    public class AboutController : Controller
    {
		// GET: /<controller>/
	    public IActionResult Index()
	    {
		    return View();
	    }
	}
}

﻿using Microsoft.AspNetCore.Mvc;

namespace GitManagementTest.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

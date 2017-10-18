using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Rock.Models;

namespace Rock.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}

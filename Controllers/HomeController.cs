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

      [HttpPost("/winner")]
      public ActionResult Winner()
      {
        Game newGame = new Game(Request.Form["player1"], Request.Form["player2"]);
        return View("Winner", newGame.SelectWinner());
      }
    }
}

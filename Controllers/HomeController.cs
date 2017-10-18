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

      [HttpPost("/players/one")]
      public ActionResult OnePlayer()
      {
        return View();
      }

      [HttpPost("/players/two")]
      public ActionResult TwoPlayers()
      {
        return View();
      }

      [HttpPost("/players/result")]
      public ActionResult Winner()
      {
        Game.ClearAll();
        if (Request.Form["player2"] == "computer")
        {
          string[] computerChoice = {"rock", "paper", "scissors"};
          Random rnd = new Random();
          int computerChoiceIndex = rnd.Next(0,2);
          Game newGame = new Game(Request.Form["player1"], computerChoice[computerChoiceIndex]);
          return View("Winner", newGame);
        }
        else
        {
          Game newGame = new Game(Request.Form["player1"], Request.Form["player2"]);
          return View("Winner", newGame);
        }
      }
    }
}

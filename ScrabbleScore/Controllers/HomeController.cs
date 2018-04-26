using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheScore.Models;
using System;

namespace TheScore.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/score")]
    public ActionResult Score()
    {
      ScoreGen inputWord = new ScoreGen(Request.Form["input-word"]);
      int finalScore = inputWord.GetScore();
      Console.WriteLine(finalScore);
      return View("Index", finalScore);
    }

  }
}

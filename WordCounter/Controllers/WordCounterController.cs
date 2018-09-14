using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounters")]
    public ActionResult Index()
    {
      List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();
       return View(allRepeatCounters);
    }

    [HttpGet("/wordcounters/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcounters")]
    public ActionResult Create()
    {
      RepeatCounter newWordTextCombination = new RepeatCounter(Request.Form["new-word"],Request.Form["new-text"]);

      //Split function
      string[] userWordsArray = RepeatCounter.TextToWords(newWordTextCombination.GetText());

      //Counting function
      int userCount = RepeatCounter.MatchCount(newWordTextCombination.GetSpecifiedWord(),userWordsArray);

      newWordTextCombination.SetCountResult(userCount);
      List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();

      return View("Index", allRepeatCounters);
    }
  }
}

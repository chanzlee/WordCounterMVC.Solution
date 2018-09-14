using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
      [HttpGet("/wordcounter")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/wordcounter/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/wordcounter")]
      public ActionResult Create()
      {
        RepeatCounter newWordTextCombination = new RepeatCounter(Request.Form["new-word"],Request.Form["new-text"]);

        //Split function
        string[] userWordsArray = RepeatCounter.TextToWords(newWordTextCombination.GetText());

        //Counting function
        int userCount = RepeatCounter.MatchCount(newWordTextCombination.GetSpecifiedWord(),userWordsArray);

        newWordTextCombination.SetCountResult(userCount);

        return View("Index", newWordTextCombination);
      }
    }
}

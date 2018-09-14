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

      // [HttpPost("/wordcounter")]
      // public ActionResult Create()
      // {
      //   // Survivor newSurvivor = new Survivor(Request.Form["survName"]);
      //   // Survivor.currentSurvivor = newSurvivor;
      //   // return View("Index", Survivor.currentSurvivor);
      // }


    }
}

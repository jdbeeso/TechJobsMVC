using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        /*static private Dictionary<string, string> searchTerm = new Dictionary<string, string>;*/
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }
        [HttpPost]
        [Route("/Search")]
        public IActionResult Results(string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            ViewBag.searchTerm = searchTerm;
            ViewBag.jobs = JobData.FindByValue(searchTerm);
            return View("Index");
        }
        // TODO #1 - Create a Results action method to process 
        // search request and display results

    }
}

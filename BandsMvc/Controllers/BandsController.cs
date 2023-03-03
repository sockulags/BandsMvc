using BandsMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace acme.Controllers
{
    public class BandsController : Controller
    {
        DataService dataService = new DataService();
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(dataService.GetAllBands());
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            return View(dataService.GetBandById(id));
        }
    }
}
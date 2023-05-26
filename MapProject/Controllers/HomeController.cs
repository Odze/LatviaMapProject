using MapProject.Data.Interfaces;
using MapProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MapProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IDataContextService _dataContextService;

        public HomeController(ILogger<HomeController> logger, IDataContextService dataContextService)
        {
            _logger = logger;
            _dataContextService = dataContextService;
        }

        public IActionResult Index()
        {
            return View(new HomeDataContainer(_dataContextService.centroids, _dataContextService.GetFarthestDirectionalCentroids()));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
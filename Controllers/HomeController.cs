using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AgingIndexWeb.Models;

namespace AgingIndexWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Services.CsvService _csvService;

    public HomeController(ILogger<HomeController> logger, Services.CsvService csvService)
    {
        _logger = logger;
        _csvService = csvService;
    }

    public IActionResult Index()
    {
        var data = _csvService.LoadData();
        return View(data);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

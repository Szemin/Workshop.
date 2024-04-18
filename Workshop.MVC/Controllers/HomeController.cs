using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Workshop.MVC.Models;

namespace Workshop.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        var model = new About()
        {
            Title = "Error",
            Description = "something",
            Tags = { "alfabet", "tebafla" }
        };

        return View(model);
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

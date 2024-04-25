using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesignEquipment.Models;

namespace DesignEquipment.Controllers;

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
    
    public IActionResult Equipment_categories()
    {
        ViewData["title"] = "Seadmed";
        return View();
    }

    public IActionResult Categoryofequipments(string id) // equipment of chosen category
    {
        ViewData["title"] = "Seadmed";
        ViewData["category"] = id;
        return View();
    }

    public IActionResult Equipment()
    {
        ViewData["title"] = "Seadmed";
        return View();
    }

    public IActionResult Groups()
    {
        return View();
    }

    public IActionResult QRscanner()
    {
        ViewData["title"] = "Sk&auml;nner";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

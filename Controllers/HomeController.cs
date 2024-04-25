using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesignEquipment.Models;
using Microsoft.Extensions.Primitives;

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

    [HttpGet]
    public IActionResult AddEquipment()
    {
        ViewData["title"] = "Seadmed";
        return View();
    }

    [ActionName("AddEquipment")]
    [HttpPost]
    public IActionResult AddEquipmentPost()
    {
        var form = Request.Form;
        StringValues serialNumber = form["serialNumber"];
        StringValues barcode = form["barcode"];
        StringValues category = form["category"];
        StringValues remark = form["remark"];
        StringValues name = form["name"];

        DatabaseContext database = new();
        Equipment equipment = new()
        {
            SerialNumber = serialNumber.ToString(),
            Barcode = barcode.ToString(),
            Name = name.ToString(),
            Category = category.ToString()
        };
        database.Equipment.Add(equipment);
        if (string.IsNullOrEmpty(remark.ToString().Trim()))
        {
            database.Comments.Add(new()
            {
                Date = DateTime.Now,
                Name = null,
                Equipment = equipment
            });
        }
        database.SaveChanges();

        return RedirectToAction("Equipment_categories");
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

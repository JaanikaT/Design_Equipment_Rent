using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesignEquipment.Models;
using Microsoft.Extensions.Primitives;
using System.Globalization;

namespace DesignEquipment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [ActionName("Index")]
    [HttpPost]
    public IActionResult IndexPost()
    {
        var form = Request.Form;
        DatabaseContext database = new();
        StringValues name = form["name"];
        StringValues email = form["email"];
        StringValues group = form["group"];
        database.Person.Add(new()
        {
            Name = name,
            Email = email,
            Group = group
        });
        database.SaveChanges();

        return Redirect("/");
    }

    public IActionResult Students(string id)
    {
        ViewData["title"] = id;
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
            Category = category.ToString(),
            AddedDate = DateTime.Now
        };
        database.Equipment.Add(equipment);
        if (!string.IsNullOrEmpty(remark.ToString().Trim()))
        {
            database.Comments.Add(new()
            {
                Date = DateTime.Now,
                Name = null,
                Equipment = equipment,
                Comment = remark
            });
        }
        database.SaveChanges();

        return RedirectToAction("Equipment_categories");
    }

    public IActionResult Equipment(int id)
    {
        ViewData["title"] = "Seade";
        ViewData["id"] = id;
        return View();
    }

    public IActionResult RemoveEquipment(int id)
    {
        DatabaseContext database = new();
        Equipment equip = database.Equipment.Where(x => x.Id == id).First();
        database.Equipment.Remove(equip);
        database.Comments.RemoveRange(database.Comments.Where(x => x.Equipment == equip));
        database.SaveChanges();

        return Redirect("/home/Categoryofequipments/" + equip.Category);
    }

    public IActionResult Groups(string id)
    {
        return View();
    }
    [HttpGet]
    public IActionResult QRscanner(int id)
    {
        ViewData["title"] = "Laenuta";
        ViewData["uid"] = id;
        return View();
    }
    [HttpPost]
    [ActionName("QRscanner")]
    public IActionResult QRscannerPost()
    {
        ViewData["title"] = "Laenuta";
        var form = Request.Form;

        StringValues uid = form["user"];
        StringValues id = form["id"];
        StringValues date = form["date"];
        StringValues reason = form["reason"];
        DatabaseContext database = new();
        database.Rent.Add(new()
        {
            EndDate = DateTime.ParseExact(date.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture),
            StartDate = DateTime.Now,
            Reason = reason,
            Expired = false,
            EquipmentId = Convert.ToInt32(id),
            PersonId = Convert.ToInt32(uid)
        });
        database.SaveChanges();

        return Redirect($"/home/qrscanner/{uid}");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

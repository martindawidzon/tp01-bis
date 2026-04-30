using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp01_bis_dawidzon_naiman.Models;

namespace tp01_bis_dawidzon_naiman.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Complejo complejo = new Complejo();
        ViewBag.dicCabañas = complejo.getDicCabañas();
        return View();
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
    public IActionResult Detalle(int id)
    {
        Complejo complejoID = new Complejo();
        ViewBag.cabaña = complejoID.getCabañaPorID(id);
        return View();
    }
}

using Microsoft.AspNetCore.Mvc;
using TP4BIS.Models;

namespace TP4BIS.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaDePaises = Info.ListarPaises();
        return View();
    }
   public IActionResult DetallePais(string pais)
    {
        ViewBag.Pais = Info.DetallePais(pais);
        return View("detallePais");
    }
}

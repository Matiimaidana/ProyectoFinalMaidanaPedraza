using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers;

public class ClientesController : Controller
{
    private readonly ILogger<ClientesController> _logger;
    public ClientesController(ILogger<ClientesController> logger){
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
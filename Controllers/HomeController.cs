using Microsoft.AspNetCore.Mvc;

namespace YMAL.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Message = "Bienvenido a mi aplicación web ASP.NET";
        return View();
    }

    public IActionResult About()
    {
        ViewBag.Title = "Acerca de";
        ViewBag.Description = "Esta es una aplicación web básica desarrollada con ASP.NET Core.";
        return View();
    }

    public IActionResult Contact()
    {
        ViewBag.Title = "Contacto";
        return View();
    }

    [HttpPost]
    public IActionResult Contact(string name, string email, string message)
    {
        if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(email))
        {
            ViewBag.Success = $"Hola {name}, tu mensaje ha sido recibido. Te contactaremos en {email}";
            _logger.LogInformation($"Contacto recibido de: {name} ({email})");
        }
        else
        {
            ViewBag.Error = "Por favor completa todos los campos.";
        }
        return View();
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Pastebin1.Controllers;

public class MyAlertsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
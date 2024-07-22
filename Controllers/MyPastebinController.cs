using Microsoft.AspNetCore.Mvc;

namespace Pastebin1.Controllers;

public class MyPastebinController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
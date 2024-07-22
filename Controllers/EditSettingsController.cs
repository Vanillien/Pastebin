using Microsoft.AspNetCore.Mvc;

namespace Pastebin1.Controllers;

public class EditSettingsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Pastebin1.Controllers;

public class ChangePasswordController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
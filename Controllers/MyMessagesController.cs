using Microsoft.AspNetCore.Mvc;

namespace Pastebin1.Controllers;

public class MyMessagesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
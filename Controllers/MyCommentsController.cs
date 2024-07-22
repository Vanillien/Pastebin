using Microsoft.AspNetCore.Mvc;

namespace Pastebin1.Controllers;

public class MyCommentsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
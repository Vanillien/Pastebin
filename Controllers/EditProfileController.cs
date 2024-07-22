using Microsoft.AspNetCore.Mvc;

namespace Pastebin1.Controllers;

public class EditProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
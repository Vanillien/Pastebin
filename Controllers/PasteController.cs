using Microsoft.AspNetCore.Mvc;
using Pastebin1.Classes;

namespace Pastebin1.Controllers;

public class PasteController : Controller
{
    public static void AddLike()
    {
        HomeController._paste.likes++;
    }
}
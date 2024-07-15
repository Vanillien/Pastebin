using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pastebin1.Classes;
//using Pastebin1.Models;

namespace Pastebin1.Controllers;

public class HomeController : Controller
{
    private static Paste _paste = new Paste();

    public static void TransferringFields()
    {
        
    }
    
    public static void ChooseTitle(string input)
    {
        _paste.title = input;
    }
    
    
    //private readonly ILogger<HomeController> _logger;<>

    /*public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }*/ 
    
}

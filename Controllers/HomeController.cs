using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pastebin1.Classes;
using Pastebin1.Interfaces;
//using Pastebin1.Models;

namespace Pastebin1.Controllers;

public class HomeController : Controller
{
    public static IPaste _paste { get; set; }

    public HomeController(IPaste paste)
    {
        _paste = paste;
    }

    public static void ConfirmCreation() 
    {
        
    }
    
    public static void ChooseTitle(string input)
    {
        
    }
    
}

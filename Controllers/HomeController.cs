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
        //этот метод передаст поля объекта _paste в объект с уникальным идентификатором, что и позволит после хранить объект в базе данных
    }
    
    public static void ChooseTitle(string input)
    {
        _paste.title = input;
    }
    
    /*public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }
    
    public static void Choose(object input)
    {
        _paste.field = input;
    }*/ //эти хрени для установки полей я напишу позже ибо щас мне лень 
    
    
    
    //private readonly ILogger<HomeController> _logger;<>

    /*public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }*/ 
    
}

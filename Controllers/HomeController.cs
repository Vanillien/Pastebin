using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pastebin1.Classes;
//using Pastebin1.Models;

namespace Pastebin1.Controllers;

public class HomeController : Controller
{
    public static Paste _paste = new Paste();

    public static void ConfirmCreation()
    {
        PasteList.AddObject();
        PasteList._paste_list[0].title = _paste.title; //нужен последний элемент списка. Попытаюсь оформить метод, который переберет массив и вернет наибольший индекс
    }
    
    public static void ChooseTitle(string input)
    {
        _paste.title = input;
    }
    
}

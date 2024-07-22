using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
namespace Pastebin1.Classes;

public class Paste
{
    public string title;
    public string text; 
    public string image;
    public Category category = Category.None;
    public float paste_expiration;
    public Paste_exposure paste_exposure;
    public int likes = 0;
    public int dislikes = 0;
    public string url;
    public string password;
    public List<string> tags = [];
    public Synthax_highlighting synthax_highlighting = Synthax_highlighting.None; 
    public string folder;
    public string date;

    public Paste()
    {
        
    }
    
    public Paste(string title)
    {
        //потом напишу основной конструктор
    }
    
}

public enum Category
{
    None, Cars, Crypt, Bottles
}

public enum Paste_exposure
{
    Public, Unlisted, Private
}

public enum Synthax_highlighting
{
    None, Python, CS, CPP, JS, Java
}
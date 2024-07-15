using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
namespace Pastebin1.Classes;

public class Paste
{
    public string title;
    private string text; 
    private string image;
    private Category category;
    private float paste_expiration;
    private Paste_exposure paste_exposure;
    private int likes;
    private int dislikes;
    private string url;

    public Paste()
    {
        
    }
    
    public Paste(string title, string text, string image, Category category, float paste_expiration, Paste_exposure paste_exposure, string url)
    {
        
    }

    public static string Name()
    {
        return "Googendoch";
    }

    public static void GenerateObject()
    {
        Paste Paste.Name = new Paste();
    }

}

public enum Category
{
    cars, crypt, bottles
}

public enum Paste_exposure
{
    _public, _unlisted, _private
}
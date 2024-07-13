using System.Runtime.CompilerServices;

namespace Pastebin1.Classes;

public class Paste
{
    private string title;
    private string text;
    private string image;
    private Category category;
    private float paste_expiration;
    private Paste_exposure paste_exposure;
    private int likes;
    private int dislikes;
    private string url; //url?

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public void SetText(string text)
    {
        this.text = text;
    }
    
    public void SetImage(string image)
    {
        this.image = image;
    }
    
    public void SetCategoryCars()
    {
        this.category = Category.cars;
    }
    
    public void SetCategoryCrypt()
    {
        this.category = Category.crypt;
    }
    
    public void SetCategoryBottles()
    {
        this.category = Category.bottles;
    }
    
    public void SetPaste_expiration(float paste_expiration)
    {
        this.paste_expiration = paste_expiration;
    }
    
    public void SetPaste_exposure_public()
    {
        this.paste_exposure = Paste_exposure._public;
    }
    
    public void SetPaste_exposure_unlisted()
    {
        this.paste_exposure = Paste_exposure._unlisted;
    }
    
    public void SetPaste_exposure_private()
    {
        this.paste_exposure = Paste_exposure._private;
    }
    
    public void AddLike()
    {
        this.likes++;
    }
    
    public void AddDislike()
    {
        this.dislikes++;
    }
    
    public void CreateUrl()
    {
        //нужен генератор хэшей, как отдельный сервис
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
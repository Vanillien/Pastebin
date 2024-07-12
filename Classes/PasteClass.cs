namespace Pastebin1.Classes;

public class Paste
{
    private string title;
    private string text;
    private string image;
    private Category category;
    private float past_expiration;
    private Paste_exposure paste_exposure;
    private int likes;
    private int dislikes;
    private string url;
}

public enum Category
{
    cars, crypt, bottles
}

public enum Paste_exposure
{
    _public, _unlisted, _private
}
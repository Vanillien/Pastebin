using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Pastebin1.Controllers;

namespace Pastebin1.Classes;

public class Paste
{
    public string title; //Название
    public User user; //User нужен
    public string text; //Текст
    public CategoryPaste category = CategoryPaste.None; //Категория поста (Надо будет создать отдельный класс CategoryPaste, чтобы после создать как поле 'этого' класса список из обьектов класса CategoryPaste(Нет))
    public float paste_expiration; //Время через которое пост исчезнет
    public Paste_exposure paste_exposure = Paste_exposure.Private; //Модификатор доступа к посту
    public int likes = 0; //Лайки
    public int dislikes = 0; //Дизлайки
    public string url; //Ссылка на пост
    //public string password; //
    public List<string> tags = []; //Теги (Ну тут точно нужно будет отдельный класс сделать)
    public Synthax_highlighting synthax_highlighting = Synthax_highlighting.None; //
    //public string folder; //
    public string date; //

    public Paste()
    {
        //PasteList.AddObj();
        PasteList.GetLastObj().title = HomeController._paste.title; 
        PasteList.GetLastObj().user = HomeController._paste.user; 
        PasteList.GetLastObj().text = HomeController._paste.text; 
        PasteList.GetLastObj().category = HomeController._paste.category; 
        PasteList.GetLastObj().paste_expiration = HomeController._paste.paste_expiration; 
        PasteList.GetLastObj().paste_exposure = HomeController._paste.paste_exposure; 
        PasteList.GetLastObj().likes = HomeController._paste.likes; 
        PasteList.GetLastObj().dislikes = HomeController._paste.dislikes; 
        PasteList.GetLastObj().url = HomeController._paste.url; 
        PasteList.GetLastObj().tags = HomeController._paste.tags; 
        PasteList.GetLastObj().synthax_highlighting = HomeController._paste.synthax_highlighting; 
        PasteList.GetLastObj().date = HomeController._paste.date; 
    }

    /*public static void ConfirmCreation() //дерьмо собаки, а не метод. Сам хочу себе глаза вырвать и растоптать, но они мне еще нужны, чтобы отрезать себе руки.
    {
        PasteList.AddObj();
        PasteList.GetLastObj().title = HomeController._paste.title; 
        PasteList.GetLastObj().user = HomeController._paste.user; 
        PasteList.GetLastObj().text = HomeController._paste.text; 
        PasteList.GetLastObj().category = HomeController._paste.category; 
        PasteList.GetLastObj().paste_expiration = HomeController._paste.paste_expiration; 
        PasteList.GetLastObj().paste_exposure = HomeController._paste.paste_exposure; 
        PasteList.GetLastObj().likes = HomeController._paste.likes; 
        PasteList.GetLastObj().dislikes = HomeController._paste.dislikes; 
        PasteList.GetLastObj().url = HomeController._paste.url; 
        PasteList.GetLastObj().tags = HomeController._paste.tags; 
        PasteList.GetLastObj().synthax_highlighting = HomeController._paste.synthax_highlighting; 
        PasteList.GetLastObj().date = HomeController._paste.date; 

    }*/
}

public enum CategoryPaste
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
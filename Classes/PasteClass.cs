using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Pastebin1.Controllers;
using Pastebin1.Interfaces;

namespace Pastebin1.Classes;

public class Paste : IPaste
{
    public IUser _user { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }

    public Paste(IUser user)
    {
        _user = user;
    }
    
}

    
using Pastebin1.Classes;
namespace Pastebin1.Interfaces;

public interface IPaste
{
    public IUser _user { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    
}
using System.Drawing;

namespace Pastebin1.Classes;

public class Comment
{
    public User _user;
    public string text;
    public Synthax_highlighting syntax_highlighting = Synthax_highlighting.None;
    public int likes = 0;
    public int dislikes = 0;
    public int views = 0;
    public string file_size; //хз, какой тип данных это будет. Наверное потом отдельно напишу.
    public string date;
}
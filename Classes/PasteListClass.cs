namespace Pastebin1.Classes;

public class PasteList
{
    public static List<Paste> _paste_list = [];

    public static void AddObject()
    {
        PasteList._paste_list.Add(new Paste());
    }

    public static Paste FindLastObject()
    {
        return _paste_list.Last();
    }
    
    
}
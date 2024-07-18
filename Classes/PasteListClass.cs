namespace Pastebin1.Classes;

public class PasteList
{
    private static List<Paste> _paste_list = [];

    public static void AddObject()
    {
        PasteList._paste_list.Add(new Paste());
    }
}
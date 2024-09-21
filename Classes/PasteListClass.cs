namespace Pastebin1.Classes;

public class PasteList
{
    public static List<Paste> _pasteList = []; //переделать в словарик

    public static void AddObj()
    {
        PasteList._pasteList.Add(new Paste());
    }

    public static Paste GetLastObj()
    {
        return _pasteList.Last();
    }
    
    
}
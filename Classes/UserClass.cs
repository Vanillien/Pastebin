namespace Pastebin1.Classes;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    //public bool email_status; //enum будет
    //public bool acount_type; //enum будет
    //public string website_url; 
    //public string avatar; //ссылка на аватар
}

public class Dependency
{
    public string field1;
}
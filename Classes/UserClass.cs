using Pastebin1.Interfaces;

namespace Pastebin1.Classes;

public class User : IUser
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    //public bool email_status; //enum будет
    //public bool acount_type; //enum будет
    //public string website_url; 
    //public string avatar; //ссылка на аватар

    public User(string username, string email, string password)
    {
        this.Username = username;
        this.Email = email;
        this.Password = password;
    }
}
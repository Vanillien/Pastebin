namespace Pastebin1.Interfaces;

public interface IUser
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
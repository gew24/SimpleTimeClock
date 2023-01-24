namespace SimpleTimeClock.Models;

public class User
{
    public Guid UserId { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string PermissionLevel { get; set; }
}
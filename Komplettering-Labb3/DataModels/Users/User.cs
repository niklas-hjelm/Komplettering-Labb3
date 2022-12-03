using Komplettering_Labb3.Enums;

namespace Komplettering_Labb3.DataModels.Users;

public abstract class User
{
    public string Name { get; }

    private string Password { get; }

    public abstract UserTypes Type { get; }

    protected User(string name, string password)
    {
        Name = name;
        Password = password;
    }

    public bool Authenticate(string password)
    {
        return Password.Equals(password);
    }
}
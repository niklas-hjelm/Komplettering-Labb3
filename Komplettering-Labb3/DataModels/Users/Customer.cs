using System;
using Komplettering_Labb3.Enums;

namespace Komplettering_Labb3.DataModels.Users;

public class Customer : User
{
    public override UserTypes Type => Enum.Parse<UserTypes>(nameof(GetType));
    public Customer(string name, string password) : base(name, password)
    {
    }
}
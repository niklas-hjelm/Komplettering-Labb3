using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Komplettering_Labb3.DataModels.Users;
using Komplettering_Labb3.Enums;

namespace Komplettering_Labb3.Managerrs;

public static class UserManager
{
    private static readonly IEnumerable<User>? _users = new List<User>();
    private static User _currentUser;

    public static IEnumerable<User>? Users => _users;

    public static User CurrentUser  
    {
        get => _currentUser;
        set
        { 
            _currentUser = value;
            CurrentUserChanged?.Invoke();
        }
    }

    public static event Action CurrentUserChanged;

    // Skicka detta efter att användarlistan ändrats eller lästs in
    public static event Action UserListChanged;

    public static bool IsAdminLoggedIn => CurrentUser.Type is UserTypes.Admin;

    public static void ChangeCurrentUser(string name, string password, UserTypes type)
    {
        throw new NotImplementedException();
    }

    public static void LogOut()
    {
        throw new NotImplementedException();
    }

    public static async Task SaveUsersToFile()
    {
        throw new NotImplementedException();
    }

    public static async Task LoadUsersFromFile()
    {
        throw new NotImplementedException();
    }
}
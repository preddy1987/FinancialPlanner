using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp;
using ToDoApp.Models;
using ToDoApp.Models.Database;

namespace ToDoApp
{
    public interface IToDoApp
    {
        bool IsAuthenticated { get; }
        void RegisterUser(User userModel);
        void LoginUser(string username, string password);
        void LogoutUser();
        IList<UserItem> Users { get; }
        RoleManager Role { get; }
        UserItem CurrentUser { get; }
        void DeleteRoleItem(int id);
        UserItem GetUserItem(string username);
        void AddUserItem(UserItem newUser);
        List<UserItem> GetUserItems();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp;
using ToDoApp.Models;
using ToDoEFDB.Context;

namespace ToDoDAL
{
    public class ToDoEFDAL : IToDoApp
    {
        #region RoleItem
        public RoleItem GetRoleItem(int roleId)
        {
            using (var context = new ToDoAppContext())
            {
                RoleItem role = context.RoleItem.Single(r => r.Id == roleId);
                return role;
            }
        }

        public List<RoleItem> GetRoleItems()
        {
            using (var context = new ToDoAppContext())
            {
                List<RoleItem> roles = context.RoleItem.ToList();
                return roles;
            }
        }

        public void UpdateRoleItem(int roleId, string name)
        {
            using (var context = new ToDoAppContext())
            {
                RoleItem updatedRole = context.RoleItem.Single(r => r.Id == roleId);
                updatedRole.Name = name;
                context.SaveChanges();
            }
        }

        public void DeleteRoleItem(int roleId)
        {
            using (var context = new ToDoAppContext())
            {
                RoleItem role = context.RoleItem.Single(r => r.Id == roleId);
                context.RoleItem.Remove(role);
                context.SaveChanges();
            }
        }
        #endregion

        #region UserItem
        public int AddUserItem(UserItem newUser)
        {
            int id;
            using (var context = new ToDoAppContext())
            {
                UserItem user = new UserItem();
                user.FirstName = newUser.FirstName;
                user.LastName = newUser.LastName;
                user.Username = newUser.Username;
                user.Email = newUser.Email;
                user.Hash = newUser.Hash;
                user.Salt = newUser.Salt;
                user.RoleId = newUser.RoleId;
                user.Password = newUser.Password;
                user.ConfirmPassword = newUser.ConfirmPassword;
                context.UserItem.Add(user);
                context.SaveChanges();
                id = user.Id;
                
            }
            return id;
        }

        public UserItem GetUserItem(int userId)
        {
            using (var context = new ToDoAppContext())
            {
                UserItem user = context.UserItem.Single(u => u.Id == userId);
                return user;
            }
        }

        public List<UserItem> GetUserItems()
        {
            using (var context = new ToDoAppContext())
            {
                List<UserItem> users = context.UserItem.ToList();

                return users;
            }
        }

        public bool UpdateUserItem(UserItem updatedUser)
        {
            using (var context = new ToDoAppContext())
            {
                UserItem user = context.UserItem.Single(u => u.Id == updatedUser.Id);
                user.FirstName = updatedUser.FirstName;
                user.LastName = updatedUser.LastName;
                user.Username = updatedUser.Username;
                user.Email = updatedUser.Email;
                user.Hash = updatedUser.Hash;
                user.Salt = updatedUser.Salt;
                user.RoleId = updatedUser.RoleId;
                user.Password = updatedUser.Password;
                user.ConfirmPassword = updatedUser.ConfirmPassword;

                context.SaveChanges();
                int? id = user.Id;
                return id != null;
            }
        }

        public void DeleteUserItem(int userId)
        {
            using (var context = new ToDoAppContext())
            {
                UserItem user = context.UserItem.Find(userId);
                context.UserItem.Remove(user);
                context.SaveChanges();
            }
        }
        #endregion

        #region ToDoItem and ToDoListItems
        public ToDoListItem AddToDoList(ToDoListItem newToDoList, int userId)
        {
            UserItem user;
            using (var context = new ToDoAppContext())
            {
                user = context.UserItem.Find(userId);
                
                ToDoListItem toDoList = new ToDoListItem();
                toDoList.Category = newToDoList.Category;
                toDoList.Description = newToDoList.Category;
                toDoList.Name = newToDoList.Name;
                toDoList.TimeCreated = DateTime.Now;
                context.ToDoListItem.Add(toDoList);

                user.UserToDoListItems.Add(new UserToDoListItem { ToDoListItemId = toDoList.Id });
                context.SaveChanges();
            }
        }

        public UserItem GetUserItem(string name)
        {
            throw new NotImplementedException();
        }

        public int AddRoleItem(RoleItem item)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRoleItem(RoleItem item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

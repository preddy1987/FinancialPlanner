﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class UserItem : BaseItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public int RoleId { get; set; }
        public List<ToDoListItem> ToDoListCollection { get; set; }

        public UserItem()
        {
            ToDoListCollection = new List<ToDoListItem>();
        }

        public UserItem Clone()
        {
            UserItem item = new UserItem();
            item.Id = this.Id;
            item.FirstName = this.FirstName;
            item.LastName = this.LastName;
            item.Username = this.Username;
            item.Email = this.Email;
            item.Hash = this.Hash;
            item.Salt = this.Salt;
            item.RoleId = this.RoleId;
            item.ToDoListCollection = this.ToDoListCollection;
            return item;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Models;

namespace ToDoEFDB.Context
{
    public class ToDoListContext : DbContext
    {
        public DbSet<ToDoListItem> ToDoListItem { get; set; }
        public DbSet<ToDoItem> ToDoItem { get; set; }
        public DbSet<UserItem> UserItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\PREDDY-MASTER\\SQLEXPRESS; Database = ToDoEFDB; Trusted_Connection = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
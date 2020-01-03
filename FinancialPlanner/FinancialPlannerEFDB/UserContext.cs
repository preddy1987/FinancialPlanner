using ToDoApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ToDoEFDB.Context
{
    public class ToDoAppContext : DbContext
    {
        public DbSet<UserItem> UserItem { get; set; }
        public DbSet<RoleItem> RoleItem { get; set; }
        public DbSet<ToDoListItem> ToDoListItem { get; set; }
        public DbSet<ToDoItem> ToDoItem { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("Data Source=PREDDY-MASTER\\SQLEXPRESS;Initial Catalog=ToDoEFDB;Integrated Security=True");
        //    optionsBuilder.UseSqlServer("Server = (localdb)\\PREDDY-MASTER\\SQLEXPRESS; Database = ToDoEFDB; Trusted_Connection = True");

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}

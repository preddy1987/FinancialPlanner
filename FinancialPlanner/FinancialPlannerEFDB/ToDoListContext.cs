using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using ToDoApp.Models.Database;

namespace ToDoEFDB.Context
{
    public class ToDoListContext : DbContext
    {
        public DbSet<ToDoListItem> ToDoListItem { get; set; }
        public DbSet<ToDoItem> ToDoItem { get; set; }
        public DbSet<UserItem> UserItem { get; set; }

        public static readonly LoggerFactory MyConsoleLoggerFactory = new LoggerFactory(new[] {
            new ConsoleLoggerProvider((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information, true)});

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\PREDDY-MASTER\\SQLEXPRESS; Database = ToDoEFDB; Trusted_Connection = True")
                .UseLoggerFactory(MyConsoleLoggerFactory).EnableSensitiveDataLogging(true);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
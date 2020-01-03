using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoEFDB.Models
{
    public class ToDoItem : BaseItem
    {
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ToDoListId { get; set; }
    }
}

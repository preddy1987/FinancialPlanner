using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Models
{
   public class ToDoListItem : BaseItem
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}

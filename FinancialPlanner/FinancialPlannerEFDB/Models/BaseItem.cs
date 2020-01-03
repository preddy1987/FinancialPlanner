using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoEFDB.Models
{
    public class BaseItem:DbContext
    {
        public const int InvalidId = -1;

        public int Id { get; set; } = InvalidId;
    }
}

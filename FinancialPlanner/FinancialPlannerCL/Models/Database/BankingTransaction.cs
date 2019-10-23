using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingService.Models
{
    public class BankingTransaction : BaseItem
    {
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public BankingTransaction Clone()
        {
            BankingTransaction item = new BankingTransaction();
            item.Id = this.Id;
            item.Date = this.Date;
            item.UserId = this.UserId;
            return item;
        }
    }
}

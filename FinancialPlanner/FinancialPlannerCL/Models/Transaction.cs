using System;
using System.Collections.Generic;
using System.Text;

namespace BankingService.Models
{
    class Transaction : BaseItem
    {
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public decimal? value = null;
        public bool isWithdraw = false;
        public bool isDeposit = false;

    }
}

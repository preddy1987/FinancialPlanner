using Financial_Planner_CL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Financial_Planner_DAO
{
    class FinancialPlannerDAO_MOCK : IFinancialPlannerDAO
    {
        public decimal GetBalance(BankAccount account)
        {
            return account.Balance;
        }

        public int GetNumberOfDeposits(BankAccount account)
        {
            return account.NumberOfDeposits;
        }

        public int GetNumberOfWithdrawals(BankAccount account)
        {
            return account.NumberOfWithdrawals;
        }

        public void SetBalance(BankAccount account, decimal balance)
        {
            account.SetBalance(balance);
        }
    }
}

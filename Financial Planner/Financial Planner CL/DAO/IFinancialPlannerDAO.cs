using Financial_Planner_CL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Financial_Planner_DAO
{
    interface IFinancialPlannerDAO
    {
        #region BankAccount
        int GetNumberOfWithdrawals(BankAccount account);
        int GetNumberOfDeposits(BankAccount account);
        //decimal GetBalance(BankAccount account);
        void SetBalance(BankAccount account, decimal balance);
        //decimal AddToBalance(BankAccount account);
        //decimal SubtractFromBalance(BankAccount account);
        #endregion

        #region Budget

        #endregion
    }
}

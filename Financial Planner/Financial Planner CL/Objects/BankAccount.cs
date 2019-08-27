using System;
using Financial_Planner_DAO;

namespace Financial_Planner_CL
{
    public class BankAccount
    {
        #region Properties and Member Variables
        public string Name { get; set; }
        public int AccountNumber { get; private set; }
        public int NumberOfWithdrawals { get; set; }
        public int NumberOfDeposits { get; set; }
        public string NameOnAccount { get; set; }
        public decimal Balance { get; private set; }
        #endregion

        #region Constructor(s)
        BankAccount(string name)
        {
            Name = name;
            AccountNumber = 1234;
            NameOnAccount = "Bob";
        }
        #endregion

        #region Methods
        public void AddTo(decimal num)
        {
            Balance += num;
            NumberOfDeposits++;
        }
        public void SubtractFrom(decimal num)
        {
            Balance -= num;
            NumberOfWithdrawals--;
        }
        public void SetBalance(decimal num)
        {
            Balance = num;
            NumberOfDeposits = 1;
            NumberOfWithdrawals = 0;
        }
        
        #endregion
    }
}

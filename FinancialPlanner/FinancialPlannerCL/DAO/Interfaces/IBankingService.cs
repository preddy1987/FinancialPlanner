using BankingService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingService.Interfaces
{
    public interface IBankingService
    {

        #region UserItem
        int AddUserItem(UserItem item);
        bool UpdateUserItem(UserItem item);
        void DeleteUserItem(int userId);
        UserItem GetUserItem(int userId);
        UserItem GetUserItem(string username);
        List<UserItem> GetUserItems();
        #endregion

        #region RoleItem
        int AddRoleItem(RoleItem item);
        List<RoleItem> GetRoleItems();
        RoleItem GetRoleItem(int id);
        bool UpdateRoleItem(RoleItem item);
        void DeleteRoleItem(int id);
        #endregion

        #region BankAccount
        int GetNumberOfWithdrawals(BankAccount account);
        int GetNumberOfDeposits(BankAccount account);
        //decimal GetBalance(BankAccount account);
        void SetBalance(BankAccount account, decimal balance);

        //UserItem GetUserItem(string username);
        //void AddUserItem(UserItem newUser);
        //object GetUserItems();
        //object GetTransactionItem(int id);
        //object GetTransactionItems(int vendingTransactionId);
        //object GetTransactionItemsForYear(int year, int userId);
        //void AddTransactionItem(TransactionItem item);
        //Microsoft.AspNetCore.Mvc.ActionResult<IEnumerable<RoleItem>> GetRoleItems();
        //object GetTransactionItemsForYear(int year);
        //Microsoft.AspNetCore.Mvc.ActionResult<RoleItem> GetRoleItem(int id);
        //object GetTransactionItems();
        //Microsoft.AspNetCore.Mvc.ActionResult<int> AddRoleItem(RoleItem item);
        //Microsoft.AspNetCore.Mvc.ActionResult<bool> UpdateRoleItem(RoleItem item);
        //void DeleteRoleItem(int id);

        //decimal AddToBalance(BankAccount account);
        //decimal SubtractFromBalance(BankAccount account);
        #endregion
    }
}

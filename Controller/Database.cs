using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Controller
{
    public class Database
    {
        Model.DBChanges dbChanges = new Model.DBChanges();
        Model.Accounts accounts = new Model.Accounts();
        Model.Categories categories = new Model.Categories();
        Model.Expenses expenses = new Model.Expenses();
        Model.Debts debts = new Model.Debts();
        Model.Home homes = new Model.Home();
        Model.SharedExpenses shared = new Model.SharedExpenses();

        #region DBChanges
        //Function to create new DB
        public int CreateNewDB()
        {
            return dbChanges.CreateNewDB();
        }

        //Function to check if DB is working fine
        public int CheckDB(string dbVersion)
        {
            return dbChanges.CheckDB(dbVersion);
        }

        //Function to put password on DB
        public bool EditPassword(Model.PasswordEntity pass)
        {
            return dbChanges.EditPassword(pass);
        }
        #endregion

        #region Accounts
        //Get list of accounts
        public DataTable GetAccounts()
        {
            return accounts.GetAccounts();
        }

        //Add a new account
        public bool AddAccount(Model.AccountEntity account)
        {
            return accounts.AddAccount(account);            
        }

        //Add or Reduce Amount in Account
        public bool ChangeAmount(Model.AccountEntity account)
        {
            return accounts.ChangeAmount(account);
        }

        //Delete Account
        public bool DeleteAccount(Model.AccountEntity account)
        {
            return accounts.DeleteAccount(account);
        }

        //Change name of account
        public bool ChangeName(Model.AccountEntity account)
        {
            return accounts.ChangeName(account);
        }

        #endregion

        #region Categories
        
        //Get list of Categories
        public DataTable GetCategories()
        {
            return categories.GetCategories();
        }

        //Add new category
        public bool AddCategory(Model.CategoryEntity category)
        {
            return categories.AddCategory(category);
        }

        //Delete category
        public bool DeleteCategory(Model.CategoryEntity category)
        {
            return categories.DeleteCategory(category);
        }

        //Change name of category
        public bool ChangeName(Model.CategoryEntity category)
        {
            return categories.ChangeName(category);
        }

        #endregion

        #region Expenses

        //Add expense
        public int AddExpense(Model.ExpenseEntity expense)
        {
            return expenses.AddExpense(expense);
        }
        
        //Get Expenses for a day to display in ViewExpenses
        public DataTable GetExpenses(DateTime date)
        {
            return expenses.GetExpenses(date);
        }

        //Delete Expense
        public bool DeleteExpense(Model.ExpenseEntity expense)
        {
            return expenses.DeleteExpense(expense);
        }

        //Update Expense
        public bool UpdateExpense(Model.ExpenseEntity expense)
        {
            return expenses.UpdateExpense(expense);
        }

        #endregion

        #region Debts
        //Get existing records
        public DataTable GetDebts(int recievable, bool showAccount = true)
        {
            return debts.GetDebts(recievable, showAccount);
        }

        //Add New Debt record
        public bool AddDebt(Model.DebtEntity debt)
        {
            return debts.AddDebt(debt);
        }

        //Delete record
        public bool DeleteDebt(Model.DebtEntity debt)
        {
            return debts.DeleteDebt(debt);
        }

        //Get Account Name
        public string GetAccountName(int account)
        {
            return debts.GetAccountName(account);
        }
        #endregion

        #region Home
        //Get expenses between dates based on category
        public DataTable CategoryWiseBetweenDates(Model.HomeEntity home)
        {
            return homes.CategoryWiseBetweenDates(home);
        }

        //Get Account Info for Home page
        public DataTable GetAccountsHome()
        {
            return homes.GetAccountsHome();
        }

        //Get last transactions for home page
        public DataTable GetLastTransactions(int no)
        {
            return homes.GetLastTransactions(no);
        }

        public DataTable GetExpensesBetweenDates(Model.HomeEntity home)
        {
            return homes.GetExpensesBetweenDates(home);
        }

        #endregion

        #region Shared

        public DataTable GetTitles()
        {
            return shared.GetTitles();
        }

        public int AddTitle(Model.SharedEntity sharedE)
        {
            return shared.AddTitle(sharedE);
        }

        public bool AddParticipant(Model.SharedEntity sharedE)
        {
            return shared.AddParticipant(sharedE);
        }

        public DataTable GetParticipants(int TitleId)
        {
            return shared.GetParticipants(TitleId);
        }

        public bool DeleteSharedExpense(Model.SharedEntity sharedE)
        {
            return shared.DeleteSharedExpense(sharedE);
        }

        public bool AddDivision(Model.SharedEntity sharedE)
        {
            return shared.AddDivision(sharedE);
        }

        public DataTable GetSharedExpenses(Model.SharedEntity sharedE)
        {
            return shared.GetSharedExpenses(sharedE);
        }

        public bool DeleteSharedRecord(int recordId)
        {
            return shared.DeleteSharedRecord(recordId);
        }

        public Model.SharedEntity GetExpenseDetails(int recordId)
        {
            return shared.GetExpenseDetails(recordId);
        }

        public DataTable GetFinalResult(int titleId)
        {
            return shared.GetFinalResult(titleId);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Model
{
    public class Expenses
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        string cmdStr;

        Model.LogEntity Log;
        Model.Accounts accounts = new Accounts();
        Model.AccountEntity account = new Model.AccountEntity();
        
        //Add a new Expense
        public int AddExpense(Model.ExpenseEntity expense)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "INSERT INTO Transactions (CategoryId, SpentOn, Amount, AccountId, DateSpent) " +
                    "VALUES (" + expense.Category.ToString() + ","+
                    "'"+expense.Note.ToString()+"',"+
                    expense.Amount.ToString() + "," +
                    expense.Account.ToString() + ","+
                    "@Date)";
                cmd.Parameters.AddWithValue("@Date", expense.Date.Date);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return 0;
                }
                conn.Close();

                //Reduce from Account
                account.AccountId = expense.Account;
                account.Amount = expense.Amount;
                account.AddAmount = false;
                accounts.ChangeAmount(account);
                return 1;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return 0;
            }
        }

        //Method to Get All Expenses for a day
        public DataTable GetExpenses(DateTime date)
        {
            OleDbDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "SELECT Transactions.AccountId, Accounts.AccountName, Transactions.CategoryId, Categories.CategoryName,"+
                    " Transactions.TransactionId, Transactions.SpentOn, Transactions.Amount" +
                    " FROM Categories "+
                    "INNER JOIN (Accounts INNER JOIN Transactions ON Accounts.AccountId = Transactions.AccountId)"+
                    " ON Categories.CategoryId = Transactions.CategoryId " +
                    " WHERE Transactions.Disabled = 0 AND Transactions.DateSpent = @Date" +
                    " ORDER BY TransactionId";
                cmd.Parameters.AddWithValue("@Date", date.Date.Date);
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return new DataTable();
            }
        }

        //Delete Expense
        public bool DeleteExpense(Model.ExpenseEntity expense)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                //Get Amount if to be edited
                if (expense.EditAmount)
                { 
                    //Get Amount
                    cmdStr = "SELECT Amount FROM Transactions WHERE TransactionId = " 
                        + expense.TransactionId.ToString();
                    cmd = new OleDbCommand(cmdStr, conn);
                    expense.Amount = Convert.ToInt32(cmd.ExecuteScalar());

                    //Get Account
                    cmdStr = "SELECT AccountId FROM Transactions WHERE TransactionId = "
                        + expense.TransactionId.ToString();
                    cmd = new OleDbCommand(cmdStr, conn);
                    expense.Account = Convert.ToInt32(cmd.ExecuteScalar());
                }

                //Set the transaction to be deleted
                cmdStr = "UPDATE Transactions SET Disabled = 1" +
                    " WHERE TransactionId = " + expense.TransactionId;
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
                }

                //Update Amount
                if (expense.EditAmount)
                {
                    //Add to Account
                    account.AccountId = expense.Account;
                    account.Amount = expense.Amount;
                    account.AddAmount = true;
                    accounts.ChangeAmount(account);
                }

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return false;
            }
        }

        //Update Expense
        public bool UpdateExpense(Model.ExpenseEntity expense)
        {
            ExpenseEntity expenseOld = new ExpenseEntity();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                //Get Amount if to be edited
                if (expense.EditAmount)
                {
                    //Get Amount
                    cmdStr = "SELECT Amount FROM Transactions WHERE TransactionId = "
                        + expense.TransactionId.ToString();
                    cmd = new OleDbCommand(cmdStr, conn);
                    expenseOld.Amount = Convert.ToInt32(cmd.ExecuteScalar());

                    //Get Account
                    cmdStr = "SELECT AccountId FROM Transactions WHERE TransactionId = "
                        + expense.TransactionId.ToString();
                    cmd = new OleDbCommand(cmdStr, conn);
                    expenseOld.Account = Convert.ToInt32(cmd.ExecuteScalar());
                }

                //Set the transaction to be updated
                cmdStr = "UPDATE Transactions SET " +
                    "CategoryId=" + expense.Category.ToString() + "," +
                    "AccountId=" + expense.Account.ToString() + "," +
                    "Amount = " + expense.Amount.ToString() + "," +
                    "SpentOn='" + expense.Note + "' WHERE TransactionId=" + expense.TransactionId;

                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
                }

                //Update Amount
                if (expense.EditAmount)
                {
                    //Remove from New account
                    account.AccountId = expense.Account;
                    account.Amount = expense.Amount;
                    account.AddAmount = false;
                    accounts.ChangeAmount(account);

                    //Add to existing Account
                    account.AccountId = expenseOld.Account;
                    account.Amount = expenseOld.Amount;
                    account.AddAmount = true;
                    accounts.ChangeAmount(account);
                }

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return false;
            }
        }
    }
}

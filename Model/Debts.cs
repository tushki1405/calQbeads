using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Model
{
    public class Debts
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        string cmdStr;

        Model.LogEntity Log;
        Model.Accounts accounts = new Accounts();
        Model.DebtEntity debts = new Model.DebtEntity();

        //Add a new Debt
        public bool AddDebt(Model.DebtEntity debt)
        {
            Model.AccountEntity account = new AccountEntity();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "INSERT INTO Debts(Person, Amount, Receivable, Notes, Account) VALUES (" +
                    "'" + debt.Name + "'," +
                    debt.Amount.ToString() + "," +
                    debt.Receivable.ToString() + "," +
                    "'" + debt.Note + "'," +
                    debt.Account.ToString() + ")";
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
                }
                conn.Close();

                if (debt.AdjustAmount)
                {
                    if (debt.Receivable == 1)
                    {
                        //Reduce from Account
                        account.AccountId = debt.Account;
                        account.Amount = debt.Amount;
                        account.AddAmount = false;
                        accounts.ChangeAmount(account);
                    }
                    else
                    {
                        //Add to Account
                        account.AccountId = debt.Account;
                        account.Amount = debt.Amount;
                        account.AddAmount = true;
                        accounts.ChangeAmount(account);
                    }
                }
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

        //Method to Get All Debts
        public DataTable GetDebts(int recievable, bool showAccount)
        {
            OleDbDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                cmd = new OleDbCommand(cmdStr, conn);
                if (showAccount)
                {
                    cmd.CommandText = "SELECT DebtId, Person, Amount, Notes, Account " +
                        " FROM Debts WHERE Disabled = 0 AND Receivable = " + recievable.ToString();
                }
                else
                {
                    cmd.CommandText = "SELECT DebtId, Person, Amount, Notes" +
                        " FROM Debts WHERE Disabled = 0 AND Receivable = " + recievable.ToString();
                }
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

        //Delete Debts
        public bool DeleteDebt(Model.DebtEntity debt)
        {
            Model.AccountEntity account = new AccountEntity();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "UPDATE Debts SET Disabled = 1 where DebtId = " + debt.Id.ToString();
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
                }
                conn.Close();

                if (debt.AdjustAmount)
                {
                    if (debt.Receivable == 1)
                    {
                        //Add to Account
                        account.AccountId = debt.Account;
                        account.Amount = debt.Amount;
                        account.AddAmount = true;
                        accounts.ChangeAmount(account);
                    }
                    else
                    {
                        //Reduce from Account
                        account.AccountId = debt.Account;
                        account.Amount = debt.Amount;
                        account.AddAmount = false;
                        accounts.ChangeAmount(account);
                    }
                }
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
    
        //Get Account Name
        public string GetAccountName(int account)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "SELECt AccountName FROM Accounts WHERE AccountID = " + account.ToString();
                string accountName = (string) cmd.ExecuteScalar();
                conn.Close();
                return accountName;
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
                return "";
            }
        }
        
    }
}

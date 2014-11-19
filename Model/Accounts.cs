using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Model
{
    public class Accounts
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        string cmdStr;

        Model.LogEntity Log;

        //Method to Get All Accounts
        public DataTable GetAccounts()
        {
            OleDbDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "SELECT * FROM Accounts WHERE Disabled = 0 ORDER BY AccountName";
                adapter = new OleDbDataAdapter(cmdStr, conn);
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

        //Add a new account
        public bool AddAccount(Model.AccountEntity account)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "INSERT INTO Accounts (AccountName, Amount) " +
                    "VALUES ('" + account.AccountName + "','0')";
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
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

        //Add or Reduce Amount in Account
        public bool ChangeAmount(Model.AccountEntity account)
        {
            try
            {
                string change;
                if (account.AddAmount)
                { change = "Amount + " + account.Amount; }
                else
                { change = "Amount - " + account.Amount; }
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "UPDATE Accounts SET Amount = " + change +
                    " WHERE AccountId = " + account.AccountId;
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
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

        //Delete Account
        public bool DeleteAccount(Model.AccountEntity account)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "UPDATE Accounts SET Disabled = 1" +
                    " WHERE AccountId = " + account.AccountId;
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
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

        //Change name of account
        public bool ChangeName(Model.AccountEntity account)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "UPDATE Accounts SET AccountName = '" + account.AccountName + "'" +
                    " WHERE AccountId = " + account.AccountId;
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
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

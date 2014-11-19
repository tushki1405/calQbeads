using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Model
{
    public class Home
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        string cmdStr;

        Model.LogEntity Log;
        Model.HomeEntity home = new HomeEntity();
        
        //Function to fetch Transactions between two dates
        public DataTable CategoryWiseBetweenDates(Model.HomeEntity home)
        {
            try
            {
                DataTable dt = new DataTable();
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "SELECT CategoryName As Category,Sum(Transactions.Amount) As Amount FROM Transactions,Categories " +
                    " WHERE Transactions.Disabled=0 and Transactions.CategoryId=Categories.CategoryId" +
                    " AND DateSpent>=@StartDate and DateSpent<=@EndDate GROUP BY Transactions.CategoryId,CategoryName";
                cmd.Parameters.Add("@StartDate", OleDbType.Date);
                cmd.Parameters.Add("@EndDate", OleDbType.Date);
                cmd.Parameters["@StartDate"].Value = home.StartDate.Date;
                cmd.Parameters["@EndDate"].Value = home.EndDate.Date;

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

        public DataTable GetExpensesBetweenDates(Model.HomeEntity home)
        {
            try
            {
                DataTable dt = new DataTable();
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "SELECT Categories.CategoryName AS Category, Transactions.Amount AS Amount, Accounts.AccountName AS Account, Transactions.DateSpent, Transactions.SpentOn " +
                    " FROM Categories " +
                    " INNER JOIN (Accounts INNER JOIN Transactions ON Accounts.AccountId = Transactions.AccountId)" +
                    " ON Categories.CategoryId = Transactions.CategoryId " +
                    " WHERE Transactions.Disabled = 0 AND DateSpent>=@StartDate and DateSpent<=@EndDate " +
                    " ORDER BY Transactions.DateSpent DESC";
                cmd.Parameters.Add("@StartDate", OleDbType.Date);
                cmd.Parameters.Add("@EndDate", OleDbType.Date);
                cmd.Parameters["@StartDate"].Value = home.StartDate.Date;
                cmd.Parameters["@EndDate"].Value = home.EndDate.Date;

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

        //Function to get data for Accounts in format of Home Page
        public DataTable GetAccountsHome()
        {
            try
            {
                DataTable dt = new DataTable();
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "SELECT AccountName as Account,Amount FROM Accounts WHERE disabled=0";
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

        //Get last transactions based on no. passed
        public DataTable GetLastTransactions(int no)
        {
            try
            {
                DataTable dt = new DataTable();
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText = "SELECT TOP " + no.ToString() + " Categories.CategoryName AS Category, Transactions.Amount AS Amount, Accounts.AccountName AS Account, Transactions.DateSpent, Transactions.SpentOn " +
                    " FROM Categories " +
                    " INNER JOIN (Accounts INNER JOIN Transactions ON Accounts.AccountId = Transactions.AccountId)" +
                    " ON Categories.CategoryId = Transactions.CategoryId " +
                    " WHERE Transactions.Disabled = 0 " +
                    " ORDER BY Transactions.DateSpent DESC";
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
    }
}

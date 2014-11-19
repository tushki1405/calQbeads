using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Model
{
    public class Categories
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        string cmdStr;

        Model.LogEntity Log;

        //Method to Get All Accounts
        public DataTable GetCategories()
        {
            OleDbDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "SELECT * FROM Categories WHERE Disabled = 0 ORDER BY CategoryName";
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

        //Add a new category
        public bool AddCategory(Model.CategoryEntity category)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "INSERT INTO Categories (CategoryName) " +
                    "VALUES ('" + category.CategoryName + "')";
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

        //Delete category
        public bool DeleteCategory(Model.CategoryEntity category)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "UPDATE Categories SET Disabled = 1" +
                    " WHERE CategoryId = " + category.CategoryId;
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

        //Change name of category
        public bool ChangeName(Model.CategoryEntity category)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "UPDATE Categories SET CategoryName = '" + category.CategoryName + "'" +
                    " WHERE CategoryId = " + category.CategoryId;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.OleDb;
using ADOX;

namespace Model
{
    public class DBChanges
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        string cmdStr;
        Model.LogEntity Log;

        //Function to create new DB
        public int CreateNewDB()
        {
            try
            {
                ADOX.CatalogClass cat = new ADOX.CatalogClass();
                if (System.IO.File.Exists(DBSettings.FilePath))
                {
                    System.IO.File.Delete(DBSettings.FilePath);
                }

                //Create Access file
                cat.Create(DBSettings.Connection);
                cat = null;

                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                
                //Audit Table
                cmdStr = "create table AuditLog (AuditLogId autoincrement, ErrorMessage memo, Page memo)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                cmdStr = "create unique index AuditLog_index on AuditLog (AuditLogId asc) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                //Transaction Table (when adding logic for userid, add index for UserId)
                cmdStr = "create table Transactions (TransactionId autoincrement, CategoryId long not null, SpentOn text(100), Amount single default 0 not null, AccountId long default 0 not null, DateSpent datetime not null, Disabled short default 0 not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index on ID
                cmdStr = "create unique index transactions_index on Transactions (TransactionId asc) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index on reading for graphs
                cmdStr = "create index transactions_all_index on Transactions (CategoryId, Amount, DateSpent) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                

                //Categories Table
                cmdStr = "create table Categories ( CategoryId autoincrement, CategoryName text(60) not null, Disabled short default 0 not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                cmdStr = "create unique index categories_index on Categories(CategoryId asc) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                //MoneySource Table
                cmdStr = "create table Accounts ( AccountId autoincrement, AccountName text(60) not null, Amount single not null, Disabled short default 0 not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                cmdStr = "create unique index account_index on Accounts (AccountId asc) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                //Debts Table
                cmdStr = "create table Debts (DebtId autoincrement, Person text(60) not null, Amount single default 0 not null, Account short, Receivable short not null, Notes text(100), disabled short default 0 not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index on ID
                cmdStr = "create unique index debt_index on Debts (DebtId asc) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index on all
                cmdStr = "create index debt_all_index on Debts (Person, Amount, Receivable) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                ////ToDo Table
                //cmdStr = "create table ToDo (ToDoId autoincrement, Task text(60) not null, DoOn datetime not null, Done short default 0 not null, disabled short default 0 not null)";
                //cmd = new OleDbCommand(cmdStr, conn);
                //cmd.ExecuteNonQuery();
                //cmdStr = "create unique index toDo_index on ToDo (ToDoId asc) with disallow null";
                //cmd = new OleDbCommand(cmdStr, conn);
                //cmd.ExecuteNonQuery();

                //Settings Table
                cmdStr = "create table Settings (SettingId autoincrement, SettingName text(60) not null, SettingValue text(100) not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                cmdStr = "Insert into Settings(SettingName, SettingValue) values ('dbVersion','2.0')";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                
                //Shared expenses - Main Expenses table
                cmdStr = "create table SEMain (TitleId autoincrement, Titlename text(100) not null, Description text(200), Type text(50) not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                cmdStr = "create unique index SEMain_index on SEMain (TitleId asc) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                //Shared expenses - Participants table
                cmdStr = "create table SEParticipants (ParticipantId autoincrement, TitleId long not null Constraint SEParticipants_TitleId References SEMain(TitleId) on delete cascade";
                cmdStr += ", ParticipantName text(100) not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index on id
                cmdStr = "create unique index SEParticipants_index on SEParticipants (ParticipantId asc) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index on getallinfo
                cmdStr = "create index SEParticipants_all_index on SEParticipants (ParticipantId, TitleId) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                //Shared expenses - Expenses table
                cmdStr = "create table SEExpense (SEEId autoincrement, ParticipantId long not null Constraint SEExpense_ParticipantId References SEParticipants(ParticipantId) on delete cascade, Amount single default 0 not null, Item text(100) not null, DateSpent datetime not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index on id
                cmdStr = "create unique index SEExpense_index on SEExpense (SEEId asc) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index to get all info
                cmdStr = "create index SEExpense_all_index on SEExpense (ParticipantId, Amount) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();


                //Shared expenses - Division table
                cmdStr = "create table SEDivision (DivisionId autoincrement, SEEId long not null Constraint SEDivision_SEEId References SEExpense(SEEId) on delete cascade, ParticipantId long not null, Share long not null)";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
                //Index to get all info
                //Index to get all info
                cmdStr = "create index SEDivision_all_index on SEDivision (SEEId, ParticipantId, Share) with disallow null";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                //Populate Table With Default Values
                string[] MoneySourceArray = { "Cash", "Bank Account 1" };
                foreach (string moneySource in MoneySourceArray)
                {
                    cmdStr = "Insert into Accounts(AccountName,Amount,Disabled) values ('" + moneySource + "',0,0)";
                    cmd = new OleDbCommand(cmdStr, conn);
                    cmd.ExecuteNonQuery();
                }

                string[] CategoryArray = { "Meals", "Entertainment", "Travelling", "Rent" };
                foreach (string category in CategoryArray)
                {
                    cmdStr = "Insert into Categories(CategoryName,Disabled) values ('" + category + "',0)";
                    cmd = new OleDbCommand(cmdStr, conn);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
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

        //Funtion to check if the DB contains all tables or not
        public int CheckDB(string dbVersion)
        {
            try
            {
                int isPasswordProtected = CheckForPass();
                if (isPasswordProtected == 1)
                    return 2;

                UpdateFromPreviousVersion(dbVersion);

                //Code to check if all tables exists
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();

                cmdStr = "select TOP 1 1 from Accounts";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from Categories";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from Debts";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                //cmdStr = "select count(*) from ToDo";
                //cmd = new OleDbCommand(cmdStr, conn);
                //cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from Transactions";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from AuditLog";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from Settings";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from SEMain";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from SEParticipants";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from SEExpense";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                cmdStr = "select TOP 1 1 from SEDivision";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
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

        //Function to check if password is there
        public int CheckForPass()
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                conn.Close();
                return 0;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (ex.Message == "Not a valid password.")
                {
                    return 1;
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return 0;
            }
        }

        //Function to edit password of DB
        public bool EditPassword(PasswordEntity pass)
        {
            try
            {
                if (string.IsNullOrEmpty(pass.OldPass))
                {
                    pass.OldPass = "";
                 }
                conn = new OleDbConnection(DBSettings.ConnectionExclusive);
                conn.Open();
                cmdStr = "Alter Database Password [" + DBSettings.passSalt + pass.NewPass + "]" + 
                    "[" + DBSettings.passSalt + pass.OldPass + "]";
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();
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

        private void UpdateFromPreviousVersion(string dbVersion)
        { 
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "SELECT SettingValue FROM Settings WHERE SettingName='dbVersion'";
                cmd = new OleDbCommand(cmdStr, conn);
                string version = (string)cmd.ExecuteScalar();
                conn.Close();
                if (dbVersion == "2.0" && version == "2.0")
                {
                    Log = new LogEntity();
                    Log.ErrorMsg = "Current Version:" + dbVersion;
                    Log.Page = "Version";
                    //Common.Log(Log);
                }
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
            }
        }
    }
}

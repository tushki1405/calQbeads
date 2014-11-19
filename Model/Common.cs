using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Model
{
    public static class Common
    {
        static OleDbConnection conn;
        static OleDbCommand cmd;
        static string cmdStr;

        //Logging for Errors
        public static void Log(Model.LogEntity log)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                log.ErrorMsg = log.ErrorMsg.Replace("'","");
                log.Page = log.Page.Replace("'", "");

                cmdStr = string.Format("Insert into AuditLog(ErrorMessage, Page) values ('{0}','{1}')",log.ErrorMsg, log.Page);
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            { 
            }
        }
    }
}

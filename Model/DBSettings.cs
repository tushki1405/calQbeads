using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public static class DBSettings
    {

        public static string fileFilter = "MsAccess 2007 Files|*.accdb|MsAccess 2003-2007 Files|*.mdb";
        private static string dataProvider = "Provider=Microsoft.Jet.OLEDB.4.0;";
        private static string dataSource = "Data Source=";
        private static string dataPass = "Jet OLEDB:Database Password=";
        public static string passSalt = "dv41414tx";

        private static string filePath;
        public static string FilePath
        {
            get { return DBSettings.filePath; }
            set { DBSettings.filePath = value; }
        }

        private static string password;
        public static string Password
        {
            get { return DBSettings.password; }
            set { DBSettings.password = value; }
        }

        //Get the connection String
        public static string Connection
        {
            get 
            {
                if (string.IsNullOrEmpty(password))
                {
                    return dataProvider + dataSource + FilePath + ";" + dataPass + passSalt + ";";
                }
                else
                {
                    return dataProvider + dataSource + FilePath + ";" + dataPass + passSalt +Password + ";";
                }
            } 
        }

        //Get connection string with exclusive rights
        public static string ConnectionExclusive
        {
            get 
            {
                if (string.IsNullOrEmpty(password))
                {
                    return dataProvider + dataSource + FilePath + ";Mode=12;" + dataPass + passSalt + ";";
                }
                else
                {
                    return dataProvider + dataSource + FilePath + ";" + dataPass + passSalt + Password + ";Mode=12;";
                }
            }
        }
    }
}

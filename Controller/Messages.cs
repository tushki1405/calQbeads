using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controller
{
    public static class Messages
    {

        public static string OpenNextTimeMsg = "Do you want to open this file automatically for future uses ? \n ";
        public static string DeleteAccount = "Are you sure you want to delete account ? \n";
        public static string DeleteExpense = "Are you sure you want to delete expense ? \n";
        public static string AdjustAmount = "Do you want to Adjust amount in Account ";
        public static string DeleteDebt = "Are you sure you want to delete debt ? \n";

        private static ToolStripStatusLabel statusMessage;
        public static ToolStripStatusLabel StatusMessage
        {
            get { return Messages.statusMessage; }
            set { Messages.statusMessage = value; }
        }

        //Set message in status bar
        public static void SetStatusMessage(string message)
        {
            StatusMessage.Text = message;
        }

        //Messages to display on page open
        public enum Pages 
        { 
            MainWindow,
            Home,
            Password,
            Accounts,
            Category,
            AddExpense,
            ViewExpense,
            Debts,
            ViewExpenseCombined,
            SEHome,
            SEEdit,
            SETran,
            SEReport
        };

        //Message to set when page opens
        public static void SetStatusMessage(Pages page)
        {
            switch (page)
            { 
                case Pages.MainWindow:
                    statusMessage.Text = "Please 'Create a New File' or 'Open an Existing file'.";
                    break;

                case Pages.Home:
                    statusMessage.Text = "";
                    break;

                case Pages.Password:
                    statusMessage.Text = "Create or Update Password for File.";
                    break;

                case Pages.Accounts:
                    statusMessage.Text = "Manage Accounts and Money in Accounts.";
                    break;

                case Pages.Category:
                    statusMessage.Text = "Add/Edit Categories.";
                    break;

                case Pages.AddExpense:
                    statusMessage.Text = "Add your Expenses.";
                    break;

                case Pages.ViewExpense:
                    statusMessage.Text = "Edit, View or Delete Expenses.";
                    break;

                case Pages.Debts:
                    statusMessage.Text = "Add, View and Delete Debts.";
                    break;

                case Pages.ViewExpenseCombined:
                    statusMessage.Text = "View Expenses between selected dates.";
                    break;

                case Pages.SEHome:
                    statusMessage.Text = "Add Expenses Shared by Multiple Persons.";
                    break;

                case Pages.SEEdit:
                    statusMessage.Text = "Add Participants to Share Expenses.";
                    break;

                case Pages.SETran:
                    statusMessage.Text = "Add transactions to be Shared.";
                    break;

                case Pages.SEReport:
                    statusMessage.Text = "View calculated reports of Shared Expenses.";
                    break;
            }
        }

        //Messages to display on Errors
        public enum ErrorMsgs
        {
            FilePathCorrupt,
            FileCorrupt,
            NoCreateDB
        };

        //Message to set on error
        public static void SetStatusMessage(ErrorMsgs msg)
        {
            switch (msg)
            {
                case ErrorMsgs.FilePathCorrupt:
                    statusMessage.Text = "File not Found or File is not a Valid Access File.";
                    break;

                case ErrorMsgs.FileCorrupt:
                    statusMessage.Text = "Selected file is corrupt or from Older version.";
                    break;

                case ErrorMsgs.NoCreateDB:
                    statusMessage.Text = "Cannot create new File.";
                    break;
            }
        }
    }
}

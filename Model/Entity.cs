using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    //Entity for new password
    public class PasswordEntity
    {
        string oldPass;
        public string OldPass
        {
            get { return oldPass; }
            set { oldPass = value; }
        }

        string newPass;
        public string NewPass
        {
            get { return newPass; }
            set { newPass = value; }
        }
    }

    //Entity for Logging
    public class LogEntity
    {
        string errorMsg;

        public string ErrorMsg
        {
            get { return errorMsg; }
            set { errorMsg = value; }
        }
        string page;

        public string Page
        {
            get { return page; }
            set { page = value; }
        }
    }

    //Entity for Accounts
    public class AccountEntity
    {
        string accountName;

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        int accountId;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        bool addAmount;

        public bool AddAmount
        {
            get { return addAmount; }
            set { addAmount = value; }
        }
    }

    //Entity for Categories
    public class CategoryEntity
    {
        string categoryName;

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        int categoryId;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
    }

    //Entity for Expenses
    public class ExpenseEntity
    {
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        int account;

        public int Account
        {
            get { return account; }
            set { account = value; }
        }
        int category;

        public int Category
        {
            get { return category; }
            set { category = value; }
        }
        int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        int transactionId;

        public int TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }

        bool editAmount;

        public bool EditAmount
        {
            get { return editAmount; }
            set { editAmount = value; }
        }

    }

    //Entity for Debts
    public class DebtEntity
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        int account;

        public int Account
        {
            get { return account; }
            set { account = value; }
        }
        bool adjustAmount;

        public bool AdjustAmount
        {
            get { return adjustAmount; }
            set { adjustAmount = value; }
        }

        private int receivable;

        public int Receivable
        {
            get { return receivable; }
            set { receivable = value; }
        }
    }

    //Entity for Results
    public class ResultEntity
    {
        string resultString;

        public string ResultString
        {
            get { return resultString; }
            set { resultString = value; }
        }
        int resultInt;

        public int ResultInt
        {
            get { return resultInt; }
            set { resultInt = value; }
        }
        bool successful;

        public bool Successful
        {
            get { return successful; }
            set { successful = value; }
        }

        float resultFloat;

        public float ResultFloat
        {
            get { return resultFloat; }
            set { resultFloat = value; }
        }

    }

    //Entity for Home page
    public class HomeEntity
    {
        DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }

    //Entity for Shared Expenses
    public class SharedEntity
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int titleId;

        public int TitleId
        {
            get { return titleId; }
            set { titleId = value; }
        }
        private string participantName;

        public string ParticipantName
        {
            get { return participantName; }
            set { participantName = value; }
        }

        private IList<SharedParticipants> participants;

        public IList<SharedParticipants> Participants
        {
            get { return participants; }
            set { participants = value; }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private int participantId;

        public int ParticipantId
        {
            get { return participantId; }
            set { participantId = value; }
        }

        private string item;

        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        private DateTime dateSpent;

        public DateTime DateSpent
        {
            get { return dateSpent; }
            set { dateSpent = value; }
        }
    }

    public class SharedParticipants
    {
        private int expenseId;

        public int ExpenseId
        {
            get { return expenseId; }
            set { expenseId = value; }
        }
        private int participantId;

        public int ParticipantId
        {
            get { return participantId; }
            set { participantId = value; }
        }
        private int share;

        public int Share
        {
            get { return share; }
            set { share = value; }
        }
    }
}



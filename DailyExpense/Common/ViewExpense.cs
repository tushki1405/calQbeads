using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyExpense.Common
{
    public partial class ViewExpense : Form
    {
        Controller.Database database = new Controller.Database();
        Model.ExpenseEntity expense = new Model.ExpenseEntity();
        DataTable accountTable;
        DataTable categoryTable;
        DataTable expenseTable;
        DataGridViewLinkColumn col_edit;
        //DataGridViewLinkColumn col_delete;
        DataGridViewColumn col_account;
        DataGridViewColumn col_category;
        DataGridViewColumn col_note;
        DataGridViewColumn col_amount;
        DataRowView dv;
        DataRow dr;
        int selectedId;
        bool eventAdded;

        string existingAmount;
        string existingAccount;

        public ViewExpense()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_error);
            eventAdded = false;
            setUI();
            Reload();
            selectedId = 0;
        }

        //Set the UI for the page
        private void setUI()
        {
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.ViewExpense);

            accountTable = database.GetAccounts();
            cb_Accounts.DataSource = accountTable;
            cb_Accounts.DisplayMember = "AccountName";
            cb_Accounts.ValueMember = "AccountId";

            categoryTable = database.GetCategories();
            cb_category.DataSource = categoryTable;
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryId";


            col_edit = new DataGridViewLinkColumn();
            col_edit.UseColumnTextForLinkValue = true;
            col_edit.DataPropertyName = "TransactionId";
            col_edit.Name = "";
            col_edit.Text = "EDIT";
            col_edit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_edit.Width = 40;
            
            col_account = new DataGridViewTextBoxColumn();
            col_account.Name = "Account";
            col_account.DataPropertyName = "AccountName";
            col_account.Width = 120;

            col_category = new DataGridViewTextBoxColumn();
            col_category.Name = "Category";
            col_category.DataPropertyName = "CategoryName";
            col_category.Width = 120;

            col_note = new DataGridViewTextBoxColumn();
            col_note.Name = "Amount";
            col_note.DataPropertyName = "Amount";
            col_note.Width = 80;
            col_note.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            col_amount = new DataGridViewTextBoxColumn();
            col_amount.Name = "Note";
            col_amount.DataPropertyName = "SpentOn";
            col_amount.Width = 132;
        }

        //Load data grid view again
        private void Reload()
        {
            expenseTable = database.GetExpenses(cal_date.SelectionStart);
            gv_data.DataSource = expenseTable;
            object sum = expenseTable.Compute("SUM(Amount)","");
            
            if(string.IsNullOrEmpty(sum.ToString()))
                lbl_total.Text = "0";
            else
                lbl_total.Text = sum.ToString();

            gv_data.Columns.Clear();
            gv_data.Columns.Add(col_account);
            gv_data.Columns.Add(col_category);
            gv_data.Columns.Add(col_amount);
            gv_data.Columns.Add(col_note);
            gv_data.Columns.Add(col_edit);
            //gv_data.Columns.Add(col_delete);
            col_account.DisplayIndex = 0;
            col_category.DisplayIndex = 1;
            col_amount.DisplayIndex = 2;
            col_note.DisplayIndex = 3;
            col_edit.DisplayIndex = 4;

            if (!eventAdded)
            {
                gv_data.CellContentClick += new DataGridViewCellEventHandler(this.gv_data_CellContentClick);
                eventAdded = true;
            }

            cb_Accounts.SelectedIndex = 0;
            cb_category.SelectedIndex = 0;
            txt_amount.Text = "";
            txt_note.Text = "";
            gv_data.Focus();
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "UpdateValid":
                    lbl_error.Text = "Invalid Characters.";
                    lbl_error.Location = new Point(615, 125);
                    break;

                case "UpdateError":
                    lbl_error.Text = "Could not Update Expense.";
                    lbl_error.Location = new Point(595, 125);
                    break;

                case "UpdateSuccess":
                    lbl_error.Text = "Expense Updated Successfully.";
                    lbl_error.Location = new Point(582, 125);
                    break;

                case "DeleteError":
                    lbl_error.Text = "Could not Delete Expense.";
                    lbl_error.Location = new Point(595, 125);
                    break;

                case "NoSelected":
                    lbl_error.Text = "Please select a record first.";
                    lbl_error.Location = new Point(595, 125);
                    break;

                default:
                    lbl_error.Text = "";
                    break;
            }
        }

        private void cal_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            Reload();
            selectedId = 0;
            ErrorMsgs("Hide");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedId > 0)
            {
                if (!Controller.Validations.IsProperNumber(txt_amount) || !Controller.Validations.NoInvalidCharacters(txt_note))
                {
                    ErrorMsgs("UpdateValid");
                    return;
                }
                expense.TransactionId = selectedId;
                expense.Account = Convert.ToInt32(cb_Accounts.SelectedValue);
                expense.Category = Convert.ToInt32(cb_category.SelectedValue);
                expense.Note = txt_note.Text;
                expense.Amount = Convert.ToInt32(txt_amount.Text);

                if (txt_amount.Text != existingAmount || cb_Accounts.Text != existingAccount)
                {
                    DialogResult resultAdjust = MessageBox.Show(Controller.Messages.AdjustAmount, "Confirm Adjustment",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (resultAdjust.ToString() == "Yes")
                    {
                        expense.EditAmount = true;
                    }
                }
                if (database.UpdateExpense(expense))
                {
                    ErrorMsgs("UpdateSuccess");
                    gv_data.Focus();
                    Reload();
                    return;
                }
                ErrorMsgs("UpdateError");
            }
            else
            {
                ErrorMsgs("NoSelected");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedId > 0)
            {
                DialogResult resultDelete = MessageBox.Show(Controller.Messages.DeleteExpense, "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (resultDelete.ToString() == "Yes")
                {
                    DialogResult resultAdjust = MessageBox.Show(Controller.Messages.AdjustAmount, "Confirm Adjustment",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (resultAdjust.ToString() == "Yes")
                    {
                        expense.EditAmount = true;
                    }
                    expense.TransactionId = selectedId;
                    if (database.DeleteExpense(expense))
                    {
                        Reload();
                        gv_data.Focus();
                        return;
                    }
                    ErrorMsgs("DeleteError");
                }
            }
            else
            {
                ErrorMsgs("NoSelected");
            }
        }

        private void gv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dv = (DataRowView)gv_data.Rows[e.RowIndex].DataBoundItem;
                dr = dv.Row;
                //0 - account ID //2 - category id //4 - transactionid //5 - Note //6 - amount
                selectedId = Convert.ToInt32(dr.ItemArray[4]);

                cb_Accounts.SelectedValue = Convert.ToInt32(dr.ItemArray[0]);
                cb_category.SelectedValue = Convert.ToInt32(dr.ItemArray[2]);
                txt_note.Text = dr.ItemArray[5].ToString(); 
                txt_amount.Text = dr.ItemArray[6].ToString();
                existingAmount = txt_amount.Text;
                existingAccount = cb_Accounts.Text;
            }
            ErrorMsgs("Hide");
        }
    }
}

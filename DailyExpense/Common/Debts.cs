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
    public partial class Debts: Form
    {
        Controller.Database database = new Controller.Database();
        DataTable accountTable;
        Model.DebtEntity debt = new Model.DebtEntity();
        DataGridViewLinkColumn col_delete;
        DataGridViewColumn col_person;
        DataGridViewColumn col_amount;
        DataGridViewColumn col_notes;
        DataRowView dv;
        DataRow dr;
        bool eventAdded;

        public Debts()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_error);
            eventAdded = false;
            setUI();
        }

        //Set the UI for the page
        private void setUI()
        {
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.Debts);

            accountTable = database.GetAccounts();
            DataRow dr = accountTable.NewRow();
            dr.ItemArray = new object[4] {0, "(None)", 0, 1};
            accountTable.Rows.InsertAt(dr, 0);

            cb_Accounts.DataSource = accountTable;
            cb_Accounts.DisplayMember = "AccountName";
            cb_Accounts.ValueMember = "AccountId";

            col_delete = new DataGridViewLinkColumn();
            col_delete.UseColumnTextForLinkValue = true;
            col_delete.DataPropertyName = "DebtId";
            col_delete.Name = "";
            col_delete.Text = "DELETE";
            col_delete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_delete.Width = 60;

            col_person = new DataGridViewTextBoxColumn();
            col_person.Name = "Name";
            col_person.DataPropertyName = "Person";
            col_person.Width = 80;

            col_notes = new DataGridViewTextBoxColumn();
            col_notes.Name = "Note";
            col_notes.DataPropertyName = "Notes";
            col_notes.Width = 147;

            col_amount = new DataGridViewTextBoxColumn();
            col_amount.Name = "Amount";
            col_amount.DataPropertyName = "Amount";
            col_amount.Width = 70;
            col_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Reload(true);
            rb_receiveView.Checked = true;
        }

        //Function to run on Reload
        private void Reload(bool ReceiveChecked)
        {
            rb_receive.Checked = true;
            txt_amount.Text = "";
            txt_name.Text = "";
            txt_note.Text = "";
            cb_Accounts.SelectedIndex = 0;
            if (ReceiveChecked)
            {
                rb_receiveView.Checked = true;
            }
            else
            {
                rb_payView.Checked = true;
            }
            GetViewData(ReceiveChecked);
            gv_display.Focus();
        }

        //Function to load Data in Grid View
        private void GetViewData(bool Recievable)
        {
            
            if (Recievable)
            {
                gv_display.DataSource = database.GetDebts(1);
            }
            else
            {
                gv_display.DataSource = database.GetDebts(0);
            }
            gv_display.Columns.Clear();
            gv_display.Columns.Add(col_person);
            gv_display.Columns.Add(col_amount);
            gv_display.Columns.Add(col_notes);
            gv_display.Columns.Add(col_delete);
            
            col_person.DisplayIndex = 0;
            col_amount.DisplayIndex = 1;
            col_notes.DisplayIndex = 2;
            col_delete.DisplayIndex = 3;

            if (!eventAdded)
            {
                gv_display.CellContentClick += new DataGridViewCellEventHandler(this.gv_display_CellContentClick);
                eventAdded = true;
            }
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "Blank":
                    lbl_error.Text = "Fields cannot be left blank.";
                    lbl_error.Location = new Point(90, 300);
                    break;

                case "Valid":
                    lbl_error.Text = "Invalid Characters.";
                    lbl_error.Location = new Point(110, 300);
                    break;

                case "UpdateSuccess":
                    lbl_error.Text = "Debt Added Successfully.";
                    lbl_error.Location = new Point(88, 300);
                    break;

                case "UpdateFail":
                    lbl_error.Text = "Could not Update Debt.";
                    lbl_error.Location = new Point(100, 300);
                    break;

                case "DeleteError":
                    lbl_error.Text = "Could not Delete Debt.";
                    lbl_error.Location = new Point(100, 300);
                    break;

                case "NoSelected":
                    lbl_error.Text = "Please select a record first.";
                    lbl_error.Location = new Point(88, 300);
                    break;

                case "Receive":
                    lbl_message.Text = "Reduce Amount from Account.";
                    lbl_message.Location = new Point(50, 225);
                    break;

                case "Pay":
                    lbl_message.Text = "Add Amount to Account.";
                    lbl_message.Location = new Point(67, 225);
                    break;

                default:
                    lbl_error.Text = "";
                    break;
            }
        }

        #region ChangeEvents
        private void rb_receiveView_CheckedChanged(object sender, EventArgs e)
        {
            GetViewData(true);
        }

        private void rb_payView_CheckedChanged(object sender, EventArgs e)
        {
            GetViewData(false);
        }
        
        private void rb_receive_CheckedChanged(object sender, EventArgs e)
        {
            ErrorMsgs("Receive");
        }

        private void rb_pay_CheckedChanged(object sender, EventArgs e)
        {
            ErrorMsgs("Pay");
        }
        #endregion

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_amount.Text) || string.IsNullOrEmpty(txt_name.Text))
            {
                ErrorMsgs("Blank");
                return;
            }
            else if (!Controller.Validations.IsProperNumber(txt_amount) || !Controller.Validations.ProperText(txt_name))
            {
                ErrorMsgs("Valid");
                return;
            }
            debt.Amount = Convert.ToInt32(txt_amount.Text);
            debt.Name = txt_name.Text;
            debt.Note = txt_note.Text;
            debt.Receivable = Convert.ToInt32(rb_receive.Checked);
            if (Convert.ToInt32(cb_Accounts.SelectedValue) == 0)
            {
                debt.AdjustAmount = false;
            }
            else
            {
                debt.Account = Convert.ToInt32(cb_Accounts.SelectedValue);
                debt.AdjustAmount = true;
            }
            if (database.AddDebt(debt))
            {
                ErrorMsgs("UpdateSuccess");
                Reload(rb_receive.Checked);
                return;
            }
            ErrorMsgs("UpdateFail");
        }

        private void gv_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dv = (DataRowView)gv_display.Rows[e.RowIndex].DataBoundItem;
                dr = dv.Row;
                //0 - debtID //1 - person//2 - amount //3 - Notes //4 - Account
                debt.Id = Convert.ToInt32(dr.ItemArray[0]);
                debt.Amount = Convert.ToInt32(dr.ItemArray[2]);
                debt.AdjustAmount = false;
                debt.Name = dr.ItemArray[1].ToString();
                debt.Account = Convert.ToInt32(dr.ItemArray[4]);
                DialogResult resultDelete = MessageBox.Show(Controller.Messages.DeleteDebt, "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (resultDelete.ToString() == "Yes")
                {
                    if (debt.Account != 0)
                    {
                        string accountName = database.GetAccountName(debt.Account);
                        if (!string.IsNullOrEmpty(accountName))
                        {
                            accountName = ": " + accountName + " ? \n";
                        }

                        DialogResult resultAdjust = MessageBox.Show(Controller.Messages.AdjustAmount + accountName, "Confirm Adjustment",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (resultAdjust.ToString() == "Yes")
                        {
                            debt.Receivable = Convert.ToInt32(rb_receiveView.Checked);
                            debt.AdjustAmount = true;
                        }
                    }
                    database.DeleteDebt(debt);
                    GetViewData(rb_receiveView.Checked);
                }
            }
            ErrorMsgs("Hide");
        }
    }
}

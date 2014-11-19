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
    public partial class AddExpense : Form
    {

        Controller.Database database = new Controller.Database();
        DataTable accountTable;
        DataTable categoryTable;
        Model.ExpenseEntity expense = new Model.ExpenseEntity();
        ComboBox[] cb_category = new ComboBox[5];
        TextBox[] txt_amount = new TextBox[5];
        TextBox[] txt_note = new TextBox[5];
        Button[] btn = new Button[4];

        public AddExpense()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_curBalVal);
            Controller.UISettings.SetErrorMessage(lbl_newBalVal);
            Controller.UISettings.SetErrorMessage(lbl_error);
            setUI();
        }

        //Set the UI for the page
        public void setUI()
        {
            categoryTable = database.GetCategories();
            
            //Category combo box
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.AddExpense);
            cb_category[0] = comboBox1;
            cb_category[1] = comboBox2;
            cb_category[2] = comboBox3;
            cb_category[3] = comboBox4;
            cb_category[4] = comboBox5;
            for (int i = 0; i < 5; i++)
            {
                cb_category[i].Visible = false;
                cb_category[i].DataSource = new DataView(categoryTable);
                cb_category[i].DisplayMember = "CategoryName";
                cb_category[i].ValueMember = "CategoryId";
            }

            //Text box for amount
            txt_amount[0] = textBox1;
            txt_amount[1] = textBox3;
            txt_amount[2] = textBox5;
            txt_amount[3] = textBox7;
            txt_amount[4] = textBox9;
            for (int i = 0; i < 5; i++)
            {
                txt_amount[i].Visible = false;
            }

            //Text box for note
            txt_note[0] = textBox2;
            txt_note[1] = textBox4;
            txt_note[2] = textBox6;
            txt_note[3] = textBox8;
            txt_note[4] = textBox10;
            for (int i = 0; i < 5; i++)
            {
                txt_note[i].Visible = false;
            }

            //Button for add new
            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            for (int i = 0; i < 4; i++)
            {
                btn[i].Visible = false;
            }

            Reload(false);
        }

        //Function to Trigger on Reload
        private void Reload(bool partial)
        {
            if (!partial)
            {
                //Get Account Details
                accountTable = database.GetAccounts();
                this.cb_Accounts.SelectedValueChanged -= new System.EventHandler(this.cb_Accounts_SelectedValueChanged);
                cb_Accounts.DataSource = accountTable;
                cb_Accounts.DisplayMember = "AccountName";
                cb_Accounts.ValueMember = "AccountId";
                this.cb_Accounts.SelectedValueChanged += new System.EventHandler(this.cb_Accounts_SelectedValueChanged);
            }

            if (Convert.ToInt32(cb_Accounts.SelectedValue) > 0)
            {
                lbl_curBalVal.Text = accountTable.Rows[Convert.ToInt32(cb_Accounts.SelectedIndex)]["Amount"].ToString();
                lbl_newBalVal.Text = accountTable.Rows[Convert.ToInt32(cb_Accounts.SelectedIndex)]["Amount"].ToString();
                ShowControls(0, true);
                ShowControls(1, false);
                ShowControls(2, false);
                ShowControls(3, false);
                ShowControls(4, false);
            }
            ErrorMsgs("Hide");
        }

        //Function to set if to show or not
        private void ShowControls(int index, bool show)
        {
            cb_category[index].SelectedIndex = 1;
            cb_category[index].Visible = show;

            txt_amount[index].Text = "";
            txt_amount[index].Visible = show;

            txt_note[index].Text = "";
            txt_note[index].Visible = show;

            if(index < 4)
                btn[index].Visible = show;
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "AddValid":
                    lbl_error.Text = "Invalid Characters.";
                    lbl_error.Location = new Point(360, 275);
                    break;

                case "AddError":
                    lbl_error.Text = "Could not Add Expenses.";
                    lbl_error.Location = new Point(347, 275);
                    break;

                case "AddSuccess":
                    lbl_error.Text = "Expenses Added Successfully.";
                    lbl_error.Location = new Point(333, 275);
                    break;

                default:
                    lbl_error.Text = "";
                    break;
            }
        }

        #region OnChange
        private void cb_Accounts_SelectedValueChanged(object sender, EventArgs e)
        {
            Reload(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowControls(1, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowControls(2, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowControls(3, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowControls(4, true);
        }

        #endregion

        #region AmountValidation
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validateAmount(textBox1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            validateAmount(textBox3);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            validateAmount(textBox5);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            validateAmount(textBox7);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            validateAmount(textBox9);
        }

        private void validateAmount(TextBox txt)
        { 
            int result;
            if (!int.TryParse(txt.Text, out result) && !string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = txt.Text.Remove(txt.Text.Length - 1);
                txt.SelectionStart = txt.Text.Length;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            changeLabelAmount(textBox1, true);
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            changeLabelAmount(textBox3, true);
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            changeLabelAmount(textBox5, true);
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            changeLabelAmount(textBox7, true);
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            changeLabelAmount(textBox9, true);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            changeLabelAmount(textBox1, false);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            changeLabelAmount(textBox3, false);
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            changeLabelAmount(textBox5, false);
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            changeLabelAmount(textBox7, false);
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            changeLabelAmount(textBox9, false);
        }

        private void changeLabelAmount(TextBox txt, bool add)
        {
            if (txt.Text.Length > 0)
            {
                if (add)
                {
                    lbl_newBalVal.Text = (Convert.ToInt32(lbl_newBalVal.Text) + Convert.ToInt32(txt.Text)).ToString();
                }
                else
                {
                    lbl_newBalVal.Text = (Convert.ToInt32(lbl_newBalVal.Text) - Convert.ToInt32(txt.Text)).ToString();
                }
            }
        }
        #endregion

        private void btn_add_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                if (!Controller.Validations.NoInvalidCharacters(txt_note[i]))
                {
                    ErrorMsgs("AddValid");
                    return;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (!string.IsNullOrEmpty(txt_amount[i].Text))
                {
                    expense.Date = cal_date.SelectionStart;
                    expense.Account = Convert.ToInt32(cb_Accounts.SelectedValue);
                    expense.Category = Convert.ToInt32(cb_category[i].SelectedValue);
                    expense.Amount = Convert.ToInt32(txt_amount[i].Text);
                    expense.Note = txt_note[i].Text;
                    total+= database.AddExpense(expense);
                }
            }
            if (total == 0)
            {
                ErrorMsgs("AddError");
            }
            else
            {
                Reload(false);
                ErrorMsgs("AddSuccess");
                cb_Accounts.Focus();
            }
        }

    }
}

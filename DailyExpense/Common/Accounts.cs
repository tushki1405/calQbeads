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
    public partial class Accounts : Form
    {
        Controller.Database database = new Controller.Database();
        DataTable accountTable;
        Model.AccountEntity account = new Model.AccountEntity();
        string currentSelection;

        #region Constants
        public Accounts()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_curBal);
            Controller.UISettings.SetErrorMessage(lbl_currentBalance);
            Controller.UISettings.SetErrorMessage(lbl_error);
            Controller.UISettings.SetErrorMessage(lbl_mainAccountError);
            Controller.UISettings.SetErrorMessage(lbl_transferError);
            //Controller.UISettings.SetErrorMessage(lbl_sourceAccount1);
            setUI();
        }

        //Set the UI for the page
        public void setUI()
        {
            lbl_curBal.Text = "Current Balance in Account:";
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.Accounts);

            pnl_base.Location = new Point(320, 43);

            pnl_EditBalance.BorderStyle = BorderStyle.FixedSingle;
            pnl_EditBalance.Location = new Point(320, 43);

            pnl_editAccount.BorderStyle = BorderStyle.FixedSingle;
            pnl_editAccount.Location = new Point(320, 43);

            pnl_transfer.BorderStyle = BorderStyle.FixedSingle;
            pnl_transfer.Location = new Point(320, 43);
            
            pnl_general.BorderStyle = BorderStyle.FixedSingle;
            pnl_general.Location = new Point(320, 43);
            
            Reload(false);
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "AccountValid":
                    lbl_error.Text = "Invalid Characters.";
                    lbl_error.Location = new Point(283, 70);
                    break;

                case "AccountError":
                    lbl_error.Text = "Could not Add Account.";
                    lbl_error.Location = new Point(283, 70);
                    break;

                case "AccountSuccess":
                    lbl_error.Text = "Account Added Successfully.";
                    lbl_error.Location = new Point(283, 70);
                    break;

                case "ChangeValid":
                    lbl_mainAccountError.Text = "Invalid Characters.";
                    lbl_mainAccountError.Location = new Point(447, 193);
                    break;

                case "ChangeError":
                    lbl_mainAccountError.Text = "Could not Update Name.";
                    lbl_mainAccountError.Location = new Point(434, 193);
                    break;

                case "ChangeSuccess":
                    lbl_mainAccountError.Text = "Name Updated Successfully.";
                    lbl_mainAccountError.Location = new Point(425, 193);
                    break;

                case "DeleteError":
                    lbl_mainAccountError.Text = "Could not Delete Account.";
                    lbl_mainAccountError.Location = new Point(40, 260);
                    break;

                case "NotNumber":
                    lbl_mainAccountError.Text = "Can contain only Numbers.";
                    lbl_mainAccountError.Location = new Point(425, 245);
                    break;

                case "AmountChanged":
                    lbl_mainAccountError.Text = "Amount Updated Successfully.";
                    lbl_mainAccountError.Location = new Point(418, 245);
                    break;

                case "AmountError":
                    lbl_mainAccountError.Text = "Could not Update Account.";
                    lbl_mainAccountError.Location = new Point(425, 245);
                    break;

                case "General":
                    lbl_mainAccountError.Text = "Edit Account : " + cb_Accounts.Text;
                    lbl_mainAccountError.Location = new Point(330, 184);
                    break;

                case "TransferValid":
                    lbl_transferError.Text = "Invalid Characters.";
                    lbl_transferError.Location = new Point(125, 265);
                    break;

                case "TransferError":
                    lbl_transferError.Text = "Could not Transfer Amount.";
                    lbl_transferError.Location = new Point(100, 265);
                    break;

                case "TransferSuccess":
                    lbl_transferError.Text = "Amount Transferred Successfully.";
                    lbl_transferError.Location = new Point(85, 265);
                    break;

                default:
                    lbl_error.Text = "";
                    lbl_mainAccountError.Text = "";
                    lbl_transferError.Text = "";
                    break;
            }
        }

        #endregion

        #region Panels
        //Function to execute when value is changed
        private void SetVisibility(string panel, bool show)
        {
            int y;
            int maxY = pnl_general.Height;

            if (panel == "Main")
            {
                pnl_accountOptions.Visible = show;
                pnl_EditBalance.Visible = show;
                pnl_editAccount.Visible = show;
                pnl_transfer.Visible = show;
                pnl_general.Visible = !show;
            }
            else if (panel == "All")
            {
                pnl_EditBalance.Visible = show;
                pnl_editAccount.Visible = show;
                pnl_transfer.Visible = show;
                pnl_general.Visible = !show;
                for (y = maxY; y >= 0; y--)
                {
                    pnl_general.Height = y;
                    System.Threading.Thread.Sleep(Controller.UISettingsValues.delayFast);
                }
                for (y = maxY; y >= 0; y--)
                {
                    pnl_general.Height = maxY - y;
                    System.Threading.Thread.Sleep(Controller.UISettingsValues.delayFast);
                }
                pnl_general.Visible = show;
            }
            else if (panel == "Balance")
            {
                SetVisibility("All", false);
                pnl_EditBalance.Visible = show;
            }
            else if (panel == "Account")
            {
                SetVisibility("All", false);
                pnl_editAccount.Visible = show;
            }
            else if (panel == "Transfer")
            {
                SetVisibility("All", false);
                pnl_transfer.Visible = show;
            }
            else if (panel == "")
            {
                SetVisibility("All", false);
                pnl_general.Visible = show;
                ErrorMsgs("General");
            }
        }

        //Show the edit panel
        private void btn_editBalance_Click(object sender, EventArgs e)
        {
            ErrorMsgs("Hide");
            SetVisibility("Balance", true);
            txt_amount.Focus();
        }

        //show the Account Panel
        private void btn_editAccount_Click(object sender, EventArgs e)
        {
            ErrorMsgs("Hide");
            SetVisibility("Account", true);
            txt_editName.Focus();
        }

        
        private void btn_transferAccount_Click(object sender, EventArgs e)
        {
            lbl_sourceAccount1.Text = "Source Account : " + cb_Accounts.Text;
            ErrorMsgs("Hide");
            SetVisibility("Transfer", true);
            txt_transfer.Focus();
        }

        #endregion

        #region Common
        //Function to Trigger on Reload
        private void Reload(bool partial)
        {
            //Get Account Details
            accountTable = database.GetAccounts();
            this.cb_Accounts.SelectedValueChanged -= new System.EventHandler(this.cb_Accounts_SelectedValueChanged);
            cb_Accounts.DataSource = new DataView(accountTable);
            cb_Accounts.DisplayMember = "AccountName";
            cb_Accounts.ValueMember = "AccountId";

            cb_transfer.DataSource = new DataView(accountTable);
            cb_transfer.DisplayMember = "AccountName";
            cb_transfer.ValueMember = "AccountId";
            if (!string.IsNullOrEmpty(currentSelection))
            {
                int i = 0;
                foreach (DataRow dr in accountTable.Rows)
                {
                    if (dr["AccountName"].ToString() == currentSelection)
                    {
                        cb_Accounts.SelectedIndex = i;
                        currentSelection = "";
                        break;
                    }
                    i++;
                }
            }

            if (partial)
            {
                cb_Accounts.SelectedValue = account.AccountId;
                pnl_accountOptions.Visible = true;
                lbl_currentBalance.Text = accountTable.Rows[Convert.ToInt32(cb_Accounts.SelectedIndex)]["Amount"].ToString();
                lbl_currentBalance.Text = cb_Accounts.Text + " : " + lbl_currentBalance.Text;
                this.cb_Accounts.SelectedValueChanged += new System.EventHandler(this.cb_Accounts_SelectedValueChanged);
            }
            else
            {
                this.cb_Accounts.SelectedValueChanged += new System.EventHandler(this.cb_Accounts_SelectedValueChanged);
                lbl_currentBalance.Text = "";
                ErrorMsgs("Hide");
                SetVisibility("Main", false);

                //Show Panel if Value is selected
                if (Convert.ToInt32(cb_Accounts.SelectedValue) > 0)
                {
                    pnl_accountOptions.Visible = true;
                    lbl_currentBalance.Text = accountTable.Rows[Convert.ToInt32(cb_Accounts.SelectedIndex)]["Amount"].ToString();
                    lbl_currentBalance.Text = cb_Accounts.Text + " : " + lbl_currentBalance.Text;
                    ErrorMsgs("General");
                }
            }
        }

        //On change of drop down list
        private void cb_Accounts_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_currentBalance.Text = accountTable.Rows[Convert.ToInt32(cb_Accounts.SelectedIndex)]["Amount"].ToString();
            lbl_currentBalance.Text = cb_Accounts.Text + " : " + lbl_currentBalance.Text;
            ErrorMsgs("Hide");
            SetVisibility("", true);
        }

        #endregion

        #region Functionality
        //Add a New Account
        private void btn_newAccount_Click(object sender, EventArgs e)
        {
            if(!Controller.Validations.ProperText(txt_newAccount))
            {
                ErrorMsgs("AccountValid");
                return;
            }
            account.AccountName = txt_newAccount.Text;
            if (database.AddAccount(account))
            {
                ErrorMsgs("AccountSuccess");
                txt_newAccount.Text = "";
                txt_newAccount.Focus();
                currentSelection = account.AccountName;
                Reload(false);
                return;
            }
            ErrorMsgs("AccountError");
        }

        //Delete Existing Account
        private void DeleteAccount()
        {
            account.AccountId = Convert.ToInt32(cb_Accounts.SelectedValue);
            if (database.DeleteAccount(account))
            {
                Reload(false);
                return;
            }
            ErrorMsgs("DeleteError");
        }

        //Add amount in account
        private void btn_addAmount_Click(object sender, EventArgs e)
        {
            if (!Controller.Validations.IsProperNumber(txt_amount))
            {
                ErrorMsgs("NotNumber");
                return;
            }
            account.Amount = Convert.ToInt32(txt_amount.Text);
            account.AccountId = Convert.ToInt32(cb_Accounts.SelectedValue);
            account.AddAmount = true;
            if (database.ChangeAmount(account))
            {
                ErrorMsgs("AmountChanged");
                Reload(true);
                txt_amount.Text = "";
                txt_amount.Focus();
                return;
            }
            ErrorMsgs("AmountError");
        }

        //Reduce Amount
        private void btn_reduceAmount_click(object sender, EventArgs e)
        {
            if (!Controller.Validations.IsProperNumber(txt_amount))
            {
                ErrorMsgs("NotNumber");
                return;
            }
            account.Amount = Convert.ToInt32(txt_amount.Text);
            account.AccountId = Convert.ToInt32(cb_Accounts.SelectedValue);
            account.AddAmount = false;
            if (database.ChangeAmount(account))
            {
                ErrorMsgs("AmountChanged");
                Reload(true);
                txt_amount.Text = "";
                txt_amount.Focus();
                return;
            }
            ErrorMsgs("AmountError");
        }

        //Change Name
        private void btn_changeName_Click(object sender, EventArgs e)
        {
            if (!Controller.Validations.ProperText(txt_editName))
            {
                ErrorMsgs("ChangeValid");
                return;
            }
            account.AccountName = txt_editName.Text;
            account.AccountId = Convert.ToInt32(cb_Accounts.SelectedValue);
            if (database.ChangeName(account))
            {
                ErrorMsgs("ChangeSuccess");
                txt_editName.Text = "";
                txt_editName.Focus();
                Reload(true);
                return;
            }
            ErrorMsgs("ChangeError");
        }

        //Transfer Amount
        private void btn_transfer_Click(object sender, EventArgs e)
        {
            if (!Controller.Validations.IsProperNumber(txt_transfer))
            {
                ErrorMsgs("TransferValid");
                return;
            }
            account.Amount = Convert.ToInt32(txt_transfer.Text);
            account.AccountId = Convert.ToInt32(cb_Accounts.SelectedValue);
            account.AddAmount = false;
            if (database.ChangeAmount(account))
            {
                account.AccountId = Convert.ToInt32(cb_transfer.SelectedValue);
                account.AddAmount = true;
                if (database.ChangeAmount(account))
                {
                    //To keep on the same account
                    account.AccountId = Convert.ToInt32(cb_Accounts.SelectedValue);
                    ErrorMsgs("TransferSuccess");
                    Reload(true);
                    txt_transfer.Text = "";
                    txt_transfer.Focus();
                    return;
                }
            }
            ErrorMsgs("TransferError");
        }

        //Show the Delete and General Panel
        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult resultDelete = MessageBox.Show(Controller.Messages.DeleteAccount, "Confirm Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resultDelete.ToString() == "Yes")
            {
                DeleteAccount();
            }
            ErrorMsgs("Hide");
            SetVisibility("", true);
        }

        private void txt_newAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_newAccount_Click(null, null);
            }
        }

        private void txt_transfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_transfer_Click(null, null);
            }
        }

        private void txt_editName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_changeName_Click(null, null);
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_addAmount_Click(null, null);
            }
        }
        #endregion

    }
}

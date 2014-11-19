namespace DailyExpense.Common
{
    partial class Accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_newAccount = new System.Windows.Forms.Label();
            this.txt_newAccount = new System.Windows.Forms.TextBox();
            this.btn_newAccount = new System.Windows.Forms.Button();
            this.gb_newAccount = new System.Windows.Forms.GroupBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.gb_existingAccounts = new System.Windows.Forms.GroupBox();
            this.pnl_transfer = new System.Windows.Forms.Panel();
            this.lbl_transferError = new System.Windows.Forms.Label();
            this.txt_transfer = new System.Windows.Forms.TextBox();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_transfer = new System.Windows.Forms.ComboBox();
            this.lbl_mainAccountError = new System.Windows.Forms.Label();
            this.pnl_editAccount = new System.Windows.Forms.Panel();
            this.btn_changeName = new System.Windows.Forms.Button();
            this.txt_editName = new System.Windows.Forms.TextBox();
            this.pnl_general = new System.Windows.Forms.Panel();
            this.pnl_EditBalance = new System.Windows.Forms.Panel();
            this.btn_reduceAmount = new System.Windows.Forms.Button();
            this.btn_addAmount = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_currentBalance = new System.Windows.Forms.Label();
            this.lbl_curBal = new System.Windows.Forms.Label();
            this.pnl_accountOptions = new System.Windows.Forms.Panel();
            this.btn_deleteAccount = new System.Windows.Forms.Button();
            this.btn_transferAccount = new System.Windows.Forms.Button();
            this.btn_editAccount = new System.Windows.Forms.Button();
            this.btn_editBalance = new System.Windows.Forms.Button();
            this.cb_Accounts = new System.Windows.Forms.ComboBox();
            this.pnl_base = new System.Windows.Forms.Panel();
            this.lbl_sourceAccount1 = new System.Windows.Forms.Label();
            this.gb_newAccount.SuspendLayout();
            this.gb_existingAccounts.SuspendLayout();
            this.pnl_transfer.SuspendLayout();
            this.pnl_editAccount.SuspendLayout();
            this.pnl_EditBalance.SuspendLayout();
            this.pnl_accountOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_newAccount
            // 
            this.lbl_newAccount.AutoSize = true;
            this.lbl_newAccount.Location = new System.Drawing.Point(26, 26);
            this.lbl_newAccount.Name = "lbl_newAccount";
            this.lbl_newAccount.Size = new System.Drawing.Size(158, 13);
            this.lbl_newAccount.TabIndex = 0;
            this.lbl_newAccount.Text = "Enter a Name for New Account:";
            // 
            // txt_newAccount
            // 
            this.txt_newAccount.Location = new System.Drawing.Point(190, 24);
            this.txt_newAccount.MaxLength = 50;
            this.txt_newAccount.Name = "txt_newAccount";
            this.txt_newAccount.Size = new System.Drawing.Size(204, 20);
            this.txt_newAccount.TabIndex = 1;
            this.txt_newAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_newAccount_KeyDown);
            // 
            // btn_newAccount
            // 
            this.btn_newAccount.Location = new System.Drawing.Point(406, 22);
            this.btn_newAccount.Name = "btn_newAccount";
            this.btn_newAccount.Size = new System.Drawing.Size(84, 23);
            this.btn_newAccount.TabIndex = 2;
            this.btn_newAccount.Text = "Add Account";
            this.btn_newAccount.UseVisualStyleBackColor = true;
            this.btn_newAccount.Click += new System.EventHandler(this.btn_newAccount_Click);
            // 
            // gb_newAccount
            // 
            this.gb_newAccount.Controls.Add(this.lbl_error);
            this.gb_newAccount.Controls.Add(this.lbl_newAccount);
            this.gb_newAccount.Controls.Add(this.btn_newAccount);
            this.gb_newAccount.Controls.Add(this.txt_newAccount);
            this.gb_newAccount.Location = new System.Drawing.Point(22, 12);
            this.gb_newAccount.Name = "gb_newAccount";
            this.gb_newAccount.Size = new System.Drawing.Size(516, 65);
            this.gb_newAccount.TabIndex = 1;
            this.gb_newAccount.TabStop = false;
            this.gb_newAccount.Text = "New Account";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(191, 46);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_error.TabIndex = 3;
            this.lbl_error.Text = "Error";
            // 
            // gb_existingAccounts
            // 
            this.gb_existingAccounts.Controls.Add(this.pnl_EditBalance);
            this.gb_existingAccounts.Controls.Add(this.pnl_editAccount);
            this.gb_existingAccounts.Controls.Add(this.pnl_transfer);
            this.gb_existingAccounts.Controls.Add(this.lbl_mainAccountError);
            this.gb_existingAccounts.Controls.Add(this.pnl_general);
            this.gb_existingAccounts.Controls.Add(this.lbl_currentBalance);
            this.gb_existingAccounts.Controls.Add(this.lbl_curBal);
            this.gb_existingAccounts.Controls.Add(this.pnl_accountOptions);
            this.gb_existingAccounts.Controls.Add(this.cb_Accounts);
            this.gb_existingAccounts.Controls.Add(this.pnl_base);
            this.gb_existingAccounts.Location = new System.Drawing.Point(22, 83);
            this.gb_existingAccounts.Name = "gb_existingAccounts";
            this.gb_existingAccounts.Size = new System.Drawing.Size(516, 270);
            this.gb_existingAccounts.TabIndex = 2;
            this.gb_existingAccounts.TabStop = false;
            this.gb_existingAccounts.Text = "Existing Accounts";
            // 
            // pnl_transfer
            // 
            this.pnl_transfer.Controls.Add(this.lbl_sourceAccount1);
            this.pnl_transfer.Controls.Add(this.lbl_transferError);
            this.pnl_transfer.Controls.Add(this.txt_transfer);
            this.pnl_transfer.Controls.Add(this.btn_transfer);
            this.pnl_transfer.Controls.Add(this.label2);
            this.pnl_transfer.Controls.Add(this.label1);
            this.pnl_transfer.Controls.Add(this.cb_transfer);
            this.pnl_transfer.Location = new System.Drawing.Point(276, 246);
            this.pnl_transfer.Name = "pnl_transfer";
            this.pnl_transfer.Size = new System.Drawing.Size(246, 218);
            this.pnl_transfer.TabIndex = 6;
            // 
            // lbl_transferError
            // 
            this.lbl_transferError.AutoSize = true;
            this.lbl_transferError.Location = new System.Drawing.Point(4, 4);
            this.lbl_transferError.Name = "lbl_transferError";
            this.lbl_transferError.Size = new System.Drawing.Size(35, 13);
            this.lbl_transferError.TabIndex = 9;
            this.lbl_transferError.Text = "label3";
            // 
            // txt_transfer
            // 
            this.txt_transfer.Location = new System.Drawing.Point(70, 67);
            this.txt_transfer.MaxLength = 10;
            this.txt_transfer.Name = "txt_transfer";
            this.txt_transfer.Size = new System.Drawing.Size(100, 20);
            this.txt_transfer.TabIndex = 8;
            this.txt_transfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_transfer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_transfer_KeyDown);
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(83, 153);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(75, 23);
            this.btn_transfer.TabIndex = 4;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // cb_transfer
            // 
            this.cb_transfer.FormattingEnabled = true;
            this.cb_transfer.Location = new System.Drawing.Point(45, 123);
            this.cb_transfer.Name = "cb_transfer";
            this.cb_transfer.Size = new System.Drawing.Size(155, 21);
            this.cb_transfer.TabIndex = 1;
            // 
            // lbl_mainAccountError
            // 
            this.lbl_mainAccountError.AutoSize = true;
            this.lbl_mainAccountError.Location = new System.Drawing.Point(6, 16);
            this.lbl_mainAccountError.Name = "lbl_mainAccountError";
            this.lbl_mainAccountError.Size = new System.Drawing.Size(35, 13);
            this.lbl_mainAccountError.TabIndex = 5;
            this.lbl_mainAccountError.Text = "label1";
            // 
            // pnl_editAccount
            // 
            this.pnl_editAccount.Controls.Add(this.btn_changeName);
            this.pnl_editAccount.Controls.Add(this.txt_editName);
            this.pnl_editAccount.Location = new System.Drawing.Point(24, 246);
            this.pnl_editAccount.Name = "pnl_editAccount";
            this.pnl_editAccount.Size = new System.Drawing.Size(246, 218);
            this.pnl_editAccount.TabIndex = 5;
            // 
            // btn_changeName
            // 
            this.btn_changeName.Location = new System.Drawing.Point(72, 74);
            this.btn_changeName.Name = "btn_changeName";
            this.btn_changeName.Size = new System.Drawing.Size(100, 23);
            this.btn_changeName.TabIndex = 11;
            this.btn_changeName.Text = "Change Name";
            this.btn_changeName.UseVisualStyleBackColor = true;
            this.btn_changeName.Click += new System.EventHandler(this.btn_changeName_Click);
            // 
            // txt_editName
            // 
            this.txt_editName.Location = new System.Drawing.Point(72, 45);
            this.txt_editName.MaxLength = 50;
            this.txt_editName.Name = "txt_editName";
            this.txt_editName.Size = new System.Drawing.Size(100, 20);
            this.txt_editName.TabIndex = 10;
            this.txt_editName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_editName_KeyDown);
            // 
            // pnl_general
            // 
            this.pnl_general.Location = new System.Drawing.Point(190, 22);
            this.pnl_general.Name = "pnl_general";
            this.pnl_general.Size = new System.Drawing.Size(246, 218);
            this.pnl_general.TabIndex = 4;
            // 
            // pnl_EditBalance
            // 
            this.pnl_EditBalance.Controls.Add(this.btn_reduceAmount);
            this.pnl_EditBalance.Controls.Add(this.btn_addAmount);
            this.pnl_EditBalance.Controls.Add(this.txt_amount);
            this.pnl_EditBalance.Location = new System.Drawing.Point(468, 22);
            this.pnl_EditBalance.Name = "pnl_EditBalance";
            this.pnl_EditBalance.Size = new System.Drawing.Size(246, 218);
            this.pnl_EditBalance.TabIndex = 4;
            // 
            // btn_reduceAmount
            // 
            this.btn_reduceAmount.Location = new System.Drawing.Point(92, 104);
            this.btn_reduceAmount.Name = "btn_reduceAmount";
            this.btn_reduceAmount.Size = new System.Drawing.Size(57, 23);
            this.btn_reduceAmount.TabIndex = 9;
            this.btn_reduceAmount.Text = "Reduce";
            this.btn_reduceAmount.UseVisualStyleBackColor = true;
            this.btn_reduceAmount.Click += new System.EventHandler(this.btn_reduceAmount_click);
            // 
            // btn_addAmount
            // 
            this.btn_addAmount.Location = new System.Drawing.Point(92, 75);
            this.btn_addAmount.Name = "btn_addAmount";
            this.btn_addAmount.Size = new System.Drawing.Size(57, 23);
            this.btn_addAmount.TabIndex = 8;
            this.btn_addAmount.Text = "Add";
            this.btn_addAmount.UseVisualStyleBackColor = true;
            this.btn_addAmount.Click += new System.EventHandler(this.btn_addAmount_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(72, 45);
            this.txt_amount.MaxLength = 10;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_amount.TabIndex = 7;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyDown);
            // 
            // lbl_currentBalance
            // 
            this.lbl_currentBalance.AutoSize = true;
            this.lbl_currentBalance.Location = new System.Drawing.Point(25, 75);
            this.lbl_currentBalance.Name = "lbl_currentBalance";
            this.lbl_currentBalance.Size = new System.Drawing.Size(46, 13);
            this.lbl_currentBalance.TabIndex = 4;
            this.lbl_currentBalance.Text = "Balance";
            // 
            // lbl_curBal
            // 
            this.lbl_curBal.AutoSize = true;
            this.lbl_curBal.Location = new System.Drawing.Point(26, 61);
            this.lbl_curBal.Name = "lbl_curBal";
            this.lbl_curBal.Size = new System.Drawing.Size(143, 13);
            this.lbl_curBal.TabIndex = 3;
            this.lbl_curBal.Text = "Current Balance in Account: ";
            // 
            // pnl_accountOptions
            // 
            this.pnl_accountOptions.Controls.Add(this.btn_deleteAccount);
            this.pnl_accountOptions.Controls.Add(this.btn_transferAccount);
            this.pnl_accountOptions.Controls.Add(this.btn_editAccount);
            this.pnl_accountOptions.Controls.Add(this.btn_editBalance);
            this.pnl_accountOptions.Location = new System.Drawing.Point(24, 93);
            this.pnl_accountOptions.Name = "pnl_accountOptions";
            this.pnl_accountOptions.Size = new System.Drawing.Size(155, 120);
            this.pnl_accountOptions.TabIndex = 3;
            // 
            // btn_deleteAccount
            // 
            this.btn_deleteAccount.Location = new System.Drawing.Point(5, 90);
            this.btn_deleteAccount.Name = "btn_deleteAccount";
            this.btn_deleteAccount.Size = new System.Drawing.Size(94, 23);
            this.btn_deleteAccount.TabIndex = 11;
            this.btn_deleteAccount.Text = "Delete Amount";
            this.btn_deleteAccount.UseVisualStyleBackColor = true;
            this.btn_deleteAccount.Click += new System.EventHandler(this.btn_deleteAccount_Click);
            // 
            // btn_transferAccount
            // 
            this.btn_transferAccount.Location = new System.Drawing.Point(5, 61);
            this.btn_transferAccount.Name = "btn_transferAccount";
            this.btn_transferAccount.Size = new System.Drawing.Size(95, 23);
            this.btn_transferAccount.TabIndex = 10;
            this.btn_transferAccount.Text = "Transfer Amount";
            this.btn_transferAccount.UseVisualStyleBackColor = true;
            this.btn_transferAccount.Click += new System.EventHandler(this.btn_transferAccount_Click);
            // 
            // btn_editAccount
            // 
            this.btn_editAccount.Location = new System.Drawing.Point(5, 32);
            this.btn_editAccount.Name = "btn_editAccount";
            this.btn_editAccount.Size = new System.Drawing.Size(94, 23);
            this.btn_editAccount.TabIndex = 9;
            this.btn_editAccount.Text = "Edit Account";
            this.btn_editAccount.UseVisualStyleBackColor = true;
            this.btn_editAccount.Click += new System.EventHandler(this.btn_editAccount_Click);
            // 
            // btn_editBalance
            // 
            this.btn_editBalance.Location = new System.Drawing.Point(5, 3);
            this.btn_editBalance.Name = "btn_editBalance";
            this.btn_editBalance.Size = new System.Drawing.Size(94, 23);
            this.btn_editBalance.TabIndex = 8;
            this.btn_editBalance.Text = "Edit Balance";
            this.btn_editBalance.UseVisualStyleBackColor = true;
            this.btn_editBalance.Click += new System.EventHandler(this.btn_editBalance_Click);
            // 
            // cb_Accounts
            // 
            this.cb_Accounts.FormattingEnabled = true;
            this.cb_Accounts.Location = new System.Drawing.Point(27, 30);
            this.cb_Accounts.Name = "cb_Accounts";
            this.cb_Accounts.Size = new System.Drawing.Size(155, 21);
            this.cb_Accounts.TabIndex = 3;
            this.cb_Accounts.SelectedValueChanged += new System.EventHandler(this.cb_Accounts_SelectedValueChanged);
            // 
            // pnl_base
            // 
            this.pnl_base.Location = new System.Drawing.Point(216, 19);
            this.pnl_base.Name = "pnl_base";
            this.pnl_base.Size = new System.Drawing.Size(246, 218);
            this.pnl_base.TabIndex = 4;
            // 
            // lbl_sourceAccount1
            // 
            this.lbl_sourceAccount1.AutoSize = true;
            this.lbl_sourceAccount1.Location = new System.Drawing.Point(21, 25);
            this.lbl_sourceAccount1.Name = "lbl_sourceAccount1";
            this.lbl_sourceAccount1.Size = new System.Drawing.Size(90, 13);
            this.lbl_sourceAccount1.TabIndex = 10;
            this.lbl_sourceAccount1.Text = "Source Account: ";
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 427);
            this.Controls.Add(this.gb_existingAccounts);
            this.Controls.Add(this.gb_newAccount);
            this.Name = "Accounts";
            this.Text = " ";
            this.gb_newAccount.ResumeLayout(false);
            this.gb_newAccount.PerformLayout();
            this.gb_existingAccounts.ResumeLayout(false);
            this.gb_existingAccounts.PerformLayout();
            this.pnl_transfer.ResumeLayout(false);
            this.pnl_transfer.PerformLayout();
            this.pnl_editAccount.ResumeLayout(false);
            this.pnl_editAccount.PerformLayout();
            this.pnl_EditBalance.ResumeLayout(false);
            this.pnl_EditBalance.PerformLayout();
            this.pnl_accountOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_newAccount;
        private System.Windows.Forms.TextBox txt_newAccount;
        private System.Windows.Forms.Button btn_newAccount;
        private System.Windows.Forms.GroupBox gb_newAccount;
        private System.Windows.Forms.GroupBox gb_existingAccounts;
        private System.Windows.Forms.ComboBox cb_Accounts;
        private System.Windows.Forms.Panel pnl_accountOptions;
        private System.Windows.Forms.Label lbl_currentBalance;
        private System.Windows.Forms.Label lbl_curBal;
        private System.Windows.Forms.Panel pnl_EditBalance;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_reduceAmount;
        private System.Windows.Forms.Button btn_addAmount;
        private System.Windows.Forms.Panel pnl_editAccount;
        private System.Windows.Forms.Button btn_changeName;
        private System.Windows.Forms.TextBox txt_editName;
        private System.Windows.Forms.Panel pnl_general;
        private System.Windows.Forms.Panel pnl_base;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_mainAccountError;
        private System.Windows.Forms.Panel pnl_transfer;
        private System.Windows.Forms.ComboBox cb_transfer;
        private System.Windows.Forms.TextBox txt_transfer;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_transferError;
        private System.Windows.Forms.Button btn_deleteAccount;
        private System.Windows.Forms.Button btn_transferAccount;
        private System.Windows.Forms.Button btn_editAccount;
        private System.Windows.Forms.Button btn_editBalance;
        private System.Windows.Forms.Label lbl_sourceAccount1;
    }
}
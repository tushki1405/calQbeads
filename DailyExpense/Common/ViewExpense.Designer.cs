namespace DailyExpense.Common
{
    partial class ViewExpense
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
            this.gb_date = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cal_date = new System.Windows.Forms.MonthCalendar();
            this.gv_data = new System.Windows.Forms.DataGridView();
            this.gb_edit = new System.Windows.Forms.GroupBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_Accounts = new System.Windows.Forms.ComboBox();
            this.lbl_account = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.gb_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).BeginInit();
            this.gb_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_date
            // 
            this.gb_date.Controls.Add(this.lbl_total);
            this.gb_date.Controls.Add(this.label4);
            this.gb_date.Controls.Add(this.cal_date);
            this.gb_date.Controls.Add(this.gv_data);
            this.gb_date.Location = new System.Drawing.Point(12, 12);
            this.gb_date.Name = "gb_date";
            this.gb_date.Size = new System.Drawing.Size(538, 223);
            this.gb_date.TabIndex = 1;
            this.gb_date.TabStop = false;
            this.gb_date.Text = "Select Date and Expense to Edit";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(97, 172);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Expenses: ";
            // 
            // cal_date
            // 
            this.cal_date.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cal_date.Location = new System.Drawing.Point(12, 46);
            this.cal_date.MaxSelectionCount = 1;
            this.cal_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cal_date.Name = "cal_date";
            this.cal_date.TabIndex = 1;
            this.cal_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_date_DateChanged);
            // 
            // gv_data
            // 
            this.gv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_data.Location = new System.Drawing.Point(191, 19);
            this.gv_data.Name = "gv_data";
            this.gv_data.Size = new System.Drawing.Size(330, 190);
            this.gv_data.TabIndex = 2;
            // 
            // gb_edit
            // 
            this.gb_edit.Controls.Add(this.lbl_error);
            this.gb_edit.Controls.Add(this.btn_delete);
            this.gb_edit.Controls.Add(this.cb_Accounts);
            this.gb_edit.Controls.Add(this.lbl_account);
            this.gb_edit.Controls.Add(this.btn_update);
            this.gb_edit.Controls.Add(this.label3);
            this.gb_edit.Controls.Add(this.label2);
            this.gb_edit.Controls.Add(this.label1);
            this.gb_edit.Controls.Add(this.txt_note);
            this.gb_edit.Controls.Add(this.txt_amount);
            this.gb_edit.Controls.Add(this.cb_category);
            this.gb_edit.Location = new System.Drawing.Point(12, 241);
            this.gb_edit.Name = "gb_edit";
            this.gb_edit.Size = new System.Drawing.Size(538, 107);
            this.gb_edit.TabIndex = 2;
            this.gb_edit.TabStop = false;
            this.gb_edit.Text = "Edit Selected Expense";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(428, 83);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_error.TabIndex = 17;
            this.lbl_error.Text = "Error";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(417, 56);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(60, 28);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_Accounts
            // 
            this.cb_Accounts.FormattingEnabled = true;
            this.cb_Accounts.Location = new System.Drawing.Point(12, 75);
            this.cb_Accounts.Name = "cb_Accounts";
            this.cb_Accounts.Size = new System.Drawing.Size(162, 21);
            this.cb_Accounts.TabIndex = 2;
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(11, 56);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(47, 13);
            this.lbl_account.TabIndex = 15;
            this.lbl_account.Text = "Account";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(417, 24);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(60, 28);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(199, 73);
            this.txt_note.MaxLength = 50;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(159, 20);
            this.txt_note.TabIndex = 4;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(199, 33);
            this.txt_amount.MaxLength = 10;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(90, 20);
            this.txt_amount.TabIndex = 3;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(12, 34);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(162, 21);
            this.cb_category.TabIndex = 1;
            // 
            // ViewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.gb_edit);
            this.Controls.Add(this.gb_date);
            this.Name = "ViewExpense";
            this.Text = "ViewExpense";
            this.gb_date.ResumeLayout(false);
            this.gb_date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).EndInit();
            this.gb_edit.ResumeLayout(false);
            this.gb_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_date;
        private System.Windows.Forms.GroupBox gb_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.MonthCalendar cal_date;
        private System.Windows.Forms.ComboBox cb_Accounts;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.DataGridView gv_data;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label4;
    }
}
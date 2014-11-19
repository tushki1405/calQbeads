namespace DailyExpense.SharedExpenses
{
    partial class SETran
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_spender = new System.Windows.Forms.ComboBox();
            this.gb_addTran = new System.Windows.Forms.GroupBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.gb_share = new System.Windows.Forms.GroupBox();
            this.gv_data = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.gb_delete = new System.Windows.Forms.GroupBox();
            this.gv_delete = new System.Windows.Forms.DataGridView();
            this.gb_addTran.SuspendLayout();
            this.gb_share.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).BeginInit();
            this.gb_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paid By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // cb_spender
            // 
            this.cb_spender.FormattingEnabled = true;
            this.cb_spender.Location = new System.Drawing.Point(66, 90);
            this.cb_spender.Name = "cb_spender";
            this.cb_spender.Size = new System.Drawing.Size(166, 21);
            this.cb_spender.TabIndex = 2;
            // 
            // gb_addTran
            // 
            this.gb_addTran.Controls.Add(this.lbl_error);
            this.gb_addTran.Controls.Add(this.gb_share);
            this.gb_addTran.Controls.Add(this.btn_back);
            this.gb_addTran.Controls.Add(this.btn_add);
            this.gb_addTran.Controls.Add(this.dtp_date);
            this.gb_addTran.Controls.Add(this.txt_amount);
            this.gb_addTran.Controls.Add(this.cb_spender);
            this.gb_addTran.Controls.Add(this.txt_name);
            this.gb_addTran.Controls.Add(this.label3);
            this.gb_addTran.Controls.Add(this.label1);
            this.gb_addTran.Controls.Add(this.label4);
            this.gb_addTran.Controls.Add(this.label2);
            this.gb_addTran.Location = new System.Drawing.Point(13, 12);
            this.gb_addTran.Name = "gb_addTran";
            this.gb_addTran.Size = new System.Drawing.Size(529, 214);
            this.gb_addTran.TabIndex = 5;
            this.gb_addTran.TabStop = false;
            this.gb_addTran.Text = "Add New ";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(243, 157);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_error.TabIndex = 12;
            this.lbl_error.Text = "label5";
            // 
            // gb_share
            // 
            this.gb_share.Controls.Add(this.gv_data);
            this.gb_share.Location = new System.Drawing.Point(254, 17);
            this.gb_share.Name = "gb_share";
            this.gb_share.Size = new System.Drawing.Size(270, 130);
            this.gb_share.TabIndex = 11;
            this.gb_share.TabStop = false;
            this.gb_share.Text = "Set Share";
            // 
            // gv_data
            // 
            this.gv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_data.Location = new System.Drawing.Point(6, 20);
            this.gv_data.Name = "gv_data";
            this.gv_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gv_data.Size = new System.Drawing.Size(259, 104);
            this.gv_data.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(260, 176);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(169, 176);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(66, 127);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(166, 20);
            this.dtp_date.TabIndex = 3;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(66, 54);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(78, 20);
            this.txt_amount.TabIndex = 1;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(66, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(166, 20);
            this.txt_name.TabIndex = 0;
            // 
            // gb_delete
            // 
            this.gb_delete.Controls.Add(this.gv_delete);
            this.gb_delete.Location = new System.Drawing.Point(13, 232);
            this.gb_delete.Name = "gb_delete";
            this.gb_delete.Size = new System.Drawing.Size(529, 104);
            this.gb_delete.TabIndex = 6;
            this.gb_delete.TabStop = false;
            this.gb_delete.Text = "Delete Existing records";
            // 
            // gv_delete
            // 
            this.gv_delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_delete.Location = new System.Drawing.Point(10, 19);
            this.gv_delete.Name = "gv_delete";
            this.gv_delete.Size = new System.Drawing.Size(509, 79);
            this.gv_delete.TabIndex = 7;
            // 
            // SETran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.gb_delete);
            this.Controls.Add(this.gb_addTran);
            this.Name = "SETran";
            this.Text = "SETran";
            this.gb_addTran.ResumeLayout(false);
            this.gb_addTran.PerformLayout();
            this.gb_share.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).EndInit();
            this.gb_delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_spender;
        private System.Windows.Forms.GroupBox gb_addTran;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DataGridView gv_data;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox gb_share;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.GroupBox gb_delete;
        private System.Windows.Forms.DataGridView gv_delete;
    }
}
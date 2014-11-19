namespace DailyExpense.Common
{
    partial class Debts
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
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.rb_receive = new System.Windows.Forms.RadioButton();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.rb_pay = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cb_Accounts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.gb_view = new System.Windows.Forms.GroupBox();
            this.rb_payView = new System.Windows.Forms.RadioButton();
            this.gv_display = new System.Windows.Forms.DataGridView();
            this.rb_receiveView = new System.Windows.Forms.RadioButton();
            this.gb_add.SuspendLayout();
            this.gb_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_display)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_add
            // 
            this.gb_add.Controls.Add(this.lbl_error);
            this.gb_add.Controls.Add(this.btn_submit);
            this.gb_add.Controls.Add(this.rb_receive);
            this.gb_add.Controls.Add(this.txt_amount);
            this.gb_add.Controls.Add(this.rb_pay);
            this.gb_add.Controls.Add(this.label4);
            this.gb_add.Controls.Add(this.label1);
            this.gb_add.Controls.Add(this.txt_name);
            this.gb_add.Controls.Add(this.cb_Accounts);
            this.gb_add.Controls.Add(this.label2);
            this.gb_add.Controls.Add(this.lbl_message);
            this.gb_add.Controls.Add(this.txt_note);
            this.gb_add.Location = new System.Drawing.Point(27, 12);
            this.gb_add.Name = "gb_add";
            this.gb_add.Size = new System.Drawing.Size(231, 254);
            this.gb_add.TabIndex = 1;
            this.gb_add.TabStop = false;
            this.gb_add.Text = "Add Debts ";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(89, 205);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_error.TabIndex = 22;
            this.lbl_error.Text = "Error";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(75, 221);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // rb_receive
            // 
            this.rb_receive.AutoSize = true;
            this.rb_receive.Location = new System.Drawing.Point(24, 27);
            this.rb_receive.Name = "rb_receive";
            this.rb_receive.Size = new System.Drawing.Size(65, 17);
            this.rb_receive.TabIndex = 1;
            this.rb_receive.TabStop = true;
            this.rb_receive.Text = "Receive";
            this.rb_receive.UseVisualStyleBackColor = true;
            this.rb_receive.CheckedChanged += new System.EventHandler(this.rb_receive_CheckedChanged);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(80, 85);
            this.txt_amount.MaxLength = 10;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(132, 20);
            this.txt_amount.TabIndex = 4;
            // 
            // rb_pay
            // 
            this.rb_pay.AutoSize = true;
            this.rb_pay.Location = new System.Drawing.Point(95, 27);
            this.rb_pay.Name = "rb_pay";
            this.rb_pay.Size = new System.Drawing.Size(43, 17);
            this.rb_pay.TabIndex = 2;
            this.rb_pay.TabStop = true;
            this.rb_pay.Text = "Pay";
            this.rb_pay.UseVisualStyleBackColor = true;
            this.rb_pay.CheckedChanged += new System.EventHandler(this.rb_pay_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(80, 59);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 20);
            this.txt_name.TabIndex = 3;
            // 
            // cb_Accounts
            // 
            this.cb_Accounts.FormattingEnabled = true;
            this.cb_Accounts.Location = new System.Drawing.Point(29, 179);
            this.cb_Accounts.Name = "cb_Accounts";
            this.cb_Accounts.Size = new System.Drawing.Size(158, 21);
            this.cb_Accounts.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Note";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(21, 150);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(177, 13);
            this.lbl_message.TabIndex = 19;
            this.lbl_message.Text = "Add/ Reduce Amount from Account";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(80, 111);
            this.txt_note.MaxLength = 50;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(132, 20);
            this.txt_note.TabIndex = 5;
            // 
            // gb_view
            // 
            this.gb_view.Controls.Add(this.rb_payView);
            this.gb_view.Controls.Add(this.gv_display);
            this.gb_view.Controls.Add(this.rb_receiveView);
            this.gb_view.Location = new System.Drawing.Point(278, 12);
            this.gb_view.Name = "gb_view";
            this.gb_view.Size = new System.Drawing.Size(265, 296);
            this.gb_view.TabIndex = 2;
            this.gb_view.TabStop = false;
            this.gb_view.Text = "View/ Modify Debts";
            // 
            // rb_payView
            // 
            this.rb_payView.AutoSize = true;
            this.rb_payView.Location = new System.Drawing.Point(139, 22);
            this.rb_payView.Name = "rb_payView";
            this.rb_payView.Size = new System.Drawing.Size(71, 17);
            this.rb_payView.TabIndex = 2;
            this.rb_payView.TabStop = true;
            this.rb_payView.Text = "Payments";
            this.rb_payView.UseVisualStyleBackColor = true;
            this.rb_payView.CheckedChanged += new System.EventHandler(this.rb_payView_CheckedChanged);
            // 
            // gv_display
            // 
            this.gv_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_display.Location = new System.Drawing.Point(13, 45);
            this.gv_display.Name = "gv_display";
            this.gv_display.Size = new System.Drawing.Size(240, 239);
            this.gv_display.TabIndex = 3;
            // 
            // rb_receiveView
            // 
            this.rb_receiveView.AutoSize = true;
            this.rb_receiveView.Location = new System.Drawing.Point(43, 22);
            this.rb_receiveView.Name = "rb_receiveView";
            this.rb_receiveView.Size = new System.Drawing.Size(84, 17);
            this.rb_receiveView.TabIndex = 1;
            this.rb_receiveView.TabStop = true;
            this.rb_receiveView.Text = "Receivables";
            this.rb_receiveView.UseVisualStyleBackColor = true;
            this.rb_receiveView.CheckedChanged += new System.EventHandler(this.rb_receiveView_CheckedChanged);
            // 
            // Debts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 427);
            this.Controls.Add(this.gb_view);
            this.Controls.Add(this.gb_add);
            this.Name = "Debts";
            this.Text = "Debts";
            this.gb_add.ResumeLayout(false);
            this.gb_add.PerformLayout();
            this.gb_view.ResumeLayout(false);
            this.gb_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.GroupBox gb_view;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RadioButton rb_receive;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.RadioButton rb_pay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cb_Accounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.RadioButton rb_payView;
        private System.Windows.Forms.DataGridView gv_display;
        private System.Windows.Forms.RadioButton rb_receiveView;
        private System.Windows.Forms.Label lbl_error;
    }
}
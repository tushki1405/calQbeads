namespace DailyExpense.Common
{
    partial class AddExpense
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
            this.cal_date = new System.Windows.Forms.MonthCalendar();
            this.cb_Accounts = new System.Windows.Forms.ComboBox();
            this.gb_date = new System.Windows.Forms.GroupBox();
            this.lbl_newBalVal = new System.Windows.Forms.Label();
            this.lbl_curBalVal = new System.Windows.Forms.Label();
            this.lbl_newBal = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.lbl_curBal = new System.Windows.Forms.Label();
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gb_date.SuspendLayout();
            this.gb_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // cal_date
            // 
            this.cal_date.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cal_date.Location = new System.Drawing.Point(22, 19);
            this.cal_date.MaxSelectionCount = 1;
            this.cal_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cal_date.Name = "cal_date";
            this.cal_date.TabIndex = 1;
            // 
            // cb_Accounts
            // 
            this.cb_Accounts.FormattingEnabled = true;
            this.cb_Accounts.Location = new System.Drawing.Point(268, 41);
            this.cb_Accounts.Name = "cb_Accounts";
            this.cb_Accounts.Size = new System.Drawing.Size(156, 21);
            this.cb_Accounts.TabIndex = 2;
            this.cb_Accounts.SelectedValueChanged += new System.EventHandler(this.cb_Accounts_SelectedValueChanged);
            // 
            // gb_date
            // 
            this.gb_date.Controls.Add(this.lbl_newBalVal);
            this.gb_date.Controls.Add(this.lbl_curBalVal);
            this.gb_date.Controls.Add(this.lbl_newBal);
            this.gb_date.Controls.Add(this.lbl_account);
            this.gb_date.Controls.Add(this.lbl_curBal);
            this.gb_date.Controls.Add(this.cal_date);
            this.gb_date.Controls.Add(this.cb_Accounts);
            this.gb_date.Location = new System.Drawing.Point(12, 12);
            this.gb_date.Name = "gb_date";
            this.gb_date.Size = new System.Drawing.Size(538, 141);
            this.gb_date.TabIndex = 1;
            this.gb_date.TabStop = false;
            this.gb_date.Text = "Select Date and Account";
            // 
            // lbl_newBalVal
            // 
            this.lbl_newBalVal.AutoSize = true;
            this.lbl_newBalVal.Location = new System.Drawing.Point(356, 102);
            this.lbl_newBalVal.Name = "lbl_newBalVal";
            this.lbl_newBalVal.Size = new System.Drawing.Size(29, 13);
            this.lbl_newBalVal.TabIndex = 6;
            this.lbl_newBalVal.Text = "New";
            // 
            // lbl_curBalVal
            // 
            this.lbl_curBalVal.AutoSize = true;
            this.lbl_curBalVal.Location = new System.Drawing.Point(356, 80);
            this.lbl_curBalVal.Name = "lbl_curBalVal";
            this.lbl_curBalVal.Size = new System.Drawing.Size(41, 13);
            this.lbl_curBalVal.TabIndex = 5;
            this.lbl_curBalVal.Text = "Current";
            // 
            // lbl_newBal
            // 
            this.lbl_newBal.AutoSize = true;
            this.lbl_newBal.Location = new System.Drawing.Point(265, 99);
            this.lbl_newBal.Name = "lbl_newBal";
            this.lbl_newBal.Size = new System.Drawing.Size(80, 13);
            this.lbl_newBal.TabIndex = 4;
            this.lbl_newBal.Text = "New Balance : ";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(265, 23);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(86, 13);
            this.lbl_account.TabIndex = 3;
            this.lbl_account.Text = "Select Account :";
            // 
            // lbl_curBal
            // 
            this.lbl_curBal.AutoSize = true;
            this.lbl_curBal.Location = new System.Drawing.Point(265, 77);
            this.lbl_curBal.Name = "lbl_curBal";
            this.lbl_curBal.Size = new System.Drawing.Size(92, 13);
            this.lbl_curBal.TabIndex = 2;
            this.lbl_curBal.Text = "Current Balance : ";
            // 
            // gb_add
            // 
            this.gb_add.Controls.Add(this.lbl_error);
            this.gb_add.Controls.Add(this.btn_add);
            this.gb_add.Controls.Add(this.textBox10);
            this.gb_add.Controls.Add(this.textBox9);
            this.gb_add.Controls.Add(this.comboBox5);
            this.gb_add.Controls.Add(this.button4);
            this.gb_add.Controls.Add(this.textBox8);
            this.gb_add.Controls.Add(this.textBox7);
            this.gb_add.Controls.Add(this.comboBox4);
            this.gb_add.Controls.Add(this.button3);
            this.gb_add.Controls.Add(this.textBox6);
            this.gb_add.Controls.Add(this.textBox5);
            this.gb_add.Controls.Add(this.comboBox3);
            this.gb_add.Controls.Add(this.button2);
            this.gb_add.Controls.Add(this.textBox4);
            this.gb_add.Controls.Add(this.textBox3);
            this.gb_add.Controls.Add(this.comboBox2);
            this.gb_add.Controls.Add(this.label3);
            this.gb_add.Controls.Add(this.label2);
            this.gb_add.Controls.Add(this.label1);
            this.gb_add.Controls.Add(this.button1);
            this.gb_add.Controls.Add(this.textBox2);
            this.gb_add.Controls.Add(this.textBox1);
            this.gb_add.Controls.Add(this.comboBox1);
            this.gb_add.Location = new System.Drawing.Point(12, 159);
            this.gb_add.Name = "gb_add";
            this.gb_add.Size = new System.Drawing.Size(538, 202);
            this.gb_add.TabIndex = 2;
            this.gb_add.TabStop = false;
            this.gb_add.Text = "Add Expenses";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(321, 172);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_error.TabIndex = 24;
            this.lbl_error.Text = "Error";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(240, 163);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(309, 137);
            this.textBox10.MaxLength = 50;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(159, 20);
            this.textBox10.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(201, 137);
            this.textBox9.MaxLength = 10;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(90, 20);
            this.textBox9.TabIndex = 18;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBox9.Leave += new System.EventHandler(this.textBox9_Leave);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(22, 138);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(162, 21);
            this.comboBox5.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(488, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(309, 111);
            this.textBox8.MaxLength = 50;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 20);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(201, 111);
            this.textBox7.MaxLength = 10;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(90, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.Enter += new System.EventHandler(this.textBox7_Enter);
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(22, 112);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(162, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(309, 85);
            this.textBox6.MaxLength = 50;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(159, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(201, 85);
            this.textBox5.MaxLength = 10;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(90, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(22, 86);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(309, 58);
            this.textBox4.MaxLength = 50;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(201, 58);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 32);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 32);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 427);
            this.Controls.Add(this.gb_add);
            this.Controls.Add(this.gb_date);
            this.Name = "AddExpense";
            this.Text = "AddExpense";
            this.gb_date.ResumeLayout(false);
            this.gb_date.PerformLayout();
            this.gb_add.ResumeLayout(false);
            this.gb_add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cal_date;
        private System.Windows.Forms.ComboBox cb_Accounts;
        private System.Windows.Forms.GroupBox gb_date;
        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.Label lbl_newBalVal;
        private System.Windows.Forms.Label lbl_curBalVal;
        private System.Windows.Forms.Label lbl_newBal;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Label lbl_curBal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_error;
    }
}
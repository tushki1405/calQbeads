namespace DailyExpense.SharedExpenses
{
    partial class SEHome
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_se = new System.Windows.Forms.ListBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.tt_description = new System.Windows.Forms.ToolTip(this.components);
            this.gb_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(85, 189);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(82, 26);
            this.txt_title.MaxLength = 100;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(165, 20);
            this.txt_title.TabIndex = 1;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(82, 54);
            this.txt_description.MaxLength = 200;
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(165, 92);
            this.txt_description.TabIndex = 2;
            // 
            // gb_add
            // 
            this.gb_add.Controls.Add(this.cb_type);
            this.gb_add.Controls.Add(this.label3);
            this.gb_add.Controls.Add(this.txt_description);
            this.gb_add.Controls.Add(this.label1);
            this.gb_add.Controls.Add(this.btn_add);
            this.gb_add.Controls.Add(this.txt_title);
            this.gb_add.Controls.Add(this.label2);
            this.gb_add.Location = new System.Drawing.Point(277, 26);
            this.gb_add.Name = "gb_add";
            this.gb_add.Size = new System.Drawing.Size(263, 226);
            this.gb_add.TabIndex = 6;
            this.gb_add.TabStop = false;
            this.gb_add.Text = "Create Shared Expenses";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(82, 153);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(108, 21);
            this.cb_type.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // lb_se
            // 
            this.lb_se.FormattingEnabled = true;
            this.lb_se.Location = new System.Drawing.Point(21, 26);
            this.lb_se.Name = "lb_se";
            this.lb_se.Size = new System.Drawing.Size(215, 160);
            this.lb_se.TabIndex = 5;
            this.lb_se.DoubleClick += new System.EventHandler(this.lb_se_DoubleClick);
            this.lb_se.MouseHover += new System.EventHandler(this.lb_se_MouseHover);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(21, 200);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(103, 23);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(21, 229);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(103, 23);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Add Participants";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(291, 264);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_error.TabIndex = 9;
            this.lbl_error.Text = "label4";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(133, 229);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(133, 200);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(103, 23);
            this.btn_report.TabIndex = 7;
            this.btn_report.Text = "View Reports";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // SEHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lb_se);
            this.Controls.Add(this.gb_add);
            this.Name = "SEHome";
            this.Text = "SEHome";
            this.gb_add.ResumeLayout(false);
            this.gb_add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.ListBox lb_se;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.ToolTip tt_description;
    }
}
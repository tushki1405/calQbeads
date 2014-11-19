namespace DailyExpense.Shared
{
    partial class UserLanding
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
            this.pnl_password = new System.Windows.Forms.Panel();
            this.str_error = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.lbl_app = new System.Windows.Forms.Label();
            this.lbl_app0 = new System.Windows.Forms.Label();
            this.pnl_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.pnl_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_password
            // 
            this.pnl_password.Controls.Add(this.str_error);
            this.pnl_password.Controls.Add(this.txt_password);
            this.pnl_password.Controls.Add(this.lbl_password);
            this.pnl_password.Location = new System.Drawing.Point(162, 86);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(249, 156);
            this.pnl_password.TabIndex = 0;
            // 
            // str_error
            // 
            this.str_error.AutoSize = true;
            this.str_error.Location = new System.Drawing.Point(86, 86);
            this.str_error.Name = "str_error";
            this.str_error.Size = new System.Drawing.Size(29, 13);
            this.str_error.TabIndex = 2;
            this.str_error.Text = "Error";
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Location = new System.Drawing.Point(44, 54);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(168, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(86, 28);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(84, 13);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Enter Password:";
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(103, 28);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(64, 64);
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // pnl_logo
            // 
            this.pnl_logo.Controls.Add(this.lbl_app0);
            this.pnl_logo.Controls.Add(this.lbl_app);
            this.pnl_logo.Controls.Add(this.pb_logo);
            this.pnl_logo.Location = new System.Drawing.Point(162, 86);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(249, 156);
            this.pnl_logo.TabIndex = 2;
            // 
            // lbl_app
            // 
            this.lbl_app.AutoSize = true;
            this.lbl_app.Location = new System.Drawing.Point(38, 113);
            this.lbl_app.Name = "lbl_app";
            this.lbl_app.Size = new System.Drawing.Size(119, 13);
            this.lbl_app.TabIndex = 2;
            this.lbl_app.Text = "Daily Expense Manager";
            // 
            // lbl_app0
            // 
            this.lbl_app0.AutoSize = true;
            this.lbl_app0.Location = new System.Drawing.Point(72, 86);
            this.lbl_app0.Name = "lbl_app0";
            this.lbl_app0.Size = new System.Drawing.Size(60, 13);
            this.lbl_app0.TabIndex = 3;
            this.lbl_app0.Text = "CalQBeads";
            // 
            // UserLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 366);
            this.Controls.Add(this.pnl_logo);
            this.Controls.Add(this.pnl_password);
            this.Name = "UserLanding";
            this.Text = "UserLanding";
            this.pnl_password.ResumeLayout(false);
            this.pnl_password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label str_error;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Label lbl_app;
        private System.Windows.Forms.Label lbl_app0;



    }
}
namespace DailyExpense.Common
{
    partial class Password
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
            this.pnl_new = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_passAgain = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_existing = new System.Windows.Forms.Panel();
            this.txt_currPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removePass = new System.Windows.Forms.PictureBox();
            this.pnl_new.SuspendLayout();
            this.pnl_existing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removePass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_new
            // 
            this.pnl_new.Controls.Add(this.btn_update);
            this.pnl_new.Controls.Add(this.label3);
            this.pnl_new.Controls.Add(this.txt_passAgain);
            this.pnl_new.Controls.Add(this.lbl_error);
            this.pnl_new.Controls.Add(this.txt_pass);
            this.pnl_new.Controls.Add(this.label1);
            this.pnl_new.Location = new System.Drawing.Point(172, 31);
            this.pnl_new.Name = "pnl_new";
            this.pnl_new.Size = new System.Drawing.Size(200, 165);
            this.pnl_new.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(61, 135);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Again";
            // 
            // txt_passAgain
            // 
            this.txt_passAgain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_passAgain.Location = new System.Drawing.Point(17, 90);
            this.txt_passAgain.MaxLength = 50;
            this.txt_passAgain.Name = "txt_passAgain";
            this.txt_passAgain.Size = new System.Drawing.Size(168, 20);
            this.txt_passAgain.TabIndex = 3;
            this.txt_passAgain.UseSystemPasswordChar = true;
            this.txt_passAgain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(41, 115);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_error.TabIndex = 2;
            this.lbl_error.Text = "Error1";
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Location = new System.Drawing.Point(17, 36);
            this.txt_pass.MaxLength = 50;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(168, 20);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Password";
            // 
            // pnl_existing
            // 
            this.pnl_existing.Controls.Add(this.btn_removePass);
            this.pnl_existing.Controls.Add(this.txt_currPass);
            this.pnl_existing.Controls.Add(this.label2);
            this.pnl_existing.Location = new System.Drawing.Point(172, 221);
            this.pnl_existing.Name = "pnl_existing";
            this.pnl_existing.Size = new System.Drawing.Size(212, 53);
            this.pnl_existing.TabIndex = 1;
            // 
            // txt_currPass
            // 
            this.txt_currPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_currPass.Location = new System.Drawing.Point(17, 24);
            this.txt_currPass.MaxLength = 50;
            this.txt_currPass.Name = "txt_currPass";
            this.txt_currPass.Size = new System.Drawing.Size(168, 20);
            this.txt_currPass.TabIndex = 1;
            this.txt_currPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Current Password";
            // 
            // btn_removePass
            // 
            this.btn_removePass.Location = new System.Drawing.Point(189, 26);
            this.btn_removePass.Name = "btn_removePass";
            this.btn_removePass.Size = new System.Drawing.Size(20, 20);
            this.btn_removePass.TabIndex = 2;
            this.btn_removePass.TabStop = false;
            this.btn_removePass.Click += new System.EventHandler(this.btn_removePass_Click);
            this.btn_removePass.MouseEnter += new System.EventHandler(this.deletebtn_enter);
            this.btn_removePass.MouseLeave += new System.EventHandler(this.deletebtn_leave);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 366);
            this.Controls.Add(this.pnl_existing);
            this.Controls.Add(this.pnl_new);
            this.Name = "Password";
            this.Text = "Password";
            this.pnl_new.ResumeLayout(false);
            this.pnl_new.PerformLayout();
            this.pnl_existing.ResumeLayout(false);
            this.pnl_existing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removePass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_new;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_existing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_currPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_passAgain;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.PictureBox btn_removePass;
    }
}
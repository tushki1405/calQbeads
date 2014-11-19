namespace DailyExpense.Shared
{
    partial class About
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
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_app = new System.Windows.Forms.Label();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.ll_dem = new System.Windows.Forms.LinkLabel();
            this.ll_gt = new System.Windows.Forms.LinkLabel();
            this.lb_email = new System.Windows.Forms.Label();
            this.lbl_newName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.Location = new System.Drawing.Point(99, 44);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(69, 14);
            this.lbl_version.TabIndex = 7;
            this.lbl_version.Text = "Version 2.0";
            // 
            // lbl_app
            // 
            this.lbl_app.AutoSize = true;
            this.lbl_app.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_app.Location = new System.Drawing.Point(67, 26);
            this.lbl_app.Name = "lbl_app";
            this.lbl_app.Size = new System.Drawing.Size(172, 19);
            this.lbl_app.TabIndex = 5;
            this.lbl_app.Text = "Daily Expense Manager";
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_feedback.Location = new System.Drawing.Point(52, 83);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(216, 14);
            this.lbl_feedback.TabIndex = 8;
            this.lbl_feedback.Text = "For Complaints and Feedback contact:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(91, 97);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(102, 17);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Tushar Gupta";
            // 
            // ll_dem
            // 
            this.ll_dem.AutoSize = true;
            this.ll_dem.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_dem.Location = new System.Drawing.Point(56, 66);
            this.ll_dem.Name = "ll_dem";
            this.ll_dem.Size = new System.Drawing.Size(150, 12);
            this.ll_dem.TabIndex = 10;
            this.ll_dem.TabStop = true;
            this.ll_dem.Text = "http://guptatushar.in/calQbeads";
            this.ll_dem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_dem_LinkClicked);
            // 
            // ll_gt
            // 
            this.ll_gt.AutoSize = true;
            this.ll_gt.Font = new System.Drawing.Font("Tahoma", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_gt.Location = new System.Drawing.Point(79, 120);
            this.ll_gt.Name = "ll_gt";
            this.ll_gt.Size = new System.Drawing.Size(71, 8);
            this.ll_gt.TabIndex = 11;
            this.ll_gt.TabStop = true;
            this.ll_gt.Text = "http://guptatushar.in";
            this.ll_gt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_gt_LinkClicked);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(76, 110);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(144, 14);
            this.lb_email.TabIndex = 12;
            this.lb_email.Text = "tushki1405@hotmail.com";
            // 
            // lbl_newName
            // 
            this.lbl_newName.AutoSize = true;
            this.lbl_newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newName.Location = new System.Drawing.Point(83, 7);
            this.lbl_newName.Name = "lbl_newName";
            this.lbl_newName.Size = new System.Drawing.Size(124, 26);
            this.lbl_newName.TabIndex = 14;
            this.lbl_newName.Text = "CalQBeads";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 144);
            this.Controls.Add(this.lbl_newName);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.ll_gt);
            this.Controls.Add(this.ll_dem);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_feedback);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_app);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_app;
        private System.Windows.Forms.Label lbl_feedback;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.LinkLabel ll_dem;
        private System.Windows.Forms.LinkLabel ll_gt;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lbl_newName;

    }
}
namespace DailyExpense.Shared
{
    partial class Splash
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
            this.timer_openApp = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.pb_load = new System.Windows.Forms.ProgressBar();
            this.lbl_created = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.ll_url = new System.Windows.Forms.LinkLabel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_newName = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_message2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_openApp
            // 
            this.timer_openApp.Enabled = true;
            this.timer_openApp.Interval = 300;
            this.timer_openApp.Tick += new System.EventHandler(this.timer_openApp_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.Location = new System.Drawing.Point(69, 46);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(68, 15);
            this.lbl_version.TabIndex = 4;
            this.lbl_version.Text = "Version 2.0";
            // 
            // pb_load
            // 
            this.pb_load.Location = new System.Drawing.Point(42, 181);
            this.pb_load.Name = "pb_load";
            this.pb_load.Size = new System.Drawing.Size(200, 5);
            this.pb_load.TabIndex = 5;
            // 
            // lbl_created
            // 
            this.lbl_created.AutoSize = true;
            this.lbl_created.Location = new System.Drawing.Point(62, 107);
            this.lbl_created.Name = "lbl_created";
            this.lbl_created.Size = new System.Drawing.Size(208, 13);
            this.lbl_created.TabIndex = 6;
            this.lbl_created.Text = "Application Developed and Maintained By:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(110, 120);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(72, 13);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Tushar Gupta";
            // 
            // ll_url
            // 
            this.ll_url.AutoSize = true;
            this.ll_url.Location = new System.Drawing.Point(99, 131);
            this.ll_url.Name = "ll_url";
            this.ll_url.Size = new System.Drawing.Size(105, 13);
            this.ll_url.TabIndex = 8;
            this.ll_url.TabStop = true;
            this.ll_url.Text = "http://guptatushar.in";
            this.ll_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_url_LinkClicked);
            // 
            // pnl_top
            // 
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(290, 3);
            this.pnl_top.TabIndex = 9;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 192);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(290, 3);
            this.pnl_bottom.TabIndex = 10;
            // 
            // pnl_right
            // 
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(287, 3);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(3, 189);
            this.pnl_right.TabIndex = 11;
            // 
            // pnl_left
            // 
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 3);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(3, 189);
            this.pnl_left.TabIndex = 12;
            // 
            // lbl_newName
            // 
            this.lbl_newName.AutoSize = true;
            this.lbl_newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newName.Location = new System.Drawing.Point(67, 22);
            this.lbl_newName.Name = "lbl_newName";
            this.lbl_newName.Size = new System.Drawing.Size(124, 26);
            this.lbl_newName.TabIndex = 13;
            this.lbl_newName.Text = "CalQBeads";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(12, 154);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(299, 13);
            this.lbl_message.TabIndex = 14;
            this.lbl_message.Text = "*CalQBeads Daily Expense Manager application is free to use ";
            // 
            // lbl_message2
            // 
            this.lbl_message2.AutoSize = true;
            this.lbl_message2.Location = new System.Drawing.Point(15, 166);
            this.lbl_message2.Name = "lbl_message2";
            this.lbl_message2.Size = new System.Drawing.Size(73, 13);
            this.lbl_message2.TabIndex = 15;
            this.lbl_message2.Text = "and distribute.";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 195);
            this.Controls.Add(this.lbl_message2);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_newName);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.ll_url);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_created);
            this.Controls.Add(this.pb_load);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_openApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.ProgressBar pb_load;
        private System.Windows.Forms.Label lbl_created;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.LinkLabel ll_url;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_newName;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_message2;
    }
}
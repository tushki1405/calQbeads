namespace DailyExpense.Shared
{
    partial class MainWindow
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
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.closeCurrentFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.debtsLoansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.statusBar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(5, 538);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(840, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "StatusBar";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Menu;
            this.panelHeader.Controls.Add(this.pictureBox4);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.menuBar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(5, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(840, 35);
            this.panelHeader.TabIndex = 4;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_OnClick);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Drag);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(5, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(728, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 28);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_enter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(767, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_enter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(804, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_enter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_leave);
            // 
            // menuBar
            // 
            this.menuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.manageToolStripMenuItem,
            this.expenseStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(35, 5);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(212, 24);
            this.menuBar.TabIndex = 11;
            this.menuBar.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.toolStripSeparator6,
            this.closeCurrentFileToolStripMenuItem1,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem2.Text = "&File";
            this.toolStripMenuItem2.DropDownClosed += new System.EventHandler(this.item_leave);
            this.toolStripMenuItem2.DropDownOpened += new System.EventHandler(this.item_enter);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(164, 6);
            // 
            // closeCurrentFileToolStripMenuItem1
            // 
            this.closeCurrentFileToolStripMenuItem1.Name = "closeCurrentFileToolStripMenuItem1";
            this.closeCurrentFileToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.closeCurrentFileToolStripMenuItem1.Text = "Close Current File";
            this.closeCurrentFileToolStripMenuItem1.Click += new System.EventHandler(this.closeCurrentFileToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItem3});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "&Manage";
            this.manageToolStripMenuItem.DropDownClosed += new System.EventHandler(this.item_leave);
            this.manageToolStripMenuItem.DropDownOpened += new System.EventHandler(this.item_enter);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.accountsToolStripMenuItem.Text = "Accounts";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem3.Text = "Password";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // expenseStripMenuItem
            // 
            this.expenseStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpenseToolStripMenuItem,
            this.viewEditExpenseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.debtsLoansToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem5});
            this.expenseStripMenuItem.Name = "expenseStripMenuItem";
            this.expenseStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.expenseStripMenuItem.Text = "&Expense";
            this.expenseStripMenuItem.DropDownClosed += new System.EventHandler(this.item_leave);
            this.expenseStripMenuItem.DropDownOpened += new System.EventHandler(this.item_enter);
            // 
            // addExpenseToolStripMenuItem
            // 
            this.addExpenseToolStripMenuItem.Name = "addExpenseToolStripMenuItem";
            this.addExpenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addExpenseToolStripMenuItem.Text = "Add Expense";
            this.addExpenseToolStripMenuItem.Click += new System.EventHandler(this.addExpenseToolStripMenuItem_Click);
            // 
            // viewEditExpenseToolStripMenuItem
            // 
            this.viewEditExpenseToolStripMenuItem.Name = "viewEditExpenseToolStripMenuItem";
            this.viewEditExpenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewEditExpenseToolStripMenuItem.Text = "View/Edit Expense";
            this.viewEditExpenseToolStripMenuItem.Click += new System.EventHandler(this.viewEditExpenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem1.Text = "View Between Range";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // debtsLoansToolStripMenuItem
            // 
            this.debtsLoansToolStripMenuItem.Name = "debtsLoansToolStripMenuItem";
            this.debtsLoansToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.debtsLoansToolStripMenuItem.Text = "Debts";
            this.debtsLoansToolStripMenuItem.Click += new System.EventHandler(this.debtsLoansToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem5.Text = "Shared Expenses";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.DropDownClosed += new System.EventHandler(this.item_leave);
            this.helpToolStripMenuItem.DropDownOpened += new System.EventHandler(this.item_enter);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(5, 562);
            this.panelLeft.TabIndex = 5;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(845, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(5, 562);
            this.panelRight.TabIndex = 6;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(5, 560);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(840, 2);
            this.panelBottom.TabIndex = 7;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(5, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(840, 2);
            this.panelTop.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 562);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewEditExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem debtsLoansToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

    }
}
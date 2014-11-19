namespace DailyExpense.Common
{
    partial class Category
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
            this.gb_newCategory = new System.Windows.Forms.GroupBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_newAccount = new System.Windows.Forms.Label();
            this.btn_newCategory = new System.Windows.Forms.Button();
            this.txt_newCategory = new System.Windows.Forms.TextBox();
            this.gb_existingCategories = new System.Windows.Forms.GroupBox();
            this.lbl_error2 = new System.Windows.Forms.Label();
            this.btn_editName = new System.Windows.Forms.Button();
            this.txt_editName = new System.Windows.Forms.TextBox();
            this.btn_deleteCategory = new System.Windows.Forms.PictureBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.gb_newCategory.SuspendLayout();
            this.gb_existingCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_newCategory
            // 
            this.gb_newCategory.Controls.Add(this.lbl_error);
            this.gb_newCategory.Controls.Add(this.lbl_newAccount);
            this.gb_newCategory.Controls.Add(this.btn_newCategory);
            this.gb_newCategory.Controls.Add(this.txt_newCategory);
            this.gb_newCategory.Location = new System.Drawing.Point(22, 12);
            this.gb_newCategory.Name = "gb_newCategory";
            this.gb_newCategory.Size = new System.Drawing.Size(516, 65);
            this.gb_newCategory.TabIndex = 1;
            this.gb_newCategory.TabStop = false;
            this.gb_newCategory.Text = "New Category";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(191, 46);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_error.TabIndex = 3;
            this.lbl_error.Text = "Error";
            // 
            // lbl_newAccount
            // 
            this.lbl_newAccount.AutoSize = true;
            this.lbl_newAccount.Location = new System.Drawing.Point(26, 26);
            this.lbl_newAccount.Name = "lbl_newAccount";
            this.lbl_newAccount.Size = new System.Drawing.Size(160, 13);
            this.lbl_newAccount.TabIndex = 0;
            this.lbl_newAccount.Text = "Enter a Name for New Category:";
            // 
            // btn_newCategory
            // 
            this.btn_newCategory.Location = new System.Drawing.Point(406, 22);
            this.btn_newCategory.Name = "btn_newCategory";
            this.btn_newCategory.Size = new System.Drawing.Size(83, 23);
            this.btn_newCategory.TabIndex = 2;
            this.btn_newCategory.Text = "Add Category";
            this.btn_newCategory.UseVisualStyleBackColor = true;
            this.btn_newCategory.Click += new System.EventHandler(this.btn_newCategory_Click);
            // 
            // txt_newCategory
            // 
            this.txt_newCategory.Location = new System.Drawing.Point(190, 24);
            this.txt_newCategory.MaxLength = 50;
            this.txt_newCategory.Name = "txt_newCategory";
            this.txt_newCategory.Size = new System.Drawing.Size(204, 20);
            this.txt_newCategory.TabIndex = 1;
            this.txt_newCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_newCategory_KeyDown);
            // 
            // gb_existingCategories
            // 
            this.gb_existingCategories.Controls.Add(this.lbl_error2);
            this.gb_existingCategories.Controls.Add(this.btn_editName);
            this.gb_existingCategories.Controls.Add(this.txt_editName);
            this.gb_existingCategories.Controls.Add(this.btn_deleteCategory);
            this.gb_existingCategories.Controls.Add(this.cb_category);
            this.gb_existingCategories.Location = new System.Drawing.Point(22, 83);
            this.gb_existingCategories.Name = "gb_existingCategories";
            this.gb_existingCategories.Size = new System.Drawing.Size(516, 270);
            this.gb_existingCategories.TabIndex = 2;
            this.gb_existingCategories.TabStop = false;
            this.gb_existingCategories.Text = "Existing Categories";
            // 
            // lbl_error2
            // 
            this.lbl_error2.AutoSize = true;
            this.lbl_error2.Location = new System.Drawing.Point(217, 154);
            this.lbl_error2.Name = "lbl_error2";
            this.lbl_error2.Size = new System.Drawing.Size(29, 13);
            this.lbl_error2.TabIndex = 4;
            this.lbl_error2.Text = "Error";
            // 
            // btn_editName
            // 
            this.btn_editName.Location = new System.Drawing.Point(215, 127);
            this.btn_editName.Name = "btn_editName";
            this.btn_editName.Size = new System.Drawing.Size(85, 23);
            this.btn_editName.TabIndex = 5;
            this.btn_editName.Text = "Change Name";
            this.btn_editName.UseVisualStyleBackColor = true;
            this.btn_editName.Click += new System.EventHandler(this.btn_editName_Click);
            // 
            // txt_editName
            // 
            this.txt_editName.Location = new System.Drawing.Point(175, 100);
            this.txt_editName.MaxLength = 50;
            this.txt_editName.Name = "txt_editName";
            this.txt_editName.Size = new System.Drawing.Size(160, 20);
            this.txt_editName.TabIndex = 4;
            this.txt_editName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_editName_KeyDown);
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.Location = new System.Drawing.Point(352, 67);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(20, 20);
            this.btn_deleteCategory.TabIndex = 1;
            this.btn_deleteCategory.TabStop = false;
            this.btn_deleteCategory.Click += new System.EventHandler(this.btn_deleteCategory_Click);
            this.btn_deleteCategory.MouseEnter += new System.EventHandler(this.deletebtn_enter);
            this.btn_deleteCategory.MouseLeave += new System.EventHandler(this.deletebtn_leave);
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(160, 66);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(187, 21);
            this.cb_category.TabIndex = 3;
            this.cb_category.SelectedValueChanged += new System.EventHandler(this.cb_category_SelectedValueChanged);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 427);
            this.Controls.Add(this.gb_existingCategories);
            this.Controls.Add(this.gb_newCategory);
            this.Name = "Category";
            this.Text = "Category";
            this.gb_newCategory.ResumeLayout(false);
            this.gb_newCategory.PerformLayout();
            this.gb_existingCategories.ResumeLayout(false);
            this.gb_existingCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_newCategory;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_newAccount;
        private System.Windows.Forms.Button btn_newCategory;
        private System.Windows.Forms.TextBox txt_newCategory;
        private System.Windows.Forms.GroupBox gb_existingCategories;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.PictureBox btn_deleteCategory;
        private System.Windows.Forms.Label lbl_error2;
        private System.Windows.Forms.Button btn_editName;
        private System.Windows.Forms.TextBox txt_editName;
    }
}
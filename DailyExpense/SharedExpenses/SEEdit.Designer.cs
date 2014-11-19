namespace DailyExpense.SharedExpenses
{
    partial class SEEdit
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
            this.gb_participant = new System.Windows.Forms.GroupBox();
            this.lbl_note = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.ListBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.gb_participant.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_participant
            // 
            this.gb_participant.Controls.Add(this.lbl_note);
            this.gb_participant.Controls.Add(this.btn_add);
            this.gb_participant.Controls.Add(this.txt_name);
            this.gb_participant.Controls.Add(this.label1);
            this.gb_participant.Location = new System.Drawing.Point(21, 26);
            this.gb_participant.Name = "gb_participant";
            this.gb_participant.Size = new System.Drawing.Size(254, 123);
            this.gb_participant.TabIndex = 0;
            this.gb_participant.TabStop = false;
            this.gb_participant.Text = "Add Participants";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(13, 109);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(30, 13);
            this.lbl_note.TabIndex = 3;
            this.lbl_note.Text = "Note";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(88, 65);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(57, 27);
            this.txt_name.MaxLength = 100;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(183, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(240, 234);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_error.TabIndex = 3;
            this.lbl_error.Text = "label2";
            // 
            // lb_name
            // 
            this.lb_name.FormattingEnabled = true;
            this.lb_name.Location = new System.Drawing.Point(310, 28);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(188, 121);
            this.lb_name.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(227, 176);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SEEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.gb_participant);
            this.Name = "SEEdit";
            this.Text = "SEEdit";
            this.gb_participant.ResumeLayout(false);
            this.gb_participant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_participant;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.ListBox lb_name;
        private System.Windows.Forms.Button btn_back;

    }
}
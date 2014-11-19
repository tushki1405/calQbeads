namespace DailyExpense.SharedExpenses
{
    partial class SEReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.gv_final = new System.Windows.Forms.DataGridView();
            this.chart_expense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_overall = new System.Windows.Forms.Label();
            this.lbl_breakup = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_expense)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_final
            // 
            this.gv_final.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_final.Location = new System.Drawing.Point(12, 253);
            this.gv_final.Name = "gv_final";
            this.gv_final.Size = new System.Drawing.Size(538, 81);
            this.gv_final.TabIndex = 2;
            // 
            // chart_expense
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_expense.ChartAreas.Add(chartArea1);
            this.chart_expense.Location = new System.Drawing.Point(12, 36);
            this.chart_expense.Name = "chart_expense";
            this.chart_expense.Size = new System.Drawing.Size(538, 187);
            this.chart_expense.TabIndex = 1;
            this.chart_expense.Text = "Graph";
            // 
            // lbl_overall
            // 
            this.lbl_overall.AutoSize = true;
            this.lbl_overall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overall.Location = new System.Drawing.Point(12, 9);
            this.lbl_overall.Name = "lbl_overall";
            this.lbl_overall.Size = new System.Drawing.Size(358, 24);
            this.lbl_overall.TabIndex = 5;
            this.lbl_overall.Text = "Caculation of Expenses (Participant Wise)";
            // 
            // lbl_breakup
            // 
            this.lbl_breakup.AutoSize = true;
            this.lbl_breakup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_breakup.Location = new System.Drawing.Point(13, 226);
            this.lbl_breakup.Name = "lbl_breakup";
            this.lbl_breakup.Size = new System.Drawing.Size(229, 24);
            this.lbl_breakup.TabIndex = 6;
            this.lbl_breakup.Text = "Recommended Payments";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.Location = new System.Drawing.Point(268, 234);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(268, 20);
            this.lbl_error.TabIndex = 7;
            this.lbl_error.Text = "Please add some expenses first.";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(236, 337);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SEReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_breakup);
            this.Controls.Add(this.lbl_overall);
            this.Controls.Add(this.chart_expense);
            this.Controls.Add(this.gv_final);
            this.Name = "SEReport";
            this.Text = "SEReport";
            ((System.ComponentModel.ISupportInitialize)(this.gv_final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_expense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_final;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_expense;
        private System.Windows.Forms.Label lbl_overall;
        private System.Windows.Forms.Label lbl_breakup;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_back;
    }
}
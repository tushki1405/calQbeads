namespace DailyExpense.Common
{
    partial class ViewExpensesCombined
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
            this.gb_dates = new System.Windows.Forms.GroupBox();
            this.btn_date = new System.Windows.Forms.Button();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.lbl_error = new System.Windows.Forms.Label();
            this.gb_data = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_showValues = new System.Windows.Forms.CheckBox();
            this.gv_data = new System.Windows.Forms.DataGridView();
            this.chart_expense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_dates.SuspendLayout();
            this.gb_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_expense)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_dates
            // 
            this.gb_dates.Controls.Add(this.btn_date);
            this.gb_dates.Controls.Add(this.dt_end);
            this.gb_dates.Controls.Add(this.dt_start);
            this.gb_dates.Location = new System.Drawing.Point(12, 12);
            this.gb_dates.Name = "gb_dates";
            this.gb_dates.Size = new System.Drawing.Size(538, 43);
            this.gb_dates.TabIndex = 0;
            this.gb_dates.TabStop = false;
            this.gb_dates.Text = "Select Date Range";
            // 
            // btn_date
            // 
            this.btn_date.Location = new System.Drawing.Point(450, 12);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(75, 23);
            this.btn_date.TabIndex = 2;
            this.btn_date.Text = "Get Data";
            this.btn_date.UseVisualStyleBackColor = true;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(240, 15);
            this.dt_end.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(200, 20);
            this.dt_end.TabIndex = 1;
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(16, 15);
            this.dt_start.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(200, 20);
            this.dt_start.TabIndex = 0;
            this.dt_start.ValueChanged += new System.EventHandler(this.dt_start_ValueChanged);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(137, 268);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_error.TabIndex = 1;
            this.lbl_error.Text = "Error";
            // 
            // gb_data
            // 
            this.gb_data.Controls.Add(this.lbl_total);
            this.gb_data.Controls.Add(this.label4);
            this.gb_data.Controls.Add(this.lbl_error);
            this.gb_data.Controls.Add(this.cb_showValues);
            this.gb_data.Controls.Add(this.gv_data);
            this.gb_data.Controls.Add(this.chart_expense);
            this.gb_data.Location = new System.Drawing.Point(12, 61);
            this.gb_data.Name = "gb_data";
            this.gb_data.Size = new System.Drawing.Size(538, 285);
            this.gb_data.TabIndex = 1;
            this.gb_data.TabStop = false;
            this.gb_data.Text = "Expenses for the selected dates";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(300, 268);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Expenses: ";
            // 
            // cb_showValues
            // 
            this.cb_showValues.AutoSize = true;
            this.cb_showValues.Location = new System.Drawing.Point(120, 238);
            this.cb_showValues.Name = "cb_showValues";
            this.cb_showValues.Size = new System.Drawing.Size(88, 17);
            this.cb_showValues.TabIndex = 7;
            this.cb_showValues.Text = "Show Values";
            this.cb_showValues.UseVisualStyleBackColor = true;
            this.cb_showValues.CheckedChanged += new System.EventHandler(this.cb_showValues_CheckedChanged);
            // 
            // gv_data
            // 
            this.gv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_data.Location = new System.Drawing.Point(219, 28);
            this.gv_data.Name = "gv_data";
            this.gv_data.Size = new System.Drawing.Size(311, 237);
            this.gv_data.TabIndex = 6;
            // 
            // chart_expense
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_expense.ChartAreas.Add(chartArea1);
            this.chart_expense.Location = new System.Drawing.Point(8, 28);
            this.chart_expense.Name = "chart_expense";
            this.chart_expense.Size = new System.Drawing.Size(200, 237);
            this.chart_expense.TabIndex = 1;
            this.chart_expense.Text = "Graph";
            // 
            // ViewExpensesCombined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.gb_data);
            this.Controls.Add(this.gb_dates);
            this.Name = "ViewExpensesCombined";
            this.Text = "ViewExpensesCombined";
            this.gb_dates.ResumeLayout(false);
            this.gb_data.ResumeLayout(false);
            this.gb_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_expense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_dates;
        private System.Windows.Forms.Button btn_date;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.GroupBox gb_data;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_expense;
        private System.Windows.Forms.DataGridView gv_data;
        private System.Windows.Forms.CheckBox cb_showValues;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label4;
    }
}
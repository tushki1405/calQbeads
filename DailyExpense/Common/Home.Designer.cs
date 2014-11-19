namespace DailyExpense.Common
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart_expense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_graph = new System.Windows.Forms.ComboBox();
            this.pnl_chart = new System.Windows.Forms.Panel();
            this.lbl_chartMessage = new System.Windows.Forms.Label();
            this.cb_showValues = new System.Windows.Forms.CheckBox();
            this.gv_accounts = new System.Windows.Forms.DataGridView();
            this.cb_grid = new System.Windows.Forms.ComboBox();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.lbl_gridMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_expense)).BeginInit();
            this.pnl_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_accounts)).BeginInit();
            this.pnl_grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_expense
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_expense.ChartAreas.Add(chartArea3);
            this.chart_expense.Location = new System.Drawing.Point(0, 0);
            this.chart_expense.Name = "chart_expense";
            this.chart_expense.Size = new System.Drawing.Size(200, 220);
            this.chart_expense.TabIndex = 0;
            this.chart_expense.Text = "Graph";
            // 
            // cb_graph
            // 
            this.cb_graph.FormattingEnabled = true;
            this.cb_graph.Location = new System.Drawing.Point(12, 13);
            this.cb_graph.Name = "cb_graph";
            this.cb_graph.Size = new System.Drawing.Size(202, 21);
            this.cb_graph.TabIndex = 1;
            this.cb_graph.SelectedIndexChanged += new System.EventHandler(this.cb_graph_SelectedIndexChanged);
            // 
            // pnl_chart
            // 
            this.pnl_chart.Controls.Add(this.lbl_chartMessage);
            this.pnl_chart.Controls.Add(this.cb_showValues);
            this.pnl_chart.Controls.Add(this.chart_expense);
            this.pnl_chart.Location = new System.Drawing.Point(12, 40);
            this.pnl_chart.Name = "pnl_chart";
            this.pnl_chart.Size = new System.Drawing.Size(200, 236);
            this.pnl_chart.TabIndex = 4;
            // 
            // lbl_chartMessage
            // 
            this.lbl_chartMessage.AutoSize = true;
            this.lbl_chartMessage.Location = new System.Drawing.Point(15, 223);
            this.lbl_chartMessage.Name = "lbl_chartMessage";
            this.lbl_chartMessage.Size = new System.Drawing.Size(57, 13);
            this.lbl_chartMessage.TabIndex = 2;
            this.lbl_chartMessage.Text = "chartLabel";
            // 
            // cb_showValues
            // 
            this.cb_showValues.AutoSize = true;
            this.cb_showValues.Location = new System.Drawing.Point(116, 218);
            this.cb_showValues.Name = "cb_showValues";
            this.cb_showValues.Size = new System.Drawing.Size(88, 17);
            this.cb_showValues.TabIndex = 1;
            this.cb_showValues.Text = "Show Values";
            this.cb_showValues.UseVisualStyleBackColor = true;
            this.cb_showValues.CheckedChanged += new System.EventHandler(this.cb_showValues_CheckedChanged);
            // 
            // gv_accounts
            // 
            this.gv_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_accounts.Location = new System.Drawing.Point(-1, -1);
            this.gv_accounts.Name = "gv_accounts";
            this.gv_accounts.Size = new System.Drawing.Size(311, 237);
            this.gv_accounts.TabIndex = 5;
            // 
            // cb_grid
            // 
            this.cb_grid.FormattingEnabled = true;
            this.cb_grid.Location = new System.Drawing.Point(232, 12);
            this.cb_grid.Name = "cb_grid";
            this.cb_grid.Size = new System.Drawing.Size(202, 21);
            this.cb_grid.TabIndex = 6;
            this.cb_grid.SelectedIndexChanged += new System.EventHandler(this.cb_grid_SelectedIndexChanged);
            // 
            // pnl_grid
            // 
            this.pnl_grid.Controls.Add(this.lbl_gridMessage);
            this.pnl_grid.Controls.Add(this.gv_accounts);
            this.pnl_grid.Location = new System.Drawing.Point(232, 40);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(312, 236);
            this.pnl_grid.TabIndex = 7;
            // 
            // lbl_gridMessage
            // 
            this.lbl_gridMessage.AutoSize = true;
            this.lbl_gridMessage.Location = new System.Drawing.Point(32, 222);
            this.lbl_gridMessage.Name = "lbl_gridMessage";
            this.lbl_gridMessage.Size = new System.Drawing.Size(67, 13);
            this.lbl_gridMessage.TabIndex = 6;
            this.lbl_gridMessage.Text = "gridMessage";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 427);
            this.Controls.Add(this.cb_grid);
            this.Controls.Add(this.pnl_chart);
            this.Controls.Add(this.cb_graph);
            this.Controls.Add(this.pnl_grid);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_Close);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_expense)).EndInit();
            this.pnl_chart.ResumeLayout(false);
            this.pnl_chart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_accounts)).EndInit();
            this.pnl_grid.ResumeLayout(false);
            this.pnl_grid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_expense;
        private System.Windows.Forms.ComboBox cb_graph;
        private System.Windows.Forms.Panel pnl_chart;
        private System.Windows.Forms.CheckBox cb_showValues;
        private System.Windows.Forms.Label lbl_chartMessage;
        private System.Windows.Forms.DataGridView gv_accounts;
        private System.Windows.Forms.ComboBox cb_grid;
        private System.Windows.Forms.Panel pnl_grid;
        private System.Windows.Forms.Label lbl_gridMessage;

    }
}
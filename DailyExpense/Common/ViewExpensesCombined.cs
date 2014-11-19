using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DailyExpense.Common
{
    public partial class ViewExpensesCombined : Form
    {
        Model.HomeEntity home = new Model.HomeEntity();
        Controller.Database database = new Controller.Database();
        DataTable chartData;
        DataTable expenseData;

        public ViewExpensesCombined()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_error);
            setUI();
        }

        private void setUI()
        {
            //Location for date selector
            gb_dates.Location = new Point(18,210);

            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.ViewExpenseCombined);

            chart_expense.BackColor = Controller.UISettingsValues.backgroundColor;
            chart_expense.Legends.Add("Legend");
            chart_expense.Legends["Legend"].BackColor = Controller.UISettingsValues.backgroundColor;
            chart_expense.ChartAreas["ChartArea1"].AxisX.Enabled = AxisEnabled.False;

            gb_data.Visible = false;
            lbl_error.Visible = true;
        }

        private void SetVisibility(bool show)
        {
            cb_showValues.Visible = show;
            chart_expense.Visible = show;
            gv_data.Visible = show;
            lbl_total.Visible = show;
            label4.Visible = show;
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "NoData":
                    lbl_error.Text = "No Data for the Selected Date Range.";
                    lbl_error.Location = new Point(280, 180);
                    break;

                default:
                    lbl_error.Text = "";
                    break;
            }
        }

        private void btn_date_Click(object sender, EventArgs e)
        {
            //Do the animation for only one time
            for (int i = gb_dates.Location.Y; i >= 18; i--)
            {
                gb_dates.Location = new Point(18, i);
                System.Threading.Thread.Sleep(Controller.UISettingsValues.delay);
            }
            gb_data.Visible = true;

            home.StartDate = dt_start.Value;
            home.EndDate = dt_end.Value;
            chartData = database.CategoryWiseBetweenDates(home);
            expenseData = database.GetExpensesBetweenDates(home);

            //Clear chart points
            Series[] newSeries = new Series[chart_expense.Series.Count];
            chart_expense.Series.CopyTo(newSeries, 0);
            foreach (Series s in newSeries)
            {
                chart_expense.Series.Remove(s);
            }

            //Add chart points
            foreach (DataRow dr in chartData.Rows)
            {
                chart_expense.Series.Add(dr["Category"].ToString());
                chart_expense.Series[dr["Category"].ToString()].IsValueShownAsLabel = false;
            }

            int max = 0;

            //Get the max value
            foreach (DataRow dr in chartData.Rows)
            {
                if(Convert.ToInt32(dr["Amount"]) > max)
                    max = Convert.ToInt32(dr["Amount"]);
            }

            if (max > 0)
            {
                SetVisibility(true);
                ErrorMsgs("");

                //Calculate the scale
                int scale = Convert.ToInt32((Math.Ceiling(Convert.ToDouble(max / 100)) + 1) * 100);
                chart_expense.ChartAreas["ChartArea1"].AxisY.Maximum = scale;

                //Update with final points
                foreach (DataRow dr in chartData.Rows)
                {
                    chart_expense.Series[dr["Category"].ToString()].Points.Clear();
                    chart_expense.Series[dr["Category"].ToString()].Points.Add(Convert.ToInt32(dr["Amount"]));
                }

                gv_data.DataSource = expenseData;
                gv_data.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv_data.Columns["DateSpent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                int width = gv_data.Width;
                if (gv_data.Rows.Count > 14)
                    width -= 20;

                int colWidth = width / gv_data.Columns.Count;
                foreach(DataGridViewColumn col in gv_data.Columns)
                {
                    col.Width = colWidth;
                }

                object sum = expenseData.Compute("SUM(Amount)", "");

                if (string.IsNullOrEmpty(sum.ToString()))
                    lbl_total.Text = "0";
                else
                    lbl_total.Text = sum.ToString();
            }
            else
            {
                SetVisibility(false);
                ErrorMsgs("NoData");
            }
        }

        private void dt_start_ValueChanged(object sender, EventArgs e)
        {
            dt_end.MinDate = dt_start.Value;
        }

        private void cb_showValues_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in chartData.Rows)
            {
                chart_expense.Series[dr["Category"].ToString()].IsValueShownAsLabel = cb_showValues.Checked;
            }
        }
    }
}
